namespace HotelReservationApp.Models;

public class RoomViewModel
{
    public int RoomId { get; set; }
    public string Type { get; set; } 
    public string PricePerNight { get; set; }
    public bool IsAvailable { get; set; }
}