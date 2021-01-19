using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        new(new(Property.Attack), 36, 321),
                        new(new(Property.Defense), 23, 534),
                        new(new(Property.AttackSpeedRate), .01m, .07m),
                        new(new(Property.Stamina), 4, 10),
                        new(new(Property.MoveSpaceRate), .01m, .07m),
                        new(new(Property.ExpVolumeRateEnemy), .02m, .15m),
                        new(new(Property.KillHPRecovery), 20, 180),
                        new(new(Property.SuperArmorBreakPowerRate), .02m, .08m),
                        new(new(Property.CooldownShorterRate), .01m, .05m),
                        new(new(Property.MoneyVolumeRateEnemy), .02m, .08m),
                        new(new(Property.SoulNovaVolumeRate), .01m, .04m),
                        new(new(Property.ExtraDamageRateAir), .02m, .12m),
                        new(new(Property.ExtraDamageRateFall), .02m, .12m),
                    },
                    4,
                    "暮光"),
                new("邊緣",
                    68,
                    AccessoryField.Amulet,
                    new EffectRandomContext[]
                    {
                        new(new(Property.Attack), 36, 321),
                        new(new(Property.Defense), 23, 534),
                        new(new(Property.AttackSpeedRate), .01m, .07m),
                        new(new(Property.Stamina), 4, 10),
                        new(new(Property.DamageReductionRate), .01m, .05m),
                        new(new(Property.ExpVolumeRateEnemy), .02m, .15m),
                        new(new(Property.KillHPRecovery), 20, 180),
                        new(new(Property.SuperArmorBreakPowerRate), .02m, .08m),
                        new(new(Property.CooldownShorterRate), .01m, .05m),
                        new(new(Property.MoneyVolumeRateEnemy), .02m, .08m),
                        new(new(Property.SoulNovaVolumeRate), .01m, .04m),
                        new(new(Property.ExtraDamageRateAir), .02m, .12m),
                        new(new(Property.ExtraDamageRateFall), .02m, .12m),
                    },
                    4,
                    "暮光")
            };
            var r68 = new AccessoryBlueprint("之冠I",
                68,
                AccessoryField.Ring,
                new EffectRandomContext[]
                {
                    new(new(Property.Attack), 19, 190),
                    new(new(Property.Defense), 16, 423),
                    new(new(Property.CriticalRate), .01m, .07m),
                    new(new(Property.CriticalDamage), 250, 694),
                    new(new(Property.Accuracy), 10, 108),
                    new(new(Property.Evade), 7, 36),
                    new(new(Property.DamageReductionRateBasic), .01m, .1m),
                    new(new(Property.DamageReductionRateBoss), .01m, .1m),
                    new(new(Property.DamageReductionRatePartialDamage), .02m, .12m),
                    new(new(Property.ExpVolumeRateEnemy), .02m, .15m),
                    new(new(Property.MoneyVolumeRateEnemy), .02m, .08m),
                    new(new(Property.SoulNovaVolumeRate), .01m, .04m),
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