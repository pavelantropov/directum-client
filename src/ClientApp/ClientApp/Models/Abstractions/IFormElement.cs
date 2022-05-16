using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Models.Abstractions
{
    public interface IFormElement
    {
        [JsonIgnore]
        bool IsValid { get; }
        void AddToLayout(StackLayout layout);
    }
}
