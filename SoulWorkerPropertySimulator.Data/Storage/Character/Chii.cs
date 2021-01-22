using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

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
                            new(StaticEffect.Hp, 6_300),
                            new(StaticEffect.Attack, 378),
                            new(StaticEffect.CriticalDamage, 302),
                            new(StaticEffect.Evade, 8),
                            new(StaticEffect.Defense, 87),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_700),
                            new(StaticEffect.Attack, 414),
                            new(StaticEffect.CriticalDamage, 331),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 95),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_100),
                            new(StaticEffect.Attack, 432),
                            new(StaticEffect.CriticalDamage, 345),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 100),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_500),
                            new(StaticEffect.Attack, 468),
                            new(StaticEffect.CriticalDamage, 374),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 107),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_900),
                            new(StaticEffect.Attack, 486),
                            new(StaticEffect.CriticalDamage, 388),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 112),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_300),
                            new(StaticEffect.Attack, 504),
                            new(StaticEffect.CriticalDamage, 403),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 120),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_700),
                            new(StaticEffect.Attack, 540),
                            new(StaticEffect.CriticalDamage, 432),
                            new(StaticEffect.Evade, 12),
                            new(StaticEffect.Defense, 125),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_100),
                            new(StaticEffect.Attack, 558),
                            new(StaticEffect.CriticalDamage, 446),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 132),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_500),
                            new(StaticEffect.Attack, 594),
                            new(StaticEffect.CriticalDamage, 475),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 137),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_900),
                            new(StaticEffect.Attack, 612),
                            new(StaticEffect.CriticalDamage, 489),
                            new(StaticEffect.Evade, 14),
                            new(StaticEffect.Defense, 145),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_300),
                            new(StaticEffect.Attack, 648),
                            new(StaticEffect.CriticalDamage, 518),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 150),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_700),
                            new(StaticEffect.Attack, 666),
                            new(StaticEffect.CriticalDamage, 532),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 157),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_100),
                            new(StaticEffect.Attack, 684),
                            new(StaticEffect.CriticalDamage, 547),
                            new(StaticEffect.Evade, 16),
                            new(StaticEffect.Defense, 162),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_500),
                            new(StaticEffect.Attack, 720),
                            new(StaticEffect.CriticalDamage, 576),
                            new(StaticEffect.Evade, 16),
                            new(StaticEffect.Defense, 170),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_900),
                            new(StaticEffect.Attack, 738),
                            new(StaticEffect.CriticalDamage, 609),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 175),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_300),
                            new(StaticEffect.Attack, 774),
                            new(StaticEffect.CriticalDamage, 619),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 182),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_700),
                            new(StaticEffect.Attack, 792),
                            new(StaticEffect.CriticalDamage, 633),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 187),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_100),
                            new(StaticEffect.Attack, 828),
                            new(StaticEffect.CriticalDamage, 662),
                            new(StaticEffect.Evade, 19),
                            new(StaticEffect.Defense, 195),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_500),
                            new(StaticEffect.Attack, 846),
                            new(StaticEffect.CriticalDamage, 676),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 200),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_900),
                            new(StaticEffect.Attack, 864),
                            new(StaticEffect.CriticalDamage, 691),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 207),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_300),
                            new(StaticEffect.Attack, 900),
                            new(StaticEffect.CriticalDamage, 720),
                            new(StaticEffect.Evade, 21),
                            new(StaticEffect.Defense, 212),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_700),
                            new(StaticEffect.Attack, 918),
                            new(StaticEffect.CriticalDamage, 734),
                            new(StaticEffect.Evade, 21),
                            new(StaticEffect.Defense, 220),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_100),
                            new(StaticEffect.Attack, 954),
                            new(StaticEffect.CriticalDamage, 763),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 225),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_500),
                            new(StaticEffect.Attack, 972),
                            new(StaticEffect.CriticalDamage, 777),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 232),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_900),
                            new(StaticEffect.Attack, 990),
                            new(StaticEffect.CriticalDamage, 792),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 237),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_300),
                            new(StaticEffect.Attack, 1_026),
                            new(StaticEffect.CriticalDamage, 820),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 245),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_700),
                            new(StaticEffect.Attack, 1_044),
                            new(StaticEffect.CriticalDamage, 835),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 250),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_100),
                            new(StaticEffect.Attack, 1_080),
                            new(StaticEffect.CriticalDamage, 864),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 257),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_500),
                            new(StaticEffect.Attack, 1_098),
                            new(StaticEffect.CriticalDamage, 878),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 262),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_900),
                            new(StaticEffect.Attack, 1_134),
                            new(StaticEffect.CriticalDamage, 907),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 270),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_300),
                            new(StaticEffect.Attack, 1_152),
                            new(StaticEffect.CriticalDamage, 921),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 275),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_700),
                            new(StaticEffect.Attack, 1_170),
                            new(StaticEffect.CriticalDamage, 936),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 282),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_100),
                            new(StaticEffect.Attack, 1_206),
                            new(StaticEffect.CriticalDamage, 964),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 287),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_500),
                            new(StaticEffect.Attack, 1_224),
                            new(StaticEffect.CriticalDamage, 979),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 295),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_900),
                            new(StaticEffect.Attack, 1_260),
                            new(StaticEffect.CriticalDamage, 1_008),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 300),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_300),
                            new(StaticEffect.Attack, 1_278),
                            new(StaticEffect.CriticalDamage, 1_022),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 307),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_700),
                            new(StaticEffect.Attack, 1_314),
                            new(StaticEffect.CriticalDamage, 1_051),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 312),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_100),
                            new(StaticEffect.Attack, 1_332),
                            new(StaticEffect.CriticalDamage, 1_065),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 320),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_500),
                            new(StaticEffect.Attack, 1_350),
                            new(StaticEffect.CriticalDamage, 1_080),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 325),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_900),
                            new(StaticEffect.Attack, 1_386),
                            new(StaticEffect.CriticalDamage, 1_108),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 332),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_300),
                            new(StaticEffect.Attack, 1_404),
                            new(StaticEffect.CriticalDamage, 1_123),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 337),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_700),
                            new(StaticEffect.Attack, 1_440),
                            new(StaticEffect.CriticalDamage, 1_152),
                            new(StaticEffect.Evade, 34),
                            new(StaticEffect.Defense, 345),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_100),
                            new(StaticEffect.Attack, 1_458),
                            new(StaticEffect.CriticalDamage, 1_166),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 350),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_500),
                            new(StaticEffect.Attack, 1_494),
                            new(StaticEffect.CriticalDamage, 1_195),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 357),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_900),
                            new(StaticEffect.Attack, 1_512),
                            new(StaticEffect.CriticalDamage, 1_209),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 362),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_300),
                            new(StaticEffect.Attack, 1_530),
                            new(StaticEffect.CriticalDamage, 1_224),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 369),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_700),
                            new(StaticEffect.Attack, 1_566),
                            new(StaticEffect.CriticalDamage, 1_252),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 374),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_100),
                            new(StaticEffect.Attack, 1_584),
                            new(StaticEffect.CriticalDamage, 1_267),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 382),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_500),
                            new(StaticEffect.Attack, 1_620),
                            new(StaticEffect.CriticalDamage, 1_296),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 387),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_900),
                            new(StaticEffect.Attack, 1_638),
                            new(StaticEffect.CriticalDamage, 1_310),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 395),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_300),
                            new(StaticEffect.Attack, 1_674),
                            new(StaticEffect.CriticalDamage, 1_339),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 400),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_700),
                            new(StaticEffect.Attack, 1_692),
                            new(StaticEffect.CriticalDamage, 1_353),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 407),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_100),
                            new(StaticEffect.Attack, 1_710),
                            new(StaticEffect.CriticalDamage, 1_368),
                            new(StaticEffect.Evade, 41),
                            new(StaticEffect.Defense, 412),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_500),
                            new(StaticEffect.Attack, 1_746),
                            new(StaticEffect.CriticalDamage, 1_396),
                            new(StaticEffect.Evade, 41),
                            new(StaticEffect.Defense, 420),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_900),
                            new(StaticEffect.Attack, 1_764),
                            new(StaticEffect.CriticalDamage, 1_411),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 425),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}