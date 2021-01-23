using System;
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
        $"{Field.GetDescription()}{Series.GetDescription()}套裝",
        Empty)
    {
        private static readonly Dictionary<int, IReadOnlyCollection<Effect>> Empty = new() {{3, Array.Empty<Effect>()}};

        public override IReadOnlyCollection<Effect> Effects => RareEffects[Rare];
    }
}