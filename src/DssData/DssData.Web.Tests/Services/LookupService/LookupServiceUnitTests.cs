using DssData.Contexts;
using DssData.ModelInterfaces;
using DssData.Models;
using DssData.Web.Services;
using System;
using NUnit;
using NUnit.Framework;

namespace DssData.Web.Tests.Servicess
{
	public class LookupServiceUnitTests
	{
		public IDssDataContext _dssdataContext;
		public ILookupService SUT;
		public LookupServiceUnitTests()
		{

		}

		[SetUp]
		public void Setup()
		{
			//SUT = new LookupService(new DssDataContext(Constants.Connection.Test.Name));
		}

		[TearDown]
		public void TearDown()
		{
			SUT = null;
		}

		[Test]
		[ExpectedException(typeof(ArgumentNullException))]
		public void LookupService_Constructor_ThrowsErrorOnFailure()
		{
			SUT = new LookupService(null);
		}

		[Test]
		public void LookupService_Constructor_DoesNotThrowOnAppContext()
		{
			SUT = new LookupService(new DssDataContext());

		}

		[Test]
		public void LookupService_Constructor_DoesNotThrowOnTestContext()
		{
			SUT = new LookupService(new DssDataContext(Constants.Connection.Test.Name));
		}
	}
}
