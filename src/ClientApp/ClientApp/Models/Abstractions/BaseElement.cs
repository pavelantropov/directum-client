using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models.Abstractions
{
    public abstract class BaseElement : IFormElement
    {
        [JsonProperty(Required = Newtonsoft.Json.Required.AllowNull)]
        public string Name { get; set; }
        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public string Placeholder { get; set; }
        [JsonProperty(Required = Newtonsoft.Json.Required.Always)]
        public bool Required { get; set; }
        [JsonProperty(Required = Newtonsoft.Json.Required.Always)]
        public ValidationRule ValidationRules { get; set; }
        [JsonProperty(Required = Newtonsoft.Json.Required.AllowNull)]
        public string Label { get; set; }
        [JsonProperty(Required = Newtonsoft.Json.Required.AllowNull)]
        public string Class { get; set; }
        [JsonProperty(Required = Newtonsoft.Json.Required.Always)]
        public bool Disabled { get; set; }

        public abstract bool IsValid { get; }
        
        public abstract void AddToLayout(StackLayout layout);
    }
}