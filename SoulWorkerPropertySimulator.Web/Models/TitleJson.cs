using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Web.Models
{
    public class TitleJson
    {
        public TitleField Field { get; set; }
        public int        Id    { get; set; }

        public string Name { get; set; } = "";

        public EffectJson[] Effect { get; set; } = Array.Empty<EffectJson>();

        public Title Title => new Title(Field, Id, Name, Effect.Select(x => x.Effect).ToList());
    }
}