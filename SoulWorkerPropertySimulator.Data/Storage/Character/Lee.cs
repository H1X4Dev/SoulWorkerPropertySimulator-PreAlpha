using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        #region

        private static Character SetupLee() =>
            new("李",
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        46,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 12_350),
                            new(StaticEffectContext.Attack, 1_278),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 230),
                            new(StaticEffectContext.Accuracy, 978)
                        }
                    },
                    {
                        47,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 12_600),
                            new(StaticEffectContext.Attack, 1_296),
                            new(StaticEffectContext.Evade, 26),
                            new(StaticEffectContext.Defense, 235),
                            new(StaticEffectContext.Accuracy, 981)
                        }
                    },
                    {
                        48,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 12_850),
                            new(StaticEffectContext.Attack, 1_332),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 240),
                            new(StaticEffectContext.Accuracy, 985)
                        }
                    },
                    {
                        49,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 13_100),
                            new(StaticEffectContext.Attack, 1_350),
                            new(StaticEffectContext.Evade, 27),
                            new(StaticEffectContext.Defense, 245),
                            new(StaticEffectContext.Accuracy, 989)
                        }
                    },
                    {
                        50,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 13_350),
                            new(StaticEffectContext.Attack, 1_386),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 250),
                            new(StaticEffectContext.Accuracy, 994)
                        }
                    },
                    {
                        51,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 13_600),
                            new(StaticEffectContext.Attack, 1_404),
                            new(StaticEffectContext.Evade, 28),
                            new(StaticEffectContext.Defense, 255),
                            new(StaticEffectContext.Accuracy, 996)
                        }
                    },
                    {
                        52,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 13_850),
                            new(StaticEffectContext.Attack, 1_440),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 260),
                            new(StaticEffectContext.Accuracy, 1_001)
                        }
                    },
                    {
                        53,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 14_100),
                            new(StaticEffectContext.Attack, 1_458),
                            new(StaticEffectContext.Evade, 29),
                            new(StaticEffectContext.Defense, 265),
                            new(StaticEffectContext.Accuracy, 1_005)
                        }
                    },
                    {
                        54,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 14_350),
                            new(StaticEffectContext.Attack, 1_494),
                            new(StaticEffectContext.Evade, 30),
                            new(StaticEffectContext.Defense, 270),
                            new(StaticEffectContext.Accuracy, 1_009)
                        }
                    },
                    {
                        55,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 14_600),
                            new(StaticEffectContext.Attack, 1_512),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 275),
                            new(StaticEffectContext.Accuracy, 1_012)
                        }
                    },
                    {
                        56,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 14_850),
                            new(StaticEffectContext.Attack, 1_548),
                            new(StaticEffectContext.Evade, 31),
                            new(StaticEffectContext.Defense, 280),
                            new(StaticEffectContext.Accuracy, 1_016)
                        }
                    },
                    {
                        57,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 15_100),
                            new(StaticEffectContext.Attack, 1_566),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 285),
                            new(StaticEffectContext.Accuracy, 1_020)
                        }
                    },
                    {
                        58,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 15_350),
                            new(StaticEffectContext.Attack, 1_602),
                            new(StaticEffectContext.Evade, 32),
                            new(StaticEffectContext.Defense, 290),
                            new(StaticEffectContext.Accuracy, 1_025)
                        }
                    },
                    {
                        59,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 15_600),
                            new(StaticEffectContext.Attack, 1_620),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 295),
                            new(StaticEffectContext.Accuracy, 1_027)
                        }
                    },
                    {
                        60,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 15_850),
                            new(StaticEffectContext.Attack, 1_656),
                            new(StaticEffectContext.Evade, 33),
                            new(StaticEffectContext.Defense, 300),
                            new(StaticEffectContext.Accuracy, 1_032)
                        }
                    },
                    {
                        61,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 16_100),
                            new(StaticEffectContext.Attack, 1_674),
                            new(StaticEffectContext.Evade, 34),
                            new(StaticEffectContext.Defense, 305),
                            new(StaticEffectContext.Accuracy, 1_036)
                        }
                    },
                    {
                        62,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 16_350),
                            new(StaticEffectContext.Attack, 1_710),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 310),
                            new(StaticEffectContext.Accuracy, 1_040)
                        }
                    },
                    {
                        63,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 16_600),
                            new(StaticEffectContext.Attack, 1_728),
                            new(StaticEffectContext.Evade, 35),
                            new(StaticEffectContext.Defense, 315),
                            new(StaticEffectContext.Accuracy, 1_043)
                        }
                    },
                    {
                        64,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 16_850),
                            new(StaticEffectContext.Attack, 1_764),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 320),
                            new(StaticEffectContext.Accuracy, 1_047)
                        }
                    },
                    {
                        65,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 17_100),
                            new(StaticEffectContext.Attack, 1_782),
                            new(StaticEffectContext.Evade, 36),
                            new(StaticEffectContext.Defense, 325),
                            new(StaticEffectContext.Accuracy, 1_051)
                        }
                    },
                    {
                        66,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 17_350),
                            new(StaticEffectContext.Attack, 1_818),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 330),
                            new(StaticEffectContext.Accuracy, 1_055)
                        }
                    },
                    {
                        67,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 17_600),
                            new(StaticEffectContext.Attack, 1_836),
                            new(StaticEffectContext.Evade, 37),
                            new(StaticEffectContext.Defense, 335),
                            new(StaticEffectContext.Accuracy, 1_058)
                        }
                    },
                    {
                        68,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 17_850),
                            new(StaticEffectContext.Attack, 1_872),
                            new(StaticEffectContext.Evade, 38),
                            new(StaticEffectContext.Defense, 340),
                            new(StaticEffectContext.Accuracy, 1_062)
                        }
                    },
                    {
                        69,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 18_100),
                            new(StaticEffectContext.Attack, 1_890),
                            new(StaticEffectContext.Evade, 38),
                            new(StaticEffectContext.Defense, 345),
                            new(StaticEffectContext.Accuracy, 1_067)
                        }
                    },
                    {
                        70,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 18_350),
                            new(StaticEffectContext.Attack, 1_926),
                            new(StaticEffectContext.Evade, 39),
                            new(StaticEffectContext.Defense, 350),
                            new(StaticEffectContext.Accuracy, 1_071)
                        }
                    },
                    {
                        71,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 18_600),
                            new(StaticEffectContext.Attack, 1_944),
                            new(StaticEffectContext.Evade, 40),
                            new(StaticEffectContext.Defense, 354),
                            new(StaticEffectContext.Accuracy, 1_074)
                        }
                    },
                    {
                        72,
                        new Effect[]
                        {
                            new(StaticEffectContext.Hp, 18_850),
                            new(StaticEffectContext.Attack, 1_980),
                            new(StaticEffectContext.Evade, 40),
                            new(StaticEffectContext.Defense, 360),
                            new(StaticEffectContext.Accuracy, 1_078)
                        }
                    }
                });

        #endregion
    }
}