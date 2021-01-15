using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IBroochesComputeService : IComputeService
    {
        Brooches? Get(BroochesField field, BroochesType type);

        // IEnumerable<Brooches?> Get(BroochesField   field);
        void Change(Brooches?    newItem, BroochesField field);
        void Clear(BroochesField field,   BroochesType? type = null);

        event Action<BroochesField, string?>? OnSetChange;
    }

    internal class BroochesComputeService : ComputeServiceBase, IBroochesComputeService
    {
        private readonly IDataProvideService                                              _provider;
        private readonly IDictionary<BroochesField, IDictionary<BroochesType, Brooches?>> Brooches;
        private readonly IDictionary<BroochesField, BroochesSetEffect?>                   BroochesSet;

        public BroochesComputeService(IDataProvideService provider)
        {
            _provider   = provider;
            Brooches    = new Dictionary<BroochesField, IDictionary<BroochesType, Brooches?>>();
            BroochesSet = new Dictionary<BroochesField, BroochesSetEffect?>();
        }

        public event Action<BroochesField, string?>? OnSetChange;

        public Brooches? Get(BroochesField field, BroochesType type)
        {
            try { return Brooches[field][type]; }
            catch (KeyNotFoundException) { return null; }
        }

        // public IEnumerable<Brooches?> Get(BroochesField field)
        // {
        //     try { return Brooches[field].Values; }
        //     catch (KeyNotFoundException) { return Array.Empty<Brooches>(); }
        // }

        public void Change(Brooches? newItem, BroochesField field)
        {
            if (newItem == null) { throw new InvalidOperationException(); }

            IDictionary<BroochesType, Brooches?> dict;
            if (Brooches.ContainsKey(field)) { dict = Brooches[field]; }
            else
            {
                dict = new Dictionary<BroochesType, Brooches?>();
                Brooches.Add(field, dict);
            }

            Brooches? before;

            try { before = dict[newItem.Type]; }
            catch (KeyNotFoundException) { before = null; }

            dict[newItem.Type] = newItem;

            var (setBefore, setAfter) = ComputeSetAffect(field);
            BroochesSet[field]        = setAfter;

            NotifyChange(ComputeAffect(
                (before?.Effects ?? Array.Empty<Effect>()).Concat(setBefore?.Effects ?? Array.Empty<Effect>()),
                newItem.Effects.Concat(setAfter?.Effects                             ?? Array.Empty<Effect>())));

            if (setBefore?.Classify != setAfter?.Classify) { OnSetChange?.Invoke(field, setAfter?.Name); }
        }

        public void Clear(BroochesField field, BroochesType? type = null)
        {
            if (!Brooches.ContainsKey(field)) { return; }

            IEnumerable<Effect> before;
            if (type == null)
            {
                before = Brooches[field].Where(x => x.Value != null).SelectMany(x => x.Value!.Effects);
                Brooches[field].Clear();
            }
            else if (Brooches[field].ContainsKey(type.Value) && Brooches[field][type.Value] != null)
            {
                before                      = Brooches[field][type.Value]!.Effects;
                Brooches[field][type.Value] = null;
            }
            else { return; }

            BroochesSetEffect? setBefore;
            try { setBefore = BroochesSet[field]; }
            catch (KeyNotFoundException) { setBefore = null; }

            BroochesSet[field] = null;
            NotifyChange(ComputeAffect(before.Concat(setBefore?.Effects ?? Array.Empty<Effect>()),
                Array.Empty<Effect>()));

            if (setBefore != null) { OnSetChange?.Invoke(field, null); }
        }

        private (BroochesSetEffect? Before, BroochesSetEffect? After) ComputeSetAffect(BroochesField field)
        {
            if (!Brooches.ContainsKey(field)) { throw new InvalidOperationException(); }

            BroochesSetEffect? before;
            try { before = BroochesSet[field]; }
            catch (KeyNotFoundException) { before = null; }

            var brooches = Brooches[field].Select(x => x.Value).Where(x => x != null)!.ToList<Brooches>();
            var after = brooches.GroupBy(x => x.BroochesClassify).All(x => x.Count() == 1) &&
                        brooches.Select(x => x.BroochesClassify).Distinct().Count() == 1 &&
                        brooches.Count == Enum.GetValues<BroochesType>().Length
                ? _provider.GetBroochesSets(brooches.First().BroochesClassify)
                : null;

            return (before, after);
        }
    }
}