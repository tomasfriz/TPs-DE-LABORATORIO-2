using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    /// <summary>
    /// CREADO POR TOMÁS AGUSTIN FRIZ
    /// </summary>
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /// <summary>
            /// CREADO POR TOMÁS AGUSTIN FRIZ
            /// </summary>
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCalculadora());
            /// <summary>
            /// CREADO POR TOMÁS AGUSTIN FRIZ
            /// </summary>
        }
    }
}
