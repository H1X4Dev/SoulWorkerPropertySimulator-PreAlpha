using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Models.Plugins;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Services.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IEquipmentComputeService : ISetComputeService<EquipmentSet>
    {
        IEnumerable<Equipment> Get();
        Equipment?             Get(EquipmentField    field);
        void                   Change(Equipment      item);
        void                   Change(EquipmentField field, Tag?                        tag);
        void                   Change(EquipmentField field, IReadOnlyCollection<Plugin> plugins);
        void                   Clear(EquipmentField  field);
    }

    internal class EquipmentComputeService : SetComputeServiceBase<EquipmentSet>, IEquipmentComputeService
    {
        private readonly IDictionary<EquipmentField, Equipment?> _equipments;
        private readonly IDataProvideService                     _provider;

        public EquipmentComputeService(IDataProvideService provider)
        {
            _provider   = provider;
            _equipments = new Dictionary<EquipmentField, Equipment?>();
        }

        public IEnumerable<Equipment> Get()
        {
            try { return _equipments.Select(x => x.Value).Where(x => x != null)!; }
            catch (KeyNotFoundException) { return Array.Empty<Equipment>(); }
        }

        public Equipment? Get(EquipmentField field)
        {
            try { return _equipments[field]; }
            catch (KeyNotFoundException) { return null; }
        }

        public void Change(Equipment item)
        {
            if (item == null) { throw new InvalidOperationException(); }

            Equipment? before;
            try { before = _equipments[item.Field]; }
            catch (KeyNotFoundException) { before = null; }

            _equipments[item.Field] = item;
            ProcessAffect(before, item);
        }

        public void Change(EquipmentField field, Tag? tag)
        {
            if (!_equipments.ContainsKey(field) || _equipments[field] == null) { return; }

            var before = _equipments[field]!;
            var after  = _equipments[field]! with {Tag = tag};
            _equipments[field] = after;

            ProcessAffect(before, after);
        }

        public void Change(EquipmentField field, IReadOnlyCollection<Plugin> plugins)
        {
            if (!_equipments.ContainsKey(field) || _equipments[field] == null) { return; }

            var before = _equipments[field]!;

            if (plugins.Count > before.PluginLimit) { throw new InvalidOperationException(); }

            var after = _equipments[field]! with {Plugins = plugins};
            _equipments[field] = after;

            ProcessAffect(before, after);
        }

        public void Clear(EquipmentField field)
        {
            if (!_equipments.ContainsKey(field) || _equipments[field] == null) { return; }

            var before = _equipments[field]!;
            _equipments[field] = null;

            ProcessAffect(before, null);
        }

        public override IReadOnlyCollection<EquipmentSet> GetAllSets() => _provider.GetEquipmentSets();

        protected override IReadOnlyCollection<Item> GetAllItems() =>
            _equipments.Values.Where(x => x != null).ToList()!;
    }
}