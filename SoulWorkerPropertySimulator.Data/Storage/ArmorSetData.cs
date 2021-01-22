using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class ArmorSetData
    {
        private static readonly IReadOnlyCollection<EquipmentSetEffect> Result = new List<EquipmentSetEffect>
        {
            new("進階暮光",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        2,
                        new Effect[] {new(StaticEffect.CriticalDamage, 9_000), new(StaticEffect.CriticalRate, .15m)}
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
                            new(StaticEffect.ExtraDamageRateBoss, .4m),
                            new(StaticEffect.SoulGateConsumptionReducedRate, .1m),
                            new(StaticEffect.SuperArmorBreakPowerRate, .5m),
                            new(StaticEffect.AttackSpeedRate, .14m)
                        }
                    }
                })
        };

        internal static IReadOnlyCollection<EquipmentSetEffect> Get() => Result;
    }
}