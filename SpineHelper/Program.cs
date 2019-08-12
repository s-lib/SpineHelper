using System;
using System.Windows.Forms;

namespace SpineHelper
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

            Settings.InitLanuage();
            if (Settings.AutoUpdates)
            {
                Versioning.CheckForUpdates();
            }

            Application.Run(new MainForm());
        }
    }
}
