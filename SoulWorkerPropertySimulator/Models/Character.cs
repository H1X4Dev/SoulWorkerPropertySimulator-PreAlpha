using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SoulWorkerPropertySimulator.Models
{
    public record Character : Item, IUpgradeable
    {
        internal Character(string name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> stepEffect) : base(name,
            Classify.Character)
        {
            if (!stepEffect.Any()) { throw new DataException(); }

            if (!stepEffect.ContainsKey(0)) { Step = stepEffect.Max(x => x.Key); }

            StepEffects = stepEffect;
        }

        // public Title? First { get; init; }
        // public Title? Last  { get; init; }

        // public IReadOnlyCollection<Effect> OriginalEffects => StepEffects[Step].ToList();

        public override IReadOnlyCollection<Effect> Effects =>
            StepEffects[Step]
                // .Concat(First?.Effects ?? Array.Empty<Effect>())
                // .Concat(Last?.Effects  ?? Array.Empty<Effect>())
                .ToList();

        public IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects { get; }

        public IReadOnlyCollection<int> ValidStep => StepEffects.Keys.OrderBy(x => x).ToList();

        public int Step { get; init; }
    }
}