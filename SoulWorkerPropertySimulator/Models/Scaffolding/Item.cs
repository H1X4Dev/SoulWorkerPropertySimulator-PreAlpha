using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models.Effects;

namespace SoulWorkerPropertySimulator.Models.Scaffolding
{
    public abstract record Item(string Name, string? SetName = null)
    {
        public string FullName => $"{SetName}{Name}";

        public abstract IReadOnlyCollection<Effect> Effects { get; }
    }
}