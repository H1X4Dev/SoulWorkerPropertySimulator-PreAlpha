using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class PluginData
    {
        private static IReadOnlyCollection<PluginBlueprint>? _blueprints;

        private static readonly Dictionary<PluginField, IReadOnlyCollection<PluginBlueprint>> PluginResult = new();

        internal static IReadOnlyCollection<PluginBlueprint> Get(PluginField field)
        {
            if (PluginResult.ContainsKey(field)) { return PluginResult[field]; }

            if (_blueprints != null) { return PluginResult[field] = _blueprints.Where(x => x.Field == field).ToList(); }

            _blueprints = new List<PluginBlueprint>
            {
                new("未知的渴望",
                    PluginField.Weapon,
                    65,
                    new EffectRandomContext[] {new(new(Property.Attack), 100, 800)},
                    1),
                new("未知的絕望",
                    PluginField.Weapon,
                    67,
                    new EffectRandomContext[] {new(new(Property.Attack), 300, 1_000)},
                    1),
                new("淨化的聖巡",
                    PluginField.Gear,
                    65,
                    new EffectRandomContext[]
                    {
                        new(new(Property.HP), 1_200, 3_000),
                        new(new(Property.Defense), 240, 960),
                        new(new(Property.DamageReductionRateBasic), .03m, .04m),
                        new(new(Property.DamageReductionRateBoss), .03m, .04m),
                        new(new(Property.Stamina), 1, 7),
                        new(new(Property.SoulNovaVolumeRate), .02m, .08m)
                    },
                    1),
                new("警戒的聖巡",
                    PluginField.Gear,
                    65,
                    new EffectRandomContext[]
                    {
                        new(new(Property.Accuracy), 48, 108),
                        new(new(Property.Attack), 250, 400),
                        new(new(Property.SuperArmorBreakPowerRate), .04m, .07m),
                        new(new(Property.ExtraDamageRateBasic), .03m, .05m),
                        new(new(Property.ExtraDamageRateBoss), .03m, .05m),
                        new(new(Property.DefenseBreakRate), .01m, .02m)
                    },
                    1),
                new("暗躍的聖巡",
                    PluginField.Gear,
                    65,
                    new EffectRandomContext[]
                    {
                        new(new(Property.CriticalRate), .01m, .02m),
                        new(new(Property.CriticalDamage), 300, 450),
                        new(new(Property.CriticalResistanceRate), .02m, .08m),
                        new(new(Property.Evade), 24, 59),
                        new(new(Property.ExpVolumeRateEnemy), .02m, .08m),
                        new(new(Property.MoneyVolumeRateEnemy), .02m, .08m)
                    },
                    1),
                new("黎明的聖巡",
                    PluginField.Gear,
                    68,
                    new EffectRandomContext[]
                    {
                        new(new(Property.HP), .05m, .1m),
                        new(new(Property.Defense), .07m, .15m),
                        new(new(Property.AttackSpeedRate), .01m, .02m),
                        new(new(Property.MoveSpaceRate), .01m, .02m),
                        new(new(Property.MoveSpaceRateBattle), .02m, .03m),
                        new(new(Property.MoveSpaceRateTown), .02m, .03m)
                    },
                    1)
            };

            return PluginResult[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}