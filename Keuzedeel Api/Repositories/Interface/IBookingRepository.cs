using Keuzedeel_Api.Models.Domain;

namespace Keuzedeel_Api.Repositories.Interface;

public interface IBookingRepository
{
	Task<Booking> CreateAsync(Booking booking);
}