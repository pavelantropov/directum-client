using ClientApp.Helpers;
using ClientApp.Models.Abstractions;
using Newtonsoft.Json;

namespace ClientApp.Models
{
    public class Form
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string Name { get; set; }
        [JsonProperty(
            Required = Required.Always,
            ItemConverterType = typeof(FormElementConverter))]
        public IFormElement[] Items { get; set; }
        [JsonProperty(Required = Required.AllowNull)]
        public string PostMessage { get; set; }
    }
}
