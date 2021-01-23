using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Models.Accessory
{
    public record AccessorySet(string Name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects) : Set(
        Name,
        StepEffects);
}