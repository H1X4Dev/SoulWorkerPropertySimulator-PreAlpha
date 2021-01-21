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
                    {BroochesRare.Mega, new[] {Attack120}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Attack, 72)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Attack, 24)}}
                });

            _bskA8 = _sdA9 with {Series = BroochesSeries.Bsk};

            _bskA9 = new("灰熊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.AttackRate, .48m), DefenseRateM005}},
                    {BroochesRare.Giga, new[] {new(Static.AttackRate, .42m), DefenseRateM005}},
                    {BroochesRare.Mega, new[] {new(Static.AttackRate, .36m), DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {new(Static.AttackRate, .3m), DefenseRateM005}},
                    {BroochesRare.Byte, new[] {AttackRate024, DefenseRateM005}}
                });

            _bskA10 = new("瘋狂",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {AttackRate038, EvadeM30}},
                    {BroochesRare.Giga, new[] {AttackRate033, EvadeM30}},
                    {BroochesRare.Mega, new[] {AttackRate028, EvadeM30}},
                    {BroochesRare.Kilo, new[] {AttackRate024, EvadeM30}},
                    {BroochesRare.Byte, new[] {AttackRate019, EvadeM30}}
                });

            _bskA11 = new("捨身",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {AttackRate038, HpRateM005}},
                    {BroochesRare.Giga, new[] {AttackRate033, HpRateM005}},
                    {BroochesRare.Mega, new[] {AttackRate028, HpRateM005}},
                    {BroochesRare.Kilo, new[] {AttackRate024, HpRateM005}},
                    {BroochesRare.Byte, new[] {AttackRate019, HpRateM005}}
                });

            _bskA12 = new("搏擊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Accuracy90, DefenseRateM005}},
                    {BroochesRare.Giga, new[] {Accuracy80, DefenseRateM005}},
                    {BroochesRare.Mega, new[] {Accuracy69, DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {Accuracy60, DefenseRateM005}},
                    {BroochesRare.Byte, new[] {Accuracy50, DefenseRateM005}}
                });

            _bskA13 = new("野豬",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Accuracy90, EvadeM30}},
                    {BroochesRare.Giga, new[] {Accuracy80, EvadeM30}},
                    {BroochesRare.Mega, new[] {Accuracy69, EvadeM30}},
                    {BroochesRare.Kilo, new[] {Accuracy60, EvadeM30}},
                    {BroochesRare.Byte, new[] {Accuracy50, EvadeM30}}
                });

            _bskA14 = new("老虎",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Accuracy90, HpRateM005}},
                    {BroochesRare.Giga, new[] {Accuracy80, HpRateM005}},
                    {BroochesRare.Mega, new[] {Accuracy69, HpRateM005}},
                    {BroochesRare.Kilo, new[] {Accuracy60, HpRateM005}},
                    {BroochesRare.Byte, new[] {Accuracy50, HpRateM005}}
                });

            _bskA15 = new("黑蛇",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {SuperArmorBreakPowerRate009, DefenseRateM005}},
                    {BroochesRare.Giga, new[] {SuperArmorBreakPowerRate008, DefenseRateM005}},
                    {BroochesRare.Mega, new[] {SuperArmorBreakPowerRate007, DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {SuperArmorBreakPowerRate006, DefenseRateM005}},
                    {BroochesRare.Byte, new[] {SuperArmorBreakPowerRate005, DefenseRateM005}}
                });

            _bskA16 = new("海怪",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {SuperArmorBreakPowerRate009, EvadeM30}},
                    {BroochesRare.Giga, new[] {SuperArmorBreakPowerRate008, EvadeM30}},
                    {BroochesRare.Mega, new[] {SuperArmorBreakPowerRate007, EvadeM30}},
                    {BroochesRare.Kilo, new[] {SuperArmorBreakPowerRate006, EvadeM30}},
                    {BroochesRare.Byte, new[] {SuperArmorBreakPowerRate005, EvadeM30}}
                });

            _bskA17 = new("麋鹿",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {SuperArmorBreakPowerRate009, HpRateM005}},
                    {BroochesRare.Giga, new[] {SuperArmorBreakPowerRate008, HpRateM005}},
                    {BroochesRare.Mega, new[] {SuperArmorBreakPowerRate007, HpRateM005}},
                    {BroochesRare.Kilo, new[] {SuperArmorBreakPowerRate006, HpRateM005}},
                    {BroochesRare.Byte, new[] {SuperArmorBreakPowerRate005, HpRateM005}}
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
                    {BroochesRare.Tera, new[] {Evade42}},
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
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOAvoidD5, .09m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOAvoidD5, .07m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOAvoidD5, .05m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOAvoidD5, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOAvoidD5, .01m)}}
                });

            _bskD4 = new("巨人",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRate, .09m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRate, .07m)}},
                    {BroochesRare.Mega, new[] {DamageReductionRate005}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRate, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRate, .01m)}}
                });

            _bskD5 = _sdD6 with {Series = BroochesSeries.Bsk};

            _bskD6 = new("麻雀",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOAirHitD5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOAirHitD5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOAirHitD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOAirHitD5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOAirHitD5, .02m)}}
                });

            _bskD7 = new("地殼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOFallSufferD5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOFallSufferD5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOFallSufferD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOFallSufferD5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOFallSufferD5, .02m)}}
                });

            _bskD8 = new("狂暴",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOSufferP3D5, 1_080)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOSufferP3D5, 840)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOSufferP3D5, 600)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOSufferP3D5, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOSufferP3D5, 120)}}
                });

            _bskD9 = new("恐懼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AccuracyOSufferP3D5, 350)}},
                    {BroochesRare.Giga, new Effect[] {new(AccuracyOSufferP3D5, 280)}},
                    {BroochesRare.Mega, new Effect[] {new(AccuracyOSufferP3D5, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(AccuracyOSufferP3D5, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(AccuracyOSufferP3D5, 70)}}
                });

            _bskD10 = new("欺騙",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOSufferP3D5, 1_500)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOSufferP3D5, 1_200)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOSufferP3D5, 900)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOSufferP3D5, 600)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOSufferP3D5, 300)}}
                });

            _bskD11 = new("發狂",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(PartialDamageRateOSufferP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(PartialDamageRateOSufferP3D5, .4m)}},
                    {BroochesRare.Mega, new Effect[] {new(PartialDamageRateOSufferP3D5, .3m)}},
                    {BroochesRare.Kilo, new Effect[] {new(PartialDamageRateOSufferP3D5, .2m)}},
                    {BroochesRare.Byte, new Effect[] {new(PartialDamageRateOSufferP3D5, .1m)}}
                });

            _bskD12 = new("死神",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(SuperArmorBreakPowerRateOSufferP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(SuperArmorBreakPowerRateOSufferP3D5, .4m)}},
                    {BroochesRare.Mega, new Effect[] {new(SuperArmorBreakPowerRateOSufferP3D5, .3m)}},
                    {BroochesRare.Kilo, new Effect[] {new(SuperArmorBreakPowerRateOSufferP3D5, .2m)}},
                    {BroochesRare.Byte, new Effect[] {new(SuperArmorBreakPowerRateOSufferP3D5, .1m)}}
                });

            _bskD13 = new("激怒",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOAvoidP3D5, 1_200)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOAvoidP3D5, 750)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOAvoidP3D5, 450)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOAvoidP3D5, 300)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOAvoidP3D5, 150)}}
                });

            _bskD14 = new("鐵桿",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AccuracyOAvoidP3D5, 20)}},
                    {BroochesRare.Giga, new Effect[] {new(AccuracyOAvoidP3D5, 16)}},
                    {BroochesRare.Mega, new Effect[] {new(AccuracyOAvoidP3D5, 12)}},
                    {BroochesRare.Kilo, new Effect[] {new(AccuracyOAvoidP3D5, 8)}},
                    {BroochesRare.Byte, new Effect[] {new(AccuracyOAvoidP3D5, 4)}}
                });

            _bskD15 = new("犀牛",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOAvoidP3D5, 2_400)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOAvoidP3D5, 1_680)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOAvoidP3D5, 1_200)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOAvoidP3D5, 960)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOAvoidP3D5, 720)}}
                });

            _bskD16 = new("憤怒",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(PartialDamageRateOAvoidP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(PartialDamageRateOAvoidP3D5, .42m)}},
                    {BroochesRare.Mega, new Effect[] {new(PartialDamageRateOAvoidP3D5, .33m)}},
                    {BroochesRare.Kilo, new Effect[] {new(PartialDamageRateOAvoidP3D5, .29m)}},
                    {BroochesRare.Byte, new Effect[] {new(PartialDamageRateOAvoidP3D5, .25m)}}
                });

            _bskD17 = new("小鬼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(SuperArmorBreakPowerRateOAvoidP3D5, .21m)}},
                    {BroochesRare.Giga, new Effect[] {new(SuperArmorBreakPowerRateOAvoidP3D5, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(SuperArmorBreakPowerRateOAvoidP3D5, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(SuperArmorBreakPowerRateOAvoidP3D5, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(SuperArmorBreakPowerRateOAvoidP3D5, .04m)}}
                });

            #endregion

            #region Effect

            _bskE1 = new("固執",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(EndureSecondOSufferP2, 12)}},
                    {BroochesRare.Giga, new Effect[] {new(EndureSecondOSufferP2, 10)}},
                    {BroochesRare.Mega, new Effect[] {new(EndureSecondOSufferP2, 8)}},
                    {BroochesRare.Kilo, new Effect[] {new(EndureSecondOSufferP2, 4)}},
                    {BroochesRare.Byte, new Effect[] {new(EndureSecondOSufferP2, 2)}}
                });

            _bskE2 = new("迅猛",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .21m)}},
                    {BroochesRare.Giga, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .19m)}},
                    {BroochesRare.Mega, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .18m)}},
                    {BroochesRare.Kilo, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .16m)}},
                    {BroochesRare.Byte, new Effect[] {new(SuperArmorBreakPowerRateOHitP5D5, .15m)}}
                });

            _bskE3 = _sdE3 with {Series = BroochesSeries.Bsk};

            _bskE4 = new("鋼鐵",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .08m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .07m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOSufferBossP1D5, .03m)}}
                });

            _bskE5 = new("搖擺",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackSpeedRateOAvoid, .56m)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackSpeedRateOAvoid, .45m)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackSpeedRateOAvoid, .4m)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackSpeedRateOAvoid, .32m)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackSpeedRateOAvoid, .24m)}}
                });

            _bskE6 = new("救濟",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryOAvoidP1, 2_500)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryOAvoidP1, 2_250)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryOAvoidP1, 2_000)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryOAvoidP1, 1_750)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryOAvoidP1, 1_500)}}
                });

            _bskE7 = new("藐視",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalResistanceRateOSufferP8D10, .04m)}}
                });

            _bskE8 = _sdE8 with {Series = BroochesSeries.Bsk};

            _bskE9 = new("發熱",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOUseSkillP1D5, 1_350)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOUseSkillP1D5, 1_050)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOUseSkillP1D5, 750)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOUseSkillP1D5, 450)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOUseSkillP1D5, 150)}}
                });

            _bskE10 = new("恢復",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AccuracyOUseSkillP1D5, 350)}},
                    {BroochesRare.Giga, new Effect[] {new(AccuracyOUseSkillP1D5, 280)}},
                    {BroochesRare.Mega, new Effect[] {new(AccuracyOUseSkillP1D5, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(AccuracyOUseSkillP1D5, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(AccuracyOUseSkillP1D5, 70)}}
                });

            _bskE11 = new("沉重",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOUseSkillP3D5, 3_000)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOUseSkillP3D5, 2_400)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOUseSkillP3D5, 1_800)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOUseSkillP3D5, 1_200)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOUseSkillP3D5, 600)}}
                });

            _bskE12 = new("劍聖",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackORunP3D5, 450)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackORunP3D5, 350)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackORunP3D5, 250)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackORunP3D5, 150)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackORunP3D5, 50)}}
                });

            _bskE13 = new("餅乾",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(SuperArmorBreakPowerRateORunP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(SuperArmorBreakPowerRateORunP1D5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(SuperArmorBreakPowerRateORunP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(SuperArmorBreakPowerRateORunP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(SuperArmorBreakPowerRateORunP1D5, .02m)}}
                });

            _bskE14 = new("充電",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseBreakRateORunP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseBreakRateORunP1D5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseBreakRateORunP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseBreakRateORunP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseBreakRateORunP1D5, .02m)}}
                });

            _bskE15 = new("狂亂",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOKillD5, 1_225)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOKillD5, 700)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOKillD5, 350)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOKillD5, 175)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOKillD5, 87)}}
                });

            _bskE16 = new("狂人",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(SuperArmorBreakPowerRateOKillD5, .16m)}},
                    {BroochesRare.Giga, new Effect[] {new(SuperArmorBreakPowerRateOKillD5, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(SuperArmorBreakPowerRateOKillD5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(SuperArmorBreakPowerRateOKillD5, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(SuperArmorBreakPowerRateOKillD5, .03m)}}
                });

            _bskE17 = new("感覺",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseBreakRateOKillD5, .16m)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseBreakRateOKillD5, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseBreakRateOKillD5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseBreakRateOKillD5, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseBreakRateOKillD5, .03m)}}
                });

            #endregion
        }

        #endregion
    }
}