using System;
using System.Linq;
using System.Windows.Forms;

namespace Example_Login
{
	static class Program
	{
		#region Login
		private static LoginForm loginForm;

		public static LoginForm LoginForm
		{
			get
			{
				if (loginForm == null || loginForm.IsDisposed == true )
				{
					loginForm =
						new LoginForm();
				}

				return loginForm;
			}
		}

		public static void ShowLogin()
		{
			loginForm.Show();
		}

		#endregion /Login

		//-----

		#region Register
		private static RegisterForm registerForm;

		private static RegisterForm RegisterForm
		{
			get
			{
				if (registerForm == null || registerForm.IsDisposed == true)
				{
					registerForm =
						new RegisterForm();
				}

				return registerForm;
			}
		}

		public static void ShowRegister()
		{
			RegisterForm.Show();
		}
		#endregion /Register

		//-----

		#region AdminUser
		public static void AdminUser()
		{
			Models.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string username = "Administrator";

				Models.User adminUser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, username, true) == 0)
					.FirstOrDefault();

				if (adminUser == null)
				{
					adminUser = new Models.User
					{
						Username = username,
						Email = "Admin@admin.com",
						Password = "12345",
					};

					databaseContext.Users.Add(adminUser);
				}

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
		#endregion /AdminUser

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AdminUser();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
