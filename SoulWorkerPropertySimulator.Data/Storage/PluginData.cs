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
                new("未知的渴望", PluginField.Weapon, 65, new EffectRandomContext[] {new(Static.Attack, 100, 800)}, 1),
                new("未知的絕望", PluginField.Weapon, 67, new EffectRandomContext[] {new(Static.Attack, 300, 1_000)}, 1),
                new("淨化的聖巡",
                    PluginField.Gear,
                    65,
                    new EffectRandomContext[]
                    {
                        new(Static.Hp, 1_200, 3_000),
                        new(Static.Defense, 240, 960),
                        new(Static.DamageReductionRateBasic, .03m, .04m),
                        new(Static.DamageReductionRateBoss, .03m, .04m),
                        new(Static.Stamina, 1, 7),
                        new(Static.SoulNovaVolumeRate, .02m, .08m)
                    },
                    1),
                new("警戒的聖巡",
                    PluginField.Gear,
                    65,
                    new EffectRandomContext[]
                    {
                        new(Static.Accuracy, 48, 108),
                        new(Static.Attack, 250, 400),
                        new(Static.SuperArmorBreakPowerRate, .04m, .07m),
                        new(Static.ExtraDamageRateBasic, .03m, .05m),
                        new(Static.ExtraDamageRateBoss, .03m, .05m),
                        new(Static.DefenseBreakRate, .01m, .02m)
                    },
                    1),
                new("暗躍的聖巡",
                    PluginField.Gear,
                    65,
                    new EffectRandomContext[]
                    {
                        new(Static.CriticalRate, .01m, .02m),
                        new(Static.CriticalDamage, 300, 450),
                        new(Static.CriticalResistanceRate, .02m, .08m),
                        new(Static.Evade, 24, 59),
                        new(Static.ExpVolumeRateEnemy, .02m, .08m),
                        new(Static.MoneyVolumeRateEnemy, .02m, .08m)
                    },
                    1),
                new("黎明的聖巡",
                    PluginField.Gear,
                    68,
                    new EffectRandomContext[]
                    {
                        new(Static.Hp, .05m, .1m),
                        new(Static.Defense, .07m, .15m),
                        new(Static.AttackSpeedRate, .01m, .02m),
                        new(Static.MoveSpaceRate, .01m, .02m),
                        new(Static.MoveSpaceRateBattle, .02m, .03m),
                        new(Static.MoveSpaceRateTown, .02m, .03m)
                    },
                    1)
            };

            return PluginResult[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}