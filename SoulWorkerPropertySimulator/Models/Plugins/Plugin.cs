using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Models.Plugins
{
    public record Plugin : Item
    {
        private readonly int? _step;

        internal Plugin(PluginBlueprint blueprint, IReadOnlyCollection<Effect>? randomEffects = null) : base(
            blueprint.Name,
            blueprint.SetName)
        {
            if (!blueprint.CheckEffectAllowed(randomEffects)) { throw new InvalidOperationException(); }

            Blueprint      = blueprint;
            SelectedEffect = randomEffects ?? Array.Empty<Effect>();

            _step = blueprint.ValidStep?.Max();
        }

        public override IReadOnlyCollection<Effect> Effects =>
            SelectedEffect.Concat(Step != null && Blueprint.StepEffects != null
                    ? Blueprint.StepEffects[Step.Value]
                    : Array.Empty<Effect>())
                .ToList();

        public PluginBlueprint Blueprint { get; }

        public IReadOnlyCollection<Effect> SelectedEffect { get; }

        public int? Step
        {
            get => _step;
            init
            {
                if ((_step == null) ^ (value == null)) { throw new InvalidOperationException(); } //1001

                _step = value;
            }
        }
    }
}