using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class TagData
    {
        public static IReadOnlyCollection<Tag> Get(TagField field) =>
            field switch
            {
                TagField.Weapon => WeaponTag,
                TagField.Gear   => GearTag,
                _               => throw new ArgumentOutOfRangeException(nameof(field), field, null)
            };
    }
}