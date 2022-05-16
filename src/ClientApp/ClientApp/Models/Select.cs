using System.Linq;
using ClientApp.Models.Abstractions;
using ClientApp.Models.Enums;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Select : BaseElement
    {
        [JsonProperty(Required = Newtonsoft.Json.Required.Always)]
        public SelectOption[] Options { get; set; }

        public override bool IsValid =>
            !(Required || ValidationRules.Type == ValidationType.SELECT) || Options.Any(option => option.Selected);

        public override void AddToLayout(StackLayout layout)
        {
            var label = new Label
            {
                Text = Label
            };
            var picker = new Picker
            {
                IsEnabled = !Disabled,
            };

            for (var i = 0; i < Options.Length; i++)
            {
                var option = Options[i];
                picker.Items.Add(option.Text);
                if (option.Selected)
                {
                    picker.SelectedIndex = i;
                }
            }
            
            // TODO set binding
            picker.BindingContext = this;

            layout.Children.Add(label);
            layout.Children.Add(picker);
        }
    }
}
