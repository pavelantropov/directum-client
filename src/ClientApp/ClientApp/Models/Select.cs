using ClientApp.Models.Abstractions;

namespace ClientApp.Models
{
    public class Select : BaseElement
    {
        public SelectOption[] Options { get; set; }
    }
}
