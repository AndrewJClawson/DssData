using DssData.Contexts;
using DssData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DssData.Web.Services
{
	public interface IFormService
	{
		IEnumerable<FormLabel> GetFormLabels();
	}
}
