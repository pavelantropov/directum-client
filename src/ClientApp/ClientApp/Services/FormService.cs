using System;
using System.IO;
using ClientApp.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

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

        public static void GenerateFormElements(Form form, StackLayout layout)
        {
            if (form == null || layout == null) return;

            foreach (var item in form.Items)
            {
                item.AddToLayout(layout);
            }
        }
    }
}