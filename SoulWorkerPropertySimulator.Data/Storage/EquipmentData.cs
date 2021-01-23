using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class EquipmentData
    {
        private static IReadOnlyCollection<EquipmentBlueprint>? _blueprints;

        private static readonly Dictionary<EquipmentField, IReadOnlyCollection<EquipmentBlueprint>> Result = new();

        internal static IReadOnlyCollection<EquipmentBlueprint> Get(EquipmentField field)
        {
            if (Result.ContainsKey(field)) { return Result[field]; }

            if (_blueprints != null) { return Result[field] = _blueprints.Where(x => x.Field == field).ToList(); }

            var result = new List<EquipmentBlueprint>();
            var weapon68 = new EquipmentBlueprint("進階暮光流浪者",
                EquipmentField.Weapon,
                68,
                3,
                new List<RandomEffect>
                {
                    new(StaticEffectContext.AttackSpeedRate, .01m, .06m),
                    new(StaticEffectContext.Accuracy, 16, 65),
                    new(StaticEffectContext.ExtraDamageRateBasic, .02m, .09m),
                    new(StaticEffectContext.ExtraDamageRateBoss, .02m, .09m),
                    new(StaticEffectContext.CriticalRate, .02m, .07m),
                    new(StaticEffectContext.CriticalDamage, 185, 1_743),
                    new(StaticEffectContext.SuperArmorBreakPowerRate, .02m, .11m),
                    new(StaticEffectContext.DefenseBreakRate, .01m, .06m),
                    new(StaticEffectContext.SoulNovaVolumeRate, .01m, .07m),
                    new(StaticEffectContext.KillHpRecovery, 28, 217)
                },
                4,
                new(StaticEffectContext.Attack, 2_175, 3_234),
                new Effect[]
                {
                    new(StaticEffectContext.Attack, 3_726),
                    new(StaticEffectContext.AttackSpeedRate, .07m),
                    new(StaticEffectContext.ExtraDamageRateBoss, .3m),
                    new(StaticEffectContext.CriticalDamage, 2_000),
                    new(StaticEffectContext.Accuracy, -50)
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

            var gear68 = new EquipmentBlueprint("鳶尾花頭盔",
                EquipmentField.Head,
                68,
                3,
                new List<RandomEffect>
                {
                    new(StaticEffectContext.Attack, 36, 198),
                    new(StaticEffectContext.Accuracy, 7, 37),
                    new(StaticEffectContext.CriticalDamage, 140, 659),
                    new(StaticEffectContext.Hp, 2_365, 11_100),
                    new(StaticEffectContext.CriticalRate, .01m, .07m),
                    new(StaticEffectContext.CooldownShorterRate, .01m, .05m),
                    new(StaticEffectContext.Defense, 66, 250),
                    new(StaticEffectContext.Evade, 14, 69),
                    new(StaticEffectContext.ExpVolumeRateEnemy, .02m, .12m),
                    new(StaticEffectContext.PartialDamageRate, .01m, .09m)
                },
                4,
                new(StaticEffectContext.Defense, 2_175, 3_234),
                new Effect[]
                {
                    new(StaticEffectContext.SoulNovaVolumeRate, .3m),
                    new(StaticEffectContext.DamageReductionRateBoss, .08m),
                    new(StaticEffectContext.Evade, -100)
                },
                ItemRare.Legendary,
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitCommon, .1m, 2), .07m)}},
                    {6, new Effect[] {new(StaticEffectContext.DefenseRate, .36m)}},
                    {9, new Effect[] {new(StaticEffectContext.ExtraDamageRateBoss, .03m)}}
                },
                "進階暮光");
            result.Add(gear68);
            result.Add(gear68 with
            {
                Name = "海洛伊護肩",
                Field = EquipmentField.Shoulder,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitBoss, .1m, 2), .06m)}},
                    {6, new Effect[] {new(StaticEffectContext.Evade, 120)}},
                    {9, new Effect[] {new(StaticEffectContext.Accuracy, 390)}}
                },
                FixedEffects = new Effect[]
                {
                    new(StaticEffectContext.DamageReductionRateCritical, .18m),
                    new(StaticEffectContext.Accuracy, 59),
                    new(StaticEffectContext.Stamina, -20)
                }
            });
            result.Add(gear68 with
            {
                Name = "之心胸甲",
                Field = EquipmentField.Chest,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        3, new Effect[] {new(new(Property.SoulGateRecoveryRate, Opportunity.UseAvoid, .05m), .12m)}
                    },
                    {6, new Effect[] {new(StaticEffectContext.Hp, 2_500)}},
                    {9, new Effect[] {new(StaticEffectContext.CriticalRate, .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(StaticEffectContext.Hp, 5_994),
                    new(StaticEffectContext.KillHpRecovery, 80),
                    new(StaticEffectContext.Defense, -10000)
                }
            });
            result.Add(gear68 with
            {
                Name = "歌頌護腿",
                Field = EquipmentField.Leg,
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        3,
                        new Effect[] {new(new(Property.CriticalDamage, Opportunity.SuperArmorBreak, .1m, 3), .65m)}
                    },
                    {6, new Effect[] {new(StaticEffectContext.DamageReductionRate, .06m)}},
                    {9, new Effect[] {new(StaticEffectContext.DefenseBreakRate, .06m)}}
                },
                FixedEffects = new Effect[]
                {
                    new(StaticEffectContext.Evade, 89),
                    new(StaticEffectContext.MoveSpaceRate, .1m),
                    new(StaticEffectContext.DamageReductionRate, -.05m)
                }
            });

            _blueprints = result;
            return Result[field] = _blueprints.Where(x => x.Field == field).ToList();
        }
    }
}