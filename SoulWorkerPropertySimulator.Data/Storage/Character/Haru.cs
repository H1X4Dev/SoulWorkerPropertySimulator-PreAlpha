using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupHaru() =>
            new("哈露",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_150),
                            new(StaticEffect.Attack, 54),
                            new(StaticEffect.CriticalDamage, 43),
                            new(StaticEffect.Evade, 0),
                            new(StaticEffect.Defense, 7),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_550),
                            new(StaticEffect.Attack, 72),
                            new(StaticEffect.CriticalDamage, 57),
                            new(StaticEffect.Evade, 1),
                            new(StaticEffect.Defense, 12),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_950),
                            new(StaticEffect.Attack, 90),
                            new(StaticEffect.CriticalDamage, 72),
                            new(StaticEffect.Evade, 2),
                            new(StaticEffect.Defense, 20),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_350),
                            new(StaticEffect.Attack, 108),
                            new(StaticEffect.CriticalDamage, 86),
                            new(StaticEffect.Evade, 2),
                            new(StaticEffect.Defense, 25),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_750),
                            new(StaticEffect.Attack, 144),
                            new(StaticEffect.CriticalDamage, 115),
                            new(StaticEffect.Evade, 3),
                            new(StaticEffect.Defense, 32),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_150),
                            new(StaticEffect.Attack, 162),
                            new(StaticEffect.CriticalDamage, 129),
                            new(StaticEffect.Evade, 3),
                            new(StaticEffect.Defense, 37),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_550),
                            new(StaticEffect.Attack, 180),
                            new(StaticEffect.CriticalDamage, 144),
                            new(StaticEffect.Evade, 4),
                            new(StaticEffect.Defense, 45),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_950),
                            new(StaticEffect.Attack, 198),
                            new(StaticEffect.CriticalDamage, 158),
                            new(StaticEffect.Evade, 5),
                            new(StaticEffect.Defense, 50),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffect.Hp, 4_350),
                            new(StaticEffect.Attack, 234),
                            new(StaticEffect.CriticalDamage, 187),
                            new(StaticEffect.Evade, 5),
                            new(StaticEffect.Defense, 57),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffect.Hp, 4_750),
                            new(StaticEffect.Attack, 252),
                            new(StaticEffect.CriticalDamage, 201),
                            new(StaticEffect.Evade, 6),
                            new(StaticEffect.Defense, 62),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_150),
                            new(StaticEffect.Attack, 270),
                            new(StaticEffect.CriticalDamage, 216),
                            new(StaticEffect.Evade, 7),
                            new(StaticEffect.Defense, 70),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_550),
                            new(StaticEffect.Attack, 288),
                            new(StaticEffect.CriticalDamage, 230),
                            new(StaticEffect.Evade, 7),
                            new(StaticEffect.Defense, 75),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_950),
                            new(StaticEffect.Attack, 324),
                            new(StaticEffect.CriticalDamage, 259),
                            new(StaticEffect.Evade, 8),
                            new(StaticEffect.Defense, 82),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_350),
                            new(StaticEffect.Attack, 342),
                            new(StaticEffect.CriticalDamage, 273),
                            new(StaticEffect.Evade, 8),
                            new(StaticEffect.Defense, 87),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_750),
                            new(StaticEffect.Attack, 360),
                            new(StaticEffect.CriticalDamage, 288),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 95),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_150),
                            new(StaticEffect.Attack, 378),
                            new(StaticEffect.CriticalDamage, 302),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 100),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_550),
                            new(StaticEffect.Attack, 414),
                            new(StaticEffect.CriticalDamage, 331),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 107),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_950),
                            new(StaticEffect.Attack, 432),
                            new(StaticEffect.CriticalDamage, 345),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 112),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_350),
                            new(StaticEffect.Attack, 450),
                            new(StaticEffect.CriticalDamage, 360),
                            new(StaticEffect.Evade, 12),
                            new(StaticEffect.Defense, 120),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_750),
                            new(StaticEffect.Attack, 468),
                            new(StaticEffect.CriticalDamage, 374),
                            new(StaticEffect.Evade, 12),
                            new(StaticEffect.Defense, 125),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_150),
                            new(StaticEffect.Attack, 504),
                            new(StaticEffect.CriticalDamage, 403),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 132),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_550),
                            new(StaticEffect.Attack, 522),
                            new(StaticEffect.CriticalDamage, 417),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 137),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_950),
                            new(StaticEffect.Attack, 540),
                            new(StaticEffect.CriticalDamage, 432),
                            new(StaticEffect.Evade, 14),
                            new(StaticEffect.Defense, 145),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_350),
                            new(StaticEffect.Attack, 558),
                            new(StaticEffect.CriticalDamage, 446),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 150),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_750),
                            new(StaticEffect.Attack, 594),
                            new(StaticEffect.CriticalDamage, 475),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 157),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_150),
                            new(StaticEffect.Attack, 612),
                            new(StaticEffect.CriticalDamage, 489),
                            new(StaticEffect.Evade, 16),
                            new(StaticEffect.Defense, 162),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_550),
                            new(StaticEffect.Attack, 630),
                            new(StaticEffect.CriticalDamage, 504),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 170),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_950),
                            new(StaticEffect.Attack, 648),
                            new(StaticEffect.CriticalDamage, 518),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 175),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_350),
                            new(StaticEffect.Attack, 684),
                            new(StaticEffect.CriticalDamage, 547),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 182),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_750),
                            new(StaticEffect.Attack, 702),
                            new(StaticEffect.CriticalDamage, 561),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 187),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_150),
                            new(StaticEffect.Attack, 720),
                            new(StaticEffect.CriticalDamage, 576),
                            new(StaticEffect.Evade, 19),
                            new(StaticEffect.Defense, 195),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_550),
                            new(StaticEffect.Attack, 738),
                            new(StaticEffect.CriticalDamage, 590),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 200),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_950),
                            new(StaticEffect.Attack, 774),
                            new(StaticEffect.CriticalDamage, 619),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 207),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_350),
                            new(StaticEffect.Attack, 792),
                            new(StaticEffect.CriticalDamage, 633),
                            new(StaticEffect.Evade, 21),
                            new(StaticEffect.Defense, 212),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_750),
                            new(StaticEffect.Attack, 810),
                            new(StaticEffect.CriticalDamage, 648),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 220),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_150),
                            new(StaticEffect.Attack, 828),
                            new(StaticEffect.CriticalDamage, 662),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 225),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_550),
                            new(StaticEffect.Attack, 864),
                            new(StaticEffect.CriticalDamage, 691),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 232),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_950),
                            new(StaticEffect.Attack, 882),
                            new(StaticEffect.CriticalDamage, 705),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 237),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_350),
                            new(StaticEffect.Attack, 900),
                            new(StaticEffect.CriticalDamage, 720),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 245),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_750),
                            new(StaticEffect.Attack, 918),
                            new(StaticEffect.CriticalDamage, 734),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 250),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_150),
                            new(StaticEffect.Attack, 954),
                            new(StaticEffect.CriticalDamage, 763),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 257),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_550),
                            new(StaticEffect.Attack, 972),
                            new(StaticEffect.CriticalDamage, 777),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 262),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_950),
                            new(StaticEffect.Attack, 990),
                            new(StaticEffect.CriticalDamage, 792),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 270),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_350),
                            new(StaticEffect.Attack, 1_008),
                            new(StaticEffect.CriticalDamage, 806),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 275),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_750),
                            new(StaticEffect.Attack, 1_044),
                            new(StaticEffect.CriticalDamage, 835),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 282),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_150),
                            new(StaticEffect.Attack, 1_062),
                            new(StaticEffect.CriticalDamage, 849),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 287),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_550),
                            new(StaticEffect.Attack, 1_080),
                            new(StaticEffect.CriticalDamage, 864),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 295),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_950),
                            new(StaticEffect.Attack, 1_098),
                            new(StaticEffect.CriticalDamage, 878),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 300),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_350),
                            new(StaticEffect.Attack, 1_134),
                            new(StaticEffect.CriticalDamage, 907),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 307),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_750),
                            new(StaticEffect.Attack, 1_152),
                            new(StaticEffect.CriticalDamage, 921),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 312),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_150),
                            new(StaticEffect.Attack, 1_170),
                            new(StaticEffect.CriticalDamage, 936),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 320),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_550),
                            new(StaticEffect.Attack, 1_188),
                            new(StaticEffect.CriticalDamage, 950),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 325),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_950),
                            new(StaticEffect.Attack, 1_224),
                            new(StaticEffect.CriticalDamage, 979),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 332),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_350),
                            new(StaticEffect.Attack, 1_242),
                            new(StaticEffect.CriticalDamage, 993),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 337),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_750),
                            new(StaticEffect.Attack, 1_260),
                            new(StaticEffect.CriticalDamage, 1_008),
                            new(StaticEffect.Evade, 34),
                            new(StaticEffect.Defense, 345),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_150),
                            new(StaticEffect.Attack, 1_278),
                            new(StaticEffect.CriticalDamage, 1_022),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 350),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_550),
                            new(StaticEffect.Attack, 1_314),
                            new(StaticEffect.CriticalDamage, 1_051),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 357),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_950),
                            new(StaticEffect.Attack, 1_332),
                            new(StaticEffect.CriticalDamage, 1_065),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 362),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_350),
                            new(StaticEffect.Attack, 1_350),
                            new(StaticEffect.CriticalDamage, 1_080),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 370),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_750),
                            new(StaticEffect.Attack, 1_368),
                            new(StaticEffect.CriticalDamage, 1_094),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 375),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_150),
                            new(StaticEffect.Attack, 1_404),
                            new(StaticEffect.CriticalDamage, 1_123),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 382),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_550),
                            new(StaticEffect.Attack, 1_422),
                            new(StaticEffect.CriticalDamage, 1_137),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 387),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_950),
                            new(StaticEffect.Attack, 1_440),
                            new(StaticEffect.CriticalDamage, 1_152),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 395),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_350),
                            new(StaticEffect.Attack, 1_457),
                            new(StaticEffect.CriticalDamage, 1_166),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 400),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_750),
                            new(StaticEffect.Attack, 1_493),
                            new(StaticEffect.CriticalDamage, 1_195),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 407),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_150),
                            new(StaticEffect.Attack, 1_512),
                            new(StaticEffect.CriticalDamage, 1_209),
                            new(StaticEffect.Evade, 41),
                            new(StaticEffect.Defense, 412),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_550),
                            new(StaticEffect.Attack, 1_530),
                            new(StaticEffect.CriticalDamage, 1_224),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 419),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_950),
                            new(StaticEffect.Attack, 1_548),
                            new(StaticEffect.CriticalDamage, 1_238),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 424),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}