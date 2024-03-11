using Keuzedeel_Api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Keuzedeel_Api.Data;

public class AppDbContext : DbContext
{
	protected readonly IConfiguration Configuration;

	public AppDbContext(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
	}
	
	public DbSet<User> users { get; set; }
	// public DbSet<Booking> bookings { get; set; }
	// public DbSet<Reservation> Reservations { get; set; }
	
}