namespace Keuzedeel_Api.Models.Domain;

public class Booking
{
	public int Id { get; set; }
	
	public int BookingAmount { get; set; }
	
	public string BookingName { get; set; }
	
	public string BookingDate { get; set; }
}