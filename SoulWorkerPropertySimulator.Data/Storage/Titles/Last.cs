using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TitleData
    {
        internal static void CreateLast(ShareEffect share) =>
            LastTitle = new Title[]
            {
                new(TitleField.Last, 1, "靈魂行者", share.ArrayAttackRate00135),
                new(TitleField.Last, 1, "安排", share.ArrayAttackRate00135),
                new(TitleField.Last, 1, "安排", share.ArrayAttackRate00135),
                new(TitleField.Last, 2, "化身", share.ArrayDefenseRate00135),
                new(TitleField.Last, 2, "自我", share.ArrayDefenseRate00135),
                new(TitleField.Last, 2, "安慰", share.ArrayDefenseRate00135),
                new(TitleField.Last, 2, "斷念", share.ArrayDefenseRate00135),
                new(TitleField.Last, 2, "安心", share.ArrayDefenseRate00135),
                new(TitleField.Last, 2, "犧牲", share.ArrayDefenseRate00135),
                new(TitleField.Last, 2, "犧牲", share.ArrayDefenseRate00135),
                new(TitleField.Last, 2, "哀悼", share.ArrayDefenseRate00135),
                new(TitleField.Last, 3, "安息", new[] {share.AttackRate0018}),
                new(TitleField.Last, 4, "劍", share.ArrayDefenseRate00135),
                new(TitleField.Last, 4, "子彈", share.ArrayDefenseRate00135),
                new(TitleField.Last, 4, "鐮刀", share.ArrayDefenseRate00135),
                new(TitleField.Last, 4, "拳", share.ArrayDefenseRate00135),
                new(TitleField.Last, 4, "幻想", share.ArrayDefenseRate00135),
                new(TitleField.Last, 4, "炮火", share.ArrayDefenseRate00135),
                new(TitleField.Last, 4, "炮火", share.ArrayDefenseRate00135),
                new(TitleField.Last, 4, "槍擊", share.ArrayDefenseRate00135),
                new(TitleField.Last,
                    5,
                    "霸王",
                    new[] {share.AttackRate0018, new(StaticEffectContext.DefenseRate, -.0135m)}),
                new(TitleField.Last, 6, "降臨者", new[] {share.DefenseRate0018, share.AttackRateM00135}),
                new(TitleField.Last, 7, "緣分", share.ArrayAttackRate00135),
                new(TitleField.Last, 8, "彷徨的少女", share.ArrayDefenseRate00135),
                new(TitleField.Last, 8, "彷徨的少年", share.ArrayDefenseRate00135),
                new(TitleField.Last, 9, "高手", new[] {share.HpRate00225, share.CooldownShorterRate002}),
                new(TitleField.Last, 10, "傷患", new[] {share.HpRate00375, share.CooldownShorterRate002}),
                new(TitleField.Last,
                    11,
                    "消費者",
                    new[] {share.HpRate00525, share.CooldownShorterRate002, share.MoneyVolumeRateEnemy00525}),
                new(TitleField.Last, 12, "先驅者", new[] {share.Stamina5, share.Evade21}),
                new(TitleField.Last, 13, "常客", new[] {share.Stamina6, share.Evade27}),
                new(TitleField.Last, 14, "VIP", new[] {share.Stamina6, share.Evade32}),
                new(TitleField.Last,
                    15,
                    "VVIP",
                    new[] {share.Stamina7, share.Evade37, share.DamageReductionRate002}),
                new(TitleField.Last, 16, "武器主人", new[] {share.DefenseRate00225, share.MoneyVolumeRateEnemy00375}),
                new(TitleField.Last, 17, "收藏家", new[] {share.DefenseRate0027, share.MoneyVolumeRateEnemy0045}),
                new(TitleField.Last,
                    18,
                    "金主",
                    new[] {share.DefenseRate00315, share.MoneyVolumeRateEnemy00525, share.ExpVolumeRateEnemy00525}),
                new(TitleField.Last,
                    19,
                    "失敗者",
                    new[] {share.HpRate00975, share.AttackRateM00225, share.KillHpRecovery42_9}),
                new(TitleField.Last,
                    20,
                    "露宿者",
                    new[] {share.HpRate0105, share.AttackRateM00225, share.KillHpRecovery46_2}),
                new(TitleField.Last,
                    21,
                    "屍體",
                    new[] {share.HpRate01125, share.AttackRateM00225, share.KillHpRecovery49_5, share.Stamina11}),
                new(TitleField.Last,
                    22,
                    "不死之身",
                    new[]
                    {
                        share.HpRate012,
                        share.AttackRateM00225,
                        new(StaticEffectContext.KillHpRecovery, 52.8m),
                        share.Stamina11,
                        share.CooldownShorterRate002
                    }),
                new(TitleField.Last, 23, "清掃者", new[] {share.DefenseRate0036, share.DamageReductionRateBasic0025}),
                new(TitleField.Last,
                    24,
                    "消滅者",
                    new[]
                    {
                        share.DefenseRate00405,
                        share.DamageReductionRateBasic003,
                        share.DamageReductionRateBoss003
                    }),
                new(TitleField.Last,
                    25,
                    "殲滅者",
                    new[]
                    {
                        share.DefenseRate0045,
                        share.DamageReductionRateBasic003,
                        share.DamageReductionRateBoss003,
                        share.ExpVolumeRateEnemy0075
                    }),
                new(TitleField.Last,
                    26,
                    "怪物",
                    new[]
                    {
                        share.DefenseRate0054,
                        new(StaticEffectContext.DamageReductionRateBasic, .035m),
                        share.DamageReductionRateBoss0035,
                        share.ExpVolumeRateEnemy009,
                        share.Evade64
                    }),
                new(TitleField.Last, 27, "實力角", new[] {share.MoveSpaceRate005, share.Evade21}),
                new(TitleField.Last, 28, "受益者", new[] {share.MoveSpaceRate005, share.Evade27}),
                new(TitleField.Last, 29, "鬥士", new[] {share.MoveSpaceRate005, share.Evade32}),
                new(TitleField.Last,
                    30,
                    "獵人",
                    new[] {share.MoveSpaceRate005, share.Evade37, share.CooldownShorterRate002}),
                new(TitleField.Last,
                    31,
                    "小市民",
                    new[] {share.DefenseRate0018, new(StaticEffectContext.DamageReductionRateBasic, .015m)}),
                new(TitleField.Last, 32, "市民", new[] {share.DefenseRate00225, share.DamageReductionRateBasic002}),
                new(TitleField.Last, 33, "挑釁者", new[] {share.DefenseRate0027, share.DamageReductionRateBasic002}),
                new(TitleField.Last,
                    34,
                    "處理者",
                    new[] {share.DefenseRate00315, share.DamageReductionRateBasic0025, share.DefenseBreakRate002}),
                new(TitleField.Last, 35, "安慰", new[] {share.DefenseRate0018, share.CriticalResistanceRate0015}),
                new(TitleField.Last, 36, "強者", new[] {share.DefenseRate00225, share.CriticalResistanceRate002}),
                new(TitleField.Last, 37, "獵手", new[] {share.DefenseRate0027, share.CriticalResistanceRate002}),
                new(TitleField.Last,
                    38,
                    "追擊者",
                    new[] {share.DefenseRate00315, share.CriticalResistanceRate0025, share.Evade37}),
                new(TitleField.Last, 39, "二號角色", new[] {share.AttackRate0018, share.CriticalDamage258}),
                new(TitleField.Last, 40, "挑戰者", new[] {share.AttackRate00225, share.CriticalDamage323}),
                new(TitleField.Last, 41, "覬覦者", new[] {share.AttackRate0027, share.CriticalDamage387}),
                new(TitleField.Last,
                    42,
                    "殺手",
                    new[] {share.AttackRate00315, share.CriticalDamage452, share.DamageReductionRate002}),
                new(TitleField.Last,
                    43,
                    "追蹤者",
                    new[]
                    {
                        share.DefenseRate00315,
                        new(StaticEffectContext.DamageReductionRateBoss, .025m),
                        share.SuperArmorBreakPowerRate0025
                    }),
                new(TitleField.Last,
                    44,
                    "威脅者",
                    new[]
                    {
                        share.DefenseRate00405,
                        share.DamageReductionRateBoss003,
                        share.SuperArmorBreakPowerRate003
                    }),
                new(TitleField.Last,
                    45,
                    "追蹤者",
                    new[]
                    {
                        share.DefenseRate00495,
                        share.DamageReductionRateBoss0035,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalRate0035
                    }),
                new(TitleField.Last,
                    46,
                    "屠殺者",
                    new[]
                    {
                        share.DefenseRate0054,
                        share.DamageReductionRateBoss0035,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalRate0035,
                        share.CriticalDamage774
                    }),
                new(TitleField.Last,
                    47,
                    "參加者",
                    new[]
                    {
                        share.AttackRate00675,
                        share.AttackSpeedRateM003,
                        share.CriticalDamage968,
                        share.SuperArmorBreakPowerRate0045
                    }),
                new(TitleField.Last,
                    48,
                    "將軍",
                    new[]
                    {
                        new(StaticEffectContext.AttackRate, .072m),
                        share.AttackSpeedRateM003,
                        new(StaticEffectContext.CriticalDamage, 1032),
                        share.SuperArmorBreakPowerRate0045
                    }),
                new(TitleField.Last,
                    49,
                    "榮耀",
                    new[]
                    {
                        share.AttackRate00765,
                        share.AttackSpeedRateM003,
                        share.CriticalDamage1097,
                        share.SuperArmorBreakPowerRate005
                    }),
                new(TitleField.Last,
                    50,
                    "會長",
                    new[]
                    {
                        share.AttackRate0081,
                        new(StaticEffectContext.AttackSpeedRate, -.025m),
                        new(StaticEffectContext.CriticalDamage, 1161),
                        share.SuperArmorBreakPowerRate005,
                        new(StaticEffectContext.CriticalRate, .045m)
                    }),
                new(TitleField.Last,
                    51,
                    "逃避者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRatePrimal, .01m)}),
                new(TitleField.Last,
                    52,
                    "紮破者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRatePrimal, .015m)}),
                new(TitleField.Last,
                    53,
                    "透視者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRatePrimal, .02m)}),
                new(TitleField.Last,
                    54,
                    "毀滅者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRatePrimal, .025m)}),
                new(TitleField.Last,
                    55,
                    "洗澡",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateJunk, .01m)}),
                new(TitleField.Last,
                    56,
                    "感覺",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateJunk, .015m)}),
                new(TitleField.Last,
                    57,
                    "居民",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateJunk, .02m)}),
                new(TitleField.Last,
                    58,
                    "清道夫",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateJunk, .025m)}),
                new(TitleField.Last,
                    59,
                    "信任",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateNed, .01m)}),
                new(TitleField.Last,
                    60,
                    "憤怒",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateNed, .015m)}),
                new(TitleField.Last,
                    61,
                    "復仇者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateNed, .02m)}),
                new(TitleField.Last,
                    62,
                    "復仇者",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        share.DamageReductionRateNed0025,
                        share.DamageReductionRateFlame0025
                    }),
                new(TitleField.Last,
                    63,
                    "消防員",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateFlame, .01m)}),
                new(TitleField.Last,
                    64,
                    "追逐者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateFlame, .015m)}),
                new(TitleField.Last,
                    65,
                    "教練",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateFlame, .02m)}),
                new(TitleField.Last,
                    66,
                    "戰士",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        share.DamageReductionRateFlame0025,
                        share.DamageReductionRateNed0025
                    }),
                new(TitleField.Last,
                    67,
                    "破壞犯",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateIron, .01m)}),
                new(TitleField.Last,
                    68,
                    "破壞狂",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateIron, .015m)}),
                new(TitleField.Last,
                    69,
                    "摧毀者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DamageReductionRateIron, .02m)}),
                new(TitleField.Last,
                    70,
                    "工程師",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        new(StaticEffectContext.DamageReductionRateIron, .025m),
                        new(StaticEffectContext.DamageReductionRateSoul, .025m)
                    }),
                new(TitleField.Last,
                    71,
                    "歡喜冤家",
                    new[] {share.Stamina11, share.DefenseRateM0027, share.DamageReductionRateSoul0045}),
                new(TitleField.Last,
                    72,
                    "友誼",
                    new[]
                    {
                        share.Stamina11,
                        share.DefenseRateM00225,
                        share.DamageReductionRateSoul0045,
                        new(StaticEffectContext.Evade, 86)
                    }),
                new(TitleField.Last,
                    73,
                    "朋友關係",
                    new[]
                    {
                        share.Stamina12, share.DefenseRateM0018, share.DamageReductionRateSoul005, share.Evade91
                    }),
                new(TitleField.Last,
                    74,
                    "朋友",
                    new[]
                    {
                        share.Stamina12,
                        share.DefenseRateM0018,
                        share.DamageReductionRateSoul005,
                        share.Evade91,
                        share.SGateReducedRate003
                    }),
                new(TitleField.Last, 75, "嗜好者", new[] {share.Stamina4, share.SuperArmorBreakPowerRate001}),
                new(TitleField.Last, 76, "破碎者", new[] {share.Stamina4, share.SuperArmorBreakPowerRate0015}),
                new(TitleField.Last, 77, "破壞者", new[] {share.Stamina5, share.SuperArmorBreakPowerRate001}),
                new(TitleField.Last, 78, "破甲", new[] {share.Stamina5, share.SuperArmorBreakPowerRate0015}),
                new(TitleField.Last, 79, "忍受者", new[] {share.AttackSpeedRate002, share.SGateReducedRate003}),
                new(TitleField.Last, 80, "連擊", new[] {share.AttackSpeedRate0025, share.SGateReducedRate003}),
                new(TitleField.Last, 81, "777!", new[] {share.AttackSpeedRate003, share.SGateReducedRate003}),
                new(TitleField.Last, 82, "連擊之王", new[] {share.AttackSpeedRate0035, share.SGateReducedRate003}),
                new(TitleField.Last, 83, "冤大頭", new[] {share.Stamina5, share.CooldownShorterRate002}),
                new(TitleField.Last, 84, "誘惑", new[] {share.Stamina6, share.CooldownShorterRate002}),
                new(TitleField.Last,
                    85,
                    "傭兵王",
                    new[] {share.Stamina7, share.CooldownShorterRate002, share.DefenseBreakRate002}),
                new(TitleField.Last,
                    86,
                    "全知全能",
                    new[]
                    {
                        share.Stamina8,
                        share.CooldownShorterRate002,
                        share.DefenseBreakRate002,
                        share.Accuracy47
                    }),
                new(TitleField.Last, 87, "徘徊之人", new[] {share.Stamina5, share.SGateReducedRate003}),
                new(TitleField.Last,
                    88,
                    "探險家",
                    new[] {share.Stamina7, share.SGateReducedRate003, share.ExpVolumeRateEnemy00525}),
                new(TitleField.Last,
                    89,
                    "探險家",
                    new[]
                    {
                        share.Stamina8,
                        share.SGateReducedRate003,
                        share.ExpVolumeRateEnemy0075,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.Last,
                    90,
                    "行進者",
                    new[] {share.AttackSpeedRate005, share.AttackRateM00135, share.Accuracy65_8}),
                new(TitleField.Last,
                    91,
                    "賽跑選手",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.AttackRateM00135,
                        share.Accuracy70_5,
                        share.CooldownShorterRate002
                    }),
                new(TitleField.Last,
                    92,
                    "修煉者",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.AttackRateM00135,
                        share.Accuracy79_9,
                        share.CooldownShorterRate002
                    }),
                new(TitleField.Last,
                    93,
                    "騎手",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.AttackRateM00135,
                        share.Accuracy79_9,
                        share.CooldownShorterRate002,
                        share.Evade70
                    }),
                new(TitleField.Last,
                    94,
                    "排名入圍者",
                    new[] {share.DefenseRate00405, share.Accuracy42_3, share.KillHpRecovery29_7}),
                new(TitleField.Last,
                    95,
                    "記錄",
                    new[]
                    {
                        share.DefenseRate0045, share.Accuracy47, share.KillHpRecovery33, share.CriticalDamage645
                    }),
                new(TitleField.Last,
                    96,
                    "階層",
                    new[]
                    {
                        share.DefenseRate00495,
                        share.Accuracy51_7,
                        share.KillHpRecovery36_3,
                        share.CriticalDamage710
                    }),
                new(TitleField.Last,
                    97,
                    "操作",
                    new[]
                    {
                        share.DefenseRate00495,
                        share.Accuracy51_7,
                        share.KillHpRecovery36_3,
                        share.CriticalDamage710,
                        share.AttackSpeedRate005
                    }),
                new(TitleField.Last,
                    98,
                    "適合者",
                    new[] {share.DefenseRate00675, share.MoveSpaceRateM005, share.DefenseBreakRate002}),
                new(TitleField.Last,
                    99,
                    "擁有者",
                    new[]
                    {
                        share.DefenseRate0072,
                        share.MoveSpaceRateM005,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate004
                    }),
                new(TitleField.Last,
                    100,
                    "榮譽",
                    new[]
                    {
                        share.DefenseRate00765,
                        share.MoveSpaceRateM005,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate004
                    }),
                new(TitleField.Last,
                    101,
                    "失敗者",
                    new[]
                    {
                        share.DefenseRate00765,
                        share.MoveSpaceRateM005,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate004,
                        new(StaticEffectContext.CriticalResistanceRate, .04m)
                    }),
                new(TitleField.Last, 102, "挖掘機", new[] {share.Stamina6, share.MoneyVolumeRateEnemy00375}),
                new(TitleField.Last,
                    103,
                    "開拓者",
                    new[] {share.Stamina7, share.MoneyVolumeRateEnemy00525, share.SoulNovaVolumeRate003}),
                new(TitleField.Last,
                    104,
                    "守財奴",
                    new[]
                    {
                        share.Stamina8,
                        share.MoneyVolumeRateEnemy0075,
                        share.SoulNovaVolumeRate003,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.Last,
                    105,
                    "大富翁",
                    new[]
                    {
                        share.Stamina9,
                        share.MoneyVolumeRateEnemy009,
                        share.SoulNovaVolumeRate003,
                        share.DefenseBreakRate002,
                        share.SGateReducedRate003
                    }),
                new(TitleField.Last, 106, "冒險家", new[] {share.Stamina4, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 107, "收藏", new[] {share.Stamina5, share.SoulNovaVolumeRate003}),
                new(TitleField.Last,
                    108,
                    "愛好者",
                    new[] {share.Stamina7, share.SoulNovaVolumeRate003, share.SuperArmorBreakPowerRate0025}),
                new(TitleField.Last,
                    109,
                    "收集者",
                    new[] {share.Stamina8, share.SoulNovaVolumeRate003, share.SuperArmorBreakPowerRate003}),
                new(TitleField.Last,
                    110,
                    "戰鬥",
                    new[]
                    {
                        share.AttackRate00765,
                        share.HpRateM00675,
                        share.DamageReductionRateSix005,
                        share.CriticalRate005
                    }),
                new(TitleField.Last,
                    111,
                    "修煉者",
                    new[]
                    {
                        share.AttackRate0081,
                        share.HpRateM006,
                        share.DamageReductionRateSix005,
                        share.CriticalRate005
                    }),
                new(TitleField.Last,
                    112,
                    "戰鬥高手",
                    new[]
                    {
                        share.AttackRate0081,
                        share.HpRateM00525,
                        share.DamageReductionRateSix005,
                        share.CriticalRate005,
                        new(StaticEffectContext.DamageReductionRateBoss, .04m)
                    }),
                new(TitleField.Last,
                    113,
                    "戰鬥",
                    new[]
                    {
                        share.AttackRate00855,
                        share.HpRateM0045,
                        share.DamageReductionRateSix005,
                        share.CriticalRate005,
                        new(StaticEffectContext.DamageReductionRateBoss, .045m)
                    }),
                new(TitleField.Last, 114, "流浪者", new[] {share.MoveSpaceRate003}),
                new(TitleField.Last, 115, "聊天者", new[] {share.MoveSpaceRate005}),
                new(TitleField.Last,
                    116,
                    "吟游詩人",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DefenseRate, .0045m)}),
                new(TitleField.Last,
                    117,
                    "記錄者",
                    new[] {share.MoveSpaceRate005, new(StaticEffectContext.DefenseRate, .009m)}),
                new(TitleField.Last, 118, "迷信者", new[] {share.AttackRate0027, share.Evade32}),
                new(TitleField.Last, 119, "駭客", new[] {share.AttackRate0036, share.Evade43}),
                new(TitleField.Last, 120, "機會", new[] {share.AttackRate0027, share.MoneyVolumeRateEnemy0045}),
                new(TitleField.Last, 121, "白費力氣", new[] {share.AttackRate0036, share.MoneyVolumeRateEnemy006}),
                new(TitleField.Last,
                    122,
                    "弱化",
                    new[] {share.AttackRate0045, share.MoneyVolumeRateEnemy0075, share.CooldownShorterRate002}),
                new(TitleField.Last,
                    123,
                    "破壞大師",
                    new[] {share.AttackRate0054, share.MoneyVolumeRateEnemy009, share.CooldownShorterRate002}),
                new(TitleField.Last, 124, "後援者", new[] {share.DefenseRate0027, share.Evade32}),
                new(TitleField.Last, 125, "煉金術士", new[] {share.DefenseRate0036, share.Evade43}),
                new(TitleField.Last, 126, "分解", new[] {share.Stamina4, share.SGateReducedRate003}),
                new(TitleField.Last, 127, "復原", new[] {share.Stamina5, share.SGateReducedRate003}),
                new(TitleField.Last, 128, "力量", new[] {share.Stamina6, share.SGateReducedRate003}),
                new(TitleField.Last, 129, "手部", new[] {share.Stamina7, share.SGateReducedRate003}),
                new(TitleField.Last,
                    130,
                    "價格比較",
                    new[] {share.HpRate00525, share.DefenseRate00315, share.CriticalRate0025}),
                new(TitleField.Last,
                    131,
                    "交易者",
                    new[] {share.HpRate00675, share.DefenseRate00405, share.CriticalRate0025}),
                new(TitleField.Last,
                    132,
                    "流動",
                    new[] {share.HpRate00675, share.DefenseRate00405, share.CriticalRate003}),
                new(TitleField.Last,
                    133,
                    "之王",
                    new[] {share.HpRate00825, share.DefenseRate00495, share.CriticalRate0035}),
                new(TitleField.Last,
                    134,
                    "天敵",
                    new[] {share.MoveSpaceRate005, share.AttackSpeedRate005, share.ExpVolumeRateEnemy009}),
                new(TitleField.Last, 135, "工作者", new[] {share.Stamina6, share.Accuracy28_2}),
                new(TitleField.Last, 136, "極限", new[] {share.Stamina6, share.Evade32}),
                new(TitleField.Last,
                    137,
                    "訓練者",
                    new[]
                    {
                        share.HpRate00975,
                        share.DefenseRate00585,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate003
                    }),
                new(TitleField.Last, 138, "滋味", new[] {share.HpRate0045, share.MoveSpaceRate005}),
                new(TitleField.Last, 139, "老顧客", new[] {share.HpRate00375}),
                new(TitleField.Last, 140, "貴客", new[] {share.HpRate00375}),
                new(TitleField.Last, 141, "開心果", new[] {share.HpRate00375}),
                new(TitleField.Last, 142, "暴徒朋友", new[] {share.HpRate00375}),
                new(TitleField.Last, 143, "超級貴賓", new[] {share.HpRate00375}),
                new(TitleField.Last,
                    144,
                    "驅動者",
                    new[] {share.AttackSpeedRate005, share.DefenseRate0045, share.SuperArmorBreakPowerRate003}),
                new(TitleField.Last,
                    145,
                    "反抗者",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.DefenseRate0045,
                        share.SuperArmorBreakPowerRate003,
                        share.CriticalResistanceRate003
                    }),
                new(TitleField.Last,
                    146,
                    "征服者",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.DefenseRate0054,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalResistanceRate0035
                    }),
                new(TitleField.Last,
                    147,
                    "指揮官",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffectContext.DamageReductionRatePrimal, .035m)
                    }),
                new(TitleField.Last,
                    148,
                    "蜘蛛女王",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffectContext.DamageReductionRateJunk, .035m)
                    }),
                new(TitleField.Last,
                    149,
                    "影子",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffectContext.DamageReductionRateFlame, .035m)
                    }),
                new(TitleField.Last,
                    150,
                    "敵人",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffectContext.DamageReductionRateIron, .035m)
                    }),
                new(TitleField.Last,
                    151,
                    "異形",
                    new[]
                    {
                        share.MoveSpaceRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffectContext.DamageReductionRateSix, .035m)
                    }),
                new(TitleField.Last, 152, "大王", new[] {share.AttackRate00225}),
                new(TitleField.Last, 153, "生命", new[] {share.AttackRate00315, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 154, "誕生", new[] {share.AttackRate0036, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 155, "樂趣", new[] {share.AttackRate00405, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 156, "喜悅", new[] {share.AttackRate0045, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 157, "農夫", new[] {share.DefenseRate00315, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 158, "自足", new[] {share.DefenseRate0036, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 159, "天職", new[] {share.DefenseRate00405, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 160, "企業家", new[] {share.DefenseRate0045, share.SoulNovaVolumeRate003}),
                new(TitleField.Last, 161, "園藝師", new[] {share.AttackSpeedRate004, share.SGateReducedRate003}),
                new(TitleField.Last, 162, "生產者", new[] {share.AttackSpeedRate004, share.CooldownShorterRate002}),
                new(TitleField.Last, 163, "之手", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy003}),
                new(TitleField.Last, 164, "幸福", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy00375}),
                new(TitleField.Last, 165, "美德", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy0045}),
                new(TitleField.Last, 166, "使者", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy00525}),
                new(TitleField.Last, 167, "切斷者", new[] {share.MoveSpaceRate005, share.SoulNovaVolumeRate003}),
                new(TitleField.Last,
                    168,
                    "解放者",
                    new[]
                    {
                        share.DefenseRate00495,
                        share.DamageReductionRateBoss0035,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalRate0035
                    }),
                new(TitleField.Last,
                    169,
                    "驅逐者",
                    new[] {share.MoveSpaceRate005, share.SoulNovaVolumeRate003, share.DamageReductionRateBoss0035}),
                new(TitleField.Last,
                    176,
                    "魔王",
                    new[]
                    {
                        new(StaticEffectContext.CriticalDamage, 550),
                        share.ExtraDamageRateBoss0045,
                        share.AttackSpeedRate0035,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffectContext.CooldownShorterRate, -.03m)
                    }),
                new(TitleField.Last,
                    177,
                    "尊敬",
                    new[]
                    {
                        new(StaticEffectContext.DefenseRate, .06m),
                        share.DamageReductionRateBoss0035,
                        share.SuperArmorBreakPowerRate003
                    }),
                new(TitleField.Last,
                    178,
                    "大將",
                    new[]
                    {
                        new(StaticEffectContext.DamageReductionRatePartialDamage, .05m),
                        share.SGateReducedRate003,
                        new(StaticEffectContext.MoneyVolumeRateEnemy, .07m),
                        new(StaticEffectContext.Evade, 45),
                        new(StaticEffectContext.DamageReductionRateFall, .05m)
                    }),
                new(TitleField.Last,
                    179,
                    "金手",
                    new Effect[]
                    {
                        new(StaticEffectContext.MoneyVolumeRateEnemy, .10m),
                        new(StaticEffectContext.SoulNovaVolumeRate, .05m)
                    }),
                new(TitleField.Last,
                    180,
                    "遊戲",
                    new[]
                    {
                        new(StaticEffectContext.DefenseRate, .08m),
                        share.MoveSpaceRateM005,
                        share.SoulNovaVolumeRate003,
                        share.DamageReductionRate003,
                        new(StaticEffectContext.CriticalRate, -.01m)
                    }),
                new(TitleField.Last,
                    181,
                    "紀念物",
                    new[]
                    {
                        new(StaticEffectContext.Stamina, 7.2m),
                        new(StaticEffectContext.Hp, 550),
                        share.SuperArmorBreakPowerRate0025,
                        share.CriticalRate002
                    }),
                new(TitleField.Last,
                    182,
                    "真實",
                    new[]
                    {
                        share.AttackSpeedRate004,
                        new(StaticEffectContext.SoulNovaVolumeRate, .035m),
                        share.ExtraDamageRateJunk0025,
                        share.ExtraDamageRateBasic003
                    }),
                new(TitleField.Last,
                    183,
                    "刀刃",
                    new[]
                    {
                        share.DefenseBreakRate002,
                        share.CooldownShorterRate002,
                        share.SuperArmorBreakPowerRate005,
                        share.HpRate00375,
                        share.DefenseRateM003
                    }),
                new(TitleField.Last,
                    184,
                    "炮彈",
                    new[]
                    {
                        share.DefenseBreakRate002,
                        share.CooldownShorterRate002,
                        share.SuperArmorBreakPowerRate005,
                        share.HpRate00375,
                        share.DefenseRateM003
                    }),
                new(TitleField.Last,
                    185,
                    "鎖鏈",
                    new[]
                    {
                        share.DefenseBreakRate002,
                        share.CooldownShorterRate002,
                        share.SuperArmorBreakPowerRate005,
                        share.HpRate00375,
                        share.DefenseRateM003
                    }),
                new(TitleField.Last,
                    186,
                    "護盾",
                    new[]
                    {
                        share.DefenseBreakRate002,
                        share.CooldownShorterRate002,
                        share.SuperArmorBreakPowerRate005,
                        share.HpRate00375,
                        share.DefenseRateM003
                    }),
                new(TitleField.Last,
                    187,
                    "鬥魂",
                    new[]
                    {
                        share.DefenseBreakRate002,
                        share.CooldownShorterRate002,
                        share.SuperArmorBreakPowerRate005,
                        share.HpRate00375,
                        share.DefenseRateM003
                    }),
                new(TitleField.Last,
                    188,
                    "兵器",
                    new[]
                    {
                        share.DefenseBreakRate002,
                        share.CooldownShorterRate002,
                        share.SuperArmorBreakPowerRate005,
                        share.HpRate00375,
                        share.DefenseRateM003
                    }),
                new(TitleField.Last,
                    188,
                    "光槍",
                    new[]
                    {
                        share.DefenseBreakRate002,
                        share.CooldownShorterRate002,
                        share.SuperArmorBreakPowerRate005,
                        share.HpRate00375,
                        share.DefenseRateM003
                    }),
                new(TitleField.Last,
                    190,
                    "傷痕",
                    new[]
                    {
                        new(StaticEffectContext.DefenseRate, .04m),
                        new(StaticEffectContext.DamageReductionRateBasic, .05m),
                        share.DamageReductionRateBoss005
                    }),
                new(TitleField.Last,
                    206,
                    "白色騎士",
                    new[]
                    {
                        new(StaticEffectContext.CooldownShorterRate, .03m),
                        new(StaticEffectContext.SoulGateConsumptionReducedRate, .045m),
                        share.HpRate01,
                        share.DamageReductionRateBoss005
                    }),
                new(TitleField.Last,
                    247,
                    "渴望者行者",
                    new[]
                    {
                        share.CriticalRate002,
                        new(StaticEffectContext.CriticalDamage, 500),
                        share.Stamina5,
                        share.MoveSpaceRate003
                    }),
                new(TitleField.Last, 250, "作戰執行者", new[] {share.DamageReductionRatePvP0025}),
                new(TitleField.Last,
                    265,
                    "怪物",
                    new[]
                    {
                        share.AttackRate005,
                        share.DefenseRate0054,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalResistanceRate0035
                    })
            };

        #region

        private static IReadOnlyCollection<Title> LastTitle { get; set; } = null!;

        #endregion
    }
}