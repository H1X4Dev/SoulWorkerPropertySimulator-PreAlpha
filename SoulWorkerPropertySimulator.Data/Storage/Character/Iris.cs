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
        private static Character Iris =>
            new("伊莉絲",
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
                            new(Defense, 7),
                            new(Accuracy, AccuracyList[0])
                        }
                    },
                    {
                        2,
                        new Effect[]
                        {
                            new(HP, 1_350),
                            new(Attack, 90),
                            new(CDamage, 72),
                            new(Evade, 1),
                            new(Defense, 12),
                            new(Accuracy, AccuracyList[1])
                        }
                    },
                    {
                        3,
                        new Effect[]
                        {
                            new(HP, 1_600),
                            new(Attack, 108),
                            new(CDamage, 86),
                            new(Evade, 1),
                            new(Defense, 20),
                            new(Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(HP, 1_850),
                            new(Attack, 144),
                            new(CDamage, 115),
                            new(Evade, 2),
                            new(Defense, 25),
                            new(Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(HP, 2_100),
                            new(Attack, 162),
                            new(CDamage, 129),
                            new(Evade, 2),
                            new(Defense, 32),
                            new(Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(HP, 2_350),
                            new(Attack, 198),
                            new(CDamage, 158),
                            new(Evade, 3),
                            new(Defense, 37),
                            new(Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(HP, 2_600),
                            new(Attack, 216),
                            new(CDamage, 172),
                            new(Evade, 4),
                            new(Defense, 45),
                            new(Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(HP, 2_850),
                            new(Attack, 252),
                            new(CDamage, 201),
                            new(Evade, 4),
                            new(Defense, 50),
                            new(Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(HP, 3_100),
                            new(Attack, 270),
                            new(CDamage, 216),
                            new(Evade, 5),
                            new(Defense, 57),
                            new(Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(HP, 3_350),
                            new(Attack, 306),
                            new(CDamage, 244),
                            new(Evade, 5),
                            new(Defense, 62),
                            new(Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(HP, 3_600),
                            new(Attack, 324),
                            new(CDamage, 259),
                            new(Evade, 6),
                            new(Defense, 70),
                            new(Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(HP, 3_850),
                            new(Attack, 360),
                            new(CDamage, 288),
                            new(Evade, 6),
                            new(Defense, 75),
                            new(Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(HP, 4_100),
                            new(Attack, 378),
                            new(CDamage, 302),
                            new(Evade, 7),
                            new(Defense, 82),
                            new(Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(HP, 4_350),
                            new(Attack, 414),
                            new(CDamage, 331),
                            new(Evade, 8),
                            new(Defense, 87),
                            new(Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(HP, 4_600),
                            new(Attack, 432),
                            new(CDamage, 345),
                            new(Evade, 8),
                            new(Defense, 95),
                            new(Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(HP, 4_850),
                            new(Attack, 468),
                            new(CDamage, 374),
                            new(Evade, 9),
                            new(Defense, 100),
                            new(Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(HP, 5_100),
                            new(Attack, 485),
                            new(CDamage, 388),
                            new(Evade, 9),
                            new(Defense, 107),
                            new(Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(HP, 5_350),
                            new(Attack, 522),
                            new(CDamage, 417),
                            new(Evade, 10),
                            new(Defense, 112),
                            new(Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(HP, 5_600),
                            new(Attack, 540),
                            new(CDamage, 432),
                            new(Evade, 10),
                            new(Defense, 120),
                            new(Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(HP, 5_850),
                            new(Attack, 576),
                            new(CDamage, 460),
                            new(Evade, 11),
                            new(Defense, 125),
                            new(Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(HP, 6_100),
                            new(Attack, 594),
                            new(CDamage, 475),
                            new(Evade, 11),
                            new(Defense, 132),
                            new(Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(HP, 6_350),
                            new(Attack, 630),
                            new(CDamage, 504),
                            new(Evade, 12),
                            new(Defense, 137),
                            new(Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(HP, 6_600),
                            new(Attack, 648),
                            new(CDamage, 518),
                            new(Evade, 13),
                            new(Defense, 145),
                            new(Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(HP, 6_850),
                            new(Attack, 684),
                            new(CDamage, 547),
                            new(Evade, 13),
                            new(Defense, 150),
                            new(Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(HP, 7_100),
                            new(Attack, 702),
                            new(CDamage, 561),
                            new(Evade, 14),
                            new(Defense, 157),
                            new(Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(HP, 7_350),
                            new(Attack, 738),
                            new(CDamage, 590),
                            new(Evade, 14),
                            new(Defense, 162),
                            new(Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(HP, 7_600),
                            new(Attack, 756),
                            new(CDamage, 604),
                            new(Evade, 15),
                            new(Defense, 170),
                            new(Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(HP, 7_850),
                            new(Attack, 792),
                            new(CDamage, 633),
                            new(Evade, 15),
                            new(Defense, 175),
                            new(Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(HP, 8_100),
                            new(Attack, 810),
                            new(CDamage, 648),
                            new(Evade, 16),
                            new(Defense, 182),
                            new(Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(HP, 8_350),
                            new(Attack, 846),
                            new(CDamage, 676),
                            new(Evade, 17),
                            new(Defense, 187),
                            new(Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(HP, 8_600),
                            new(Attack, 864),
                            new(CDamage, 691),
                            new(Evade, 17),
                            new(Defense, 195),
                            new(Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(HP, 8_850),
                            new(Attack, 900),
                            new(CDamage, 720),
                            new(Evade, 18),
                            new(Defense, 200),
                            new(Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(HP, 9_100),
                            new(Attack, 918),
                            new(CDamage, 734),
                            new(Evade, 18),
                            new(Defense, 207),
                            new(Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(HP, 9_350),
                            new(Attack, 954),
                            new(CDamage, 763),
                            new(Evade, 19),
                            new(Defense, 212),
                            new(Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(HP, 9_600),
                            new(Attack, 971),
                            new(CDamage, 777),
                            new(Evade, 19),
                            new(Defense, 220),
                            new(Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(HP, 9_850),
                            new(Attack, 1_007),
                            new(CDamage, 806),
                            new(Evade, 20),
                            new(Defense, 225),
                            new(Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(HP, 10_100),
                            new(Attack, 1_025),
                            new(CDamage, 820),
                            new(Evade, 20),
                            new(Defense, 232),
                            new(Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(HP, 10_350),
                            new(Attack, 1_061),
                            new(CDamage, 849),
                            new(Evade, 21),
                            new(Defense, 237),
                            new(Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(HP, 10_600),
                            new(Attack, 1_079),
                            new(CDamage, 863),
                            new(Evade, 22),
                            new(Defense, 245),
                            new(Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(HP, 10_850),
                            new(Attack, 1_115),
                            new(CDamage, 892),
                            new(Evade, 22),
                            new(Defense, 250),
                            new(Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(HP, 11_100),
                            new(Attack, 1_133),
                            new(CDamage, 907),
                            new(Evade, 23),
                            new(Defense, 257),
                            new(Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(HP, 11_350),
                            new(Attack, 1_170),
                            new(CDamage, 936),
                            new(Evade, 23),
                            new(Defense, 262),
                            new(Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(HP, 11_600),
                            new(Attack, 1_187),
                            new(CDamage, 950),
                            new(Evade, 24),
                            new(Defense, 270),
                            new(Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(HP, 11_850),
                            new(Attack, 1_224),
                            new(CDamage, 979),
                            new(Evade, 24),
                            new(Defense, 275),
                            new(Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(HP, 12_100),
                            new(Attack, 1_242),
                            new(CDamage, 993),
                            new(Evade, 25),
                            new(Defense, 282),
                            new(Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(HP, 12_350),
                            new(Attack, 1_277),
                            new(CDamage, 1_022),
                            new(Evade, 26),
                            new(Defense, 287),
                            new(Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(HP, 12_600),
                            new(Attack, 1_295),
                            new(CDamage, 1_036),
                            new(Evade, 26),
                            new(Defense, 295),
                            new(Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(HP, 12_850),
                            new(Attack, 1_331),
                            new(CDamage, 1_065),
                            new(Evade, 27),
                            new(Defense, 300),
                            new(Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(HP, 13_100),
                            new(Attack, 1_349),
                            new(CDamage, 1_079),
                            new(Evade, 27),
                            new(Defense, 307),
                            new(Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(HP, 13_350),
                            new(Attack, 1_385),
                            new(CDamage, 1_108),
                            new(Evade, 28),
                            new(Defense, 312),
                            new(Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(HP, 13_600),
                            new(Attack, 1_403),
                            new(CDamage, 1_123),
                            new(Evade, 28),
                            new(Defense, 320),
                            new(Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(HP, 13_850),
                            new(Attack, 1_439),
                            new(CDamage, 1_151),
                            new(Evade, 29),
                            new(Defense, 325),
                            new(Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(HP, 14_100),
                            new(Attack, 1_458),
                            new(CDamage, 1_166),
                            new(Evade, 29),
                            new(Defense, 332),
                            new(Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(HP, 14_350),
                            new(Attack, 1_494),
                            new(CDamage, 1_195),
                            new(Evade, 30),
                            new(Defense, 337),
                            new(Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(HP, 14_600),
                            new(Attack, 1_512),
                            new(CDamage, 1_209),
                            new(Evade, 31),
                            new(Defense, 345),
                            new(Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(HP, 14_850),
                            new(Attack, 1_548),
                            new(CDamage, 1_238),
                            new(Evade, 31),
                            new(Defense, 350),
                            new(Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(HP, 15_100),
                            new(Attack, 1_566),
                            new(CDamage, 1_262),
                            new(Evade, 32),
                            new(Defense, 357),
                            new(Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(HP, 15_350),
                            new(Attack, 1_602),
                            new(CDamage, 1_291),
                            new(Evade, 32),
                            new(Defense, 362),
                            new(Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(HP, 15_600),
                            new(Attack, 1_620),
                            new(CDamage, 1_306),
                            new(Evade, 33),
                            new(Defense, 370),
                            new(Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(HP, 15_850),
                            new(Attack, 1_656),
                            new(CDamage, 1_334),
                            new(Evade, 33),
                            new(Defense, 375),
                            new(Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(HP, 16_100),
                            new(Attack, 1_674),
                            new(CDamage, 1_339),
                            new(Evade, 34),
                            new(Defense, 382),
                            new(Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(HP, 16_350),
                            new(Attack, 1_710),
                            new(CDamage, 1_368),
                            new(Evade, 35),
                            new(Defense, 387),
                            new(Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(HP, 16_600),
                            new(Attack, 1_728),
                            new(CDamage, 1_382),
                            new(Evade, 35),
                            new(Defense, 394),
                            new(Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(HP, 16_850),
                            new(Attack, 1_764),
                            new(CDamage, 1_411),
                            new(Evade, 36),
                            new(Defense, 399),
                            new(Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(HP, 17_100),
                            new(Attack, 1_782),
                            new(CDamage, 1_425),
                            new(Evade, 36),
                            new(Defense, 407),
                            new(Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(HP, 17_350),
                            new(Attack, 1_818),
                            new(CDamage, 1_454),
                            new(Evade, 37),
                            new(Defense, 412),
                            new(Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(HP, 17_600),
                            new(Attack, 1_836),
                            new(CDamage, 1_468),
                            new(Evade, 37),
                            new(Defense, 419),
                            new(Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(HP, 17_850),
                            new(Attack, 1_872),
                            new(CDamage, 1_497),
                            new(Evade, 38),
                            new(Defense, 424),
                            new(Accuracy, AccuracyList[67])
                        }
                    }
                });
    };
}