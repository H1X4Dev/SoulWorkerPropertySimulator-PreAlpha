using System.ComponentModel;

namespace SoulWorkerPropertySimulator
{
    public enum Classify
    {
        Character,
        Armor,
        Accessory,
        Akasha,
        Brooches
    }

    public enum ArmorField
    {
        Weapon,
        Head,
        Shoulder,
        Chest,
        Leg
    }

    public enum ArmorRare
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

    public enum PluginField { Weapon, Gear }

    public enum AccessoryField { Amulet, Earrings, Ring }

    public enum BroochesSeries
    {
        Sd,
        Fot,
        Bsk,
        Sin
    }

    public enum BroochesRare
    {
        [Description("綠")]
        Byte,

        [Description("藍")]
        Kilo,

        [Description("黃")]
        Mega,

        [Description("紅")]
        Giga,

        [Description("紫")]
        Tera
    }

    public enum TagRare
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

    public enum TagField { Weapon, Gear }

    public enum BroochesType
    {
        [Description("攻擊")]
        Attack,

        [Description("防禦")]
        Defense,

        [Description("功能")]
        Effect
    }

    public enum BroochesField
    {
        [Description("頭部")]
        Head,

        [Description("上衣")]
        Top,

        [Description("手套")]
        Gloves,

        [Description("下衣")]
        Bottom,

        [Description("鞋子")]
        Shoes
    }

    public enum TitleField { First, Last }
}