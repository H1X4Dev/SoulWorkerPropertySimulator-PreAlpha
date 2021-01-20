using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Stella =>
            new("史黛拉",
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
                            new(Static.Defense, 5),
                            new(Static.Accuracy, AccuracyList[0])
                        }
                    },
                    {
                        2,
                        new Effect[]
                        {
                            new(Static.HP, 1_400),
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
                            new(Static.HP, 1_700),
                            new(Static.Attack, 108),
                            new(Static.CriticalDamage, 86),
                            new(Static.Evade, 2),
                            new(Static.Defense, 15),
                            new(Static.Accuracy, AccuracyList[2])
                        }
                    },
                    {
                        4,
                        new Effect[]
                        {
                            new(Static.HP, 2_000),
                            new(Static.Attack, 126),
                            new(Static.CriticalDamage, 100),
                            new(Static.Evade, 2),
                            new(Static.Defense, 20),
                            new(Static.Accuracy, AccuracyList[3])
                        }
                    },
                    {
                        5,
                        new Effect[]
                        {
                            new(Static.HP, 2_300),
                            new(Static.Attack, 144),
                            new(Static.CriticalDamage, 115),
                            new(Static.Evade, 3),
                            new(Static.Defense, 25),
                            new(Static.Accuracy, AccuracyList[4])
                        }
                    },
                    {
                        6,
                        new Effect[]
                        {
                            new(Static.HP, 2_600),
                            new(Static.Attack, 180),
                            new(Static.CriticalDamage, 144),
                            new(Static.Evade, 4),
                            new(Static.Defense, 30),
                            new(Static.Accuracy, AccuracyList[5])
                        }
                    },
                    {
                        7,
                        new Effect[]
                        {
                            new(Static.HP, 2_900),
                            new(Static.Attack, 198),
                            new(Static.CriticalDamage, 158),
                            new(Static.Evade, 4),
                            new(Static.Defense, 35),
                            new(Static.Accuracy, AccuracyList[6])
                        }
                    },
                    {
                        8,
                        new Effect[]
                        {
                            new(Static.HP, 3_200),
                            new(Static.Attack, 216),
                            new(Static.CriticalDamage, 172),
                            new(Static.Evade, 5),
                            new(Static.Defense, 40),
                            new(Static.Accuracy, AccuracyList[7])
                        }
                    },
                    {
                        9,
                        new Effect[]
                        {
                            new(Static.HP, 3_500),
                            new(Static.Attack, 252),
                            new(Static.CriticalDamage, 201),
                            new(Static.Evade, 6),
                            new(Static.Defense, 45),
                            new(Static.Accuracy, AccuracyList[8])
                        }
                    },
                    {
                        10,
                        new Effect[]
                        {
                            new(Static.HP, 3_800),
                            new(Static.Attack, 270),
                            new(Static.CriticalDamage, 216),
                            new(Static.Evade, 7),
                            new(Static.Defense, 50),
                            new(Static.Accuracy, AccuracyList[9])
                        }
                    },
                    {
                        11,
                        new Effect[]
                        {
                            new(Static.HP, 4_100),
                            new(Static.Attack, 306),
                            new(Static.CriticalDamage, 244),
                            new(Static.Evade, 7),
                            new(Static.Defense, 55),
                            new(Static.Accuracy, AccuracyList[10])
                        }
                    },
                    {
                        12,
                        new Effect[]
                        {
                            new(Static.HP, 4_400),
                            new(Static.Attack, 324),
                            new(Static.CriticalDamage, 259),
                            new(Static.Evade, 8),
                            new(Static.Defense, 60),
                            new(Static.Accuracy, AccuracyList[11])
                        }
                    },
                    {
                        13,
                        new Effect[]
                        {
                            new(Static.HP, 4_700),
                            new(Static.Attack, 342),
                            new(Static.CriticalDamage, 273),
                            new(Static.Evade, 9),
                            new(Static.Defense, 65),
                            new(Static.Accuracy, AccuracyList[12])
                        }
                    },
                    {
                        14,
                        new Effect[]
                        {
                            new(Static.HP, 5_000),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 9),
                            new(Static.Defense, 70),
                            new(Static.Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(Static.HP, 5_300),
                            new(Static.Attack, 396),
                            new(Static.CriticalDamage, 316),
                            new(Static.Evade, 10),
                            new(Static.Defense, 75),
                            new(Static.Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(Static.HP, 5_600),
                            new(Static.Attack, 414),
                            new(Static.CriticalDamage, 331),
                            new(Static.Evade, 11),
                            new(Static.Defense, 80),
                            new(Static.Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(Static.HP, 5_900),
                            new(Static.Attack, 450),
                            new(Static.CriticalDamage, 360),
                            new(Static.Evade, 11),
                            new(Static.Defense, 85),
                            new(Static.Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(Static.HP, 6_200),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 12),
                            new(Static.Defense, 90),
                            new(Static.Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(Static.HP, 6_500),
                            new(Static.Attack, 503),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 13),
                            new(Static.Defense, 95),
                            new(Static.Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(Static.HP, 6_800),
                            new(Static.Attack, 521),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 13),
                            new(Static.Defense, 100),
                            new(Static.Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(Static.HP, 7_100),
                            new(Static.Attack, 539),
                            new(Static.CriticalDamage, 431),
                            new(Static.Evade, 14),
                            new(Static.Defense, 105),
                            new(Static.Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(Static.HP, 7_400),
                            new(Static.Attack, 576),
                            new(Static.CriticalDamage, 460),
                            new(Static.Evade, 15),
                            new(Static.Defense, 110),
                            new(Static.Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(Static.HP, 7_700),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 15),
                            new(Static.Defense, 115),
                            new(Static.Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(Static.HP, 8_000),
                            new(Static.Attack, 612),
                            new(Static.CriticalDamage, 489),
                            new(Static.Evade, 16),
                            new(Static.Defense, 120),
                            new(Static.Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(Static.HP, 8_300),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 17),
                            new(Static.Defense, 125),
                            new(Static.Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(Static.HP, 8_600),
                            new(Static.Attack, 666),
                            new(Static.CriticalDamage, 532),
                            new(Static.Evade, 18),
                            new(Static.Defense, 130),
                            new(Static.Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(Static.HP, 8_900),
                            new(Static.Attack, 702),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 18),
                            new(Static.Defense, 135),
                            new(Static.Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(Static.HP, 9_200),
                            new(Static.Attack, 720),
                            new(Static.CriticalDamage, 576),
                            new(Static.Evade, 19),
                            new(Static.Defense, 140),
                            new(Static.Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(Static.HP, 9_500),
                            new(Static.Attack, 738),
                            new(Static.CriticalDamage, 590),
                            new(Static.Evade, 20),
                            new(Static.Defense, 145),
                            new(Static.Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(Static.HP, 9_800),
                            new(Static.Attack, 774),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 20),
                            new(Static.Defense, 150),
                            new(Static.Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(Static.HP, 10_100),
                            new(Static.Attack, 792),
                            new(Static.CriticalDamage, 633),
                            new(Static.Evade, 21),
                            new(Static.Defense, 155),
                            new(Static.Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(Static.HP, 10_400),
                            new(Static.Attack, 809),
                            new(Static.CriticalDamage, 647),
                            new(Static.Evade, 22),
                            new(Static.Defense, 160),
                            new(Static.Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(Static.HP, 10_700),
                            new(Static.Attack, 845),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 22),
                            new(Static.Defense, 165),
                            new(Static.Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(Static.HP, 11_000),
                            new(Static.Attack, 863),
                            new(Static.CriticalDamage, 691),
                            new(Static.Evade, 23),
                            new(Static.Defense, 170),
                            new(Static.Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(Static.HP, 11_300),
                            new(Static.Attack, 899),
                            new(Static.CriticalDamage, 719),
                            new(Static.Evade, 24),
                            new(Static.Defense, 175),
                            new(Static.Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(Static.HP, 11_600),
                            new(Static.Attack, 917),
                            new(Static.CriticalDamage, 734),
                            new(Static.Evade, 24),
                            new(Static.Defense, 180),
                            new(Static.Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(Static.HP, 11_900),
                            new(Static.Attack, 936),
                            new(Static.CriticalDamage, 748),
                            new(Static.Evade, 25),
                            new(Static.Defense, 185),
                            new(Static.Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(Static.HP, 12_200),
                            new(Static.Attack, 971),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 26),
                            new(Static.Defense, 190),
                            new(Static.Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(Static.HP, 12_500),
                            new(Static.Attack, 990),
                            new(Static.CriticalDamage, 792),
                            new(Static.Evade, 26),
                            new(Static.Defense, 195),
                            new(Static.Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(Static.HP, 12_800),
                            new(Static.Attack, 1_008),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 27),
                            new(Static.Defense, 200),
                            new(Static.Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(Static.HP, 13_100),
                            new(Static.Attack, 1_044),
                            new(Static.CriticalDamage, 835),
                            new(Static.Evade, 28),
                            new(Static.Defense, 205),
                            new(Static.Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(Static.HP, 13_400),
                            new(Static.Attack, 1_062),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 29),
                            new(Static.Defense, 210),
                            new(Static.Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(Static.HP, 13_700),
                            new(Static.Attack, 1_098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 29),
                            new(Static.Defense, 215),
                            new(Static.Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(Static.HP, 14_000),
                            new(Static.Attack, 1_116),
                            new(Static.CriticalDamage, 892),
                            new(Static.Evade, 30),
                            new(Static.Defense, 220),
                            new(Static.Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(Static.HP, 14_300),
                            new(Static.Attack, 1_134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 31),
                            new(Static.Defense, 225),
                            new(Static.Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(Static.HP, 14_600),
                            new(Static.Attack, 1_170),
                            new(Static.CriticalDamage, 936),
                            new(Static.Evade, 31),
                            new(Static.Defense, 230),
                            new(Static.Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(Static.HP, 14_900),
                            new(Static.Attack, 1_188),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 32),
                            new(Static.Defense, 235),
                            new(Static.Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(Static.HP, 15_200),
                            new(Static.Attack, 1_206),
                            new(Static.CriticalDamage, 964),
                            new(Static.Evade, 33),
                            new(Static.Defense, 240),
                            new(Static.Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(Static.HP, 15_500),
                            new(Static.Attack, 1_242),
                            new(Static.CriticalDamage, 993),
                            new(Static.Evade, 33),
                            new(Static.Defense, 245),
                            new(Static.Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(Static.HP, 15_800),
                            new(Static.Attack, 1_260),
                            new(Static.CriticalDamage, 1_008),
                            new(Static.Evade, 34),
                            new(Static.Defense, 250),
                            new(Static.Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(Static.HP, 16_100),
                            new(Static.Attack, 1_296),
                            new(Static.CriticalDamage, 1_036),
                            new(Static.Evade, 35),
                            new(Static.Defense, 255),
                            new(Static.Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(Static.HP, 16_400),
                            new(Static.Attack, 1_314),
                            new(Static.CriticalDamage, 1_051),
                            new(Static.Evade, 35),
                            new(Static.Defense, 260),
                            new(Static.Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(Static.HP, 16_700),
                            new(Static.Attack, 1_331),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 36),
                            new(Static.Defense, 265),
                            new(Static.Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(Static.HP, 17_000),
                            new(Static.Attack, 1_368),
                            new(Static.CriticalDamage, 1_094),
                            new(Static.Evade, 37),
                            new(Static.Defense, 270),
                            new(Static.Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(Static.HP, 17_300),
                            new(Static.Attack, 1_386),
                            new(Static.CriticalDamage, 1_108),
                            new(Static.Evade, 37),
                            new(Static.Defense, 275),
                            new(Static.Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(Static.HP, 17_600),
                            new(Static.Attack, 1_404),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 38),
                            new(Static.Defense, 279),
                            new(Static.Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(Static.HP, 17_900),
                            new(Static.Attack, 1_440),
                            new(Static.CriticalDamage, 1_152),
                            new(Static.Evade, 39),
                            new(Static.Defense, 284),
                            new(Static.Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(Static.HP, 18_200),
                            new(Static.Attack, 1_458),
                            new(Static.CriticalDamage, 1_166),
                            new(Static.Evade, 40),
                            new(Static.Defense, 289),
                            new(Static.Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(Static.HP, 18_500),
                            new(Static.Attack, 1_494),
                            new(Static.CriticalDamage, 1_195),
                            new(Static.Evade, 40),
                            new(Static.Defense, 294),
                            new(Static.Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(Static.HP, 18_800),
                            new(Static.Attack, 1_512),
                            new(Static.CriticalDamage, 1_209),
                            new(Static.Evade, 41),
                            new(Static.Defense, 299),
                            new(Static.Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(Static.HP, 19_100),
                            new(Static.Attack, 1_530),
                            new(Static.CriticalDamage, 1_224),
                            new(Static.Evade, 42),
                            new(Static.Defense, 305),
                            new(Static.Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(Static.HP, 19_400),
                            new(Static.Attack, 1_566),
                            new(Static.CriticalDamage, 1_252),
                            new(Static.Evade, 42),
                            new(Static.Defense, 310),
                            new(Static.Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(Static.HP, 19_700),
                            new(Static.Attack, 1_584),
                            new(Static.CriticalDamage, 1_267),
                            new(Static.Evade, 43),
                            new(Static.Defense, 315),
                            new(Static.Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(Static.HP, 20_000),
                            new(Static.Attack, 1_602),
                            new(Static.CriticalDamage, 1_281),
                            new(Static.Evade, 44),
                            new(Static.Defense, 320),
                            new(Static.Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(Static.HP, 20_300),
                            new(Static.Attack, 1_638),
                            new(Static.CriticalDamage, 1_310),
                            new(Static.Evade, 44),
                            new(Static.Defense, 325),
                            new(Static.Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(Static.HP, 20_600),
                            new(Static.Attack, 1_656),
                            new(Static.CriticalDamage, 1_324),
                            new(Static.Evade, 45),
                            new(Static.Defense, 329),
                            new(Static.Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(Static.HP, 20_900),
                            new(Static.Attack, 1_692),
                            new(Static.CriticalDamage, 1_353),
                            new(Static.Evade, 46),
                            new(Static.Defense, 334),
                            new(Static.Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(Static.HP, 21_200),
                            new(Static.Attack, 1_710),
                            new(Static.CriticalDamage, 1_368),
                            new(Static.Evade, 46),
                            new(Static.Defense, 339),
                            new(Static.Accuracy, AccuracyList[67])
                        }
                    }
                });

        #endregion
    }
}