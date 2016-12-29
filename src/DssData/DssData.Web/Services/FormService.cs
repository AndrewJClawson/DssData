using DssData.Contexts;
using DssData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DssData.Web.Services
{
	public class FormService : IFormService
	{
		private IDssDataContext _dataContext;
		public FormService(IDssDataContext dataContext)
		{
			if (dataContext == null)
			{
				throw new ArgumentNullException();
			}
			else
			{
				_dataContext = dataContext;
			}
		}

		public IEnumerable<FormLabel> GetFormLabels()
		{
			return _dataContext.FormLabels;
		}


	}
}
