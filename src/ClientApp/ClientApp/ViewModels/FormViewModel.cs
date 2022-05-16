using System.Linq;
using ClientApp.Models;
using Xamarin.Forms;

namespace ClientApp.ViewModels
{
    public class FormViewModel
    {
        public FormViewModel()
        {
            ButtonClickCommand = new Command(OnButtonClick, ValidateButtonClick);
        }

        private bool ValidateButtonClick()
        {
            // TODO fix validation
            // return Form.Items.All(i => i.IsValid);
            return true;
        }

        public Form Form { get; set; }

        public Command ButtonClickCommand { get; }
        
        private async void OnButtonClick()
        {
            await Application.Current.MainPage.DisplayAlert(Form.Name, Form.PostMessage, "OK");
        }
    }
}
