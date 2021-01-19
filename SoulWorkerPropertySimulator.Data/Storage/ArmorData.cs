using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class ArmorData
    {
        private static IReadOnlyCollection<ArmorBlueprint>? _blueprints;

        private static readonly Dictionary<ArmorField, IReadOnlyCollection<ArmorBlueprint>> _result = new();

        internal static IReadOnlyCollection<ArmorBlueprint> Get(ArmorField field)
        {
            if (_result.ContainsKey(field)) { return _result[field]; }

            if (_blueprints != null) { return _result[field] = _blueprints.Where(x => x.Field == field).ToList(); }

            var result = new List<ArmorBlueprint>();
            var weapon68 = new ArmorBlueprint("進階暮光流浪者",
                ArmorField.Weapon,
                68,
                ArmorRare.Legendary,
                4,
                new List<EffectRandomContext>
                {
                    new(new(Property.AttackSpeedRate), .01m, .06m),
                    new(new(Property.Accuracy), 16, 65),
                    new(new(Property.ExtraDamageRateBasic), .02m, .09m),
                    new(new(Property.ExtraDamageRateBoss), .02m, .09m),
                    new(new(Property.CriticalRate), .02m, .07m),
                    new(new(Property.CriticalDamage), 1_743, 1_885),
                    new(new(Property.SuperArmorBreakPowerRate), .02m, .11m),
                    new(new(Property.DefenseBreakRate), .01m, .06m),
                    new(new(Property.SoulNovaVolumeRate), .01m, .07m),
                    new(new(Property.KillHPRecovery), 28, 217)
                },
                3,
                Property.Attack,
                2175,
                3234,
                fixedEffects: new Effect[]
                {
                    new(new(Property.Attack), 3_726),
                    new(new(Property.AttackSpeedRate), .07m),
                    new(new(Property.ExtraDamageRateBoss), .3m),
                    new(new(Property.CriticalDamage), 2_000),
                    new(new(Property.Accuracy), -50)
                });
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
                ArmorRare.Legendary,
                4,
                new List<EffectRandomContext>
                {
                    new(new(Property.Attack), 36, 198),
                    new(new(Property.Accuracy), 7, 37),
                    new(new(Property.CriticalDamage), 140, 659),
                    new(new(Property.HP), 2_365, 11_100),
                    new(new(Property.CriticalRate), .01m, .07m),
                    new(new(Property.CooldownShorterRate), .01m, .05m),
                    new(new(Property.Defense), 66, 250),
                    new(new(Property.Evade), 14, 69),
                    new(new(Property.ExpVolumeRateEnemy), .02m, .12m),
                    new(new(Property.PartialDamageRate), .01m, .09m)
                },
                3,
                Property.Defense,
                2175,
                3234,
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitCommon, .1m, 2), .07m)}},
                    {6, new Effect[] {new(new(Property.DefenseRate), .36m)}},
                    {9, new Effect[] {new(new(Property.ExtraDamageRateBoss), .03m)}}
                },
                "進階暮光",
                new Effect[]
                {
                    new(new(Property.SoulNovaVolumeRate), .3m),
                    new(new(Property.DamageReductionRateBoss), .08m),
                    new(new(Property.Evade), -100)
                });
            result.Add(gear68);
            result.Add(gear68 with
            {
                Name = "海洛伊護肩",
                Field = ArmorField.Shoulder,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitBoss, .1m, 2), .06m)}},
                    {6, new Effect[] {new(new(Property.Evade), 120)}},
                    {9, new Effect[] {new(new(Property.Accuracy), 390)}}
                },
                FixedEffects = new Effect[]
                {
                    new(new(Property.DamageReductionRateCritical), .18m),
                    new(new(Property.Accuracy), 59),
                    new(new(Property.Stamina), -20)
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
                    {6, new Effect[] {new(new(Property.HP), 2_500)}},
                    {9, new Effect[] {new(new(Property.CriticalRate), .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(new(Property.HP), 5_994),
                    new(new(Property.KillHPRecovery), 80),
                    new(new(Property.Defense), -10000)
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
                    {6, new Effect[] {new(new(Property.DamageReductionRate), .06m)}},
                    {9, new Effect[] {new(new(Property.DefenseBreakRate), .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(new(Property.Evade), 89),
                    new(new(Property.MoveSpaceRate), .1m),
                    new(new(Property.DamageReductionRate), -.05m)
                }
            });

            _blueprints = result;
            return _result[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}