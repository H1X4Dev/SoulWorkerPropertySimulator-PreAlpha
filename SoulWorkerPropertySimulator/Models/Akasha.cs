using System;
using System.Collections.Generic;

namespace SoulWorkerPropertySimulator.Models
{
    public record Akasha : Item
    {
        internal Akasha(string name, bool isSecret, int step, IReadOnlyCollection<Effect> effects) : base(name)
        {
            Step     = step;
            IsSecret = isSecret;
            Effects  = effects;
        }

        internal Akasha(string name, bool isSecret, int step, string skill) : base(name)
        {
            Step     = step;
            IsSecret = isSecret;
            Skill    = skill;
        }

        public override IReadOnlyCollection<Effect> Effects { get; } = Array.Empty<Effect>();

        public bool    IsSecret { get; }
        public int     Step     { get; }
        public string? Skill    { get; }

        public bool IsPassive => Skill == null;
    }
}