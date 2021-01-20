using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Iris =>
            new("伊莉絲",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new Effect[]
                        {
                            new(Static.HP, 1_100),
                            new(Static.Attack, 54),
                            new(Static.CriticalDamage, 43),
                            new(Static.Evade, 0),
                            new(Static.Defense, 7),
                            new(Static.Accuracy, AccuracyList[0])
                        }
                    },
                    {
                        2,
                        new Effect[]
                        {
                            new(Static.HP, 1_350),
                            new(Static.Attack, 90),
                            new(Static.CriticalDamage, 72),
                            new(Static.Evade, 1),
                            new(Static.Defense, 12),
                            new(Static.Accuracy, AccuracyList[1])
                        }
                    },
                    {
                        3,
                        new Effect[]
                        {
                            new(Static.HP, 1_600),
                            new(Static.Attack, 108),
                            new(Static.CriticalDamage, 86),
                            new(Static.Evade, 1),
                            new(Static.Defense, 20),
                            new(Static.Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(Static.HP, 1_850),
                            new(Static.Attack, 144),
                            new(Static.CriticalDamage, 115),
                            new(Static.Evade, 2),
                            new(Static.Defense, 25),
                            new(Static.Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(Static.HP, 2_100),
                            new(Static.Attack, 162),
                            new(Static.CriticalDamage, 129),
                            new(Static.Evade, 2),
                            new(Static.Defense, 32),
                            new(Static.Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(Static.HP, 2_350),
                            new(Static.Attack, 198),
                            new(Static.CriticalDamage, 158),
                            new(Static.Evade, 3),
                            new(Static.Defense, 37),
                            new(Static.Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(Static.HP, 2_600),
                            new(Static.Attack, 216),
                            new(Static.CriticalDamage, 172),
                            new(Static.Evade, 4),
                            new(Static.Defense, 45),
                            new(Static.Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(Static.HP, 2_850),
                            new(Static.Attack, 252),
                            new(Static.CriticalDamage, 201),
                            new(Static.Evade, 4),
                            new(Static.Defense, 50),
                            new(Static.Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(Static.HP, 3_100),
                            new(Static.Attack, 270),
                            new(Static.CriticalDamage, 216),
                            new(Static.Evade, 5),
                            new(Static.Defense, 57),
                            new(Static.Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(Static.HP, 3_350),
                            new(Static.Attack, 306),
                            new(Static.CriticalDamage, 244),
                            new(Static.Evade, 5),
                            new(Static.Defense, 62),
                            new(Static.Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(Static.HP, 3_600),
                            new(Static.Attack, 324),
                            new(Static.CriticalDamage, 259),
                            new(Static.Evade, 6),
                            new(Static.Defense, 70),
                            new(Static.Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(Static.HP, 3_850),
                            new(Static.Attack, 360),
                            new(Static.CriticalDamage, 288),
                            new(Static.Evade, 6),
                            new(Static.Defense, 75),
                            new(Static.Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(Static.HP, 4_100),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 7),
                            new(Static.Defense, 82),
                            new(Static.Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(Static.HP, 4_350),
                            new(Static.Attack, 414),
                            new(Static.CriticalDamage, 331),
                            new(Static.Evade, 8),
                            new(Static.Defense, 87),
                            new(Static.Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(Static.HP, 4_600),
                            new(Static.Attack, 432),
                            new(Static.CriticalDamage, 345),
                            new(Static.Evade, 8),
                            new(Static.Defense, 95),
                            new(Static.Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(Static.HP, 4_850),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 9),
                            new(Static.Defense, 100),
                            new(Static.Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(Static.HP, 5_100),
                            new(Static.Attack, 485),
                            new(Static.CriticalDamage, 388),
                            new(Static.Evade, 9),
                            new(Static.Defense, 107),
                            new(Static.Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(Static.HP, 5_350),
                            new(Static.Attack, 522),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 10),
                            new(Static.Defense, 112),
                            new(Static.Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(Static.HP, 5_600),
                            new(Static.Attack, 540),
                            new(Static.CriticalDamage, 432),
                            new(Static.Evade, 10),
                            new(Static.Defense, 120),
                            new(Static.Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(Static.HP, 5_850),
                            new(Static.Attack, 576),
                            new(Static.CriticalDamage, 460),
                            new(Static.Evade, 11),
                            new(Static.Defense, 125),
                            new(Static.Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(Static.HP, 6_100),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 11),
                            new(Static.Defense, 132),
                            new(Static.Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(Static.HP, 6_350),
                            new(Static.Attack, 630),
                            new(Static.CriticalDamage, 504),
                            new(Static.Evade, 12),
                            new(Static.Defense, 137),
                            new(Static.Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(Static.HP, 6_600),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 13),
                            new(Static.Defense, 145),
                            new(Static.Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(Static.HP, 6_850),
                            new(Static.Attack, 684),
                            new(Static.CriticalDamage, 547),
                            new(Static.Evade, 13),
                            new(Static.Defense, 150),
                            new(Static.Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(Static.HP, 7_100),
                            new(Static.Attack, 702),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 14),
                            new(Static.Defense, 157),
                            new(Static.Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(Static.HP, 7_350),
                            new(Static.Attack, 738),
                            new(Static.CriticalDamage, 590),
                            new(Static.Evade, 14),
                            new(Static.Defense, 162),
                            new(Static.Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(Static.HP, 7_600),
                            new(Static.Attack, 756),
                            new(Static.CriticalDamage, 604),
                            new(Static.Evade, 15),
                            new(Static.Defense, 170),
                            new(Static.Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(Static.HP, 7_850),
                            new(Static.Attack, 792),
                            new(Static.CriticalDamage, 633),
                            new(Static.Evade, 15),
                            new(Static.Defense, 175),
                            new(Static.Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(Static.HP, 8_100),
                            new(Static.Attack, 810),
                            new(Static.CriticalDamage, 648),
                            new(Static.Evade, 16),
                            new(Static.Defense, 182),
                            new(Static.Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(Static.HP, 8_350),
                            new(Static.Attack, 846),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 17),
                            new(Static.Defense, 187),
                            new(Static.Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(Static.HP, 8_600),
                            new(Static.Attack, 864),
                            new(Static.CriticalDamage, 691),
                            new(Static.Evade, 17),
                            new(Static.Defense, 195),
                            new(Static.Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(Static.HP, 8_850),
                            new(Static.Attack, 900),
                            new(Static.CriticalDamage, 720),
                            new(Static.Evade, 18),
                            new(Static.Defense, 200),
                            new(Static.Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(Static.HP, 9_100),
                            new(Static.Attack, 918),
                            new(Static.CriticalDamage, 734),
                            new(Static.Evade, 18),
                            new(Static.Defense, 207),
                            new(Static.Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(Static.HP, 9_350),
                            new(Static.Attack, 954),
                            new(Static.CriticalDamage, 763),
                            new(Static.Evade, 19),
                            new(Static.Defense, 212),
                            new(Static.Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(Static.HP, 9_600),
                            new(Static.Attack, 971),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 19),
                            new(Static.Defense, 220),
                            new(Static.Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(Static.HP, 9_850),
                            new(Static.Attack, 1_007),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 20),
                            new(Static.Defense, 225),
                            new(Static.Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(Static.HP, 10_100),
                            new(Static.Attack, 1_025),
                            new(Static.CriticalDamage, 820),
                            new(Static.Evade, 20),
                            new(Static.Defense, 232),
                            new(Static.Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(Static.HP, 10_350),
                            new(Static.Attack, 1_061),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 21),
                            new(Static.Defense, 237),
                            new(Static.Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(Static.HP, 10_600),
                            new(Static.Attack, 1_079),
                            new(Static.CriticalDamage, 863),
                            new(Static.Evade, 22),
                            new(Static.Defense, 245),
                            new(Static.Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(Static.HP, 10_850),
                            new(Static.Attack, 1_115),
                            new(Static.CriticalDamage, 892),
                            new(Static.Evade, 22),
                            new(Static.Defense, 250),
                            new(Static.Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(Static.HP, 11_100),
                            new(Static.Attack, 1_133),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 23),
                            new(Static.Defense, 257),
                            new(Static.Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(Static.HP, 11_350),
                            new(Static.Attack, 1_170),
                            new(Static.CriticalDamage, 936),
                            new(Static.Evade, 23),
                            new(Static.Defense, 262),
                            new(Static.Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(Static.HP, 11_600),
                            new(Static.Attack, 1_187),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 24),
                            new(Static.Defense, 270),
                            new(Static.Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(Static.HP, 11_850),
                            new(Static.Attack, 1_224),
                            new(Static.CriticalDamage, 979),
                            new(Static.Evade, 24),
                            new(Static.Defense, 275),
                            new(Static.Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(Static.HP, 12_100),
                            new(Static.Attack, 1_242),
                            new(Static.CriticalDamage, 993),
                            new(Static.Evade, 25),
                            new(Static.Defense, 282),
                            new(Static.Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(Static.HP, 12_350),
                            new(Static.Attack, 1_277),
                            new(Static.CriticalDamage, 1_022),
                            new(Static.Evade, 26),
                            new(Static.Defense, 287),
                            new(Static.Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(Static.HP, 12_600),
                            new(Static.Attack, 1_295),
                            new(Static.CriticalDamage, 1_036),
                            new(Static.Evade, 26),
                            new(Static.Defense, 295),
                            new(Static.Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(Static.HP, 12_850),
                            new(Static.Attack, 1_331),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 27),
                            new(Static.Defense, 300),
                            new(Static.Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(Static.HP, 13_100),
                            new(Static.Attack, 1_349),
                            new(Static.CriticalDamage, 1_079),
                            new(Static.Evade, 27),
                            new(Static.Defense, 307),
                            new(Static.Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(Static.HP, 13_350),
                            new(Static.Attack, 1_385),
                            new(Static.CriticalDamage, 1_108),
                            new(Static.Evade, 28),
                            new(Static.Defense, 312),
                            new(Static.Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(Static.HP, 13_600),
                            new(Static.Attack, 1_403),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 28),
                            new(Static.Defense, 320),
                            new(Static.Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(Static.HP, 13_850),
                            new(Static.Attack, 1_439),
                            new(Static.CriticalDamage, 1_151),
                            new(Static.Evade, 29),
                            new(Static.Defense, 325),
                            new(Static.Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(Static.HP, 14_100),
                            new(Static.Attack, 1_458),
                            new(Static.CriticalDamage, 1_166),
                            new(Static.Evade, 29),
                            new(Static.Defense, 332),
                            new(Static.Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(Static.HP, 14_350),
                            new(Static.Attack, 1_494),
                            new(Static.CriticalDamage, 1_195),
                            new(Static.Evade, 30),
                            new(Static.Defense, 337),
                            new(Static.Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(Static.HP, 14_600),
                            new(Static.Attack, 1_512),
                            new(Static.CriticalDamage, 1_209),
                            new(Static.Evade, 31),
                            new(Static.Defense, 345),
                            new(Static.Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(Static.HP, 14_850),
                            new(Static.Attack, 1_548),
                            new(Static.CriticalDamage, 1_238),
                            new(Static.Evade, 31),
                            new(Static.Defense, 350),
                            new(Static.Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(Static.HP, 15_100),
                            new(Static.Attack, 1_566),
                            new(Static.CriticalDamage, 1_262),
                            new(Static.Evade, 32),
                            new(Static.Defense, 357),
                            new(Static.Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(Static.HP, 15_350),
                            new(Static.Attack, 1_602),
                            new(Static.CriticalDamage, 1_291),
                            new(Static.Evade, 32),
                            new(Static.Defense, 362),
                            new(Static.Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(Static.HP, 15_600),
                            new(Static.Attack, 1_620),
                            new(Static.CriticalDamage, 1_306),
                            new(Static.Evade, 33),
                            new(Static.Defense, 370),
                            new(Static.Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(Static.HP, 15_850),
                            new(Static.Attack, 1_656),
                            new(Static.CriticalDamage, 1_334),
                            new(Static.Evade, 33),
                            new(Static.Defense, 375),
                            new(Static.Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(Static.HP, 16_100),
                            new(Static.Attack, 1_674),
                            new(Static.CriticalDamage, 1_339),
                            new(Static.Evade, 34),
                            new(Static.Defense, 382),
                            new(Static.Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(Static.HP, 16_350),
                            new(Static.Attack, 1_710),
                            new(Static.CriticalDamage, 1_368),
                            new(Static.Evade, 35),
                            new(Static.Defense, 387),
                            new(Static.Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(Static.HP, 16_600),
                            new(Static.Attack, 1_728),
                            new(Static.CriticalDamage, 1_382),
                            new(Static.Evade, 35),
                            new(Static.Defense, 394),
                            new(Static.Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(Static.HP, 16_850),
                            new(Static.Attack, 1_764),
                            new(Static.CriticalDamage, 1_411),
                            new(Static.Evade, 36),
                            new(Static.Defense, 399),
                            new(Static.Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(Static.HP, 17_100),
                            new(Static.Attack, 1_782),
                            new(Static.CriticalDamage, 1_425),
                            new(Static.Evade, 36),
                            new(Static.Defense, 407),
                            new(Static.Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(Static.HP, 17_350),
                            new(Static.Attack, 1_818),
                            new(Static.CriticalDamage, 1_454),
                            new(Static.Evade, 37),
                            new(Static.Defense, 412),
                            new(Static.Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(Static.HP, 17_600),
                            new(Static.Attack, 1_836),
                            new(Static.CriticalDamage, 1_468),
                            new(Static.Evade, 37),
                            new(Static.Defense, 419),
                            new(Static.Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(Static.HP, 17_850),
                            new(Static.Attack, 1_872),
                            new(Static.CriticalDamage, 1_497),
                            new(Static.Evade, 38),
                            new(Static.Defense, 424),
                            new(Static.Accuracy, AccuracyList[67])
                        }
                    }
                });

        #endregion
    }
}