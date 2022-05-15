using Xamarin.Forms;

namespace ClientApp.Models.Abstractions
{
    public interface IFormElement
    {
        bool IsValid { get; }
        void AddToLayout(StackLayout layout);
    }
}
