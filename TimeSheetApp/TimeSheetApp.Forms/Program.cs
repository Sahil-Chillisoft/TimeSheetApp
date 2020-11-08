using System;
using System.Windows.Forms;
using TimeSheetApp.Forms;
using TimeSheetApp.Helpers.Data;

namespace TimeSheetApp
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
            Application.Run(new DashboardForm(new SqlHelper(), new DateManager()));
        }
    }
}
