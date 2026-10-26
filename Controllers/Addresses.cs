using Microsoft.AspNetCore.Mvc;
using simpleBooking.Models;

namespace simpleBooking.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AddressesController : ControllerBase
{
    private AddressBook _addressBook;

    public AddressesController(AddressBook addressBook)
    {
        _addressBook = addressBook;
    }

    [HttpGet]
    public IActionResult GetAllAddresses()
    {
        var addresses = new Dictionary<(string? Street, int? StreetNo, string? City, int? PostalCode), int>();

        foreach (var person in _addressBook.People)
        {
            var address = person.Address;

            if (address == null)
            {
                continue;
            }

            var key = (
                address.Street,
                address.StreetNo,
                address.City,
                address.PostalCode
            );

            if(addresses.TryGetValue(key, out int count))
            {
                addresses[key] = count + 1;
            }
            else
            {
                addresses.Add(key, 1);
            }
        }

        return Ok(addresses.Select(r => new
        {
            Address = new Address
            {
                Street = r.Key.Street,
                StreetNo = r.Key.StreetNo,
                City = r.Key.City,
                PostalCode = r.Key.PostalCode
            },
            Count = r.Value
        }).ToList());
    }
}