using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class AccessorySetData
    {
        private static IReadOnlyCollection<AccessorySetEffect>? _result;

        internal static IReadOnlyCollection<AccessorySetEffect> Get()
        {
            if (_result != null) { return _result; }

            return _result = new List<AccessorySetEffect>
            {
                new("暮光",
                    new Dictionary<int, IReadOnlyCollection<Effect>>
                    {
                        {
                            2,
                            new Effect[] {new(new(Property.Stamina), 17), new(new(Property.CriticalDamage), 2_200)}
                        },
                        {
                            3,
                            new Effect[]
                            {
                                new(new(Property.Accuracy), 370), new(new(Property.ExtraDamageRateBoss), .35m)
                            }
                        },
                        {
                            4,
                            new Effect[]
                            {
                                new(new(Property.CooldownShorterRate), .8m),
                                new(new(Property.DefenseBreakRate), .12m)
                            }
                        }
                    })
            };
        }
    }
}