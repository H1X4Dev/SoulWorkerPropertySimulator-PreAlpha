using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum BroochesType
    {
        [Description("攻擊")]
        Attack,

        [Description("防禦")]
        Defense,

        [Description("功能")]
        Effect
    }
}