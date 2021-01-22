using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models
{
    public record Tag : Item
    {
        private readonly TagBase _base;

        private readonly ItemRare _rare;

        public Tag(TagField                                                   field,
                   string                                                     name,
                   IReadOnlyDictionary<ItemRare, IReadOnlyCollection<Effect>> effects,
                   ItemRare                                                   rare = ItemRare.Heroic) : base(name)
        {
            _base = new(field, name, effects);
            Field = field;
            Rare  = rare;
        }

        public override IReadOnlyCollection<Effect>   Effects   => _base.Effects[Rare];
        public          IReadOnlyCollection<ItemRare> ValidRare => _base.Effects.Keys.ToList();

        public TagField Field
        {
            get => _base.Field;
            init => _base = _base with {Field = value};
        }

        public ItemRare Rare
        {
            get => _rare;
            init
            {
                if (!ValidRare.Contains(value)) { throw new InvalidOperationException(); }

                _rare = value;
            }
        }

        public virtual bool Equals(Tag? other) => _base.Equals(other?._base);

        public override int GetHashCode() => _base.GetHashCode();

        private record TagBase(TagField                                                   Field,
                               string                                                     Name,
                               IReadOnlyDictionary<ItemRare, IReadOnlyCollection<Effect>> Effects);
    }
}