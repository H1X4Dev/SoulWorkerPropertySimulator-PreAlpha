using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupIris() =>
            new("Iris Yuma",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_100),
                            new(StaticEffectContext.Attack, 54),
                            new(StaticEffectContext.Evade, 0),
                            new(StaticEffectContext.Defense, 7),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_350),
                            new(StaticEffectContext.Attack, 90),
                            new(StaticEffectContext.Evade, 1),
                            new(StaticEffectContext.Defense, 12),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_600),
                            new(StaticEffectContext.Attack, 108),
                            new(StaticEffectContext.Evade, 1),
                            new(StaticEffectContext.Defense, 20),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_850),
                            new(StaticEffectContext.Attack, 144),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 25),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_100),
                            new(StaticEffectContext.Attack, 162),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 32),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_350),
                            new(StaticEffectContext.Attack, 198),
                            new(StaticEffectContext.Evade, 3),
                            new(StaticEffectContext.Defense, 37),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_600),
                            new(StaticEffectContext.Attack, 216),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 45),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_850),
                            new(StaticEffectContext.Attack, 252),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 50),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_100),
                            new(StaticEffectContext.Attack, 270),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 57),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_350),
                            new(StaticEffectContext.Attack, 306),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 62),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_600),
                            new(StaticEffectContext.Attack, 324),
                            new(StaticEffectContext.Evade, 6),
                            new(StaticEffectContext.Defense, 70),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_850),
                            new(StaticEffectContext.Attack, 360),
                            new(StaticEffectContext.Evade, 6),
                            new(StaticEffectContext.Defense, 75),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_100),
                            new(StaticEffectContext.Attack, 378),
                            new(StaticEffectContext.Evade, 7),
                            new(StaticEffectContext.Defense, 82),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_350),
                            new(StaticEffectContext.Attack, 414),
                            new(StaticEffectContext.Evade, 8),
                            new(StaticEffectContext.Defense, 87),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_600),
                            new(StaticEffectContext.Attack, 432),
                            new(StaticEffectContext.Evade, 8),
                            new(StaticEffectContext.Defense, 95),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_850),
                            new(StaticEffectContext.Attack, 468),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 100),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_100),
                            new(StaticEffectContext.Attack, 485),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 107),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_350),
                            new(StaticEffectContext.Attack, 522),
                            new(StaticEffectContext.Evade, 10),
                            new(StaticEffectContext.Defense, 112),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_600),
                            new(StaticEffectContext.Attack, 540),
                            new(StaticEffectContext.Evade, 10),
                            new(StaticEffectContext.Defense, 120),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_850),
                            new(StaticEffectContext.Attack, 576),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 125),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_100),
                            new(StaticEffectContext.Attack, 594),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 132),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_350),
                            new(StaticEffectContext.Attack, 630),
                            new(StaticEffectContext.Evade, 12),
                            new(StaticEffectContext.Defense, 137),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_600),
                            new(StaticEffectContext.Attack, 648),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 145),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_850),
                            new(StaticEffectContext.Attack, 684),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 150),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_100),
                            new(StaticEffectContext.Attack, 702),
                            new(StaticEffectContext.Evade, 14),
                            new(StaticEffectContext.Defense, 157),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_350),
                            new(StaticEffectContext.Attack, 738),
                            new(StaticEffectContext.Evade, 14),
                            new(StaticEffectContext.Defense, 162),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_600),
                            new(StaticEffectContext.Attack, 756),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 170),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_850),
                            new(StaticEffectContext.Attack, 792),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 175),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_100),
                            new(StaticEffectContext.Attack, 810),
                            new(StaticEffectContext.Evade, 16),
                            new(StaticEffectContext.Defense, 182),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_350),
                            new(StaticEffectContext.Attack, 846),
                            new(StaticEffectContext.Evade, 17),
                            new(StaticEffectContext.Defense, 187),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_600),
                            new(StaticEffectContext.Attack, 864),
                            new(StaticEffectContext.Evade, 17),
                            new(StaticEffectContext.Defense, 195),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_850),
                            new(StaticEffectContext.Attack, 900),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 200),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_100),
                            new(StaticEffectContext.Attack, 918),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 207),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_350),
                            new(StaticEffectContext.Attack, 954),
                            new(StaticEffectContext.Evade, 19),
                            new(StaticEffectContext.Defense, 212),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_600),
                            new(StaticEffectContext.Attack, 971),
                            new(StaticEffectContext.Evade, 19),
                            new(StaticEffectContext.Defense, 220),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_850),
                            new(StaticEffectContext.Attack, 1_007),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 225),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_100),
                            new(StaticEffectContext.Attack, 1_025),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 232),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_350),
                            new(StaticEffectContext.Attack, 1_061),
                            new(StaticEffectContext.Evade, 21),
                            new(StaticEffectContext.Defense, 237),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_600),
                            new(StaticEffectContext.Attack, 1_079),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 245),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_850),
                            new(StaticEffectContext.Attack, 1_115),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 250),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_100),
                            new(StaticEffectContext.Attack, 1_133),
                            new(StaticEffectContext.Evade, 23),
                            new(StaticEffectContext.Defense, 257),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_350),
                            new(StaticEffectContext.Attack, 1_170),
                            new(StaticEffectContext.Evade, 23),
                            new(StaticEffectContext.Defense, 262),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_600),
                            new(StaticEffectContext.Attack, 1_187),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 270),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_850),
                            new(StaticEffectContext.Attack, 1_224),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 275),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_100),
                            new(StaticEffectContext.Attack, 1_242),
                            new(StaticEffectContext.Evade, 25),
                            new(StaticEffectContext.Defense, 282),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_350),
                            new(StaticEffectContext.Attack, 1_277),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 287),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_600),
                            new(StaticEffectContext.Attack, 1_295),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 295),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_850),
                            new(StaticEffectContext.Attack, 1_331),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 300),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_100),
                            new(StaticEffectContext.Attack, 1_349),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 307),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_350),
                            new(StaticEffectContext.Attack, 1_385),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 312),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_600),
                            new(StaticEffectContext.Attack, 1_403),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 320),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_850),
                            new(StaticEffectContext.Attack, 1_439),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 325),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_100),
                            new(StaticEffectContext.Attack, 1_458),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 332),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_350),
                            new(StaticEffectContext.Attack, 1_494),
                            new(StaticEffectContext.Evade, 30),
                            new(StaticEffectContext.Defense, 337),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_600),
                            new(StaticEffectContext.Attack, 1_512),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 345),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_850),
                            new(StaticEffectContext.Attack, 1_548),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 350),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_100),
                            new(StaticEffectContext.Attack, 1_566),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 357),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_350),
                            new(StaticEffectContext.Attack, 1_602),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 362),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_600),
                            new(StaticEffectContext.Attack, 1_620),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 370),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_850),
                            new(StaticEffectContext.Attack, 1_656),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 375),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_100),
                            new(StaticEffectContext.Attack, 1_674),
                            new(StaticEffectContext.Evade, 34),
                            new(StaticEffectContext.Defense, 382),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_350),
                            new(StaticEffectContext.Attack, 1_710),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 387),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_600),
                            new(StaticEffectContext.Attack, 1_728),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 394),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_850),
                            new(StaticEffectContext.Attack, 1_764),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 399),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_100),
                            new(StaticEffectContext.Attack, 1_782),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 407),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_350),
                            new(StaticEffectContext.Attack, 1_818),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 412),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_600),
                            new(StaticEffectContext.Attack, 1_836),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 419),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_850),
                            new(StaticEffectContext.Attack, 1_872),
                            new(StaticEffectContext.Evade, 38),
                            new(StaticEffectContext.Defense, 424),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}