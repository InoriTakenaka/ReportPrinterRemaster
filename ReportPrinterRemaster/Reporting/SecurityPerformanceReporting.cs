using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using HNK.Core;
using HNK.Infrustracture;
using HNK.Infrustracture.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportPrinterRemaster.Reporting
{
    public abstract class SecurityPerformanceReporting:
        Report
    {
        public string PASS = "合格";
        public string FAIL = "不合格";
        public string NoData = "未检";        
        public string NoComment = "不判定"; 
        public string MoreThan = "≥";
        public string LessThan = "≤";
        public string NoDataS = "-";
        protected ReportDocument m_doc;
        protected RESULT_VEHICLE_INFO m_vehInfo;
        public SecurityPerformanceReporting(DbAccessLayer dbAccess,
                                            RESULT_VEHICLE_INFO vehicleInfo)
            :base(dbAccess)
        {
            m_vehInfo = vehicleInfo;
        }

        public void Add(string key, string value)
        {
            m_doc.SetParameterValue(key, value);
        }

        public abstract bool InitDataEntity();
        public abstract bool FillRpoert();
        public abstract ReportDocument GetReportInstance();

        public string GetPD_Text(string val)
        {
            if (val == "1")
                return PASS;
            else if (val == "2")
                return FAIL;
            else if (val == "3")
                return NoData;
            else return NoComment;
        }

        public string GetJYLX(string JYLBDH)
        {
            string JYLB = "在用机动车检验（定检）";
            string[] arr = JYLBDH.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case "01":
                        JYLB = "在用机动车检验";
                        break;
                    case "02":
                        JYLB = "注册登记检验";
                        break;
                    case "03":
                        JYLB = "临时检验";
                        break;
                    case "04":
                        JYLB = "特殊检验";
                        break;
                    case "05":
                        JYLB = "在用车检验（非定检）";
                        break;
                }

            }
            return JYLB;
        }
    }
}
