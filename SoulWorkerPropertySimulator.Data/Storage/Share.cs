// ReSharper disable once CheckNamespace

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class ShareEffect
    {
        internal static readonly EffectContext AccuracyOAvoidP3D5  = new(Property.Accuracy, Opportunity.Avoid, .3m, 5);
        internal static readonly EffectContext AccuracyOSufferP3D5 = new(Property.Accuracy, Opportunity.Suffer, .3m, 5);

        internal static readonly EffectContext AccuracyOUseSkillP1D5 =
            new(Property.Accuracy, Opportunity.UseSkill, .1m, 5);

        internal static readonly EffectContext AttackOAvoidP3D5 = new(Property.Attack, Opportunity.Avoid, .3m, 5);

        internal static readonly EffectContext AttackOCriticalHitP1D5 =
            new(Property.Attack, Opportunity.CriticalHit, .1m, 5);

        internal static readonly EffectContext AttackOHitP1D5 = new(Property.Attack, Opportunity.Hit, .1m, 5);
        internal static readonly EffectContext AttackOKillD5 = new(Property.Attack, Opportunity.Kill, duration: 5);
        internal static readonly EffectContext AttackORunP3D5 = new(Property.Attack, Opportunity.Run, .3m, 5);
        internal static readonly EffectContext AttackOSufferP3D5 = new(Property.Attack, Opportunity.Suffer, .3m, 5);
        internal static readonly EffectContext AttackOUseItemP2D5 = new(Property.Attack, Opportunity.UseItem, .2m, 5);
        internal static readonly EffectContext AttackOUseSkillP1D5 = new(Property.Attack, Opportunity.UseSkill, .1m, 5);
        internal static readonly EffectContext AttackRateOAvoid = new(Property.AttackRate, Opportunity.Avoid);
        internal static readonly EffectContext AttackRateOHitP1D5 = new(Property.AttackRate, Opportunity.Hit, .1m, 5);
        internal static readonly EffectContext AttackRateOHitP3D3 = new(Property.AttackRate, Opportunity.Hit, .3m, 3);
        internal static readonly EffectContext AttackSpeedRateOAvoid = new(Property.AttackRateNext, Opportunity.Avoid);

        internal static readonly EffectContext AttackSpeedRateOCriticalHitP1D2 =
            new(Property.AttackSpeedRate, Opportunity.CriticalHit, .1m, 2);

        internal static readonly EffectContext AttackSpeedRateOSufferCriticalP5D2 =
            new(Property.AttackSpeedRate, Opportunity.SufferCritical, .5m, 2);

        internal static readonly EffectContext AttackSpeedRateOSufferP3D15M =
            new(Property.AttackSpeedRate, Opportunity.Suffer, .3m, 1.5m);

        internal static readonly EffectContext CooldownShorterRateOUseSkillP2 =
            new(Property.CooldownShorterRate, Opportunity.UseSkill, .2m);

        internal static readonly EffectContext CriticalDamageOAvoidP3D5 =
            new(Property.CriticalDamage, Opportunity.Avoid, .3m, 5);

        internal static readonly EffectContext CriticalDamageOCriticalD3 =
            new(Property.CriticalDamage, Opportunity.Critical, duration: 3);

        internal static readonly EffectContext CriticalDamageOCriticalHitP1D2 =
            new(Property.CriticalDamage, Opportunity.CriticalHit, .1m, 2);

        internal static readonly EffectContext CriticalDamageOhp30DownThenHitD3 =
            new(Property.CriticalDamage, Opportunity.Hp30DownThenHit, duration: 3);

        internal static readonly EffectContext CriticalDamageORunP2D3 =
            new(Property.CriticalDamage, Opportunity.Run, .2m, 3);

        internal static readonly EffectContext CriticalDamageOSufferCriticalP5D2 =
            new(Property.CriticalDamage, Opportunity.SufferCritical, .5m, 2);

        internal static readonly EffectContext CriticalDamageOSufferP3D5 =
            new(Property.CriticalDamage, Opportunity.Suffer, .3m, 5);

        internal static readonly EffectContext CriticalDamageOSufferP5D3 =
            new(Property.CriticalDamage, Opportunity.Suffer, .5m, 3);

        internal static readonly EffectContext CriticalDamageOSufferStamina50UpD5 =
            new(Property.CriticalDamage, Opportunity.SufferStamina50Up, duration: 5);

        internal static readonly EffectContext CriticalDamageOUseAvoidP1D5 =
            new(Property.CriticalDamage, Opportunity.UseAvoid, .1m, 5);

        internal static readonly EffectContext CriticalDamageOUseItemP2D5 =
            new(Property.CriticalDamage, Opportunity.UseItem, .2m, 5);

        internal static readonly EffectContext CriticalDamageOUseSkillP3D5 =
            new(Property.CriticalDamage, Opportunity.UseSkill, .3m, 5);

        internal static readonly EffectContext CriticalDamageOUseSkillP5D5 =
            new(Property.CriticalDamage, Opportunity.UseSkill, .5m, 5);

        internal static readonly EffectContext CriticalRateOAvoidP3D2 =
            new(Property.CriticalRate, Opportunity.Avoid, .3m, 2);

        internal static readonly EffectContext CriticalRateORunP3D5 =
            new(Property.CriticalRate, Opportunity.Run, .3m, 5);

        internal static readonly EffectContext CriticalRateOUseAvoidP1D5 =
            new(Property.CriticalRate, Opportunity.UseAvoid, .1m, 5);

        internal static readonly EffectContext CriticalRateOUseSkillP5D5 =
            new(Property.CriticalRate, Opportunity.UseSkill, .5m, 5);

        internal static readonly EffectContext CriticalResistanceRateOHp50DownD10 =
            new(Property.CriticalResistanceRate, Opportunity.Hp50Down, duration: 10);

        internal static readonly EffectContext CriticalResistanceRateOSufferP8D10 =
            new(Property.CriticalResistanceRate, Opportunity.Suffer, .8m, 10);

        internal static readonly EffectContext DamageReductionRateOAirHitD5 =
            new(Property.DamageReductionRate, Opportunity.AirHit, duration: 5);

        internal static readonly EffectContext DamageReductionRateOAirSufferD5 =
            new(Property.DamageReductionRate, Opportunity.AirSuffer, duration: 5);

        internal static readonly EffectContext DamageReductionRateOAvoidD5 =
            new(Property.DamageReductionRate, Opportunity.Avoid, duration: 5);

        internal static readonly EffectContext DamageReductionRateOFallD5 =
            new(Property.DamageReductionRate, Opportunity.Fall, duration: 5);

        internal static readonly EffectContext DamageReductionRateOFallSufferD5 =
            new(Property.DamageReductionRate, Opportunity.FallSuffer, duration: 5);

        internal static readonly EffectContext DamageReductionRateOKillD5 =
            new(Property.DamageReductionRate, Opportunity.Kill, duration: 5);

        internal static readonly EffectContext DamageReductionRateOSufferBossP1D5 =
            new(Property.DamageReductionRate, Opportunity.SufferBoss, .1m, 5);

        internal static readonly EffectContext DefenseBreakRateOCriticalP3D5 =
            new(Property.DefenseBreakRate, Opportunity.Critical, .3m, 5);

        internal static readonly EffectContext DefenseBreakRateOCriticalP5D3 =
            new(Property.DefenseBreakRate, Opportunity.Critical, .5m, 3);

        internal static readonly EffectContext DefenseBreakRateOKillD5 =
            new(Property.DefenseBreakRate, Opportunity.Kill, duration: 5);

        internal static readonly EffectContext DefenseBreakRateORunP1D5 =
            new(Property.DefenseBreakRate, Opportunity.Run, .1m, 5);

        internal static readonly EffectContext DefenseOHp50DownD10 =
            new(Property.Defense, Opportunity.Hp50Down, duration: 10);

        internal static readonly EffectContext DefenseOKillD5 = new(Property.Defense, Opportunity.Kill, duration: 5);
        internal static readonly EffectContext DefenseORunP1D5 = new(Property.Defense, Opportunity.Run, .1m, 5);
        internal static readonly EffectContext DefenseOSufferP5D10 = new(Property.Defense, Opportunity.Suffer, .5m, 10);

        internal static readonly EffectContext DefenseOUseSkillP1D5 =
            new(Property.Defense, Opportunity.UseSkill, .1m, 5);

        internal static readonly EffectContext DefenseRateOSufferHp50DownP1D5 =
            new(Property.DefenseRate, Opportunity.SufferHp50Down, .1m, 5);

        internal static readonly EffectContext DefenseRateOSufferP15D5 =
            new(Property.DefenseRate, Opportunity.Suffer, .15m, 5);

        internal static readonly EffectContext EvadeOSufferP15D3 = new(Property.Evade, Opportunity.Suffer, .15m, 3);

        internal static readonly EffectContext EndureSecondOSufferP2 =
            new(Property.EndureSecond, Opportunity.Suffer, .2m);

        internal static readonly EffectContext EvadeOSufferP4D3   = new(Property.Evade, Opportunity.Suffer, .4m, 3);
        internal static readonly EffectContext HpRecoveryOAvoidP1 = new(Property.HpRecovery, Opportunity.Avoid, .1m);
        internal static readonly EffectContext HpRecoveryOHitP15  = new(Property.HpRecovery, Opportunity.Hit, .15m);
        internal static readonly EffectContext HpRecoveryOKill    = new(Property.HpRecovery, Opportunity.Kill);

        internal static readonly EffectContext HpRecoveryOSufferCriticalD50 =
            new(Property.HpRecovery, Opportunity.SufferCritical, duration: 50);

        internal static readonly EffectContext HpRecoveryOSufferP3 = new(Property.HpRecovery, Opportunity.Suffer, .3m);

        internal static readonly EffectContext HpRecoveryOSufferStamina50Up =
            new(Property.HpRecovery, Opportunity.SufferStamina50Up);

        internal static readonly EffectContext HpRecoveryRateOUseAvoidP1 =
            new(Property.HpRecoveryRate, Opportunity.UseAvoid, .1m);

        internal static readonly EffectContext InvincibleSecondOHp20DownP1 =
            new(Property.InvincibleSecond, Opportunity.Hp20Down, .1m);

        internal static readonly EffectContext MoveSpaceRateORunP15D5 =
            new(Property.MoveSpaceRate, Opportunity.Run, .15m, 5);

        internal static readonly EffectContext MoveSpaceRateOSufferP2D6 =
            new(Property.MoveSpaceRate, Opportunity.Suffer, .2m, 6);

        internal static readonly EffectContext PartialDamageRateOAvoidP1D10 =
            new(Property.PartialDamageRate, Opportunity.Avoid, .1m, 10);

        internal static readonly EffectContext PartialDamageRateOAvoidP3D5 =
            new(Property.PartialDamageRate, Opportunity.Avoid, .3m, 5);

        internal static readonly EffectContext PartialDamageRateOSufferP3D5 =
            new(Property.PartialDamageRate, Opportunity.Suffer, .3m, 5);

        internal static readonly EffectContext SoulGateRecoveryRateOUseSkillP1 =
            new(Property.SoulGateRecoveryRate, Opportunity.UseSkill, .1m);

        internal static readonly EffectContext StaminaRecoveryOHitP2 =
            new(Property.StaminaRecovery, Opportunity.Hit, .2m);

        internal static readonly EffectContext SuperArmorBreakPowerRateOAvoidP3D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Avoid, .3m, 5);

        internal static readonly EffectContext SuperArmorBreakPowerRateOHitP5D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Hit, .5m, 5);

        internal static readonly EffectContext SuperArmorBreakPowerRateOKillD5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Kill, duration: 5);

        internal static readonly EffectContext SuperArmorBreakPowerRateORunP1D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Run, .1m, 5);

        internal static readonly EffectContext SuperArmorBreakPowerRateOSufferP3D5 =
            new(Property.SuperArmorBreakPowerRate, Opportunity.Suffer, .3m, 5);

        internal static readonly Effect Accuracy28_2                 = new(Static.Accuracy, 28.2m);
        internal static readonly Effect Accuracy42_3                 = new(Static.Accuracy, 42.3m);
        internal static readonly Effect Accuracy47                   = new(Static.Accuracy, 47);
        internal static readonly Effect Accuracy50                   = new(Static.Accuracy, 50);
        internal static readonly Effect Accuracy51_7                 = new(Static.Accuracy, 51.7m);
        internal static readonly Effect Accuracy56_4                 = new(Static.Accuracy, 56.4m);
        internal static readonly Effect Accuracy60                   = new(Static.Accuracy, 60);
        internal static readonly Effect Accuracy65_8                 = new(Static.Accuracy, 65.8m);
        internal static readonly Effect Accuracy69                   = new(Static.Accuracy, 69);
        internal static readonly Effect Accuracy70_5                 = new(Static.Accuracy, 70.5m);
        internal static readonly Effect Accuracy79_9                 = new(Static.Accuracy, 79.9m);
        internal static readonly Effect Accuracy80                   = new(Static.Accuracy, 80);
        internal static readonly Effect Accuracy90                   = new(Static.Accuracy, 90);
        internal static readonly Effect AccuracyM25                  = new(Static.Accuracy, -25);
        internal static readonly Effect AccuracyM30                  = new(Static.Accuracy, -30);
        internal static readonly Effect AccuracyM45                  = new(Static.Accuracy, -45);
        internal static readonly Effect Attack60                     = new(Static.Attack, 60);
        internal static readonly Effect Attack120                    = new(Static.Attack, 120);
        internal static readonly Effect Attack240                    = new(Static.Attack, 240);
        internal static readonly Effect Attack420                    = new(Static.Attack, 420);
        internal static readonly Effect Attack600                    = new(Static.Attack, 600);
        internal static readonly Effect AttackRate00135              = new(Static.AttackRate, .0135m);
        internal static readonly Effect AttackRate0018               = new(Static.AttackRate, .018m);
        internal static readonly Effect AttackRate00225              = new(Static.AttackRate, .0225m);
        internal static readonly Effect AttackRate0027               = new(Static.AttackRate, .027m);
        internal static readonly Effect AttackRate00315              = new(Static.AttackRate, .0315m);
        internal static readonly Effect AttackRate0036               = new(Static.AttackRate, .036m);
        internal static readonly Effect AttackRate00405              = new(Static.AttackRate, .0405m);
        internal static readonly Effect AttackRate0045               = new(Static.AttackRate, .045m);
        internal static readonly Effect AttackRate005                = new(Static.AttackRate, .05m);
        internal static readonly Effect AttackRate0054               = new(Static.AttackRate, .054m);
        internal static readonly Effect AttackRate00675              = new(Static.AttackRate, .0675m);
        internal static readonly Effect AttackRate00765              = new(Static.AttackRate, .0765m);
        internal static readonly Effect AttackRate0081               = new(Static.AttackRate, .081m);
        internal static readonly Effect AttackRate00855              = new(Static.AttackRate, .0855m);
        internal static readonly Effect AttackRate009                = new(Static.AttackRate, .09m);
        internal static readonly Effect AttackRate019                = new(Static.AttackRate, .19m);
        internal static readonly Effect AttackRate024                = new(Static.AttackRate, .24m);
        internal static readonly Effect AttackRate028                = new(Static.AttackRate, .28m);
        internal static readonly Effect AttackRate033                = new(Static.AttackRate, .33m);
        internal static readonly Effect AttackRate038                = new(Static.AttackRate, .38m);
        internal static readonly Effect AttackRateM00135             = new(Static.AttackRate, -.0135m);
        internal static readonly Effect AttackRateM00225             = new(Static.AttackRate, -.0225m);
        internal static readonly Effect AttackRateOriginal018        = new(Static.AttackRateOriginal, .18m);
        internal static readonly Effect AttackRateOriginal036        = new(Static.AttackRateOriginal, .36m);
        internal static readonly Effect AttackSpeedRate001           = new(Static.AttackSpeedRate, .01m);
        internal static readonly Effect AttackSpeedRate002           = new(Static.AttackSpeedRate, .02m);
        internal static readonly Effect AttackSpeedRate0025          = new(Static.AttackSpeedRate, .025m);
        internal static readonly Effect AttackSpeedRate003           = new(Static.AttackSpeedRate, .03m);
        internal static readonly Effect AttackSpeedRate0035          = new(Static.AttackSpeedRate, .035m);
        internal static readonly Effect AttackSpeedRate004           = new(Static.AttackSpeedRate, .04m);
        internal static readonly Effect AttackSpeedRate005           = new(Static.AttackSpeedRate, .05m);
        internal static readonly Effect AttackSpeedRateM001          = new(Static.AttackSpeedRate, -.01m);
        internal static readonly Effect AttackSpeedRateM003          = new(Static.AttackSpeedRate, -.03m);
        internal static readonly Effect AttackSpeedRateM0035         = new(Static.AttackSpeedRate, -.035m);
        internal static readonly Effect CooldownShorterRate002       = new(Static.CooldownShorterRate, .02m);
        internal static readonly Effect CriticalDamage90             = new(Static.CriticalDamage, 90);
        internal static readonly Effect CriticalDamage140            = new(Static.CriticalDamage, 140);
        internal static readonly Effect CriticalDamage180            = new(Static.CriticalDamage, 180);
        internal static readonly Effect CriticalDamage258            = new(Static.CriticalDamage, 258);
        internal static readonly Effect CriticalDamage270            = new(Static.CriticalDamage, 240);
        internal static readonly Effect CriticalDamage280            = new(Static.CriticalDamage, 280);
        internal static readonly Effect CriticalDamage323            = new(Static.CriticalDamage, 323);
        internal static readonly Effect CriticalDamage387            = new(Static.CriticalDamage, 387);
        internal static readonly Effect CriticalDamage420            = new(Static.CriticalDamage, 420);
        internal static readonly Effect CriticalDamage452            = new(Static.CriticalDamage, 452);
        internal static readonly Effect CriticalDamage480            = new(Static.CriticalDamage, 480);
        internal static readonly Effect CriticalDamage560            = new(Static.CriticalDamage, 560);
        internal static readonly Effect CriticalDamage645            = new(Static.CriticalDamage, 645);
        internal static readonly Effect CriticalDamage700            = new(Static.CriticalDamage, 700);
        internal static readonly Effect CriticalDamage710            = new(Static.CriticalDamage, 710);
        internal static readonly Effect CriticalDamage720            = new(Static.CriticalDamage, 720);
        internal static readonly Effect CriticalDamage774            = new(Static.CriticalDamage, 774);
        internal static readonly Effect CriticalDamage968            = new(Static.CriticalDamage, 968);
        internal static readonly Effect CriticalDamage1097           = new(Static.CriticalDamage, 1_097);
        internal static readonly Effect CriticalRate001              = new(Static.CriticalRate, .01m);
        internal static readonly Effect CriticalRate002              = new(Static.CriticalRate, .02m);
        internal static readonly Effect CriticalRate0025             = new(Static.CriticalRate, .025m);
        internal static readonly Effect CriticalRate003              = new(Static.CriticalRate, .03m);
        internal static readonly Effect CriticalRate0035             = new(Static.CriticalRate, .035m);
        internal static readonly Effect CriticalRate004              = new(Static.CriticalRate, .04m);
        internal static readonly Effect CriticalRate005              = new(Static.CriticalRate, .05m);
        internal static readonly Effect CriticalResistanceRate0015   = new(Static.CriticalResistanceRate, .015m);
        internal static readonly Effect CriticalResistanceRate002    = new(Static.CriticalResistanceRate, .02m);
        internal static readonly Effect CriticalResistanceRate0025   = new(Static.CriticalResistanceRate, .025m);
        internal static readonly Effect CriticalResistanceRate003    = new(Static.CriticalResistanceRate, .03m);
        internal static readonly Effect CriticalResistanceRate0035   = new(Static.CriticalResistanceRate, .035m);
        internal static readonly Effect CriticalResistanceRate004    = new(Static.CriticalResistanceRate, .04m);
        internal static readonly Effect DamageReductionRate002       = new(Static.DamageReductionRate, .02m);
        internal static readonly Effect DamageReductionRate003       = new(Static.DamageReductionRate, .03m);
        internal static readonly Effect DamageReductionRate004       = new(Static.DamageReductionRate, .04m);
        internal static readonly Effect DamageReductionRate005       = new(Static.DamageReductionRate, .05m);
        internal static readonly Effect DamageReductionRateBasic002  = new(Static.DamageReductionRateBasic, .02m);
        internal static readonly Effect DamageReductionRateBasic0025 = new(Static.DamageReductionRateBasic, .025m);
        internal static readonly Effect DamageReductionRateBasic003  = new(Static.DamageReductionRateBasic, .03m);
        internal static readonly Effect DamageReductionRateBoss003   = new(Static.DamageReductionRateBoss, .03m);
        internal static readonly Effect DamageReductionRateBoss0035  = new(Static.DamageReductionRateBoss, .035m);
        internal static readonly Effect DamageReductionRateBoss005   = new(Static.DamageReductionRateBoss, .05m);
        internal static readonly Effect DamageReductionRateFlame0025 = new(Static.DamageReductionRateFlame, .025m);
        internal static readonly Effect DamageReductionRateNed0025   = new(Static.DamageReductionRateNed, .025m);
        internal static readonly Effect DamageReductionRatePvP0025   = new(Static.DamageReductionRatePvP, .025m);
        internal static readonly Effect DamageReductionRateSix005    = new(Static.DamageReductionRateSix, .05m);
        internal static readonly Effect DamageReductionRateSoul0045  = new(Static.DamageReductionRateSoul, .045m);
        internal static readonly Effect DamageReductionRateSoul005   = new(Static.DamageReductionRateSoul, .05m);
        internal static readonly Effect Defense72                    = new(Static.Defense, 72);
        internal static readonly Effect Defense144                   = new(Static.Defense, 144);
        internal static readonly Effect Defense312                   = new(Static.Defense, 312);
        internal static readonly Effect Defense480                   = new(Static.Defense, 480);
        internal static readonly Effect Defense720                   = new(Static.Defense, 720);
        internal static readonly Effect DefenseBreakRate001          = new(Static.DefenseBreakRate, .01m);
        internal static readonly Effect DefenseBreakRate002          = new(Static.DefenseBreakRate, .02m);
        internal static readonly Effect DefenseBreakRate003          = new(Static.DefenseBreakRate, .03m);
        internal static readonly Effect DefenseBreakRate004          = new(Static.DefenseBreakRate, .04m);
        internal static readonly Effect DefenseBreakRate005          = new(Static.DefenseBreakRate, .05m);
        internal static readonly Effect DefenseRate0018              = new(Static.DefenseRate, .018m);
        internal static readonly Effect DefenseRate00225             = new(Static.DefenseRate, .0225m);
        internal static readonly Effect DefenseRate0027              = new(Static.DefenseRate, .027m);
        internal static readonly Effect DefenseRate00315             = new(Static.DefenseRate, .0315m);
        internal static readonly Effect DefenseRate0036              = new(Static.DefenseRate, .036m);
        internal static readonly Effect DefenseRate00405             = new(Static.DefenseRate, .0405m);
        internal static readonly Effect DefenseRate0045              = new(Static.DefenseRate, .045m);
        internal static readonly Effect DefenseRate00495             = new(Static.DefenseRate, .0495m);
        internal static readonly Effect DefenseRate0054              = new(Static.DefenseRate, .054m);
        internal static readonly Effect DefenseRate00585             = new(Static.DefenseRate, .0585m);
        internal static readonly Effect DefenseRate00675             = new(Static.DefenseRate, .0675m);
        internal static readonly Effect DefenseRate0072              = new(Static.DefenseRate, .072m);
        internal static readonly Effect DefenseRate00765             = new(Static.DefenseRate, .0765m);
        internal static readonly Effect DefenseRateM0018             = new(Static.DefenseRate, -.018m);
        internal static readonly Effect DefenseRateM00225            = new(Static.DefenseRate, -.0225m);
        internal static readonly Effect DefenseRateM0027             = new(Static.DefenseRate, -.027m);
        internal static readonly Effect DefenseRateM003              = new(Static.DefenseRate, -.03m);
        internal static readonly Effect DefenseRateM005              = new(Static.DefenseRate, -.05m);
        internal static readonly Effect Evade21                      = new(Static.Evade, 21);
        internal static readonly Effect Evade27                      = new(Static.Evade, 27);
        internal static readonly Effect Evade32                      = new(Static.Evade, 32);
        internal static readonly Effect Evade37                      = new(Static.Evade, 37);
        internal static readonly Effect Evade42                      = new(Static.Evade, 42);
        internal static readonly Effect Evade43                      = new(Static.Evade, 43);
        internal static readonly Effect Evade64                      = new(Static.Evade, 64);
        internal static readonly Effect Evade70                      = new(Static.Evade, 70);
        internal static readonly Effect Evade80                      = new(Static.Evade, 80);
        internal static readonly Effect Evade91                      = new(Static.Evade, 91);
        internal static readonly Effect EvadeM30                     = new(Static.Evade, -30);
        internal static readonly Effect EvadeM38                     = new(Static.Evade, -38);
        internal static readonly Effect EvadeM45                     = new(Static.Evade, -45);
        internal static readonly Effect EvadeM50                     = new(Static.Evade, -50);
        internal static readonly Effect ExpVolumeRateEnemy00525      = new(Static.ExpVolumeRateEnemy, .0525m);
        internal static readonly Effect ExpVolumeRateEnemy0075       = new(Static.ExpVolumeRateEnemy, .075m);
        internal static readonly Effect ExpVolumeRateEnemy009        = new(Static.ExpVolumeRateEnemy, .09m);
        internal static readonly Effect ExtraDamageRateBasic002      = new(Static.ExtraDamageRateBasic, .02m);
        internal static readonly Effect ExtraDamageRateBasic0025     = new(Static.ExtraDamageRateBasic, .025m);
        internal static readonly Effect ExtraDamageRateBasic003      = new(Static.ExtraDamageRateBasic, .03m);
        internal static readonly Effect ExtraDamageRateBoss002       = new(Static.ExtraDamageRateBoss, .02m);
        internal static readonly Effect ExtraDamageRateBoss0025      = new(Static.ExtraDamageRateBoss, .025m);
        internal static readonly Effect ExtraDamageRateBoss003       = new(Static.ExtraDamageRateBoss, .03m);
        internal static readonly Effect ExtraDamageRateBoss0035      = new(Static.ExtraDamageRateBoss, .035m);
        internal static readonly Effect ExtraDamageRateBoss0045      = new(Static.ExtraDamageRateBoss, .045m);
        internal static readonly Effect ExtraDamageRateBoss005       = new(Static.ExtraDamageRateBoss, .05m);
        internal static readonly Effect ExtraDamageRateFall004       = new(Static.ExtraDamageRateFall, .04m);
        internal static readonly Effect ExtraDamageRateFall008       = new(Static.ExtraDamageRateFall, .08m);
        internal static readonly Effect ExtraDamageRateFall012       = new(Static.ExtraDamageRateFall, .12m);
        internal static readonly Effect ExtraDamageRateFall016       = new(Static.ExtraDamageRateFall, .16m);
        internal static readonly Effect ExtraDamageRateFall02        = new(Static.ExtraDamageRateFall, .2m);
        internal static readonly Effect ExtraDamageRateFlame0025     = new(Static.ExtraDamageRateFlame, .025m);
        internal static readonly Effect ExtraDamageRateJunk0025      = new(Static.ExtraDamageRateJunk, .025m);
        internal static readonly Effect ExtraDamageRateSix005        = new(Static.ExtraDamageRateSix, .05m);
        internal static readonly Effect ExtraDamageRateSoul0045      = new(Static.ExtraDamageRateSoul, .045m);
        internal static readonly Effect ExtraDamageRateSoul005       = new(Static.ExtraDamageRateSoul, .05m);
        internal static readonly Effect Hp1500                       = new(Static.Hp, 150);
        internal static readonly Effect HpRate0015                   = new(Static.HpRate, .015m);
        internal static readonly Effect HpRate002                    = new(Static.HpRate, .02m);
        internal static readonly Effect HpRate00225                  = new(Static.HpRate, .0225m);
        internal static readonly Effect HpRate003                    = new(Static.HpRate, .03m);
        internal static readonly Effect HpRate00375                  = new(Static.HpRate, .0375m);
        internal static readonly Effect HpRate004                    = new(Static.HpRate, .04m);
        internal static readonly Effect HpRate0045                   = new(Static.HpRate, .045m);
        internal static readonly Effect HpRate00525                  = new(Static.HpRate, .0525m);
        internal static readonly Effect HpRate006                    = new(Static.HpRate, .06m);
        internal static readonly Effect HpRate00675                  = new(Static.HpRate, .0675m);
        internal static readonly Effect HpRate0075                   = new(Static.HpRate, .075m);
        internal static readonly Effect HpRate00825                  = new(Static.HpRate, .0825m);
        internal static readonly Effect HpRate00975                  = new(Static.HpRate, .0975m);
        internal static readonly Effect HpRate01                     = new(Static.HpRate, .10m);
        internal static readonly Effect HpRate0105                   = new(Static.HpRate, .105m);
        internal static readonly Effect HpRate011                    = new(Static.HpRate, .11m);
        internal static readonly Effect HpRate01125                  = new(Static.HpRate, .1125m);
        internal static readonly Effect HpRate012                    = new(Static.HpRate, .12m);
        internal static readonly Effect HpRate015                    = new(Static.HpRate, .15m);
        internal static readonly Effect HpRateM0015                  = new(Static.HpRate, -.015m);
        internal static readonly Effect HpRateM0045                  = new(Static.HpRate, -.045m);
        internal static readonly Effect HpRateM005                   = new(Static.HpRate, -.05m);
        internal static readonly Effect HpRateM00525                 = new(Static.HpRate, -.0525m);
        internal static readonly Effect HpRateM006                   = new(Static.HpRate, -.06m);
        internal static readonly Effect HpRateM00675                 = new(Static.HpRate, -.0675m);
        internal static readonly Effect KillHpRecovery29_7           = new(Static.KillHpRecovery, 29.7m);
        internal static readonly Effect KillHpRecovery33             = new(Static.KillHpRecovery, 33);
        internal static readonly Effect KillHpRecovery36_3           = new(Static.KillHpRecovery, 36.3m);
        internal static readonly Effect KillHpRecovery39_6           = new(Static.KillHpRecovery, 39.6m);
        internal static readonly Effect KillHpRecovery42_9           = new(Static.KillHpRecovery, 42.9m);
        internal static readonly Effect KillHpRecovery46_2           = new(Static.KillHpRecovery, 46.2m);
        internal static readonly Effect KillHpRecovery49_5           = new(Static.KillHpRecovery, 49.5m);
        internal static readonly Effect MoneyVolumeRateEnemy003      = new(Static.MoneyVolumeRateEnemy, .03m);
        internal static readonly Effect MoneyVolumeRateEnemy00375    = new(Static.MoneyVolumeRateEnemy, .0375m);
        internal static readonly Effect MoneyVolumeRateEnemy0045     = new(Static.MoneyVolumeRateEnemy, .045m);
        internal static readonly Effect MoneyVolumeRateEnemy00525    = new(Static.MoneyVolumeRateEnemy, .0525m);
        internal static readonly Effect MoneyVolumeRateEnemy006      = new(Static.MoneyVolumeRateEnemy, .06m);
        internal static readonly Effect MoneyVolumeRateEnemy0075     = new(Static.MoneyVolumeRateEnemy, .075m);
        internal static readonly Effect MoneyVolumeRateEnemy009      = new(Static.MoneyVolumeRateEnemy, .09m);
        internal static readonly Effect MoveSpaceRate001             = new(Static.MoveSpaceRate, .01m);
        internal static readonly Effect MoveSpaceRate002             = new(Static.MoveSpaceRate, .02m);
        internal static readonly Effect MoveSpaceRate003             = new(Static.MoveSpaceRate, .03m);
        internal static readonly Effect MoveSpaceRate004             = new(Static.MoveSpaceRate, .04m);
        internal static readonly Effect MoveSpaceRate005             = new(Static.MoveSpaceRate, .05m);
        internal static readonly Effect MoveSpaceRateM001            = new(Static.MoveSpaceRate, -.01m);
        internal static readonly Effect MoveSpaceRateM005            = new(Static.MoveSpaceRate, -.05m);
        internal static readonly Effect SGateReducedRate003          = new(Static.SoulGateConsumptionReducedRate, .03m);
        internal static readonly Effect SoulNovaVolumeRate003        = new(Static.SoulNovaVolumeRate, .03m);
        internal static readonly Effect Stamina4                     = new(Static.Stamina, 4);
        internal static readonly Effect Stamina5                     = new(Static.Stamina, 5);
        internal static readonly Effect Stamina6                     = new(Static.Stamina, 6);
        internal static readonly Effect Stamina7                     = new(Static.Stamina, 7);
        internal static readonly Effect Stamina8                     = new(Static.Stamina, 8);
        internal static readonly Effect Stamina9                     = new(Static.Stamina, 9);
        internal static readonly Effect Stamina11                    = new(Static.Stamina, 11);
        internal static readonly Effect Stamina12                    = new(Static.Stamina, 12);
        internal static readonly Effect SuperArmorBreakPowerRate001  = new(Static.SuperArmorBreakPowerRate, .01m);
        internal static readonly Effect SuperArmorBreakPowerRate0015 = new(Static.SuperArmorBreakPowerRate, .015m);
        internal static readonly Effect SuperArmorBreakPowerRate002  = new(Static.SuperArmorBreakPowerRate, .02m);
        internal static readonly Effect SuperArmorBreakPowerRate0025 = new(Static.SuperArmorBreakPowerRate, .025m);
        internal static readonly Effect SuperArmorBreakPowerRate003  = new(Static.SuperArmorBreakPowerRate, .03m);
        internal static readonly Effect SuperArmorBreakPowerRate0035 = new(Static.SuperArmorBreakPowerRate, .035m);
        internal static readonly Effect SuperArmorBreakPowerRate004  = new(Static.SuperArmorBreakPowerRate, .04m);
        internal static readonly Effect SuperArmorBreakPowerRate0045 = new(Static.SuperArmorBreakPowerRate, .045m);
        internal static readonly Effect SuperArmorBreakPowerRate005  = new(Static.SuperArmorBreakPowerRate, .05m);
        internal static readonly Effect SuperArmorBreakPowerRate006  = new(Static.SuperArmorBreakPowerRate, .06m);
        internal static readonly Effect SuperArmorBreakPowerRate007  = new(Static.SuperArmorBreakPowerRate, .07m);
        internal static readonly Effect SuperArmorBreakPowerRate008  = new(Static.SuperArmorBreakPowerRate, .08m);
        internal static readonly Effect SuperArmorBreakPowerRate009  = new(Static.SuperArmorBreakPowerRate, .09m);
        internal static readonly Effect SuperArmorBreakPowerRate01   = new(Static.SuperArmorBreakPowerRate, .1m);

        internal static readonly Effect[] ArrayHpRate00225          = {HpRate00225};
        internal static readonly Effect[] ArrayStamina5_HpRateM0015 = {Stamina5, HpRateM0015};
        internal static readonly Effect[] ArrayAttackRate00135      = {AttackRate00135};
        internal static readonly Effect[] ArrayDefenseRate00135     = {new(Static.DefenseRate, .0135m)};
    }
}