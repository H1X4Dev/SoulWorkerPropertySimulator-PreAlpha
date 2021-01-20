using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        private static Character Chii =>
            new("琪",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        14,
                        new Effect[]
                        {
                            new(HP, 6_300),
                            new(Attack, 378),
                            new(CDamage, 302),
                            new(Evade, 8),
                            new(Defense, 87),
                            new(Accuracy, AccuracyList[13])
                        }
                    },
                    {
                        15,
                        new Effect[]
                        {
                            new(HP, 6_700),
                            new(Attack, 414),
                            new(CDamage, 331),
                            new(Evade, 9),
                            new(Defense, 95),
                            new(Accuracy, AccuracyList[14])
                        }
                    },
                    {
                        16,
                        new Effect[]
                        {
                            new(HP, 7_100),
                            new(Attack, 432),
                            new(CDamage, 345),
                            new(Evade, 10),
                            new(Defense, 100),
                            new(Accuracy, AccuracyList[15])
                        }
                    },
                    {
                        17,
                        new Effect[]
                        {
                            new(HP, 7_500),
                            new(Attack, 468),
                            new(CDamage, 374),
                            new(Evade, 10),
                            new(Defense, 107),
                            new(Accuracy, AccuracyList[16])
                        }
                    },
                    {
                        18,
                        new Effect[]
                        {
                            new(HP, 7_900),
                            new(Attack, 486),
                            new(CDamage, 388),
                            new(Evade, 11),
                            new(Defense, 112),
                            new(Accuracy, AccuracyList[17])
                        }
                    },
                    {
                        19,
                        new Effect[]
                        {
                            new(HP, 8_300),
                            new(Attack, 504),
                            new(CDamage, 403),
                            new(Evade, 11),
                            new(Defense, 120),
                            new(Accuracy, AccuracyList[18])
                        }
                    },
                    {
                        20,
                        new Effect[]
                        {
                            new(HP, 8_700),
                            new(Attack, 540),
                            new(CDamage, 432),
                            new(Evade, 12),
                            new(Defense, 125),
                            new(Accuracy, AccuracyList[19])
                        }
                    },
                    {
                        21,
                        new Effect[]
                        {
                            new(HP, 9_100),
                            new(Attack, 558),
                            new(CDamage, 446),
                            new(Evade, 13),
                            new(Defense, 132),
                            new(Accuracy, AccuracyList[20])
                        }
                    },
                    {
                        22,
                        new Effect[]
                        {
                            new(HP, 9_500),
                            new(Attack, 594),
                            new(CDamage, 475),
                            new(Evade, 13),
                            new(Defense, 137),
                            new(Accuracy, AccuracyList[21])
                        }
                    },
                    {
                        23,
                        new Effect[]
                        {
                            new(HP, 9_900),
                            new(Attack, 612),
                            new(CDamage, 489),
                            new(Evade, 14),
                            new(Defense, 145),
                            new(Accuracy, AccuracyList[22])
                        }
                    },
                    {
                        24,
                        new Effect[]
                        {
                            new(HP, 10_300),
                            new(Attack, 648),
                            new(CDamage, 518),
                            new(Evade, 15),
                            new(Defense, 150),
                            new(Accuracy, AccuracyList[23])
                        }
                    },
                    {
                        25,
                        new Effect[]
                        {
                            new(HP, 10_700),
                            new(Attack, 666),
                            new(CDamage, 532),
                            new(Evade, 15),
                            new(Defense, 157),
                            new(Accuracy, AccuracyList[24])
                        }
                    },
                    {
                        26,
                        new Effect[]
                        {
                            new(HP, 11_100),
                            new(Attack, 684),
                            new(CDamage, 547),
                            new(Evade, 16),
                            new(Defense, 162),
                            new(Accuracy, AccuracyList[25])
                        }
                    },
                    {
                        27,
                        new Effect[]
                        {
                            new(HP, 11_500),
                            new(Attack, 720),
                            new(CDamage, 576),
                            new(Evade, 16),
                            new(Defense, 170),
                            new(Accuracy, AccuracyList[26])
                        }
                    },
                    {
                        28,
                        new Effect[]
                        {
                            new(HP, 11_900),
                            new(Attack, 738),
                            new(CDamage, 609),
                            new(Evade, 17),
                            new(Defense, 175),
                            new(Accuracy, AccuracyList[27])
                        }
                    },
                    {
                        29,
                        new Effect[]
                        {
                            new(HP, 12_300),
                            new(Attack, 774),
                            new(CDamage, 619),
                            new(Evade, 18),
                            new(Defense, 182),
                            new(Accuracy, AccuracyList[28])
                        }
                    },
                    {
                        30,
                        new Effect[]
                        {
                            new(HP, 12_700),
                            new(Attack, 792),
                            new(CDamage, 633),
                            new(Evade, 18),
                            new(Defense, 187),
                            new(Accuracy, AccuracyList[29])
                        }
                    },
                    {
                        31,
                        new Effect[]
                        {
                            new(HP, 13_100),
                            new(Attack, 828),
                            new(CDamage, 662),
                            new(Evade, 19),
                            new(Defense, 195),
                            new(Accuracy, AccuracyList[30])
                        }
                    },
                    {
                        32,
                        new Effect[]
                        {
                            new(HP, 13_500),
                            new(Attack, 846),
                            new(CDamage, 676),
                            new(Evade, 20),
                            new(Defense, 200),
                            new(Accuracy, AccuracyList[31])
                        }
                    },
                    {
                        33,
                        new Effect[]
                        {
                            new(HP, 13_900),
                            new(Attack, 864),
                            new(CDamage, 691),
                            new(Evade, 20),
                            new(Defense, 207),
                            new(Accuracy, AccuracyList[32])
                        }
                    },
                    {
                        34,
                        new Effect[]
                        {
                            new(HP, 14_300),
                            new(Attack, 900),
                            new(CDamage, 720),
                            new(Evade, 21),
                            new(Defense, 212),
                            new(Accuracy, AccuracyList[33])
                        }
                    },
                    {
                        35,
                        new Effect[]
                        {
                            new(HP, 14_700),
                            new(Attack, 918),
                            new(CDamage, 734),
                            new(Evade, 21),
                            new(Defense, 220),
                            new(Accuracy, AccuracyList[34])
                        }
                    },
                    {
                        36,
                        new Effect[]
                        {
                            new(HP, 15_100),
                            new(Attack, 954),
                            new(CDamage, 763),
                            new(Evade, 22),
                            new(Defense, 225),
                            new(Accuracy, AccuracyList[35])
                        }
                    },
                    {
                        37,
                        new Effect[]
                        {
                            new(HP, 15_500),
                            new(Attack, 972),
                            new(CDamage, 777),
                            new(Evade, 23),
                            new(Defense, 232),
                            new(Accuracy, AccuracyList[36])
                        }
                    },
                    {
                        38,
                        new Effect[]
                        {
                            new(HP, 15_900),
                            new(Attack, 990),
                            new(CDamage, 792),
                            new(Evade, 23),
                            new(Defense, 237),
                            new(Accuracy, AccuracyList[37])
                        }
                    },
                    {
                        39,
                        new Effect[]
                        {
                            new(HP, 16_300),
                            new(Attack, 1_026),
                            new(CDamage, 820),
                            new(Evade, 24),
                            new(Defense, 245),
                            new(Accuracy, AccuracyList[38])
                        }
                    },
                    {
                        40,
                        new Effect[]
                        {
                            new(HP, 16_700),
                            new(Attack, 1_044),
                            new(CDamage, 835),
                            new(Evade, 25),
                            new(Defense, 250),
                            new(Accuracy, AccuracyList[39])
                        }
                    },
                    {
                        41,
                        new Effect[]
                        {
                            new(HP, 17_100),
                            new(Attack, 1_080),
                            new(CDamage, 864),
                            new(Evade, 25),
                            new(Defense, 257),
                            new(Accuracy, AccuracyList[40])
                        }
                    },
                    {
                        42,
                        new Effect[]
                        {
                            new(HP, 17_500),
                            new(Attack, 1_098),
                            new(CDamage, 878),
                            new(Evade, 26),
                            new(Defense, 262),
                            new(Accuracy, AccuracyList[41])
                        }
                    },
                    {
                        43,
                        new Effect[]
                        {
                            new(HP, 17_900),
                            new(Attack, 1_134),
                            new(CDamage, 907),
                            new(Evade, 26),
                            new(Defense, 270),
                            new(Accuracy, AccuracyList[42])
                        }
                    },
                    {
                        44,
                        new Effect[]
                        {
                            new(HP, 18_300),
                            new(Attack, 1_152),
                            new(CDamage, 921),
                            new(Evade, 27),
                            new(Defense, 275),
                            new(Accuracy, AccuracyList[43])
                        }
                    },
                    {
                        45,
                        new Effect[]
                        {
                            new(HP, 18_700),
                            new(Attack, 1_170),
                            new(CDamage, 936),
                            new(Evade, 28),
                            new(Defense, 282),
                            new(Accuracy, AccuracyList[44])
                        }
                    },
                    {
                        46,
                        new Effect[]
                        {
                            new(HP, 19_100),
                            new(Attack, 1_206),
                            new(CDamage, 964),
                            new(Evade, 28),
                            new(Defense, 287),
                            new(Accuracy, AccuracyList[45])
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(HP, 19_500),
                            new(Attack, 1_224),
                            new(CDamage, 979),
                            new(Evade, 29),
                            new(Defense, 295),
                            new(Accuracy, AccuracyList[46])
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(HP, 19_900),
                            new(Attack, 1_260),
                            new(CDamage, 1_008),
                            new(Evade, 30),
                            new(Defense, 300),
                            new(Accuracy, AccuracyList[47])
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(HP, 20_300),
                            new(Attack, 1_278),
                            new(CDamage, 1_022),
                            new(Evade, 30),
                            new(Defense, 307),
                            new(Accuracy, AccuracyList[48])
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(HP, 20_700),
                            new(Attack, 1_314),
                            new(CDamage, 1_051),
                            new(Evade, 31),
                            new(Defense, 312),
                            new(Accuracy, AccuracyList[49])
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(HP, 21_100),
                            new(Attack, 1_332),
                            new(CDamage, 1_065),
                            new(Evade, 31),
                            new(Defense, 320),
                            new(Accuracy, AccuracyList[50])
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(HP, 21_500),
                            new(Attack, 1_350),
                            new(CDamage, 1_080),
                            new(Evade, 32),
                            new(Defense, 325),
                            new(Accuracy, AccuracyList[51])
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(HP, 21_900),
                            new(Attack, 1_386),
                            new(CDamage, 1_108),
                            new(Evade, 33),
                            new(Defense, 332),
                            new(Accuracy, AccuracyList[52])
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(HP, 22_300),
                            new(Attack, 1_404),
                            new(CDamage, 1_123),
                            new(Evade, 33),
                            new(Defense, 337),
                            new(Accuracy, AccuracyList[53])
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(HP, 22_700),
                            new(Attack, 1_440),
                            new(CDamage, 1_152),
                            new(Evade, 34),
                            new(Defense, 345),
                            new(Accuracy, AccuracyList[54])
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(HP, 23_100),
                            new(Attack, 1_458),
                            new(CDamage, 1_166),
                            new(Evade, 35),
                            new(Defense, 350),
                            new(Accuracy, AccuracyList[55])
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(HP, 23_500),
                            new(Attack, 1_494),
                            new(CDamage, 1_195),
                            new(Evade, 35),
                            new(Defense, 357),
                            new(Accuracy, AccuracyList[56])
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(HP, 23_900),
                            new(Attack, 1_512),
                            new(CDamage, 1_209),
                            new(Evade, 36),
                            new(Defense, 362),
                            new(Accuracy, AccuracyList[57])
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(HP, 24_300),
                            new(Attack, 1_530),
                            new(CDamage, 1_224),
                            new(Evade, 36),
                            new(Defense, 369),
                            new(Accuracy, AccuracyList[58])
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(HP, 24_700),
                            new(Attack, 1_566),
                            new(CDamage, 1_252),
                            new(Evade, 37),
                            new(Defense, 374),
                            new(Accuracy, AccuracyList[59])
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(HP, 25_100),
                            new(Attack, 1_584),
                            new(CDamage, 1_267),
                            new(Evade, 38),
                            new(Defense, 382),
                            new(Accuracy, AccuracyList[60])
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(HP, 25_500),
                            new(Attack, 1_620),
                            new(CDamage, 1_296),
                            new(Evade, 38),
                            new(Defense, 387),
                            new(Accuracy, AccuracyList[61])
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(HP, 25_900),
                            new(Attack, 1_638),
                            new(CDamage, 1_310),
                            new(Evade, 39),
                            new(Defense, 395),
                            new(Accuracy, AccuracyList[62])
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(HP, 26_300),
                            new(Attack, 1_674),
                            new(CDamage, 1_339),
                            new(Evade, 40),
                            new(Defense, 400),
                            new(Accuracy, AccuracyList[63])
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(HP, 26_700),
                            new(Attack, 1_692),
                            new(CDamage, 1_353),
                            new(Evade, 40),
                            new(Defense, 407),
                            new(Accuracy, AccuracyList[64])
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(HP, 27_100),
                            new(Attack, 1_710),
                            new(CDamage, 1_368),
                            new(Evade, 41),
                            new(Defense, 412),
                            new(Accuracy, AccuracyList[65])
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(HP, 27_500),
                            new(Attack, 1_746),
                            new(CDamage, 1_396),
                            new(Evade, 41),
                            new(Defense, 420),
                            new(Accuracy, AccuracyList[66])
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(HP, 27_900),
                            new(Attack, 1_764),
                            new(CDamage, 1_411),
                            new(Evade, 42),
                            new(Defense, 425),
                            new(Accuracy, AccuracyList[67])
                        }
                    }
                });
    };
}