using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        private static Brooch _sdA1  = null!;
        private static Brooch _sdA2  = null!;
        private static Brooch _sdA3  = null!;
        private static Brooch _sdA4  = null!;
        private static Brooch _sdA9  = null!;
        private static Brooch _sdA14 = null!;
        private static Brooch _sdA15 = null!;
        private static Brooch _sdD6  = null!;
        private static Brooch _sdE3  = null!;
        private static Brooch _sdE8  = null!;

        #region

        #region

        private static IReadOnlyCollection<Brooch> SetupSd(ShareEffect share)
        {
            _sdA1 = new("鷹眼",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.Accuracy, 52)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.Accuracy, 42)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.Accuracy, 31)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.Accuracy, 21)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.Accuracy, 10)}}
                });
            _sdA2 = new("致命",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {share.CriticalDamage700}},
                    {BroochesRare.Giga, new[] {share.CriticalDamage560}},
                    {BroochesRare.Mega, new[] {share.CriticalDamage420}},
                    {BroochesRare.Kilo, new[] {share.CriticalDamage280}},
                    {BroochesRare.Byte, new[] {share.CriticalDamage140}}
                });
            _sdA3 = new("破碎",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {share.SuperArmorBreakPowerRate01}},
                    {BroochesRare.Giga, new[] {share.SuperArmorBreakPowerRate008}},
                    {BroochesRare.Mega, new[] {share.SuperArmorBreakPowerRate006}},
                    {BroochesRare.Kilo, new[] {share.SuperArmorBreakPowerRate004}},
                    {BroochesRare.Byte, new[] {share.SuperArmorBreakPowerRate002}}
                });
            _sdA4 = new("熔解",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {share.DefenseBreakRate005}},
                    {BroochesRare.Giga, new[] {share.DefenseBreakRate004}},
                    {BroochesRare.Mega, new[] {share.DefenseBreakRate003}},
                    {BroochesRare.Kilo, new[] {share.DefenseBreakRate002}},
                    {BroochesRare.Byte, new[] {share.DefenseBreakRate001}}
                });
            _sdA9 = new("碎片",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.PartialDamageRate, .2m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.PartialDamageRate, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.PartialDamageRate, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.PartialDamageRate, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.PartialDamageRate, .04m)}}
                });
            _sdA14 = new("黃蜂",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.ExtraDamageRateAir, .2m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.ExtraDamageRateAir, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.ExtraDamageRateAir, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.ExtraDamageRateAir, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.ExtraDamageRateAir, .04m)}}
                });
            _sdA15 = new("踐踏",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {share.ExtraDamageRateFall02}},
                    {BroochesRare.Giga, new[] {share.ExtraDamageRateFall016}},
                    {BroochesRare.Mega, new[] {share.ExtraDamageRateFall012}},
                    {BroochesRare.Kilo, new[] {share.ExtraDamageRateFall008}},
                    {BroochesRare.Byte, new[] {share.ExtraDamageRateFall004}}
                });
            _sdD6 = new("鸚螺",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.DamageReductionRateBoss, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.DamageReductionRateBoss, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.DamageReductionRateBoss, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.DamageReductionRateBoss, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.DamageReductionRateBoss, .01m)}}
                });

            _sdE3 = new("行軍",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.MoveSpaceRateTown, .06m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.MoveSpaceRateTown, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.MoveSpaceRateTown, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.MoveSpaceRateTown, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.MoveSpaceRateTown, .02m)}}
                });
            _sdE8 = new("迅速",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {share.MoveSpaceRate005}},
                    {BroochesRare.Giga, new[] {share.MoveSpaceRate004}},
                    {BroochesRare.Mega, new[] {share.MoveSpaceRate003}},
                    {BroochesRare.Kilo, new[] {share.MoveSpaceRate002}},
                    {BroochesRare.Byte, new[] {share.MoveSpaceRate001}}
                });

            return new List<Brooch>
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
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.ExtraDamageRateBoss, .05m)}},
                        {BroochesRare.Giga, new[] {share.ExtraDamageRateBoss002}}
                    }),

                // sdA6
                new("獨輪",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.ExtraDamageRateBasic, .05m)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.ExtraDamageRateBasic, .02m)}}
                    }),

                // sdA7
                new("突擊",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.AttackRateOriginal036}},
                        {BroochesRare.Giga, new[] {share.AttackRateOriginal018}}
                    }),

                // sdA8
                new("攻擊者",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.Attack, 405)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.Attack, 315)}},
                        {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.Attack, 225)}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.Attack, 135)}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.Attack, 45)}}
                    }),

                // sdA9
                new("碎片",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.PartialDamageRate, .2m)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.PartialDamageRate, .16m)}},
                        {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.PartialDamageRate, .12m)}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.PartialDamageRate, .08m)}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.PartialDamageRate, .04m)}}
                    }),

                // sdA10
                new("燃燒",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackRateOHitP3D3, .24m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackRateOHitP3D3, .21m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackRateOHitP3D3, .18m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackRateOHitP3D3, .15m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackRateOHitP3D3, .12m)}}
                    }),

                // sdA11
                new("過熱",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackRateOHitP1D5, .45m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackRateOHitP1D5, .42m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackRateOHitP1D5, .39m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackRateOHitP1D5, .36m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackRateOHitP1D5, .33m)}}
                    }),

                // sdA12
                new("刺穿",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseBreakRateOCriticalP5D3, .06m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseBreakRateOCriticalP5D3, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseBreakRateOCriticalP5D3, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseBreakRateOCriticalP5D3, .03m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseBreakRateOCriticalP5D3, .02m)}}
                    }),

                // sdA13
                new("滲透",
                    BroochesSeries.Sd,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseBreakRateOCriticalP3D5, .1m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseBreakRateOCriticalP3D5, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseBreakRateOCriticalP3D5, .08m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseBreakRateOCriticalP3D5, .07m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseBreakRateOCriticalP3D5, .06m)}}
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
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.AttackRateOriginal, .54m)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.AttackRateOriginal, .45m)}},
                        {BroochesRare.Mega, new[] {share.AttackRateOriginal036}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.AttackRateOriginal, .27m)}},
                        {BroochesRare.Byte, new[] {share.AttackRateOriginal018}}
                    }),

                // sdD2
                new("受傷",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.CriticalResistanceRate, .06m)}},
                        {BroochesRare.Giga, new[] {share.CriticalResistanceRate004}},
                        {BroochesRare.Mega, new[] {share.CriticalResistanceRate003}},
                        {BroochesRare.Kilo, new[] {share.CriticalResistanceRate002}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.CriticalResistanceRate, .01m)}}
                    }),

                // sdD3
                new("模糊",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.Evade, 52)}},
                        {BroochesRare.Giga, new[] {share.Evade42}},
                        {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.Evade, 31)}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.Evade, 21)}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.Evade, 10)}}
                    }),

                // sdD4
                new("幽靈",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DamageReductionRateOAvoidD5, .05m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DamageReductionRateOAvoidD5, .04m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DamageReductionRateOAvoidD5, .03m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DamageReductionRateOAvoidD5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DamageReductionRateOAvoidD5, .01m)}}
                    }),

                // sdD5
                new("巨人",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.DamageReductionRateBasic, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.DamageReductionRateBasic, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.DamageReductionRateBasic, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.DamageReductionRateBasic, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.DamageReductionRateBasic, .01m)}}
                    }),

                // sdD6
                _sdD6,

                // sdD7
                new("麻雀",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DamageReductionRateOAirSufferD5, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DamageReductionRateOAirSufferD5, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DamageReductionRateOAirSufferD5, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DamageReductionRateOAirSufferD5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DamageReductionRateOAirSufferD5, .01m)}}
                    }),

                // sdD8
                new("地殼",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DamageReductionRateOFallD5, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DamageReductionRateOFallD5, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DamageReductionRateOFallD5, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DamageReductionRateOFallD5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DamageReductionRateOFallD5, .01m)}}
                    }),

                // sdD9
                new("幻象",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.EvadeOSufferP15D3, 270)}},
                        {BroochesRare.Giga, new Effect[] {new(share.EvadeOSufferP15D3, 240)}},
                        {BroochesRare.Mega, new Effect[] {new(share.EvadeOSufferP15D3, 210)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.EvadeOSufferP15D3, 180)}},
                        {BroochesRare.Byte, new Effect[] {new(share.EvadeOSufferP15D3, 150)}}
                    }),

                // sdD10
                new("幻影",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.PartialDamageRateOAvoidP1D10, .3m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.PartialDamageRateOAvoidP1D10, .27m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.PartialDamageRateOAvoidP1D10, .24m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.PartialDamageRateOAvoidP1D10, .21m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.PartialDamageRateOAvoidP1D10, .18m)}}
                    }),

                // sdD11
                new("巨魔",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.HpRecoveryOSufferCriticalD50, 2_500)}},
                        {BroochesRare.Giga, new Effect[] {new(share.HpRecoveryOSufferCriticalD50, 2_000)}},
                        {BroochesRare.Mega, new Effect[] {new(share.HpRecoveryOSufferCriticalD50, 1_500)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.HpRecoveryOSufferCriticalD50, 1_000)}},
                        {BroochesRare.Byte, new Effect[] {new(share.HpRecoveryOSufferCriticalD50, 500)}}
                    }),

                // sdD12
                new("生命",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.HpRate, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.HpRate, .1m)}},
                        {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.HpRate, .07m)}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.HpRate, .05m)}},
                        {BroochesRare.Byte, new[] {share.HpRate002}}
                    }),

                // sdD13
                new("活力",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.StaminaRecovery, 8)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.StaminaRecovery, 6)}}
                    }),

                // sdD14
                new("屏障",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.DamageReductionRate005}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.DamageReductionRate, .02m)}}
                    }),

                // sdD15
                new("石像",
                    BroochesSeries.Sd,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseRateOSufferHp50DownP1D5, .5m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseRateOSufferHp50DownP1D5, .37m)}}
                    }),

                #endregion

                #region Effect

                // sdE1
                new("吸血",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.HpRecoveryOKill, 600)}},
                        {BroochesRare.Giga, new Effect[] {new(share.HpRecoveryOKill, 480)}},
                        {BroochesRare.Mega, new Effect[] {new(share.HpRecoveryOKill, 360)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.HpRecoveryOKill, 240)}},
                        {BroochesRare.Byte, new Effect[] {new(share.HpRecoveryOKill, 120)}}
                    }),

                // sdE2
                new("迅猛",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.SuperArmorBreakPowerRateOHitP5D5, .25m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.SuperArmorBreakPowerRateOHitP5D5, .23m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.SuperArmorBreakPowerRateOHitP5D5, .21m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.SuperArmorBreakPowerRateOHitP5D5, .19m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.SuperArmorBreakPowerRateOHitP5D5, .18m)}}
                    }),

                // sdE3
                _sdE3,

                // sdE4
                new("鋼鐵",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DamageReductionRateOSufferBossP1D5, .1m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DamageReductionRateOSufferBossP1D5, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DamageReductionRateOSufferBossP1D5, .07m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DamageReductionRateOSufferBossP1D5, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DamageReductionRateOSufferBossP1D5, .04m)}}
                    }),

                // sdE5
                new("搖擺",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackRateOAvoid, .7m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackRateOAvoid, .6m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackRateOAvoid, .5m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackRateOAvoid, .4m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackRateOAvoid, .3m)}}
                    }),

                // sdE6
                new("救濟",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.HpRecoveryOAvoidP1, 1_500)}},
                        {BroochesRare.Giga, new Effect[] {new(share.HpRecoveryOAvoidP1, 1_350)}},
                        {BroochesRare.Mega, new Effect[] {new(share.HpRecoveryOAvoidP1, 1_200)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.HpRecoveryOAvoidP1, 1_050)}},
                        {BroochesRare.Byte, new Effect[] {new(share.HpRecoveryOAvoidP1, 900)}}
                    }),

                // sdE7
                new("吸收",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.StaminaRecoveryOHitP2, 10)}},
                        {BroochesRare.Giga, new Effect[] {new(share.StaminaRecoveryOHitP2, 9)}},
                        {BroochesRare.Mega, new Effect[] {new(share.StaminaRecoveryOHitP2, 8)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.StaminaRecoveryOHitP2, 7)}},
                        {BroochesRare.Byte, new Effect[] {new(share.StaminaRecoveryOHitP2, 6)}}
                    }),

                // sdE8
                _sdE8,

                // sdE9
                new("硬度",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseRateOSufferP15D5, .7m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseRateOSufferP15D5, .63m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseRateOSufferP15D5, .56m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseRateOSufferP15D5, .49m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseRateOSufferP15D5, .42m)}}
                    }),

                // sdE10
                new("藐視",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalResistanceRateOSufferP8D10, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalResistanceRateOSufferP8D10, .1m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalResistanceRateOSufferP8D10, .09m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalResistanceRateOSufferP8D10, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalResistanceRateOSufferP8D10, .04m)}}
                    }),

                // sdE11
                new("固執",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.EndureSecondOSufferP2, 12)}},
                        {BroochesRare.Giga, new Effect[] {new(share.EndureSecondOSufferP2, 10)}},
                        {BroochesRare.Mega, new Effect[] {new(share.EndureSecondOSufferP2, 8)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.EndureSecondOSufferP2, 4)}},
                        {BroochesRare.Byte, new Effect[] {new(share.EndureSecondOSufferP2, 1)}}
                    }),

                // sdE12
                new("刺蝟",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.MoveSpaceRateOSufferP2D6, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.MoveSpaceRateOSufferP2D6, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.MoveSpaceRateOSufferP2D6, .06m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.MoveSpaceRateOSufferP2D6, .04m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.MoveSpaceRateOSufferP2D6, .02m)}}
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
                        {BroochesRare.Tera, new Effect[] {new(share.MoveSpaceRateORunP15D5, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.MoveSpaceRateORunP15D5, .06m)}}
                    }),

                // sdE15
                new("啟蒙",
                    BroochesSeries.Sd,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CooldownShorterRateOUseSkillP2, .1m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CooldownShorterRateOUseSkillP2, .05m)}}
                    }),

                #endregion
            };

            #endregion
        }

        #endregion
    }
}