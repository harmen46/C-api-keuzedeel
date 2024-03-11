using Keuzedeel_Api.Models.Domain;
using Keuzedeel_Api.Models.Dto;
using Keuzedeel_Api.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
 
namespace Keuzedeel_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
	private readonly IReservationRepository _reservationRepository;
	
	public OrderController(IReservationRepository reservationRepository)
	{
		_reservationRepository = reservationRepository;
	}
	
	[HttpGet]
	public async Task<IActionResult> GetReservations()
	{
		return Ok();
	}
	
	[HttpPost] 
	public async Task<IActionResult> AddReservation(ReservationDto reservationDto)
	{
		var reservation = new Order
		{
			ProductName = reservationDto.ProductName,
			Price = reservationDto.Price
		};
		
		await _reservationRepository.CreateAsync(reservation);
		
		return Ok();
	}
	
	[HttpPut("{id}")]
	public async Task<IActionResult> UpdateReservation(int id)
	{
		return Ok();
	}
	
	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteReservation(int id)
	{
		return Ok();
	}
}