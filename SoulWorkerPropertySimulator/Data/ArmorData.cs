using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data
{
    internal static class ArmorData
    {
        private static ICollection<ArmorBlueprint>? _armorBlueprintResult;

        internal static ICollection<ArmorBlueprint> Get()
        {
            if (_armorBlueprintResult != null) { return _armorBlueprintResult; }

            var result = new List<ArmorBlueprint>();
            var weapon68 = new ArmorBlueprint("進階幕光的流浪者",
                ArmorField.Weapon,
                68,
                ArmorRare.Legendary,
                4,
                new List<EffectRandomContext>
                {
                    new(new EffectContext(Property.AttackSpeedRate), .01m, .06m),
                    new(new EffectContext(Property.Accuracy), 16, 65),
                    new(new EffectContext(Property.ExtraDamageRateBasic), .02m, .09m),
                    new(new EffectContext(Property.ExtraDamageRateBoss), .02m, .09m),
                    new(new EffectContext(Property.CriticalRate), .02m, .07m),
                    new(new EffectContext(Property.CriticalDamage), 1885, 1743),
                    new(new EffectContext(Property.SuperArmorBreakPowerRate), .02m, .11m),
                    new(new EffectContext(Property.DefenseBreakRate), .01m, .06m),
                    new(new EffectContext(Property.SoulNovaVolumeRate), .01m, .07m),
                    new(new EffectContext(Property.KillHPRecovery), 28, 217)
                },
                3,
                Property.Attack,
                2175,
                3234,
                fixedEffects: new List<Effect>
                {
                    new(new EffectContext(Property.Attack), 3726),
                    new(new EffectContext(Property.AttackSpeedRate), .07m),
                    new(new EffectContext(Property.ExtraDamageRateBoss), .3m),
                    new(new EffectContext(Property.CriticalDamage), 2000),
                    new(new EffectContext(Property.Accuracy), -50)
                });
            result.Add(weapon68);
            result.Add(weapon68 with {Name = "進階幕光的平流"});
            result.Add(weapon68 with {Name = "進階幕光的榮耀"});
            result.Add(weapon68 with {Name = "進階幕光憐憫頌"});
            result.Add(weapon68 with {Name = "進階幕光的細緻"});
            result.Add(weapon68 with {Name = "進階幕光的廢墟"});
            result.Add(weapon68 with {Name = "進階幕光的追跡"});
            result.Add(weapon68 with {Name = "進階幕光的畸變"});

            return _armorBlueprintResult = result;
        }
    }
}