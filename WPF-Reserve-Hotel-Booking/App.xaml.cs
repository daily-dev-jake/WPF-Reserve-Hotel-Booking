using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Reserve_Hotel_Booking.Exceptions;
using WPF_Reserve_Hotel_Booking.Models;

namespace WPF_Reserve_Hotel_Booking
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Hotel California");
            try
            {
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 2),
                "John",
                new DateTime(2000, 1, 1),
                new DateTime(2000, 1, 2)
                ));
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 2),
                "Mary",
                new DateTime(2000, 1, 3),
                new DateTime(2000, 1, 4)
                ));
                //hotel.MakeReservation(new Reservation(
                //    new RoomID(1, 3),
                //    "John",
                //    new DateTime(2000, 1, 4),
                //    new DateTime(2000, 1, 5)
                //    ));
            }
            catch (ReservationConflictException ex)
            {

            }

            IEnumerable<Reservation> reservations = hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }
}
