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
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public Reservation(RoomID roomID, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
