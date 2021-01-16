using Microsoft.AspNetCore.Components;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Web.Shared
{
    public abstract class ItemGenerator<T> : ComponentBase where T : Item
    {
        public abstract T? Item { get; }
    }
}