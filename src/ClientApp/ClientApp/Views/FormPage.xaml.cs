using System.IO;
using ClientApp.Models;
using ClientApp.Services;
using ClientApp.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Views
{
    public partial class FormPage : ContentPage
    {
        public FormPage()
        {
            InitializeComponent();
            FormService.LoadForm(Properties.Resources.Form2);
            FormService.GenerateFormElements(Form, FormStack);
            BindingContext = new FormViewModel();
        }

        public Form Form { get; set; }
    }
}