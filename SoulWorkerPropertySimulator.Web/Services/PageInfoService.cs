using System;

namespace SoulWorkerPropertySimulator.Web.Services
{
    public interface IPageInfoService
    {
        event Action<string?>? OnTitleChange;
        event Action<string?>? OnBottomChange;
        void                   SetTitle(string?  name);
        void                   SetBottom(string? html);
    }

    public class PageInfoService : IPageInfoService
    {
        public event Action<string?>? OnTitleChange;
        public event Action<string?>? OnBottomChange;
        public void                   SetTitle(string?  name) => OnTitleChange?.Invoke(name);
        public void                   SetBottom(string? html) => OnBottomChange?.Invoke(html);
    }
}