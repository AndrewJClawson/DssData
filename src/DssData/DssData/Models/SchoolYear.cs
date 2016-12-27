using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("school_years")]
	public class SchoolYear : ISchoolYear
	{
		[Column("pk_school_year_id")]
		public int SchoolYearId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		// Navigation properties
		public virtual ICollection<Quarter> Quarters {get;set;}

		public SchoolYear()
		{
		}
	}
}
