using System;
using DssData.Models;

namespace DssData.ModelInterfaces
{
	public interface IAssessment
	{
		int AssessmentId { get; set; }
		int AssessmentTitleId { get; set; }
		int FormId { get; set; }

	}
}
