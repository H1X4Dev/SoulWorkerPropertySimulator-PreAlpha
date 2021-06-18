using System.ComponentModel;

namespace SoulWorkerPropertySimulator.Types
{
    public enum EquipmentField
    {
        [Description("Weapon")]
        Weapon,

        [Description("Helmet")]
        Head,

        [Description("Shoulder Guard")]
        Shoulder,

        [Description("Top")]
        Chest,

        [Description("Bottom")]
        Leg
    }
}