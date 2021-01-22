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

        public IReadOnlyCollection<EquipmentSetEffect> GetArmorSetEffects() => EquipmentSetData.Get();

        public IReadOnlyCollection<Brooch> GetBrooches(BroochesType type) => BroochesData.Get(type);

        public IReadOnlyCollection<EquipmentBlueprint> GetArmorBlueprints(ArmorField field) => EquipmentData.Get(field);

        public IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field) =>
            AccessoryData.Get(field);

        public IReadOnlyCollection<PluginBlueprint> GetPluginBlueprints(PluginField field) => PluginData.Get(field);

        public IReadOnlyCollection<Tag> GetTags(TagField field) => TagData.Get(field);

        public IReadOnlyCollection<Title> GetTitles(TitleField field) => TitleData.Get(field);

        public IReadOnlyCollection<Character> GetCharacters() => CharacterData.Get();

        public IReadOnlyCollection<Akasha> GetAkashas() => throw new NotImplementedException();

        public static void Create()
        {
            SafeCall(() => AccessorySetData.Get());
            SafeCall(() => EquipmentSetData.Get());
            SafeCall(() => CharacterData.Get());
            // SafeCall(() => GetAkashas());

            var share = new ShareEffect();
            SafeCall(() => BroochesData.Create(share));
            SafeCall(() => TitleData.Create(share));

            foreach (var field in Enum.GetValues<ArmorField>()) { SafeCall(() => EquipmentData.Get(field)); }

            foreach (var field in Enum.GetValues<AccessoryField>()) { SafeCall(() => AccessoryData.Get(field)); }

            foreach (var field in Enum.GetValues<PluginField>()) { SafeCall(() => PluginData.Get(field)); }

            foreach (var field in Enum.GetValues<TagField>()) { SafeCall(() => TagData.Get(field)); }
        }

        #region

        private static void SafeCall(Action action)
        {
            // #if DEBUG
            try { action.Invoke(); }
            catch (NotImplementedException) { }

            // #else
            //            action.Invoke();
            // #endif
        }

        #endregion
    }
}