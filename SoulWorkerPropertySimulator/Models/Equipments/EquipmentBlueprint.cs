using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Equipments
{
    public sealed record EquipmentBlueprint : Blueprint<Equipment>
    {
        public EquipmentBlueprint(string                                                 name,
                                  EquipmentField                                         field,
                                  int                                                    level,
                                  int                                                    randomAmount,
                                  IReadOnlyCollection<RandomEffect>                      randomEffects,
                                  int                                                    pluginLimit,
                                  RandomEffect                                           randomQuality,
                                  IReadOnlyCollection<Effect>                            fixedEffects,
                                  ItemRare                                               rare,
                                  IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? stepEffects = null,
                                  string?                                                setName = null) : base(name,
            level,
            randomAmount,
            randomEffects,
            rare,
            fixedEffects,
            stepEffects,
            setName)
        {
            Field         = field;
            PluginLimit   = pluginLimit;
            RandomQuality = randomQuality;
        }

        public EquipmentField Field         { get; init; }
        public int            PluginLimit   { get; }
        public RandomEffect   RandomQuality { get; }

        public TagField    TagField    => Field == EquipmentField.Weapon ? TagField.Weapon : TagField.Gear;
        public PluginField PluginField => Field == EquipmentField.Weapon ? PluginField.Weapon : PluginField.Gear;

        public IReadOnlyCollection<int>? ValidStep
        {
            get
            {
                var max = GetMaxStep(Rare!.Value);
                return max == null ? null : Enumerable.Range(0, max.Value + 1).ToList();
            }
        }

        public override Equipment Create(IReadOnlyCollection<Effect> randomEffects) => new(this, 1, randomEffects);

        public decimal GetStepMagnification(int step)
        {
            if (Rare == ItemRare.Common) { return 1; }

            try { return GetMagnification(Rare!.Value)[step]; }
            catch (KeyNotFoundException) { return 1; }
        }

        #region

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

        private static IDictionary<int, decimal> GetMagnification(ItemRare rare, bool isPrimal = false) =>
            rare switch
            {
                ItemRare.Magical                 => Magical,
                ItemRare.Valuable                => Valuable,
                ItemRare.Unique                  => Unique,
                ItemRare.Legendary when isPrimal => Unique,
                ItemRare.Legendary               => Legendary,
                ItemRare.Heroic                  => throw new NotImplementedException(),
                _                                => throw new ArgumentOutOfRangeException(nameof(rare), rare, null)
            };

        private static int? GetMaxStep(ItemRare rare, bool isPrimal = false) =>
            rare switch
            {
                ItemRare.Common                  => null,
                ItemRare.Magical                 => Magical.Keys.Max(),
                ItemRare.Valuable                => Valuable.Keys.Max(),
                ItemRare.Unique                  => Unique.Keys.Max(),
                ItemRare.Legendary when isPrimal => Unique.Keys.Max(),
                ItemRare.Legendary               => Legendary.Keys.Max(),
                // ItemRare.Heroic    => Magical.Keys.Max(),
                _ => throw new ArgumentOutOfRangeException(nameof(rare), rare, null)
            };

        #endregion
    }
}