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
        private static Character Erwin =>
            new("歐文",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new Effect[]
                        {
                            new(HP, 1_100),
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
                            new(HP, 1_450),
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
                            new(HP, 1_800),
                            new(Attack, 90),
                            new(CDamage, 72),
                            new(Evade, 2),
                            new(Defense, 15),
                            new(Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(HP, 2_150),
                            new(Attack, 108),
                            new(CDamage, 86),
                            new(Evade, 2),
                            new(Defense, 20),
                            new(Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(HP, 2_500),
                            new(Attack, 144),
                            new(CDamage, 115),
                            new(Evade, 3),
                            new(Defense, 25),
                            new(Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(HP, 2_850),
                            new(Attack, 162),
                            new(CDamage, 129),
                            new(Evade, 4),
                            new(Defense, 30),
                            new(Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(HP, 3_200),
                            new(Attack, 180),
                            new(CDamage, 144),
                            new(Evade, 4),
                            new(Defense, 35),
                            new(Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(HP, 3_550),
                            new(Attack, 198),
                            new(CDamage, 158),
                            new(Evade, 5),
                            new(Defense, 40),
                            new(Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(HP, 3_900),
                            new(Attack, 234),
                            new(CDamage, 187),
                            new(Evade, 6),
                            new(Defense, 45),
                            new(Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(HP, 4_250),
                            new(Attack, 252),
                            new(CDamage, 201),
                            new(Evade, 7
                            ),
                            new(Defense, 50),
                            new(Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(HP, 4_600),
                            new(Attack, 270),
                            new(CDamage, 216),
                            new(Evade, 7),
                            new(Defense, 55),
                            new(Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(HP, 4_950),
                            new(Attack, 288),
                            new(CDamage, 230),
                            new(Evade, 8),
                            new(Defense, 60),
                            new(Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(HP, 5_300),
                            new(Attack, 324),
                            new(CDamage, 259),
                            new(Evade, 9),
                            new(Defense, 65),
                            new(Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(HP, 5_650),
                            new(Attack, 342),
                            new(CDamage, 273),
                            new(Evade, 9),
                            new(Defense, 70),
                            new(Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(HP, 6_000),
                            new(Attack, 360),
                            new(CDamage, 288),
                            new(Evade, 10),
                            new(Defense, 75),
                            new(Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(HP, 6_350),
                            new(Attack, 378),
                            new(CDamage, 302),
                            new(Evade, 11),
                            new(Defense, 80),
                            new(Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(HP, 6_700),
                            new(Attack, 414),
                            new(CDamage, 331),
                            new(Evade, 11),
                            new(Defense, 85),
                            new(Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(HP, 7_050),
                            new(Attack, 432),
                            new(CDamage, 345),
                            new(Evade, 12),
                            new(Defense, 90),
                            new(Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(HP, 7_400),
                            new(Attack, 450),
                            new(CDamage, 360),
                            new(Evade, 13),
                            new(Defense, 95),
                            new(Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(HP, 7_750),
                            new(Attack, 468),
                            new(CDamage, 374),
                            new(Evade, 13),
                            new(Defense, 100),
                            new(Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(HP, 8_100),
                            new(Attack, 504),
                            new(CDamage, 403),
                            new(Evade, 14),
                            new(Defense, 105),
                            new(Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(HP, 8_450),
                            new(Attack, 522),
                            new(CDamage, 417),
                            new(Evade, 15),
                            new(Defense, 110),
                            new(Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(HP, 8_800),
                            new(Attack, 540),
                            new(CDamage, 432),
                            new(Evade, 15),
                            new(Defense, 115),
                            new(Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(HP, 9_150),
                            new(Attack, 558),
                            new(CDamage, 446),
                            new(Evade, 16),
                            new(Defense, 120),
                            new(Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(HP, 9_500),
                            new(Attack, 594),
                            new(CDamage, 475),
                            new(Evade, 17),
                            new(Defense, 125),
                            new(Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(HP, 9_850),
                            new(Attack, 612),
                            new(CDamage, 489),
                            new(Evade, 18),
                            new(Defense, 130),
                            new(Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(HP, 10_200),
                            new(Attack, 630),
                            new(CDamage, 504),
                            new(Evade, 18),
                            new(Defense, 135),
                            new(Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(HP, 10_550),
                            new(Attack, 648),
                            new(CDamage, 518),
                            new(Evade, 19),
                            new(Defense, 140),
                            new(Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(HP, 10_900),
                            new(Attack, 684),
                            new(CDamage, 547),
                            new(Evade, 20),
                            new(Defense, 145),
                            new(Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(HP, 11_250),
                            new(Attack, 702),
                            new(CDamage, 561),
                            new(Evade, 20),
                            new(Defense, 150),
                            new(Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(HP, 11_600),
                            new(Attack, 720),
                            new(CDamage, 576),
                            new(Evade, 21),
                            new(Defense, 155),
                            new(Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(HP, 11_950),
                            new(Attack, 738),
                            new(CDamage, 590),
                            new(Evade, 22),
                            new(Defense, 160),
                            new(Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(HP, 12_300),
                            new(Attack, 774),
                            new(CDamage, 619),
                            new(Evade, 22),
                            new(Defense, 165),
                            new(Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(HP, 12_650),
                            new(Attack, 792),
                            new(CDamage, 633),
                            new(Evade, 23),
                            new(Defense, 170),
                            new(Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(HP, 13_000),
                            new(Attack, 810),
                            new(CDamage, 648),
                            new(Evade, 24),
                            new(Defense, 175),
                            new(Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(HP, 13_350),
                            new(Attack, 828),
                            new(CDamage, 662),
                            new(Evade, 24),
                            new(Defense, 180),
                            new(Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(HP, 13_700),
                            new(Attack, 864),
                            new(CDamage, 691),
                            new(Evade, 25),
                            new(Defense, 185),
                            new(Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(HP, 14_050),
                            new(Attack, 882),
                            new(CDamage, 705),
                            new(Evade, 26),
                            new(Defense, 190),
                            new(Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(HP, 14_400),
                            new(Attack, 900),
                            new(CDamage, 720),
                            new(Evade, 26),
                            new(Defense, 195),
                            new(Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(HP, 14_750),
                            new(Attack, 918),
                            new(CDamage, 734),
                            new(Evade, 27),
                            new(Defense, 200),
                            new(Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(HP, 15_100),
                            new(Attack, 954),
                            new(CDamage, 763),
                            new(Evade, 28),
                            new(Defense, 205),
                            new(Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(HP, 15_450),
                            new(Attack, 972),
                            new(CDamage, 777),
                            new(Evade, 29),
                            new(Defense, 210),
                            new(Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(HP, 15_800),
                            new(Attack, 990),
                            new(CDamage, 792),
                            new(Evade, 29),
                            new(Defense, 215),
                            new(Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(HP, 16_150),
                            new(Attack, 1_008),
                            new(CDamage, 806),
                            new(Evade, 30),
                            new(Defense, 220),
                            new(Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(HP, 16_500),
                            new(Attack, 1_044),
                            new(CDamage, 835),
                            new(Evade, 31),
                            new(Defense, 225),
                            new(Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(HP, 16_850),
                            new(Attack, 1_062),
                            new(CDamage, 849),
                            new(Evade, 31),
                            new(Defense, 230),
                            new(Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(HP, 17_200),
                            new(Attack, 1_080),
                            new(CDamage, 864),
                            new(Evade, 32),
                            new(Defense, 235),
                            new(Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(HP, 17_550),
                            new(Attack, 1_098),
                            new(CDamage, 878),
                            new(Evade, 33),
                            new(Defense, 240),
                            new(Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(HP, 17_900),
                            new(Attack, 1_134),
                            new(CDamage, 907),
                            new(Evade, 33),
                            new(Defense, 245),
                            new(Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(HP, 18_250),
                            new(Attack, 1_152),
                            new(CDamage, 921),
                            new(Evade, 34),
                            new(Defense, 250),
                            new(Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(HP, 18_600),
                            new(Attack, 1_170),
                            new(CDamage, 936),
                            new(Evade, 35),
                            new(Defense, 255),
                            new(Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(HP, 18_950),
                            new(Attack, 1_188),
                            new(CDamage, 950),
                            new(Evade, 35),
                            new(Defense, 260),
                            new(Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(HP, 19_300),
                            new(Attack, 1_224),
                            new(CDamage, 979),
                            new(Evade, 36),
                            new(Defense, 265),
                            new(Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(HP, 19_650),
                            new(Attack, 1_242),
                            new(CDamage, 993),
                            new(Evade, 37),
                            new(Defense, 270),
                            new(Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(HP, 20_000),
                            new(Attack, 1_260),
                            new(CDamage, 1_008),
                            new(Evade, 37),
                            new(Defense, 275),
                            new(Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(HP, 20_350),
                            new(Attack, 1_278),
                            new(CDamage, 1_022),
                            new(Evade, 38),
                            new(Defense, 280),
                            new(Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(HP, 20_700),
                            new(Attack, 1_314),
                            new(CDamage, 1_051),
                            new(Evade, 39),
                            new(Defense, 285),
                            new(Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(HP, 21_050),
                            new(Attack, 1_332),
                            new(CDamage, 1_065),
                            new(Evade, 40),
                            new(Defense, 290),
                            new(Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(HP, 21_400),
                            new(Attack, 1_350),
                            new(CDamage, 1_080),
                            new(Evade, 40),
                            new(Defense, 295),
                            new(Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(HP, 21_750),
                            new(Attack, 1_368),
                            new(CDamage, 1_094),
                            new(Evade, 41),
                            new(Defense, 300),
                            new(Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(HP, 22_100),
                            new(Attack, 1_404),
                            new(CDamage, 1_123),
                            new(Evade, 42),
                            new(Defense, 304),
                            new(Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(HP, 22_450),
                            new(Attack, 1_422),
                            new(CDamage, 1_137),
                            new(Evade, 42),
                            new(Defense, 309),
                            new(Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(HP, 22_800),
                            new(Attack, 1_440),
                            new(CDamage, 1_152),
                            new(Evade, 43),
                            new(Defense, 314),
                            new(Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(HP, 23_150),
                            new(Attack, 1_458),
                            new(CDamage, 1_166),
                            new(Evade, 44),
                            new(Defense, 319),
                            new(Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(HP, 23_500),
                            new(Attack, 1_494),
                            new(CDamage, 1_195),
                            new(Evade, 44),
                            new(Defense, 325),
                            new(Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(HP, 23_850),
                            new(Attack, 1_512),
                            new(CDamage, 1_209),
                            new(Evade, 45),
                            new(Defense, 329),
                            new(Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(HP, 24_200),
                            new(Attack, 1_530),
                            new(CDamage, 1_224),
                            new(Evade, 46),
                            new(Defense, 334),
                            new(Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(HP, 24_550),
                            new(Attack, 1_548),
                            new(CDamage, 1_238),
                            new(Evade, 46),
                            new(Defense, 339),
                            new(Accuracy, AccuracyList[67])
                        }
                    }
                });
    }
}