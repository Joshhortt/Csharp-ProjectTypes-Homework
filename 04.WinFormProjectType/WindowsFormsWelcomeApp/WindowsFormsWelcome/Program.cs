// HOMEWORK - 04 -  Project Types - WinForms
//Build a WinForms application that has a simple data entry. First and Last name fields.
// Have button say 'Hi' and return a messageBox when button is pressed.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWelcome
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Dashboard());
		}
	}
}
