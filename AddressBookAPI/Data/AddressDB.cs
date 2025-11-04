using AddressBookAPI.Models;

namespace AddressBookAPI.Data
{
	public static class AddressDB
	{
		public static List<AddressBook> GetAddresses() => [
			new AddressBook {
				Id = 1,
				Address = "22 Elizabeth Court",
				AddressNumber = "22",
				AddressStreet = "Elizabeth",
				AddressStreetPart = "Ct"
			},
			new AddressBook {
				Id = 2,
				Address = "4 Tullily Lane",
				AddressNumber = "4",
				AddressStreet = "Tullily",
				AddressStreetPart = "Ln",
			}
		];
	}
}
