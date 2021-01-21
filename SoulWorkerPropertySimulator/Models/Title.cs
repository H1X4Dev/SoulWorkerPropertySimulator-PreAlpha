using System.Collections.Generic;

namespace SoulWorkerPropertySimulator.Models
{
    public record Title : Item
    {
        public Title(string name, TitleField field, int id, IReadOnlyCollection<Effect> effects) : base(name)
        {
            Id      = id;
            Field   = field;
            Effects = effects;
        }

        public override IReadOnlyCollection<Effect> Effects { get; }

        public int        Id    { get; }
        public TitleField Field { get; }
    }
}