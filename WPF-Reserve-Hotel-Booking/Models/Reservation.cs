using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Reserve_Hotel_Booking.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string Username { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public TimeSpan Length => EndDate.Subtract(StartDate);
        public Reservation(RoomID roomID, string Username, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endDate;
        }

        public bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.StartDate < EndDate && reservation.EndDate > StartDate;
        }
    }
}
