# WPF-Reserve-Hotel-Booking

## Hotel Booking desktop app
This app allows hotel user to reserve hotel rooms by entering in the following details:
1. Username
2. Start date
3. End date 
4. Room to book

## Details of MVVM
### Models

```
Hotel (1) --> (1) Reservation book (1) 
                   /   |   \    (many)
                   V   V   V
                  Reservation      (1) --> (1) Room ID
```
