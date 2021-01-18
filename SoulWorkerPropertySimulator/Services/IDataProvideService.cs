using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IDataProvideService
    {
        BroochesSetEffect                       GetBroochesSets(BroochesClassify classify);
        IReadOnlyCollection<AccessorySetEffect> GetAccessorySetEffects();
        IReadOnlyCollection<ArmorSetEffect>     GetArmorSetEffects();
        IReadOnlyCollection<BroochesD>          GetBrooches(BroochesType              type);
        IReadOnlyCollection<ArmorBlueprint>     GetArmorBlueprints(ArmorField         field);
        IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field);
        IReadOnlyCollection<PluginBlueprint>    GetPluginBlueprints(PluginField       field);
        IReadOnlyCollection<Tag>                GetTags(TagField                      field);
        IReadOnlyCollection<Title>              GetTitles(TitleField                  field);
        IReadOnlyCollection<Character>          GetCharacters();
        IReadOnlyCollection<Akasha>             GetAkashas();
    }
}