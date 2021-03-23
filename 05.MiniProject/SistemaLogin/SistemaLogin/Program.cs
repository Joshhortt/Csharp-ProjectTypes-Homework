// HOMEWORK - 05 - Mini-Project - Encripted Login System
// Build a login system with encription. Use one form to enter password details,
// and another when you are accessed with success.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaLogin
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
            Application.Run(new frmLogin());
        }
    }
}
