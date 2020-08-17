using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HNK.Infrustracture;
using HNK.Infrustracture.Auxiliary;
using HNK.Core;
namespace ReportPrinterRemaster
{
    public partial class WndOutfitInspectionResultList : Form
    {
        public class JOIN_RESULT:Entity
        {
            //public string JSSJ { get; set; }
            public string JCLSH { get; set; }
            public string AJJCCS { get; set; }
            public string HPHM { get; set; }
            public string VIN { get; set; }
            public string AJLSH { get; set; }
            public string JYXM { get; set; }
            public string YJXM { get; set; }
            //public string ZCWKCC_PD { get; set; }
        }
        DbAccessLayer m_dbAccess;
        const int PAGE_SIZE = 15;
        int m_CurrentPage = 1;
        public WndOutfitInspectionResultList(DbAccessLayer dbAccess)
        {
            m_dbAccess = dbAccess;
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void Search()
        {
            try
            {
                string HPHM = "";
                string condition = "";
                if (HPHM.IsEffective())
                {
                    condition = "AND (HPHM LIKE %{0}%)".FormatWith(HPHM);
                }
                string query = "";
                if (textBox1.Text.Trim().IsNullOrEmprty())
                {
                    query = @"SELECT TOP 100 JCLSH,AJLSH,AJJCCS,HPHM,VIN,JYXM,YJXM
                    FROM VEHICLE_DISPATCH
                    WHERE 
                    (JYXM LIKE '%M1%' OR JYXM LIKE '%W1%' OR JYXM LIKE '%M1,W1%' OR JYXM LIKE '%W1,M1%')
                    AND 
                    (YJXM LIKE '%M1%' OR YJXM LIKE '%W1%')
                    ORDER BY ID DESC";
                }
                else
                {
                    query = @"SELECT JCLSH,AJLSH,AJJCCS,HPHM,VIN,JYXM,YJXM
                    FROM VEHICLE_DISPATCH " +
                    $"WHERE HPHM like '%{textBox1.Text.Trim()}%' AND " +
                    @"(JYXM LIKE '%M1%' OR JYXM LIKE '%W1%' OR JYXM LIKE '%M1,W1%' OR JYXM LIKE '%W1,M1%')
                    AND
                    (YJXM LIKE '%M1%' OR YJXM LIKE '%W1%')
                    ORDER BY ID DESC";
                }
                List<JOIN_RESULT> LstVehs =
                    m_dbAccess.Select<JOIN_RESULT>(query);
                if (LstVehs == null || LstVehs.Count == 0)
                {
                    MessageBox.Show("没有数据");
                    return;
                }
                foreach (var veh in LstVehs)
                {
                    if (veh == null)
                    {
                        //MessageBox.Show("veh is null");
                        continue;
                    }
                    if (veh.JYXM == null)
                    {
                        //MessageBox.Show("jyxm is null");
                        continue;
                    }                    
                    string display1 = "",display2="";
                    if (veh.JYXM.Contains("M1"))
                        display1 += "外廓尺寸,";
                    if (veh.JYXM.Contains("W1"))
                        display1 += "整备质量,";
                    veh.JYXM = display1;
                    if (veh.YJXM == null)
                        continue;
                    if (veh.YJXM.Contains("M1"))
                        display2 += "外廓尺寸,";
                    if(veh.YJXM.Contains("W1"))
                        display2 += "整备质量,";
                    veh.YJXM = display2;

                }
                dataGridView1.DataSource = LstVehs;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "->" + ex.StackTrace);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            m_CurrentPage++;
            Search();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (m_CurrentPage > 1)
            {
                m_CurrentPage -= 1;
                Search();
            }
            else
            {
                MessageBox.Show("没有上一页了");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            JOIN_RESULT vehicleEntity = dataGridView1.CurrentRow.DataBoundItem as JOIN_RESULT;
            VEHICLE_DISPATCH vehicleDispatch = m_dbAccess.Select<VEHICLE_DISPATCH>(
                $"SELECT * FROM VEHICLE_DISPATCH WHERE JCLSH='{vehicleEntity.JCLSH}'").FirstOrDefault();
            if (vehicleDispatch == null) MessageBox.Show("调度表记录已经被清除");
            try
            {
                Reporting.OverallSizeReport overallSizeReport=null;
                Reporting.KerbmassReport kerbmassReport=null;
                if(vehicleDispatch.JYXM.Contains("M1"))
                     overallSizeReport = new Reporting.OverallSizeReport(vehicleDispatch, m_dbAccess, null);
                if(vehicleDispatch.JYXM.Contains("W1"))
                     kerbmassReport = new Reporting.KerbmassReport(vehicleDispatch, m_dbAccess, null);
               
                WndReportView wndReport = new WndReportView(kerbmassReport,overallSizeReport);
                wndReport.JCLSH = vehicleEntity.JCLSH;
                wndReport.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("车辆尚未完成检测或照片缺失");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Write(ex.StackTrace);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IsNullOrEmprty()) return;
            List<RESULT_VEHICLE_INFO> LstVehs = m_dbAccess.Select<RESULT_VEHICLE_INFO>(
                $"SELECT JCLSH, AJLSH, DLRQ, HPHM,HPZLDH, VIN, JYXM, AJJCCS "+
                $"FROM RESULT_VEHICLE_INFO WHERE HPHM LIKE '%{textBox1.Text.Trim()}%' ORDER BY ID DESC");
            if (LstVehs == null || LstVehs.Count == 0)
            {
                MessageBox.Show("没有数据");
                return;
            }
            foreach (var veh in LstVehs)
            {
                string display = "";
                if (veh.JYXM.Contains("M1"))
                    display += "外廓尺寸,";
                if (veh.JYXM.Contains("W1"))
                    display += "整备质量,";
                veh.JYXM = display;
            }
            dataGridView1.DataSource = LstVehs;
        }
    }
}
