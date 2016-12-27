using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DssData.ModelInterfaces;

namespace DssData.Models
{
	[Table("_assessment_titles")]
	public class AssessmentTitle : IAssessmentTitle
	{
		[Column("pk_assessment_title_id")]
		public int AssessmentTitleId {get;set;}

		[Column("name")]
		public string Name { get; set; }

		public AssessmentTitle()
		{
		}
	}
}
