using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace TranslateUtility
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
            Application.Run(new frmLauncher());
        }
    }
}
