using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HNK.Core;
using HNK.BLL;
using System.Windows.Forms;
using ReportPrinterRemaster.Reporting;

namespace ReportPrinterRemaster
{
    public partial class WndReportView : Form
    {
        public string JCLSH { get; set; }
        KerbmassReport m_kerbmassReport;
        OverallSizeReport m_overallSizeReport;
        public WndReportView(KerbmassReport kerbmassReport,
            OverallSizeReport overallSizeRreport)
        {
            InitializeComponent();
            m_kerbmassReport = kerbmassReport;
            m_overallSizeReport = overallSizeRreport;
            if (kerbmassReport == null)
            {
                btnKerbmass.Enabled = false;
                btn_overallSize_Click(null, null);
            }
            else if(overallSizeRreport==null)
            {
                btn_overallSize.Enabled = false;
                btnKerbmass_Click(null, null);
            }
            else
            {
                btn_overallSize_Click(null, null);
            }
        }

        private void btnKerbmass_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = m_kerbmassReport.GetReportInstance();
        }

        private void btn_overallSize_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = m_overallSizeReport.GetReportInstance();
        }

        private void WndReportView_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlAccess sqlAccess = new SqlAccess(AppConfig.ConnectionString);

            RESULT_VEHICLE_INFO vehicleInfo =
                sqlAccess.Select<RESULT_VEHICLE_INFO>($"SELECT*FROM RESULT_VEHICLE_INFO WHERE JCLSH='{JCLSH}'").FirstOrDefault();
            VEHICLE_DISPATCH dispatch =
                sqlAccess.Select<VEHICLE_DISPATCH>($"SELECT*FROM VEHICLE_DISPATCH WHERE JCLSH ='{JCLSH}'").FirstOrDefault();
            OverallSizeReport overallSizeReport = new OverallSizeReport(dispatch, sqlAccess, vehicleInfo);
            WndDataInput wndDataInput = new WndDataInput();
            wndDataInput.ShowDialog();
            if (wndDataInput.DialogResult == DialogResult.Cancel)
            {
                overallSizeReport.MaxLength = wndDataInput.Length;
                overallSizeReport.MaxWidth = wndDataInput.Width;
                overallSizeReport.MaxHeight = wndDataInput.Height;
                overallSizeReport.WagenHeight = wndDataInput.WagenHeigh;
                overallSizeReport.SpecialVehicle = true;
            }
            overallSizeReport.FillRpoert();
            crystalReportViewer1.ReportSource = overallSizeReport.GetReportInstance();
            m_overallSizeReport = overallSizeReport;
        }
    }
}
