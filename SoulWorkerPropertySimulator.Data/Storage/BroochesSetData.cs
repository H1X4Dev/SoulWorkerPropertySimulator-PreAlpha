using System;
using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class BroochesSetData
    {
        private static IReadOnlyCollection<BroochesSetEffect> _setEffects = new List<BroochesSetEffect>
        {
            new(BroochesField.Head,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.AttackRate, .15m),
                            new(Static.PartialDamageRate, .2m),
                            new(Static.DefenseBreakRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.AttackRate, .1m),
                            new(Static.PartialDamageRate, .14m),
                            new(Static.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.AttackRate, .07m), new(Static.PartialDamageRate, .1m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.AttackRate, .05m), new(Static.PartialDamageRate, .07m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.AttackRate, .03m), new(Static.PartialDamageRate, .05m)}
                    }
                }),
            new(BroochesField.Top,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.Attack, 1_000),
                            new(Static.DefenseRate, .5m),
                            new(Static.HpRate, .5m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.Attack, 1_000),
                            new(Static.DefenseRate, .5m),
                            new(Static.HpRate, .5m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {
                            new(Static.Attack, 1_000),
                            new(Static.DefenseRate, .5m),
                            new(Static.HpRate, .5m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {
                            new(Static.Attack, 1_000),
                            new(Static.DefenseRate, .5m),
                            new(Static.HpRate, .5m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {
                            new(Static.Attack, 1_000),
                            new(Static.DefenseRate, .5m),
                            new(Static.HpRate, .5m)}
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.AttackRate, .15m),
                            new(Static.PartialDamageRate, .2m),
                            new(Static.DefenseBreakRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.AttackRate, .1m),
                            new(Static.PartialDamageRate, .14m),
                            new(Static.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.AttackRate, .07m), new(Static.PartialDamageRate, .1m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.AttackRate, .05m), new(Static.PartialDamageRate, .07m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.AttackRate, .03m), new(Static.PartialDamageRate, .05m),}
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.AttackRate, .15m),
                            new(Static.PartialDamageRate, .2m),
                            new(Static.DefenseBreakRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.AttackRate, .1m),
                            new(Static.PartialDamageRate, .14m),
                            new(Static.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.AttackRate, .07m), new(Static.PartialDamageRate, .1m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.AttackRate, .05m), new(Static.PartialDamageRate, .07m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.AttackRate, .03m), new(Static.PartialDamageRate, .05m),}
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.AttackRate, .15m),
                            new(Static.PartialDamageRate, .2m),
                            new(Static.DefenseBreakRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.AttackRate, .1m),
                            new(Static.PartialDamageRate, .14m),
                            new(Static.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.AttackRate, .07m), new(Static.PartialDamageRate, .1m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.AttackRate, .05m), new(Static.PartialDamageRate, .07m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.AttackRate, .03m), new(Static.PartialDamageRate, .05m),}
                    }
                }),
        };

        public static IReadOnlyCollection<BroochesSetEffect> Get() => throw new NotImplementedException();
    }
}