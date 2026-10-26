namespace simpleBooking.Models;

public class Person
{
    public string? FirstName{ set; get; }
    public string? MiddleName  { set; get; }
    public Address? Address { set; get; }
    public string? Email { set; get; }
    public Country? Country { set; get; }
    public int? PhoneNumber { set; get; }
}

public enum Country
{
    Sweden,
    Norway,
    Denmark
}