using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class TitleData
    {
        private static          IReadOnlyCollection<Title>?                        _titles;
        private static readonly Dictionary<TitleField, IReadOnlyCollection<Title>> Result = new();

        public static IReadOnlyCollection<Title> Get(TitleField field)
        {
            if (Result.ContainsKey(field)) { return Result[field]; }

            if (_titles != null) { return Result[field] = _titles.Where(x => x.Field == field).ToList(); }

            _titles = new List<Title>
            {
                new("嶄露頭角的", TitleField.First, 1, new Effect[] {new(Static.HpRate, .0225m)}),
                new("另一個", TitleField.First, 1, new Effect[] {new(Static.HpRate, .0225m)}),
                new("另一個", TitleField.First, 1, new Effect[] {new(Static.HpRate, .0225m)}),
                new("神聖的", TitleField.First, 2, new Effect[] {new(Static.Stamina, 4)}),
                new("漆黑的", TitleField.First, 3, new Effect[] {new(Static.HpRate, .015m)}),
                new("悲歎少女的", TitleField.First, 4, new Effect[] {new(Static.Stamina, 4)}),
                new("悲歎少年的", TitleField.First, 4, new Effect[] {new(Static.Stamina, 4)}),
                new("蒼穹的", TitleField.First, 5, new Effect[] {new(Static.HpRate, .0225m), new(Static.Stamina, -4)}),
                new("懲戒之刃", TitleField.First, 6, new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("懲戒之彈", TitleField.First, 6, new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("懲戒之鐮", TitleField.First, 6, new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("懲戒之拳", TitleField.First, 6, new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("懲戒之幻想",
                    TitleField.First,
                    6,
                    new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("懲戒之炮", TitleField.First, 6, new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("懲戒之炮", TitleField.First, 6, new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("懲戒槍擊", TitleField.First, 6, new Effect[] {new(Static.Stamina, 5), new(Static.HpRate, -.015m)}),
                new("呼風喚雨的", TitleField.First, 7, new Effect[] {new(Static.HpRate, .0225m)}),
                new("命運中的", TitleField.First, 8, new Effect[] {new(Static.Stamina, 5)}),
                new("危機處理",
                    TitleField.First,
                    9,
                    new Effect[] {new(Static.HpRate, .0375m), new(Static.CooldownShorterRate, .02m)}),
                new("需要檢查的",
                    TitleField.First,
                    10,
                    new Effect[] {new(Static.HpRate, .045m), new(Static.CooldownShorterRate, .02m)}),
                new("美麗的",
                    TitleField.First,
                    11,
                    new Effect[]
                    {
                        new(Static.HpRate, .0525m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.MoneyVolumeRateEnemy, .0525m)
                    }),
                new("過度消費的", TitleField.First, 12, new Effect[] {new(Static.HpRate, .03m), new(Static.Evade, 21)}),
                new("商人聯盟的",
                    TitleField.First,
                    13,
                    new Effect[] {new(Static.HpRate, .0375m), new(Static.Evade, 27)}),
                new("傑出的", TitleField.First, 14, new Effect[] {new(Static.HpRate, .045m), new(Static.Evade, 32)}),
                new("光榮的",
                    TitleField.First,
                    15,
                    new Effect[]
                    {
                        new(Static.HpRate, .0525m), new(Static.Evade, 37), new(Static.DamageReductionRate, .02m)
                    }),
                new("心軟的",
                    TitleField.First,
                    16,
                    new Effect[] {new(Static.AttackRate, .0225m), new(Static.MoneyVolumeRateEnemy, .0375m)}),
                new("老古董",
                    TitleField.First,
                    17,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.MoneyVolumeRateEnemy, .045m)}),
                new("修理界的",
                    TitleField.First,
                    18,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0315m),
                        new(Static.MoneyVolumeRateEnemy, .0525m),
                        new(Static.ExpVolumeRateEnemy, .0525m)
                    }),
                new("沒有棉被的",
                    TitleField.First,
                    19,
                    new Effect[]
                    {
                        new(Static.HpRate, .0975m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.KillHpRecovery, 39.6m)
                    }),
                new("用報紙當被子的",
                    TitleField.First,
                    20,
                    new Effect[]
                    {
                        new(Static.HpRate, .105m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.KillHpRecovery, 42.9m)
                    }),
                new("復活的",
                    TitleField.First,
                    21,
                    new Effect[]
                    {
                        new(Static.HpRate, .1125m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.KillHpRecovery, 46.2m),
                        new(Static.Stamina, 10)
                    }),
                new("頑強的",
                    TitleField.First,
                    22,
                    new Effect[]
                    {
                        new(Static.HpRate, .12m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.KillHpRecovery, 49.5m),
                        new(Static.Stamina, 11),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("敵人",
                    TitleField.First,
                    23,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.ExtraDamageRateBasic, .02m)}),
                new("眼前的敵人",
                    TitleField.First,
                    24,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0315m),
                        new(Static.ExtraDamageRateBasic, .025m),
                        new(Static.ExtraDamageRateBoss, .025m)
                    }),
                new("十萬大軍",
                    TitleField.First,
                    25,
                    new Effect[]
                    {
                        new(Static.AttackRate, .045m),
                        new(Static.ExtraDamageRateBasic, .03m),
                        new(Static.ExtraDamageRateBoss, .03m),
                        new(Static.ExpVolumeRateEnemy, .075m)
                    }),
                new("怪物的",
                    TitleField.First,
                    26,
                    new Effect[]
                    {
                        new(Static.AttackRate, .054m),
                        new(Static.ExtraDamageRateBasic, .035m),
                        new(Static.ExtraDamageRateBoss, .035m),
                        new(Static.ExpVolumeRateEnemy, .09m),
                        new(Static.Evade, 64)
                    }),
                new("被餡餅砸中的",
                    TitleField.First,
                    27,
                    new Effect[] {new(Static.AttackSpeedRate, .035m), new(Static.Evade, 21)}),
                new("刻意為之的",
                    TitleField.First,
                    28,
                    new Effect[] {new(Static.AttackSpeedRate, .04m), new(Static.Evade, 27)}),
                new("眼力超群的",
                    TitleField.First,
                    29,
                    new Effect[] {new(Static.AttackSpeedRate, .05m), new(Static.Evade, 32)}),
                new("弱者",
                    TitleField.First,
                    30,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.Evade, 37),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("無畏的",
                    TitleField.First,
                    31,
                    new Effect[] {new(Static.AttackRate, .018m), new(Static.ExtraDamageRateBasic, .015m)}),
                new("勇敢的",
                    TitleField.First,
                    32,
                    new Effect[] {new(Static.AttackRate, .0225m), new(Static.ExtraDamageRateBasic, .02m)}),
                new("傲慢的",
                    TitleField.First,
                    33,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.ExtraDamageRateBasic, .02m)}),
                new("垃圾",
                    TitleField.First,
                    34,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0315m),
                        new(Static.ExtraDamageRateBasic, .025m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("只差2%的",
                    TitleField.First,
                    35,
                    new Effect[] {new(Static.DefenseRate, .018m), new(Static.CriticalResistanceRate, .015m)}),
                new("畏縮的",
                    TitleField.First,
                    36,
                    new Effect[] {new(Static.DefenseRate, .0225m), new(Static.CriticalResistanceRate, .02m)}),
                new("選擇中的",
                    TitleField.First,
                    37,
                    new Effect[] {new(Static.DefenseRate, .027m), new(Static.CriticalResistanceRate, .02m)}),
                new("最強",
                    TitleField.First,
                    38,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0315m),
                        new(Static.CriticalResistanceRate, .025m),
                        new(Static.Evade, 37)
                    }),
                new("BOSS一般的",
                    TitleField.First,
                    39,
                    new Effect[] {new(Static.AttackRate, .018m), new(Static.CriticalDamage, 258)}),
                new("中級",
                    TitleField.First,
                    40,
                    new Effect[] {new(Static.AttackRate, .0225m), new(Static.CriticalDamage, 323)}),
                new("二號角色",
                    TitleField.First,
                    41,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.CriticalDamage, 387)}),
                new("中級BOSS",
                    TitleField.First,
                    42,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0315m),
                        new(Static.CriticalDamage, 452),
                        new(Static.DamageReductionRate, .02m)
                    }),
                new("無意識的",
                    TitleField.First,
                    43,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0315m),
                        new(Static.ExtraDamageRateBoss, .025m),
                        new(Static.SuperArmorBreakPowerRate, .025m)
                    }),
                new("王座",
                    TitleField.First,
                    44,
                    new Effect[]
                    {
                        new(Static.AttackRate, .036m),
                        new(Static.ExtraDamageRateBoss, .025m),
                        new(Static.SuperArmorBreakPowerRate, .025m)
                    }),
                new("BOSS",
                    TitleField.First,
                    45,
                    new Effect[]
                    {
                        new(Static.AttackRate, .045m),
                        new(Static.ExtraDamageRateBoss, .03m),
                        new(Static.SuperArmorBreakPowerRate, .03m),
                        new(Static.CriticalResistanceRate, .02m)
                    }),
                new("國王",
                    TitleField.First,
                    46,
                    new Effect[]
                    {
                        new(Static.AttackRate, .054m),
                        new(Static.ExtraDamageRateBoss, .035m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalResistanceRate, .035m),
                        new(Static.CriticalDamage, 774)
                    }),
                new("豪邁的",
                    TitleField.First,
                    47,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0675m),
                        new(Static.AttackSpeedRate, -.035m),
                        new(Static.CriticalDamage, 968),
                        new(Static.SuperArmorBreakPowerRate, .045m)
                    }),
                new("凱旋歸來的",
                    TitleField.First,
                    48,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0765m),
                        new(Static.AttackSpeedRate, -.035m),
                        new(Static.CriticalDamage, 1097),
                        new(Static.SuperArmorBreakPowerRate, .05m)
                    }),
                new("協力的",
                    TitleField.First,
                    49,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0855m),
                        new(Static.AttackSpeedRate, -.035m),
                        new(Static.CriticalDamage, 1226),
                        new(Static.SuperArmorBreakPowerRate, .05m)
                    }),
                new("區域突襲副本",
                    TitleField.First,
                    50,
                    new Effect[]
                    {
                        new(Static.AttackRate, .09m),
                        new(Static.AttackSpeedRate, -.03m),
                        new(Static.CriticalDamage, 1290),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.CriticalRate, .03m)
                    }),
                new("恐怖傀儡",
                    TitleField.First,
                    51,
                    new Effect[] {new(Static.AttackSpeedRate, .02m), new(Static.ExtraDamageRatePuppet, .01m)}),
                new("氣球",
                    TitleField.First,
                    52,
                    new Effect[] {new(Static.AttackSpeedRate, .025m), new(Static.ExtraDamageRatePuppet, .015m)}),
                new("門後的",
                    TitleField.First,
                    53,
                    new Effect[] {new(Static.AttackSpeedRate, .03m), new(Static.ExtraDamageRatePuppet, .02m)}),
                new("玩偶",
                    TitleField.First,
                    54,
                    new Effect[] {new(Static.AttackSpeedRate, .035m), new(Static.ExtraDamageRatePuppet, .025m)}),
                new("必須去",
                    TitleField.First,
                    55,
                    new Effect[] {new(Static.AttackSpeedRate, .02m), new(Static.ExtraDamageRateJunk, .01m)}),
                new("麻痹的",
                    TitleField.First,
                    56,
                    new Effect[] {new(Static.AttackSpeedRate, .025m), new(Static.ExtraDamageRateJunk, .015m)}),
                new("下水道",
                    TitleField.First,
                    57,
                    new Effect[] {new(Static.AttackSpeedRate, .03m), new(Static.ExtraDamageRateJunk, .02m)}),
                new("殘渣",
                    TitleField.First,
                    58,
                    new Effect[] {new(Static.AttackSpeedRate, .035m), new(Static.ExtraDamageRateJunk, .025m)}),
                new("扭曲的",
                    TitleField.First,
                    59,
                    new Effect[] {new(Static.AttackSpeedRate, .025m), new(Static.ExtraDamageRateNED, .01m)}),
                new("無情的",
                    TitleField.First,
                    60,
                    new Effect[] {new(Static.AttackSpeedRate, .03m), new(Static.ExtraDamageRateNED, .015m)}),
                new("暴怒的",
                    TitleField.First,
                    61,
                    new Effect[] {new(Static.AttackSpeedRate, .035m), new(Static.ExtraDamageRateNED, .02m)}),
                new("N.E.D",
                    TitleField.First,
                    62,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.ExtraDamageRateNED, .025m),
                        new(Static.ExtraDamageRateFlame, .025m)
                    }),
                new("生疏的",
                    TitleField.First,
                    63,
                    new Effect[] {new(Static.AttackSpeedRate, .025m), new(Static.ExtraDamageRateFlame, .01m)}),
                new("減肥夢",
                    TitleField.First,
                    64,
                    new Effect[] {new(Static.AttackSpeedRate, .03m), new(Static.ExtraDamageRateFlame, .015m)}),
                new("健身",
                    TitleField.First,
                    65,
                    new Effect[] {new(Static.AttackSpeedRate, .035m), new(Static.ExtraDamageRateFlame, .02m)}),
                new("火焰",
                    TitleField.First,
                    66,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.ExtraDamageRateFlame, .025m),
                        new(Static.ExtraDamageRateNED, .025m)
                    }),
                new("蓄意的",
                    TitleField.First,
                    67,
                    new Effect[] {new(Static.AttackSpeedRate, .025m), new(Static.ExtraDamageRateIron, .01m)}),
                new("鋼鐵",
                    TitleField.First,
                    68,
                    new Effect[] {new(Static.AttackSpeedRate, .03m), new(Static.ExtraDamageRateIron, .015m)}),
                new("模型",
                    TitleField.First,
                    69,
                    new Effect[] {new(Static.AttackSpeedRate, .035m), new(Static.ExtraDamageRateIron, .02m)}),
                new("機器人",
                    TitleField.First,
                    70,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.ExtraDamageRateIron, .025m),
                        new(Static.ExtraDamageRateSoul, .025m)
                    }),
                new("日久生情的",
                    TitleField.First,
                    71,
                    new Effect[]
                    {
                        new(Static.Stamina, 11),
                        new(Static.DefenseRate, -.027m),
                        new(Static.ExtraDamageRateSoul, .045m)
                    }),
                new("充滿殺意的",
                    TitleField.First,
                    72,
                    new Effect[]
                    {
                        new(Static.Stamina, 11),
                        new(Static.DefenseRate, -.0225m),
                        new(Static.ExtraDamageRateSoul, .045m),
                        new(Static.Evade, 70)
                    }),
                new("打情罵俏的",
                    TitleField.First,
                    73,
                    new Effect[]
                    {
                        new(Static.Stamina, 12),
                        new(Static.DefenseRate, -.018m),
                        new(Static.ExtraDamageRateSoul, .05m),
                        new(Static.Evade, 80)
                    }),
                new("近乎",
                    TitleField.First,
                    74,
                    new Effect[]
                    {
                        new(Static.Stamina, 12),
                        new(Static.DefenseRate, -.018m),
                        new(Static.ExtraDamageRateSoul, .05m),
                        new(Static.Evade, 91),
                        new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("破壞",
                    TitleField.First,
                    75,
                    new Effect[] {new(Static.HpRate, .015m), new(Static.SuperArmorBreakPowerRate, .01m)}),
                new("盾牌",
                    TitleField.First,
                    76,
                    new Effect[] {new(Static.HpRate, .0225m), new(Static.SuperArmorBreakPowerRate, .015m)}),
                new("銅牆鐵壁",
                    TitleField.First,
                    77,
                    new Effect[] {new(Static.HpRate, .03m), new(Static.SuperArmorBreakPowerRate, .02m)}),
                new("破甲",
                    TitleField.First,
                    78,
                    new Effect[] {new(Static.HpRate, .0375m), new(Static.SuperArmorBreakPowerRate, .025m)}),
                new("手疼",
                    TitleField.First,
                    79,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .025m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("夢幻般的",
                    TitleField.First,
                    80,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .03m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("人品爆發",
                    TitleField.First,
                    81,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .035m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("傳說中的",
                    TitleField.First,
                    82,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .04m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("心地善良的",
                    TitleField.First,
                    83,
                    new Effect[] {new(Static.Stamina, 5), new(Static.CooldownShorterRate, .02m)}),
                new("藍色問號的",
                    TitleField.First,
                    84,
                    new Effect[] {new(Static.Stamina, 6), new(Static.CooldownShorterRate, .02m)}),
                new("前世",
                    TitleField.First,
                    85,
                    new Effect[]
                    {
                        new(Static.Stamina, 7),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("1000",
                    TitleField.First,
                    86,
                    new Effect[]
                    {
                        new(Static.Stamina, 8),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.Accuracy, 47)
                    }),
                new("迷惘",
                    TitleField.First,
                    87,
                    new Effect[] {new(Static.HpRate, .03m), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("在迷宮中的",
                    TitleField.First,
                    88,
                    new Effect[]
                    {
                        new(Static.HpRate, .0525m),
                        new(Static.SoulGateConsumptionReducedRate, .03m),
                        new(Static.ExpVolumeRateEnemy, .0525m)
                    }),
                new("迷宮",
                    TitleField.First,
                    89,
                    new Effect[]
                    {
                        new(Static.HpRate, .075m),
                        new(Static.SoulGateConsumptionReducedRate, .03m),
                        new(Static.ExpVolumeRateEnemy, .075m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("光速",
                    TitleField.First,
                    90,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 56.4m)
                    }),
                new("神速的",
                    TitleField.First,
                    91,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 61.1m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("遁地術",
                    TitleField.First,
                    92,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 65.8m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("疾速",
                    TitleField.First,
                    93,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 70.5m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.Evade, 107)
                    }),
                new("菁英",
                    TitleField.First,
                    94,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0405m),
                        new(Static.Accuracy, 42.3m),
                        new(Static.KillHpRecovery, 29.7m)
                    }),
                new("榮耀的",
                    TitleField.First,
                    95,
                    new Effect[]
                    {
                        new(Static.AttackRate, .045m),
                        new(Static.Accuracy, 47),
                        new(Static.KillHpRecovery, 33),
                        new(Static.CriticalDamage, 645)
                    }),
                new("第一",
                    TitleField.First,
                    96,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0495m),
                        new(Static.Accuracy, 51.7m),
                        new(Static.KillHpRecovery, 36.3m),
                        new(Static.CriticalDamage, 710)
                    }),
                new("神一般的",
                    TitleField.First,
                    97,
                    new Effect[]
                    {
                        new(Static.AttackRate, .054m),
                        new(Static.Accuracy, 56.4m),
                        new(Static.KillHpRecovery, 39.6m),
                        new(Static.CriticalDamage, 774),
                        new(Static.AttackSpeedRate, .05m)
                    }),
                new("雙槍",
                    TitleField.First,
                    98,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0585m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("絕對意志",
                    TitleField.First,
                    99,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .063m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .03m)
                    }),
                new("有點奇怪的",
                    TitleField.First,
                    100,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0675m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .03m)
                    }),
                new("故意的",
                    TitleField.First,
                    101,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .072m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .03m),
                        new(Static.CriticalResistanceRate, .05m)
                    }),
                new("遊樂園的",
                    TitleField.First,
                    102,
                    new Effect[] {new(Static.HpRate, .03m), new(Static.MoneyVolumeRateEnemy, .03m)}),
                new("富礦",
                    TitleField.First,
                    103,
                    new Effect[]
                    {
                        new(Static.HpRate, .0525m),
                        new(Static.MoneyVolumeRateEnemy, .0525m),
                        new(Static.SoulNovaVolumeRate, .03m)
                    }),
                new("身經百戰的",
                    TitleField.First,
                    104,
                    new Effect[]
                    {
                        new(Static.HpRate, .075m),
                        new(Static.MoneyVolumeRateEnemy, .075m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("掉落",
                    TitleField.First,
                    105,
                    new Effect[]
                    {
                        new(Static.HpRate, .09m),
                        new(Static.MoneyVolumeRateEnemy, .09m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("固執的",
                    TitleField.First,
                    106,
                    new Effect[] {new(Static.HpRate, .045m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("需要強化的",
                    TitleField.First,
                    107,
                    new Effect[] {new(Static.HpRate, .0525m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("圓形",
                    TitleField.First,
                    108,
                    new Effect[]
                    {
                        new(Static.HpRate, .06m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.SuperArmorBreakPowerRate, .025m)
                    }),
                new("乙太",
                    TitleField.First,
                    109,
                    new Effect[]
                    {
                        new(Static.HpRate, .0675m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.SuperArmorBreakPowerRate, .03m)
                    }),
                new("達到新境界的",
                    TitleField.First,
                    110,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0765m),
                        new(Static.HpRate, -.0675m),
                        new(Static.ExtraDamageRateSix, .05m),
                        new(Static.CriticalRate, .05m)
                    }),
                new("遊刃有餘的",
                    TitleField.First,
                    111,
                    new Effect[]
                    {
                        new(Static.AttackRate, .081m),
                        new(Static.HpRate, -.06m),
                        new(Static.ExtraDamageRateSix, .05m),
                        new(Static.CriticalRate, .05m)
                    }),
                new("老練的",
                    TitleField.First,
                    112,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0855m),
                        new(Static.HpRate, -.0525m),
                        new(Static.ExtraDamageRateSix, .05m),
                        new(Static.CriticalRate, .05m),
                        new(Static.ExtraDamageRateBoss, .05m)
                    }),
                new("如魚得水的",
                    TitleField.First,
                    113,
                    new Effect[]
                    {
                        new(Static.AttackRate, .09m),
                        new(Static.HpRate, -.045m),
                        new(Static.ExtraDamageRateSix, .05m),
                        new(Static.CriticalRate, .05m),
                        new(Static.ExtraDamageRateBoss, .05m)
                    }),
                new("做完熱身運動的", TitleField.First, 114, new Effect[] {new(Static.AttackSpeedRate, .02m)}),
                new("饑餓的", TitleField.First, 115, new Effect[] {new(Static.AttackSpeedRate, .025m)}),
                new("失眠的",
                    TitleField.First,
                    116,
                    new Effect[] {new(Static.AttackSpeedRate, .02m), new(Static.AttackRate, .0135m)}),
                new("時間",
                    TitleField.First,
                    117,
                    new Effect[] {new(Static.AttackSpeedRate, .025m), new(Static.AttackRate, .0135m)}),
                new("強化",
                    TitleField.First,
                    118,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.Evade, 32)}),
                new("黃金",
                    TitleField.First,
                    119,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.Evade, 43)}),
                new("下一步",
                    TitleField.First,
                    120,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.MoneyVolumeRateEnemy, .045m)}),
                new("這東西",
                    TitleField.First,
                    121,
                    new Effect[] {new(Static.AttackRate, .036m), new(Static.MoneyVolumeRateEnemy, .06m)}),
                new("強化變成了",
                    TitleField.First,
                    122,
                    new Effect[]
                    {
                        new(Static.AttackRate, .045m),
                        new(Static.MoneyVolumeRateEnemy, .075m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("傳說中的",
                    TitleField.First,
                    123,
                    new Effect[]
                    {
                        new(Static.AttackRate, .054m),
                        new(Static.MoneyVolumeRateEnemy, .09m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("製作",
                    TitleField.First,
                    124,
                    new Effect[] {new(Static.DefenseRate, .027m), new(Static.Evade, 32)}),
                new("黃金",
                    TitleField.First,
                    125,
                    new Effect[] {new(Static.DefenseRate, .036m), new(Static.Evade, 43)}),
                new("神秘的",
                    TitleField.First,
                    126,
                    new Effect[] {new(Static.HpRate, .0225m), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("無法",
                    TitleField.First,
                    127,
                    new Effect[] {new(Static.HpRate, .03m), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("分解是",
                    TitleField.First,
                    128,
                    new Effect[] {new(Static.HpRate, .0375m), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("庖丁",
                    TitleField.First,
                    129,
                    new Effect[] {new(Static.HpRate, .045m), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("徹底的",
                    TitleField.First,
                    130,
                    new Effect[]
                    {
                        new(Static.HpRate, .0525m),
                        new(Static.DefenseRate, .0315m),
                        new(Static.CriticalRate, .025m)
                    }),
                new("熟練的",
                    TitleField.First,
                    131,
                    new Effect[]
                    {
                        new(Static.HpRate, .0675m),
                        new(Static.DefenseRate, .0405m),
                        new(Static.CriticalRate, .025m)
                    }),
                new("金錢",
                    TitleField.First,
                    132,
                    new Effect[]
                    {
                        new(Static.HpRate, .0675m),
                        new(Static.DefenseRate, .0405m),
                        new(Static.CriticalRate, .03m)
                    }),
                new("購物",
                    TitleField.First,
                    133,
                    new Effect[]
                    {
                        new(Static.HpRate, .0825m),
                        new(Static.DefenseRate, .0495m),
                        new(Static.CriticalRate, .035m)
                    }),
                new("藏寶狸的",
                    TitleField.First,
                    134,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.MoneyVolumeRateEnemy, .09m)
                    }),
                new("兢兢業業",
                    TitleField.First,
                    135,
                    new Effect[] {new(Static.Stamina, 6), new(Static.Accuracy, 28.2m)}),
                new("隱藏", TitleField.First, 136, new Effect[] {new(Static.Stamina, 6), new(Static.Evade, 32)}),
                new("虛擬世界的",
                    TitleField.First,
                    137,
                    new Effect[]
                    {
                        new(Static.HpRate, .0975m),
                        new(Static.DefenseRate, .0585m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .03m)
                    }),
                new("花錢的",
                    TitleField.First,
                    138,
                    new Effect[] {new(Static.HpRate, .045m), new(Static.MoveSpaceRate, .05m)}),
                new("齋藤的", TitleField.First, 139, new Effect[] {new(Static.HpRate, .0375m)}),
                new("由美的", TitleField.First, 140, new Effect[] {new(Static.HpRate, .0375m)}),
                new("珍妮絲的", TitleField.First, 141, new Effect[] {new(Static.HpRate, .0375m)}),
                new("特麗莎的", TitleField.First, 142, new Effect[] {new(Static.HpRate, .0375m)}),
                new("阿珍的", TitleField.First, 143, new Effect[] {new(Static.HpRate, .0375m)}),
                new("扭曲幻境",
                    TitleField.First,
                    144,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.DefenseRate, .045m),
                        new(Static.SuperArmorBreakPowerRate, .03m)
                    }),
                new("金光幻境",
                    TitleField.First,
                    145,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.DefenseRate, .045m),
                        new(Static.SuperArmorBreakPowerRate, .03m),
                        new(Static.CriticalResistanceRate, .03m)
                    }),
                new("荒蕪幻境",
                    TitleField.First,
                    146,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.DefenseRate, .054m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalResistanceRate, .035m)
                    }),
                new("傀儡",
                    TitleField.First,
                    147,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.ExtraDamageRatePuppet, .035m)
                    }),
                new("紫色",
                    TitleField.First,
                    148,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.ExtraDamageRateJunk, .035m)
                    }),
                new("漆黑",
                    TitleField.First,
                    149,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.ExtraDamageRateFlame, .035m)
                    }),
                new("未完成的",
                    TitleField.First,
                    150,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.ExtraDamageRateIron, .035m)
                    }),
                new("金色",
                    TitleField.First,
                    151,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.ExtraDamageRateSix, .035m)
                    }),
                new("蹭吃蹭喝", TitleField.First, 152, new Effect[] {new(Static.DefenseRate, .0225m)}),
                new("萌發的",
                    TitleField.First,
                    153,
                    new Effect[] {new(Static.AttackRate, .0315m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("激蕩的",
                    TitleField.First,
                    154,
                    new Effect[] {new(Static.AttackRate, .036m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("成長的",
                    TitleField.First,
                    155,
                    new Effect[] {new(Static.AttackRate, .0405m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("盛放的",
                    TitleField.First,
                    156,
                    new Effect[] {new(Static.AttackRate, .045m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("新手",
                    TitleField.First,
                    157,
                    new Effect[] {new(Static.DefenseRate, .0315m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("自給",
                    TitleField.First,
                    158,
                    new Effect[] {new(Static.DefenseRate, .036m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("這是我的",
                    TitleField.First,
                    159,
                    new Effect[] {new(Static.DefenseRate, .0405m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("農民",
                    TitleField.First,
                    160,
                    new Effect[] {new(Static.DefenseRate, .045m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("黃金時間",
                    TitleField.First,
                    161,
                    new Effect[] {new(Static.AttackSpeedRate, .04m), new(Static.MoneyVolumeRateEnemy, .03m)}),
                new("肥料",
                    TitleField.First,
                    162,
                    new Effect[] {new(Static.AttackSpeedRate, .04m), new(Static.CooldownShorterRate, .02m)}),
                new("援助",
                    TitleField.First,
                    163,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .03m)}),
                new("在一起的",
                    TitleField.First,
                    164,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .0375m)}),
                new("善行的",
                    TitleField.First,
                    165,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .045m)}),
                new("上帝",
                    TitleField.First,
                    166,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .0525m)}),
                new("虛空",
                    TitleField.First,
                    167,
                    new Effect[] {new(Static.AttackSpeedRate, .05m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("第六區域的",
                    TitleField.First,
                    168,
                    new Effect[]
                    {
                        new(Static.AttackRate, .045m),
                        new(Static.ExtraDamageRateBoss, .03m),
                        new(Static.SuperArmorBreakPowerRate, .03m),
                        new(Static.CriticalResistanceRate, .02m)
                    }),
                new("災難的",
                    TitleField.First,
                    169,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.ExtraDamageRateBoss, .035m)
                    }),
                new("可怕的",
                    TitleField.First,
                    176,
                    new Effect[]
                    {
                        new(Static.AttackRate, .064m),
                        new(Static.ExtraDamageRateBasic, .05m),
                        new(Static.ExtraDamageRateBoss, .045m),
                        new(Static.Stamina, 9),
                        new(Static.CriticalDamage, 250)
                    }),
                new("全部的",
                    TitleField.First,
                    177,
                    new Effect[]
                    {
                        new(Static.Hp, 2500), new(Static.Evade, 80), new(Static.CooldownShorterRate, .02m)
                    }),
                new("史無前例",
                    TitleField.First,
                    178,
                    new Effect[]
                    {
                        new(Static.HpRate, .08m),
                        new(Static.CriticalRate, .03m),
                        new(Static.CriticalDamage, 750),
                        new(Static.AttackRate, -.05m)
                    }),
                new("世紀的",
                    TitleField.First,
                    179,
                    new Effect[]
                    {
                        new(Static.AttackRate, .06m),
                        new(Static.Accuracy, 60),
                        new(Static.Accuracy, 100),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("專家",
                    TitleField.First,
                    180,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .078m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .03m),
                        new(Static.Hp, 500)
                    }),
                new("天然",
                    TitleField.First,
                    181,
                    new Effect[] {new(Static.HpRate, .10m), new(Static.DefenseRate, .05m)}),
                new("到達",
                    TitleField.First,
                    182,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.SuperArmorBreakPowerRate, .03m),
                        new(Static.ExtraDamageRateBasic, .0425m),
                        new(Static.SoulNovaVolumeRate, .04m)
                    }),
                new("勇氣",
                    TitleField.First,
                    183,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .045m),
                        new(Static.Hp, 1500),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("永續的",
                    TitleField.First,
                    184,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .045m),
                        new(Static.Hp, 1500),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("搶先的",
                    TitleField.First,
                    185,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .045m),
                        new(Static.Hp, 1500),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("熱情的",
                    TitleField.First,
                    186,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .045m),
                        new(Static.Hp, 1500),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("非凡的",
                    TitleField.First,
                    187,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .045m),
                        new(Static.Hp, 1500),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("橫行",
                    TitleField.First,
                    188,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .045m),
                        new(Static.Hp, 1500),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("突變的",
                    TitleField.First,
                    188,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .045m),
                        new(Static.Hp, 1500),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("殘存的",
                    TitleField.First,
                    190,
                    new Effect[] {new(Static.Hp, 2200), new(Static.KillHpRecovery, 50)}),
                new("清高地 理想的",
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
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .04m),
                        new(Static.MoveSpaceRate, .06m),
                        new(Static.CooldownShorterRate, .04m),
                        new(Static.Evade, 150)
                    }),
                new("不敗的", TitleField.First, 250, new Effect[] {new(Static.DamageReductionRatePvP, .025m)}),
                new("虛空的",
                    TitleField.First,
                    265,
                    new Effect[]
                    {
                        new(Static.AttackRate, .05m),
                        new(Static.DefenseRate, .054m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalResistanceRate, .035m)
                    }),
                new("靈魂行者", TitleField.Last, 1, new Effect[] {new(Static.AttackRate, .0135m)}),
                new("安排", TitleField.Last, 1, new Effect[] {new(Static.AttackRate, .0135m)}),
                new("安排", TitleField.Last, 1, new Effect[] {new(Static.AttackRate, .0135m)}),
                new("化身", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("自我", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("安慰", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("斷念", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("安心", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("犧牲", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("犧牲", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("哀悼", TitleField.Last, 2, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("安息", TitleField.Last, 3, new Effect[] {new(Static.AttackRate, .018m)}),
                new("劍", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("子彈", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("鐮刀", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("拳", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("幻想", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("炮火", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("炮火", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("槍擊", TitleField.Last, 4, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("霸王",
                    TitleField.Last,
                    5,
                    new Effect[] {new(Static.AttackRate, .018m), new(Static.DefenseRate, -.0135m)}),
                new("降臨者",
                    TitleField.Last,
                    6,
                    new Effect[] {new(Static.DefenseRate, .018m), new(Static.AttackRate, -.0135m)}),
                new("緣分", TitleField.Last, 7, new Effect[] {new(Static.AttackRate, .0135m)}),
                new("彷徨的少女", TitleField.Last, 8, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("彷徨的少年", TitleField.Last, 8, new Effect[] {new(Static.DefenseRate, .0135m)}),
                new("高手",
                    TitleField.Last,
                    9,
                    new Effect[] {new(Static.HpRate, .0225m), new(Static.CooldownShorterRate, .02m)}),
                new("傷患",
                    TitleField.Last,
                    10,
                    new Effect[] {new(Static.HpRate, .0375m), new(Static.CooldownShorterRate, .02m)}),
                new("消費者",
                    TitleField.Last,
                    11,
                    new Effect[]
                    {
                        new(Static.HpRate, .0525m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.MoneyVolumeRateEnemy, .0525m)
                    }),
                new("先驅者", TitleField.Last, 12, new Effect[] {new(Static.Stamina, 5), new(Static.Evade, 21)}),
                new("常客", TitleField.Last, 13, new Effect[] {new(Static.Stamina, 6), new(Static.Evade, 27)}),
                new("VIP", TitleField.Last, 14, new Effect[] {new(Static.Stamina, 6), new(Static.Evade, 32)}),
                new("VVIP",
                    TitleField.Last,
                    15,
                    new Effect[]
                    {
                        new(Static.Stamina, 7), new(Static.Evade, 37), new(Static.DamageReductionRate, .02m)
                    }),
                new("武器主人",
                    TitleField.Last,
                    16,
                    new Effect[] {new(Static.DefenseRate, .0225m), new(Static.MoneyVolumeRateEnemy, .0375m)}),
                new("收藏家",
                    TitleField.Last,
                    17,
                    new Effect[] {new(Static.DefenseRate, .027m), new(Static.MoneyVolumeRateEnemy, .045m)}),
                new("金主",
                    TitleField.Last,
                    18,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0315m),
                        new(Static.MoneyVolumeRateEnemy, .0525m),
                        new(Static.ExpVolumeRateEnemy, .0525m)
                    }),
                new("失敗者",
                    TitleField.Last,
                    19,
                    new Effect[]
                    {
                        new(Static.HpRate, .0975m),
                        new(Static.AttackRate, -.0225m),
                        new(Static.KillHpRecovery, 42.9m)
                    }),
                new("露宿者",
                    TitleField.Last,
                    20,
                    new Effect[]
                    {
                        new(Static.HpRate, .105m),
                        new(Static.AttackRate, -.0225m),
                        new(Static.KillHpRecovery, 46.2m)
                    }),
                new("屍體",
                    TitleField.Last,
                    21,
                    new Effect[]
                    {
                        new(Static.HpRate, .1125m),
                        new(Static.AttackRate, -.0225m),
                        new(Static.KillHpRecovery, 49.5m),
                        new(Static.Stamina, 11)
                    }),
                new("不死之身",
                    TitleField.Last,
                    22,
                    new Effect[]
                    {
                        new(Static.HpRate, .12m),
                        new(Static.AttackRate, -.0225m),
                        new(Static.KillHpRecovery, 52.8m),
                        new(Static.Stamina, 11),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("清掃者",
                    TitleField.Last,
                    23,
                    new Effect[] {new(Static.DefenseRate, .036m), new(Static.DamageReductionRateBasic, .025m)}),
                new("消滅者",
                    TitleField.Last,
                    24,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0405m),
                        new(Static.DamageReductionRateBasic, .03m),
                        new(Static.DamageReductionRateBoss, .03m)
                    }),
                new("殲滅者",
                    TitleField.Last,
                    25,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .045m),
                        new(Static.DamageReductionRateBasic, .03m),
                        new(Static.DamageReductionRateBoss, .03m),
                        new(Static.ExpVolumeRateEnemy, .075m)
                    }),
                new("怪物",
                    TitleField.Last,
                    26,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .054m),
                        new(Static.DamageReductionRateBasic, .035m),
                        new(Static.DamageReductionRateBoss, .035m),
                        new(Static.ExpVolumeRateEnemy, .09m),
                        new(Static.Evade, 64)
                    }),
                new("實力角",
                    TitleField.Last,
                    27,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.Evade, 21)}),
                new("受益者",
                    TitleField.Last,
                    28,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.Evade, 27)}),
                new("鬥士",
                    TitleField.Last,
                    29,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.Evade, 32)}),
                new("獵人",
                    TitleField.Last,
                    30,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.Evade, 37),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("小市民",
                    TitleField.Last,
                    31,
                    new Effect[] {new(Static.DefenseRate, .018m), new(Static.DamageReductionRateBasic, .015m)}),
                new("市民",
                    TitleField.Last,
                    32,
                    new Effect[] {new(Static.DefenseRate, .0225m), new(Static.DamageReductionRateBasic, .02m)}),
                new("挑釁者",
                    TitleField.Last,
                    33,
                    new Effect[] {new(Static.DefenseRate, .027m), new(Static.DamageReductionRateBasic, .02m)}),
                new("處理者",
                    TitleField.Last,
                    34,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0315m),
                        new(Static.DamageReductionRateBasic, .025m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("安慰",
                    TitleField.Last,
                    35,
                    new Effect[] {new(Static.DefenseRate, .018m), new(Static.CriticalResistanceRate, .015m)}),
                new("強者",
                    TitleField.Last,
                    36,
                    new Effect[] {new(Static.DefenseRate, .0225m), new(Static.CriticalResistanceRate, .02m)}),
                new("獵手",
                    TitleField.Last,
                    37,
                    new Effect[] {new(Static.DefenseRate, .027m), new(Static.CriticalResistanceRate, .02m)}),
                new("追擊者",
                    TitleField.Last,
                    38,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0315m),
                        new(Static.CriticalResistanceRate, .025m),
                        new(Static.Evade, 37)
                    }),
                new("二號角色",
                    TitleField.Last,
                    39,
                    new Effect[] {new(Static.AttackRate, .018m), new(Static.CriticalDamage, 258)}),
                new("挑戰者",
                    TitleField.Last,
                    40,
                    new Effect[] {new(Static.AttackRate, .0225m), new(Static.CriticalDamage, 323)}),
                new("覬覦者",
                    TitleField.Last,
                    41,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.CriticalDamage, 387)}),
                new("殺手",
                    TitleField.Last,
                    42,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0315m),
                        new(Static.CriticalDamage, 452),
                        new(Static.DamageReductionRate, .02m)
                    }),
                new("追蹤者",
                    TitleField.Last,
                    43,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0315m),
                        new(Static.DamageReductionRateBoss, .025m),
                        new(Static.SuperArmorBreakPowerRate, .025m)
                    }),
                new("威脅者",
                    TitleField.Last,
                    44,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0405m),
                        new(Static.DamageReductionRateBoss, .03m),
                        new(Static.SuperArmorBreakPowerRate, .03m)
                    }),
                new("追蹤者",
                    TitleField.Last,
                    45,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0495m),
                        new(Static.DamageReductionRateBoss, .035m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalRate, .035m)
                    }),
                new("屠殺者",
                    TitleField.Last,
                    46,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .054m),
                        new(Static.DamageReductionRateBoss, .035m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalRate, .035m),
                        new(Static.CriticalDamage, 774)
                    }),
                new("參加者",
                    TitleField.Last,
                    47,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0675m),
                        new(Static.AttackSpeedRate, -.03m),
                        new(Static.CriticalDamage, 968),
                        new(Static.SuperArmorBreakPowerRate, .045m)
                    }),
                new("將軍",
                    TitleField.Last,
                    48,
                    new Effect[]
                    {
                        new(Static.AttackRate, .072m),
                        new(Static.AttackSpeedRate, -.03m),
                        new(Static.CriticalDamage, 1032),
                        new(Static.SuperArmorBreakPowerRate, .045m)
                    }),
                new("榮耀",
                    TitleField.Last,
                    49,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0765m),
                        new(Static.AttackSpeedRate, -.03m),
                        new(Static.CriticalDamage, 1097),
                        new(Static.SuperArmorBreakPowerRate, .05m)
                    }),
                new("會長",
                    TitleField.Last,
                    50,
                    new Effect[]
                    {
                        new(Static.AttackRate, .081m),
                        new(Static.AttackSpeedRate, -.025m),
                        new(Static.CriticalDamage, 1161),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.CriticalRate, .045m)
                    }),
                new("逃避者",
                    TitleField.Last,
                    51,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRatePrimal, .01m)}),
                new("紮破者",
                    TitleField.Last,
                    52,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRatePrimal, .015m)}),
                new("透視者",
                    TitleField.Last,
                    53,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRatePrimal, .02m)}),
                new("毀滅者",
                    TitleField.Last,
                    54,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRatePrimal, .025m)}),
                new("洗澡",
                    TitleField.Last,
                    55,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateJunk, .01m)}),
                new("感覺",
                    TitleField.Last,
                    56,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateJunk, .015m)}),
                new("居民",
                    TitleField.Last,
                    57,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateJunk, .02m)}),
                new("清道夫",
                    TitleField.Last,
                    58,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateJunk, .025m)}),
                new("信任",
                    TitleField.Last,
                    59,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateNED, .01m)}),
                new("憤怒",
                    TitleField.Last,
                    60,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateNED, .015m)}),
                new("復仇者",
                    TitleField.Last,
                    61,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateNED, .02m)}),
                new("復仇者",
                    TitleField.Last,
                    62,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.DamageReductionRateNED, .025m),
                        new(Static.DamageReductionRateFlame, .025m)
                    }),
                new("消防員",
                    TitleField.Last,
                    63,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateFlame, .01m)}),
                new("追逐者",
                    TitleField.Last,
                    64,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateFlame, .015m)}),
                new("教練",
                    TitleField.Last,
                    65,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateFlame, .02m)}),
                new("戰士",
                    TitleField.Last,
                    66,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.DamageReductionRateFlame, .025m),
                        new(Static.DamageReductionRateNED, .025m)
                    }),
                new("破壞犯",
                    TitleField.Last,
                    67,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateIron, .01m)}),
                new("破壞狂",
                    TitleField.Last,
                    68,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateIron, .015m)}),
                new("摧毀者",
                    TitleField.Last,
                    69,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DamageReductionRateIron, .02m)}),
                new("工程師",
                    TitleField.Last,
                    70,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.DamageReductionRateIron, .025m),
                        new(Static.DamageReductionRateSoul, .025m)
                    }),
                new("歡喜冤家",
                    TitleField.Last,
                    71,
                    new Effect[]
                    {
                        new(Static.Stamina, 11),
                        new(Static.DefenseRate, -.027m),
                        new(Static.DamageReductionRateSoul, .045m)
                    }),
                new("友誼",
                    TitleField.Last,
                    72,
                    new Effect[]
                    {
                        new(Static.Stamina, 11),
                        new(Static.DefenseRate, -.0225m),
                        new(Static.DamageReductionRateSoul, .045m),
                        new(Static.Evade, 86)
                    }),
                new("朋友關係",
                    TitleField.Last,
                    73,
                    new Effect[]
                    {
                        new(Static.Stamina, 12),
                        new(Static.DefenseRate, -.018m),
                        new(Static.DamageReductionRateSoul, .05m),
                        new(Static.Evade, 91)
                    }),
                new("朋友",
                    TitleField.Last,
                    74,
                    new Effect[]
                    {
                        new(Static.Stamina, 12),
                        new(Static.DefenseRate, -.018m),
                        new(Static.DamageReductionRateSoul, .05m),
                        new(Static.Evade, 91),
                        new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("嗜好者",
                    TitleField.Last,
                    75,
                    new Effect[] {new(Static.Stamina, 4), new(Static.SuperArmorBreakPowerRate, .01m)}),
                new("破碎者",
                    TitleField.Last,
                    76,
                    new Effect[] {new(Static.Stamina, 4), new(Static.SuperArmorBreakPowerRate, .015m)}),
                new("破壞者",
                    TitleField.Last,
                    77,
                    new Effect[] {new(Static.Stamina, 5), new(Static.SuperArmorBreakPowerRate, .01m)}),
                new("破甲",
                    TitleField.Last,
                    78,
                    new Effect[] {new(Static.Stamina, 5), new(Static.SuperArmorBreakPowerRate, .015m)}),
                new("忍受者",
                    TitleField.Last,
                    79,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .02m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("連擊",
                    TitleField.Last,
                    80,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .025m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("777!",
                    TitleField.Last,
                    81,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .03m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("連擊之王",
                    TitleField.Last,
                    82,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .035m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("冤大頭",
                    TitleField.Last,
                    83,
                    new Effect[] {new(Static.Stamina, 5), new(Static.CooldownShorterRate, .02m)}),
                new("誘惑",
                    TitleField.Last,
                    84,
                    new Effect[] {new(Static.Stamina, 6), new(Static.CooldownShorterRate, .02m)}),
                new("傭兵王",
                    TitleField.Last,
                    85,
                    new Effect[]
                    {
                        new(Static.Stamina, 7),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("全知全能",
                    TitleField.Last,
                    86,
                    new Effect[]
                    {
                        new(Static.Stamina, 8),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.Accuracy, 47)
                    }),
                new("徘徊之人",
                    TitleField.Last,
                    87,
                    new Effect[] {new(Static.Stamina, 5), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("探險家",
                    TitleField.Last,
                    88,
                    new Effect[]
                    {
                        new(Static.Stamina, 7),
                        new(Static.SoulGateConsumptionReducedRate, .03m),
                        new(Static.ExpVolumeRateEnemy, .0525m)
                    }),
                new("探險家",
                    TitleField.Last,
                    89,
                    new Effect[]
                    {
                        new(Static.Stamina, 8),
                        new(Static.SoulGateConsumptionReducedRate, .03m),
                        new(Static.ExpVolumeRateEnemy, .075m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("行進者",
                    TitleField.Last,
                    90,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 65.8m)
                    }),
                new("賽跑選手",
                    TitleField.Last,
                    91,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 70.5m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("修煉者",
                    TitleField.Last,
                    92,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 79.9m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("騎手",
                    TitleField.Last,
                    93,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.AttackRate, -.0135m),
                        new(Static.Accuracy, 79.9m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.Evade, 70)
                    }),
                new("排名入圍者",
                    TitleField.Last,
                    94,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0405m),
                        new(Static.Accuracy, 42.3m),
                        new(Static.KillHpRecovery, 29.7m)
                    }),
                new("記錄",
                    TitleField.Last,
                    95,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .045m),
                        new(Static.Accuracy, 47),
                        new(Static.KillHpRecovery, 33),
                        new(Static.CriticalDamage, 645)
                    }),
                new("階層",
                    TitleField.Last,
                    96,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0495m),
                        new(Static.Accuracy, 51.7m),
                        new(Static.KillHpRecovery, 36.3m),
                        new(Static.CriticalDamage, 710)
                    }),
                new("操作",
                    TitleField.Last,
                    97,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0495m),
                        new(Static.Accuracy, 51.7m),
                        new(Static.KillHpRecovery, 36.3m),
                        new(Static.CriticalDamage, 710),
                        new(Static.AttackSpeedRate, .05m)
                    }),
                new("適合者",
                    TitleField.Last,
                    98,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0675m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("擁有者",
                    TitleField.Last,
                    99,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .072m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .04m)
                    }),
                new("榮譽",
                    TitleField.Last,
                    100,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0765m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .04m)
                    }),
                new("失敗者",
                    TitleField.Last,
                    101,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0765m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .04m),
                        new(Static.CriticalResistanceRate, .04m)
                    }),
                new("挖掘機",
                    TitleField.Last,
                    102,
                    new Effect[] {new(Static.Stamina, 6), new(Static.MoneyVolumeRateEnemy, .0375m)}),
                new("開拓者",
                    TitleField.Last,
                    103,
                    new Effect[]
                    {
                        new(Static.Stamina, 7),
                        new(Static.MoneyVolumeRateEnemy, .0525m),
                        new(Static.SoulNovaVolumeRate, .03m)
                    }),
                new("守財奴",
                    TitleField.Last,
                    104,
                    new Effect[]
                    {
                        new(Static.Stamina, 8),
                        new(Static.MoneyVolumeRateEnemy, .075m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DefenseBreakRate, .02m)
                    }),
                new("大富翁",
                    TitleField.Last,
                    105,
                    new Effect[]
                    {
                        new(Static.Stamina, 9),
                        new(Static.MoneyVolumeRateEnemy, .09m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("冒險家",
                    TitleField.Last,
                    106,
                    new Effect[] {new(Static.Stamina, 4), new(Static.SoulNovaVolumeRate, .03m)}),
                new("收藏",
                    TitleField.Last,
                    107,
                    new Effect[] {new(Static.Stamina, 5), new(Static.SoulNovaVolumeRate, .03m)}),
                new("愛好者",
                    TitleField.Last,
                    108,
                    new Effect[]
                    {
                        new(Static.Stamina, 7),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.SuperArmorBreakPowerRate, .025m)
                    }),
                new("收集者",
                    TitleField.Last,
                    109,
                    new Effect[]
                    {
                        new(Static.Stamina, 8),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.SuperArmorBreakPowerRate, .03m)
                    }),
                new("戰鬥",
                    TitleField.Last,
                    110,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0765m),
                        new(Static.HpRate, -.0675m),
                        new(Static.DamageReductionRateSix, .05m),
                        new(Static.CriticalRate, .05m)
                    }),
                new("修煉者",
                    TitleField.Last,
                    111,
                    new Effect[]
                    {
                        new(Static.AttackRate, .081m),
                        new(Static.HpRate, -.06m),
                        new(Static.DamageReductionRateSix, .05m),
                        new(Static.CriticalRate, .05m)
                    }),
                new("戰鬥高手",
                    TitleField.Last,
                    112,
                    new Effect[]
                    {
                        new(Static.AttackRate, .081m),
                        new(Static.HpRate, -.0525m),
                        new(Static.DamageReductionRateSix, .05m),
                        new(Static.CriticalRate, .05m),
                        new(Static.DamageReductionRateBoss, .04m)
                    }),
                new("戰鬥",
                    TitleField.Last,
                    113,
                    new Effect[]
                    {
                        new(Static.AttackRate, .0855m),
                        new(Static.HpRate, -.045m),
                        new(Static.DamageReductionRateSix, .05m),
                        new(Static.CriticalRate, .05m),
                        new(Static.DamageReductionRateBoss, .045m)
                    }),
                new("流浪者", TitleField.Last, 114, new Effect[] {new(Static.MoveSpaceRate, .03m)}),
                new("聊天者", TitleField.Last, 115, new Effect[] {new(Static.MoveSpaceRate, .05m)}),
                new("吟游詩人",
                    TitleField.Last,
                    116,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DefenseRate, .0045m)}),
                new("記錄者",
                    TitleField.Last,
                    117,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.DefenseRate, .009m)}),
                new("迷信者",
                    TitleField.Last,
                    118,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.Evade, 32)}),
                new("駭客",
                    TitleField.Last,
                    119,
                    new Effect[] {new(Static.AttackRate, .036m), new(Static.Evade, 43)}),
                new("機會",
                    TitleField.Last,
                    120,
                    new Effect[] {new(Static.AttackRate, .027m), new(Static.MoneyVolumeRateEnemy, .045m)}),
                new("白費力氣",
                    TitleField.Last,
                    121,
                    new Effect[] {new(Static.AttackRate, .036m), new(Static.MoneyVolumeRateEnemy, .06m)}),
                new("弱化",
                    TitleField.Last,
                    122,
                    new Effect[]
                    {
                        new(Static.AttackRate, .045m),
                        new(Static.MoneyVolumeRateEnemy, .075m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("破壞大師",
                    TitleField.Last,
                    123,
                    new Effect[]
                    {
                        new(Static.AttackRate, .054m),
                        new(Static.MoneyVolumeRateEnemy, .09m),
                        new(Static.CooldownShorterRate, .02m)
                    }),
                new("後援者",
                    TitleField.Last,
                    124,
                    new Effect[] {new(Static.DefenseRate, .027m), new(Static.Evade, 32)}),
                new("煉金術士",
                    TitleField.Last,
                    125,
                    new Effect[] {new(Static.DefenseRate, .036m), new(Static.Evade, 43)}),
                new("分解",
                    TitleField.Last,
                    126,
                    new Effect[] {new(Static.Stamina, 4), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("復原",
                    TitleField.Last,
                    127,
                    new Effect[] {new(Static.Stamina, 5), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("力量",
                    TitleField.Last,
                    128,
                    new Effect[] {new(Static.Stamina, 6), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("手部",
                    TitleField.Last,
                    129,
                    new Effect[] {new(Static.Stamina, 7), new(Static.SoulGateConsumptionReducedRate, .03m)}),
                new("價格比較",
                    TitleField.Last,
                    130,
                    new Effect[]
                    {
                        new(Static.HpRate, .0525m),
                        new(Static.DefenseRate, .0315m),
                        new(Static.CriticalRate, .025m)
                    }),
                new("交易者",
                    TitleField.Last,
                    131,
                    new Effect[]
                    {
                        new(Static.HpRate, .0675m),
                        new(Static.DefenseRate, .0405m),
                        new(Static.CriticalRate, .025m)
                    }),
                new("流動",
                    TitleField.Last,
                    132,
                    new Effect[]
                    {
                        new(Static.HpRate, .0675m),
                        new(Static.DefenseRate, .0405m),
                        new(Static.CriticalRate, .03m)
                    }),
                new("之王",
                    TitleField.Last,
                    133,
                    new Effect[]
                    {
                        new(Static.HpRate, .0825m),
                        new(Static.DefenseRate, .0495m),
                        new(Static.CriticalRate, .035m)
                    }),
                new("天敵",
                    TitleField.Last,
                    134,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.ExpVolumeRateEnemy, .09m)
                    }),
                new("工作者",
                    TitleField.Last,
                    135,
                    new Effect[] {new(Static.Stamina, 6), new(Static.Accuracy, 28.2m)}),
                new("極限", TitleField.Last, 136, new Effect[] {new(Static.Stamina, 6), new(Static.Evade, 32)}),
                new("訓練者",
                    TitleField.Last,
                    137,
                    new Effect[]
                    {
                        new(Static.HpRate, .0975m),
                        new(Static.DefenseRate, .0585m),
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.DamageReductionRate, .03m)
                    }),
                new("滋味",
                    TitleField.Last,
                    138,
                    new Effect[] {new(Static.HpRate, .045m), new(Static.MoveSpaceRate, .05m)}),
                new("老顧客", TitleField.Last, 139, new Effect[] {new(Static.HpRate, .0375m)}),
                new("貴客", TitleField.Last, 140, new Effect[] {new(Static.HpRate, .0375m)}),
                new("開心果", TitleField.Last, 141, new Effect[] {new(Static.HpRate, .0375m)}),
                new("暴徒朋友", TitleField.Last, 142, new Effect[] {new(Static.HpRate, .0375m)}),
                new("超級貴賓", TitleField.Last, 143, new Effect[] {new(Static.HpRate, .0375m)}),
                new("驅動者",
                    TitleField.Last,
                    144,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.DefenseRate, .045m),
                        new(Static.SuperArmorBreakPowerRate, .03m)
                    }),
                new("反抗者",
                    TitleField.Last,
                    145,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.DefenseRate, .045m),
                        new(Static.SuperArmorBreakPowerRate, .03m),
                        new(Static.CriticalResistanceRate, .03m)
                    }),
                new("征服者",
                    TitleField.Last,
                    146,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .05m),
                        new(Static.DefenseRate, .054m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalResistanceRate, .035m)
                    }),
                new("指揮官",
                    TitleField.Last,
                    147,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DamageReductionRatePrimal, .035m)
                    }),
                new("蜘蛛女王",
                    TitleField.Last,
                    148,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DamageReductionRateJunk, .035m)
                    }),
                new("影子",
                    TitleField.Last,
                    149,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DamageReductionRateFlame, .035m)
                    }),
                new("敵人",
                    TitleField.Last,
                    150,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DamageReductionRateIron, .035m)
                    }),
                new("異形",
                    TitleField.Last,
                    151,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DamageReductionRateSix, .035m)
                    }),
                new("大王", TitleField.Last, 152, new Effect[] {new(Static.AttackRate, .0225m)}),
                new("生命",
                    TitleField.Last,
                    153,
                    new Effect[] {new(Static.AttackRate, .0315m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("誕生",
                    TitleField.Last,
                    154,
                    new Effect[] {new(Static.AttackRate, .036m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("樂趣",
                    TitleField.Last,
                    155,
                    new Effect[] {new(Static.AttackRate, .0405m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("喜悅",
                    TitleField.Last,
                    156,
                    new Effect[] {new(Static.AttackRate, .045m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("農夫",
                    TitleField.Last,
                    157,
                    new Effect[] {new(Static.DefenseRate, .0315m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("自足",
                    TitleField.Last,
                    158,
                    new Effect[] {new(Static.DefenseRate, .036m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("天職",
                    TitleField.Last,
                    159,
                    new Effect[] {new(Static.DefenseRate, .0405m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("企業家",
                    TitleField.Last,
                    160,
                    new Effect[] {new(Static.DefenseRate, .045m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("園藝師",
                    TitleField.Last,
                    161,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .04m), new(Static.SoulGateConsumptionReducedRate, .03m)
                    }),
                new("生產者",
                    TitleField.Last,
                    162,
                    new Effect[] {new(Static.AttackSpeedRate, .04m), new(Static.CooldownShorterRate, .02m)}),
                new("之手",
                    TitleField.Last,
                    163,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .03m)}),
                new("幸福",
                    TitleField.Last,
                    164,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .0375m)}),
                new("美德",
                    TitleField.Last,
                    165,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .045m)}),
                new("使者",
                    TitleField.Last,
                    166,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.MoneyVolumeRateEnemy, .0525m)}),
                new("切斷者",
                    TitleField.Last,
                    167,
                    new Effect[] {new(Static.MoveSpaceRate, .05m), new(Static.SoulNovaVolumeRate, .03m)}),
                new("解放者",
                    TitleField.Last,
                    168,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .0495m),
                        new(Static.DamageReductionRateBoss, .035m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalRate, .035m)
                    }),
                new("驅逐者",
                    TitleField.Last,
                    169,
                    new Effect[]
                    {
                        new(Static.MoveSpaceRate, .05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DamageReductionRateBoss, .035m)
                    }),
                new("魔王",
                    TitleField.Last,
                    176,
                    new Effect[]
                    {
                        new(Static.CriticalDamage, 550),
                        new(Static.ExtraDamageRateBoss, .045m),
                        new(Static.AttackSpeedRate, .035m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.CooldownShorterRate, -.03m)
                    }),
                new("尊敬",
                    TitleField.Last,
                    177,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .06m),
                        new(Static.DamageReductionRateBoss, .035m),
                        new(Static.SuperArmorBreakPowerRate, .03m)
                    }),
                new("大將",
                    TitleField.Last,
                    178,
                    new Effect[]
                    {
                        new(Static.DamageReductionRatePartialDamage, .05m),
                        new(Static.SoulGateConsumptionReducedRate, .03m),
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
                    new Effect[]
                    {
                        new(Static.DefenseRate, .08m),
                        new(Static.MoveSpaceRate, -.05m),
                        new(Static.SoulNovaVolumeRate, .03m),
                        new(Static.DamageReductionRate, .03m),
                        new(Static.CriticalRate, -.01m)
                    }),
                new("紀念物",
                    TitleField.Last,
                    181,
                    new Effect[]
                    {
                        new(Static.Stamina, 7.2m),
                        new(Static.Hp, 550),
                        new(Static.SuperArmorBreakPowerRate, .025m),
                        new(Static.CriticalRate, .02m)
                    }),
                new("真實",
                    TitleField.Last,
                    182,
                    new Effect[]
                    {
                        new(Static.AttackSpeedRate, .04m),
                        new(Static.SoulNovaVolumeRate, .035m),
                        new(Static.ExtraDamageRateJunk, .025m),
                        new(Static.ExtraDamageRateBasic, .03m)
                    }),
                new("刀刃",
                    TitleField.Last,
                    183,
                    new Effect[]
                    {
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.HpRate, .0375m),
                        new(Static.DefenseRate, -.03m)
                    }),
                new("炮彈",
                    TitleField.Last,
                    184,
                    new Effect[]
                    {
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.HpRate, .0375m),
                        new(Static.DefenseRate, -.03m)
                    }),
                new("鎖鏈",
                    TitleField.Last,
                    185,
                    new Effect[]
                    {
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.HpRate, .0375m),
                        new(Static.DefenseRate, -.03m)
                    }),
                new("護盾",
                    TitleField.Last,
                    186,
                    new Effect[]
                    {
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.HpRate, .0375m),
                        new(Static.DefenseRate, -.03m)
                    }),
                new("鬥魂",
                    TitleField.Last,
                    187,
                    new Effect[]
                    {
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.HpRate, .0375m),
                        new(Static.DefenseRate, -.03m)
                    }),
                new("兵器",
                    TitleField.Last,
                    188,
                    new Effect[]
                    {
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.HpRate, .0375m),
                        new(Static.DefenseRate, -.03m)
                    }),
                new("光槍",
                    TitleField.Last,
                    188,
                    new Effect[]
                    {
                        new(Static.DefenseBreakRate, .02m),
                        new(Static.CooldownShorterRate, .02m),
                        new(Static.SuperArmorBreakPowerRate, .05m),
                        new(Static.HpRate, .0375m),
                        new(Static.DefenseRate, -.03m)
                    }),
                new("傷痕",
                    TitleField.Last,
                    190,
                    new Effect[]
                    {
                        new(Static.DefenseRate, .04m),
                        new(Static.DamageReductionRateBasic, .05m),
                        new(Static.DamageReductionRateBoss, .05m)
                    }),
                new("白色騎士",
                    TitleField.Last,
                    206,
                    new Effect[]
                    {
                        new(Static.CooldownShorterRate, .03m),
                        new(Static.SoulGateConsumptionReducedRate, .045m),
                        new(Static.HpRate, .10m),
                        new(Static.DamageReductionRateBoss, .05m)
                    }),
                new("渴望者行者",
                    TitleField.Last,
                    247,
                    new Effect[]
                    {
                        new(Static.CriticalRate, .02m),
                        new(Static.CriticalDamage, 500),
                        new(Static.Stamina, 5),
                        new(Static.MoveSpaceRate, .03m)
                    }),
                new("作戰執行者", TitleField.Last, 250, new Effect[] {new(Static.DamageReductionRatePvP, .025m)}),
                new("怪物",
                    TitleField.Last,
                    265,
                    new Effect[]
                    {
                        new(Static.AttackRate, .05m),
                        new(Static.DefenseRate, .054m),
                        new(Static.SuperArmorBreakPowerRate, .035m),
                        new(Static.CriticalResistanceRate, .035m)
                    })
            };

            return Result[field] = _titles.Where(x => x.Field == field).ToList();
        }
    }
}