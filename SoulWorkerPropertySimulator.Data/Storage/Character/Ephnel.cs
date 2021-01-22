using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupEphnel() =>
            new("艾芙妮爾",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        14,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_300),
                            new(StaticEffect.Attack, 378),
                            new(StaticEffect.CriticalDamage, 302),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 95),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_700),
                            new(StaticEffect.Attack, 396),
                            new(StaticEffect.CriticalDamage, 316),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 102),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_100),
                            new(StaticEffect.Attack, 432),
                            new(StaticEffect.CriticalDamage, 345),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 110),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_500),
                            new(StaticEffect.Attack, 450),
                            new(StaticEffect.CriticalDamage, 360),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 117),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_900),
                            new(StaticEffect.Attack, 468),
                            new(StaticEffect.CriticalDamage, 374),
                            new(StaticEffect.Evade, 12),
                            new(StaticEffect.Defense, 122),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_300),
                            new(StaticEffect.Attack, 504),
                            new(StaticEffect.CriticalDamage, 403),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 130),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_700),
                            new(StaticEffect.Attack, 522),
                            new(StaticEffect.CriticalDamage, 417),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 137),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_100),
                            new(StaticEffect.Attack, 558),
                            new(StaticEffect.CriticalDamage, 446),
                            new(StaticEffect.Evade, 14),
                            new(StaticEffect.Defense, 145),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_500),
                            new(StaticEffect.Attack, 576),
                            new(StaticEffect.CriticalDamage, 460),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 150),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_900),
                            new(StaticEffect.Attack, 594),
                            new(StaticEffect.CriticalDamage, 475),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 157),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_300),
                            new(StaticEffect.Attack, 630),
                            new(StaticEffect.CriticalDamage, 504),
                            new(StaticEffect.Evade, 16),
                            new(StaticEffect.Defense, 165),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_700),
                            new(StaticEffect.Attack, 648),
                            new(StaticEffect.CriticalDamage, 518),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 172),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_100),
                            new(StaticEffect.Attack, 683),
                            new(StaticEffect.CriticalDamage, 547),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 177),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_500),
                            new(StaticEffect.Attack, 701),
                            new(StaticEffect.CriticalDamage, 561),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 185),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_900),
                            new(StaticEffect.Attack, 719),
                            new(StaticEffect.CriticalDamage, 575),
                            new(StaticEffect.Evade, 19),
                            new(StaticEffect.Defense, 192),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_300),
                            new(StaticEffect.Attack, 755),
                            new(StaticEffect.CriticalDamage, 604),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 200),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_700),
                            new(StaticEffect.Attack, 773),
                            new(StaticEffect.CriticalDamage, 619),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 205),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_100),
                            new(StaticEffect.Attack, 809),
                            new(StaticEffect.CriticalDamage, 647),
                            new(StaticEffect.Evade, 21),
                            new(StaticEffect.Defense, 212),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_500),
                            new(StaticEffect.Attack, 827),
                            new(StaticEffect.CriticalDamage, 662),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 220),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_900),
                            new(StaticEffect.Attack, 845),
                            new(StaticEffect.CriticalDamage, 676),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 227),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_300),
                            new(StaticEffect.Attack, 881),
                            new(StaticEffect.CriticalDamage, 705),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 232),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_700),
                            new(StaticEffect.Attack, 899),
                            new(StaticEffect.CriticalDamage, 719),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 240),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_100),
                            new(StaticEffect.Attack, 935),
                            new(StaticEffect.CriticalDamage, 748),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 247),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_500),
                            new(StaticEffect.Attack, 953),
                            new(StaticEffect.CriticalDamage, 763),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 255),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_900),
                            new(StaticEffect.Attack, 972),
                            new(StaticEffect.CriticalDamage, 777),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 260),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_300),
                            new(StaticEffect.Attack, 1_007),
                            new(StaticEffect.CriticalDamage, 806),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 267),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_700),
                            new(StaticEffect.Attack, 1_025),
                            new(StaticEffect.CriticalDamage, 820),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 275),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_100),
                            new(StaticEffect.Attack, 1_062),
                            new(StaticEffect.CriticalDamage, 849),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 282),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_500),
                            new(StaticEffect.Attack, 1_080),
                            new(StaticEffect.CriticalDamage, 864),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 287),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_900),
                            new(StaticEffect.Attack, 1_098),
                            new(StaticEffect.CriticalDamage, 878),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 295),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_300),
                            new(StaticEffect.Attack, 1_134),
                            new(StaticEffect.CriticalDamage, 907),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 302),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_700),
                            new(StaticEffect.Attack, 1_152),
                            new(StaticEffect.CriticalDamage, 921),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 310),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_100),
                            new(StaticEffect.Attack, 1_188),
                            new(StaticEffect.CriticalDamage, 950),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 315),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_500),
                            new(StaticEffect.Attack, 1_206),
                            new(StaticEffect.CriticalDamage, 964),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 322),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_900),
                            new(StaticEffect.Attack, 1_224),
                            new(StaticEffect.CriticalDamage, 979),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 330),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_300),
                            new(StaticEffect.Attack, 1_260),
                            new(StaticEffect.CriticalDamage, 1_008),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 337),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_700),
                            new(StaticEffect.Attack, 1_278),
                            new(StaticEffect.CriticalDamage, 1_022),
                            new(StaticEffect.Evade, 34),
                            new(StaticEffect.Defense, 342),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_100),
                            new(StaticEffect.Attack, 1_314),
                            new(StaticEffect.CriticalDamage, 1_051),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 350),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_500),
                            new(StaticEffect.Attack, 1_332),
                            new(StaticEffect.CriticalDamage, 1_065),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 357),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_900),
                            new(StaticEffect.Attack, 1_350),
                            new(StaticEffect.CriticalDamage, 1_080),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 365),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_300),
                            new(StaticEffect.Attack, 1_386),
                            new(StaticEffect.CriticalDamage, 1_108),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 370),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_700),
                            new(StaticEffect.Attack, 1_403),
                            new(StaticEffect.CriticalDamage, 1_123),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 377),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_100),
                            new(StaticEffect.Attack, 1_440),
                            new(StaticEffect.CriticalDamage, 1_152),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 385),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_500),
                            new(StaticEffect.Attack, 1_458),
                            new(StaticEffect.CriticalDamage, 1_166),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 392),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_900),
                            new(StaticEffect.Attack, 1_476),
                            new(StaticEffect.CriticalDamage, 1_180),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 397),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_300),
                            new(StaticEffect.Attack, 1_512),
                            new(StaticEffect.CriticalDamage, 1_209),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 405),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_700),
                            new(StaticEffect.Attack, 1_530),
                            new(StaticEffect.CriticalDamage, 1_224),
                            new(StaticEffect.Evade, 41),
                            new(StaticEffect.Defense, 412),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_100),
                            new(StaticEffect.Attack, 1_566),
                            new(StaticEffect.CriticalDamage, 1_252),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 420),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_500),
                            new(StaticEffect.Attack, 1_584),
                            new(StaticEffect.CriticalDamage, 1_267),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 425),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_900),
                            new(StaticEffect.Attack, 1_602),
                            new(StaticEffect.CriticalDamage, 1_281),
                            new(StaticEffect.Evade, 43),
                            new(StaticEffect.Defense, 432),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_300),
                            new(StaticEffect.Attack, 1_638),
                            new(StaticEffect.CriticalDamage, 1_310),
                            new(StaticEffect.Evade, 44),
                            new(StaticEffect.Defense, 440),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_700),
                            new(StaticEffect.Attack, 1_656),
                            new(StaticEffect.CriticalDamage, 1_324),
                            new(StaticEffect.Evade, 44),
                            new(StaticEffect.Defense, 447),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_100),
                            new(StaticEffect.Attack, 1_692),
                            new(StaticEffect.CriticalDamage, 1_353),
                            new(StaticEffect.Evade, 45),
                            new(StaticEffect.Defense, 452),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_500),
                            new(StaticEffect.Attack, 1_710),
                            new(StaticEffect.CriticalDamage, 1_368),
                            new(StaticEffect.Evade, 46),
                            new(StaticEffect.Defense, 460),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_900),
                            new(StaticEffect.Attack, 1_728),
                            new(StaticEffect.CriticalDamage, 1_382),
                            new(StaticEffect.Evade, 46),
                            new(StaticEffect.Defense, 467),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}