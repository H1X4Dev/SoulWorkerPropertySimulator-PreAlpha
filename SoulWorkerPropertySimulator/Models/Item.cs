using System;
using System.Collections.Generic;
using System.Linq;

namespace SoulWorkerPropertySimulator.Models
{
    public abstract record Item
    {
        protected Item(string name, Classify classify, string? setName = null)
        {
            Name     = name;
            Classify = classify;
            SetName  = setName;
        }

        public string   Name     { get; }
        public string?  SetName  { get; }
        public Classify Classify { get; }

        public string FullName => $"{SetName}{Name}";

        public abstract IReadOnlyCollection<Effect> Effects { get; }
    }

    public interface ICreatable<out TBlueprint> where TBlueprint : Blueprint
    {
        TBlueprint                         Blueprint      { get; }
        public IReadOnlyCollection<Effect> SelectedEffect { get; }
    }

    public abstract record Blueprint
    {
        protected Blueprint(string                                                 name,
                            int                                                    level,
                            IReadOnlyCollection<EffectRandomContext>               randomEffects,
                            int                                                    randomEffectCount,
                            IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? stepEffects  = null,
                            string?                                                setName      = null,
                            IReadOnlyCollection<Effect>?                           fixedEffects = null)
        {
            Name              = name;
            Level             = level;
            RandomEffects     = randomEffects;
            RandomEffectCount = randomEffectCount;
            StepEffects       = stepEffects ?? new Dictionary<int, IReadOnlyCollection<Effect>>();
            SetName           = setName;
            FixedEffects      = fixedEffects ?? Array.Empty<Effect>();
        }

        public string                                                Name              { get; init; }
        public int                                                   Level             { get; }
        public IReadOnlyCollection<EffectRandomContext>              RandomEffects     { get; }
        public int                                                   RandomEffectCount { get; }
        public string?                                               SetName           { get; }
        public IReadOnlyCollection<Effect>                           FixedEffects      { get; init; }
        public IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects       { get; init; }

        public string FullName => $"{SetName}{Name}";

        public bool CheckEffectAllowed(IReadOnlyCollection<Effect>? effects) =>
            effects                 == null
                ? RandomEffectCount == 0
                : effects.Count == RandomEffectCount                       &&
                  effects.GroupBy(x => x.Context).All(x => x.Count() == 1) &&
                  effects.All(x =>
                  {
                      var (context, value) = x;
                      var tmp = RandomEffects.FirstOrDefault(y => y.Context.Equals(context));
                      return tmp != null && value >= tmp.Min && value <= tmp.Max;
                  });
    }

    public abstract record Blueprint<T> : Blueprint where T : Item
    {
        protected Blueprint(string                                                 name,
                            int                                                    level,
                            IReadOnlyCollection<EffectRandomContext>               randomEffects,
                            int                                                    randomEffectCount,
                            IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? stepEffects  = null,
                            string?                                                setName      = null,
                            IReadOnlyCollection<Effect>?                           fixedEffects = null) : base(name,
            level,
            randomEffects,
            randomEffectCount,
            stepEffects,
            setName,
            fixedEffects)
        {
        }

        public abstract T Create(IReadOnlyCollection<Effect> randomEffects);
    }

    public abstract record RandomValueBlueprint<T> : Blueprint where T : Item
    {
        protected RandomValueBlueprint(string name,
                                       int level,
                                       IReadOnlyCollection<EffectRandomContext> randomEffects,
                                       int randomEffectCount,
                                       IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? stepEffects = null,
                                       string? setName = null,
                                       IReadOnlyCollection<Effect>? fixedEffects = null) : base(name,
            level,
            randomEffects,
            randomEffectCount,
            stepEffects,
            setName,
            fixedEffects)
        {
        }

        // public abstract T Create(decimal ratio, IReadOnlyCollection<Effect> randomEffects);
    }

    public interface IRandomGenerator
    {
        Property RandomProperty { get; }
        int      MinValue       { get; }
        int      MaxValue       { get; }
    }

    public interface IRandomProperty
    {
        Property Property      { get; }
        decimal  SelectedRatio { get; }
    }

    public interface IUpgradeable
    {
        int                                                   Step        { get; }
        IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects { get; }
        IReadOnlyCollection<int>                              ValidStep   { get; }
    }
}