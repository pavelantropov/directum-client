using System.Windows.Input;
using ClientApp.Models.Abstractions;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Button : IFormElement
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string Class { get; set; }
        [JsonProperty(Required = Required.AllowNull)]
        public string Text { get; set; }

        [JsonIgnore]
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
