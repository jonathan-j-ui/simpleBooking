namespace simpleBooking.Models;

public class AddressBook
{
public AddressBook()
{
    var sharedAddress = new Address
    {
        Id = 1,
        Street = "Avenyn",
        StreetNo = 25,
        City = "Göteborg",
        PostalCode = 41136
    };

    People = new List<Person>
    {
        new()
        {
            Id = 1,
            FirstName = "Stefan",
            LastName = "Eriksson",
            Email = "stefan@example.com",
            Country = Country.Sweden,
            PhoneNumber = 701234567,
            Address = sharedAddress
        },
        new()
        {
            Id = 2,
            FirstName = "Malin",
            LastName = "Nilsson",
            Email = "malin@example.com",
            Country = Country.Sweden,
            PhoneNumber = 702345678,
            Address = sharedAddress
        },
        new()
        {
            Id = 3,
            FirstName = "Anna",
            LastName = "Mare",
            Email = "anna@example.com",
            Country = Country.Sweden,
            PhoneNumber = 703456789,
            Address = new Address
            {
                Id = 2,
                Street = "Storgatan",
                StreetNo = 8,
                City = "Malmö",
                PostalCode = 21141
            }
        },
        new()
        {
            Id = 4,
            FirstName = "Lars",
            LastName = "Hammar",
            Email = "lars@example.com",
            Country = Country.Norway,
            PhoneNumber = 41234567,
            Address = new Address
            {
                Id = 3,
                Street = "Storgata",
                StreetNo = 15,
                City = "Oslo",
                PostalCode = 184
            }
        },
        new()
        {
            Id = 5,
            FirstName = "Ingrid",
            LastName = "Alesdotter",
            Email = "ingrid@example.com",
            Country = Country.Norway,
            PhoneNumber = 42345678,
            Address = new Address
            {
                Id = 4,
                Street = "Strandgaten",
                StreetNo = 42,
                City = "Bergen",
                PostalCode = 5004
            }
        },
        new()
        {
            Id = 6,
            FirstName = "Frederik",
            LastName = "Christiansen",
            Email = "frederik@example.com",
            Country = Country.Denmark,
            PhoneNumber = 23456789,
            Address = new Address
            {
                Id = 5,
                Street = "Nørrebrogade",
                StreetNo = 18,
                City = "København",
                PostalCode = 2200
            }
        },
        new()
        {
            Id = 7,
            FirstName = "Sofie",
            LastName = "Larsen",
            Email = "sofie@example.com",
            Country = Country.Denmark,
            PhoneNumber = 34567890,
            Address = new Address
            {
                Id = 6,
                Street = "Vestergade",
                StreetNo = 7,
                City = "Aarhus",
                PostalCode = 8000
            }
        }
    };
}

    public List<Person> People { get; set; }
}