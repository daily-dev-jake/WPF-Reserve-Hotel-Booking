﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF_Reserve_Hotel_Booking.Commands;
using WPF_Reserve_Hotel_Booking.Stores;

namespace WPF_Reserve_Hotel_Booking.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }
        public ReservationListingViewModel(NavigationStore navigationStore, Func<MakeReservationViewModel> createMakeReservationViewModel)
        {
            MakeReservationCommand = new NavigateCommand(navigationStore, createMakeReservationViewModel);

            _reservations = new ObservableCollection<ReservationViewModel>();
            // Hardcoded addition to test
            _reservations.Add(new ReservationViewModel(new Models.Reservation(new Models.RoomID(1, 2), "Jacob", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation(new Models.RoomID(3, 2), "Joe", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation(new Models.RoomID(2, 4), "Bon Jovi", DateTime.Now, DateTime.Now)));
        }
    }
}
