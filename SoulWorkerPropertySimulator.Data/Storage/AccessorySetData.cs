using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class AccessorySetData
    {
        private static readonly IReadOnlyCollection<AccessorySetEffect> Result = new List<AccessorySetEffect>
        {
            new("暮光",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {2, new Effect[] {new(Static.Stamina, 17), new(Static.CriticalDamage, 2_200)}},
                    {3, new Effect[] {new(Static.Accuracy, 370), new(Static.ExtraDamageRateBoss, .35m)}},
                    {4, new Effect[] {new(Static.CooldownShorterRate, .8m), new(Static.DefenseBreakRate, .12m)}}
                })
        };

        internal static IReadOnlyCollection<AccessorySetEffect> Get() => Result;
    }
}