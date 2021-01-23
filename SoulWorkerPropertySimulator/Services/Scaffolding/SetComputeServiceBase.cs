using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Services.Scaffolding
{
    public interface ISetComputeService<out T> : IComputeService where T : Set
    {
        event Action<IReadOnlyCollection<T>>? OnSetChange;
        IReadOnlyCollection<T>                GetSets();
    }


    internal abstract class SetComputeServiceBase<T> : ComputeServiceBase, ISetComputeService<T> where T : Set
    {
        protected List<T>                            Sets = new();
        public event Action<IReadOnlyCollection<T>>? OnSetChange;

        public          IReadOnlyCollection<T> GetSets() => Sets.ToList();
        public abstract IReadOnlyCollection<T> GetAllSets();

        protected abstract IReadOnlyCollection<Item> GetAllItems();

        protected new void ProcessAffect(Item? before, Item? after) =>
            ProcessAffect(before != null ? new[] {before} : Array.Empty<Item>(),
                after            != null ? new[] {after} : Array.Empty<Item>());

        protected void ProcessAffect(IEnumerable<Item> before, Item? after) =>
            ProcessAffect(before, after != null ? new[] {after} : Array.Empty<Item>());

        protected new void ProcessAffect(IEnumerable<Item> before, IEnumerable<Item> after)
        {
            var afterList = after.ToList();
            base.ProcessAffect(before, afterList);
            ComputeSetAffect();
        }

        private void ComputeSetAffect()
        {
            var before  = Sets.ToList();
            var allSets = GetAllSets();
            var data    = GetAllItems().Where(x => x != null && x.SetName != null).GroupBy(x => x.SetName);

            var after = new List<T>();
            foreach (var set in data)
            {
                var effect = allSets.FirstOrDefault(x =>
                    x.Name.Equals(set.Key, StringComparison.InvariantCultureIgnoreCase));
                if (effect != null) { effect = effect with {Step = set.Select(x => x.Name).Distinct().Count()}; }

                if (effect?.Effects.Any() ?? false) { after.Add(effect!); }
            }

            if (before.Count == after.Count && before.All(x => after.Contains(x))) { return; }

            Sets.Clear();
            foreach (var x in after) { Sets.Add(x); }

            ProcessAffect(before, after);

            OnSetChange?.Invoke(after);
        }
    }
}