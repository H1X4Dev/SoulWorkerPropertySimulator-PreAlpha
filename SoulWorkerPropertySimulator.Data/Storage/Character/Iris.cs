using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Iris { get; } = new("伊莉絲",
            new Dictionary<int, IReadOnlyCollection<Effect>>
            {
                {
                    1,
                    new[]
                    {
                        new(Static.Hp, 1_100),
                        new(Static.Attack, 54),
                        new(Static.CriticalDamage, 43),
                        new(Static.Evade, 0),
                        new(Static.Defense, 7),
                        AccuracyList[0]
                    }
                },
                {
                    2,
                    new[]
                    {
                        new(Static.Hp, 1_350),
                        new(Static.Attack, 90),
                        new(Static.CriticalDamage, 72),
                        new(Static.Evade, 1),
                        new(Static.Defense, 12),
                        AccuracyList[1]
                    }
                },
                {
                    3,
                    new[]
                    {
                        new(Static.Hp, 1_600),
                        new(Static.Attack, 108),
                        new(Static.CriticalDamage, 86),
                        new(Static.Evade, 1),
                        new(Static.Defense, 20),
                        AccuracyList[2]
                    }
                },
                {
                    4,
                    new[]
                    {
                        new(Static.Hp, 1_850),
                        new(Static.Attack, 144),
                        new(Static.CriticalDamage, 115),
                        new(Static.Evade, 2),
                        new(Static.Defense, 25),
                        AccuracyList[3]
                    }
                },
                {
                    5,
                    new[]
                    {
                        new(Static.Hp, 2_100),
                        new(Static.Attack, 162),
                        new(Static.CriticalDamage, 129),
                        new(Static.Evade, 2),
                        new(Static.Defense, 32),
                        AccuracyList[4]
                    }
                },
                {
                    6,
                    new[]
                    {
                        new(Static.Hp, 2_350),
                        new(Static.Attack, 198),
                        new(Static.CriticalDamage, 158),
                        new(Static.Evade, 3),
                        new(Static.Defense, 37),
                        AccuracyList[5]
                    }
                },
                {
                    7,
                    new[]
                    {
                        new(Static.Hp, 2_600),
                        new(Static.Attack, 216),
                        new(Static.CriticalDamage, 172),
                        new(Static.Evade, 4),
                        new(Static.Defense, 45),
                        AccuracyList[6]
                    }
                },
                {
                    8,
                    new[]
                    {
                        new(Static.Hp, 2_850),
                        new(Static.Attack, 252),
                        new(Static.CriticalDamage, 201),
                        new(Static.Evade, 4),
                        new(Static.Defense, 50),
                        AccuracyList[7]
                    }
                },
                {
                    9,
                    new[]
                    {
                        new(Static.Hp, 3_100),
                        new(Static.Attack, 270),
                        new(Static.CriticalDamage, 216),
                        new(Static.Evade, 5),
                        new(Static.Defense, 57),
                        AccuracyList[8]
                    }
                },
                {
                    10,
                    new[]
                    {
                        new(Static.Hp, 3_350),
                        new(Static.Attack, 306),
                        new(Static.CriticalDamage, 244),
                        new(Static.Evade, 5),
                        new(Static.Defense, 62),
                        AccuracyList[9]
                    }
                },
                {
                    11,
                    new[]
                    {
                        new(Static.Hp, 3_600),
                        new(Static.Attack, 324),
                        new(Static.CriticalDamage, 259),
                        new(Static.Evade, 6),
                        new(Static.Defense, 70),
                        AccuracyList[10]
                    }
                },
                {
                    12,
                    new[]
                    {
                        new(Static.Hp, 3_850),
                        new(Static.Attack, 360),
                        new(Static.CriticalDamage, 288),
                        new(Static.Evade, 6),
                        new(Static.Defense, 75),
                        AccuracyList[11]
                    }
                },
                {
                    13,
                    new[]
                    {
                        new(Static.Hp, 4_100),
                        new(Static.Attack, 378),
                        new(Static.CriticalDamage, 302),
                        new(Static.Evade, 7),
                        new(Static.Defense, 82),
                        AccuracyList[12]
                    }
                },
                {
                    14,
                    new[]
                    {
                        new(Static.Hp, 4_350),
                        new(Static.Attack, 414),
                        new(Static.CriticalDamage, 331),
                        new(Static.Evade, 8),
                        new(Static.Defense, 87),
                        AccuracyList[13]
                    }
                },
                {
                    15,
                    new[]
                    {
                        new(Static.Hp, 4_600),
                        new(Static.Attack, 432),
                        new(Static.CriticalDamage, 345),
                        new(Static.Evade, 8),
                        new(Static.Defense, 95),
                        AccuracyList[14]
                    }
                },
                {
                    16,
                    new[]
                    {
                        new(Static.Hp, 4_850),
                        new(Static.Attack, 468),
                        new(Static.CriticalDamage, 374),
                        new(Static.Evade, 9),
                        new(Static.Defense, 100),
                        AccuracyList[15]
                    }
                },
                {
                    17,
                    new[]
                    {
                        new(Static.Hp, 5_100),
                        new(Static.Attack, 485),
                        new(Static.CriticalDamage, 388),
                        new(Static.Evade, 9),
                        new(Static.Defense, 107),
                        AccuracyList[16]
                    }
                },
                {
                    18,
                    new[]
                    {
                        new(Static.Hp, 5_350),
                        new(Static.Attack, 522),
                        new(Static.CriticalDamage, 417),
                        new(Static.Evade, 10),
                        new(Static.Defense, 112),
                        AccuracyList[17]
                    }
                },
                {
                    19,
                    new[]
                    {
                        new(Static.Hp, 5_600),
                        new(Static.Attack, 540),
                        new(Static.CriticalDamage, 432),
                        new(Static.Evade, 10),
                        new(Static.Defense, 120),
                        AccuracyList[18]
                    }
                },
                {
                    20,
                    new[]
                    {
                        new(Static.Hp, 5_850),
                        new(Static.Attack, 576),
                        new(Static.CriticalDamage, 460),
                        new(Static.Evade, 11),
                        new(Static.Defense, 125),
                        AccuracyList[19]
                    }
                },
                {
                    21,
                    new[]
                    {
                        new(Static.Hp, 6_100),
                        new(Static.Attack, 594),
                        new(Static.CriticalDamage, 475),
                        new(Static.Evade, 11),
                        new(Static.Defense, 132),
                        AccuracyList[20]
                    }
                },
                {
                    22,
                    new[]
                    {
                        new(Static.Hp, 6_350),
                        new(Static.Attack, 630),
                        new(Static.CriticalDamage, 504),
                        new(Static.Evade, 12),
                        new(Static.Defense, 137),
                        AccuracyList[21]
                    }
                },
                {
                    23,
                    new[]
                    {
                        new(Static.Hp, 6_600),
                        new(Static.Attack, 648),
                        new(Static.CriticalDamage, 518),
                        new(Static.Evade, 13),
                        new(Static.Defense, 145),
                        AccuracyList[22]
                    }
                },
                {
                    24,
                    new[]
                    {
                        new(Static.Hp, 6_850),
                        new(Static.Attack, 684),
                        new(Static.CriticalDamage, 547),
                        new(Static.Evade, 13),
                        new(Static.Defense, 150),
                        AccuracyList[23]
                    }
                },
                {
                    25,
                    new[]
                    {
                        new(Static.Hp, 7_100),
                        new(Static.Attack, 702),
                        new(Static.CriticalDamage, 561),
                        new(Static.Evade, 14),
                        new(Static.Defense, 157),
                        AccuracyList[24]
                    }
                },
                {
                    26,
                    new[]
                    {
                        new(Static.Hp, 7_350),
                        new(Static.Attack, 738),
                        new(Static.CriticalDamage, 590),
                        new(Static.Evade, 14),
                        new(Static.Defense, 162),
                        AccuracyList[25]
                    }
                },
                {
                    27,
                    new[]
                    {
                        new(Static.Hp, 7_600),
                        new(Static.Attack, 756),
                        new(Static.CriticalDamage, 604),
                        new(Static.Evade, 15),
                        new(Static.Defense, 170),
                        AccuracyList[26]
                    }
                },
                {
                    28,
                    new[]
                    {
                        new(Static.Hp, 7_850),
                        new(Static.Attack, 792),
                        new(Static.CriticalDamage, 633),
                        new(Static.Evade, 15),
                        new(Static.Defense, 175),
                        AccuracyList[27]
                    }
                },
                {
                    29,
                    new[]
                    {
                        new(Static.Hp, 8_100),
                        new(Static.Attack, 810),
                        new(Static.CriticalDamage, 648),
                        new(Static.Evade, 16),
                        new(Static.Defense, 182),
                        AccuracyList[28]
                    }
                },
                {
                    30,
                    new[]
                    {
                        new(Static.Hp, 8_350),
                        new(Static.Attack, 846),
                        new(Static.CriticalDamage, 676),
                        new(Static.Evade, 17),
                        new(Static.Defense, 187),
                        AccuracyList[29]
                    }
                },
                {
                    31,
                    new[]
                    {
                        new(Static.Hp, 8_600),
                        new(Static.Attack, 864),
                        new(Static.CriticalDamage, 691),
                        new(Static.Evade, 17),
                        new(Static.Defense, 195),
                        AccuracyList[30]
                    }
                },
                {
                    32,
                    new[]
                    {
                        new(Static.Hp, 8_850),
                        new(Static.Attack, 900),
                        new(Static.CriticalDamage, 720),
                        new(Static.Evade, 18),
                        new(Static.Defense, 200),
                        AccuracyList[31]
                    }
                },
                {
                    33,
                    new[]
                    {
                        new(Static.Hp, 9_100),
                        new(Static.Attack, 918),
                        new(Static.CriticalDamage, 734),
                        new(Static.Evade, 18),
                        new(Static.Defense, 207),
                        AccuracyList[32]
                    }
                },
                {
                    34,
                    new[]
                    {
                        new(Static.Hp, 9_350),
                        new(Static.Attack, 954),
                        new(Static.CriticalDamage, 763),
                        new(Static.Evade, 19),
                        new(Static.Defense, 212),
                        AccuracyList[33]
                    }
                },
                {
                    35,
                    new[]
                    {
                        new(Static.Hp, 9_600),
                        new(Static.Attack, 971),
                        new(Static.CriticalDamage, 777),
                        new(Static.Evade, 19),
                        new(Static.Defense, 220),
                        AccuracyList[34]
                    }
                },
                {
                    36,
                    new[]
                    {
                        new(Static.Hp, 9_850),
                        new(Static.Attack, 1_007),
                        new(Static.CriticalDamage, 806),
                        new(Static.Evade, 20),
                        new(Static.Defense, 225),
                        AccuracyList[35]
                    }
                },
                {
                    37,
                    new[]
                    {
                        new(Static.Hp, 10_100),
                        new(Static.Attack, 1_025),
                        new(Static.CriticalDamage, 820),
                        new(Static.Evade, 20),
                        new(Static.Defense, 232),
                        AccuracyList[36]
                    }
                },
                {
                    38,
                    new[]
                    {
                        new(Static.Hp, 10_350),
                        new(Static.Attack, 1_061),
                        new(Static.CriticalDamage, 849),
                        new(Static.Evade, 21),
                        new(Static.Defense, 237),
                        AccuracyList[37]
                    }
                },
                {
                    39,
                    new[]
                    {
                        new(Static.Hp, 10_600),
                        new(Static.Attack, 1_079),
                        new(Static.CriticalDamage, 863),
                        new(Static.Evade, 22),
                        new(Static.Defense, 245),
                        AccuracyList[38]
                    }
                },
                {
                    40,
                    new[]
                    {
                        new(Static.Hp, 10_850),
                        new(Static.Attack, 1_115),
                        new(Static.CriticalDamage, 892),
                        new(Static.Evade, 22),
                        new(Static.Defense, 250),
                        AccuracyList[39]
                    }
                },
                {
                    41,
                    new[]
                    {
                        new(Static.Hp, 11_100),
                        new(Static.Attack, 1_133),
                        new(Static.CriticalDamage, 907),
                        new(Static.Evade, 23),
                        new(Static.Defense, 257),
                        AccuracyList[40]
                    }
                },
                {
                    42,
                    new[]
                    {
                        new(Static.Hp, 11_350),
                        new(Static.Attack, 1_170),
                        new(Static.CriticalDamage, 936),
                        new(Static.Evade, 23),
                        new(Static.Defense, 262),
                        AccuracyList[41]
                    }
                },
                {
                    43,
                    new[]
                    {
                        new(Static.Hp, 11_600),
                        new(Static.Attack, 1_187),
                        new(Static.CriticalDamage, 950),
                        new(Static.Evade, 24),
                        new(Static.Defense, 270),
                        AccuracyList[42]
                    }
                },
                {
                    44,
                    new[]
                    {
                        new(Static.Hp, 11_850),
                        new(Static.Attack, 1_224),
                        new(Static.CriticalDamage, 979),
                        new(Static.Evade, 24),
                        new(Static.Defense, 275),
                        AccuracyList[43]
                    }
                },
                {
                    45,
                    new[]
                    {
                        new(Static.Hp, 12_100),
                        new(Static.Attack, 1_242),
                        new(Static.CriticalDamage, 993),
                        new(Static.Evade, 25),
                        new(Static.Defense, 282),
                        AccuracyList[44]
                    }
                },
                {
                    46,
                    new[]
                    {
                        new(Static.Hp, 12_350),
                        new(Static.Attack, 1_277),
                        new(Static.CriticalDamage, 1_022),
                        new(Static.Evade, 26),
                        new(Static.Defense, 287),
                        AccuracyList[45]
                    }
                },
                {
                    47,
                    new[]
                    {
                        new(Static.Hp, 12_600),
                        new(Static.Attack, 1_295),
                        new(Static.CriticalDamage, 1_036),
                        new(Static.Evade, 26),
                        new(Static.Defense, 295),
                        AccuracyList[46]
                    }
                },
                {
                    48,
                    new[]
                    {
                        new(Static.Hp, 12_850),
                        new(Static.Attack, 1_331),
                        new(Static.CriticalDamage, 1_065),
                        new(Static.Evade, 27),
                        new(Static.Defense, 300),
                        AccuracyList[47]
                    }
                },
                {
                    49,
                    new[]
                    {
                        new(Static.Hp, 13_100),
                        new(Static.Attack, 1_349),
                        new(Static.CriticalDamage, 1_079),
                        new(Static.Evade, 27),
                        new(Static.Defense, 307),
                        AccuracyList[48]
                    }
                },
                {
                    50,
                    new[]
                    {
                        new(Static.Hp, 13_350),
                        new(Static.Attack, 1_385),
                        new(Static.CriticalDamage, 1_108),
                        new(Static.Evade, 28),
                        new(Static.Defense, 312),
                        AccuracyList[49]
                    }
                },
                {
                    51,
                    new[]
                    {
                        new(Static.Hp, 13_600),
                        new(Static.Attack, 1_403),
                        new(Static.CriticalDamage, 1_123),
                        new(Static.Evade, 28),
                        new(Static.Defense, 320),
                        AccuracyList[50]
                    }
                },
                {
                    52,
                    new[]
                    {
                        new(Static.Hp, 13_850),
                        new(Static.Attack, 1_439),
                        new(Static.CriticalDamage, 1_151),
                        new(Static.Evade, 29),
                        new(Static.Defense, 325),
                        AccuracyList[51]
                    }
                },
                {
                    53,
                    new[]
                    {
                        new(Static.Hp, 14_100),
                        new(Static.Attack, 1_458),
                        new(Static.CriticalDamage, 1_166),
                        new(Static.Evade, 29),
                        new(Static.Defense, 332),
                        AccuracyList[52]
                    }
                },
                {
                    54,
                    new[]
                    {
                        new(Static.Hp, 14_350),
                        new(Static.Attack, 1_494),
                        new(Static.CriticalDamage, 1_195),
                        new(Static.Evade, 30),
                        new(Static.Defense, 337),
                        AccuracyList[53]
                    }
                },
                {
                    55,
                    new[]
                    {
                        new(Static.Hp, 14_600),
                        new(Static.Attack, 1_512),
                        new(Static.CriticalDamage, 1_209),
                        new(Static.Evade, 31),
                        new(Static.Defense, 345),
                        AccuracyList[54]
                    }
                },
                {
                    56,
                    new[]
                    {
                        new(Static.Hp, 14_850),
                        new(Static.Attack, 1_548),
                        new(Static.CriticalDamage, 1_238),
                        new(Static.Evade, 31),
                        new(Static.Defense, 350),
                        AccuracyList[55]
                    }
                },
                {
                    57,
                    new[]
                    {
                        new(Static.Hp, 15_100),
                        new(Static.Attack, 1_566),
                        new(Static.CriticalDamage, 1_262),
                        new(Static.Evade, 32),
                        new(Static.Defense, 357),
                        AccuracyList[56]
                    }
                },
                {
                    58,
                    new[]
                    {
                        new(Static.Hp, 15_350),
                        new(Static.Attack, 1_602),
                        new(Static.CriticalDamage, 1_291),
                        new(Static.Evade, 32),
                        new(Static.Defense, 362),
                        AccuracyList[57]
                    }
                },
                {
                    59,
                    new[]
                    {
                        new(Static.Hp, 15_600),
                        new(Static.Attack, 1_620),
                        new(Static.CriticalDamage, 1_306),
                        new(Static.Evade, 33),
                        new(Static.Defense, 370),
                        AccuracyList[58]
                    }
                },
                {
                    60,
                    new[]
                    {
                        new(Static.Hp, 15_850),
                        new(Static.Attack, 1_656),
                        new(Static.CriticalDamage, 1_334),
                        new(Static.Evade, 33),
                        new(Static.Defense, 375),
                        AccuracyList[59]
                    }
                },
                {
                    61,
                    new[]
                    {
                        new(Static.Hp, 16_100),
                        new(Static.Attack, 1_674),
                        new(Static.CriticalDamage, 1_339),
                        new(Static.Evade, 34),
                        new(Static.Defense, 382),
                        AccuracyList[60]
                    }
                },
                {
                    62,
                    new[]
                    {
                        new(Static.Hp, 16_350),
                        new(Static.Attack, 1_710),
                        new(Static.CriticalDamage, 1_368),
                        new(Static.Evade, 35),
                        new(Static.Defense, 387),
                        AccuracyList[61]
                    }
                },
                {
                    63,
                    new[]
                    {
                        new(Static.Hp, 16_600),
                        new(Static.Attack, 1_728),
                        new(Static.CriticalDamage, 1_382),
                        new(Static.Evade, 35),
                        new(Static.Defense, 394),
                        AccuracyList[62]
                    }
                },
                {
                    64,
                    new[]
                    {
                        new(Static.Hp, 16_850),
                        new(Static.Attack, 1_764),
                        new(Static.CriticalDamage, 1_411),
                        new(Static.Evade, 36),
                        new(Static.Defense, 399),
                        AccuracyList[63]
                    }
                },
                {
                    65,
                    new[]
                    {
                        new(Static.Hp, 17_100),
                        new(Static.Attack, 1_782),
                        new(Static.CriticalDamage, 1_425),
                        new(Static.Evade, 36),
                        new(Static.Defense, 407),
                        AccuracyList[64]
                    }
                },
                {
                    66,
                    new[]
                    {
                        new(Static.Hp, 17_350),
                        new(Static.Attack, 1_818),
                        new(Static.CriticalDamage, 1_454),
                        new(Static.Evade, 37),
                        new(Static.Defense, 412),
                        AccuracyList[65]
                    }
                },
                {
                    67,
                    new[]
                    {
                        new(Static.Hp, 17_600),
                        new(Static.Attack, 1_836),
                        new(Static.CriticalDamage, 1_468),
                        new(Static.Evade, 37),
                        new(Static.Defense, 419),
                        AccuracyList[66]
                    }
                },
                {
                    68,
                    new[]
                    {
                        new(Static.Hp, 17_850),
                        new(Static.Attack, 1_872),
                        new(Static.CriticalDamage, 1_497),
                        new(Static.Evade, 38),
                        new(Static.Defense, 424),
                        AccuracyList[67]
                    }
                }
            });

        #endregion
    }
}