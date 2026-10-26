namespace simpleBooking.Models;

public class AddressBook
{
    public AddressBook()
    {
        People = new List<Person>
        {
            new()
            {
                FirstName = "Stefan",
                MiddleName = "Erik",
                Email = "stefan@example.com",
                Country = Country.Sweden,
                PhoneNumber = 701234567,
                Address = new Address
                {
                    Street = "Avenyn",
                    StreetNo = 25,
                    City = "Göteborg",
                    PostalCode = 41136
                }
            },
            new()
            {
                FirstName = "Malin",
                MiddleName = "Sofia",
                Email = "malin@example.com",
                Country = Country.Sweden,
                PhoneNumber = 702345678,
                Address = new Address
                {
                    Street = "Avenyn",
                    StreetNo = 25,
                    City = "Göteborg",
                    PostalCode = 41136
                }
            },
            new()
            {
                FirstName = "Anna",
                MiddleName = "Maria",
                Email = "anna@example.com",
                Country = Country.Sweden,
                PhoneNumber = 703456789,
                Address = new Address
                {
                    Street = "Storgatan",
                    StreetNo = 8,
                    City = "Malmö",
                    PostalCode = 21141
                }
            },
            new()
            {
                FirstName = "Lars",
                MiddleName = "Magnus",
                Email = "lars@example.com",
                Country = Country.Norway,
                PhoneNumber = 41234567,
                Address = new Address
                {
                    Street = "Storgata",
                    StreetNo = 15,
                    City = "Oslo",
                    PostalCode = 184
                }
            },
            new()
            {
                FirstName = "Ingrid",
                MiddleName = "Elise",
                Email = "ingrid@example.com",
                Country = Country.Norway,
                PhoneNumber = 42345678,
                Address = new Address
                {
                    Street = "Strandgaten",
                    StreetNo = 42,
                    City = "Bergen",
                    PostalCode = 5004
                }
            },
            new()
            {
                FirstName = "Frederik",
                MiddleName = "Christian",
                Email = "frederik@example.com",
                Country = Country.Denmark,
                PhoneNumber = 23456789,
                Address = new Address
                {
                    Street = "Nørrebrogade",
                    StreetNo = 18,
                    City = "København",
                    PostalCode = 2200
                }
            },
            new()
            {
                FirstName = "Sofie",
                MiddleName = "Marie",
                Email = "sofie@example.com",
                Country = Country.Denmark,
                PhoneNumber = 34567890,
                Address = new Address
                {
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