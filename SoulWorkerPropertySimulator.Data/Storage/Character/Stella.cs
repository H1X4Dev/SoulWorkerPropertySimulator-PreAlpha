using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupStella() =>
            new("Stella Unibell",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_100),
                            new(StaticEffectContext.Attack, 54),
                            new(StaticEffectContext.Evade, 0),
                            new(StaticEffectContext.Defense, 5),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_400),
                            new(StaticEffectContext.Attack, 72),
                            new(StaticEffectContext.Evade, 1),
                            new(StaticEffectContext.Defense, 10),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_700),
                            new(StaticEffectContext.Attack, 108),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 15),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_000),
                            new(StaticEffectContext.Attack, 126),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 20),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_300),
                            new(StaticEffectContext.Attack, 144),
                            new(StaticEffectContext.Evade, 3),
                            new(StaticEffectContext.Defense, 25),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_600),
                            new(StaticEffectContext.Attack, 180),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 30),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_900),
                            new(StaticEffectContext.Attack, 198),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 35),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_200),
                            new(StaticEffectContext.Attack, 216),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 40),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_500),
                            new(StaticEffectContext.Attack, 252),
                            new(StaticEffectContext.Evade, 6),
                            new(StaticEffectContext.Defense, 45),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_800),
                            new(StaticEffectContext.Attack, 270),
                            new(StaticEffectContext.Evade, 7),
                            new(StaticEffectContext.Defense, 50),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_100),
                            new(StaticEffectContext.Attack, 306),
                            new(StaticEffectContext.Evade, 7),
                            new(StaticEffectContext.Defense, 55),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_400),
                            new(StaticEffectContext.Attack, 324),
                            new(StaticEffectContext.Evade, 8),
                            new(StaticEffectContext.Defense, 60),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_700),
                            new(StaticEffectContext.Attack, 342),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 65),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_000),
                            new(StaticEffectContext.Attack, 378),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 70),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_300),
                            new(StaticEffectContext.Attack, 396),
                            new(StaticEffectContext.Evade, 10),
                            new(StaticEffectContext.Defense, 75),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_600),
                            new(StaticEffectContext.Attack, 414),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 80),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_900),
                            new(StaticEffectContext.Attack, 450),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 85),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_200),
                            new(StaticEffectContext.Attack, 468),
                            new(StaticEffectContext.Evade, 12),
                            new(StaticEffectContext.Defense, 90),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_500),
                            new(StaticEffectContext.Attack, 503),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 95),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_800),
                            new(StaticEffectContext.Attack, 521),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 100),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_100),
                            new(StaticEffectContext.Attack, 539),
                            new(StaticEffectContext.Evade, 14),
                            new(StaticEffectContext.Defense, 105),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_400),
                            new(StaticEffectContext.Attack, 576),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 110),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_700),
                            new(StaticEffectContext.Attack, 594),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 115),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_000),
                            new(StaticEffectContext.Attack, 612),
                            new(StaticEffectContext.Evade, 16),
                            new(StaticEffectContext.Defense, 120),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_300),
                            new(StaticEffectContext.Attack, 648),
                            new(StaticEffectContext.Evade, 17),
                            new(StaticEffectContext.Defense, 125),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_600),
                            new(StaticEffectContext.Attack, 666),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 130),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_900),
                            new(StaticEffectContext.Attack, 702),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 135),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_200),
                            new(StaticEffectContext.Attack, 720),
                            new(StaticEffectContext.Evade, 19),
                            new(StaticEffectContext.Defense, 140),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_500),
                            new(StaticEffectContext.Attack, 738),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 145),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_800),
                            new(StaticEffectContext.Attack, 774),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 150),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_100),
                            new(StaticEffectContext.Attack, 792),
                            new(StaticEffectContext.Evade, 21),
                            new(StaticEffectContext.Defense, 155),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_400),
                            new(StaticEffectContext.Attack, 809),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 160),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_700),
                            new(StaticEffectContext.Attack, 845),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 165),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_000),
                            new(StaticEffectContext.Attack, 863),
                            new(StaticEffectContext.Evade, 23),
                            new(StaticEffectContext.Defense, 170),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_300),
                            new(StaticEffectContext.Attack, 899),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 175),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_600),
                            new(StaticEffectContext.Attack, 917),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 180),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_900),
                            new(StaticEffectContext.Attack, 936),
                            new(StaticEffectContext.Evade, 25),
                            new(StaticEffectContext.Defense, 185),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_200),
                            new(StaticEffectContext.Attack, 971),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 190),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_500),
                            new(StaticEffectContext.Attack, 990),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 195),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_800),
                            new(StaticEffectContext.Attack, 1_008),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 200),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_100),
                            new(StaticEffectContext.Attack, 1_044),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 205),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_400),
                            new(StaticEffectContext.Attack, 1_062),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 210),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_700),
                            new(StaticEffectContext.Attack, 1_098),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 215),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_000),
                            new(StaticEffectContext.Attack, 1_116),
                            new(StaticEffectContext.Evade, 30),
                            new(StaticEffectContext.Defense, 220),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_300),
                            new(StaticEffectContext.Attack, 1_134),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 225),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_600),
                            new(StaticEffectContext.Attack, 1_170),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 230),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_900),
                            new(StaticEffectContext.Attack, 1_188),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 235),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_200),
                            new(StaticEffectContext.Attack, 1_206),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 240),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_500),
                            new(StaticEffectContext.Attack, 1_242),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 245),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_800),
                            new(StaticEffectContext.Attack, 1_260),
                            new(StaticEffectContext.Evade, 34),
                            new(StaticEffectContext.Defense, 250),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_100),
                            new(StaticEffectContext.Attack, 1_296),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 255),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_400),
                            new(StaticEffectContext.Attack, 1_314),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 260),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_700),
                            new(StaticEffectContext.Attack, 1_331),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 265),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_000),
                            new(StaticEffectContext.Attack, 1_368),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 270),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_300),
                            new(StaticEffectContext.Attack, 1_386),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 275),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_600),
                            new(StaticEffectContext.Attack, 1_404),
                            new(StaticEffectContext.Evade, 38),
                            new(StaticEffectContext.Defense, 279),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_900),
                            new(StaticEffectContext.Attack, 1_440),
                            new(StaticEffectContext.Evade, 39),
                            new(StaticEffectContext.Defense, 284),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_200),
                            new(StaticEffectContext.Attack, 1_458),
                            new(StaticEffectContext.Evade, 40),
                            new(StaticEffectContext.Defense, 289),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_500),
                            new(StaticEffectContext.Attack, 1_494),
                            new(StaticEffectContext.Evade, 40),
                            new(StaticEffectContext.Defense, 294),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_800),
                            new(StaticEffectContext.Attack, 1_512),
                            new(StaticEffectContext.Evade, 41),
                            new(StaticEffectContext.Defense, 299),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19_100),
                            new(StaticEffectContext.Attack, 1_530),
                            new(StaticEffectContext.Evade, 42),
                            new(StaticEffectContext.Defense, 305),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19_400),
                            new(StaticEffectContext.Attack, 1_566),
                            new(StaticEffectContext.Evade, 42),
                            new(StaticEffectContext.Defense, 310),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19_700),
                            new(StaticEffectContext.Attack, 1_584),
                            new(StaticEffectContext.Evade, 43),
                            new(StaticEffectContext.Defense, 315),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_000),
                            new(StaticEffectContext.Attack, 1_602),
                            new(StaticEffectContext.Evade, 44),
                            new(StaticEffectContext.Defense, 320),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_300),
                            new(StaticEffectContext.Attack, 1_638),
                            new(StaticEffectContext.Evade, 44),
                            new(StaticEffectContext.Defense, 325),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_600),
                            new(StaticEffectContext.Attack, 1_656),
                            new(StaticEffectContext.Evade, 45),
                            new(StaticEffectContext.Defense, 329),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_900),
                            new(StaticEffectContext.Attack, 1_692),
                            new(StaticEffectContext.Evade, 46),
                            new(StaticEffectContext.Defense, 334),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 21_200),
                            new(StaticEffectContext.Attack, 1_710),
                            new(StaticEffectContext.Evade, 46),
                            new(StaticEffectContext.Defense, 339),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}