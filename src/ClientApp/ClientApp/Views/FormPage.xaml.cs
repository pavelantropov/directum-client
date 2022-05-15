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
            LoadForm(Properties.Resources.Form2);
            GenerateFormElements(Form);
            BindingContext = new FormViewModel();
        }

        public void LoadForm(byte[] bytes)
        {
            using var stream = new MemoryStream(bytes);
            using var reader = new StreamReader(stream);

            var json = reader.ReadToEnd();

            var data = JsonConvert.DeserializeObject<JsonData>(json);
            
            Form = data?.Form;
        }

        private void GenerateFormElements(Form form)
        {
            if (form == null) return;

            foreach (var item in form.Items)
            {
                item.AddToLayout(FormStack);
            }
        }
    }
}