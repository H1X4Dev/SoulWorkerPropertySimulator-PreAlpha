using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TagData
    {
        private static readonly IReadOnlyCollection<Tag> GearTag = new Tag[]
        {
            new("異常的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.GearDefense, 368), new Effect(Static.Defense, 28)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 274), new Effect(Static.Defense, 23)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.GearDefense, 192), new Effect(Static.Defense, 17)}},
                    {TagRare.Valuable, new[] {new Effect(Static.GearDefense, 72), new Effect(Static.Defense, 11)}},
                    {TagRare.Magical, new[] {new Effect(Static.GearDefense, 23), new Effect(Static.Defense, 6)}},
                    {TagRare.Common, new[] {new Effect(Static.GearDefense, 12), new Effect(Static.Defense, 3)}}
                }),
            new("韌性的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.GearDefense, .06m), new Effect(Static.Defense, 28)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, .05m), new Effect(Static.Defense, 23)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.GearDefense, .04m), new Effect(Static.Defense, 17)}},
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, .03m), new Effect(Static.Defense, 11)}
                    },
                    {TagRare.Magical, new[] {new Effect(Static.GearDefense, .02m), new Effect(Static.Defense, 6)}},
                    {TagRare.Common, new[] {new Effect(Static.GearDefense, .01m), new Effect(Static.Defense, 3)}}
                }),
            new("火花的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, 368), new Effect(Static.CriticalDamage, 158)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 274), new Effect(Static.CriticalDamage, 126)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, 192), new Effect(Static.CriticalDamage, 95)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 72), new Effect(Static.CriticalDamage, 63)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, 23), new Effect(Static.CriticalDamage, 32)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefense, 12), new Effect(Static.CriticalDamage, 11)}
                    }
                }),
            new("混亂的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, .06m), new Effect(Static.CriticalDamage, 158)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, .05m), new Effect(Static.CriticalDamage, 126)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, .04m), new Effect(Static.CriticalDamage, 95)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, .03m), new Effect(Static.CriticalDamage, 63)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, .02m), new Effect(Static.CriticalDamage, 32)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefense, .01m), new Effect(Static.CriticalDamage, 11)}
                    }
                }),
            new("受詛咒的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, 408), new Effect(Static.CriticalResistanceRate, .05m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 304), new Effect(Static.CriticalResistanceRate, .04m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, 213), new Effect(Static.CriticalResistanceRate, .03m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 80), new Effect(Static.CriticalResistanceRate, .02m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, 25), new Effect(Static.CriticalResistanceRate, .01m)}
                    }
                }),
            new("本能的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, .06m),
                            new Effect(Static.CriticalResistanceRate, .05m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, .05m),
                            new Effect(Static.CriticalResistanceRate, .04m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, .04m),
                            new Effect(Static.CriticalResistanceRate, .03m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefense, .03m),
                            new Effect(Static.CriticalResistanceRate, .02m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.GearDefense, .02m),
                            new Effect(Static.CriticalResistanceRate, .01m)
                        }
                    }
                }),
            new("黎明的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, 347),
                            new Effect(Static.DamageReductionRateBasic, .03m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, 259),
                            new Effect(Static.DamageReductionRateBasic, .02m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, 182),
                            new Effect(Static.DamageReductionRateBasic, .01m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefense, 68),
                            new Effect(Static.DamageReductionRateBasic, .01m)
                        }
                    }
                }),
            new("不屈的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, .06m),
                            new Effect(Static.DamageReductionRateBasic, .03m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, .05m),
                            new Effect(Static.DamageReductionRateBasic, .02m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, .04m),
                            new Effect(Static.DamageReductionRateBasic, .01m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefense, .03m),
                            new Effect(Static.DamageReductionRateBasic, .01m)
                        }
                    }
                }),
            new("悲鳴的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, 347),
                            new Effect(Static.DamageReductionRateBoss, .03m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, 259),
                            new Effect(Static.DamageReductionRateBoss, .02m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, 182),
                            new Effect(Static.DamageReductionRateBoss, .01m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 68), new Effect(Static.DamageReductionRateBoss, .01m)}
                    }
                }),
            new("守護的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, .06m),
                            new Effect(Static.DamageReductionRateBoss, .03m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, .05m),
                            new Effect(Static.DamageReductionRateBoss, .02m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, .04m),
                            new Effect(Static.DamageReductionRateBoss, .01m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefense, .03m),
                            new Effect(Static.DamageReductionRateBoss, .01m)
                        }
                    }
                }),
            new("無謀的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, 449),
                            new Effect(Static.DamageReductionRatePartialDamage, .15m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, 335),
                            new Effect(Static.DamageReductionRatePartialDamage, .11m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, 235),
                            new Effect(Static.DamageReductionRatePartialDamage, .08m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefense, 88),
                            new Effect(Static.DamageReductionRatePartialDamage, .05m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.GearDefense, 28),
                            new Effect(Static.DamageReductionRatePartialDamage, .03m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.GearDefense, 15),
                            new Effect(Static.DamageReductionRatePartialDamage, .02m)
                        }
                    }
                }),
            new("光暈的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, .07m),
                            new Effect(Static.DamageReductionRatePartialDamage, .15m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, .06m),
                            new Effect(Static.DamageReductionRatePartialDamage, .11m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, .05m),
                            new Effect(Static.DamageReductionRatePartialDamage, .08m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefense, .04m),
                            new Effect(Static.DamageReductionRatePartialDamage, .05m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.GearDefense, .03m),
                            new Effect(Static.DamageReductionRatePartialDamage, .03m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.GearDefense, .02m),
                            new Effect(Static.DamageReductionRatePartialDamage, .02m)
                        }
                    }
                }),
            new("怪異的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, 327), new Effect(Static.DefenseRate, .09m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 244), new Effect(Static.DefenseRate, .07m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, 171), new Effect(Static.DefenseRate, .05m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 64), new Effect(Static.DefenseRate, .04m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, 20), new Effect(Static.DefenseRate, .02m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefense, 11), new Effect(Static.DefenseRate, .01m)}
                    }
                }),
            new("銅牆鐵壁的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, .05m), new Effect(Static.DefenseRate, .09m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, .04m), new Effect(Static.DefenseRate, .07m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, .04m), new Effect(Static.DefenseRate, .05m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, .03m), new Effect(Static.DefenseRate, .04m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, .02m), new Effect(Static.DefenseRate, .02m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefense, .01m), new Effect(Static.DefenseRate, .01m)}
                    }
                }),
            new("探索的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {new Effect(Static.GearDefense, 388), new Effect(Static.Evade, 59)}},
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 289), new Effect(Static.Evade, 48)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.GearDefense, 203), new Effect(Static.Evade, 36)}},
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 76), new Effect(Static.Evade, 24)}
                    },
                    {TagRare.Magical, new[] {new Effect(Static.GearDefense, 24), new Effect(Static.Evade, 12)}},
                    {TagRare.Common, new[] {new Effect(Static.GearDefense, 13), new Effect(Static.Evade, 6)}}
                }),
            new("完美的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.GearDefense, .06m), new Effect(Static.Evade, 59)}
                    },
                    {TagRare.Legendary, new[] {new Effect(Static.GearDefense, .05m), new Effect(Static.Evade, 48)}},
                    {TagRare.Unique, new[] {new Effect(Static.GearDefense, .04m), new Effect(Static.Evade, 36)}},
                    {TagRare.Valuable, new[] {new Effect(Static.GearDefense, .03m), new Effect(Static.Evade, 24)}},
                    {TagRare.Magical, new[] {new Effect(Static.GearDefense, .02m), new Effect(Static.Evade, 12)}},
                    {TagRare.Common, new[] {new Effect(Static.GearDefense, .01m), new Effect(Static.Evade, 6)}}
                }),
            new("偉大的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, 449), new Effect(Static.ExpVolumeRateEnemy, .44m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 335), new Effect(Static.ExpVolumeRateEnemy, .33m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, 235), new Effect(Static.ExpVolumeRateEnemy, .22m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 88), new Effect(Static.ExpVolumeRateEnemy, .17m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, 28), new Effect(Static.ExpVolumeRateEnemy, .11m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefense, 15), new Effect(Static.ExpVolumeRateEnemy, .06m)}
                    }
                }),
            new("旅者的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .07m),
                            new Effect(Static.ExpVolumeRateEnemy, .44m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .06m),
                            new Effect(Static.ExpVolumeRateEnemy, .33m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .05m),
                            new Effect(Static.ExpVolumeRateEnemy, .22m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .04m),
                            new Effect(Static.ExpVolumeRateEnemy, .17m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .03m),
                            new Effect(Static.ExpVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .02m),
                            new Effect(Static.ExpVolumeRateEnemy, .06m)
                        }
                    }
                }),
            new("基礎的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {TagRare.Heroic, new[] {new Effect(Static.GearDefense, 327), new Effect(Static.Hp, 320)}},
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 244), new Effect(Static.Hp, 240)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.GearDefense, 171), new Effect(Static.Hp, 192)}},
                    {TagRare.Valuable, new[] {new Effect(Static.GearDefense, 64), new Effect(Static.Hp, 144)}},
                    {TagRare.Magical, new[] {new Effect(Static.GearDefense, 20), new Effect(Static.Hp, 100)}},
                    {TagRare.Common, new[] {new Effect(Static.GearDefense, 11), new Effect(Static.Hp, 60)}}
                }),
            new("海邊的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.GearDefenseRate, .05m), new Effect(Static.Hp, 320)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefenseRate, .04m), new Effect(Static.Hp, 240)}
                    },
                    {TagRare.Unique, new[] {new Effect(Static.GearDefenseRate, .04m), new Effect(Static.Hp, 192)}},
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefenseRate, .03m), new Effect(Static.Hp, 144)}
                    },
                    {TagRare.Magical, new[] {new Effect(Static.GearDefenseRate, .02m), new Effect(Static.Hp, 100)}},
                    {TagRare.Common, new[] {new Effect(Static.GearDefenseRate, .01m), new Effect(Static.Hp, 60)}}
                }),
            new("霸氣的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, 408), new Effect(Static.KillHpRecovery, 500)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 304), new Effect(Static.KillHpRecovery, 350)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, 213), new Effect(Static.KillHpRecovery, 230)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 80), new Effect(Static.KillHpRecovery, 140)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, 25), new Effect(Static.KillHpRecovery, 65)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefense, 13), new Effect(Static.KillHpRecovery, 30)}
                    }
                }),
            new("異能力者的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefenseRate, .06m), new Effect(Static.KillHpRecovery, 500)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefenseRate, .05m), new Effect(Static.KillHpRecovery, 350)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefenseRate, .04m), new Effect(Static.KillHpRecovery, 230)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefenseRate, .03m), new Effect(Static.KillHpRecovery, 140)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefenseRate, .02m), new Effect(Static.KillHpRecovery, 65)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefenseRate, .01m), new Effect(Static.KillHpRecovery, 30)}
                    }
                }),
            new("和睦的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, 449), new Effect(Static.MoneyVolumeRateEnemy, .15m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 335), new Effect(Static.MoneyVolumeRateEnemy, .11m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, 235), new Effect(Static.MoneyVolumeRateEnemy, .09m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 88), new Effect(Static.MoneyVolumeRateEnemy, .07m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, 28), new Effect(Static.MoneyVolumeRateEnemy, .05m)}
                    },
                    {
                        TagRare.Common,
                        new[] {new Effect(Static.GearDefense, 15), new Effect(Static.MoneyVolumeRateEnemy, .03m)}
                    }
                }),
            new("樸素的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .07m),
                            new Effect(Static.MoneyVolumeRateEnemy, .15m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .06m),
                            new Effect(Static.MoneyVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .05m),
                            new Effect(Static.MoneyVolumeRateEnemy, .09m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .04m),
                            new Effect(Static.MoneyVolumeRateEnemy, .07m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .03m),
                            new Effect(Static.MoneyVolumeRateEnemy, .05m)
                        }
                    },
                    {
                        TagRare.Common,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .02m),
                            new Effect(Static.MoneyVolumeRateEnemy, .03m)
                        }
                    }
                }),
            new("非凡的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefense, 449),
                            new Effect(Static.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefense, 335),
                            new Effect(Static.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefense, 235),
                            new Effect(Static.SoulGateConsumptionReducedRate, .02m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefense, 88),
                            new Effect(Static.SoulGateConsumptionReducedRate, .02m)
                        }
                    }
                }),
            new("鬥志的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .07m),
                            new Effect(Static.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .06m),
                            new Effect(Static.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .05m),
                            new Effect(Static.SoulGateConsumptionReducedRate, .02m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .04m),
                            new Effect(Static.SoulGateConsumptionReducedRate, .02m)
                        }
                    }
                }),
            new("安平的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefense, 388), new Effect(Static.SoulNovaVolumeRate, .07m)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefense, 289), new Effect(Static.SoulNovaVolumeRate, .06m)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefense, 203), new Effect(Static.SoulNovaVolumeRate, .04m)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefense, 76), new Effect(Static.SoulNovaVolumeRate, .03m)}
                    },
                    {
                        TagRare.Magical,
                        new[] {new Effect(Static.GearDefense, 24), new Effect(Static.SoulNovaVolumeRate, .01m)}
                    }
                }),
            new("野生的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .06m),
                            new Effect(Static.SoulNovaVolumeRate, .07m)
                        }
                    },
                    {
                        TagRare.Legendary,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .05m),
                            new Effect(Static.SoulNovaVolumeRate, .06m)
                        }
                    },
                    {
                        TagRare.Unique,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .04m),
                            new Effect(Static.SoulNovaVolumeRate, .04m)
                        }
                    },
                    {
                        TagRare.Valuable,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .03m),
                            new Effect(Static.SoulNovaVolumeRate, .03m)
                        }
                    },
                    {
                        TagRare.Magical,
                        new[]
                        {
                            new Effect(Static.GearDefenseRate, .02m),
                            new Effect(Static.SoulNovaVolumeRate, .01m)
                        }
                    }
                }),
            new("寡言的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic, new[] {new Effect(Static.GearDefense, 368), new Effect(Static.Stamina, 3)}
                    },
                    {TagRare.Legendary, new[] {new Effect(Static.GearDefense, 274), new Effect(Static.Stamina, 2)}},
                    {TagRare.Unique, new[] {new Effect(Static.GearDefense, 192), new Effect(Static.Stamina, 1)}},
                    {TagRare.Valuable, new[] {new Effect(Static.GearDefense, 72), new Effect(Static.Stamina, 1)}}
                }),
            new("閃光的",
                TagField.Gear,
                new Dictionary<TagRare, IReadOnlyCollection<Effect>>
                {
                    {
                        TagRare.Heroic,
                        new[] {new Effect(Static.GearDefenseRate, .06m), new Effect(Static.Stamina, 3)}
                    },
                    {
                        TagRare.Legendary,
                        new[] {new Effect(Static.GearDefenseRate, .05m), new Effect(Static.Stamina, 2)}
                    },
                    {
                        TagRare.Unique,
                        new[] {new Effect(Static.GearDefenseRate, .04m), new Effect(Static.Stamina, 1)}
                    },
                    {
                        TagRare.Valuable,
                        new[] {new Effect(Static.GearDefenseRate, .03m), new Effect(Static.Stamina, 1)}
                    }
                })
        };
    }
}