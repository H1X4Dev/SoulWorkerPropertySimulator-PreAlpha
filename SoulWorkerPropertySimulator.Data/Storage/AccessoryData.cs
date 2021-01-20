using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class AccessoryData
    {
        private static IReadOnlyCollection<AccessoryBlueprint>? _blueprints;

        private static readonly Dictionary<AccessoryField, IReadOnlyCollection<AccessoryBlueprint>> _result = new();

        internal static IReadOnlyCollection<AccessoryBlueprint> Get(AccessoryField field)
        {
            if (_result.ContainsKey(field)) { return _result[field]; }

            if (_blueprints != null) { return _result[field] = _blueprints.Where(x => x.Field == field).ToList(); }

            var blueprints = new List<AccessoryBlueprint>
            {
                new("閃耀",
                    68,
                    AccessoryField.Earrings,
                    new EffectRandomContext[]
                    {
                        new(Static.Attack, 36, 321),
                        new(Static.Defense, 23, 534),
                        new(Static.AttackSpeedRate, .01m, .07m),
                        new(Static.Stamina, 4, 10),
                        new(Static.MoveSpaceRate, .01m, .07m),
                        new(Static.ExpVolumeRateEnemy, .02m, .15m),
                        new(Static.KillHPRecovery, 20, 180),
                        new(Static.SuperArmorBreakPowerRate, .02m, .08m),
                        new(Static.CooldownShorterRate, .01m, .05m),
                        new(Static.MoneyVolumeRateEnemy, .02m, .08m),
                        new(Static.SoulNovaVolumeRate, .01m, .04m),
                        new(Static.ExtraDamageRateAir, .02m, .12m),
                        new(Static.ExtraDamageRateFall, .02m, .12m)
                    },
                    4,
                    "暮光"),
                new("邊緣",
                    68,
                    AccessoryField.Amulet,
                    new EffectRandomContext[]
                    {
                        new(Static.Attack, 36, 321),
                        new(Static.Defense, 23, 534),
                        new(Static.AttackSpeedRate, .01m, .07m),
                        new(Static.Stamina, 4, 10),
                        new(Static.DamageReductionRate, .01m, .05m),
                        new(Static.ExpVolumeRateEnemy, .02m, .15m),
                        new(Static.KillHPRecovery, 20, 180),
                        new(Static.SuperArmorBreakPowerRate, .02m, .08m),
                        new(Static.CooldownShorterRate, .01m, .05m),
                        new(Static.MoneyVolumeRateEnemy, .02m, .08m),
                        new(Static.SoulNovaVolumeRate, .01m, .04m),
                        new(Static.ExtraDamageRateAir, .02m, .12m),
                        new(Static.ExtraDamageRateFall, .02m, .12m)
                    },
                    4,
                    "暮光")
            };
            var r68 = new AccessoryBlueprint("之冠I",
                68,
                AccessoryField.Ring,
                new EffectRandomContext[]
                {
                    new(Static.Attack, 19, 190),
                    new(Static.Defense, 16, 423),
                    new(Static.CriticalRate, .01m, .07m),
                    new(Static.CriticalDamage, 250, 694),
                    new(Static.Accuracy, 10, 108),
                    new(Static.Evade, 7, 36),
                    new(Static.DamageReductionRateBasic, .01m, .1m),
                    new(Static.DamageReductionRateBoss, .01m, .1m),
                    new(Static.DamageReductionRatePartialDamage, .02m, .12m),
                    new(Static.ExpVolumeRateEnemy, .02m, .15m),
                    new(Static.MoneyVolumeRateEnemy, .02m, .08m),
                    new(Static.SoulNovaVolumeRate, .01m, .04m)
                },
                4,
                "暮光");
            blueprints.Add(r68);
            blueprints.Add(r68 with {Name = "之冠II"});

            _blueprints = blueprints;
            return _result[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}