using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SoulWorkerPropertySimulator.Extensions;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Brooches
{
    public record Brooch : Item
    {
        private readonly BroochBase _base;

        private readonly BroochesRare _rare;

        public Brooch(string name,
                      BroochesSeries series,
                      BroochesType type,
                      IReadOnlyDictionary<BroochesRare, IReadOnlyCollection<Effect>> effects,
                      BroochesRare rare = BroochesRare.Tera) : base(name)
        {
            DebugCheck(name, effects);

            _base = new(name, series, type, effects);
            Rare  = rare;
        }

        public override IReadOnlyCollection<Effect>       Effects   => _base.Effects[Rare];
        public          IReadOnlyCollection<BroochesRare> ValidRare => _base.Effects.Keys.ToList();
        public          BroochesType                      Type      => _base.Type;

        public BroochesRare Rare
        {
            get => _rare;
            init
            {
                if (!ValidRare.Contains(value)) { throw new IndexOutOfRangeException(); }

                _rare = value;
            }
        }

        public BroochesSeries Series
        {
            get => _base.Series;
            init => _base = _base with {Series = value};
        }

        public string DisplayName => $"{Series.GetDescription()}：{Name}";

        public virtual bool Equals(Brooch? other) => _base.Equals(other?._base);

        public override int GetHashCode() => _base.GetHashCode();

        #region

        [Conditional("DEBUG")]
        private static void DebugCheck(string                                                         name,
                                       IReadOnlyDictionary<BroochesRare, IReadOnlyCollection<Effect>> effects)
        {
            if (!name.Equals("對策"))
            {
                var cache = 0m;
                foreach (var (_, effect) in effects.OrderBy(x => x.Key))
                {
                    if (cache == 0m) { cache = effect.First().Value; }
                    else
                    {
                        if (cache > effect.First().Value) { throw new IndexOutOfRangeException(); }

                        if (cache == effect.First().Value && effect.Count != 2)
                        {
                            throw new InvalidOperationException();
                        }

                        cache = effect.First().Value;
                    }
                }
            }
        }

        #endregion

        private record BroochBase(string                                                         Name,
                                  BroochesSeries                                                 Series,
                                  BroochesType                                                   Type,
                                  IReadOnlyDictionary<BroochesRare, IReadOnlyCollection<Effect>> Effects);
    }
}