using System;
using System.Collections.Generic;
using System.Linq;

namespace SoulWorkerPropertySimulator.Models
{
    public record Tag : Item
    {
        private readonly IReadOnlyDictionary<TagRare, IReadOnlyCollection<Effect>> _effects;
        private readonly TagRare                                                   _rare;

        public Tag(string                                                    name,
                   TagField                                                  field,
                   IReadOnlyDictionary<TagRare, IReadOnlyCollection<Effect>> effects,
                   TagRare                                                   rare = TagRare.Heroic) : base(name)
        {
            Field    = field;
            _effects = effects;
            Rare     = rare;
        }

        public override IReadOnlyCollection<Effect>  Effects   => _effects[Rare];
        public          IReadOnlyCollection<TagRare> ValidRare => _effects.Keys.ToList();

        public TagField Field { get; }

        public TagRare Rare
        {
            get => _rare;
            init
            {
                if (!ValidRare.Contains(value)) { throw new IndexOutOfRangeException(); }

                _rare = value;
            }
        }
    }

    public record TagD : Item
    {
        public TagD(string name, TagRare rare, TagField field, IReadOnlyCollection<Effect> effects) : base(name)
        {
            Rare    = rare;
            Field   = field;
            Effects = effects;
        }

        public override IReadOnlyCollection<Effect> Effects { get; }

        public TagRare  Rare  { get; }
        public TagField Field { get; }
    }
}