using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Plugins
{
    public record PluginBlueprint : Blueprint<Plugin>
    {
        public PluginBlueprint(string                                                 name,
                               PluginField                                            field,
                               int                                                    level,
                               int                                                    randomAmount,
                               IReadOnlyCollection<RandomEffect>                      randomEffects,
                               IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? stepEffects = null) : base(name,
            level,
            randomAmount,
            randomEffects,
            StepEffects: stepEffects) =>
            Field = field;

        public PluginField Field { get; }

        public IReadOnlyCollection<int>? ValidStep => StepEffects?.Keys.ToList();

        public override Plugin Create(IReadOnlyCollection<Effect>? randomEffects) => new(this, randomEffects);
    }
}