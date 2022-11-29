using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Reserve_Hotel_Booking.Exceptions;

namespace WPF_Reserve_Hotel_Booking.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;
        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }
        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(x => x.Username == username);
        }
        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }

            }
            _reservations.Add(reservation);
        }

    }
}
