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
                            new(StaticEffectContext.AttackRate, .15m),
                            new(StaticEffectContext.PartialDamageRate, .2m),
                            new(StaticEffectContext.DefenseBreakRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackRate, .1m),
                            new(StaticEffectContext.PartialDamageRate, .14m),
                            new(StaticEffectContext.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackRate, .07m),
                            new(StaticEffectContext.PartialDamageRate, .1m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackRate, .05m),
                            new(StaticEffectContext.PartialDamageRate, .07m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackRate, .03m),
                            new(StaticEffectContext.PartialDamageRate, .05m)
                        }
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
                            new(StaticEffectContext.Attack, 1_000),
                            new(StaticEffectContext.DefenseRate, .5m),
                            new(StaticEffectContext.HpRate, .5m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.Attack, 700),
                            new(StaticEffectContext.DefenseRate, .35m),
                            new(StaticEffectContext.HpRate, .35m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.Attack, 490),
                            new(StaticEffectContext.DefenseRate, .25m),
                            new(StaticEffectContext.HpRate, .25m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.Attack, 340),
                            new(StaticEffectContext.DefenseRate, .17m),
                            new(StaticEffectContext.HpRate, .17m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.Attack, 240),
                            new(StaticEffectContext.DefenseRate, .12m),
                            new(StaticEffectContext.HpRate, .12m)
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
                            new(StaticEffectContext.Evade, 100),
                            new(StaticEffectContext.CriticalResistanceRate, .05m),
                            new(StaticEffectContext.DamageReductionRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.Evade, 70),
                            new(StaticEffectContext.CriticalResistanceRate, .04m),
                            new(StaticEffectContext.DamageReductionRate, .04m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.Evade, 49),
                            new(StaticEffectContext.CriticalResistanceRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.Evade, 34),
                            new(StaticEffectContext.CriticalResistanceRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.CriticalResistanceRate, .01m)
                        }
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
                            new(StaticEffectContext.Stamina, 17),
                            new(StaticEffectContext.AttackSpeedRate, .05m),
                            new(StaticEffectContext.MoveSpaceRate, .04m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 14),
                            new(StaticEffectContext.AttackSpeedRate, .04m),
                            new(StaticEffectContext.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 1), new(StaticEffectContext.AttackSpeedRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 8), new(StaticEffectContext.AttackSpeedRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 5), new(StaticEffectContext.AttackSpeedRate, .01m)
                        }
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
                            new(StaticEffectContext.Accuracy, 120),
                            new(StaticEffectContext.CriticalDamage, 1_000),
                            new(StaticEffectContext.CriticalRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.Accuracy, 84),
                            new(StaticEffectContext.CriticalDamage, 900),
                            new(StaticEffectContext.CriticalRate, .01m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.Accuracy, 58), new(StaticEffectContext.CriticalDamage, 800)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.Accuracy, 41), new(StaticEffectContext.CriticalDamage, 700)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.Accuracy, 28), new(StaticEffectContext.CriticalDamage, 600)
                        }
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.AttackRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.AttackRate, .2m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.AttackRate, .15m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.AttackRate, .1m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.AttackRate, .05m)}}
                }),
            new(BroochesField.Top,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.CriticalRate, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.CriticalRate, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.CriticalRate, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.CriticalRate, .01m)}}
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.SuperArmorBreakPowerRate, .25m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.SuperArmorBreakPowerRate, .18m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.SuperArmorBreakPowerRate, .12m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.SuperArmorBreakPowerRate, .07m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.SuperArmorBreakPowerRate, .03m)}}
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .06m),
                            new(StaticEffectContext.MoveSpaceRate, .06m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .05m),
                            new(StaticEffectContext.MoveSpaceRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .03m),
                            new(StaticEffectContext.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .02m),
                            new(StaticEffectContext.MoveSpaceRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .01m),
                            new(StaticEffectContext.MoveSpaceRate, .01m)
                        }
                    }
                }),
            new(BroochesField.Shoes,
                BroochesSeries.Bsk,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.CriticalDamage, 1_700)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.CriticalDamage, 1_350)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.CriticalDamage, 1_000)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.CriticalDamage, 850)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.CriticalDamage, 700)}}
                }),
            new(BroochesField.Head,
                BroochesSeries.Fot,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 1_000),
                            new(StaticEffectContext.CriticalRate, .03m),
                            new(StaticEffectContext.Attack, 800)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 700),
                            new(StaticEffectContext.CriticalRate, .03m),
                            new(StaticEffectContext.Attack, 560)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 490), new(StaticEffectContext.Attack, 390)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 340), new(StaticEffectContext.Attack, 270)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 240), new(StaticEffectContext.Attack, 190)
                        }
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
                            new(StaticEffectContext.HpRate, 1),
                            new(StaticEffectContext.Attack, 2_500),
                            new(StaticEffectContext.DamageReductionRate, .1m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.HpRate, .7m),
                            new(StaticEffectContext.Attack, 1_700),
                            new(StaticEffectContext.DamageReductionRate, .07m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.HpRate, .49m),
                            new(StaticEffectContext.Attack, 1_225),
                            new(StaticEffectContext.DamageReductionRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.HpRate, .34m),
                            new(StaticEffectContext.Attack, 875),
                            new(StaticEffectContext.DamageReductionRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.HpRate, .24m),
                            new(StaticEffectContext.Attack, 600),
                            new(StaticEffectContext.DamageReductionRate, .02m)
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
                            new(StaticEffectContext.DefenseRate, 1),
                            new(StaticEffectContext.DamageReductionRate, .05m),
                            new(StaticEffectContext.Hp, 5_000)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.DefenseRate, .7m),
                            new(StaticEffectContext.DamageReductionRate, .04m),
                            new(StaticEffectContext.Hp, 3_500)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.DefenseRate, .49m),
                            new(StaticEffectContext.DamageReductionRate, .03m),
                            new(StaticEffectContext.Hp, 2_450)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.DefenseRate, .34m),
                            new(StaticEffectContext.DamageReductionRate, .02m),
                            new(StaticEffectContext.Hp, 1_715)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.DefenseRate, .24m),
                            new(StaticEffectContext.DamageReductionRate, .01m),
                            new(StaticEffectContext.Hp, 1_200)
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
                            new(StaticEffectContext.Stamina, 20),
                            new(StaticEffectContext.CriticalDamage, 800),
                            new(StaticEffectContext.Accuracy, 200)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 14),
                            new(StaticEffectContext.CriticalDamage, 560),
                            new(StaticEffectContext.Accuracy, 140)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 10),
                            new(StaticEffectContext.CriticalDamage, 392),
                            new(StaticEffectContext.Accuracy, 98)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 7),
                            new(StaticEffectContext.CriticalDamage, 274),
                            new(StaticEffectContext.Accuracy, 68)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.Stamina, 8),
                            new(StaticEffectContext.CriticalDamage, 192),
                            new(StaticEffectContext.Accuracy, 48)
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
                            new(StaticEffectContext.Hp, 8_000),
                            new(StaticEffectContext.StaminaRecovery, 5),
                            new(StaticEffectContext.Attack, 500)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 5_600),
                            new(StaticEffectContext.StaminaRecovery, 4),
                            new(StaticEffectContext.Attack, 350)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 3_920),
                            new(StaticEffectContext.StaminaRecovery, 3),
                            new(StaticEffectContext.Attack, 245)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 2_744),
                            new(StaticEffectContext.StaminaRecovery, 2),
                            new(StaticEffectContext.Attack, 171)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 1_820),
                            new(StaticEffectContext.StaminaRecovery, 1),
                            new(StaticEffectContext.Attack, 120)
                        }
                    }
                }),
            new(BroochesField.Head,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(StaticEffectContext.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(StaticEffectContext.CriticalRate, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.CriticalRate, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.CriticalRate, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.CriticalRate, .01m)}}
                }),
            new(BroochesField.Top,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffectContext.Evade, 200), new(StaticEffectContext.AttackSpeedRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.Evade, 160), new(StaticEffectContext.AttackSpeedRate, .01m)
                        }
                    },
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.Evade, 120)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.Evade, 80)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.Evade, 40)}}
                }),
            new(BroochesField.Bottom,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 1_350),
                            new(StaticEffectContext.MoveSpaceRateBattle, .03m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalDamage, 1_150),
                            new(StaticEffectContext.AttackSpeedRate, .02m)
                        }
                    },
                    {BroochesRare.Mega, new Effect[] {new(StaticEffectContext.CriticalDamage, 950)}},
                    {BroochesRare.Kilo, new Effect[] {new(StaticEffectContext.CriticalDamage, 750)}},
                    {BroochesRare.Byte, new Effect[] {new(StaticEffectContext.CriticalDamage, 550)}}
                }),
            new(BroochesField.Gloves,
                BroochesSeries.Sin,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {
                        BroochesRare.Tera,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .06m),
                            new(StaticEffectContext.CriticalRate, .03m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .05m),
                            new(StaticEffectContext.CriticalRate, .02m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .03m),
                            new(StaticEffectContext.CriticalRate, .01m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .02m),
                            new(StaticEffectContext.CriticalRate, .01m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.AttackSpeedRate, .01m),
                            new(StaticEffectContext.CriticalRate, .01m)
                        }
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
                            new(StaticEffectContext.CriticalRate, .03m),
                            new(StaticEffectContext.SuperArmorBreakPowerRate, .15m)
                        }
                    },
                    {
                        BroochesRare.Giga,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalRate, .02m),
                            new(StaticEffectContext.SuperArmorBreakPowerRate, .1m)
                        }
                    },
                    {
                        BroochesRare.Mega,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalRate, .01m),
                            new(StaticEffectContext.SuperArmorBreakPowerRate, .07m)
                        }
                    },
                    {
                        BroochesRare.Kilo,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalRate, .01m),
                            new(StaticEffectContext.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        BroochesRare.Byte,
                        new Effect[]
                        {
                            new(StaticEffectContext.CriticalRate, .01m),
                            new(StaticEffectContext.SuperArmorBreakPowerRate, .03m)
                        }
                    }
                })
        };

        public static BroochSet Get(BroochesField field, BroochesSeries series) =>
            SetEffects.First(x => x.Field == field && x.Series == series);
    }
}