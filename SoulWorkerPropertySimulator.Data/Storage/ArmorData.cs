using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class ArmorData
    {
        private static IReadOnlyCollection<ArmorBlueprint>? _blueprints;

        private static readonly Dictionary<ArmorField, IReadOnlyCollection<ArmorBlueprint>> Result = new();

        internal static IReadOnlyCollection<ArmorBlueprint> Get(ArmorField field)
        {
            if (Result.ContainsKey(field)) { return Result[field]; }

            if (_blueprints != null) { return Result[field] = _blueprints.Where(x => x.Field == field).ToList(); }

            var result = new List<ArmorBlueprint>();
            var weapon68 = new ArmorBlueprint("進階暮光流浪者",
                ArmorField.Weapon,
                68,
                3,
                new List<RandomEffect>
                {
                    new(StaticEffect.AttackSpeedRate, .01m, .06m),
                    new(StaticEffect.Accuracy, 16, 65),
                    new(StaticEffect.ExtraDamageRateBasic, .02m, .09m),
                    new(StaticEffect.ExtraDamageRateBoss, .02m, .09m),
                    new(StaticEffect.CriticalRate, .02m, .07m),
                    new(StaticEffect.CriticalDamage, 1_743, 1_885),
                    new(StaticEffect.SuperArmorBreakPowerRate, .02m, .11m),
                    new(StaticEffect.DefenseBreakRate, .01m, .06m),
                    new(StaticEffect.SoulNovaVolumeRate, .01m, .07m),
                    new(StaticEffect.KillHpRecovery, 28, 217)
                },
                4,
                new(StaticEffect.Attack, 2_175, 3_234),
                new Effect[]
                {
                    new(StaticEffect.Attack, 3_726),
                    new(StaticEffect.AttackSpeedRate, .07m),
                    new(StaticEffect.ExtraDamageRateBoss, .3m),
                    new(StaticEffect.CriticalDamage, 2_000),
                    new(StaticEffect.Accuracy, -50)
                },
                ItemRare.Legendary);
            result.Add(weapon68);
            result.Add(weapon68 with {Name = "進階暮光激鬥者"});
            result.Add(weapon68 with {Name = "進階暮光收割者"});
            result.Add(weapon68 with {Name = "進階暮光慈悲者"});
            result.Add(weapon68 with {Name = "進階暮光修行者"});
            result.Add(weapon68 with {Name = "進階暮光傾訴者"});
            result.Add(weapon68 with {Name = "進階暮光追蹤者"});
            result.Add(weapon68 with {Name = "進階暮光畸變者"});

            var gear68 = new ArmorBlueprint("鳶尾花頭盔",
                ArmorField.Head,
                68,
                3,
                new List<RandomEffect>
                {
                    new(StaticEffect.Attack, 36, 198),
                    new(StaticEffect.Accuracy, 7, 37),
                    new(StaticEffect.CriticalDamage, 140, 659),
                    new(StaticEffect.Hp, 2_365, 11_100),
                    new(StaticEffect.CriticalRate, .01m, .07m),
                    new(StaticEffect.CooldownShorterRate, .01m, .05m),
                    new(StaticEffect.Defense, 66, 250),
                    new(StaticEffect.Evade, 14, 69),
                    new(StaticEffect.ExpVolumeRateEnemy, .02m, .12m),
                    new(StaticEffect.PartialDamageRate, .01m, .09m)
                },
                4,
                new(StaticEffect.Defense, 2_175, 3_234),
                new Effect[]
                {
                    new(StaticEffect.SoulNovaVolumeRate, .3m),
                    new(StaticEffect.DamageReductionRateBoss, .08m),
                    new(StaticEffect.Evade, -100)
                },
                ItemRare.Legendary,
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitCommon, .1m, 2), .07m)}},
                    {6, new Effect[] {new(StaticEffect.DefenseRate, .36m)}},
                    {9, new Effect[] {new(StaticEffect.ExtraDamageRateBoss, .03m)}}
                },
                "進階暮光");
            result.Add(gear68);
            result.Add(gear68 with
            {
                Name = "海洛伊護肩",
                Field = ArmorField.Shoulder,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitBoss, .1m, 2), .06m)}},
                    {6, new Effect[] {new(StaticEffect.Evade, 120)}},
                    {9, new Effect[] {new(StaticEffect.Accuracy, 390)}}
                },
                FixedEffects = new Effect[]
                {
                    new(StaticEffect.DamageReductionRateCritical, .18m),
                    new(StaticEffect.Accuracy, 59),
                    new(StaticEffect.Stamina, -20)
                }
            });
            result.Add(gear68 with
            {
                Name = "之心胸甲",
                Field = ArmorField.Chest,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        3, new Effect[] {new(new(Property.SoulGateRecoveryRate, Opportunity.UseAvoid, .05m), .12m)}
                    },
                    {6, new Effect[] {new(StaticEffect.Hp, 2_500)}},
                    {9, new Effect[] {new(StaticEffect.CriticalRate, .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(StaticEffect.Hp, 5_994),
                    new(StaticEffect.KillHpRecovery, 80),
                    new(StaticEffect.Defense, -10000)
                }
            });
            result.Add(gear68 with
            {
                Name = "歌頌護腿",
                Field = ArmorField.Leg,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        3,
                        new Effect[] {new(new(Property.CriticalDamage, Opportunity.SuperArmorBreak, .1m, 3), .65m)}
                    },
                    {6, new Effect[] {new(StaticEffect.DamageReductionRate, .06m)}},
                    {9, new Effect[] {new(StaticEffect.DefenseBreakRate, .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(StaticEffect.Evade, 89),
                    new(StaticEffect.MoveSpaceRate, .1m),
                    new(StaticEffect.DamageReductionRate, -.05m)
                }
            });

            _blueprints = result;
            return Result[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}