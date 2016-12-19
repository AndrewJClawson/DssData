using System;
namespace DssData.ModelInterfaces
{
	public interface IPermission
	{
		int PermissionId { get; set; }
		int ContentTypeOperationId { get; set; }
		string Name { get; set; }
	}
}
