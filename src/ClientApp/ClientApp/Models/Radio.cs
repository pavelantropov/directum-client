using ClientApp.Models.Abstractions;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Radio : BaseElement
    {
        public RadioOption[] Items { get; set; }

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
                    IsChecked = item.Checked,
                    Value = item.Value,
                };

                layout.Children.Add(label);
                layout.Children.Add(radioButton);
            }
        }
    }
}
