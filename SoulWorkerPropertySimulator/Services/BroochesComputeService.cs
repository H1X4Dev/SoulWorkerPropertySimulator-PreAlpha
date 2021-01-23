using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Services.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IBroochesSetComputeService : ISetComputeService<BroochSet>
    {
        Brooch? Get(BroochesField    field, BroochesType type);
        void    Change(BroochesField field, Brooch       newItem);
        void    Clear(BroochesField  field, BroochesType type);
    }

    internal class BroochesSetComputeService : ComputeServiceBase, IBroochesSetComputeService
    {
        private readonly Dictionary<BroochesField, Dictionary<BroochesType, Brooch?>> _brooches    = new();
        private readonly Dictionary<BroochesField, BroochSet?>                        _broochesSet = new();
        private readonly IDataProvideService                                          _provider;

        public BroochesSetComputeService(IDataProvideService provider) => _provider = provider;
        public event Action<IReadOnlyCollection<BroochSet>>? OnSetChange;
        public IReadOnlyCollection<BroochSet> GetSets() => _broochesSet.Values.Where(x => x != null).ToList()!;

        public Brooch? Get(BroochesField field, BroochesType type)
        {
            try { return _brooches[field][type]; }
            catch (KeyNotFoundException) { return null; }
        }

        public void Change(BroochesField field, Brooch newItem)
        {
            Brooch? before = null;
            if (!_brooches.ContainsKey(field)) { _brooches.Add(field, new()); }

            if (_brooches[field].ContainsKey(newItem.Type)) { before = _brooches[field][newItem.Type]; }

            _brooches[field][newItem.Type] = newItem;

            ProcessAffect(before, newItem, field);
        }

        public void Clear(BroochesField field, BroochesType type)
        {
            if (!_brooches.ContainsKey(field)) { return; }

            if (!_brooches[field].ContainsKey(type) || _brooches[field][type] == null) { return; }

            var before = _brooches[field][type];
            if (before == null) { return; }

            _brooches[field][type] = null;

            ProcessAffect(before, null, field);
        }

        protected void ProcessAffect(Brooch? before, Brooch? after, BroochesField field)
        {
            ProcessAffect(before, after);
            ComputeSetAffect(field);
        }

        private void ComputeSetAffect(BroochesField field)
        {
            if (!_brooches.ContainsKey(field)) { throw new InvalidOperationException(); }

            BroochSet? before;
            try { before = _broochesSet[field]; }
            catch (KeyNotFoundException) { before = null; }

            var        brooches = _brooches[field].Select(x => x.Value).Where(x => x != null).ToList();
            BroochSet? after    = null;
            var        first    = brooches.FirstOrDefault();
            if (first          != null                                  &&
                brooches.Count == Enum.GetValues<BroochesType>().Length &&
                brooches.All(x => x!.Series == first.Series)            &&
                brooches.All(x => x!.Rare   == first.Rare))
            {
                after = _provider.GetBroochesSets(field, first.Series) with {Rare = first.Rare};
            }

            if (before == after) { return; }

            _broochesSet[field] = after;

            ProcessAffect(before, after);

            OnSetChange?.Invoke(_broochesSet.Values.Where(x => x != null).ToList()!);
        }
    }
}