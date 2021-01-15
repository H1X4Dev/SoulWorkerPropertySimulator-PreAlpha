using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Data;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IDataProvideService
    {
        BroochesSetEffect                       GetBroochesSets(BroochesClassify classify);
        IReadOnlyCollection<AccessorySetEffect> GetAccessorySetEffects();
        IReadOnlyCollection<ArmorSetEffect>     GetArmorSetEffects();
        IReadOnlyCollection<Brooches>           GetBrooches(BroochesType              type);
        IReadOnlyCollection<ArmorBlueprint>     GetArmorBlueprints(ArmorField         field);
        IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field);
        IReadOnlyCollection<PluginBlueprint>    GetPluginBlueprints(PluginField       field);
        IReadOnlyCollection<Tag>                GetTags(TagField                      field, TagRare rare);
        IReadOnlyCollection<Title>              GetTitles(TitleField                  field);
        IReadOnlyCollection<Character>          GetCharacters();
        IReadOnlyCollection<Akasha>             GetAkashas();
    }

    internal class DataProvideService : IDataProvideService
    {
        public BroochesSetEffect GetBroochesSets(BroochesClassify classify) => throw new NotImplementedException();

        public IReadOnlyCollection<AccessorySetEffect> GetAccessorySetEffects() => throw new NotImplementedException();

        public IReadOnlyCollection<ArmorSetEffect> GetArmorSetEffects() => throw new NotImplementedException();

        public IReadOnlyCollection<Brooches> GetBrooches(BroochesType type) =>
            BroochesData.Get().Where(x => x.Type == type).ToList();

        public IReadOnlyCollection<ArmorBlueprint> GetArmorBlueprints(ArmorField field) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<PluginBlueprint> GetPluginBlueprints(PluginField field) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<Tag> GetTags(TagField field, TagRare rare) => throw new NotImplementedException();
        public IReadOnlyCollection<Title> GetTitles(TitleField field) => throw new NotImplementedException();
        public IReadOnlyCollection<Character> GetCharacters() => throw new NotImplementedException();
        public IReadOnlyCollection<Akasha> GetAkashas() => throw new NotImplementedException();
    }
}