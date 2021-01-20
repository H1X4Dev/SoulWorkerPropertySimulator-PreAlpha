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
                        new[]
                        {
                            new(Static.HP, 6_300),
                            new(Static.Attack, 378),
                            new(Static.CriticalDamage, 302),
                            new(Static.Evade, 9),
                            new(Static.Defense, 95),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(Static.HP, 6_700),
                            new(Static.Attack, 396),
                            new(Static.CriticalDamage, 316),
                            new(Static.Evade, 10),
                            new(Static.Defense, 102),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(Static.HP, 7_100),
                            new(Static.Attack, 432),
                            new(Static.CriticalDamage, 345),
                            new(Static.Evade, 11),
                            new(Static.Defense, 110),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(Static.HP, 7_500),
                            new(Static.Attack, 450),
                            new(Static.CriticalDamage, 360),
                            new(Static.Evade, 11),
                            new(Static.Defense, 117),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(Static.HP, 7_900),
                            new(Static.Attack, 468),
                            new(Static.CriticalDamage, 374),
                            new(Static.Evade, 12),
                            new(Static.Defense, 122),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(Static.HP, 8_300),
                            new(Static.Attack, 504),
                            new(Static.CriticalDamage, 403),
                            new(Static.Evade, 13),
                            new(Static.Defense, 130),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(Static.HP, 8_700),
                            new(Static.Attack, 522),
                            new(Static.CriticalDamage, 417),
                            new(Static.Evade, 13),
                            new(Static.Defense, 137),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(Static.HP, 9_100),
                            new(Static.Attack, 558),
                            new(Static.CriticalDamage, 446),
                            new(Static.Evade, 14),
                            new(Static.Defense, 145),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(Static.HP, 9_500),
                            new(Static.Attack, 576),
                            new(Static.CriticalDamage, 460),
                            new(Static.Evade, 15),
                            new(Static.Defense, 150),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(Static.HP, 9_900),
                            new(Static.Attack, 594),
                            new(Static.CriticalDamage, 475),
                            new(Static.Evade, 15),
                            new(Static.Defense, 157),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(Static.HP, 10_300),
                            new(Static.Attack, 630),
                            new(Static.CriticalDamage, 504),
                            new(Static.Evade, 16),
                            new(Static.Defense, 165),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(Static.HP, 10_700),
                            new(Static.Attack, 648),
                            new(Static.CriticalDamage, 518),
                            new(Static.Evade, 17),
                            new(Static.Defense, 172),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(Static.HP, 11_100),
                            new(Static.Attack, 683),
                            new(Static.CriticalDamage, 547),
                            new(Static.Evade, 17),
                            new(Static.Defense, 177),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(Static.HP, 11_500),
                            new(Static.Attack, 701),
                            new(Static.CriticalDamage, 561),
                            new(Static.Evade, 18),
                            new(Static.Defense, 185),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(Static.HP, 11_900),
                            new(Static.Attack, 719),
                            new(Static.CriticalDamage, 575),
                            new(Static.Evade, 19),
                            new(Static.Defense, 192),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(Static.HP, 12_300),
                            new(Static.Attack, 755),
                            new(Static.CriticalDamage, 604),
                            new(Static.Evade, 20),
                            new(Static.Defense, 200),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(Static.HP, 12_700),
                            new(Static.Attack, 773),
                            new(Static.CriticalDamage, 619),
                            new(Static.Evade, 20),
                            new(Static.Defense, 205),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(Static.HP, 13_100),
                            new(Static.Attack, 809),
                            new(Static.CriticalDamage, 647),
                            new(Static.Evade, 21),
                            new(Static.Defense, 212),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(Static.HP, 13_500),
                            new(Static.Attack, 827),
                            new(Static.CriticalDamage, 662),
                            new(Static.Evade, 22),
                            new(Static.Defense, 220),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(Static.HP, 13_900),
                            new(Static.Attack, 845),
                            new(Static.CriticalDamage, 676),
                            new(Static.Evade, 22),
                            new(Static.Defense, 227),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(Static.HP, 14_300),
                            new(Static.Attack, 881),
                            new(Static.CriticalDamage, 705),
                            new(Static.Evade, 23),
                            new(Static.Defense, 232),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(Static.HP, 14_700),
                            new(Static.Attack, 899),
                            new(Static.CriticalDamage, 719),
                            new(Static.Evade, 24),
                            new(Static.Defense, 240),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(Static.HP, 15_100),
                            new(Static.Attack, 935),
                            new(Static.CriticalDamage, 748),
                            new(Static.Evade, 24),
                            new(Static.Defense, 247),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(Static.HP, 15_500),
                            new(Static.Attack, 953),
                            new(Static.CriticalDamage, 763),
                            new(Static.Evade, 25),
                            new(Static.Defense, 255),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(Static.HP, 15_900),
                            new(Static.Attack, 972),
                            new(Static.CriticalDamage, 777),
                            new(Static.Evade, 26),
                            new(Static.Defense, 260),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(Static.HP, 16_300),
                            new(Static.Attack, 1_007),
                            new(Static.CriticalDamage, 806),
                            new(Static.Evade, 26),
                            new(Static.Defense, 267),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(Static.HP, 16_700),
                            new(Static.Attack, 1_025),
                            new(Static.CriticalDamage, 820),
                            new(Static.Evade, 27),
                            new(Static.Defense, 275),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(Static.HP, 17_100),
                            new(Static.Attack, 1_062),
                            new(Static.CriticalDamage, 849),
                            new(Static.Evade, 28),
                            new(Static.Defense, 282),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(Static.HP, 17_500),
                            new(Static.Attack, 1_080),
                            new(Static.CriticalDamage, 864),
                            new(Static.Evade, 28),
                            new(Static.Defense, 287),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(Static.HP, 17_900),
                            new(Static.Attack, 1_098),
                            new(Static.CriticalDamage, 878),
                            new(Static.Evade, 29),
                            new(Static.Defense, 295),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(Static.HP, 18_300),
                            new(Static.Attack, 1_134),
                            new(Static.CriticalDamage, 907),
                            new(Static.Evade, 30),
                            new(Static.Defense, 302),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(Static.HP, 18_700),
                            new(Static.Attack, 1_152),
                            new(Static.CriticalDamage, 921),
                            new(Static.Evade, 31),
                            new(Static.Defense, 310),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(Static.HP, 19_100),
                            new(Static.Attack, 1_188),
                            new(Static.CriticalDamage, 950),
                            new(Static.Evade, 31),
                            new(Static.Defense, 315),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(Static.HP, 19_500),
                            new(Static.Attack, 1_206),
                            new(Static.CriticalDamage, 964),
                            new(Static.Evade, 32),
                            new(Static.Defense, 322),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(Static.HP, 19_900),
                            new(Static.Attack, 1_224),
                            new(Static.CriticalDamage, 979),
                            new(Static.Evade, 33),
                            new(Static.Defense, 330),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(Static.HP, 20_300),
                            new(Static.Attack, 1_260),
                            new(Static.CriticalDamage, 1_008),
                            new(Static.Evade, 33),
                            new(Static.Defense, 337),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(Static.HP, 20_700),
                            new(Static.Attack, 1_278),
                            new(Static.CriticalDamage, 1_022),
                            new(Static.Evade, 34),
                            new(Static.Defense, 342),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(Static.HP, 21_100),
                            new(Static.Attack, 1_314),
                            new(Static.CriticalDamage, 1_051),
                            new(Static.Evade, 35),
                            new(Static.Defense, 350),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(Static.HP, 21_500),
                            new(Static.Attack, 1_332),
                            new(Static.CriticalDamage, 1_065),
                            new(Static.Evade, 35),
                            new(Static.Defense, 357),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(Static.HP, 21_900),
                            new(Static.Attack, 1_350),
                            new(Static.CriticalDamage, 1_080),
                            new(Static.Evade, 36),
                            new(Static.Defense, 365),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(Static.HP, 22_300),
                            new(Static.Attack, 1_386),
                            new(Static.CriticalDamage, 1_108),
                            new(Static.Evade, 37),
                            new(Static.Defense, 370),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(Static.HP, 22_700),
                            new(Static.Attack, 1_403),
                            new(Static.CriticalDamage, 1_123),
                            new(Static.Evade, 37),
                            new(Static.Defense, 377),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(Static.HP, 23_100),
                            new(Static.Attack, 1_440),
                            new(Static.CriticalDamage, 1_152),
                            new(Static.Evade, 38),
                            new(Static.Defense, 385),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(Static.HP, 23_500),
                            new(Static.Attack, 1_458),
                            new(Static.CriticalDamage, 1_166),
                            new(Static.Evade, 39),
                            new(Static.Defense, 392),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(Static.HP, 23_900),
                            new(Static.Attack, 1_476),
                            new(Static.CriticalDamage, 1_180),
                            new(Static.Evade, 39),
                            new(Static.Defense, 397),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(Static.HP, 24_300),
                            new(Static.Attack, 1_512),
                            new(Static.CriticalDamage, 1_209),
                            new(Static.Evade, 40),
                            new(Static.Defense, 405),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(Static.HP, 24_700),
                            new(Static.Attack, 1_530),
                            new(Static.CriticalDamage, 1_224),
                            new(Static.Evade, 41),
                            new(Static.Defense, 412),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(Static.HP, 25_100),
                            new(Static.Attack, 1_566),
                            new(Static.CriticalDamage, 1_252),
                            new(Static.Evade, 42),
                            new(Static.Defense, 420),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(Static.HP, 25_500),
                            new(Static.Attack, 1_584),
                            new(Static.CriticalDamage, 1_267),
                            new(Static.Evade, 42),
                            new(Static.Defense, 425),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(Static.HP, 25_900),
                            new(Static.Attack, 1_602),
                            new(Static.CriticalDamage, 1_281),
                            new(Static.Evade, 43),
                            new(Static.Defense, 432),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(Static.HP, 26_300),
                            new(Static.Attack, 1_638),
                            new(Static.CriticalDamage, 1_310),
                            new(Static.Evade, 44),
                            new(Static.Defense, 440),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(Static.HP, 26_700),
                            new(Static.Attack, 1_656),
                            new(Static.CriticalDamage, 1_324),
                            new(Static.Evade, 44),
                            new(Static.Defense, 447),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(Static.HP, 27_100),
                            new(Static.Attack, 1_692),
                            new(Static.CriticalDamage, 1_353),
                            new(Static.Evade, 45),
                            new(Static.Defense, 452),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(Static.HP, 27_500),
                            new(Static.Attack, 1_710),
                            new(Static.CriticalDamage, 1_368),
                            new(Static.Evade, 46),
                            new(Static.Defense, 460),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(Static.HP, 27_900),
                            new(Static.Attack, 1_728),
                            new(Static.CriticalDamage, 1_382),
                            new(Static.Evade, 46),
                            new(Static.Defense, 467),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}