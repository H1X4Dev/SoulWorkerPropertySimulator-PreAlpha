using Microsoft.Extensions.DependencyInjection;
using SoulWorkerPropertySimulator.Data.Services;
using SoulWorkerPropertySimulator.Services;

namespace SoulWorkerPropertySimulator.Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection InjectData(this IServiceCollection self)
        {
            self.AddSingleton<IDataProvideService, DataProvideService>();

            DataProvideService.Create();

            return self;
        }
    }
}