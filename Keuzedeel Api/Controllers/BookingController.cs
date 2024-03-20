using Keuzedeel_Api.Models.Domain;
using Keuzedeel_Api.Models.Dto;
using Keuzedeel_Api.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Keuzedeel_Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
	private readonly IBookingRepository _bookingRepository;
	
	public BookingController(IBookingRepository bookingRepository)
	{
		_bookingRepository = bookingRepository;
	}
	
	[HttpPost] 
	public async Task<IActionResult> AddBooking(BookingDto request)
	{
		var reservation = new Booking
		{
			BookingDate = request.BookingDate,
			BookingName = request.BookingName,
			BookingAmount = request.BookingAmount
		};
		
		await _bookingRepository.CreateAsync(reservation);
		
		var response = new BookingDto()
		{
			Id = reservation.Id,
			BookingAmount = reservation.BookingAmount,
			BookingDate = reservation.BookingDate,
			BookingName = reservation.BookingName
		};
		
		return new OkObjectResult(response);
	}
	//
	// [HttpGet]
	// public async Task<IActionResult> GetBookings()
	// {
	// 	return Ok();
	// }
	//
	//
	//
	// [HttpPut("{id}")]
	// public async Task<IActionResult> UpdateBooking(int id)
	// {
	// 	return Ok();
	// }
	//
	// [HttpDelete("{id}")]
	// public async Task<IActionResult> DeleteBooking(int id)
	// {
	// 	return Ok();
	// }
}