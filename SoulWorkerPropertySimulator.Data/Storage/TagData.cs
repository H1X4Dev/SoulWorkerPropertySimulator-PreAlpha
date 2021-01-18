using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class TagData
    {
        private static IReadOnlyCollection<Tag>? _tags;

        private static readonly IDictionary<TagField, IReadOnlyCollection<Tag>> TagResult =
            new Dictionary<TagField, IReadOnlyCollection<Tag>>();

        public static IReadOnlyCollection<Tag> Get(TagField field)
        {
            if (TagResult.ContainsKey(field)) { return TagResult[field]; }

            if (_tags != null) { return TagResult[field] = _tags.Where(x => x.Field == field).ToList(); }

            var wi   = new Effect(new(Property.WeaponAttack), 0);
            var wr   = new Effect(new(Property.WeaponAttackRate), 0);
            var gi   = new Effect(new(Property.GearDefense), 0);
            var gr   = new Effect(new(Property.GearDefenseRate), 0);
            var tags = new List<Tag>();

            var iAttack = new Effect(new(Property.Attack), 0);
            tags.Add(new("異常的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 481}, iAttack with {Value = 112}}},
                    {TagRare.Legendary, new[] {wi with {Value = 359}, iAttack with {Value = 96}}},
                    {TagRare.Unique, new[] {wi with {Value = 252}, iAttack with {Value = 72}}},
                    {TagRare.Valuable, new[] {wi with {Value = 95}, iAttack with {Value = 48}}},
                    {TagRare.Magical, new[] {wi with {Value = 31}, iAttack with {Value = 24}}},
                    {TagRare.Common, new[] {wi with {Value = 16}, iAttack with {Value = 14}}}
                }));
            tags.Add(new("放置的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 541}, iAttack with {Value = 315}}},
                    {TagRare.Legendary, new[] {wi with {Value = 404}, iAttack with {Value = 252}}},
                    {TagRare.Unique, new[] {wi with {Value = 283}, iAttack with {Value = 189}}},
                    {TagRare.Valuable, new[] {wi with {Value = 107}, iAttack with {Value = 126}}},
                    {TagRare.Magical, new[] {wi with {Value = 35}, iAttack with {Value = 63}}},
                    {TagRare.Common, new[] {wi with {Value = 18}, iAttack with {Value = 32}}}
                }));
            var iAccuracy = new Effect(new(Property.Accuracy), 0);
            tags.Add(new("挑戰者的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .13m}, iAccuracy with {Value = 315}}},
                    {TagRare.Legendary, new[] {wr with {Value = .1m}, iAccuracy with {Value = 252}}},
                    {TagRare.Unique, new[] {wr with {Value = .09m}, iAccuracy with {Value = 189}}},
                    {TagRare.Valuable, new[] {wr with {Value = .06m}, iAccuracy with {Value = 126}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iAccuracy with {Value = 63}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iAccuracy with {Value = 32}}}
                }));
            tags.Add(new("剛直的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iAccuracy with {Value = 112}}},
                    {TagRare.Legendary, new[] {wr with {Value = .09m}, iAccuracy with {Value = 96}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iAccuracy with {Value = 72}}},
                    {TagRare.Valuable, new[] {wr with {Value = .05m}, iAccuracy with {Value = 48}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iAccuracy with {Value = 24}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iAccuracy with {Value = 14}}}
                }));
            var iAttackRate = new Effect(new(Property.AttackRate), 0);
            tags.Add(new("怪異的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 481}, iAttackRate with {Value = .15m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 359}, iAttackRate with {Value = .12m}}},
                    {TagRare.Unique, new[] {wi with {Value = 252}, iAttackRate with {Value = .1m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 95}, iAttackRate with {Value = .08m}}},
                    {TagRare.Magical, new[] {wi with {Value = 31}, iAttackRate with {Value = .05m}}},
                    {TagRare.Common, new[] {wi with {Value = 16}, iAttackRate with {Value = .03m}}}
                }));
            tags.Add(new("鋼鐵的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iAttackRate with {Value = .15m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .09m}, iAttackRate with {Value = .12m}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iAttackRate with {Value = .1m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .05m}, iAttackRate with {Value = .08m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iAttackRate with {Value = .05m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iAttackRate with {Value = .03m}}}
                }));
            var iCD = new Effect(new(Property.CriticalDamage), 0);
            tags.Add(new("粗糙的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 481}, iCD with {Value = 384}}},
                    {TagRare.Legendary, new[] {wi with {Value = 359}, iCD with {Value = 240}}},
                    {TagRare.Unique, new[] {wi with {Value = 252}, iCD with {Value = 200}}},
                    {TagRare.Valuable, new[] {wi with {Value = 95}, iCD with {Value = 140}}},
                    {TagRare.Magical, new[] {wi with {Value = 31}, iCD with {Value = 80}}},
                    {TagRare.Common, new[] {wi with {Value = 16}, iCD with {Value = 40}}}
                }));
            tags.Add(new("炙熱的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iCD with {Value = 384}}},
                    {TagRare.Legendary, new[] {wr with {Value = .09m}, iCD with {Value = 240}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iCD with {Value = 200}}},
                    {TagRare.Valuable, new[] {wr with {Value = .05m}, iCD with {Value = 140}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iCD with {Value = 80}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iCD with {Value = 40}}}
                }));
            var iCR = new Effect(new(Property.CriticalRate), 0);
            tags.Add(new("附加的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 481}, iCR with {Value = .07m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 359}, iCR with {Value = .05m}}},
                    {TagRare.Unique, new[] {wi with {Value = 252}, iCR with {Value = .04m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 95}, iCR with {Value = .03m}}},
                    {TagRare.Magical, new[] {wi with {Value = 31}, iCR with {Value = .02m}}},
                    {TagRare.Common, new[] {wi with {Value = 16}, iCR with {Value = .01m}}}
                }));
            tags.Add(new("火山的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iCR with {Value = .07m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .09m}, iCR with {Value = .05m}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iCR with {Value = .04m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .05m}, iCR with {Value = .03m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iCR with {Value = .02m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iCR with {Value = .01m}}}
                }));
            var iDB = new Effect(new(Property.DefenseBreakRate), 0);
            tags.Add(new("狂暴的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 481}, iDB with {Value = .04m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 359}, iDB with {Value = .04m}}},
                    {TagRare.Unique, new[] {wi with {Value = 252}, iDB with {Value = .03m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 95}, iDB with {Value = .02m}}},
                    {TagRare.Magical, new[] {wi with {Value = 31}, iDB with {Value = .01m}}},
                    {TagRare.Common, new[] {wi with {Value = 16}, iDB with {Value = .01m}}}
                }));
            tags.Add(new("刺眼的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iDB with {Value = .04m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .09m}, iDB with {Value = .04m}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iDB with {Value = .03m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .05m}, iDB with {Value = .02m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iDB with {Value = .01m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iDB with {Value = .01m}}}
                }));
            var iEDBasic = new Effect(new(Property.ExtraDamageRateBasic), 0);
            tags.Add(new("遺失的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 511}, iEDBasic with {Value = .12m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 381}, iEDBasic with {Value = .09m}}},
                    {TagRare.Unique, new[] {wi with {Value = 267}, iEDBasic with {Value = .06m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 101}, iEDBasic with {Value = .05m}}},
                    {TagRare.Magical, new[] {wi with {Value = 33}, iEDBasic with {Value = .03m}}},
                    {TagRare.Common, new[] {wi with {Value = 17}, iEDBasic with {Value = .01m}}}
                }));
            tags.Add(new("閃電的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iEDBasic with {Value = .12m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .1m}, iEDBasic with {Value = .09m}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iEDBasic with {Value = .06m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .06m}, iEDBasic with {Value = .05m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iEDBasic with {Value = .03m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iEDBasic with {Value = .01m}}}
                }));
            var iEDBoss = new Effect(new(Property.ExtraDamageRateBoss), 0);
            tags.Add(new("高喊的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 511}, iEDBoss with {Value = .12m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 381}, iEDBoss with {Value = .09m}}},
                    {TagRare.Unique, new[] {wi with {Value = 267}, iEDBoss with {Value = .06m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 101}, iEDBoss with {Value = .05m}}},
                    {TagRare.Magical, new[] {wi with {Value = 33}, iEDBoss with {Value = .03m}}},
                    {TagRare.Common, new[] {wi with {Value = 17}, iEDBoss with {Value = .01m}}}
                }));
            tags.Add(new("凌晨的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iEDBoss with {Value = .12m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .1m}, iEDBoss with {Value = .09m}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iEDBoss with {Value = .06m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .06m}, iEDBoss with {Value = .05m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iEDBoss with {Value = .03m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iEDBoss with {Value = .01m}}}
                }));
            var iEDGolden = new Effect(new(Property.ExtraDamageRateGolden), 0);
            tags.Add(new("假的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 481}, iEDGolden with {Value = .16m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 359}, iEDGolden with {Value = .12m}}},
                    {TagRare.Unique, new[] {wi with {Value = 252}, iEDGolden with {Value = .09m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 95}, iEDGolden with {Value = .06m}}},
                    {TagRare.Magical, new[] {wi with {Value = 31}, iEDGolden with {Value = .04m}}},
                    {TagRare.Common, new[] {wi with {Value = 16}, iEDGolden with {Value = .03m}}}
                }));
            tags.Add(new("假的(%)",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iEDGolden with {Value = .16m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .09m}, iEDGolden with {Value = .12m}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iEDGolden with {Value = .09m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .05m}, iEDGolden with {Value = .06m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iEDGolden with {Value = .04m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iEDGolden with {Value = .03m}}}
                }));
            var iEDPrimal = new Effect(new(Property.ExtraDamageRatePrimal), 0);
            tags.Add(new("傲慢的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 481}, iEDPrimal with {Value = .16m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 359}, iEDPrimal with {Value = .12m}}},
                    {TagRare.Unique, new[] {wi with {Value = 252}, iEDPrimal with {Value = .09m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 95}, iEDPrimal with {Value = .06m}}},
                    {TagRare.Magical, new[] {wi with {Value = 31}, iEDPrimal with {Value = .04m}}},
                    {TagRare.Common, new[] {wi with {Value = 16}, iEDPrimal with {Value = .03m}}}
                }));
            tags.Add(new("傲慢的(%)",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .12m}, iEDPrimal with {Value = .16m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .09m}, iEDPrimal with {Value = .12m}}},
                    {TagRare.Unique, new[] {wr with {Value = .08m}, iEDPrimal with {Value = .09m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .05m}, iEDPrimal with {Value = .06m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iEDPrimal with {Value = .04m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iEDPrimal with {Value = .03m}}}
                }));
            var iHP = new Effect(new(Property.HP), 0);
            tags.Add(new("慈悲的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 541}, iHP with {Value = 1_800}}},
                    {TagRare.Legendary, new[] {wi with {Value = 404}, iHP with {Value = 1_260}}},
                    {TagRare.Unique, new[] {wi with {Value = 283}, iHP with {Value = 810}}},
                    {TagRare.Valuable, new[] {wi with {Value = 107}, iHP with {Value = 450}}},
                    {TagRare.Magical, new[] {wi with {Value = 35}, iHP with {Value = 225}}},
                    {TagRare.Common, new[] {wi with {Value = 18}, iHP with {Value = 135}}}
                }));
            tags.Add(new("執著的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .13m}, iHP with {Value = 1_800}}},
                    {TagRare.Legendary, new[] {wr with {Value = .1m}, iHP with {Value = 1_260}}},
                    {TagRare.Unique, new[] {wr with {Value = .09m}, iHP with {Value = 810}}},
                    {TagRare.Valuable, new[] {wr with {Value = .06m}, iHP with {Value = 450}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iHP with {Value = 225}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iHP with {Value = 135}}}
                }));
            var iMoveSpace = new Effect(new(Property.MoveSpaceRate), 0);
            tags.Add(new("贖罪的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 541}, iMoveSpace with {Value = .05m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 404}, iMoveSpace with {Value = .04m}}},
                    {TagRare.Unique, new[] {wi with {Value = 283}, iMoveSpace with {Value = .03m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 107}, iMoveSpace with {Value = .02m}}},
                    {TagRare.Magical, new[] {wi with {Value = 35}, iMoveSpace with {Value = .01m}}},
                    {TagRare.Common, new[] {wi with {Value = 18}, iMoveSpace with {Value = .01m}}}
                }));
            tags.Add(new("多雲的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .13m}, iMoveSpace with {Value = .05m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .1m}, iMoveSpace with {Value = .04m}}},
                    {TagRare.Unique, new[] {wr with {Value = .09m}, iMoveSpace with {Value = .03m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .06m}, iMoveSpace with {Value = .02m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iMoveSpace with {Value = .01m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iMoveSpace with {Value = .01m}}}
                }));
            var iPDamage = new Effect(new(Property.PartialDamageRate), 0);
            tags.Add(new("生銹的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 662}, iPDamage with {Value = .55m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 493}, iPDamage with {Value = .44m}}},
                    {TagRare.Unique, new[] {wi with {Value = 346}, iPDamage with {Value = .33m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 130}, iPDamage with {Value = .22m}}},
                    {TagRare.Magical, new[] {wi with {Value = 42}, iPDamage with {Value = .11m}}},
                    {TagRare.Common, new[] {wi with {Value = 22}, iPDamage with {Value = .06m}}}
                }));
            tags.Add(new("螺旋的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .16m}, iPDamage with {Value = .55m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .13m}, iPDamage with {Value = .44m}}},
                    {TagRare.Unique, new[] {wr with {Value = .1m}, iPDamage with {Value = .33m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .07m}, iPDamage with {Value = .22m}}},
                    {TagRare.Magical, new[] {wr with {Value = .05m}, iPDamage with {Value = .11m}}},
                    {TagRare.Common, new[] {wr with {Value = .03m}, iPDamage with {Value = .06m}}}
                }));
            var iStamina = new Effect(new(Property.Stamina), 0);
            tags.Add(new("疲倦者的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 541}, iStamina with {Value = 6}}},
                    {TagRare.Legendary, new[] {wi with {Value = 404}, iStamina with {Value = 5}}},
                    {TagRare.Unique, new[] {wi with {Value = 283}, iStamina with {Value = 4}}},
                    {TagRare.Valuable, new[] {wi with {Value = 107}, iStamina with {Value = 3}}},
                    {TagRare.Magical, new[] {wi with {Value = 35}, iStamina with {Value = 2}}},
                    {TagRare.Common, new[] {wi with {Value = 18}, iStamina with {Value = 1}}}
                }));
            tags.Add(new("幹練的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .13m}, iStamina with {Value = 6}}},
                    {TagRare.Legendary, new[] {wr with {Value = .1m}, iStamina with {Value = 5}}},
                    {TagRare.Unique, new[] {wr with {Value = .09m}, iStamina with {Value = 4}}},
                    {TagRare.Valuable, new[] {wr with {Value = .06m}, iStamina with {Value = 3}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iStamina with {Value = 2}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iStamina with {Value = 1}}}
                }));
            var iSABreak = new Effect(new(Property.SuperArmorBreakPowerRate), 0);
            tags.Add(new("激流的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wi with {Value = 601}, iSABreak with {Value = .22m}}},
                    {TagRare.Legendary, new[] {wi with {Value = 448}, iSABreak with {Value = .16m}}},
                    {TagRare.Unique, new[] {wi with {Value = 314}, iSABreak with {Value = .12m}}},
                    {TagRare.Valuable, new[] {wi with {Value = 118}, iSABreak with {Value = .08m}}},
                    {TagRare.Magical, new[] {wi with {Value = 38}, iSABreak with {Value = .05m}}},
                    {TagRare.Common, new[] {wi with {Value = 20}, iSABreak with {Value = .03m}}}
                }));
            tags.Add(new("颱風的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {wr with {Value = .14m}, iSABreak with {Value = .22m}}},
                    {TagRare.Legendary, new[] {wr with {Value = .11m}, iSABreak with {Value = .16m}}},
                    {TagRare.Unique, new[] {wr with {Value = .09m}, iSABreak with {Value = .12m}}},
                    {TagRare.Valuable, new[] {wr with {Value = .06m}, iSABreak with {Value = .08m}}},
                    {TagRare.Magical, new[] {wr with {Value = .04m}, iSABreak with {Value = .05m}}},
                    {TagRare.Common, new[] {wr with {Value = .02m}, iSABreak with {Value = .03m}}}
                }));


            var iDefense = new Effect(new(Property.Defense), 0);
            tags.Add(new("異常的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 368}, iDefense with {Value = 28}}},
                    {TagRare.Legendary, new[] {gi with {Value = 274}, iDefense with {Value = 23}}},
                    {TagRare.Unique, new[] {gi with {Value = 192}, iDefense with {Value = 17}}},
                    {TagRare.Valuable, new[] {gi with {Value = 72}, iDefense with {Value = 11}}},
                    {TagRare.Magical, new[] {gi with {Value = 23}, iDefense with {Value = 6}}},
                    {TagRare.Common, new[] {gi with {Value = 12}, iDefense with {Value = 3}}}
                }));
            tags.Add(new("韌性的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .06m}, iDefense with {Value = 28}}},
                    {TagRare.Legendary, new[] {gi with {Value = .05m}, iDefense with {Value = 23}}},
                    {TagRare.Unique, new[] {gi with {Value = .04m}, iDefense with {Value = 17}}},
                    {TagRare.Valuable, new[] {gi with {Value = .03m}, iDefense with {Value = 11}}},
                    {TagRare.Magical, new[] {gi with {Value = .02m}, iDefense with {Value = 6}}},
                    {TagRare.Common, new[] {gi with {Value = .01m}, iDefense with {Value = 3}}}
                }));
            tags.Add(new("火花的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 368}, iCD with {Value = 158}}},
                    {TagRare.Legendary, new[] {gi with {Value = 274}, iCD with {Value = 126}}},
                    {TagRare.Unique, new[] {gi with {Value = 192}, iCD with {Value = 95}}},
                    {TagRare.Valuable, new[] {gi with {Value = 72}, iCD with {Value = 63}}},
                    {TagRare.Magical, new[] {gi with {Value = 23}, iCD with {Value = 32}}},
                    {TagRare.Common, new[] {gi with {Value = 12}, iCD with {Value = 11}}}
                }));
            tags.Add(new("混亂的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .06m}, iCD with {Value = 158}}},
                    {TagRare.Legendary, new[] {gi with {Value = .05m}, iCD with {Value = 126}}},
                    {TagRare.Unique, new[] {gi with {Value = .04m}, iCD with {Value = 95}}},
                    {TagRare.Valuable, new[] {gi with {Value = .03m}, iCD with {Value = 63}}},
                    {TagRare.Magical, new[] {gi with {Value = .02m}, iCD with {Value = 32}}},
                    {TagRare.Common, new[] {gi with {Value = .01m}, iCD with {Value = 11}}}
                }));
            var iCResist = new Effect(new(Property.CriticalResistanceRate), 0);
            tags.Add(new("受詛咒的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 408}, iCResist with {Value = .05m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 304}, iCResist with {Value = .04m}}},
                    {TagRare.Unique, new[] {gi with {Value = 213}, iCResist with {Value = .03m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 80}, iCResist with {Value = .02m}}},
                    {TagRare.Magical, new[] {gi with {Value = 25}, iCResist with {Value = .01m}}}
                }));
            tags.Add(new("本能的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .06m}, iCResist with {Value = .05m}}},
                    {TagRare.Legendary, new[] {gi with {Value = .05m}, iCResist with {Value = .04m}}},
                    {TagRare.Unique, new[] {gi with {Value = .04m}, iCResist with {Value = .03m}}},
                    {TagRare.Valuable, new[] {gi with {Value = .03m}, iCResist with {Value = .02m}}},
                    {TagRare.Magical, new[] {gi with {Value = .02m}, iCResist with {Value = .01m}}}
                }));
            var iDRBasic = new Effect(new(Property.DamageReductionRateBasic), 0);
            tags.Add(new("黎明的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 347}, iDRBasic with {Value = .03m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 259}, iDRBasic with {Value = .02m}}},
                    {TagRare.Unique, new[] {gi with {Value = 182}, iDRBasic with {Value = .01m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 68}, iDRBasic with {Value = .01m}}}
                }));
            tags.Add(new("不屈的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .06m}, iDRBasic with {Value = .03m}}},
                    {TagRare.Legendary, new[] {gi with {Value = .05m}, iDRBasic with {Value = .02m}}},
                    {TagRare.Unique, new[] {gi with {Value = .04m}, iDRBasic with {Value = .01m}}},
                    {TagRare.Valuable, new[] {gi with {Value = .03m}, iDRBasic with {Value = .01m}}}
                }));
            var iDRBoss = new Effect(new(Property.DamageReductionRateBoss), 0);
            tags.Add(new("悲鳴的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 347}, iDRBoss with {Value = .03m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 259}, iDRBoss with {Value = .02m}}},
                    {TagRare.Unique, new[] {gi with {Value = 182}, iDRBoss with {Value = .01m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 68}, iDRBoss with {Value = .01m}}}
                }));
            tags.Add(new("守護的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .06m}, iDRBoss with {Value = .03m}}},
                    {TagRare.Legendary, new[] {gi with {Value = .05m}, iDRBoss with {Value = .02m}}},
                    {TagRare.Unique, new[] {gi with {Value = .04m}, iDRBoss with {Value = .01m}}},
                    {TagRare.Valuable, new[] {gi with {Value = .03m}, iDRBoss with {Value = .01m}}}
                }));
            var iDRPart = new Effect(new(Property.DamageReductionRatePartialDamage), 0);
            tags.Add(new("無謀的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 449}, iDRPart with {Value = .15m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 335}, iDRPart with {Value = .11m}}},
                    {TagRare.Unique, new[] {gi with {Value = 235}, iDRPart with {Value = .08m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 88}, iDRPart with {Value = .05m}}},
                    {TagRare.Magical, new[] {gi with {Value = 28}, iDRPart with {Value = .03m}}},
                    {TagRare.Common, new[] {gi with {Value = 15}, iDRPart with {Value = .02m}}}
                }));
            tags.Add(new("光暈的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .07m}, iDRPart with {Value = .15m}}},
                    {TagRare.Legendary, new[] {gi with {Value = .06m}, iDRPart with {Value = .11m}}},
                    {TagRare.Unique, new[] {gi with {Value = .05m}, iDRPart with {Value = .08m}}},
                    {TagRare.Valuable, new[] {gi with {Value = .04m}, iDRPart with {Value = .05m}}},
                    {TagRare.Magical, new[] {gi with {Value = .03m}, iDRPart with {Value = .03m}}},
                    {TagRare.Common, new[] {gi with {Value = .02m}, iDRPart with {Value = .02m}}}
                }));
            var iDefenseR = new Effect(new(Property.DefenseRate), 0);
            tags.Add(new("怪異的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 327}, iDefenseR with {Value = .09m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 244}, iDefenseR with {Value = .07m}}},
                    {TagRare.Unique, new[] {gi with {Value = 171}, iDefenseR with {Value = .05m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 64}, iDefenseR with {Value = .04m}}},
                    {TagRare.Magical, new[] {gi with {Value = 20}, iDefenseR with {Value = .02m}}},
                    {TagRare.Common, new[] {gi with {Value = 11}, iDefenseR with {Value = .01m}}}
                }));
            tags.Add(new("銅牆鐵壁的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .05m}, iDefenseR with {Value = .09m}}},
                    {TagRare.Legendary, new[] {gi with {Value = .04m}, iDefenseR with {Value = .07m}}},
                    {TagRare.Unique, new[] {gi with {Value = .04m}, iDefenseR with {Value = .05m}}},
                    {TagRare.Valuable, new[] {gi with {Value = .03m}, iDefenseR with {Value = .04m}}},
                    {TagRare.Magical, new[] {gi with {Value = .02m}, iDefenseR with {Value = .02m}}},
                    {TagRare.Common, new[] {gi with {Value = .01m}, iDefenseR with {Value = .01m}}}
                }));
            var iEvade = new Effect(new(Property.Evade), 0);
            tags.Add(new("探索的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 388}, iEvade with {Value = 59}}},
                    {TagRare.Legendary, new[] {gi with {Value = 289}, iEvade with {Value = 48}}},
                    {TagRare.Unique, new[] {gi with {Value = 203}, iEvade with {Value = 36}}},
                    {TagRare.Valuable, new[] {gi with {Value = 76}, iEvade with {Value = 24}}},
                    {TagRare.Magical, new[] {gi with {Value = 24}, iEvade with {Value = 12}}},
                    {TagRare.Common, new[] {gi with {Value = 13}, iEvade with {Value = 6}}}
                }));
            tags.Add(new("完美的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = .06m}, iEvade with {Value = 59}}},
                    {TagRare.Legendary, new[] {gi with {Value = .05m}, iEvade with {Value = 48}}},
                    {TagRare.Unique, new[] {gi with {Value = .04m}, iEvade with {Value = 36}}},
                    {TagRare.Valuable, new[] {gi with {Value = .03m}, iEvade with {Value = 24}}},
                    {TagRare.Magical, new[] {gi with {Value = .02m}, iEvade with {Value = 12}}},
                    {TagRare.Common, new[] {gi with {Value = .01m}, iEvade with {Value = 6}}}
                }));
            var iExp = new Effect(new(Property.ExpVolumeRateEnemy), 0);
            tags.Add(new("偉大的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 449}, iExp with {Value = .44m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 335}, iExp with {Value = .33m}}},
                    {TagRare.Unique, new[] {gi with {Value = 235}, iExp with {Value = .22m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 88}, iExp with {Value = .17m}}},
                    {TagRare.Magical, new[] {gi with {Value = 28}, iExp with {Value = .11m}}},
                    {TagRare.Common, new[] {gi with {Value = 15}, iExp with {Value = .06m}}}
                }));
            tags.Add(new("旅者的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gr with {Value = .07m}, iExp with {Value = .44m}}},
                    {TagRare.Legendary, new[] {gr with {Value = .06m}, iExp with {Value = .33m}}},
                    {TagRare.Unique, new[] {gr with {Value = .05m}, iExp with {Value = .22m}}},
                    {TagRare.Valuable, new[] {gr with {Value = .04m}, iExp with {Value = .17m}}},
                    {TagRare.Magical, new[] {gr with {Value = .03m}, iExp with {Value = .11m}}},
                    {TagRare.Common, new[] {gr with {Value = .02m}, iExp with {Value = .06m}}}
                }));
            tags.Add(new("基礎的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 327}, iHP with {Value = 320}}},
                    {TagRare.Legendary, new[] {gi with {Value = 244}, iHP with {Value = 240}}},
                    {TagRare.Unique, new[] {gi with {Value = 171}, iHP with {Value = 192}}},
                    {TagRare.Valuable, new[] {gi with {Value = 64}, iHP with {Value = 144}}},
                    {TagRare.Magical, new[] {gi with {Value = 20}, iHP with {Value = 100}}},
                    {TagRare.Common, new[] {gi with {Value = 11}, iHP with {Value = 60}}}
                }));
            tags.Add(new("海邊的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gr with {Value = .05m}, iHP with {Value = 320}}},
                    {TagRare.Legendary, new[] {gr with {Value = .04m}, iHP with {Value = 240}}},
                    {TagRare.Unique, new[] {gr with {Value = .04m}, iHP with {Value = 192}}},
                    {TagRare.Valuable, new[] {gr with {Value = .03m}, iHP with {Value = 144}}},
                    {TagRare.Magical, new[] {gr with {Value = .02m}, iHP with {Value = 100}}},
                    {TagRare.Common, new[] {gr with {Value = .01m}, iHP with {Value = 60}}}
                }));
            var iKill = new Effect(new(Property.KillHPRecovery), 0);
            tags.Add(new("霸氣的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 408}, iKill with {Value = 500}}},
                    {TagRare.Legendary, new[] {gi with {Value = 304}, iKill with {Value = 350}}},
                    {TagRare.Unique, new[] {gi with {Value = 213}, iKill with {Value = 230}}},
                    {TagRare.Valuable, new[] {gi with {Value = 80}, iKill with {Value = 140}}},
                    {TagRare.Magical, new[] {gi with {Value = 25}, iKill with {Value = 65}}},
                    {TagRare.Common, new[] {gi with {Value = 13}, iKill with {Value = 30}}}
                }));
            tags.Add(new("異能力者的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gr with {Value = .06m}, iKill with {Value = 500}}},
                    {TagRare.Legendary, new[] {gr with {Value = .05m}, iKill with {Value = 350}}},
                    {TagRare.Unique, new[] {gr with {Value = .04m}, iKill with {Value = 230}}},
                    {TagRare.Valuable, new[] {gr with {Value = .03m}, iKill with {Value = 140}}},
                    {TagRare.Magical, new[] {gr with {Value = .02m}, iKill with {Value = 65}}},
                    {TagRare.Common, new[] {gr with {Value = .01m}, iKill with {Value = 30}}}
                }));
            var iMoney = new Effect(new(Property.MoneyVolumeRateEnemy), 0);
            tags.Add(new("和睦的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 449}, iMoney with {Value = .15m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 335}, iMoney with {Value = .11m}}},
                    {TagRare.Unique, new[] {gi with {Value = 235}, iMoney with {Value = .09m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 88}, iMoney with {Value = .07m}}},
                    {TagRare.Magical, new[] {gi with {Value = 28}, iMoney with {Value = .05m}}},
                    {TagRare.Common, new[] {gi with {Value = 15}, iMoney with {Value = .03m}}}
                }));
            tags.Add(new("樸素的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gr with {Value = .07m}, iMoney with {Value = .15m}}},
                    {TagRare.Legendary, new[] {gr with {Value = .06m}, iMoney with {Value = .11m}}},
                    {TagRare.Unique, new[] {gr with {Value = .05m}, iMoney with {Value = .09m}}},
                    {TagRare.Valuable, new[] {gr with {Value = .04m}, iMoney with {Value = .07m}}},
                    {TagRare.Magical, new[] {gr with {Value = .03m}, iMoney with {Value = .05m}}},
                    {TagRare.Common, new[] {gr with {Value = .02m}, iMoney with {Value = .03m}}}
                }));
            var iSoulGate = new Effect(new(Property.SoulGateConsumptionReducedRate), 0);
            tags.Add(new("非凡的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 449}, iSoulGate with {Value = .03m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 335}, iSoulGate with {Value = .03m}}},
                    {TagRare.Unique, new[] {gi with {Value = 235}, iSoulGate with {Value = .02m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 88}, iSoulGate with {Value = .02m}}}
                }));
            tags.Add(new("鬥志的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gr with {Value = .07m}, iSoulGate with {Value = .03m}}},
                    {TagRare.Legendary, new[] {gr with {Value = .06m}, iSoulGate with {Value = .03m}}},
                    {TagRare.Unique, new[] {gr with {Value = .05m}, iSoulGate with {Value = .02m}}},
                    {TagRare.Valuable, new[] {gr with {Value = .04m}, iSoulGate with {Value = .02m}}}
                }));
            var iSoulNova = new Effect(new(Property.SoulNovaVolumeRate), 0);
            tags.Add(new("安平的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 388}, iSoulNova with {Value = .07m}}},
                    {TagRare.Legendary, new[] {gi with {Value = 289}, iSoulNova with {Value = .06m}}},
                    {TagRare.Unique, new[] {gi with {Value = 203}, iSoulNova with {Value = .04m}}},
                    {TagRare.Valuable, new[] {gi with {Value = 76}, iSoulNova with {Value = .03m}}},
                    {TagRare.Magical, new[] {gi with {Value = 24}, iSoulNova with {Value = .01m}}}
                }));
            tags.Add(new("野生的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gr with {Value = .06m}, iSoulNova with {Value = .07m}}},
                    {TagRare.Legendary, new[] {gr with {Value = .05m}, iSoulNova with {Value = .06m}}},
                    {TagRare.Unique, new[] {gr with {Value = .04m}, iSoulNova with {Value = .04m}}},
                    {TagRare.Valuable, new[] {gr with {Value = .03m}, iSoulNova with {Value = .03m}}},
                    {TagRare.Magical, new[] {gr with {Value = .02m}, iSoulNova with {Value = .01m}}}
                }));
            tags.Add(new("寡言的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gi with {Value = 368}, iStamina with {Value = 3}}},
                    {TagRare.Legendary, new[] {gi with {Value = 274}, iStamina with {Value = 2}}},
                    {TagRare.Unique, new[] {gi with {Value = 192}, iStamina with {Value = 1}}},
                    {TagRare.Valuable, new[] {gi with {Value = 72}, iStamina with {Value = 1}}}
                }));
            tags.Add(new("閃光的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {gr with {Value = .06m}, iStamina with {Value = 3}}},
                    {TagRare.Legendary, new[] {gr with {Value = .05m}, iStamina with {Value = 2}}},
                    {TagRare.Unique, new[] {gr with {Value = .04m}, iStamina with {Value = 1}}},
                    {TagRare.Valuable, new[] {gr with {Value = .03m}, iStamina with {Value = 1}}}
                }));

            _tags = tags;
            return TagResult[field] = tags.Where(x => x.Field == field).ToList();
        }
    }
}