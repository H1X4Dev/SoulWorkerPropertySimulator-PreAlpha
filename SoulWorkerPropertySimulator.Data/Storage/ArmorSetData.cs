using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class ArmorSetData
    {
        private static IReadOnlyCollection<ArmorSetEffect>? _armorSetEffectResult;

        internal static IReadOnlyCollection<ArmorSetEffect> Get()
        {
            if (_armorSetEffectResult != null) { return _armorSetEffectResult; }

            return _armorSetEffectResult = new List<ArmorSetEffect>
            {
                new("進階暮光",
                    new Dictionary<int, IReadOnlyCollection<Effect>>
                    {
                        {
                            2,
                            new List<Effect>
                            {
                                new(new(Property.CriticalDamage), 9000), new(new(Property.CriticalRate), .15m)
                            }
                        },
                        {
                            3,
                            new List<Effect>
                            {
                                new(new(Property.Attack, Opportunity.HitStamina70Down, duration: 1), 500),
                                new(new(Property.Attack, Opportunity.HitStamina40Down, duration: 1), 1000),
                                new(new(Property.Attack, Opportunity.HitStamina10Down, duration: 1), 3000)
                            }
                        },
                        {
                            4,
                            new List<Effect>
                            {
                                new(new(Property.ExtraDamageRateBoss), .4m),
                                new(new(Property.SoulGateConsumptionReducedRate), .1m),
                                new(new(Property.SuperArmorBreakPowerRate), .5m),
                                new(new(Property.AttackSpeedRate), .14m)
                            }
                        }
                    })
            };
        }
    }
}