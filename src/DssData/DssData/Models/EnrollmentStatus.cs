using System;
using DssData.ModelInterfaces;

namespace DssData.Models
{
	public class EnrollmentStatus : IEnrollmentStatus
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public EnrollmentStatus()
		{
		}
	}
}
