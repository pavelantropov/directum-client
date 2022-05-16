using ClientApp.Models;
using ClientApp.Services;
using ClientApp.ViewModels;
using Xamarin.Forms;

namespace ClientApp.Views
{
    public partial class FormPage : ContentPage
    {
        private Form _form;

        public FormPage()
        {
            InitializeComponent();
            _form = FormService.LoadForm(Properties.Resources.Form2);
            BindingContext = new FormViewModel { Form = _form };
            FormService.GenerateFormElements(_form, FormStack, (FormViewModel)BindingContext);
        }
    }
}