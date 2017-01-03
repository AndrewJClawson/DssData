using System;

namespace DssData.ModelInterfaces
{
	public interface IStudent
	{
		int StudentId { get; set; }
		int CampusId { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }

	}
}
