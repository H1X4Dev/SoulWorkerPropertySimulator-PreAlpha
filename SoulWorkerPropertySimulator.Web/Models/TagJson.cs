using System;
using System.Linq;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Web.Models
{
    public class TagJson
    {
        public TagField       Field { get; set; }
        public string         Name  { get; set; } = "";
        public ItemRareJson[] Rares { get; set; } = Array.Empty<ItemRareJson>();

        public Tag Tag => new(Field, Name, Rares.Select(x => x.ToPair).ToDictionary(x => x.Key, x => x.Value));
    }
}