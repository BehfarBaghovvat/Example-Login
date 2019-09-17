using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mbb.Windows.Forms
{
	public static class Appliction
	{

		public static void Exit()
		{
			System.Windows.Forms.DialogResult dialogResult;

			dialogResult = System.Windows.Forms.MessageBox.Show("Do you want to [Exit]...?",
					caption: "Application Exit",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					icon: System.Windows.Forms.MessageBoxIcon.Question);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		
}
}
