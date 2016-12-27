using System;
using System.Data.Entity;
using MySql.Data.Entity;
using DssData.Models;

namespace DssData.Contexts
{
	public interface IDssDataContext
	{
		DbSet<ContentType> ContentTypes {get;set;}
		DbSet<Operation> Operations { get; set; }
		DbSet<ContentTypeOperation> ContentTypeOperations { get; set; }
		DbSet<Permission> Permissions { get; set; }
		DbSet<ProfilePermission> ProfilePermissions { get; set; }

		DbSet<Role> Roles { get; set; }
		DbSet<EnrollmentStatus> EnrollmentStatuses { get; set; }
		// Application API models
		//public DbSet<Account> Accounts { get; set; }
		DbSet<Profile> Profiles { get; set; }
		//public DbSet<School> Schools { get; set; }
		DbSet<Student> Students { get; set; }

		DbSet<FormLabel> FormLabels { get; set; }
		DbSet<Form> Forms { get; set; }
		DbSet<AssessmentTitle> AssessmentTitles { get; set; }
	}
}
