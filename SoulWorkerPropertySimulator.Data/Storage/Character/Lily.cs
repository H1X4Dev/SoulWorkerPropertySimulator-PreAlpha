using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Lily =>
            new("莉莉",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(Static.HP, 1150),
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
                            new(Static.HP, 1450),
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
                            new(Static.HP, 1750),
                            new(Static.Attack, 108),
                            new(Static.CriticalDamage, 86),
                            new(Static.Evade, 2),
                            new(Static.Defense, 12),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(Static.HP, 2050),
                            new(Static.Attack, 126),
                            new(Static.CriticalDamage, 100),
                            new(Static.Evade, 3),
                            new(Static.Defense, 17),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(Static.HP, 2350),
                            new(Static.Attack, 144),
                            new(Static.CriticalDamage, 115),
                            new(Static.Evade, 4),
                            new(Static.Defense, 22),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(Static.HP, 2650),
                            new(Static.Attack, 180),
                            new(Static.CriticalDamage, 144),
                            new(Static.Evade, 5),
                            new(Static.Defense, 27),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(Static.HP, 2950),
                            new(Static.Attack, 198),
                            new(Static.CriticalDamage, 158),
                            new(Static.Evade, 5),
                            new(Static.Defense, 30),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(Static.HP, 3250),
                            new(Static.Attack, 216),
                            new(Static.CriticalDamage, 172),
                            new(Static.Evade, 6),
                            new(Static.Defense, 35),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(Static.HP, 3550),
                            new(Static.Attack, 252),
                            new(Static.CriticalDamage, 201),
                            new(Static.Evade, 7),
                            new(Static.Defense, 40),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(Static.HP, 3850),
                            new(Static.Attack, 270),
                            new(Static.CriticalDamage, 216),
                            new(Static.Evade, 8),
                            new(Static.Defense, 45),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(Static.HP, 4150),
                            new(Static.Attack, 306),
                            new(Static.CriticalDamage, 244),
                            new(Static.Evade, 9),
                            new(Static.Defense, 47),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(Static.HP, 4450),
                            new(Static.Attack, 324),
                            new(Static.CriticalDamage, 259),
                            new(Static.Evade, 9),
                            new(Static.Defense, 52),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(Static.HP, 4750),
                            new(Static.Attack, 342),
                            new(Static.CriticalDamage, 273),
                            new(Static.Evade, 10),
                            new(Static.Defense, 57),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(Static.HP, 5050),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 11),
                            new(Static.Defense, 62),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(Static.HP, 5350),
                            new(Static.Attack, 396),
                            new(Static.CriticalDamage, 316),
                            new(Static.Evade, 12),
                            new(Static.Defense, 65),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(Static.HP, 5650),
                            new(Static.Attack, 414),
                            new(Static.CriticalDamage, 331),
                            new(Static.Evade, 13),
                            new(Static.Defense, 70),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(Static.HP, 5950),
                            new(Static.Attack, 450),
                            new(Static.CriticalDamage, 360),
                            new(Static.Evade, 13),
                            new(Static.Defense, 75),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(Static.HP, 6250),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 14),
                            new(Static.Defense, 80),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(Static.HP, 6550),
                            new(Static.Attack, 504),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 15),
                            new(Static.Defense, 82),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(Static.HP, 6850),
                            new(Static.Attack, 522),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 16),
                            new(Static.Defense, 87),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(Static.HP, 7150),
                            new(Static.Attack, 540),
                            new(Static.CriticalDamage, 432),
                            new(Static.Evade, 17),
                            new(Static.Defense, 92),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(Static.HP, 7450),
                            new(Static.Attack, 576),
                            new(Static.CriticalDamage, 460),
                            new(Static.Evade, 18),
                            new(Static.Defense, 97),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(Static.HP, 7750),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 18),
                            new(Static.Defense, 100),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(Static.HP, 8050),
                            new(Static.Attack, 612),
                            new(Static.CriticalDamage, 489),
                            new(Static.Evade, 19),
                            new(Static.Defense, 105),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(Static.HP, 8350),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 20),
                            new(Static.Defense, 110),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(Static.HP, 8650),
                            new(Static.Attack, 666),
                            new(Static.CriticalDamage, 532),
                            new(Static.Evade, 21),
                            new(Static.Defense, 115),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(Static.HP, 8950),
                            new(Static.Attack, 702),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 22),
                            new(Static.Defense, 117),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(Static.HP, 9250),
                            new(Static.Attack, 720),
                            new(Static.CriticalDamage, 576),
                            new(Static.Evade, 22),
                            new(Static.Defense, 122),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(Static.HP, 9550),
                            new(Static.Attack, 738),
                            new(Static.CriticalDamage, 590),
                            new(Static.Evade, 23),
                            new(Static.Defense, 127),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(Static.HP, 9850),
                            new(Static.Attack, 774),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 24),
                            new(Static.Defense, 132),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(Static.HP, 10150),
                            new(Static.Attack, 792),
                            new(Static.CriticalDamage, 633),
                            new(Static.Evade, 25),
                            new(Static.Defense, 135),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(Static.HP, 10450),
                            new(Static.Attack, 810),
                            new(Static.CriticalDamage, 648),
                            new(Static.Evade, 26),
                            new(Static.Defense, 140),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(Static.HP, 10750),
                            new(Static.Attack, 846),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 26),
                            new(Static.Defense, 145),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(Static.HP, 11050),
                            new(Static.Attack, 864),
                            new(Static.CriticalDamage, 691),
                            new(Static.Evade, 27),
                            new(Static.Defense, 150),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(Static.HP, 11350),
                            new(Static.Attack, 900),
                            new(Static.CriticalDamage, 720),
                            new(Static.Evade, 28),
                            new(Static.Defense, 152),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(Static.HP, 11650),
                            new(Static.Attack, 918),
                            new(Static.CriticalDamage, 734),
                            new(Static.Evade, 29),
                            new(Static.Defense, 157),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(Static.HP, 11950),
                            new(Static.Attack, 936),
                            new(Static.CriticalDamage, 748),
                            new(Static.Evade, 30),
                            new(Static.Defense, 162),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(Static.HP, 12250),
                            new(Static.Attack, 972),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 31),
                            new(Static.Defense, 167),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(Static.HP, 12550),
                            new(Static.Attack, 990),
                            new(Static.CriticalDamage, 792),
                            new(Static.Evade, 31),
                            new(Static.Defense, 170),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(Static.HP, 12850),
                            new(Static.Attack, 1008),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 32),
                            new(Static.Defense, 175),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(Static.HP, 13150),
                            new(Static.Attack, 1044),
                            new(Static.CriticalDamage, 835),
                            new(Static.Evade, 33),
                            new(Static.Defense, 180),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(Static.HP, 13450),
                            new(Static.Attack, 1062),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 34),
                            new(Static.Defense, 185),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(Static.HP, 13750),
                            new(Static.Attack, 1098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 35),
                            new(Static.Defense, 187),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(Static.HP, 14050),
                            new(Static.Attack, 1116),
                            new(Static.CriticalDamage, 892),
                            new(Static.Evade, 35),
                            new(Static.Defense, 192),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(Static.HP, 14350),
                            new(Static.Attack, 1134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 36),
                            new(Static.Defense, 197),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(Static.HP, 14650),
                            new(Static.Attack, 1170),
                            new(Static.CriticalDamage, 936),
                            new(Static.Evade, 37),
                            new(Static.Defense, 202),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(Static.HP, 14950),
                            new(Static.Attack, 1188),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 38),
                            new(Static.Defense, 205),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(Static.HP, 15250),
                            new(Static.Attack, 1206),
                            new(Static.CriticalDamage, 964),
                            new(Static.Evade, 39),
                            new(Static.Defense, 210),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(Static.HP, 15550),
                            new(Static.Attack, 1242),
                            new(Static.CriticalDamage, 993),
                            new(Static.Evade, 39),
                            new(Static.Defense, 215),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(Static.HP, 15850),
                            new(Static.Attack, 1260),
                            new(Static.CriticalDamage, 1008),
                            new(Static.Evade, 40),
                            new(Static.Defense, 220),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(Static.HP, 16150),
                            new(Static.Attack, 1295),
                            new(Static.CriticalDamage, 1036),
                            new(Static.Evade, 41),
                            new(Static.Defense, 222),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(Static.HP, 16450),
                            new(Static.Attack, 1314),
                            new(Static.CriticalDamage, 1051),
                            new(Static.Evade, 42),
                            new(Static.Defense, 227),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(Static.HP, 16750),
                            new(Static.Attack, 1331),
                            new(Static.CriticalDamage, 1065),
                            new(Static.Evade, 43),
                            new(Static.Defense, 232),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(Static.HP, 17050),
                            new(Static.Attack, 1368),
                            new(Static.CriticalDamage, 1094),
                            new(Static.Evade, 44),
                            new(Static.Defense, 237),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(Static.HP, 17350),
                            new(Static.Attack, 1386),
                            new(Static.CriticalDamage, 1108),
                            new(Static.Evade, 44),
                            new(Static.Defense, 240),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(Static.HP, 17650),
                            new(Static.Attack, 1404),
                            new(Static.CriticalDamage, 1123),
                            new(Static.Evade, 45),
                            new(Static.Defense, 245),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(Static.HP, 17950),
                            new(Static.Attack, 1440),
                            new(Static.CriticalDamage, 1152),
                            new(Static.Evade, 46),
                            new(Static.Defense, 250),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(Static.HP, 18250),
                            new(Static.Attack, 1458),
                            new(Static.CriticalDamage, 1166),
                            new(Static.Evade, 47),
                            new(Static.Defense, 255),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(Static.HP, 18550),
                            new(Static.Attack, 1494),
                            new(Static.CriticalDamage, 1195),
                            new(Static.Evade, 48),
                            new(Static.Defense, 257),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(Static.HP, 18850),
                            new(Static.Attack, 1512),
                            new(Static.CriticalDamage, 1209),
                            new(Static.Evade, 48),
                            new(Static.Defense, 262),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(Static.HP, 19150),
                            new(Static.Attack, 1530),
                            new(Static.CriticalDamage, 1224),
                            new(Static.Evade, 49),
                            new(Static.Defense, 267),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(Static.HP, 19450),
                            new(Static.Attack, 1566),
                            new(Static.CriticalDamage, 1252),
                            new(Static.Evade, 50),
                            new(Static.Defense, 272),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(Static.HP, 19750),
                            new(Static.Attack, 1584),
                            new(Static.CriticalDamage, 1267),
                            new(Static.Evade, 51),
                            new(Static.Defense, 275),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(Static.HP, 20050),
                            new(Static.Attack, 1601),
                            new(Static.CriticalDamage, 1281),
                            new(Static.Evade, 52),
                            new(Static.Defense, 280),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(Static.HP, 20350),
                            new(Static.Attack, 1638),
                            new(Static.CriticalDamage, 1310),
                            new(Static.Evade, 52),
                            new(Static.Defense, 285),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(Static.HP, 20650),
                            new(Static.Attack, 1656),
                            new(Static.CriticalDamage, 1324),
                            new(Static.Evade, 53),
                            new(Static.Defense, 289),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(Static.HP, 20950),
                            new(Static.Attack, 1692),
                            new(Static.CriticalDamage, 1353),
                            new(Static.Evade, 54),
                            new(Static.Defense, 292),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(Static.HP, 21250),
                            new(Static.Attack, 1710),
                            new(Static.CriticalDamage, 1368),
                            new(Static.Evade, 55),
                            new(Static.Defense, 297),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}