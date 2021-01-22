using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class BroochesSetData
    {
        private static readonly IReadOnlyCollection<BroochesSetEffect> SetEffects = new List<BroochesSetEffect>
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
                            new(Static.Attack, 1_000), new(Static.DefenseRate, .5m), new(Static.HpRate, .5m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.Attack, 700), new(Static.DefenseRate, .35m), new(Static.HpRate, .35m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(Static.Attack, 490), new(Static.DefenseRate, .25m), new(Static.HpRate, .25m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(Static.Attack, 340), new(Static.DefenseRate, .17m), new(Static.HpRate, .17m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(Static.Attack, 240), new(Static.DefenseRate, .12m), new(Static.HpRate, .12m)
                        }
                    }
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.Evade, 100),
                            new(Static.CriticalResistanceRate, .05m),
                            new(Static.DamageReductionRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.Evade, 70),
                            new(Static.CriticalResistanceRate, .04m),
                            new(Static.DamageReductionRate, .04m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.Evade, 49), new(Static.CriticalResistanceRate, .03m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.Evade, 34), new(Static.CriticalResistanceRate, .02m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.Evade, 24), new(Static.CriticalResistanceRate, .01m)}
                    }
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.Stamina, 17),
                            new(Static.AttackSpeedRate, .05m),
                            new(Static.MoveSpaceRate, .04m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.Stamina, 14),
                            new(Static.AttackSpeedRate, .04m),
                            new(Static.MoveSpaceRate, .03m)
                        }
                    },
                    {BroochesRare.Mega, new Effect[] {new(Static.Stamina, 1), new(Static.AttackSpeedRate, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Stamina, 8), new(Static.AttackSpeedRate, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Stamina, 5), new(Static.AttackSpeedRate, .01m)}}
                }),
            new(BroochesField.Shoes,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.Accuracy, 120),
                            new(Static.CriticalDamage, 1_000),
                            new(Static.CriticalRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.Accuracy, 84),
                            new(Static.CriticalDamage, 900),
                            new(Static.CriticalRate, .01m)
                        }
                    },
                    {BroochesRare.Mega, new Effect[] {new(Static.Accuracy, 58), new(Static.CriticalDamage, 800)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Accuracy, 41), new(Static.CriticalDamage, 700)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Accuracy, 28), new(Static.CriticalDamage, 600)}}
                }),
            new(BroochesField.Head,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.AttackRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.AttackRate, .2m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.AttackRate, .15m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.AttackRate, .1m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.AttackRate, .05m)}}
                }),
            new(BroochesField.Top,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.CriticalRate, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.CriticalRate, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.CriticalRate, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalRate, .01m)}}
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.SuperArmorBreakPowerRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.SuperArmorBreakPowerRate, .18m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.SuperArmorBreakPowerRate, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.SuperArmorBreakPowerRate, .07m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.SuperArmorBreakPowerRate, .03m)}}
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(Static.AttackSpeedRate, .06m), new(Static.MoveSpaceRate, .06m)}
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[] {new(Static.AttackSpeedRate, .05m), new(Static.MoveSpaceRate, .05m)}
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.AttackSpeedRate, .03m), new(Static.MoveSpaceRate, .03m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.AttackSpeedRate, .02m), new(Static.MoveSpaceRate, .02m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.AttackSpeedRate, .01m), new(Static.MoveSpaceRate, .01m)}
                    }
                }),
            new(BroochesField.Shoes,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalDamage, 1_700)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.CriticalDamage, 1_350)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.CriticalDamage, 1_000)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.CriticalDamage, 850)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalDamage, 700)}}
                }),
            new(BroochesField.Head,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.CriticalDamage, 1_000),
                            new(Static.CriticalRate, .03m),
                            new(Static.Attack, 800)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.CriticalDamage, 700),
                            new(Static.CriticalRate, .03m),
                            new(Static.Attack, 560)
                        }
                    },
                    {BroochesRare.Mega, new Effect[] {new(Static.CriticalDamage, 490), new(Static.Attack, 390)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.CriticalDamage, 340), new(Static.Attack, 270)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalDamage, 240), new(Static.Attack, 190)}}
                }),
            new(BroochesField.Top,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.HpRate, 1),
                            new(Static.Attack, 2_500),
                            new(Static.DamageReductionRate, .1m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.HpRate, .7m),
                            new(Static.Attack, 1_700),
                            new(Static.DamageReductionRate, .07m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(Static.HpRate, .49m),
                            new(Static.Attack, 1_225),
                            new(Static.DamageReductionRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(Static.HpRate, .34m),
                            new(Static.Attack, 875),
                            new(Static.DamageReductionRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(Static.HpRate, .24m),
                            new(Static.Attack, 600),
                            new(Static.DamageReductionRate, .02m)
                        }
                    }
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.DefenseRate, 1),
                            new(Static.DamageReductionRate, .05m),
                            new(Static.Hp, 5_000)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.DefenseRate, .7m),
                            new(Static.DamageReductionRate, .04m),
                            new(Static.Hp, 3_500)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(Static.DefenseRate, .49m),
                            new(Static.DamageReductionRate, .03m),
                            new(Static.Hp, 2_450)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(Static.DefenseRate, .34m),
                            new(Static.DamageReductionRate, .02m),
                            new(Static.Hp, 1_715)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(Static.DefenseRate, .24m),
                            new(Static.DamageReductionRate, .01m),
                            new(Static.Hp, 1_200)
                        }
                    }
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.Stamina, 20), new(Static.CriticalDamage, 800), new(Static.Accuracy, 200)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.Stamina, 14), new(Static.CriticalDamage, 560), new(Static.Accuracy, 140)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(Static.Stamina, 10), new(Static.CriticalDamage, 392), new(Static.Accuracy, 98)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(Static.Stamina, 7), new(Static.CriticalDamage, 274), new(Static.Accuracy, 68)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(Static.Stamina, 8), new(Static.CriticalDamage, 192), new(Static.Accuracy, 48)
                        }
                    }
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(Static.Hp, 8_000), new(Static.StaminaRecovery, 5), new(Static.Attack, 500)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(Static.Hp, 5_600), new(Static.StaminaRecovery, 4), new(Static.Attack, 350)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(Static.Hp, 3_920), new(Static.StaminaRecovery, 3), new(Static.Attack, 245)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(Static.Hp, 2_744), new(Static.StaminaRecovery, 2), new(Static.Attack, 171)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(Static.Hp, 1_820), new(Static.StaminaRecovery, 1), new(Static.Attack, 120)
                        }
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.CriticalRate, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.CriticalRate, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.CriticalRate, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalRate, .01m)}}
                }),
            new(BroochesField.Top,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera, new Effect[] {new(Static.Evade, 200), new(Static.AttackSpeedRate, .02m)}
                    },
                    {BroochesRare.Giga, new Effect[] {new(Static.Evade, 160), new(Static.AttackSpeedRate, .01m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Evade, 120)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 80)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Evade, 40)}}
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(Static.CriticalDamage, 1_350), new(Static.MoveSpaceRateBattle, .03m)}
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[] {new(Static.CriticalDamage, 1_150), new(Static.AttackSpeedRate, .02m)}
                    },
                    {BroochesRare.Mega, new Effect[] {new(Static.CriticalDamage, 950)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.CriticalDamage, 750)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalDamage, 550)}}
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(Static.AttackSpeedRate, .06m), new(Static.CriticalRate, .03m)}
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[] {new(Static.AttackSpeedRate, .05m), new(Static.CriticalRate, .02m)}
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.AttackSpeedRate, .03m), new(Static.CriticalRate, .01m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.AttackSpeedRate, .02m), new(Static.CriticalRate, .01m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.AttackSpeedRate, .01m), new(Static.CriticalRate, .01m)}
                    }
                }),
            new(BroochesField.Shoes,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(Static.CriticalRate, .03m), new(Static.SuperArmorBreakPowerRate, .15m)}
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[] {new(Static.CriticalRate, .02m), new(Static.SuperArmorBreakPowerRate, .1m)}
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(Static.CriticalRate, .01m), new(Static.SuperArmorBreakPowerRate, .07m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(Static.CriticalRate, .01m), new(Static.SuperArmorBreakPowerRate, .05m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(Static.CriticalRate, .01m), new(Static.SuperArmorBreakPowerRate, .03m)}
                    }
                })
        };

        public static BroochesSetEffect Get(BroochesField field, BroochesSeries series) =>
            SetEffects.First(x => x.Field == field && x.Series == series);
    }
}