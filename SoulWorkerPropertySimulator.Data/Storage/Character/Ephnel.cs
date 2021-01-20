using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Ephnel =>
            new("艾芙妮爾",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        14,
                        new Effect[]
                        {
                            new(Static.HP, 6_300),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 9),
                            new(Static.Defense, 95),
                            new(Static.Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(Static.HP, 6_700),
                            new(Static.Attack, 396),
                            new(Static.CriticalDamage, 316),
                            new(Static.Evade, 10),
                            new(Static.Defense, 102),
                            new(Static.Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(Static.HP, 7_100),
                            new(Static.Attack, 432),
                            new(Static.CriticalDamage, 345),
                            new(Static.Evade, 11),
                            new(Static.Defense, 110),
                            new(Static.Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(Static.HP, 7_500),
                            new(Static.Attack, 450),
                            new(Static.CriticalDamage, 360),
                            new(Static.Evade, 11),
                            new(Static.Defense, 117),
                            new(Static.Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(Static.HP, 7_900),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 12),
                            new(Static.Defense, 122),
                            new(Static.Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(Static.HP, 8_300),
                            new(Static.Attack, 504),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 13),
                            new(Static.Defense, 130),
                            new(Static.Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(Static.HP, 8_700),
                            new(Static.Attack, 522),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 13),
                            new(Static.Defense, 137),
                            new(Static.Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(Static.HP, 9_100),
                            new(Static.Attack, 558),
                            new(Static.CriticalDamage, 446),
                            new(Static.Evade, 14),
                            new(Static.Defense, 145),
                            new(Static.Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(Static.HP, 9_500),
                            new(Static.Attack, 576),
                            new(Static.CriticalDamage, 460),
                            new(Static.Evade, 15),
                            new(Static.Defense, 150),
                            new(Static.Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(Static.HP, 9_900),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 15),
                            new(Static.Defense, 157),
                            new(Static.Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(Static.HP, 10_300),
                            new(Static.Attack, 630),
                            new(Static.CriticalDamage, 504),
                            new(Static.Evade, 16),
                            new(Static.Defense, 165),
                            new(Static.Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(Static.HP, 10_700),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 17),
                            new(Static.Defense, 172),
                            new(Static.Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(Static.HP, 11_100),
                            new(Static.Attack, 683),
                            new(Static.CriticalDamage, 547),
                            new(Static.Evade, 17),
                            new(Static.Defense, 177),
                            new(Static.Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(Static.HP, 11_500),
                            new(Static.Attack, 701),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 18),
                            new(Static.Defense, 185),
                            new(Static.Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(Static.HP, 11_900),
                            new(Static.Attack, 719),
                            new(Static.CriticalDamage, 575),
                            new(Static.Evade, 19),
                            new(Static.Defense, 192),
                            new(Static.Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(Static.HP, 12_300),
                            new(Static.Attack, 755),
                            new(Static.CriticalDamage, 604),
                            new(Static.Evade, 20),
                            new(Static.Defense, 200),
                            new(Static.Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(Static.HP, 12_700),
                            new(Static.Attack, 773),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 20),
                            new(Static.Defense, 205),
                            new(Static.Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(Static.HP, 13_100),
                            new(Static.Attack, 809),
                            new(Static.CriticalDamage, 647),
                            new(Static.Evade, 21),
                            new(Static.Defense, 212),
                            new(Static.Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(Static.HP, 13_500),
                            new(Static.Attack, 827),
                            new(Static.CriticalDamage, 662),
                            new(Static.Evade, 22),
                            new(Static.Defense, 220),
                            new(Static.Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(Static.HP, 13_900),
                            new(Static.Attack, 845),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 22),
                            new(Static.Defense, 227),
                            new(Static.Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(Static.HP, 14_300),
                            new(Static.Attack, 881),
                            new(Static.CriticalDamage, 705),
                            new(Static.Evade, 23),
                            new(Static.Defense, 232),
                            new(Static.Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(Static.HP, 14_700),
                            new(Static.Attack, 899),
                            new(Static.CriticalDamage, 719),
                            new(Static.Evade, 24),
                            new(Static.Defense, 240),
                            new(Static.Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(Static.HP, 15_100),
                            new(Static.Attack, 935),
                            new(Static.CriticalDamage, 748),
                            new(Static.Evade, 24),
                            new(Static.Defense, 247),
                            new(Static.Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(Static.HP, 15_500),
                            new(Static.Attack, 953),
                            new(Static.CriticalDamage, 763),
                            new(Static.Evade, 25),
                            new(Static.Defense, 255),
                            new(Static.Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(Static.HP, 15_900),
                            new(Static.Attack, 972),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 26),
                            new(Static.Defense, 260),
                            new(Static.Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(Static.HP, 16_300),
                            new(Static.Attack, 1_007),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 26),
                            new(Static.Defense, 267),
                            new(Static.Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(Static.HP, 16_700),
                            new(Static.Attack, 1_025),
                            new(Static.CriticalDamage, 820),
                            new(Static.Evade, 27),
                            new(Static.Defense, 275),
                            new(Static.Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(Static.HP, 17_100),
                            new(Static.Attack, 1_062),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 28),
                            new(Static.Defense, 282),
                            new(Static.Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(Static.HP, 17_500),
                            new(Static.Attack, 1_080),
                            new(Static.CriticalDamage, 864),
                            new(Static.Evade, 28),
                            new(Static.Defense, 287),
                            new(Static.Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(Static.HP, 17_900),
                            new(Static.Attack, 1_098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 29),
                            new(Static.Defense, 295),
                            new(Static.Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(Static.HP, 18_300),
                            new(Static.Attack, 1_134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 30),
                            new(Static.Defense, 302),
                            new(Static.Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(Static.HP, 18_700),
                            new(Static.Attack, 1_152),
                            new(Static.CriticalDamage, 921),
                            new(Static.Evade, 31),
                            new(Static.Defense, 310),
                            new(Static.Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(Static.HP, 19_100),
                            new(Static.Attack, 1_188),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 31),
                            new(Static.Defense, 315),
                            new(Static.Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(Static.HP, 19_500),
                            new(Static.Attack, 1_206),
                            new(Static.CriticalDamage, 964),
                            new(Static.Evade, 32),
                            new(Static.Defense, 322),
                            new(Static.Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(Static.HP, 19_900),
                            new(Static.Attack, 1_224),
                            new(Static.CriticalDamage, 979),
                            new(Static.Evade, 33),
                            new(Static.Defense, 330),
                            new(Static.Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(Static.HP, 20_300),
                            new(Static.Attack, 1_260),
                            new(Static.CriticalDamage, 1_008),
                            new(Static.Evade, 33),
                            new(Static.Defense, 337),
                            new(Static.Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(Static.HP, 20_700),
                            new(Static.Attack, 1_278),
                            new(Static.CriticalDamage, 1_022),
                            new(Static.Evade, 34),
                            new(Static.Defense, 342),
                            new(Static.Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(Static.HP, 21_100),
                            new(Static.Attack, 1_314),
                            new(Static.CriticalDamage, 1_051),
                            new(Static.Evade, 35),
                            new(Static.Defense, 350),
                            new(Static.Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(Static.HP, 21_500),
                            new(Static.Attack, 1_332),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 35),
                            new(Static.Defense, 357),
                            new(Static.Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(Static.HP, 21_900),
                            new(Static.Attack, 1_350),
                            new(Static.CriticalDamage, 1_080),
                            new(Static.Evade, 36),
                            new(Static.Defense, 365),
                            new(Static.Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(Static.HP, 22_300),
                            new(Static.Attack, 1_386),
                            new(Static.CriticalDamage, 1_108),
                            new(Static.Evade, 37),
                            new(Static.Defense, 370),
                            new(Static.Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(Static.HP, 22_700),
                            new(Static.Attack, 1_403),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 37),
                            new(Static.Defense, 377),
                            new(Static.Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(Static.HP, 23_100),
                            new(Static.Attack, 1_440),
                            new(Static.CriticalDamage, 1_152),
                            new(Static.Evade, 38),
                            new(Static.Defense, 385),
                            new(Static.Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(Static.HP, 23_500),
                            new(Static.Attack, 1_458),
                            new(Static.CriticalDamage, 1_166),
                            new(Static.Evade, 39),
                            new(Static.Defense, 392),
                            new(Static.Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(Static.HP, 23_900),
                            new(Static.Attack, 1_476),
                            new(Static.CriticalDamage, 1_180),
                            new(Static.Evade, 39),
                            new(Static.Defense, 397),
                            new(Static.Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(Static.HP, 24_300),
                            new(Static.Attack, 1_512),
                            new(Static.CriticalDamage, 1_209),
                            new(Static.Evade, 40),
                            new(Static.Defense, 405),
                            new(Static.Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(Static.HP, 24_700),
                            new(Static.Attack, 1_530),
                            new(Static.CriticalDamage, 1_224),
                            new(Static.Evade, 41),
                            new(Static.Defense, 412),
                            new(Static.Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(Static.HP, 25_100),
                            new(Static.Attack, 1_566),
                            new(Static.CriticalDamage, 1_252),
                            new(Static.Evade, 42),
                            new(Static.Defense, 420),
                            new(Static.Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(Static.HP, 25_500),
                            new(Static.Attack, 1_584),
                            new(Static.CriticalDamage, 1_267),
                            new(Static.Evade, 42),
                            new(Static.Defense, 425),
                            new(Static.Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(Static.HP, 25_900),
                            new(Static.Attack, 1_602),
                            new(Static.CriticalDamage, 1_281),
                            new(Static.Evade, 43),
                            new(Static.Defense, 432),
                            new(Static.Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(Static.HP, 26_300),
                            new(Static.Attack, 1_638),
                            new(Static.CriticalDamage, 1_310),
                            new(Static.Evade, 44),
                            new(Static.Defense, 440),
                            new(Static.Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(Static.HP, 26_700),
                            new(Static.Attack, 1_656),
                            new(Static.CriticalDamage, 1_324),
                            new(Static.Evade, 44),
                            new(Static.Defense, 447),
                            new(Static.Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(Static.HP, 27_100),
                            new(Static.Attack, 1_692),
                            new(Static.CriticalDamage, 1_353),
                            new(Static.Evade, 45),
                            new(Static.Defense, 452),
                            new(Static.Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(Static.HP, 27_500),
                            new(Static.Attack, 1_710),
                            new(Static.CriticalDamage, 1_368),
                            new(Static.Evade, 46),
                            new(Static.Defense, 460),
                            new(Static.Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(Static.HP, 27_900),
                            new(Static.Attack, 1_728),
                            new(Static.CriticalDamage, 1_382),
                            new(Static.Evade, 46),
                            new(Static.Defense, 467),
                            new(Static.Accuracy, AccuracyList[67])
                        }
                    }
                });

        #endregion
    }
}