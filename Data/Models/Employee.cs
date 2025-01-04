using System;

namespace HotelReservationApp.Data.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }

    //Relation: Many Reservations -> One employee
    public List<Reservation> Reservations { get; set; }
}
