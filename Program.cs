using System;
using System.Windows.Forms;

namespace Pocitani
{
    static class Program // Changed to static
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() // Removed args, added [STAThread]
        {
            // Standard WinForms initialization
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Launch Form1
        }

        // Removed ZiskatCislo() and all console calculation logic
    }
}

