using ClientApp.Models.Abstractions;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Checkbox : BaseElement
    {
        public bool Checked { get; set; }

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

            layout.Children.Add(label);
            layout.Children.Add(checkBox);
        }
    }
}
