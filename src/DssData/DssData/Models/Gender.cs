using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("_genders")]
	public class Gender : IGender
	{
		[Column("pk_gender_id")]
		public int GenderId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public Gender()
		{
		}
	}
}
