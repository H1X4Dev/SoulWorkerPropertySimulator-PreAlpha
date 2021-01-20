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
        private static Character Haru =>
            new("哈露",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new Effect[]
                        {
                            new(HP, 1_150),
                            new(Attack, 54),
                            new(CDamage, 43),
                            new(Evade, 0),
                            new(Defense, 7),
                            new(Accuracy, AccuracyList[0])
                        }
                    },
                    {
                        2,
                        new Effect[]
                        {
                            new(HP, 1_550),
                            new(Attack, 72),
                            new(CDamage, 57),
                            new(Evade, 1),
                            new(Defense, 12),
                            new(Accuracy, AccuracyList[1])
                        }
                    },
                    {
                        3,
                        new Effect[]
                        {
                            new(HP, 1_950),
                            new(Attack, 90),
                            new(CDamage, 72),
                            new(Evade, 2),
                            new(Defense, 20),
                            new(Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(HP, 2_350),
                            new(Attack, 108),
                            new(CDamage, 86),
                            new(Evade, 2),
                            new(Defense, 25),
                            new(Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(HP, 2_750),
                            new(Attack, 144),
                            new(CDamage, 115),
                            new(Evade, 3),
                            new(Defense, 32),
                            new(Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(HP, 3_150),
                            new(Attack, 162),
                            new(CDamage, 129),
                            new(Evade, 3),
                            new(Defense, 37),
                            new(Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(HP, 3_550),
                            new(Attack, 180),
                            new(CDamage, 144),
                            new(Evade, 4),
                            new(Defense, 45),
                            new(Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(HP, 3_950),
                            new(Attack, 198),
                            new(CDamage, 158),
                            new(Evade, 5),
                            new(Defense, 50),
                            new(Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(HP, 4_350),
                            new(Attack, 234),
                            new(CDamage, 187),
                            new(Evade, 5),
                            new(Defense, 57),
                            new(Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(HP, 4_750),
                            new(Attack, 252),
                            new(CDamage, 201),
                            new(Evade, 6),
                            new(Defense, 62),
                            new(Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(HP, 5_150),
                            new(Attack, 270),
                            new(CDamage, 216),
                            new(Evade, 7),
                            new(Defense, 70),
                            new(Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(HP, 5_550),
                            new(Attack, 288),
                            new(CDamage, 230),
                            new(Evade, 7),
                            new(Defense, 75),
                            new(Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(HP, 5_950),
                            new(Attack, 324),
                            new(CDamage, 259),
                            new(Evade, 8),
                            new(Defense, 82),
                            new(Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(HP, 6_350),
                            new(Attack, 342),
                            new(CDamage, 273),
                            new(Evade, 8),
                            new(Defense, 87),
                            new(Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(HP, 6_750),
                            new(Attack, 360),
                            new(CDamage, 288),
                            new(Evade, 9),
                            new(Defense, 95),
                            new(Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(HP, 7_150),
                            new(Attack, 378),
                            new(CDamage, 302),
                            new(Evade, 10),
                            new(Defense, 100),
                            new(Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(HP, 7_550),
                            new(Attack, 414),
                            new(CDamage, 331),
                            new(Evade, 10),
                            new(Defense, 107),
                            new(Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(HP, 7_950),
                            new(Attack, 432),
                            new(CDamage, 345),
                            new(Evade, 11),
                            new(Defense, 112),
                            new(Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(HP, 8_350),
                            new(Attack, 450),
                            new(CDamage, 360),
                            new(Evade, 12),
                            new(Defense, 120),
                            new(Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(HP, 8_750),
                            new(Attack, 468),
                            new(CDamage, 374),
                            new(Evade, 12),
                            new(Defense, 125),
                            new(Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(HP, 9_150),
                            new(Attack, 504),
                            new(CDamage, 403),
                            new(Evade, 13),
                            new(Defense, 132),
                            new(Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(HP, 9_550),
                            new(Attack, 522),
                            new(CDamage, 417),
                            new(Evade, 13),
                            new(Defense, 137),
                            new(Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(HP, 9_950),
                            new(Attack, 540),
                            new(CDamage, 432),
                            new(Evade, 14),
                            new(Defense, 145),
                            new(Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(HP, 10_350),
                            new(Attack, 558),
                            new(CDamage, 446),
                            new(Evade, 15),
                            new(Defense, 150),
                            new(Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(HP, 10_750),
                            new(Attack, 594),
                            new(CDamage, 475),
                            new(Evade, 15),
                            new(Defense, 157),
                            new(Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(HP, 11_150),
                            new(Attack, 612),
                            new(CDamage, 489),
                            new(Evade, 16),
                            new(Defense, 162),
                            new(Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(HP, 11_550),
                            new(Attack, 630),
                            new(CDamage, 504),
                            new(Evade, 17),
                            new(Defense, 170),
                            new(Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(HP, 11_950),
                            new(Attack, 648),
                            new(CDamage, 518),
                            new(Evade, 17),
                            new(Defense, 175),
                            new(Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(HP, 12_350),
                            new(Attack, 684),
                            new(CDamage, 547),
                            new(Evade, 18),
                            new(Defense, 182),
                            new(Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(HP, 12_750),
                            new(Attack, 702),
                            new(CDamage, 561),
                            new(Evade, 18),
                            new(Defense, 187),
                            new(Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(HP, 13_150),
                            new(Attack, 720),
                            new(CDamage, 576),
                            new(Evade, 19),
                            new(Defense, 195),
                            new(Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(HP, 13_550),
                            new(Attack, 738),
                            new(CDamage, 590),
                            new(Evade, 20),
                            new(Defense, 200),
                            new(Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(HP, 13_950),
                            new(Attack, 774),
                            new(CDamage, 619),
                            new(Evade, 20),
                            new(Defense, 207),
                            new(Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(HP, 14_350),
                            new(Attack, 792),
                            new(CDamage, 633),
                            new(Evade, 21),
                            new(Defense, 212),
                            new(Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(HP, 14_750),
                            new(Attack, 810),
                            new(CDamage, 648),
                            new(Evade, 22),
                            new(Defense, 220),
                            new(Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(HP, 15_150),
                            new(Attack, 828),
                            new(CDamage, 662),
                            new(Evade, 22),
                            new(Defense, 225),
                            new(Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(HP, 15_550),
                            new(Attack, 864),
                            new(CDamage, 691),
                            new(Evade, 23),
                            new(Defense, 232),
                            new(Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(HP, 15_950),
                            new(Attack, 882),
                            new(CDamage, 705),
                            new(Evade, 23),
                            new(Defense, 237),
                            new(Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(HP, 16_350),
                            new(Attack, 900),
                            new(CDamage, 720),
                            new(Evade, 24),
                            new(Defense, 245),
                            new(Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(HP, 16_750),
                            new(Attack, 918),
                            new(CDamage, 734),
                            new(Evade, 25),
                            new(Defense, 250),
                            new(Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(HP, 17_150),
                            new(Attack, 954),
                            new(CDamage, 763),
                            new(Evade, 25),
                            new(Defense, 257),
                            new(Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(HP, 17_550),
                            new(Attack, 972),
                            new(CDamage, 777),
                            new(Evade, 26),
                            new(Defense, 262),
                            new(Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(HP, 17_950),
                            new(Attack, 990),
                            new(CDamage, 792),
                            new(Evade, 27),
                            new(Defense, 270),
                            new(Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(HP, 18_350),
                            new(Attack, 1_008),
                            new(CDamage, 806),
                            new(Evade, 27),
                            new(Defense, 275),
                            new(Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(HP, 18_750),
                            new(Attack, 1_044),
                            new(CDamage, 835),
                            new(Evade, 28),
                            new(Defense, 282),
                            new(Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(HP, 19_150),
                            new(Attack, 1_062),
                            new(CDamage, 849),
                            new(Evade, 28),
                            new(Defense, 287),
                            new(Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(HP, 19_550),
                            new(Attack, 1_080),
                            new(CDamage, 864),
                            new(Evade, 29),
                            new(Defense, 295),
                            new(Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(HP, 19_950),
                            new(Attack, 1_098),
                            new(CDamage, 878),
                            new(Evade, 30),
                            new(Defense, 300),
                            new(Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(HP, 20_350),
                            new(Attack, 1_134),
                            new(CDamage, 907),
                            new(Evade, 30),
                            new(Defense, 307),
                            new(Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(HP, 20_750),
                            new(Attack, 1_152),
                            new(CDamage, 921),
                            new(Evade, 31),
                            new(Defense, 312),
                            new(Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(HP, 21_150),
                            new(Attack, 1_170),
                            new(CDamage, 936),
                            new(Evade, 32),
                            new(Defense, 320),
                            new(Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(HP, 21_550),
                            new(Attack, 1_188),
                            new(CDamage, 950),
                            new(Evade, 32),
                            new(Defense, 325),
                            new(Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(HP, 21_950),
                            new(Attack, 1_224),
                            new(CDamage, 979),
                            new(Evade, 33),
                            new(Defense, 332),
                            new(Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(HP, 22_350),
                            new(Attack, 1_242),
                            new(CDamage, 993),
                            new(Evade, 33),
                            new(Defense, 337),
                            new(Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(HP, 22_750),
                            new(Attack, 1_260),
                            new(CDamage, 1_008),
                            new(Evade, 34),
                            new(Defense, 345),
                            new(Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(HP, 23_150),
                            new(Attack, 1_278),
                            new(CDamage, 1_022),
                            new(Evade, 35),
                            new(Defense, 350),
                            new(Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(HP, 23_550),
                            new(Attack, 1_314),
                            new(CDamage, 1_051),
                            new(Evade, 35),
                            new(Defense, 357),
                            new(Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(HP, 23_950),
                            new(Attack, 1_332),
                            new(CDamage, 1_065),
                            new(Evade, 36),
                            new(Defense, 362),
                            new(Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(HP, 24_350),
                            new(Attack, 1_350),
                            new(CDamage, 1_080),
                            new(Evade, 37),
                            new(Defense, 370),
                            new(Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(HP, 24_750),
                            new(Attack, 1_368),
                            new(CDamage, 1_094),
                            new(Evade, 37),
                            new(Defense, 375),
                            new(Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(HP, 25_150),
                            new(Attack, 1_404),
                            new(CDamage, 1_123),
                            new(Evade, 38),
                            new(Defense, 382),
                            new(Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(HP, 25_550),
                            new(Attack, 1_422),
                            new(CDamage, 1_137),
                            new(Evade, 38),
                            new(Defense, 387),
                            new(Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(HP, 25_950),
                            new(Attack, 1_440),
                            new(CDamage, 1_152),
                            new(Evade, 39),
                            new(Defense, 395),
                            new(Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(HP, 26_350),
                            new(Attack, 1_457),
                            new(CDamage, 1_166),
                            new(Evade, 40),
                            new(Defense, 400),
                            new(Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(HP, 26_750),
                            new(Attack, 1_493),
                            new(CDamage, 1_195),
                            new(Evade, 40),
                            new(Defense, 407),
                            new(Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(HP, 27_150),
                            new(Attack, 1_512),
                            new(CDamage, 1_209),
                            new(Evade, 41),
                            new(Defense, 412),
                            new(Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(HP, 27_550),
                            new(Attack, 1_530),
                            new(CDamage, 1_224),
                            new(Evade, 42),
                            new(Defense, 419),
                            new(Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(HP, 27_950),
                            new(Attack, 1_548),
                            new(CDamage, 1_238),
                            new(Evade, 42),
                            new(Defense, 424),
                            new(Accuracy, AccuracyList[67])
                        }
                    },
                });
    }
}