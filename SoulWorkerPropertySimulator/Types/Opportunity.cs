using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
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
}