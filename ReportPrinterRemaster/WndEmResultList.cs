using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HNK.Infrustracture;
using HNK.Infrustracture.Defines;
using HNK.Infrustracture.Auxiliary;
using HNK.Core;
namespace ReportPrinterRemaster
{
    public partial class WndEmResultList : Form
    {
        class RowData
        {
            public string jclsh;
            public string hphm;
            public string vin;
            public string startTime;
            public string endTime;
            public string status;
            public string method;
            public string result;
        }
        private DbAccessLayer m_dbAccess;
        private ListEnhancer<RowData> m_displayData;
        public WndEmResultList(DbAccessLayer dbAccess)
        {
            InitializeComponent();
            m_dbAccess = dbAccess;
            this.WindowState = FormWindowState.Maximized;
            this.m_dgv.AutoGenerateColumns = false;
            this.m_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.m_dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.m_dgv.RowsDefaultCellStyle.Font = new Font("宋体", 16, FontStyle.Regular);     
            Fill();
        }

        private void Fill()
        {
            List<VEHICLE_DISPATCH> lstResult = m_dbAccess.Select<VEHICLE_DISPATCH>("SELECT*FROM VEHICLE_DISPATCH WHERE CHARINDEX('X',JYXM)<>'0' AND JCLSH LIKE 'T%' ");
            List<RowData> displayData = new List<RowData>();
            foreach (var item in lstResult)
            {
                RowData row = new RowData();
                row.jclsh = item.JCLSH;
                row.hphm = item.HPHM;
                row.vin = item.VIN;
                row.startTime = item.CLSXSJ;
                row.endTime = item.CLXXSJ;
                switch (item.JYXM)
                {
                    case "X1":
                        {
                            row.method = ISPMSD.X1;
                            if (item.JCZT_STATUS == 0)
                                row.status = "未上线";
                            else if (item.JCZT_STATUS == 4)
                            {
                                row.status = "已下线";
                                RESULT_SDS sds = m_dbAccess.Select<RESULT_SDS>("SELECT*FROM RESULT_SDS WHERE JCLSH ='{0}'"
                                    .FormatWith(item.JCLSH)).FirstOrDefault<RESULT_SDS>();
                                if (sds != null)
                                    row.result = GetPD(sds.SDS_PD);
                            }
                            else row.status = "在检";
                            break;
                        }
                    case "X2":
                        {
                            row.method = ISPMSD.X2;
                            if (item.JCZT_STATUS == 0)
                                row.status = "未上线";
                            else if (item.JCZT_STATUS == 4)
                            {
                                row.status = "已下线";
                                RESULT_ASM asm = m_dbAccess.Select<RESULT_ASM>("SELECT*FROM RESULT_ASM WHERE JCLSH ='{0}'"
                                    .FormatWith(item.JCLSH)).FirstOrDefault<RESULT_ASM>();
                                if (asm != null)
                                    row.result = GetPD(asm.ASM_PD);
                            }
                            else row.status = "在检";
                            break;
                        }
                    case "X3":
                        {
                            row.method = ISPMSD.X3;
                            if (item.JCZT_STATUS == 0)
                                row.status = "未上线";
                            else if (item.JCZT_STATUS == 4)
                            {
                                row.status = "已下线";
                                RESULT_VMAS vmas = m_dbAccess.Select<RESULT_VMAS>("SELECT*FROM RESULT_VMAS WHERE JCLSH ='{0}'"
                                    .FormatWith(item.JCLSH)).FirstOrDefault<RESULT_VMAS>();
                                if (vmas != null)
                                    row.result = GetPD(vmas.VMAS_PD);
                            }
                            break;
                        }
                    case "X4":
                        {
                            row.method = ISPMSD.X4;
                            if (item.JCZT_STATUS == 0)
                                row.status = "未上线";
                            else if (item.JCZT_STATUS == 4)
                            {
                                row.status = "已下线";
                                RESULT_ZYJS zyjs = m_dbAccess.Select<RESULT_ZYJS>("SELECT*FROM RESULT_ZYJS WHERE JCLSH ='{0}'"
                                    .FormatWith(item.JCLSH)).FirstOrDefault<RESULT_ZYJS>();
                                if (zyjs != null)
                                    row.result = GetPD(zyjs.ZYJS_PD);
                            }
                            break;
                        }
                    case "X5":
                        {
                            row.method = ISPMSD.X5;
                            if (item.JCZT_STATUS == 0)
                                row.status = "未上线";
                            else if (item.JCZT_STATUS == 4)
                            {
                                row.status = "已下线";
                                RESULT_LD ld = m_dbAccess.Select<RESULT_LD>("SELECT*FROM RESULT_LD WHERE JCLSH ='{0}'"
                                    .FormatWith(item.JCLSH)).FirstOrDefault<RESULT_LD>();
                                if (ld != null)
                                    row.result = GetPD(ld.LD_PD);
                            }
                            break;
                        }
                    case "X6":
                        {
                            row.method = ISPMSD.X6;
                            if (item.JCZT_STATUS == 0)
                                row.status = "未上线";
                            else if (item.JCZT_STATUS == 4)
                            {
                                row.status = "已下线";
                                RESULT_ZYJS zyjs = m_dbAccess.Select<RESULT_ZYJS>("SELECT*FROM RESULT_ZYJS WHERE JCLSH ='{0}'"
                                    .FormatWith(item.JCLSH)).FirstOrDefault<RESULT_ZYJS>();
                                if (zyjs != null)
                                    row.result = GetPD(zyjs.ZYJS_PD);
                            }
                            break;
                        }
                }
                displayData.Add(row);
            }

            this.m_displayData = new ListEnhancer<RowData>(displayData, 10);
            this.m_dgv.DataSource = m_displayData.First();
            Rectangle clientArea = Screen.GetBounds(this);
            m_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            m_dgv.ColumnHeadersHeight = clientArea.Height / 11;
            m_dgv.RowTemplate.Height = clientArea.Height / 11;
            m_dgv.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            m_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;   
        }

        private string GetPD(string src)
        {
            if (src == "0")
                return "未检";
            else if (src == "1")
                return "合格";
            else if (src == "2")
                return "不合格";
            else return "N/A";
        }
    }
}
