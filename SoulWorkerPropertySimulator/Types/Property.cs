using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum Property
    {
        [Description("命中度")]
        Accuracy,

        [Description("攻擊力")]
        Attack,

        [Description("攻擊力(%)")]
        AttackRate,

        [Description("下次攻擊的攻擊力(%)")]
        AttackRateNext,

        [Description("空裝攻擊力")]
        AttackRateOriginal,

        [Description("攻擊速度")]
        AttackSpeedRate,

        [Description("冷卻時間")]
        CooldownShorterRate,

        [Description("暴擊傷害")]
        CriticalDamage,

        [Description("暴擊率")]
        CriticalRate,

        [Description("暴擊抵抗(%)")]
        CriticalResistanceRate,

        [Description("減傷率")]
        DamageReductionRate,

        [Description("傷害減少：第六區域")]
        DamageReductionRateSix,

        [Description("傷害減少：空中")]
        DamageReductionRateAir,

        [Description("傷害減少：一般怪物")]
        DamageReductionRateBasic,

        [Description("傷害減少：BOSS")]
        DamageReductionRateBoss,

        [Description("傷害減少：暴擊")]
        DamageReductionRateCritical,

        [Description("傷害減少：倒地")]
        DamageReductionRateFall,

        [Description("傷害減少：疾速烈焰")]
        DamageReductionRateFlame,

        [Description("傷害減少：鋼鐵勢力")]
        DamageReductionRateIron,

        [Description("傷害減少：靈魂暗影")]
        DamageReductionRateJunk,

        [Description("傷害減少：NED")]
        DamageReductionRateNed,

        [Description("傷害減少：攻擊失敗")]
        DamageReductionRatePartialDamage,

        [Description("傷害減少：原始勢力")]
        DamageReductionRatePrimal,

        [Description("傷害減少：傀儡軍隊")]
        DamageReductionRatePuppet,

        [Description("傷害減少：PvP")]
        DamageReductionRatePvP,

        [Description("傷害減少：人造靈魂行者")]
        DamageReductionRateSoul,

        [Description("防禦度")]
        Defense,

        [Description("防禦貫穿率")]
        DefenseBreakRate,

        [Description("防禦度(%)")]
        DefenseRate,

        [Description("空裝防禦度")]
        DefenseRateOriginal,

        [Description("霸體(秒)")]
        EndureSecond,

        [Description("回避度")]
        Evade,

        [Description("從敵人獲得經驗")]
        ExpVolumeRateEnemy,

        [Description("附加傷害：第六區域")]
        ExtraDamageRateSix,

        [Description("附加傷害：空中")]
        ExtraDamageRateAir,

        [Description("附加傷害：一般")]
        ExtraDamageRateBasic,

        [Description("附加傷害：BOSS")]
        ExtraDamageRateBoss,

        [Description("附加傷害：倒地")]
        ExtraDamageRateFall,

        [Description("附加傷害：疾速烈焰")]
        ExtraDamageRateFlame,

        [Description("附加傷害：金色城堡")]
        ExtraDamageRateGolden,

        [Description("附加傷害：鋼鐵勢力")]
        ExtraDamageRateIron,

        [Description("附加傷害：靈魂暗影")]
        ExtraDamageRateJunk,

        [Description("附加傷害：NED")]
        ExtraDamageRateNed,

        [Description("附加傷害：原始勢力")]
        ExtraDamageRatePrimal,

        [Description("附加傷害：傀儡軍隊")]
        ExtraDamageRatePuppet,

        [Description("附加傷害：人造靈魂行者")]
        ExtraDamageRateSoul,

        [Description("防禦防禦度")]
        GearDefense,

        [Description("防禦防禦度(%)")]
        GearDefenseRate,

        [Description("最大HP")]
        Hp,

        [Description("最大HP(%)")]
        HpRate,

        [Description("HP恢復")]
        HpRecovery,

        [Description("HP恢復(%)")]
        HpRecoveryRate,

        [Description("無敵(秒)")]
        InvincibleSecond,

        [Description("擊殺效果：HP恢復")]
        KillHpRecovery,

        [Description("從敵人獲得金幣量")]
        MoneyVolumeRateEnemy,

        [Description("移動速度")]
        MoveSpaceRate,

        [Description("戰鬥中移動速度")]
        MoveSpaceRateBattle,

        [Description("城鎮中移動速度")]
        MoveSpaceRateTown,

        [Description("攻擊失敗傷害")]
        PartialDamageRate,

        [Description("反射傷害量")]
        ReflectionDamageRate,

        [Description("SG消耗量減少")]
        SoulGateConsumptionReducedRate,

        [Description("SG恢復(%)")]
        SoulGateRecoveryRate,

        [Description("SV獲得量")]
        SoulNovaVolumeRate,

        [Description("最大耐力")]
        Stamina,

        [Description("耐力回復")]
        StaminaRecovery,

        [Description("SA破壞力")]
        SuperArmorBreakPowerRate,

        [Description("武器攻擊力")]
        WeaponAttack,

        [Description("武器攻擊力(%)")]
        WeaponAttackRate
    }
}