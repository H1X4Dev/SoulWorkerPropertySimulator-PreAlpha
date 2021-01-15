using System.Collections.Generic;

namespace SoulWorkerPropertySimulator.Models
{
    public record BroochesClassify(BroochesSeries Series, BroochesRare Rare);

    public record Brooches : Item
    {
        internal Brooches(string        name,
            BroochesType                type,
            BroochesClassify            classify,
            IReadOnlyCollection<Effect> effects) : base(name, Classify.Brooches)
        {
            Type             = type;
            BroochesClassify = classify;
            Effects          = effects;

            Id = $"{{ Name:{Name}, {BroochesClassify} }}";
        }

        public          BroochesType                Type             { get; }
        public          BroochesClassify            BroochesClassify { get; }
        public override IReadOnlyCollection<Effect> Effects          { get; }

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

        public          BroochesClassify            Class   { get; }
        public override IReadOnlyCollection<Effect> Effects { get; }
    }
}