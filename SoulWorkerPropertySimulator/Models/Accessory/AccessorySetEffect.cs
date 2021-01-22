using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Models.Accessory
{
    public record AccessorySetEffect
        (string Name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects) : Set(Name)
    {
        public override IReadOnlyCollection<Effect> Effects =>
            StepEffects.Where(x => x.Key <= Step).SelectMany(x => x.Value).ToList();

        public int Step { get; init; }

        public IReadOnlyCollection<int> ValidStep => Enumerable.Range(0, StepEffects.Select(x => x.Key).Max()).ToList();
    }
}