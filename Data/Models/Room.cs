using System;

namespace HotelReservationApp.Data.Models;

public class Room
{
        public int RoomId { get; set; }
        public string Type { get; set; } 
        public string PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        // Relation: One room -> many reservations
        public List<Reservation> Reservations { get; set; }
}
