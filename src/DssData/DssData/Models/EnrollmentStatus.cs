using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("_enrollment_statuses")]
	public class EnrollmentStatus : IEnrollmentStatus
	{
		[Column("pk_enrollment_status_id")]
		public int Id { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public EnrollmentStatus()
		{
		}
	}
}
