using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
#pragma warning disable CS8618
#pragma warning disable CS8604
        static BroochesData()
        {
            Brooches = SetupSd().Concat(SetupBsk()).Concat(SetupFot()).Concat(SetupSin()).ToList();

#if DEBUG
            if (Brooches.Count != 45 + 17 * 3 + 30 + 30)
            {
                Console.WriteLine(Brooches.Count);
                throw new IndexOutOfRangeException();
            }

            if (Brooches.Any(x => x == null)) { throw new InvalidOperationException(); }
#endif
        }
#pragma warning restore CS8604
#pragma warning restore CS8618

        internal static IReadOnlyCollection<Brooches> Get(BroochesType type)
        {
            if (Result.ContainsKey(type)) { return Result[type]; }

            return Result[type] = Brooches.Where(x => x.Type == type).ToList();
        }
#pragma warning disable CS0649
        private static readonly IReadOnlyCollection<Brooches>                           Brooches;
        private static readonly Dictionary<BroochesType, IReadOnlyCollection<Brooches>> Result = new();
#pragma warning restore CS0649
    }
}