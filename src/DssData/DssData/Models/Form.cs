using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("forms")]
	public class Form : IForm
	{
		[Column("pk_form_id")]
		public int FormId { get; set; }

		[Column("fk_form_label_id")]
		public int FormLabelId { get; set;}

		[Column("fk_student_id")]
		public int StudentId { get; set; }

		[Column("fk_quarter_id")]
		public int QuarterId { get; set; }

		[Column("test_date")]
		public DateTime TestDate { get; set; }

		public virtual FormLabel Label {get;set;}

		public virtual Student Student { get; set; }

		public virtual Quarter Quarter { get; set; }


		public Form()
		{
		}
	}
}
