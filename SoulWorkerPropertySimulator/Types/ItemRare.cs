using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum ItemRare
    {
        [Description("Common")]
        Common,

        [Description("Magic")]
        Magical,

        [Description("Rare")]
        Valuable,

        [Description("Unique")]
        Unique,

        [Description("Legend")]
        Legendary,

        [Description("Hero")]
        Heroic
    }
}