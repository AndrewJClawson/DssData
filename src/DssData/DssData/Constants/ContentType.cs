using System;
namespace EduSim.Core.Constants
{
	public class ContentType
	{

		public static Constant User
		{
			get { return new Constant() { Id = 1, Name = "User" }; }
		}

		public static Constant Profile
		{
			get { return new Constant() { Id = 2, Name = "Profile" }; }
		}
	}
}
