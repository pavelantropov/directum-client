using Newtonsoft.Json;

namespace ClientApp.Models
{
    public class RadioOption
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string Value { get; set; }
        [JsonProperty(Required = Required.AllowNull)]
        public string Label { get; set; }
        [JsonProperty(Required = Required.Always)]
        public bool Checked { get; set; }
    }
}