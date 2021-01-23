using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Services.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IAccessorySetComputeService : ISetComputeService<AccessorySet>
    {
        IEnumerable<Accessory> Get();
        IEnumerable<Accessory> Get(AccessoryField                    field);
        void                   Clear(AccessoryField                  field);
        void                   Change(IReadOnlyCollection<Accessory> accessories);
    }

    internal class AccessorySetComputeService : SetComputeServiceBase<AccessorySet>, IAccessorySetComputeService
    {
        private readonly IList<Accessory>    _accessories;
        private readonly IDataProvideService _provider;

        public AccessorySetComputeService(IDataProvideService provider)
        {
            _provider    = provider;
            _accessories = new List<Accessory>();
        }

        public IEnumerable<Accessory> Get() => _accessories.Where(x => x != null).ToList();

        public IEnumerable<Accessory> Get(AccessoryField field) =>
            _accessories.Where(x => x != null && x.Field == field);

        public void Change(IReadOnlyCollection<Accessory> accessories)
        {
            var fields = accessories.GroupBy(x => x.Field).ToList();

            var before = new List<Accessory>();
            foreach (var field in fields)
            {
                before.AddRange(_accessories.Where(x => x.Field == field.Key));
                foreach (var a in before) { _accessories.Remove(a); }
            }

            foreach (var accessory in accessories) { _accessories.Add(accessory); }

            ProcessAffect(before, accessories);
        }

        public void Clear(AccessoryField field)
        {
            var before = _accessories.Where(x => x.Field == field && x != null).ToList();
            if (!before.Any()) { return; }

            before.ForEach(x => _accessories.Remove(x));

            ProcessAffect(before, (Item?) null);
        }

        public override    IReadOnlyCollection<AccessorySet> GetAllSets()  => _provider.GetAccessorySets();
        protected override IReadOnlyCollection<Item>         GetAllItems() => _accessories.ToList();
    }
}