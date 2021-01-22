using System;
using System.Collections.Generic;
using SoulWorkerPropertySimulator.Data.Storage;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Models.Plugins;
using SoulWorkerPropertySimulator.Services;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Data.Services
{
    internal class DataProvideService : IDataProvideService
    {
        public BroochSet GetBroochesSets(BroochesField field, BroochesSeries series) =>
            BroochesSetData.Get(field, series);

        public IReadOnlyCollection<AccessorySetEffect> GetAccessorySetEffects() => AccessorySetData.Get();

        public IReadOnlyCollection<ArmorSetEffect> GetArmorSetEffects() => ArmorSetData.Get();

        public IReadOnlyCollection<Brooch> GetBrooches(BroochesType type) => BroochesData.Get(type);

        public IReadOnlyCollection<ArmorBlueprint> GetArmorBlueprints(ArmorField field) => ArmorData.Get(field);

        public IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field) =>
            AccessoryData.Get(field);

        public IReadOnlyCollection<PluginBlueprint> GetPluginBlueprints(PluginField field) => PluginData.Get(field);

        public IReadOnlyCollection<Tag> GetTags(TagField field) => TagData.Get(field);

        public IReadOnlyCollection<Title> GetTitles(TitleField field) => TitleData.Get(field);

        public IReadOnlyCollection<Character> GetCharacters() => CharacterData.Get();

        public IReadOnlyCollection<Akasha> GetAkashas() => throw new NotImplementedException();
    }
}