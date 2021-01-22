using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IAccessoryComputeService : IComputeService<AccessorySetEffect>
    {
        IEnumerable<Accessory> Get();
        IEnumerable<Accessory> Get(AccessoryField                    field);
        void                   Change(Accessory                      accessory);
        void                   Clear(AccessoryField                  field);
        void                   Change(IReadOnlyCollection<Accessory> accessories);
    }

    internal class AccessoryComputeService : ComputeServiceBase<AccessorySetEffect>, IAccessoryComputeService
    {
        private readonly IList<Accessory>    _accessories;
        private readonly IDataProvideService _provider;

        public AccessoryComputeService(IDataProvideService provider)
        {
            _provider    = provider;
            _accessories = new List<Accessory>();
        }

        public IEnumerable<Accessory> Get() => _accessories.Where(x => x != null).ToList();

        public IEnumerable<Accessory> Get(AccessoryField field) =>
            _accessories.Where(x => x != null && x.Field == field);

        public void Change(Accessory? newItem)
        {
            if (newItem == null) { throw new InvalidOperationException(); }

            Change(new[] {newItem});
        }

        public void Change(IReadOnlyCollection<Accessory> accessories)
        {
            var fields = accessories.GroupBy(x => x.Field).ToList();

            var old = new List<Accessory>();
            foreach (var field in fields)
            {
                old.AddRange(_accessories.Where(x => x.Field == field.Key));
                foreach (var a in old) { _accessories.Remove(a); }
            }

            foreach (var accessory in accessories) { _accessories.Add(accessory); }

            var (setBefore, setAfter, changed) = ProcessSetAffect();
            NotifyChange(ComputeAffect(old.SelectMany(x => x.Effects).Concat(setBefore.SelectMany(x => x.Effects)),
                accessories.SelectMany(x => x.Effects).Concat(setAfter.SelectMany(x => x.Effects))));
            if (changed) { NotifySetChange(); }
        }

        public void Clear(AccessoryField field)
        {
            var before = _accessories.Where(x => x.Field == field && x != null).ToList();
            if (!before.Any()) { return; }

            before.ForEach(x => _accessories.Remove(x));

            var (setBefore, setAfter, changed) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.SelectMany(x => x.Effects).Concat(setBefore.SelectMany(x => x.Effects)),
                setAfter.SelectMany(x => x.Effects)));
            if (changed) { NotifySetChange(); }
        }

        private (ICollection<AccessorySetEffect> Before, ICollection<AccessorySetEffect> After, bool HasChanged)
            ProcessSetAffect()
        {
            var (setBefore, setAfter, changed) = ComputeSetAffect();

            Sets.Clear();
            foreach (var x in setAfter) { Sets.Add(x); }

            return (setBefore, setAfter, changed);
        }

        private (ICollection<AccessorySetEffect> Before, ICollection<AccessorySetEffect> After, bool HasChanged)
            ComputeSetAffect()
        {
            var before = Sets.ToList();
            var sets   = _provider.GetAccessorySetEffects();
            var data   = _accessories.Where(x => x != null).GroupBy(x => x.SetName);

            var after = new List<AccessorySetEffect>();
            foreach (var set in data)
            {
                var effect =
                    sets.FirstOrDefault(x => x.Name.Equals(set.Key, StringComparison.InvariantCultureIgnoreCase));
                if (effect != null) { effect = effect with {Step = set.Select(x => x.Name).Distinct().Count()}; }

                if (effect?.Effects.Any() ?? false) { after.Add(effect!); }
            }

            var changed = before.Count != after.Count || before.Any(x => !after.Contains(x));

            return (before, after, changed);
        }
    }
}