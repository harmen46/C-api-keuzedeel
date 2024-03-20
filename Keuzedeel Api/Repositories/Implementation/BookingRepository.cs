using Keuzedeel_Api.Data;
using Keuzedeel_Api.Models.Domain;
using Keuzedeel_Api.Repositories.Interface;

namespace Keuzedeel_Api.Repositories.Implementation;

public class BookingRepository : IBookingRepository
{
	private readonly AppDbContext _dbContext;

	public BookingRepository(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<Booking> CreateAsync(Booking booking)
	{
		await _dbContext.bookings.AddAsync(booking);
		await _dbContext.SaveChangesAsync();

		return booking;
	}
}