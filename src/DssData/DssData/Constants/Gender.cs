using System;

namespace DssData.Constants
{
	public class Gender
	{
		public static Constant Male
		{
			get { return new Constant() { Id = 1, Name = "Male" };}
		}

		public static Constant Female
		{
			get { return new Constant() { Id = 2, Name = "Female" }; }
		}
	}
}
