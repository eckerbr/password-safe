using Prism.Mvvm;

namespace EckTech.PasswordSafe.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Password Safe";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
        }
    }
}
