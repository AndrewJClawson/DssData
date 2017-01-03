using DssData.Models;
using System;
using System.Collections.Generic;

namespace DssData.Web.Services
{
	public interface ILookupService
	{
		
		IEnumerable<EnrollmentStatus> GetEnrollmentStatuses();
		IEnumerable<Gender> GetGenders();
	}
}
