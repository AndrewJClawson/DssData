using System;

namespace DssData.ModelInterfaces
{
	public interface IStudent
	{
		int StudentId { get; set; }
		int CampusId { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Address { get; set; }
		string City { get; set; }
		string State { get; set; }
		string Zip { get; set; }
	}
}
