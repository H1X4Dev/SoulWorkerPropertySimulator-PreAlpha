using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Accessory
{
    public record AccessoryBlueprint : Blueprint<Accessory>
    {
        public AccessoryBlueprint(string                            name,
                                  int                               level,
                                  AccessoryField                    field,
                                  int                               randomAmount,
                                  IReadOnlyCollection<RandomEffect> randomEffects,
                                  ItemRare                          rare,
                                  string?                           setName = null) : base(name,
            level,
            randomAmount,
            randomEffects,
            rare,
            SetName: setName) =>
            Field = field;

        public AccessoryField Field { get; }

        public override Accessory Create(IReadOnlyCollection<Effect> randomEffects) => new(this, randomEffects);
    }
}