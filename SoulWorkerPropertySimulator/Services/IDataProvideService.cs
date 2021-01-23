using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Models.Plugins;
using SoulWorkerPropertySimulator.Types;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IDataProvideService
    {
        BroochSet                               GetBroochesSets(BroochesField field, BroochesSeries series);
        IReadOnlyCollection<AccessorySet>       GetAccessorySets();
        IReadOnlyCollection<EquipmentSet>       GetEquipmentSets();
        IReadOnlyCollection<Brooch>             GetBrooches(BroochesType              type);
        IReadOnlyCollection<EquipmentBlueprint> GetEquipmentBlueprints(EquipmentField field);
        IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field);
        IReadOnlyCollection<PluginBlueprint>    GetPluginBlueprints(PluginField       field);
        IReadOnlyCollection<Tag>                GetTags(TagField                      field);
        IReadOnlyCollection<Title>              GetTitles(TitleField                  field);
        IReadOnlyCollection<Character>          GetCharacters();
        IReadOnlyCollection<Akasha>             GetAkashas();
    }
}