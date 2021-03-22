using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWelcome
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hi" + ' ' + txtFirstName.Text + ' ' + txtLastName.Text + ' ' +

			"Welcome to the Windows World", "Welcome", MessageBoxButtons.OKCancel,

			MessageBoxIcon.Information);
		}
	}
}
