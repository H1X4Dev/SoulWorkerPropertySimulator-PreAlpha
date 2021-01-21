using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        private static Brooches _bskA1;
        private static Brooches _bskA2;
        private static Brooches _bsk3;
        private static Brooches _bskA4;
        private static Brooches _bskA5;
        private static Brooches _bskA6;
        private static Brooches _bskA7;
        private static Brooches _bskA8;
        private static Brooches _bskA9;
        private static Brooches _bskA10;
        private static Brooches _bskA11;
        private static Brooches _bskA12;
        private static Brooches _bskA13;
        private static Brooches _bskA14;
        private static Brooches _bskA15;
        private static Brooches _bskA16;
        private static Brooches _bskA17;

        private static Brooches _bskD1;
        private static Brooches _bskD2;
        private static Brooches _bskD3;
        private static Brooches _bskD4;
        private static Brooches _bskD5;
        private static Brooches _bskD6;
        private static Brooches _bskD7;
        private static Brooches _bskD8;
        private static Brooches _bskD9;
        private static Brooches _bskD10;
        private static Brooches _bskD11;
        private static Brooches _bskD12;
        private static Brooches _bskD13;
        private static Brooches _bskD14;
        private static Brooches _bskD15;
        private static Brooches _bskD16;
        private static Brooches _bskD17;

        private static Brooches _bskE1;
        private static Brooches _bskE2;
        private static Brooches _bskE3;
        private static Brooches _bskE4;
        private static Brooches _bskE5;
        private static Brooches _bskE6;
        private static Brooches _bskE7;
        private static Brooches _bskE8;
        private static Brooches _bskE9;
        private static Brooches _bskE10;
        private static Brooches _bskE11;
        private static Brooches _bskE12;
        private static Brooches _bskE13;
        private static Brooches _bskE14;
        private static Brooches _bskE15;
        private static Brooches _bskE16;
        private static Brooches _bskE17;

        #region

        private static void SetupBsk()
        {
            #region Attack

            _bskA1 = _sdA1 with {Series = BroochesSeries.Bsk};
            _bskA2 = _sdA14 with {Name = "飛行", Series = BroochesSeries.Bsk};
            _bsk3  = _sdA2 with {Series = BroochesSeries.Bsk};
            _bskA4 = _sdA15 with {Name = "阻礙", Series = BroochesSeries.Bsk};
            _bskA5 = _sdA3 with {Series = BroochesSeries.Bsk};
            _bskA6 = _sdA4 with {Series = BroochesSeries.Bsk};

            _bskA7 = new("攻擊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Attack, 216)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Attack, 160)}},
                    {BroochesRare.Mega, new[] {ShareEffect.Attack120}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Attack, 72)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Attack, 24)}}
                });

            _bskA8 = _sdA9 with {Series = BroochesSeries.Bsk};

            _bskA9 = new("灰熊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.AttackRate, .48m), ShareEffect.DefenseRateM005}},
                    {BroochesRare.Giga, new[] {new(Static.AttackRate, .42m), ShareEffect.DefenseRateM005}},
                    {BroochesRare.Mega, new[] {new(Static.AttackRate, .36m), ShareEffect.DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {new(Static.AttackRate, .3m), ShareEffect.DefenseRateM005}},
                    {BroochesRare.Byte, new[] {ShareEffect.AttackRate024, ShareEffect.DefenseRateM005}}
                });

            _bskA10 = new("瘋狂",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.AttackRate038, ShareEffect.EvadeM30}},
                    {BroochesRare.Giga, new[] {ShareEffect.AttackRate033, ShareEffect.EvadeM30}},
                    {BroochesRare.Mega, new[] {ShareEffect.AttackRate028, ShareEffect.EvadeM30}},
                    {BroochesRare.Kilo, new[] {ShareEffect.AttackRate024, ShareEffect.EvadeM30}},
                    {BroochesRare.Byte, new[] {ShareEffect.AttackRate019, ShareEffect.EvadeM30}}
                });

            _bskA11 = new("捨身",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.AttackRate038, ShareEffect.HpRateM005}},
                    {BroochesRare.Giga, new[] {ShareEffect.AttackRate033, ShareEffect.HpRateM005}},
                    {BroochesRare.Mega, new[] {ShareEffect.AttackRate028, ShareEffect.HpRateM005}},
                    {BroochesRare.Kilo, new[] {ShareEffect.AttackRate024, ShareEffect.HpRateM005}},
                    {BroochesRare.Byte, new[] {ShareEffect.AttackRate019, ShareEffect.HpRateM005}}
                });

            _bskA12 = new("搏擊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Accuracy90, ShareEffect.DefenseRateM005}},
                    {BroochesRare.Giga, new[] {ShareEffect.Accuracy80, ShareEffect.DefenseRateM005}},
                    {BroochesRare.Mega, new[] {ShareEffect.Accuracy69, ShareEffect.DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Accuracy60, ShareEffect.DefenseRateM005}},
                    {BroochesRare.Byte, new[] {ShareEffect.Accuracy50, ShareEffect.DefenseRateM005}}
                });

            _bskA13 = new("野豬",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Accuracy90, ShareEffect.EvadeM30}},
                    {BroochesRare.Giga, new[] {ShareEffect.Accuracy80, ShareEffect.EvadeM30}},
                    {BroochesRare.Mega, new[] {ShareEffect.Accuracy69, ShareEffect.EvadeM30}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Accuracy60, ShareEffect.EvadeM30}},
                    {BroochesRare.Byte, new[] {ShareEffect.Accuracy50, ShareEffect.EvadeM30}}
                });

            _bskA14 = new("老虎",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Accuracy90, ShareEffect.HpRateM005}},
                    {BroochesRare.Giga, new[] {ShareEffect.Accuracy80, ShareEffect.HpRateM005}},
                    {BroochesRare.Mega, new[] {ShareEffect.Accuracy69, ShareEffect.HpRateM005}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Accuracy60, ShareEffect.HpRateM005}},
                    {BroochesRare.Byte, new[] {ShareEffect.Accuracy50, ShareEffect.HpRateM005}}
                });

            _bskA15 = new("黑蛇",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera, new[] {ShareEffect.SuperArmorBreakPowerRate009, ShareEffect.DefenseRateM005}
                    },
                    {BroochesRare.Giga, new[] {ShareEffect.SuperArmorBreakPowerRate008, ShareEffect.DefenseRateM005}},
                    {BroochesRare.Mega, new[] {ShareEffect.SuperArmorBreakPowerRate007, ShareEffect.DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {ShareEffect.SuperArmorBreakPowerRate006, ShareEffect.DefenseRateM005}},
                    {BroochesRare.Byte, new[] {ShareEffect.SuperArmorBreakPowerRate005, ShareEffect.DefenseRateM005}}
                });

            _bskA16 = new("海怪",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.SuperArmorBreakPowerRate009, ShareEffect.EvadeM30}},
                    {BroochesRare.Giga, new[] {ShareEffect.SuperArmorBreakPowerRate008, ShareEffect.EvadeM30}},
                    {BroochesRare.Mega, new[] {ShareEffect.SuperArmorBreakPowerRate007, ShareEffect.EvadeM30}},
                    {BroochesRare.Kilo, new[] {ShareEffect.SuperArmorBreakPowerRate006, ShareEffect.EvadeM30}},
                    {BroochesRare.Byte, new[] {ShareEffect.SuperArmorBreakPowerRate005, ShareEffect.EvadeM30}}
                });

            _bskA17 = new("麋鹿",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.SuperArmorBreakPowerRate009, ShareEffect.HpRateM005}},
                    {BroochesRare.Giga, new[] {ShareEffect.SuperArmorBreakPowerRate008, ShareEffect.HpRateM005}},
                    {BroochesRare.Mega, new[] {ShareEffect.SuperArmorBreakPowerRate007, ShareEffect.HpRateM005}},
                    {BroochesRare.Kilo, new[] {ShareEffect.SuperArmorBreakPowerRate006, ShareEffect.HpRateM005}},
                    {BroochesRare.Byte, new[] {ShareEffect.SuperArmorBreakPowerRate005, ShareEffect.HpRateM005}}
                });

            #endregion

            #region Defense

            _bskD1 = new("盔甲",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DefenseRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DefenseRate, .21m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.DefenseRate, .16m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DefenseRate, .12m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DefenseRate, .08m)}}
                });

            _bskD2 = new("模糊",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Evade42}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Evade, 33)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Evade, 25)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 16)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Evade, 8)}}
                });

            _bskD3 = new("幽靈",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .09m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .07m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .05m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOAvoidD5, .01m)}}
                });

            _bskD4 = new("巨人",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRate, .09m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRate, .07m)}},
                    {BroochesRare.Mega, new[] {ShareEffect.DamageReductionRate005}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRate, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRate, .01m)}}
                });

            _bskD5 = _sdD6 with {Series = BroochesSeries.Bsk};

            _bskD6 = new("麻雀",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOAirHitD5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOAirHitD5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOAirHitD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOAirHitD5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOAirHitD5, .02m)}}
                });

            _bskD7 = new("地殼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOFallSufferD5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOFallSufferD5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOFallSufferD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOFallSufferD5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOFallSufferD5, .02m)}}
                });

            _bskD8 = new("狂暴",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOSufferP3D5, 1_080)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOSufferP3D5, 840)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOSufferP3D5, 600)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOSufferP3D5, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOSufferP3D5, 120)}}
                });

            _bskD9 = new("恐懼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AccuracyOSufferP3D5, 350)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AccuracyOSufferP3D5, 280)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AccuracyOSufferP3D5, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AccuracyOSufferP3D5, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AccuracyOSufferP3D5, 70)}}
                });

            _bskD10 = new("欺騙",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalDamageOSufferP3D5, 1_500)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalDamageOSufferP3D5, 1_200)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalDamageOSufferP3D5, 900)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalDamageOSufferP3D5, 600)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalDamageOSufferP3D5, 300)}}
                });

            _bskD11 = new("發狂",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.PartialDamageRateOSufferP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.PartialDamageRateOSufferP3D5, .4m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.PartialDamageRateOSufferP3D5, .3m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.PartialDamageRateOSufferP3D5, .2m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.PartialDamageRateOSufferP3D5, .1m)}}
                });

            _bskD12 = new("死神",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOSufferP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOSufferP3D5, .4m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOSufferP3D5, .3m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOSufferP3D5, .2m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOSufferP3D5, .1m)}}
                });

            _bskD13 = new("激怒",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOAvoidP3D5, 1_200)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOAvoidP3D5, 750)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOAvoidP3D5, 450)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOAvoidP3D5, 300)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOAvoidP3D5, 150)}}
                });

            _bskD14 = new("鐵桿",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AccuracyOAvoidP3D5, 20)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AccuracyOAvoidP3D5, 16)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AccuracyOAvoidP3D5, 12)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AccuracyOAvoidP3D5, 8)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AccuracyOAvoidP3D5, 4)}}
                });

            _bskD15 = new("犀牛",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalDamageOAvoidP3D5, 2_400)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalDamageOAvoidP3D5, 1_680)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalDamageOAvoidP3D5, 1_200)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalDamageOAvoidP3D5, 960)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalDamageOAvoidP3D5, 720)}}
                });

            _bskD16 = new("憤怒",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP3D5, .42m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP3D5, .33m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP3D5, .29m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.PartialDamageRateOAvoidP3D5, .25m)}}
                });

            _bskD17 = new("小鬼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOAvoidP3D5, .21m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOAvoidP3D5, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOAvoidP3D5, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOAvoidP3D5, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOAvoidP3D5, .04m)}}
                });

            #endregion

            #region Effect

            _bskE1 = new("固執",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 12)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 10)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 8)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 4)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.EndureSecondOSufferP2, 2)}}
                });

            _bskE2 = new("迅猛",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .21m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .19m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .18m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .16m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOHitP5D5, .15m)}}
                });

            _bskE3 = _sdE3 with {Series = BroochesSeries.Bsk};

            _bskE4 = new("鋼鐵",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .08m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .07m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOSufferBossP1D5, .03m)}}
                });

            _bskE5 = new("搖擺",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackSpeedRateOAvoid, .56m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackSpeedRateOAvoid, .45m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackSpeedRateOAvoid, .4m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackSpeedRateOAvoid, .32m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackSpeedRateOAvoid, .24m)}}
                });

            _bskE6 = new("救濟",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 2_500)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 2_250)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 2_000)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 1_750)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOAvoidP1, 1_500)}}
                });

            _bskE7 = new("藐視",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalResistanceRateOSufferP8D10, .04m)}}
                });

            _bskE8 = _sdE8 with {Series = BroochesSeries.Bsk};

            _bskE9 = new("發熱",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOUseSkillP1D5, 1_350)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOUseSkillP1D5, 1_050)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOUseSkillP1D5, 750)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOUseSkillP1D5, 450)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOUseSkillP1D5, 150)}}
                });

            _bskE10 = new("恢復",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AccuracyOUseSkillP1D5, 350)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AccuracyOUseSkillP1D5, 280)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AccuracyOUseSkillP1D5, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AccuracyOUseSkillP1D5, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AccuracyOUseSkillP1D5, 70)}}
                });

            _bskE11 = new("沉重",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalDamageOUseSkillP3D5, 3_000)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalDamageOUseSkillP3D5, 2_400)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalDamageOUseSkillP3D5, 1_800)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalDamageOUseSkillP3D5, 1_200)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalDamageOUseSkillP3D5, 600)}}
                });

            _bskE12 = new("劍聖",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackORunP3D5, 450)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackORunP3D5, 350)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackORunP3D5, 250)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackORunP3D5, 150)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackORunP3D5, 50)}}
                });

            _bskE13 = new("餅乾",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateORunP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateORunP1D5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateORunP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateORunP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateORunP1D5, .02m)}}
                });

            _bskE14 = new("充電",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseBreakRateORunP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseBreakRateORunP1D5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseBreakRateORunP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseBreakRateORunP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseBreakRateORunP1D5, .02m)}}
                });

            _bskE15 = new("狂亂",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOKillD5, 1_225)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOKillD5, 700)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOKillD5, 350)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOKillD5, 175)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOKillD5, 87)}}
                });

            _bskE16 = new("狂人",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOKillD5, .16m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOKillD5, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOKillD5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOKillD5, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.SuperArmorBreakPowerRateOKillD5, .03m)}}
                });

            _bskE17 = new("感覺",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseBreakRateOKillD5, .16m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseBreakRateOKillD5, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseBreakRateOKillD5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseBreakRateOKillD5, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseBreakRateOKillD5, .03m)}}
                });

            #endregion
        }

        #endregion
    }
}