using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Models.Effects;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class AccessorySetData
    {
        private static readonly IReadOnlyCollection<AccessorySet> Result = new List<AccessorySet>
        {
            new("Twilight",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        2,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 17), new(StaticEffectContext.CriticalDamage, 2_200)
                        }
                    },
                    {
                        3,
                        new Effect[]
                        {
                            new(StaticEffectContext.Accuracy, 370),
                            new(StaticEffectContext.ExtraDamageRateBoss, .35m)
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(StaticEffectContext.CooldownShorterRate, .8m),
                            new(StaticEffectContext.DefenseBreakRate, .12m)
                        }
                    }
                })
        };

        internal static IReadOnlyCollection<AccessorySet> Get() => Result;
    }
}