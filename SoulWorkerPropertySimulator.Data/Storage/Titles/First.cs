using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TitleData
    {
        private static readonly IReadOnlyCollection<Title> FirstTitle = new Title[]
        {
            new(TitleField.First, 1, "嶄露頭角的", ShareEffect.ArrayHpRate00225),
            new(TitleField.First, 1, "另一個", ShareEffect.ArrayHpRate00225),
            new(TitleField.First, 1, "另一個", ShareEffect.ArrayHpRate00225),
            new(TitleField.First, 2, "神聖的", new[] {ShareEffect.Stamina4}),
            new(TitleField.First, 3, "漆黑的", new[] {ShareEffect.HpRate0015}),
            new(TitleField.First, 4, "悲歎少女的", new[] {ShareEffect.Stamina4}),
            new(TitleField.First, 4, "悲歎少年的", new[] {ShareEffect.Stamina4}),
            new(TitleField.First, 5, "蒼穹的", new[] {ShareEffect.HpRate00225, new(StaticEffect.Stamina, -4)}),
            new(TitleField.First, 6, "懲戒之刃", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 6, "懲戒之彈", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 6, "懲戒之鐮", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 6, "懲戒之拳", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 6, "懲戒之幻想", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 6, "懲戒之炮", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 6, "懲戒之炮", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 6, "懲戒槍擊", ShareEffect.ArrayStamina5_HpRateM0015),
            new(TitleField.First, 7, "呼風喚雨的", ShareEffect.ArrayHpRate00225),
            new(TitleField.First, 8, "命運中的", new[] {ShareEffect.Stamina5}),
            new(TitleField.First, 9, "危機處理", new[] {ShareEffect.HpRate00375, ShareEffect.CooldownShorterRate002}),
            new(TitleField.First, 10, "需要檢查的", new[] {ShareEffect.HpRate0045, ShareEffect.CooldownShorterRate002}),
            new(TitleField.First,
                11,
                "美麗的",
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.MoneyVolumeRateEnemy00525
                }),
            new(TitleField.First, 12, "過度消費的", new[] {ShareEffect.HpRate003, ShareEffect.Evade21}),
            new(TitleField.First, 13, "商人聯盟的", new[] {ShareEffect.HpRate00375, ShareEffect.Evade27}),
            new(TitleField.First, 14, "傑出的", new[] {ShareEffect.HpRate0045, ShareEffect.Evade32}),
            new(TitleField.First,
                15,
                "光榮的",
                new[] {ShareEffect.HpRate00525, ShareEffect.Evade37, ShareEffect.DamageReductionRate002}),
            new(TitleField.First,
                16,
                "心軟的",
                new[] {ShareEffect.AttackRate00225, ShareEffect.MoneyVolumeRateEnemy00375}),
            new(TitleField.First,
                17,
                "老古董",
                new[] {ShareEffect.AttackRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new(TitleField.First,
                18,
                "修理界的",
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.ExpVolumeRateEnemy00525
                }),
            new(TitleField.First,
                19,
                "沒有棉被的",
                new[] {ShareEffect.HpRate00975, ShareEffect.AttackRateM00135, ShareEffect.KillHpRecovery39_6}),
            new(TitleField.First,
                20,
                "用報紙當被子的",
                new[] {ShareEffect.HpRate0105, ShareEffect.AttackRateM00135, ShareEffect.KillHpRecovery42_9}),
            new(TitleField.First,
                21,
                "復活的",
                new[]
                {
                    ShareEffect.HpRate01125,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.KillHpRecovery46_2,
                    new(StaticEffect.Stamina, 10)
                }),
            new(TitleField.First,
                22,
                "頑強的",
                new[]
                {
                    ShareEffect.HpRate012,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.KillHpRecovery49_5,
                    ShareEffect.Stamina11,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.First,
                23,
                "敵人",
                new[] {ShareEffect.AttackRate0027, ShareEffect.ExtraDamageRateBasic002}),
            new(TitleField.First,
                24,
                "眼前的敵人",
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.ExtraDamageRateBasic0025,
                    ShareEffect.ExtraDamageRateBoss0025
                }),
            new(TitleField.First,
                25,
                "十萬大軍",
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.ExtraDamageRateBasic003,
                    ShareEffect.ExtraDamageRateBoss003,
                    ShareEffect.ExpVolumeRateEnemy0075
                }),
            new(TitleField.First,
                26,
                "怪物的",
                new[]
                {
                    ShareEffect.AttackRate0054,
                    new(StaticEffect.ExtraDamageRateBasic, .035m),
                    ShareEffect.ExtraDamageRateBoss0035,
                    ShareEffect.ExpVolumeRateEnemy009,
                    ShareEffect.Evade64
                }),
            new(TitleField.First, 27, "被餡餅砸中的", new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.Evade21}),
            new(TitleField.First, 28, "刻意為之的", new[] {ShareEffect.AttackSpeedRate004, ShareEffect.Evade27}),
            new(TitleField.First, 29, "眼力超群的", new[] {ShareEffect.AttackSpeedRate005, ShareEffect.Evade32}),
            new(TitleField.First,
                30,
                "弱者",
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.Evade37, ShareEffect.CooldownShorterRate002}),
            new(TitleField.First,
                31,
                "無畏的",
                new[] {ShareEffect.AttackRate0018, new(StaticEffect.ExtraDamageRateBasic, .015m)}),
            new(TitleField.First,
                32,
                "勇敢的",
                new[] {ShareEffect.AttackRate00225, ShareEffect.ExtraDamageRateBasic002}),
            new(TitleField.First,
                33,
                "傲慢的",
                new[] {ShareEffect.AttackRate0027, ShareEffect.ExtraDamageRateBasic002}),
            new(TitleField.First,
                34,
                "垃圾",
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.ExtraDamageRateBasic0025,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                35,
                "只差2%的",
                new[] {ShareEffect.DefenseRate0018, ShareEffect.CriticalResistanceRate0015}),
            new(TitleField.First,
                36,
                "畏縮的",
                new[] {ShareEffect.DefenseRate00225, ShareEffect.CriticalResistanceRate002}),
            new(TitleField.First,
                37,
                "選擇中的",
                new[] {ShareEffect.DefenseRate0027, ShareEffect.CriticalResistanceRate002}),
            new(TitleField.First,
                38,
                "最強",
                new[] {ShareEffect.DefenseRate00315, ShareEffect.CriticalResistanceRate0025, ShareEffect.Evade37}),
            new(TitleField.First, 39, "BOSS一般的", new[] {ShareEffect.AttackRate0018, ShareEffect.CriticalDamage258}),
            new(TitleField.First, 40, "中級", new[] {ShareEffect.AttackRate00225, ShareEffect.CriticalDamage323}),
            new(TitleField.First, 41, "二號角色", new[] {ShareEffect.AttackRate0027, ShareEffect.CriticalDamage387}),
            new(TitleField.First,
                42,
                "中級BOSS",
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.CriticalDamage452,
                    ShareEffect.DamageReductionRate002
                }),
            new(TitleField.First,
                43,
                "無意識的",
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.ExtraDamageRateBoss0025,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new(TitleField.First,
                44,
                "王座",
                new[]
                {
                    ShareEffect.AttackRate0036,
                    ShareEffect.ExtraDamageRateBoss0025,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new(TitleField.First,
                45,
                "BOSS",
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.ExtraDamageRateBoss003,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate002
                }),
            new(TitleField.First,
                46,
                "國王",
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.ExtraDamageRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalResistanceRate0035,
                    ShareEffect.CriticalDamage774
                }),
            new(TitleField.First,
                47,
                "豪邁的",
                new[]
                {
                    ShareEffect.AttackRate00675,
                    ShareEffect.AttackSpeedRateM0035,
                    ShareEffect.CriticalDamage968,
                    ShareEffect.SuperArmorBreakPowerRate0045
                }),
            new(TitleField.First,
                48,
                "凱旋歸來的",
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.AttackSpeedRateM0035,
                    ShareEffect.CriticalDamage1097,
                    ShareEffect.SuperArmorBreakPowerRate005
                }),
            new(TitleField.First,
                49,
                "協力的",
                new[]
                {
                    ShareEffect.AttackRate00855,
                    ShareEffect.AttackSpeedRateM0035,
                    new(StaticEffect.CriticalDamage, 1226),
                    ShareEffect.SuperArmorBreakPowerRate005
                }),
            new(TitleField.First,
                50,
                "區域突襲副本",
                new[]
                {
                    ShareEffect.AttackRate009,
                    ShareEffect.AttackSpeedRateM003,
                    new(StaticEffect.CriticalDamage, 1290),
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.CriticalRate003
                }),
            new(TitleField.First,
                51,
                "恐怖傀儡",
                new[] {ShareEffect.AttackSpeedRate002, new(StaticEffect.ExtraDamageRatePuppet, .01m)}),
            new(TitleField.First,
                52,
                "氣球",
                new[] {ShareEffect.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRatePuppet, .015m)}),
            new(TitleField.First,
                53,
                "門後的",
                new[] {ShareEffect.AttackSpeedRate003, new(StaticEffect.ExtraDamageRatePuppet, .02m)}),
            new(TitleField.First,
                54,
                "玩偶",
                new[] {ShareEffect.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRatePuppet, .025m)}),
            new(TitleField.First,
                55,
                "必須去",
                new[] {ShareEffect.AttackSpeedRate002, new(StaticEffect.ExtraDamageRateJunk, .01m)}),
            new(TitleField.First,
                56,
                "麻痹的",
                new[] {ShareEffect.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateJunk, .015m)}),
            new(TitleField.First,
                57,
                "下水道",
                new[] {ShareEffect.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateJunk, .02m)}),
            new(TitleField.First,
                58,
                "殘渣",
                new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.ExtraDamageRateJunk0025}),
            new(TitleField.First,
                59,
                "扭曲的",
                new[] {ShareEffect.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateNed, .01m)}),
            new(TitleField.First,
                60,
                "無情的",
                new[] {ShareEffect.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateNed, .015m)}),
            new(TitleField.First,
                61,
                "暴怒的",
                new[] {ShareEffect.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRateNed, .02m)}),
            new(TitleField.First,
                62,
                "N.E.D",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    new(StaticEffect.ExtraDamageRateNed, .025m),
                    ShareEffect.ExtraDamageRateFlame0025
                }),
            new(TitleField.First,
                63,
                "生疏的",
                new[] {ShareEffect.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateFlame, .01m)}),
            new(TitleField.First,
                64,
                "減肥夢",
                new[] {ShareEffect.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateFlame, .015m)}),
            new(TitleField.First,
                65,
                "健身",
                new[] {ShareEffect.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRateFlame, .02m)}),
            new(TitleField.First,
                66,
                "火焰",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.ExtraDamageRateFlame0025,
                    new(StaticEffect.ExtraDamageRateNed, .025m)
                }),
            new(TitleField.First,
                67,
                "蓄意的",
                new[] {ShareEffect.AttackSpeedRate0025, new(StaticEffect.ExtraDamageRateIron, .01m)}),
            new(TitleField.First,
                68,
                "鋼鐵",
                new[] {ShareEffect.AttackSpeedRate003, new(StaticEffect.ExtraDamageRateIron, .015m)}),
            new(TitleField.First,
                69,
                "模型",
                new[] {ShareEffect.AttackSpeedRate0035, new(StaticEffect.ExtraDamageRateIron, .02m)}),
            new(TitleField.First,
                70,
                "機器人",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    new(StaticEffect.ExtraDamageRateIron, .025m),
                    new(StaticEffect.ExtraDamageRateSoul, .025m)
                }),
            new(TitleField.First,
                71,
                "日久生情的",
                new[] {ShareEffect.Stamina11, ShareEffect.DefenseRateM0027, ShareEffect.ExtraDamageRateSoul0045}),
            new(TitleField.First,
                72,
                "充滿殺意的",
                new[]
                {
                    ShareEffect.Stamina11,
                    ShareEffect.DefenseRateM00225,
                    ShareEffect.ExtraDamageRateSoul0045,
                    ShareEffect.Evade70
                }),
            new(TitleField.First,
                73,
                "打情罵俏的",
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.ExtraDamageRateSoul005,
                    ShareEffect.Evade80
                }),
            new(TitleField.First,
                74,
                "近乎",
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.ExtraDamageRateSoul005,
                    ShareEffect.Evade91,
                    ShareEffect.SGateReducedRate003
                }),
            new(TitleField.First,
                75,
                "破壞",
                new[] {ShareEffect.HpRate0015, ShareEffect.SuperArmorBreakPowerRate001}),
            new(TitleField.First,
                76,
                "盾牌",
                new[] {ShareEffect.HpRate00225, ShareEffect.SuperArmorBreakPowerRate0015}),
            new(TitleField.First,
                77,
                "銅牆鐵壁",
                new[] {ShareEffect.HpRate003, new(StaticEffect.SuperArmorBreakPowerRate, .02m)}),
            new(TitleField.First,
                78,
                "破甲",
                new[] {ShareEffect.HpRate00375, ShareEffect.SuperArmorBreakPowerRate0025}),
            new(TitleField.First,
                79,
                "手疼",
                new[] {ShareEffect.AttackSpeedRate0025, ShareEffect.SGateReducedRate003}),
            new(TitleField.First,
                80,
                "夢幻般的",
                new[] {ShareEffect.AttackSpeedRate003, ShareEffect.SGateReducedRate003}),
            new(TitleField.First,
                81,
                "人品爆發",
                new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.SGateReducedRate003}),
            new(TitleField.First,
                82,
                "傳說中的",
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.SGateReducedRate003}),
            new(TitleField.First, 83, "心地善良的", new[] {ShareEffect.Stamina5, ShareEffect.CooldownShorterRate002}),
            new(TitleField.First, 84, "藍色問號的", new[] {ShareEffect.Stamina6, ShareEffect.CooldownShorterRate002}),
            new(TitleField.First,
                85,
                "前世",
                new[] {ShareEffect.Stamina7, ShareEffect.CooldownShorterRate002, ShareEffect.DefenseBreakRate002}),
            new(TitleField.First,
                86,
                "1000",
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.Accuracy47
                }),
            new(TitleField.First, 87, "迷惘", new[] {ShareEffect.HpRate003, ShareEffect.SGateReducedRate003}),
            new(TitleField.First,
                88,
                "在迷宮中的",
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.SGateReducedRate003,
                    ShareEffect.ExpVolumeRateEnemy00525
                }),
            new(TitleField.First,
                89,
                "迷宮",
                new[]
                {
                    ShareEffect.HpRate0075,
                    ShareEffect.SGateReducedRate003,
                    ShareEffect.ExpVolumeRateEnemy0075,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                90,
                "光速",
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.AttackRateM00135, ShareEffect.Accuracy56_4}),
            new(TitleField.First,
                91,
                "神速的",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    new(StaticEffect.Accuracy, 61.1m),
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.First,
                92,
                "遁地術",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy65_8,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.First,
                93,
                "疾速",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy70_5,
                    ShareEffect.CooldownShorterRate002,
                    new(StaticEffect.Evade, 107)
                }),
            new(TitleField.First,
                94,
                "菁英",
                new[] {ShareEffect.AttackRate00405, ShareEffect.Accuracy42_3, ShareEffect.KillHpRecovery29_7}),
            new(TitleField.First,
                95,
                "榮耀的",
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.Accuracy47,
                    ShareEffect.KillHpRecovery33,
                    ShareEffect.CriticalDamage645
                }),
            new(TitleField.First,
                96,
                "第一",
                new[]
                {
                    new(StaticEffect.AttackRate, .0495m),
                    ShareEffect.Accuracy51_7,
                    ShareEffect.KillHpRecovery36_3,
                    ShareEffect.CriticalDamage710
                }),
            new(TitleField.First,
                97,
                "神一般的",
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.Accuracy56_4,
                    ShareEffect.KillHpRecovery39_6,
                    ShareEffect.CriticalDamage774,
                    ShareEffect.AttackSpeedRate005
                }),
            new(TitleField.First,
                98,
                "雙槍",
                new[]
                {
                    ShareEffect.DefenseRate00585, ShareEffect.MoveSpaceRateM005, ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                99,
                "絕對意志",
                new[]
                {
                    new(StaticEffect.DefenseRate, .063m),
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new(TitleField.First,
                100,
                "有點奇怪的",
                new[]
                {
                    ShareEffect.DefenseRate00675,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new(TitleField.First,
                101,
                "故意的",
                new[]
                {
                    ShareEffect.DefenseRate0072,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003,
                    new(StaticEffect.CriticalResistanceRate, .05m)
                }),
            new(TitleField.First, 102, "遊樂園的", new[] {ShareEffect.HpRate003, ShareEffect.MoneyVolumeRateEnemy003}),
            new(TitleField.First,
                103,
                "富礦",
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.SoulNovaVolumeRate003
                }),
            new(TitleField.First,
                104,
                "身經百戰的",
                new[]
                {
                    ShareEffect.HpRate0075,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                105,
                "掉落",
                new[]
                {
                    new(StaticEffect.HpRate, .09m),
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.SGateReducedRate003
                }),
            new(TitleField.First, 106, "固執的", new[] {ShareEffect.HpRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First, 107, "需要強化的", new[] {ShareEffect.HpRate00525, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                108,
                "圓形",
                new[]
                {
                    new(StaticEffect.HpRate, .06m),
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new(TitleField.First,
                109,
                "乙太",
                new[]
                {
                    ShareEffect.HpRate00675,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new(TitleField.First,
                110,
                "達到新境界的",
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.HpRateM00675,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new(TitleField.First,
                111,
                "遊刃有餘的",
                new[]
                {
                    ShareEffect.AttackRate0081,
                    ShareEffect.HpRateM006,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new(TitleField.First,
                112,
                "老練的",
                new[]
                {
                    ShareEffect.AttackRate00855,
                    ShareEffect.HpRateM00525,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005,
                    ShareEffect.ExtraDamageRateBoss005
                }),
            new(TitleField.First,
                113,
                "如魚得水的",
                new[]
                {
                    ShareEffect.AttackRate009,
                    ShareEffect.HpRateM0045,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005,
                    ShareEffect.ExtraDamageRateBoss005
                }),
            new(TitleField.First, 114, "做完熱身運動的", new[] {ShareEffect.AttackSpeedRate002}),
            new(TitleField.First, 115, "饑餓的", new[] {ShareEffect.AttackSpeedRate0025}),
            new(TitleField.First, 116, "失眠的", new[] {ShareEffect.AttackSpeedRate002, ShareEffect.AttackRate00135}),
            new(TitleField.First, 117, "時間", new[] {ShareEffect.AttackSpeedRate0025, ShareEffect.AttackRate00135}),
            new(TitleField.First, 118, "強化", new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade32}),
            new(TitleField.First, 119, "黃金", new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade43}),
            new(TitleField.First,
                120,
                "下一步",
                new[] {ShareEffect.AttackRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new(TitleField.First,
                121,
                "這東西",
                new[] {ShareEffect.AttackRate0036, ShareEffect.MoneyVolumeRateEnemy006}),
            new(TitleField.First,
                122,
                "強化變成了",
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.First,
                123,
                "傳說中的",
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.First, 124, "製作", new[] {ShareEffect.DefenseRate0027, ShareEffect.Evade32}),
            new(TitleField.First, 125, "黃金", new[] {ShareEffect.DefenseRate0036, ShareEffect.Evade43}),
            new(TitleField.First, 126, "神秘的", new[] {ShareEffect.HpRate00225, ShareEffect.SGateReducedRate003}),
            new(TitleField.First, 127, "無法", new[] {ShareEffect.HpRate003, ShareEffect.SGateReducedRate003}),
            new(TitleField.First, 128, "分解是", new[] {ShareEffect.HpRate00375, ShareEffect.SGateReducedRate003}),
            new(TitleField.First, 129, "庖丁", new[] {ShareEffect.HpRate0045, ShareEffect.SGateReducedRate003}),
            new(TitleField.First,
                130,
                "徹底的",
                new[] {ShareEffect.HpRate00525, ShareEffect.DefenseRate00315, ShareEffect.CriticalRate0025}),
            new(TitleField.First,
                131,
                "熟練的",
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate0025}),
            new(TitleField.First,
                132,
                "金錢",
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate003}),
            new(TitleField.First,
                133,
                "購物",
                new[] {ShareEffect.HpRate00825, ShareEffect.DefenseRate00495, ShareEffect.CriticalRate0035}),
            new(TitleField.First,
                134,
                "藏寶狸的",
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.MoneyVolumeRateEnemy009
                }),
            new(TitleField.First, 135, "兢兢業業", new[] {ShareEffect.Stamina6, ShareEffect.Accuracy28_2}),
            new(TitleField.First, 136, "隱藏", new[] {ShareEffect.Stamina6, ShareEffect.Evade32}),
            new(TitleField.First,
                137,
                "虛擬世界的",
                new[]
                {
                    ShareEffect.HpRate00975,
                    ShareEffect.DefenseRate00585,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new(TitleField.First, 138, "花錢的", new[] {ShareEffect.HpRate0045, ShareEffect.MoveSpaceRate005}),
            new(TitleField.First, 139, "齋藤的", new[] {ShareEffect.HpRate00375}),
            new(TitleField.First, 140, "由美的", new[] {ShareEffect.HpRate00375}),
            new(TitleField.First, 141, "珍妮絲的", new[] {ShareEffect.HpRate00375}),
            new(TitleField.First, 142, "特麗莎的", new[] {ShareEffect.HpRate00375}),
            new(TitleField.First, 143, "阿珍的", new[] {ShareEffect.HpRate00375}),
            new(TitleField.First,
                144,
                "扭曲幻境",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new(TitleField.First,
                145,
                "金光幻境",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate003
                }),
            new(TitleField.First,
                146,
                "荒蕪幻境",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0054,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalResistanceRate0035
                }),
            new(TitleField.First,
                147,
                "傀儡",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.ExtraDamageRatePuppet, .035m)
                }),
            new(TitleField.First,
                148,
                "紫色",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.ExtraDamageRateJunk, .035m)
                }),
            new(TitleField.First,
                149,
                "漆黑",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.ExtraDamageRateFlame, .035m)
                }),
            new(TitleField.First,
                150,
                "未完成的",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.ExtraDamageRateIron, .035m)
                }),
            new(TitleField.First,
                151,
                "金色",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(StaticEffect.ExtraDamageRateSix, .035m)
                }),
            new(TitleField.First, 152, "蹭吃蹭喝", new[] {ShareEffect.DefenseRate00225}),
            new(TitleField.First,
                153,
                "萌發的",
                new[] {ShareEffect.AttackRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                154,
                "激蕩的",
                new[] {ShareEffect.AttackRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                155,
                "成長的",
                new[] {ShareEffect.AttackRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                156,
                "盛放的",
                new[] {ShareEffect.AttackRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                157,
                "新手",
                new[] {ShareEffect.DefenseRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                158,
                "自給",
                new[] {ShareEffect.DefenseRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                159,
                "這是我的",
                new[] {ShareEffect.DefenseRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                160,
                "農民",
                new[] {ShareEffect.DefenseRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                161,
                "黃金時間",
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.MoneyVolumeRateEnemy003}),
            new(TitleField.First,
                162,
                "肥料",
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.CooldownShorterRate002}),
            new(TitleField.First,
                163,
                "援助",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy003}),
            new(TitleField.First,
                164,
                "在一起的",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00375}),
            new(TitleField.First,
                165,
                "善行的",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy0045}),
            new(TitleField.First,
                166,
                "上帝",
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00525}),
            new(TitleField.First,
                167,
                "虛空",
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.SoulNovaVolumeRate003}),
            new(TitleField.First,
                168,
                "第六區域的",
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.ExtraDamageRateBoss003,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate002
                }),
            new(TitleField.First,
                169,
                "災難的",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.ExtraDamageRateBoss0035
                }),
            new(TitleField.First,
                176,
                "可怕的",
                new[]
                {
                    new(StaticEffect.AttackRate, .064m),
                    new(StaticEffect.ExtraDamageRateBasic, .05m),
                    ShareEffect.ExtraDamageRateBoss0045,
                    ShareEffect.Stamina9,
                    new(StaticEffect.CriticalDamage, 250)
                }),
            new(TitleField.First,
                177,
                "全部的",
                new[] {new(StaticEffect.Hp, 2500), ShareEffect.Evade80, ShareEffect.CooldownShorterRate002}),
            new(TitleField.First,
                178,
                "史無前例",
                new[]
                {
                    new(StaticEffect.HpRate, .08m),
                    ShareEffect.CriticalRate003,
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
                    ShareEffect.CooldownShorterRate002
                }),
            new(TitleField.First,
                180,
                "專家",
                new[]
                {
                    new(StaticEffect.DefenseRate, .078m),
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003,
                    new(StaticEffect.Hp, 500)
                }),
            new(TitleField.First, 181, "天然", new[] {ShareEffect.HpRate01, new(StaticEffect.DefenseRate, .05m)}),
            new(TitleField.First,
                182,
                "到達",
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    new(StaticEffect.ExtraDamageRateBasic, .0425m),
                    new(StaticEffect.SoulNovaVolumeRate, .04m)
                }),
            new(TitleField.First,
                183,
                "勇氣",
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                184,
                "永續的",
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                185,
                "搶先的",
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                186,
                "熱情的",
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                187,
                "非凡的",
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                188,
                "橫行",
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new(TitleField.First,
                188,
                "突變的",
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
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
                    ShareEffect.AttackSpeedRate004,
                    new(StaticEffect.MoveSpaceRate, .06m),
                    new(StaticEffect.CooldownShorterRate, .04m),
                    new(StaticEffect.Evade, 150)
                }),
            new(TitleField.First, 250, "不敗的", new[] {ShareEffect.DamageReductionRatePvP0025}),
            new(TitleField.First,
                265,
                "虛空的",
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