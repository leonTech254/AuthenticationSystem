using AUTHENTICATION_SYSTEM.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTHENTICATION_SYSTEM.Connections
{
	public class DbConn:DbContext
	{

		public DbSet<UserModel> user_Details { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-2KRMLJS\MSSQLSERVER01;Database=EFCoreDB1;Trusted_Connection=True;TrustServerCertificate=True;");
		}

		
	}
}
