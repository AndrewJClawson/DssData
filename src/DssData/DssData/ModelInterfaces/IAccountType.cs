using System;
using System.ComponentModel;

namespace DssData.ModelInterfaces
{
	
	public interface IAccountType
	{
		int AccountTypeId { get; set; }
		string Name { get; set; }
	}
}
