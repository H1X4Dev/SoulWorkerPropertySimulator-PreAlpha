using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum EquipmentField
    {
        [Description("武器")]
        Weapon,

        [Description("頭盔")]
        Head,

        [Description("護肩")]
        Shoulder,

        [Description("胸甲")]
        Chest,

        [Description("護腿")]
        Leg
    }
}