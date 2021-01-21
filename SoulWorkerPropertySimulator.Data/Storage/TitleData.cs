using System;
using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TitleData
    {
        public static IReadOnlyCollection<Title> Get(TitleField field) =>
            field switch
            {
                TitleField.First => _firstTitle,
                TitleField.Last  => _lastTitle,
                _                => throw new ArgumentOutOfRangeException(nameof(field), field, null)
            };
    }
}