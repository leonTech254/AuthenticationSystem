// See https://aka.ms/new-console-template for more information
using AUTHENTICATION_SYSTEM.Connections;
using AUTHENTICATION_SYSTEM.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
class Program
{
	static void Main()
	{

		DbConn dbConn = new DbConn();
		if (isConn(dbConn))
		{
			Console.WriteLine("Connected Successfully");

		}
		else
		{
			Console.WriteLine("Failed to connect");
		}

		using (var dbContext = new DbConn())
		{
			/*ADDING THE UER TO THE DATABASE*/

			RegisterUsersService registerUsersService = new RegisterUsersService();
			registerUsersService.registerUser();

			Console.WriteLine("User registered successfully!");
		}
	}

	static bool isConn(DbConn dbConn)
	{
		try
		{
			dbConn.Database.OpenConnection();
			return true;
		}
		catch (Exception e)
		{
			Console.WriteLine(e.ToString());
			return false;

		}
	}
}

