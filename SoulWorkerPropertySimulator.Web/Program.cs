using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SoulWorkerPropertySimulator.Data;

namespace SoulWorkerPropertySimulator.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSoulWorkerPropertySimulator().InjectData();

            await builder.Build().RunAsync();
        }
    }
}