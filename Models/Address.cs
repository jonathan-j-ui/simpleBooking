namespace simpleBooking.Models;

public class Address
{
    public AddressType addressType{ set; get; }
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