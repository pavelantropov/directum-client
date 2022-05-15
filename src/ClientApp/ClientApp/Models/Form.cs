using ClientApp.Helpers;
using ClientApp.Models.Abstractions;
using Newtonsoft.Json;

namespace ClientApp.Models
{
    public class Form
    {
        public string Name { get; set; }
        [JsonProperty(ItemConverterType = typeof(FormElementConverter))]
        public IFormElement[] Items { get; set; }
        public string PostMessage { get; set; }
    }
}
