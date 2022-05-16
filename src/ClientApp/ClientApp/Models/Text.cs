using ClientApp.Helpers;
using ClientApp.Models.Abstractions;
using ClientApp.Models.Enums;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Text : BaseElement
    {
        public string Value { get; set; }
        
        public override bool IsValid =>
            !Required || 
            (ValidationRules.Type == ValidationType.TEXT && !string.IsNullOrEmpty(Value)) ||
            (ValidationRules.Type == ValidationType.TEL && ValidationHelper.ValidatePhone(Value)) ||
            (ValidationRules.Type == ValidationType.EMAIL && ValidationHelper.ValidateEmail(Value));

        public override void AddToLayout(StackLayout layout)
        {
            var label = new Label
            {
                Text = Label
            };
            var entry = new Entry
            {
                Placeholder = Placeholder,
                IsEnabled = !Disabled,
            };
            
            entry.SetBinding(Entry.TextProperty, nameof(Value));
            entry.BindingContext = this;

            layout.Children.Add(label);
            layout.Children.Add(entry);
        }
    }
}
