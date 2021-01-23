using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;

namespace SoulWorkerPropertySimulator.Models.Scaffolding
{
    public abstract record Set
        (string Name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects) : Item(Name)
    {
        public override IReadOnlyCollection<Effect> Effects =>
            StepEffects.Where(x => x.Key <= Step).SelectMany(x => x.Value).ToList();

        public int Step { get; init; }
    }
}