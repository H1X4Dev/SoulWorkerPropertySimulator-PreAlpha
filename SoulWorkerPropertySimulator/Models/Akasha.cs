using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Models
{
    public record Akasha : Item
    {
        private readonly TagBase _base;

        private readonly int _step;

        internal Akasha(string name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> effects) : base(name)
        {
            _base = new(name, effects);
            _step = effects.Keys.Min();
        }

        public bool IsSecret
        {
            get => _step < 0;
            init
            {
                if (_base.Effects.Keys.Min() > 0) { throw new InvalidOperationException(); }

                _step = GetValidValue(-(_step - 1));
            }
        }

        public int Step
        {
            get => Math.Abs(_step);
            init => _step = GetValidValue(_step * (IsSecret ? -1 : 1));
        }

        public override IReadOnlyCollection<Effect> Effects => _base.Effects[_step];


        private int GetValidValue(int target)
        {
            if (target > 0 && target > _base.Effects.Keys.Max()) { return _base.Effects.Keys.Max(); }

            if (target < 0 && target < _base.Effects.Keys.Min()) { return _base.Effects.Keys.Min(); }

            return target;
        }

        private record TagBase(string Name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> Effects);
    }
}