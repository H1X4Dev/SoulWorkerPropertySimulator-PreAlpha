using System;
using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IComputeService
    {
        event Action<EffectContext, decimal>? OnChange;
    }

    internal abstract class ComputeServiceBase
    {
        protected readonly IDictionary<EffectContext, decimal> Effect;

        protected ComputeServiceBase() => Effect = new Dictionary<EffectContext, decimal>();

        public event Action<EffectContext, decimal>? OnChange;

        protected IDictionary<EffectContext, decimal> ComputeAffect(Item? before, Item? after) =>
            ComputeAffect(before?.Effects ?? Array.Empty<Effect>(), after);

        protected IDictionary<EffectContext, decimal> ComputeAffect(IEnumerable<Effect> before, Item? after) =>
            ComputeAffect(before, after?.Effects ?? Array.Empty<Effect>());

        protected IDictionary<EffectContext, decimal> ComputeAffect(IEnumerable<Effect> before,
            IEnumerable<Effect>                                                         after)
        {
            var result = new Dictionary<EffectContext, decimal>();

            foreach (var (effectContext, value) in before) { result.Add(effectContext, -value); }

            foreach (var (effectContext, value) in after)
            {
                if (result.ContainsKey(effectContext)) { result[effectContext] += value; }
                else { result.Add(effectContext, value); }
            }

            return result;
        }

        protected void NotifyChange(IEnumerable<KeyValuePair<EffectContext, decimal>> data)
        {
            foreach (var (context, value) in data)
            {
                if (Effect.ContainsKey(context)) { Effect[context] += value; }
                else { Effect[context]                             =  value; }

                OnChange?.Invoke(context, Effect[context]);
            }
        }

        protected void Invoke(EffectContext context, decimal value) { OnChange?.Invoke(context, value); }
    }
}