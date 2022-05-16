using System.Windows.Input;
using ClientApp.Models.Abstractions;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Button : IFormElement
    {
        public string Class { get; set; }
        public string Text { get; set; }
        public ICommand Command { get; set; }

        public bool IsValid => !string.IsNullOrEmpty(Text);

        public void AddToLayout(StackLayout layout)
        {
            var button = new Xamarin.Forms.Button
            {
                Text = this.Text,
                Command = this.Command
            };

            layout.Children.Add(button);
        }
    }
}
