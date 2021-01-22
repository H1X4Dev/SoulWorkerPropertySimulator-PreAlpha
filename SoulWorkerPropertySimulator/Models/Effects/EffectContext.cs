using SoulWorkerPropertySimulator.Extensions;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Effects
{
    public record EffectContext
    {
        public EffectContext(Property     property,
                             Opportunity? opportunity = null,
                             decimal?     probability = null,
                             decimal?     duration    = null)
        {
            Property    = property;
            Opportunity = opportunity;
            Probability = probability;
            Duration    = duration;
        }

        public Property     Property    { get; }
        public Opportunity? Opportunity { get; }
        public decimal?     Probability { get; }
        public decimal?     Duration    { get; }

        public bool IsStatic => Opportunity == null && Probability == null && Duration == null;

        public string Description =>
            $"{Opportunity?.GetDescription()}{(Probability != null ? $"{Probability * 10}%機率" : "")}{(Duration != null ? $"{Duration}秒內" : "")}{Property.GetDescription()}";
    }

    public static class StaticEffect
    {
        public static EffectContext Accuracy                         = new(Property.Accuracy);
        public static EffectContext Attack                           = new(Property.Attack);
        public static EffectContext AttackRate                       = new(Property.AttackRate);
        public static EffectContext AttackRateNext                   = new(Property.AttackRateNext);
        public static EffectContext AttackRateOriginal               = new(Property.AttackRateOriginal);
        public static EffectContext AttackSpeedRate                  = new(Property.AttackSpeedRate);
        public static EffectContext CooldownShorterRate              = new(Property.CooldownShorterRate);
        public static EffectContext CriticalDamage                   = new(Property.CriticalDamage);
        public static EffectContext CriticalRate                     = new(Property.CriticalRate);
        public static EffectContext CriticalResistanceRate           = new(Property.CriticalResistanceRate);
        public static EffectContext DamageReductionRate              = new(Property.DamageReductionRate);
        public static EffectContext DamageReductionRateSix           = new(Property.DamageReductionRateSix);
        public static EffectContext DamageReductionRateAir           = new(Property.DamageReductionRateAir);
        public static EffectContext DamageReductionRateBasic         = new(Property.DamageReductionRateBasic);
        public static EffectContext DamageReductionRateBoss          = new(Property.DamageReductionRateBoss);
        public static EffectContext DamageReductionRateCritical      = new(Property.DamageReductionRateCritical);
        public static EffectContext DamageReductionRateFall          = new(Property.DamageReductionRateFall);
        public static EffectContext DamageReductionRateFlame         = new(Property.DamageReductionRateFlame);
        public static EffectContext DamageReductionRateIron          = new(Property.DamageReductionRateIron);
        public static EffectContext DamageReductionRateJunk          = new(Property.DamageReductionRateJunk);
        public static EffectContext DamageReductionRateNed           = new(Property.DamageReductionRateNed);
        public static EffectContext DamageReductionRatePartialDamage = new(Property.DamageReductionRatePartialDamage);
        public static EffectContext DamageReductionRatePrimal        = new(Property.DamageReductionRatePrimal);
        public static EffectContext DamageReductionRatePuppet        = new(Property.DamageReductionRatePuppet);
        public static EffectContext DamageReductionRatePvP           = new(Property.DamageReductionRatePvP);
        public static EffectContext DamageReductionRateSoul          = new(Property.DamageReductionRateSoul);
        public static EffectContext Defense                          = new(Property.Defense);
        public static EffectContext DefenseBreakRate                 = new(Property.DefenseBreakRate);
        public static EffectContext DefenseRate                      = new(Property.DefenseRate);
        public static EffectContext DefenseRateOriginal              = new(Property.DefenseRateOriginal);
        public static EffectContext EndureSecond                     = new(Property.EndureSecond);
        public static EffectContext Evade                            = new(Property.Evade);
        public static EffectContext ExpVolumeRateEnemy               = new(Property.ExpVolumeRateEnemy);
        public static EffectContext ExtraDamageRateSix               = new(Property.ExtraDamageRateSix);
        public static EffectContext ExtraDamageRateAir               = new(Property.ExtraDamageRateAir);
        public static EffectContext ExtraDamageRateBasic             = new(Property.ExtraDamageRateBasic);
        public static EffectContext ExtraDamageRateBoss              = new(Property.ExtraDamageRateBoss);
        public static EffectContext ExtraDamageRateFall              = new(Property.ExtraDamageRateFall);
        public static EffectContext ExtraDamageRateFlame             = new(Property.ExtraDamageRateFlame);
        public static EffectContext ExtraDamageRateGolden            = new(Property.ExtraDamageRateGolden);
        public static EffectContext ExtraDamageRateIron              = new(Property.ExtraDamageRateIron);
        public static EffectContext ExtraDamageRateJunk              = new(Property.ExtraDamageRateJunk);
        public static EffectContext ExtraDamageRateNed               = new(Property.ExtraDamageRateNed);
        public static EffectContext ExtraDamageRatePrimal            = new(Property.ExtraDamageRatePrimal);
        public static EffectContext ExtraDamageRatePuppet            = new(Property.ExtraDamageRatePuppet);
        public static EffectContext ExtraDamageRateSoul              = new(Property.ExtraDamageRateSoul);
        public static EffectContext GearDefense                      = new(Property.GearDefense);
        public static EffectContext GearDefenseRate                  = new(Property.GearDefenseRate);
        public static EffectContext Hp                               = new(Property.Hp);
        public static EffectContext HpRate                           = new(Property.HpRate);
        public static EffectContext HpRecovery                       = new(Property.HpRecovery);
        public static EffectContext HpRecoveryRate                   = new(Property.HpRecoveryRate);
        public static EffectContext InvincibleSecond                 = new(Property.InvincibleSecond);
        public static EffectContext KillHpRecovery                   = new(Property.KillHpRecovery);
        public static EffectContext MoneyVolumeRateEnemy             = new(Property.MoneyVolumeRateEnemy);
        public static EffectContext MoveSpaceRate                    = new(Property.MoveSpaceRate);
        public static EffectContext MoveSpaceRateBattle              = new(Property.MoveSpaceRateBattle);
        public static EffectContext MoveSpaceRateTown                = new(Property.MoveSpaceRateTown);
        public static EffectContext PartialDamageRate                = new(Property.PartialDamageRate);
        public static EffectContext ReflectionDamageRate             = new(Property.ReflectionDamageRate);
        public static EffectContext SoulGateConsumptionReducedRate   = new(Property.SoulGateConsumptionReducedRate);
        public static EffectContext SoulGateRecoveryRate             = new(Property.SoulGateRecoveryRate);
        public static EffectContext SoulNovaVolumeRate               = new(Property.SoulNovaVolumeRate);
        public static EffectContext Stamina                          = new(Property.Stamina);
        public static EffectContext StaminaRecovery                  = new(Property.StaminaRecovery);
        public static EffectContext SuperArmorBreakPowerRate         = new(Property.SuperArmorBreakPowerRate);
        public static EffectContext WeaponAttack                     = new(Property.WeaponAttack);
        public static EffectContext WeaponAttackRate                 = new(Property.WeaponAttackRate);
    }
}