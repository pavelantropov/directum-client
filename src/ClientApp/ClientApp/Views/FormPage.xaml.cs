using System.IO;
using ClientApp.Models;
using ClientApp.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ClientApp.Views
{
    public partial class FormPage : ContentPage
    {
        public Form Form { get; set; }

        public FormPage()
        {
            InitializeComponent();
            LoadDynamicFields();
            BindingContext = new FormViewModel();
        }

        public void LoadDynamicFields()
        {
            if (!(Properties.Resources.ResourceManager.GetObject("Form1") is byte[] fileBytes)) return;

            using var stream = new MemoryStream(fileBytes);
            using var reader = new StreamReader(stream);

            var json = reader.ReadToEnd();

            var data = JsonConvert.DeserializeObject<JsonData>(json);
            
            Form = data?.Form;
        }
    }
}