using System.Linq;
namespace Example_Login
{
	public partial class LoginForm : MetroFramework.Forms.MetroForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		#region LoginForm_Load
		private void LoginForm_Load(object sender, System.EventArgs e)
		{
			UserLoader();
		}
		#endregion /LoginForm_Load

		#region SignUpLinkLabel_LinkClicked
		private void SignUpLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Hide();
			Program.ShowRegister();
		}
		#endregion /SignUpLinkLabel_LinkClicked

		#region UserLoader
		public void UserLoader()
		{
			userDataGridView.ReadOnly = true;

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.User> users = null;

				users =
					databaseContext.Users
					.OrderBy(current => current.Username)
					.ToList();

				userDataGridView.DataSource = users;

				userDataGridView.AutoResizeColumns
					(autoSizeColumnsMode: System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);

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

		#endregion /UserLoader

		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			Mbb.Windows.Forms.Appliction.Exit();
		}
		#endregion /ExitButton_Click

		#region UserDataGridView_CellDoubleClick
		private void UserDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DatabaseContext databaseContext = new Models.DatabaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			usernameTextBox.Text = userDataGridView.CurrentRow.Cells[0].Value.ToString();

			//*****For load picture whith DataGrtidView in PictureBox
			var byteImage = (byte[])userDataGridView.CurrentRow.Cells[1].Value;

			if (byteImage == null)
			{
				userPicPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
				userPicPicturBox.Image = Properties.Resources.error_no_512;

				return;
			}
			else
			{
				userPicPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					userPicPicturBox.Image = System.Drawing.Image.FromStream(ms);
				}
			}

			passwordTextBox.Focus();
		}
		#endregion /UserDataGridView_CellDoubleClick

		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string errorMessage = string.Empty;

				#region Validation
				if (string.IsNullOrWhiteSpace(usernameTextBox.Text)|| usernameTextBox.Text == string.Empty)
				{
					errorMessage =
						"Please type your USERNAME!";

					usernameTextBox.Focus();
				}

				if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordTextBox.Text == string.Empty)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage += 
							System.Environment.NewLine;
					}

					errorMessage +=
						"please type your PASSWORD!";

					passwordTextBox.Focus();
				}

				if (errorMessage!=string.Empty)
				{
					if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || usernameTextBox.Text == string.Empty)
					{
						usernameTextBox.Focus();
						usernameTextBox.SelectAll();
					}
					else
					{
						passwordTextBox.Focus();
						passwordTextBox.SelectAll();
					}

					System.Windows.Forms.MessageBox.Show
						(text: errorMessage,
						caption: "Enter error",
						buttons: System.Windows.Forms.MessageBoxButtons.OK,
						icon: System.Windows.Forms.MessageBoxIcon.Warning);
				}
				#endregion /Validation

				Models.User foundUser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();
				if (foundUser == null )
				{
					string error =
						"Wrong username or password...!";

					System.Windows.Forms.MessageBox.Show
						(text: error,
						caption: "Identification error",
						buttons: System.Windows.Forms.MessageBoxButtons.OK,
						icon: System.Windows.Forms.MessageBoxIcon.Warning);

					usernameTextBox.Focus();
					usernameTextBox.SelectAll();

					return;
				}

				if (string.Compare(foundUser.Password,passwordTextBox.Text,true) != 0)
				{
					string error =
						"Wrong username or password...!";

					System.Windows.Forms.MessageBox.Show
						(text: error,
						caption: "Identification error",
						buttons: System.Windows.Forms.MessageBoxButtons.OK,
						icon: System.Windows.Forms.MessageBoxIcon.Warning);

					usernameTextBox.Focus();
					usernameTextBox.SelectAll();

					return;
				}

				System.Windows.Forms.MessageBox.Show("Login Complete");

			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

			finally
			{
				if (databaseContext !=null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
