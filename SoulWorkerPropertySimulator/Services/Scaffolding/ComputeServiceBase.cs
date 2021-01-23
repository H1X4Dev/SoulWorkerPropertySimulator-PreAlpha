using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Models.Scaffolding;

namespace SoulWorkerPropertySimulator.Services.Scaffolding
{
    public interface IComputeService
    {
        event Action<EffectContext, decimal>? OnStaticChange;
        event Action<Effect, int>?            OnNonStaticChange;
    }

    internal abstract class ComputeServiceBase : IComputeService
    {
        protected readonly Dictionary<Effect, int>            NonStaticEffect = new();
        protected readonly Dictionary<EffectContext, decimal> StaticEffect    = new();

        public event Action<EffectContext, decimal>? OnStaticChange;
        public event Action<Effect, int>?            OnNonStaticChange;

        protected void ProcessAffect(Item? before, Item? after) =>
            ProcessAffect(before != null ? new[] {before} : Array.Empty<Item>(),
                after            != null ? new[] {after} : Array.Empty<Item>());

        protected void ProcessAffect(IEnumerable<Item> before, IEnumerable<Item> after)
        {
            var (staticEffect, nonStaticEffect) = Process(before.SelectMany(x => x.Effects), true);
            var (afterStatic, asterNonStatic)   = Process(after.SelectMany(x => x.Effects), false);

            // Insert afterStatic into beforeStatic
            foreach (var (context, value) in afterStatic) { InsertStatic(staticEffect, context, value); }

            // Insert afterNonStatic into beforeNonStatic
            foreach (var (effect, value) in asterNonStatic) { InsertNonStatic(nonStaticEffect, effect, value); }

            SaveStaticChange(staticEffect);
            SaveNonStaticChange(nonStaticEffect);

            static (IDictionary<EffectContext, decimal> Static, IDictionary<Effect, int> NonStatic) Process(
                IEnumerable<Effect> effects,
                bool                isOld)
            {
                var staticEffect    = new Dictionary<EffectContext, decimal>();
                var nonStaticEffect = new Dictionary<Effect, int>();

                foreach (var effect in effects)
                {
                    if (PrepareValue(effect, isOld, out var value))
                    {
                        InsertStatic(staticEffect, effect.Context, value);
                    }
                    else { InsertNonStatic(nonStaticEffect, effect, (int) value); }
                }

                return (staticEffect, nonStaticEffect);

                static bool PrepareValue(Effect effect, bool isOld, out decimal value)
                {
                    var (effectContext, v) = effect;
                    if (effectContext.IsStatic)
                    {
                        value = v * (isOld ? -1 : 1);
                        return true;
                    }

                    value = isOld ? -1 : 1;
                    return false;
                }
            }

            static void InsertStatic(IDictionary<EffectContext, decimal> target, EffectContext key, decimal value)
            {
                if (target.ContainsKey(key)) { target[key] += value; }
                else { target[key]                         =  value; }
            }

            static void InsertNonStatic(IDictionary<Effect, int> target, Effect key, int value)
            {
                if (target.ContainsKey(key)) { target[key] += value; }
                else { target[key]                         =  value; }
            }

            void SaveStaticChange(IEnumerable<KeyValuePair<EffectContext, decimal>> data)
            {
                foreach (var (context, value) in data)
                {
                    // var beforeValue = 0m;
                    if (!StaticEffect.ContainsKey(context)) { StaticEffect[context] = value; }
                    else
                    {
                        // beforeValue           =  StaticEffect[context];
                        StaticEffect[context] += value;
                    }

                    OnStaticChange?.Invoke(context, value);
                }
            }

            void SaveNonStaticChange(IEnumerable<KeyValuePair<Effect, int>> data)
            {
                foreach (var (context, value) in data)
                {
                    var beforeValue = 0;
                    if (!NonStaticEffect.ContainsKey(context)) { NonStaticEffect[context] = value; }
                    else
                    {
                        beforeValue              =  NonStaticEffect[context];
                        NonStaticEffect[context] += value;
                    }

                    OnNonStaticChange?.Invoke(context, value);
                }
            }
        }

        protected void InvokeStatic(EffectContext context, decimal value) => OnStaticChange?.Invoke(context, value);
        protected void InvokeNonStatic(Effect     effect,  int     value) => OnNonStaticChange?.Invoke(effect, value);
    }
}