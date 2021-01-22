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

        private static IReadOnlyCollection<Brooch> SetupFot() =>
            new List<Brooch>
            {
                #region Attack

                // fotA1
                new("燃料庫",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.DefenseBreakRate005, ShareEffect.EvadeM45}},
                        {BroochesRare.Giga, new[] {ShareEffect.DefenseBreakRate004, ShareEffect.EvadeM45}},
                        {BroochesRare.Mega, new[] {ShareEffect.DefenseBreakRate003, ShareEffect.EvadeM45}},
                        {BroochesRare.Kilo, new[] {ShareEffect.DefenseBreakRate002, ShareEffect.EvadeM45}},
                        {BroochesRare.Byte, new[] {ShareEffect.DefenseBreakRate001, ShareEffect.EvadeM45}}
                    }),

                // fotA2
                new("投石器",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.DefenseBreakRate005, ShareEffect.AccuracyM45}},
                        {BroochesRare.Giga, new[] {ShareEffect.DefenseBreakRate004, ShareEffect.AccuracyM45}},
                        {BroochesRare.Mega, new[] {ShareEffect.DefenseBreakRate003, ShareEffect.AccuracyM45}},
                        {BroochesRare.Kilo, new[] {ShareEffect.DefenseBreakRate002, ShareEffect.AccuracyM45}},
                        {BroochesRare.Byte, new[] {ShareEffect.DefenseBreakRate001, ShareEffect.AccuracyM45}}
                    }),

                // fotA3
                new("發射器",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.CriticalDamage720, ShareEffect.AccuracyM25}},
                        {BroochesRare.Giga, new[] {ShareEffect.CriticalDamage480, ShareEffect.AccuracyM25}},
                        {BroochesRare.Mega, new[] {ShareEffect.CriticalDamage270, ShareEffect.AccuracyM25}},
                        {BroochesRare.Kilo, new[] {ShareEffect.CriticalDamage180, ShareEffect.AccuracyM25}},
                        {BroochesRare.Byte, new[] {ShareEffect.CriticalDamage90, ShareEffect.AccuracyM25}}
                    }),

                // fotA4
                new("閃電戰",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.CriticalDamage720, ShareEffect.EvadeM38}},
                        {BroochesRare.Giga, new[] {ShareEffect.CriticalDamage480, ShareEffect.EvadeM38}},
                        {BroochesRare.Mega, new[] {ShareEffect.CriticalDamage270, ShareEffect.EvadeM38}},
                        {BroochesRare.Kilo, new[] {ShareEffect.CriticalDamage180, ShareEffect.EvadeM38}},
                        {BroochesRare.Byte, new[] {ShareEffect.CriticalDamage90, ShareEffect.EvadeM38}}
                    }),

                // fotA5
                new("加農",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.Attack600, ShareEffect.AccuracyM25}},
                        {BroochesRare.Giga, new[] {ShareEffect.Attack420, ShareEffect.AccuracyM25}},
                        {BroochesRare.Mega, new[] {ShareEffect.Attack240, ShareEffect.AccuracyM25}},
                        {BroochesRare.Kilo, new[] {ShareEffect.Attack120, ShareEffect.AccuracyM25}},
                        {BroochesRare.Byte, new[] {ShareEffect.Attack60, ShareEffect.AccuracyM25}}
                    }),

                // fotA6
                new("佔領",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.Attack600, ShareEffect.EvadeM38}},
                        {BroochesRare.Giga, new[] {ShareEffect.Attack420, ShareEffect.EvadeM38}},
                        {BroochesRare.Mega, new[] {ShareEffect.Attack240, ShareEffect.EvadeM38}},
                        {BroochesRare.Kilo, new[] {ShareEffect.Attack120, ShareEffect.EvadeM38}},
                        {BroochesRare.Byte, new[] {ShareEffect.Attack60, ShareEffect.EvadeM38}}
                    }),

                // fotA7
                new("支配",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {new(StaticEffect.CriticalRate, .08m), ShareEffect.EvadeM38}},
                        {BroochesRare.Giga, new[] {ShareEffect.CriticalRate004, ShareEffect.EvadeM38}},
                        {BroochesRare.Mega, new[] {ShareEffect.CriticalRate003, ShareEffect.EvadeM38}},
                        {BroochesRare.Kilo, new[] {ShareEffect.CriticalRate002, ShareEffect.EvadeM38}},
                        {BroochesRare.Byte, new[] {ShareEffect.CriticalRate001, ShareEffect.EvadeM38}}
                    }),

                // fotA8
                new("游擊隊",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 870)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 560)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 336)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 280)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalDamageOCriticalD3, 140)}}
                    }),

                // fotA9
                new("勇氣",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {
                            BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 1_260)}
                        },
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 810)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 450)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 360)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalDamageOhp30DownThenHitD3, 180)}}
                    }),

                // fotA10
                new("大將",
                    BroochesSeries.Fot,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 320)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 220)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 160)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 100)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOHitP15, 40)}}
                    }),

                #endregion

                #region Defense

                // fotD1
                new("戰壕",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.Defense720, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Giga, new[] {ShareEffect.Defense480, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Mega, new[] {ShareEffect.Defense312, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Kilo, new[] {ShareEffect.Defense144, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Byte, new[] {ShareEffect.Defense72, ShareEffect.MoveSpaceRateM001}}
                    }),

                // fotD2
                new("危城",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.Defense720, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Giga, new[] {ShareEffect.Defense480, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Mega, new[] {ShareEffect.Defense312, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Kilo, new[] {ShareEffect.Defense144, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Byte, new[] {ShareEffect.Defense72, ShareEffect.AttackSpeedRateM001}}
                    }),

                // fotD3
                new("防禦",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.Defense720, ShareEffect.AccuracyM30}},
                        {BroochesRare.Giga, new[] {ShareEffect.Defense480, ShareEffect.AccuracyM30}},
                        {BroochesRare.Mega, new[] {ShareEffect.Defense312, ShareEffect.AccuracyM30}},
                        {BroochesRare.Kilo, new[] {ShareEffect.Defense144, ShareEffect.AccuracyM30}},
                        {BroochesRare.Byte, new[] {ShareEffect.Defense72, ShareEffect.AccuracyM30}}
                    }),

                // fotD4
                new("地圖",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.MoveSpaceRateM001}},
                        {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.MoveSpaceRateM001}}
                    }),

                // fotD5
                new("堡壘",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.AttackSpeedRateM001}},
                        {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.AttackSpeedRateM001}}
                    }),

                // fotD6
                new("停留",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.AccuracyM30}},
                        {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.AccuracyM30}},
                        {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.AccuracyM30}},
                        {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.AccuracyM30}},
                        {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.AccuracyM30}}
                    }),

                // fotD7
                new("堅固的",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {ShareEffect.HpRate015, ShareEffect.EvadeM50}},
                        {BroochesRare.Giga, new[] {ShareEffect.HpRate011, ShareEffect.EvadeM50}},
                        {BroochesRare.Mega, new[] {ShareEffect.HpRate006, ShareEffect.EvadeM50}},
                        {BroochesRare.Kilo, new[] {ShareEffect.HpRate004, ShareEffect.EvadeM50}},
                        {BroochesRare.Byte, new[] {ShareEffect.HpRate002, ShareEffect.EvadeM50}}
                    }),

                // fotD8
                new("摩擦",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 1_000)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 660)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 500)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 330)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryOSufferP3, 160)}}
                    }),

                // fotD9
                new("穩固",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 770)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 490)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 280)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 140)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOHp50DownD10, 70)}}
                    }),

                // fotD10
                new("休戰",
                    BroochesSeries.Fot,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {
                            BroochesRare.Tera, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .27m)}
                        },
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .18m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .12m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.CriticalResistanceRateOHp50DownD10, .03m)}}
                    }),

                #endregion

                #region Effect

                // fotE1
                new("掃蕩",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseORunP1D5, 400)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseORunP1D5, 300)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseORunP1D5, 220)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseORunP1D5, 80)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseORunP1D5, 40)}}
                    }),

                // fotE2
                new("戰術",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOKillD5, 1_200)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOKillD5, 1_000)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOKillD5, 800)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOKillD5, 500)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOKillD5, 200)}}
                    }),

                // fotE3
                new("防護",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOKillD5, 850)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOKillD5, 575)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOKillD5, 400)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOKillD5, 250)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOKillD5, 100)}}
                    }),

                // fotE4
                new("撤退",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .15m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .11m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .08m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .05m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.HpRecoveryRateOUseAvoidP1, .02m)}}
                    }),

                // fotE5
                new("疏散",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .06m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .03m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DamageReductionRateOKillD5, .01m)}}
                    }),

                // fotE6
                new("狙擊",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .15m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .12m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .09m)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .06m)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.SoulGateRecoveryRateOUseSkillP1, .03m)}}
                    }),

                // fotE7
                new("打擾",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 150)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 100)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 60)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 30)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOSufferP5D10, 10)}}
                    }),

                // fotE8
                new("偵察",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.AttackOHitP1D5, 400)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.AttackOHitP1D5, 300)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.AttackOHitP1D5, 175)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.AttackOHitP1D5, 75)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.AttackOHitP1D5, 25)}}
                    }),

                // fotE9
                new("對策",
                    BroochesSeries.Fot,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.InvincibleSecondOHp20DownP1, 1.5m)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.InvincibleSecondOHp20DownP1, 1.25m)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.InvincibleSecondOHp20DownP1, 1)}},
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
                        {BroochesRare.Tera, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 800)}},
                        {BroochesRare.Giga, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 600)}},
                        {BroochesRare.Mega, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 440)}},
                        {BroochesRare.Kilo, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 280)}},
                        {BroochesRare.Byte, new Effect[] {new(ShareEffect.DefenseOUseSkillP1D5, 140)}}
                    })

                #endregion
            };

        #endregion
    }
}