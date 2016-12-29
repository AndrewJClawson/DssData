using System;
using System.Collections.Generic;
using DssData.Contexts;

namespace DssData.Sandbox
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			using (DssDataContext context = new DssDataContext("DssDataTestContext"))
			{
				var assessmentTitles = context.AssessmentTitles;
				var formLabels = context.FormLabels;
				foreach (var label in formLabels)
				{
					System.Console.WriteLine(label.Name);
				}
			}
		}
	}
}
