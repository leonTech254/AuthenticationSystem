using AUTHENTICATION_SYSTEM.Connections;
using AUTHENTICATION_SYSTEM.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AUTHENTICATION_SYSTEM.Services
{
	public class RegisterUsersService
	{
		public void registerUser()
		{
			using(var dbcontext=new DbConn())
			{
				UserModel userModel = new UserModel()
				{
					username = "martin",
					password = "martin123456"
				};
				dbcontext.user_Details.Add(userModel);
				dbcontext.SaveChanges();
			}
			
		}

		

	}
}
