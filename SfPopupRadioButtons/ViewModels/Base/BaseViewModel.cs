using System;
using System.ComponentModel;

namespace SfPopupRadioButtons.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        object _selection;

        public BaseViewModel()
        {
        }

        public object Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                OnPropertyChanged(nameof(Selection));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
