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
                    new(Static.AttackSpeedRate, .01m, .06m),
                    new(Static.Accuracy, 16, 65),
                    new(Static.ExtraDamageRateBasic, .02m, .09m),
                    new(Static.ExtraDamageRateBoss, .02m, .09m),
                    new(Static.CriticalRate, .02m, .07m),
                    new(Static.CriticalDamage, 1_743, 1_885),
                    new(Static.SuperArmorBreakPowerRate, .02m, .11m),
                    new(Static.DefenseBreakRate, .01m, .06m),
                    new(Static.SoulNovaVolumeRate, .01m, .07m),
                    new(Static.KillHpRecovery, 28, 217)
                },
                3,
                Property.Attack,
                2175,
                3234,
                fixedEffects: new Effect[]
                {
                    new(Static.Attack, 3_726),
                    new(Static.AttackSpeedRate, .07m),
                    new(Static.ExtraDamageRateBoss, .3m),
                    new(Static.CriticalDamage, 2_000),
                    new(Static.Accuracy, -50)
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
                    new(Static.Attack, 36, 198),
                    new(Static.Accuracy, 7, 37),
                    new(Static.CriticalDamage, 140, 659),
                    new(Static.Hp, 2_365, 11_100),
                    new(Static.CriticalRate, .01m, .07m),
                    new(Static.CooldownShorterRate, .01m, .05m),
                    new(Static.Defense, 66, 250),
                    new(Static.Evade, 14, 69),
                    new(Static.ExpVolumeRateEnemy, .02m, .12m),
                    new(Static.PartialDamageRate, .01m, .09m)
                },
                3,
                Property.Defense,
                2175,
                3234,
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Ppportunity.HitCommon, .1m, 2), .07m)}},
                    {6, new Effect[] {new(Static.DefenseRate, .36m)}},
                    {9, new Effect[] {new(Static.ExtraDamageRateBoss, .03m)}}
                },
                "進階暮光",
                new Effect[]
                {
                    new(Static.SoulNovaVolumeRate, .3m),
                    new(Static.DamageReductionRateBoss, .08m),
                    new(Static.Evade, -100)
                });
            result.Add(gear68);
            result.Add(gear68 with
            {
                Name = "海洛伊護肩",
                Field = ArmorField.Shoulder,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Ppportunity.HitBoss, .1m, 2), .06m)}},
                    {6, new Effect[] {new(Static.Evade, 120)}},
                    {9, new Effect[] {new(Static.Accuracy, 390)}}
                },
                FixedEffects = new Effect[]
                {
                    new(Static.DamageReductionRateCritical, .18m),
                    new(Static.Accuracy, 59),
                    new(Static.Stamina, -20)
                }
            });
            result.Add(gear68 with
            {
                Name = "之心胸甲",
                Field = ArmorField.Chest,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        3, new Effect[] {new(new(Property.SoulGateRecoveryRate, Ppportunity.UseAvoid, .05m), .12m)}
                    },
                    {6, new Effect[] {new(Static.Hp, 2_500)}},
                    {9, new Effect[] {new(Static.CriticalRate, .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(Static.Hp, 5_994), new(Static.KillHpRecovery, 80), new(Static.Defense, -10000)
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
                        new Effect[] {new(new(Property.CriticalDamage, Ppportunity.SuperArmorBreak, .1m, 3), .65m)}
                    },
                    {6, new Effect[] {new(Static.DamageReductionRate, .06m)}},
                    {9, new Effect[] {new(Static.DefenseBreakRate, .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(Static.Evade, 89),
                    new(Static.MoveSpaceRate, .1m),
                    new(Static.DamageReductionRate, -.05m)
                }
            });

            _blueprints = result;
            return _result[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}