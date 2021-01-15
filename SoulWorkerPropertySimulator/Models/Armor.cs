using System;
using System.Collections.Generic;
using System.Linq;

namespace SoulWorkerPropertySimulator.Models
{
    public sealed record ArmorBlueprint : RandomValueBlueprint<Armor>, IRandomGenerator
    {
        public ArmorBlueprint(string                               name,
            ArmorField                                             field,
            int                                                    level,
            ArmorRare                                              rare,
            int                                                    pluginLimit,
            IReadOnlyCollection<EffectRandomContext>               randomEffects,
            int                                                    randomEffectCount,
            Property                                               randomProperty,
            int                                                    minValue,
            int                                                    maxValue,
            IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? stepEffects  = null,
            string?                                                setName      = null,
            IReadOnlyCollection<Effect>?                           fixedEffects = null) : base(name,
            level,
            randomEffects,
            randomEffectCount,
            stepEffects ?? new Dictionary<int, IReadOnlyCollection<Effect>>(),
            setName,
            fixedEffects)
        {
            Field          = field;
            Rare           = rare;
            PluginLimit    = pluginLimit;
            RandomProperty = randomProperty;
            MinValue       = minValue;
            MaxValue       = maxValue;
        }

        public ArmorField               Field       { get; }
        public ArmorRare                Rare        { get; }
        public int                      PluginLimit { get; }
        public IReadOnlyCollection<int> ValidStep   => Enumerable.Range(0, StepEffects.Keys.Max()).ToList();

        private static IDictionary<int, decimal> Legendary =>
            new Dictionary<int, decimal>
            {
                {0, 1},
                {1, 1.07m},
                {2, 1.17m},
                {3, 1.31m},
                {4, 1.54m},
                {5, 1.91m},
                {6, 2.47m},
                {7, 3.24m},
                {8, 4.36m},
                {9, 5}
            };

        private static IDictionary<int, decimal> Unique =>
            new Dictionary<int, decimal>
            {
                {0, 1},
                {1, 1.07m},
                {2, 1.18m},
                {3, 1.4m},
                {4, 1.71m},
                {5, 2.1m},
                {6, 2.59m},
                {7, 3.16m},
                {8, 4.82m},
                {9, 4.6m}
            };

        private static IDictionary<int, decimal> Valuable =>
            new Dictionary<int, decimal>
            {
                {0, 1},
                {1, 1.05m},
                {2, 1.13m},
                {3, 1.3m},
                {4, 1.53m},
                {5, 1.84m},
                {6, 2.2m},
                {7, 2.63m},
                {8, 3.12m},
                {9, 3.7m}
            };

        private static IDictionary<int, decimal> Magical =>
            new Dictionary<int, decimal>
            {
                {0, 1},
                {1, 1.05m},
                {2, 1.12m},
                {3, 1.25m},
                {4, 1.43m},
                {5, 1.66m},
                {6, 1.94m},
                {7, 2.28m},
                {8, 2.66m},
                {9, 3.1m}
            };

        public Property RandomProperty { get; }
        public int      MinValue       { get; }
        public int      MaxValue       { get; }

        public Armor Create(decimal      ratio,
            IReadOnlyCollection<Effect>  randomEffects,
            IReadOnlyCollection<Plugin>? plugins = null,
            Tag?                         tag     = null) =>
            new(this, ratio, randomEffects) {Plugins = plugins ?? Array.Empty<Plugin>(), Tag = tag};

        public Effect ComputePropertyValue(int value, int step)
        {
            if (Rare == ArmorRare.Common) { return new Effect(new EffectContext(RandomProperty), value); }

            try { return new Effect(new EffectContext(RandomProperty), value * GetMagnification(Rare)[step]); }
            catch (KeyNotFoundException) { return new Effect(new EffectContext(RandomProperty), MaxValue); }
        }

        private static IDictionary<int, decimal> GetMagnification(ArmorRare rare, bool isPrimal = false) =>
            rare switch
            {
                ArmorRare.Magical                 => Magical,
                ArmorRare.Valuable                => Valuable,
                ArmorRare.Unique                  => Unique,
                ArmorRare.Legendary when isPrimal => Unique,
                ArmorRare.Legendary               => Legendary,
                ArmorRare.Heroic                  => throw new NotImplementedException(),
                _                                 => throw new ArgumentOutOfRangeException(nameof(rare), rare, null)
            };
    }

    public record Armor : Item, ICreatable<ArmorBlueprint>, IRandomProperty, IUpgradeable
    {
        internal Armor(ArmorBlueprint blueprint, decimal ratio, IReadOnlyCollection<Effect> randomEffects) : base(
            blueprint.Name,
            Classify.Armor,
            blueprint.SetName)
        {
            if (!blueprint.CheckEffectAllowed(randomEffects) || ratio < 0 || ratio > 1)
            {
                throw new InvalidOperationException();
            }

            Plugins        = Array.Empty<Plugin>();
            Blueprint      = blueprint;
            SelectedEffect = randomEffects;
            SelectedRatio  = ratio;
            Step           = StepEffects.Keys.Max();
            Plugins        = new List<Plugin>();
        }

        public Tag?                        Tag         { get; init; }
        public IReadOnlyCollection<Plugin> Plugins     { get; init; }
        public ArmorField                  Field       => Blueprint.Field;
        public int                         PluginLimit => Blueprint.PluginLimit;

        public int SelectedValue =>
            (int) Math.Round((Blueprint.MinValue - Blueprint.MaxValue) * SelectedRatio, 0) + Blueprint.MinValue;

        public override IReadOnlyCollection<Effect> Effects =>
            Blueprint.FixedEffects.Concat(SelectedEffect)
                .Concat(new[] {PropertyEffect})
                .Concat(StepEffects.Where(x => x.Key <= Step).SelectMany(x => x.Value))
                .Concat(Plugins.Where(x => x         != null).SelectMany(x => x!.Effects))
                .Concat(Tag?.Effects ?? Array.Empty<Effect>())
                .ToList();

        public int Level => Blueprint.Level;

        private Effect PropertyEffect => Blueprint.ComputePropertyValue(SelectedValue, Step);

        public ArmorBlueprint                                        Blueprint      { get; }
        public IReadOnlyCollection<Effect>                           SelectedEffect { get; init; }
        public decimal                                               SelectedRatio  { get; init; }
        public Property                                              Property       => Blueprint.RandomProperty;
        public int                                                   Step           { get; init; }
        public IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects    => Blueprint.StepEffects;
        public IReadOnlyCollection<int>                              ValidStep      => Blueprint.ValidStep;

        public int CalcEffectByLevel(int enemyLevel) =>
            (int) (PropertyEffect.Value * CalcLevelGapWeaken(enemyLevel - Level) * CalcRareWeaken(Blueprint.Rare));

        private static decimal CalcLevelGapWeaken(int gap) =>
            gap switch
            {
                <= 5 => 1,
                6    => .9m,
                7    => .8m,
                8    => .7m,
                9    => .6m,
                10   => .5m,
                11   => .4m,
                12   => .3m,
                13   => .2m,
                14   => .1m,
                _    => .01m
            };

        private static decimal CalcRareWeaken(ArmorRare rare) =>
            rare switch
            {
                ArmorRare.Common   => .1m,
                ArmorRare.Magical  => .2m,
                ArmorRare.Valuable => .4m,
                ArmorRare.Unique   => .6m,
                _                  => 1
            };
    }

    public record ArmorSetEffect : Item, IUpgradeable
    {
        internal ArmorSetEffect(string name, IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> stepEffects) : base(
            name,
            Classify.Accessory,
            name)
        {
            StepEffects = stepEffects;
            ValidStep   = Enumerable.Range(0, stepEffects.Select(x => x.Key).Max()).ToList();
        }

        public override IReadOnlyCollection<Effect> Effects =>
            StepEffects.Where(x => x.Key <= Step).SelectMany(x => x.Value).ToList();

        public int                                                   Step        { get; init; }
        public IReadOnlyDictionary<int, IReadOnlyCollection<Effect>> StepEffects { get; }
        public IReadOnlyCollection<int>                              ValidStep   { get; }
    }
}