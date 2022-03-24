using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class UserData
    {
		private static List<User> _testUsers = new List<User>();

		public static List<User> testUsers
		{
			get
			{
				resetUserData();
				return _testUsers;
			}

			set { }
		}
		public static void resetUserData()
		{
			if (!_testUsers.Any())
			{
				_testUsers.Add(FillUser(UserRoles.ADMIN));

				for (int i = 1; i < 2; i++)
				{
					_testUsers.Add(FillUser(UserRoles.STUDENT));
				}
			}
		}

		public static User IsUserPassCorrect(string name, string pass)
		{
			User user = (from account in testUsers where account.Name.Equals(name, StringComparison.Ordinal) && account.Pass.Equals(pass, StringComparison.Ordinal) select account).FirstOrDefault();

			return user;
		}

		public static User getUserByUsername(string name)
		{
			foreach (User user in testUsers)
			{
                if (name.Equals(user.Name, StringComparison.Ordinal))
				{
					return user;
				}
			}
			return null;
		}

		private static User FillUser(UserRoles role)
		{
			User user = new User();
			Console.WriteLine("Hello, please enter you username: ");
			user.Name = Console.ReadLine();
			Console.WriteLine("Enter your password");
			user.Pass = Console.ReadLine();
			Console.WriteLine("Enter your faculty number:");
			user.facNum = Console.ReadLine();
			user.Role = role;
			user.Created = DateTime.MaxValue;
			return user;
		}

		public static void SetUserActiveTo(string name, DateTime date)
		{
			foreach (User user in testUsers)
			{
				if (name.Equals(user.Name))
				{
					Logger.LogActivity("Change the activity of " + name);
					user.Created = date;
					break;
				}
			}
		}

		public static void seeAllUsers()
		{
			foreach (User user in _testUsers)
			{
				Console.WriteLine(user.Name);
			}
		}

		public static void AssignUserRole(string name, UserRoles role)
		{
			foreach (User user in testUsers)
			{
				if (name.Equals(user.Name, StringComparison.Ordinal))
				{
					Logger.LogActivity("Changing the role of " + name);
					user.Role = role;
					break;
				}
			}
		}

		public static void PrepareCertificate()
		{
			StringBuilder certificateBuffer = new StringBuilder();
			certificateBuffer.AppendLine("This certificate is evidence for graduating the following course and year for the following student");
			Console.WriteLine("Enter the username of the student");
			User user = getUserByUsername(Console.ReadLine());
			if (user == null)
			{
				Console.WriteLine("No such user");
				return;
			}
			certificateBuffer.AppendLine("Name: " + user.Name);
			certificateBuffer.AppendLine("Faculty number: " + user.facNum);
			Console.WriteLine("Enter speciality for student");
			certificateBuffer.AppendLine("Graduated specialty: " + Console.ReadLine());
			Console.WriteLine("Enter course of the student");
			certificateBuffer.AppendLine("Course: " + Console.ReadLine());
			while (true)
			{
				Console.WriteLine("Enter file name with exstension: ");
				string filename = Console.ReadLine();
				if ((filename == null) || !filename.Contains(".txt"))
				{
					Console.WriteLine("Invalid file");
				}
				else
				{

					SaveCertificate(certificateBuffer.ToString(), filename);
					break;
				}
			}

		}

		private static void SaveCertificate(string certificate, string filename)
		{
			if (File.Exists(filename))
			{
				Thread.Sleep(1000);
				File.AppendAllText(filename, certificate);
			}
			else
			{
				FileStream file = File.Create(filename);
				StreamWriter writer = new StreamWriter(file);
				writer.WriteLine(certificate);
				writer.Close();
				file.Close();
			}
		}

	}

}
