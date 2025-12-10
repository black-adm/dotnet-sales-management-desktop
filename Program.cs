using System;
using System.Windows.Forms;
using SalesManagement.br.com.project.view;

namespace SalesManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCustomers());
        }
    }
}
