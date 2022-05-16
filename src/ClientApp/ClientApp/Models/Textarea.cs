using ClientApp.Helpers;
using ClientApp.Models.Abstractions;
using ClientApp.Models.Enums;
using ClientApp.ViewModels;
using Xamarin.Forms;

namespace ClientApp.Models
{
    public class Textarea : BaseElement
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
            var editor = new Editor
            {
                Placeholder = Placeholder,
                IsEnabled = !Disabled,
            };

            editor.SetBinding(Editor.TextProperty, nameof(Value));
            editor.BindingContext = this;

            layout.Children.Add(label);
            layout.Children.Add(editor);
        }
    }
}
