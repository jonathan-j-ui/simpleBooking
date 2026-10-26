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
    public AddressBook GetAllPeople()
    {
        return _addressBook;
    }
}