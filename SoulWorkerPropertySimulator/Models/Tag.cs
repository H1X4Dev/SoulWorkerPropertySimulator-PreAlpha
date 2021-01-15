using System.Collections.Generic;

namespace SoulWorkerPropertySimulator.Models
{
    public record Tag : Item
    {
        internal Tag(string name, TagRare rare, TagField field, IReadOnlyCollection<Effect> effects) : base(name,
            Classify.Armor)
        {
            Rare    = rare;
            Field   = field;
            Effects = effects;
        }

        public          TagRare                     Rare    { get; }
        public          TagField                    Field   { get; }
        public override IReadOnlyCollection<Effect> Effects { get; }
    }
}