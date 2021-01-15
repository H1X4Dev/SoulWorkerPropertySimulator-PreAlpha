using System;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface ITitleComputeService : IComputeService
    {
        Title? Get(TitleField   field);
        void   Change(Title?    newItem);
        void   Clear(TitleField field);
    }

    internal class TitleComputeService : ComputeServiceBase, ITitleComputeService
    {
        private Title? _first;
        private Title? _last;

        public Title? Get(TitleField field) =>
            field switch
            {
                TitleField.First => _first,
                TitleField.Last  => _last,
                _                => throw new ArgumentOutOfRangeException(nameof(field), field, null)
            };

        public void Change(Title? newItem)
        {
            if (newItem == null) { throw new InvalidOperationException(); }

            Title? old;
            switch (newItem.Field)
            {
                case TitleField.First:
                    old    = _first;
                    _first = newItem;
                    break;
                case TitleField.Last:
                    old   = _last;
                    _last = newItem;
                    break;
                default: throw new ArgumentOutOfRangeException();
            }

            NotifyChange(ComputeAffect(old, newItem));
        }

        public void Clear(TitleField field)
        {
            Title item;
            switch (field)
            {
                case TitleField.First:
                    if (_first == null) { return; }

                    item = _first;
                    break;
                case TitleField.Last:
                    if (_last == null) { return; }

                    item = _last;
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(field), field, null);
            }

            NotifyChange(ComputeAffect(item, null));
        }
    }
}