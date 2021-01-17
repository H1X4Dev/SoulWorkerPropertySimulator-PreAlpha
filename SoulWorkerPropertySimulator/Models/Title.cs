using System.Collections.Generic;

namespace SoulWorkerPropertySimulator.Models
{
    public record Title : Item
    {
        internal Title(string name, TitleField field, int index, IReadOnlyCollection<Effect> effects) : base(name,
            Classify.Character)
        {
            Index   = index;
            Field   = field;
            Effects = effects;
        }

        public override IReadOnlyCollection<Effect> Effects { get; }

        public int        Index { get; }
        public TitleField Field { get; }
    }
}