using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum BroochesType
    {
        [Description("Attack")]
        Attack,

        [Description("Defense")]
        Defense,

        [Description("Technical")]
        Effect
    }
}