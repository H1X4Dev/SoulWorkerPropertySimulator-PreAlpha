using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum Property
    {
        [Description("Accuracy")]
        Accuracy,

        [Description("Attack")]
        Attack,

        [Description("Attack(%)")]
        AttackRate,

        [Description("Next Attack(%)")]
        AttackRateNext,

        [Description("Original Attack")]
        AttackRateOriginal,

        [Description("Attack Speed")]
        AttackSpeedRate,

        [Description("Cooldown Reduction")]
        CooldownShorterRate,

        [Description("Critical Damage")]
        CriticalDamage,

        [Description("Critical")]
        CriticalRate,

        [Description("Critical Resist.(%)")]
        CriticalResistanceRate,

        [Description("Damage Reduction")]
        DamageReductionRate,

        [Description("Damage Reduction: Air")]
        DamageReductionRateAir,

        [Description("Damage Reduction：Basic")]
        DamageReductionRateBasic,

        [Description("Damage Reduction：Boss/Named")]
        DamageReductionRateBoss,

        [Description("Damage Reduction：Critical")]
        DamageReductionRateCritical,

        [Description("Damage Reduction : Fall")]
        DamageReductionRateFall,

        [Description("Damage Reduction：Fire")]
        DamageReductionRateFlame,

        [Description("Damage Reduction：Iron")]
        DamageReductionRateIron,

        [Description("Damage Reduction：Junk")]
        DamageReductionRateJunk,

        [Description("Damage Reduction：NED")]
        DamageReductionRateNed,

        [Description("Damage Reduction：Partial Damage")]
        DamageReductionRatePartialDamage,

        [Description("Damage Reduction : Primal")]
        DamageReductionRatePrimal,

        [Description("Damage Reduction：Doll")]
        DamageReductionRatePuppet,

        [Description("Damage Reduction：PvP")]
        DamageReductionRatePvP,

        [Description("Damage Reduction：District 6")]
        DamageReductionRateSix,

        [Description("Damage Reduction：Soul")]
        DamageReductionRateSoul,

        [Description("Defense")]
        Defense,

        [Description("Armor Break")]
        DefenseBreakRate,

        [Description("Defense(%)")]
        DefenseRate,

        [Description("Original Defense")]
        DefenseRateOriginal,

        [Description("Stamina(秒)")]
        EndureSecond,

        [Description("Evasion")]
        Evade,

        [Description("EXP% increase")]
        ExpVolumeRateEnemy,

        [Description("Extra Damage against：Air")]
        ExtraDamageRateAir,

        [Description("Extra Damage against：Basic")]
        ExtraDamageRateBasic,

        [Description("Extra Damage against：Boss/Named")]
        ExtraDamageRateBoss,

        [Description("Extra Damage against：Fall")]
        ExtraDamageRateFall,

        [Description("Extra Damage against：Flame")]
        ExtraDamageRateFlame,

        [Description("Extra Damage against：Golden Citadel")]
        ExtraDamageRateGolden,

        [Description("Extra Damage against：Iron")]
        ExtraDamageRateIron,

        [Description("Extra Damage against：Soul Junk")]
        ExtraDamageRateJunk,

        [Description("Extra Damage against：NED")]
        ExtraDamageRateNed,

        [Description("Extra Damage against：Primal")]
        ExtraDamageRatePrimal,

        [Description("Extra Damage against：Doll")]
        ExtraDamageRatePuppet,

        [Description("Extra Damage against：Distric Six")]
        ExtraDamageRateSix,

        [Description("Extra Damage against：Soul Junk")]
        ExtraDamageRateSoul,

        [Description("Gear Defense")]
        GearDefense,

        [Description("Gear Defense(%)")]
        GearDefenseRate,

        [Description("HP")]
        Hp,

        [Description("HP(%)")]
        HpRate,

        [Description("HP Recovery")]
        HpRecovery,

        [Description("HP Recovery(%)")]
        HpRecoveryRate,

        [Description("Invinicible/s")]
        InvincibleSecond,

        [Description("HP Recovery on kill")]
        KillHpRecovery,

        [Description("Zenny increase from enemy")]
        MoneyVolumeRateEnemy,

        [Description("Movement Speed")]
        MoveSpaceRate,

        [Description("Movement Speed in Battle")]
        MoveSpaceRateBattle,

        [Description("Movement Speed in District")]
        MoveSpaceRateTown,

        [Description("Partial Damage(%)")]
        PartialDamageRate,

        [Description("Reflect Damage")]
        ReflectionDamageRate,

        [Description("SG Consumption")]
        SoulGateConsumptionReducedRate,

        [Description("SG Recovery(%)")]
        SoulGateRecoveryRate,

        [Description("SV")]
        SoulNovaVolumeRate,

        [Description("Stamina")]
        Stamina,

        [Description("Stamina Recovery")]
        StaminaRecovery,

        [Description("Super Armor Break Power")]
        SuperArmorBreakPowerRate,

        [Description("Weapon Attack")]
        WeaponAttack,

        [Description("Weapon Attack(%)")]
        WeaponAttackRate
    }
}