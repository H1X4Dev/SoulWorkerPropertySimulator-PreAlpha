using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupJin() =>
            new("金",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_150),
                            new(StaticEffect.Attack, 36),
                            new(StaticEffect.CriticalDamage, 28),
                            new(StaticEffect.Evade, 0),
                            new(StaticEffect.Defense, 10),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_600),
                            new(StaticEffect.Attack, 54),
                            new(StaticEffect.CriticalDamage, 43),
                            new(StaticEffect.Evade, 1),
                            new(StaticEffect.Defense, 20),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_050),
                            new(StaticEffect.Attack, 90),
                            new(StaticEffect.CriticalDamage, 72),
                            new(StaticEffect.Evade, 1),
                            new(StaticEffect.Defense, 27),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_500),
                            new(StaticEffect.Attack, 108),
                            new(StaticEffect.CriticalDamage, 86),
                            new(StaticEffect.Evade, 2),
                            new(StaticEffect.Defense, 37),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_950),
                            new(StaticEffect.Attack, 126),
                            new(StaticEffect.CriticalDamage, 100),
                            new(StaticEffect.Evade, 2),
                            new(StaticEffect.Defense, 47),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_400),
                            new(StaticEffect.Attack, 144),
                            new(StaticEffect.CriticalDamage, 115),
                            new(StaticEffect.Evade, 3),
                            new(StaticEffect.Defense, 57),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_850),
                            new(StaticEffect.Attack, 162),
                            new(StaticEffect.CriticalDamage, 129),
                            new(StaticEffect.Evade, 4),
                            new(StaticEffect.Defense, 65),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffect.Hp, 4_300),
                            new(StaticEffect.Attack, 180),
                            new(StaticEffect.CriticalDamage, 144),
                            new(StaticEffect.Evade, 4),
                            new(StaticEffect.Defense, 75),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffect.Hp, 4_750),
                            new(StaticEffect.Attack, 198),
                            new(StaticEffect.CriticalDamage, 158),
                            new(StaticEffect.Evade, 5),
                            new(StaticEffect.Defense, 85),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_200),
                            new(StaticEffect.Attack, 216),
                            new(StaticEffect.CriticalDamage, 172),
                            new(StaticEffect.Evade, 5),
                            new(StaticEffect.Defense, 95),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_650),
                            new(StaticEffect.Attack, 252),
                            new(StaticEffect.CriticalDamage, 201),
                            new(StaticEffect.Evade, 6),
                            new(StaticEffect.Defense, 102),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_100),
                            new(StaticEffect.Attack, 270),
                            new(StaticEffect.CriticalDamage, 216),
                            new(StaticEffect.Evade, 6),
                            new(StaticEffect.Defense, 112),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_550),
                            new(StaticEffect.Attack, 288),
                            new(StaticEffect.CriticalDamage, 230),
                            new(StaticEffect.Evade, 7),
                            new(StaticEffect.Defense, 122),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_000),
                            new(StaticEffect.Attack, 306),
                            new(StaticEffect.CriticalDamage, 244),
                            new(StaticEffect.Evade, 8),
                            new(StaticEffect.Defense, 132),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_450),
                            new(StaticEffect.Attack, 324),
                            new(StaticEffect.CriticalDamage, 259),
                            new(StaticEffect.Evade, 8),
                            new(StaticEffect.Defense, 140),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_900),
                            new(StaticEffect.Attack, 342),
                            new(StaticEffect.CriticalDamage, 273),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 150),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_350),
                            new(StaticEffect.Attack, 360),
                            new(StaticEffect.CriticalDamage, 288),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 160),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_800),
                            new(StaticEffect.Attack, 378),
                            new(StaticEffect.CriticalDamage, 302),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 170),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_250),
                            new(StaticEffect.Attack, 413),
                            new(StaticEffect.CriticalDamage, 331),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 177),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_700),
                            new(StaticEffect.Attack, 431),
                            new(StaticEffect.CriticalDamage, 345),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 187),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_150),
                            new(StaticEffect.Attack, 450),
                            new(StaticEffect.CriticalDamage, 360),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 197),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_600),
                            new(StaticEffect.Attack, 467),
                            new(StaticEffect.CriticalDamage, 374),
                            new(StaticEffect.Evade, 12),
                            new(StaticEffect.Defense, 207),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_050),
                            new(StaticEffect.Attack, 485),
                            new(StaticEffect.CriticalDamage, 388),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 215),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_500),
                            new(StaticEffect.Attack, 503),
                            new(StaticEffect.CriticalDamage, 403),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 225),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_950),
                            new(StaticEffect.Attack, 522),
                            new(StaticEffect.CriticalDamage, 417),
                            new(StaticEffect.Evade, 14),
                            new(StaticEffect.Defense, 235),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_400),
                            new(StaticEffect.Attack, 540),
                            new(StaticEffect.CriticalDamage, 432),
                            new(StaticEffect.Evade, 14),
                            new(StaticEffect.Defense, 245),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_850),
                            new(StaticEffect.Attack, 576),
                            new(StaticEffect.CriticalDamage, 460),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 252),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_300),
                            new(StaticEffect.Attack, 594),
                            new(StaticEffect.CriticalDamage, 475),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 262),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_750),
                            new(StaticEffect.Attack, 612),
                            new(StaticEffect.CriticalDamage, 489),
                            new(StaticEffect.Evade, 16),
                            new(StaticEffect.Defense, 272),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_200),
                            new(StaticEffect.Attack, 630),
                            new(StaticEffect.CriticalDamage, 504),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 282),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_650),
                            new(StaticEffect.Attack, 648),
                            new(StaticEffect.CriticalDamage, 518),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 290),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_100),
                            new(StaticEffect.Attack, 666),
                            new(StaticEffect.CriticalDamage, 532),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 300),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_550),
                            new(StaticEffect.Attack, 684),
                            new(StaticEffect.CriticalDamage, 547),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 310),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_000),
                            new(StaticEffect.Attack, 702),
                            new(StaticEffect.CriticalDamage, 561),
                            new(StaticEffect.Evade, 19),
                            new(StaticEffect.Defense, 320),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_450),
                            new(StaticEffect.Attack, 738),
                            new(StaticEffect.CriticalDamage, 590),
                            new(StaticEffect.Evade, 19),
                            new(StaticEffect.Defense, 327),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_900),
                            new(StaticEffect.Attack, 755),
                            new(StaticEffect.CriticalDamage, 604),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 337),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_350),
                            new(StaticEffect.Attack, 773),
                            new(StaticEffect.CriticalDamage, 619),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 347),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_800),
                            new(StaticEffect.Attack, 791),
                            new(StaticEffect.CriticalDamage, 633),
                            new(StaticEffect.Evade, 21),
                            new(StaticEffect.Defense, 357),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_250),
                            new(StaticEffect.Attack, 810),
                            new(StaticEffect.CriticalDamage, 648),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 365),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_700),
                            new(StaticEffect.Attack, 828),
                            new(StaticEffect.CriticalDamage, 662),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 374),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_150),
                            new(StaticEffect.Attack, 846),
                            new(StaticEffect.CriticalDamage, 676),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 384),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_600),
                            new(StaticEffect.Attack, 864),
                            new(StaticEffect.CriticalDamage, 691),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 394),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_050),
                            new(StaticEffect.Attack, 900),
                            new(StaticEffect.CriticalDamage, 720),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 402),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_500),
                            new(StaticEffect.Attack, 918),
                            new(StaticEffect.CriticalDamage, 734),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 412),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_950),
                            new(StaticEffect.Attack, 936),
                            new(StaticEffect.CriticalDamage, 748),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 422),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_400),
                            new(StaticEffect.Attack, 954),
                            new(StaticEffect.CriticalDamage, 763),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 432),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_850),
                            new(StaticEffect.Attack, 972),
                            new(StaticEffect.CriticalDamage, 777),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 440),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_300),
                            new(StaticEffect.Attack, 990),
                            new(StaticEffect.CriticalDamage, 792),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 450),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffect.Hp, 22_750),
                            new(StaticEffect.Attack, 1_008),
                            new(StaticEffect.CriticalDamage, 806),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 459),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_200),
                            new(StaticEffect.Attack, 1_026),
                            new(StaticEffect.CriticalDamage, 820),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 469),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffect.Hp, 23_650),
                            new(StaticEffect.Attack, 1_062),
                            new(StaticEffect.CriticalDamage, 849),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 477),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_100),
                            new(StaticEffect.Attack, 1_080),
                            new(StaticEffect.CriticalDamage, 864),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 487),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffect.Hp, 24_550),
                            new(StaticEffect.Attack, 1_098),
                            new(StaticEffect.CriticalDamage, 878),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 497),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_000),
                            new(StaticEffect.Attack, 1_116),
                            new(StaticEffect.CriticalDamage, 892),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 507),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_450),
                            new(StaticEffect.Attack, 1_134),
                            new(StaticEffect.CriticalDamage, 907),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 515),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffect.Hp, 25_900),
                            new(StaticEffect.Attack, 1_152),
                            new(StaticEffect.CriticalDamage, 921),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 525),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_350),
                            new(StaticEffect.Attack, 1_170),
                            new(StaticEffect.CriticalDamage, 936),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 535),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffect.Hp, 26_800),
                            new(StaticEffect.Attack, 1_188),
                            new(StaticEffect.CriticalDamage, 950),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 545),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_250),
                            new(StaticEffect.Attack, 1_224),
                            new(StaticEffect.CriticalDamage, 979),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 552),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffect.Hp, 27_700),
                            new(StaticEffect.Attack, 1_242),
                            new(StaticEffect.CriticalDamage, 993),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 562),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffect.Hp, 28_150),
                            new(StaticEffect.Attack, 1_260),
                            new(StaticEffect.CriticalDamage, 1_008),
                            new(StaticEffect.Evade, 34),
                            new(StaticEffect.Defense, 572),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffect.Hp, 28_600),
                            new(StaticEffect.Attack, 1_278),
                            new(StaticEffect.CriticalDamage, 1_022),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 582),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffect.Hp, 29_050),
                            new(StaticEffect.Attack, 1_296),
                            new(StaticEffect.CriticalDamage, 1_036),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 590),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffect.Hp, 29_500),
                            new(StaticEffect.Attack, 1_314),
                            new(StaticEffect.CriticalDamage, 1_051),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 600),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffect.Hp, 29_950),
                            new(StaticEffect.Attack, 1_332),
                            new(StaticEffect.CriticalDamage, 1_065),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 610),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffect.Hp, 30_400),
                            new(StaticEffect.Attack, 1_350),
                            new(StaticEffect.CriticalDamage, 1_080),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 619),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffect.Hp, 30_850),
                            new(StaticEffect.Attack, 1_386),
                            new(StaticEffect.CriticalDamage, 1_108),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 627),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffect.Hp, 31_300),
                            new(StaticEffect.Attack, 1_404),
                            new(StaticEffect.CriticalDamage, 1_123),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 637),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}