using Keuzedeel_Api.Data;
using Keuzedeel_Api.Models.Domain;
using Keuzedeel_Api.Repositories.Interface;

namespace Keuzedeel_Api.Repositories.Implementation;

public class ReservationRepository : IReservationRepository
{
	private readonly AppDbContext _dbContext;
	
	public ReservationRepository(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}
	
	public async Task<Order> CreateAsync(Order order)
	{
		// await _dbContext.Reservation.AddAsync(category);
		await _dbContext.SaveChangesAsync();

		return order;
	}

}