using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class ArmorSetData
    {
        private static readonly IReadOnlyCollection<ArmorSetEffect> Result = new List<ArmorSetEffect>
        {
            new("進階暮光",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {2, new Effect[] {new(Static.CriticalDamage, 9_000), new(Static.CriticalRate, .15m)}},
                    {
                        3,
                        new Effect[]
                        {
                            new(new(Property.Attack, Opportunity.HitStamina70Down, duration: 1), 500),
                            new(new(Property.Attack, Opportunity.HitStamina40Down, duration: 1), 1000),
                            new(new(Property.Attack, Opportunity.HitStamina10Down, duration: 1), 3000)
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(Static.ExtraDamageRateBoss, .4m),
                            new(Static.SoulGateConsumptionReducedRate, .1m),
                            new(Static.SuperArmorBreakPowerRate, .5m),
                            new(Static.AttackSpeedRate, .14m)
                        }
                    }
                })
        };

        internal static IReadOnlyCollection<ArmorSetEffect> Get() => Result;
    }
}