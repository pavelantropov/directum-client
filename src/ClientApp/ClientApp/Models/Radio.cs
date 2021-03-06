using System.Linq;
using ClientApp.Models.Abstractions;
using ClientApp.Models.Enums;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Radio : BaseElement
    {
        [JsonProperty(Required = Newtonsoft.Json.Required.Always)]
        public RadioOption[] Items { get; set; }

        public override bool IsValid => 
            !(Required || ValidationRules.Type == ValidationType.RADIO) || Items.Any(item => item.Checked);

        public override void AddToLayout(StackLayout layout)
        {
            foreach (var item in Items)
            {
                var label = new Label
                {
                    Text = item.Label
                };
                var radioButton = new RadioButton
                {
                    IsEnabled = !Disabled,
                    Value = item.Value,
                };

                // TODO set bindings
                radioButton.BindingContext = this;

                layout.Children.Add(label);
                layout.Children.Add(radioButton);
            }
        }
    }
}
