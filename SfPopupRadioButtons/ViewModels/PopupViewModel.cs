using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace SfPopupRadioButtons.ViewModels.Base
{
    public class PopupViewModel : AppViewModel
    {
        public PopupViewModel()
        {
            RightButtonCommand = new Command(ClosePopup);
        }

        public ICommand RightButtonCommand { get; }

    }
}
        