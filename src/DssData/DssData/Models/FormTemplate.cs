using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("_form_templates")]
	public class FormTemplate : IFormTemplate
	{
		[Column("pk_form_template_id")]
		public int FormTemplateId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public FormTemplate()
		{
		}
	}
}
