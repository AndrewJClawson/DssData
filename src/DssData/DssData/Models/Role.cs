using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DssData.ModelInterfaces;
using System.Security;

namespace DssData.Models
{
	[Table("_roles")]
	public class Role : IRole
	{
		[Column("pk_role_id")]
		public int RoleId { get; set; }

		[Column("name")]
		public string Name { get; set; }

		public Role()
		{
		}
	}
}
