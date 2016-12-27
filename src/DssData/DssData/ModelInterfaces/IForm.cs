using System;
using DssData.Models;
namespace DssData.ModelInterfaces
{
	public interface IForm
	{
		int FormId { get; set; }
		int FormLabelId { get; set; }
		int StudentId { get; set; }
		int QuarterId { get; set; }

		FormLabel Label { get; set; }
		Student Student { get; set; }
		Quarter Quarter { get; set; }
	}
}
