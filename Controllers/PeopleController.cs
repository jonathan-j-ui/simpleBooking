using Microsoft.AspNetCore.Mvc;
using simpleBooking.Models;

namespace simpleBooking.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class PeopleController : ControllerBase
{
    private AddressBook _addressBook;

    public PeopleController(AddressBook addressBook)
    {
        _addressBook = addressBook;
    }

    [HttpGet]
    public AddressBook GetAllPeople()
    {
        return _addressBook;
    }
}