using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Jin =>
            new("金",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new Effect[]
                        {
                            new(Static.HP, 1_150),
                            new(Static.Attack, 36),
                            new(Static.CriticalDamage, 28),
                            new(Static.Evade, 0),
                            new(Static.Defense, 10),
                            new(Static.Accuracy, AccuracyList[0])
                        }
                    },
                    {
                        2,
                        new Effect[]
                        {
                            new(Static.HP, 1_600),
                            new(Static.Attack, 54),
                            new(Static.CriticalDamage, 43),
                            new(Static.Evade, 1),
                            new(Static.Defense, 20),
                            new(Static.Accuracy, AccuracyList[1])
                        }
                    },
                    {
                        3,
                        new Effect[]
                        {
                            new(Static.HP, 2_050),
                            new(Static.Attack, 90),
                            new(Static.CriticalDamage, 72),
                            new(Static.Evade, 1),
                            new(Static.Defense, 27),
                            new(Static.Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(Static.HP, 2_500),
                            new(Static.Attack, 108),
                            new(Static.CriticalDamage, 86),
                            new(Static.Evade, 2),
                            new(Static.Defense, 37),
                            new(Static.Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(Static.HP, 2_950),
                            new(Static.Attack, 126),
                            new(Static.CriticalDamage, 100),
                            new(Static.Evade, 2),
                            new(Static.Defense, 47),
                            new(Static.Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(Static.HP, 3_400),
                            new(Static.Attack, 144),
                            new(Static.CriticalDamage, 115),
                            new(Static.Evade, 3),
                            new(Static.Defense, 57),
                            new(Static.Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(Static.HP, 3_850),
                            new(Static.Attack, 162),
                            new(Static.CriticalDamage, 129),
                            new(Static.Evade, 4),
                            new(Static.Defense, 65),
                            new(Static.Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(Static.HP, 4_300),
                            new(Static.Attack, 180),
                            new(Static.CriticalDamage, 144),
                            new(Static.Evade, 4),
                            new(Static.Defense, 75),
                            new(Static.Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(Static.HP, 4_750),
                            new(Static.Attack, 198),
                            new(Static.CriticalDamage, 158),
                            new(Static.Evade, 5),
                            new(Static.Defense, 85),
                            new(Static.Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(Static.HP, 5_200),
                            new(Static.Attack, 216),
                            new(Static.CriticalDamage, 172),
                            new(Static.Evade, 5),
                            new(Static.Defense, 95),
                            new(Static.Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(Static.HP, 5_650),
                            new(Static.Attack, 252),
                            new(Static.CriticalDamage, 201),
                            new(Static.Evade, 6),
                            new(Static.Defense, 102),
                            new(Static.Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(Static.HP, 6_100),
                            new(Static.Attack, 270),
                            new(Static.CriticalDamage, 216),
                            new(Static.Evade, 6),
                            new(Static.Defense, 112),
                            new(Static.Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(Static.HP, 6_550),
                            new(Static.Attack, 288),
                            new(Static.CriticalDamage, 230),
                            new(Static.Evade, 7),
                            new(Static.Defense, 122),
                            new(Static.Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(Static.HP, 7_000),
                            new(Static.Attack, 306),
                            new(Static.CriticalDamage, 244),
                            new(Static.Evade, 8),
                            new(Static.Defense, 132),
                            new(Static.Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(Static.HP, 7_450),
                            new(Static.Attack, 324),
                            new(Static.CriticalDamage, 259),
                            new(Static.Evade, 8),
                            new(Static.Defense, 140),
                            new(Static.Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(Static.HP, 7_900),
                            new(Static.Attack, 342),
                            new(Static.CriticalDamage, 273),
                            new(Static.Evade, 9),
                            new(Static.Defense, 150),
                            new(Static.Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(Static.HP, 8_350),
                            new(Static.Attack, 360),
                            new(Static.CriticalDamage, 288),
                            new(Static.Evade, 9),
                            new(Static.Defense, 160),
                            new(Static.Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(Static.HP, 8_800),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 10),
                            new(Static.Defense, 170),
                            new(Static.Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(Static.HP, 9_250),
                            new(Static.Attack, 413),
                            new(Static.CriticalDamage, 331),
                            new(Static.Evade, 10),
                            new(Static.Defense, 177),
                            new(Static.Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(Static.HP, 9_700),
                            new(Static.Attack, 431),
                            new(Static.CriticalDamage, 345),
                            new(Static.Evade, 11),
                            new(Static.Defense, 187),
                            new(Static.Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(Static.HP, 10_150),
                            new(Static.Attack, 450),
                            new(Static.CriticalDamage, 360),
                            new(Static.Evade, 11),
                            new(Static.Defense, 197),
                            new(Static.Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(Static.HP, 10_600),
                            new(Static.Attack, 467),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 12),
                            new(Static.Defense, 207),
                            new(Static.Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(Static.HP, 11_050),
                            new(Static.Attack, 485),
                            new(Static.CriticalDamage, 388),
                            new(Static.Evade, 13),
                            new(Static.Defense, 215),
                            new(Static.Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(Static.HP, 11_500),
                            new(Static.Attack, 503),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 13),
                            new(Static.Defense, 225),
                            new(Static.Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(Static.HP, 11_950),
                            new(Static.Attack, 522),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 14),
                            new(Static.Defense, 235),
                            new(Static.Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(Static.HP, 12_400),
                            new(Static.Attack, 540),
                            new(Static.CriticalDamage, 432),
                            new(Static.Evade, 14),
                            new(Static.Defense, 245),
                            new(Static.Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(Static.HP, 12_850),
                            new(Static.Attack, 576),
                            new(Static.CriticalDamage, 460),
                            new(Static.Evade, 15),
                            new(Static.Defense, 252),
                            new(Static.Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(Static.HP, 13_300),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 15),
                            new(Static.Defense, 262),
                            new(Static.Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(Static.HP, 13_750),
                            new(Static.Attack, 612),
                            new(Static.CriticalDamage, 489),
                            new(Static.Evade, 16),
                            new(Static.Defense, 272),
                            new(Static.Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(Static.HP, 14_200),
                            new(Static.Attack, 630),
                            new(Static.CriticalDamage, 504),
                            new(Static.Evade, 17),
                            new(Static.Defense, 282),
                            new(Static.Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(Static.HP, 14_650),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 17),
                            new(Static.Defense, 290),
                            new(Static.Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(Static.HP, 15_100),
                            new(Static.Attack, 666),
                            new(Static.CriticalDamage, 532),
                            new(Static.Evade, 18),
                            new(Static.Defense, 300),
                            new(Static.Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(Static.HP, 15_550),
                            new(Static.Attack, 684),
                            new(Static.CriticalDamage, 547),
                            new(Static.Evade, 18),
                            new(Static.Defense, 310),
                            new(Static.Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(Static.HP, 16_000),
                            new(Static.Attack, 702),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 19),
                            new(Static.Defense, 320),
                            new(Static.Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(Static.HP, 16_450),
                            new(Static.Attack, 738),
                            new(Static.CriticalDamage, 590),
                            new(Static.Evade, 19),
                            new(Static.Defense, 327),
                            new(Static.Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(Static.HP, 16_900),
                            new(Static.Attack, 755),
                            new(Static.CriticalDamage, 604),
                            new(Static.Evade, 20),
                            new(Static.Defense, 337),
                            new(Static.Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(Static.HP, 17_350),
                            new(Static.Attack, 773),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 20),
                            new(Static.Defense, 347),
                            new(Static.Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(Static.HP, 17_800),
                            new(Static.Attack, 791),
                            new(Static.CriticalDamage, 633),
                            new(Static.Evade, 21),
                            new(Static.Defense, 357),
                            new(Static.Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(Static.HP, 18_250),
                            new(Static.Attack, 810),
                            new(Static.CriticalDamage, 648),
                            new(Static.Evade, 22),
                            new(Static.Defense, 365),
                            new(Static.Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(Static.HP, 18_700),
                            new(Static.Attack, 828),
                            new(Static.CriticalDamage, 662),
                            new(Static.Evade, 22),
                            new(Static.Defense, 374),
                            new(Static.Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(Static.HP, 19_150),
                            new(Static.Attack, 846),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 23),
                            new(Static.Defense, 384),
                            new(Static.Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(Static.HP, 19_600),
                            new(Static.Attack, 864),
                            new(Static.CriticalDamage, 691),
                            new(Static.Evade, 23),
                            new(Static.Defense, 394),
                            new(Static.Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(Static.HP, 20_050),
                            new(Static.Attack, 900),
                            new(Static.CriticalDamage, 720),
                            new(Static.Evade, 24),
                            new(Static.Defense, 402),
                            new(Static.Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(Static.HP, 20_500),
                            new(Static.Attack, 918),
                            new(Static.CriticalDamage, 734),
                            new(Static.Evade, 24),
                            new(Static.Defense, 412),
                            new(Static.Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(Static.HP, 20_950),
                            new(Static.Attack, 936),
                            new(Static.CriticalDamage, 748),
                            new(Static.Evade, 25),
                            new(Static.Defense, 422),
                            new(Static.Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(Static.HP, 21_400),
                            new(Static.Attack, 954),
                            new(Static.CriticalDamage, 763),
                            new(Static.Evade, 26),
                            new(Static.Defense, 432),
                            new(Static.Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(Static.HP, 21_850),
                            new(Static.Attack, 972),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 26),
                            new(Static.Defense, 440),
                            new(Static.Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(Static.HP, 22_300),
                            new(Static.Attack, 990),
                            new(Static.CriticalDamage, 792),
                            new(Static.Evade, 27),
                            new(Static.Defense, 450),
                            new(Static.Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(Static.HP, 22_750),
                            new(Static.Attack, 1_008),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 27),
                            new(Static.Defense, 459),
                            new(Static.Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(Static.HP, 23_200),
                            new(Static.Attack, 1_026),
                            new(Static.CriticalDamage, 820),
                            new(Static.Evade, 28),
                            new(Static.Defense, 469),
                            new(Static.Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(Static.HP, 23_650),
                            new(Static.Attack, 1_062),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 28),
                            new(Static.Defense, 477),
                            new(Static.Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(Static.HP, 24_100),
                            new(Static.Attack, 1_080),
                            new(Static.CriticalDamage, 864),
                            new(Static.Evade, 29),
                            new(Static.Defense, 487),
                            new(Static.Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(Static.HP, 24_550),
                            new(Static.Attack, 1_098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 29),
                            new(Static.Defense, 497),
                            new(Static.Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(Static.HP, 25_000),
                            new(Static.Attack, 1_116),
                            new(Static.CriticalDamage, 892),
                            new(Static.Evade, 30),
                            new(Static.Defense, 507),
                            new(Static.Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(Static.HP, 25_450),
                            new(Static.Attack, 1_134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 31),
                            new(Static.Defense, 515),
                            new(Static.Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(Static.HP, 25_900),
                            new(Static.Attack, 1_152),
                            new(Static.CriticalDamage, 921),
                            new(Static.Evade, 31),
                            new(Static.Defense, 525),
                            new(Static.Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(Static.HP, 26_350),
                            new(Static.Attack, 1_170),
                            new(Static.CriticalDamage, 936),
                            new(Static.Evade, 32),
                            new(Static.Defense, 535),
                            new(Static.Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(Static.HP, 26_800),
                            new(Static.Attack, 1_188),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 32),
                            new(Static.Defense, 545),
                            new(Static.Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(Static.HP, 27_250),
                            new(Static.Attack, 1_224),
                            new(Static.CriticalDamage, 979),
                            new(Static.Evade, 33),
                            new(Static.Defense, 552),
                            new(Static.Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(Static.HP, 27_700),
                            new(Static.Attack, 1_242),
                            new(Static.CriticalDamage, 993),
                            new(Static.Evade, 33),
                            new(Static.Defense, 562),
                            new(Static.Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(Static.HP, 28_150),
                            new(Static.Attack, 1_260),
                            new(Static.CriticalDamage, 1_008),
                            new(Static.Evade, 34),
                            new(Static.Defense, 572),
                            new(Static.Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(Static.HP, 28_600),
                            new(Static.Attack, 1_278),
                            new(Static.CriticalDamage, 1_022),
                            new(Static.Evade, 35),
                            new(Static.Defense, 582),
                            new(Static.Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(Static.HP, 29_050),
                            new(Static.Attack, 1_296),
                            new(Static.CriticalDamage, 1_036),
                            new(Static.Evade, 35),
                            new(Static.Defense, 590),
                            new(Static.Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(Static.HP, 29_500),
                            new(Static.Attack, 1_314),
                            new(Static.CriticalDamage, 1_051),
                            new(Static.Evade, 36),
                            new(Static.Defense, 600),
                            new(Static.Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(Static.HP, 29_950),
                            new(Static.Attack, 1_332),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 36),
                            new(Static.Defense, 610),
                            new(Static.Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(Static.HP, 30_400),
                            new(Static.Attack, 1_350),
                            new(Static.CriticalDamage, 1_080),
                            new(Static.Evade, 37),
                            new(Static.Defense, 619),
                            new(Static.Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(Static.HP, 30_850),
                            new(Static.Attack, 1_386),
                            new(Static.CriticalDamage, 1_108),
                            new(Static.Evade, 37),
                            new(Static.Defense, 627),
                            new(Static.Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(Static.HP, 31_300),
                            new(Static.Attack, 1_404),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 38),
                            new(Static.Defense, 637),
                            new(Static.Accuracy, AccuracyList[67])
                        }
                    }
                });

        #endregion
    }
}