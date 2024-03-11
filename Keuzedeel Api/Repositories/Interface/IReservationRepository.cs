using Keuzedeel_Api.Models.Domain;

namespace Keuzedeel_Api.Repositories.Interface;

public interface IReservationRepository
{ 
	Task<Order> CreateAsync(Order order);
}