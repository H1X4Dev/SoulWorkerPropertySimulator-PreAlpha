using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Data.Storage;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Services;

namespace SoulWorkerPropertySimulator.Data.Services
{
    internal class DataProvideService : IDataProvideService
    {
        public BroochesSetEffect GetBroochesSets(BroochesClassify classify) => throw new NotImplementedException();

        public IReadOnlyCollection<AccessorySetEffect> GetAccessorySetEffects() => throw new NotImplementedException();

        public IReadOnlyCollection<ArmorSetEffect> GetArmorSetEffects() => ArmorSetData.Get();

        public IReadOnlyCollection<BroochesD> GetBrooches(BroochesType type) =>
            BroochesData.Get().Where(x => x.Type == type).ToList();

        public IReadOnlyCollection<ArmorBlueprint> GetArmorBlueprints(ArmorField field) =>
            ArmorData.Get().Where(x => x.Field == field).ToList();

        public IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<PluginBlueprint> GetPluginBlueprints(PluginField field) => PluginData.Get(field);

        public IReadOnlyCollection<Tag> GetTags(TagField field) => TagData.Get(field);

        public IReadOnlyCollection<Title> GetTitles(TitleField field) => throw new NotImplementedException();

        public IReadOnlyCollection<Character> GetCharacters() => throw new NotImplementedException();

        public IReadOnlyCollection<Akasha> GetAkashas() => throw new NotImplementedException();
    }
}