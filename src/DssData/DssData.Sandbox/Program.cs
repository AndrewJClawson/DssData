using System;
using System.Collections.Generic;
using DssData.Contexts;

namespace DssData.Sandbox
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			using (DssDataContext context = new DssDataContext())
			{
				var assessmentTitles = context.AssessmentTitles;
				foreach (var title in assessmentTitles)
				{
					System.Console.WriteLine(title.Name);
				}
			}
		}
	}
}
