using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        private static Character Lily =>
            new("莉莉",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new Effect[]
                        {
                            new(HP, 1150),
                            new(Attack, 54),
                            new(CDamage, 43),
                            new(Evade, 0),
                            new(Defense, 5),
                            new(Accuracy, AccuracyList[0])
                        }
                    },
                    {
                        2,
                        new Effect[]
                        {
                            new(HP, 1450),
                            new(Attack, 72),
                            new(CDamage, 57),
                            new(Evade, 1),
                            new(Defense, 10),
                            new(Accuracy, AccuracyList[1])
                        }
                    },
                    {
                        3,
                        new Effect[]
                        {
                            new(HP, 1750),
                            new(Attack, 108),
                            new(CDamage, 86),
                            new(Evade, 2),
                            new(Defense, 12),
                            new(Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(HP, 2050),
                            new(Attack, 126),
                            new(CDamage, 100),
                            new(Evade, 3),
                            new(Defense, 17),
                            new(Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(HP, 2350),
                            new(Attack, 144),
                            new(CDamage, 115),
                            new(Evade, 4),
                            new(Defense, 22),
                            new(Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(HP, 2650),
                            new(Attack, 180),
                            new(CDamage, 144),
                            new(Evade, 5),
                            new(Defense, 27),
                            new(Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(HP, 2950),
                            new(Attack, 198),
                            new(CDamage, 158),
                            new(Evade, 5),
                            new(Defense, 30),
                            new(Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(HP, 3250),
                            new(Attack, 216),
                            new(CDamage, 172),
                            new(Evade, 6),
                            new(Defense, 35),
                            new(Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(HP, 3550),
                            new(Attack, 252),
                            new(CDamage, 201),
                            new(Evade, 7),
                            new(Defense, 40),
                            new(Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(HP, 3850),
                            new(Attack, 270),
                            new(CDamage, 216),
                            new(Evade, 8),
                            new(Defense, 45),
                            new(Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(HP, 4150),
                            new(Attack, 306),
                            new(CDamage, 244),
                            new(Evade, 9),
                            new(Defense, 47),
                            new(Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(HP, 4450),
                            new(Attack, 324),
                            new(CDamage, 259),
                            new(Evade, 9),
                            new(Defense, 52),
                            new(Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(HP, 4750),
                            new(Attack, 342),
                            new(CDamage, 273),
                            new(Evade, 10),
                            new(Defense, 57),
                            new(Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(HP, 5050),
                            new(Attack, 378),
                            new(CDamage, 302),
                            new(Evade, 11),
                            new(Defense, 62),
                            new(Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(HP, 5350),
                            new(Attack, 396),
                            new(CDamage, 316),
                            new(Evade, 12),
                            new(Defense, 65),
                            new(Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(HP, 5650),
                            new(Attack, 414),
                            new(CDamage, 331),
                            new(Evade, 13),
                            new(Defense, 70),
                            new(Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(HP, 5950),
                            new(Attack, 450),
                            new(CDamage, 360),
                            new(Evade, 13),
                            new(Defense, 75),
                            new(Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(HP, 6250),
                            new(Attack, 468),
                            new(CDamage, 374),
                            new(Evade, 14),
                            new(Defense, 80),
                            new(Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(HP, 6550),
                            new(Attack, 504),
                            new(CDamage, 403),
                            new(Evade, 15),
                            new(Defense, 82),
                            new(Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(HP, 6850),
                            new(Attack, 522),
                            new(CDamage, 417),
                            new(Evade, 16),
                            new(Defense, 87),
                            new(Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(HP, 7150),
                            new(Attack, 540),
                            new(CDamage, 432),
                            new(Evade, 17),
                            new(Defense, 92),
                            new(Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(HP, 7450),
                            new(Attack, 576),
                            new(CDamage, 460),
                            new(Evade, 18),
                            new(Defense, 97),
                            new(Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(HP, 7750),
                            new(Attack, 594),
                            new(CDamage, 475),
                            new(Evade, 18),
                            new(Defense, 100),
                            new(Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(HP, 8050),
                            new(Attack, 612),
                            new(CDamage, 489),
                            new(Evade, 19),
                            new(Defense, 105),
                            new(Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(HP, 8350),
                            new(Attack, 648),
                            new(CDamage, 518),
                            new(Evade, 20),
                            new(Defense, 110),
                            new(Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(HP, 8650),
                            new(Attack, 666),
                            new(CDamage, 532),
                            new(Evade, 21),
                            new(Defense, 115),
                            new(Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(HP, 8950),
                            new(Attack, 702),
                            new(CDamage, 561),
                            new(Evade, 22),
                            new(Defense, 117),
                            new(Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(HP, 9250),
                            new(Attack, 720),
                            new(CDamage, 576),
                            new(Evade, 22),
                            new(Defense, 122),
                            new(Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(HP, 9550),
                            new(Attack, 738),
                            new(CDamage, 590),
                            new(Evade, 23),
                            new(Defense, 127),
                            new(Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(HP, 9850),
                            new(Attack, 774),
                            new(CDamage, 619),
                            new(Evade, 24),
                            new(Defense, 132),
                            new(Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(HP, 10150),
                            new(Attack, 792),
                            new(CDamage, 633),
                            new(Evade, 25),
                            new(Defense, 135),
                            new(Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(HP, 10450),
                            new(Attack, 810),
                            new(CDamage, 648),
                            new(Evade, 26),
                            new(Defense, 140),
                            new(Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(HP, 10750),
                            new(Attack, 846),
                            new(CDamage, 676),
                            new(Evade, 26),
                            new(Defense, 145),
                            new(Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(HP, 11050),
                            new(Attack, 864),
                            new(CDamage, 691),
                            new(Evade, 27),
                            new(Defense, 150),
                            new(Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(HP, 11350),
                            new(Attack, 900),
                            new(CDamage, 720),
                            new(Evade, 28),
                            new(Defense, 152),
                            new(Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(HP, 11650),
                            new(Attack, 918),
                            new(CDamage, 734),
                            new(Evade, 29),
                            new(Defense, 157),
                            new(Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(HP, 11950),
                            new(Attack, 936),
                            new(CDamage, 748),
                            new(Evade, 30),
                            new(Defense, 162),
                            new(Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(HP, 12250),
                            new(Attack, 972),
                            new(CDamage, 777),
                            new(Evade, 31),
                            new(Defense, 167),
                            new(Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(HP, 12550),
                            new(Attack, 990),
                            new(CDamage, 792),
                            new(Evade, 31),
                            new(Defense, 170),
                            new(Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(HP, 12850),
                            new(Attack, 1008),
                            new(CDamage, 806),
                            new(Evade, 32),
                            new(Defense, 175),
                            new(Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(HP, 13150),
                            new(Attack, 1044),
                            new(CDamage, 835),
                            new(Evade, 33),
                            new(Defense, 180),
                            new(Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(HP, 13450),
                            new(Attack, 1062),
                            new(CDamage, 849),
                            new(Evade, 34),
                            new(Defense, 185),
                            new(Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(HP, 13750),
                            new(Attack, 1098),
                            new(CDamage, 878),
                            new(Evade, 35),
                            new(Defense, 187),
                            new(Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(HP, 14050),
                            new(Attack, 1116),
                            new(CDamage, 892),
                            new(Evade, 35),
                            new(Defense, 192),
                            new(Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(HP, 14350),
                            new(Attack, 1134),
                            new(CDamage, 907),
                            new(Evade, 36),
                            new(Defense, 197),
                            new(Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(HP, 14650),
                            new(Attack, 1170),
                            new(CDamage, 936),
                            new(Evade, 37),
                            new(Defense, 202),
                            new(Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(HP, 14950),
                            new(Attack, 1188),
                            new(CDamage, 950),
                            new(Evade, 38),
                            new(Defense, 205),
                            new(Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(HP, 15250),
                            new(Attack, 1206),
                            new(CDamage, 964),
                            new(Evade, 39),
                            new(Defense, 210),
                            new(Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(HP, 15550),
                            new(Attack, 1242),
                            new(CDamage, 993),
                            new(Evade, 39),
                            new(Defense, 215),
                            new(Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(HP, 15850),
                            new(Attack, 1260),
                            new(CDamage, 1008),
                            new(Evade, 40),
                            new(Defense, 220),
                            new(Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(HP, 16150),
                            new(Attack, 1295),
                            new(CDamage, 1036),
                            new(Evade, 41),
                            new(Defense, 222),
                            new(Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(HP, 16450),
                            new(Attack, 1314),
                            new(CDamage, 1051),
                            new(Evade, 42),
                            new(Defense, 227),
                            new(Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(HP, 16750),
                            new(Attack, 1331),
                            new(CDamage, 1065),
                            new(Evade, 43),
                            new(Defense, 232),
                            new(Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(HP, 17050),
                            new(Attack, 1368),
                            new(CDamage, 1094),
                            new(Evade, 44),
                            new(Defense, 237),
                            new(Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(HP, 17350),
                            new(Attack, 1386),
                            new(CDamage, 1108),
                            new(Evade, 44),
                            new(Defense, 240),
                            new(Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(HP, 17650),
                            new(Attack, 1404),
                            new(CDamage, 1123),
                            new(Evade, 45),
                            new(Defense, 245),
                            new(Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(HP, 17950),
                            new(Attack, 1440),
                            new(CDamage, 1152),
                            new(Evade, 46),
                            new(Defense, 250),
                            new(Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(HP, 18250),
                            new(Attack, 1458),
                            new(CDamage, 1166),
                            new(Evade, 47),
                            new(Defense, 255),
                            new(Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(HP, 18550),
                            new(Attack, 1494),
                            new(CDamage, 1195),
                            new(Evade, 48),
                            new(Defense, 257),
                            new(Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(HP, 18850),
                            new(Attack, 1512),
                            new(CDamage, 1209),
                            new(Evade, 48),
                            new(Defense, 262),
                            new(Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(HP, 19150),
                            new(Attack, 1530),
                            new(CDamage, 1224),
                            new(Evade, 49),
                            new(Defense, 267),
                            new(Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(HP, 19450),
                            new(Attack, 1566),
                            new(CDamage, 1252),
                            new(Evade, 50),
                            new(Defense, 272),
                            new(Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(HP, 19750),
                            new(Attack, 1584),
                            new(CDamage, 1267),
                            new(Evade, 51),
                            new(Defense, 275),
                            new(Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(HP, 20050),
                            new(Attack, 1601),
                            new(CDamage, 1281),
                            new(Evade, 52),
                            new(Defense, 280),
                            new(Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(HP, 20350),
                            new(Attack, 1638),
                            new(CDamage, 1310),
                            new(Evade, 52),
                            new(Defense, 285),
                            new(Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(HP, 20650),
                            new(Attack, 1656),
                            new(CDamage, 1324),
                            new(Evade, 53),
                            new(Defense, 289),
                            new(Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(HP, 20950),
                            new(Attack, 1692),
                            new(CDamage, 1353),
                            new(Evade, 54),
                            new(Defense, 292),
                            new(Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(HP, 21250),
                            new(Attack, 1710),
                            new(CDamage, 1368),
                            new(Evade, 55),
                            new(Defense, 297),
                            new(Accuracy, AccuracyList[67])
                        }
                    }
                });
    }
}