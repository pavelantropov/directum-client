using ClientApp.Models.Abstractions;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Text : BaseElement
    {
        public string Value { get; set; }

        public override void AddToLayout(StackLayout layout)
        {
            var label = new Label
            {
                Text = Label
            };
            var entry = new Entry
            {
                Text = Value,
                Placeholder = Placeholder,
                IsEnabled = !Disabled,
            };

            layout.Children.Add(label);
            layout.Children.Add(entry);
        }
    }
}
