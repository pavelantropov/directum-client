using ClientApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ClientApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}