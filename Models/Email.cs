using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public static class Email
	{

		private static string[] formatEmail = new string[9];
		private static bool	Status { get; set; }

		private static bool TrueStatus { get; set; }


		public static bool EmailChecker(string email)
		{
			
			formatEmail[0] = "@gmail.com";
			formatEmail[1] = "@Gmail.com";
			formatEmail[2] = "@GMAIL.com";
			formatEmail[3] = "@yahoo.com";
			formatEmail[4] = "@Yahoo.com";
			formatEmail[5] = "@YAHOO.com";
			formatEmail[6] = "@hotmail.com";
			formatEmail[7] = "@Hotmail.com";
			formatEmail[8] = "@HOTMAIL.com";

			for (int i = 0; i < formatEmail.Length; i++)
			{
				Status = email.EndsWith(formatEmail[i]);

				if (Status == true)
				{
					TrueStatus = Status;
				}
			}

			return TrueStatus;
		}
	}
}
