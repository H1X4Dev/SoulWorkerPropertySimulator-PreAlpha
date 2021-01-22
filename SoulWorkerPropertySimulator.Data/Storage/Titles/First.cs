using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TitleData
    {
        public static void CreateFirst(ShareEffect share) =>
            FirstTitle = new Title[]
            {
                new(TitleField.First, 1, "嶄露頭角的", share.ArrayHpRate00225),
                new(TitleField.First, 1, "另一個", share.ArrayHpRate00225),
                new(TitleField.First, 1, "另一個", share.ArrayHpRate00225),
                new(TitleField.First, 2, "神聖的", new[] {share.Stamina4}),
                new(TitleField.First, 3, "漆黑的", new[] {share.HpRate0015}),
                new(TitleField.First, 4, "悲歎少女的", new[] {share.Stamina4}),
                new(TitleField.First, 4, "悲歎少年的", new[] {share.Stamina4}),
                new(TitleField.First, 5, "蒼穹的", new[] {share.HpRate00225, new(StaticEffect.Stamina, -4)}),
                new(TitleField.First, 6, "懲戒之刃", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 6, "懲戒之彈", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 6, "懲戒之鐮", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 6, "懲戒之拳", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 6, "懲戒之幻想", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 6, "懲戒之炮", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 6, "懲戒之炮", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 6, "懲戒槍擊", share.ArrayStamina5_HpRateM0015),
                new(TitleField.First, 7, "呼風喚雨的", share.ArrayHpRate00225),
                new(TitleField.First, 8, "命運中的", new[] {share.Stamina5}),
                new(TitleField.First, 9, "危機處理", new[] {share.HpRate00375, share.CooldownShorterRate002}),
                new(TitleField.First, 10, "需要檢查的", new[] {share.HpRate0045, share.CooldownShorterRate002}),
                new(TitleField.First,
                    11,
                    "美麗的",
                    new[] {share.HpRate00525, share.CooldownShorterRate002, share.MoneyVolumeRateEnemy00525}),
                new(TitleField.First, 12, "過度消費的", new[] {share.HpRate003, share.Evade21}),
                new(TitleField.First, 13, "商人聯盟的", new[] {share.HpRate00375, share.Evade27}),
                new(TitleField.First, 14, "傑出的", new[] {share.HpRate0045, share.Evade32}),
                new(TitleField.First,
                    15,
                    "光榮的",
                    new[] {share.HpRate00525, share.Evade37, share.DamageReductionRate002}),
                new(TitleField.First, 16, "心軟的", new[] {share.AttackRate00225, share.MoneyVolumeRateEnemy00375}),
                new(TitleField.First, 17, "老古董", new[] {share.AttackRate0027, share.MoneyVolumeRateEnemy0045}),
                new(TitleField.First,
                    18,
                    "修理界的",
                    new[] {share.AttackRate00315, share.MoneyVolumeRateEnemy00525, share.ExpVolumeRateEnemy00525}),
                new(TitleField.First,
                    19,
                    "沒有棉被的",
                    new[] {share.HpRate00975, share.AttackRateM00135, share.KillHpRecovery39_6}),
                new(TitleField.First,
                    20,
                    "用報紙當被子的",
                    new[] {share.HpRate0105, share.AttackRateM00135, share.KillHpRecovery42_9}),
                new(TitleField.First,
                    21,
                    "復活的",
                    new[]
                    {
                        share.HpRate01125,
                        share.AttackRateM00135,
                        share.KillHpRecovery46_2,
                        new(StaticEffect.Stamina, 10)
                    }),
                new(TitleField.First,
                    22,
                    "頑強的",
                    new[]
                    {
                        share.HpRate012,
                        share.AttackRateM00135,
                        share.KillHpRecovery49_5,
                        share.Stamina11,
                        share.CooldownShorterRate002
                    }),
                new(TitleField.First, 23, "敵人", new[] {share.AttackRate0027, share.ExtraDamageRateBasic002}),
                new(TitleField.First,
                    24,
                    "眼前的敵人",
                    new[] {share.AttackRate00315, share.ExtraDamageRateBasic0025, share.ExtraDamageRateBoss0025}),
                new(TitleField.First,
                    25,
                    "十萬大軍",
                    new[]
                    {
                        share.AttackRate0045,
                        share.ExtraDamageRateBasic003,
                        share.ExtraDamageRateBoss003,
                        share.ExpVolumeRateEnemy0075
                    }),
                new(TitleField.First,
                    26,
                    "怪物的",
                    new[]
                    {
                        share.AttackRate0054,
                        new(StaticEffect.ExtraDamageRateBasic, .035m),
                        share.ExtraDamageRateBoss0035,
                        share.ExpVolumeRateEnemy009,
                        share.Evade64
                    }),
                new(TitleField.First, 27, "被餡餅砸中的", new[] {share.AttackSpeedRate0035, share.Evade21}),
                new(TitleField.First, 28, "刻意為之的", new[] {share.AttackSpeedRate004, share.Evade27}),
                new(TitleField.First, 29, "眼力超群的", new[] {share.AttackSpeedRate005, share.Evade32}),
                new(TitleField.First,
                    30,
                    "弱者",
                    new[] {share.AttackSpeedRate005, share.Evade37, share.CooldownShorterRate002}),
                new(TitleField.First,
                    31,
                    "無畏的",
                    new[] {share.AttackRate0018, new(StaticEffect.ExtraDamageRateBasic, .015m)}),
                new(TitleField.First, 32, "勇敢的", new[] {share.AttackRate00225, share.ExtraDamageRateBasic002}),
                new(TitleField.First, 33, "傲慢的", new[] {share.AttackRate0027, share.ExtraDamageRateBasic002}),
                new(TitleField.First,
                    34,
                    "垃圾",
                    new[] {share.AttackRate00315, share.ExtraDamageRateBasic0025, share.DefenseBreakRate002}),
                new(TitleField.First, 35, "只差2%的", new[] {share.DefenseRate0018, share.CriticalResistanceRate0015}),
                new(TitleField.First, 36, "畏縮的", new[] {share.DefenseRate00225, share.CriticalResistanceRate002}),
                new(TitleField.First, 37, "選擇中的", new[] {share.DefenseRate0027, share.CriticalResistanceRate002}),
                new(TitleField.First,
                    38,
                    "最強",
                    new[] {share.DefenseRate00315, share.CriticalResistanceRate0025, share.Evade37}),
                new(TitleField.First, 39, "BOSS一般的", new[] {share.AttackRate0018, share.CriticalDamage258}),
                new(TitleField.First, 40, "中級", new[] {share.AttackRate00225, share.CriticalDamage323}),
                new(TitleField.First, 41, "二號角色", new[] {share.AttackRate0027, share.CriticalDamage387}),
                new(TitleField.First,
                    42,
                    "中級BOSS",
                    new[] {share.AttackRate00315, share.CriticalDamage452, share.DamageReductionRate002}),
                new(TitleField.First,
                    43,
                    "無意識的",
                    new[]
                    {
                        share.AttackRate00315, share.ExtraDamageRateBoss0025, share.SuperArmorBreakPowerRate0025
                    }),
                new(TitleField.First,
                    44,
                    "王座",
                    new[]
                    {
                        share.AttackRate0036, share.ExtraDamageRateBoss0025, share.SuperArmorBreakPowerRate0025
                    }),
                new(TitleField.First,
                    45,
                    "BOSS",
                    new[]
                    {
                        share.AttackRate0045,
                        share.ExtraDamageRateBoss003,
                        share.SuperArmorBreakPowerRate003,
                        share.CriticalResistanceRate002
                    }),
                new(TitleField.First,
                    46,
                    "國王",
                    new[]
                    {
                        share.AttackRate0054,
                        share.ExtraDamageRateBoss0035,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalResistanceRate0035,
                        share.CriticalDamage774
                    }),
                new(TitleField.First,
                    47,
                    "豪邁的",
                    new[]
                    {
                        share.AttackRate00675,
                        share.AttackSpeedRateM0035,
                        share.CriticalDamage968,
                        share.SuperArmorBreakPowerRate0045
                    }),
                new(TitleField.First,
                    48,
                    "凱旋歸來的",
                    new[]
                    {
                        share.AttackRate00765,
                        share.AttackSpeedRateM0035,
                        share.CriticalDamage1097,
                        share.SuperArmorBreakPowerRate005
                    }),
                new(TitleField.First,
                    49,
                    "協力的",
                    new[]
                    {
                        share.AttackRate00855,
                        share.AttackSpeedRateM0035,
                        new(StaticEffect.CriticalDamage, 1226),
                        share.SuperArmorBreakPowerRate005
                    }),
                new(TitleField.First,
                    50,
                    "區域突襲副本",
                    new[]
                    {
                        share.AttackRate009,
                        share.AttackSpeedRateM003,
                        new(StaticEffect.CriticalDamage, 1290),
                        share.SuperArmorBreakPowerRate005,
                        share.CriticalRate003
                    }),
                new(TitleField.First,
                    51,
                    "恐怖傀儡",
                    new[] {share.AttackSpeedRate002, new(StaticEffect.ExtraDamageRatePuppet, .01m)}),
                new(TitleField.First,
                    52,
                    "氣球",
                    new[] {share.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRatePuppet, .015m)}),
                new(TitleField.First,
                    53,
                    "門後的",
                    new[] {share.AttackSpeedRate003, new(StaticEffect.ExtraDamageRatePuppet, .02m)}),
                new(TitleField.First,
                    54,
                    "玩偶",
                    new[] {share.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRatePuppet, .025m)}),
                new(TitleField.First,
                    55,
                    "必須去",
                    new[] {share.AttackSpeedRate002, new(StaticEffect.ExtraDamageRateJunk, .01m)}),
                new(TitleField.First,
                    56,
                    "麻痹的",
                    new[] {share.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateJunk, .015m)}),
                new(TitleField.First,
                    57,
                    "下水道",
                    new[] {share.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateJunk, .02m)}),
                new(TitleField.First, 58, "殘渣", new[] {share.AttackSpeedRate0035, share.ExtraDamageRateJunk0025}),
                new(TitleField.First,
                    59,
                    "扭曲的",
                    new[] {share.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateNed, .01m)}),
                new(TitleField.First,
                    60,
                    "無情的",
                    new[] {share.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateNed, .015m)}),
                new(TitleField.First,
                    61,
                    "暴怒的",
                    new[] {share.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRateNed, .02m)}),
                new(TitleField.First,
                    62,
                    "N.E.D",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        new(StaticEffect.ExtraDamageRateNed, .025m),
                        share.ExtraDamageRateFlame0025
                    }),
                new(TitleField.First,
                    63,
                    "生疏的",
                    new[] {share.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateFlame, .01m)}),
                new(TitleField.First,
                    64,
                    "減肥夢",
                    new[] {share.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateFlame, .015m)}),
                new(TitleField.First,
                    65,
                    "健身",
                    new[] {share.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRateFlame, .02m)}),
                new(TitleField.First,
                    66,
                    "火焰",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.ExtraDamageRateFlame0025,
                        new(StaticEffect.ExtraDamageRateNed, .025m)
                    }),
                new(TitleField.First,
                    67,
                    "蓄意的",
                    new[] {share.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateIron, .01m)}),
                new(TitleField.First,
                    68,
                    "鋼鐵",
                    new[] {share.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateIron, .015m)}),
                new(TitleField.First,
                    69,
                    "模型",
                    new[] {share.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRateIron, .02m)}),
                new(TitleField.First,
                    70,
                    "機器人",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        new(StaticEffect.ExtraDamageRateIron, .025m),
                        new(StaticEffect.ExtraDamageRateSoul, .025m)
                    }),
                new(TitleField.First,
                    71,
                    "日久生情的",
                    new[] {share.Stamina11, share.DefenseRateM0027, share.ExtraDamageRateSoul0045}),
                new(TitleField.First,
                    72,
                    "充滿殺意的",
                    new[] {share.Stamina11, share.DefenseRateM00225, share.ExtraDamageRateSoul0045, share.Evade70}),
                new(TitleField.First,
                    73,
                    "打情罵俏的",
                    new[] {share.Stamina12, share.DefenseRateM0018, share.ExtraDamageRateSoul005, share.Evade80}),
                new(TitleField.First,
                    74,
                    "近乎",
                    new[]
                    {
                        share.Stamina12,
                        share.DefenseRateM0018,
                        share.ExtraDamageRateSoul005,
                        share.Evade91,
                        share.SGateReducedRate003
                    }),
                new(TitleField.First, 75, "破壞", new[] {share.HpRate0015, share.SuperArmorBreakPowerRate001}),
                new(TitleField.First, 76, "盾牌", new[] {share.HpRate00225, share.SuperArmorBreakPowerRate0015}),
                new(TitleField.First,
                    77,
                    "銅牆鐵壁",
                    new[] {share.HpRate003, new(StaticEffect.SuperArmorBreakPowerRate, .02m)}),
                new(TitleField.First, 78, "破甲", new[] {share.HpRate00375, share.SuperArmorBreakPowerRate0025}),
                new(TitleField.First, 79, "手疼", new[] {share.AttackSpeedRate0025, share.SGateReducedRate003}),
                new(TitleField.First, 80, "夢幻般的", new[] {share.AttackSpeedRate003, share.SGateReducedRate003}),
                new(TitleField.First, 81, "人品爆發", new[] {share.AttackSpeedRate0035, share.SGateReducedRate003}),
                new(TitleField.First, 82, "傳說中的", new[] {share.AttackSpeedRate004, share.SGateReducedRate003}),
                new(TitleField.First, 83, "心地善良的", new[] {share.Stamina5, share.CooldownShorterRate002}),
                new(TitleField.First, 84, "藍色問號的", new[] {share.Stamina6, share.CooldownShorterRate002}),
                new(TitleField.First,
                    85,
                    "前世",
                    new[] {share.Stamina7, share.CooldownShorterRate002, share.DefenseBreakRate002}),
                new(TitleField.First,
                    86,
                    "1000",
                    new[]
                    {
                        share.Stamina8,
                        share.CooldownShorterRate002,
                        share.DefenseBreakRate002,
                        share.Accuracy47
                    }),
                new(TitleField.First, 87, "迷惘", new[] {share.HpRate003, share.SGateReducedRate003}),
                new(TitleField.First,
                    88,
                    "在迷宮中的",
                    new[] {share.HpRate00525, share.SGateReducedRate003, share.ExpVolumeRateEnemy00525}),
                new(TitleField.First,
                    89,
                    "迷宮",
                    new[]
                    {
                        share.HpRate0075,
                        share.SGateReducedRate003,
                        share.ExpVolumeRateEnemy0075,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    90,
                    "光速",
                    new[] {share.AttackSpeedRate005, share.AttackRateM00135, share.Accuracy56_4}),
                new(TitleField.First,
                    91,
                    "神速的",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.AttackRateM00135,
                        new(StaticEffect.Accuracy, 61.1m),
                        share.CooldownShorterRate002
                    }),
                new(TitleField.First,
                    92,
                    "遁地術",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.AttackRateM00135,
                        share.Accuracy65_8,
                        share.CooldownShorterRate002
                    }),
                new(TitleField.First,
                    93,
                    "疾速",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.AttackRateM00135,
                        share.Accuracy70_5,
                        share.CooldownShorterRate002,
                        new(StaticEffect.Evade, 107)
                    }),
                new(TitleField.First,
                    94,
                    "菁英",
                    new[] {share.AttackRate00405, share.Accuracy42_3, share.KillHpRecovery29_7}),
                new(TitleField.First,
                    95,
                    "榮耀的",
                    new[]
                    {
                        share.AttackRate0045, share.Accuracy47, share.KillHpRecovery33, share.CriticalDamage645
                    }),
                new(TitleField.First,
                    96,
                    "第一",
                    new[]
                    {
                        new(StaticEffect.AttackRate, .0495m),
                        share.Accuracy51_7,
                        share.KillHpRecovery36_3,
                        share.CriticalDamage710
                    }),
                new(TitleField.First,
                    97,
                    "神一般的",
                    new[]
                    {
                        share.AttackRate0054,
                        share.Accuracy56_4,
                        share.KillHpRecovery39_6,
                        share.CriticalDamage774,
                        share.AttackSpeedRate005
                    }),
                new(TitleField.First,
                    98,
                    "雙槍",
                    new[] {share.DefenseRate00585, share.MoveSpaceRateM005, share.DefenseBreakRate002}),
                new(TitleField.First,
                    99,
                    "絕對意志",
                    new[]
                    {
                        new(StaticEffect.DefenseRate, .063m),
                        share.MoveSpaceRateM005,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate003
                    }),
                new(TitleField.First,
                    100,
                    "有點奇怪的",
                    new[]
                    {
                        share.DefenseRate00675,
                        share.MoveSpaceRateM005,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate003
                    }),
                new(TitleField.First,
                    101,
                    "故意的",
                    new[]
                    {
                        share.DefenseRate0072,
                        share.MoveSpaceRateM005,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate003,
                        new(StaticEffect.CriticalResistanceRate, .05m)
                    }),
                new(TitleField.First, 102, "遊樂園的", new[] {share.HpRate003, share.MoneyVolumeRateEnemy003}),
                new(TitleField.First,
                    103,
                    "富礦",
                    new[] {share.HpRate00525, share.MoneyVolumeRateEnemy00525, share.SoulNovaVolumeRate003}),
                new(TitleField.First,
                    104,
                    "身經百戰的",
                    new[]
                    {
                        share.HpRate0075,
                        share.MoneyVolumeRateEnemy0075,
                        share.SoulNovaVolumeRate003,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    105,
                    "掉落",
                    new[]
                    {
                        new(StaticEffect.HpRate, .09m),
                        share.MoneyVolumeRateEnemy009,
                        share.SoulNovaVolumeRate003,
                        share.DefenseBreakRate002,
                        share.SGateReducedRate003
                    }),
                new(TitleField.First, 106, "固執的", new[] {share.HpRate0045, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 107, "需要強化的", new[] {share.HpRate00525, share.SoulNovaVolumeRate003}),
                new(TitleField.First,
                    108,
                    "圓形",
                    new[]
                    {
                        new(StaticEffect.HpRate, .06m),
                        share.SoulNovaVolumeRate003,
                        share.SuperArmorBreakPowerRate0025
                    }),
                new(TitleField.First,
                    109,
                    "乙太",
                    new[] {share.HpRate00675, share.SoulNovaVolumeRate003, share.SuperArmorBreakPowerRate003}),
                new(TitleField.First,
                    110,
                    "達到新境界的",
                    new[]
                    {
                        share.AttackRate00765,
                        share.HpRateM00675,
                        share.ExtraDamageRateSix005,
                        share.CriticalRate005
                    }),
                new(TitleField.First,
                    111,
                    "遊刃有餘的",
                    new[]
                    {
                        share.AttackRate0081,
                        share.HpRateM006,
                        share.ExtraDamageRateSix005,
                        share.CriticalRate005
                    }),
                new(TitleField.First,
                    112,
                    "老練的",
                    new[]
                    {
                        share.AttackRate00855,
                        share.HpRateM00525,
                        share.ExtraDamageRateSix005,
                        share.CriticalRate005,
                        share.ExtraDamageRateBoss005
                    }),
                new(TitleField.First,
                    113,
                    "如魚得水的",
                    new[]
                    {
                        share.AttackRate009,
                        share.HpRateM0045,
                        share.ExtraDamageRateSix005,
                        share.CriticalRate005,
                        share.ExtraDamageRateBoss005
                    }),
                new(TitleField.First, 114, "做完熱身運動的", new[] {share.AttackSpeedRate002}),
                new(TitleField.First, 115, "饑餓的", new[] {share.AttackSpeedRate0025}),
                new(TitleField.First, 116, "失眠的", new[] {share.AttackSpeedRate002, share.AttackRate00135}),
                new(TitleField.First, 117, "時間", new[] {share.AttackSpeedRate0025, share.AttackRate00135}),
                new(TitleField.First, 118, "強化", new[] {share.MoveSpaceRate005, share.Evade32}),
                new(TitleField.First, 119, "黃金", new[] {share.MoveSpaceRate005, share.Evade43}),
                new(TitleField.First, 120, "下一步", new[] {share.AttackRate0027, share.MoneyVolumeRateEnemy0045}),
                new(TitleField.First, 121, "這東西", new[] {share.AttackRate0036, share.MoneyVolumeRateEnemy006}),
                new(TitleField.First,
                    122,
                    "強化變成了",
                    new[] {share.AttackRate0045, share.MoneyVolumeRateEnemy0075, share.CooldownShorterRate002}),
                new(TitleField.First,
                    123,
                    "傳說中的",
                    new[] {share.AttackRate0054, share.MoneyVolumeRateEnemy009, share.CooldownShorterRate002}),
                new(TitleField.First, 124, "製作", new[] {share.DefenseRate0027, share.Evade32}),
                new(TitleField.First, 125, "黃金", new[] {share.DefenseRate0036, share.Evade43}),
                new(TitleField.First, 126, "神秘的", new[] {share.HpRate00225, share.SGateReducedRate003}),
                new(TitleField.First, 127, "無法", new[] {share.HpRate003, share.SGateReducedRate003}),
                new(TitleField.First, 128, "分解是", new[] {share.HpRate00375, share.SGateReducedRate003}),
                new(TitleField.First, 129, "庖丁", new[] {share.HpRate0045, share.SGateReducedRate003}),
                new(TitleField.First,
                    130,
                    "徹底的",
                    new[] {share.HpRate00525, share.DefenseRate00315, share.CriticalRate0025}),
                new(TitleField.First,
                    131,
                    "熟練的",
                    new[] {share.HpRate00675, share.DefenseRate00405, share.CriticalRate0025}),
                new(TitleField.First,
                    132,
                    "金錢",
                    new[] {share.HpRate00675, share.DefenseRate00405, share.CriticalRate003}),
                new(TitleField.First,
                    133,
                    "購物",
                    new[] {share.HpRate00825, share.DefenseRate00495, share.CriticalRate0035}),
                new(TitleField.First,
                    134,
                    "藏寶狸的",
                    new[] {share.MoveSpaceRate005, share.AttackSpeedRate005, share.MoneyVolumeRateEnemy009}),
                new(TitleField.First, 135, "兢兢業業", new[] {share.Stamina6, share.Accuracy28_2}),
                new(TitleField.First, 136, "隱藏", new[] {share.Stamina6, share.Evade32}),
                new(TitleField.First,
                    137,
                    "虛擬世界的",
                    new[]
                    {
                        share.HpRate00975,
                        share.DefenseRate00585,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate003
                    }),
                new(TitleField.First, 138, "花錢的", new[] {share.HpRate0045, share.MoveSpaceRate005}),
                new(TitleField.First, 139, "齋藤的", new[] {share.HpRate00375}),
                new(TitleField.First, 140, "由美的", new[] {share.HpRate00375}),
                new(TitleField.First, 141, "珍妮絲的", new[] {share.HpRate00375}),
                new(TitleField.First, 142, "特麗莎的", new[] {share.HpRate00375}),
                new(TitleField.First, 143, "阿珍的", new[] {share.HpRate00375}),
                new(TitleField.First,
                    144,
                    "扭曲幻境",
                    new[] {share.AttackSpeedRate005, share.DefenseRate0045, share.SuperArmorBreakPowerRate003}),
                new(TitleField.First,
                    145,
                    "金光幻境",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.DefenseRate0045,
                        share.SuperArmorBreakPowerRate003,
                        share.CriticalResistanceRate003
                    }),
                new(TitleField.First,
                    146,
                    "荒蕪幻境",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.DefenseRate0054,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalResistanceRate0035
                    }),
                new(TitleField.First,
                    147,
                    "傀儡",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffect.ExtraDamageRatePuppet, .035m)
                    }),
                new(TitleField.First,
                    148,
                    "紫色",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffect.ExtraDamageRateJunk, .035m)
                    }),
                new(TitleField.First,
                    149,
                    "漆黑",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffect.ExtraDamageRateFlame, .035m)
                    }),
                new(TitleField.First,
                    150,
                    "未完成的",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffect.ExtraDamageRateIron, .035m)
                    }),
                new(TitleField.First,
                    151,
                    "金色",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.SoulNovaVolumeRate003,
                        new(StaticEffect.ExtraDamageRateSix, .035m)
                    }),
                new(TitleField.First, 152, "蹭吃蹭喝", new[] {share.DefenseRate00225}),
                new(TitleField.First, 153, "萌發的", new[] {share.AttackRate00315, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 154, "激蕩的", new[] {share.AttackRate0036, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 155, "成長的", new[] {share.AttackRate00405, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 156, "盛放的", new[] {share.AttackRate0045, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 157, "新手", new[] {share.DefenseRate00315, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 158, "自給", new[] {share.DefenseRate0036, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 159, "這是我的", new[] {share.DefenseRate00405, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 160, "農民", new[] {share.DefenseRate0045, share.SoulNovaVolumeRate003}),
                new(TitleField.First, 161, "黃金時間", new[] {share.AttackSpeedRate004, share.MoneyVolumeRateEnemy003}),
                new(TitleField.First, 162, "肥料", new[] {share.AttackSpeedRate004, share.CooldownShorterRate002}),
                new(TitleField.First, 163, "援助", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy003}),
                new(TitleField.First, 164, "在一起的", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy00375}),
                new(TitleField.First, 165, "善行的", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy0045}),
                new(TitleField.First, 166, "上帝", new[] {share.MoveSpaceRate005, share.MoneyVolumeRateEnemy00525}),
                new(TitleField.First, 167, "虛空", new[] {share.AttackSpeedRate005, share.SoulNovaVolumeRate003}),
                new(TitleField.First,
                    168,
                    "第六區域的",
                    new[]
                    {
                        share.AttackRate0045,
                        share.ExtraDamageRateBoss003,
                        share.SuperArmorBreakPowerRate003,
                        share.CriticalResistanceRate002
                    }),
                new(TitleField.First,
                    169,
                    "災難的",
                    new[] {share.AttackSpeedRate005, share.SoulNovaVolumeRate003, share.ExtraDamageRateBoss0035}),
                new(TitleField.First,
                    176,
                    "可怕的",
                    new[]
                    {
                        new(StaticEffect.AttackRate, .064m),
                        new(StaticEffect.ExtraDamageRateBasic, .05m),
                        share.ExtraDamageRateBoss0045,
                        share.Stamina9,
                        new(StaticEffect.CriticalDamage, 250)
                    }),
                new(TitleField.First,
                    177,
                    "全部的",
                    new[] {new(StaticEffect.Hp, 2500), share.Evade80, share.CooldownShorterRate002}),
                new(TitleField.First,
                    178,
                    "史無前例",
                    new[]
                    {
                        new(StaticEffect.HpRate, .08m),
                        share.CriticalRate003,
                        new(StaticEffect.CriticalDamage, 750),
                        new(StaticEffect.AttackRate, -.05m)
                    }),
                new(TitleField.First,
                    179,
                    "世紀的",
                    new[]
                    {
                        new(StaticEffect.AttackRate, .06m),
                        new(StaticEffect.Accuracy, 60),
                        new(StaticEffect.Accuracy, 100),
                        share.CooldownShorterRate002
                    }),
                new(TitleField.First,
                    180,
                    "專家",
                    new[]
                    {
                        new(StaticEffect.DefenseRate, .078m),
                        share.MoveSpaceRateM005,
                        share.DefenseBreakRate002,
                        share.DamageReductionRate003,
                        new(StaticEffect.Hp, 500)
                    }),
                new(TitleField.First, 181, "天然", new[] {share.HpRate01, new(StaticEffect.DefenseRate, .05m)}),
                new(TitleField.First,
                    182,
                    "到達",
                    new[]
                    {
                        share.AttackSpeedRate005,
                        share.SuperArmorBreakPowerRate003,
                        new(StaticEffect.ExtraDamageRateBasic, .0425m),
                        new(StaticEffect.SoulNovaVolumeRate, .04m)
                    }),
                new(TitleField.First,
                    183,
                    "勇氣",
                    new[]
                    {
                        share.AttackSpeedRate002,
                        share.SuperArmorBreakPowerRate0045,
                        share.Hp1500,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    184,
                    "永續的",
                    new[]
                    {
                        share.AttackSpeedRate002,
                        share.SuperArmorBreakPowerRate0045,
                        share.Hp1500,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    185,
                    "搶先的",
                    new[]
                    {
                        share.AttackSpeedRate002,
                        share.SuperArmorBreakPowerRate0045,
                        share.Hp1500,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    186,
                    "熱情的",
                    new[]
                    {
                        share.AttackSpeedRate002,
                        share.SuperArmorBreakPowerRate0045,
                        share.Hp1500,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    187,
                    "非凡的",
                    new[]
                    {
                        share.AttackSpeedRate002,
                        share.SuperArmorBreakPowerRate0045,
                        share.Hp1500,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    188,
                    "橫行",
                    new[]
                    {
                        share.AttackSpeedRate002,
                        share.SuperArmorBreakPowerRate0045,
                        share.Hp1500,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    188,
                    "突變的",
                    new[]
                    {
                        share.AttackSpeedRate002,
                        share.SuperArmorBreakPowerRate0045,
                        share.Hp1500,
                        share.DefenseBreakRate002
                    }),
                new(TitleField.First,
                    190,
                    "殘存的",
                    new Effect[] {new(StaticEffect.Hp, 2200), new(StaticEffect.KillHpRecovery, 50)}),
                new(TitleField.First,
                    206,
                    "清高地?理想的",
                    new Effect[]
                    {
                        new(StaticEffect.CriticalRate, .04m),
                        new(StaticEffect.AttackRate, .08m),
                        new(StaticEffect.DefenseBreakRate, .035m),
                        new(StaticEffect.DamageReductionRateBasic, .04m)
                    }),
                new(TitleField.First,
                    249,
                    "幻想般的",
                    new[]
                    {
                        share.AttackSpeedRate004,
                        new(StaticEffect.MoveSpaceRate, .06m),
                        new(StaticEffect.CooldownShorterRate, .04m),
                        new(StaticEffect.Evade, 150)
                    }),
                new(TitleField.First, 250, "不敗的", new[] {share.DamageReductionRatePvP0025}),
                new(TitleField.First,
                    265,
                    "虛空的",
                    new[]
                    {
                        share.AttackRate005,
                        share.DefenseRate0054,
                        share.SuperArmorBreakPowerRate0035,
                        share.CriticalResistanceRate0035
                    })
            };

        #region

        private static IReadOnlyCollection<Title> FirstTitle { get; set; }

        #endregion
    }
}