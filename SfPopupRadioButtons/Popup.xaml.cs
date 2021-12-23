using SfPopupRadioButtons.ViewModels;
using SfPopupRadioButtons.ViewModels.Base;
using Syncfusion.XForms.PopupLayout;

namespace SfPopupRadioButtons
{
    public partial class SfPopup : SfPopupLayout
    {
        public SfPopup(PopupViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
