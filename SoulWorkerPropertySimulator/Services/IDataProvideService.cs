using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
}