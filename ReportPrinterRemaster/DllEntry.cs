using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HNK.Infrustracture;
using HNK.BLL;
using HNK.Infrustracture.Auxiliary;

namespace ReportPrinterRemaster
{
    public class DllEntry
    {
        DbAccessLayer m_db;
        public bool Init = false;
        public void
            InstallComponent()
        {
            try
            {
                StringBuilder buffer = new StringBuilder(20);
                INIFileReader.InitConfig();
                if (!INIFileReader.ready)
                    return;
                string serverName = INIFileReader.GetConfigString("SERVER_DB", "DB_SERVER", string.Empty, buffer, buffer.Capacity);
                string instanceName = INIFileReader.GetConfigString("SERVER_DB", "DB_NAME", string.Empty, buffer, buffer.Capacity);
                string uid = INIFileReader.GetConfigString("SERVER_DB", "UID", string.Empty, buffer, buffer.Capacity);
                string pwd = INIFileReader.GetConfigString("SERVER_DB", "PWD", string.Empty, buffer, buffer.Capacity);
                string connectionString = "server={0}; Initial Catalog={1};User Id={2};Password={3};"
                                                           .FormatWith(serverName, instanceName, uid, pwd);
                AppConfig.ConnectionString = connectionString;
                m_db = new SqlAccess(AppConfig.ConnectionString);
                Init = true;
            }
            catch (Exception ex)
            {
                Init = false;
                throw ex;
            }
        }

        public Form GetEmReportWindowInstance()
        {
            return null;
        }

        public Form GetSecurityPerformanceReportPrintWindowInstance()
        {
            return new WndOutfitInspectionResultList(m_db);
        }

        public Form GetEmResultListWindowInstance()
        {
            return new WndEmResultList(m_db);
        }
    }
}
