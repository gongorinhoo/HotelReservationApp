namespace HotelReservationApp.Models;

public class ReservationViewModel
{
    public int ReservationId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    public RoomViewModel Room { get; set; }
    public CustomerViewModel Customer { get; set; }  
    public EmployeeViewModel Employee { get; set; } 
}