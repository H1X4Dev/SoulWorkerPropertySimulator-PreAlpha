namespace SoulWorkerPropertySimulator.Data
{
    internal static class Static
    {
        public static EffectContext Accuracy                    { get; } = new(Property.Accuracy);
        public static EffectContext Attack                      { get; } = new(Property.Attack);
        public static EffectContext AttackRate                  { get; } = new(Property.AttackRate);
        public static EffectContext AttackRateNext              { get; } = new(Property.AttackRateNext);
        public static EffectContext AttackRateOriginal          { get; } = new(Property.AttackRateOriginal);
        public static EffectContext AttackSpeedRate             { get; } = new(Property.AttackSpeedRate);
        public static EffectContext CooldownShorterRate         { get; } = new(Property.CooldownShorterRate);
        public static EffectContext CriticalDamage              { get; } = new(Property.CriticalDamage);
        public static EffectContext CriticalRate                { get; } = new(Property.CriticalRate);
        public static EffectContext CriticalResistanceRate      { get; } = new(Property.CriticalResistanceRate);
        public static EffectContext DamageReductionRate         { get; } = new(Property.DamageReductionRate);
        public static EffectContext DamageReductionRateSix      { get; } = new(Property.DamageReductionRateSix);
        public static EffectContext DamageReductionRateAir      { get; } = new(Property.DamageReductionRateAir);
        public static EffectContext DamageReductionRateBasic    { get; } = new(Property.DamageReductionRateBasic);
        public static EffectContext DamageReductionRateBoss     { get; } = new(Property.DamageReductionRateBoss);
        public static EffectContext DamageReductionRateCritical { get; } = new(Property.DamageReductionRateCritical);
        public static EffectContext DamageReductionRateFall     { get; } = new(Property.DamageReductionRateFall);
        public static EffectContext DamageReductionRateFlame    { get; } = new(Property.DamageReductionRateFlame);
        public static EffectContext DamageReductionRateIron     { get; } = new(Property.DamageReductionRateIron);
        public static EffectContext DamageReductionRateJunk     { get; } = new(Property.DamageReductionRateJunk);
        public static EffectContext DamageReductionRateNed      { get; } = new(Property.DamageReductionRateNed);

        public static EffectContext DamageReductionRatePartialDamage { get; } =
            new(Property.DamageReductionRatePartialDamage);

        public static EffectContext DamageReductionRatePrimal { get; } = new(Property.DamageReductionRatePrimal);
        public static EffectContext DamageReductionRatePuppet { get; } = new(Property.DamageReductionRatePuppet);
        public static EffectContext DamageReductionRatePvP    { get; } = new(Property.DamageReductionRatePvP);
        public static EffectContext DamageReductionRateSoul   { get; } = new(Property.DamageReductionRateSoul);
        public static EffectContext Defense                   { get; } = new(Property.Defense);
        public static EffectContext DefenseBreakRate          { get; } = new(Property.DefenseBreakRate);
        public static EffectContext DefenseRate               { get; } = new(Property.DefenseRate);
        public static EffectContext DefenseRateOriginal       { get; } = new(Property.DefenseRateOriginal);
        public static EffectContext EndureSecond              { get; } = new(Property.EndureSecond);
        public static EffectContext Evade                     { get; } = new(Property.Evade);
        public static EffectContext ExpVolumeRateEnemy        { get; } = new(Property.ExpVolumeRateEnemy);
        public static EffectContext ExtraDamageRateSix        { get; } = new(Property.ExtraDamageRateSix);
        public static EffectContext ExtraDamageRateAir        { get; } = new(Property.ExtraDamageRateAir);
        public static EffectContext ExtraDamageRateBasic      { get; } = new(Property.ExtraDamageRateBasic);
        public static EffectContext ExtraDamageRateBoss       { get; } = new(Property.ExtraDamageRateBoss);
        public static EffectContext ExtraDamageRateFall       { get; } = new(Property.ExtraDamageRateFall);
        public static EffectContext ExtraDamageRateFlame      { get; } = new(Property.ExtraDamageRateFlame);
        public static EffectContext ExtraDamageRateGolden     { get; } = new(Property.ExtraDamageRateGolden);
        public static EffectContext ExtraDamageRateIron       { get; } = new(Property.ExtraDamageRateIron);
        public static EffectContext ExtraDamageRateJunk       { get; } = new(Property.ExtraDamageRateJunk);
        public static EffectContext ExtraDamageRateNed        { get; } = new(Property.ExtraDamageRateNED);
        public static EffectContext ExtraDamageRatePrimal     { get; } = new(Property.ExtraDamageRatePrimal);
        public static EffectContext ExtraDamageRatePuppet     { get; } = new(Property.ExtraDamageRatePuppet);
        public static EffectContext ExtraDamageRateSoul       { get; } = new(Property.ExtraDamageRateSoul);
        public static EffectContext GearDefense               { get; } = new(Property.GearDefense);
        public static EffectContext GearDefenseRate           { get; } = new(Property.GearDefenseRate);
        public static EffectContext Hp                        { get; } = new(Property.Hp);
        public static EffectContext HpRate                    { get; } = new(Property.HpRate);
        public static EffectContext HpRecovery                { get; } = new(Property.HpRecovery);
        public static EffectContext HpRecoveryRate            { get; } = new(Property.HpRecoveryRate);
        public static EffectContext InvincibleSecond          { get; } = new(Property.InvincibleSecond);
        public static EffectContext KillHpRecovery            { get; } = new(Property.KillHpRecovery);
        public static EffectContext MoneyVolumeRateEnemy      { get; } = new(Property.MoneyVolumeRateEnemy);
        public static EffectContext MoveSpaceRate             { get; } = new(Property.MoveSpaceRate);
        public static EffectContext MoveSpaceRateBattle       { get; } = new(Property.MoveSpaceRateBattle);
        public static EffectContext MoveSpaceRateTown         { get; } = new(Property.MoveSpaceRateTown);
        public static EffectContext PartialDamageRate         { get; } = new(Property.PartialDamageRate);
        public static EffectContext ReflectionDamageRate      { get; } = new(Property.ReflectionDamageRate);

        public static EffectContext SoulGateConsumptionReducedRate { get; } =
            new(Property.SoulGateConsumptionReducedRate);

        public static EffectContext SoulGateRecoveryRate     { get; } = new(Property.SoulGateRecoveryRate);
        public static EffectContext SoulNovaVolumeRate       { get; } = new(Property.SoulNovaVolumeRate);
        public static EffectContext Stamina                  { get; } = new(Property.Stamina);
        public static EffectContext StaminaRecovery          { get; } = new(Property.StaminaRecovery);
        public static EffectContext SuperArmorBreakPowerRate { get; } = new(Property.SuperArmorBreakPowerRate);
        public static EffectContext WeaponAttack             { get; } = new(Property.WeaponAttack);
        public static EffectContext WeaponAttackRate         { get; } = new(Property.WeaponAttackRate);
    }
}