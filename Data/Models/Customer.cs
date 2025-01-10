using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HotelReservationApp.Data.Models;

public class Customer
{
    [ValidateNever]
    public int CustomerId { get; set; }
    
    [Required(ErrorMessage = "Imie jest wymagane.")]
    [MaxLength(20, ErrorMessage = "Imie może mieć maksymalnie 20 znaków.")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Nazwisko jest wymagane.")]
    [MaxLength(20, ErrorMessage = "Nazwisko może mieć maksymalnie 20 znaków.")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Numer telefonu jest wymagane.")]
    [MaxLength(9, ErrorMessage = "Numer telefonu może mieć maksymalnie 9 znaków.")]
    public string PhoneNumber { get; set; }
}
