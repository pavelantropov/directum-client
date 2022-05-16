using ClientApp.Models.Abstractions;
using ClientApp.Models.Enums;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Checkbox : BaseElement
    {
        [JsonProperty(Required = Newtonsoft.Json.Required.Always)]
        public bool Checked { get; set; }

        public override bool IsValid => 
            !(Required || ValidationRules.Type == ValidationType.CHECKBOX) || Checked;

        public override void AddToLayout(StackLayout layout)
        {
            var label = new Label
            {
                Text = Label
            };
            var checkBox = new CheckBox
            {
                IsEnabled = !Disabled,
                IsChecked = Checked,
            };

            checkBox.SetBinding(CheckBox.IsCheckedProperty, nameof(Checked), BindingMode.TwoWay);
            checkBox.BindingContext = this;

            layout.Children.Add(label);
            layout.Children.Add(checkBox);
        }
    }
}
