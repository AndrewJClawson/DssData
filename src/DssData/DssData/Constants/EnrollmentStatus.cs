using System;
namespace DssData.Constants
{
	public class EnrollmentStatus
	{
		public static Constant Enrolled
		{
			get { return new Constant { Id = 1, Name = "Enrolled" }; }
		}

		public static Constant Active
		{
			get {return new Constant {Id = 2, Name = "Active"}; }
		}

		public static Constant Graduated
		{
			get { return new Constant { Id = 3, Name = "Graduated" }; }
		}

		public static Constant Withdrawn
		{
			get { return new Constant { Id = 4, Name = "Withdrawn" }; }
		}

	}
}
