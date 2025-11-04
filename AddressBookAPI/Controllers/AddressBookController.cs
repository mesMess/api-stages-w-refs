using AddressBookAPI.Data;
using AddressBookAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AddressBookAPI.Controllers
{
	[Route("api/AddressBook")]
	[ApiController]
	public class AddressBookController : ControllerBase
	{
		[HttpGet]
		public ActionResult<List<AddressBook>> GetAddresses()
		{
			return Ok(AddressDB.GetAddresses());
		}

		[HttpGet]
		[Route("{id}")]
		public ActionResult<AddressBook> GetAddressById(int id)
		{
			var address = AddressDB.GetAddresses().FirstOrDefault(a => a.Id == id);
			if (address is null)
			{
				return NotFound();
			}

			return Ok(address);
		}

		[HttpPost]
		public ActionResult AddAddress(AddressBook address)
		{
			if (address is null)
			{
				return BadRequest();
			}

			address.Id = AddressDB.GetAddresses().Max(c => c.Id) + 1;
			AddressDB.GetAddresses().Add(address);
			return CreatedAtAction(nameof(GetAddressById), new { id = address.Id }, address);
		}

		[HttpPut]
		[Route("{id}")]
		public IActionResult UpdateAddress(int id, AddressBook updatedAddress)
		{
			if (updatedAddress is null)
			{
				return BadRequest();
			}

			updatedAddress.AddressNumber = "Updated Addr No";

			return NoContent();
		}
	}
}
