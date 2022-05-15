using System;
using ClientApp.Models;
using ClientApp.Models.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClientApp.Helpers
{
    public class FormElementConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jo = JObject.Load(reader);
            
            var type = (string) jo["type"];

            IFormElement element;

            switch (type)
            {
                case "filler":
                    element = new Filler();
                    break;
                case "text":
                    element = new Text();
                    break;
                case "textarea":
                    element = new Textarea();
                    break;
                case "checkbox":
                    element = new Checkbox();
                    break;
                case "select":
                    element = new Select();
                    break;
                case "radio":
                    element = new Radio();
                    break;
                case "button":
                    element = new Button();
                    break;
                default:
                    return null;
            }

            serializer.Populate(jo.CreateReader(), element);

            return element;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IFormElement).IsAssignableFrom(objectType);
        }
    }
}