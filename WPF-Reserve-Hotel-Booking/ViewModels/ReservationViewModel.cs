using System;
using WPF_Reserve_Hotel_Booking.Models;

namespace WPF_Reserve_Hotel_Booking.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation reservation;

        public string RoomID => reservation.RoomID?.ToString();
        public string Username => reservation.Username;
        public DateTime StartDate => reservation.StartDate;
        public DateTime EndDate => reservation.EndDate;
        public ReservationViewModel(Reservation reservation)
        {
            this.reservation = reservation;
        }
    }
}
