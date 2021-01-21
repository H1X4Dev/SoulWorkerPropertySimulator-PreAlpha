// ReSharper disable once CheckNamespace

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        private static readonly EffectContext AccuracyOAvoidP3D5  = new(Property.Accuracy, Ppportunity.Avoid, .3m, 5);
        private static readonly EffectContext AccuracyOSufferP3D5 = new(Property.Accuracy, Ppportunity.Suffer, .3m, 5);

        private static readonly EffectContext AccuracyOUseSkillP1D5 =
            new(Property.Accuracy, Ppportunity.UseSkill, .1m, 5);

        private static readonly EffectContext AttackOAvoidP3D5 = new(Property.Attack, Ppportunity.Avoid, .3m, 5);

        private static readonly EffectContext AttackOCriticalHitP1D5 =
            new(Property.Attack, Ppportunity.CriticalHit, .1m, 5);

        private static readonly EffectContext AttackOHitP1D5 = new(Property.Attack, Ppportunity.Hit, .1m, 5);
        private static readonly EffectContext AttackOKillD5 = new(Property.Attack, Ppportunity.Kill, duration: 5);
        private static readonly EffectContext AttackORunP3D5 = new(Property.Attack, Ppportunity.Run, .3m, 5);
        private static readonly EffectContext AttackOSufferP3D5 = new(Property.Attack, Ppportunity.Suffer, .3m, 5);
        private static readonly EffectContext AttackOUseItemP2D5 = new(Property.Attack, Ppportunity.UseItem, .2m, 5);
        private static readonly EffectContext AttackOUseSkillP1D5 = new(Property.Attack, Ppportunity.UseSkill, .1m, 5);
        private static readonly EffectContext AttackRateOAvoid = new(Property.AttackRate, Ppportunity.Avoid);
        private static readonly EffectContext AttackRateOHitP1D5 = new(Property.AttackRate, Ppportunity.Hit, .1m, 5);
        private static readonly EffectContext AttackRateOHitP3D3 = new(Property.AttackRate, Ppportunity.Hit, .3m, 3);
        private static readonly EffectContext AttackSpeedRateOAvoid = new(Property.AttackRateNext, Ppportunity.Avoid);

        private static readonly EffectContext AttackSpeedRateOCriticalHitP1D2 =
            new(Property.AttackSpeedRate, Ppportunity.CriticalHit, .1m, 2);

        private static readonly EffectContext AttackSpeedRateOSufferCriticalP5D2 =
            new(Property.AttackSpeedRate, Ppportunity.SufferCritical, .5m, 2);

        private static readonly EffectContext AttackSpeedRateOSufferP3D15M =
            new(Property.AttackSpeedRate, Ppportunity.Suffer, .3m, 1.5m);

        private static readonly EffectContext CooldownShorterRateOUseSkillP2 =
            new(Property.CooldownShorterRate, Ppportunity.UseSkill, .2m);

        private static readonly EffectContext CriticalDamageOAvoidP3D5 =
            new(Property.CriticalDamage, Ppportunity.Avoid, .3m, 5);

        private static readonly EffectContext CriticalDamageOCriticalD3 =
            new(Property.CriticalDamage, Ppportunity.Critical, duration: 3);

        private static readonly EffectContext CriticalDamageOCriticalHitP1D2 =
            new(Property.CriticalDamage, Ppportunity.CriticalHit, .1m, 2);

        private static readonly EffectContext CriticalDamageOhp30DownThenHitD3 =
            new(Property.CriticalDamage, Ppportunity.HP30DownThenHit, duration: 3);

        private static readonly EffectContext CriticalDamageORunP2D3 =
            new(Property.CriticalDamage, Ppportunity.Run, .2m, 3);

        private static readonly EffectContext CriticalDamageOSufferCriticalP5D2 =
            new(Property.CriticalDamage, Ppportunity.SufferCritical, .5m, 2);

        private static readonly EffectContext CriticalDamageOSufferP3D5 =
            new(Property.CriticalDamage, Ppportunity.Suffer, .3m, 5);

        private static readonly EffectContext CriticalDamageOSufferP5D3 =
            new(Property.CriticalDamage, Ppportunity.Suffer, .5m, 3);

        private static readonly EffectContext CriticalDamageOSufferStamina50UpD5 =
            new(Property.CriticalDamage, Ppportunity.SufferStamina50Up, duration: 5);

        private static readonly EffectContext CriticalDamageOUseAvoidP1D5 =
            new(Property.CriticalDamage, Ppportunity.UseAvoid, .1m, 5);

        private static readonly EffectContext CriticalDamageOUseItemP2D5 =
            new(Property.CriticalDamage, Ppportunity.UseItem, .2m, 5);

        private static readonly EffectContext CriticalDamageOUseSkillP3D5 =
            new(Property.CriticalDamage, Ppportunity.UseSkill, .3m, 5);

        private static readonly EffectContext CriticalDamageOUseSkillP5D5 =
            new(Property.CriticalDamage, Ppportunity.UseSkill, .5m, 5);

        private static readonly EffectContext CriticalRateOAvoidP3D2 =
            new(Property.CriticalRate, Ppportunity.Avoid, .3m, 2);

        private static readonly EffectContext
            CriticalRateORunP3D5 = new(Property.CriticalRate, Ppportunity.Run, .3m, 5);

        private static readonly EffectContext CriticalRateOUseAvoidP1D5 =
            new(Property.CriticalRate, Ppportunity.UseAvoid, .1m, 5);

        private static readonly EffectContext CriticalRateOUseSkillP5D5 =
            new(Property.CriticalRate, Ppportunity.UseSkill, .5m, 5);

        private static readonly EffectContext CriticalResistanceRateOHP50DownD10 =
            new(Property.CriticalResistanceRate, Ppportunity.HP50Down, duration: 10);

        private static readonly EffectContext CriticalResistanceRateOSufferP8D10 =
            new(Property.CriticalResistanceRate, Ppportunity.Suffer, .8m, 10);

        private static readonly EffectContext DamageReductionRateOAirHitD5 =
            new(Property.DamageReductionRate, Ppportunity.AirHit, duration: 5);

        private static readonly EffectContext DamageReductionRateOAirSufferD5 =
            new(Property.DamageReductionRate, Ppportunity.AirSuffer, duration: 5);

        private static readonly EffectContext DamageReductionRateOAvoidD5 =
            new(Property.DamageReductionRate, Ppportunity.Avoid, duration: 5);

        private static readonly EffectContext DamageReductionRateOFallD5 =
            new(Property.DamageReductionRate, Ppportunity.Fall, duration: 5);

        private static readonly EffectContext damageReductionRateOFallSufferD5 =
            new(Property.DamageReductionRate, Ppportunity.FallSuffer, duration: 5);

        private static readonly EffectContext DamageReductionRateOKillD5 =
            new(Property.DamageReductionRate, Ppportunity.Kill, duration: 5);

        private static readonly EffectContext DamageReductionRateOSufferBossP1D5 =
            new(Property.DamageReductionRate, Ppportunity.SufferBoss, .1m, 5);

        private static readonly EffectContext DefenseBreakRateOCriticalP3D5 =
            new(Property.DefenseBreakRate, Ppportunity.Critical, .3m, 5);

        private static readonly EffectContext DefenseBreakRateOCriticalP5D3 =
            new(Property.DefenseBreakRate, Ppportunity.Critical, .5m, 3);

        private static readonly EffectContext DefenseBreakRateOKillD5 =
            new(Property.DefenseBreakRate, Ppportunity.Kill, duration: 5);

        private static readonly EffectContext DefenseBreakRateORunP1D5 =
            new(Property.DefenseBreakRate, Ppportunity.Run, .1m, 5);

        private static readonly EffectContext DefenseOHp50DownD10 =
            new(Property.Defense, Ppportunity.HP50Down, duration: 10);

        private static readonly EffectContext DefenseOKillD5 = new(Property.Defense, Ppportunity.Kill, duration: 5);
        private static readonly EffectContext DefenseORunP1D5 = new(Property.Defense, Ppportunity.Run, .1m, 5);
        private static readonly EffectContext DefenseOSufferP5D10 = new(Property.Defense, Ppportunity.Suffer, .5m, 10);

        private static readonly EffectContext
            DefenseOUseSkillP1D5 = new(Property.Defense, Ppportunity.UseSkill, .1m, 5);

        private static readonly EffectContext DefenseRateOSufferHp50DownP1D5 =
            new(Property.DefenseRate, Ppportunity.SufferHP50Down, .1m, 5);

        private static readonly EffectContext DefenseRateOSufferP15D5 =
            new(Property.DefenseRate, Ppportunity.Suffer, .15m, 5);

        private static readonly EffectContext EvadeOSufferP15D3 = new(Property.Evade, Ppportunity.Suffer, .15m, 3);

        private static readonly EffectContext EndureSecondOSufferP2 =
            new(Property.EndureSecond, Ppportunity.Suffer, .2m);

        private static readonly EffectContext EvadeOSufferP4D3   = new(Property.Evade, Ppportunity.Suffer, .4m, 3);
        private static readonly EffectContext HpRecoveryOAvoidP1 = new(Property.HpRecovery, Ppportunity.Avoid, .1m);
        private static readonly EffectContext HpRecoveryOHitP15  = new(Property.HpRecovery, Ppportunity.Hit, .15m);
        private static readonly EffectContext HpRecoveryOKill    = new(Property.HpRecovery, Ppportunity.Kill);

        private static readonly EffectContext HpRecoveryOSufferCriticalD50 =
            new(Property.HpRecovery, Ppportunity.SufferCritical, duration: 50);

        private static readonly EffectContext HpRecoveryOSufferP3 = new(Property.HpRecovery, Ppportunity.Suffer, .3m);

        private static readonly EffectContext HpRecoveryOSufferStamina50Up =
            new(Property.HpRecovery, Ppportunity.SufferStamina50Up);

        private static readonly EffectContext HpRecoveryRateOUseAvoidP1 =
            new(Property.HpRecoveryRate, Ppportunity.UseAvoid, .1m);

        private static readonly EffectContext InvincibleSecondOHp20DownP1 =
            new(Property.InvincibleSecond, Ppportunity.HP20Down, .1m);

        private static readonly EffectContext MoveSpaceRateORunP15D5 =
            new(Property.MoveSpaceRate, Ppportunity.Run, .15m, 5);

        private static readonly EffectContext MoveSpaceRateOSufferP2D6 =
            new(Property.MoveSpaceRate, Ppportunity.Suffer, .2m, 6);

        private static readonly EffectContext PartialDamageRateOAvoidP1D10 =
            new(Property.PartialDamageRate, Ppportunity.Avoid, .1m, 10);

        private static readonly EffectContext PartialDamageRateOAvoidP3D5 =
            new(Property.PartialDamageRate, Ppportunity.Avoid, .3m, 5);

        private static readonly EffectContext PartialDamageRateOSufferP3D5 =
            new(Property.PartialDamageRate, Ppportunity.Suffer, .3m, 5);

        private static readonly EffectContext SoulGateRecoveryRateOUseSkillP1 =
            new(Property.SoulGateRecoveryRate, Ppportunity.UseSkill, .1m);

        private static readonly EffectContext StaminaRecoveryOHitP2 =
            new(Property.StaminaRecovery, Ppportunity.Hit, .2m);

        private static readonly EffectContext SuperArmorBreakPowerRateOAvoidP3D5 =
            new(Property.SuperArmorBreakPowerRate, Ppportunity.Avoid, .3m, 5);

        private static readonly EffectContext SuperArmorBreakPowerRateOHitP5D5 =
            new(Property.SuperArmorBreakPowerRate, Ppportunity.Hit, .5m, 5);

        private static readonly EffectContext SuperArmorBreakPowerRateOKillD5 =
            new(Property.SuperArmorBreakPowerRate, Ppportunity.Kill, duration: 5);

        private static readonly EffectContext SuperArmorBreakPowerRateORunP1D5 =
            new(Property.SuperArmorBreakPowerRate, Ppportunity.Run, .1m, 5);

        private static readonly EffectContext SuperArmorBreakPowerRateOSufferP3D5 =
            new(Property.SuperArmorBreakPowerRate, Ppportunity.Suffer, .3m, 5);

        private static readonly Effect Accuracy50                  = new(Static.Accuracy, 50);
        private static readonly Effect Accuracy60                  = new(Static.Accuracy, 60);
        private static readonly Effect Accuracy69                  = new(Static.Accuracy, 69);
        private static readonly Effect Accuracy80                  = new(Static.Accuracy, 80);
        private static readonly Effect Accuracy90                  = new(Static.Accuracy, 90);
        private static readonly Effect AccuracyM25                 = new(Static.Accuracy, -25);
        private static readonly Effect AccuracyM30                 = new(Static.Accuracy, -30);
        private static readonly Effect AccuracyM45                 = new(Static.Accuracy, -45);
        private static readonly Effect Attack120                   = new(Static.Attack, 120);
        private static readonly Effect Attack240                   = new(Static.Attack, 240);
        private static readonly Effect Attack420                   = new(Static.Attack, 420);
        private static readonly Effect Attack60                    = new(Static.Attack, 60);
        private static readonly Effect Attack600                   = new(Static.Attack, 600);
        private static readonly Effect AttackRate019               = new(Static.AttackRate, .19m);
        private static readonly Effect AttackRate024               = new(Static.AttackRate, .24m);
        private static readonly Effect AttackRate028               = new(Static.AttackRate, .28m);
        private static readonly Effect AttackRate033               = new(Static.AttackRate, .33m);
        private static readonly Effect AttackRate038               = new(Static.AttackRate, .38m);
        private static readonly Effect AttackRateOriginal018       = new(Static.AttackRateOriginal, .18m);
        private static readonly Effect AttackRateOriginal036       = new(Static.AttackRateOriginal, .36m);
        private static readonly Effect AttackSpeedRate001          = new(Static.AttackSpeedRate, .01m);
        private static readonly Effect AttackSpeedRate002          = new(Static.AttackSpeedRate, .02m);
        private static readonly Effect AttackSpeedRate003          = new(Static.AttackSpeedRate, .03m);
        private static readonly Effect AttackSpeedRate004          = new(Static.AttackSpeedRate, .04m);
        private static readonly Effect AttackSpeedRateM001         = new(Static.AttackSpeedRate, -.01m);
        private static readonly Effect CriticalDamage140           = new(Static.CriticalDamage, 140);
        private static readonly Effect CriticalDamage180           = new(Static.CriticalDamage, 180);
        private static readonly Effect CriticalDamage270           = new(Static.CriticalDamage, 240);
        private static readonly Effect CriticalDamage280           = new(Static.CriticalDamage, 280);
        private static readonly Effect CriticalDamage420           = new(Static.CriticalDamage, 420);
        private static readonly Effect CriticalDamage480           = new(Static.CriticalDamage, 480);
        private static readonly Effect CriticalDamage560           = new(Static.CriticalDamage, 560);
        private static readonly Effect CriticalDamage700           = new(Static.CriticalDamage, 700);
        private static readonly Effect CriticalDamage720           = new(Static.CriticalDamage, 720);
        private static readonly Effect CriticalDamage90            = new(Static.CriticalDamage, 90);
        private static readonly Effect CriticalRate001             = new(Static.CriticalRate, .01m);
        private static readonly Effect CriticalRate002             = new(Static.CriticalRate, .02m);
        private static readonly Effect CriticalRate003             = new(Static.CriticalRate, .03m);
        private static readonly Effect CriticalRate004             = new(Static.CriticalRate, .04m);
        private static readonly Effect CriticalResistanceRate002   = new(Static.CriticalResistanceRate, .02m);
        private static readonly Effect CriticalResistanceRate003   = new(Static.CriticalResistanceRate, .03m);
        private static readonly Effect CriticalResistanceRate004   = new(Static.CriticalResistanceRate, .04m);
        private static readonly Effect DamageReductionRate005      = new(Static.DamageReductionRate, .05m);
        private static readonly Effect Defense144                  = new(Static.Defense, 144);
        private static readonly Effect Defense312                  = new(Static.Defense, 312);
        private static readonly Effect Defense480                  = new(Static.Defense, 480);
        private static readonly Effect Defense72                   = new(Static.Defense, 72);
        private static readonly Effect Defense720                  = new(Static.Defense, 720);
        private static readonly Effect DefenseBreakRate001         = new(Static.DefenseBreakRate, .01m);
        private static readonly Effect DefenseBreakRate002         = new(Static.DefenseBreakRate, .02m);
        private static readonly Effect DefenseBreakRate003         = new(Static.DefenseBreakRate, .03m);
        private static readonly Effect DefenseBreakRate004         = new(Static.DefenseBreakRate, .04m);
        private static readonly Effect DefenseBreakRate005         = new(Static.DefenseBreakRate, .05m);
        private static readonly Effect DefenseRateM005             = new(Static.DefenseRate, -.05m);
        private static readonly Effect Evade42                     = new(Static.Evade, 42);
        private static readonly Effect EvadeM30                    = new(Static.Evade, -30);
        private static readonly Effect EvadeM38                    = new(Static.Evade, -38);
        private static readonly Effect EvadeM45                    = new(Static.Evade, -45);
        private static readonly Effect EvadeM50                    = new(Static.Evade, -50);
        private static readonly Effect ExtraDamageRateBoss002      = new(Static.ExtraDamageRateBoss, .02m);
        private static readonly Effect ExtraDamageRateFall004      = new(Static.ExtraDamageRateFall, .04m);
        private static readonly Effect ExtraDamageRateFall008      = new(Static.ExtraDamageRateFall, .08m);
        private static readonly Effect ExtraDamageRateFall012      = new(Static.ExtraDamageRateFall, .12m);
        private static readonly Effect ExtraDamageRateFall016      = new(Static.ExtraDamageRateFall, .16m);
        private static readonly Effect ExtraDamageRateFall02       = new(Static.ExtraDamageRateFall, .2m);
        private static readonly Effect HpRate002                   = new(Static.HpRate, .02m);
        private static readonly Effect HpRate004                   = new(Static.HpRate, .04m);
        private static readonly Effect HpRate006                   = new(Static.HpRate, .06m);
        private static readonly Effect HpRate011                   = new(Static.HpRate, .11m);
        private static readonly Effect HpRate015                   = new(Static.HpRate, .15m);
        private static readonly Effect HpRateM005                  = new(Static.HpRate, -.05m);
        private static readonly Effect MoveSpaceRate001            = new(Static.MoveSpaceRate, .01m);
        private static readonly Effect MoveSpaceRate002            = new(Static.MoveSpaceRate, .02m);
        private static readonly Effect MoveSpaceRate003            = new(Static.MoveSpaceRate, .03m);
        private static readonly Effect MoveSpaceRate004            = new(Static.MoveSpaceRate, .04m);
        private static readonly Effect MoveSpaceRate005            = new(Static.MoveSpaceRate, .05m);
        private static readonly Effect MoveSpaceRateM001           = new(Static.MoveSpaceRate, -.01m);
        private static readonly Effect SuperArmorBreakPowerRate001 = new(Static.SuperArmorBreakPowerRate, .01m);
        private static readonly Effect SuperArmorBreakPowerRate002 = new(Static.SuperArmorBreakPowerRate, .02m);
        private static readonly Effect SuperArmorBreakPowerRate003 = new(Static.SuperArmorBreakPowerRate, .03m);
        private static readonly Effect SuperArmorBreakPowerRate004 = new(Static.SuperArmorBreakPowerRate, .04m);
        private static readonly Effect SuperArmorBreakPowerRate005 = new(Static.SuperArmorBreakPowerRate, .05m);
        private static readonly Effect SuperArmorBreakPowerRate006 = new(Static.SuperArmorBreakPowerRate, .06m);
        private static readonly Effect SuperArmorBreakPowerRate007 = new(Static.SuperArmorBreakPowerRate, .07m);
        private static readonly Effect SuperArmorBreakPowerRate008 = new(Static.SuperArmorBreakPowerRate, .08m);
        private static readonly Effect SuperArmorBreakPowerRate009 = new(Static.SuperArmorBreakPowerRate, .09m);
        private static readonly Effect SuperArmorBreakPowerRate01  = new(Static.SuperArmorBreakPowerRate, .1m);
    }
}