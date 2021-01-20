using System;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface ICharacterComputeService : IComputeService
    {
        Character? Get();
        void       Change(Character? newItem);
        void       Change(Title?     title);
        void       Clear(TitleField  field);

        // void       Change(int        level);
    }

    internal class CharacterComputeService : ComputeServiceBase, ICharacterComputeService
    {
        private Character? _character;

        public Character? Get() => _character;

        public void Change(Character? newItem)
        {
            var before = _character;
            _character = newItem;
            NotifyChange(ComputeAffect(before, _character));
        }

        public void Change(Title? title)
        {
            if (_character == null || title == null) { throw new InvalidOperationException(); }

            var before = _character;
            _character = title?.Field switch
            {
                TitleField.First => _character with {First = title},
                TitleField.Last  => _character with {Last = title},
                _                => throw new ArgumentOutOfRangeException()
            };

            NotifyChange(ComputeAffect(before, _character));
        }

        public void Clear(TitleField field)
        {
            if (_character == null) { return; }

            var before = _character;
            _character = field switch
            {
                TitleField.First => _character with {First = null},
                TitleField.Last  => _character with {Last = null},
                _                => throw new ArgumentOutOfRangeException()
            };

            NotifyChange(ComputeAffect(before, _character));
        }
    }
}