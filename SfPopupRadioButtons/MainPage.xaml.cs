using SfPopupRadioButtons.ViewModels;
using Xamarin.Forms;

namespace SfPopupRadioButtons
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new AppViewModel();
        }
    }
}
