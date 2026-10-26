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
    public IActionResult GetAllAddresses(
        [FromQuery] string? street = null,
        [FromQuery] int? streetNo = null,
        [FromQuery] string? city = null,
        [FromQuery] int? postalCode = null,
        [FromQuery] Country? country = null
    )
    {
        var addresses = new Dictionary<int, (Address Address, int Count)>();

        foreach (var person in _addressBook.People)
        {
            var address = person.Address;

            if (address == null)
            {
                continue;
            }

            if (street != null && !string.Equals(address.Street, street, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if (city != null && !string.Equals(address.City, city, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if(postalCode.HasValue && address.PostalCode != postalCode.Value)
            {
                continue;
            }

            if (country.HasValue && person.Country != country.Value)
            {
                continue;
            }

            if(addresses.TryGetValue(address.Id, out var entry))
            {
                addresses[address.Id] = (entry.Address, entry.Count + 1);
            }
            else
            {
                addresses.Add(address.Id, (address, 1));
            }
        }

        return Ok(addresses.Values.Select(entry => new
        {
            Address = entry.Address,
            Count = entry.Count
        }).ToList());
    }
}