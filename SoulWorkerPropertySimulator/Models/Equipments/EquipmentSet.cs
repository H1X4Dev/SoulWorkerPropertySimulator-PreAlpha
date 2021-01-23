using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Models.Equipments
{
    public record EquipmentSet(string Name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects) : Set(
        Name,
        StepEffects);
}