using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupLily() =>
            new("莉莉",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(StaticEffect.Hp, 1150),
                            new(StaticEffect.Attack, 54),
                            new(StaticEffect.CriticalDamage, 43),
                            new(StaticEffect.Evade, 0),
                            new(StaticEffect.Defense, 5),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffect.Hp, 1450),
                            new(StaticEffect.Attack, 72),
                            new(StaticEffect.CriticalDamage, 57),
                            new(StaticEffect.Evade, 1),
                            new(StaticEffect.Defense, 10),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffect.Hp, 1750),
                            new(StaticEffect.Attack, 108),
                            new(StaticEffect.CriticalDamage, 86),
                            new(StaticEffect.Evade, 2),
                            new(StaticEffect.Defense, 12),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffect.Hp, 2050),
                            new(StaticEffect.Attack, 126),
                            new(StaticEffect.CriticalDamage, 100),
                            new(StaticEffect.Evade, 3),
                            new(StaticEffect.Defense, 17),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffect.Hp, 2350),
                            new(StaticEffect.Attack, 144),
                            new(StaticEffect.CriticalDamage, 115),
                            new(StaticEffect.Evade, 4),
                            new(StaticEffect.Defense, 22),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffect.Hp, 2650),
                            new(StaticEffect.Attack, 180),
                            new(StaticEffect.CriticalDamage, 144),
                            new(StaticEffect.Evade, 5),
                            new(StaticEffect.Defense, 27),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffect.Hp, 2950),
                            new(StaticEffect.Attack, 198),
                            new(StaticEffect.CriticalDamage, 158),
                            new(StaticEffect.Evade, 5),
                            new(StaticEffect.Defense, 30),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffect.Hp, 3250),
                            new(StaticEffect.Attack, 216),
                            new(StaticEffect.CriticalDamage, 172),
                            new(StaticEffect.Evade, 6),
                            new(StaticEffect.Defense, 35),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffect.Hp, 3550),
                            new(StaticEffect.Attack, 252),
                            new(StaticEffect.CriticalDamage, 201),
                            new(StaticEffect.Evade, 7),
                            new(StaticEffect.Defense, 40),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffect.Hp, 3850),
                            new(StaticEffect.Attack, 270),
                            new(StaticEffect.CriticalDamage, 216),
                            new(StaticEffect.Evade, 8),
                            new(StaticEffect.Defense, 45),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffect.Hp, 4150),
                            new(StaticEffect.Attack, 306),
                            new(StaticEffect.CriticalDamage, 244),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 47),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffect.Hp, 4450),
                            new(StaticEffect.Attack, 324),
                            new(StaticEffect.CriticalDamage, 259),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 52),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffect.Hp, 4750),
                            new(StaticEffect.Attack, 342),
                            new(StaticEffect.CriticalDamage, 273),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 57),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffect.Hp, 5050),
                            new(StaticEffect.Attack, 378),
                            new(StaticEffect.CriticalDamage, 302),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 62),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffect.Hp, 5350),
                            new(StaticEffect.Attack, 396),
                            new(StaticEffect.CriticalDamage, 316),
                            new(StaticEffect.Evade, 12),
                            new(StaticEffect.Defense, 65),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffect.Hp, 5650),
                            new(StaticEffect.Attack, 414),
                            new(StaticEffect.CriticalDamage, 331),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 70),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffect.Hp, 5950),
                            new(StaticEffect.Attack, 450),
                            new(StaticEffect.CriticalDamage, 360),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 75),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffect.Hp, 6250),
                            new(StaticEffect.Attack, 468),
                            new(StaticEffect.CriticalDamage, 374),
                            new(StaticEffect.Evade, 14),
                            new(StaticEffect.Defense, 80),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffect.Hp, 6550),
                            new(StaticEffect.Attack, 504),
                            new(StaticEffect.CriticalDamage, 403),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 82),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffect.Hp, 6850),
                            new(StaticEffect.Attack, 522),
                            new(StaticEffect.CriticalDamage, 417),
                            new(StaticEffect.Evade, 16),
                            new(StaticEffect.Defense, 87),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffect.Hp, 7150),
                            new(StaticEffect.Attack, 540),
                            new(StaticEffect.CriticalDamage, 432),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 92),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffect.Hp, 7450),
                            new(StaticEffect.Attack, 576),
                            new(StaticEffect.CriticalDamage, 460),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 97),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffect.Hp, 7750),
                            new(StaticEffect.Attack, 594),
                            new(StaticEffect.CriticalDamage, 475),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 100),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffect.Hp, 8050),
                            new(StaticEffect.Attack, 612),
                            new(StaticEffect.CriticalDamage, 489),
                            new(StaticEffect.Evade, 19),
                            new(StaticEffect.Defense, 105),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffect.Hp, 8350),
                            new(StaticEffect.Attack, 648),
                            new(StaticEffect.CriticalDamage, 518),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 110),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffect.Hp, 8650),
                            new(StaticEffect.Attack, 666),
                            new(StaticEffect.CriticalDamage, 532),
                            new(StaticEffect.Evade, 21),
                            new(StaticEffect.Defense, 115),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffect.Hp, 8950),
                            new(StaticEffect.Attack, 702),
                            new(StaticEffect.CriticalDamage, 561),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 117),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffect.Hp, 9250),
                            new(StaticEffect.Attack, 720),
                            new(StaticEffect.CriticalDamage, 576),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 122),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffect.Hp, 9550),
                            new(StaticEffect.Attack, 738),
                            new(StaticEffect.CriticalDamage, 590),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 127),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffect.Hp, 9850),
                            new(StaticEffect.Attack, 774),
                            new(StaticEffect.CriticalDamage, 619),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 132),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffect.Hp, 10150),
                            new(StaticEffect.Attack, 792),
                            new(StaticEffect.CriticalDamage, 633),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 135),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffect.Hp, 10450),
                            new(StaticEffect.Attack, 810),
                            new(StaticEffect.CriticalDamage, 648),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 140),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffect.Hp, 10750),
                            new(StaticEffect.Attack, 846),
                            new(StaticEffect.CriticalDamage, 676),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 145),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffect.Hp, 11050),
                            new(StaticEffect.Attack, 864),
                            new(StaticEffect.CriticalDamage, 691),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 150),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffect.Hp, 11350),
                            new(StaticEffect.Attack, 900),
                            new(StaticEffect.CriticalDamage, 720),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 152),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffect.Hp, 11650),
                            new(StaticEffect.Attack, 918),
                            new(StaticEffect.CriticalDamage, 734),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 157),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffect.Hp, 11950),
                            new(StaticEffect.Attack, 936),
                            new(StaticEffect.CriticalDamage, 748),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 162),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffect.Hp, 12250),
                            new(StaticEffect.Attack, 972),
                            new(StaticEffect.CriticalDamage, 777),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 167),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffect.Hp, 12550),
                            new(StaticEffect.Attack, 990),
                            new(StaticEffect.CriticalDamage, 792),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 170),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffect.Hp, 12850),
                            new(StaticEffect.Attack, 1008),
                            new(StaticEffect.CriticalDamage, 806),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 175),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffect.Hp, 13150),
                            new(StaticEffect.Attack, 1044),
                            new(StaticEffect.CriticalDamage, 835),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 180),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffect.Hp, 13450),
                            new(StaticEffect.Attack, 1062),
                            new(StaticEffect.CriticalDamage, 849),
                            new(StaticEffect.Evade, 34),
                            new(StaticEffect.Defense, 185),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffect.Hp, 13750),
                            new(StaticEffect.Attack, 1098),
                            new(StaticEffect.CriticalDamage, 878),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 187),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffect.Hp, 14050),
                            new(StaticEffect.Attack, 1116),
                            new(StaticEffect.CriticalDamage, 892),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 192),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffect.Hp, 14350),
                            new(StaticEffect.Attack, 1134),
                            new(StaticEffect.CriticalDamage, 907),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 197),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffect.Hp, 14650),
                            new(StaticEffect.Attack, 1170),
                            new(StaticEffect.CriticalDamage, 936),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 202),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffect.Hp, 14950),
                            new(StaticEffect.Attack, 1188),
                            new(StaticEffect.CriticalDamage, 950),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 205),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffect.Hp, 15250),
                            new(StaticEffect.Attack, 1206),
                            new(StaticEffect.CriticalDamage, 964),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 210),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffect.Hp, 15550),
                            new(StaticEffect.Attack, 1242),
                            new(StaticEffect.CriticalDamage, 993),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 215),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffect.Hp, 15850),
                            new(StaticEffect.Attack, 1260),
                            new(StaticEffect.CriticalDamage, 1008),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 220),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffect.Hp, 16150),
                            new(StaticEffect.Attack, 1295),
                            new(StaticEffect.CriticalDamage, 1036),
                            new(StaticEffect.Evade, 41),
                            new(StaticEffect.Defense, 222),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffect.Hp, 16450),
                            new(StaticEffect.Attack, 1314),
                            new(StaticEffect.CriticalDamage, 1051),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 227),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffect.Hp, 16750),
                            new(StaticEffect.Attack, 1331),
                            new(StaticEffect.CriticalDamage, 1065),
                            new(StaticEffect.Evade, 43),
                            new(StaticEffect.Defense, 232),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffect.Hp, 17050),
                            new(StaticEffect.Attack, 1368),
                            new(StaticEffect.CriticalDamage, 1094),
                            new(StaticEffect.Evade, 44),
                            new(StaticEffect.Defense, 237),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffect.Hp, 17350),
                            new(StaticEffect.Attack, 1386),
                            new(StaticEffect.CriticalDamage, 1108),
                            new(StaticEffect.Evade, 44),
                            new(StaticEffect.Defense, 240),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffect.Hp, 17650),
                            new(StaticEffect.Attack, 1404),
                            new(StaticEffect.CriticalDamage, 1123),
                            new(StaticEffect.Evade, 45),
                            new(StaticEffect.Defense, 245),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffect.Hp, 17950),
                            new(StaticEffect.Attack, 1440),
                            new(StaticEffect.CriticalDamage, 1152),
                            new(StaticEffect.Evade, 46),
                            new(StaticEffect.Defense, 250),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffect.Hp, 18250),
                            new(StaticEffect.Attack, 1458),
                            new(StaticEffect.CriticalDamage, 1166),
                            new(StaticEffect.Evade, 47),
                            new(StaticEffect.Defense, 255),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffect.Hp, 18550),
                            new(StaticEffect.Attack, 1494),
                            new(StaticEffect.CriticalDamage, 1195),
                            new(StaticEffect.Evade, 48),
                            new(StaticEffect.Defense, 257),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffect.Hp, 18850),
                            new(StaticEffect.Attack, 1512),
                            new(StaticEffect.CriticalDamage, 1209),
                            new(StaticEffect.Evade, 48),
                            new(StaticEffect.Defense, 262),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffect.Hp, 19150),
                            new(StaticEffect.Attack, 1530),
                            new(StaticEffect.CriticalDamage, 1224),
                            new(StaticEffect.Evade, 49),
                            new(StaticEffect.Defense, 267),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffect.Hp, 19450),
                            new(StaticEffect.Attack, 1566),
                            new(StaticEffect.CriticalDamage, 1252),
                            new(StaticEffect.Evade, 50),
                            new(StaticEffect.Defense, 272),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffect.Hp, 19750),
                            new(StaticEffect.Attack, 1584),
                            new(StaticEffect.CriticalDamage, 1267),
                            new(StaticEffect.Evade, 51),
                            new(StaticEffect.Defense, 275),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffect.Hp, 20050),
                            new(StaticEffect.Attack, 1601),
                            new(StaticEffect.CriticalDamage, 1281),
                            new(StaticEffect.Evade, 52),
                            new(StaticEffect.Defense, 280),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffect.Hp, 20350),
                            new(StaticEffect.Attack, 1638),
                            new(StaticEffect.CriticalDamage, 1310),
                            new(StaticEffect.Evade, 52),
                            new(StaticEffect.Defense, 285),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffect.Hp, 20650),
                            new(StaticEffect.Attack, 1656),
                            new(StaticEffect.CriticalDamage, 1324),
                            new(StaticEffect.Evade, 53),
                            new(StaticEffect.Defense, 289),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffect.Hp, 20950),
                            new(StaticEffect.Attack, 1692),
                            new(StaticEffect.CriticalDamage, 1353),
                            new(StaticEffect.Evade, 54),
                            new(StaticEffect.Defense, 292),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffect.Hp, 21250),
                            new(StaticEffect.Attack, 1710),
                            new(StaticEffect.CriticalDamage, 1368),
                            new(StaticEffect.Evade, 55),
                            new(StaticEffect.Defense, 297),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}