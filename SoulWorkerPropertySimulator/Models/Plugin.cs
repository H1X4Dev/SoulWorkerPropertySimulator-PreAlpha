using System;
using System.Collections.Generic;
using System.Linq;

namespace SoulWorkerPropertySimulator.Models
{
    public record PluginBlueprint : Blueprint<Plugin>
    {
        public PluginBlueprint(string                                                 name,
                               PluginField                                            field,
                               int                                                    level,
                               IReadOnlyCollection<EffectRandomContext>               randomEffects,
                               int                                                    randomEffectCount,
                               IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? stepEffects  = null,
                               string?                                                setName      = null,
                               IReadOnlyCollection<Effect>?                           fixedEffects = null) : base(name,
            level,
            randomEffects,
            randomEffectCount,
            stepEffects,
            setName,
            fixedEffects) =>
            Field = field;

        public PluginField Field { get; }

        public IReadOnlyCollection<int> ValidStep =>
            StepEffects.Any() ? new[] {0} : StepEffects.Keys.OrderBy(x => x).ToList();

        public override Plugin Create(IReadOnlyCollection<Effect>? randomEffects = null) => new(this, randomEffects);
    }

    public record Plugin : Item, ICreatable<PluginBlueprint>, IUpgradeable
    {
        private readonly int? _step;

        internal Plugin(PluginBlueprint blueprint, IReadOnlyCollection<Effect>? randomEffects = null) : base(
            blueprint.Name,
            Classify.Armor,
            blueprint.SetName)
        {
            if (!blueprint.CheckEffectAllowed(randomEffects)) { throw new InvalidOperationException(); }

            Blueprint      = blueprint;
            SelectedEffect = randomEffects ?? Array.Empty<Effect>();

            _step = StepEffects.Any() ? StepEffects.Max(x => x.Key) : null;
        }

        public override IReadOnlyCollection<Effect> Effects =>
            Blueprint.FixedEffects.Concat(SelectedEffect)
                .Concat(_step == null ? Array.Empty<Effect>() : StepEffects[Step])
                .ToList();

        // public PluginField Field => Blueprint.Field;
        // public int         Level => Blueprint.Level;

        public PluginBlueprint                                       Blueprint      { get; }
        public IReadOnlyCollection<Effect>                           SelectedEffect { get; }
        public IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects    => Blueprint.StepEffects!;
        public IReadOnlyCollection<int>                              ValidStep      => Blueprint.ValidStep;

        public int Step
        {
            get => _step ?? 0;
            init
            {
                if (_step == null) { throw new InvalidOperationException(); }

                _step = value;
            }
        }
    }
}