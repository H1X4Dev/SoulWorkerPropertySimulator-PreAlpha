using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models
{
    public record Title : Item
    {
        public Title(TitleField field, int id, string name, IReadOnlyCollection<Effect> effects) : base(name)
        {
            Field   = field;
            Id      = id;
            Effects = effects;
        }

        public override IReadOnlyCollection<Effect> Effects { get; }

        public int        Id    { get; }
        public TitleField Field { get; }
    }
}