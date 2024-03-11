namespace Keuzedeel_Api.Models.Domain;

public class Order
{
	public int Id { get; set; }
	
	public string ProductName { get; set; }
	
	public int Price { get; set; }
	
	// public DateTime OrderTime { get; set; }
}