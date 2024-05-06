using WPF_Reserve_Hotel_Booking.Models;

namespace WPF_Reserve_Hotel_Booking.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation reservation;

        public string RoomID => reservation.RoomID?.ToString();
        public string Username => reservation.Username;
        public string StartDate => reservation.StartDate.ToString("d");
        public string EndDate => reservation.EndDate.ToString("d");
        public ReservationViewModel(Reservation reservation)
        {
            this.reservation = reservation;
        }
    }
}
