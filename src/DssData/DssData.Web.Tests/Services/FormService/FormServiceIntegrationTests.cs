using DssData.Web.Services;
using DssData.Contexts;
using System.Linq;
using NUnit.Framework;

namespace DssData.Web.Tests.Services
{
	public class FormServiceIntegrationTests
	{
		public FormServiceIntegrationTests()
		{
		}

		public IDssDataContext _dssDataContext;
		public IFormService SUT;


		[SetUp]
		public void Setup()
		{
			_dssDataContext = new DssDataContext(Constants.Connection.Test.Name);
			SUT = new FormService(_dssDataContext);
		}

		[TearDown]
		public void TearDown()
		{
			SUT = null;
		}

		[Test]
		public void FormService_GetFormLabels_HasFormA()
		{
			var formList = this.SUT.GetFormLabels().Where(l => l.FormLabelId == Constants.FormLabel.A.Id).ToList();
			Assert.That(formList.FirstOrDefault().Name == Constants.FormLabel.A.Name);

		}

		[Test]
		public void FormService_GetFormLabels_HasFormB()
		{
			var formList = this.SUT.GetFormLabels().Where(l => l.FormLabelId == Constants.FormLabel.B.Id).ToList();
			Assert.That(formList.FirstOrDefault().Name == Constants.FormLabel.B.Name);
		}
	}
}
