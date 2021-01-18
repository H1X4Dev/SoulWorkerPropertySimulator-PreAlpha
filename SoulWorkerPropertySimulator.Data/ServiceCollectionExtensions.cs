using System;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using SoulWorkerPropertySimulator.Data.Services;
using SoulWorkerPropertySimulator.Services;

namespace SoulWorkerPropertySimulator.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection InjectData(this IServiceCollection self)
        {
            self.AddSingleton<IDataProvideService, DataProvideService>();

            using var serviceProvider = self.BuildServiceProvider();

            var dataProvider = serviceProvider.GetRequiredService<IDataProvideService>();

            SafeCall(() => dataProvider.GetAccessorySetEffects());
            SafeCall(() => dataProvider.GetArmorSetEffects());
            SafeCall(() => dataProvider.GetCharacters());
            SafeCall(() => dataProvider.GetAkashas());

            foreach (var type in Enum.GetValues<BroochesType>()) { SafeCall(() => dataProvider.GetBrooches(type)); }

            foreach (var field in Enum.GetValues<ArmorField>())
            {
                SafeCall(() => dataProvider.GetArmorBlueprints(field));
            }

            foreach (var field in Enum.GetValues<AccessoryField>())
            {
                SafeCall(() => dataProvider.GetAccessoryBlueprints(field));
            }

            foreach (var field in Enum.GetValues<PluginField>())
            {
                SafeCall(() => dataProvider.GetPluginBlueprints(field));
            }

            foreach (var field in Enum.GetValues<TagField>()) { SafeCall(() => dataProvider.GetTags(field)); }

            foreach (var field in Enum.GetValues<TitleField>()) { SafeCall(() => dataProvider.GetTitles(field)); }

            return self;
        }

        private static void SafeCall(Action action)
        {
#if DEBUG
            try { action.Invoke(); }
            catch (NotImplementedException) { }
#else
            action.Invoke();
#endif
        }
    }
}