using ClientApp.Models.Abstractions;

namespace ClientApp.Models
{
    public class Button : IFormElement
    {
        public string Class { get; set; }
        public string Text { get; set; }
    }
}
