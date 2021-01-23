using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class EquipmentSetData
    {
        private static readonly IReadOnlyCollection<EquipmentSet> Result = new List<EquipmentSet>
        {
            new("進階暮光",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        2,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 9_000),
                            new(StaticEffectContext.CriticalRate, .15m)
                        }
                    },
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
                            new(StaticEffectContext.ExtraDamageRateBoss, .4m),
                            new(StaticEffectContext.SoulGateConsumptionReducedRate, .1m),
                            new(StaticEffectContext.SuperArmorBreakPowerRate, .5m),
                            new(StaticEffectContext.AttackSpeedRate, .14m)
                        }
                    }
                })
        };

        internal static IReadOnlyCollection<EquipmentSet> Get() => Result;
    }
}