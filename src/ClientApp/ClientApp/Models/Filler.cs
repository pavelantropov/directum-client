using ClientApp.Models.Abstractions;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Filler : IFormElement
    {
        [JsonProperty(Required = Required.AllowNull)]
        public string Message { get; set; }

        public bool IsValid => !string.IsNullOrEmpty(Message);

        public void AddToLayout(StackLayout layout)
        {
            var html = new HtmlWebViewSource { Html = Message };

            var filler = new WebView
            {
                Source = html,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            layout.Children.Add(filler);
        }
    }
}
