using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IAccessoryComputeService : IComputeService<AccessorySetEffect>
    {
        IEnumerable<Accessory?> Get();
        IEnumerable<Accessory?> Get(AccessoryField                    field);
        void                    Change(Accessory                      accessory);
        void                    Clear(AccessoryField                  field);
        void                    Change(IReadOnlyCollection<Accessory> accessories);
    }

    internal class AccessoryComputeService : ComputeServiceBase<AccessorySetEffect>, IAccessoryComputeService
    {
        private readonly IList<Accessory>          _accessories;
        private readonly IDataProvideService       _provider;
        private readonly IList<AccessorySetEffect> _sets;

        public AccessoryComputeService(IDataProvideService provider)
        {
            _provider    = provider;
            _accessories = new List<Accessory>();
            _sets        = new List<AccessorySetEffect>();
        }

        public IEnumerable<Accessory?> Get() => _accessories.ToList();

        public IEnumerable<Accessory?> Get(AccessoryField field) => _accessories.Where(x => x?.Field == field);

        public void Change(Accessory? newItem)
        {
            if (newItem == null) { throw new InvalidOperationException(); }

            Change(new[] {newItem});
        }

        public void Change(IReadOnlyCollection<Accessory> accessories)
        {
            var grouping = accessories.GroupBy(x => x.Field).ToList();
            if (grouping.Where(x => x.Key != AccessoryField.Ring).Any(x => x.Count() > 1) ||
                (grouping.FirstOrDefault(x => x.Key == AccessoryField.Ring)?.Count() ?? 3) > 2)
            {
                throw new IndexOutOfRangeException();
            }

            var old = new List<Accessory>();
            foreach (var accessory in accessories)
            {
                old.AddRange(_accessories.Where(x => x.Field == accessory.Field));
                foreach (var a in old) { _accessories.Remove(a); }
            }

            foreach (var accessory in accessories) { _accessories.Add(accessory); }


            var (setBefore, setAfter) = ProcessSetAffect();
            NotifyChange(ComputeAffect(old.SelectMany(x => x.Effects).Concat(setBefore.SelectMany(x => x.Effects)),
                accessories.SelectMany(x => x.Effects).Concat(setAfter.SelectMany(x => x.Effects))));
        }

        public void Clear(AccessoryField field)
        {
            var before = _accessories.Where(x => x.Field == field && x != null).ToList();
            if (!before.Any()) { return; }

            before.ForEach(x => _accessories.Remove(x));

            var (setBefore, setAfter) = ProcessSetAffect();
            NotifyChange(ComputeAffect(before.SelectMany(x => x.Effects).Concat(setBefore.SelectMany(x => x.Effects)),
                setAfter.SelectMany(x => x.Effects)));
        }

        private (ICollection<AccessorySetEffect> Before, ICollection<AccessorySetEffect> After) ProcessSetAffect()
        {
            var (setBefore, setAfter) = ComputeSetAffect();

            _sets.Clear();
            foreach (var x in setAfter) { _sets.Add(x); }

            return (setBefore, setAfter);
        }

        private (ICollection<AccessorySetEffect> Before, ICollection<AccessorySetEffect> After) ComputeSetAffect()
        {
            var before = _sets.ToList();
            var sets   = _provider.GetAccessorySetEffects();
            var data   = _accessories.Where(x => x != null).GroupBy(x => x.SetName);

            ICollection<AccessorySetEffect> after = (from grouping in data
                                                     let effect =
                                                         sets.FirstOrDefault(x => x.Name.Equals(grouping.Key,
                                                             StringComparison.InvariantCultureIgnoreCase))
                                                     where effect != null
                                                     select effect with {Step = grouping.Count()}).ToList()!;

            return (before, after);
        }
    }
}