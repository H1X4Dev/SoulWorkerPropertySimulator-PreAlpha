using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data
{
    internal static class ArmorSetData
    {
        private static IReadOnlyCollection<ArmorSetEffect>? _armorSetEffectResult;

        internal static IReadOnlyCollection<ArmorSetEffect> Get()
        {
            if (_armorSetEffectResult != null) { return _armorSetEffectResult; }

            return _armorSetEffectResult = new List<ArmorSetEffect>
            {
                new("進階幕光套裝",
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
                                new(new(Property.Attack, Opportunity.HitStamina70Down, Duration: 1), 500),
                                new(new(Property.Attack, Opportunity.HitStamina40Down, Duration: 1), 1000),
                                new(new(Property.Attack, Opportunity.HitStamina10Down, Duration: 1), 3000),
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