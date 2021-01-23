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
                new("未知的渴望",
                    PluginField.Weapon,
                    65,
                    1,
                    new RandomEffect[] {new(StaticEffectContext.Attack, 100, 800)}),
                new("未知的絕望",
                    PluginField.Weapon,
                    67,
                    1,
                    new RandomEffect[] {new(StaticEffectContext.Attack, 300, 1_000)}),
                new("淨化的聖巡",
                    PluginField.Gear,
                    65,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffectContext.Hp, 1_200, 3_000),
                        new(StaticEffectContext.Defense, 240, 960),
                        new(StaticEffectContext.DamageReductionRateBasic, .03m, .04m),
                        new(StaticEffectContext.DamageReductionRateBoss, .03m, .04m),
                        new(StaticEffectContext.Stamina, 1, 7),
                        new(StaticEffectContext.SoulNovaVolumeRate, .02m, .08m)
                    }),
                new("警戒的聖巡",
                    PluginField.Gear,
                    65,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffectContext.Accuracy, 48, 108),
                        new(StaticEffectContext.Attack, 250, 400),
                        new(StaticEffectContext.SuperArmorBreakPowerRate, .04m, .07m),
                        new(StaticEffectContext.ExtraDamageRateBasic, .03m, .05m),
                        new(StaticEffectContext.ExtraDamageRateBoss, .03m, .05m),
                        new(StaticEffectContext.DefenseBreakRate, .01m, .02m)
                    }),
                new("暗躍的聖巡",
                    PluginField.Gear,
                    65,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffectContext.CriticalRate, .01m, .02m),
                        new(StaticEffectContext.CriticalDamage, 300, 450),
                        new(StaticEffectContext.CriticalResistanceRate, .02m, .08m),
                        new(StaticEffectContext.Evade, 24, 59),
                        new(StaticEffectContext.ExpVolumeRateEnemy, .02m, .08m),
                        new(StaticEffectContext.MoneyVolumeRateEnemy, .02m, .08m)
                    }),
                new("黎明的聖巡",
                    PluginField.Gear,
                    68,
                    1,
                    new RandomEffect[]
                    {
                        new(StaticEffectContext.Hp, .05m, .1m),
                        new(StaticEffectContext.Defense, .07m, .15m),
                        new(StaticEffectContext.AttackSpeedRate, .01m, .02m),
                        new(StaticEffectContext.MoveSpaceRate, .01m, .02m),
                        new(StaticEffectContext.MoveSpaceRateBattle, .02m, .03m),
                        new(StaticEffectContext.MoveSpaceRateTown, .02m, .03m)
                    })
            };

            return PluginResult[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}