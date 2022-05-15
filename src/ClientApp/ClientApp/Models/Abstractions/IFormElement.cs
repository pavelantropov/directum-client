using Xamarin.Forms;

namespace ClientApp.Models.Abstractions
{
    public interface IFormElement
    {
        void AddToLayout(StackLayout layout);
    }
}
