using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HotelReservationApp.Data.Models;

public class Reservation
{
        [ValidateNever]
        public int ReservationId { get; set; }
        
        [Required(ErrorMessage = "Check-in jest wymagany.")]
        public DateTime CheckInDate { get; set; }
        
        [Required(ErrorMessage = "Check-out jest wymagany.")]
        public DateTime CheckOutDate { get; set; }

        // Relation: Reservation -> one room
        [Required(ErrorMessage = "Pokój jest wymagany.")]
        [Range(1, int.MaxValue, ErrorMessage = "Pokój jest wymagany.")]
        public int RoomId { get; set; }
        
        [ValidateNever]
        public Room Room { get; set; }

        // Relation: Reservation -> one customer
        [Required(ErrorMessage = "Klient jest wymagany.")] 
        [Range(1, int.MaxValue, ErrorMessage = "Klient jest wymagany.")]
        public int CustomerId { get; set; }

        [ValidateNever]
        public Customer Customer { get; set; }  

        // Relation: Reservation -> one Employee
        [Required(ErrorMessage = "Pracownik jest wymagany.")]
        [Range(1, int.MaxValue, ErrorMessage = "Pracownik jest wymagany.")]
        public int EmployeeId { get; set; }
        
        [ValidateNever]
        public Employee Employee { get; set; }  
}
