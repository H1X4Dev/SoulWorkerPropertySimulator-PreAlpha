using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Models
{
    public record Character : Item
    {
        private readonly CharacterBase _base;

        private readonly int _step;

        public Character(string                                                name,
                         IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> stepEffect,
                         int?                                                  bonusSkillLevel = null,
                         IReadOnlyCollection<Effect>?                          bonusSkill      = null) : base(name)
        {
            if ((bonusSkillLevel == null) ^ (bonusSkill == null)) { throw new InvalidOperationException(); } // 1001

            _base = new(name, stepEffect, bonusSkillLevel, bonusSkill);
            Step  = stepEffect.Max(x => x.Key);
        }

        public Title? First { get; init; }
        public Title? Last  { get; init; }

        public override IReadOnlyCollection<Effect> Effects =>
            _base.StepEffects[Step]
                .Concat(First?.Effects ?? Array.Empty<Effect>())
                .Concat(Last?.Effects  ?? Array.Empty<Effect>())
                .Concat(EnableBonus && _base.BonusSkill != null ? _base.BonusSkill : Array.Empty<Effect>())
                .ToList();

        public bool EnableBonus { get; init; }

        public IReadOnlyCollection<int> ValidStep => _base.StepEffects.Keys.ToList();

        public int Step
        {
            get => _step;
            init
            {
                if (!ValidStep.Contains(value)) { throw new InvalidOperationException(); }

                _step = value;
            }
        }

        public virtual bool Equals(Character? other) => _base.Equals(other?._base);

        public override int GetHashCode() => _base.GetHashCode();

        private record CharacterBase(string                                                Name,
                                     IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects,
                                     int?                                                  BonusSkillLevel,
                                     IReadOnlyCollection<Effect>?                          BonusSkill);
    }
}