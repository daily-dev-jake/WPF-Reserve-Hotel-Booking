using System.Windows;
using WPF_Reserve_Hotel_Booking.Exceptions;
using WPF_Reserve_Hotel_Booking.Models;
using WPF_Reserve_Hotel_Booking.ViewModels;

namespace WPF_Reserve_Hotel_Booking.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        public MakeReservationCommand(ViewModels.MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            this._makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;

            _makeReservationViewModel.PropertyChanged += _makeReservationViewModel_PropertyChanged;
        }

        private void _makeReservationViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Username) ||
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) &&
                _makeReservationViewModel.FloorNumber > 0 &&
                base.CanExecute(parameter);
        }
        public override void Execute(object parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(
                    _makeReservationViewModel.FloorNumber,
                    _makeReservationViewModel.RoomNumber),
                    _makeReservationViewModel.Username,
                    _makeReservationViewModel.StartDate,
                    _makeReservationViewModel.EndDate);
            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("Room registered!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictException)
            {

                MessageBox.Show("Room is already taken!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
