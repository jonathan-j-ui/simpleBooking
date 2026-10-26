using Microsoft.AspNetCore.Mvc;
using simpleBooking.Models;

namespace simpleBooking.Controllers;

public class AddressesController : ControllerBase
{
    private List<Address> _addressBook;

    public AddressesController(AddressBook addressBook)
    {
        _addressBook = addressBook;
    }
}