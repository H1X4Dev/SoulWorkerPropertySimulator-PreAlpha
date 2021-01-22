using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class BroochesSetData
    {
        private static readonly IReadOnlyCollection<BroochSet> SetEffects = new List<BroochSet>
        {
            new(BroochesField.Head,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffect.AttackRate, .15m),
                            new(StaticEffect.PartialDamageRate, .2m),
                            new(StaticEffect.DefenseBreakRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.AttackRate, .1m),
                            new(StaticEffect.PartialDamageRate, .14m),
                            new(StaticEffect.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(StaticEffect.AttackRate, .07m), new(StaticEffect.PartialDamageRate, .1m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(StaticEffect.AttackRate, .05m), new(StaticEffect.PartialDamageRate, .07m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(StaticEffect.AttackRate, .03m), new(StaticEffect.PartialDamageRate, .05m)}
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
                            new(StaticEffect.Attack, 1_000),
                            new(StaticEffect.DefenseRate, .5m),
                            new(StaticEffect.HpRate, .5m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.Attack, 700),
                            new(StaticEffect.DefenseRate, .35m),
                            new(StaticEffect.HpRate, .35m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffect.Attack, 490),
                            new(StaticEffect.DefenseRate, .25m),
                            new(StaticEffect.HpRate, .25m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffect.Attack, 340),
                            new(StaticEffect.DefenseRate, .17m),
                            new(StaticEffect.HpRate, .17m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffect.Attack, 240),
                            new(StaticEffect.DefenseRate, .12m),
                            new(StaticEffect.HpRate, .12m)
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
                            new(StaticEffect.Evade, 100),
                            new(StaticEffect.CriticalResistanceRate, .05m),
                            new(StaticEffect.DamageReductionRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.Evade, 70),
                            new(StaticEffect.CriticalResistanceRate, .04m),
                            new(StaticEffect.DamageReductionRate, .04m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(StaticEffect.Evade, 49), new(StaticEffect.CriticalResistanceRate, .03m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(StaticEffect.Evade, 34), new(StaticEffect.CriticalResistanceRate, .02m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(StaticEffect.Evade, 24), new(StaticEffect.CriticalResistanceRate, .01m)}
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
                            new(StaticEffect.Stamina, 17),
                            new(StaticEffect.AttackSpeedRate, .05m),
                            new(StaticEffect.MoveSpaceRate, .04m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.Stamina, 14),
                            new(StaticEffect.AttackSpeedRate, .04m),
                            new(StaticEffect.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(StaticEffect.Stamina, 1), new(StaticEffect.AttackSpeedRate, .03m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(StaticEffect.Stamina, 8), new(StaticEffect.AttackSpeedRate, .02m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(StaticEffect.Stamina, 5), new(StaticEffect.AttackSpeedRate, .01m)}
                    }
                }),
            new(BroochesField.Shoes,
                BroochesSeries.Sd,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffect.Accuracy, 120),
                            new(StaticEffect.CriticalDamage, 1_000),
                            new(StaticEffect.CriticalRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.Accuracy, 84),
                            new(StaticEffect.CriticalDamage, 900),
                            new(StaticEffect.CriticalRate, .01m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(StaticEffect.Accuracy, 58), new(StaticEffect.CriticalDamage, 800)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(StaticEffect.Accuracy, 41), new(StaticEffect.CriticalDamage, 700)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(StaticEffect.Accuracy, 28), new(StaticEffect.CriticalDamage, 600)}
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffect.AttackRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffect.AttackRate, .2m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffect.AttackRate, .15m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffect.AttackRate, .1m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffect.AttackRate, .05m)}}
                }),
            new(BroochesField.Top,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffect.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffect.CriticalRate, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffect.CriticalRate, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffect.CriticalRate, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffect.CriticalRate, .01m)}}
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffect.SuperArmorBreakPowerRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffect.SuperArmorBreakPowerRate, .18m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffect.SuperArmorBreakPowerRate, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffect.SuperArmorBreakPowerRate, .07m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffect.SuperArmorBreakPowerRate, .03m)}}
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffect.AttackSpeedRate, .06m), new(StaticEffect.MoveSpaceRate, .06m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.AttackSpeedRate, .05m), new(StaticEffect.MoveSpaceRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffect.AttackSpeedRate, .03m), new(StaticEffect.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffect.AttackSpeedRate, .02m), new(StaticEffect.MoveSpaceRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffect.AttackSpeedRate, .01m), new(StaticEffect.MoveSpaceRate, .01m)
                        }
                    }
                }),
            new(BroochesField.Shoes,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffect.CriticalDamage, 1_700)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffect.CriticalDamage, 1_350)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffect.CriticalDamage, 1_000)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffect.CriticalDamage, 850)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffect.CriticalDamage, 700)}}
                }),
            new(BroochesField.Head,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalDamage, 1_000),
                            new(StaticEffect.CriticalRate, .03m),
                            new(StaticEffect.Attack, 800)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalDamage, 700),
                            new(StaticEffect.CriticalRate, .03m),
                            new(StaticEffect.Attack, 560)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(StaticEffect.CriticalDamage, 490), new(StaticEffect.Attack, 390)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(StaticEffect.CriticalDamage, 340), new(StaticEffect.Attack, 270)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(StaticEffect.CriticalDamage, 240), new(StaticEffect.Attack, 190)}
                    }
                }),
            new(BroochesField.Top,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffect.HpRate, 1),
                            new(StaticEffect.Attack, 2_500),
                            new(StaticEffect.DamageReductionRate, .1m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.HpRate, .7m),
                            new(StaticEffect.Attack, 1_700),
                            new(StaticEffect.DamageReductionRate, .07m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffect.HpRate, .49m),
                            new(StaticEffect.Attack, 1_225),
                            new(StaticEffect.DamageReductionRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffect.HpRate, .34m),
                            new(StaticEffect.Attack, 875),
                            new(StaticEffect.DamageReductionRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffect.HpRate, .24m),
                            new(StaticEffect.Attack, 600),
                            new(StaticEffect.DamageReductionRate, .02m)
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
                            new(StaticEffect.DefenseRate, 1),
                            new(StaticEffect.DamageReductionRate, .05m),
                            new(StaticEffect.Hp, 5_000)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.DefenseRate, .7m),
                            new(StaticEffect.DamageReductionRate, .04m),
                            new(StaticEffect.Hp, 3_500)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffect.DefenseRate, .49m),
                            new(StaticEffect.DamageReductionRate, .03m),
                            new(StaticEffect.Hp, 2_450)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffect.DefenseRate, .34m),
                            new(StaticEffect.DamageReductionRate, .02m),
                            new(StaticEffect.Hp, 1_715)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffect.DefenseRate, .24m),
                            new(StaticEffect.DamageReductionRate, .01m),
                            new(StaticEffect.Hp, 1_200)
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
                            new(StaticEffect.Stamina, 20),
                            new(StaticEffect.CriticalDamage, 800),
                            new(StaticEffect.Accuracy, 200)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.Stamina, 14),
                            new(StaticEffect.CriticalDamage, 560),
                            new(StaticEffect.Accuracy, 140)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffect.Stamina, 10),
                            new(StaticEffect.CriticalDamage, 392),
                            new(StaticEffect.Accuracy, 98)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffect.Stamina, 7),
                            new(StaticEffect.CriticalDamage, 274),
                            new(StaticEffect.Accuracy, 68)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffect.Stamina, 8),
                            new(StaticEffect.CriticalDamage, 192),
                            new(StaticEffect.Accuracy, 48)
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
                            new(StaticEffect.Hp, 8_000),
                            new(StaticEffect.StaminaRecovery, 5),
                            new(StaticEffect.Attack, 500)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 5_600),
                            new(StaticEffect.StaminaRecovery, 4),
                            new(StaticEffect.Attack, 350)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 3_920),
                            new(StaticEffect.StaminaRecovery, 3),
                            new(StaticEffect.Attack, 245)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 2_744),
                            new(StaticEffect.StaminaRecovery, 2),
                            new(StaticEffect.Attack, 171)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 1_820),
                            new(StaticEffect.StaminaRecovery, 1),
                            new(StaticEffect.Attack, 120)
                        }
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffect.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffect.CriticalRate, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffect.CriticalRate, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffect.CriticalRate, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffect.CriticalRate, .01m)}}
                }),
            new(BroochesField.Top,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(StaticEffect.Evade, 200), new(StaticEffect.AttackSpeedRate, .02m)}
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[] {new(StaticEffect.Evade, 160), new(StaticEffect.AttackSpeedRate, .01m)}
                    },
                    {BroochesRare.Mega, new Effect[] {new(StaticEffect.Evade, 120)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffect.Evade, 80)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffect.Evade, 40)}}
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalDamage, 1_350), new(StaticEffect.MoveSpaceRateBattle, .03m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalDamage, 1_150), new(StaticEffect.AttackSpeedRate, .02m)
                        }
                    },
                    {BroochesRare.Mega, new Effect[] {new(StaticEffect.CriticalDamage, 950)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffect.CriticalDamage, 750)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffect.CriticalDamage, 550)}}
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[] {new(StaticEffect.AttackSpeedRate, .06m), new(StaticEffect.CriticalRate, .03m)}
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[] {new(StaticEffect.AttackSpeedRate, .05m), new(StaticEffect.CriticalRate, .02m)}
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[] {new(StaticEffect.AttackSpeedRate, .03m), new(StaticEffect.CriticalRate, .01m)}
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[] {new(StaticEffect.AttackSpeedRate, .02m), new(StaticEffect.CriticalRate, .01m)}
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[] {new(StaticEffect.AttackSpeedRate, .01m), new(StaticEffect.CriticalRate, .01m)}
                    }
                }),
            new(BroochesField.Shoes,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalRate, .03m),
                            new(StaticEffect.SuperArmorBreakPowerRate, .15m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalRate, .02m),
                            new(StaticEffect.SuperArmorBreakPowerRate, .1m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalRate, .01m),
                            new(StaticEffect.SuperArmorBreakPowerRate, .07m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalRate, .01m),
                            new(StaticEffect.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffect.CriticalRate, .01m),
                            new(StaticEffect.SuperArmorBreakPowerRate, .03m)
                        }
                    }
                })
        };

        public static BroochSet Get(BroochesField field, BroochesSeries series) =>
            SetEffects.First(x => x.Field == field && x.Series == series);
    }
}