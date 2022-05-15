using System.Linq;
using ClientApp.Models;
using Xamarin.Forms;

namespace ClientApp.ViewModels
{
    // TODO
    internal class FormViewModel : BaseViewModel
    {
        private Form _form;

        public FormViewModel(Form form)
        {
            _form = form;
            Title = _form.Name;

            SaveCommand = new Command(OnSave, ValidateSave);
            PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return _form.Items.All(i => i.IsValid);
        }
        
        public Command SaveCommand { get; }
        
        
        private async void OnSave()
        {
            await Application.Current.MainPage.DisplayAlert(_form.Name, _form.PostMessage, "OK");
        
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
