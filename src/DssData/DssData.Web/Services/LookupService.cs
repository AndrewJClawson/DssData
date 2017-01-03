using DssData.Contexts;
using DssData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace DssData.Web.Services
{
	public class LookupService : ILookupService
	{
		private IDssDataContext _dataContext;
		public LookupService(IDssDataContext dssDataContext)
		{
			if (dssDataContext == null)
			{
				throw new ArgumentNullException();
			}
			else
			{
				_dataContext = dssDataContext;
			}
		}

		public IEnumerable<EnrollmentStatus> GetEnrollmentStatuses()
		{
			return _dataContext.EnrollmentStatuses;
		}

		public IEnumerable<Gender> GetGenders()
		{
			return _dataContext.Genders;
		}
	}
}
