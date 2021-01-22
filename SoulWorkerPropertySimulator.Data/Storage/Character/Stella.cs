using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupStella() =>
            new("史黛拉",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_100),
                            new(StaticEffect.Attack, 54),
                            new(StaticEffect.CriticalDamage, 43),
                            new(StaticEffect.Evade, 0),
                            new(StaticEffect.Defense, 5),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_400),
                            new(StaticEffect.Attack, 72),
                            new(StaticEffect.CriticalDamage, 57),
                            new(StaticEffect.Evade, 1),
                            new(StaticEffect.Defense, 10),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffect.Hp, 1_700),
                            new(StaticEffect.Attack, 108),
                            new(StaticEffect.CriticalDamage, 86),
                            new(StaticEffect.Evade, 2),
                            new(StaticEffect.Defense, 15),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_000),
                            new(StaticEffect.Attack, 126),
                            new(StaticEffect.CriticalDamage, 100),
                            new(StaticEffect.Evade, 2),
                            new(StaticEffect.Defense, 20),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_300),
                            new(StaticEffect.Attack, 144),
                            new(StaticEffect.CriticalDamage, 115),
                            new(StaticEffect.Evade, 3),
                            new(StaticEffect.Defense, 25),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_600),
                            new(StaticEffect.Attack, 180),
                            new(StaticEffect.CriticalDamage, 144),
                            new(StaticEffect.Evade, 4),
                            new(StaticEffect.Defense, 30),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffect.Hp, 2_900),
                            new(StaticEffect.Attack, 198),
                            new(StaticEffect.CriticalDamage, 158),
                            new(StaticEffect.Evade, 4),
                            new(StaticEffect.Defense, 35),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_200),
                            new(StaticEffect.Attack, 216),
                            new(StaticEffect.CriticalDamage, 172),
                            new(StaticEffect.Evade, 5),
                            new(StaticEffect.Defense, 40),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_500),
                            new(StaticEffect.Attack, 252),
                            new(StaticEffect.CriticalDamage, 201),
                            new(StaticEffect.Evade, 6),
                            new(StaticEffect.Defense, 45),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffect.Hp, 3_800),
                            new(StaticEffect.Attack, 270),
                            new(StaticEffect.CriticalDamage, 216),
                            new(StaticEffect.Evade, 7),
                            new(StaticEffect.Defense, 50),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffect.Hp, 4_100),
                            new(StaticEffect.Attack, 306),
                            new(StaticEffect.CriticalDamage, 244),
                            new(StaticEffect.Evade, 7),
                            new(StaticEffect.Defense, 55),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffect.Hp, 4_400),
                            new(StaticEffect.Attack, 324),
                            new(StaticEffect.CriticalDamage, 259),
                            new(StaticEffect.Evade, 8),
                            new(StaticEffect.Defense, 60),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffect.Hp, 4_700),
                            new(StaticEffect.Attack, 342),
                            new(StaticEffect.CriticalDamage, 273),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 65),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_000),
                            new(StaticEffect.Attack, 378),
                            new(StaticEffect.CriticalDamage, 302),
                            new(StaticEffect.Evade, 9),
                            new(StaticEffect.Defense, 70),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_300),
                            new(StaticEffect.Attack, 396),
                            new(StaticEffect.CriticalDamage, 316),
                            new(StaticEffect.Evade, 10),
                            new(StaticEffect.Defense, 75),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_600),
                            new(StaticEffect.Attack, 414),
                            new(StaticEffect.CriticalDamage, 331),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 80),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffect.Hp, 5_900),
                            new(StaticEffect.Attack, 450),
                            new(StaticEffect.CriticalDamage, 360),
                            new(StaticEffect.Evade, 11),
                            new(StaticEffect.Defense, 85),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_200),
                            new(StaticEffect.Attack, 468),
                            new(StaticEffect.CriticalDamage, 374),
                            new(StaticEffect.Evade, 12),
                            new(StaticEffect.Defense, 90),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_500),
                            new(StaticEffect.Attack, 503),
                            new(StaticEffect.CriticalDamage, 403),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 95),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffect.Hp, 6_800),
                            new(StaticEffect.Attack, 521),
                            new(StaticEffect.CriticalDamage, 417),
                            new(StaticEffect.Evade, 13),
                            new(StaticEffect.Defense, 100),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_100),
                            new(StaticEffect.Attack, 539),
                            new(StaticEffect.CriticalDamage, 431),
                            new(StaticEffect.Evade, 14),
                            new(StaticEffect.Defense, 105),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_400),
                            new(StaticEffect.Attack, 576),
                            new(StaticEffect.CriticalDamage, 460),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 110),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffect.Hp, 7_700),
                            new(StaticEffect.Attack, 594),
                            new(StaticEffect.CriticalDamage, 475),
                            new(StaticEffect.Evade, 15),
                            new(StaticEffect.Defense, 115),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_000),
                            new(StaticEffect.Attack, 612),
                            new(StaticEffect.CriticalDamage, 489),
                            new(StaticEffect.Evade, 16),
                            new(StaticEffect.Defense, 120),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_300),
                            new(StaticEffect.Attack, 648),
                            new(StaticEffect.CriticalDamage, 518),
                            new(StaticEffect.Evade, 17),
                            new(StaticEffect.Defense, 125),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_600),
                            new(StaticEffect.Attack, 666),
                            new(StaticEffect.CriticalDamage, 532),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 130),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffect.Hp, 8_900),
                            new(StaticEffect.Attack, 702),
                            new(StaticEffect.CriticalDamage, 561),
                            new(StaticEffect.Evade, 18),
                            new(StaticEffect.Defense, 135),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_200),
                            new(StaticEffect.Attack, 720),
                            new(StaticEffect.CriticalDamage, 576),
                            new(StaticEffect.Evade, 19),
                            new(StaticEffect.Defense, 140),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_500),
                            new(StaticEffect.Attack, 738),
                            new(StaticEffect.CriticalDamage, 590),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 145),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffect.Hp, 9_800),
                            new(StaticEffect.Attack, 774),
                            new(StaticEffect.CriticalDamage, 619),
                            new(StaticEffect.Evade, 20),
                            new(StaticEffect.Defense, 150),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_100),
                            new(StaticEffect.Attack, 792),
                            new(StaticEffect.CriticalDamage, 633),
                            new(StaticEffect.Evade, 21),
                            new(StaticEffect.Defense, 155),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_400),
                            new(StaticEffect.Attack, 809),
                            new(StaticEffect.CriticalDamage, 647),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 160),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffect.Hp, 10_700),
                            new(StaticEffect.Attack, 845),
                            new(StaticEffect.CriticalDamage, 676),
                            new(StaticEffect.Evade, 22),
                            new(StaticEffect.Defense, 165),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_000),
                            new(StaticEffect.Attack, 863),
                            new(StaticEffect.CriticalDamage, 691),
                            new(StaticEffect.Evade, 23),
                            new(StaticEffect.Defense, 170),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_300),
                            new(StaticEffect.Attack, 899),
                            new(StaticEffect.CriticalDamage, 719),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 175),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_600),
                            new(StaticEffect.Attack, 917),
                            new(StaticEffect.CriticalDamage, 734),
                            new(StaticEffect.Evade, 24),
                            new(StaticEffect.Defense, 180),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffect.Hp, 11_900),
                            new(StaticEffect.Attack, 936),
                            new(StaticEffect.CriticalDamage, 748),
                            new(StaticEffect.Evade, 25),
                            new(StaticEffect.Defense, 185),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_200),
                            new(StaticEffect.Attack, 971),
                            new(StaticEffect.CriticalDamage, 777),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 190),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_500),
                            new(StaticEffect.Attack, 990),
                            new(StaticEffect.CriticalDamage, 792),
                            new(StaticEffect.Evade, 26),
                            new(StaticEffect.Defense, 195),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffect.Hp, 12_800),
                            new(StaticEffect.Attack, 1_008),
                            new(StaticEffect.CriticalDamage, 806),
                            new(StaticEffect.Evade, 27),
                            new(StaticEffect.Defense, 200),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_100),
                            new(StaticEffect.Attack, 1_044),
                            new(StaticEffect.CriticalDamage, 835),
                            new(StaticEffect.Evade, 28),
                            new(StaticEffect.Defense, 205),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_400),
                            new(StaticEffect.Attack, 1_062),
                            new(StaticEffect.CriticalDamage, 849),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 210),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffect.Hp, 13_700),
                            new(StaticEffect.Attack, 1_098),
                            new(StaticEffect.CriticalDamage, 878),
                            new(StaticEffect.Evade, 29),
                            new(StaticEffect.Defense, 215),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_000),
                            new(StaticEffect.Attack, 1_116),
                            new(StaticEffect.CriticalDamage, 892),
                            new(StaticEffect.Evade, 30),
                            new(StaticEffect.Defense, 220),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_300),
                            new(StaticEffect.Attack, 1_134),
                            new(StaticEffect.CriticalDamage, 907),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 225),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_600),
                            new(StaticEffect.Attack, 1_170),
                            new(StaticEffect.CriticalDamage, 936),
                            new(StaticEffect.Evade, 31),
                            new(StaticEffect.Defense, 230),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffect.Hp, 14_900),
                            new(StaticEffect.Attack, 1_188),
                            new(StaticEffect.CriticalDamage, 950),
                            new(StaticEffect.Evade, 32),
                            new(StaticEffect.Defense, 235),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_200),
                            new(StaticEffect.Attack, 1_206),
                            new(StaticEffect.CriticalDamage, 964),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 240),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_500),
                            new(StaticEffect.Attack, 1_242),
                            new(StaticEffect.CriticalDamage, 993),
                            new(StaticEffect.Evade, 33),
                            new(StaticEffect.Defense, 245),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffect.Hp, 15_800),
                            new(StaticEffect.Attack, 1_260),
                            new(StaticEffect.CriticalDamage, 1_008),
                            new(StaticEffect.Evade, 34),
                            new(StaticEffect.Defense, 250),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_100),
                            new(StaticEffect.Attack, 1_296),
                            new(StaticEffect.CriticalDamage, 1_036),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 255),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_400),
                            new(StaticEffect.Attack, 1_314),
                            new(StaticEffect.CriticalDamage, 1_051),
                            new(StaticEffect.Evade, 35),
                            new(StaticEffect.Defense, 260),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffect.Hp, 16_700),
                            new(StaticEffect.Attack, 1_331),
                            new(StaticEffect.CriticalDamage, 1_065),
                            new(StaticEffect.Evade, 36),
                            new(StaticEffect.Defense, 265),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_000),
                            new(StaticEffect.Attack, 1_368),
                            new(StaticEffect.CriticalDamage, 1_094),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 270),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_300),
                            new(StaticEffect.Attack, 1_386),
                            new(StaticEffect.CriticalDamage, 1_108),
                            new(StaticEffect.Evade, 37),
                            new(StaticEffect.Defense, 275),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_600),
                            new(StaticEffect.Attack, 1_404),
                            new(StaticEffect.CriticalDamage, 1_123),
                            new(StaticEffect.Evade, 38),
                            new(StaticEffect.Defense, 279),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffect.Hp, 17_900),
                            new(StaticEffect.Attack, 1_440),
                            new(StaticEffect.CriticalDamage, 1_152),
                            new(StaticEffect.Evade, 39),
                            new(StaticEffect.Defense, 284),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_200),
                            new(StaticEffect.Attack, 1_458),
                            new(StaticEffect.CriticalDamage, 1_166),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 289),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_500),
                            new(StaticEffect.Attack, 1_494),
                            new(StaticEffect.CriticalDamage, 1_195),
                            new(StaticEffect.Evade, 40),
                            new(StaticEffect.Defense, 294),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffect.Hp, 18_800),
                            new(StaticEffect.Attack, 1_512),
                            new(StaticEffect.CriticalDamage, 1_209),
                            new(StaticEffect.Evade, 41),
                            new(StaticEffect.Defense, 299),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_100),
                            new(StaticEffect.Attack, 1_530),
                            new(StaticEffect.CriticalDamage, 1_224),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 305),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_400),
                            new(StaticEffect.Attack, 1_566),
                            new(StaticEffect.CriticalDamage, 1_252),
                            new(StaticEffect.Evade, 42),
                            new(StaticEffect.Defense, 310),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffect.Hp, 19_700),
                            new(StaticEffect.Attack, 1_584),
                            new(StaticEffect.CriticalDamage, 1_267),
                            new(StaticEffect.Evade, 43),
                            new(StaticEffect.Defense, 315),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_000),
                            new(StaticEffect.Attack, 1_602),
                            new(StaticEffect.CriticalDamage, 1_281),
                            new(StaticEffect.Evade, 44),
                            new(StaticEffect.Defense, 320),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_300),
                            new(StaticEffect.Attack, 1_638),
                            new(StaticEffect.CriticalDamage, 1_310),
                            new(StaticEffect.Evade, 44),
                            new(StaticEffect.Defense, 325),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_600),
                            new(StaticEffect.Attack, 1_656),
                            new(StaticEffect.CriticalDamage, 1_324),
                            new(StaticEffect.Evade, 45),
                            new(StaticEffect.Defense, 329),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffect.Hp, 20_900),
                            new(StaticEffect.Attack, 1_692),
                            new(StaticEffect.CriticalDamage, 1_353),
                            new(StaticEffect.Evade, 46),
                            new(StaticEffect.Defense, 334),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffect.Hp, 21_200),
                            new(StaticEffect.Attack, 1_710),
                            new(StaticEffect.CriticalDamage, 1_368),
                            new(StaticEffect.Evade, 46),
                            new(StaticEffect.Defense, 339),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}