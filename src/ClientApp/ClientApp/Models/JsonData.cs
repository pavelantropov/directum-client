using Newtonsoft.Json;

namespace ClientApp.Models
{
    public class JsonData
    {
        [JsonProperty(Required = Required.Always)]
        public Form Form { get; set; }
    }
}