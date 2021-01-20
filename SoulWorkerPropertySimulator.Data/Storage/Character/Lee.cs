using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character Lee =>
            new("李",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        46,
                        new Effect[]
                        {
                            new(Static.HP, 12350),
                            new(Static.Attack, 1278),
                            new(Static.CriticalDamage, 1022),
                            new(Static.Evade, 26),
                            new(Static.Defense, 230),
                            new(Static.Accuracy, 978)
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(Static.HP, 12600),
                            new(Static.Attack, 1296),
                            new(Static.CriticalDamage, 1036),
                            new(Static.Evade, 26),
                            new(Static.Defense, 235),
                            new(Static.Accuracy, 981)
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(Static.HP, 12850),
                            new(Static.Attack, 1332),
                            new(Static.CriticalDamage, 1065),
                            new(Static.Evade, 27),
                            new(Static.Defense, 240),
                            new(Static.Accuracy, 985)
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(Static.HP, 13100),
                            new(Static.Attack, 1350),
                            new(Static.CriticalDamage, 1080),
                            new(Static.Evade, 27),
                            new(Static.Defense, 245),
                            new(Static.Accuracy, 989)
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(Static.HP, 13350),
                            new(Static.Attack, 1386),
                            new(Static.CriticalDamage, 1108),
                            new(Static.Evade, 28),
                            new(Static.Defense, 250),
                            new(Static.Accuracy, 994)
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(Static.HP, 13600),
                            new(Static.Attack, 1404),
                            new(Static.CriticalDamage, 1123),
                            new(Static.Evade, 28),
                            new(Static.Defense, 255),
                            new(Static.Accuracy, 996)
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(Static.HP, 13850),
                            new(Static.Attack, 1440),
                            new(Static.CriticalDamage, 1152),
                            new(Static.Evade, 29),
                            new(Static.Defense, 260),
                            new(Static.Accuracy, 1001)
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(Static.HP, 14100),
                            new(Static.Attack, 1458),
                            new(Static.CriticalDamage, 1166),
                            new(Static.Evade, 29),
                            new(Static.Defense, 265),
                            new(Static.Accuracy, 1005)
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(Static.HP, 14350),
                            new(Static.Attack, 1494),
                            new(Static.CriticalDamage, 1195),
                            new(Static.Evade, 30),
                            new(Static.Defense, 270),
                            new(Static.Accuracy, 1009)
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(Static.HP, 14600),
                            new(Static.Attack, 1512),
                            new(Static.CriticalDamage, 1209),
                            new(Static.Evade, 31),
                            new(Static.Defense, 275),
                            new(Static.Accuracy, 1012)
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(Static.HP, 14850),
                            new(Static.Attack, 1548),
                            new(Static.CriticalDamage, 1238),
                            new(Static.Evade, 31),
                            new(Static.Defense, 280),
                            new(Static.Accuracy, 1016)
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(Static.HP, 15100),
                            new(Static.Attack, 1566),
                            new(Static.CriticalDamage, 1252),
                            new(Static.Evade, 32),
                            new(Static.Defense, 285),
                            new(Static.Accuracy, 1020)
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(Static.HP, 15350),
                            new(Static.Attack, 1602),
                            new(Static.CriticalDamage, 1281),
                            new(Static.Evade, 32),
                            new(Static.Defense, 290),
                            new(Static.Accuracy, 1025)
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(Static.HP, 15600),
                            new(Static.Attack, 1620),
                            new(Static.CriticalDamage, 1296),
                            new(Static.Evade, 33),
                            new(Static.Defense, 295),
                            new(Static.Accuracy, 1027)
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(Static.HP, 15850),
                            new(Static.Attack, 1656),
                            new(Static.CriticalDamage, 1324),
                            new(Static.Evade, 33),
                            new(Static.Defense, 300),
                            new(Static.Accuracy, 1032)
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(Static.HP, 16100),
                            new(Static.Attack, 1674),
                            new(Static.CriticalDamage, 1339),
                            new(Static.Evade, 34),
                            new(Static.Defense, 305),
                            new(Static.Accuracy, 1036)
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(Static.HP, 16350),
                            new(Static.Attack, 1710),
                            new(Static.CriticalDamage, 1368),
                            new(Static.Evade, 35),
                            new(Static.Defense, 310),
                            new(Static.Accuracy, 1040)
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(Static.HP, 16600),
                            new(Static.Attack, 1728),
                            new(Static.CriticalDamage, 1382),
                            new(Static.Evade, 35),
                            new(Static.Defense, 315),
                            new(Static.Accuracy, 1043)
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(Static.HP, 16850),
                            new(Static.Attack, 1764),
                            new(Static.CriticalDamage, 1411),
                            new(Static.Evade, 36),
                            new(Static.Defense, 320),
                            new(Static.Accuracy, 1047)
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(Static.HP, 17100),
                            new(Static.Attack, 1782),
                            new(Static.CriticalDamage, 1425),
                            new(Static.Evade, 36),
                            new(Static.Defense, 325),
                            new(Static.Accuracy, 1051)
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(Static.HP, 17350),
                            new(Static.Attack, 1818),
                            new(Static.CriticalDamage, 1454),
                            new(Static.Evade, 37),
                            new(Static.Defense, 330),
                            new(Static.Accuracy, 1055)
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(Static.HP, 17600),
                            new(Static.Attack, 1836),
                            new(Static.CriticalDamage, 1468),
                            new(Static.Evade, 37),
                            new(Static.Defense, 335),
                            new(Static.Accuracy, 1058)
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(Static.HP, 17850),
                            new(Static.Attack, 1872),
                            new(Static.CriticalDamage, 1497),
                            new(Static.Evade, 38),
                            new(Static.Defense, 340),
                            new(Static.Accuracy, 1062)
                        }
                    },
                    {
                        69,
                        new Effect[]
                        {
                            new(Static.HP, 18100),
                            new(Static.Attack, 1890),
                            new(Static.CriticalDamage, 1512),
                            new(Static.Evade, 38),
                            new(Static.Defense, 345),
                            new(Static.Accuracy, 1067)
                        }
                    },
                    {
                        70,
                        new Effect[]
                        {
                            new(Static.HP, 18350),
                            new(Static.Attack, 1926),
                            new(Static.CriticalDamage, 1540),
                            new(Static.Evade, 39),
                            new(Static.Defense, 350),
                            new(Static.Accuracy, 1071)
                        }
                    },
                    {
                        71,
                        new Effect[]
                        {
                            new(Static.HP, 18600),
                            new(Static.Attack, 1944),
                            new(Static.CriticalDamage, 1555),
                            new(Static.Evade, 40),
                            new(Static.Defense, 354),
                            new(Static.Accuracy, 1074)
                        }
                    },
                    {
                        72,
                        new Effect[]
                        {
                            new(Static.HP, 18850),
                            new(Static.Attack, 1980),
                            new(Static.CriticalDamage, 1584),
                            new(Static.Evade, 40),
                            new(Static.Defense, 360),
                            new(Static.Accuracy, 1078)
                        }
                    }
                });

        #endregion
    }
}