using System;
using System.Collections.Generic;
using System.ComponentModel;
using SoulWorkerPropertySimulator.Extensions;

namespace SoulWorkerPropertySimulator
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

    public enum Opportunity
    {
        [Description("空中命中時")]
        AirHit,

        [Description("在空中受到傷害時")]
        AirSuffer,

        [Description("耐力達到100%狀態下進行攻擊時")]
        AttackStamina100,

        [Description("迴避時")]
        Avoid,

        [Description("暴擊時")]
        Critical,

        [Description("暴擊命中時")]
        CriticalHit,

        [Description("死亡時")]
        Death,

        [Description("倒地時")]
        Fall,

        [Description("落地受到傷害時")]
        FallSuffer,

        [Description("命中時")]
        Hit,

        [Description("BOSS敵人命中時")]
        HitBoss,

        [Description("普通怪物命中時")]
        HitCommon,

        [Description("耐力未滿10%攻擊命中時")]
        HitStamina10Down,

        [Description("耐力未滿40%攻擊命中時")]
        HitStamina40Down,

        [Description("耐力未滿70%攻擊命中時")]
        HitStamina70Down,

        [Description("HP未滿10%時")]
        Hp10Down,

        [Description("HP未滿15%時")]
        Hp15Down,

        [Description("HP未滿20%時")]
        Hp20Down,

        [Description("HP未滿20%且受擊時")]
        Hp20DownThenHit,

        [Description("HP未滿30%且受擊時")]
        Hp30DownThenHit,

        [Description("HP未滿50%時")]
        Hp50Down,

        [Description("恢復體力時")]
        HpRecover,

        [Description("擊敗效果")]
        Kill,

        [Description("使用衝刺時")]
        Run,

        [Description("耐力未滿30%狀態下使用衝刺時")]
        RunStamina30Down,

        [Description("技能：暴走公主")]
        SkillBaozougongzhu,

        [Description("技能：長槍飛舞")]
        SkillChangqiangfeiwu,

        [Description("技能：電磁步槍")]
        SkillDiancibuqiang,

        [Description("技能：電脈加農")]
        SkillDiancijianong,

        [Description("技能：火球彈每次")]
        SkillHuoqiudanPerTimes,

        [Description("技能：火焰翻滾")]
        SkillHuoyanfangun,

        [Description("技能：集中射擊每次")]
        SkillJizhongsjekoPerTimes,

        [Description("技能：靈魂尖嘯每次")]
        SkillLinghunjianxiaoPerTimes,

        [Description("技能：喵道0式-寒風暴雨")]
        SkillMiaodao0,

        [Description("技能：喵道2式-露出腳爪")]
        SkillMiaodao2,

        [Description("技能：破空拔刀斬")]
        SkillPokongbadaozhan,

        [Description("技能：三重碎裂")]
        SkillSanchongsiolei,

        [Description("技能：突刺")]
        SkillTuci,

        [Description("技能：湮滅龍捲每次")]
        SkillYanmielongjuanPerTimes,

        [Description("技能：重型爆震")]
        SkillZhongxingbaozheng,

        [Description("技能：灼熱焚斬")]
        SkillZHuorefenzhan,

        [Description("受擊時")]
        Suffer,

        [Description("受到BOSS攻擊時")]
        SufferBoss,

        [Description("受到暴擊攻擊時")]
        SufferCritical,

        [Description("受擊且HP未滿50%時")]
        SufferHp50Down,

        [Description("耐力50%以上受擊時")]
        SufferStamina50Up,

        [Description("霸體破壞時")]
        SuperArmorBreak,

        [Description("迴避技能使用時")]
        UseAvoid,

        [Description("使用消耗道具時")]
        UseItem,

        [Description("技能使用時")]
        UseSkill
    }

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
            IsPercent   = Percent.Contains(Property);
        }

        public Property     Property    { get; }
        public Opportunity? Opportunity { get; }
        public decimal?     Probability { get; }
        public decimal?     Duration    { get; }
        public bool         IsPercent   { get; }

        public bool IsStatic => Opportunity == null && Probability == null && Duration == null;

        public string Description =>
            $"{Opportunity?.GetDescription()}{(Probability != null ? $"{Probability * 10}%機率" : "")}{(Duration != null ? $"{Duration}秒內" : "")}{Property.GetDescription()}";

        #region

        private static HashSet<Property> Percent { get; } = new()
        {
            Property.AttackRate,
            Property.AttackRateNext,
            Property.AttackRateOriginal,
            Property.AttackSpeedRate,
            Property.CooldownShorterRate,
            Property.CriticalRate,
            Property.CriticalResistanceRate,
            Property.DamageReductionRate,
            Property.DamageReductionRateSix,
            Property.DamageReductionRateAir,
            Property.DamageReductionRateBasic,
            Property.DamageReductionRateBoss,
            Property.DamageReductionRateCritical,
            Property.DamageReductionRateFall,
            Property.DamageReductionRateFlame,
            Property.DamageReductionRateIron,
            Property.DamageReductionRateJunk,
            Property.DamageReductionRateNed,
            Property.DamageReductionRatePartialDamage,
            Property.DamageReductionRatePrimal,
            Property.DamageReductionRatePuppet,
            Property.DamageReductionRatePvP,
            Property.DamageReductionRateSoul,
            Property.DefenseBreakRate,
            Property.DefenseRate,
            Property.DefenseRateOriginal,
            Property.ExpVolumeRateEnemy,
            Property.ExtraDamageRateSix,
            Property.ExtraDamageRateAir,
            Property.ExtraDamageRateBasic,
            Property.ExtraDamageRateBoss,
            Property.ExtraDamageRateFall,
            Property.ExtraDamageRateFlame,
            Property.ExtraDamageRateGolden,
            Property.ExtraDamageRateIron,
            Property.ExtraDamageRateJunk,
            Property.ExtraDamageRateNed,
            Property.ExtraDamageRatePrimal,
            Property.ExtraDamageRatePuppet,
            Property.ExtraDamageRateSoul,
            Property.GearDefenseRate,
            Property.HpRate,
            Property.HpRecoveryRate,
            Property.MoneyVolumeRateEnemy,
            Property.MoveSpaceRate,
            Property.MoveSpaceRateBattle,
            Property.MoveSpaceRateTown,
            Property.PartialDamageRate,
            Property.ReflectionDamageRate,
            Property.SoulGateConsumptionReducedRate,
            Property.SoulGateRecoveryRate,
            Property.SoulNovaVolumeRate,
            Property.SuperArmorBreakPowerRate,
            Property.WeaponAttackRate
        };

        #endregion
    }

    public record EffectRandomContext
    {
        public EffectRandomContext(EffectContext context, decimal min, decimal max)
        {
#if DEBUG
            if (min > max) { throw new InvalidOperationException(); }
#endif

            Context = context;
            Min     = min;
            Max     = max;
        }

        public EffectContext Context { get; init; }
        public decimal       Min     { get; init; }
        public decimal       Max     { get; init; }


        public int DisplayMinValue => (int) (Context.Property.ToString("G").Contains("Rate") ? Min * 100 : Min);
        public int DisplayMaxValue => (int) (Context.Property.ToString("G").Contains("Rate") ? Max * 100 : Max);

        public Effect CreateEffect(decimal value)
        {
            if (value < Min || value > Max) { throw new IndexOutOfRangeException(); }

            return new(Context, value);
        }
    }

    public record Effect(EffectContext Context, decimal Value);
}