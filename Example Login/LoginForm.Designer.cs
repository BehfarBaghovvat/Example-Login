namespace Example_Login
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.userDataGridView = new System.Windows.Forms.DataGridView();
			this.UserPicture = new System.Windows.Forms.DataGridViewImageColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginBoxGroupBox = new System.Windows.Forms.GroupBox();
			this.textLabel = new Mbb.Windows.Forms.Label();
			this.signUpLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.loginButton = new Mbb.Windows.Forms.Button();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.exitButton = new Mbb.Windows.Forms.Button();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.passwordLable = new Mbb.Windows.Forms.Label();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernameLable = new Mbb.Windows.Forms.Label();
			this.userPicPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
			this.loginBoxGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPicPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// userDataGridView
			// 
			this.userDataGridView.AllowUserToAddRows = false;
			this.userDataGridView.AllowUserToDeleteRows = false;
			this.userDataGridView.AutoGenerateColumns = false;
			this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.UserPicture,
            this.Email});
			this.userDataGridView.DataSource = this.userBindingSource;
			this.userDataGridView.Location = new System.Drawing.Point(23, 63);
			this.userDataGridView.Name = "userDataGridView";
			this.userDataGridView.ReadOnly = true;
			this.userDataGridView.Size = new System.Drawing.Size(240, 202);
			this.userDataGridView.TabIndex = 0;
			this.userDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellDoubleClick);
			// 
			// UserPicture
			// 
			this.UserPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.UserPicture.DataPropertyName = "UserPicture";
			this.UserPicture.HeaderText = "UserPicture";
			this.UserPicture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.UserPicture.Name = "UserPicture";
			this.UserPicture.ReadOnly = true;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Visible = false;
			this.Email.Width = 150;
			// 
			// loginBoxGroupBox
			// 
			this.loginBoxGroupBox.Controls.Add(this.textLabel);
			this.loginBoxGroupBox.Controls.Add(this.signUpLinkLabel);
			this.loginBoxGroupBox.Controls.Add(this.loginButton);
			this.loginBoxGroupBox.Controls.Add(this.resetButton);
			this.loginBoxGroupBox.Controls.Add(this.exitButton);
			this.loginBoxGroupBox.Controls.Add(this.passwordTextBox);
			this.loginBoxGroupBox.Controls.Add(this.passwordLable);
			this.loginBoxGroupBox.Controls.Add(this.userPicPicturBox);
			this.loginBoxGroupBox.Controls.Add(this.usernameTextBox);
			this.loginBoxGroupBox.Controls.Add(this.usernameLable);
			this.loginBoxGroupBox.Location = new System.Drawing.Point(269, 63);
			this.loginBoxGroupBox.Name = "loginBoxGroupBox";
			this.loginBoxGroupBox.Size = new System.Drawing.Size(473, 202);
			this.loginBoxGroupBox.TabIndex = 1;
			this.loginBoxGroupBox.TabStop = false;
			// 
			// textLabel
			// 
			this.textLabel.AutoSize = true;
			this.textLabel.Location = new System.Drawing.Point(77, 170);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size(122, 13);
			this.textLabel.TabIndex = 10;
			this.textLabel.Text = "Don\'t have an account?";
			// 
			// signUpLinkLabel
			// 
			this.signUpLinkLabel.AutoSize = true;
			this.signUpLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.signUpLinkLabel.Location = new System.Drawing.Point(195, 170);
			this.signUpLinkLabel.Name = "signUpLinkLabel";
			this.signUpLinkLabel.Size = new System.Drawing.Size(45, 13);
			this.signUpLinkLabel.TabIndex = 9;
			this.signUpLinkLabel.TabStop = true;
			this.signUpLinkLabel.Text = "&Sign Up";
			this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabel_LinkClicked);
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(216, 131);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(80, 23);
			this.loginButton.TabIndex = 8;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(130, 131);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(80, 23);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(44, 131);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(80, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "&Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(44, 103);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(252, 22);
			this.passwordTextBox.TabIndex = 5;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// passwordLable
			// 
			this.passwordLable.AutoSize = true;
			this.passwordLable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLable.Location = new System.Drawing.Point(41, 87);
			this.passwordLable.Name = "passwordLable";
			this.passwordLable.Size = new System.Drawing.Size(56, 13);
			this.passwordLable.TabIndex = 4;
			this.passwordLable.Text = "&Password";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.Location = new System.Drawing.Point(44, 64);
			this.usernameTextBox.MaxLength = 50;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(252, 22);
			this.usernameTextBox.TabIndex = 2;
			// 
			// usernameLable
			// 
			this.usernameLable.AutoSize = true;
			this.usernameLable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameLable.Location = new System.Drawing.Point(41, 48);
			this.usernameLable.Name = "usernameLable";
			this.usernameLable.Size = new System.Drawing.Size(58, 13);
			this.usernameLable.TabIndex = 1;
			this.usernameLable.Text = "&Username";
			// 
			// userPicPicturBox
			// 
			this.userPicPicturBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userPicPicturBox.Location = new System.Drawing.Point(334, 19);
			this.userPicPicturBox.Name = "userPicPicturBox";
			this.userPicPicturBox.Size = new System.Drawing.Size(120, 165);
			this.userPicPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userPicPicturBox.TabIndex = 3;
			this.userPicPicturBox.TabStop = false;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
			this.usernameDataGridViewTextBoxColumn.MaxInputLength = 40;
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			this.usernameDataGridViewTextBoxColumn.Width = 80;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Models.User);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 290);
			this.Controls.Add(this.loginBoxGroupBox);
			this.Controls.Add(this.userDataGridView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(760, 290);
			this.MinimumSize = new System.Drawing.Size(760, 290);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
			this.loginBoxGroupBox.ResumeLayout(false);
			this.loginBoxGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPicPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox loginBoxGroupBox;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Mbb.Windows.Forms.Label passwordLable;
		private Mbb.Windows.Forms.PicturBox userPicPicturBox;
		private Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.Label usernameLable;
		private Mbb.Windows.Forms.Label textLabel;
		private Mbb.Windows.Forms.LinkLabel signUpLinkLabel;
		private Mbb.Windows.Forms.Button loginButton;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Button exitButton;
		public System.Windows.Forms.DataGridView userDataGridView;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn UserPicture;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
	}
}