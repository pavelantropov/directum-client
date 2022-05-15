using ClientApp.Models.Abstractions;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Button : IFormElement
    {
        public string Class { get; set; }
        public string Text { get; set; }

        public void AddToLayout(StackLayout layout)
        {
            var button = new Xamarin.Forms.Button
            {
                Text = this.Text,
            };

            layout.Children.Add(button);
        }
    }
}
