namespace simpleBooking.Models;

public class Address
{
    public AddressType addressType{ set; get; }
    public string Street { set; get; }
    public int StreetNo { set; get; }
    public string City { set; get; }
    public int PostalCode { set; get; }
}

public class AddressType
{
    public static AddressType Business { get; } = new AddressType("Business");
    public static AddressType Person { get; } = new AddressType("Person");

    public string Name { get; }

    private AddressType(string name)
    {
        Name = name;
    }
}