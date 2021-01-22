using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

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
                            new(Static.Hp, 1_100),
                            new(Static.Attack, 54),
                            new(Static.CriticalDamage, 43),
                            new(Static.Evade, 0),
                            new(Static.Defense, 5),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(Static.Hp, 1_450),
                            new(Static.Attack, 72),
                            new(Static.CriticalDamage, 57),
                            new(Static.Evade, 1),
                            new(Static.Defense, 10),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(Static.Hp, 1_800),
                            new(Static.Attack, 90),
                            new(Static.CriticalDamage, 72),
                            new(Static.Evade, 2),
                            new(Static.Defense, 15),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(Static.Hp, 2_150),
                            new(Static.Attack, 108),
                            new(Static.CriticalDamage, 86),
                            new(Static.Evade, 2),
                            new(Static.Defense, 20),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(Static.Hp, 2_500),
                            new(Static.Attack, 144),
                            new(Static.CriticalDamage, 115),
                            new(Static.Evade, 3),
                            new(Static.Defense, 25),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(Static.Hp, 2_850),
                            new(Static.Attack, 162),
                            new(Static.CriticalDamage, 129),
                            new(Static.Evade, 4),
                            new(Static.Defense, 30),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(Static.Hp, 3_200),
                            new(Static.Attack, 180),
                            new(Static.CriticalDamage, 144),
                            new(Static.Evade, 4),
                            new(Static.Defense, 35),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(Static.Hp, 3_550),
                            new(Static.Attack, 198),
                            new(Static.CriticalDamage, 158),
                            new(Static.Evade, 5),
                            new(Static.Defense, 40),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(Static.Hp, 3_900),
                            new(Static.Attack, 234),
                            new(Static.CriticalDamage, 187),
                            new(Static.Evade, 6),
                            new(Static.Defense, 45),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(Static.Hp, 4_250),
                            new(Static.Attack, 252),
                            new(Static.CriticalDamage, 201),
                            new(Static.Evade, 7),
                            new(Static.Defense, 50),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(Static.Hp, 4_600),
                            new(Static.Attack, 270),
                            new(Static.CriticalDamage, 216),
                            new(Static.Evade, 7),
                            new(Static.Defense, 55),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(Static.Hp, 4_950),
                            new(Static.Attack, 288),
                            new(Static.CriticalDamage, 230),
                            new(Static.Evade, 8),
                            new(Static.Defense, 60),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(Static.Hp, 5_300),
                            new(Static.Attack, 324),
                            new(Static.CriticalDamage, 259),
                            new(Static.Evade, 9),
                            new(Static.Defense, 65),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(Static.Hp, 5_650),
                            new(Static.Attack, 342),
                            new(Static.CriticalDamage, 273),
                            new(Static.Evade, 9),
                            new(Static.Defense, 70),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(Static.Hp, 6_000),
                            new(Static.Attack, 360),
                            new(Static.CriticalDamage, 288),
                            new(Static.Evade, 10),
                            new(Static.Defense, 75),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(Static.Hp, 6_350),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 11),
                            new(Static.Defense, 80),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(Static.Hp, 6_700),
                            new(Static.Attack, 414),
                            new(Static.CriticalDamage, 331),
                            new(Static.Evade, 11),
                            new(Static.Defense, 85),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(Static.Hp, 7_050),
                            new(Static.Attack, 432),
                            new(Static.CriticalDamage, 345),
                            new(Static.Evade, 12),
                            new(Static.Defense, 90),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(Static.Hp, 7_400),
                            new(Static.Attack, 450),
                            new(Static.CriticalDamage, 360),
                            new(Static.Evade, 13),
                            new(Static.Defense, 95),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(Static.Hp, 7_750),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 13),
                            new(Static.Defense, 100),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(Static.Hp, 8_100),
                            new(Static.Attack, 504),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 14),
                            new(Static.Defense, 105),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(Static.Hp, 8_450),
                            new(Static.Attack, 522),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 15),
                            new(Static.Defense, 110),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(Static.Hp, 8_800),
                            new(Static.Attack, 540),
                            new(Static.CriticalDamage, 432),
                            new(Static.Evade, 15),
                            new(Static.Defense, 115),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(Static.Hp, 9_150),
                            new(Static.Attack, 558),
                            new(Static.CriticalDamage, 446),
                            new(Static.Evade, 16),
                            new(Static.Defense, 120),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(Static.Hp, 9_500),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 17),
                            new(Static.Defense, 125),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(Static.Hp, 9_850),
                            new(Static.Attack, 612),
                            new(Static.CriticalDamage, 489),
                            new(Static.Evade, 18),
                            new(Static.Defense, 130),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(Static.Hp, 10_200),
                            new(Static.Attack, 630),
                            new(Static.CriticalDamage, 504),
                            new(Static.Evade, 18),
                            new(Static.Defense, 135),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(Static.Hp, 10_550),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 19),
                            new(Static.Defense, 140),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(Static.Hp, 10_900),
                            new(Static.Attack, 684),
                            new(Static.CriticalDamage, 547),
                            new(Static.Evade, 20),
                            new(Static.Defense, 145),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(Static.Hp, 11_250),
                            new(Static.Attack, 702),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 20),
                            new(Static.Defense, 150),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(Static.Hp, 11_600),
                            new(Static.Attack, 720),
                            new(Static.CriticalDamage, 576),
                            new(Static.Evade, 21),
                            new(Static.Defense, 155),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(Static.Hp, 11_950),
                            new(Static.Attack, 738),
                            new(Static.CriticalDamage, 590),
                            new(Static.Evade, 22),
                            new(Static.Defense, 160),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(Static.Hp, 12_300),
                            new(Static.Attack, 774),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 22),
                            new(Static.Defense, 165),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(Static.Hp, 12_650),
                            new(Static.Attack, 792),
                            new(Static.CriticalDamage, 633),
                            new(Static.Evade, 23),
                            new(Static.Defense, 170),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(Static.Hp, 13_000),
                            new(Static.Attack, 810),
                            new(Static.CriticalDamage, 648),
                            new(Static.Evade, 24),
                            new(Static.Defense, 175),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(Static.Hp, 13_350),
                            new(Static.Attack, 828),
                            new(Static.CriticalDamage, 662),
                            new(Static.Evade, 24),
                            new(Static.Defense, 180),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(Static.Hp, 13_700),
                            new(Static.Attack, 864),
                            new(Static.CriticalDamage, 691),
                            new(Static.Evade, 25),
                            new(Static.Defense, 185),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(Static.Hp, 14_050),
                            new(Static.Attack, 882),
                            new(Static.CriticalDamage, 705),
                            new(Static.Evade, 26),
                            new(Static.Defense, 190),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(Static.Hp, 14_400),
                            new(Static.Attack, 900),
                            new(Static.CriticalDamage, 720),
                            new(Static.Evade, 26),
                            new(Static.Defense, 195),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(Static.Hp, 14_750),
                            new(Static.Attack, 918),
                            new(Static.CriticalDamage, 734),
                            new(Static.Evade, 27),
                            new(Static.Defense, 200),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(Static.Hp, 15_100),
                            new(Static.Attack, 954),
                            new(Static.CriticalDamage, 763),
                            new(Static.Evade, 28),
                            new(Static.Defense, 205),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(Static.Hp, 15_450),
                            new(Static.Attack, 972),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 29),
                            new(Static.Defense, 210),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(Static.Hp, 15_800),
                            new(Static.Attack, 990),
                            new(Static.CriticalDamage, 792),
                            new(Static.Evade, 29),
                            new(Static.Defense, 215),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(Static.Hp, 16_150),
                            new(Static.Attack, 1_008),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 30),
                            new(Static.Defense, 220),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(Static.Hp, 16_500),
                            new(Static.Attack, 1_044),
                            new(Static.CriticalDamage, 835),
                            new(Static.Evade, 31),
                            new(Static.Defense, 225),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(Static.Hp, 16_850),
                            new(Static.Attack, 1_062),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 31),
                            new(Static.Defense, 230),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(Static.Hp, 17_200),
                            new(Static.Attack, 1_080),
                            new(Static.CriticalDamage, 864),
                            new(Static.Evade, 32),
                            new(Static.Defense, 235),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(Static.Hp, 17_550),
                            new(Static.Attack, 1_098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 33),
                            new(Static.Defense, 240),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(Static.Hp, 17_900),
                            new(Static.Attack, 1_134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 33),
                            new(Static.Defense, 245),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(Static.Hp, 18_250),
                            new(Static.Attack, 1_152),
                            new(Static.CriticalDamage, 921),
                            new(Static.Evade, 34),
                            new(Static.Defense, 250),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(Static.Hp, 18_600),
                            new(Static.Attack, 1_170),
                            new(Static.CriticalDamage, 936),
                            new(Static.Evade, 35),
                            new(Static.Defense, 255),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(Static.Hp, 18_950),
                            new(Static.Attack, 1_188),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 35),
                            new(Static.Defense, 260),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(Static.Hp, 19_300),
                            new(Static.Attack, 1_224),
                            new(Static.CriticalDamage, 979),
                            new(Static.Evade, 36),
                            new(Static.Defense, 265),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(Static.Hp, 19_650),
                            new(Static.Attack, 1_242),
                            new(Static.CriticalDamage, 993),
                            new(Static.Evade, 37),
                            new(Static.Defense, 270),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(Static.Hp, 20_000),
                            new(Static.Attack, 1_260),
                            new(Static.CriticalDamage, 1_008),
                            new(Static.Evade, 37),
                            new(Static.Defense, 275),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(Static.Hp, 20_350),
                            new(Static.Attack, 1_278),
                            new(Static.CriticalDamage, 1_022),
                            new(Static.Evade, 38),
                            new(Static.Defense, 280),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(Static.Hp, 20_700),
                            new(Static.Attack, 1_314),
                            new(Static.CriticalDamage, 1_051),
                            new(Static.Evade, 39),
                            new(Static.Defense, 285),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(Static.Hp, 21_050),
                            new(Static.Attack, 1_332),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 40),
                            new(Static.Defense, 290),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(Static.Hp, 21_400),
                            new(Static.Attack, 1_350),
                            new(Static.CriticalDamage, 1_080),
                            new(Static.Evade, 40),
                            new(Static.Defense, 295),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(Static.Hp, 21_750),
                            new(Static.Attack, 1_368),
                            new(Static.CriticalDamage, 1_094),
                            new(Static.Evade, 41),
                            new(Static.Defense, 300),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(Static.Hp, 22_100),
                            new(Static.Attack, 1_404),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 42),
                            new(Static.Defense, 304),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(Static.Hp, 22_450),
                            new(Static.Attack, 1_422),
                            new(Static.CriticalDamage, 1_137),
                            new(Static.Evade, 42),
                            new(Static.Defense, 309),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(Static.Hp, 22_800),
                            new(Static.Attack, 1_440),
                            new(Static.CriticalDamage, 1_152),
                            new(Static.Evade, 43),
                            new(Static.Defense, 314),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(Static.Hp, 23_150),
                            new(Static.Attack, 1_458),
                            new(Static.CriticalDamage, 1_166),
                            new(Static.Evade, 44),
                            new(Static.Defense, 319),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(Static.Hp, 23_500),
                            new(Static.Attack, 1_494),
                            new(Static.CriticalDamage, 1_195),
                            new(Static.Evade, 44),
                            new(Static.Defense, 325),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(Static.Hp, 23_850),
                            new(Static.Attack, 1_512),
                            new(Static.CriticalDamage, 1_209),
                            new(Static.Evade, 45),
                            new(Static.Defense, 329),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(Static.Hp, 24_200),
                            new(Static.Attack, 1_530),
                            new(Static.CriticalDamage, 1_224),
                            new(Static.Evade, 46),
                            new(Static.Defense, 334),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(Static.Hp, 24_550),
                            new(Static.Attack, 1_548),
                            new(Static.CriticalDamage, 1_238),
                            new(Static.Evade, 46),
                            new(Static.Defense, 339),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}