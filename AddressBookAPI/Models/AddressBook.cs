namespace AddressBookAPI.Models
{
	public class AddressBook
	{
		public int Id { get; set; }
		public string Address { get; set; }
		public string AddressNumber { get; set; }
		public string AddressStreet { get; set; }
		public string AddressStreetPart { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string StateCode { get; set; }
	}
}
