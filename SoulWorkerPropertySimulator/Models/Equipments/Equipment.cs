using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Plugins;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Equipments
{
    public record Equipment : Item
    {
        private readonly decimal _ratio;
        private readonly int?    _step;

        internal Equipment(EquipmentBlueprint blueprint, decimal ratio, IReadOnlyCollection<Effect> randomEffects) :
            base(blueprint.Name, blueprint.SetName)
        {
            if (!blueprint.CheckEffectAllowed(randomEffects) || ratio < 0 || ratio > 1)
            {
                throw new InvalidOperationException();
            }

            Blueprint      = blueprint;
            SelectedEffect = randomEffects;
            _step          = blueprint.ValidStep?.Max();
            _ratio         = ratio;
        }

        public IReadOnlyCollection<Plugin> Plugins        { get; init; } = Array.Empty<Plugin>();
        public Tag?                        Tag            { get; init; }
        public EquipmentBlueprint          Blueprint      { get; }
        public IReadOnlyCollection<Effect> SelectedEffect { get; }

        public EquipmentField Field       => Blueprint.Field;
        public int            PluginLimit => Blueprint.PluginLimit;

        public decimal Ratio
        {
            get => _ratio;
            init
            {
                if (value < 0 || value > 1) { throw new InvalidOperationException(); }

                _ratio = value;
            }
        }

        private int Quality =>
            (int) ((Blueprint.RandomQuality.Max - Blueprint.RandomQuality.Min) * _ratio + Blueprint.RandomQuality.Min);

        public int? Step
        {
            get => _step;
            init
            {
                if ((_step == null) ^ (value == null)) { throw new InvalidOperationException(); } //1001

                _step = value;
            }
        }

        public override IReadOnlyCollection<Effect> Effects
        {
            get
            {
                var result = SelectedEffect.Concat(Plugins.Where(x => x != null).SelectMany(x => x!.Effects))
                    .Concat(Tag?.Effects           ?? Array.Empty<Effect>())
                    .Concat(Blueprint.FixedEffects ?? Array.Empty<Effect>())
                    .Concat(Blueprint.StepEffects?.Where(x => x.Key <= Step).SelectMany(x => x.Value) ??
                            Array.Empty<Effect>())
                    .ToList();

                var propertyName = $"{Blueprint.TagField:G}{Blueprint.RandomQuality.Context.Property:G}";
                var influentialEffect = result.Where(x =>
                        x.Context.IsStatic && x.Context.Property.ToString("G").StartsWith(propertyName))
                    .ToList();

                var valueList = influentialEffect.Select(x => (x.Context.Property.ToString("G"), x.Value))
                    .ToList<(string Name, decimal Value)>();
                result.Add(new(Blueprint.RandomQuality.Context,
                    (int) ((Quality + (int) valueList.Where(x => !x.Name.Contains("Rate")).Sum(x => x.Value)) *
                           (Step == null ? 1 : Blueprint.GetStepMagnification(Step.Value))                    *
                           (1 + valueList.Where(x => x.Name.Contains("Rate")).Sum(x => x.Value)))));

                influentialEffect.ForEach(x => result.Remove(x));

                return result.GroupBy(x => x.Context).Select(x => new Effect(x.Key, x.Sum(y => y.Value))).ToList();
            }
        }

        #region

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

        private static decimal CalcRareWeaken(ItemRare rare) =>
            rare switch
            {
                ItemRare.Common   => .1m,
                ItemRare.Magical  => .2m,
                ItemRare.Valuable => .4m,
                ItemRare.Unique   => .6m,
                _                 => 1
            };

        #endregion
    }
}