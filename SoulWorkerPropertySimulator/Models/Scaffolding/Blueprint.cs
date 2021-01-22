using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Scaffolding
{
    public abstract record Blueprint(string                                                 Name,
                                     int                                                    Level,
                                     int                                                    RandomAmount,
                                     IReadOnlyCollection<RandomEffect>                      RandomEffects,
                                     ItemRare?                                              Rare         = null,
                                     IReadOnlyCollection<Effect>?                           FixedEffects = null,
                                     IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? StepEffects  = null,
                                     string?                                                SetName      = null)
    {
        public string FullName => $"{SetName}{Name}";

        public bool CheckEffectAllowed(IReadOnlyCollection<Effect>? effects) =>
            (effects?.Count ?? 0) == RandomAmount &&
            (effects == null ||
             !effects.GroupBy(x => x.Context).Any(x => x.Count() > 1) &&
             !effects.Any(x =>
             {
                 var (context, value) = x;
                 var target = RandomEffects.FirstOrDefault(y => y.Context.Equals(context));
                 return target == null || value < target.Min || value > target.Max;
             }));
    }

    public abstract record Blueprint<T> : Blueprint where T : Item
    {
        protected Blueprint(string                                                 Name,
                            int                                                    Level,
                            int                                                    RandomAmount,
                            IReadOnlyCollection<RandomEffect>                      RandomEffects,
                            ItemRare?                                              Rare         = null,
                            IReadOnlyCollection<Effect>?                           FixedEffects = null,
                            IReadOnlyDictionary<int, IReadOnlyCollection<Effect>>? StepEffects  = null,
                            string?                                                SetName      = null) : base(Name,
            Level,
            RandomAmount,
            RandomEffects,
            Rare,
            FixedEffects,
            StepEffects,
            SetName)
        {
        }

        public abstract T Create(IReadOnlyCollection<Effect> randomEffects);
    }
}