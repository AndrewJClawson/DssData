using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("_form_labels")]
	public class FormLabel : IFormLabel
	{
		[Column("pk_form_label_id")]
		public int FormLabelId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public FormLabel()
		{
		}
	}
}
