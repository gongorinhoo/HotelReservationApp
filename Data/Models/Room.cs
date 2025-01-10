using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HotelReservationApp.Data.Models;

public class Room
{
        [ValidateNever]
        public int RoomId { get; set; }
        
        [Required(ErrorMessage = "Typ jest wymagany.")]
        [MaxLength(30, ErrorMessage = "Typ może mieć maksymalnie 30 znaków.")]        
        public string Type { get; set; } 
        
        
        [Required(ErrorMessage = "Cena jest wymagana.")]
        [MaxLength(30, ErrorMessage = "Cena może mieć maksymalnie 30 znaków.")] 
        public string PricePerNight { get; set; }
        
        
        public bool IsAvailable { get; set; }

        // Relation: One room -> many reservations
        [ValidateNever]
        public List<Reservation> Reservations { get; set; }
}
