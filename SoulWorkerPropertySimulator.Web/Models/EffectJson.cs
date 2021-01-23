using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Web.Models
{
    public class EffectJson
    {
        public Property     Property    { get; set; }
        public Opportunity? Opportunity { get; set; }
        public decimal?     Probability { get; set; }
        public decimal?     Duration    { get; set; }
        public decimal      Value       { get; set; }

        public Effect Effect => new(new(Property, Opportunity, Probability, Duration), Value);
    }
}