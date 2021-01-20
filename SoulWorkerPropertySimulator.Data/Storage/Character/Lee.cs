using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Lee =>
            new("李",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        46,
                        new Effect[]
                        {
                            new(Static.HP, 12_350),
                            new(Static.Attack, 1_278),
                            new(Static.CriticalDamage, 1_022),
                            new(Static.Evade, 26),
                            new(Static.Defense, 230),
                            new(Static.Accuracy, 978)
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(Static.HP, 12_600),
                            new(Static.Attack, 1_296),
                            new(Static.CriticalDamage, 1_036),
                            new(Static.Evade, 26),
                            new(Static.Defense, 235),
                            new(Static.Accuracy, 981)
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(Static.HP, 12_850),
                            new(Static.Attack, 1_332),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 27),
                            new(Static.Defense, 240),
                            new(Static.Accuracy, 985)
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(Static.HP, 13_100),
                            new(Static.Attack, 1_350),
                            new(Static.CriticalDamage, 1_080),
                            new(Static.Evade, 27),
                            new(Static.Defense, 245),
                            new(Static.Accuracy, 989)
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(Static.HP, 13_350),
                            new(Static.Attack, 1_386),
                            new(Static.CriticalDamage, 1_108),
                            new(Static.Evade, 28),
                            new(Static.Defense, 250),
                            new(Static.Accuracy, 994)
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(Static.HP, 13_600),
                            new(Static.Attack, 1_404),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 28),
                            new(Static.Defense, 255),
                            new(Static.Accuracy, 996)
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(Static.HP, 13_850),
                            new(Static.Attack, 1_440),
                            new(Static.CriticalDamage, 1_152),
                            new(Static.Evade, 29),
                            new(Static.Defense, 260),
                            new(Static.Accuracy, 1_001)
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(Static.HP, 14_100),
                            new(Static.Attack, 1_458),
                            new(Static.CriticalDamage, 1_166),
                            new(Static.Evade, 29),
                            new(Static.Defense, 265),
                            new(Static.Accuracy, 1_005)
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(Static.HP, 14_350),
                            new(Static.Attack, 1_494),
                            new(Static.CriticalDamage, 1_195),
                            new(Static.Evade, 30),
                            new(Static.Defense, 270),
                            new(Static.Accuracy, 1_009)
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(Static.HP, 14_600),
                            new(Static.Attack, 1_512),
                            new(Static.CriticalDamage, 1_209),
                            new(Static.Evade, 31),
                            new(Static.Defense, 275),
                            new(Static.Accuracy, 1_012)
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(Static.HP, 14_850),
                            new(Static.Attack, 1_548),
                            new(Static.CriticalDamage, 1_238),
                            new(Static.Evade, 31),
                            new(Static.Defense, 280),
                            new(Static.Accuracy, 1_016)
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(Static.HP, 15_100),
                            new(Static.Attack, 1_566),
                            new(Static.CriticalDamage, 1_252),
                            new(Static.Evade, 32),
                            new(Static.Defense, 285),
                            new(Static.Accuracy, 1_020)
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(Static.HP, 15_350),
                            new(Static.Attack, 1_602),
                            new(Static.CriticalDamage, 1_281),
                            new(Static.Evade, 32),
                            new(Static.Defense, 290),
                            new(Static.Accuracy, 1_025)
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(Static.HP, 15_600),
                            new(Static.Attack, 1_620),
                            new(Static.CriticalDamage, 1_296),
                            new(Static.Evade, 33),
                            new(Static.Defense, 295),
                            new(Static.Accuracy, 1_027)
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(Static.HP, 15_850),
                            new(Static.Attack, 1_656),
                            new(Static.CriticalDamage, 1_324),
                            new(Static.Evade, 33),
                            new(Static.Defense, 300),
                            new(Static.Accuracy, 1_032)
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(Static.HP, 16_100),
                            new(Static.Attack, 1_674),
                            new(Static.CriticalDamage, 1_339),
                            new(Static.Evade, 34),
                            new(Static.Defense, 305),
                            new(Static.Accuracy, 1_036)
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(Static.HP, 16_350),
                            new(Static.Attack, 1_710),
                            new(Static.CriticalDamage, 1_368),
                            new(Static.Evade, 35),
                            new(Static.Defense, 310),
                            new(Static.Accuracy, 1_040)
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(Static.HP, 16_600),
                            new(Static.Attack, 1_728),
                            new(Static.CriticalDamage, 1_382),
                            new(Static.Evade, 35),
                            new(Static.Defense, 315),
                            new(Static.Accuracy, 1_043)
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(Static.HP, 16_850),
                            new(Static.Attack, 1_764),
                            new(Static.CriticalDamage, 1_411),
                            new(Static.Evade, 36),
                            new(Static.Defense, 320),
                            new(Static.Accuracy, 1_047)
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(Static.HP, 17_100),
                            new(Static.Attack, 1_782),
                            new(Static.CriticalDamage, 1_425),
                            new(Static.Evade, 36),
                            new(Static.Defense, 325),
                            new(Static.Accuracy, 1_051)
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(Static.HP, 17_350),
                            new(Static.Attack, 1_818),
                            new(Static.CriticalDamage, 1_454),
                            new(Static.Evade, 37),
                            new(Static.Defense, 330),
                            new(Static.Accuracy, 1_055)
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(Static.HP, 17_600),
                            new(Static.Attack, 1_836),
                            new(Static.CriticalDamage, 1_468),
                            new(Static.Evade, 37),
                            new(Static.Defense, 335),
                            new(Static.Accuracy, 1_058)
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(Static.HP, 17_850),
                            new(Static.Attack, 1_872),
                            new(Static.CriticalDamage, 1_497),
                            new(Static.Evade, 38),
                            new(Static.Defense, 340),
                            new(Static.Accuracy, 1_062)
                        }
                    },
                    {
                        69,
                        new Effect[]
                        {
                            new(Static.HP, 18_100),
                            new(Static.Attack, 1_890),
                            new(Static.CriticalDamage, 1_512),
                            new(Static.Evade, 38),
                            new(Static.Defense, 345),
                            new(Static.Accuracy, 1_067)
                        }
                    },
                    {
                        70,
                        new Effect[]
                        {
                            new(Static.HP, 18_350),
                            new(Static.Attack, 1_926),
                            new(Static.CriticalDamage, 1_540),
                            new(Static.Evade, 39),
                            new(Static.Defense, 350),
                            new(Static.Accuracy, 1_071)
                        }
                    },
                    {
                        71,
                        new Effect[]
                        {
                            new(Static.HP, 18_600),
                            new(Static.Attack, 1_944),
                            new(Static.CriticalDamage, 1_555),
                            new(Static.Evade, 40),
                            new(Static.Defense, 354),
                            new(Static.Accuracy, 1_074)
                        }
                    },
                    {
                        72,
                        new Effect[]
                        {
                            new(Static.HP, 18_850),
                            new(Static.Attack, 1_980),
                            new(Static.CriticalDamage, 1_584),
                            new(Static.Evade, 40),
                            new(Static.Defense, 360),
                            new(Static.Accuracy, 1_078)
                        }
                    }
                });

        #endregion
    }
}