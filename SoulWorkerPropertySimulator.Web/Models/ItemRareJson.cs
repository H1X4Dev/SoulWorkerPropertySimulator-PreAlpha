using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Web.Models
{
    public class ItemRareJson
    {
        public ItemRare     Rare    { get; set; }
        public EffectJson[] Effects { get; set; }

        public KeyValuePair<ItemRare, IReadOnlyCollection<Effect>> ToPair =>
            new(Rare, Effects.Select(x => x.Effect).ToList());
    }
}