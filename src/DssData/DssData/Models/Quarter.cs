using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("quarters")]
	public class Quarter : IQuarter
	{
		[Column("pk_quarter_id")]
		public int QuarterId { get; set; }

		[Column("number")]
		public int Number { get; set; }

		public virtual ICollection<Form> Forms { get; set; }

		public Quarter()
		{
		}
	}
}
