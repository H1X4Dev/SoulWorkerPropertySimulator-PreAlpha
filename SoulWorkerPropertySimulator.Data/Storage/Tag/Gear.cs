using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TagData
    {
        private static readonly IReadOnlyCollection<Tag> GearTag = new Tag[]
        {
            new(TagField.Gear,
                "異常的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefense, 368), new Effect(StaticEffect.Defense, 28)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefense, 274), new Effect(StaticEffect.Defense, 23)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefense, 192), new Effect(StaticEffect.Defense, 17)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefense, 72), new Effect(StaticEffect.Defense, 11)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.GearDefense, 23), new Effect(StaticEffect.Defense, 6)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.GearDefense, 12), new Effect(StaticEffect.Defense, 3)}
                    }
                }),
            new(TagField.Gear,
                "韌性的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefense, .06m), new Effect(StaticEffect.Defense, 28)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefense, .05m), new Effect(StaticEffect.Defense, 23)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefense, .04m), new Effect(StaticEffect.Defense, 17)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefense, .03m), new Effect(StaticEffect.Defense, 11)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.GearDefense, .02m), new Effect(StaticEffect.Defense, 6)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.GearDefense, .01m), new Effect(StaticEffect.Defense, 3)}
                    }
                }),
            new(TagField.Gear,
                "火花的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 368),
                            new Effect(StaticEffect.CriticalDamage, 158)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 274),
                            new Effect(StaticEffect.CriticalDamage, 126)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 192),
                            new Effect(StaticEffect.CriticalDamage, 95)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 72),
                            new Effect(StaticEffect.CriticalDamage, 63)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 23),
                            new Effect(StaticEffect.CriticalDamage, 32)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 12),
                            new Effect(StaticEffect.CriticalDamage, 11)
                        }
                    }
                }),
            new(TagField.Gear,
                "混亂的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .06m),
                            new Effect(StaticEffect.CriticalDamage, 158)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .05m),
                            new Effect(StaticEffect.CriticalDamage, 126)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .04m),
                            new Effect(StaticEffect.CriticalDamage, 95)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .03m),
                            new Effect(StaticEffect.CriticalDamage, 63)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .02m),
                            new Effect(StaticEffect.CriticalDamage, 32)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .01m),
                            new Effect(StaticEffect.CriticalDamage, 11)
                        }
                    }
                }),
            new(TagField.Gear,
                "受詛咒的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 408),
                            new Effect(StaticEffect.CriticalResistanceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 304),
                            new Effect(StaticEffect.CriticalResistanceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 213),
                            new Effect(StaticEffect.CriticalResistanceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 80),
                            new Effect(StaticEffect.CriticalResistanceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 25),
                            new Effect(StaticEffect.CriticalResistanceRate, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "本能的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .06m),
                            new Effect(StaticEffect.CriticalResistanceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .05m),
                            new Effect(StaticEffect.CriticalResistanceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .04m),
                            new Effect(StaticEffect.CriticalResistanceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .03m),
                            new Effect(StaticEffect.CriticalResistanceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .02m),
                            new Effect(StaticEffect.CriticalResistanceRate, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "黎明的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 347),
                            new Effect(StaticEffect.DamageReductionRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 259),
                            new Effect(StaticEffect.DamageReductionRateBasic, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 182),
                            new Effect(StaticEffect.DamageReductionRateBasic, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 68),
                            new Effect(StaticEffect.DamageReductionRateBasic, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "不屈的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .06m),
                            new Effect(StaticEffect.DamageReductionRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .05m),
                            new Effect(StaticEffect.DamageReductionRateBasic, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .04m),
                            new Effect(StaticEffect.DamageReductionRateBasic, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .03m),
                            new Effect(StaticEffect.DamageReductionRateBasic, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "悲鳴的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 347),
                            new Effect(StaticEffect.DamageReductionRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 259),
                            new Effect(StaticEffect.DamageReductionRateBoss, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 182),
                            new Effect(StaticEffect.DamageReductionRateBoss, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 68),
                            new Effect(StaticEffect.DamageReductionRateBoss, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "守護的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .06m),
                            new Effect(StaticEffect.DamageReductionRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .05m),
                            new Effect(StaticEffect.DamageReductionRateBoss, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .04m),
                            new Effect(StaticEffect.DamageReductionRateBoss, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .03m),
                            new Effect(StaticEffect.DamageReductionRateBoss, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "無謀的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 449),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 335),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 235),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .08m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 88),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 28),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 15),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .02m)
                        }
                    }
                }),
            new(TagField.Gear,
                "光暈的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .07m),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .06m),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .05m),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .08m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .04m),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .03m),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .02m),
                            new Effect(StaticEffect.DamageReductionRatePartialDamage, .02m)
                        }
                    }
                }),
            new(TagField.Gear,
                "怪異的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 327),
                            new Effect(StaticEffect.DefenseRate, .09m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 244),
                            new Effect(StaticEffect.DefenseRate, .07m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 171),
                            new Effect(StaticEffect.DefenseRate, .05m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefense, 64), new Effect(StaticEffect.DefenseRate, .04m)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.GearDefense, 20), new Effect(StaticEffect.DefenseRate, .02m)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.GearDefense, 11), new Effect(StaticEffect.DefenseRate, .01m)}
                    }
                }),
            new(TagField.Gear,
                "銅牆鐵壁的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .05m),
                            new Effect(StaticEffect.DefenseRate, .09m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .04m),
                            new Effect(StaticEffect.DefenseRate, .07m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .04m),
                            new Effect(StaticEffect.DefenseRate, .05m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .03m),
                            new Effect(StaticEffect.DefenseRate, .04m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .02m),
                            new Effect(StaticEffect.DefenseRate, .02m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, .01m),
                            new Effect(StaticEffect.DefenseRate, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "探索的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefense, 388), new Effect(StaticEffect.Evade, 59)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefense, 289), new Effect(StaticEffect.Evade, 48)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefense, 203), new Effect(StaticEffect.Evade, 36)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefense, 76), new Effect(StaticEffect.Evade, 24)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.GearDefense, 24), new Effect(StaticEffect.Evade, 12)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.GearDefense, 13), new Effect(StaticEffect.Evade, 6)}
                    }
                }),
            new(TagField.Gear,
                "完美的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefense, .06m), new Effect(StaticEffect.Evade, 59)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefense, .05m), new Effect(StaticEffect.Evade, 48)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefense, .04m), new Effect(StaticEffect.Evade, 36)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefense, .03m), new Effect(StaticEffect.Evade, 24)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.GearDefense, .02m), new Effect(StaticEffect.Evade, 12)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.GearDefense, .01m), new Effect(StaticEffect.Evade, 6)}
                    }
                }),
            new(TagField.Gear,
                "偉大的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 449),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .44m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 335),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .33m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 235),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .22m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 88),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .17m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 28),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 15),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .06m)
                        }
                    }
                }),
            new(TagField.Gear,
                "旅者的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .07m),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .44m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .06m),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .33m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .05m),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .22m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .04m),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .17m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .03m),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .02m),
                            new Effect(StaticEffect.ExpVolumeRateEnemy, .06m)
                        }
                    }
                }),
            new(TagField.Gear,
                "基礎的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefense, 327), new Effect(StaticEffect.Hp, 320)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefense, 244), new Effect(StaticEffect.Hp, 240)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefense, 171), new Effect(StaticEffect.Hp, 192)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefense, 64), new Effect(StaticEffect.Hp, 144)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.GearDefense, 20), new Effect(StaticEffect.Hp, 100)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.GearDefense, 11), new Effect(StaticEffect.Hp, 60)}
                    }
                }),
            new(TagField.Gear,
                "海邊的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .05m), new Effect(StaticEffect.Hp, 320)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .04m), new Effect(StaticEffect.Hp, 240)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .04m), new Effect(StaticEffect.Hp, 192)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .03m), new Effect(StaticEffect.Hp, 144)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .02m), new Effect(StaticEffect.Hp, 100)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .01m), new Effect(StaticEffect.Hp, 60)}
                    }
                }),
            new(TagField.Gear,
                "霸氣的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 408),
                            new Effect(StaticEffect.KillHpRecovery, 500)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 304),
                            new Effect(StaticEffect.KillHpRecovery, 350)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 213),
                            new Effect(StaticEffect.KillHpRecovery, 230)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 80),
                            new Effect(StaticEffect.KillHpRecovery, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 25),
                            new Effect(StaticEffect.KillHpRecovery, 65)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 13),
                            new Effect(StaticEffect.KillHpRecovery, 30)
                        }
                    }
                }),
            new(TagField.Gear,
                "異能力者的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .06m),
                            new Effect(StaticEffect.KillHpRecovery, 500)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .05m),
                            new Effect(StaticEffect.KillHpRecovery, 350)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .04m),
                            new Effect(StaticEffect.KillHpRecovery, 230)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .03m),
                            new Effect(StaticEffect.KillHpRecovery, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .02m),
                            new Effect(StaticEffect.KillHpRecovery, 65)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .01m),
                            new Effect(StaticEffect.KillHpRecovery, 30)
                        }
                    }
                }),
            new(TagField.Gear,
                "和睦的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 449),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 335),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 235),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 88),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .07m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 28),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 15),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .03m)
                        }
                    }
                }),
            new(TagField.Gear,
                "樸素的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .07m),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .06m),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .05m),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .04m),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .07m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .03m),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .02m),
                            new Effect(StaticEffect.MoneyVolumeRateEnemy, .03m)
                        }
                    }
                }),
            new(TagField.Gear,
                "非凡的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 449),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 335),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 235),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .02m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 88),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .02m)
                        }
                    }
                }),
            new(TagField.Gear,
                "鬥志的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .07m),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .06m),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .05m),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .02m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .04m),
                            new Effect(StaticEffect.SoulGateConsumptionReducedRate, .02m)
                        }
                    }
                }),
            new(TagField.Gear,
                "安平的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 388),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 289),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .06m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 203),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 76),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefense, 24),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "野生的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .06m),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .05m),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .06m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .04m),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .03m),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.GearDefenseRate, .02m),
                            new Effect(StaticEffect.SoulNovaVolumeRate, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "寡言的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefense, 368), new Effect(StaticEffect.Stamina, 3)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefense, 274), new Effect(StaticEffect.Stamina, 2)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefense, 192), new Effect(StaticEffect.Stamina, 1)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefense, 72), new Effect(StaticEffect.Stamina, 1)}
                    }
                }),
            new(TagField.Gear,
                "閃光的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .06m), new Effect(StaticEffect.Stamina, 3)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .05m), new Effect(StaticEffect.Stamina, 2)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .04m), new Effect(StaticEffect.Stamina, 1)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.GearDefenseRate, .03m), new Effect(StaticEffect.Stamina, 1)}
                    }
                })
        };
    }
}