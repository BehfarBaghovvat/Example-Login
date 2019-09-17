namespace Example_Login
{
	partial class RegisterForm
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
			this.informationUserGroupBox = new System.Windows.Forms.GroupBox();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernameLable = new Mbb.Windows.Forms.Label();
			this.LoginLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.addUserPictureLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.registerButton = new Mbb.Windows.Forms.Button();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.exitButton = new Mbb.Windows.Forms.Button();
			this.confirmNewPasswordTextBox = new Mbb.Windows.Forms.TextBox();
			this.confirmNewPasswordLable = new Mbb.Windows.Forms.Label();
			this.newPasswordTextBox = new Mbb.Windows.Forms.TextBox();
			this.newPasswordLable = new Mbb.Windows.Forms.Label();
			this.confirmNewEmailTextBox = new Mbb.Windows.Forms.TextBox();
			this.confirmNewEmailLable = new Mbb.Windows.Forms.Label();
			this.newEmailTextBox = new Mbb.Windows.Forms.TextBox();
			this.newEmailLable = new Mbb.Windows.Forms.Label();
			this.lastNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.lastNameLable = new Mbb.Windows.Forms.Label();
			this.userPicPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.firstNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.firstNameLable = new Mbb.Windows.Forms.Label();
			this.informationUserGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPicPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// informationUserGroupBox
			// 
			this.informationUserGroupBox.Controls.Add(this.usernameTextBox);
			this.informationUserGroupBox.Controls.Add(this.usernameLable);
			this.informationUserGroupBox.Controls.Add(this.LoginLinkLabel);
			this.informationUserGroupBox.Controls.Add(this.addUserPictureLinkLabel);
			this.informationUserGroupBox.Controls.Add(this.registerButton);
			this.informationUserGroupBox.Controls.Add(this.resetButton);
			this.informationUserGroupBox.Controls.Add(this.exitButton);
			this.informationUserGroupBox.Controls.Add(this.confirmNewPasswordTextBox);
			this.informationUserGroupBox.Controls.Add(this.confirmNewPasswordLable);
			this.informationUserGroupBox.Controls.Add(this.newPasswordTextBox);
			this.informationUserGroupBox.Controls.Add(this.newPasswordLable);
			this.informationUserGroupBox.Controls.Add(this.confirmNewEmailTextBox);
			this.informationUserGroupBox.Controls.Add(this.confirmNewEmailLable);
			this.informationUserGroupBox.Controls.Add(this.newEmailTextBox);
			this.informationUserGroupBox.Controls.Add(this.newEmailLable);
			this.informationUserGroupBox.Controls.Add(this.lastNameTextBox);
			this.informationUserGroupBox.Controls.Add(this.lastNameLable);
			this.informationUserGroupBox.Controls.Add(this.userPicPicturBox);
			this.informationUserGroupBox.Controls.Add(this.firstNameTextBox);
			this.informationUserGroupBox.Controls.Add(this.firstNameLable);
			this.informationUserGroupBox.Location = new System.Drawing.Point(23, 63);
			this.informationUserGroupBox.Name = "informationUserGroupBox";
			this.informationUserGroupBox.Size = new System.Drawing.Size(488, 344);
			this.informationUserGroupBox.TabIndex = 0;
			this.informationUserGroupBox.TabStop = false;
			this.informationUserGroupBox.Text = "Information User";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.HideSelection = false;
			this.usernameTextBox.Location = new System.Drawing.Point(36, 127);
			this.usernameTextBox.MaxLength = 25;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(252, 20);
			this.usernameTextBox.TabIndex = 5;
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			this.usernameTextBox.Validated += new System.EventHandler(this.UsernameTextBox_Validated);
			// 
			// usernameLable
			// 
			this.usernameLable.AutoSize = true;
			this.usernameLable.Location = new System.Drawing.Point(33, 111);
			this.usernameLable.Name = "usernameLable";
			this.usernameLable.Size = new System.Drawing.Size(55, 13);
			this.usernameLable.TabIndex = 4;
			this.usernameLable.Text = "&Username";
			// 
			// LoginLinkLabel
			// 
			this.LoginLinkLabel.AutoSize = true;
			this.LoginLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.LoginLinkLabel.Location = new System.Drawing.Point(449, 319);
			this.LoginLinkLabel.Name = "LoginLinkLabel";
			this.LoginLinkLabel.Size = new System.Drawing.Size(33, 13);
			this.LoginLinkLabel.TabIndex = 16;
			this.LoginLinkLabel.TabStop = true;
			this.LoginLinkLabel.Text = "&Login";
			this.LoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkLabel_LinkClicked);
			// 
			// addUserPictureLinkLabel
			// 
			this.addUserPictureLinkLabel.AutoSize = true;
			this.addUserPictureLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.addUserPictureLinkLabel.Location = new System.Drawing.Point(342, 220);
			this.addUserPictureLinkLabel.Name = "addUserPictureLinkLabel";
			this.addUserPictureLinkLabel.Size = new System.Drawing.Size(87, 13);
			this.addUserPictureLinkLabel.TabIndex = 14;
			this.addUserPictureLinkLabel.TabStop = true;
			this.addUserPictureLinkLabel.Text = "&Add User Picture";
			this.addUserPictureLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddUserPictureLinkLabel_LinkClicked);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(208, 309);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(80, 23);
			this.registerButton.TabIndex = 15;
			this.registerButton.Text = "&Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(122, 309);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(80, 23);
			this.resetButton.TabIndex = 17;
			this.resetButton.Text = "Re&set";
			this.resetButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(36, 309);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(80, 23);
			this.exitButton.TabIndex = 18;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// confirmNewPasswordTextBox
			// 
			this.confirmNewPasswordTextBox.HideSelection = false;
			this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(36, 283);
			this.confirmNewPasswordTextBox.MaxLength = 40;
			this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
			this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(252, 20);
			this.confirmNewPasswordTextBox.TabIndex = 13;
			this.confirmNewPasswordTextBox.Validated += new System.EventHandler(this.ConfirmNewPasswordTextBox_Validated);
			// 
			// confirmNewPasswordLable
			// 
			this.confirmNewPasswordLable.AutoSize = true;
			this.confirmNewPasswordLable.Location = new System.Drawing.Point(33, 267);
			this.confirmNewPasswordLable.Name = "confirmNewPasswordLable";
			this.confirmNewPasswordLable.Size = new System.Drawing.Size(116, 13);
			this.confirmNewPasswordLable.TabIndex = 12;
			this.confirmNewPasswordLable.Text = "Confirm New &Password";
			// 
			// newPasswordTextBox
			// 
			this.newPasswordTextBox.HideSelection = false;
			this.newPasswordTextBox.Location = new System.Drawing.Point(36, 244);
			this.newPasswordTextBox.MaxLength = 40;
			this.newPasswordTextBox.Name = "newPasswordTextBox";
			this.newPasswordTextBox.Size = new System.Drawing.Size(252, 20);
			this.newPasswordTextBox.TabIndex = 11;
			this.newPasswordTextBox.TextChanged += new System.EventHandler(this.NewPasswordTextBox_TextChanged);
			// 
			// newPasswordLable
			// 
			this.newPasswordLable.AutoSize = true;
			this.newPasswordLable.Location = new System.Drawing.Point(33, 228);
			this.newPasswordLable.Name = "newPasswordLable";
			this.newPasswordLable.Size = new System.Drawing.Size(78, 13);
			this.newPasswordLable.TabIndex = 10;
			this.newPasswordLable.Text = "New &Password";
			// 
			// confirmNewEmailTextBox
			// 
			this.confirmNewEmailTextBox.HideSelection = false;
			this.confirmNewEmailTextBox.Location = new System.Drawing.Point(36, 205);
			this.confirmNewEmailTextBox.MaxLength = 60;
			this.confirmNewEmailTextBox.Name = "confirmNewEmailTextBox";
			this.confirmNewEmailTextBox.Size = new System.Drawing.Size(252, 20);
			this.confirmNewEmailTextBox.TabIndex = 9;
			this.confirmNewEmailTextBox.Validated += new System.EventHandler(this.ConfirmNewEmailTextBox_Validated);
			// 
			// confirmNewEmailLable
			// 
			this.confirmNewEmailLable.AutoSize = true;
			this.confirmNewEmailLable.Location = new System.Drawing.Point(33, 189);
			this.confirmNewEmailLable.Name = "confirmNewEmailLable";
			this.confirmNewEmailLable.Size = new System.Drawing.Size(99, 13);
			this.confirmNewEmailLable.TabIndex = 8;
			this.confirmNewEmailLable.Text = "Confirm New &E-Mail";
			// 
			// newEmailTextBox
			// 
			this.newEmailTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.newEmailTextBox.HideSelection = false;
			this.newEmailTextBox.Location = new System.Drawing.Point(36, 166);
			this.newEmailTextBox.MaxLength = 60;
			this.newEmailTextBox.Name = "newEmailTextBox";
			this.newEmailTextBox.Size = new System.Drawing.Size(252, 20);
			this.newEmailTextBox.TabIndex = 7;
			this.newEmailTextBox.TextChanged += new System.EventHandler(this.NewEmailTextBox_TextChanged);
			this.newEmailTextBox.Validated += new System.EventHandler(this.NewEmailTextBox_Validated);
			// 
			// newEmailLable
			// 
			this.newEmailLable.AutoSize = true;
			this.newEmailLable.Location = new System.Drawing.Point(33, 150);
			this.newEmailLable.Name = "newEmailLable";
			this.newEmailLable.Size = new System.Drawing.Size(60, 13);
			this.newEmailLable.TabIndex = 6;
			this.newEmailLable.Text = "New &E-mail";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(36, 88);
			this.lastNameTextBox.MaxLength = 25;
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(252, 20);
			this.lastNameTextBox.TabIndex = 3;
			this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
			// 
			// lastNameLable
			// 
			this.lastNameLable.AutoSize = true;
			this.lastNameLable.Location = new System.Drawing.Point(33, 72);
			this.lastNameLable.Name = "lastNameLable";
			this.lastNameLable.Size = new System.Drawing.Size(58, 13);
			this.lastNameLable.TabIndex = 2;
			this.lastNameLable.Text = "Las&t Name";
			// 
			// userPicPicturBox
			// 
			this.userPicPicturBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userPicPicturBox.Location = new System.Drawing.Point(310, 33);
			this.userPicPicturBox.Name = "userPicPicturBox";
			this.userPicPicturBox.Size = new System.Drawing.Size(150, 175);
			this.userPicPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userPicPicturBox.TabIndex = 2;
			this.userPicPicturBox.TabStop = false;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(36, 49);
			this.firstNameTextBox.MaxLength = 20;
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(252, 20);
			this.firstNameTextBox.TabIndex = 1;
			this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
			// 
			// firstNameLable
			// 
			this.firstNameLable.AutoSize = true;
			this.firstNameLable.Location = new System.Drawing.Point(33, 33);
			this.firstNameLable.Name = "firstNameLable";
			this.firstNameLable.Size = new System.Drawing.Size(57, 13);
			this.firstNameLable.TabIndex = 0;
			this.firstNameLable.Text = "&First Name";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 419);
			this.Controls.Add(this.informationUserGroupBox);
			this.Name = "RegisterForm";
			this.Text = "Register";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.informationUserGroupBox.ResumeLayout(false);
			this.informationUserGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPicPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox informationUserGroupBox;
		private Mbb.Windows.Forms.Label firstNameLable;
		private Mbb.Windows.Forms.LinkLabel addUserPictureLinkLabel;
		private Mbb.Windows.Forms.Button registerButton;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Button exitButton;
		private Mbb.Windows.Forms.TextBox confirmNewPasswordTextBox;
		private Mbb.Windows.Forms.Label confirmNewPasswordLable;
		private Mbb.Windows.Forms.TextBox newPasswordTextBox;
		private Mbb.Windows.Forms.Label newPasswordLable;
		private Mbb.Windows.Forms.TextBox confirmNewEmailTextBox;
		private Mbb.Windows.Forms.Label confirmNewEmailLable;
		private Mbb.Windows.Forms.TextBox newEmailTextBox;
		private Mbb.Windows.Forms.Label newEmailLable;
		private Mbb.Windows.Forms.TextBox lastNameTextBox;
		private Mbb.Windows.Forms.Label lastNameLable;
		private Mbb.Windows.Forms.PicturBox userPicPicturBox;
		private Mbb.Windows.Forms.TextBox firstNameTextBox;
		private Mbb.Windows.Forms.LinkLabel LoginLinkLabel;
		private Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.Label usernameLable;
	}
}