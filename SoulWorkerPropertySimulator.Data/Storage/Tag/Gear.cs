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
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 368),
                            new Effect(StaticEffectContext.Defense, 28)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 274),
                            new Effect(StaticEffectContext.Defense, 23)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 192),
                            new Effect(StaticEffectContext.Defense, 17)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 72),
                            new Effect(StaticEffectContext.Defense, 11)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 23),
                            new Effect(StaticEffectContext.Defense, 6)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 12),
                            new Effect(StaticEffectContext.Defense, 3)
                        }
                    }
                }),
            new(TagField.Gear,
                "韌性的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .06m),
                            new Effect(StaticEffectContext.Defense, 28)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.Defense, 23)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.Defense, 17)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.Defense, 11)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .02m),
                            new Effect(StaticEffectContext.Defense, 6)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .01m),
                            new Effect(StaticEffectContext.Defense, 3)
                        }
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
                            new Effect(StaticEffectContext.GearDefense, 368),
                            new Effect(StaticEffectContext.CriticalDamage, 158)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 274),
                            new Effect(StaticEffectContext.CriticalDamage, 126)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 192),
                            new Effect(StaticEffectContext.CriticalDamage, 95)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 72),
                            new Effect(StaticEffectContext.CriticalDamage, 63)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 23),
                            new Effect(StaticEffectContext.CriticalDamage, 32)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 12),
                            new Effect(StaticEffectContext.CriticalDamage, 11)
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
                            new Effect(StaticEffectContext.GearDefense, .06m),
                            new Effect(StaticEffectContext.CriticalDamage, 158)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.CriticalDamage, 126)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.CriticalDamage, 95)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.CriticalDamage, 63)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .02m),
                            new Effect(StaticEffectContext.CriticalDamage, 32)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .01m),
                            new Effect(StaticEffectContext.CriticalDamage, 11)
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
                            new Effect(StaticEffectContext.GearDefense, 408),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 304),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 213),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 80),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 25),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .01m)
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
                            new Effect(StaticEffectContext.GearDefense, .06m),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .02m),
                            new Effect(StaticEffectContext.CriticalResistanceRate, .01m)
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
                            new Effect(StaticEffectContext.GearDefense, 347),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 259),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 182),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 68),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .01m)
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
                            new Effect(StaticEffectContext.GearDefense, .06m),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.DamageReductionRateBasic, .01m)
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
                            new Effect(StaticEffectContext.GearDefense, 347),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 259),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 182),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 68),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .01m)
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
                            new Effect(StaticEffectContext.GearDefense, .06m),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .02m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .01m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.DamageReductionRateBoss, .01m)
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
                            new Effect(StaticEffectContext.GearDefense, 449),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 335),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 235),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .08m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 88),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 28),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 15),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .02m)
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
                            new Effect(StaticEffectContext.GearDefense, .07m),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .06m),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .08m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .02m),
                            new Effect(StaticEffectContext.DamageReductionRatePartialDamage, .02m)
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
                            new Effect(StaticEffectContext.GearDefense, 327),
                            new Effect(StaticEffectContext.DefenseRate, .09m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 244),
                            new Effect(StaticEffectContext.DefenseRate, .07m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 171),
                            new Effect(StaticEffectContext.DefenseRate, .05m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 64),
                            new Effect(StaticEffectContext.DefenseRate, .04m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 20),
                            new Effect(StaticEffectContext.DefenseRate, .02m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 11),
                            new Effect(StaticEffectContext.DefenseRate, .01m)
                        }
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
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.DefenseRate, .09m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.DefenseRate, .07m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.DefenseRate, .05m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.DefenseRate, .04m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .02m),
                            new Effect(StaticEffectContext.DefenseRate, .02m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .01m),
                            new Effect(StaticEffectContext.DefenseRate, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "探索的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 388),
                            new Effect(StaticEffectContext.Evade, 59)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 289),
                            new Effect(StaticEffectContext.Evade, 48)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 203),
                            new Effect(StaticEffectContext.Evade, 36)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 76),
                            new Effect(StaticEffectContext.Evade, 24)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 24),
                            new Effect(StaticEffectContext.Evade, 12)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 13),
                            new Effect(StaticEffectContext.Evade, 6)
                        }
                    }
                }),
            new(TagField.Gear,
                "完美的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .06m),
                            new Effect(StaticEffectContext.Evade, 59)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .05m),
                            new Effect(StaticEffectContext.Evade, 48)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .04m),
                            new Effect(StaticEffectContext.Evade, 36)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .03m),
                            new Effect(StaticEffectContext.Evade, 24)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .02m),
                            new Effect(StaticEffectContext.Evade, 12)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, .01m),
                            new Effect(StaticEffectContext.Evade, 6)
                        }
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
                            new Effect(StaticEffectContext.GearDefense, 449),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .44m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 335),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .33m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 235),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .22m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 88),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .17m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 28),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 15),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .06m)
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
                            new Effect(StaticEffectContext.GearDefenseRate, .07m),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .44m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .06m),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .33m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .05m),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .22m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .17m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .03m),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .02m),
                            new Effect(StaticEffectContext.ExpVolumeRateEnemy, .06m)
                        }
                    }
                }),
            new(TagField.Gear,
                "基礎的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 327),
                            new Effect(StaticEffectContext.Hp, 320)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 244),
                            new Effect(StaticEffectContext.Hp, 240)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 171),
                            new Effect(StaticEffectContext.Hp, 192)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 64),
                            new Effect(StaticEffectContext.Hp, 144)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 20),
                            new Effect(StaticEffectContext.Hp, 100)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 11),
                            new Effect(StaticEffectContext.Hp, 60)
                        }
                    }
                }),
            new(TagField.Gear,
                "海邊的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .05m),
                            new Effect(StaticEffectContext.Hp, 320)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.Hp, 240)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.Hp, 192)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .03m),
                            new Effect(StaticEffectContext.Hp, 144)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .02m),
                            new Effect(StaticEffectContext.Hp, 100)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .01m),
                            new Effect(StaticEffectContext.Hp, 60)
                        }
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
                            new Effect(StaticEffectContext.GearDefense, 408),
                            new Effect(StaticEffectContext.KillHpRecovery, 500)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 304),
                            new Effect(StaticEffectContext.KillHpRecovery, 350)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 213),
                            new Effect(StaticEffectContext.KillHpRecovery, 230)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 80),
                            new Effect(StaticEffectContext.KillHpRecovery, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 25),
                            new Effect(StaticEffectContext.KillHpRecovery, 65)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 13),
                            new Effect(StaticEffectContext.KillHpRecovery, 30)
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
                            new Effect(StaticEffectContext.GearDefenseRate, .06m),
                            new Effect(StaticEffectContext.KillHpRecovery, 500)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .05m),
                            new Effect(StaticEffectContext.KillHpRecovery, 350)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.KillHpRecovery, 230)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .03m),
                            new Effect(StaticEffectContext.KillHpRecovery, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .02m),
                            new Effect(StaticEffectContext.KillHpRecovery, 65)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .01m),
                            new Effect(StaticEffectContext.KillHpRecovery, 30)
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
                            new Effect(StaticEffectContext.GearDefense, 449),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 335),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 235),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 88),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .07m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 28),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 15),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .03m)
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
                            new Effect(StaticEffectContext.GearDefenseRate, .07m),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .06m),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .11m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .05m),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .07m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .03m),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .02m),
                            new Effect(StaticEffectContext.MoneyVolumeRateEnemy, .03m)
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
                            new Effect(StaticEffectContext.GearDefense, 449),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 335),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 235),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .02m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 88),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .02m)
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
                            new Effect(StaticEffectContext.GearDefenseRate, .07m),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .06m),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .03m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .05m),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .02m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.SoulGateConsumptionReducedRate, .02m)
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
                            new Effect(StaticEffectContext.GearDefense, 388),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 289),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .06m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 203),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 76),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 24),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .01m)
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
                            new Effect(StaticEffectContext.GearDefenseRate, .06m),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .05m),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .06m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .03m),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .02m),
                            new Effect(StaticEffectContext.SoulNovaVolumeRate, .01m)
                        }
                    }
                }),
            new(TagField.Gear,
                "寡言的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 368),
                            new Effect(StaticEffectContext.Stamina, 3)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 274),
                            new Effect(StaticEffectContext.Stamina, 2)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 192),
                            new Effect(StaticEffectContext.Stamina, 1)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefense, 72),
                            new Effect(StaticEffectContext.Stamina, 1)
                        }
                    }
                }),
            new(TagField.Gear,
                "閃光的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .06m),
                            new Effect(StaticEffectContext.Stamina, 3)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .05m),
                            new Effect(StaticEffectContext.Stamina, 2)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .04m),
                            new Effect(StaticEffectContext.Stamina, 1)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.GearDefenseRate, .03m),
                            new Effect(StaticEffectContext.Stamina, 1)
                        }
                    }
                })
        };
    }
}