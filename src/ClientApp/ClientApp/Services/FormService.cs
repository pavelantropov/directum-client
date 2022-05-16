using System.IO;
using ClientApp.Models;
using ClientApp.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;
using Button = ClientApp.Models.Button;

namespace ClientApp.Services
{
    public static class FormService
    {
        public static Form LoadForm(byte[] bytes)
        {
            using var stream = new MemoryStream(bytes);
            using var reader = new StreamReader(stream);

            var json = reader.ReadToEnd();

            var data = JsonConvert.DeserializeObject<JsonData>(json);

            return data?.Form;
        }

        public static void GenerateFormElements(Form form, StackLayout layout, FormViewModel model)
        {
            if (form == null || layout == null) return;

            foreach (var item in form.Items)
            {
                if (item is Button button)
                {
                    button.Command = model.ButtonClickCommand;
                }

                item.AddToLayout(layout);
            }
        }
    }
}