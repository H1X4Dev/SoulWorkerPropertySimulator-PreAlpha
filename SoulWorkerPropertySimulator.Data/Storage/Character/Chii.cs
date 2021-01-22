using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupChii() =>
            new("琪",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        14,
                        new[]
                        {
                            new(Static.Hp, 6_300),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 8),
                            new(Static.Defense, 87),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(Static.Hp, 6_700),
                            new(Static.Attack, 414),
                            new(Static.CriticalDamage, 331),
                            new(Static.Evade, 9),
                            new(Static.Defense, 95),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(Static.Hp, 7_100),
                            new(Static.Attack, 432),
                            new(Static.CriticalDamage, 345),
                            new(Static.Evade, 10),
                            new(Static.Defense, 100),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(Static.Hp, 7_500),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 10),
                            new(Static.Defense, 107),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(Static.Hp, 7_900),
                            new(Static.Attack, 486),
                            new(Static.CriticalDamage, 388),
                            new(Static.Evade, 11),
                            new(Static.Defense, 112),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(Static.Hp, 8_300),
                            new(Static.Attack, 504),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 11),
                            new(Static.Defense, 120),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(Static.Hp, 8_700),
                            new(Static.Attack, 540),
                            new(Static.CriticalDamage, 432),
                            new(Static.Evade, 12),
                            new(Static.Defense, 125),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(Static.Hp, 9_100),
                            new(Static.Attack, 558),
                            new(Static.CriticalDamage, 446),
                            new(Static.Evade, 13),
                            new(Static.Defense, 132),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(Static.Hp, 9_500),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 13),
                            new(Static.Defense, 137),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(Static.Hp, 9_900),
                            new(Static.Attack, 612),
                            new(Static.CriticalDamage, 489),
                            new(Static.Evade, 14),
                            new(Static.Defense, 145),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(Static.Hp, 10_300),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 15),
                            new(Static.Defense, 150),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(Static.Hp, 10_700),
                            new(Static.Attack, 666),
                            new(Static.CriticalDamage, 532),
                            new(Static.Evade, 15),
                            new(Static.Defense, 157),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(Static.Hp, 11_100),
                            new(Static.Attack, 684),
                            new(Static.CriticalDamage, 547),
                            new(Static.Evade, 16),
                            new(Static.Defense, 162),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(Static.Hp, 11_500),
                            new(Static.Attack, 720),
                            new(Static.CriticalDamage, 576),
                            new(Static.Evade, 16),
                            new(Static.Defense, 170),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(Static.Hp, 11_900),
                            new(Static.Attack, 738),
                            new(Static.CriticalDamage, 609),
                            new(Static.Evade, 17),
                            new(Static.Defense, 175),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(Static.Hp, 12_300),
                            new(Static.Attack, 774),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 18),
                            new(Static.Defense, 182),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(Static.Hp, 12_700),
                            new(Static.Attack, 792),
                            new(Static.CriticalDamage, 633),
                            new(Static.Evade, 18),
                            new(Static.Defense, 187),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(Static.Hp, 13_100),
                            new(Static.Attack, 828),
                            new(Static.CriticalDamage, 662),
                            new(Static.Evade, 19),
                            new(Static.Defense, 195),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(Static.Hp, 13_500),
                            new(Static.Attack, 846),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 20),
                            new(Static.Defense, 200),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(Static.Hp, 13_900),
                            new(Static.Attack, 864),
                            new(Static.CriticalDamage, 691),
                            new(Static.Evade, 20),
                            new(Static.Defense, 207),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(Static.Hp, 14_300),
                            new(Static.Attack, 900),
                            new(Static.CriticalDamage, 720),
                            new(Static.Evade, 21),
                            new(Static.Defense, 212),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(Static.Hp, 14_700),
                            new(Static.Attack, 918),
                            new(Static.CriticalDamage, 734),
                            new(Static.Evade, 21),
                            new(Static.Defense, 220),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(Static.Hp, 15_100),
                            new(Static.Attack, 954),
                            new(Static.CriticalDamage, 763),
                            new(Static.Evade, 22),
                            new(Static.Defense, 225),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(Static.Hp, 15_500),
                            new(Static.Attack, 972),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 23),
                            new(Static.Defense, 232),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(Static.Hp, 15_900),
                            new(Static.Attack, 990),
                            new(Static.CriticalDamage, 792),
                            new(Static.Evade, 23),
                            new(Static.Defense, 237),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(Static.Hp, 16_300),
                            new(Static.Attack, 1_026),
                            new(Static.CriticalDamage, 820),
                            new(Static.Evade, 24),
                            new(Static.Defense, 245),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(Static.Hp, 16_700),
                            new(Static.Attack, 1_044),
                            new(Static.CriticalDamage, 835),
                            new(Static.Evade, 25),
                            new(Static.Defense, 250),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(Static.Hp, 17_100),
                            new(Static.Attack, 1_080),
                            new(Static.CriticalDamage, 864),
                            new(Static.Evade, 25),
                            new(Static.Defense, 257),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(Static.Hp, 17_500),
                            new(Static.Attack, 1_098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 26),
                            new(Static.Defense, 262),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(Static.Hp, 17_900),
                            new(Static.Attack, 1_134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 26),
                            new(Static.Defense, 270),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(Static.Hp, 18_300),
                            new(Static.Attack, 1_152),
                            new(Static.CriticalDamage, 921),
                            new(Static.Evade, 27),
                            new(Static.Defense, 275),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(Static.Hp, 18_700),
                            new(Static.Attack, 1_170),
                            new(Static.CriticalDamage, 936),
                            new(Static.Evade, 28),
                            new(Static.Defense, 282),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(Static.Hp, 19_100),
                            new(Static.Attack, 1_206),
                            new(Static.CriticalDamage, 964),
                            new(Static.Evade, 28),
                            new(Static.Defense, 287),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(Static.Hp, 19_500),
                            new(Static.Attack, 1_224),
                            new(Static.CriticalDamage, 979),
                            new(Static.Evade, 29),
                            new(Static.Defense, 295),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(Static.Hp, 19_900),
                            new(Static.Attack, 1_260),
                            new(Static.CriticalDamage, 1_008),
                            new(Static.Evade, 30),
                            new(Static.Defense, 300),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(Static.Hp, 20_300),
                            new(Static.Attack, 1_278),
                            new(Static.CriticalDamage, 1_022),
                            new(Static.Evade, 30),
                            new(Static.Defense, 307),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(Static.Hp, 20_700),
                            new(Static.Attack, 1_314),
                            new(Static.CriticalDamage, 1_051),
                            new(Static.Evade, 31),
                            new(Static.Defense, 312),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(Static.Hp, 21_100),
                            new(Static.Attack, 1_332),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 31),
                            new(Static.Defense, 320),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(Static.Hp, 21_500),
                            new(Static.Attack, 1_350),
                            new(Static.CriticalDamage, 1_080),
                            new(Static.Evade, 32),
                            new(Static.Defense, 325),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(Static.Hp, 21_900),
                            new(Static.Attack, 1_386),
                            new(Static.CriticalDamage, 1_108),
                            new(Static.Evade, 33),
                            new(Static.Defense, 332),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(Static.Hp, 22_300),
                            new(Static.Attack, 1_404),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 33),
                            new(Static.Defense, 337),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(Static.Hp, 22_700),
                            new(Static.Attack, 1_440),
                            new(Static.CriticalDamage, 1_152),
                            new(Static.Evade, 34),
                            new(Static.Defense, 345),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(Static.Hp, 23_100),
                            new(Static.Attack, 1_458),
                            new(Static.CriticalDamage, 1_166),
                            new(Static.Evade, 35),
                            new(Static.Defense, 350),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(Static.Hp, 23_500),
                            new(Static.Attack, 1_494),
                            new(Static.CriticalDamage, 1_195),
                            new(Static.Evade, 35),
                            new(Static.Defense, 357),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(Static.Hp, 23_900),
                            new(Static.Attack, 1_512),
                            new(Static.CriticalDamage, 1_209),
                            new(Static.Evade, 36),
                            new(Static.Defense, 362),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(Static.Hp, 24_300),
                            new(Static.Attack, 1_530),
                            new(Static.CriticalDamage, 1_224),
                            new(Static.Evade, 36),
                            new(Static.Defense, 369),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(Static.Hp, 24_700),
                            new(Static.Attack, 1_566),
                            new(Static.CriticalDamage, 1_252),
                            new(Static.Evade, 37),
                            new(Static.Defense, 374),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(Static.Hp, 25_100),
                            new(Static.Attack, 1_584),
                            new(Static.CriticalDamage, 1_267),
                            new(Static.Evade, 38),
                            new(Static.Defense, 382),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(Static.Hp, 25_500),
                            new(Static.Attack, 1_620),
                            new(Static.CriticalDamage, 1_296),
                            new(Static.Evade, 38),
                            new(Static.Defense, 387),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(Static.Hp, 25_900),
                            new(Static.Attack, 1_638),
                            new(Static.CriticalDamage, 1_310),
                            new(Static.Evade, 39),
                            new(Static.Defense, 395),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(Static.Hp, 26_300),
                            new(Static.Attack, 1_674),
                            new(Static.CriticalDamage, 1_339),
                            new(Static.Evade, 40),
                            new(Static.Defense, 400),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(Static.Hp, 26_700),
                            new(Static.Attack, 1_692),
                            new(Static.CriticalDamage, 1_353),
                            new(Static.Evade, 40),
                            new(Static.Defense, 407),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(Static.Hp, 27_100),
                            new(Static.Attack, 1_710),
                            new(Static.CriticalDamage, 1_368),
                            new(Static.Evade, 41),
                            new(Static.Defense, 412),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(Static.Hp, 27_500),
                            new(Static.Attack, 1_746),
                            new(Static.CriticalDamage, 1_396),
                            new(Static.Evade, 41),
                            new(Static.Defense, 420),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(Static.Hp, 27_900),
                            new(Static.Attack, 1_764),
                            new(Static.CriticalDamage, 1_411),
                            new(Static.Evade, 42),
                            new(Static.Defense, 425),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}