using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        private static readonly Dictionary<BroochesType, IReadOnlyCollection<Brooch>> Result = new();

        internal static void Create(ShareEffect share)
        {
            Brooches = SetupSd(share).Concat(SetupBsk(share)).Concat(SetupFot(share)).Concat(SetupSin(share)).ToList();

#if DEBUG
            if (Brooches.Count != 45 + 17 * 3 + 30 + 30)
            {
                Console.WriteLine(Brooches.Count);
                throw new IndexOutOfRangeException();
            }

            if (Brooches.Any(x => x == null)) { throw new InvalidOperationException(); }
#endif
        }

        internal static IReadOnlyCollection<Brooch> Get(BroochesType type)
        {
            if (Result.ContainsKey(type)) { return Result[type]; }

            return Result[type] = Brooches.Where(x => x.Type == type).ToList();
        }

        #region

        private static IReadOnlyCollection<Brooch> Brooches { get; set; } = null!;

        #endregion
    }
}