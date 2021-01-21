using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        private static Brooches _sdA1;
        private static Brooches _sdA2;
        private static Brooches _sdA3;
        private static Brooches _sdA4;
        private static Brooches _sdA5;
        private static Brooches _sdA6;
        private static Brooches _sdA7;
        private static Brooches _sdA8;
        private static Brooches _sdA9;
        private static Brooches _sdA10;
        private static Brooches _sdA11;
        private static Brooches _sdA12;
        private static Brooches _sdA13;
        private static Brooches _sdA14;
        private static Brooches _sdA15;

        private static Brooches _sdD1;
        private static Brooches _sdD2;
        private static Brooches _sdD3;
        private static Brooches _sdD4;
        private static Brooches _sdD5;
        private static Brooches _sdD6;
        private static Brooches _sdD7;
        private static Brooches _sdD8;
        private static Brooches _sdD9;
        private static Brooches _sdD10;
        private static Brooches _sdD11;
        private static Brooches _sdD12;
        private static Brooches _sdD13;
        private static Brooches _sdD14;
        private static Brooches _sdD15;

        private static Brooches _sdE1;
        private static Brooches _sdE2;
        private static Brooches _sdE3;
        private static Brooches _sdE4;
        private static Brooches _sdE5;
        private static Brooches _sdE6;
        private static Brooches _sdE7;
        private static Brooches _sdE8;
        private static Brooches _sdE9;
        private static Brooches _sdE10;
        private static Brooches _sdE11;
        private static Brooches _sdE12;
        private static Brooches _sdE13;
        private static Brooches _sdE14;
        private static Brooches _sdE15;

        #region

        private static void SetupSd()
        {
            #region Attack

            _sdA1 = new("鷹眼",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Accuracy, 52)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Accuracy, 42)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Accuracy, 31)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Accuracy, 21)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Accuracy, 10)}}
                });

            _sdA2 = new("致命",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {CriticalDamage700}},
                    {BroochesRare.Giga, new[] {CriticalDamage560}},
                    {BroochesRare.Mega, new[] {CriticalDamage420}},
                    {BroochesRare.Kilo, new[] {CriticalDamage280}},
                    {BroochesRare.Byte, new[] {CriticalDamage140}}
                });

            _sdA3 = new("破碎",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {SuperArmorBreakPowerRate01}},
                    {BroochesRare.Giga, new[] {SuperArmorBreakPowerRate008}},
                    {BroochesRare.Mega, new[] {SuperArmorBreakPowerRate006}},
                    {BroochesRare.Kilo, new[] {SuperArmorBreakPowerRate004}},
                    {BroochesRare.Byte, new[] {SuperArmorBreakPowerRate002}}
                });

            _sdA4 = new("熔解",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {DefenseBreakRate005}},
                    {BroochesRare.Giga, new[] {DefenseBreakRate004}},
                    {BroochesRare.Mega, new[] {DefenseBreakRate003}},
                    {BroochesRare.Kilo, new[] {DefenseBreakRate002}},
                    {BroochesRare.Byte, new[] {DefenseBreakRate001}}
                });

            _sdA5 = new("屠殺",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateBoss, .05m)}},
                    {BroochesRare.Giga, new[] {ExtraDamageRateBoss002}}
                });

            _sdA6 = new("獨輪",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateBasic, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.ExtraDamageRateBasic, .02m)}}
                });

            _sdA7 = new("突擊",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {AttackRateOriginal036}},
                    {BroochesRare.Giga, new[] {AttackRateOriginal018}}
                });

            _sdA8 = new("攻擊者",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Attack, 405)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Attack, 315)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Attack, 225)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Attack, 135)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Attack, 45)}}
                });

            _sdA9 = new("碎片",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.PartialDamageRate, .2m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.PartialDamageRate, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.PartialDamageRate, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.PartialDamageRate, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.PartialDamageRate, .04m)}}
                });

            _sdA10 = new("燃燒",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackRateOHitP3D3, .24m)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackRateOHitP3D3, .21m)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackRateOHitP3D3, .18m)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackRateOHitP3D3, .15m)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackRateOHitP3D3, .12m)}}
                });

            _sdA11 = new("過熱",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackRateOHitP1D5, .45m)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackRateOHitP1D5, .42m)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackRateOHitP1D5, .39m)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackRateOHitP1D5, .36m)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackRateOHitP1D5, .33m)}}
                });

            _sdA12 = new("刺穿",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseBreakRateOCriticalP5D3, .06m)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseBreakRateOCriticalP5D3, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseBreakRateOCriticalP5D3, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseBreakRateOCriticalP5D3, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseBreakRateOCriticalP5D3, .02m)}}
                });

            _sdA13 = new("滲透",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseBreakRateOCriticalP3D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseBreakRateOCriticalP3D5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseBreakRateOCriticalP3D5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseBreakRateOCriticalP3D5, .07m)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseBreakRateOCriticalP3D5, .06m)}}
                });

            _sdA14 = new("黃蜂",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateAir, .2m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.ExtraDamageRateAir, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.ExtraDamageRateAir, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.ExtraDamageRateAir, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.ExtraDamageRateAir, .04m)}}
                });

            _sdA15 = new("踐踏",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ExtraDamageRateFall02}},
                    {BroochesRare.Giga, new[] {ExtraDamageRateFall016}},
                    {BroochesRare.Mega, new[] {ExtraDamageRateFall012}},
                    {BroochesRare.Kilo, new[] {ExtraDamageRateFall008}},
                    {BroochesRare.Byte, new[] {ExtraDamageRateFall004}}
                });

            #endregion

            #region Defense

            _sdD1 = new("盔甲",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.AttackRateOriginal, .54m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.AttackRateOriginal, .45m)}},
                    {BroochesRare.Mega, new[] {AttackRateOriginal036}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.AttackRateOriginal, .27m)}},
                    {BroochesRare.Byte, new[] {AttackRateOriginal018}}
                });

            _sdD2 = new("受傷",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalResistanceRate, .06m)}},
                    {BroochesRare.Giga, new[] {CriticalResistanceRate004}},
                    {BroochesRare.Mega, new[] {CriticalResistanceRate003}},
                    {BroochesRare.Kilo, new[] {CriticalResistanceRate002}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalResistanceRate, .01m)}}
                });

            _sdD3 = new("模糊",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Evade, 52)}},
                    {BroochesRare.Giga, new[] {Evade42}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Evade, 31)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 21)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Evade, 10)}}
                });

            _sdD4 = new("幽靈",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOAvoidD5, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOAvoidD5, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOAvoidD5, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOAvoidD5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOAvoidD5, .01m)}}
                });

            _sdD5 = new("巨人",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRateBasic, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRateBasic, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.DamageReductionRateBasic, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRateBasic, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRateBasic, .01m)}}
                });

            _sdD6 = new("鸚螺",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRateBoss, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRateBoss, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.DamageReductionRateBoss, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRateBoss, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRateBoss, .01m)}}
                });

            _sdD7 = new("麻雀",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOAirSufferD5, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOAirSufferD5, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOAirSufferD5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOAirSufferD5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOAirSufferD5, .01m)}}
                });

            _sdD8 = new("地殼",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOFallD5, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOFallD5, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOFallD5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOFallD5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOFallD5, .01m)}}
                });

            _sdD9 = new("幻象",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(EvadeOSufferP15D3, 270)}},
                    {BroochesRare.Giga, new Effect[] {new(EvadeOSufferP15D3, 240)}},
                    {BroochesRare.Mega, new Effect[] {new(EvadeOSufferP15D3, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(EvadeOSufferP15D3, 180)}},
                    {BroochesRare.Byte, new Effect[] {new(EvadeOSufferP15D3, 150)}}
                });

            _sdD10 = new("幻影",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(PartialDamageRateOAvoidP1D10, .3m)}},
                    {BroochesRare.Giga, new Effect[] {new(PartialDamageRateOAvoidP1D10, .27m)}},
                    {BroochesRare.Mega, new Effect[] {new(PartialDamageRateOAvoidP1D10, .24m)}},
                    {BroochesRare.Kilo, new Effect[] {new(PartialDamageRateOAvoidP1D10, .21m)}},
                    {BroochesRare.Byte, new Effect[] {new(PartialDamageRateOAvoidP1D10, .18m)}}
                });

            _sdD11 = new("巨魔",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryOSufferCriticalD50, 2_500)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryOSufferCriticalD50, 2_000)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryOSufferCriticalD50, 1_500)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryOSufferCriticalD50, 1_000)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryOSufferCriticalD50, 500)}}
                });

            _sdD12 = new("生命",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.HpRate, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.HpRate, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.HpRate, .07m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.HpRate, .05m)}},
                    {BroochesRare.Byte, new[] {HpRate002}}
                });

            _sdD13 = new("活力",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.StaminaRecovery, 8)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.StaminaRecovery, 6)}}
                });

            _sdD14 = new("屏障",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {DamageReductionRate005}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRate, .02m)}}
                });

            _sdD15 = new("石像",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseRateOSufferHp50DownP1D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseRateOSufferHp50DownP1D5, .37m)}}
                });

            #endregion

            #region Effect

            _sdE1 = new("吸血",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryOKill, 600)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryOKill, 480)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryOKill, 360)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryOKill, 240)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryOKill, 120)}}
                });

            _sdE2 = new("迅猛",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .23m)}},
                    {BroochesRare.Mega, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .21m)}},
                    {BroochesRare.Kilo, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .19m)}},
                    {BroochesRare.Byte, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .18m)}}
                });

            _sdE3 = new("行軍",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.MoveSpaceRateTown, .06m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.MoveSpaceRateTown, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.MoveSpaceRateTown, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.MoveSpaceRateTown, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.MoveSpaceRateTown, .02m)}}
                });

            _sdE4 = new("鋼鐵",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .07m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .04m)}}
                });

            _sdE5 = new("搖擺",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackRateOAvoid, .7m)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackRateOAvoid, .6m)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackRateOAvoid, .5m)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackRateOAvoid, .4m)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackRateOAvoid, .3m)}}
                });

            _sdE6 = new("救濟",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryOAvoidP1, 1_500)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryOAvoidP1, 1_350)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryOAvoidP1, 1_200)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryOAvoidP1, 1_050)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryOAvoidP1, 900)}}
                });

            _sdE7 = new("吸收",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaminaRecoveryOHitP2, 10)}},
                    {BroochesRare.Giga, new Effect[] {new(StaminaRecoveryOHitP2, 9)}},
                    {BroochesRare.Mega, new Effect[] {new(StaminaRecoveryOHitP2, 8)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaminaRecoveryOHitP2, 7)}},
                    {BroochesRare.Byte, new Effect[] {new(StaminaRecoveryOHitP2, 6)}}
                });

            _sdE8 = new("迅速",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {MoveSpaceRate005}},
                    {BroochesRare.Giga, new[] {MoveSpaceRate004}},
                    {BroochesRare.Mega, new[] {MoveSpaceRate003}},
                    {BroochesRare.Kilo, new[] {MoveSpaceRate002}},
                    {BroochesRare.Byte, new[] {MoveSpaceRate001}}
                });

            _sdE9 = new("硬度",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseRateOSufferP15D5, .7m)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseRateOSufferP15D5, .63m)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseRateOSufferP15D5, .56m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseRateOSufferP15D5, .49m)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseRateOSufferP15D5, .42m)}}
                });

            _sdE10 = new("藐視",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .04m)}}
                });

            _sdE11 = new("固執",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(EndureSecondOSufferP2, 12)}},
                    {BroochesRare.Giga, new Effect[] {new(EndureSecondOSufferP2, 10)}},
                    {BroochesRare.Mega, new Effect[] {new(EndureSecondOSufferP2, 8)}},
                    {BroochesRare.Kilo, new Effect[] {new(EndureSecondOSufferP2, 4)}},
                    {BroochesRare.Byte, new Effect[] {new(EndureSecondOSufferP2, 1)}}
                });

            _sdE12 = new("刺蝟",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(MoveSpaceRateOSufferP2D6, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(MoveSpaceRateOSufferP2D6, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(MoveSpaceRateOSufferP2D6, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(MoveSpaceRateOSufferP2D6, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(MoveSpaceRateOSufferP2D6, .02m)}}
                });

            _sdE13 = new("喜悅",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(new(Property.HpRecoveryRate, Opportunity.UseAvoid, .15m), 5)}
                    },
                    {BroochesRare.Giga, new Effect[] {new(new(Property.HpRecoveryRate, Opportunity.UseAvoid, .1m), 3)}}
                });

            _sdE14 = new("行者",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(MoveSpaceRateORunP15D5, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(MoveSpaceRateORunP15D5, .06m)}}
                });

            _sdE15 = new("啟蒙",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CooldownShorterRateOUseSkillP2, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(CooldownShorterRateOUseSkillP2, .05m)}}
                });

            #endregion
        }

        #endregion
    }
}