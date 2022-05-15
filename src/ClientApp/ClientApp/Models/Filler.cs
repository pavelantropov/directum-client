using ClientApp.Models.Abstractions;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Filler : IFormElement
    {
        public string Message { get; set; }

        public void AddToLayout(StackLayout layout)
        {
            var html = new HtmlWebViewSource
            {
                Html = Message,
            };

            var filler = new WebView()
            {
                Source = html,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            layout.Children.Add(filler);
        }
    }
}
