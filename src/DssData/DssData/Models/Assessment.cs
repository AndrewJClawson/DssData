using System;
using DssData.ModelInterfaces;

namespace DssData.Models
{
	public class Assessment : IAssessment
	{
		public int AssessmentId { get; set; }
		public int AssessmentTitleId { get; set; }
		public int FormId { get; set; }

		public virtual AssessmentTitle Title { get; set; }

		public virtual Form Form { get; set; }

		public Assessment()
		{
			
		}
	}
}
