using System;
using System.Windows.Input;
using WPF_Reserve_Hotel_Booking.Commands;
using WPF_Reserve_Hotel_Booking.Models;
using WPF_Reserve_Hotel_Booking.Stores;

namespace WPF_Reserve_Hotel_Booking.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string _userName;
        public string Username
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(nameof(_userName)); }
        }
        private int _roomNumber;
        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; OnPropertyChanged(nameof(_roomNumber)); }
        }
        private int _floorNumber;
        public int FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; OnPropertyChanged(nameof(_floorNumber)); }
        }
        private DateTime _startDate = DateTime.UtcNow;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; OnPropertyChanged(nameof(_startDate)); }
        }
        private DateTime _endDate = DateTime.UtcNow;
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; OnPropertyChanged(nameof(_endDate)); }
        }
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public MakeReservationViewModel(Hotel hotel, NavigationStore navigationStore, Func<ReservationListingViewModel> createReservationViewModel)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel);
            CancelCommand = new NavigateCommand(navigationStore, createReservationViewModel);
        }
    }
}
