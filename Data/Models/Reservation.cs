using System;

namespace HotelReservationApp.Data.Models;

public class Reservation
{
        public int ReservationId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        // Relation: Reservation -> one room
        public int RoomId { get; set; }
        public Room Room { get; set; }

        // Relation: Reservation -> one customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }  

        // Relation: Reservation -> one Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }  
}
