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
                    {BroochesRare.Tera, new[] {ShareEffect.DefenseBreakRate005, ShareEffect.EvadeM45}},
                    {BroochesRare.Giga, new[] {ShareEffect.DefenseBreakRate004, ShareEffect.EvadeM45}},
                    {BroochesRare.Mega, new[] {ShareEffect.DefenseBreakRate003, ShareEffect.EvadeM45}},
                    {BroochesRare.Kilo, new[] {ShareEffect.DefenseBreakRate002, ShareEffect.EvadeM45}},
                    {BroochesRare.Byte, new[] {ShareEffect.DefenseBreakRate001, ShareEffect.EvadeM45}}
                });

            _fotA2 = new("投石器",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.DefenseBreakRate005, ShareEffect.AccuracyM45}},
                    {BroochesRare.Giga, new[] {ShareEffect.DefenseBreakRate004, ShareEffect.AccuracyM45}},
                    {BroochesRare.Mega, new[] {ShareEffect.DefenseBreakRate003, ShareEffect.AccuracyM45}},
                    {BroochesRare.Kilo, new[] {ShareEffect.DefenseBreakRate002, ShareEffect.AccuracyM45}},
                    {BroochesRare.Byte, new[] {ShareEffect.DefenseBreakRate001, ShareEffect.AccuracyM45}}
                });

            _fotA3 = new("發射器",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.CriticalDamage720, ShareEffect.AccuracyM25}},
                    {BroochesRare.Giga, new[] {ShareEffect.CriticalDamage480, ShareEffect.AccuracyM25}},
                    {BroochesRare.Mega, new[] {ShareEffect.CriticalDamage270, ShareEffect.AccuracyM25}},
                    {BroochesRare.Kilo, new[] {ShareEffect.CriticalDamage180, ShareEffect.AccuracyM25}},
                    {BroochesRare.Byte, new[] {ShareEffect.CriticalDamage90, ShareEffect.AccuracyM25}}
                });

            _fotA4 = new("閃電戰",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.CriticalDamage720, ShareEffect.EvadeM38}},
                    {BroochesRare.Giga, new[] {ShareEffect.CriticalDamage480, ShareEffect.EvadeM38}},
                    {BroochesRare.Mega, new[] {ShareEffect.CriticalDamage270, ShareEffect.EvadeM38}},
                    {BroochesRare.Kilo, new[] {ShareEffect.CriticalDamage180, ShareEffect.EvadeM38}},
                    {BroochesRare.Byte, new[] {ShareEffect.CriticalDamage90, ShareEffect.EvadeM38}}
                });

            _fotA5 = new("加農",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Attack600, ShareEffect.AccuracyM25}},
                    {BroochesRare.Giga, new[] {ShareEffect.Attack420, ShareEffect.AccuracyM25}},
                    {BroochesRare.Mega, new[] {ShareEffect.Attack240, ShareEffect.AccuracyM25}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Attack120, ShareEffect.AccuracyM25}},
                    {BroochesRare.Byte, new[] {ShareEffect.Attack60, ShareEffect.AccuracyM25}}
                });

            _fotA6 = new("佔領",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Attack600, ShareEffect.EvadeM38}},
                    {BroochesRare.Giga, new[] {ShareEffect.Attack420, ShareEffect.EvadeM38}},
                    {BroochesRare.Mega, new[] {ShareEffect.Attack240, ShareEffect.EvadeM38}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Attack120, ShareEffect.EvadeM38}},
                    {BroochesRare.Byte, new[] {ShareEffect.Attack60, ShareEffect.EvadeM38}}
                });

            _fotA7 = new("支配",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.CriticalRate, .08m), ShareEffect.EvadeM38}},
                    {BroochesRare.Giga, new[] {ShareEffect.CriticalRate004, ShareEffect.EvadeM38}},
                    {BroochesRare.Mega, new[] {ShareEffect.CriticalRate003, ShareEffect.EvadeM38}},
                    {BroochesRare.Kilo, new[] {ShareEffect.CriticalRate002, ShareEffect.EvadeM38}},
                    {BroochesRare.Byte, new[] {ShareEffect.CriticalRate001, ShareEffect.EvadeM38}}
                });

            _fotA8 = new("游擊隊",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 870)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 560)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 336)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 280)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 140)}}
                });

            _fotA9 = new("勇氣",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 1_260)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 810)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 450)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 180)}}
                });

            _fotA10 = new("大將",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 320)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 220)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 160)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 100)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 40)}}
                });

            #endregion

            #region Defense

            _fotD1 = new("戰壕",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Defense720, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Giga, new[] {ShareEffect.Defense480, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Mega, new[] {ShareEffect.Defense312, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Defense144, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Byte, new[] {ShareEffect.Defense72, ShareEffect.MoveSpaceRateM001}}
                });

            _fotD2 = new("危城",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Defense720, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Giga, new[] {ShareEffect.Defense480, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Mega, new[] {ShareEffect.Defense312, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Defense144, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Byte, new[] {ShareEffect.Defense72, ShareEffect.AttackSpeedRateM001}}
                });

            _fotD3 = new("防禦",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.Defense720, ShareEffect.AccuracyM30}},
                    {BroochesRare.Giga, new[] {ShareEffect.Defense480, ShareEffect.AccuracyM30}},
                    {BroochesRare.Mega, new[] {ShareEffect.Defense312, ShareEffect.AccuracyM30}},
                    {BroochesRare.Kilo, new[] {ShareEffect.Defense144, ShareEffect.AccuracyM30}},
                    {BroochesRare.Byte, new[] {ShareEffect.Defense72, ShareEffect.AccuracyM30}}
                });

            _fotD4 = new("地圖",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.MoveSpaceRateM001}},
                    {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.MoveSpaceRateM001}}
                });

            _fotD5 = new("堡壘",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.AttackSpeedRateM001}},
                    {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.AttackSpeedRateM001}}
                });

            _fotD6 = new("停留",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.AccuracyM30}},
                    {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.AccuracyM30}},
                    {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.AccuracyM30}},
                    {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.AccuracyM30}},
                    {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.AccuracyM30}}
                });

            _fotD7 = new("堅固的",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.EvadeM50}},
                    {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.EvadeM50}},
                    {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.EvadeM50}},
                    {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.EvadeM50}},
                    {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.EvadeM50}}
                });

            _fotD8 = new("摩擦",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 1_000)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 660)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 500)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 330)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 160)}}
                });

            _fotD9 = new("穩固",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 770)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 490)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 280)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 70)}}
                });

            _fotD10 = new("休戰",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .27m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .18m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .03m)}}
                });

            #endregion

            #region Effect

            _fotE1 = new("掃蕩",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseORunP1D5, 400)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseORunP1D5, 300)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseORunP1D5, 220)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseORunP1D5, 80)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseORunP1D5, 40)}}
                });

            _fotE2 = new("戰術",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOKillD5, 1_200)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOKillD5, 1_000)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOKillD5, 800)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOKillD5, 500)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOKillD5, 200)}}
                });

            _fotE3 = new("防護",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOKillD5, 850)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOKillD5, 575)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOKillD5, 400)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOKillD5, 250)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOKillD5, 100)}}
                });

            _fotE4 = new("撤退",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .15m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .11m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .02m)}}
                });

            _fotE5 = new("疏散",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .01m)}}
                });

            _fotE6 = new("狙擊",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .15m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .03m)}}
                });

            _fotE7 = new("打擾",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 150)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 100)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 60)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 30)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 10)}}
                });

            _fotE8 = new("偵察",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOHitP1D5, 400)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOHitP1D5, 300)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOHitP1D5, 175)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOHitP1D5, 75)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOHitP1D5, 25)}}
                });

            _fotE9 = new("對策",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.InvincibleSecondOHp20DownP1, 1.5m)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.InvincibleSecondOHp20DownP1, 1.25m)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.InvincibleSecondOHp20DownP1, 1)}},
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(new(Property.InvincibleSecond, Opportunity.HP15Down, .1m), 1)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(new(Property.InvincibleSecond, Opportunity.HP10Down, .1m), 1)}
                    }
                });

            _fotE10 = new("保護",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 800)}},
                    {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 600)}},
                    {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 440)}},
                    {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 280)}},
                    {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 140)}}
                });

            #endregion
        }

        #endregion
    }
}