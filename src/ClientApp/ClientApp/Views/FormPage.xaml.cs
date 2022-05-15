using ClientApp.Models;
using ClientApp.ViewModels;
using Xamarin.Forms;

namespace ClientApp.Views
{
    public partial class FormPage : ContentPage
    {
        public Form Form { get; set; }

        public FormPage()
        {
            InitializeComponent();
            BindingContext = new FormViewModel();
        }
    }
}