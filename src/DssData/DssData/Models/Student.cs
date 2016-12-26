using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("students")]
	public class Student : IStudent
	{
		[Column("pk_student_id")]
		public int StudentId { get; set; }

		[Column("fk_campus_id")]
		public int CampusId { get; set; }

		[Column("fk_enrollment_status_id")]
		public int EnrollmentStatusId { get; set; }

		[Column("first_name")]
		public string FirstName { get; set; }

		[Column("last_name")]
		public string LastName { get; set; }

		[Column("address")]
		public string Address { get; set; }

		[Column("city")]
		public string City { get; set; }

		[Column("state")]
		public string State { get; set; }

		[Column("zip")]
		public string Zip { get; set; }

		public Student()
		{
		}

	}
}
