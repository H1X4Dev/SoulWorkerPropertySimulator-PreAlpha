using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IArmorComputeService : IComputeService
    {
        IEnumerable<Armor> Get();
        Armor?             Get(ArmorField    field);
        void               Change(Armor?     item);
        void               Change(ArmorField field, int                         step);
        void               Change(ArmorField field, Tag?                        tag);
        void               Change(ArmorField field, IReadOnlyCollection<Plugin> plugins);
        void               Clear(ArmorField  field);
    }

    internal class ArmorComputeService : ComputeServiceBase, IArmorComputeService
    {
        private readonly IDictionary<ArmorField, Armor?> _armors;
        private readonly IDataProvideService             _provider;
        private readonly IList<ArmorSetEffect>           _sets;

        public ArmorComputeService(IDataProvideService provider)
        {
            _provider = provider;
            _armors   = new Dictionary<ArmorField, Armor?>();
            _sets     = new List<ArmorSetEffect>();
        }

        public IEnumerable<Armor> Get()
        {
            try { return _armors.Select(x => x.Value).Where(x => x != null)!; }
            catch (KeyNotFoundException) { return Array.Empty<Armor>(); }
        }

        public Armor? Get(ArmorField field)
        {
            try { return _armors[field]; }
            catch (KeyNotFoundException) { return null; }
        }

        public void Change(Armor? item)
        {
            if (item == null) { throw new InvalidOperationException(); }

            Armor? before;
            try { before = _armors[item.Field]; }
            catch (KeyNotFoundException) { before = null; }

            _armors[item.Field] = item;

            var (setBefore, setAfter) = ProcessSetAffect();
            NotifyChange(ComputeAffect(
                (before?.Effects ?? Array.Empty<Effect>()).Concat(setBefore.SelectMany(x => x.Effects)),
                item.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
        }

        public void Change(ArmorField field, int step)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { throw new InvalidOperationException(); }

            var before = _armors[field]!;
            var after  = _armors[field]! with {Step = step};
            _armors[field] = after;

            var (setBefore, setAfter) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                after.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
        }

        public void Change(ArmorField field, Tag? tag)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { throw new InvalidOperationException(); }

            var before = _armors[field]!;
            var after  = _armors[field]! with {Tag = tag};
            _armors[field] = after;

            var (setBefore, setAfter) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                after.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
        }

        public void Change(ArmorField field, IReadOnlyCollection<Plugin> plugins)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { throw new InvalidOperationException(); }

            var before = _armors[field]!;

            if (plugins.Count > before.PluginLimit) { throw new InvalidOperationException(); }

            var after = _armors[field]! with {Plugins = plugins};
            _armors[field] = after;

            var (setBefore, setAfter) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                after.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
        }

        public void Clear(ArmorField field)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { return; }

            var before = _armors[field]!;
            _armors[field] = null;

            var (setBefore, setAfter) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                setAfter.SelectMany(x => x.Effects)));
        }

        private (ICollection<ArmorSetEffect> Before, ICollection<ArmorSetEffect> After) ProcessSetAffect()
        {
            var (setBefore, setAfter) = ComputeSetAffect();

            _sets.Clear();
            foreach (var x in setAfter) { _sets.Add(x); }

            return (setBefore, setAfter);
        }

        private (ICollection<ArmorSetEffect> Before, ICollection<ArmorSetEffect> After) ComputeSetAffect()
        {
            var before = _sets.ToList();
            var sets   = _provider.GetArmorSetEffects();
            var data   = _armors.Where(x => x.Value != null).GroupBy(x => x.Value!.SetName);

            ICollection<ArmorSetEffect> after = (from grouping in data
                                                 let effect = sets.FirstOrDefault(x => x.Name.Equals(grouping.Key))
                                                 where effect != null
                                                 select effect with {Step = grouping.Count()}).ToList()!;

            return (before, after);
        }
    }
}