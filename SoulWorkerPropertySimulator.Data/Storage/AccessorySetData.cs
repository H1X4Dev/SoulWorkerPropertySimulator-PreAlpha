using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Models.Effects;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class AccessorySetData
    {
        private static readonly IReadOnlyCollection<AccessorySetEffect> Result = new List<AccessorySetEffect>
        {
            new("暮光",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {2, new Effect[] {new(StaticEffect.Stamina, 17), new(StaticEffect.CriticalDamage, 2_200)}},
                    {
                        3,
                        new Effect[]
                        {
                            new(StaticEffect.Accuracy, 370), new(StaticEffect.ExtraDamageRateBoss, .35m)
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(StaticEffect.CooldownShorterRate, .8m),
                            new(StaticEffect.DefenseBreakRate, .12m)
                        }
                    }
                })
        };

        internal static IReadOnlyCollection<AccessorySetEffect> Get() => Result;
    }
}