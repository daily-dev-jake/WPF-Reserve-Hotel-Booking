using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Reserve_Hotel_Booking.Models
{
    public class Hotels
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }
        public Hotels( string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }
    }
}
