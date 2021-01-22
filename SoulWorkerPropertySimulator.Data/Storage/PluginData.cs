using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Plugins;
using SoulWorkerPropertySimulator.Types;

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
                new("未知的渴望", PluginField.Weapon, 65, 1, new RandomEffect[] {new(StaticEffect.Attack, 100, 800)}),
                new("未知的絕望", PluginField.Weapon, 67, 1, new RandomEffect[] {new(StaticEffect.Attack, 300, 1_000)}),
                new("淨化的聖巡",
                    PluginField.Gear,
                    65,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffect.Hp, 1_200, 3_000),
                        new(StaticEffect.Defense, 240, 960),
                        new(StaticEffect.DamageReductionRateBasic, .03m, .04m),
                        new(StaticEffect.DamageReductionRateBoss, .03m, .04m),
                        new(StaticEffect.Stamina, 1, 7),
                        new(StaticEffect.SoulNovaVolumeRate, .02m, .08m)
                    }),
                new("警戒的聖巡",
                    PluginField.Gear,
                    65,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffect.Accuracy, 48, 108),
                        new(StaticEffect.Attack, 250, 400),
                        new(StaticEffect.SuperArmorBreakPowerRate, .04m, .07m),
                        new(StaticEffect.ExtraDamageRateBasic, .03m, .05m),
                        new(StaticEffect.ExtraDamageRateBoss, .03m, .05m),
                        new(StaticEffect.DefenseBreakRate, .01m, .02m)
                    }),
                new("暗躍的聖巡",
                    PluginField.Gear,
                    65,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffect.CriticalRate, .01m, .02m),
                        new(StaticEffect.CriticalDamage, 300, 450),
                        new(StaticEffect.CriticalResistanceRate, .02m, .08m),
                        new(StaticEffect.Evade, 24, 59),
                        new(StaticEffect.ExpVolumeRateEnemy, .02m, .08m),
                        new(StaticEffect.MoneyVolumeRateEnemy, .02m, .08m)
                    }),
                new("黎明的聖巡",
                    PluginField.Gear,
                    68,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffect.Hp, .05m, .1m),
                        new(StaticEffect.Defense, .07m, .15m),
                        new(StaticEffect.AttackSpeedRate, .01m, .02m),
                        new(StaticEffect.MoveSpaceRate, .01m, .02m),
                        new(StaticEffect.MoveSpaceRateBattle, .02m, .03m),
                        new(StaticEffect.MoveSpaceRateTown, .02m, .03m)
                    })
            };

            return PluginResult[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}