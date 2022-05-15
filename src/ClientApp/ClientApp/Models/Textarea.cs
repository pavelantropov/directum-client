using ClientApp.Models.Abstractions;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Textarea : BaseElement
    {
        public string Value { get; set; }

        public override void AddToLayout(StackLayout layout)
        {
            var label = new Label
            {
                Text = Label
            };
            var editor = new Editor
            {
                Text = Value,
                Placeholder = Placeholder,
                IsEnabled = !Disabled,
            };

            layout.Children.Add(label);
            layout.Children.Add(editor);
        }
    }
}
