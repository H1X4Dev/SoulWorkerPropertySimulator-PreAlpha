using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        #region

        private static IReadOnlyCollection<Brooch> SetupFot(ShareEffect share) =>
            new List<Brooch>
            {
                #region Attack

                // fotA1
                new("燃料庫",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.DefenseBreakRate005, share.EvadeM45}},
                        {BroochesRare.Giga, new[] {share.DefenseBreakRate004, share.EvadeM45}},
                        {BroochesRare.Mega, new[] {share.DefenseBreakRate003, share.EvadeM45}},
                        {BroochesRare.Kilo, new[] {share.DefenseBreakRate002, share.EvadeM45}},
                        {BroochesRare.Byte, new[] {share.DefenseBreakRate001, share.EvadeM45}}
                    }),

                // fotA2
                new("投石器",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.DefenseBreakRate005, share.AccuracyM45}},
                        {BroochesRare.Giga, new[] {share.DefenseBreakRate004, share.AccuracyM45}},
                        {BroochesRare.Mega, new[] {share.DefenseBreakRate003, share.AccuracyM45}},
                        {BroochesRare.Kilo, new[] {share.DefenseBreakRate002, share.AccuracyM45}},
                        {BroochesRare.Byte, new[] {share.DefenseBreakRate001, share.AccuracyM45}}
                    }),

                // fotA3
                new("發射器",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.CriticalDamage720, share.AccuracyM25}},
                        {BroochesRare.Giga, new[] {share.CriticalDamage480, share.AccuracyM25}},
                        {BroochesRare.Mega, new[] {share.CriticalDamage270, share.AccuracyM25}},
                        {BroochesRare.Kilo, new[] {share.CriticalDamage180, share.AccuracyM25}},
                        {BroochesRare.Byte, new[] {share.CriticalDamage90, share.AccuracyM25}}
                    }),

                // fotA4
                new("閃電戰",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.CriticalDamage720, share.EvadeM38}},
                        {BroochesRare.Giga, new[] {share.CriticalDamage480, share.EvadeM38}},
                        {BroochesRare.Mega, new[] {share.CriticalDamage270, share.EvadeM38}},
                        {BroochesRare.Kilo, new[] {share.CriticalDamage180, share.EvadeM38}},
                        {BroochesRare.Byte, new[] {share.CriticalDamage90, share.EvadeM38}}
                    }),

                // fotA5
                new("加農",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.Attack600, share.AccuracyM25}},
                        {BroochesRare.Giga, new[] {share.Attack420, share.AccuracyM25}},
                        {BroochesRare.Mega, new[] {share.Attack240, share.AccuracyM25}},
                        {BroochesRare.Kilo, new[] {share.Attack120, share.AccuracyM25}},
                        {BroochesRare.Byte, new[] {share.Attack60, share.AccuracyM25}}
                    }),

                // fotA6
                new("佔領",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.Attack600, share.EvadeM38}},
                        {BroochesRare.Giga, new[] {share.Attack420, share.EvadeM38}},
                        {BroochesRare.Mega, new[] {share.Attack240, share.EvadeM38}},
                        {BroochesRare.Kilo, new[] {share.Attack120, share.EvadeM38}},
                        {BroochesRare.Byte, new[] {share.Attack60, share.EvadeM38}}
                    }),

                // fotA7
                new("支配",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {new(StaticEffectContext.CriticalRate, .08m), share.EvadeM38}},
                        {BroochesRare.Giga, new[] {share.CriticalRate004, share.EvadeM38}},
                        {BroochesRare.Mega, new[] {share.CriticalRate003, share.EvadeM38}},
                        {BroochesRare.Kilo, new[] {share.CriticalRate002, share.EvadeM38}},
                        {BroochesRare.Byte, new[] {share.CriticalRate001, share.EvadeM38}}
                    }),

                // fotA8
                new("游擊隊",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOCriticalD3, 870)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOCriticalD3, 560)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOCriticalD3, 336)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOCriticalD3, 280)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOCriticalD3, 140)}}
                    }),

                // fotA9
                new("勇氣",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOhp30DownThenHitD3, 1_260)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOhp30DownThenHitD3, 810)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOhp30DownThenHitD3, 450)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOhp30DownThenHitD3, 360)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOhp30DownThenHitD3, 180)}}
                    }),

                // fotA10
                new("大將",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.HpRecoveryOHitP15, 320)}},
                        {BroochesRare.Giga, new Effect[] {new(share.HpRecoveryOHitP15, 220)}},
                        {BroochesRare.Mega, new Effect[] {new(share.HpRecoveryOHitP15, 160)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.HpRecoveryOHitP15, 100)}},
                        {BroochesRare.Byte, new Effect[] {new(share.HpRecoveryOHitP15, 40)}}
                    }),

                #endregion

                #region Defense

                // fotD1
                new("戰壕",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.Defense720, share.MoveSpaceRateM001}},
                        {BroochesRare.Giga, new[] {share.Defense480, share.MoveSpaceRateM001}},
                        {BroochesRare.Mega, new[] {share.Defense312, share.MoveSpaceRateM001}},
                        {BroochesRare.Kilo, new[] {share.Defense144, share.MoveSpaceRateM001}},
                        {BroochesRare.Byte, new[] {share.Defense72, share.MoveSpaceRateM001}}
                    }),

                // fotD2
                new("危城",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.Defense720, share.AttackSpeedRateM001}},
                        {BroochesRare.Giga, new[] {share.Defense480, share.AttackSpeedRateM001}},
                        {BroochesRare.Mega, new[] {share.Defense312, share.AttackSpeedRateM001}},
                        {BroochesRare.Kilo, new[] {share.Defense144, share.AttackSpeedRateM001}},
                        {BroochesRare.Byte, new[] {share.Defense72, share.AttackSpeedRateM001}}
                    }),

                // fotD3
                new("防禦",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.Defense720, share.AccuracyM30}},
                        {BroochesRare.Giga, new[] {share.Defense480, share.AccuracyM30}},
                        {BroochesRare.Mega, new[] {share.Defense312, share.AccuracyM30}},
                        {BroochesRare.Kilo, new[] {share.Defense144, share.AccuracyM30}},
                        {BroochesRare.Byte, new[] {share.Defense72, share.AccuracyM30}}
                    }),

                // fotD4
                new("地圖",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.HpRate015, share.MoveSpaceRateM001}},
                        {BroochesRare.Giga, new[] {share.HpRate011, share.MoveSpaceRateM001}},
                        {BroochesRare.Mega, new[] {share.HpRate006, share.MoveSpaceRateM001}},
                        {BroochesRare.Kilo, new[] {share.HpRate004, share.MoveSpaceRateM001}},
                        {BroochesRare.Byte, new[] {share.HpRate002, share.MoveSpaceRateM001}}
                    }),

                // fotD5
                new("堡壘",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.HpRate015, share.AttackSpeedRateM001}},
                        {BroochesRare.Giga, new[] {share.HpRate011, share.AttackSpeedRateM001}},
                        {BroochesRare.Mega, new[] {share.HpRate006, share.AttackSpeedRateM001}},
                        {BroochesRare.Kilo, new[] {share.HpRate004, share.AttackSpeedRateM001}},
                        {BroochesRare.Byte, new[] {share.HpRate002, share.AttackSpeedRateM001}}
                    }),

                // fotD6
                new("停留",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.HpRate015, share.AccuracyM30}},
                        {BroochesRare.Giga, new[] {share.HpRate011, share.AccuracyM30}},
                        {BroochesRare.Mega, new[] {share.HpRate006, share.AccuracyM30}},
                        {BroochesRare.Kilo, new[] {share.HpRate004, share.AccuracyM30}},
                        {BroochesRare.Byte, new[] {share.HpRate002, share.AccuracyM30}}
                    }),

                // fotD7
                new("堅固的",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.HpRate015, share.EvadeM50}},
                        {BroochesRare.Giga, new[] {share.HpRate011, share.EvadeM50}},
                        {BroochesRare.Mega, new[] {share.HpRate006, share.EvadeM50}},
                        {BroochesRare.Kilo, new[] {share.HpRate004, share.EvadeM50}},
                        {BroochesRare.Byte, new[] {share.HpRate002, share.EvadeM50}}
                    }),

                // fotD8
                new("摩擦",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.HpRecoveryOSufferP3, 1_000)}},
                        {BroochesRare.Giga, new Effect[] {new(share.HpRecoveryOSufferP3, 660)}},
                        {BroochesRare.Mega, new Effect[] {new(share.HpRecoveryOSufferP3, 500)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.HpRecoveryOSufferP3, 330)}},
                        {BroochesRare.Byte, new Effect[] {new(share.HpRecoveryOSufferP3, 160)}}
                    }),

                // fotD9
                new("穩固",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseOHp50DownD10, 770)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseOHp50DownD10, 490)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseOHp50DownD10, 280)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseOHp50DownD10, 140)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseOHp50DownD10, 70)}}
                    }),

                // fotD10
                new("休戰",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalResistanceRateOHp50DownD10, .27m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalResistanceRateOHp50DownD10, .18m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalResistanceRateOHp50DownD10, .12m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalResistanceRateOHp50DownD10, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalResistanceRateOHp50DownD10, .03m)}}
                    }),

                #endregion

                #region Effect

                // fotE1
                new("掃蕩",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseORunP1D5, 400)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseORunP1D5, 300)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseORunP1D5, 220)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseORunP1D5, 80)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseORunP1D5, 40)}}
                    }),

                // fotE2
                new("戰術",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackOKillD5, 1_200)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackOKillD5, 1_000)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackOKillD5, 800)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackOKillD5, 500)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackOKillD5, 200)}}
                    }),

                // fotE3
                new("防護",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseOKillD5, 850)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseOKillD5, 575)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseOKillD5, 400)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseOKillD5, 250)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseOKillD5, 100)}}
                    }),

                // fotE4
                new("撤退",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.HpRecoveryRateOUseAvoidP1, .15m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.HpRecoveryRateOUseAvoidP1, .11m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.HpRecoveryRateOUseAvoidP1, .08m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.HpRecoveryRateOUseAvoidP1, .05m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.HpRecoveryRateOUseAvoidP1, .02m)}}
                    }),

                // fotE5
                new("疏散",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DamageReductionRateOKillD5, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DamageReductionRateOKillD5, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DamageReductionRateOKillD5, .06m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DamageReductionRateOKillD5, .03m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DamageReductionRateOKillD5, .01m)}}
                    }),

                // fotE6
                new("狙擊",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.SoulGateRecoveryRateOUseSkillP1, .15m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.SoulGateRecoveryRateOUseSkillP1, .12m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.SoulGateRecoveryRateOUseSkillP1, .09m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.SoulGateRecoveryRateOUseSkillP1, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.SoulGateRecoveryRateOUseSkillP1, .03m)}}
                    }),

                // fotE7
                new("打擾",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseOSufferP5D10, 150)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseOSufferP5D10, 100)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseOSufferP5D10, 60)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseOSufferP5D10, 30)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseOSufferP5D10, 10)}}
                    }),

                // fotE8
                new("偵察",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackOHitP1D5, 400)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackOHitP1D5, 300)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackOHitP1D5, 175)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackOHitP1D5, 75)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackOHitP1D5, 25)}}
                    }),

                // fotE9
                new("對策",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.InvincibleSecondOHp20DownP1, 1.5m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.InvincibleSecondOHp20DownP1, 1.25m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.InvincibleSecondOHp20DownP1, 1)}},
                        {
                            BroochesRare.Kilo,
                            new Effect[] {new(new(Property.InvincibleSecond, Opportunity.Hp15Down, .1m), 1)}
                        },
                        {
                            BroochesRare.Byte,
                            new Effect[] {new(new(Property.InvincibleSecond, Opportunity.Hp10Down, .1m), 1)}
                        }
                    }),

                // fotE10
                new("保護",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.DefenseOUseSkillP1D5, 800)}},
                        {BroochesRare.Giga, new Effect[] {new(share.DefenseOUseSkillP1D5, 600)}},
                        {BroochesRare.Mega, new Effect[] {new(share.DefenseOUseSkillP1D5, 440)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.DefenseOUseSkillP1D5, 280)}},
                        {BroochesRare.Byte, new Effect[] {new(share.DefenseOUseSkillP1D5, 140)}}
                    })

                #endregion
            };

        #endregion
    }
}