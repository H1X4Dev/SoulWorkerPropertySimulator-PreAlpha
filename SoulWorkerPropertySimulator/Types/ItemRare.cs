using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum ItemRare
    {
        [Description("白")]
        Common,

        [Description("綠")]
        Magical,

        [Description("藍")]
        Valuable,

        [Description("黃")]
        Unique,

        [Description("紅")]
        Legendary,

        [Description("紫")]
        Heroic
    }
}