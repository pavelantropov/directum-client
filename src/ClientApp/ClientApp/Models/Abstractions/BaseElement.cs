﻿using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models.Abstractions
{
    public abstract class BaseElement : IFormElement
    {
        public string Name { get; set; }
        [JsonProperty(Required = Newtonsoft.Json.Required.Default)]
        public string Placeholder { get; set; }
        public bool Required { get; set; }
        public ValidationRule ValidationRules { get; set; }
        public string Label { get; set; }
        public string Class { get; set; }
        public bool Disabled { get; set; }

        public abstract void AddToLayout(StackLayout layout);
    }
}