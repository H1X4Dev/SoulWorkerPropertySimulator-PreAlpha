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
                            new(StaticEffectContext.Hp, 1_150),
                            new(StaticEffectContext.Attack, 36),
                            new(StaticEffectContext.Evade, 0),
                            new(StaticEffectContext.Defense, 10),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1_600),
                            new(StaticEffectContext.Attack, 54),
                            new(StaticEffectContext.Evade, 1),
                            new(StaticEffectContext.Defense, 20),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_050),
                            new(StaticEffectContext.Attack, 90),
                            new(StaticEffectContext.Evade, 1),
                            new(StaticEffectContext.Defense, 27),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_500),
                            new(StaticEffectContext.Attack, 108),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 37),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2_950),
                            new(StaticEffectContext.Attack, 126),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 47),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_400),
                            new(StaticEffectContext.Attack, 144),
                            new(StaticEffectContext.Evade, 3),
                            new(StaticEffectContext.Defense, 57),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3_850),
                            new(StaticEffectContext.Attack, 162),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 65),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_300),
                            new(StaticEffectContext.Attack, 180),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 75),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4_750),
                            new(StaticEffectContext.Attack, 198),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 85),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_200),
                            new(StaticEffectContext.Attack, 216),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 95),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5_650),
                            new(StaticEffectContext.Attack, 252),
                            new(StaticEffectContext.Evade, 6),
                            new(StaticEffectContext.Defense, 102),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_100),
                            new(StaticEffectContext.Attack, 270),
                            new(StaticEffectContext.Evade, 6),
                            new(StaticEffectContext.Defense, 112),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6_550),
                            new(StaticEffectContext.Attack, 288),
                            new(StaticEffectContext.Evade, 7),
                            new(StaticEffectContext.Defense, 122),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_000),
                            new(StaticEffectContext.Attack, 306),
                            new(StaticEffectContext.Evade, 8),
                            new(StaticEffectContext.Defense, 132),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_450),
                            new(StaticEffectContext.Attack, 324),
                            new(StaticEffectContext.Evade, 8),
                            new(StaticEffectContext.Defense, 140),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7_900),
                            new(StaticEffectContext.Attack, 342),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 150),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_350),
                            new(StaticEffectContext.Attack, 360),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 160),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8_800),
                            new(StaticEffectContext.Attack, 378),
                            new(StaticEffectContext.Evade, 10),
                            new(StaticEffectContext.Defense, 170),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_250),
                            new(StaticEffectContext.Attack, 413),
                            new(StaticEffectContext.Evade, 10),
                            new(StaticEffectContext.Defense, 177),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9_700),
                            new(StaticEffectContext.Attack, 431),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 187),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_150),
                            new(StaticEffectContext.Attack, 450),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 197),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10_600),
                            new(StaticEffectContext.Attack, 467),
                            new(StaticEffectContext.Evade, 12),
                            new(StaticEffectContext.Defense, 207),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_050),
                            new(StaticEffectContext.Attack, 485),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 215),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_500),
                            new(StaticEffectContext.Attack, 503),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 225),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11_950),
                            new(StaticEffectContext.Attack, 522),
                            new(StaticEffectContext.Evade, 14),
                            new(StaticEffectContext.Defense, 235),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_400),
                            new(StaticEffectContext.Attack, 540),
                            new(StaticEffectContext.Evade, 14),
                            new(StaticEffectContext.Defense, 245),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12_850),
                            new(StaticEffectContext.Attack, 576),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 252),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_300),
                            new(StaticEffectContext.Attack, 594),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 262),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13_750),
                            new(StaticEffectContext.Attack, 612),
                            new(StaticEffectContext.Evade, 16),
                            new(StaticEffectContext.Defense, 272),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_200),
                            new(StaticEffectContext.Attack, 630),
                            new(StaticEffectContext.Evade, 17),
                            new(StaticEffectContext.Defense, 282),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14_650),
                            new(StaticEffectContext.Attack, 648),
                            new(StaticEffectContext.Evade, 17),
                            new(StaticEffectContext.Defense, 290),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_100),
                            new(StaticEffectContext.Attack, 666),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 300),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15_550),
                            new(StaticEffectContext.Attack, 684),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 310),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_000),
                            new(StaticEffectContext.Attack, 702),
                            new(StaticEffectContext.Evade, 19),
                            new(StaticEffectContext.Defense, 320),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_450),
                            new(StaticEffectContext.Attack, 738),
                            new(StaticEffectContext.Evade, 19),
                            new(StaticEffectContext.Defense, 327),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16_900),
                            new(StaticEffectContext.Attack, 755),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 337),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_350),
                            new(StaticEffectContext.Attack, 773),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 347),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17_800),
                            new(StaticEffectContext.Attack, 791),
                            new(StaticEffectContext.Evade, 21),
                            new(StaticEffectContext.Defense, 357),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_250),
                            new(StaticEffectContext.Attack, 810),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 365),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18_700),
                            new(StaticEffectContext.Attack, 828),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 374),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19_150),
                            new(StaticEffectContext.Attack, 846),
                            new(StaticEffectContext.Evade, 23),
                            new(StaticEffectContext.Defense, 384),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19_600),
                            new(StaticEffectContext.Attack, 864),
                            new(StaticEffectContext.Evade, 23),
                            new(StaticEffectContext.Defense, 394),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_050),
                            new(StaticEffectContext.Attack, 900),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 402),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_500),
                            new(StaticEffectContext.Attack, 918),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 412),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20_950),
                            new(StaticEffectContext.Attack, 936),
                            new(StaticEffectContext.Evade, 25),
                            new(StaticEffectContext.Defense, 422),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 21_400),
                            new(StaticEffectContext.Attack, 954),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 432),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 21_850),
                            new(StaticEffectContext.Attack, 972),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 440),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 22_300),
                            new(StaticEffectContext.Attack, 990),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 450),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 22_750),
                            new(StaticEffectContext.Attack, 1_008),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 459),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 23_200),
                            new(StaticEffectContext.Attack, 1_026),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 469),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 23_650),
                            new(StaticEffectContext.Attack, 1_062),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 477),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 24_100),
                            new(StaticEffectContext.Attack, 1_080),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 487),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 24_550),
                            new(StaticEffectContext.Attack, 1_098),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 497),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 25_000),
                            new(StaticEffectContext.Attack, 1_116),
                            new(StaticEffectContext.Evade, 30),
                            new(StaticEffectContext.Defense, 507),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 25_450),
                            new(StaticEffectContext.Attack, 1_134),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 515),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 25_900),
                            new(StaticEffectContext.Attack, 1_152),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 525),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 26_350),
                            new(StaticEffectContext.Attack, 1_170),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 535),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 26_800),
                            new(StaticEffectContext.Attack, 1_188),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 545),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 27_250),
                            new(StaticEffectContext.Attack, 1_224),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 552),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 27_700),
                            new(StaticEffectContext.Attack, 1_242),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 562),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 28_150),
                            new(StaticEffectContext.Attack, 1_260),
                            new(StaticEffectContext.Evade, 34),
                            new(StaticEffectContext.Defense, 572),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 28_600),
                            new(StaticEffectContext.Attack, 1_278),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 582),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 29_050),
                            new(StaticEffectContext.Attack, 1_296),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 590),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 29_500),
                            new(StaticEffectContext.Attack, 1_314),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 600),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 29_950),
                            new(StaticEffectContext.Attack, 1_332),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 610),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 30_400),
                            new(StaticEffectContext.Attack, 1_350),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 619),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 30_850),
                            new(StaticEffectContext.Attack, 1_386),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 627),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 31_300),
                            new(StaticEffectContext.Attack, 1_404),
                            new(StaticEffectContext.Evade, 38),
                            new(StaticEffectContext.Defense, 637),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}