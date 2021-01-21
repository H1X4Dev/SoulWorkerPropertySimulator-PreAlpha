using System;
using System.Collections.Generic;
using System.Linq;

namespace SoulWorkerPropertySimulator.Models
{
    public record BroochesClassify(BroochesSeries Series, BroochesRare Rare);

    public record Brooches : Item
    {
        private readonly IReadOnlyDictionary<BroochesRare, IReadOnlyCollection<Effect>> _effects;
        private readonly BroochesRare                                                   _rare;

        public Brooches(string name,
                        BroochesSeries series,
                        BroochesType type,
                        IReadOnlyDictionary<BroochesRare, IReadOnlyCollection<Effect>> effects,
                        BroochesRare rare = BroochesRare.Tera) : base(name, Classify.Brooches)
        {
#if DEBUG
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
#endif

            Series   = series;
            Type     = type;
            _effects = effects;
            Rare     = rare;
        }

        public override IReadOnlyCollection<Effect>       Effects   => _effects[Rare];
        public          IReadOnlyCollection<BroochesRare> ValidRare => _effects.Keys.ToList();

        public BroochesRare Rare
        {
            get => _rare;
            init
            {
                if (!ValidRare.Contains(value)) { throw new IndexOutOfRangeException(); }

                _rare = value;
            }
        }

        public BroochesSeries Series { get; init; }
        public BroochesType   Type   { get; }
    }

    public record BroochesD : Item
    {
        public BroochesD(string name, BroochesType type, BroochesClassify classify, IReadOnlyCollection<Effect> effects)
            : base(name, Classify.Brooches)
        {
            Type             = type;
            BroochesClassify = classify;
            Effects          = effects;

            Id = $"{{ Name:{Name}, {BroochesClassify} }}";
        }

        public override IReadOnlyCollection<Effect> Effects { get; }

        public BroochesType     Type             { get; }
        public BroochesClassify BroochesClassify { get; }

        public string Id { get; }
    }

    public record BroochesSetEffect : Item
    {
        public BroochesSetEffect(string name, BroochesClassify classify, IReadOnlyCollection<Effect> effects) : base(
            name,
            Classify.Brooches)
        {
            Class   = classify;
            Effects = effects;
        }

        public override IReadOnlyCollection<Effect> Effects { get; }

        public BroochesClassify Class { get; }
    }
}