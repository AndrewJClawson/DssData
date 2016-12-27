using System;
namespace DssData.Constants
{
	public class Connection
	{
		public static Constant Application
		{
			get { return new Constant() { Id = 1, Name = "DssDataContext" }; }
		}

		public static Constant Test
		{
			get { return new Constant() { Id = 2, Name = "DssDataTestContext" }; }
		}

		public static Constant Auth
		{
			get { return new Constant() { Id = 3, Name = "DssDataAuth" }; }
		}
	}
}
