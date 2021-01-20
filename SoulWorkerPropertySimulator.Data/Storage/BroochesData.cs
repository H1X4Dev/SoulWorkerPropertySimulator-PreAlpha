using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class BroochesData
    {
        private static          IReadOnlyCollection<Brooches>?                           _brooches;
        private static readonly Dictionary<BroochesClass, IReadOnlyCollection<Brooches>> _result = new();

        internal static IReadOnlyCollection<Brooches> Get(BroochesSeries series, BroochesType type)
        {
            var classify = new BroochesClass(series, type);
            if (_result.ContainsKey(classify)) { return _result[classify]; }

            if (_brooches != null)
            {
                return _result[classify] = _brooches.Where(x => x.Series == series && x.Type == type).ToList();
            }

            var accuracyOAvoidP3D5     = new EffectContext(Property.Accuracy, Opportunity.Avoid, .3m, 5);
            var accuracyOSufferP3D5    = new EffectContext(Property.Accuracy, Opportunity.Suffer, .3m, 5);
            var accuracyOUseSkillP1D5  = new EffectContext(Property.Accuracy, Opportunity.UseSkill, .1m, 5);
            var attackOAvoidP3D5       = new EffectContext(Property.Attack, Opportunity.Avoid, .3m, 5);
            var attackOCriticalHitP1D5 = new EffectContext(Property.Attack, Opportunity.CriticalHit, .1m, 5);
            var attackOHitP1D5         = new EffectContext(Property.Attack, Opportunity.Hit, .1m, 5);
            var attackOKillD5          = new EffectContext(Property.Attack, Opportunity.Kill, duration: 5);
            var attackORunP3D5         = new EffectContext(Property.Attack, Opportunity.Run, .3m, 5);
            var attackOSufferP3D5      = new EffectContext(Property.Attack, Opportunity.Suffer, .3m, 5);
            var attackOUseItemP2D5     = new EffectContext(Property.Attack, Opportunity.UseItem, .2m, 5);
            var attackOUseSkillP1D5    = new EffectContext(Property.Attack, Opportunity.UseSkill, .1m, 5);
            var attackRateOAvoid       = new EffectContext(Property.AttackRate, Opportunity.Avoid);
            var attackRateOHitP1D5     = new EffectContext(Property.AttackRate, Opportunity.Hit, .1m, 5);
            var attackRateOHitP3D3     = new EffectContext(Property.AttackRate, Opportunity.Hit, .3m, 3);
            var attackSpeedRateOAvoid  = new EffectContext(Property.AttackRateNext, Opportunity.Avoid);
            var attackSpeedRateOCriticalHitP1D2 =
                new EffectContext(Property.AttackSpeedRate, Opportunity.CriticalHit, .1m, 2);
            var attackSpeedRateOSufferP3 = new EffectContext(Property.AttackSpeedRate, Opportunity.Suffer, .3m);
            var attackSpeedRateOSufferP3D1_5m =
                new EffectContext(Property.AttackSpeedRate, Opportunity.Suffer, .3m, 1.5m);
            var attackSpeedRateOSufferCriticalP5D2 =
                new EffectContext(Property.AttackSpeedRate, Opportunity.SufferCritical, .5m, 2);
            var cooldownShorterRateOUseSkillP2 =
                new EffectContext(Property.CooldownShorterRate, Opportunity.UseSkill, .2m);
            var criticalDamageOAvoidP3D5 = new EffectContext(Property.CriticalDamage, Opportunity.Avoid, .3m, 5);
            var criticalDamageOCriticalD3 =
                new EffectContext(Property.CriticalDamage, Opportunity.Critical, duration: 3);
            var criticalDamageOCriticalHitP1D2 =
                new EffectContext(Property.CriticalDamage, Opportunity.CriticalHit, .1m, 2);
            var criticalDamageOHP30DownThenHitD3 =
                new EffectContext(Property.CriticalDamage, Opportunity.HP30DownThenHit, duration: 3);
            var criticalDamageORunP2D3    = new EffectContext(Property.CriticalDamage, Opportunity.Run, .2m, 3);
            var criticalDamageOSufferP3D5 = new EffectContext(Property.CriticalDamage, Opportunity.Suffer, .3m, 5);
            var criticalDamageOSufferP5D3 = new EffectContext(Property.CriticalDamage, Opportunity.Suffer, .5m, 3);
            var criticalDamageOSufferCriticalP5D2 =
                new EffectContext(Property.CriticalDamage, Opportunity.SufferCritical, .5m, 2);
            var criticalDamageOSufferStamina50UpD5 =
                new EffectContext(Property.CriticalDamage, Opportunity.SufferStamina50Up, duration: 5);
            var criticalDamageOUseAvoidP1D5 = new EffectContext(Property.CriticalDamage, Opportunity.UseAvoid, .1m, 5);
            var criticalDamageOUseItemP2D5  = new EffectContext(Property.CriticalDamage, Opportunity.UseItem, .2m, 5);
            var criticalDamageOUseSkillP3D5 = new EffectContext(Property.CriticalDamage, Opportunity.UseSkill, .3m, 5);
            var criticalDamageOUseSkillP5D5 = new EffectContext(Property.CriticalDamage, Opportunity.UseSkill, .5m, 5);
            var criticalRateOAvoidP3D2      = new EffectContext(Property.CriticalRate, Opportunity.Avoid, .3m, 2);
            var criticalRateORunP3D5        = new EffectContext(Property.CriticalRate, Opportunity.Run, .3m, 5);
            var criticalRateOUseAvoidP1D5   = new EffectContext(Property.CriticalRate, Opportunity.UseAvoid, .1m, 5);
            var criticalRateOUseSkillP5D5   = new EffectContext(Property.CriticalRate, Opportunity.UseSkill, .5m, 5);
            var criticalResistanceRateOHP50DownD10 =
                new EffectContext(Property.CriticalResistanceRate, Opportunity.HP50Down, duration: 10);
            var criticalResistanceRateOSufferP8D10 =
                new EffectContext(Property.CriticalResistanceRate, Opportunity.Suffer, .8m, 10);
            var damageReductionRateOAirHitD5 =
                new EffectContext(Property.DamageReductionRate, Opportunity.AirHit, duration: 5);
            var damageReductionRateOAirSufferD5 =
                new EffectContext(Property.DamageReductionRate, Opportunity.AirSuffer, duration: 5);
            var damageReductionRateOAvoidD5 =
                new EffectContext(Property.DamageReductionRate, Opportunity.Avoid, duration: 5);
            var damageReductionRateOFallD5 =
                new EffectContext(Property.DamageReductionRate, Opportunity.Fall, duration: 5);
            var damageReductionRateOFallSufferD5 =
                new EffectContext(Property.DamageReductionRate, Opportunity.FallSuffer, duration: 5);
            var damageReductionRateOKillD5 =
                new EffectContext(Property.DamageReductionRate, Opportunity.Kill, duration: 5);
            var damageReductionRateOSufferBossP1D5 =
                new EffectContext(Property.DamageReductionRate, Opportunity.SufferBoss, .1m, 5);
            var defenseOHP50DownD10  = new EffectContext(Property.Defense, Opportunity.HP50Down, duration: 10);
            var defenseOKillD5       = new EffectContext(Property.Defense, Opportunity.Kill, duration: 5);
            var defenseORunP1D5      = new EffectContext(Property.Defense, Opportunity.Run, .1m, 5);
            var defenseOSufferP5D10  = new EffectContext(Property.Defense, Opportunity.Suffer, .5m, 10);
            var defenseOUseSkillP1D5 = new EffectContext(Property.Defense, Opportunity.UseSkill, .1m, 5);
            var defenseBreakRateOCriticalP3D5 =
                new EffectContext(Property.DefenseBreakRate, Opportunity.Critical, .3m, 5);
            var defenseBreakRateOCriticalP5D3 =
                new EffectContext(Property.DefenseBreakRate, Opportunity.Critical, .5m, 3);
            var defenseBreakRateOKillD5  = new EffectContext(Property.DefenseBreakRate, Opportunity.Kill, duration: 5);
            var defenseBreakRateORunP1D5 = new EffectContext(Property.DefenseBreakRate, Opportunity.Run, .1m, 5);
            var defenseRateOSufferP15D5  = new EffectContext(Property.DefenseRate, Opportunity.Suffer, .15m, 5);
            var defenseRateOSufferHP50DownP1D5 =
                new EffectContext(Property.DefenseRate, Opportunity.SufferHP50Down, .1m, 5);
            var endureSecondOSufferP2 = new EffectContext(Property.EndureSecond, Opportunity.Suffer, .2m);
            var evadeOSufferP15D3     = new EffectContext(Property.Evade, Opportunity.Suffer, .15m, 3);
            var evadeOSufferP4D3      = new EffectContext(Property.Evade, Opportunity.Suffer, .4m, 3);
            var hpRecoveryOAvoidP1    = new EffectContext(Property.HPRecovery, Opportunity.Avoid, .1m);
            var hpRecoveryOHitP15     = new EffectContext(Property.HPRecovery, Opportunity.Hit, .15m);
            var hpRecoveryOKill       = new EffectContext(Property.HPRecovery, Opportunity.Kill);
            var hpRecoveryOSufferCriticalD50 =
                new EffectContext(Property.HPRecovery, Opportunity.SufferCritical, duration: 50);
            var hpRecoveryOSufferP3          = new EffectContext(Property.HPRecovery, Opportunity.Suffer, .3m);
            var hpRecoveryOSufferStamina50Up = new EffectContext(Property.HPRecovery, Opportunity.SufferStamina50Up);
            var hpRecoveryRateOUseAvoidP1    = new EffectContext(Property.HPRecoveryRate, Opportunity.UseAvoid, .1m);
            var invincibleSecondOHP20DownP1  = new EffectContext(Property.InvincibleSecond, Opportunity.HP20Down, .1m);
            var moveSpaceRateORunP15D5       = new EffectContext(Property.MoveSpaceRate, Opportunity.Run, .15m, 5);
            var moveSpaceRateOSufferP2D6     = new EffectContext(Property.MoveSpaceRate, Opportunity.Suffer, .2m, 6);
            var partialDamageRateOAvoidP1D10 =
                new EffectContext(Property.PartialDamageRate, Opportunity.Avoid, .1m, 10);
            var partialDamageRateOAvoidP3D5 = new EffectContext(Property.PartialDamageRate, Opportunity.Avoid, .3m, 5);
            var partialDamageRateOSufferP3D5 =
                new EffectContext(Property.PartialDamageRate, Opportunity.Suffer, .3m, 5);
            var soulGateRecoveryRateOUseSkillP1 =
                new EffectContext(Property.SoulGateRecoveryRate, Opportunity.UseSkill, .1m);
            var staminaRecoveryOHitP2 = new EffectContext(Property.StaminaRecovery, Opportunity.Hit, .2m);
            var superArmorBreakPowerRateOAvoidP3D5 =
                new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Avoid, .3m, 5);
            var superArmorBreakPowerRateOHitP5D5 =
                new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Hit, .5m, 5);
            var superArmorBreakPowerRateOKillD5 =
                new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Kill, duration: 5);
            var superArmorBreakPowerRateORunP1D5 =
                new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Run, .1m, 5);
            var superArmorBreakPowerRateOSufferP3D5 =
                new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Suffer, .3m, 5);

            var accuracy90                  = new Effect(Static.Accuracy, 90);
            var accuracy80                  = new Effect(Static.Accuracy, 80);
            var accuracy69                  = new Effect(Static.Accuracy, 69);
            var accuracy60                  = new Effect(Static.Accuracy, 90);
            var accuracy50                  = new Effect(Static.Accuracy, 50);
            var AccuracyM25                 = new Effect(Static.Accuracy, -25);
            var AccuracyM30                 = new Effect(Static.Accuracy, -30);
            var AccuracyM45                 = new Effect(Static.Accuracy, -45);
            var AttackSpeedRateM001         = new Effect(Static.AttackSpeedRate, -.01m);
            var DefenseRateM005             = new Effect(Static.DefenseRate, -.05m);
            var EvadeM30                    = new Effect(Static.Evade, -30);
            var EvadeM38                    = new Effect(Static.Evade, -38);
            var EvadeM45                    = new Effect(Static.Evade, -45);
            var EvadeM50                    = new Effect(Static.Evade, -50);
            var HPRateM005                  = new Effect(Static.HPRate, -.05m);
            var MoveSpaceRateM001           = new Effect(Static.MoveSpaceRate, -.01m);
            var criticalRate004             = new Effect(Static.CriticalRate, .04m);
            var criticalRate003             = new Effect(Static.CriticalRate, .03m);
            var criticalRate002             = new Effect(Static.CriticalRate, .02m);
            var criticalRate001             = new Effect(Static.CriticalRate, .01m);
            var attack600                   = new Effect(Static.Attack, 600);
            var attack420                   = new Effect(Static.Attack, 420);
            var attack240                   = new Effect(Static.Attack, 240);
            var attack120                   = new Effect(Static.Attack, 120);
            var attack60                    = new Effect(Static.Attack, 60);
            var defense720                  = new Effect(Static.Defense, 720);
            var defense480                  = new Effect(Static.Defense, 480);
            var defense312                  = new Effect(Static.Defense, 312);
            var defense144                  = new Effect(Static.Defense, 144);
            var defense72                   = new Effect(Static.Defense, 72);
            var hpRate015                   = new Effect(Static.HPRate, .15m);
            var hpRate011                   = new Effect(Static.HPRate, .11m);
            var hpRate006                   = new Effect(Static.HPRate, .06m);
            var hpRate004                   = new Effect(Static.HPRate, .04m);
            var hpRate002                   = new Effect(Static.HPRate, .02m);
            var damageReductionRate005      = new Effect(Static.DamageReductionRate, .05m);
            var defenseBreakRate005         = new Effect(Static.DefenseBreakRate, .05m);
            var defenseBreakRate004         = new Effect(Static.DefenseBreakRate, .04m);
            var defenseBreakRate003         = new Effect(Static.DefenseBreakRate, .03m);
            var defenseBreakRate002         = new Effect(Static.DefenseBreakRate, .02m);
            var defenseBreakRate001         = new Effect(Static.DefenseBreakRate, .01m);
            var moveSpaceRate005            = new Effect(Static.MoveSpaceRate, .05m);
            var moveSpaceRate004            = new Effect(Static.MoveSpaceRate, .04m);
            var moveSpaceRate003            = new Effect(Static.MoveSpaceRate, .03m);
            var moveSpaceRate002            = new Effect(Static.MoveSpaceRate, .02m);
            var moveSpaceRate001            = new Effect(Static.MoveSpaceRate, .01m);
            var superArmorBreakPowerRate006 = new Effect(Static.SuperArmorBreakPowerRate, .06m);
            var superArmorBreakPowerRate004 = new Effect(Static.SuperArmorBreakPowerRate, .04m);
            var superArmorBreakPowerRate003 = new Effect(Static.SuperArmorBreakPowerRate, .03m);
            var superArmorBreakPowerRate002 = new Effect(Static.SuperArmorBreakPowerRate, .02m);
            var superArmorBreakPowerRate001 = new Effect(Static.SuperArmorBreakPowerRate, .01m);
            var criticalResistanceRate004   = new Effect(Static.CriticalResistanceRate, .04m);
            var criticalResistanceRate003   = new Effect(Static.CriticalResistanceRate, .03m);
            var criticalResistanceRate002   = new Effect(Static.CriticalResistanceRate, .02m);
            var extraDamageRateFall02       = new Effect(Static.ExtraDamageRateFall, .2m);
            var extraDamageRateFall016      = new Effect(Static.ExtraDamageRateFall, .16m);
            var extraDamageRateFall012      = new Effect(Static.ExtraDamageRateFall, .12m);
            var extraDamageRateFall008      = new Effect(Static.ExtraDamageRateFall, .08m);
            var extraDamageRateFall004      = new Effect(Static.ExtraDamageRateFall, .04m);
            var attackRateOriginal036       = new Effect(Static.AttackRateOriginal, .36m);
            var attackRateOriginal018       = new Effect(Static.AttackRateOriginal, .18m);
            var criticalDamage700           = new Effect(Static.CriticalDamage, 700);
            var criticalDamage560           = new Effect(Static.CriticalDamage, 560);
            var criticalDamage420           = new Effect(Static.CriticalDamage, 420);
            var criticalDamage280           = new Effect(Static.CriticalDamage, 280);
            var criticalDamage140           = new Effect(Static.CriticalDamage, 140);
            var superArmorBreakPowerRate005 = new Effect(Static.SuperArmorBreakPowerRate, .05m);
            var superArmorBreakPowerRate007 = new Effect(Static.SuperArmorBreakPowerRate, .07m);
            var superArmorBreakPowerRate008 = new Effect(Static.SuperArmorBreakPowerRate, .08m);
            var superArmorBreakPowerRate009 = new Effect(Static.SuperArmorBreakPowerRate, .09m);
            var superArmorBreakPowerRate01  = new Effect(Static.SuperArmorBreakPowerRate, .1m);
            var criticalDamage720           = new Effect(Static.CriticalDamage, 720);
            var criticalDamage480           = new Effect(Static.CriticalDamage, 480);
            var criticalDamage270           = new Effect(Static.CriticalDamage, 240);
            var criticalDamage180           = new Effect(Static.CriticalDamage, 180);
            var criticalDamage90            = new Effect(Static.CriticalDamage, 90);
            var attackRate038               = new Effect(Static.AttackRate, .38m);
            var attackRate033               = new Effect(Static.AttackRate, .33m);
            var attackRate028               = new Effect(Static.AttackRate, .28m);
            var attackRate024               = new Effect(Static.AttackRate, .24m);
            var attackRate019               = new Effect(Static.AttackRate, .19m);
            var attackSpeedRate004          = new Effect(Static.AttackSpeedRate, .04m);
            var attackSpeedRate003          = new Effect(Static.AttackSpeedRate, .03m);
            var attackSpeedRate002          = new Effect(Static.AttackSpeedRate, .02m);
            var attackSpeedRate001          = new Effect(Static.AttackSpeedRate, .01m);
            var extraDamageRateBoss002      = new Effect(Static.ExtraDamageRateBoss, .02m);
            var evade42                     = new Effect(Static.Evade, 42);

            var brooches = new List<Brooches>();

            #region SD

            #region Attack

            var b鷹眼Sd = new Brooches("鷹眼",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Accuracy, 52)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Accuracy, 42)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Accuracy, 31)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Accuracy, 21)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Accuracy, 10)}}
                });
            var b致命Sd = new Brooches("致命",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {criticalDamage700}},
                    {BroochesRare.Giga, new[] {criticalDamage560}},
                    {BroochesRare.Mega, new[] {criticalDamage420}},
                    {BroochesRare.Kilo, new[] {criticalDamage280}},
                    {BroochesRare.Byte, new[] {criticalDamage140}}
                });
            var b破碎Sd = new Brooches("破碎",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {superArmorBreakPowerRate01}},
                    {BroochesRare.Giga, new[] {superArmorBreakPowerRate008}},
                    {BroochesRare.Mega, new[] {superArmorBreakPowerRate006}},
                    {BroochesRare.Kilo, new[] {superArmorBreakPowerRate004}},
                    {BroochesRare.Byte, new[] {superArmorBreakPowerRate002}}
                });
            var b熔解Sd = new Brooches("熔解",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {defenseBreakRate005}},
                    {BroochesRare.Giga, new[] {defenseBreakRate004}},
                    {BroochesRare.Mega, new[] {defenseBreakRate003}},
                    {BroochesRare.Kilo, new[] {defenseBreakRate002}},
                    {BroochesRare.Byte, new[] {defenseBreakRate001}}
                });
            var b屠殺Sd = new Brooches("屠殺",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateBoss, .05m)}},
                    {BroochesRare.Giga, new[] {extraDamageRateBoss002}}
                });
            var b獨輪Sd = new Brooches("獨輪",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateBasic, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.ExtraDamageRateBasic, .02m)}}
                });
            var b突擊Sd = new Brooches("突擊",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {attackRateOriginal036}},
                    {BroochesRare.Giga, new[] {attackRateOriginal018}}
                });
            var b攻擊者Sd = new Brooches("攻擊者",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Attack, 405)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Attack, 315)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Attack, 225)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Attack, 135)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Attack, 45)}}
                });
            var b碎片Sd = new Brooches("碎片",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.PartialDamageRate, .2m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.PartialDamageRate, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.PartialDamageRate, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.PartialDamageRate, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.PartialDamageRate, .04m)}}
                });
            var b燃燒Sd = new Brooches("燃燒",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackRateOHitP3D3, .24m)}},
                    {BroochesRare.Giga, new Effect[] {new(attackRateOHitP3D3, .21m)}},
                    {BroochesRare.Mega, new Effect[] {new(attackRateOHitP3D3, .18m)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackRateOHitP3D3, .15m)}},
                    {BroochesRare.Byte, new Effect[] {new(attackRateOHitP3D3, .12m)}}
                });
            var b過熱Sd = new Brooches("過熱",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackRateOHitP1D5, .45m)}},
                    {BroochesRare.Giga, new Effect[] {new(attackRateOHitP1D5, .42m)}},
                    {BroochesRare.Mega, new Effect[] {new(attackRateOHitP1D5, .39m)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackRateOHitP1D5, .36m)}},
                    {BroochesRare.Byte, new Effect[] {new(attackRateOHitP1D5, .33m)}}
                });
            var b刺穿Sd = new Brooches("刺穿",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseBreakRateOCriticalP5D3, .06m)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseBreakRateOCriticalP5D3, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseBreakRateOCriticalP5D3, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseBreakRateOCriticalP5D3, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseBreakRateOCriticalP5D3, .02m)}}
                });
            var b滲透Sd = new Brooches("滲透",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseBreakRateOCriticalP3D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseBreakRateOCriticalP3D5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseBreakRateOCriticalP3D5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseBreakRateOCriticalP3D5, .07m)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseBreakRateOCriticalP3D5, .06m)}}
                });
            var b黃蜂Sd = new Brooches("黃蜂",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.ExtraDamageRateAir, .2m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.ExtraDamageRateAir, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.ExtraDamageRateAir, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.ExtraDamageRateAir, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.ExtraDamageRateAir, .04m)}}
                });
            var b踐踏Sd = new Brooches("踐踏",
                BroochesSeries.Sd,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {extraDamageRateFall02}},
                    {BroochesRare.Giga, new[] {extraDamageRateFall016}},
                    {BroochesRare.Mega, new[] {extraDamageRateFall012}},
                    {BroochesRare.Kilo, new[] {extraDamageRateFall008}},
                    {BroochesRare.Byte, new[] {extraDamageRateFall004}}
                });

            #endregion

            #region Defense

            var b盔甲Sd = new Brooches("盔甲",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.AttackRateOriginal, .54m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.AttackRateOriginal, .45m)}},
                    {BroochesRare.Mega, new[] {attackRateOriginal036}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.AttackRateOriginal, .27m)}},
                    {BroochesRare.Byte, new[] {attackRateOriginal018}}
                });
            var b受傷Sd = new Brooches("受傷",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalResistanceRate, .06m)}},
                    {BroochesRare.Giga, new[] {criticalResistanceRate004}},
                    {BroochesRare.Mega, new[] {criticalResistanceRate003}},
                    {BroochesRare.Kilo, new[] {criticalResistanceRate002}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalResistanceRate, .01m)}}
                });
            var b模糊Sd = new Brooches("模糊",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Evade, 52)}},
                    {BroochesRare.Giga, new[] {evade42}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Evade, 31)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 21)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Evade, 10)}}
                });
            var b幽靈Sd = new Brooches("幽靈",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOAvoidD5, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOAvoidD5, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOAvoidD5, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOAvoidD5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOAvoidD5, .01m)}}
                });
            var b巨人Sd = new Brooches("巨人",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRateBasic, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRateBasic, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.DamageReductionRateBasic, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRateBasic, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRateBasic, .01m)}}
                });
            var b鸚螺Sd = new Brooches("鸚螺",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRateBoss, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRateBoss, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.DamageReductionRateBoss, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRateBoss, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRateBoss, .01m)}}
                });
            var b麻雀Sd = new Brooches("麻雀",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOAirSufferD5, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOAirSufferD5, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOAirSufferD5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOAirSufferD5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOAirSufferD5, .01m)}}
                });
            var b地殼Sd = new Brooches("地殼",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOFallD5, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOFallD5, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOFallD5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOFallD5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOFallD5, .01m)}}
                });
            var b幻象Sd = new Brooches("幻象",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(evadeOSufferP15D3, 270)}},
                    {BroochesRare.Giga, new Effect[] {new(evadeOSufferP15D3, 240)}},
                    {BroochesRare.Mega, new Effect[] {new(evadeOSufferP15D3, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(evadeOSufferP15D3, 180)}},
                    {BroochesRare.Byte, new Effect[] {new(evadeOSufferP15D3, 150)}}
                });
            var b幻影Sd = new Brooches("幻影",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(partialDamageRateOAvoidP1D10, .3m)}},
                    {BroochesRare.Giga, new Effect[] {new(partialDamageRateOAvoidP1D10, .27m)}},
                    {BroochesRare.Mega, new Effect[] {new(partialDamageRateOAvoidP1D10, .24m)}},
                    {BroochesRare.Kilo, new Effect[] {new(partialDamageRateOAvoidP1D10, .21m)}},
                    {BroochesRare.Byte, new Effect[] {new(partialDamageRateOAvoidP1D10, .18m)}}
                });
            var b巨魔Sd = new Brooches("巨魔",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryOSufferCriticalD50, 2_500)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryOSufferCriticalD50, 2_000)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryOSufferCriticalD50, 1_500)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryOSufferCriticalD50, 1_000)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryOSufferCriticalD50, 500)}}
                });
            var b生命Sd = new Brooches("生命",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.HPRate, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.HPRate, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.HPRate, .07m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.HPRate, .05m)}},
                    {BroochesRare.Byte, new[] {hpRate002}}
                });
            var b活力Sd = new Brooches("活力",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.StaminaRecovery, 8)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.StaminaRecovery, 6)}}
                });
            var b屏障Sd = new Brooches("屏障",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {damageReductionRate005}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRate, .02m)}}
                });
            var b石像Sd = new Brooches("石像",
                BroochesSeries.Sd,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseRateOSufferHP50DownP1D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseRateOSufferHP50DownP1D5, .37m)}}
                });

            #endregion

            #region Effect

            var b吸血Sd = new Brooches("吸血",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryOKill, 600)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryOKill, 480)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryOKill, 360)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryOKill, 240)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryOKill, 120)}}
                });
            var b迅猛Sd = new Brooches("迅猛",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .23m)}},
                    {BroochesRare.Mega, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .21m)}},
                    {BroochesRare.Kilo, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .19m)}},
                    {BroochesRare.Byte, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .18m)}}
                });
            var b行軍Sd = new Brooches("行軍",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.MoveSpaceRateTown, .06m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.MoveSpaceRateTown, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.MoveSpaceRateTown, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.MoveSpaceRateTown, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.MoveSpaceRateTown, .02m)}}
                });
            var b鋼鐵Sd = new Brooches("鋼鐵",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOSufferBossP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOSufferBossP1D5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOSufferBossP1D5, .07m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOSufferBossP1D5, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOSufferBossP1D5, .04m)}}
                });
            var b搖擺Sd = new Brooches("搖擺",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackRateOAvoid, .7m)}},
                    {BroochesRare.Giga, new Effect[] {new(attackRateOAvoid, .6m)}},
                    {BroochesRare.Mega, new Effect[] {new(attackRateOAvoid, .5m)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackRateOAvoid, .4m)}},
                    {BroochesRare.Byte, new Effect[] {new(attackRateOAvoid, .3m)}}
                });
            var b救濟Sd = new Brooches("救濟",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryOAvoidP1, 1_500)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryOAvoidP1, 1_350)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryOAvoidP1, 1_200)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryOAvoidP1, 1_050)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryOAvoidP1, 900)}}
                });
            var b吸收Sd = new Brooches("吸收",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(staminaRecoveryOHitP2, 10)}},
                    {BroochesRare.Giga, new Effect[] {new(staminaRecoveryOHitP2, 9)}},
                    {BroochesRare.Mega, new Effect[] {new(staminaRecoveryOHitP2, 8)}},
                    {BroochesRare.Kilo, new Effect[] {new(staminaRecoveryOHitP2, 7)}},
                    {BroochesRare.Byte, new Effect[] {new(staminaRecoveryOHitP2, 6)}}
                });
            var b迅速Sd = new Brooches("迅速",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {moveSpaceRate005}},
                    {BroochesRare.Giga, new[] {moveSpaceRate004}},
                    {BroochesRare.Mega, new[] {moveSpaceRate003}},
                    {BroochesRare.Kilo, new[] {moveSpaceRate002}},
                    {BroochesRare.Byte, new[] {moveSpaceRate001}}
                });
            var b硬度Sd = new Brooches("硬度",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseRateOSufferP15D5, .7m)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseRateOSufferP15D5, .63m)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseRateOSufferP15D5, .56m)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseRateOSufferP15D5, .49m)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseRateOSufferP15D5, .42m)}}
                });
            var b藐視Sd = new Brooches("藐視",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalResistanceRateOSufferP8D10, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalResistanceRateOSufferP8D10, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalResistanceRateOSufferP8D10, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalResistanceRateOSufferP8D10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalResistanceRateOSufferP8D10, .04m)}}
                });
            var b固執Sd = new Brooches("固執",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(endureSecondOSufferP2, 12)}},
                    {BroochesRare.Giga, new Effect[] {new(endureSecondOSufferP2, 10)}},
                    {BroochesRare.Mega, new Effect[] {new(endureSecondOSufferP2, 8)}},
                    {BroochesRare.Kilo, new Effect[] {new(endureSecondOSufferP2, 4)}},
                    {BroochesRare.Byte, new Effect[] {new(endureSecondOSufferP2, 1)}}
                });
            var b刺蝟Sd = new Brooches("刺蝟",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(moveSpaceRateOSufferP2D6, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(moveSpaceRateOSufferP2D6, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(moveSpaceRateOSufferP2D6, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(moveSpaceRateOSufferP2D6, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(moveSpaceRateOSufferP2D6, .02m)}}
                });
            var b喜悅Sd = new Brooches("喜悅",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(new(Property.HPRecoveryRate, Opportunity.UseAvoid, .15m), 5)}
                    },
                    {BroochesRare.Giga, new Effect[] {new(new(Property.HPRecoveryRate, Opportunity.UseAvoid, .1m), 3)}}
                });
            var b行者Sd = new Brooches("行者",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(moveSpaceRateORunP15D5, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(moveSpaceRateORunP15D5, .06m)}}
                });
            var b啟蒙Sd = new Brooches("啟蒙",
                BroochesSeries.Sd,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(cooldownShorterRateOUseSkillP2, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(cooldownShorterRateOUseSkillP2, .05m)}}
                });

            #endregion

            #endregion

            #region BSK

            #region Attack

            var b鷹眼Bsk = b鷹眼Sd with {Series = BroochesSeries.Bsk};
            var b飛行Bsk = b黃蜂Sd with {Name = "飛行", Series = BroochesSeries.Bsk};
            var b致命Bsk = b致命Sd with {Series = BroochesSeries.Bsk};
            var b阻礙Bsk = b踐踏Sd with {Name = "阻礙", Series = BroochesSeries.Bsk};
            var b破碎Bsk = b破碎Sd with {Series = BroochesSeries.Bsk};
            var b熔解Bsk = b熔解Sd with {Series = BroochesSeries.Bsk};
            var b攻擊Bsk = new Brooches("攻擊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Attack, 216)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Attack, 160)}},
                    {BroochesRare.Mega, new[] {attack120}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Attack, 72)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Attack, 24)}}
                });
            var b碎片Bsk = b碎片Sd with {Series = BroochesSeries.Bsk};

            var b灰熊Bsk = new Brooches("灰熊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.AttackRate, .48m), DefenseRateM005}},
                    {BroochesRare.Giga, new[] {new(Static.AttackRate, .42m), DefenseRateM005}},
                    {BroochesRare.Mega, new[] {new(Static.AttackRate, .36m), DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {new(Static.AttackRate, .3m), DefenseRateM005}},
                    {BroochesRare.Byte, new[] {attackRate024, DefenseRateM005}}
                });
            var b瘋狂Bsk = new Brooches("瘋狂",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {attackRate038, EvadeM30}},
                    {BroochesRare.Giga, new[] {attackRate033, EvadeM30}},
                    {BroochesRare.Mega, new[] {attackRate028, EvadeM30}},
                    {BroochesRare.Kilo, new[] {attackRate024, EvadeM30}},
                    {BroochesRare.Byte, new[] {attackRate019, EvadeM30}}
                });
            var b捨身Bsk = new Brooches("捨身",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {attackRate038, HPRateM005}},
                    {BroochesRare.Giga, new[] {attackRate033, HPRateM005}},
                    {BroochesRare.Mega, new[] {attackRate028, HPRateM005}},
                    {BroochesRare.Kilo, new[] {attackRate024, HPRateM005}},
                    {BroochesRare.Byte, new[] {attackRate019, HPRateM005}}
                });
            var b搏擊Bsk = new Brooches("搏擊",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {accuracy90, DefenseRateM005}},
                    {BroochesRare.Giga, new[] {accuracy80, DefenseRateM005}},
                    {BroochesRare.Mega, new[] {accuracy69, DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {accuracy60, DefenseRateM005}},
                    {BroochesRare.Byte, new[] {accuracy50, DefenseRateM005}}
                });
            var b野豬Bsk = new Brooches("野豬",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {accuracy90, EvadeM30}},
                    {BroochesRare.Giga, new[] {accuracy80, EvadeM30}},
                    {BroochesRare.Mega, new[] {accuracy69, EvadeM30}},
                    {BroochesRare.Kilo, new[] {accuracy60, EvadeM30}},
                    {BroochesRare.Byte, new[] {accuracy50, EvadeM30}}
                });
            var b老虎Bsk = new Brooches("老虎",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {accuracy90, HPRateM005}},
                    {BroochesRare.Giga, new[] {accuracy80, HPRateM005}},
                    {BroochesRare.Mega, new[] {accuracy69, HPRateM005}},
                    {BroochesRare.Kilo, new[] {accuracy60, HPRateM005}},
                    {BroochesRare.Byte, new[] {accuracy50, HPRateM005}}
                });
            var b黑蛇Bsk = new Brooches("黑蛇",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {superArmorBreakPowerRate009, DefenseRateM005}},
                    {BroochesRare.Giga, new[] {superArmorBreakPowerRate008, DefenseRateM005}},
                    {BroochesRare.Mega, new[] {superArmorBreakPowerRate007, DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {superArmorBreakPowerRate006, DefenseRateM005}},
                    {BroochesRare.Byte, new[] {superArmorBreakPowerRate005, DefenseRateM005}}
                });
            var b海怪Bsk = new Brooches("海怪",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {superArmorBreakPowerRate009, EvadeM30}},
                    {BroochesRare.Giga, new[] {superArmorBreakPowerRate008, EvadeM30}},
                    {BroochesRare.Mega, new[] {superArmorBreakPowerRate007, EvadeM30}},
                    {BroochesRare.Kilo, new[] {superArmorBreakPowerRate006, EvadeM30}},
                    {BroochesRare.Byte, new[] {superArmorBreakPowerRate005, EvadeM30}}
                });
            var b麋鹿Bsk = new Brooches("麋鹿",
                BroochesSeries.Bsk,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {superArmorBreakPowerRate009, HPRateM005}},
                    {BroochesRare.Giga, new[] {superArmorBreakPowerRate008, HPRateM005}},
                    {BroochesRare.Mega, new[] {superArmorBreakPowerRate007, HPRateM005}},
                    {BroochesRare.Kilo, new[] {superArmorBreakPowerRate006, HPRateM005}},
                    {BroochesRare.Byte, new[] {superArmorBreakPowerRate005, HPRateM005}}
                });

            #endregion

            #region Defense

            var b盔甲Bsk = new Brooches("盔甲",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DefenseRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DefenseRate, .21m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.DefenseRate, .16m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DefenseRate, .12m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DefenseRate, .08m)}}
                });
            var b模糊Bsk = new Brooches("模糊",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {evade42}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Evade, 33)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Evade, 25)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 16)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Evade, 8)}}
                });
            var b幽靈Bsk = new Brooches("幽靈",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOAvoidD5, .09m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOAvoidD5, .07m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOAvoidD5, .05m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOAvoidD5, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOAvoidD5, .01m)}}
                });
            var b巨人Bsk = new Brooches("巨人",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.DamageReductionRate, .09m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.DamageReductionRate, .07m)}},
                    {BroochesRare.Mega, new[] {damageReductionRate005}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.DamageReductionRate, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.DamageReductionRate, .01m)}}
                });
            var b鸚螺bsk = b鸚螺Sd with {Series = BroochesSeries.Bsk};
            var b麻雀Bsk = new Brooches("麻雀",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOAirHitD5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOAirHitD5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOAirHitD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOAirHitD5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOAirHitD5, .02m)}}
                });
            var b地殼Bsk = new Brooches("地殼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOFallSufferD5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOFallSufferD5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOFallSufferD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOFallSufferD5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOFallSufferD5, .02m)}}
                });
            var b狂暴Bsk = new Brooches("狂暴",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOSufferP3D5, 1_080)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOSufferP3D5, 840)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOSufferP3D5, 600)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOSufferP3D5, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOSufferP3D5, 120)}}
                });
            var b恐懼Bsk = new Brooches("恐懼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(accuracyOSufferP3D5, 350)}},
                    {BroochesRare.Giga, new Effect[] {new(accuracyOSufferP3D5, 280)}},
                    {BroochesRare.Mega, new Effect[] {new(accuracyOSufferP3D5, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(accuracyOSufferP3D5, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(accuracyOSufferP3D5, 70)}}
                });
            var b欺騙Bsk = new Brooches("欺騙",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOSufferP3D5, 1_500)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOSufferP3D5, 1_200)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOSufferP3D5, 900)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOSufferP3D5, 600)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOSufferP3D5, 300)}}
                });
            var b發狂Bsk = new Brooches("發狂",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(partialDamageRateOSufferP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(partialDamageRateOSufferP3D5, .4m)}},
                    {BroochesRare.Mega, new Effect[] {new(partialDamageRateOSufferP3D5, .3m)}},
                    {BroochesRare.Kilo, new Effect[] {new(partialDamageRateOSufferP3D5, .2m)}},
                    {BroochesRare.Byte, new Effect[] {new(partialDamageRateOSufferP3D5, .1m)}}
                });
            var b死神Bsk = new Brooches("死神",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(superArmorBreakPowerRateOSufferP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(superArmorBreakPowerRateOSufferP3D5, .4m)}},
                    {BroochesRare.Mega, new Effect[] {new(superArmorBreakPowerRateOSufferP3D5, .3m)}},
                    {BroochesRare.Kilo, new Effect[] {new(superArmorBreakPowerRateOSufferP3D5, .2m)}},
                    {BroochesRare.Byte, new Effect[] {new(superArmorBreakPowerRateOSufferP3D5, .1m)}}
                });
            var b激怒Bsk = new Brooches("激怒",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOAvoidP3D5, 1_200)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOAvoidP3D5, 750)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOAvoidP3D5, 450)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOAvoidP3D5, 300)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOAvoidP3D5, 150)}}
                });
            var b鐵桿Bsk = new Brooches("鐵桿",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(accuracyOAvoidP3D5, 20)}},
                    {BroochesRare.Giga, new Effect[] {new(accuracyOAvoidP3D5, 16)}},
                    {BroochesRare.Mega, new Effect[] {new(accuracyOAvoidP3D5, 12)}},
                    {BroochesRare.Kilo, new Effect[] {new(accuracyOAvoidP3D5, 8)}},
                    {BroochesRare.Byte, new Effect[] {new(accuracyOAvoidP3D5, 4)}}
                });
            var b犀牛Bsk = new Brooches("犀牛",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOAvoidP3D5, 2_400)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOAvoidP3D5, 1_680)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOAvoidP3D5, 1_200)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOAvoidP3D5, 960)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOAvoidP3D5, 720)}}
                });
            var b憤怒Bsk = new Brooches("憤怒",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(partialDamageRateOAvoidP3D5, .5m)}},
                    {BroochesRare.Giga, new Effect[] {new(partialDamageRateOAvoidP3D5, .42m)}},
                    {BroochesRare.Mega, new Effect[] {new(partialDamageRateOAvoidP3D5, .33m)}},
                    {BroochesRare.Kilo, new Effect[] {new(partialDamageRateOAvoidP3D5, .29m)}},
                    {BroochesRare.Byte, new Effect[] {new(partialDamageRateOAvoidP3D5, .25m)}}
                });
            var b小鬼Bsk = new Brooches("小鬼",
                BroochesSeries.Bsk,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(superArmorBreakPowerRateOAvoidP3D5, .21m)}},
                    {BroochesRare.Giga, new Effect[] {new(superArmorBreakPowerRateOAvoidP3D5, .16m)}},
                    {BroochesRare.Mega, new Effect[] {new(superArmorBreakPowerRateOAvoidP3D5, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(superArmorBreakPowerRateOAvoidP3D5, .08m)}},
                    {BroochesRare.Byte, new Effect[] {new(superArmorBreakPowerRateOAvoidP3D5, .04m)}}
                });

            #endregion

            #region Effect

            var b固執Bsk = new Brooches("固執",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(endureSecondOSufferP2, 12)}},
                    {BroochesRare.Giga, new Effect[] {new(endureSecondOSufferP2, 10)}},
                    {BroochesRare.Mega, new Effect[] {new(endureSecondOSufferP2, 8)}},
                    {BroochesRare.Kilo, new Effect[] {new(endureSecondOSufferP2, 4)}},
                    {BroochesRare.Byte, new Effect[] {new(endureSecondOSufferP2, 2)}}
                });
            var b迅猛Bsk = new Brooches("迅猛",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .21m)}},
                    {BroochesRare.Giga, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .19m)}},
                    {BroochesRare.Mega, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .18m)}},
                    {BroochesRare.Kilo, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .16m)}},
                    {BroochesRare.Byte, new Effect[] {new(superArmorBreakPowerRateOHitP5D5, .15m)}}
                });
            var b行軍Bsk = b行軍Sd with {Series = BroochesSeries.Bsk};
            var b鋼鐵Bsk = new Brooches("鋼鐵",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOSufferBossP1D5, .08m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOSufferBossP1D5, .07m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOSufferBossP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOSufferBossP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOSufferBossP1D5, .03m)}}
                });

            var b搖擺Bsk = new Brooches("搖擺",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackSpeedRateOAvoid, .56m)}},
                    {BroochesRare.Giga, new Effect[] {new(attackSpeedRateOAvoid, .45m)}},
                    {BroochesRare.Mega, new Effect[] {new(attackSpeedRateOAvoid, .4m)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackSpeedRateOAvoid, .32m)}},
                    {BroochesRare.Byte, new Effect[] {new(attackSpeedRateOAvoid, .24m)}}
                });
            var b救濟Bsk = new Brooches("救濟",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryOAvoidP1, 2_500)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryOAvoidP1, 2_250)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryOAvoidP1, 2_000)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryOAvoidP1, 1_750)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryOAvoidP1, 1_500)}}
                });
            var b藐視Bsk = new Brooches("藐視",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalResistanceRateOSufferP8D10, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalResistanceRateOSufferP8D10, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalResistanceRateOSufferP8D10, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalResistanceRateOSufferP8D10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalResistanceRateOSufferP8D10, .04m)}}
                });
            var b迅速Bsk = b迅速Sd with {Series = BroochesSeries.Bsk};

            var b發熱Bsk = new Brooches("發熱",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOUseSkillP1D5, 1_350)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOUseSkillP1D5, 1_050)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOUseSkillP1D5, 750)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOUseSkillP1D5, 450)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOUseSkillP1D5, 150)}}
                });
            var b恢復Bsk = new Brooches("恢復",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(accuracyOUseSkillP1D5, 350)}},
                    {BroochesRare.Giga, new Effect[] {new(accuracyOUseSkillP1D5, 280)}},
                    {BroochesRare.Mega, new Effect[] {new(accuracyOUseSkillP1D5, 210)}},
                    {BroochesRare.Kilo, new Effect[] {new(accuracyOUseSkillP1D5, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(accuracyOUseSkillP1D5, 710)}}
                });
            var b沉重Bsk = new Brooches("沉重",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOUseSkillP3D5, 3_000)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOUseSkillP3D5, 2_400)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOUseSkillP3D5, 1_800)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOUseSkillP3D5, 1_200)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOUseSkillP3D5, 600)}}
                });
            var b劍聖Bsk = new Brooches("劍聖",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackORunP3D5, 450)}},
                    {BroochesRare.Giga, new Effect[] {new(attackORunP3D5, 350)}},
                    {BroochesRare.Mega, new Effect[] {new(attackORunP3D5, 250)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackORunP3D5, 150)}},
                    {BroochesRare.Byte, new Effect[] {new(attackORunP3D5, 50)}}
                });
            var b餅乾Bsk = new Brooches("餅乾",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(superArmorBreakPowerRateORunP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(superArmorBreakPowerRateORunP1D5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(superArmorBreakPowerRateORunP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(superArmorBreakPowerRateORunP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(superArmorBreakPowerRateORunP1D5, .02m)}}
                });
            var b充電Bsk = new Brooches("充電",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseBreakRateORunP1D5, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseBreakRateORunP1D5, .08m)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseBreakRateORunP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseBreakRateORunP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseBreakRateORunP1D5, .02m)}}
                });
            var b狂亂Bsk = new Brooches("狂亂",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOKillD5, 1_225)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOKillD5, 700)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOKillD5, 350)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOKillD5, 175)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOKillD5, 87)}}
                });
            var b狂人Bsk = new Brooches("狂人",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(superArmorBreakPowerRateOKillD5, .16m)}},
                    {BroochesRare.Giga, new Effect[] {new(superArmorBreakPowerRateOKillD5, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(superArmorBreakPowerRateOKillD5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(superArmorBreakPowerRateOKillD5, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(superArmorBreakPowerRateOKillD5, .03m)}}
                });
            var b感覺Bsk = new Brooches("感覺",
                BroochesSeries.Bsk,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseBreakRateOKillD5, .16m)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseBreakRateOKillD5, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseBreakRateOKillD5, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseBreakRateOKillD5, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseBreakRateOKillD5, .03m)}}
                });

            #endregion

            #endregion

            #region FOT

            #region Attack

            var b燃料庫Fot = new Brooches("燃料庫",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {defenseBreakRate005, EvadeM45}},
                    {BroochesRare.Giga, new[] {defenseBreakRate004, EvadeM45}},
                    {BroochesRare.Mega, new[] {defenseBreakRate003, EvadeM45}},
                    {BroochesRare.Kilo, new[] {defenseBreakRate002, EvadeM45}},
                    {BroochesRare.Byte, new[] {defenseBreakRate001, EvadeM45}}
                });
            var b投石器Fot = new Brooches("投石器",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {defenseBreakRate005, AccuracyM45}},
                    {BroochesRare.Giga, new[] {defenseBreakRate004, AccuracyM45}},
                    {BroochesRare.Mega, new[] {defenseBreakRate003, AccuracyM45}},
                    {BroochesRare.Kilo, new[] {defenseBreakRate002, AccuracyM45}},
                    {BroochesRare.Byte, new[] {defenseBreakRate001, AccuracyM45}}
                });
            var b發射器Fot = new Brooches("發射器",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {criticalDamage720, AccuracyM25}},
                    {BroochesRare.Giga, new[] {criticalDamage480, AccuracyM25}},
                    {BroochesRare.Mega, new[] {criticalDamage270, AccuracyM25}},
                    {BroochesRare.Kilo, new[] {criticalDamage180, AccuracyM25}},
                    {BroochesRare.Byte, new[] {criticalDamage90, AccuracyM25}}
                });
            var b閃電戰Fot = new Brooches("閃電戰",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {criticalDamage720, EvadeM38}},
                    {BroochesRare.Giga, new[] {criticalDamage480, EvadeM38}},
                    {BroochesRare.Mega, new[] {criticalDamage270, EvadeM38}},
                    {BroochesRare.Kilo, new[] {criticalDamage180, EvadeM38}},
                    {BroochesRare.Byte, new[] {criticalDamage90, EvadeM38}}
                });
            var b加農Fot = new Brooches("加農",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {attack600, AccuracyM25}},
                    {BroochesRare.Giga, new[] {attack420, AccuracyM25}},
                    {BroochesRare.Mega, new[] {attack240, AccuracyM25}},
                    {BroochesRare.Kilo, new[] {attack120, AccuracyM25}},
                    {BroochesRare.Byte, new[] {attack60, AccuracyM25}}
                });
            var b佔領Fot = new Brooches("佔領",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {attack600, EvadeM38}},
                    {BroochesRare.Giga, new[] {attack420, EvadeM38}},
                    {BroochesRare.Mega, new[] {attack240, EvadeM38}},
                    {BroochesRare.Kilo, new[] {attack120, EvadeM38}},
                    {BroochesRare.Byte, new[] {attack60, EvadeM38}}
                });
            var b支配Fot = new Brooches("支配",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.CriticalRate, .08m), EvadeM38}},
                    {BroochesRare.Giga, new[] {criticalRate004, EvadeM38}},
                    {BroochesRare.Mega, new[] {criticalRate003, EvadeM38}},
                    {BroochesRare.Kilo, new[] {criticalRate002, EvadeM38}},
                    {BroochesRare.Byte, new[] {criticalRate001, EvadeM38}}
                });
            var b游擊隊Fot = new Brooches("游擊隊",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOCriticalD3, 870)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOCriticalD3, 560)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOCriticalD3, 336)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOCriticalD3, 280)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOCriticalD3, 140)}}
                });
            var b勇氣Fot = new Brooches("勇氣",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOHP30DownThenHitD3, 1_260)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOHP30DownThenHitD3, 810)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOHP30DownThenHitD3, 450)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOHP30DownThenHitD3, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOHP30DownThenHitD3, 180)}}
                });
            var b大將Fot = new Brooches("大將",
                BroochesSeries.Fot,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryOHitP15, 320)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryOHitP15, 220)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryOHitP15, 160)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryOHitP15, 100)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryOHitP15, 40)}}
                });

            #endregion

            #region Defense

            var b戰壕Fot = new Brooches("戰壕",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {defense720, MoveSpaceRateM001}},
                    {BroochesRare.Giga, new[] {defense480, MoveSpaceRateM001}},
                    {BroochesRare.Mega, new[] {defense312, MoveSpaceRateM001}},
                    {BroochesRare.Kilo, new[] {defense144, MoveSpaceRateM001}},
                    {BroochesRare.Byte, new[] {defense72, MoveSpaceRateM001}}
                });
            var b危城Fot = new Brooches("危城",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {defense720, AttackSpeedRateM001}},
                    {BroochesRare.Giga, new[] {defense480, AttackSpeedRateM001}},
                    {BroochesRare.Mega, new[] {defense312, AttackSpeedRateM001}},
                    {BroochesRare.Kilo, new[] {defense144, AttackSpeedRateM001}},
                    {BroochesRare.Byte, new[] {defense72, AttackSpeedRateM001}}
                });
            var b防禦Fot = new Brooches("防禦",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {defense720, AccuracyM30}},
                    {BroochesRare.Giga, new[] {defense480, AccuracyM30}},
                    {BroochesRare.Mega, new[] {defense312, AccuracyM30}},
                    {BroochesRare.Kilo, new[] {defense144, AccuracyM30}},
                    {BroochesRare.Byte, new[] {defense72, AccuracyM30}}
                });
            var b地圖Fot = new Brooches("地圖",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {hpRate015, MoveSpaceRateM001}},
                    {BroochesRare.Giga, new[] {hpRate011, MoveSpaceRateM001}},
                    {BroochesRare.Mega, new[] {hpRate006, MoveSpaceRateM001}},
                    {BroochesRare.Kilo, new[] {hpRate004, MoveSpaceRateM001}},
                    {BroochesRare.Byte, new[] {hpRate002, MoveSpaceRateM001}}
                });
            var b堡壘Fot = new Brooches("堡壘",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {hpRate015, AttackSpeedRateM001}},
                    {BroochesRare.Giga, new[] {hpRate011, AttackSpeedRateM001}},
                    {BroochesRare.Mega, new[] {hpRate006, AttackSpeedRateM001}},
                    {BroochesRare.Kilo, new[] {hpRate004, AttackSpeedRateM001}},
                    {BroochesRare.Byte, new[] {hpRate002, AttackSpeedRateM001}}
                });
            var b停留Fot = new Brooches("停留",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {hpRate015, AccuracyM30}},
                    {BroochesRare.Giga, new[] {hpRate011, AccuracyM30}},
                    {BroochesRare.Mega, new[] {hpRate006, AccuracyM30}},
                    {BroochesRare.Kilo, new[] {hpRate004, AccuracyM30}},
                    {BroochesRare.Byte, new[] {hpRate002, AccuracyM30}}
                });
            var b堅固的Fot = new Brooches("堅固的",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {hpRate015, EvadeM50}},
                    {BroochesRare.Giga, new[] {hpRate011, EvadeM50}},
                    {BroochesRare.Mega, new[] {hpRate006, EvadeM50}},
                    {BroochesRare.Kilo, new[] {hpRate004, EvadeM50}},
                    {BroochesRare.Byte, new[] {hpRate002, EvadeM50}}
                });
            var b摩擦Fot = new Brooches("摩擦",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryOSufferP3, .1000m)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryOSufferP3, .660m)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryOSufferP3, .500m)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryOSufferP3, .330m)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryOSufferP3, .160m)}}
                });
            var b穩固Fot = new Brooches("穩固",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseOHP50DownD10, 770)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseOHP50DownD10, 490)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseOHP50DownD10, 280)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseOHP50DownD10, 140)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseOHP50DownD10, 70)}}
                });
            var b休戰Fot = new Brooches("休戰",
                BroochesSeries.Fot,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalResistanceRateOHP50DownD10, .27m)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalResistanceRateOHP50DownD10, .18m)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalResistanceRateOHP50DownD10, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalResistanceRateOHP50DownD10, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalResistanceRateOHP50DownD10, .03m)}}
                });

            #endregion

            #region Effect

            var b掃蕩Fot = new Brooches("掃蕩",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseORunP1D5, 400)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseORunP1D5, 300)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseORunP1D5, 220)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseORunP1D5, 80)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseORunP1D5, 40)}}
                });
            var b戰術Fot = new Brooches("戰術",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOKillD5, 1_200)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOKillD5, 1_000)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOKillD5, 800)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOKillD5, 500)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOKillD5, 200)}}
                });
            var b防護Fot = new Brooches("防護",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseOKillD5, 850)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseOKillD5, 575)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseOKillD5, 400)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseOKillD5, 250)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseOKillD5, 100)}}
                });
            var b撤退Fot = new Brooches("撤退",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryRateOUseAvoidP1, .15m)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryRateOUseAvoidP1, .11m)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryRateOUseAvoidP1, .08m)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryRateOUseAvoidP1, .05m)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryRateOUseAvoidP1, .02m)}}
                });
            var b疏散Fot = new Brooches("疏散",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(damageReductionRateOKillD5, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(damageReductionRateOKillD5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(damageReductionRateOKillD5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(damageReductionRateOKillD5, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(damageReductionRateOKillD5, .01m)}}
                });
            var b狙擊Fot = new Brooches("狙擊",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(soulGateRecoveryRateOUseSkillP1, .15m)}},
                    {BroochesRare.Giga, new Effect[] {new(soulGateRecoveryRateOUseSkillP1, .12m)}},
                    {BroochesRare.Mega, new Effect[] {new(soulGateRecoveryRateOUseSkillP1, .09m)}},
                    {BroochesRare.Kilo, new Effect[] {new(soulGateRecoveryRateOUseSkillP1, .06m)}},
                    {BroochesRare.Byte, new Effect[] {new(soulGateRecoveryRateOUseSkillP1, .03m)}}
                });
            var b打擾Fot = new Brooches("打擾",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseOSufferP5D10, 150)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseOSufferP5D10, 100)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseOSufferP5D10, 60)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseOSufferP5D10, 30)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseOSufferP5D10, 10)}}
                });
            var b偵察Fot = new Brooches("偵察",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOHitP1D5, 400)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOHitP1D5, 300)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOHitP1D5, 175)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOHitP1D5, 75)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOHitP1D5, 25)}}
                });
            var b對策Fot = new Brooches("對策",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(invincibleSecondOHP20DownP1, 1.5m)}},
                    {BroochesRare.Giga, new Effect[] {new(invincibleSecondOHP20DownP1, 1.25m)}},
                    {BroochesRare.Mega, new Effect[] {new(invincibleSecondOHP20DownP1, 1)}},
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(new(Property.InvincibleSecond, Opportunity.HP15Down, .1m), 1)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(new(Property.InvincibleSecond, Opportunity.HP10Down, .1m), 1)}
                    }
                });
            var b保護Fot = new Brooches("保護",
                BroochesSeries.Fot,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(defenseOUseSkillP1D5, 800)}},
                    {BroochesRare.Giga, new Effect[] {new(defenseOUseSkillP1D5, 600)}},
                    {BroochesRare.Mega, new Effect[] {new(defenseOUseSkillP1D5, 440)}},
                    {BroochesRare.Kilo, new Effect[] {new(defenseOUseSkillP1D5, 280)}},
                    {BroochesRare.Byte, new Effect[] {new(defenseOUseSkillP1D5, 140)}}
                });

            #endregion

            #endregion

            #region SIN

            #region Attack

            var b猝死Sin = new Brooches("猝死",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new[] {criticalRate004}},
                    {BroochesRare.Mega, new[] {criticalRate003}},
                    {BroochesRare.Kilo, new[] {criticalRate002}},
                    {BroochesRare.Byte, new[] {criticalRate001}}
                });
            var b暗殺Sin = new Brooches("暗殺",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {superArmorBreakPowerRate006, EvadeM30}},
                    {BroochesRare.Giga, new[] {superArmorBreakPowerRate004, EvadeM30}},
                    {BroochesRare.Mega, new[] {superArmorBreakPowerRate003, EvadeM30}},
                    {BroochesRare.Kilo, new[] {superArmorBreakPowerRate002, EvadeM30}},
                    {BroochesRare.Byte, new[] {superArmorBreakPowerRate001, EvadeM30}}
                });
            var b刺激者Sin = new Brooches("刺激者",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {superArmorBreakPowerRate006, HPRateM005}},
                    {BroochesRare.Giga, new[] {superArmorBreakPowerRate004, HPRateM005}},
                    {BroochesRare.Mega, new[] {superArmorBreakPowerRate003, HPRateM005}},
                    {BroochesRare.Kilo, new[] {superArmorBreakPowerRate002, HPRateM005}},
                    {BroochesRare.Byte, new[] {superArmorBreakPowerRate001, HPRateM005}}
                });
            var b擦傷Sin = new Brooches("擦傷",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {attackSpeedRate004, defenseBreakRate002}},
                    {BroochesRare.Giga, new[] {attackSpeedRate003, defenseBreakRate001}},
                    {BroochesRare.Mega, new[] {attackSpeedRate003}},
                    {BroochesRare.Kilo, new[] {attackSpeedRate002}},
                    {BroochesRare.Byte, new[] {attackSpeedRate001}}
                });
            var b颱風Sin = new Brooches("颱風",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {attackSpeedRate004, extraDamageRateBoss002}},
                    {BroochesRare.Giga, new[] {attackSpeedRate003, new(Static.ExtraDamageRateBoss, .01m)}},
                    {BroochesRare.Mega, new[] {attackSpeedRate003}},
                    {BroochesRare.Kilo, new[] {attackSpeedRate002}},
                    {BroochesRare.Byte, new[] {attackSpeedRate001}}
                });
            var b根除Sin = new Brooches("根除",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.CriticalDamage, 980), HPRateM005}},
                    {BroochesRare.Giga, new[] {criticalDamage560, HPRateM005}},
                    {BroochesRare.Mega, new[] {new(Static.CriticalDamage, 336), HPRateM005}},
                    {BroochesRare.Kilo, new[] {new(Static.CriticalDamage, 196), HPRateM005}},
                    {BroochesRare.Byte, new[] {new(Static.CriticalDamage, 98), HPRateM005}}
                });
            var b魯莽Sin = new Brooches("魯莽",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {defenseBreakRate005, DefenseRateM005}},
                    {BroochesRare.Giga, new[] {defenseBreakRate004, DefenseRateM005}},
                    {BroochesRare.Mega, new[] {defenseBreakRate003, DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {defenseBreakRate002, DefenseRateM005}},
                    {BroochesRare.Byte, new[] {defenseBreakRate001, DefenseRateM005}}
                });
            var b清除Sin = new Brooches("清除",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalDamage, 756)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.CriticalDamage, 448)}},
                    {BroochesRare.Mega, new[] {criticalDamage280}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.CriticalDamage, 168)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalDamage, 84)}}
                });
            var b驅動Sin = new Brooches("驅動",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackSpeedRateOCriticalHitP1D2, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(attackSpeedRateOCriticalHitP1D2, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(attackSpeedRateOCriticalHitP1D2, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackSpeedRateOCriticalHitP1D2, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(attackSpeedRateOCriticalHitP1D2, .01m)}}
                });
            var b酸性的Sin = new Brooches("酸性的",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOCriticalHitP1D2, 1_620)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOCriticalHitP1D2, 1_134)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOCriticalHitP1D2, 793)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOCriticalHitP1D2, 555)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOCriticalHitP1D2, 388)}}
                });

            #endregion

            #region Defense

            var b躲藏Sin = new Brooches("躲藏",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Evade, 130)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Evade, 91)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Evade, 63)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 44)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Evade, 30)}}
                });
            var b油漆Sin = new Brooches("油漆",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackSpeedRateOSufferCriticalP5D2, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(attackSpeedRateOSufferCriticalP5D2, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(attackSpeedRateOSufferCriticalP5D2, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackSpeedRateOSufferCriticalP5D2, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(attackSpeedRateOSufferCriticalP5D2, .01m)}}
                });
            var b分身Sin = new Brooches("分身",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOSufferCriticalP5D2, 1_560)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOSufferCriticalP5D2, 960)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOSufferCriticalP5D2, 600)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOSufferCriticalP5D2, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOSufferCriticalP5D2, 180)}}
                });
            var b煙霧Sin = new Brooches("煙霧",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalRateOUseAvoidP1D5, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalRateOUseAvoidP1D5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalRateOUseAvoidP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalRateOUseAvoidP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalRateOUseAvoidP1D5, .01m)}}
                });
            var b逃避Sin = new Brooches("逃避",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOUseAvoidP1D5, 1_723)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOUseAvoidP1D5, 1_060)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOUseAvoidP1D5, 663)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOUseAvoidP1D5, 397)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOUseAvoidP1D5, 162)}}
                });
            var b預防Sin = new Brooches("預防",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalResistanceRate, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.CriticalResistanceRate, .08m)}},
                    {BroochesRare.Mega, new[] {criticalResistanceRate004}},
                    {BroochesRare.Kilo, new[] {criticalResistanceRate003}},
                    {BroochesRare.Byte, new[] {criticalResistanceRate002}}
                });
            var b流動Sin = new Brooches("流動",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackSpeedRateOSufferP3D1_5m, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(attackSpeedRateOSufferP3D1_5m, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(attackSpeedRateOSufferP3D1_5m, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackSpeedRateOSufferP3D1_5m, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(attackSpeedRateOSufferP3D1_5m, .01m)}}
                });
            var b打斷Sin = new Brooches("打斷",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(evadeOSufferP4D3, 180)}},
                    {BroochesRare.Giga, new Effect[] {new(evadeOSufferP4D3, 126)}},
                    {BroochesRare.Mega, new Effect[] {new(evadeOSufferP4D3, 88)}},
                    {BroochesRare.Kilo, new Effect[] {new(evadeOSufferP4D3, 61)}},
                    {BroochesRare.Byte, new Effect[] {new(evadeOSufferP4D3, 42)}}
                });
            var b影子步伐Sin = new Brooches("影子步伐",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalRateOAvoidP3D2, .14m)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalRateOAvoidP3D2, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalRateOAvoidP3D2, .05m)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalRateOAvoidP3D2, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalRateOAvoidP3D2, .01m)}}
                });
            var b後退步伐Sin = new Brooches("後退步伐",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOSufferP5D3, 1_930)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOSufferP5D3, 1_351)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOSufferP5D3, 945)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOSufferP5D3, 661)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOSufferP5D3, 463)}}
                });

            #endregion

            #region Effect

            var b飛鼠裝Sin = new Brooches("飛鼠裝",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.MoveSpaceRateBattle, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.MoveSpaceRateBattle, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.MoveSpaceRateBattle, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.MoveSpaceRateBattle, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.MoveSpaceRateBattle, .01m)}}
                });
            var b貓眼Sin = new Brooches("貓眼",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOUseSkillP5D5, 2_200)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOUseSkillP5D5, 1_600)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOUseSkillP5D5, 1_100)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOUseSkillP5D5, 650)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOUseSkillP5D5, 300)}}
                });
            var b鷹眼Sin = new Brooches("鷹眼",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageORunP2D3, 1_760)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageORunP2D3, 1_232)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageORunP2D3, 862)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageORunP2D3, 603)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageORunP2D3, 422)}}
                });
            var b追捕Sin = new Brooches("追捕",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalRateORunP3D5, .08m)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalRateORunP3D5, .06m)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalRateORunP3D5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalRateORunP3D5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalRateORunP3D5, .01m)}}
                });
            var b血腥斗篷Sin = new Brooches("血腥斗篷",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalRateOUseSkillP5D5, .08m)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalRateOUseSkillP5D5, .06m)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalRateOUseSkillP5D5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalRateOUseSkillP5D5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalRateOUseSkillP5D5, .01m)}}
                });
            var b每週標記Sin = new Brooches("每週標記",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOSufferStamina50UpD5, 550)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOSufferStamina50UpD5, 385)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOSufferStamina50UpD5, 269)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOSufferStamina50UpD5, 188)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOSufferStamina50UpD5, 131)}}
                });
            var b噬血Sin = new Brooches("噬血",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(hpRecoveryOSufferStamina50Up, 140)}},
                    {BroochesRare.Giga, new Effect[] {new(hpRecoveryOSufferStamina50Up, 100)}},
                    {BroochesRare.Mega, new Effect[] {new(hpRecoveryOSufferStamina50Up, 70)}},
                    {BroochesRare.Kilo, new Effect[] {new(hpRecoveryOSufferStamina50Up, 40)}},
                    {BroochesRare.Byte, new Effect[] {new(hpRecoveryOSufferStamina50Up, 20)}}
                });
            var b斷頭台Sin = new Brooches("斷頭台",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(criticalDamageOUseItemP2D5, 1_250)}},
                    {BroochesRare.Giga, new Effect[] {new(criticalDamageOUseItemP2D5, 875)}},
                    {BroochesRare.Mega, new Effect[] {new(criticalDamageOUseItemP2D5, 612)}},
                    {BroochesRare.Kilo, new Effect[] {new(criticalDamageOUseItemP2D5, 428)}},
                    {BroochesRare.Byte, new Effect[] {new(criticalDamageOUseItemP2D5, 299)}}
                });
            var b瘋狂Sin = new Brooches("瘋狂",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOUseItemP2D5, 936)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOUseItemP2D5, 655)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOUseItemP2D5, 458)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOUseItemP2D5, 320)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOUseItemP2D5, 224)}}
                });
            var b技術Sin = new Brooches("技術",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(attackOCriticalHitP1D5, 760)}},
                    {BroochesRare.Giga, new Effect[] {new(attackOCriticalHitP1D5, 532)}},
                    {BroochesRare.Mega, new Effect[] {new(attackOCriticalHitP1D5, 372)}},
                    {BroochesRare.Kilo, new Effect[] {new(attackOCriticalHitP1D5, 260)}},
                    {BroochesRare.Byte, new Effect[] {new(attackOCriticalHitP1D5, 182)}}
                });

            #endregion

            #endregion

            return _result[classify] = brooches.Where(x => x.Series == series && x.Type == type).ToList();
        }

        private record BroochesClass(BroochesSeries Series, BroochesType Type);
    }
}