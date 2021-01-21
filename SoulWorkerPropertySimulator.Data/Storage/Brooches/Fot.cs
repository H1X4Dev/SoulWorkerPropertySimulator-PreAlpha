using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        private static Brooches _fotA1;
        private static Brooches _fotA2;
        private static Brooches _fotA3;
        private static Brooches _fotA4;
        private static Brooches _fotA5;
        private static Brooches _fotA6;
        private static Brooches _fotA7;
        private static Brooches _fotA8;
        private static Brooches _fotA9;
        private static Brooches _fotA10;

        private static Brooches _fotD1;
        private static Brooches _fotD2;
        private static Brooches _fotD3;
        private static Brooches _fotD4;
        private static Brooches _fotD5;
        private static Brooches _fotD6;
        private static Brooches _fotD7;
        private static Brooches _fotD8;
        private static Brooches _fotD9;
        private static Brooches _fotD10;

        private static Brooches _fotE1;
        private static Brooches _fotE2;
        private static Brooches _fotE3;
        private static Brooches _fotE4;
        private static Brooches _fotE5;
        private static Brooches _fotE6;
        private static Brooches _fotE7;
        private static Brooches _fotE8;
        private static Brooches _fotE9;
        private static Brooches _fotE10;

        #region

        private static void SetupFot()
        {
            #region Attack

            _fotA1 = new("燃料庫",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {DefenseBreakRate005, EvadeM45}},
                    {BroochesRare.Giga, new[] {DefenseBreakRate004, EvadeM45}},
                    {BroochesRare.Mega, new[] {DefenseBreakRate003, EvadeM45}},
                    {BroochesRare.Kilo, new[] {DefenseBreakRate002, EvadeM45}},
                    {BroochesRare.Byte, new[] {DefenseBreakRate001, EvadeM45}}
                });

            _fotA2 = new("投石器",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {DefenseBreakRate005, AccuracyM45}},
                    {BroochesRare.Giga, new[] {DefenseBreakRate004, AccuracyM45}},
                    {BroochesRare.Mega, new[] {DefenseBreakRate003, AccuracyM45}},
                    {BroochesRare.Kilo, new[] {DefenseBreakRate002, AccuracyM45}},
                    {BroochesRare.Byte, new[] {DefenseBreakRate001, AccuracyM45}}
                });

            _fotA3 = new("發射器",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {CriticalDamage720, AccuracyM25}},
                    {BroochesRare.Giga, new[] {CriticalDamage480, AccuracyM25}},
                    {BroochesRare.Mega, new[] {CriticalDamage270, AccuracyM25}},
                    {BroochesRare.Kilo, new[] {CriticalDamage180, AccuracyM25}},
                    {BroochesRare.Byte, new[] {CriticalDamage90, AccuracyM25}}
                });

            _fotA4 = new("閃電戰",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {CriticalDamage720, EvadeM38}},
                    {BroochesRare.Giga, new[] {CriticalDamage480, EvadeM38}},
                    {BroochesRare.Mega, new[] {CriticalDamage270, EvadeM38}},
                    {BroochesRare.Kilo, new[] {CriticalDamage180, EvadeM38}},
                    {BroochesRare.Byte, new[] {CriticalDamage90, EvadeM38}}
                });

            _fotA5 = new("加農",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Attack600, AccuracyM25}},
                    {BroochesRare.Giga, new[] {Attack420, AccuracyM25}},
                    {BroochesRare.Mega, new[] {Attack240, AccuracyM25}},
                    {BroochesRare.Kilo, new[] {Attack120, AccuracyM25}},
                    {BroochesRare.Byte, new[] {Attack60, AccuracyM25}}
                });

            _fotA6 = new("佔領",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Attack600, EvadeM38}},
                    {BroochesRare.Giga, new[] {Attack420, EvadeM38}},
                    {BroochesRare.Mega, new[] {Attack240, EvadeM38}},
                    {BroochesRare.Kilo, new[] {Attack120, EvadeM38}},
                    {BroochesRare.Byte, new[] {Attack60, EvadeM38}}
                });

            _fotA7 = new("支配",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.CriticalRate, .08m), EvadeM38}},
                    {BroochesRare.Giga, new[] {CriticalRate004, EvadeM38}},
                    {BroochesRare.Mega, new[] {CriticalRate003, EvadeM38}},
                    {BroochesRare.Kilo, new[] {CriticalRate002, EvadeM38}},
                    {BroochesRare.Byte, new[] {CriticalRate001, EvadeM38}}
                });

            _fotA8 = new("游擊隊",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOCriticalD3, 870)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOCriticalD3, 560)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOCriticalD3, 336)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOCriticalD3, 280)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOCriticalD3, 140)}}
                });

            _fotA9 = new("勇氣",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOhp30DownThenHitD3, 1_260)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOhp30DownThenHitD3, 810)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOhp30DownThenHitD3, 450)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOhp30DownThenHitD3, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOhp30DownThenHitD3, 180)}}
                });

            _fotA10 = new("大將",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryOHitP15, 320)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryOHitP15, 220)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryOHitP15, 160)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryOHitP15, 100)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryOHitP15, 40)}}
                });

            #endregion

            #region Defense

            _fotD1 = new("戰壕",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Defense720, MoveSpaceRateM001}},
                    {BroochesRare.Giga, new[] {Defense480, MoveSpaceRateM001}},
                    {BroochesRare.Mega, new[] {Defense312, MoveSpaceRateM001}},
                    {BroochesRare.Kilo, new[] {Defense144, MoveSpaceRateM001}},
                    {BroochesRare.Byte, new[] {Defense72, MoveSpaceRateM001}}
                });

            _fotD2 = new("危城",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Defense720, AttackSpeedRateM001}},
                    {BroochesRare.Giga, new[] {Defense480, AttackSpeedRateM001}},
                    {BroochesRare.Mega, new[] {Defense312, AttackSpeedRateM001}},
                    {BroochesRare.Kilo, new[] {Defense144, AttackSpeedRateM001}},
                    {BroochesRare.Byte, new[] {Defense72, AttackSpeedRateM001}}
                });

            _fotD3 = new("防禦",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {Defense720, AccuracyM30}},
                    {BroochesRare.Giga, new[] {Defense480, AccuracyM30}},
                    {BroochesRare.Mega, new[] {Defense312, AccuracyM30}},
                    {BroochesRare.Kilo, new[] {Defense144, AccuracyM30}},
                    {BroochesRare.Byte, new[] {Defense72, AccuracyM30}}
                });

            _fotD4 = new("地圖",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {HpRate015, MoveSpaceRateM001}},
                    {BroochesRare.Giga, new[] {HpRate011, MoveSpaceRateM001}},
                    {BroochesRare.Mega, new[] {HpRate006, MoveSpaceRateM001}},
                    {BroochesRare.Kilo, new[] {HpRate004, MoveSpaceRateM001}},
                    {BroochesRare.Byte, new[] {HpRate002, MoveSpaceRateM001}}
                });

            _fotD5 = new("堡壘",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {HpRate015, AttackSpeedRateM001}},
                    {BroochesRare.Giga, new[] {HpRate011, AttackSpeedRateM001}},
                    {BroochesRare.Mega, new[] {HpRate006, AttackSpeedRateM001}},
                    {BroochesRare.Kilo, new[] {HpRate004, AttackSpeedRateM001}},
                    {BroochesRare.Byte, new[] {HpRate002, AttackSpeedRateM001}}
                });

            _fotD6 = new("停留",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {HpRate015, AccuracyM30}},
                    {BroochesRare.Giga, new[] {HpRate011, AccuracyM30}},
                    {BroochesRare.Mega, new[] {HpRate006, AccuracyM30}},
                    {BroochesRare.Kilo, new[] {HpRate004, AccuracyM30}},
                    {BroochesRare.Byte, new[] {HpRate002, AccuracyM30}}
                });

            _fotD7 = new("堅固的",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {HpRate015, EvadeM50}},
                    {BroochesRare.Giga, new[] {HpRate011, EvadeM50}},
                    {BroochesRare.Mega, new[] {HpRate006, EvadeM50}},
                    {BroochesRare.Kilo, new[] {HpRate004, EvadeM50}},
                    {BroochesRare.Byte, new[] {HpRate002, EvadeM50}}
                });

            _fotD8 = new("摩擦",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryOSufferP3, 1_000)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryOSufferP3, 660)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryOSufferP3, 500)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryOSufferP3, 330)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryOSufferP3, 160)}}
                });

            _fotD9 = new("穩固",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseOHp50DownD10, 770)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseOHp50DownD10, 490)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseOHp50DownD10, 280)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseOHp50DownD10, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseOHp50DownD10, 70)}}
                });

            _fotD10 = new("休戰",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalResistanceRateOHP50DownD10, .27m)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalResistanceRateOHP50DownD10, .18m)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalResistanceRateOHP50DownD10, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalResistanceRateOHP50DownD10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalResistanceRateOHP50DownD10, .03m)}}
                });

            #endregion

            #region Effect

            _fotE1 = new("掃蕩",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseORunP1D5, 400)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseORunP1D5, 300)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseORunP1D5, 220)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseORunP1D5, 80)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseORunP1D5, 40)}}
                });

            _fotE2 = new("戰術",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOKillD5, 1_200)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOKillD5, 1_000)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOKillD5, 800)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOKillD5, 500)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOKillD5, 200)}}
                });

            _fotE3 = new("防護",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseOKillD5, 850)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseOKillD5, 575)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseOKillD5, 400)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseOKillD5, 250)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseOKillD5, 100)}}
                });

            _fotE4 = new("撤退",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryRateOUseAvoidP1, .15m)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryRateOUseAvoidP1, .11m)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryRateOUseAvoidP1, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryRateOUseAvoidP1, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryRateOUseAvoidP1, .02m)}}
                });

            _fotE5 = new("疏散",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DamageReductionRateOKillD5, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(DamageReductionRateOKillD5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(DamageReductionRateOKillD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(DamageReductionRateOKillD5, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(DamageReductionRateOKillD5, .01m)}}
                });

            _fotE6 = new("狙擊",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(SoulGateRecoveryRateOUseSkillP1, .15m)}},
                    {BroochesRare.Giga, new Effect[] {new(SoulGateRecoveryRateOUseSkillP1, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(SoulGateRecoveryRateOUseSkillP1, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(SoulGateRecoveryRateOUseSkillP1, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(SoulGateRecoveryRateOUseSkillP1, .03m)}}
                });

            _fotE7 = new("打擾",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseOSufferP5D10, 150)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseOSufferP5D10, 100)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseOSufferP5D10, 60)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseOSufferP5D10, 30)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseOSufferP5D10, 10)}}
                });

            _fotE8 = new("偵察",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOHitP1D5, 400)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOHitP1D5, 300)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOHitP1D5, 175)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOHitP1D5, 75)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOHitP1D5, 25)}}
                });

            _fotE9 = new("對策",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(InvincibleSecondOHp20DownP1, 1.5m)}},
                    {BroochesRare.Giga, new Effect[] {new(InvincibleSecondOHp20DownP1, 1.25m)}},
                    {BroochesRare.Mega, new Effect[] {new(InvincibleSecondOHp20DownP1, 1)}},
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(new(Property.InvincibleSecond, Ppportunity.HP15Down, .1m), 1)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(new(Property.InvincibleSecond, Ppportunity.HP10Down, .1m), 1)}
                    }
                });

            _fotE10 = new("保護",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(DefenseOUseSkillP1D5, 800)}},
                    {BroochesRare.Giga, new Effect[] {new(DefenseOUseSkillP1D5, 600)}},
                    {BroochesRare.Mega, new Effect[] {new(DefenseOUseSkillP1D5, 440)}},
                    {BroochesRare.Kilo, new Effect[] {new(DefenseOUseSkillP1D5, 280)}},
                    {BroochesRare.Byte, new Effect[] {new(DefenseOUseSkillP1D5, 140)}}
                });

            #endregion
        }

        #endregion
    }
}