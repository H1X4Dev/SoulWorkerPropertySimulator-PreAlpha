using System.Collections.Generic;
using SoulWorkerPropertySimulator.Extensions;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Brooches
{
    public record BroochSet(BroochesField Field,
                            BroochesSeries Series,
                            IReadOnlyDictionary<BroochesRare, IReadOnlyCollection<Effect>> RareEffects,
                            BroochesRare Rare = BroochesRare.Tera) : Set(
        $"{Field.GetDescription()}{Series.GetDescription()}套裝")
    {
        public override IReadOnlyCollection<Effect> Effects => RareEffects[Rare];
    }
}