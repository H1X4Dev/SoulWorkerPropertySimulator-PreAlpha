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

        private static IReadOnlyCollection<Brooch> SetupSin(ShareEffect share) =>
            new List<Brooch>
            {
                #region Attack

                // sinA1
                new("猝死",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffect.CriticalRate, .05m)}},
                        {BroochesRare.Giga, new[] {share.CriticalRate004}},
                        {BroochesRare.Mega, new[] {share.CriticalRate003}},
                        {BroochesRare.Kilo, new[] {share.CriticalRate002}},
                        {BroochesRare.Byte, new[] {share.CriticalRate001}}
                    }),

                // sinA2
                new("暗殺",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.SuperArmorBreakPowerRate006, share.EvadeM30}},
                        {BroochesRare.Giga, new[] {share.SuperArmorBreakPowerRate004, share.EvadeM30}},
                        {BroochesRare.Mega, new[] {share.SuperArmorBreakPowerRate003, share.EvadeM30}},
                        {BroochesRare.Kilo, new[] {share.SuperArmorBreakPowerRate002, share.EvadeM30}},
                        {BroochesRare.Byte, new[] {share.SuperArmorBreakPowerRate001, share.EvadeM30}}
                    }),

                // sinA3
                new("刺激者",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.SuperArmorBreakPowerRate006, share.HpRateM005}},
                        {BroochesRare.Giga, new[] {share.SuperArmorBreakPowerRate004, share.HpRateM005}},
                        {BroochesRare.Mega, new[] {share.SuperArmorBreakPowerRate003, share.HpRateM005}},
                        {BroochesRare.Kilo, new[] {share.SuperArmorBreakPowerRate002, share.HpRateM005}},
                        {BroochesRare.Byte, new[] {share.SuperArmorBreakPowerRate001, share.HpRateM005}}
                    }),

                // sinA4
                new("擦傷",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.AttackSpeedRate004, share.DefenseBreakRate002}},
                        {BroochesRare.Giga, new[] {share.AttackSpeedRate003, share.DefenseBreakRate001}},
                        {BroochesRare.Mega, new[] {share.AttackSpeedRate003}},
                        {BroochesRare.Kilo, new[] {share.AttackSpeedRate002}},
                        {BroochesRare.Byte, new[] {share.AttackSpeedRate001}}
                    }),

                // sinA5
                new("颱風",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.AttackSpeedRate004, share.ExtraDamageRateBoss002}},
                        {
                            BroochesRare.Giga,
                            new[] {share.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateBoss, .01m)}
                        },
                        {BroochesRare.Mega, new[] {share.AttackSpeedRate003}},
                        {BroochesRare.Kilo, new[] {share.AttackSpeedRate002}},
                        {BroochesRare.Byte, new[] {share.AttackSpeedRate001}}
                    }),

                // sinA6
                new("根除",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {new(StaticEffect.CriticalDamage, 980), share.HpRateM005}},
                        {BroochesRare.Giga, new[] {share.CriticalDamage560, share.HpRateM005}},
                        {BroochesRare.Mega, new[] {new(StaticEffect.CriticalDamage, 336), share.HpRateM005}},
                        {BroochesRare.Kilo, new[] {new(StaticEffect.CriticalDamage, 196), share.HpRateM005}},
                        {BroochesRare.Byte, new[] {new(StaticEffect.CriticalDamage, 98), share.HpRateM005}}
                    }),

                // sinA7
                new("魯莽",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new[] {share.DefenseBreakRate005, share.DefenseRateM005}},
                        {BroochesRare.Giga, new[] {share.DefenseBreakRate004, share.DefenseRateM005}},
                        {BroochesRare.Mega, new[] {share.DefenseBreakRate003, share.DefenseRateM005}},
                        {BroochesRare.Kilo, new[] {share.DefenseBreakRate002, share.DefenseRateM005}},
                        {BroochesRare.Byte, new[] {share.DefenseBreakRate001, share.DefenseRateM005}}
                    }),

                // sinA8
                new("清除",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffect.CriticalDamage, 756)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffect.CriticalDamage, 448)}},
                        {BroochesRare.Mega, new[] {share.CriticalDamage280}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffect.CriticalDamage, 168)}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffect.CriticalDamage, 84)}}
                    }),

                // sinA9
                new("驅動",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackSpeedRateOCriticalHitP1D2, .05m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackSpeedRateOCriticalHitP1D2, .04m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackSpeedRateOCriticalHitP1D2, .03m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackSpeedRateOCriticalHitP1D2, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackSpeedRateOCriticalHitP1D2, .01m)}}
                    }),

                // sinA10
                new("酸性的",
                    BroochesSeries.Sin,
                    BroochesType.Attack,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOCriticalHitP1D2, 1_620)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOCriticalHitP1D2, 1_134)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOCriticalHitP1D2, 793)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOCriticalHitP1D2, 555)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOCriticalHitP1D2, 388)}}
                    }),

                #endregion

                #region Defense

                // sinD1
                new("躲藏",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffect.Evade, 130)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffect.Evade, 91)}},
                        {BroochesRare.Mega, new Effect[] {new(StaticEffect.Evade, 63)}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffect.Evade, 44)}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffect.Evade, 30)}}
                    }),

                // sinD2
                new("油漆",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackSpeedRateOSufferCriticalP5D2, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackSpeedRateOSufferCriticalP5D2, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackSpeedRateOSufferCriticalP5D2, .06m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackSpeedRateOSufferCriticalP5D2, .03m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackSpeedRateOSufferCriticalP5D2, .01m)}}
                    }),

                // sinD3
                new("分身",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOSufferCriticalP5D2, 1_560)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOSufferCriticalP5D2, 960)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOSufferCriticalP5D2, 600)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOSufferCriticalP5D2, 360)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOSufferCriticalP5D2, 180)}}
                    }),

                // sinD4
                new("煙霧",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalRateOUseAvoidP1D5, .12m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalRateOUseAvoidP1D5, .09m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalRateOUseAvoidP1D5, .06m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalRateOUseAvoidP1D5, .04m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalRateOUseAvoidP1D5, .01m)}}
                    }),

                // sinD5
                new("逃避",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOUseAvoidP1D5, 1_723)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOUseAvoidP1D5, 1_060)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOUseAvoidP1D5, 663)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOUseAvoidP1D5, 397)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOUseAvoidP1D5, 162)}}
                    }),

                // sinD6
                new("預防",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffect.CriticalResistanceRate, .1m)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffect.CriticalResistanceRate, .08m)}},
                        {BroochesRare.Mega, new[] {share.CriticalResistanceRate004}},
                        {BroochesRare.Kilo, new[] {share.CriticalResistanceRate003}},
                        {BroochesRare.Byte, new[] {share.CriticalResistanceRate002}}
                    }),

                // sinD7
                new("流動",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackSpeedRateOSufferP3D15M, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackSpeedRateOSufferP3D15M, .04m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackSpeedRateOSufferP3D15M, .03m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackSpeedRateOSufferP3D15M, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackSpeedRateOSufferP3D15M, .01m)}}
                    }),

                // sinD8
                new("打斷",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.EvadeOSufferP4D3, 180)}},
                        {BroochesRare.Giga, new Effect[] {new(share.EvadeOSufferP4D3, 126)}},
                        {BroochesRare.Mega, new Effect[] {new(share.EvadeOSufferP4D3, 88)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.EvadeOSufferP4D3, 61)}},
                        {BroochesRare.Byte, new Effect[] {new(share.EvadeOSufferP4D3, 42)}}
                    }),

                // sinD9
                new("影子步伐",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalRateOAvoidP3D2, .14m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalRateOAvoidP3D2, .1m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalRateOAvoidP3D2, .05m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalRateOAvoidP3D2, .03m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalRateOAvoidP3D2, .01m)}}
                    }),

                // sinD10
                new("後退步伐",
                    BroochesSeries.Sin,
                    BroochesType.Defense,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOSufferP5D3, 1_930)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOSufferP5D3, 1_351)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOSufferP5D3, 945)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOSufferP5D3, 661)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOSufferP5D3, 463)}}
                    }),

                #endregion

                #region Effect

                // sinE1
                new("飛鼠裝",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(StaticEffect.MoveSpaceRateBattle, .07m)}},
                        {BroochesRare.Giga, new Effect[] {new(StaticEffect.MoveSpaceRateBattle, .05m)}},
                        {BroochesRare.Mega, new Effect[] {new(StaticEffect.MoveSpaceRateBattle, .03m)}},
                        {BroochesRare.Kilo, new Effect[] {new(StaticEffect.MoveSpaceRateBattle, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(StaticEffect.MoveSpaceRateBattle, .01m)}}
                    }),

                // sinE2
                new("貓眼",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOUseSkillP5D5, 2_200)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOUseSkillP5D5, 1_600)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOUseSkillP5D5, 1_100)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOUseSkillP5D5, 650)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOUseSkillP5D5, 300)}}
                    }),

                // sinE3
                new("鷹眼",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageORunP2D3, 1_760)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageORunP2D3, 1_232)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageORunP2D3, 862)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageORunP2D3, 603)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageORunP2D3, 422)}}
                    }),

                // sinE4
                new("追捕",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalRateORunP3D5, .08m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalRateORunP3D5, .06m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalRateORunP3D5, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalRateORunP3D5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalRateORunP3D5, .01m)}}
                    }),

                // sinE5
                new("血腥斗篷",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalRateOUseSkillP5D5, .08m)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalRateOUseSkillP5D5, .06m)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalRateOUseSkillP5D5, .04m)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalRateOUseSkillP5D5, .02m)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalRateOUseSkillP5D5, .01m)}}
                    }),

                // sinE6
                new("每週標記",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOSufferStamina50UpD5, 550)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOSufferStamina50UpD5, 385)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOSufferStamina50UpD5, 269)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOSufferStamina50UpD5, 188)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOSufferStamina50UpD5, 131)}}
                    }),

                // sinE7
                new("噬血",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.HpRecoveryOSufferStamina50Up, 140)}},
                        {BroochesRare.Giga, new Effect[] {new(share.HpRecoveryOSufferStamina50Up, 100)}},
                        {BroochesRare.Mega, new Effect[] {new(share.HpRecoveryOSufferStamina50Up, 70)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.HpRecoveryOSufferStamina50Up, 40)}},
                        {BroochesRare.Byte, new Effect[] {new(share.HpRecoveryOSufferStamina50Up, 20)}}
                    }),

                // sinE8
                new("斷頭台",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.CriticalDamageOUseItemP2D5, 1_250)}},
                        {BroochesRare.Giga, new Effect[] {new(share.CriticalDamageOUseItemP2D5, 875)}},
                        {BroochesRare.Mega, new Effect[] {new(share.CriticalDamageOUseItemP2D5, 612)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.CriticalDamageOUseItemP2D5, 428)}},
                        {BroochesRare.Byte, new Effect[] {new(share.CriticalDamageOUseItemP2D5, 299)}}
                    }),

                // sinE9
                new("瘋狂",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackOUseItemP2D5, 936)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackOUseItemP2D5, 655)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackOUseItemP2D5, 458)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackOUseItemP2D5, 320)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackOUseItemP2D5, 224)}}
                    }),

                // sinE10
                new("技術",
                    BroochesSeries.Sin,
                    BroochesType.Effect,
                    new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                    {
                        {BroochesRare.Tera, new Effect[] {new(share.AttackOCriticalHitP1D5, 760)}},
                        {BroochesRare.Giga, new Effect[] {new(share.AttackOCriticalHitP1D5, 532)}},
                        {BroochesRare.Mega, new Effect[] {new(share.AttackOCriticalHitP1D5, 372)}},
                        {BroochesRare.Kilo, new Effect[] {new(share.AttackOCriticalHitP1D5, 260)}},
                        {BroochesRare.Byte, new Effect[] {new(share.AttackOCriticalHitP1D5, 182)}}
                    }),

                #endregion
            };

        #endregion
    }
}