using System;
using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Accessory
{
    public record Accessory : Item
    {
        internal Accessory(AccessoryBlueprint blueprint, IReadOnlyCollection<Effect> randomEffects) : base(
            blueprint.Name,
            blueprint.SetName)
        {
            if (!blueprint.CheckEffectAllowed(randomEffects)) { throw new InvalidOperationException(); }

            Blueprint      = blueprint;
            SelectedEffect = randomEffects;
        }

        public override IReadOnlyCollection<Effect> Effects => SelectedEffect;

        public AccessoryBlueprint          Blueprint      { get; }
        public IReadOnlyCollection<Effect> SelectedEffect { get; }

        public AccessoryField Field => Blueprint.Field;
    }
}