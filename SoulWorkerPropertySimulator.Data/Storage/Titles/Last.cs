using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TitleData
    {
        private static readonly IReadOnlyCollection<Title> LastTitle = new Title[]
        {
            new(TitleField.Last, 1, "靈魂行者", ShareEffect.ArrayAttackRate00135),
            new(TitleField.Last, 1, "安排", ShareEffect.ArrayAttackRate00135),
            new(TitleField.Last, 1, "安排", ShareEffect.ArrayAttackRate00135),
            new(TitleField.Last, 2, "化身", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 2, "自我", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 2, "安慰", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 2, "斷念", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 2, "安心", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 2, "犧牲", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 2, "犧牲", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 2, "哀悼", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 3, "安息", new[] {ShareEffect.AttackRate0018}),
            new(TitleField.Last, 4, "劍", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 4, "子彈", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 4, "鐮刀", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 4, "拳", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 4, "幻想", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 4, "炮火", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 4, "炮火", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 4, "槍擊", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last,
                5,
                "霸王",
                new[] {ShareEffect.AttackRate0018, new(StaticEffect.DefenseRate, -.0135m)}),
            new(TitleField.Last, 6, "降臨者", new[] {ShareEffect.DefenseRate0018, ShareEffect.AttackRateM00135}),
            new(TitleField.Last, 7, "緣分", ShareEffect.ArrayAttackRate00135),
            new(TitleField.Last, 8, "彷徨的少女", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 8, "彷徨的少年", ShareEffect.ArrayDefenseRate00135),
            new(TitleField.Last, 9, "高手", new[] {ShareEffect.HpRate00225, ShareEffect.CooldownShorterRate002}),
            new(TitleField.Last, 10, "傷患", new[] {ShareEffect.HpRate00375, ShareEffect.CooldownShorterRate002}),
            new(TitleField.Last,
                11,
                "消費者",
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.MoneyVolumeRateEnemy00525
                }),
            new(TitleField.Last, 12, "先驅者", new[] {ShareEffect.Stamina5, ShareEffect.Evade21}),
            new(TitleField.Last, 13, "常客", new[] {ShareEffect.Stamina6, ShareEffect.Evade27}),
            new(TitleField.Last, 14, "VIP", new[] {ShareEffect.Stamina6, ShareEffect.Evade32}),
            new(TitleField.Last,
                15,
                "VVIP",
                new[] {ShareEffect.Stamina7, ShareEffect.Evade37, ShareEffect.DamageReductionRate002}),
            new(TitleField.Last,
                16,
                "武器主人",
                new[] {ShareEffect.DefenseRate00225, ShareEffect.MoneyVolumeRateEnemy00375}),
            new(TitleField.Last,
                17,
                "收藏家",
                new[] {ShareEffect.DefenseRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new(TitleField.Last,
                18,
                "金主",
                new[]
                {
                    ShareEffect.DefenseRate00315,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.ExpVolumeRateEnemy00525
                }),
            new(TitleField.Last,
                19,
                "失敗者",
                new[] {ShareEffect.HpRate00975, ShareEffect.AttackRateM00225, ShareEffect.KillHpRecovery42_9}),
            new(TitleField.Last,
                20,
                "露宿者",
                new[] {ShareEffect.HpRate0105, ShareEffect.AttackRateM00225, ShareEffect.KillHpRecovery46_2}),
            new(TitleField.Last,
                21,
                "屍體",
                new[]
                {
                    ShareEffect.HpRate01125,
                    ShareEffect.AttackRateM00225,
                    ShareEffect.KillHpRecovery49_5,
                    ShareEffect.Stamina11
                }),
            new(TitleField.Last,
                22,
                "不死之身",
                new[]
                {
                    ShareEffect.HpRate012,
                    ShareEffect.AttackRateM00225,
                    new(StaticEffect.KillHpRecovery, 52.8m),
                    ShareEffect.Stamina11,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.Last,
                23,
                "清掃者",
                new[] {ShareEffect.DefenseRate0036, ShareEffect.DamageReductionRateBasic0025}),
            new(TitleField.Last,
                24,
                "消滅者",
                new[]
                {
                    ShareEffect.DefenseRate00405,
                    ShareEffect.DamageReductionRateBasic003,
                    ShareEffect.DamageReductionRateBoss003
                }),
            new(TitleField.Last,
                25,
                "殲滅者",
                new[]
                {
                    ShareEffect.DefenseRate0045,
                    ShareEffect.DamageReductionRateBasic003,
                    ShareEffect.DamageReductionRateBoss003,
                    ShareEffect.ExpVolumeRateEnemy0075
                }),
            new(TitleField.Last,
                26,
                "怪物",
                new[]
                {
                    ShareEffect.DefenseRate0054,
                    new(StaticEffect.DamageReductionRateBasic, .035m),
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.ExpVolumeRateEnemy009,
                    ShareEffect.Evade64
                }),
            new(TitleField.Last, 27, "實力角", new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade21}),
            new(TitleField.Last, 28, "受益者", new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade27}),
            new(TitleField.Last, 29, "鬥士", new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade32}),
            new(TitleField.Last,
                30,
                "獵人",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade37, ShareEffect.CooldownShorterRate002}),
            new(TitleField.Last,
                31,
                "小市民",
                new[] {ShareEffect.DefenseRate0018, new(StaticEffect.DamageReductionRateBasic, .015m)}),
            new(TitleField.Last,
                32,
                "市民",
                new[] {ShareEffect.DefenseRate00225, ShareEffect.DamageReductionRateBasic002}),
            new(TitleField.Last,
                33,
                "挑釁者",
                new[] {ShareEffect.DefenseRate0027, ShareEffect.DamageReductionRateBasic002}),
            new(TitleField.Last,
                34,
                "處理者",
                new[]
                {
                    ShareEffect.DefenseRate00315,
                    ShareEffect.DamageReductionRateBasic0025,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.Last,
                35,
                "安慰",
                new[] {ShareEffect.DefenseRate0018, ShareEffect.CriticalResistanceRate0015}),
            new(TitleField.Last,
                36,
                "強者",
                new[] {ShareEffect.DefenseRate00225, ShareEffect.CriticalResistanceRate002}),
            new(TitleField.Last,
                37,
                "獵手",
                new[] {ShareEffect.DefenseRate0027, ShareEffect.CriticalResistanceRate002}),
            new(TitleField.Last,
                38,
                "追擊者",
                new[] {ShareEffect.DefenseRate00315, ShareEffect.CriticalResistanceRate0025, ShareEffect.Evade37}),
            new(TitleField.Last, 39, "二號角色", new[] {ShareEffect.AttackRate0018, ShareEffect.CriticalDamage258}),
            new(TitleField.Last, 40, "挑戰者", new[] {ShareEffect.AttackRate00225, ShareEffect.CriticalDamage323}),
            new(TitleField.Last, 41, "覬覦者", new[] {ShareEffect.AttackRate0027, ShareEffect.CriticalDamage387}),
            new(TitleField.Last,
                42,
                "殺手",
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.CriticalDamage452,
                    ShareEffect.DamageReductionRate002
                }),
            new(TitleField.Last,
                43,
                "追蹤者",
                new[]
                {
                    ShareEffect.DefenseRate00315,
                    new(StaticEffect.DamageReductionRateBoss, .025m),
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new(TitleField.Last,
                44,
                "威脅者",
                new[]
                {
                    ShareEffect.DefenseRate00405,
                    ShareEffect.DamageReductionRateBoss003,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new(TitleField.Last,
                45,
                "追蹤者",
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalRate0035
                }),
            new(TitleField.Last,
                46,
                "屠殺者",
                new[]
                {
                    ShareEffect.DefenseRate0054,
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalRate0035,
                    ShareEffect.CriticalDamage774
                }),
            new(TitleField.Last,
                47,
                "參加者",
                new[]
                {
                    ShareEffect.AttackRate00675,
                    ShareEffect.AttackSpeedRateM003,
                    ShareEffect.CriticalDamage968,
                    ShareEffect.SuperArmorBreakPowerRate0045
                }),
            new(TitleField.Last,
                48,
                "將軍",
                new[]
                {
                    new(StaticEffect.AttackRate, .072m),
                    ShareEffect.AttackSpeedRateM003,
                    new(StaticEffect.CriticalDamage, 1032),
                    ShareEffect.SuperArmorBreakPowerRate0045
                }),
            new(TitleField.Last,
                49,
                "榮耀",
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.AttackSpeedRateM003,
                    ShareEffect.CriticalDamage1097,
                    ShareEffect.SuperArmorBreakPowerRate005
                }),
            new(TitleField.Last,
                50,
                "會長",
                new[]
                {
                    ShareEffect.AttackRate0081,
                    new(StaticEffect.AttackSpeedRate, -.025m),
                    new(StaticEffect.CriticalDamage, 1161),
                    ShareEffect.SuperArmorBreakPowerRate005,
                    new(StaticEffect.CriticalRate, .045m)
                }),
            new(TitleField.Last,
                51,
                "逃避者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRatePrimal, .01m)}),
            new(TitleField.Last,
                52,
                "紮破者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRatePrimal, .015m)}),
            new(TitleField.Last,
                53,
                "透視者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRatePrimal, .02m)}),
            new(TitleField.Last,
                54,
                "毀滅者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRatePrimal, .025m)}),
            new(TitleField.Last,
                55,
                "洗澡",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateJunk, .01m)}),
            new(TitleField.Last,
                56,
                "感覺",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateJunk, .015m)}),
            new(TitleField.Last,
                57,
                "居民",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateJunk, .02m)}),
            new(TitleField.Last,
                58,
                "清道夫",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateJunk, .025m)}),
            new(TitleField.Last,
                59,
                "信任",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateNed, .01m)}),
            new(TitleField.Last,
                60,
                "憤怒",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateNed, .015m)}),
            new(TitleField.Last,
                61,
                "復仇者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateNed, .02m)}),
            new(TitleField.Last,
                62,
                "復仇者",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.DamageReductionRateNed0025,
                    ShareEffect.DamageReductionRateFlame0025
                }),
            new(TitleField.Last,
                63,
                "消防員",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateFlame, .01m)}),
            new(TitleField.Last,
                64,
                "追逐者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateFlame, .015m)}),
            new(TitleField.Last,
                65,
                "教練",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateFlame, .02m)}),
            new(TitleField.Last,
                66,
                "戰士",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.DamageReductionRateFlame0025,
                    ShareEffect.DamageReductionRateNed0025
                }),
            new(TitleField.Last,
                67,
                "破壞犯",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateIron, .01m)}),
            new(TitleField.Last,
                68,
                "破壞狂",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateIron, .015m)}),
            new(TitleField.Last,
                69,
                "摧毀者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DamageReductionRateIron, .02m)}),
            new(TitleField.Last,
                70,
                "工程師",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    new(StaticEffect.DamageReductionRateIron, .025m),
                    new(StaticEffect.DamageReductionRateSoul, .025m)
                }),
            new(TitleField.Last,
                71,
                "歡喜冤家",
                new[]
                {
                    ShareEffect.Stamina11, ShareEffect.DefenseRateM0027, ShareEffect.DamageReductionRateSoul0045
                }),
            new(TitleField.Last,
                72,
                "友誼",
                new[]
                {
                    ShareEffect.Stamina11,
                    ShareEffect.DefenseRateM00225,
                    ShareEffect.DamageReductionRateSoul0045,
                    new(StaticEffect.Evade, 86)
                }),
            new(TitleField.Last,
                73,
                "朋友關係",
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.DamageReductionRateSoul005,
                    ShareEffect.Evade91
                }),
            new(TitleField.Last,
                74,
                "朋友",
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.DamageReductionRateSoul005,
                    ShareEffect.Evade91,
                    ShareEffect.SGateReducedRate003
                }),
            new(TitleField.Last, 75, "嗜好者", new[] {ShareEffect.Stamina4, ShareEffect.SuperArmorBreakPowerRate001}),
            new(TitleField.Last, 76, "破碎者", new[] {ShareEffect.Stamina4, ShareEffect.SuperArmorBreakPowerRate0015}),
            new(TitleField.Last, 77, "破壞者", new[] {ShareEffect.Stamina5, ShareEffect.SuperArmorBreakPowerRate001}),
            new(TitleField.Last, 78, "破甲", new[] {ShareEffect.Stamina5, ShareEffect.SuperArmorBreakPowerRate0015}),
            new(TitleField.Last,
                79,
                "忍受者",
                new[] {ShareEffect.AttackSpeedRate002, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last,
                80,
                "連擊",
                new[] {ShareEffect.AttackSpeedRate0025, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last,
                81,
                "777!",
                new[] {ShareEffect.AttackSpeedRate003, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last,
                82,
                "連擊之王",
                new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last, 83, "冤大頭", new[] {ShareEffect.Stamina5, ShareEffect.CooldownShorterRate002}),
            new(TitleField.Last, 84, "誘惑", new[] {ShareEffect.Stamina6, ShareEffect.CooldownShorterRate002}),
            new(TitleField.Last,
                85,
                "傭兵王",
                new[] {ShareEffect.Stamina7, ShareEffect.CooldownShorterRate002, ShareEffect.DefenseBreakRate002}),
            new(TitleField.Last,
                86,
                "全知全能",
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.Accuracy47
                }),
            new(TitleField.Last, 87, "徘徊之人", new[] {ShareEffect.Stamina5, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last,
                88,
                "探險家",
                new[] {ShareEffect.Stamina7, ShareEffect.SGateReducedRate003, ShareEffect.ExpVolumeRateEnemy00525}),
            new(TitleField.Last,
                89,
                "探險家",
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.SGateReducedRate003,
                    ShareEffect.ExpVolumeRateEnemy0075,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.Last,
                90,
                "行進者",
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.AttackRateM00135, ShareEffect.Accuracy65_8}),
            new(TitleField.Last,
                91,
                "賽跑選手",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy70_5,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.Last,
                92,
                "修煉者",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy79_9,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.Last,
                93,
                "騎手",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy79_9,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.Evade70
                }),
            new(TitleField.Last,
                94,
                "排名入圍者",
                new[] {ShareEffect.DefenseRate00405, ShareEffect.Accuracy42_3, ShareEffect.KillHpRecovery29_7}),
            new(TitleField.Last,
                95,
                "記錄",
                new[]
                {
                    ShareEffect.DefenseRate0045,
                    ShareEffect.Accuracy47,
                    ShareEffect.KillHpRecovery33,
                    ShareEffect.CriticalDamage645
                }),
            new(TitleField.Last,
                96,
                "階層",
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.Accuracy51_7,
                    ShareEffect.KillHpRecovery36_3,
                    ShareEffect.CriticalDamage710
                }),
            new(TitleField.Last,
                97,
                "操作",
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.Accuracy51_7,
                    ShareEffect.KillHpRecovery36_3,
                    ShareEffect.CriticalDamage710,
                    ShareEffect.AttackSpeedRate005
                }),
            new(TitleField.Last,
                98,
                "適合者",
                new[]
                {
                    ShareEffect.DefenseRate00675, ShareEffect.MoveSpaceRateM005, ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.Last,
                99,
                "擁有者",
                new[]
                {
                    ShareEffect.DefenseRate0072,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate004
                }),
            new(TitleField.Last,
                100,
                "榮譽",
                new[]
                {
                    ShareEffect.DefenseRate00765,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate004
                }),
            new(TitleField.Last,
                101,
                "失敗者",
                new[]
                {
                    ShareEffect.DefenseRate00765,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate004,
                    new(StaticEffect.CriticalResistanceRate, .04m)
                }),
            new(TitleField.Last, 102, "挖掘機", new[] {ShareEffect.Stamina6, ShareEffect.MoneyVolumeRateEnemy00375}),
            new(TitleField.Last,
                103,
                "開拓者",
                new[]
                {
                    ShareEffect.Stamina7,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.SoulNovaVolumeRate003
                }),
            new(TitleField.Last,
                104,
                "守財奴",
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.Last,
                105,
                "大富翁",
                new[]
                {
                    ShareEffect.Stamina9,
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.SGateReducedRate003
                }),
            new(TitleField.Last, 106, "冒險家", new[] {ShareEffect.Stamina4, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last, 107, "收藏", new[] {ShareEffect.Stamina5, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last,
                108,
                "愛好者",
                new[]
                {
                    ShareEffect.Stamina7,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new(TitleField.Last,
                109,
                "收集者",
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new(TitleField.Last,
                110,
                "戰鬥",
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.HpRateM00675,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new(TitleField.Last,
                111,
                "修煉者",
                new[]
                {
                    ShareEffect.AttackRate0081,
                    ShareEffect.HpRateM006,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new(TitleField.Last,
                112,
                "戰鬥高手",
                new[]
                {
                    ShareEffect.AttackRate0081,
                    ShareEffect.HpRateM00525,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005,
                    new(StaticEffect.DamageReductionRateBoss, .04m)
                }),
            new(TitleField.Last,
                113,
                "戰鬥",
                new[]
                {
                    ShareEffect.AttackRate00855,
                    ShareEffect.HpRateM0045,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005,
                    new(StaticEffect.DamageReductionRateBoss, .045m)
                }),
            new(TitleField.Last, 114, "流浪者", new[] {ShareEffect.MoveSpaceRate003}),
            new(TitleField.Last, 115, "聊天者", new[] {ShareEffect.MoveSpaceRate005}),
            new(TitleField.Last,
                116,
                "吟游詩人",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DefenseRate, .0045m)}),
            new(TitleField.Last,
                117,
                "記錄者",
                new[] {ShareEffect.MoveSpaceRate005, new(StaticEffect.DefenseRate, .009m)}),
            new(TitleField.Last, 118, "迷信者", new[] {ShareEffect.AttackRate0027, ShareEffect.Evade32}),
            new(TitleField.Last, 119, "駭客", new[] {ShareEffect.AttackRate0036, ShareEffect.Evade43}),
            new(TitleField.Last,
                120,
                "機會",
                new[] {ShareEffect.AttackRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new(TitleField.Last,
                121,
                "白費力氣",
                new[] {ShareEffect.AttackRate0036, ShareEffect.MoneyVolumeRateEnemy006}),
            new(TitleField.Last,
                122,
                "弱化",
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.Last,
                123,
                "破壞大師",
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.Last, 124, "後援者", new[] {ShareEffect.DefenseRate0027, ShareEffect.Evade32}),
            new(TitleField.Last, 125, "煉金術士", new[] {ShareEffect.DefenseRate0036, ShareEffect.Evade43}),
            new(TitleField.Last, 126, "分解", new[] {ShareEffect.Stamina4, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last, 127, "復原", new[] {ShareEffect.Stamina5, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last, 128, "力量", new[] {ShareEffect.Stamina6, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last, 129, "手部", new[] {ShareEffect.Stamina7, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last,
                130,
                "價格比較",
                new[] {ShareEffect.HpRate00525, ShareEffect.DefenseRate00315, ShareEffect.CriticalRate0025}),
            new(TitleField.Last,
                131,
                "交易者",
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate0025}),
            new(TitleField.Last,
                132,
                "流動",
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate003}),
            new(TitleField.Last,
                133,
                "之王",
                new[] {ShareEffect.HpRate00825, ShareEffect.DefenseRate00495, ShareEffect.CriticalRate0035}),
            new(TitleField.Last,
                134,
                "天敵",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.ExpVolumeRateEnemy009
                }),
            new(TitleField.Last, 135, "工作者", new[] {ShareEffect.Stamina6, ShareEffect.Accuracy28_2}),
            new(TitleField.Last, 136, "極限", new[] {ShareEffect.Stamina6, ShareEffect.Evade32}),
            new(TitleField.Last,
                137,
                "訓練者",
                new[]
                {
                    ShareEffect.HpRate00975,
                    ShareEffect.DefenseRate00585,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new(TitleField.Last, 138, "滋味", new[] {ShareEffect.HpRate0045, ShareEffect.MoveSpaceRate005}),
            new(TitleField.Last, 139, "老顧客", new[] {ShareEffect.HpRate00375}),
            new(TitleField.Last, 140, "貴客", new[] {ShareEffect.HpRate00375}),
            new(TitleField.Last, 141, "開心果", new[] {ShareEffect.HpRate00375}),
            new(TitleField.Last, 142, "暴徒朋友", new[] {ShareEffect.HpRate00375}),
            new(TitleField.Last, 143, "超級貴賓", new[] {ShareEffect.HpRate00375}),
            new(TitleField.Last,
                144,
                "驅動者",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new(TitleField.Last,
                145,
                "反抗者",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate003
                }),
            new(TitleField.Last,
                146,
                "征服者",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0054,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalResistanceRate0035
                }),
            new(TitleField.Last,
                147,
                "指揮官",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.DamageReductionRatePrimal, .035m)
                }),
            new(TitleField.Last,
                148,
                "蜘蛛女王",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.DamageReductionRateJunk, .035m)
                }),
            new(TitleField.Last,
                149,
                "影子",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.DamageReductionRateFlame, .035m)
                }),
            new(TitleField.Last,
                150,
                "敵人",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.DamageReductionRateIron, .035m)
                }),
            new(TitleField.Last,
                151,
                "異形",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.DamageReductionRateSix, .035m)
                }),
            new(TitleField.Last, 152, "大王", new[] {ShareEffect.AttackRate00225}),
            new(TitleField.Last, 153, "生命", new[] {ShareEffect.AttackRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last, 154, "誕生", new[] {ShareEffect.AttackRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last, 155, "樂趣", new[] {ShareEffect.AttackRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last, 156, "喜悅", new[] {ShareEffect.AttackRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last,
                157,
                "農夫",
                new[] {ShareEffect.DefenseRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last, 158, "自足", new[] {ShareEffect.DefenseRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last,
                159,
                "天職",
                new[] {ShareEffect.DefenseRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last,
                160,
                "企業家",
                new[] {ShareEffect.DefenseRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last,
                161,
                "園藝師",
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.SGateReducedRate003}),
            new(TitleField.Last,
                162,
                "生產者",
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.CooldownShorterRate002}),
            new(TitleField.Last,
                163,
                "之手",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy003}),
            new(TitleField.Last,
                164,
                "幸福",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00375}),
            new(TitleField.Last,
                165,
                "美德",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy0045}),
            new(TitleField.Last,
                166,
                "使者",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00525}),
            new(TitleField.Last,
                167,
                "切斷者",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.Last,
                168,
                "解放者",
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalRate0035
                }),
            new(TitleField.Last,
                169,
                "驅逐者",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DamageReductionRateBoss0035
                }),
            new(TitleField.Last,
                176,
                "魔王",
                new[]
                {
                    new(StaticEffect.CriticalDamage, 550),
                    ShareEffect.ExtraDamageRateBoss0045,
                    ShareEffect.AttackSpeedRate0035,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.CooldownShorterRate, -.03m)
                }),
            new(TitleField.Last,
                177,
                "尊敬",
                new[]
                {
                    new(StaticEffect.DefenseRate, .06m),
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new(TitleField.Last,
                178,
                "大將",
                new[]
                {
                    new(StaticEffect.DamageReductionRatePartialDamage, .05m),
                    ShareEffect.SGateReducedRate003,
                    new(StaticEffect.MoneyVolumeRateEnemy, .07m),
                    new(StaticEffect.Evade, 45),
                    new(StaticEffect.DamageReductionRateFall, .05m)
                }),
            new(TitleField.Last,
                179,
                "金手",
                new Effect[]
                {
                    new(StaticEffect.MoneyVolumeRateEnemy, .10m), new(StaticEffect.SoulNovaVolumeRate, .05m)
                }),
            new(TitleField.Last,
                180,
                "遊戲",
                new[]
                {
                    new(StaticEffect.DefenseRate, .08m),
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DamageReductionRate003,
                    new(StaticEffect.CriticalRate, -.01m)
                }),
            new(TitleField.Last,
                181,
                "紀念物",
                new[]
                {
                    new(StaticEffect.Stamina, 7.2m),
                    new(StaticEffect.Hp, 550),
                    ShareEffect.SuperArmorBreakPowerRate0025,
                    ShareEffect.CriticalRate002
                }),
            new(TitleField.Last,
                182,
                "真實",
                new[]
                {
                    ShareEffect.AttackSpeedRate004,
                    new(StaticEffect.SoulNovaVolumeRate, .035m),
                    ShareEffect.ExtraDamageRateJunk0025,
                    ShareEffect.ExtraDamageRateBasic003
                }),
            new(TitleField.Last,
                183,
                "刀刃",
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new(TitleField.Last,
                184,
                "炮彈",
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new(TitleField.Last,
                185,
                "鎖鏈",
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new(TitleField.Last,
                186,
                "護盾",
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new(TitleField.Last,
                187,
                "鬥魂",
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new(TitleField.Last,
                188,
                "兵器",
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new(TitleField.Last,
                188,
                "光槍",
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new(TitleField.Last,
                190,
                "傷痕",
                new[]
                {
                    new(StaticEffect.DefenseRate, .04m),
                    new(StaticEffect.DamageReductionRateBasic, .05m),
                    ShareEffect.DamageReductionRateBoss005
                }),
            new(TitleField.Last,
                206,
                "白色騎士",
                new[]
                {
                    new(StaticEffect.CooldownShorterRate, .03m),
                    new(StaticEffect.SoulGateConsumptionReducedRate, .045m),
                    ShareEffect.HpRate01,
                    ShareEffect.DamageReductionRateBoss005
                }),
            new(TitleField.Last,
                247,
                "渴望者行者",
                new[]
                {
                    ShareEffect.CriticalRate002,
                    new(StaticEffect.CriticalDamage, 500),
                    ShareEffect.Stamina5,
                    ShareEffect.MoveSpaceRate003
                }),
            new(TitleField.Last, 250, "作戰執行者", new[] {ShareEffect.DamageReductionRatePvP0025}),
            new(TitleField.Last,
                265,
                "怪物",
                new[]
                {
                    ShareEffect.AttackRate005,
                    ShareEffect.DefenseRate0054,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalResistanceRate0035
                })
        };
    }
}