using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupLee() =>
            new("李",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        46,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 12_350),
                            new(StaticEffect.Attack, 1_278),
                            new(StaticEffect.CriticalDamage, 1_022),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 230),
                            new(StaticEffect.Accuracy, 978)
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 12_600),
                            new(StaticEffect.Attack, 1_296),
                            new(StaticEffect.CriticalDamage, 1_036),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 235),
                            new(StaticEffect.Accuracy, 981)
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 12_850),
                            new(StaticEffect.Attack, 1_332),
                            new(StaticEffect.CriticalDamage, 1_065),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 240),
                            new(StaticEffect.Accuracy, 985)
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 13_100),
                            new(StaticEffect.Attack, 1_350),
                            new(StaticEffect.CriticalDamage, 1_080),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 245),
                            new(StaticEffect.Accuracy, 989)
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 13_350),
                            new(StaticEffect.Attack, 1_386),
                            new(StaticEffect.CriticalDamage, 1_108),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 250),
                            new(StaticEffect.Accuracy, 994)
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 13_600),
                            new(StaticEffect.Attack, 1_404),
                            new(StaticEffect.CriticalDamage, 1_123),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 255),
                            new(StaticEffect.Accuracy, 996)
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 13_850),
                            new(StaticEffect.Attack, 1_440),
                            new(StaticEffect.CriticalDamage, 1_152),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 260),
                            new(StaticEffect.Accuracy, 1_001)
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 14_100),
                            new(StaticEffect.Attack, 1_458),
                            new(StaticEffect.CriticalDamage, 1_166),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 265),
                            new(StaticEffect.Accuracy, 1_005)
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 14_350),
                            new(StaticEffect.Attack, 1_494),
                            new(StaticEffect.CriticalDamage, 1_195),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 270),
                            new(StaticEffect.Accuracy, 1_009)
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 14_600),
                            new(StaticEffect.Attack, 1_512),
                            new(StaticEffect.CriticalDamage, 1_209),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 275),
                            new(StaticEffect.Accuracy, 1_012)
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 14_850),
                            new(StaticEffect.Attack, 1_548),
                            new(StaticEffect.CriticalDamage, 1_238),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 280),
                            new(StaticEffect.Accuracy, 1_016)
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 15_100),
                            new(StaticEffect.Attack, 1_566),
                            new(StaticEffect.CriticalDamage, 1_252),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 285),
                            new(StaticEffect.Accuracy, 1_020)
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 15_350),
                            new(StaticEffect.Attack, 1_602),
                            new(StaticEffect.CriticalDamage, 1_281),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 290),
                            new(StaticEffect.Accuracy, 1_025)
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 15_600),
                            new(StaticEffect.Attack, 1_620),
                            new(StaticEffect.CriticalDamage, 1_296),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 295),
                            new(StaticEffect.Accuracy, 1_027)
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 15_850),
                            new(StaticEffect.Attack, 1_656),
                            new(StaticEffect.CriticalDamage, 1_324),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 300),
                            new(StaticEffect.Accuracy, 1_032)
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 16_100),
                            new(StaticEffect.Attack, 1_674),
                            new(StaticEffect.CriticalDamage, 1_339),
                            new(StaticEffect.Evade, 34),
                            new(StaticEffect.Defense, 305),
                            new(StaticEffect.Accuracy, 1_036)
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 16_350),
                            new(StaticEffect.Attack, 1_710),
                            new(StaticEffect.CriticalDamage, 1_368),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 310),
                            new(StaticEffect.Accuracy, 1_040)
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 16_600),
                            new(StaticEffect.Attack, 1_728),
                            new(StaticEffect.CriticalDamage, 1_382),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 315),
                            new(StaticEffect.Accuracy, 1_043)
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 16_850),
                            new(StaticEffect.Attack, 1_764),
                            new(StaticEffect.CriticalDamage, 1_411),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 320),
                            new(StaticEffect.Accuracy, 1_047)
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 17_100),
                            new(StaticEffect.Attack, 1_782),
                            new(StaticEffect.CriticalDamage, 1_425),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 325),
                            new(StaticEffect.Accuracy, 1_051)
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 17_350),
                            new(StaticEffect.Attack, 1_818),
                            new(StaticEffect.CriticalDamage, 1_454),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 330),
                            new(StaticEffect.Accuracy, 1_055)
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 17_600),
                            new(StaticEffect.Attack, 1_836),
                            new(StaticEffect.CriticalDamage, 1_468),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 335),
                            new(StaticEffect.Accuracy, 1_058)
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 17_850),
                            new(StaticEffect.Attack, 1_872),
                            new(StaticEffect.CriticalDamage, 1_497),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 340),
                            new(StaticEffect.Accuracy, 1_062)
                        }
                    },
                    {
                        69,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 18_100),
                            new(StaticEffect.Attack, 1_890),
                            new(StaticEffect.CriticalDamage, 1_512),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 345),
                            new(StaticEffect.Accuracy, 1_067)
                        }
                    },
                    {
                        70,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 18_350),
                            new(StaticEffect.Attack, 1_926),
                            new(StaticEffect.CriticalDamage, 1_540),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 350),
                            new(StaticEffect.Accuracy, 1_071)
                        }
                    },
                    {
                        71,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 18_600),
                            new(StaticEffect.Attack, 1_944),
                            new(StaticEffect.CriticalDamage, 1_555),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 354),
                            new(StaticEffect.Accuracy, 1_074)
                        }
                    },
                    {
                        72,
                        new Effect[]
                        {
                            new(StaticEffect.Hp, 18_850),
                            new(StaticEffect.Attack, 1_980),
                            new(StaticEffect.CriticalDamage, 1_584),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 360),
                            new(StaticEffect.Accuracy, 1_078)
                        }
                    }
                });

        #endregion
    }
}