using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Reserve_Hotel_Booking.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _roomsToReservations;
        public ReservationBook()
        {
            _roomsToReservations = new List<Reservation>();
        }

    }
}
