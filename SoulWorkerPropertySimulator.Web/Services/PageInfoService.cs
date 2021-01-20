using System;

namespace SoulWorkerPropertySimulator.Web.Services
{
    public interface IPageInfoService
    {
        event Action<string?>? OnTitleChange;
        event Action<string?>? OnBottomChange;
        void                   SetTitle(string  caller, string? name);
        void                   SetBottom(string caller, string? html);
    }

    public class PageInfoService : IPageInfoService
    {
        private string?               _lastCaller;
        public event Action<string?>? OnTitleChange;
        public event Action<string?>? OnBottomChange;

        public void SetTitle(string caller, string? name)
        {
            if (name == null && (!_lastCaller?.Equals(caller) ?? false)) { return; }

            _lastCaller = caller;
            OnTitleChange?.Invoke(name);
        }

        public void SetBottom(string caller, string? html)
        {
            if (html == null && (!_lastCaller?.Equals(caller) ?? false)) { return; }

            _lastCaller = caller;
            OnBottomChange?.Invoke(html);
        }
    }
}