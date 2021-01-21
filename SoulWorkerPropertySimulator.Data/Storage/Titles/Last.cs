using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TitleData
    {
        private static readonly IReadOnlyCollection<Title> _lastTitle = new Title[]
        {
            new("靈魂行者", TitleField.Last, 1, ShareEffect.ArrayAttackRate00135),
            new("安排", TitleField.Last, 1, ShareEffect.ArrayAttackRate00135),
            new("安排", TitleField.Last, 1, ShareEffect.ArrayAttackRate00135),
            new("化身", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("自我", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("安慰", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("斷念", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("安心", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("犧牲", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("犧牲", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("哀悼", TitleField.Last, 2, ShareEffect.ArrayDefenseRate00135),
            new("安息", TitleField.Last, 3, new[] {ShareEffect.AttackRate0018}),
            new("劍", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("子彈", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("鐮刀", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("拳", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("幻想", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("炮火", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("炮火", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("槍擊", TitleField.Last, 4, ShareEffect.ArrayDefenseRate00135),
            new("霸王", TitleField.Last, 5, new[] {ShareEffect.AttackRate0018, new(Static.DefenseRate, -.0135m)}),
            new("降臨者", TitleField.Last, 6, new[] {ShareEffect.DefenseRate0018, ShareEffect.AttackRateM00135}),
            new("緣分", TitleField.Last, 7, ShareEffect.ArrayAttackRate00135),
            new("彷徨的少女", TitleField.Last, 8, ShareEffect.ArrayDefenseRate00135),
            new("彷徨的少年", TitleField.Last, 8, ShareEffect.ArrayDefenseRate00135),
            new("高手", TitleField.Last, 9, new[] {ShareEffect.HpRate00225, ShareEffect.CooldownShorterRate002}),
            new("傷患", TitleField.Last, 10, new[] {ShareEffect.HpRate00375, ShareEffect.CooldownShorterRate002}),
            new("消費者",
                TitleField.Last,
                11,
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.MoneyVolumeRateEnemy00525
                }),
            new("先驅者", TitleField.Last, 12, new[] {ShareEffect.Stamina5, ShareEffect.Evade21}),
            new("常客", TitleField.Last, 13, new[] {ShareEffect.Stamina6, ShareEffect.Evade27}),
            new("VIP", TitleField.Last, 14, new[] {ShareEffect.Stamina6, ShareEffect.Evade32}),
            new("VVIP",
                TitleField.Last,
                15,
                new[] {ShareEffect.Stamina7, ShareEffect.Evade37, ShareEffect.DamageReductionRate002}),
            new("武器主人",
                TitleField.Last,
                16,
                new[] {ShareEffect.DefenseRate00225, ShareEffect.MoneyVolumeRateEnemy00375}),
            new("收藏家",
                TitleField.Last,
                17,
                new[] {ShareEffect.DefenseRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new("金主",
                TitleField.Last,
                18,
                new[]
                {
                    ShareEffect.DefenseRate00315,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.ExpVolumeRateEnemy00525
                }),
            new("失敗者",
                TitleField.Last,
                19,
                new[] {ShareEffect.HpRate00975, ShareEffect.AttackRateM00225, ShareEffect.KillHpRecovery42_9}),
            new("露宿者",
                TitleField.Last,
                20,
                new[] {ShareEffect.HpRate0105, ShareEffect.AttackRateM00225, ShareEffect.KillHpRecovery46_2}),
            new("屍體",
                TitleField.Last,
                21,
                new[]
                {
                    ShareEffect.HpRate01125,
                    ShareEffect.AttackRateM00225,
                    ShareEffect.KillHpRecovery49_5,
                    ShareEffect.Stamina11
                }),
            new("不死之身",
                TitleField.Last,
                22,
                new[]
                {
                    ShareEffect.HpRate012,
                    ShareEffect.AttackRateM00225,
                    new(Static.KillHpRecovery, 52.8m),
                    ShareEffect.Stamina11,
                    ShareEffect.CooldownShorterRate002
                }),
            new("清掃者",
                TitleField.Last,
                23,
                new[] {ShareEffect.DefenseRate0036, ShareEffect.DamageReductionRateBasic0025}),
            new("消滅者",
                TitleField.Last,
                24,
                new[]
                {
                    ShareEffect.DefenseRate00405,
                    ShareEffect.DamageReductionRateBasic003,
                    ShareEffect.DamageReductionRateBoss003
                }),
            new("殲滅者",
                TitleField.Last,
                25,
                new[]
                {
                    ShareEffect.DefenseRate0045,
                    ShareEffect.DamageReductionRateBasic003,
                    ShareEffect.DamageReductionRateBoss003,
                    ShareEffect.ExpVolumeRateEnemy0075
                }),
            new("怪物",
                TitleField.Last,
                26,
                new[]
                {
                    ShareEffect.DefenseRate0054,
                    new(Static.DamageReductionRateBasic, .035m),
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.ExpVolumeRateEnemy009,
                    ShareEffect.Evade64
                }),
            new("實力角", TitleField.Last, 27, new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade21}),
            new("受益者", TitleField.Last, 28, new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade27}),
            new("鬥士", TitleField.Last, 29, new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade32}),
            new("獵人",
                TitleField.Last,
                30,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade37, ShareEffect.CooldownShorterRate002}),
            new("小市民",
                TitleField.Last,
                31,
                new[] {ShareEffect.DefenseRate0018, new(Static.DamageReductionRateBasic, .015m)}),
            new("市民",
                TitleField.Last,
                32,
                new[] {ShareEffect.DefenseRate00225, ShareEffect.DamageReductionRateBasic002}),
            new("挑釁者",
                TitleField.Last,
                33,
                new[] {ShareEffect.DefenseRate0027, ShareEffect.DamageReductionRateBasic002}),
            new("處理者",
                TitleField.Last,
                34,
                new[]
                {
                    ShareEffect.DefenseRate00315,
                    ShareEffect.DamageReductionRateBasic0025,
                    ShareEffect.DefenseBreakRate002
                }),
            new("安慰",
                TitleField.Last,
                35,
                new[] {ShareEffect.DefenseRate0018, ShareEffect.CriticalResistanceRate0015}),
            new("強者",
                TitleField.Last,
                36,
                new[] {ShareEffect.DefenseRate00225, ShareEffect.CriticalResistanceRate002}),
            new("獵手",
                TitleField.Last,
                37,
                new[] {ShareEffect.DefenseRate0027, ShareEffect.CriticalResistanceRate002}),
            new("追擊者",
                TitleField.Last,
                38,
                new[] {ShareEffect.DefenseRate00315, ShareEffect.CriticalResistanceRate0025, ShareEffect.Evade37}),
            new("二號角色", TitleField.Last, 39, new[] {ShareEffect.AttackRate0018, ShareEffect.CriticalDamage258}),
            new("挑戰者", TitleField.Last, 40, new[] {ShareEffect.AttackRate00225, ShareEffect.CriticalDamage323}),
            new("覬覦者", TitleField.Last, 41, new[] {ShareEffect.AttackRate0027, ShareEffect.CriticalDamage387}),
            new("殺手",
                TitleField.Last,
                42,
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.CriticalDamage452,
                    ShareEffect.DamageReductionRate002
                }),
            new("追蹤者",
                TitleField.Last,
                43,
                new[]
                {
                    ShareEffect.DefenseRate00315,
                    new(Static.DamageReductionRateBoss, .025m),
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new("威脅者",
                TitleField.Last,
                44,
                new[]
                {
                    ShareEffect.DefenseRate00405,
                    ShareEffect.DamageReductionRateBoss003,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new("追蹤者",
                TitleField.Last,
                45,
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalRate0035
                }),
            new("屠殺者",
                TitleField.Last,
                46,
                new[]
                {
                    ShareEffect.DefenseRate0054,
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalRate0035,
                    ShareEffect.CriticalDamage774
                }),
            new("參加者",
                TitleField.Last,
                47,
                new[]
                {
                    ShareEffect.AttackRate00675,
                    ShareEffect.AttackSpeedRateM003,
                    ShareEffect.CriticalDamage968,
                    ShareEffect.SuperArmorBreakPowerRate0045
                }),
            new("將軍",
                TitleField.Last,
                48,
                new[]
                {
                    new(Static.AttackRate, .072m),
                    ShareEffect.AttackSpeedRateM003,
                    new(Static.CriticalDamage, 1032),
                    ShareEffect.SuperArmorBreakPowerRate0045
                }),
            new("榮耀",
                TitleField.Last,
                49,
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.AttackSpeedRateM003,
                    ShareEffect.CriticalDamage1097,
                    ShareEffect.SuperArmorBreakPowerRate005
                }),
            new("會長",
                TitleField.Last,
                50,
                new[]
                {
                    ShareEffect.AttackRate0081,
                    new(Static.AttackSpeedRate, -.025m),
                    new(Static.CriticalDamage, 1161),
                    ShareEffect.SuperArmorBreakPowerRate005,
                    new(Static.CriticalRate, .045m)
                }),
            new("逃避者",
                TitleField.Last,
                51,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRatePrimal, .01m)}),
            new("紮破者",
                TitleField.Last,
                52,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRatePrimal, .015m)}),
            new("透視者",
                TitleField.Last,
                53,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRatePrimal, .02m)}),
            new("毀滅者",
                TitleField.Last,
                54,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRatePrimal, .025m)}),
            new("洗澡",
                TitleField.Last,
                55,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateJunk, .01m)}),
            new("感覺",
                TitleField.Last,
                56,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateJunk, .015m)}),
            new("居民",
                TitleField.Last,
                57,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateJunk, .02m)}),
            new("清道夫",
                TitleField.Last,
                58,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateJunk, .025m)}),
            new("信任",
                TitleField.Last,
                59,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateNed, .01m)}),
            new("憤怒",
                TitleField.Last,
                60,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateNed, .015m)}),
            new("復仇者",
                TitleField.Last,
                61,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateNed, .02m)}),
            new("復仇者",
                TitleField.Last,
                62,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.DamageReductionRateNed0025,
                    ShareEffect.DamageReductionRateFlame0025
                }),
            new("消防員",
                TitleField.Last,
                63,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateFlame, .01m)}),
            new("追逐者",
                TitleField.Last,
                64,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateFlame, .015m)}),
            new("教練",
                TitleField.Last,
                65,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateFlame, .02m)}),
            new("戰士",
                TitleField.Last,
                66,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.DamageReductionRateFlame0025,
                    ShareEffect.DamageReductionRateNed0025
                }),
            new("破壞犯",
                TitleField.Last,
                67,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateIron, .01m)}),
            new("破壞狂",
                TitleField.Last,
                68,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateIron, .015m)}),
            new("摧毀者",
                TitleField.Last,
                69,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DamageReductionRateIron, .02m)}),
            new("工程師",
                TitleField.Last,
                70,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    new(Static.DamageReductionRateIron, .025m),
                    new(Static.DamageReductionRateSoul, .025m)
                }),
            new("歡喜冤家",
                TitleField.Last,
                71,
                new[]
                {
                    ShareEffect.Stamina11, ShareEffect.DefenseRateM0027, ShareEffect.DamageReductionRateSoul0045
                }),
            new("友誼",
                TitleField.Last,
                72,
                new[]
                {
                    ShareEffect.Stamina11,
                    ShareEffect.DefenseRateM00225,
                    ShareEffect.DamageReductionRateSoul0045,
                    new(Static.Evade, 86)
                }),
            new("朋友關係",
                TitleField.Last,
                73,
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.DamageReductionRateSoul005,
                    ShareEffect.Evade91
                }),
            new("朋友",
                TitleField.Last,
                74,
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.DamageReductionRateSoul005,
                    ShareEffect.Evade91,
                    ShareEffect.SGateReducedRate003
                }),
            new("嗜好者", TitleField.Last, 75, new[] {ShareEffect.Stamina4, ShareEffect.SuperArmorBreakPowerRate001}),
            new("破碎者", TitleField.Last, 76, new[] {ShareEffect.Stamina4, ShareEffect.SuperArmorBreakPowerRate0015}),
            new("破壞者", TitleField.Last, 77, new[] {ShareEffect.Stamina5, ShareEffect.SuperArmorBreakPowerRate001}),
            new("破甲", TitleField.Last, 78, new[] {ShareEffect.Stamina5, ShareEffect.SuperArmorBreakPowerRate0015}),
            new("忍受者",
                TitleField.Last,
                79,
                new[] {ShareEffect.AttackSpeedRate002, ShareEffect.SGateReducedRate003}),
            new("連擊",
                TitleField.Last,
                80,
                new[] {ShareEffect.AttackSpeedRate0025, ShareEffect.SGateReducedRate003}),
            new("777!",
                TitleField.Last,
                81,
                new[] {ShareEffect.AttackSpeedRate003, ShareEffect.SGateReducedRate003}),
            new("連擊之王",
                TitleField.Last,
                82,
                new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.SGateReducedRate003}),
            new("冤大頭", TitleField.Last, 83, new[] {ShareEffect.Stamina5, ShareEffect.CooldownShorterRate002}),
            new("誘惑", TitleField.Last, 84, new[] {ShareEffect.Stamina6, ShareEffect.CooldownShorterRate002}),
            new("傭兵王",
                TitleField.Last,
                85,
                new[] {ShareEffect.Stamina7, ShareEffect.CooldownShorterRate002, ShareEffect.DefenseBreakRate002}),
            new("全知全能",
                TitleField.Last,
                86,
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.Accuracy47
                }),
            new("徘徊之人", TitleField.Last, 87, new[] {ShareEffect.Stamina5, ShareEffect.SGateReducedRate003}),
            new("探險家",
                TitleField.Last,
                88,
                new[] {ShareEffect.Stamina7, ShareEffect.SGateReducedRate003, ShareEffect.ExpVolumeRateEnemy00525}),
            new("探險家",
                TitleField.Last,
                89,
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.SGateReducedRate003,
                    ShareEffect.ExpVolumeRateEnemy0075,
                    ShareEffect.DefenseBreakRate002
                }),
            new("行進者",
                TitleField.Last,
                90,
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.AttackRateM00135, ShareEffect.Accuracy65_8}),
            new("賽跑選手",
                TitleField.Last,
                91,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy70_5,
                    ShareEffect.CooldownShorterRate002
                }),
            new("修煉者",
                TitleField.Last,
                92,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy79_9,
                    ShareEffect.CooldownShorterRate002
                }),
            new("騎手",
                TitleField.Last,
                93,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy79_9,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.Evade70
                }),
            new("排名入圍者",
                TitleField.Last,
                94,
                new[] {ShareEffect.DefenseRate00405, ShareEffect.Accuracy42_3, ShareEffect.KillHpRecovery29_7}),
            new("記錄",
                TitleField.Last,
                95,
                new[]
                {
                    ShareEffect.DefenseRate0045,
                    ShareEffect.Accuracy47,
                    ShareEffect.KillHpRecovery33,
                    ShareEffect.CriticalDamage645
                }),
            new("階層",
                TitleField.Last,
                96,
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.Accuracy51_7,
                    ShareEffect.KillHpRecovery36_3,
                    ShareEffect.CriticalDamage710
                }),
            new("操作",
                TitleField.Last,
                97,
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.Accuracy51_7,
                    ShareEffect.KillHpRecovery36_3,
                    ShareEffect.CriticalDamage710,
                    ShareEffect.AttackSpeedRate005
                }),
            new("適合者",
                TitleField.Last,
                98,
                new[]
                {
                    ShareEffect.DefenseRate00675, ShareEffect.MoveSpaceRateM005, ShareEffect.DefenseBreakRate002
                }),
            new("擁有者",
                TitleField.Last,
                99,
                new[]
                {
                    ShareEffect.DefenseRate0072,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate004
                }),
            new("榮譽",
                TitleField.Last,
                100,
                new[]
                {
                    ShareEffect.DefenseRate00765,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate004
                }),
            new("失敗者",
                TitleField.Last,
                101,
                new[]
                {
                    ShareEffect.DefenseRate00765,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate004,
                    new(Static.CriticalResistanceRate, .04m)
                }),
            new("挖掘機", TitleField.Last, 102, new[] {ShareEffect.Stamina6, ShareEffect.MoneyVolumeRateEnemy00375}),
            new("開拓者",
                TitleField.Last,
                103,
                new[]
                {
                    ShareEffect.Stamina7,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.SoulNovaVolumeRate003
                }),
            new("守財奴",
                TitleField.Last,
                104,
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002
                }),
            new("大富翁",
                TitleField.Last,
                105,
                new[]
                {
                    ShareEffect.Stamina9,
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.SGateReducedRate003
                }),
            new("冒險家", TitleField.Last, 106, new[] {ShareEffect.Stamina4, ShareEffect.SoulNovaVolumeRate003}),
            new("收藏", TitleField.Last, 107, new[] {ShareEffect.Stamina5, ShareEffect.SoulNovaVolumeRate003}),
            new("愛好者",
                TitleField.Last,
                108,
                new[]
                {
                    ShareEffect.Stamina7,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new("收集者",
                TitleField.Last,
                109,
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new("戰鬥",
                TitleField.Last,
                110,
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.HpRateM00675,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new("修煉者",
                TitleField.Last,
                111,
                new[]
                {
                    ShareEffect.AttackRate0081,
                    ShareEffect.HpRateM006,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new("戰鬥高手",
                TitleField.Last,
                112,
                new[]
                {
                    ShareEffect.AttackRate0081,
                    ShareEffect.HpRateM00525,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005,
                    new(Static.DamageReductionRateBoss, .04m)
                }),
            new("戰鬥",
                TitleField.Last,
                113,
                new[]
                {
                    ShareEffect.AttackRate00855,
                    ShareEffect.HpRateM0045,
                    ShareEffect.DamageReductionRateSix005,
                    ShareEffect.CriticalRate005,
                    new(Static.DamageReductionRateBoss, .045m)
                }),
            new("流浪者", TitleField.Last, 114, new[] {ShareEffect.MoveSpaceRate003}),
            new("聊天者", TitleField.Last, 115, new[] {ShareEffect.MoveSpaceRate005}),
            new("吟游詩人",
                TitleField.Last,
                116,
                new[] {ShareEffect.MoveSpaceRate005, new(Static.DefenseRate, .0045m)}),
            new("記錄者", TitleField.Last, 117, new[] {ShareEffect.MoveSpaceRate005, new(Static.DefenseRate, .009m)}),
            new("迷信者", TitleField.Last, 118, new[] {ShareEffect.AttackRate0027, ShareEffect.Evade32}),
            new("駭客", TitleField.Last, 119, new[] {ShareEffect.AttackRate0036, ShareEffect.Evade43}),
            new("機會",
                TitleField.Last,
                120,
                new[] {ShareEffect.AttackRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new("白費力氣",
                TitleField.Last,
                121,
                new[] {ShareEffect.AttackRate0036, ShareEffect.MoneyVolumeRateEnemy006}),
            new("弱化",
                TitleField.Last,
                122,
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.CooldownShorterRate002
                }),
            new("破壞大師",
                TitleField.Last,
                123,
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.CooldownShorterRate002
                }),
            new("後援者", TitleField.Last, 124, new[] {ShareEffect.DefenseRate0027, ShareEffect.Evade32}),
            new("煉金術士", TitleField.Last, 125, new[] {ShareEffect.DefenseRate0036, ShareEffect.Evade43}),
            new("分解", TitleField.Last, 126, new[] {ShareEffect.Stamina4, ShareEffect.SGateReducedRate003}),
            new("復原", TitleField.Last, 127, new[] {ShareEffect.Stamina5, ShareEffect.SGateReducedRate003}),
            new("力量", TitleField.Last, 128, new[] {ShareEffect.Stamina6, ShareEffect.SGateReducedRate003}),
            new("手部", TitleField.Last, 129, new[] {ShareEffect.Stamina7, ShareEffect.SGateReducedRate003}),
            new("價格比較",
                TitleField.Last,
                130,
                new[] {ShareEffect.HpRate00525, ShareEffect.DefenseRate00315, ShareEffect.CriticalRate0025}),
            new("交易者",
                TitleField.Last,
                131,
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate0025}),
            new("流動",
                TitleField.Last,
                132,
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate003}),
            new("之王",
                TitleField.Last,
                133,
                new[] {ShareEffect.HpRate00825, ShareEffect.DefenseRate00495, ShareEffect.CriticalRate0035}),
            new("天敵",
                TitleField.Last,
                134,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.ExpVolumeRateEnemy009
                }),
            new("工作者", TitleField.Last, 135, new[] {ShareEffect.Stamina6, ShareEffect.Accuracy28_2}),
            new("極限", TitleField.Last, 136, new[] {ShareEffect.Stamina6, ShareEffect.Evade32}),
            new("訓練者",
                TitleField.Last,
                137,
                new[]
                {
                    ShareEffect.HpRate00975,
                    ShareEffect.DefenseRate00585,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new("滋味", TitleField.Last, 138, new[] {ShareEffect.HpRate0045, ShareEffect.MoveSpaceRate005}),
            new("老顧客", TitleField.Last, 139, new[] {ShareEffect.HpRate00375}),
            new("貴客", TitleField.Last, 140, new[] {ShareEffect.HpRate00375}),
            new("開心果", TitleField.Last, 141, new[] {ShareEffect.HpRate00375}),
            new("暴徒朋友", TitleField.Last, 142, new[] {ShareEffect.HpRate00375}),
            new("超級貴賓", TitleField.Last, 143, new[] {ShareEffect.HpRate00375}),
            new("驅動者",
                TitleField.Last,
                144,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new("反抗者",
                TitleField.Last,
                145,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate003
                }),
            new("征服者",
                TitleField.Last,
                146,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0054,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalResistanceRate0035
                }),
            new("指揮官",
                TitleField.Last,
                147,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.DamageReductionRatePrimal, .035m)
                }),
            new("蜘蛛女王",
                TitleField.Last,
                148,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.DamageReductionRateJunk, .035m)
                }),
            new("影子",
                TitleField.Last,
                149,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.DamageReductionRateFlame, .035m)
                }),
            new("敵人",
                TitleField.Last,
                150,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.DamageReductionRateIron, .035m)
                }),
            new("異形",
                TitleField.Last,
                151,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.DamageReductionRateSix, .035m)
                }),
            new("大王", TitleField.Last, 152, new[] {ShareEffect.AttackRate00225}),
            new("生命", TitleField.Last, 153, new[] {ShareEffect.AttackRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new("誕生", TitleField.Last, 154, new[] {ShareEffect.AttackRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new("樂趣", TitleField.Last, 155, new[] {ShareEffect.AttackRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new("喜悅", TitleField.Last, 156, new[] {ShareEffect.AttackRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new("農夫",
                TitleField.Last,
                157,
                new[] {ShareEffect.DefenseRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new("自足", TitleField.Last, 158, new[] {ShareEffect.DefenseRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new("天職",
                TitleField.Last,
                159,
                new[] {ShareEffect.DefenseRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new("企業家",
                TitleField.Last,
                160,
                new[] {ShareEffect.DefenseRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new("園藝師",
                TitleField.Last,
                161,
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.SGateReducedRate003}),
            new("生產者",
                TitleField.Last,
                162,
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.CooldownShorterRate002}),
            new("之手",
                TitleField.Last,
                163,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy003}),
            new("幸福",
                TitleField.Last,
                164,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00375}),
            new("美德",
                TitleField.Last,
                165,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy0045}),
            new("使者",
                TitleField.Last,
                166,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00525}),
            new("切斷者",
                TitleField.Last,
                167,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.SoulNovaVolumeRate003}),
            new("解放者",
                TitleField.Last,
                168,
                new[]
                {
                    ShareEffect.DefenseRate00495,
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalRate0035
                }),
            new("驅逐者",
                TitleField.Last,
                169,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DamageReductionRateBoss0035
                }),
            new("魔王",
                TitleField.Last,
                176,
                new[]
                {
                    new(Static.CriticalDamage, 550),
                    ShareEffect.ExtraDamageRateBoss0045,
                    ShareEffect.AttackSpeedRate0035,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.CooldownShorterRate, -.03m)
                }),
            new("尊敬",
                TitleField.Last,
                177,
                new[]
                {
                    new(Static.DefenseRate, .06m),
                    ShareEffect.DamageReductionRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new("大將",
                TitleField.Last,
                178,
                new[]
                {
                    new(Static.DamageReductionRatePartialDamage, .05m),
                    ShareEffect.SGateReducedRate003,
                    new(Static.MoneyVolumeRateEnemy, .07m),
                    new(Static.Evade, 45),
                    new(Static.DamageReductionRateFall, .05m)
                }),
            new("金手",
                TitleField.Last,
                179,
                new Effect[] {new(Static.MoneyVolumeRateEnemy, .10m), new(Static.SoulNovaVolumeRate, .05m)}),
            new("遊戲",
                TitleField.Last,
                180,
                new[]
                {
                    new(Static.DefenseRate, .08m),
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DamageReductionRate003,
                    new(Static.CriticalRate, -.01m)
                }),
            new("紀念物",
                TitleField.Last,
                181,
                new[]
                {
                    new(Static.Stamina, 7.2m),
                    new(Static.Hp, 550),
                    ShareEffect.SuperArmorBreakPowerRate0025,
                    ShareEffect.CriticalRate002
                }),
            new("真實",
                TitleField.Last,
                182,
                new[]
                {
                    ShareEffect.AttackSpeedRate004,
                    new(Static.SoulNovaVolumeRate, .035m),
                    ShareEffect.ExtraDamageRateJunk0025,
                    ShareEffect.ExtraDamageRateBasic003
                }),
            new("刀刃",
                TitleField.Last,
                183,
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new("炮彈",
                TitleField.Last,
                184,
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new("鎖鏈",
                TitleField.Last,
                185,
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new("護盾",
                TitleField.Last,
                186,
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new("鬥魂",
                TitleField.Last,
                187,
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new("兵器",
                TitleField.Last,
                188,
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new("光槍",
                TitleField.Last,
                188,
                new[]
                {
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.HpRate00375,
                    ShareEffect.DefenseRateM003
                }),
            new("傷痕",
                TitleField.Last,
                190,
                new[]
                {
                    new(Static.DefenseRate, .04m),
                    new(Static.DamageReductionRateBasic, .05m),
                    ShareEffect.DamageReductionRateBoss005
                }),
            new("白色騎士",
                TitleField.Last,
                206,
                new[]
                {
                    new(Static.CooldownShorterRate, .03m),
                    new(Static.SoulGateConsumptionReducedRate, .045m),
                    ShareEffect.HpRate01,
                    ShareEffect.DamageReductionRateBoss005
                }),
            new("渴望者行者",
                TitleField.Last,
                247,
                new[]
                {
                    ShareEffect.CriticalRate002,
                    new(Static.CriticalDamage, 500),
                    ShareEffect.Stamina5,
                    ShareEffect.MoveSpaceRate003
                }),
            new("作戰執行者", TitleField.Last, 250, new[] {ShareEffect.DamageReductionRatePvP0025}),
            new("怪物",
                TitleField.Last,
                265,
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