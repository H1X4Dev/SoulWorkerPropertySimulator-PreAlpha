using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class AccessoryData
    {
        private static IReadOnlyCollection<AccessoryBlueprint>? _blueprints;

        private static readonly Dictionary<AccessoryField, IReadOnlyCollection<AccessoryBlueprint>> Result = new();

        internal static IReadOnlyCollection<AccessoryBlueprint> Get(AccessoryField field)
        {
            if (Result.ContainsKey(field)) { return Result[field]; }

            if (_blueprints != null) { return Result[field] = _blueprints.Where(x => x.Field == field).ToList(); }

            var blueprints = new List<AccessoryBlueprint>
            {
                new("閃耀",
                    68,
                    AccessoryField.Earrings,
                    4,
                    new RandomEffect[]
                    {
                        new(StaticEffect.Attack, 36, 321),
                        new(StaticEffect.Defense, 23, 534),
                        new(StaticEffect.AttackSpeedRate, .01m, .07m),
                        new(StaticEffect.Stamina, 4, 10),
                        new(StaticEffect.MoveSpaceRate, .01m, .07m),
                        new(StaticEffect.ExpVolumeRateEnemy, .02m, .15m),
                        new(StaticEffect.KillHpRecovery, 20, 180),
                        new(StaticEffect.SuperArmorBreakPowerRate, .02m, .08m),
                        new(StaticEffect.CooldownShorterRate, .01m, .05m),
                        new(StaticEffect.MoneyVolumeRateEnemy, .02m, .08m),
                        new(StaticEffect.SoulNovaVolumeRate, .01m, .04m),
                        new(StaticEffect.ExtraDamageRateAir, .02m, .12m),
                        new(StaticEffect.ExtraDamageRateFall, .02m, .12m)
                    },
                    ItemRare.Legendary,
                    "暮光"),
                new("邊緣",
                    68,
                    AccessoryField.Amulet,
                    4,
                    new RandomEffect[]
                    {
                        new(StaticEffect.Attack, 36, 321),
                        new(StaticEffect.Defense, 23, 534),
                        new(StaticEffect.AttackSpeedRate, .01m, .07m),
                        new(StaticEffect.Stamina, 4, 10),
                        new(StaticEffect.DamageReductionRate, .01m, .05m),
                        new(StaticEffect.ExpVolumeRateEnemy, .02m, .15m),
                        new(StaticEffect.KillHpRecovery, 20, 180),
                        new(StaticEffect.SuperArmorBreakPowerRate, .02m, .08m),
                        new(StaticEffect.CooldownShorterRate, .01m, .05m),
                        new(StaticEffect.MoneyVolumeRateEnemy, .02m, .08m),
                        new(StaticEffect.SoulNovaVolumeRate, .01m, .04m),
                        new(StaticEffect.ExtraDamageRateAir, .02m, .12m),
                        new(StaticEffect.ExtraDamageRateFall, .02m, .12m)
                    },
                    ItemRare.Legendary,
                    "暮光")
            };
            var r68 = new AccessoryBlueprint("之冠I",
                68,
                AccessoryField.Ring,
                4,
                new RandomEffect[]
                {
                    new(StaticEffect.Attack, 19, 190),
                    new(StaticEffect.Defense, 16, 423),
                    new(StaticEffect.CriticalRate, .01m, .07m),
                    new(StaticEffect.CriticalDamage, 250, 694),
                    new(StaticEffect.Accuracy, 10, 108),
                    new(StaticEffect.Evade, 7, 36),
                    new(StaticEffect.DamageReductionRateBasic, .01m, .1m),
                    new(StaticEffect.DamageReductionRateBoss, .01m, .1m),
                    new(StaticEffect.DamageReductionRatePartialDamage, .02m, .12m),
                    new(StaticEffect.ExpVolumeRateEnemy, .02m, .15m),
                    new(StaticEffect.MoneyVolumeRateEnemy, .02m, .08m),
                    new(StaticEffect.SoulNovaVolumeRate, .01m, .04m)
                },
                ItemRare.Legendary,
                "暮光");
            blueprints.Add(r68);
            blueprints.Add(r68 with {Name = "之冠II"});

            _blueprints = blueprints;
            return Result[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}