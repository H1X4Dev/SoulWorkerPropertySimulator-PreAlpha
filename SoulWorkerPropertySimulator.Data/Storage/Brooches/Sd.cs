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
        private static Brooches _sdA9;
        private static Brooches _sdA14;
        private static Brooches _sdA15;
        private static Brooches _sdD6;
        private static Brooches _sdE3;
        private static Brooches _sdE8;

        #region

        #region

        private static IReadOnlyCollection<Brooches> SetupSd()
        {
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
                    {BroochesRare.Tera, new[] {ShareEffect.CriticalDamage700}},
                    {BroochesRare.Giga, new[] {ShareEffect.CriticalDamage560}},
                    {BroochesRare.Mega, new[] {ShareEffect.CriticalDamage420}},
                    {BroochesRare.Kilo, new[] {ShareEffect.CriticalDamage280}},
                    {BroochesRare.Byte, new[] {ShareEffect.CriticalDamage140}}
                });
            _sdA3 = new("破碎",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.SuperArmorBreakPowerRate01}},
                    {BroochesRare.Giga, new[] {ShareEffect.SuperArmorBreakPowerRate008}},
                    {BroochesRare.Mega, new[] {ShareEffect.SuperArmorBreakPowerRate006}},
                    {BroochesRare.Kilo, new[] {ShareEffect.SuperArmorBreakPowerRate004}},
                    {BroochesRare.Byte, new[] {ShareEffect.SuperArmorBreakPowerRate002}}
                });
            _sdA4 = new("熔解",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.DefenseBreakRate005}},
                    {BroochesRare.Giga, new[] {ShareEffect.DefenseBreakRate004}},
                    {BroochesRare.Mega, new[] {ShareEffect.DefenseBreakRate003}},
                    {BroochesRare.Kilo, new[] {ShareEffect.DefenseBreakRate002}},
                    {BroochesRare.Byte, new[] {ShareEffect.DefenseBreakRate001}}
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
                    {BroochesRare.Tera, new[] {ShareEffect.ExtraDamageRateFall02}},
                    {BroochesRare.Giga, new[] {ShareEffect.ExtraDamageRateFall016}},
                    {BroochesRare.Mega, new[] {ShareEffect.ExtraDamageRateFall012}},
                    {BroochesRare.Kilo, new[] {ShareEffect.ExtraDamageRateFall008}},
                    {BroochesRare.Byte, new[] {ShareEffect.ExtraDamageRateFall004}}
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
            _sdE8 = new("迅速",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.MoveSpaceRate005}},
                    {BroochesRare.Giga, new[] {ShareEffect.MoveSpaceRate004}},
                    {BroochesRare.Mega, new[] {ShareEffect.MoveSpaceRate003}},
                    {BroochesRare.Kilo, new[] {ShareEffect.MoveSpaceRate002}},
                    {BroochesRare.Byte, new[] {ShareEffect.MoveSpaceRate001}}
                });

            return new List<Brooches>
            {
                #region Attack

                // sdA1
                _sdA1,

                // sdA2
                _sdA2,

                // sdA3
                _sdA3,

                // sdA4
                _sdA4,

                // sdA5
                new("屠殺",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateBoss, .05m)}},
                        {BroochesRare.Giga, new[] {ShareEffect.ExtraDamageRateBoss002}}
                    }),

                // sdA6
                new("獨輪",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateBasic, .05m)}},
                        {BroochesRare.Giga, new Effect[] {new(Static.ExtraDamageRateBasic, .02m)}}
                    }),

                // sdA7
                new("突擊",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.AttackRateOriginal036}},
                        {BroochesRare.Giga, new[] {ShareEffect.AttackRateOriginal018}}
                    }),

                // sdA8
                new("攻擊者",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.Attack, 405)}},
                        {BroochesRare.Giga, new Effect[] {new(Static.Attack, 315)}},
                        {BroochesRare.Mega, new Effect[] {new(Static.Attack, 225)}},
                        {BroochesRare.Kilo, new Effect[] {new(Static.Attack, 135)}},
                        {BroochesRare.Byte, new Effect[] {new(Static.Attack, 45)}}
                    }),

                // sdA9
                new("碎片",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.PartialDamageRate, .2m)}},
                        {BroochesRare.Giga, new Effect[] {new(Static.PartialDamageRate, .16m)}},
                        {BroochesRare.Mega, new Effect[] {new(Static.PartialDamageRate, .12m)}},
                        {BroochesRare.Kilo, new Effect[] {new(Static.PartialDamageRate, .08m)}},
                        {BroochesRare.Byte, new Effect[] {new(Static.PartialDamageRate, .04m)}}
                    }),

                // sdA10
                new("燃燒",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackRateOHitP3D3, .24m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackRateOHitP3D3, .21m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackRateOHitP3D3, .18m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackRateOHitP3D3, .15m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackRateOHitP3D3, .12m)}}
                    }),

                // sdA11
                new("過熱",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackRateOHitP1D5, .45m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackRateOHitP1D5, .42m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackRateOHitP1D5, .39m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackRateOHitP1D5, .36m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackRateOHitP1D5, .33m)}}
                    }),

                // sdA12
                new("刺穿",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP5D3, .06m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP5D3, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP5D3, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP5D3, .03m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP5D3, .02m)}}
                    }),

                // sdA13
                new("滲透",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP3D5, .1m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP3D5, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP3D5, .08m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP3D5, .07m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseBreakRateOCriticalP3D5, .06m)}}
                    }),

                // sdA14
                _sdA14,

                // sdA15
                _sdA15,

                #endregion

                #region Defense

                // sdD1
                new("盔甲",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.AttackRateOriginal, .54m)}},
                        {BroochesRare.Giga, new Effect[] {new(Static.AttackRateOriginal, .45m)}},
                        {BroochesRare.Mega, new[] {ShareEffect.AttackRateOriginal036}},
                        {BroochesRare.Kilo, new Effect[] {new(Static.AttackRateOriginal, .27m)}},
                        {BroochesRare.Byte, new[] {ShareEffect.AttackRateOriginal018}}
                    }),

                // sdD2
                new("受傷",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.CriticalResistanceRate, .06m)}},
                        {BroochesRare.Giga, new[] {ShareEffect.CriticalResistanceRate004}},
                        {BroochesRare.Mega, new[] {ShareEffect.CriticalResistanceRate003}},
                        {BroochesRare.Kilo, new[] {ShareEffect.CriticalResistanceRate002}},
                        {BroochesRare.Byte, new Effect[] {new(Static.CriticalResistanceRate, .01m)}}
                    }),

                // sdD3
                new("模糊",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.Evade, 52)}},
                        {BroochesRare.Giga, new[] {ShareEffect.Evade42}},
                        {BroochesRare.Mega, new Effect[] {new(Static.Evade, 31)}},
                        {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 21)}},
                        {BroochesRare.Byte, new Effect[] {new(Static.Evade, 10)}}
                    }),

                // sdD4
                new("幽靈",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .05m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .04m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .03m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .01m)}}
                    }),

                // sdD5
                new("巨人",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRateBasic, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRateBasic, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(Static.DamageReductionRateBasic, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRateBasic, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRateBasic, .01m)}}
                    }),

                // sdD6
                _sdD6,

                // sdD7
                new("麻雀",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOAirSufferD5, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOAirSufferD5, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOAirSufferD5, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOAirSufferD5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOAirSufferD5, .01m)}}
                    }),

                // sdD8
                new("地殼",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOFallD5, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOFallD5, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOFallD5, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOFallD5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOFallD5, .01m)}}
                    }),

                // sdD9
                new("幻象",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.EvadeOSufferP15D3, 270)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.EvadeOSufferP15D3, 240)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.EvadeOSufferP15D3, 210)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.EvadeOSufferP15D3, 180)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.EvadeOSufferP15D3, 150)}}
                    }),

                // sdD10
                new("幻影",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP1D10, .3m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP1D10, .27m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP1D10, .24m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP1D10, .21m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP1D10, .18m)}}
                    }),

                // sdD11
                new("巨魔",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOSufferCriticalD50, 2_500)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOSufferCriticalD50, 2_000)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOSufferCriticalD50, 1_500)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOSufferCriticalD50, 1_000)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOSufferCriticalD50, 500)}}
                    }),

                // sdD12
                new("生命",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.HpRate, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(Static.HpRate, .1m)}},
                        {BroochesRare.Mega, new Effect[] {new(Static.HpRate, .07m)}},
                        {BroochesRare.Kilo, new Effect[] {new(Static.HpRate, .05m)}},
                        {BroochesRare.Byte, new[] {ShareEffect.HpRate002}}
                    }),

                // sdD13
                new("活力",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(Static.StaminaRecovery, 8)}},
                        {BroochesRare.Giga, new Effect[] {new(Static.StaminaRecovery, 6)}}
                    }),

                // sdD14
                new("屏障",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.DamageReductionRate005}},
                        {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRate, .02m)}}
                    }),

                // sdD15
                new("石像",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseRateOSufferHp50DownP1D5, .5m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseRateOSufferHp50DownP1D5, .37m)}}
                    }),

                #endregion

                #region Effect

                // sdE1
                new("吸血",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOKill, 600)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOKill, 480)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOKill, 360)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOKill, 240)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOKill, 120)}}
                    }),

                // sdE2
                new("迅猛",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .25m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .23m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .21m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .19m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .18m)}}
                    }),

                // sdE3
                _sdE3,

                // sdE4
                new("鋼鐵",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {
                            BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .1m)}
                        },
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .07m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .04m)}}
                    }),

                // sdE5
                new("搖擺",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackRateOAvoid, .7m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackRateOAvoid, .6m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackRateOAvoid, .5m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackRateOAvoid, .4m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackRateOAvoid, .3m)}}
                    }),

                // sdE6
                new("救濟",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 1_500)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 1_350)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 1_200)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 1_050)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 900)}}
                    }),

                // sdE7
                new("吸收",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.StaminaRecoveryOHitP2, 10)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.StaminaRecoveryOHitP2, 9)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.StaminaRecoveryOHitP2, 8)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.StaminaRecoveryOHitP2, 7)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.StaminaRecoveryOHitP2, 6)}}
                    }),

                // sdE8
                _sdE8,

                // sdE9
                new("硬度",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseRateOSufferP15D5, .7m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseRateOSufferP15D5, .63m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseRateOSufferP15D5, .56m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseRateOSufferP15D5, .49m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseRateOSufferP15D5, .42m)}}
                    }),

                // sdE10
                new("藐視",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {
                            BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .12m)}
                        },
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .1m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .09m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .04m)}}
                    }),

                // sdE11
                new("固執",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 12)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 10)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 8)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 4)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 1)}}
                    }),

                // sdE12
                new("刺蝟",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.MoveSpaceRateOSufferP2D6, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.MoveSpaceRateOSufferP2D6, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.MoveSpaceRateOSufferP2D6, .06m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.MoveSpaceRateOSufferP2D6, .04m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.MoveSpaceRateOSufferP2D6, .02m)}}
                    }),

                // sdE13
                new("喜悅",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {
                            BroochesRare.Tera,
                            new Effect[] {new(new(Property.HpRecoveryRate, Opportunity.UseAvoid, .15m), 5)}
                        },
                        {
                            BroochesRare.Giga,
                            new Effect[] {new(new(Property.HpRecoveryRate, Opportunity.UseAvoid, .1m), 3)}
                        }
                    }),

                // sdE14
                new("行者",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.MoveSpaceRateORunP15D5, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.MoveSpaceRateORunP15D5, .06m)}}
                    }),

                // sdE15
                new("啟蒙",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.CooldownShorterRateOUseSkillP2, .1m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.CooldownShorterRateOUseSkillP2, .05m)}}
                    }),

                #endregion
            };

            #endregion
        }

        #endregion
    }
}