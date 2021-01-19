using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SoulWorkerPropertySimulator.Data;
using SoulWorkerPropertySimulator.Web.Services;

namespace SoulWorkerPropertySimulator.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new(builder.HostEnvironment.BaseAddress)});
            builder.Services.AddSoulWorkerPropertySimulator().InjectData();
            builder.Services.AddSingleton<IPageInfoService, PageInfoService>();

            await builder.Build().RunAsync();
        }
    }
}