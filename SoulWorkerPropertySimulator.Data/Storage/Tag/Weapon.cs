using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TagData
    {
        private static readonly IReadOnlyCollection<Tag> WeaponTag = new Tag[]
        {
            new("異常的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.WeaponAttack, 481), new Effect(Static.Attack, 112)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 359), new Effect(Static.Attack, 96)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.WeaponAttack, 252), new Effect(Static.Attack, 72)}},
                    {TagRare.Valuable, new[] {new Effect(Static.WeaponAttack, 95), new Effect(Static.Attack, 48)}},
                    {TagRare.Magical, new[] {new Effect(Static.WeaponAttack, 31), new Effect(Static.Attack, 24)}},
                    {TagRare.Common, new[] {new Effect(Static.WeaponAttack, 16), new Effect(Static.Attack, 14)}}
                }),
            new("放置的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.WeaponAttack, 541), new Effect(Static.Attack, 315)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 404), new Effect(Static.Attack, 252)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.WeaponAttack, 283), new Effect(Static.Attack, 189)}},
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 107), new Effect(Static.Attack, 126)}
                    },
                    {TagRare.Magical, new[] {new Effect(Static.WeaponAttack, 35), new Effect(Static.Attack, 63)}},
                    {TagRare.Common, new[] {new Effect(Static.WeaponAttack, 18), new Effect(Static.Attack, 32)}}
                }),
            new("挑戰者的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .13m), new Effect(Static.Accuracy, 315)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .1m), new Effect(Static.Accuracy, 252)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.Accuracy, 189)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .06m), new Effect(Static.Accuracy, 126)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.Accuracy, 63)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.Accuracy, 32)}
                    }
                }),
            new("剛直的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .12m), new Effect(Static.Accuracy, 112)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.Accuracy, 96)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .08m), new Effect(Static.Accuracy, 72)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .05m), new Effect(Static.Accuracy, 48)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.Accuracy, 24)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.Accuracy, 14)}
                    }
                }),
            new("怪異的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 481), new Effect(Static.AttackRate, .15m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 359), new Effect(Static.AttackRate, .12m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 252), new Effect(Static.AttackRate, .1m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 95), new Effect(Static.AttackRate, .08m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 31), new Effect(Static.AttackRate, .05m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 16), new Effect(Static.AttackRate, .03m)}
                    }
                }),
            new("鋼鐵的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .12m), new Effect(Static.AttackRate, .15m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.AttackRate, .12m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .08m), new Effect(Static.AttackRate, .1m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .05m), new Effect(Static.AttackRate, .08m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.AttackRate, .05m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.AttackRate, .03m)}
                    }
                }),
            new("粗糙的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 481), new Effect(Static.CriticalDamage, 384)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 359), new Effect(Static.CriticalDamage, 240)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 252), new Effect(Static.CriticalDamage, 200)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 95), new Effect(Static.CriticalDamage, 140)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 31), new Effect(Static.CriticalDamage, 80)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 16), new Effect(Static.CriticalDamage, 40)}
                    }
                }),
            new("炙熱的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .12m), new Effect(Static.CriticalDamage, 384)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.CriticalDamage, 240)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .08m), new Effect(Static.CriticalDamage, 200)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .05m), new Effect(Static.CriticalDamage, 140)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.CriticalDamage, 80)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.CriticalDamage, 40)}
                    }
                }),
            new("附加的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 481), new Effect(Static.CriticalRate, .07m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 359), new Effect(Static.CriticalRate, .05m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 252), new Effect(Static.CriticalRate, .04m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 95), new Effect(Static.CriticalRate, .03m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 31), new Effect(Static.CriticalRate, .02m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 16), new Effect(Static.CriticalRate, .01m)}
                    }
                }),
            new("火山的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .12m), new Effect(Static.CriticalRate, .07m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.CriticalRate, .05m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .08m), new Effect(Static.CriticalRate, .04m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .05m), new Effect(Static.CriticalRate, .03m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.CriticalRate, .02m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.CriticalRate, .01m)}
                    }
                }),
            new("狂暴的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 481), new Effect(Static.DefenseBreakRate, .04m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 359), new Effect(Static.DefenseBreakRate, .04m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 252), new Effect(Static.DefenseBreakRate, .03m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 95), new Effect(Static.DefenseBreakRate, .02m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 31), new Effect(Static.DefenseBreakRate, .01m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 16), new Effect(Static.DefenseBreakRate, .01m)}
                    }
                }),
            new("刺眼的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .12m), new Effect(Static.DefenseBreakRate, .04m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.DefenseBreakRate, .04m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .08m), new Effect(Static.DefenseBreakRate, .03m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .05m), new Effect(Static.DefenseBreakRate, .02m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.DefenseBreakRate, .01m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.DefenseBreakRate, .01m)}
                    }
                }),
            new("遺失的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 511), new Effect(Static.ExtraDamageRateBasic, .12m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 381), new Effect(Static.ExtraDamageRateBasic, .09m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 267), new Effect(Static.ExtraDamageRateBasic, .06m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 101), new Effect(Static.ExtraDamageRateBasic, .05m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 33), new Effect(Static.ExtraDamageRateBasic, .03m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 17), new Effect(Static.ExtraDamageRateBasic, .01m)}
                    }
                }),
            new("閃電的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .12m),
                            new Effect(Static.ExtraDamageRateBasic, .12m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .1m),
                            new Effect(Static.ExtraDamageRateBasic, .09m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .08m),
                            new Effect(Static.ExtraDamageRateBasic, .06m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .06m),
                            new Effect(Static.ExtraDamageRateBasic, .05m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .04m),
                            new Effect(Static.ExtraDamageRateBasic, .03m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .02m),
                            new Effect(Static.ExtraDamageRateBasic, .01m)
                        }
                    }
                }),
            new("高喊的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 511), new Effect(Static.ExtraDamageRateBoss, .12m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 381), new Effect(Static.ExtraDamageRateBoss, .09m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 267), new Effect(Static.ExtraDamageRateBoss, .06m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 101), new Effect(Static.ExtraDamageRateBoss, .05m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 33), new Effect(Static.ExtraDamageRateBoss, .03m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 17), new Effect(Static.ExtraDamageRateBoss, .01m)}
                    }
                }),
            new("凌晨的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .12m),
                            new Effect(Static.ExtraDamageRateBoss, .12m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .1m),
                            new Effect(Static.ExtraDamageRateBoss, .09m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .08m),
                            new Effect(Static.ExtraDamageRateBoss, .06m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .06m),
                            new Effect(Static.ExtraDamageRateBoss, .05m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .04m),
                            new Effect(Static.ExtraDamageRateBoss, .03m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .02m),
                            new Effect(Static.ExtraDamageRateBoss, .01m)
                        }
                    }
                }),
            new("假的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 481), new Effect(Static.ExtraDamageRateGolden, .16m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 359), new Effect(Static.ExtraDamageRateGolden, .12m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 252), new Effect(Static.ExtraDamageRateGolden, .09m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 95), new Effect(Static.ExtraDamageRateGolden, .06m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 31), new Effect(Static.ExtraDamageRateGolden, .04m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 16), new Effect(Static.ExtraDamageRateGolden, .03m)}
                    }
                }),
            new("假的(%)",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .12m),
                            new Effect(Static.ExtraDamageRateGolden, .16m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .09m),
                            new Effect(Static.ExtraDamageRateGolden, .12m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .08m),
                            new Effect(Static.ExtraDamageRateGolden, .09m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .05m),
                            new Effect(Static.ExtraDamageRateGolden, .06m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .04m),
                            new Effect(Static.ExtraDamageRateGolden, .04m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .02m),
                            new Effect(Static.ExtraDamageRateGolden, .03m)
                        }
                    }
                }),
            new("傲慢的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 481), new Effect(Static.ExtraDamageRatePrimal, .16m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 359), new Effect(Static.ExtraDamageRatePrimal, .12m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 252), new Effect(Static.ExtraDamageRatePrimal, .09m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 95), new Effect(Static.ExtraDamageRatePrimal, .06m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 31), new Effect(Static.ExtraDamageRatePrimal, .04m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 16), new Effect(Static.ExtraDamageRatePrimal, .03m)}
                    }
                }),
            new("傲慢的(%)",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .12m),
                            new Effect(Static.ExtraDamageRatePrimal, .16m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .09m),
                            new Effect(Static.ExtraDamageRatePrimal, .12m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .08m),
                            new Effect(Static.ExtraDamageRatePrimal, .09m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .05m),
                            new Effect(Static.ExtraDamageRatePrimal, .06m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .04m),
                            new Effect(Static.ExtraDamageRatePrimal, .04m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .02m),
                            new Effect(Static.ExtraDamageRatePrimal, .03m)
                        }
                    }
                }),
            new("慈悲的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.WeaponAttack, 541), new Effect(Static.Hp, 1_800)}
                    },
                    {TagRare.Legendary, new[] {new Effect(Static.WeaponAttack, 404), new Effect(Static.Hp, 1_260)}},
                    {TagRare.Unique, new[] {new Effect(Static.WeaponAttack, 283), new Effect(Static.Hp, 810)}},
                    {TagRare.Valuable, new[] {new Effect(Static.WeaponAttack, 107), new Effect(Static.Hp, 450)}},
                    {TagRare.Magical, new[] {new Effect(Static.WeaponAttack, 35), new Effect(Static.Hp, 225)}},
                    {TagRare.Common, new[] {new Effect(Static.WeaponAttack, 18), new Effect(Static.Hp, 135)}}
                }),
            new("執著的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .13m), new Effect(Static.Hp, 1_800)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .1m), new Effect(Static.Hp, 1_260)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.Hp, 810)}},
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .06m), new Effect(Static.Hp, 450)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.Hp, 225)}
                    },
                    {TagRare.Common, new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.Hp, 135)}}
                }),
            new("贖罪的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 541), new Effect(Static.MoveSpaceRate, .05m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 404), new Effect(Static.MoveSpaceRate, .04m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 283), new Effect(Static.MoveSpaceRate, .03m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 107), new Effect(Static.MoveSpaceRate, .02m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 35), new Effect(Static.MoveSpaceRate, .01m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 18), new Effect(Static.MoveSpaceRate, .01m)}
                    }
                }),
            new("多雲的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .13m), new Effect(Static.MoveSpaceRate, .05m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .1m), new Effect(Static.MoveSpaceRate, .04m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.MoveSpaceRate, .03m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .06m), new Effect(Static.MoveSpaceRate, .02m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.MoveSpaceRate, .01m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.MoveSpaceRate, .01m)}
                    }
                }),
            new("生銹的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttack, 662), new Effect(Static.PartialDamageRate, .55m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 493), new Effect(Static.PartialDamageRate, .44m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttack, 346), new Effect(Static.PartialDamageRate, .33m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttack, 130), new Effect(Static.PartialDamageRate, .22m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttack, 42), new Effect(Static.PartialDamageRate, .11m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttack, 22), new Effect(Static.PartialDamageRate, .06m)}
                    }
                }),
            new("螺旋的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .16m),
                            new Effect(Static.PartialDamageRate, .55m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .13m),
                            new Effect(Static.PartialDamageRate, .44m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .1m), new Effect(Static.PartialDamageRate, .33m)}
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .07m),
                            new Effect(Static.PartialDamageRate, .22m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .05m),
                            new Effect(Static.PartialDamageRate, .11m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .03m),
                            new Effect(Static.PartialDamageRate, .06m)
                        }
                    }
                }),
            new("疲倦者的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.WeaponAttack, 541), new Effect(Static.Stamina, 6)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttack, 404), new Effect(Static.Stamina, 5)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.WeaponAttack, 283), new Effect(Static.Stamina, 4)}},
                    {TagRare.Valuable, new[] {new Effect(Static.WeaponAttack, 107), new Effect(Static.Stamina, 3)}},
                    {TagRare.Magical, new[] {new Effect(Static.WeaponAttack, 35), new Effect(Static.Stamina, 2)}},
                    {TagRare.Common, new[] {new Effect(Static.WeaponAttack, 18), new Effect(Static.Stamina, 1)}}
                }),
            new("幹練的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.WeaponAttackRate, .13m), new Effect(Static.Stamina, 6)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.WeaponAttackRate, .1m), new Effect(Static.Stamina, 5)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.WeaponAttackRate, .09m), new Effect(Static.Stamina, 4)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.WeaponAttackRate, .06m), new Effect(Static.Stamina, 3)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.WeaponAttackRate, .04m), new Effect(Static.Stamina, 2)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.WeaponAttackRate, .02m), new Effect(Static.Stamina, 1)}
                    }
                }),
            new("激流的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.WeaponAttack, 601),
                            new Effect(Static.SuperArmorBreakPowerRate, .22m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.WeaponAttack, 448),
                            new Effect(Static.SuperArmorBreakPowerRate, .16m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.WeaponAttack, 314),
                            new Effect(Static.SuperArmorBreakPowerRate, .12m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.WeaponAttack, 118),
                            new Effect(Static.SuperArmorBreakPowerRate, .08m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.WeaponAttack, 38),
                            new Effect(Static.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.WeaponAttack, 20),
                            new Effect(Static.SuperArmorBreakPowerRate, .03m)
                        }
                    }
                }),
            new("颱風的",
                TagField.Weapon,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .14m),
                            new Effect(Static.SuperArmorBreakPowerRate, .22m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .11m),
                            new Effect(Static.SuperArmorBreakPowerRate, .16m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .09m),
                            new Effect(Static.SuperArmorBreakPowerRate, .12m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .06m),
                            new Effect(Static.SuperArmorBreakPowerRate, .08m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .04m),
                            new Effect(Static.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.WeaponAttackRate, .02m),
                            new Effect(Static.SuperArmorBreakPowerRate, .03m)
                        }
                    }
                })
        };
    }
}