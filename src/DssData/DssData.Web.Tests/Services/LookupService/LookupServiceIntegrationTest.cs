using DssData.Constants;
using DssData.Contexts;
using DssData.ModelInterfaces;
using DssData.Models;
using DssData.Web.Services;

using System;
using System.Linq;
using System.Collections.Generic;

using NUnit;
using NUnit.Framework;

namespace DssData.Web.Tests.Services
{
	public class LookupServiceIntegrationTest
	{
		public IDssDataContext _dssDataContext;
		public ILookupService SUT;
		public LookupServiceIntegrationTest()
		{
		}

		[SetUp]
		public void Setup()
		{
			_dssDataContext = new DssDataContext(Constants.Connection.Test.Name);
			SUT = new LookupService(_dssDataContext);
		}

		[TearDown]
		public void TearDown()
		{
			SUT = null;
		}

		[Test]
		public void LookupService_GetFormLabels_HasUniqueFormA()
		{
			var formA = SUT.GetFormLabels().Where(l => l.Name == Constants.FormLabel.A.Name).ToList();
			Assert.True(formA.Count == 1);
		}

	}
}
