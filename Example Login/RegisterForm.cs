using System.Linq;
namespace Example_Login
{
	public partial class RegisterForm : MetroFramework.Forms.MetroForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		#region Properties

		public static LoginForm loginForm = null;

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string UserName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string UserPicture { get; set; }

		#endregion /Properties

		#region RegisterForm_Load
		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
			if (loginForm == null || loginForm.IsDisposed == true)
			{
				loginForm =
					new LoginForm();
			}
		}
		#endregion /RegisterForm_Load
		//*****
		#region FirstNameTextBox_TextChanged
		private void FirstNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			FirstName = firstNameTextBox.Text;
		}

		#endregion /FirstNameTextBox_TextChanged
		//*****
		#region LastNameTextBox_TextChanged
		private void LastNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			LastName = lastNameTextBox.Text;
		}

		#endregion /LastNameTextBox_TextChanged
		//*****
		#region UsernameTextBox
		#region UsernameTextBox_TextChanged
		private void UsernameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			UserName = usernameTextBox.Text;
		}
		#endregion /UsernameTextBox_TextChanged
		//-----
		#region UsernameTextBox_Validated
		private void UsernameTextBox_Validated(object sender, System.EventArgs e)
		{
			string erroreMessage = string.Empty;
			; if (string.IsNullOrWhiteSpace(UserName))
			{
				erroreMessage =
					"Please type your username...! ";
				usernameTextBox.Focus();
			}

			if (erroreMessage != string.Empty)
			{
				if (string.IsNullOrWhiteSpace(UserName))
				{
					usernameTextBox.Focus();
				}

				System.Windows.Forms.MessageBox.Show
					(text: erroreMessage,
					caption: "Enter error",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error);
			}

		}
		#endregion /UsernameTextBox_Validated
		#endregion /UsernameTextBox
		//*****
		#region AddUserPictureLinkLabel_LinkClicked
		private void AddUserPictureLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPEP (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				UserPicture = openFileDialog.FileName;

				userPicPicturBox.Image = System.Drawing.Image.FromFile(UserPicture);
				//deletePicturBox.Visible = true;
			}
		}
		#endregion /AddUserPictureLinkLabel_LinkClicked
		//*****
		#region NewEmailTextBox
		#region NewEmailTextBox_TextChanged
		private void NewEmailTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Email = newEmailTextBox.Text;
		}
		#endregion /NewEmailTextBox_TextChanged
		//-----
		#region NewEmailTextBox_Validated
		private void NewEmailTextBox_Validated(object sender, System.EventArgs e)
		{
			if (newEmailTextBox.Text == string.Empty)
			{
				return;
			}
			else if (Models.Email.EmailChecker(Email) == true || Email == string.Empty)
			{
				newEmailTextBox.BackColor = System.Drawing.SystemColors.Window;
				newEmailTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
				return;
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("email format is incorrect. Please try again.");
				newEmailTextBox.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
				newEmailTextBox.ForeColor = System.Drawing.SystemColors.Window;
				newEmailTextBox.Focus();
				newEmailTextBox.SelectAll();
			}
		}
		#endregion /NewEmailTextBox_Validated 
		#endregion/NewEmailTextBox
		//*****
		#region ConfirmNewEmailTextBox_Leave
		private void ConfirmNewEmailTextBox_Validated(object sender, System.EventArgs e)
		{
			if (Models.Email.EmailChecker(confirmNewEmailTextBox.Text) == true || confirmNewEmailTextBox.Text == string.Empty)
			{
				confirmNewPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
				confirmNewPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;

				return;
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("email format is incorrect. Please try again.");

				confirmNewPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
				confirmNewPasswordTextBox.ForeColor = System.Drawing.SystemColors.Window;
				confirmNewEmailTextBox.Focus();
				confirmNewEmailTextBox.SelectAll();
			}

			if (string.Compare(confirmNewEmailTextBox.Text, Email, false) == 0)
			{
				newEmailTextBox.BackColor = System.Drawing.SystemColors.Window;
				newEmailTextBox.ForeColor = System.Drawing.SystemColors.WindowText;

				confirmNewPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
				confirmNewPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;

				return;
			}

			else
			{
				System.Windows.Forms.MessageBox.Show("Emails do not match. Please try again.");

				newEmailTextBox.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
				newEmailTextBox.ForeColor = System.Drawing.SystemColors.Window;
				newEmailTextBox.Focus();
				newEmailTextBox.SelectAll();

				confirmNewPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
				confirmNewPasswordTextBox.ForeColor = System.Drawing.SystemColors.Window;
			}
		}
		#endregion /ConfirmNewEmailTextBox_Leave
		//*****
		#region NewPasswordTextBox_TextChanged
		private void NewPasswordTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Password = newPasswordTextBox.Text;
		}
		#endregion /NewPasswordTextBox_TextChanged
		//*****
		#region ConfirmNewPasswordTextBox_Validated
		private void ConfirmNewPasswordTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.Compare(newPasswordTextBox.Text, confirmNewPasswordTextBox.Text, ignoreCase: true) == 0 || confirmNewPasswordTextBox.Text == string.Empty)
			{
				newPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
				newPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;

				confirmNewPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
				confirmNewPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			}

			else
			{
				System.Windows.Forms.MessageBox.Show(text: "Password does not match. Please try again.",
					caption: "Match errore",
					buttons: System.Windows.Forms.MessageBoxButtons.OK,
					icon: System.Windows.Forms.MessageBoxIcon.Error);

				confirmNewPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
				confirmNewPasswordTextBox.ForeColor = System.Drawing.SystemColors.Window;

				newPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
				newPasswordTextBox.ForeColor = System.Drawing.SystemColors.Window;
				newPasswordTextBox.Focus();
				newPasswordTextBox.SelectAll();
			}
		}
		#endregion /ConfirmNewPasswordTextBox_Validated
		//*****
		#region LoginLinkLabel_LinkClicked
		private void LoginLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			loginForm.Show();
		}
		#endregion /LoginLinkLabel_LinkClicked
		//*****
		#region RegisterButton_Click
		private void RegisterButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();
				string errorMessage = string.Empty;

				if (string.IsNullOrEmpty(UserPicture))
				{
					errorMessage =
						"Please select a photo for the user.";
				}

				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrEmpty(UserPicture))
					{
						System.Windows.Forms.MessageBox.Show(
							text:errorMessage,
							caption:"Picture error",
							buttons: System.Windows.Forms.MessageBoxButtons.OK,
							icon: System.Windows.Forms.MessageBoxIcon.Error);

						System.Windows.Forms.OpenFileDialog openFileDialog =
							new System.Windows.Forms.OpenFileDialog
							{
								Filter = "JPEP (*.jpg)|*.jpg|"+
								"PNG (*.png)|*.png|"+
								"BMP (*.bmp)|*.bmp",
								Title = "Load user picture ",
							};

						if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
						{
							UserPicture = openFileDialog.FileName;

							userPicPicturBox.Image = System.Drawing.Image.FromFile(UserPicture);
						}
					}
				}

				Models.User user =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (user != null)
				{
					string error =
						"This Username already exists. Use a different Username.";
					System.Windows.Forms.MessageBox.Show(error, "Username error");

					usernameTextBox.Focus();
					return;
				}
				user = new Models.User
				{
					FirstName = firstNameTextBox.Text,
					LastName = lastNameTextBox.Text,
					Username = usernameTextBox.Text,
					Email = newEmailTextBox.Text,
					Password = newPasswordTextBox.Text,
					UserPicture = System.IO.File.ReadAllBytes(UserPicture),
				};

				databaseContext.Users.Add(user);
				databaseContext.SaveChanges();

				string message =
					$"Username {usernameTextBox.Text} created.";

				System.Windows.Forms.MessageBox.Show(message);

				if (loginForm != null)
				{
					loginForm.UserLoader();
				}

			}
			catch (System.Exception ex)
			{

				System.Windows.Forms.MessageBox.Show(ex.Message);
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
		#endregion /RegisterButton_Click
		//*****
		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			Mbb.Windows.Forms.Appliction.Exit();
		}
		#endregion /ExitButton_Click

		
	}

}
