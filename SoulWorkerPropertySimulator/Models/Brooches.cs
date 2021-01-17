using System.Collections.Generic;

namespace SoulWorkerPropertySimulator.Models
{
    public record BroochesClassify(BroochesSeries Series, BroochesRare Rare);

    public record Brooches : Item
    {
        public Brooches(string name, BroochesType type, BroochesClassify classify, IReadOnlyCollection<Effect> effects)
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