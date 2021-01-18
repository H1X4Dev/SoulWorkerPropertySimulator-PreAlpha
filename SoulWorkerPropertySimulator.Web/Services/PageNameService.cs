using System;

namespace SoulWorkerPropertySimulator.Web.Services
{
    public interface IPageNameService
    {
        event Action<string?>? OnChange;
        void                   Set(string? name);
    }

    public class PageNameService : IPageNameService
    {
        public event Action<string?>? OnChange;
        public void                   Set(string? name) => OnChange?.Invoke(name);
    }
}