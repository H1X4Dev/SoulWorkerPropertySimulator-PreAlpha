using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupErwin() =>
            new("歐文",
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
                            new(StaticEffectContext.Hp, 1_450),
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
                            new(StaticEffectContext.Hp, 1_800),
                            new(StaticEffectContext.Attack, 90),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 15),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_150),
                            new(StaticEffectContext.Attack, 108),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 20),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_500),
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
                            new(StaticEffectContext.Hp, 2_850),
                            new(StaticEffectContext.Attack, 162),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 30),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_200),
                            new(StaticEffectContext.Attack, 180),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 35),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_550),
                            new(StaticEffectContext.Attack, 198),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 40),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_900),
                            new(StaticEffectContext.Attack, 234),
                            new(StaticEffectContext.Evade, 6),
                            new(StaticEffectContext.Defense, 45),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_250),
                            new(StaticEffectContext.Attack, 252),
                            new(StaticEffectContext.Evade, 7),
                            new(StaticEffectContext.Defense, 50),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_600),
                            new(StaticEffectContext.Attack, 270),
                            new(StaticEffectContext.Evade, 7),
                            new(StaticEffectContext.Defense, 55),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_950),
                            new(StaticEffectContext.Attack, 288),
                            new(StaticEffectContext.Evade, 8),
                            new(StaticEffectContext.Defense, 60),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_300),
                            new(StaticEffectContext.Attack, 324),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 65),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_650),
                            new(StaticEffectContext.Attack, 342),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 70),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_000),
                            new(StaticEffectContext.Attack, 360),
                            new(StaticEffectContext.Evade, 10),
                            new(StaticEffectContext.Defense, 75),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_350),
                            new(StaticEffectContext.Attack, 378),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 80),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_700),
                            new(StaticEffectContext.Attack, 414),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 85),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_050),
                            new(StaticEffectContext.Attack, 432),
                            new(StaticEffectContext.Evade, 12),
                            new(StaticEffectContext.Defense, 90),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_400),
                            new(StaticEffectContext.Attack, 450),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 95),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_750),
                            new(StaticEffectContext.Attack, 468),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 100),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_100),
                            new(StaticEffectContext.Attack, 504),
                            new(StaticEffectContext.Evade, 14),
                            new(StaticEffectContext.Defense, 105),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_450),
                            new(StaticEffectContext.Attack, 522),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 110),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_800),
                            new(StaticEffectContext.Attack, 540),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 115),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_150),
                            new(StaticEffectContext.Attack, 558),
                            new(StaticEffectContext.Evade, 16),
                            new(StaticEffectContext.Defense, 120),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_500),
                            new(StaticEffectContext.Attack, 594),
                            new(StaticEffectContext.Evade, 17),
                            new(StaticEffectContext.Defense, 125),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_850),
                            new(StaticEffectContext.Attack, 612),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 130),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_200),
                            new(StaticEffectContext.Attack, 630),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 135),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_550),
                            new(StaticEffectContext.Attack, 648),
                            new(StaticEffectContext.Evade, 19),
                            new(StaticEffectContext.Defense, 140),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_900),
                            new(StaticEffectContext.Attack, 684),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 145),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_250),
                            new(StaticEffectContext.Attack, 702),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 150),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_600),
                            new(StaticEffectContext.Attack, 720),
                            new(StaticEffectContext.Evade, 21),
                            new(StaticEffectContext.Defense, 155),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_950),
                            new(StaticEffectContext.Attack, 738),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 160),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_300),
                            new(StaticEffectContext.Attack, 774),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 165),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_650),
                            new(StaticEffectContext.Attack, 792),
                            new(StaticEffectContext.Evade, 23),
                            new(StaticEffectContext.Defense, 170),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_000),
                            new(StaticEffectContext.Attack, 810),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 175),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_350),
                            new(StaticEffectContext.Attack, 828),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 180),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_700),
                            new(StaticEffectContext.Attack, 864),
                            new(StaticEffectContext.Evade, 25),
                            new(StaticEffectContext.Defense, 185),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_050),
                            new(StaticEffectContext.Attack, 882),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 190),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_400),
                            new(StaticEffectContext.Attack, 900),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 195),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_750),
                            new(StaticEffectContext.Attack, 918),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 200),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_100),
                            new(StaticEffectContext.Attack, 954),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 205),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_450),
                            new(StaticEffectContext.Attack, 972),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 210),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_800),
                            new(StaticEffectContext.Attack, 990),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 215),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_150),
                            new(StaticEffectContext.Attack, 1_008),
                            new(StaticEffectContext.Evade, 30),
                            new(StaticEffectContext.Defense, 220),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_500),
                            new(StaticEffectContext.Attack, 1_044),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 225),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_850),
                            new(StaticEffectContext.Attack, 1_062),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 230),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_200),
                            new(StaticEffectContext.Attack, 1_080),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 235),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_550),
                            new(StaticEffectContext.Attack, 1_098),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 240),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_900),
                            new(StaticEffectContext.Attack, 1_134),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 245),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_250),
                            new(StaticEffectContext.Attack, 1_152),
                            new(StaticEffectContext.Evade, 34),
                            new(StaticEffectContext.Defense, 250),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_600),
                            new(StaticEffectContext.Attack, 1_170),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 255),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_950),
                            new(StaticEffectContext.Attack, 1_188),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 260),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19_300),
                            new(StaticEffectContext.Attack, 1_224),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 265),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19_650),
                            new(StaticEffectContext.Attack, 1_242),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 270),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_000),
                            new(StaticEffectContext.Attack, 1_260),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 275),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_350),
                            new(StaticEffectContext.Attack, 1_278),
                            new(StaticEffectContext.Evade, 38),
                            new(StaticEffectContext.Defense, 280),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_700),
                            new(StaticEffectContext.Attack, 1_314),
                            new(StaticEffectContext.Evade, 39),
                            new(StaticEffectContext.Defense, 285),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 21_050),
                            new(StaticEffectContext.Attack, 1_332),
                            new(StaticEffectContext.Evade, 40),
                            new(StaticEffectContext.Defense, 290),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 21_400),
                            new(StaticEffectContext.Attack, 1_350),
                            new(StaticEffectContext.Evade, 40),
                            new(StaticEffectContext.Defense, 295),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 21_750),
                            new(StaticEffectContext.Attack, 1_368),
                            new(StaticEffectContext.Evade, 41),
                            new(StaticEffectContext.Defense, 300),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 22_100),
                            new(StaticEffectContext.Attack, 1_404),
                            new(StaticEffectContext.Evade, 42),
                            new(StaticEffectContext.Defense, 304),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 22_450),
                            new(StaticEffectContext.Attack, 1_422),
                            new(StaticEffectContext.Evade, 42),
                            new(StaticEffectContext.Defense, 309),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 22_800),
                            new(StaticEffectContext.Attack, 1_440),
                            new(StaticEffectContext.Evade, 43),
                            new(StaticEffectContext.Defense, 314),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 23_150),
                            new(StaticEffectContext.Attack, 1_458),
                            new(StaticEffectContext.Evade, 44),
                            new(StaticEffectContext.Defense, 319),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 23_500),
                            new(StaticEffectContext.Attack, 1_494),
                            new(StaticEffectContext.Evade, 44),
                            new(StaticEffectContext.Defense, 325),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 23_850),
                            new(StaticEffectContext.Attack, 1_512),
                            new(StaticEffectContext.Evade, 45),
                            new(StaticEffectContext.Defense, 329),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 24_200),
                            new(StaticEffectContext.Attack, 1_530),
                            new(StaticEffectContext.Evade, 46),
                            new(StaticEffectContext.Defense, 334),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 24_550),
                            new(StaticEffectContext.Attack, 1_548),
                            new(StaticEffectContext.Evade, 46),
                            new(StaticEffectContext.Defense, 339),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}