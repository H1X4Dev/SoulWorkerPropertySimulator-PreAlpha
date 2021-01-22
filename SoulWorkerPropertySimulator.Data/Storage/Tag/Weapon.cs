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
                        new[] {new Effect(StaticEffect.WeaponAttack, 481), new Effect(StaticEffect.Attack, 112)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.WeaponAttack, 359), new Effect(StaticEffect.Attack, 96)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.WeaponAttack, 252), new Effect(StaticEffect.Attack, 72)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.WeaponAttack, 95), new Effect(StaticEffect.Attack, 48)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.WeaponAttack, 31), new Effect(StaticEffect.Attack, 24)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.WeaponAttack, 16), new Effect(StaticEffect.Attack, 14)}
                    }
                }),
            new(TagField.Weapon,
                "放置的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.WeaponAttack, 541), new Effect(StaticEffect.Attack, 315)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.WeaponAttack, 404), new Effect(StaticEffect.Attack, 252)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.WeaponAttack, 283), new Effect(StaticEffect.Attack, 189)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.WeaponAttack, 107), new Effect(StaticEffect.Attack, 126)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.WeaponAttack, 35), new Effect(StaticEffect.Attack, 63)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.WeaponAttack, 18), new Effect(StaticEffect.Attack, 32)}
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
                            new Effect(StaticEffect.WeaponAttackRate, .13m),
                            new Effect(StaticEffect.Accuracy, 315)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .1m),
                            new Effect(StaticEffect.Accuracy, 252)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.Accuracy, 189)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .06m),
                            new Effect(StaticEffect.Accuracy, 126)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.Accuracy, 63)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.Accuracy, 32)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.Accuracy, 112)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.Accuracy, 96)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.Accuracy, 72)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.Accuracy, 48)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.Accuracy, 24)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.Accuracy, 14)
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
                            new Effect(StaticEffect.WeaponAttack, 481),
                            new Effect(StaticEffect.AttackRate, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 359),
                            new Effect(StaticEffect.AttackRate, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.WeaponAttack, 252), new Effect(StaticEffect.AttackRate, .1m)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.WeaponAttack, 95), new Effect(StaticEffect.AttackRate, .08m)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.WeaponAttack, 31), new Effect(StaticEffect.AttackRate, .05m)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.WeaponAttack, 16), new Effect(StaticEffect.AttackRate, .03m)}
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.AttackRate, .15m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.AttackRate, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.AttackRate, .1m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.AttackRate, .08m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.AttackRate, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.AttackRate, .03m)
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
                            new Effect(StaticEffect.WeaponAttack, 481),
                            new Effect(StaticEffect.CriticalDamage, 384)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 359),
                            new Effect(StaticEffect.CriticalDamage, 240)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 252),
                            new Effect(StaticEffect.CriticalDamage, 200)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 95),
                            new Effect(StaticEffect.CriticalDamage, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 31),
                            new Effect(StaticEffect.CriticalDamage, 80)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 16),
                            new Effect(StaticEffect.CriticalDamage, 40)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.CriticalDamage, 384)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.CriticalDamage, 240)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.CriticalDamage, 200)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.CriticalDamage, 140)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.CriticalDamage, 80)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.CriticalDamage, 40)
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
                            new Effect(StaticEffect.WeaponAttack, 481),
                            new Effect(StaticEffect.CriticalRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 359),
                            new Effect(StaticEffect.CriticalRate, .05m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 252),
                            new Effect(StaticEffect.CriticalRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 95),
                            new Effect(StaticEffect.CriticalRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 31),
                            new Effect(StaticEffect.CriticalRate, .02m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 16),
                            new Effect(StaticEffect.CriticalRate, .01m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.CriticalRate, .07m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.CriticalRate, .05m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.CriticalRate, .04m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.CriticalRate, .03m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.CriticalRate, .02m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.CriticalRate, .01m)
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
                            new Effect(StaticEffect.WeaponAttack, 481),
                            new Effect(StaticEffect.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 359),
                            new Effect(StaticEffect.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 252),
                            new Effect(StaticEffect.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 95),
                            new Effect(StaticEffect.DefenseBreakRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 31),
                            new Effect(StaticEffect.DefenseBreakRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 16),
                            new Effect(StaticEffect.DefenseBreakRate, .01m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.DefenseBreakRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.DefenseBreakRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.DefenseBreakRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.DefenseBreakRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.DefenseBreakRate, .01m)
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
                            new Effect(StaticEffect.WeaponAttack, 511),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 381),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 267),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 101),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 33),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 17),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .01m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .1m),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .06m),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.ExtraDamageRateBasic, .01m)
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
                            new Effect(StaticEffect.WeaponAttack, 511),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 381),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 267),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 101),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 33),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 17),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .01m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .12m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .1m),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .09m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .06m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .06m),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .05m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .03m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.ExtraDamageRateBoss, .01m)
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
                            new Effect(StaticEffect.WeaponAttack, 481),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 359),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 252),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 95),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 31),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 16),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .03m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.ExtraDamageRateGolden, .03m)
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
                            new Effect(StaticEffect.WeaponAttack, 481),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 359),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 252),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 95),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 31),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 16),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .03m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .12m),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .16m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .12m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .08m),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .09m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .06m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .04m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.ExtraDamageRatePrimal, .03m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "慈悲的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.WeaponAttack, 541), new Effect(StaticEffect.Hp, 1_800)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.WeaponAttack, 404), new Effect(StaticEffect.Hp, 1_260)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.WeaponAttack, 283), new Effect(StaticEffect.Hp, 810)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.WeaponAttack, 107), new Effect(StaticEffect.Hp, 450)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.WeaponAttack, 35), new Effect(StaticEffect.Hp, 225)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.WeaponAttack, 18), new Effect(StaticEffect.Hp, 135)}
                    }
                }),
            new(TagField.Weapon,
                "執著的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .13m), new Effect(StaticEffect.Hp, 1_800)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .1m), new Effect(StaticEffect.Hp, 1_260)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .09m), new Effect(StaticEffect.Hp, 810)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .06m), new Effect(StaticEffect.Hp, 450)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .04m), new Effect(StaticEffect.Hp, 225)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .02m), new Effect(StaticEffect.Hp, 135)}
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
                            new Effect(StaticEffect.WeaponAttack, 541),
                            new Effect(StaticEffect.MoveSpaceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 404),
                            new Effect(StaticEffect.MoveSpaceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 283),
                            new Effect(StaticEffect.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 107),
                            new Effect(StaticEffect.MoveSpaceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 35),
                            new Effect(StaticEffect.MoveSpaceRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 18),
                            new Effect(StaticEffect.MoveSpaceRate, .01m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .13m),
                            new Effect(StaticEffect.MoveSpaceRate, .05m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .1m),
                            new Effect(StaticEffect.MoveSpaceRate, .04m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.MoveSpaceRate, .03m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .06m),
                            new Effect(StaticEffect.MoveSpaceRate, .02m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.MoveSpaceRate, .01m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.MoveSpaceRate, .01m)
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
                            new Effect(StaticEffect.WeaponAttack, 662),
                            new Effect(StaticEffect.PartialDamageRate, .55m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 493),
                            new Effect(StaticEffect.PartialDamageRate, .44m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 346),
                            new Effect(StaticEffect.PartialDamageRate, .33m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 130),
                            new Effect(StaticEffect.PartialDamageRate, .22m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 42),
                            new Effect(StaticEffect.PartialDamageRate, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 22),
                            new Effect(StaticEffect.PartialDamageRate, .06m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .16m),
                            new Effect(StaticEffect.PartialDamageRate, .55m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .13m),
                            new Effect(StaticEffect.PartialDamageRate, .44m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .1m),
                            new Effect(StaticEffect.PartialDamageRate, .33m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .07m),
                            new Effect(StaticEffect.PartialDamageRate, .22m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .05m),
                            new Effect(StaticEffect.PartialDamageRate, .11m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .03m),
                            new Effect(StaticEffect.PartialDamageRate, .06m)
                        }
                    }
                }),
            new(TagField.Weapon,
                "疲倦者的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.WeaponAttack, 541), new Effect(StaticEffect.Stamina, 6)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.WeaponAttack, 404), new Effect(StaticEffect.Stamina, 5)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.WeaponAttack, 283), new Effect(StaticEffect.Stamina, 4)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.WeaponAttack, 107), new Effect(StaticEffect.Stamina, 3)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.WeaponAttack, 35), new Effect(StaticEffect.Stamina, 2)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.WeaponAttack, 18), new Effect(StaticEffect.Stamina, 1)}
                    }
                }),
            new(TagField.Weapon,
                "幹練的",
                new Dictionary<ItemRare, IReadOnlyCollection<Effect>>
                {
                    {
                        ItemRare.Heroic,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .13m), new Effect(StaticEffect.Stamina, 6)}
                    },
                    {
                        ItemRare.Legendary,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .1m), new Effect(StaticEffect.Stamina, 5)}
                    },
                    {
                        ItemRare.Unique,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .09m), new Effect(StaticEffect.Stamina, 4)}
                    },
                    {
                        ItemRare.Valuable,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .06m), new Effect(StaticEffect.Stamina, 3)}
                    },
                    {
                        ItemRare.Magical,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .04m), new Effect(StaticEffect.Stamina, 2)}
                    },
                    {
                        ItemRare.Common,
                        new[] {new Effect(StaticEffect.WeaponAttackRate, .02m), new Effect(StaticEffect.Stamina, 1)}
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
                            new Effect(StaticEffect.WeaponAttack, 601),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .22m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 448),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .16m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 314),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .12m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 118),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .08m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 38),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttack, 20),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .03m)
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
                            new Effect(StaticEffect.WeaponAttackRate, .14m),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .22m)
                        }
                    },
                    {
                        ItemRare.Legendary,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .11m),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .16m)
                        }
                    },
                    {
                        ItemRare.Unique,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .09m),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .12m)
                        }
                    },
                    {
                        ItemRare.Valuable,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .06m),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .08m)
                        }
                    },
                    {
                        ItemRare.Magical,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .04m),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .05m)
                        }
                    },
                    {
                        ItemRare.Common,
                        new[]
                        {
                            new Effect(StaticEffect.WeaponAttackRate, .02m),
                            new Effect(StaticEffect.SuperArmorBreakPowerRate, .03m)
                        }
                    }
                })
        };
    }
}