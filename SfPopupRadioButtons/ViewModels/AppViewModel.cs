using System.Windows.Input;
using SfPopupRadioButtons.ViewModels.Base;
using Xamarin.Forms;

namespace SfPopupRadioButtons.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        SfPopup _sfPopup;

        public AppViewModel()
        {
            ShowPopupCommand = new Command(ShowPopup);
            _sfPopup = new SfPopup();
        }

        public ICommand ShowPopupCommand { get; }

        public void ShowPopup()
        {
            _sfPopup.Show();
        }
    }
}
