using System;

namespace WPF_Reserve_Hotel_Booking.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public string Username { get; }
        public Reservation(RoomID roomID, string Username, DateTime startDate, DateTime endDate)
        {
            RoomID = roomID;
            this.Username = Username;
            StartDate = startDate;
            EndDate = endDate;
        }
        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }
            return reservation.StartDate < EndDate && reservation.EndDate > StartDate;
        }
    }
}
