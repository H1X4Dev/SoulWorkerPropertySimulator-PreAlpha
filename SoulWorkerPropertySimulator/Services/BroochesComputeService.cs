using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IBroochesComputeService : IComputeService<BroochesSetEffect>
    {
        Brooches? Get(BroochesField    field, BroochesType  type);
        void      Change(BroochesField field, Brooches      newItem);
        void      Clear(BroochesField  field, BroochesType? type = null);
    }

    internal class BroochesComputeService : ComputeServiceBase<BroochesSetEffect>, IBroochesComputeService
    {
        private readonly Dictionary<BroochesField, IDictionary<BroochesType, Brooches?>> _brooches    = new();
        private readonly Dictionary<BroochesField, BroochesSetEffect?>                   _broochesSet = new();
        private readonly IDataProvideService                                             _provider;

        public BroochesComputeService(IDataProvideService provider) => _provider = provider;

        protected override List<BroochesSetEffect> Sets => _broochesSet.Values.Where(x => x != null).ToList()!;

        public Brooches? Get(BroochesField field, BroochesType type)
        {
            try { return _brooches[field][type]; }
            catch (KeyNotFoundException) { return null; }
        }

        public void Change(BroochesField field, Brooches newItem)
        {
            if (newItem == null) { throw new InvalidOperationException(); }

            IDictionary<BroochesType, Brooches?> dict;
            if (_brooches.ContainsKey(field)) { dict = _brooches[field]; }
            else
            {
                dict = new Dictionary<BroochesType, Brooches?>();
                _brooches.Add(field, dict);
            }

            Brooches? before;

            try { before = dict[newItem.Type]; }
            catch (KeyNotFoundException) { before = null; }

            dict[newItem.Type] = newItem;

            var setResult = ComputeSetAffect(field);

            NotifyChange(ComputeAffect(
                (before?.Effects ?? Array.Empty<Effect>()).Concat(setResult?.Before?.Effects ?? Array.Empty<Effect>()),
                newItem.Effects.Concat(setResult?.After?.Effects ?? Array.Empty<Effect>())));

            if (setResult != null)
            {
                _broochesSet[field] = setResult.Value.After;

                NotifySetChange();
            }
        }

        public void Clear(BroochesField field, BroochesType? type = null)
        {
            if (!_brooches.ContainsKey(field)) { return; }

            IEnumerable<Effect> before;
            if (type == null)
            {
                before = _brooches[field].Where(x => x.Value != null).SelectMany(x => x.Value!.Effects);
                _brooches[field].Clear();
            }
            else if (_brooches[field].ContainsKey(type.Value) && _brooches[field][type.Value] != null)
            {
                before                       = _brooches[field][type.Value]!.Effects;
                _brooches[field][type.Value] = null;
            }
            else { return; }

            BroochesSetEffect? setBefore;
            try { setBefore = _broochesSet[field]; }
            catch (KeyNotFoundException) { setBefore = null; }

            _broochesSet[field] = null;
            NotifyChange(ComputeAffect(before.Concat(setBefore?.Effects ?? Array.Empty<Effect>()),
                Array.Empty<Effect>()));

            if (setBefore != null) { NotifySetChange(); }
        }

        private (BroochesSetEffect? Before, BroochesSetEffect? After)? ComputeSetAffect(BroochesField field)
        {
            if (!_brooches.ContainsKey(field)) { throw new InvalidOperationException(); }

            BroochesSetEffect? before;
            try { before = _broochesSet[field]; }
            catch (KeyNotFoundException) { before = null; }

            var                brooches = _brooches[field].Select(x => x.Value).Where(x => x != null).ToList();
            BroochesSetEffect? after    = null;
            var                first    = brooches.FirstOrDefault();
            if (first          != null                                  &&
                brooches.Count == Enum.GetValues<BroochesType>().Length &&
                brooches.All(x => x!.Series == first.Series)            &&
                brooches.All(x => x!.Rare   == first.Rare))
            {
                after = _provider.GetBroochesSets(field, first.Series) with {Rare = first.Rare};
            }

            return before == null && after == null ? ((BroochesSetEffect? Before, BroochesSetEffect? After)?) null :
                before?.Name.Equals(after?.Name) ?? false ? null : (before, after);
        }
    }
}