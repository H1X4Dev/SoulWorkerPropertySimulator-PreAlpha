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
                        new Effect[]
                        {
                            new(Static.HP, 1150),
                            new(Static.Attack, 54),
                            new(Static.CriticalDamage, 43),
                            new(Static.Evade, 0),
                            new(Static.Defense, 5),
                            new(Static.Accuracy, AccuracyList[0])
                        }
                    },
                    {
                        2,
                        new Effect[]
                        {
                            new(Static.HP, 1450),
                            new(Static.Attack, 72),
                            new(Static.CriticalDamage, 57),
                            new(Static.Evade, 1),
                            new(Static.Defense, 10),
                            new(Static.Accuracy, AccuracyList[1])
                        }
                    },
                    {
                        3,
                        new Effect[]
                        {
                            new(Static.HP, 1750),
                            new(Static.Attack, 108),
                            new(Static.CriticalDamage, 86),
                            new(Static.Evade, 2),
                            new(Static.Defense, 12),
                            new(Static.Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(Static.HP, 2050),
                            new(Static.Attack, 126),
                            new(Static.CriticalDamage, 100),
                            new(Static.Evade, 3),
                            new(Static.Defense, 17),
                            new(Static.Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(Static.HP, 2350),
                            new(Static.Attack, 144),
                            new(Static.CriticalDamage, 115),
                            new(Static.Evade, 4),
                            new(Static.Defense, 22),
                            new(Static.Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(Static.HP, 2650),
                            new(Static.Attack, 180),
                            new(Static.CriticalDamage, 144),
                            new(Static.Evade, 5),
                            new(Static.Defense, 27),
                            new(Static.Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(Static.HP, 2950),
                            new(Static.Attack, 198),
                            new(Static.CriticalDamage, 158),
                            new(Static.Evade, 5),
                            new(Static.Defense, 30),
                            new(Static.Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(Static.HP, 3250),
                            new(Static.Attack, 216),
                            new(Static.CriticalDamage, 172),
                            new(Static.Evade, 6),
                            new(Static.Defense, 35),
                            new(Static.Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(Static.HP, 3550),
                            new(Static.Attack, 252),
                            new(Static.CriticalDamage, 201),
                            new(Static.Evade, 7),
                            new(Static.Defense, 40),
                            new(Static.Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(Static.HP, 3850),
                            new(Static.Attack, 270),
                            new(Static.CriticalDamage, 216),
                            new(Static.Evade, 8),
                            new(Static.Defense, 45),
                            new(Static.Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(Static.HP, 4150),
                            new(Static.Attack, 306),
                            new(Static.CriticalDamage, 244),
                            new(Static.Evade, 9),
                            new(Static.Defense, 47),
                            new(Static.Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(Static.HP, 4450),
                            new(Static.Attack, 324),
                            new(Static.CriticalDamage, 259),
                            new(Static.Evade, 9),
                            new(Static.Defense, 52),
                            new(Static.Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(Static.HP, 4750),
                            new(Static.Attack, 342),
                            new(Static.CriticalDamage, 273),
                            new(Static.Evade, 10),
                            new(Static.Defense, 57),
                            new(Static.Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(Static.HP, 5050),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 11),
                            new(Static.Defense, 62),
                            new(Static.Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(Static.HP, 5350),
                            new(Static.Attack, 396),
                            new(Static.CriticalDamage, 316),
                            new(Static.Evade, 12),
                            new(Static.Defense, 65),
                            new(Static.Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(Static.HP, 5650),
                            new(Static.Attack, 414),
                            new(Static.CriticalDamage, 331),
                            new(Static.Evade, 13),
                            new(Static.Defense, 70),
                            new(Static.Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(Static.HP, 5950),
                            new(Static.Attack, 450),
                            new(Static.CriticalDamage, 360),
                            new(Static.Evade, 13),
                            new(Static.Defense, 75),
                            new(Static.Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(Static.HP, 6250),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 14),
                            new(Static.Defense, 80),
                            new(Static.Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(Static.HP, 6550),
                            new(Static.Attack, 504),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 15),
                            new(Static.Defense, 82),
                            new(Static.Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(Static.HP, 6850),
                            new(Static.Attack, 522),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 16),
                            new(Static.Defense, 87),
                            new(Static.Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(Static.HP, 7150),
                            new(Static.Attack, 540),
                            new(Static.CriticalDamage, 432),
                            new(Static.Evade, 17),
                            new(Static.Defense, 92),
                            new(Static.Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(Static.HP, 7450),
                            new(Static.Attack, 576),
                            new(Static.CriticalDamage, 460),
                            new(Static.Evade, 18),
                            new(Static.Defense, 97),
                            new(Static.Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(Static.HP, 7750),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 18),
                            new(Static.Defense, 100),
                            new(Static.Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(Static.HP, 8050),
                            new(Static.Attack, 612),
                            new(Static.CriticalDamage, 489),
                            new(Static.Evade, 19),
                            new(Static.Defense, 105),
                            new(Static.Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(Static.HP, 8350),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 20),
                            new(Static.Defense, 110),
                            new(Static.Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(Static.HP, 8650),
                            new(Static.Attack, 666),
                            new(Static.CriticalDamage, 532),
                            new(Static.Evade, 21),
                            new(Static.Defense, 115),
                            new(Static.Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(Static.HP, 8950),
                            new(Static.Attack, 702),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 22),
                            new(Static.Defense, 117),
                            new(Static.Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(Static.HP, 9250),
                            new(Static.Attack, 720),
                            new(Static.CriticalDamage, 576),
                            new(Static.Evade, 22),
                            new(Static.Defense, 122),
                            new(Static.Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(Static.HP, 9550),
                            new(Static.Attack, 738),
                            new(Static.CriticalDamage, 590),
                            new(Static.Evade, 23),
                            new(Static.Defense, 127),
                            new(Static.Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(Static.HP, 9850),
                            new(Static.Attack, 774),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 24),
                            new(Static.Defense, 132),
                            new(Static.Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(Static.HP, 10150),
                            new(Static.Attack, 792),
                            new(Static.CriticalDamage, 633),
                            new(Static.Evade, 25),
                            new(Static.Defense, 135),
                            new(Static.Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(Static.HP, 10450),
                            new(Static.Attack, 810),
                            new(Static.CriticalDamage, 648),
                            new(Static.Evade, 26),
                            new(Static.Defense, 140),
                            new(Static.Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(Static.HP, 10750),
                            new(Static.Attack, 846),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 26),
                            new(Static.Defense, 145),
                            new(Static.Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(Static.HP, 11050),
                            new(Static.Attack, 864),
                            new(Static.CriticalDamage, 691),
                            new(Static.Evade, 27),
                            new(Static.Defense, 150),
                            new(Static.Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(Static.HP, 11350),
                            new(Static.Attack, 900),
                            new(Static.CriticalDamage, 720),
                            new(Static.Evade, 28),
                            new(Static.Defense, 152),
                            new(Static.Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(Static.HP, 11650),
                            new(Static.Attack, 918),
                            new(Static.CriticalDamage, 734),
                            new(Static.Evade, 29),
                            new(Static.Defense, 157),
                            new(Static.Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(Static.HP, 11950),
                            new(Static.Attack, 936),
                            new(Static.CriticalDamage, 748),
                            new(Static.Evade, 30),
                            new(Static.Defense, 162),
                            new(Static.Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(Static.HP, 12250),
                            new(Static.Attack, 972),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 31),
                            new(Static.Defense, 167),
                            new(Static.Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(Static.HP, 12550),
                            new(Static.Attack, 990),
                            new(Static.CriticalDamage, 792),
                            new(Static.Evade, 31),
                            new(Static.Defense, 170),
                            new(Static.Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(Static.HP, 12850),
                            new(Static.Attack, 1008),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 32),
                            new(Static.Defense, 175),
                            new(Static.Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(Static.HP, 13150),
                            new(Static.Attack, 1044),
                            new(Static.CriticalDamage, 835),
                            new(Static.Evade, 33),
                            new(Static.Defense, 180),
                            new(Static.Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(Static.HP, 13450),
                            new(Static.Attack, 1062),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 34),
                            new(Static.Defense, 185),
                            new(Static.Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(Static.HP, 13750),
                            new(Static.Attack, 1098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 35),
                            new(Static.Defense, 187),
                            new(Static.Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(Static.HP, 14050),
                            new(Static.Attack, 1116),
                            new(Static.CriticalDamage, 892),
                            new(Static.Evade, 35),
                            new(Static.Defense, 192),
                            new(Static.Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(Static.HP, 14350),
                            new(Static.Attack, 1134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 36),
                            new(Static.Defense, 197),
                            new(Static.Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(Static.HP, 14650),
                            new(Static.Attack, 1170),
                            new(Static.CriticalDamage, 936),
                            new(Static.Evade, 37),
                            new(Static.Defense, 202),
                            new(Static.Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(Static.HP, 14950),
                            new(Static.Attack, 1188),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 38),
                            new(Static.Defense, 205),
                            new(Static.Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(Static.HP, 15250),
                            new(Static.Attack, 1206),
                            new(Static.CriticalDamage, 964),
                            new(Static.Evade, 39),
                            new(Static.Defense, 210),
                            new(Static.Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(Static.HP, 15550),
                            new(Static.Attack, 1242),
                            new(Static.CriticalDamage, 993),
                            new(Static.Evade, 39),
                            new(Static.Defense, 215),
                            new(Static.Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(Static.HP, 15850),
                            new(Static.Attack, 1260),
                            new(Static.CriticalDamage, 1008),
                            new(Static.Evade, 40),
                            new(Static.Defense, 220),
                            new(Static.Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(Static.HP, 16150),
                            new(Static.Attack, 1295),
                            new(Static.CriticalDamage, 1036),
                            new(Static.Evade, 41),
                            new(Static.Defense, 222),
                            new(Static.Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(Static.HP, 16450),
                            new(Static.Attack, 1314),
                            new(Static.CriticalDamage, 1051),
                            new(Static.Evade, 42),
                            new(Static.Defense, 227),
                            new(Static.Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(Static.HP, 16750),
                            new(Static.Attack, 1331),
                            new(Static.CriticalDamage, 1065),
                            new(Static.Evade, 43),
                            new(Static.Defense, 232),
                            new(Static.Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(Static.HP, 17050),
                            new(Static.Attack, 1368),
                            new(Static.CriticalDamage, 1094),
                            new(Static.Evade, 44),
                            new(Static.Defense, 237),
                            new(Static.Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(Static.HP, 17350),
                            new(Static.Attack, 1386),
                            new(Static.CriticalDamage, 1108),
                            new(Static.Evade, 44),
                            new(Static.Defense, 240),
                            new(Static.Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(Static.HP, 17650),
                            new(Static.Attack, 1404),
                            new(Static.CriticalDamage, 1123),
                            new(Static.Evade, 45),
                            new(Static.Defense, 245),
                            new(Static.Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(Static.HP, 17950),
                            new(Static.Attack, 1440),
                            new(Static.CriticalDamage, 1152),
                            new(Static.Evade, 46),
                            new(Static.Defense, 250),
                            new(Static.Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(Static.HP, 18250),
                            new(Static.Attack, 1458),
                            new(Static.CriticalDamage, 1166),
                            new(Static.Evade, 47),
                            new(Static.Defense, 255),
                            new(Static.Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(Static.HP, 18550),
                            new(Static.Attack, 1494),
                            new(Static.CriticalDamage, 1195),
                            new(Static.Evade, 48),
                            new(Static.Defense, 257),
                            new(Static.Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(Static.HP, 18850),
                            new(Static.Attack, 1512),
                            new(Static.CriticalDamage, 1209),
                            new(Static.Evade, 48),
                            new(Static.Defense, 262),
                            new(Static.Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(Static.HP, 19150),
                            new(Static.Attack, 1530),
                            new(Static.CriticalDamage, 1224),
                            new(Static.Evade, 49),
                            new(Static.Defense, 267),
                            new(Static.Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(Static.HP, 19450),
                            new(Static.Attack, 1566),
                            new(Static.CriticalDamage, 1252),
                            new(Static.Evade, 50),
                            new(Static.Defense, 272),
                            new(Static.Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(Static.HP, 19750),
                            new(Static.Attack, 1584),
                            new(Static.CriticalDamage, 1267),
                            new(Static.Evade, 51),
                            new(Static.Defense, 275),
                            new(Static.Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(Static.HP, 20050),
                            new(Static.Attack, 1601),
                            new(Static.CriticalDamage, 1281),
                            new(Static.Evade, 52),
                            new(Static.Defense, 280),
                            new(Static.Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(Static.HP, 20350),
                            new(Static.Attack, 1638),
                            new(Static.CriticalDamage, 1310),
                            new(Static.Evade, 52),
                            new(Static.Defense, 285),
                            new(Static.Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(Static.HP, 20650),
                            new(Static.Attack, 1656),
                            new(Static.CriticalDamage, 1324),
                            new(Static.Evade, 53),
                            new(Static.Defense, 289),
                            new(Static.Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(Static.HP, 20950),
                            new(Static.Attack, 1692),
                            new(Static.CriticalDamage, 1353),
                            new(Static.Evade, 54),
                            new(Static.Defense, 292),
                            new(Static.Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(Static.HP, 21250),
                            new(Static.Attack, 1710),
                            new(Static.CriticalDamage, 1368),
                            new(Static.Evade, 55),
                            new(Static.Defense, 297),
                            new(Static.Accuracy, AccuracyList[67])
                        }
                    }
                });

        #endregion
    }
}