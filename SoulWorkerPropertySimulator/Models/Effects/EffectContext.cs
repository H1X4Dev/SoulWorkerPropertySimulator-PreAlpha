using SoulWorkerPropertySimulator.Extensions;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Models.Effects
{
    public record EffectContext
    {
        public EffectContext(Property     property,
                             Opportunity? opportunity = null,
                             decimal?     probability = null,
                             decimal?     duration    = null)
        {
            Property    = property;
            Opportunity = opportunity;
            Probability = probability;
            Duration    = duration;
        }

        public Property     Property    { get; }
        public Opportunity? Opportunity { get; }
        public decimal?     Probability { get; }
        public decimal?     Duration    { get; }

        public bool IsStatic => Probability == null;

        public string Description =>
            $"{Opportunity?.GetDescription()}{(Probability != null ? $"{Probability * 10}%機率" : "")}{(Duration != null ? $"{Duration}秒內" : "")}{Property.GetDescription()}";
    }
}