using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportPrinterRemaster
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
            DllEntry reportHelper = new DllEntry();
            reportHelper.InstallComponent();
            var form = reportHelper.GetSecurityPerformanceReportPrintWindowInstance();
            Application.Run(form);
        }
    }
}
