using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Models.Plugins;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IArmorComputeService : IComputeService<EquipmentSetEffect>
    {
        IEnumerable<Equipment> Get();
        Equipment?             Get(ArmorField    field);
        void                   Change(Equipment? item);
        void                   Change(ArmorField field, int                         step);
        void                   Change(ArmorField field, Tag?                        tag);
        void                   Change(ArmorField field, IReadOnlyCollection<Plugin> plugins);
        void                   Clear(ArmorField  field);
    }

    internal class ArmorComputeService : ComputeServiceBase<EquipmentSetEffect>, IArmorComputeService
    {
        private readonly IDictionary<ArmorField, Equipment?> _armors;
        private readonly IDataProvideService                 _data;

        public ArmorComputeService(IDataProvideService data)
        {
            _data   = data;
            _armors = new Dictionary<ArmorField, Equipment?>();
        }

        public IEnumerable<Equipment> Get()
        {
            try { return _armors.Select(x => x.Value).Where(x => x != null)!; }
            catch (KeyNotFoundException) { return Array.Empty<Equipment>(); }
        }

        public Equipment? Get(ArmorField field)
        {
            try { return _armors[field]; }
            catch (KeyNotFoundException) { return null; }
        }

        public void Change(Equipment? item)
        {
            if (item == null) { throw new InvalidOperationException(); }

            Equipment? before;
            try { before = _armors[item.Field]; }
            catch (KeyNotFoundException) { before = null; }

            _armors[item.Field] = item;

            var (setBefore, setAfter, changed) = ProcessSetAffect();
            NotifyChange(ComputeAffect(
                (before?.Effects ?? Array.Empty<Effect>()).Concat(setBefore.SelectMany(x => x.Effects)),
                item.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
            if (changed) { NotifySetChange(); }
        }

        public void Change(ArmorField field, int step)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { throw new InvalidOperationException(); }

            var before = _armors[field]!;
            var after  = _armors[field]! with {Step = step};
            _armors[field] = after;

            var (setBefore, setAfter, changed) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                after.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
            if (changed) { NotifySetChange(); }
        }

        public void Change(ArmorField field, Tag? tag)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { throw new InvalidOperationException(); }

            var before = _armors[field]!;
            var after  = _armors[field]! with {Tag = tag};
            _armors[field] = after;

            var (setBefore, setAfter, changed) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                after.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
            if (changed) { NotifySetChange(); }
        }

        public void Change(ArmorField field, IReadOnlyCollection<Plugin> plugins)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { throw new InvalidOperationException(); }

            var before = _armors[field]!;

            if (plugins.Count > before.PluginLimit) { throw new InvalidOperationException(); }

            var after = _armors[field]! with {Plugins = plugins};
            _armors[field] = after;

            var (setBefore, setAfter, changed) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                after.Effects.Concat(setAfter.SelectMany(x => x.Effects))));
            if (changed) { NotifySetChange(); }
        }

        public void Clear(ArmorField field)
        {
            if (!_armors.ContainsKey(field) || _armors[field] == null) { return; }

            var before = _armors[field]!;
            _armors[field] = null;

            var (setBefore, setAfter, changed) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.Effects.Concat(setBefore.SelectMany(x => x.Effects)),
                setAfter.SelectMany(x => x.Effects)));
            if (changed) { NotifySetChange(); }
        }

        private (ICollection<EquipmentSetEffect> Before, ICollection<EquipmentSetEffect> After, bool HasChanged)
            ProcessSetAffect()
        {
            var (setBefore, setAfter, changed) = ComputeSetAffect();

            Sets.Clear();
            foreach (var x in setAfter) { Sets.Add(x); }

            return (setBefore, setAfter, changed);
        }

        private (ICollection<EquipmentSetEffect> Before, ICollection<EquipmentSetEffect> After, bool HasChanged)
            ComputeSetAffect()
        {
            var before = Sets.ToList();
            var sets   = _data.GetArmorSetEffects();
            var data   = _armors.Where(x => x.Value != null).GroupBy(x => x.Value!.SetName);

            var after = new List<EquipmentSetEffect>();
            foreach (var set in data)
            {
                var effect = sets.FirstOrDefault(x => x.Name.Equals(set.Key));
                if (effect != null) { effect = effect with {Step = set.Count()}; }

                if (effect?.Effects.Any() ?? false) { after.Add(effect); }
            }

            var changed = before.Count != after.Count || before.Any(x => !after.Contains(x));

            return (before, after, changed);
        }
    }
}