using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        private static Character Lee =>
            new("李",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        46,
                        new Effect[]
                        {
                            new(HP, 12350),
                            new(Attack, 1278),
                            new(CDamage, 1022),
                            new(Evade, 26),
                            new(Defense, 230),
                            new(Accuracy, 978)
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(HP, 12600),
                            new(Attack, 1296),
                            new(CDamage, 1036),
                            new(Evade, 26),
                            new(Defense, 235),
                            new(Accuracy, 981)
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(HP, 12850),
                            new(Attack, 1332),
                            new(CDamage, 1065),
                            new(Evade, 27),
                            new(Defense, 240),
                            new(Accuracy, 985)
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(HP, 13100),
                            new(Attack, 1350),
                            new(CDamage, 1080),
                            new(Evade, 27),
                            new(Defense, 245),
                            new(Accuracy, 989)
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(HP, 13350),
                            new(Attack, 1386),
                            new(CDamage, 1108),
                            new(Evade, 28),
                            new(Defense, 250),
                            new(Accuracy, 994)
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(HP, 13600),
                            new(Attack, 1404),
                            new(CDamage, 1123),
                            new(Evade, 28),
                            new(Defense, 255),
                            new(Accuracy, 996)
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(HP, 13850),
                            new(Attack, 1440),
                            new(CDamage, 1152),
                            new(Evade, 29),
                            new(Defense, 260),
                            new(Accuracy, 1001)
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(HP, 14100),
                            new(Attack, 1458),
                            new(CDamage, 1166),
                            new(Evade, 29),
                            new(Defense, 265),
                            new(Accuracy, 1005)
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(HP, 14350),
                            new(Attack, 1494),
                            new(CDamage, 1195),
                            new(Evade, 30),
                            new(Defense, 270),
                            new(Accuracy, 1009)
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(HP, 14600),
                            new(Attack, 1512),
                            new(CDamage, 1209),
                            new(Evade, 31),
                            new(Defense, 275),
                            new(Accuracy, 1012)
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(HP, 14850),
                            new(Attack, 1548),
                            new(CDamage, 1238),
                            new(Evade, 31),
                            new(Defense, 280),
                            new(Accuracy, 1016)
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(HP, 15100),
                            new(Attack, 1566),
                            new(CDamage, 1252),
                            new(Evade, 32),
                            new(Defense, 285),
                            new(Accuracy, 1020)
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(HP, 15350),
                            new(Attack, 1602),
                            new(CDamage, 1281),
                            new(Evade, 32),
                            new(Defense, 290),
                            new(Accuracy, 1025)
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(HP, 15600),
                            new(Attack, 1620),
                            new(CDamage, 1296),
                            new(Evade, 33),
                            new(Defense, 295),
                            new(Accuracy, 1027)
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(HP, 15850),
                            new(Attack, 1656),
                            new(CDamage, 1324),
                            new(Evade, 33),
                            new(Defense, 300),
                            new(Accuracy, 1032)
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(HP, 16100),
                            new(Attack, 1674),
                            new(CDamage, 1339),
                            new(Evade, 34),
                            new(Defense, 305),
                            new(Accuracy, 1036)
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(HP, 16350),
                            new(Attack, 1710),
                            new(CDamage, 1368),
                            new(Evade, 35),
                            new(Defense, 310),
                            new(Accuracy, 1040)
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(HP, 16600),
                            new(Attack, 1728),
                            new(CDamage, 1382),
                            new(Evade, 35),
                            new(Defense, 315),
                            new(Accuracy, 1043)
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(HP, 16850),
                            new(Attack, 1764),
                            new(CDamage, 1411),
                            new(Evade, 36),
                            new(Defense, 320),
                            new(Accuracy, 1047)
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(HP, 17100),
                            new(Attack, 1782),
                            new(CDamage, 1425),
                            new(Evade, 36),
                            new(Defense, 325),
                            new(Accuracy, 1051)
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(HP, 17350),
                            new(Attack, 1818),
                            new(CDamage, 1454),
                            new(Evade, 37),
                            new(Defense, 330),
                            new(Accuracy, 1055)
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(HP, 17600),
                            new(Attack, 1836),
                            new(CDamage, 1468),
                            new(Evade, 37),
                            new(Defense, 335),
                            new(Accuracy, 1058)
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(HP, 17850),
                            new(Attack, 1872),
                            new(CDamage, 1497),
                            new(Evade, 38),
                            new(Defense, 340),
                            new(Accuracy, 1062)
                        }
                    },
                    {
                        69,
                        new Effect[]
                        {
                            new(HP, 18100),
                            new(Attack, 1890),
                            new(CDamage, 1512),
                            new(Evade, 38),
                            new(Defense, 345),
                            new(Accuracy, 1067)
                        }
                    },
                    {
                        70,
                        new Effect[]
                        {
                            new(HP, 18350),
                            new(Attack, 1926),
                            new(CDamage, 1540),
                            new(Evade, 39),
                            new(Defense, 350),
                            new(Accuracy, 1071)
                        }
                    },
                    {
                        71,
                        new Effect[]
                        {
                            new(HP, 18600),
                            new(Attack, 1944),
                            new(CDamage, 1555),
                            new(Evade, 40),
                            new(Defense, 354),
                            new(Accuracy, 1074)
                        }
                    },
                    {
                        72,
                        new Effect[]
                        {
                            new(HP, 18850),
                            new(Attack, 1980),
                            new(CDamage, 1584),
                            new(Evade, 40),
                            new(Defense, 360),
                            new(Accuracy, 1078)
                        }
                    }
                });
    }
}