namespace simpleBooking.Models;

public class Address
{   
    public int? Id { set; get; }
    public string? Street { set; get; }
    public int? StreetNo { set; get; }
    public string? City { set; get; }
    public int? PostalCode { set; get; }
}