using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class LoginValidation
    {
		private string _name, _password, _email;
		private static UserRoles _currentUserRole;
		public static string name
		{
			get;
		}

		public delegate void ActionOnError(string error);

		private ActionOnError _onError;

		public LoginValidation(string name, string password, ActionOnError error)
		{
			_name = name;
			_password = password;
			_onError = error;
		}

		public static UserRoles currentUserRole
		{
			get;
			private set;
		}

		public static UserRoles getRole()
		{
			return _currentUserRole;
		}


		public bool validateUserInput(ref User user)
		{
			string errorMessage;


			if (_name.Equals(null) || _password.Equals(null))
			{
				user.Role = UserRoles.ANONYMOUS;
				_onError("Null username or password");
				return false;
			}
			else if (IsStringEmpty(_name) || IsStringEmpty(_name))
			{
				user.Role = UserRoles.ANONYMOUS;
				_onError("Empty username or password");
				return false;
			}
			else if (IsStringLessThan5(_name) || IsStringLessThan5(_name))
			{
				user.Role = UserRoles.ANONYMOUS;
				_onError("Username or password");
				return false;
			}

			user = UserData.IsUserPassCorrect(_name, _password);

			if (user == null)
			{
				errorMessage = "No user";
				_onError(errorMessage);
				return false;
			}
			_currentUserRole = user.Role;
			Logger.LogActivity("Successed Login");
			return true;
		}



		private static bool IsStringEmpty(string word)
		{
			return word.Equals(String.Empty);
		}

		private static bool IsStringLessThan5(string word)
		{
			return word.Length < 5;
		}

		public LoginValidation()
		{
		}
	}
}
