using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static class PluginData
    {
        private static readonly IDictionary<PluginField, IReadOnlyCollection<PluginBlueprint>> PluginResult =
            new Dictionary<PluginField, IReadOnlyCollection<PluginBlueprint>>();

        internal static IReadOnlyCollection<PluginBlueprint> Get(PluginField field)
        {
            if (PluginResult.ContainsKey(field)) { return PluginResult[field]; }

            var result = new List<PluginBlueprint>();

            return PluginResult[field] = result;
        }
    }
}