using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Accessory;
using SoulWorkerPropertySimulator.Models.Brooches;
using SoulWorkerPropertySimulator.Models.Equipments;
using SoulWorkerPropertySimulator.Models.Plugins;
using SoulWorkerPropertySimulator.Services;
using SoulWorkerPropertySimulator.Types;
using SoulWorkerPropertySimulator.Web.Models;

namespace SoulWorkerPropertySimulator.Web.Services
{
    public interface IWebDataProvideService : IDataProvideService
    {
        Task DownloadAsync();
    }

    public class WebDataProvideService : IWebDataProvideService
    {
        private readonly HttpClient _client;

        private readonly JsonSerializerOptions _option;

        public WebDataProvideService(HttpClient client)
        {
            _client = client;
            _option = new(JsonSerializerDefaults.Web);
            _option.Converters.Add(new JsonStringEnumConverter());
        }

        private Title[] _title;

        public BroochSet GetBroochesSets(BroochesField field, BroochesSeries series) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<AccessorySet> GetAccessorySets() => throw new NotImplementedException();

        public IReadOnlyCollection<EquipmentSet> GetEquipmentSets() => throw new NotImplementedException();

        public IReadOnlyCollection<Brooch> GetBrooches(BroochesType type) => throw new NotImplementedException();

        public IReadOnlyCollection<EquipmentBlueprint> GetEquipmentBlueprints(EquipmentField field) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<AccessoryBlueprint> GetAccessoryBlueprints(AccessoryField field) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<PluginBlueprint> GetPluginBlueprints(PluginField field) =>
            throw new NotImplementedException();

        public IReadOnlyCollection<Tag> GetTags(TagField field) => throw new NotImplementedException();

        public IReadOnlyCollection<Title> GetTitles(TitleField field) => throw new NotImplementedException();

        public IReadOnlyCollection<Character> GetCharacters() => throw new NotImplementedException();

        public IReadOnlyCollection<Akasha> GetAkashas() => throw new NotImplementedException();

        public async Task DownloadAsync()
        {
            _title = (await _client.GetFromJsonAsync<TitleJson[]>("data/title.json", _option))!.Select(x => x.Title)
                .ToArray();
        }
    }
}