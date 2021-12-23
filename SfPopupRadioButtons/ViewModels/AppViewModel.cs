using System.Windows.Input;
using SfPopupRadioButtons.ViewModels.Base;
using Xamarin.Forms;

namespace SfPopupRadioButtons.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        public static SfPopup SfPopup { get; set; }

        public AppViewModel()
        {
            ShowPopupCommand = new Command(ShowPopup);
        }

        public ICommand ShowPopupCommand { get; }

        public void ShowPopup()
        {
            PopupViewModel popupViewModel = new PopupViewModel();
            SfPopup = new SfPopup(popupViewModel);
            SfPopup.Show();
        }

        public void ClosePopup()
        {
            SfPopup.Dismiss();
        }
    }
}
