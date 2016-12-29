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
		public void LookupService_GetEnrollmentStatuses_HasEnrolled()
		{
			var enrollmentStatusList = this.SUT.GetEnrollmentStatuses().Where(s => s.Id == Constants.EnrollmentStatus.Enrolled.Id).ToList();
			Assert.That(enrollmentStatusList.FirstOrDefault().Name == Constants.EnrollmentStatus.Enrolled.Name);
		}

		[Test]
		public void LookupService_GetEnrollmentStatuses_HasActive()
		{
			var enrollmentStatusList = this.SUT.GetEnrollmentStatuses().Where(s => s.Id == Constants.EnrollmentStatus.Active.Id).ToList();
			Assert.That(enrollmentStatusList.FirstOrDefault().Name == Constants.EnrollmentStatus.Active.Name);
		}

	}
}
