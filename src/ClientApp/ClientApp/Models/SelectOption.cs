using Newtonsoft.Json;

namespace ClientApp.Models
{
    public class SelectOption
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string Value { get; set; }
        [JsonProperty(Required = Required.AllowNull)]
        public string Text { get; set; }
        [JsonProperty(Required = Required.Always)]
        public bool Selected { get; set; }
    }
}