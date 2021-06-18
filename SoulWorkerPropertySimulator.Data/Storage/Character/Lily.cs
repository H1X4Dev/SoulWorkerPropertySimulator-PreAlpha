using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupLily() =>
            new("Lily Bloomerchen",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        1,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1150),
                            new(StaticEffectContext.Attack, 54),
                            new(StaticEffectContext.Evade, 0),
                            new(StaticEffectContext.Defense, 5),
                            AccuracyList[0]
                        }
                    },
                    {
                        2,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1450),
                            new(StaticEffectContext.Attack, 72),
                            new(StaticEffectContext.Evade, 1),
                            new(StaticEffectContext.Defense, 10),
                            AccuracyList[1]
                        }
                    },
                    {
                        3,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 1750),
                            new(StaticEffectContext.Attack, 108),
                            new(StaticEffectContext.Evade, 2),
                            new(StaticEffectContext.Defense, 12),
                            AccuracyList[2]
                        }
                    },
                    {
                        4,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2050),
                            new(StaticEffectContext.Attack, 126),
                            new(StaticEffectContext.Evade, 3),
                            new(StaticEffectContext.Defense, 17),
                            AccuracyList[3]
                        }
                    },
                    {
                        5,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2350),
                            new(StaticEffectContext.Attack, 144),
                            new(StaticEffectContext.Evade, 4),
                            new(StaticEffectContext.Defense, 22),
                            AccuracyList[4]
                        }
                    },
                    {
                        6,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2650),
                            new(StaticEffectContext.Attack, 180),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 27),
                            AccuracyList[5]
                        }
                    },
                    {
                        7,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 2950),
                            new(StaticEffectContext.Attack, 198),
                            new(StaticEffectContext.Evade, 5),
                            new(StaticEffectContext.Defense, 30),
                            AccuracyList[6]
                        }
                    },
                    {
                        8,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3250),
                            new(StaticEffectContext.Attack, 216),
                            new(StaticEffectContext.Evade, 6),
                            new(StaticEffectContext.Defense, 35),
                            AccuracyList[7]
                        }
                    },
                    {
                        9,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3550),
                            new(StaticEffectContext.Attack, 252),
                            new(StaticEffectContext.Evade, 7),
                            new(StaticEffectContext.Defense, 40),
                            AccuracyList[8]
                        }
                    },
                    {
                        10,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 3850),
                            new(StaticEffectContext.Attack, 270),
                            new(StaticEffectContext.Evade, 8),
                            new(StaticEffectContext.Defense, 45),
                            AccuracyList[9]
                        }
                    },
                    {
                        11,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4150),
                            new(StaticEffectContext.Attack, 306),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 47),
                            AccuracyList[10]
                        }
                    },
                    {
                        12,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4450),
                            new(StaticEffectContext.Attack, 324),
                            new(StaticEffectContext.Evade, 9),
                            new(StaticEffectContext.Defense, 52),
                            AccuracyList[11]
                        }
                    },
                    {
                        13,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 4750),
                            new(StaticEffectContext.Attack, 342),
                            new(StaticEffectContext.Evade, 10),
                            new(StaticEffectContext.Defense, 57),
                            AccuracyList[12]
                        }
                    },
                    {
                        14,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5050),
                            new(StaticEffectContext.Attack, 378),
                            new(StaticEffectContext.Evade, 11),
                            new(StaticEffectContext.Defense, 62),
                            AccuracyList[13]
                        }
                    },
                    {
                        15,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5350),
                            new(StaticEffectContext.Attack, 396),
                            new(StaticEffectContext.Evade, 12),
                            new(StaticEffectContext.Defense, 65),
                            AccuracyList[14]
                        }
                    },
                    {
                        16,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5650),
                            new(StaticEffectContext.Attack, 414),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 70),
                            AccuracyList[15]
                        }
                    },
                    {
                        17,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 5950),
                            new(StaticEffectContext.Attack, 450),
                            new(StaticEffectContext.Evade, 13),
                            new(StaticEffectContext.Defense, 75),
                            AccuracyList[16]
                        }
                    },
                    {
                        18,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6250),
                            new(StaticEffectContext.Attack, 468),
                            new(StaticEffectContext.Evade, 14),
                            new(StaticEffectContext.Defense, 80),
                            AccuracyList[17]
                        }
                    },
                    {
                        19,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6550),
                            new(StaticEffectContext.Attack, 504),
                            new(StaticEffectContext.Evade, 15),
                            new(StaticEffectContext.Defense, 82),
                            AccuracyList[18]
                        }
                    },
                    {
                        20,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 6850),
                            new(StaticEffectContext.Attack, 522),
                            new(StaticEffectContext.Evade, 16),
                            new(StaticEffectContext.Defense, 87),
                            AccuracyList[19]
                        }
                    },
                    {
                        21,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7150),
                            new(StaticEffectContext.Attack, 540),
                            new(StaticEffectContext.Evade, 17),
                            new(StaticEffectContext.Defense, 92),
                            AccuracyList[20]
                        }
                    },
                    {
                        22,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7450),
                            new(StaticEffectContext.Attack, 576),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 97),
                            AccuracyList[21]
                        }
                    },
                    {
                        23,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 7750),
                            new(StaticEffectContext.Attack, 594),
                            new(StaticEffectContext.Evade, 18),
                            new(StaticEffectContext.Defense, 100),
                            AccuracyList[22]
                        }
                    },
                    {
                        24,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8050),
                            new(StaticEffectContext.Attack, 612),
                            new(StaticEffectContext.Evade, 19),
                            new(StaticEffectContext.Defense, 105),
                            AccuracyList[23]
                        }
                    },
                    {
                        25,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8350),
                            new(StaticEffectContext.Attack, 648),
                            new(StaticEffectContext.Evade, 20),
                            new(StaticEffectContext.Defense, 110),
                            AccuracyList[24]
                        }
                    },
                    {
                        26,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8650),
                            new(StaticEffectContext.Attack, 666),
                            new(StaticEffectContext.Evade, 21),
                            new(StaticEffectContext.Defense, 115),
                            AccuracyList[25]
                        }
                    },
                    {
                        27,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 8950),
                            new(StaticEffectContext.Attack, 702),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 117),
                            AccuracyList[26]
                        }
                    },
                    {
                        28,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9250),
                            new(StaticEffectContext.Attack, 720),
                            new(StaticEffectContext.Evade, 22),
                            new(StaticEffectContext.Defense, 122),
                            AccuracyList[27]
                        }
                    },
                    {
                        29,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9550),
                            new(StaticEffectContext.Attack, 738),
                            new(StaticEffectContext.Evade, 23),
                            new(StaticEffectContext.Defense, 127),
                            AccuracyList[28]
                        }
                    },
                    {
                        30,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 9850),
                            new(StaticEffectContext.Attack, 774),
                            new(StaticEffectContext.Evade, 24),
                            new(StaticEffectContext.Defense, 132),
                            AccuracyList[29]
                        }
                    },
                    {
                        31,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10150),
                            new(StaticEffectContext.Attack, 792),
                            new(StaticEffectContext.Evade, 25),
                            new(StaticEffectContext.Defense, 135),
                            AccuracyList[30]
                        }
                    },
                    {
                        32,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10450),
                            new(StaticEffectContext.Attack, 810),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 140),
                            AccuracyList[31]
                        }
                    },
                    {
                        33,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 10750),
                            new(StaticEffectContext.Attack, 846),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 145),
                            AccuracyList[32]
                        }
                    },
                    {
                        34,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11050),
                            new(StaticEffectContext.Attack, 864),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 150),
                            AccuracyList[33]
                        }
                    },
                    {
                        35,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11350),
                            new(StaticEffectContext.Attack, 900),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 152),
                            AccuracyList[34]
                        }
                    },
                    {
                        36,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11650),
                            new(StaticEffectContext.Attack, 918),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 157),
                            AccuracyList[35]
                        }
                    },
                    {
                        37,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 11950),
                            new(StaticEffectContext.Attack, 936),
                            new(StaticEffectContext.Evade, 30),
                            new(StaticEffectContext.Defense, 162),
                            AccuracyList[36]
                        }
                    },
                    {
                        38,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12250),
                            new(StaticEffectContext.Attack, 972),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 167),
                            AccuracyList[37]
                        }
                    },
                    {
                        39,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12550),
                            new(StaticEffectContext.Attack, 990),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 170),
                            AccuracyList[38]
                        }
                    },
                    {
                        40,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 12850),
                            new(StaticEffectContext.Attack, 1008),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 175),
                            AccuracyList[39]
                        }
                    },
                    {
                        41,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13150),
                            new(StaticEffectContext.Attack, 1044),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 180),
                            AccuracyList[40]
                        }
                    },
                    {
                        42,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13450),
                            new(StaticEffectContext.Attack, 1062),
                            new(StaticEffectContext.Evade, 34),
                            new(StaticEffectContext.Defense, 185),
                            AccuracyList[41]
                        }
                    },
                    {
                        43,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 13750),
                            new(StaticEffectContext.Attack, 1098),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 187),
                            AccuracyList[42]
                        }
                    },
                    {
                        44,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14050),
                            new(StaticEffectContext.Attack, 1116),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 192),
                            AccuracyList[43]
                        }
                    },
                    {
                        45,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14350),
                            new(StaticEffectContext.Attack, 1134),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 197),
                            AccuracyList[44]
                        }
                    },
                    {
                        46,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14650),
                            new(StaticEffectContext.Attack, 1170),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 202),
                            AccuracyList[45]
                        }
                    },
                    {
                        47,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 14950),
                            new(StaticEffectContext.Attack, 1188),
                            new(StaticEffectContext.Evade, 38),
                            new(StaticEffectContext.Defense, 205),
                            AccuracyList[46]
                        }
                    },
                    {
                        48,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15250),
                            new(StaticEffectContext.Attack, 1206),
                            new(StaticEffectContext.Evade, 39),
                            new(StaticEffectContext.Defense, 210),
                            AccuracyList[47]
                        }
                    },
                    {
                        49,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15550),
                            new(StaticEffectContext.Attack, 1242),
                            new(StaticEffectContext.Evade, 39),
                            new(StaticEffectContext.Defense, 215),
                            AccuracyList[48]
                        }
                    },
                    {
                        50,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 15850),
                            new(StaticEffectContext.Attack, 1260),
                            new(StaticEffectContext.Evade, 40),
                            new(StaticEffectContext.Defense, 220),
                            AccuracyList[49]
                        }
                    },
                    {
                        51,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16150),
                            new(StaticEffectContext.Attack, 1295),
                            new(StaticEffectContext.Evade, 41),
                            new(StaticEffectContext.Defense, 222),
                            AccuracyList[50]
                        }
                    },
                    {
                        52,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16450),
                            new(StaticEffectContext.Attack, 1314),
                            new(StaticEffectContext.Evade, 42),
                            new(StaticEffectContext.Defense, 227),
                            AccuracyList[51]
                        }
                    },
                    {
                        53,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 16750),
                            new(StaticEffectContext.Attack, 1331),
                            new(StaticEffectContext.Evade, 43),
                            new(StaticEffectContext.Defense, 232),
                            AccuracyList[52]
                        }
                    },
                    {
                        54,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17050),
                            new(StaticEffectContext.Attack, 1368),
                            new(StaticEffectContext.Evade, 44),
                            new(StaticEffectContext.Defense, 237),
                            AccuracyList[53]
                        }
                    },
                    {
                        55,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17350),
                            new(StaticEffectContext.Attack, 1386),
                            new(StaticEffectContext.Evade, 44),
                            new(StaticEffectContext.Defense, 240),
                            AccuracyList[54]
                        }
                    },
                    {
                        56,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17650),
                            new(StaticEffectContext.Attack, 1404),
                            new(StaticEffectContext.Evade, 45),
                            new(StaticEffectContext.Defense, 245),
                            AccuracyList[55]
                        }
                    },
                    {
                        57,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 17950),
                            new(StaticEffectContext.Attack, 1440),
                            new(StaticEffectContext.Evade, 46),
                            new(StaticEffectContext.Defense, 250),
                            AccuracyList[56]
                        }
                    },
                    {
                        58,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18250),
                            new(StaticEffectContext.Attack, 1458),
                            new(StaticEffectContext.Evade, 47),
                            new(StaticEffectContext.Defense, 255),
                            AccuracyList[57]
                        }
                    },
                    {
                        59,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18550),
                            new(StaticEffectContext.Attack, 1494),
                            new(StaticEffectContext.Evade, 48),
                            new(StaticEffectContext.Defense, 257),
                            AccuracyList[58]
                        }
                    },
                    {
                        60,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 18850),
                            new(StaticEffectContext.Attack, 1512),
                            new(StaticEffectContext.Evade, 48),
                            new(StaticEffectContext.Defense, 262),
                            AccuracyList[59]
                        }
                    },
                    {
                        61,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19150),
                            new(StaticEffectContext.Attack, 1530),
                            new(StaticEffectContext.Evade, 49),
                            new(StaticEffectContext.Defense, 267),
                            AccuracyList[60]
                        }
                    },
                    {
                        62,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19450),
                            new(StaticEffectContext.Attack, 1566),
                            new(StaticEffectContext.Evade, 50),
                            new(StaticEffectContext.Defense, 272),
                            AccuracyList[61]
                        }
                    },
                    {
                        63,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 19750),
                            new(StaticEffectContext.Attack, 1584),
                            new(StaticEffectContext.Evade, 51),
                            new(StaticEffectContext.Defense, 275),
                            AccuracyList[62]
                        }
                    },
                    {
                        64,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20050),
                            new(StaticEffectContext.Attack, 1601),
                            new(StaticEffectContext.Evade, 52),
                            new(StaticEffectContext.Defense, 280),
                            AccuracyList[63]
                        }
                    },
                    {
                        65,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20350),
                            new(StaticEffectContext.Attack, 1638),
                            new(StaticEffectContext.Evade, 52),
                            new(StaticEffectContext.Defense, 285),
                            AccuracyList[64]
                        }
                    },
                    {
                        66,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20650),
                            new(StaticEffectContext.Attack, 1656),
                            new(StaticEffectContext.Evade, 53),
                            new(StaticEffectContext.Defense, 289),
                            AccuracyList[65]
                        }
                    },
                    {
                        67,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 20950),
                            new(StaticEffectContext.Attack, 1692),
                            new(StaticEffectContext.Evade, 54),
                            new(StaticEffectContext.Defense, 292),
                            AccuracyList[66]
                        }
                    },
                    {
                        68,
                        new[]
                        {
                            new(StaticEffectContext.Hp, 21250),
                            new(StaticEffectContext.Attack, 1710),
                            new(StaticEffectContext.Evade, 55),
                            new(StaticEffectContext.Defense, 297),
                            AccuracyList[67]
                        }
                    }
                });

        #endregion
    }
}