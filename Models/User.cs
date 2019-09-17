namespace Models
{
	public class User : BaseEntity
	{

		public User() : base()
		{
		}

		#region FirstName

		//--Lenght FirstName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string FirstName { get; set; }
		#endregion /FirstName

		//******

		#region LastName

		//--Length LastName
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		public string LastName { get; set; }
		#endregion /LastName

		//******

		#region Username

		//--Uniq Username
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		//--Empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string Username { get; set; }
		#endregion /Username

		//******

		#region Email
		//--Uniq Email
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		//--Lenght Email
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 60)]

		public string Email { get; set; }
		#endregion /Email

		//******

		#region Password

		//--Empty Password
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Password
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40)]
		public string Password { get; set; }
		#endregion /Password

		//******

		#region UserPicture
		public byte[] UserPicture { get; set; }
		#endregion /UserPicture
	}
}
