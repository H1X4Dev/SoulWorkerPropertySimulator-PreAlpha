// ReSharper disable once CheckNamespace

using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal class ShareEffect
    {
        // ReSharper disable InconsistentNaming
        internal readonly EffectContext AccuracyOAvoidP3D5     = new(Property.Accuracy, Opportunity.Avoid, .3m, 5);
        internal readonly EffectContext AccuracyOSufferP3D5    = new(Property.Accuracy, Opportunity.Suffer, .3m, 5);
        internal readonly EffectContext AccuracyOUseSkillP1D5  = new(Property.Accuracy, Opportunity.UseSkill, .1m, 5);
        internal readonly EffectContext AttackOAvoidP3D5       = new(Property.Attack, Opportunity.Avoid, .3m, 5);
        internal readonly EffectContext AttackOCriticalHitP1D5 = new(Property.Attack, Opportunity.CriticalHit, .1m, 5);
        internal readonly EffectContext AttackOHitP1D5         = new(Property.Attack, Opportunity.Hit, .1m, 5);
        internal readonly EffectContext AttackOKillD5          = new(Property.Attack, Opportunity.Kill, duration: 5);
        internal readonly EffectContext AttackORunP3D5         = new(Property.Attack, Opportunity.Run, .3m, 5);
        internal readonly EffectContext AttackOSufferP3D5      = new(Property.Attack, Opportunity.Suffer, .3m, 5);
        internal readonly EffectContext AttackOUseItemP2D5     = new(Property.Attack, Opportunity.UseItem, .2m, 5);
        internal readonly EffectContext AttackOUseSkillP1D5    = new(Property.Attack, Opportunity.UseSkill, .1m, 5);
        internal readonly EffectContext AttackRateOAvoid       = new(Property.AttackRate, Opportunity.Avoid);
        internal readonly EffectContext AttackRateOHitP1D5     = new(Property.AttackRate, Opportunity.Hit, .1m, 5);
        internal readonly EffectContext AttackRateOHitP3D3     = new(Property.AttackRate, Opportunity.Hit, .3m, 3);
        internal readonly EffectContext AttackSpeedRateOAvoid  = new(Property.AttackRateNext, Opportunity.Avoid);

        internal readonly EffectContext AttackSpeedRateOCriticalHitP1D2 =
            new(Property.AttackSpeedRate, Opportunity.CriticalHit, .1m, 2);

        internal readonly EffectContext AttackSpeedRateOSufferCriticalP5D2 =
            new(Property.AttackSpeedRate, Opportunity.SufferCritical, .5m, 2);

        internal readonly EffectContext AttackSpeedRateOSufferP3D15M =
            new(Property.AttackSpeedRate, Opportunity.Suffer, .3m, 1.5m);

        internal readonly EffectContext CooldownShorterRateOUseSkillP2 =
            new(Property.CooldownShorterRate, Opportunity.UseSkill, .2m);

        internal readonly EffectContext CriticalDamageOAvoidP3D5 =
            new(Property.CriticalDamage, Opportunity.Avoid, .3m, 5);

        internal readonly EffectContext CriticalDamageOCriticalD3 =
            new(Property.CriticalDamage, Opportunity.Critical, duration: 3);

        internal readonly EffectContext CriticalDamageOCriticalHitP1D2 =
            new(Property.CriticalDamage, Opportunity.CriticalHit, .1m, 2);

        internal readonly EffectContext CriticalDamageOhp30DownThenHitD3 =
            new(Property.CriticalDamage, Opportunity.Hp30DownThenHit, duration: 3);

        internal readonly EffectContext CriticalDamageORunP2D3 = new(Property.CriticalDamage, Opportunity.Run, .2m, 3);

        internal readonly EffectContext CriticalDamageOSufferCriticalP5D2 =
            new(Property.CriticalDamage, Opportunity.SufferCritical, .5m, 2);

        internal readonly EffectContext CriticalDamageOSufferP3D5 =
            new(Property.CriticalDamage, Opportunity.Suffer, .3m, 5);

        internal readonly EffectContext CriticalDamageOSufferP5D3 =
            new(Property.CriticalDamage, Opportunity.Suffer, .5m, 3);

        internal readonly EffectContext CriticalDamageOSufferStamina50UpD5 =
            new(Property.CriticalDamage, Opportunity.SufferStamina50Up, duration: 5);

        internal readonly EffectContext CriticalDamageOUseAvoidP1D5 =
            new(Property.CriticalDamage, Opportunity.UseAvoid, .1m, 5);

        internal readonly EffectContext CriticalDamageOUseItemP2D5 =
            new(Property.CriticalDamage, Opportunity.UseItem, .2m, 5);

        internal readonly EffectContext CriticalDamageOUseSkillP3D5 =
            new(Property.CriticalDamage, Opportunity.UseSkill, .3m, 5);

        internal readonly EffectContext CriticalDamageOUseSkillP5D5 =
            new(Property.CriticalDamage, Opportunity.UseSkill, .5m, 5);

        internal readonly EffectContext CriticalRateOAvoidP3D2 = new(Property.CriticalRate, Opportunity.Avoid, .3m, 2);
        internal readonly EffectContext CriticalRateORunP3D5   = new(Property.CriticalRate, Opportunity.Run, .3m, 5);

        internal readonly EffectContext CriticalRateOUseAvoidP1D5 =
            new(Property.CriticalRate, Opportunity.UseAvoid, .1m, 5);

        internal readonly EffectContext CriticalRateOUseSkillP5D5 =
            new(Property.CriticalRate, Opportunity.UseSkill, .5m, 5);

        internal readonly EffectContext CriticalResistanceRateOHp50DownD10 =
            new(Property.CriticalResistanceRate, Opportunity.Hp50Down, duration: 10);

        internal readonly EffectContext CriticalResistanceRateOSufferP8D10 =
            new(Property.CriticalResistanceRate, Opportunity.Suffer, .8m, 10);

        internal readonly EffectContext DamageReductionRateOAirHitD5 =
            new(Property.DamageReductionRate, Opportunity.AirHit, duration: 5);

        internal readonly EffectContext DamageReductionRateOAirSufferD5 =
            new(Property.DamageReductionRate, Opportunity.AirSuffer, duration: 5);

        internal readonly EffectContext DamageReductionRateOAvoidD5 =
            new(Property.DamageReductionRate, Opportunity.Avoid, duration: 5);

        internal readonly EffectContext DamageReductionRateOFallD5 =
            new(Property.DamageReductionRate, Opportunity.Fall, duration: 5);

        internal readonly EffectContext DamageReductionRateOFallSufferD5 =
            new(Property.DamageReductionRate, Opportunity.FallSuffer, duration: 5);

        internal readonly EffectContext DamageReductionRateOKillD5 =
            new(Property.DamageReductionRate, Opportunity.Kill, duration: 5);

        internal readonly EffectContext DamageReductionRateOSufferBossP1D5 =
            new(Property.DamageReductionRate, Opportunity.SufferBoss, .1m, 5);

        internal readonly EffectContext DefenseBreakRateOCriticalP3D5 =
            new(Property.DefenseBreakRate, Opportunity.Critical, .3m, 5);

        internal readonly EffectContext DefenseBreakRateOCriticalP5D3 =
            new(Property.DefenseBreakRate, Opportunity.Critical, .5m, 3);

        internal readonly EffectContext DefenseBreakRateOKillD5 =
            new(Property.DefenseBreakRate, Opportunity.Kill, duration: 5);

        internal readonly EffectContext DefenseBreakRateORunP1D5 =
            new(Property.DefenseBreakRate, Opportunity.Run, .1m, 5);

        internal readonly EffectContext DefenseOHp50DownD10 = new(Property.Defense, Opportunity.Hp50Down, duration: 10);
        internal readonly EffectContext DefenseOKillD5 = new(Property.Defense, Opportunity.Kill, duration: 5);
        internal readonly EffectContext DefenseORunP1D5 = new(Property.Defense, Opportunity.Run, .1m, 5);
        internal readonly EffectContext DefenseOSufferP5D10 = new(Property.Defense, Opportunity.Suffer, .5m, 10);
        internal readonly EffectContext DefenseOUseSkillP1D5 = new(Property.Defense, Opportunity.UseSkill, .1m, 5);

        internal readonly EffectContext DefenseRateOSufferHp50DownP1D5 =
            new(Property.DefenseRate, Opportunity.SufferHp50Down, .1m, 5);

        internal readonly EffectContext DefenseRateOSufferP15D5 =
            new(Property.DefenseRate, Opportunity.Suffer, .15m, 5);

        internal readonly EffectContext EvadeOSufferP15D3     = new(Property.Evade, Opportunity.Suffer, .15m, 3);
        internal readonly EffectContext EndureSecondOSufferP2 = new(Property.EndureSecond, Opportunity.Suffer, .2m);
        internal readonly EffectContext EvadeOSufferP4D3      = new(Property.Evade, Opportunity.Suffer, .4m, 3);
        internal readonly EffectContext HpRecoveryOAvoidP1    = new(Property.HpRecovery, Opportunity.Avoid, .1m);
        internal readonly EffectContext HpRecoveryOHitP15     = new(Property.HpRecovery, Opportunity.Hit, .15m);
        internal readonly EffectContext HpRecoveryOKill       = new(Property.HpRecovery, Opportunity.Kill);

        internal readonly EffectContext HpRecoveryOSufferCriticalD50 =
            new(Property.HpRecovery, Opportunity.SufferCritical, duration: 50);

        internal readonly EffectContext HpRecoveryOSufferP3 = new(Property.HpRecovery, Opportunity.Suffer, .3m);

        internal readonly EffectContext HpRecoveryOSufferStamina50Up =
            new(Property.HpRecovery, Opportunity.SufferStamina50Up);

        internal readonly EffectContext HpRecoveryRateOUseAvoidP1 =
            new(Property.HpRecoveryRate, Opportunity.UseAvoid, .1m);

        internal readonly EffectContext InvincibleSecondOHp20DownP1 =
            new(Property.InvincibleSecond, Opportunity.Hp20Down, .1m);

        internal readonly EffectContext MoveSpaceRateORunP15D5 = new(Property.MoveSpaceRate, Opportunity.Run, .15m, 5);

        internal readonly EffectContext MoveSpaceRateOSufferP2D6 =
            new(Property.MoveSpaceRate, Opportunity.Suffer, .2m, 6);

        internal readonly EffectContext PartialDamageRateOAvoidP1D10 =
            new(Property.PartialDamageRate, Opportunity.Avoid, .1m, 10);

        internal readonly EffectContext PartialDamageRateOAvoidP3D5 =
            new(Property.PartialDamageRate, Opportunity.Avoid, .3m, 5);

        internal readonly EffectContext PartialDamageRateOSufferP3D5 =
            new(Property.PartialDamageRate, Opportunity.Suffer, .3m, 5);

        internal readonly EffectContext SoulGateRecoveryRateOUseSkillP1 =
            new(Property.SoulGateRecoveryRate, Opportunity.UseSkill, .1m);

        internal readonly EffectContext StaminaRecoveryOHitP2 = new(Property.StaminaRecovery, Opportunity.Hit, .2m);

        internal readonly EffectContext SuperArmorBreakPowerRateOAvoidP3D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Avoid, .3m, 5);

        internal readonly EffectContext SuperArmorBreakPowerRateOHitP5D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Hit, .5m, 5);

        internal readonly EffectContext SuperArmorBreakPowerRateOKillD5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Kill, duration: 5);

        internal readonly EffectContext SuperArmorBreakPowerRateORunP1D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Run, .1m, 5);

        internal readonly EffectContext SuperArmorBreakPowerRateOSufferP3D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Suffer, .3m, 5);

        internal readonly Effect Accuracy28_2                = new(StaticEffectContext.Accuracy, 28.2m);
        internal readonly Effect Accuracy42_3                = new(StaticEffectContext.Accuracy, 42.3m);
        internal readonly Effect Accuracy47                  = new(StaticEffectContext.Accuracy, 47);
        internal readonly Effect Accuracy50                  = new(StaticEffectContext.Accuracy, 50);
        internal readonly Effect Accuracy51_7                = new(StaticEffectContext.Accuracy, 51.7m);
        internal readonly Effect Accuracy56_4                = new(StaticEffectContext.Accuracy, 56.4m);
        internal readonly Effect Accuracy60                  = new(StaticEffectContext.Accuracy, 60);
        internal readonly Effect Accuracy65_8                = new(StaticEffectContext.Accuracy, 65.8m);
        internal readonly Effect Accuracy69                  = new(StaticEffectContext.Accuracy, 69);
        internal readonly Effect Accuracy70_5                = new(StaticEffectContext.Accuracy, 70.5m);
        internal readonly Effect Accuracy79_9                = new(StaticEffectContext.Accuracy, 79.9m);
        internal readonly Effect Accuracy80                  = new(StaticEffectContext.Accuracy, 80);
        internal readonly Effect Accuracy90                  = new(StaticEffectContext.Accuracy, 90);
        internal readonly Effect AccuracyM25                 = new(StaticEffectContext.Accuracy, -25);
        internal readonly Effect AccuracyM30                 = new(StaticEffectContext.Accuracy, -30);
        internal readonly Effect AccuracyM45                 = new(StaticEffectContext.Accuracy, -45);
        internal readonly Effect Attack60                    = new(StaticEffectContext.Attack, 60);
        internal readonly Effect Attack120                   = new(StaticEffectContext.Attack, 120);
        internal readonly Effect Attack240                   = new(StaticEffectContext.Attack, 240);
        internal readonly Effect Attack420                   = new(StaticEffectContext.Attack, 420);
        internal readonly Effect Attack600                   = new(StaticEffectContext.Attack, 600);
        internal readonly Effect AttackRate00135             = new(StaticEffectContext.AttackRate, .0135m);
        internal readonly Effect AttackRate0018              = new(StaticEffectContext.AttackRate, .018m);
        internal readonly Effect AttackRate00225             = new(StaticEffectContext.AttackRate, .0225m);
        internal readonly Effect AttackRate0027              = new(StaticEffectContext.AttackRate, .027m);
        internal readonly Effect AttackRate00315             = new(StaticEffectContext.AttackRate, .0315m);
        internal readonly Effect AttackRate0036              = new(StaticEffectContext.AttackRate, .036m);
        internal readonly Effect AttackRate00405             = new(StaticEffectContext.AttackRate, .0405m);
        internal readonly Effect AttackRate0045              = new(StaticEffectContext.AttackRate, .045m);
        internal readonly Effect AttackRate005               = new(StaticEffectContext.AttackRate, .05m);
        internal readonly Effect AttackRate0054              = new(StaticEffectContext.AttackRate, .054m);
        internal readonly Effect AttackRate00675             = new(StaticEffectContext.AttackRate, .0675m);
        internal readonly Effect AttackRate00765             = new(StaticEffectContext.AttackRate, .0765m);
        internal readonly Effect AttackRate0081              = new(StaticEffectContext.AttackRate, .081m);
        internal readonly Effect AttackRate00855             = new(StaticEffectContext.AttackRate, .0855m);
        internal readonly Effect AttackRate009               = new(StaticEffectContext.AttackRate, .09m);
        internal readonly Effect AttackRate019               = new(StaticEffectContext.AttackRate, .19m);
        internal readonly Effect AttackRate024               = new(StaticEffectContext.AttackRate, .24m);
        internal readonly Effect AttackRate028               = new(StaticEffectContext.AttackRate, .28m);
        internal readonly Effect AttackRate033               = new(StaticEffectContext.AttackRate, .33m);
        internal readonly Effect AttackRate038               = new(StaticEffectContext.AttackRate, .38m);
        internal readonly Effect AttackRateM00135            = new(StaticEffectContext.AttackRate, -.0135m);
        internal readonly Effect AttackRateM00225            = new(StaticEffectContext.AttackRate, -.0225m);
        internal readonly Effect AttackRateOriginal018       = new(StaticEffectContext.AttackRateOriginal, .18m);
        internal readonly Effect AttackRateOriginal036       = new(StaticEffectContext.AttackRateOriginal, .36m);
        internal readonly Effect AttackSpeedRate001          = new(StaticEffectContext.AttackSpeedRate, .01m);
        internal readonly Effect AttackSpeedRate002          = new(StaticEffectContext.AttackSpeedRate, .02m);
        internal readonly Effect AttackSpeedRate0025         = new(StaticEffectContext.AttackSpeedRate, .025m);
        internal readonly Effect AttackSpeedRate003          = new(StaticEffectContext.AttackSpeedRate, .03m);
        internal readonly Effect AttackSpeedRate0035         = new(StaticEffectContext.AttackSpeedRate, .035m);
        internal readonly Effect AttackSpeedRate004          = new(StaticEffectContext.AttackSpeedRate, .04m);
        internal readonly Effect AttackSpeedRate005          = new(StaticEffectContext.AttackSpeedRate, .05m);
        internal readonly Effect AttackSpeedRateM001         = new(StaticEffectContext.AttackSpeedRate, -.01m);
        internal readonly Effect AttackSpeedRateM003         = new(StaticEffectContext.AttackSpeedRate, -.03m);
        internal readonly Effect AttackSpeedRateM0035        = new(StaticEffectContext.AttackSpeedRate, -.035m);
        internal readonly Effect CooldownShorterRate002      = new(StaticEffectContext.CooldownShorterRate, .02m);
        internal readonly Effect CriticalDamage90            = new(StaticEffectContext.CriticalDamage, 90);
        internal readonly Effect CriticalDamage140           = new(StaticEffectContext.CriticalDamage, 140);
        internal readonly Effect CriticalDamage180           = new(StaticEffectContext.CriticalDamage, 180);
        internal readonly Effect CriticalDamage258           = new(StaticEffectContext.CriticalDamage, 258);
        internal readonly Effect CriticalDamage270           = new(StaticEffectContext.CriticalDamage, 240);
        internal readonly Effect CriticalDamage280           = new(StaticEffectContext.CriticalDamage, 280);
        internal readonly Effect CriticalDamage323           = new(StaticEffectContext.CriticalDamage, 323);
        internal readonly Effect CriticalDamage387           = new(StaticEffectContext.CriticalDamage, 387);
        internal readonly Effect CriticalDamage420           = new(StaticEffectContext.CriticalDamage, 420);
        internal readonly Effect CriticalDamage452           = new(StaticEffectContext.CriticalDamage, 452);
        internal readonly Effect CriticalDamage480           = new(StaticEffectContext.CriticalDamage, 480);
        internal readonly Effect CriticalDamage560           = new(StaticEffectContext.CriticalDamage, 560);
        internal readonly Effect CriticalDamage645           = new(StaticEffectContext.CriticalDamage, 645);
        internal readonly Effect CriticalDamage700           = new(StaticEffectContext.CriticalDamage, 700);
        internal readonly Effect CriticalDamage710           = new(StaticEffectContext.CriticalDamage, 710);
        internal readonly Effect CriticalDamage720           = new(StaticEffectContext.CriticalDamage, 720);
        internal readonly Effect CriticalDamage774           = new(StaticEffectContext.CriticalDamage, 774);
        internal readonly Effect CriticalDamage968           = new(StaticEffectContext.CriticalDamage, 968);
        internal readonly Effect CriticalDamage1097          = new(StaticEffectContext.CriticalDamage, 1_097);
        internal readonly Effect CriticalRate001             = new(StaticEffectContext.CriticalRate, .01m);
        internal readonly Effect CriticalRate002             = new(StaticEffectContext.CriticalRate, .02m);
        internal readonly Effect CriticalRate0025            = new(StaticEffectContext.CriticalRate, .025m);
        internal readonly Effect CriticalRate003             = new(StaticEffectContext.CriticalRate, .03m);
        internal readonly Effect CriticalRate0035            = new(StaticEffectContext.CriticalRate, .035m);
        internal readonly Effect CriticalRate004             = new(StaticEffectContext.CriticalRate, .04m);
        internal readonly Effect CriticalRate005             = new(StaticEffectContext.CriticalRate, .05m);
        internal readonly Effect CriticalResistanceRate0015  = new(StaticEffectContext.CriticalResistanceRate, .015m);
        internal readonly Effect CriticalResistanceRate002   = new(StaticEffectContext.CriticalResistanceRate, .02m);
        internal readonly Effect CriticalResistanceRate0025  = new(StaticEffectContext.CriticalResistanceRate, .025m);
        internal readonly Effect CriticalResistanceRate003   = new(StaticEffectContext.CriticalResistanceRate, .03m);
        internal readonly Effect CriticalResistanceRate0035  = new(StaticEffectContext.CriticalResistanceRate, .035m);
        internal readonly Effect CriticalResistanceRate004   = new(StaticEffectContext.CriticalResistanceRate, .04m);
        internal readonly Effect DamageReductionRate002      = new(StaticEffectContext.DamageReductionRate, .02m);
        internal readonly Effect DamageReductionRate003      = new(StaticEffectContext.DamageReductionRate, .03m);
        internal readonly Effect DamageReductionRate004      = new(StaticEffectContext.DamageReductionRate, .04m);
        internal readonly Effect DamageReductionRate005      = new(StaticEffectContext.DamageReductionRate, .05m);
        internal readonly Effect DamageReductionRateBasic002 = new(StaticEffectContext.DamageReductionRateBasic, .02m);

        internal readonly Effect DamageReductionRateBasic0025 =
            new(StaticEffectContext.DamageReductionRateBasic, .025m);

        internal readonly Effect DamageReductionRateBasic003 = new(StaticEffectContext.DamageReductionRateBasic, .03m);
        internal readonly Effect DamageReductionRateBoss003  = new(StaticEffectContext.DamageReductionRateBoss, .03m);
        internal readonly Effect DamageReductionRateBoss0035 = new(StaticEffectContext.DamageReductionRateBoss, .035m);
        internal readonly Effect DamageReductionRateBoss005  = new(StaticEffectContext.DamageReductionRateBoss, .05m);

        internal readonly Effect DamageReductionRateFlame0025 =
            new(StaticEffectContext.DamageReductionRateFlame, .025m);

        internal readonly Effect DamageReductionRateNed0025 = new(StaticEffectContext.DamageReductionRateNed, .025m);
        internal readonly Effect DamageReductionRatePvP0025 = new(StaticEffectContext.DamageReductionRatePvP, .025m);
        internal readonly Effect DamageReductionRateSix005 = new(StaticEffectContext.DamageReductionRateSix, .05m);
        internal readonly Effect DamageReductionRateSoul0045 = new(StaticEffectContext.DamageReductionRateSoul, .045m);
        internal readonly Effect DamageReductionRateSoul005 = new(StaticEffectContext.DamageReductionRateSoul, .05m);
        internal readonly Effect Defense72 = new(StaticEffectContext.Defense, 72);
        internal readonly Effect Defense144 = new(StaticEffectContext.Defense, 144);
        internal readonly Effect Defense312 = new(StaticEffectContext.Defense, 312);
        internal readonly Effect Defense480 = new(StaticEffectContext.Defense, 480);
        internal readonly Effect Defense720 = new(StaticEffectContext.Defense, 720);
        internal readonly Effect DefenseBreakRate001 = new(StaticEffectContext.DefenseBreakRate, .01m);
        internal readonly Effect DefenseBreakRate002 = new(StaticEffectContext.DefenseBreakRate, .02m);
        internal readonly Effect DefenseBreakRate003 = new(StaticEffectContext.DefenseBreakRate, .03m);
        internal readonly Effect DefenseBreakRate004 = new(StaticEffectContext.DefenseBreakRate, .04m);
        internal readonly Effect DefenseBreakRate005 = new(StaticEffectContext.DefenseBreakRate, .05m);
        internal readonly Effect DefenseRate0018 = new(StaticEffectContext.DefenseRate, .018m);
        internal readonly Effect DefenseRate00225 = new(StaticEffectContext.DefenseRate, .0225m);
        internal readonly Effect DefenseRate0027 = new(StaticEffectContext.DefenseRate, .027m);
        internal readonly Effect DefenseRate00315 = new(StaticEffectContext.DefenseRate, .0315m);
        internal readonly Effect DefenseRate0036 = new(StaticEffectContext.DefenseRate, .036m);
        internal readonly Effect DefenseRate00405 = new(StaticEffectContext.DefenseRate, .0405m);
        internal readonly Effect DefenseRate0045 = new(StaticEffectContext.DefenseRate, .045m);
        internal readonly Effect DefenseRate00495 = new(StaticEffectContext.DefenseRate, .0495m);
        internal readonly Effect DefenseRate0054 = new(StaticEffectContext.DefenseRate, .054m);
        internal readonly Effect DefenseRate00585 = new(StaticEffectContext.DefenseRate, .0585m);
        internal readonly Effect DefenseRate00675 = new(StaticEffectContext.DefenseRate, .0675m);
        internal readonly Effect DefenseRate0072 = new(StaticEffectContext.DefenseRate, .072m);
        internal readonly Effect DefenseRate00765 = new(StaticEffectContext.DefenseRate, .0765m);
        internal readonly Effect DefenseRateM0018 = new(StaticEffectContext.DefenseRate, -.018m);
        internal readonly Effect DefenseRateM00225 = new(StaticEffectContext.DefenseRate, -.0225m);
        internal readonly Effect DefenseRateM0027 = new(StaticEffectContext.DefenseRate, -.027m);
        internal readonly Effect DefenseRateM003 = new(StaticEffectContext.DefenseRate, -.03m);
        internal readonly Effect DefenseRateM005 = new(StaticEffectContext.DefenseRate, -.05m);
        internal readonly Effect Evade21 = new(StaticEffectContext.Evade, 21);
        internal readonly Effect Evade27 = new(StaticEffectContext.Evade, 27);
        internal readonly Effect Evade32 = new(StaticEffectContext.Evade, 32);
        internal readonly Effect Evade37 = new(StaticEffectContext.Evade, 37);
        internal readonly Effect Evade42 = new(StaticEffectContext.Evade, 42);
        internal readonly Effect Evade43 = new(StaticEffectContext.Evade, 43);
        internal readonly Effect Evade64 = new(StaticEffectContext.Evade, 64);
        internal readonly Effect Evade70 = new(StaticEffectContext.Evade, 70);
        internal readonly Effect Evade80 = new(StaticEffectContext.Evade, 80);
        internal readonly Effect Evade91 = new(StaticEffectContext.Evade, 91);
        internal readonly Effect EvadeM30 = new(StaticEffectContext.Evade, -30);
        internal readonly Effect EvadeM38 = new(StaticEffectContext.Evade, -38);
        internal readonly Effect EvadeM45 = new(StaticEffectContext.Evade, -45);
        internal readonly Effect EvadeM50 = new(StaticEffectContext.Evade, -50);
        internal readonly Effect ExpVolumeRateEnemy00525 = new(StaticEffectContext.ExpVolumeRateEnemy, .0525m);
        internal readonly Effect ExpVolumeRateEnemy0075 = new(StaticEffectContext.ExpVolumeRateEnemy, .075m);
        internal readonly Effect ExpVolumeRateEnemy009 = new(StaticEffectContext.ExpVolumeRateEnemy, .09m);
        internal readonly Effect ExtraDamageRateBasic002 = new(StaticEffectContext.ExtraDamageRateBasic, .02m);
        internal readonly Effect ExtraDamageRateBasic0025 = new(StaticEffectContext.ExtraDamageRateBasic, .025m);
        internal readonly Effect ExtraDamageRateBasic003 = new(StaticEffectContext.ExtraDamageRateBasic, .03m);
        internal readonly Effect ExtraDamageRateBoss002 = new(StaticEffectContext.ExtraDamageRateBoss, .02m);
        internal readonly Effect ExtraDamageRateBoss0025 = new(StaticEffectContext.ExtraDamageRateBoss, .025m);
        internal readonly Effect ExtraDamageRateBoss003 = new(StaticEffectContext.ExtraDamageRateBoss, .03m);
        internal readonly Effect ExtraDamageRateBoss0035 = new(StaticEffectContext.ExtraDamageRateBoss, .035m);
        internal readonly Effect ExtraDamageRateBoss0045 = new(StaticEffectContext.ExtraDamageRateBoss, .045m);
        internal readonly Effect ExtraDamageRateBoss005 = new(StaticEffectContext.ExtraDamageRateBoss, .05m);
        internal readonly Effect ExtraDamageRateFall004 = new(StaticEffectContext.ExtraDamageRateFall, .04m);
        internal readonly Effect ExtraDamageRateFall008 = new(StaticEffectContext.ExtraDamageRateFall, .08m);
        internal readonly Effect ExtraDamageRateFall012 = new(StaticEffectContext.ExtraDamageRateFall, .12m);
        internal readonly Effect ExtraDamageRateFall016 = new(StaticEffectContext.ExtraDamageRateFall, .16m);
        internal readonly Effect ExtraDamageRateFall02 = new(StaticEffectContext.ExtraDamageRateFall, .2m);
        internal readonly Effect ExtraDamageRateFlame0025 = new(StaticEffectContext.ExtraDamageRateFlame, .025m);
        internal readonly Effect ExtraDamageRateJunk0025 = new(StaticEffectContext.ExtraDamageRateJunk, .025m);
        internal readonly Effect ExtraDamageRateSix005 = new(StaticEffectContext.ExtraDamageRateSix, .05m);
        internal readonly Effect ExtraDamageRateSoul0045 = new(StaticEffectContext.ExtraDamageRateSoul, .045m);
        internal readonly Effect ExtraDamageRateSoul005 = new(StaticEffectContext.ExtraDamageRateSoul, .05m);
        internal readonly Effect Hp1500 = new(StaticEffectContext.Hp, 150);
        internal readonly Effect HpRate0015 = new(StaticEffectContext.HpRate, .015m);
        internal readonly Effect HpRate002 = new(StaticEffectContext.HpRate, .02m);
        internal readonly Effect HpRate00225 = new(StaticEffectContext.HpRate, .0225m);
        internal readonly Effect HpRate003 = new(StaticEffectContext.HpRate, .03m);
        internal readonly Effect HpRate00375 = new(StaticEffectContext.HpRate, .0375m);
        internal readonly Effect HpRate004 = new(StaticEffectContext.HpRate, .04m);
        internal readonly Effect HpRate0045 = new(StaticEffectContext.HpRate, .045m);
        internal readonly Effect HpRate00525 = new(StaticEffectContext.HpRate, .0525m);
        internal readonly Effect HpRate006 = new(StaticEffectContext.HpRate, .06m);
        internal readonly Effect HpRate00675 = new(StaticEffectContext.HpRate, .0675m);
        internal readonly Effect HpRate0075 = new(StaticEffectContext.HpRate, .075m);
        internal readonly Effect HpRate00825 = new(StaticEffectContext.HpRate, .0825m);
        internal readonly Effect HpRate00975 = new(StaticEffectContext.HpRate, .0975m);
        internal readonly Effect HpRate01 = new(StaticEffectContext.HpRate, .10m);
        internal readonly Effect HpRate0105 = new(StaticEffectContext.HpRate, .105m);
        internal readonly Effect HpRate011 = new(StaticEffectContext.HpRate, .11m);
        internal readonly Effect HpRate01125 = new(StaticEffectContext.HpRate, .1125m);
        internal readonly Effect HpRate012 = new(StaticEffectContext.HpRate, .12m);
        internal readonly Effect HpRate015 = new(StaticEffectContext.HpRate, .15m);
        internal readonly Effect HpRateM0015 = new(StaticEffectContext.HpRate, -.015m);
        internal readonly Effect HpRateM0045 = new(StaticEffectContext.HpRate, -.045m);
        internal readonly Effect HpRateM005 = new(StaticEffectContext.HpRate, -.05m);
        internal readonly Effect HpRateM00525 = new(StaticEffectContext.HpRate, -.0525m);
        internal readonly Effect HpRateM006 = new(StaticEffectContext.HpRate, -.06m);
        internal readonly Effect HpRateM00675 = new(StaticEffectContext.HpRate, -.0675m);
        internal readonly Effect KillHpRecovery29_7 = new(StaticEffectContext.KillHpRecovery, 29.7m);
        internal readonly Effect KillHpRecovery33 = new(StaticEffectContext.KillHpRecovery, 33);
        internal readonly Effect KillHpRecovery36_3 = new(StaticEffectContext.KillHpRecovery, 36.3m);
        internal readonly Effect KillHpRecovery39_6 = new(StaticEffectContext.KillHpRecovery, 39.6m);
        internal readonly Effect KillHpRecovery42_9 = new(StaticEffectContext.KillHpRecovery, 42.9m);
        internal readonly Effect KillHpRecovery46_2 = new(StaticEffectContext.KillHpRecovery, 46.2m);
        internal readonly Effect KillHpRecovery49_5 = new(StaticEffectContext.KillHpRecovery, 49.5m);
        internal readonly Effect MoneyVolumeRateEnemy003 = new(StaticEffectContext.MoneyVolumeRateEnemy, .03m);
        internal readonly Effect MoneyVolumeRateEnemy00375 = new(StaticEffectContext.MoneyVolumeRateEnemy, .0375m);
        internal readonly Effect MoneyVolumeRateEnemy0045 = new(StaticEffectContext.MoneyVolumeRateEnemy, .045m);
        internal readonly Effect MoneyVolumeRateEnemy00525 = new(StaticEffectContext.MoneyVolumeRateEnemy, .0525m);
        internal readonly Effect MoneyVolumeRateEnemy006 = new(StaticEffectContext.MoneyVolumeRateEnemy, .06m);
        internal readonly Effect MoneyVolumeRateEnemy0075 = new(StaticEffectContext.MoneyVolumeRateEnemy, .075m);
        internal readonly Effect MoneyVolumeRateEnemy009 = new(StaticEffectContext.MoneyVolumeRateEnemy, .09m);
        internal readonly Effect MoveSpaceRate001 = new(StaticEffectContext.MoveSpaceRate, .01m);
        internal readonly Effect MoveSpaceRate002 = new(StaticEffectContext.MoveSpaceRate, .02m);
        internal readonly Effect MoveSpaceRate003 = new(StaticEffectContext.MoveSpaceRate, .03m);
        internal readonly Effect MoveSpaceRate004 = new(StaticEffectContext.MoveSpaceRate, .04m);
        internal readonly Effect MoveSpaceRate005 = new(StaticEffectContext.MoveSpaceRate, .05m);
        internal readonly Effect MoveSpaceRateM001 = new(StaticEffectContext.MoveSpaceRate, -.01m);
        internal readonly Effect MoveSpaceRateM005 = new(StaticEffectContext.MoveSpaceRate, -.05m);
        internal readonly Effect SGateReducedRate003 = new(StaticEffectContext.SoulGateConsumptionReducedRate, .03m);
        internal readonly Effect SoulNovaVolumeRate003 = new(StaticEffectContext.SoulNovaVolumeRate, .03m);
        internal readonly Effect Stamina4 = new(StaticEffectContext.Stamina, 4);
        internal readonly Effect Stamina5 = new(StaticEffectContext.Stamina, 5);
        internal readonly Effect Stamina6 = new(StaticEffectContext.Stamina, 6);
        internal readonly Effect Stamina7 = new(StaticEffectContext.Stamina, 7);
        internal readonly Effect Stamina8 = new(StaticEffectContext.Stamina, 8);
        internal readonly Effect Stamina9 = new(StaticEffectContext.Stamina, 9);
        internal readonly Effect Stamina11 = new(StaticEffectContext.Stamina, 11);
        internal readonly Effect Stamina12 = new(StaticEffectContext.Stamina, 12);
        internal readonly Effect SuperArmorBreakPowerRate001 = new(StaticEffectContext.SuperArmorBreakPowerRate, .01m);

        internal readonly Effect SuperArmorBreakPowerRate0015 =
            new(StaticEffectContext.SuperArmorBreakPowerRate, .015m);

        internal readonly Effect SuperArmorBreakPowerRate002 = new(StaticEffectContext.SuperArmorBreakPowerRate, .02m);

        internal readonly Effect SuperArmorBreakPowerRate0025 =
            new(StaticEffectContext.SuperArmorBreakPowerRate, .025m);

        internal readonly Effect SuperArmorBreakPowerRate003 = new(StaticEffectContext.SuperArmorBreakPowerRate, .03m);

        internal readonly Effect SuperArmorBreakPowerRate0035 =
            new(StaticEffectContext.SuperArmorBreakPowerRate, .035m);

        internal readonly Effect SuperArmorBreakPowerRate004 = new(StaticEffectContext.SuperArmorBreakPowerRate, .04m);

        internal readonly Effect SuperArmorBreakPowerRate0045 =
            new(StaticEffectContext.SuperArmorBreakPowerRate, .045m);

        internal readonly Effect SuperArmorBreakPowerRate005 = new(StaticEffectContext.SuperArmorBreakPowerRate, .05m);
        internal readonly Effect SuperArmorBreakPowerRate006 = new(StaticEffectContext.SuperArmorBreakPowerRate, .06m);
        internal readonly Effect SuperArmorBreakPowerRate007 = new(StaticEffectContext.SuperArmorBreakPowerRate, .07m);
        internal readonly Effect SuperArmorBreakPowerRate008 = new(StaticEffectContext.SuperArmorBreakPowerRate, .08m);
        internal readonly Effect SuperArmorBreakPowerRate009 = new(StaticEffectContext.SuperArmorBreakPowerRate, .09m);
        internal readonly Effect SuperArmorBreakPowerRate01  = new(StaticEffectContext.SuperArmorBreakPowerRate, .1m);

        internal readonly Effect[] ArrayDefenseRate00135 = {new(StaticEffectContext.DefenseRate, .0135m)};
        internal          Effect[] ArrayAttackRate00135      { get; }
        internal          Effect[] ArrayHpRate00225          { get; }
        internal          Effect[] ArrayStamina5_HpRateM0015 { get; }

        internal ShareEffect()
        {
            ArrayHpRate00225          = new[] {HpRate00225};
            ArrayStamina5_HpRateM0015 = new[] {Stamina5, HpRateM0015};
            ArrayAttackRate00135      = new[] {AttackRate00135};
        }
        // ReSharper restore InconsistentNaming
    }
}