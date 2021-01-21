using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
#pragma warning disable CS0649
        private static readonly IReadOnlyCollection<Brooches>                            Brooches;
        private static readonly Dictionary<BroochesClass, IReadOnlyCollection<Brooches>> Result = new();
#pragma warning restore CS0649

#pragma warning disable CS8618
        static BroochesData()
        {
            SetupSd();
            SetupBsk();
            SetupFot();
            SetupSin();

            Brooches = new List<Brooches>
            {
                #region Sd

                _sdA1,
                _sdA2,
                _sdA3,
                _sdA4,
                _sdA5,
                _sdA6,
                _sdA7,
                _sdA8,
                _sdA9,
                _sdA10,
                _sdA11,
                _sdA12,
                _sdA13,
                _sdA14,
                _sdA15,
                _sdD1,
                _sdD2,
                _sdD3,
                _sdD4,
                _sdD5,
                _sdD6,
                _sdD7,
                _sdD8,
                _sdD9,
                _sdD10,
                _sdD11,
                _sdD12,
                _sdD13,
                _sdD14,
                _sdD15,
                _sdE1,
                _sdE2,
                _sdE3,
                _sdE4,
                _sdE5,
                _sdE6,
                _sdE7,
                _sdE8,
                _sdE9,
                _sdE10,
                _sdE11,
                _sdE12,
                _sdE13,
                _sdE14,
                _sdE15,

                #endregion

                #region Bsk

                _bskA1,
                _bskA2,
                _bsk3,
                _bskA4,
                _bskA5,
                _bskA6,
                _bskA7,
                _bskA8,
                _bskA9,
                _bskA10,
                _bskA11,
                _bskA12,
                _bskA13,
                _bskA14,
                _bskA15,
                _bskA16,
                _bskA17,
                _bskD1,
                _bskD2,
                _bskD3,
                _bskD4,
                _bskD5,
                _bskD6,
                _bskD7,
                _bskD8,
                _bskD9,
                _bskD10,
                _bskD11,
                _bskD12,
                _bskD13,
                _bskD14,
                _bskD15,
                _bskD16,
                _bskD17,
                _bskE1,
                _bskE2,
                _bskE3,
                _bskE4,
                _bskE5,
                _bskE6,
                _bskE7,
                _bskE8,
                _bskE9,
                _bskE10,
                _bskE11,
                _bskE12,
                _bskE13,
                _bskE14,
                _bskE15,
                _bskE16,
                _bskE17,

                #endregion

                #region Fot

                _fotA1,
                _fotA2,
                _fotA3,
                _fotA4,
                _fotA5,
                _fotA6,
                _fotA7,
                _fotA8,
                _fotA9,
                _fotA10,
                _fotD1,
                _fotD2,
                _fotD3,
                _fotD4,
                _fotD5,
                _fotD6,
                _fotD7,
                _fotD8,
                _fotD9,
                _fotD10,
                _fotE1,
                _fotE2,
                _fotE3,
                _fotE4,
                _fotE5,
                _fotE6,
                _fotE7,
                _fotE8,
                _fotE9,
                _fotE10,

                #endregion

                #region Sin

                _sinA1,
                _sinA2,
                _sinA3,
                _sinA4,
                _sinA5,
                _sinA6,
                _sinA7,
                _sinA8,
                _sinA9,
                _sinA10,
                _sinD1,
                _sinD2,
                _sinD3,
                _sinD4,
                _sinD5,
                _sinD6,
                _sinD7,
                _sinD8,
                _sinD9,
                _sinD10,
                _sinE1,
                _sinE2,
                _sinE3,
                _sinE4,
                _sinE5,
                _sinE6,
                _sinE7,
                _sinE8,
                _sinE9,
                _sinE10,

                #endregion
            };
        }
#pragma warning restore CS8618

        internal static IReadOnlyCollection<Brooches> Get(BroochesSeries series, BroochesType type)
        {
            var classify = new BroochesClass(series, type);
            if (Result.ContainsKey(classify)) { return Result[classify]; }

            return Result[classify] = Brooches.Where(x => x.Series == series && x.Type == type).ToList();
        }

        private record BroochesClass(BroochesSeries Series, BroochesType Type);
    }
}