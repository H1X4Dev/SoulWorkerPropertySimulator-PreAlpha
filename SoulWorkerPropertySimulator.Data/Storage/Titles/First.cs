using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TitleData
    {
        private static readonly IReadOnlyCollection<Title> _firstTitle = new Title[]
        {
            new("嶄露頭角的", TitleField.First, 1, ShareEffect.ArrayHpRate00225),
            new("另一個", TitleField.First, 1, ShareEffect.ArrayHpRate00225),
            new("另一個", TitleField.First, 1, ShareEffect.ArrayHpRate00225),
            new("神聖的", TitleField.First, 2, new[] {ShareEffect.Stamina4}),
            new("漆黑的", TitleField.First, 3, new[] {ShareEffect.HpRate0015}),
            new("悲歎少女的", TitleField.First, 4, new[] {ShareEffect.Stamina4}),
            new("悲歎少年的", TitleField.First, 4, new[] {ShareEffect.Stamina4}),
            new("蒼穹的", TitleField.First, 5, new[] {ShareEffect.HpRate00225, new(Static.Stamina, -4)}),
            new("懲戒之刃", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("懲戒之彈", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("懲戒之鐮", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("懲戒之拳", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("懲戒之幻想", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("懲戒之炮", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("懲戒之炮", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("懲戒槍擊", TitleField.First, 6, ShareEffect.ArrayStamina5_HpRateM0015),
            new("呼風喚雨的", TitleField.First, 7, ShareEffect.ArrayHpRate00225),
            new("命運中的", TitleField.First, 8, new[] {ShareEffect.Stamina5}),
            new("危機處理", TitleField.First, 9, new[] {ShareEffect.HpRate00375, ShareEffect.CooldownShorterRate002}),
            new("需要檢查的", TitleField.First, 10, new[] {ShareEffect.HpRate0045, ShareEffect.CooldownShorterRate002}),
            new("美麗的",
                TitleField.First,
                11,
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.MoneyVolumeRateEnemy00525
                }),
            new("過度消費的", TitleField.First, 12, new[] {ShareEffect.HpRate003, ShareEffect.Evade21}),
            new("商人聯盟的", TitleField.First, 13, new[] {ShareEffect.HpRate00375, ShareEffect.Evade27}),
            new("傑出的", TitleField.First, 14, new[] {ShareEffect.HpRate0045, ShareEffect.Evade32}),
            new("光榮的",
                TitleField.First,
                15,
                new[] {ShareEffect.HpRate00525, ShareEffect.Evade37, ShareEffect.DamageReductionRate002}),
            new("心軟的",
                TitleField.First,
                16,
                new[] {ShareEffect.AttackRate00225, ShareEffect.MoneyVolumeRateEnemy00375}),
            new("老古董",
                TitleField.First,
                17,
                new[] {ShareEffect.AttackRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new("修理界的",
                TitleField.First,
                18,
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.ExpVolumeRateEnemy00525
                }),
            new("沒有棉被的",
                TitleField.First,
                19,
                new[] {ShareEffect.HpRate00975, ShareEffect.AttackRateM00135, ShareEffect.KillHpRecovery39_6}),
            new("用報紙當被子的",
                TitleField.First,
                20,
                new[] {ShareEffect.HpRate0105, ShareEffect.AttackRateM00135, ShareEffect.KillHpRecovery42_9}),
            new("復活的",
                TitleField.First,
                21,
                new[]
                {
                    ShareEffect.HpRate01125,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.KillHpRecovery46_2,
                    new(Static.Stamina, 10)
                }),
            new("頑強的",
                TitleField.First,
                22,
                new[]
                {
                    ShareEffect.HpRate012,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.KillHpRecovery49_5,
                    ShareEffect.Stamina11,
                    ShareEffect.CooldownShorterRate002
                }),
            new("敵人",
                TitleField.First,
                23,
                new[] {ShareEffect.AttackRate0027, ShareEffect.ExtraDamageRateBasic002}),
            new("眼前的敵人",
                TitleField.First,
                24,
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.ExtraDamageRateBasic0025,
                    ShareEffect.ExtraDamageRateBoss0025
                }),
            new("十萬大軍",
                TitleField.First,
                25,
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.ExtraDamageRateBasic003,
                    ShareEffect.ExtraDamageRateBoss003,
                    ShareEffect.ExpVolumeRateEnemy0075
                }),
            new("怪物的",
                TitleField.First,
                26,
                new[]
                {
                    ShareEffect.AttackRate0054,
                    new(Static.ExtraDamageRateBasic, .035m),
                    ShareEffect.ExtraDamageRateBoss0035,
                    ShareEffect.ExpVolumeRateEnemy009,
                    ShareEffect.Evade64
                }),
            new("被餡餅砸中的", TitleField.First, 27, new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.Evade21}),
            new("刻意為之的", TitleField.First, 28, new[] {ShareEffect.AttackSpeedRate004, ShareEffect.Evade27}),
            new("眼力超群的", TitleField.First, 29, new[] {ShareEffect.AttackSpeedRate005, ShareEffect.Evade32}),
            new("弱者",
                TitleField.First,
                30,
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.Evade37, ShareEffect.CooldownShorterRate002}),
            new("無畏的",
                TitleField.First,
                31,
                new[] {ShareEffect.AttackRate0018, new(Static.ExtraDamageRateBasic, .015m)}),
            new("勇敢的",
                TitleField.First,
                32,
                new[] {ShareEffect.AttackRate00225, ShareEffect.ExtraDamageRateBasic002}),
            new("傲慢的",
                TitleField.First,
                33,
                new[] {ShareEffect.AttackRate0027, ShareEffect.ExtraDamageRateBasic002}),
            new("垃圾",
                TitleField.First,
                34,
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.ExtraDamageRateBasic0025,
                    ShareEffect.DefenseBreakRate002
                }),
            new("只差2%的",
                TitleField.First,
                35,
                new[] {ShareEffect.DefenseRate0018, ShareEffect.CriticalResistanceRate0015}),
            new("畏縮的",
                TitleField.First,
                36,
                new[] {ShareEffect.DefenseRate00225, ShareEffect.CriticalResistanceRate002}),
            new("選擇中的",
                TitleField.First,
                37,
                new[] {ShareEffect.DefenseRate0027, ShareEffect.CriticalResistanceRate002}),
            new("最強",
                TitleField.First,
                38,
                new[] {ShareEffect.DefenseRate00315, ShareEffect.CriticalResistanceRate0025, ShareEffect.Evade37}),
            new("BOSS一般的", TitleField.First, 39, new[] {ShareEffect.AttackRate0018, ShareEffect.CriticalDamage258}),
            new("中級", TitleField.First, 40, new[] {ShareEffect.AttackRate00225, ShareEffect.CriticalDamage323}),
            new("二號角色", TitleField.First, 41, new[] {ShareEffect.AttackRate0027, ShareEffect.CriticalDamage387}),
            new("中級BOSS",
                TitleField.First,
                42,
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.CriticalDamage452,
                    ShareEffect.DamageReductionRate002
                }),
            new("無意識的",
                TitleField.First,
                43,
                new[]
                {
                    ShareEffect.AttackRate00315,
                    ShareEffect.ExtraDamageRateBoss0025,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new("王座",
                TitleField.First,
                44,
                new[]
                {
                    ShareEffect.AttackRate0036,
                    ShareEffect.ExtraDamageRateBoss0025,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new("BOSS",
                TitleField.First,
                45,
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.ExtraDamageRateBoss003,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate002
                }),
            new("國王",
                TitleField.First,
                46,
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.ExtraDamageRateBoss0035,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalResistanceRate0035,
                    ShareEffect.CriticalDamage774
                }),
            new("豪邁的",
                TitleField.First,
                47,
                new[]
                {
                    ShareEffect.AttackRate00675,
                    ShareEffect.AttackSpeedRateM0035,
                    ShareEffect.CriticalDamage968,
                    ShareEffect.SuperArmorBreakPowerRate0045
                }),
            new("凱旋歸來的",
                TitleField.First,
                48,
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.AttackSpeedRateM0035,
                    ShareEffect.CriticalDamage1097,
                    ShareEffect.SuperArmorBreakPowerRate005
                }),
            new("協力的",
                TitleField.First,
                49,
                new[]
                {
                    ShareEffect.AttackRate00855,
                    ShareEffect.AttackSpeedRateM0035,
                    new(Static.CriticalDamage, 1226),
                    ShareEffect.SuperArmorBreakPowerRate005
                }),
            new("區域突襲副本",
                TitleField.First,
                50,
                new[]
                {
                    ShareEffect.AttackRate009,
                    ShareEffect.AttackSpeedRateM003,
                    new(Static.CriticalDamage, 1290),
                    ShareEffect.SuperArmorBreakPowerRate005,
                    ShareEffect.CriticalRate003
                }),
            new("恐怖傀儡",
                TitleField.First,
                51,
                new[] {ShareEffect.AttackSpeedRate002, new(Static.ExtraDamageRatePuppet, .01m)}),
            new("氣球",
                TitleField.First,
                52,
                new[] {ShareEffect.AttackSpeedRate0025, new(Static.ExtraDamageRatePuppet, .015m)}),
            new("門後的",
                TitleField.First,
                53,
                new[] {ShareEffect.AttackSpeedRate003, new(Static.ExtraDamageRatePuppet, .02m)}),
            new("玩偶",
                TitleField.First,
                54,
                new[] {ShareEffect.AttackSpeedRate0035, new(Static.ExtraDamageRatePuppet, .025m)}),
            new("必須去",
                TitleField.First,
                55,
                new[] {ShareEffect.AttackSpeedRate002, new(Static.ExtraDamageRateJunk, .01m)}),
            new("麻痹的",
                TitleField.First,
                56,
                new[] {ShareEffect.AttackSpeedRate0025, new(Static.ExtraDamageRateJunk, .015m)}),
            new("下水道",
                TitleField.First,
                57,
                new[] {ShareEffect.AttackSpeedRate003, new(Static.ExtraDamageRateJunk, .02m)}),
            new("殘渣",
                TitleField.First,
                58,
                new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.ExtraDamageRateJunk0025}),
            new("扭曲的",
                TitleField.First,
                59,
                new[] {ShareEffect.AttackSpeedRate0025, new(Static.ExtraDamageRateNed, .01m)}),
            new("無情的",
                TitleField.First,
                60,
                new[] {ShareEffect.AttackSpeedRate003, new(Static.ExtraDamageRateNed, .015m)}),
            new("暴怒的",
                TitleField.First,
                61,
                new[] {ShareEffect.AttackSpeedRate0035, new(Static.ExtraDamageRateNed, .02m)}),
            new("N.E.D",
                TitleField.First,
                62,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    new(Static.ExtraDamageRateNed, .025m),
                    ShareEffect.ExtraDamageRateFlame0025
                }),
            new("生疏的",
                TitleField.First,
                63,
                new[] {ShareEffect.AttackSpeedRate0025, new(Static.ExtraDamageRateFlame, .01m)}),
            new("減肥夢",
                TitleField.First,
                64,
                new[] {ShareEffect.AttackSpeedRate003, new(Static.ExtraDamageRateFlame, .015m)}),
            new("健身",
                TitleField.First,
                65,
                new[] {ShareEffect.AttackSpeedRate0035, new(Static.ExtraDamageRateFlame, .02m)}),
            new("火焰",
                TitleField.First,
                66,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.ExtraDamageRateFlame0025,
                    new(Static.ExtraDamageRateNed, .025m)
                }),
            new("蓄意的",
                TitleField.First,
                67,
                new[] {ShareEffect.AttackSpeedRate0025, new(Static.ExtraDamageRateIron, .01m)}),
            new("鋼鐵",
                TitleField.First,
                68,
                new[] {ShareEffect.AttackSpeedRate003, new(Static.ExtraDamageRateIron, .015m)}),
            new("模型",
                TitleField.First,
                69,
                new[] {ShareEffect.AttackSpeedRate0035, new(Static.ExtraDamageRateIron, .02m)}),
            new("機器人",
                TitleField.First,
                70,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    new(Static.ExtraDamageRateIron, .025m),
                    new(Static.ExtraDamageRateSoul, .025m)
                }),
            new("日久生情的",
                TitleField.First,
                71,
                new[] {ShareEffect.Stamina11, ShareEffect.DefenseRateM0027, ShareEffect.ExtraDamageRateSoul0045}),
            new("充滿殺意的",
                TitleField.First,
                72,
                new[]
                {
                    ShareEffect.Stamina11,
                    ShareEffect.DefenseRateM00225,
                    ShareEffect.ExtraDamageRateSoul0045,
                    ShareEffect.Evade70
                }),
            new("打情罵俏的",
                TitleField.First,
                73,
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.ExtraDamageRateSoul005,
                    ShareEffect.Evade80
                }),
            new("近乎",
                TitleField.First,
                74,
                new[]
                {
                    ShareEffect.Stamina12,
                    ShareEffect.DefenseRateM0018,
                    ShareEffect.ExtraDamageRateSoul005,
                    ShareEffect.Evade91,
                    ShareEffect.SGateReducedRate003
                }),
            new("破壞",
                TitleField.First,
                75,
                new[] {ShareEffect.HpRate0015, ShareEffect.SuperArmorBreakPowerRate001}),
            new("盾牌",
                TitleField.First,
                76,
                new[] {ShareEffect.HpRate00225, ShareEffect.SuperArmorBreakPowerRate0015}),
            new("銅牆鐵壁",
                TitleField.First,
                77,
                new[] {ShareEffect.HpRate003, new(Static.SuperArmorBreakPowerRate, .02m)}),
            new("破甲",
                TitleField.First,
                78,
                new[] {ShareEffect.HpRate00375, ShareEffect.SuperArmorBreakPowerRate0025}),
            new("手疼",
                TitleField.First,
                79,
                new[] {ShareEffect.AttackSpeedRate0025, ShareEffect.SGateReducedRate003}),
            new("夢幻般的",
                TitleField.First,
                80,
                new[] {ShareEffect.AttackSpeedRate003, ShareEffect.SGateReducedRate003}),
            new("人品爆發",
                TitleField.First,
                81,
                new[] {ShareEffect.AttackSpeedRate0035, ShareEffect.SGateReducedRate003}),
            new("傳說中的",
                TitleField.First,
                82,
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.SGateReducedRate003}),
            new("心地善良的", TitleField.First, 83, new[] {ShareEffect.Stamina5, ShareEffect.CooldownShorterRate002}),
            new("藍色問號的", TitleField.First, 84, new[] {ShareEffect.Stamina6, ShareEffect.CooldownShorterRate002}),
            new("前世",
                TitleField.First,
                85,
                new[] {ShareEffect.Stamina7, ShareEffect.CooldownShorterRate002, ShareEffect.DefenseBreakRate002}),
            new("1000",
                TitleField.First,
                86,
                new[]
                {
                    ShareEffect.Stamina8,
                    ShareEffect.CooldownShorterRate002,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.Accuracy47
                }),
            new("迷惘", TitleField.First, 87, new[] {ShareEffect.HpRate003, ShareEffect.SGateReducedRate003}),
            new("在迷宮中的",
                TitleField.First,
                88,
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.SGateReducedRate003,
                    ShareEffect.ExpVolumeRateEnemy00525
                }),
            new("迷宮",
                TitleField.First,
                89,
                new[]
                {
                    ShareEffect.HpRate0075,
                    ShareEffect.SGateReducedRate003,
                    ShareEffect.ExpVolumeRateEnemy0075,
                    ShareEffect.DefenseBreakRate002
                }),
            new("光速",
                TitleField.First,
                90,
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.AttackRateM00135, ShareEffect.Accuracy56_4}),
            new("神速的",
                TitleField.First,
                91,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    new(Static.Accuracy, 61.1m),
                    ShareEffect.CooldownShorterRate002
                }),
            new("遁地術",
                TitleField.First,
                92,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy65_8,
                    ShareEffect.CooldownShorterRate002
                }),
            new("疾速",
                TitleField.First,
                93,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.AttackRateM00135,
                    ShareEffect.Accuracy70_5,
                    ShareEffect.CooldownShorterRate002,
                    new(Static.Evade, 107)
                }),
            new("菁英",
                TitleField.First,
                94,
                new[] {ShareEffect.AttackRate00405, ShareEffect.Accuracy42_3, ShareEffect.KillHpRecovery29_7}),
            new("榮耀的",
                TitleField.First,
                95,
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.Accuracy47,
                    ShareEffect.KillHpRecovery33,
                    ShareEffect.CriticalDamage645
                }),
            new("第一",
                TitleField.First,
                96,
                new[]
                {
                    new(Static.AttackRate, .0495m),
                    ShareEffect.Accuracy51_7,
                    ShareEffect.KillHpRecovery36_3,
                    ShareEffect.CriticalDamage710
                }),
            new("神一般的",
                TitleField.First,
                97,
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.Accuracy56_4,
                    ShareEffect.KillHpRecovery39_6,
                    ShareEffect.CriticalDamage774,
                    ShareEffect.AttackSpeedRate005
                }),
            new("雙槍",
                TitleField.First,
                98,
                new[]
                {
                    ShareEffect.DefenseRate00585, ShareEffect.MoveSpaceRateM005, ShareEffect.DefenseBreakRate002
                }),
            new("絕對意志",
                TitleField.First,
                99,
                new[]
                {
                    new(Static.DefenseRate, .063m),
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new("有點奇怪的",
                TitleField.First,
                100,
                new[]
                {
                    ShareEffect.DefenseRate00675,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new("故意的",
                TitleField.First,
                101,
                new[]
                {
                    ShareEffect.DefenseRate0072,
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003,
                    new(Static.CriticalResistanceRate, .05m)
                }),
            new("遊樂園的", TitleField.First, 102, new[] {ShareEffect.HpRate003, ShareEffect.MoneyVolumeRateEnemy003}),
            new("富礦",
                TitleField.First,
                103,
                new[]
                {
                    ShareEffect.HpRate00525,
                    ShareEffect.MoneyVolumeRateEnemy00525,
                    ShareEffect.SoulNovaVolumeRate003
                }),
            new("身經百戰的",
                TitleField.First,
                104,
                new[]
                {
                    ShareEffect.HpRate0075,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002
                }),
            new("掉落",
                TitleField.First,
                105,
                new[]
                {
                    new(Static.HpRate, .09m),
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.SGateReducedRate003
                }),
            new("固執的", TitleField.First, 106, new[] {ShareEffect.HpRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new("需要強化的", TitleField.First, 107, new[] {ShareEffect.HpRate00525, ShareEffect.SoulNovaVolumeRate003}),
            new("圓形",
                TitleField.First,
                108,
                new[]
                {
                    new(Static.HpRate, .06m),
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate0025
                }),
            new("乙太",
                TitleField.First,
                109,
                new[]
                {
                    ShareEffect.HpRate00675,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new("達到新境界的",
                TitleField.First,
                110,
                new[]
                {
                    ShareEffect.AttackRate00765,
                    ShareEffect.HpRateM00675,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new("遊刃有餘的",
                TitleField.First,
                111,
                new[]
                {
                    ShareEffect.AttackRate0081,
                    ShareEffect.HpRateM006,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005
                }),
            new("老練的",
                TitleField.First,
                112,
                new[]
                {
                    ShareEffect.AttackRate00855,
                    ShareEffect.HpRateM00525,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005,
                    ShareEffect.ExtraDamageRateBoss005
                }),
            new("如魚得水的",
                TitleField.First,
                113,
                new[]
                {
                    ShareEffect.AttackRate009,
                    ShareEffect.HpRateM0045,
                    ShareEffect.ExtraDamageRateSix005,
                    ShareEffect.CriticalRate005,
                    ShareEffect.ExtraDamageRateBoss005
                }),
            new("做完熱身運動的", TitleField.First, 114, new[] {ShareEffect.AttackSpeedRate002}),
            new("饑餓的", TitleField.First, 115, new[] {ShareEffect.AttackSpeedRate0025}),
            new("失眠的", TitleField.First, 116, new[] {ShareEffect.AttackSpeedRate002, ShareEffect.AttackRate00135}),
            new("時間", TitleField.First, 117, new[] {ShareEffect.AttackSpeedRate0025, ShareEffect.AttackRate00135}),
            new("強化", TitleField.First, 118, new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade32}),
            new("黃金", TitleField.First, 119, new[] {ShareEffect.MoveSpaceRate005, ShareEffect.Evade43}),
            new("下一步",
                TitleField.First,
                120,
                new[] {ShareEffect.AttackRate0027, ShareEffect.MoneyVolumeRateEnemy0045}),
            new("這東西",
                TitleField.First,
                121,
                new[] {ShareEffect.AttackRate0036, ShareEffect.MoneyVolumeRateEnemy006}),
            new("強化變成了",
                TitleField.First,
                122,
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.MoneyVolumeRateEnemy0075,
                    ShareEffect.CooldownShorterRate002
                }),
            new("傳說中的",
                TitleField.First,
                123,
                new[]
                {
                    ShareEffect.AttackRate0054,
                    ShareEffect.MoneyVolumeRateEnemy009,
                    ShareEffect.CooldownShorterRate002
                }),
            new("製作", TitleField.First, 124, new[] {ShareEffect.DefenseRate0027, ShareEffect.Evade32}),
            new("黃金", TitleField.First, 125, new[] {ShareEffect.DefenseRate0036, ShareEffect.Evade43}),
            new("神秘的", TitleField.First, 126, new[] {ShareEffect.HpRate00225, ShareEffect.SGateReducedRate003}),
            new("無法", TitleField.First, 127, new[] {ShareEffect.HpRate003, ShareEffect.SGateReducedRate003}),
            new("分解是", TitleField.First, 128, new[] {ShareEffect.HpRate00375, ShareEffect.SGateReducedRate003}),
            new("庖丁", TitleField.First, 129, new[] {ShareEffect.HpRate0045, ShareEffect.SGateReducedRate003}),
            new("徹底的",
                TitleField.First,
                130,
                new[] {ShareEffect.HpRate00525, ShareEffect.DefenseRate00315, ShareEffect.CriticalRate0025}),
            new("熟練的",
                TitleField.First,
                131,
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate0025}),
            new("金錢",
                TitleField.First,
                132,
                new[] {ShareEffect.HpRate00675, ShareEffect.DefenseRate00405, ShareEffect.CriticalRate003}),
            new("購物",
                TitleField.First,
                133,
                new[] {ShareEffect.HpRate00825, ShareEffect.DefenseRate00495, ShareEffect.CriticalRate0035}),
            new("藏寶狸的",
                TitleField.First,
                134,
                new[]
                {
                    ShareEffect.MoveSpaceRate005,
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.MoneyVolumeRateEnemy009
                }),
            new("兢兢業業", TitleField.First, 135, new[] {ShareEffect.Stamina6, ShareEffect.Accuracy28_2}),
            new("隱藏", TitleField.First, 136, new[] {ShareEffect.Stamina6, ShareEffect.Evade32}),
            new("虛擬世界的",
                TitleField.First,
                137,
                new[]
                {
                    ShareEffect.HpRate00975,
                    ShareEffect.DefenseRate00585,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003
                }),
            new("花錢的", TitleField.First, 138, new[] {ShareEffect.HpRate0045, ShareEffect.MoveSpaceRate005}),
            new("齋藤的", TitleField.First, 139, new[] {ShareEffect.HpRate00375}),
            new("由美的", TitleField.First, 140, new[] {ShareEffect.HpRate00375}),
            new("珍妮絲的", TitleField.First, 141, new[] {ShareEffect.HpRate00375}),
            new("特麗莎的", TitleField.First, 142, new[] {ShareEffect.HpRate00375}),
            new("阿珍的", TitleField.First, 143, new[] {ShareEffect.HpRate00375}),
            new("扭曲幻境",
                TitleField.First,
                144,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003
                }),
            new("金光幻境",
                TitleField.First,
                145,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0045,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate003
                }),
            new("荒蕪幻境",
                TitleField.First,
                146,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.DefenseRate0054,
                    ShareEffect.SuperArmorBreakPowerRate0035,
                    ShareEffect.CriticalResistanceRate0035
                }),
            new("傀儡",
                TitleField.First,
                147,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.ExtraDamageRatePuppet, .035m)
                }),
            new("紫色",
                TitleField.First,
                148,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.ExtraDamageRateJunk, .035m)
                }),
            new("漆黑",
                TitleField.First,
                149,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.ExtraDamageRateFlame, .035m)
                }),
            new("未完成的",
                TitleField.First,
                150,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.ExtraDamageRateIron, .035m)
                }),
            new("金色",
                TitleField.First,
                151,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    new(Static.ExtraDamageRateSix, .035m)
                }),
            new("蹭吃蹭喝", TitleField.First, 152, new[] {ShareEffect.DefenseRate00225}),
            new("萌發的",
                TitleField.First,
                153,
                new[] {ShareEffect.AttackRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new("激蕩的",
                TitleField.First,
                154,
                new[] {ShareEffect.AttackRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new("成長的",
                TitleField.First,
                155,
                new[] {ShareEffect.AttackRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new("盛放的",
                TitleField.First,
                156,
                new[] {ShareEffect.AttackRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new("新手",
                TitleField.First,
                157,
                new[] {ShareEffect.DefenseRate00315, ShareEffect.SoulNovaVolumeRate003}),
            new("自給",
                TitleField.First,
                158,
                new[] {ShareEffect.DefenseRate0036, ShareEffect.SoulNovaVolumeRate003}),
            new("這是我的",
                TitleField.First,
                159,
                new[] {ShareEffect.DefenseRate00405, ShareEffect.SoulNovaVolumeRate003}),
            new("農民",
                TitleField.First,
                160,
                new[] {ShareEffect.DefenseRate0045, ShareEffect.SoulNovaVolumeRate003}),
            new("黃金時間",
                TitleField.First,
                161,
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.MoneyVolumeRateEnemy003}),
            new("肥料",
                TitleField.First,
                162,
                new[] {ShareEffect.AttackSpeedRate004, ShareEffect.CooldownShorterRate002}),
            new("援助",
                TitleField.First,
                163,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy003}),
            new("在一起的",
                TitleField.First,
                164,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00375}),
            new("善行的",
                TitleField.First,
                165,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy0045}),
            new("上帝",
                TitleField.First,
                166,
                new[] {ShareEffect.MoveSpaceRate005, ShareEffect.MoneyVolumeRateEnemy00525}),
            new("虛空",
                TitleField.First,
                167,
                new[] {ShareEffect.AttackSpeedRate005, ShareEffect.SoulNovaVolumeRate003}),
            new("第六區域的",
                TitleField.First,
                168,
                new[]
                {
                    ShareEffect.AttackRate0045,
                    ShareEffect.ExtraDamageRateBoss003,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    ShareEffect.CriticalResistanceRate002
                }),
            new("災難的",
                TitleField.First,
                169,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SoulNovaVolumeRate003,
                    ShareEffect.ExtraDamageRateBoss0035
                }),
            new("可怕的",
                TitleField.First,
                176,
                new[]
                {
                    new(Static.AttackRate, .064m),
                    new(Static.ExtraDamageRateBasic, .05m),
                    ShareEffect.ExtraDamageRateBoss0045,
                    ShareEffect.Stamina9,
                    new(Static.CriticalDamage, 250)
                }),
            new("全部的",
                TitleField.First,
                177,
                new[] {new(Static.Hp, 2500), ShareEffect.Evade80, ShareEffect.CooldownShorterRate002}),
            new("史無前例",
                TitleField.First,
                178,
                new[]
                {
                    new(Static.HpRate, .08m),
                    ShareEffect.CriticalRate003,
                    new(Static.CriticalDamage, 750),
                    new(Static.AttackRate, -.05m)
                }),
            new("世紀的",
                TitleField.First,
                179,
                new[]
                {
                    new(Static.AttackRate, .06m),
                    new(Static.Accuracy, 60),
                    new(Static.Accuracy, 100),
                    ShareEffect.CooldownShorterRate002
                }),
            new("專家",
                TitleField.First,
                180,
                new[]
                {
                    new(Static.DefenseRate, .078m),
                    ShareEffect.MoveSpaceRateM005,
                    ShareEffect.DefenseBreakRate002,
                    ShareEffect.DamageReductionRate003,
                    new(Static.Hp, 500)
                }),
            new("天然", TitleField.First, 181, new[] {ShareEffect.HpRate01, new(Static.DefenseRate, .05m)}),
            new("到達",
                TitleField.First,
                182,
                new[]
                {
                    ShareEffect.AttackSpeedRate005,
                    ShareEffect.SuperArmorBreakPowerRate003,
                    new(Static.ExtraDamageRateBasic, .0425m),
                    new(Static.SoulNovaVolumeRate, .04m)
                }),
            new("勇氣",
                TitleField.First,
                183,
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new("永續的",
                TitleField.First,
                184,
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new("搶先的",
                TitleField.First,
                185,
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new("熱情的",
                TitleField.First,
                186,
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new("非凡的",
                TitleField.First,
                187,
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new("橫行",
                TitleField.First,
                188,
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new("突變的",
                TitleField.First,
                188,
                new[]
                {
                    ShareEffect.AttackSpeedRate002,
                    ShareEffect.SuperArmorBreakPowerRate0045,
                    ShareEffect.Hp1500,
                    ShareEffect.DefenseBreakRate002
                }),
            new("殘存的", TitleField.First, 190, new Effect[] {new(Static.Hp, 2200), new(Static.KillHpRecovery, 50)}),
            new("清高地?理想的",
                TitleField.First,
                206,
                new Effect[]
                {
                    new(Static.CriticalRate, .04m),
                    new(Static.AttackRate, .08m),
                    new(Static.DefenseBreakRate, .035m),
                    new(Static.DamageReductionRateBasic, .04m)
                }),
            new("幻想般的",
                TitleField.First,
                249,
                new[]
                {
                    ShareEffect.AttackSpeedRate004,
                    new(Static.MoveSpaceRate, .06m),
                    new(Static.CooldownShorterRate, .04m),
                    new(Static.Evade, 150)
                }),
            new("不敗的", TitleField.First, 250, new[] {ShareEffect.DamageReductionRatePvP0025}),
            new("虛空的",
                TitleField.First,
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