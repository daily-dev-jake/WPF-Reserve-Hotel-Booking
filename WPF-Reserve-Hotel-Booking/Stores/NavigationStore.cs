using System;
using WPF_Reserve_Hotel_Booking.ViewModels;

namespace WPF_Reserve_Hotel_Booking.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel; set
            {
                OnCurrentViewModelChanged();
                _currentViewModel = value;
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChange?.Invoke();
        }

        public event Action CurrentViewModelChange;
    }
}
