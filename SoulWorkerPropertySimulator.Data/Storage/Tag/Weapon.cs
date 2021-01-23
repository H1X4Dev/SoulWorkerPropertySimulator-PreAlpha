using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TagData
    {
        private static readonly IReadOnlyCollection<Tag> WeaponTag = new Tag[]
        {
            new(TagField.Weapon,
                "異常的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 481),
                            new Effect(StaticEffectContext.Attack, 112)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 359),
                            new Effect(StaticEffectContext.Attack, 96)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 252),
                            new Effect(StaticEffectContext.Attack, 72)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 95),
                            new Effect(StaticEffectContext.Attack, 48)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 31),
                            new Effect(StaticEffectContext.Attack, 24)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 16),
                            new Effect(StaticEffectContext.Attack, 14)
                        }
                    }
                }),
            new(TagField.Weapon,
                "放置的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 541),
                            new Effect(StaticEffectContext.Attack, 315)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 404),
                            new Effect(StaticEffectContext.Attack, 252)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 283),
                            new Effect(StaticEffectContext.Attack, 189)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 107),
                            new Effect(StaticEffectContext.Attack, 126)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 35),
                            new Effect(StaticEffectContext.Attack, 63)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 18),
                            new Effect(StaticEffectContext.Attack, 32)
                        }
                    }
                }),
            new(TagField.Weapon,
                "挑戰者的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .13m),
                            new Effect(StaticEffectContext.Accuracy, 315)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .1m),
                            new Effect(StaticEffectContext.Accuracy, 252)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.Accuracy, 189)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .06m),
                            new Effect(StaticEffectContext.Accuracy, 126)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.Accuracy, 63)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.Accuracy, 32)
                        }
                    }
                }),
            new(TagField.Weapon,
                "剛直的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.Accuracy, 112)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.Accuracy, 96)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.Accuracy, 72)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.Accuracy, 48)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.Accuracy, 24)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.Accuracy, 14)
                        }
                    }
                }),
            new(TagField.Weapon,
                "怪異的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 481),
                            new Effect(StaticEffectContext.AttackRate, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 359),
                            new Effect(StaticEffectContext.AttackRate, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 252),
                            new Effect(StaticEffectContext.AttackRate, .1m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 95),
                            new Effect(StaticEffectContext.AttackRate, .08m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 31),
                            new Effect(StaticEffectContext.AttackRate, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 16),
                            new Effect(StaticEffectContext.AttackRate, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "鋼鐵的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.AttackRate, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.AttackRate, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.AttackRate, .1m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.AttackRate, .08m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.AttackRate, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.AttackRate, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "粗糙的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 481),
                            new Effect(StaticEffectContext.CriticalDamage, 384)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 359),
                            new Effect(StaticEffectContext.CriticalDamage, 240)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 252),
                            new Effect(StaticEffectContext.CriticalDamage, 200)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 95),
                            new Effect(StaticEffectContext.CriticalDamage, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 31),
                            new Effect(StaticEffectContext.CriticalDamage, 80)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 16),
                            new Effect(StaticEffectContext.CriticalDamage, 40)
                        }
                    }
                }),
            new(TagField.Weapon,
                "炙熱的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.CriticalDamage, 384)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.CriticalDamage, 240)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.CriticalDamage, 200)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.CriticalDamage, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.CriticalDamage, 80)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.CriticalDamage, 40)
                        }
                    }
                }),
            new(TagField.Weapon,
                "附加的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 481),
                            new Effect(StaticEffectContext.CriticalRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 359),
                            new Effect(StaticEffectContext.CriticalRate, .05m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 252),
                            new Effect(StaticEffectContext.CriticalRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 95),
                            new Effect(StaticEffectContext.CriticalRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 31),
                            new Effect(StaticEffectContext.CriticalRate, .02m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 16),
                            new Effect(StaticEffectContext.CriticalRate, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "火山的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.CriticalRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.CriticalRate, .05m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.CriticalRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.CriticalRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.CriticalRate, .02m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.CriticalRate, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "狂暴的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 481),
                            new Effect(StaticEffectContext.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 359),
                            new Effect(StaticEffectContext.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 252),
                            new Effect(StaticEffectContext.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 95),
                            new Effect(StaticEffectContext.DefenseBreakRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 31),
                            new Effect(StaticEffectContext.DefenseBreakRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 16),
                            new Effect(StaticEffectContext.DefenseBreakRate, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "刺眼的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.DefenseBreakRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.DefenseBreakRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.DefenseBreakRate, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "遺失的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 511),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 381),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 267),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 101),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 33),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 17),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "閃電的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .1m),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .06m),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.ExtraDamageRateBasic, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "高喊的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 511),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 381),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 267),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 101),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 33),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 17),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "凌晨的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .1m),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .06m),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.ExtraDamageRateBoss, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "假的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 481),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 359),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 252),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 95),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 31),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 16),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "假的(%)",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.ExtraDamageRateGolden, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "傲慢的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 481),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 359),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 252),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 95),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 31),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 16),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "傲慢的(%)",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .12m),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .08m),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.ExtraDamageRatePrimal, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "慈悲的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 541),
                            new Effect(StaticEffectContext.Hp, 1_800)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 404),
                            new Effect(StaticEffectContext.Hp, 1_260)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 283),
                            new Effect(StaticEffectContext.Hp, 810)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 107),
                            new Effect(StaticEffectContext.Hp, 450)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 35),
                            new Effect(StaticEffectContext.Hp, 225)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 18),
                            new Effect(StaticEffectContext.Hp, 135)
                        }
                    }
                }),
            new(TagField.Weapon,
                "執著的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .13m),
                            new Effect(StaticEffectContext.Hp, 1_800)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .1m),
                            new Effect(StaticEffectContext.Hp, 1_260)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.Hp, 810)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .06m),
                            new Effect(StaticEffectContext.Hp, 450)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.Hp, 225)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.Hp, 135)
                        }
                    }
                }),
            new(TagField.Weapon,
                "贖罪的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 541),
                            new Effect(StaticEffectContext.MoveSpaceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 404),
                            new Effect(StaticEffectContext.MoveSpaceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 283),
                            new Effect(StaticEffectContext.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 107),
                            new Effect(StaticEffectContext.MoveSpaceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 35),
                            new Effect(StaticEffectContext.MoveSpaceRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 18),
                            new Effect(StaticEffectContext.MoveSpaceRate, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "多雲的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .13m),
                            new Effect(StaticEffectContext.MoveSpaceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .1m),
                            new Effect(StaticEffectContext.MoveSpaceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .06m),
                            new Effect(StaticEffectContext.MoveSpaceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.MoveSpaceRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.MoveSpaceRate, .01m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "生銹的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 662),
                            new Effect(StaticEffectContext.PartialDamageRate, .55m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 493),
                            new Effect(StaticEffectContext.PartialDamageRate, .44m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 346),
                            new Effect(StaticEffectContext.PartialDamageRate, .33m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 130),
                            new Effect(StaticEffectContext.PartialDamageRate, .22m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 42),
                            new Effect(StaticEffectContext.PartialDamageRate, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 22),
                            new Effect(StaticEffectContext.PartialDamageRate, .06m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "螺旋的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .16m),
                            new Effect(StaticEffectContext.PartialDamageRate, .55m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .13m),
                            new Effect(StaticEffectContext.PartialDamageRate, .44m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .1m),
                            new Effect(StaticEffectContext.PartialDamageRate, .33m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .07m),
                            new Effect(StaticEffectContext.PartialDamageRate, .22m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .05m),
                            new Effect(StaticEffectContext.PartialDamageRate, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .03m),
                            new Effect(StaticEffectContext.PartialDamageRate, .06m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "疲倦者的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 541),
                            new Effect(StaticEffectContext.Stamina, 6)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 404),
                            new Effect(StaticEffectContext.Stamina, 5)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 283),
                            new Effect(StaticEffectContext.Stamina, 4)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 107),
                            new Effect(StaticEffectContext.Stamina, 3)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 35),
                            new Effect(StaticEffectContext.Stamina, 2)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 18),
                            new Effect(StaticEffectContext.Stamina, 1)
                        }
                    }
                }),
            new(TagField.Weapon,
                "幹練的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .13m),
                            new Effect(StaticEffectContext.Stamina, 6)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .1m),
                            new Effect(StaticEffectContext.Stamina, 5)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.Stamina, 4)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .06m),
                            new Effect(StaticEffectContext.Stamina, 3)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.Stamina, 2)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.Stamina, 1)
                        }
                    }
                }),
            new(TagField.Weapon,
                "激流的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 601),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .22m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 448),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .16m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 314),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .12m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 118),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .08m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 38),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttack, 20),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "颱風的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .14m),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .22m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .11m),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .16m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .09m),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .12m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .06m),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .08m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .04m),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffectContext.WeaponAttackRate, .02m),
                            new Effect(StaticEffectContext.SuperArmorBreakPowerRate, .03m)
                        }
                    }
                })
        };
    }
}