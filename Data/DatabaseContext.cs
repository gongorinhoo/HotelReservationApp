using HotelReservationApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationApp.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
        
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Room> Rooms { get; set; }
}