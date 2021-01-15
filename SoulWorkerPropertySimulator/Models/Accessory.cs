using System;
using System.Collections.Generic;
using System.Linq;

namespace SoulWorkerPropertySimulator.Models
{
    public record AccessoryBlueprint : Blueprint<Accessory>
    {
        public AccessoryBlueprint(string             name,
            int                                      level,
            AccessoryField                           field,
            IReadOnlyCollection<EffectRandomContext> randomEffects,
            int                                      randomEffectCount,
            string?                                  setName      = null,
            IReadOnlyCollection<Effect>?             fixedEffects = null) : base(name,
            level,
            randomEffects,
            randomEffectCount,
            null,
            setName,
            fixedEffects) =>
            Field = field;

        public AccessoryField Field { get; }

        public override Accessory Create(IReadOnlyCollection<Effect> randomEffects) => new(this, randomEffects);
    }

    public record Accessory : Item, ICreatable<AccessoryBlueprint>
    {
        internal Accessory(AccessoryBlueprint blueprint, IReadOnlyCollection<Effect> randomEffects) : base(
            blueprint.Name,
            Classify.Accessory,
            blueprint.SetName)
        {
            if (!blueprint.CheckEffectAllowed(randomEffects)) { throw new InvalidOperationException(); }

            Blueprint      = blueprint;
            SelectedEffect = randomEffects;
        }

        public          AccessoryField              Field => Blueprint.Field;
        public override IReadOnlyCollection<Effect> Effects => Blueprint.FixedEffects.Concat(SelectedEffect).ToList();
        public          AccessoryBlueprint          Blueprint { get; }
        public          IReadOnlyCollection<Effect> SelectedEffect { get; }
    }

    public record AccessorySetEffect : Item, IUpgradeable
    {
        internal AccessorySetEffect(IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> stepEffect,
            string name,
            string? inSet = null) : base(name, Classify.Accessory, inSet)
        {
            StepEffects = stepEffect;
            ValidStep   = Enumerable.Range(0, stepEffect.Select(x => x.Key).Max()).ToList();
        }

        public override IReadOnlyCollection<Effect> Effects =>
            StepEffects.Where(x => x.Key <= Step).SelectMany(x => x.Value).ToList();

        public int                                                   Step        { get; init; }
        public IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects { get; }
        public IReadOnlyCollection<int>                              ValidStep   { get; }
    }
}