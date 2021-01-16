using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            return self;
        }
    }
}