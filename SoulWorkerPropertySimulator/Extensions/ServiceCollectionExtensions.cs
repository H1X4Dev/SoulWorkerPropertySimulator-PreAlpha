using Microsoft.Extensions.DependencyInjection;
using SoulWorkerPropertySimulator.Services;

namespace SoulWorkerPropertySimulator.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSoulWorkerPropertySimulator(this IServiceCollection self)
        {
            self.AddSingleton<IAccessorySetComputeService, AccessorySetComputeService>();
            self.AddSingleton<IAkashaComputeService, AkashaComputeService>();
            self.AddSingleton<IEquipmentComputeService, EquipmentComputeService>();
            self.AddSingleton<IBroochesSetComputeService, BroochesSetComputeService>();
            self.AddSingleton<ICharacterComputeService, CharacterComputeService>();
            self.AddSingleton<IAttackComputeService, AttackComputeService>();
            self.AddSingleton<IPanelComputeService, PanelComputeService>();

            return self;
        }
    }
}