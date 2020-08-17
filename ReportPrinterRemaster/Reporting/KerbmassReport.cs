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
    public class KerbmassReport:
        SecurityPerformanceReporting
    {
        RESULT_KERBMASS m_kerbmass;
        LOGIN_VEHICLE_INFO m_loginInfo;
        VEHICLE_DISPATCH m_vehicleDispatch;
        bool print_before_offline;
        public KerbmassReport(VEHICLE_DISPATCH vehicleDispatch,
                              DbAccessLayer dbAccess,
                              RESULT_VEHICLE_INFO vehicleInfo)
            :base(dbAccess,vehicleInfo)
        {
            if (vehicleDispatch != null)
            {
                m_vehicleDispatch = vehicleDispatch;
                print_before_offline = true;
            }
            else { print_before_offline = false; }
            this.m_doc = new ReportDocument();
            m_doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"/rpt/KERBMASS_REPORT.rpt");
            InitDataEntity();
            FillRpoert();
        }

        public override bool InitDataEntity()
        {
            string jclsh = m_vehicleDispatch.JCLSH;
            string vehicleID = m_vehicleDispatch.HPZLDH+m_vehicleDispatch.HPHM;
            try
            {
                m_kerbmass = m_dbAccess.Select<RESULT_KERBMASS>(
                    "SELECT*FROM RESULT_KERBMASS WHERE JCLSH ='{0}'".FormatWith(jclsh)
                    ).FirstOrDefault<RESULT_KERBMASS>();
                m_loginInfo = m_dbAccess.Select<LOGIN_VEHICLE_INFO>(
                    "SELECT*FROM LOGIN_VEHICLE_INFO WHERE VEHICLEID='{0}'".FormatWith(vehicleID)
                    ).FirstOrDefault<LOGIN_VEHICLE_INFO>();
                if (m_kerbmass == null)
                    throw new NullReferenceException();
                return true;
            }
            catch (Exception ex)
            {
                m_kerbmass = null;
                throw ex;
            }
        }

        public override bool FillRpoert()
        {
            try
            {
                if (m_loginInfo != null)
                {
                    Add("STATION_NAME", "宝鸡交安机动车检测有限公司");
                    Add("JCLSH", m_vehicleDispatch.JCLSH);
                    Add("HPHM", m_loginInfo.HPHM);
                    Add("VIN", m_loginInfo.VIN);
                    Add("CLZL", m_loginInfo.CLZL);
                    Add("HPZL", m_loginInfo.HPZL);
                    Add("JYLX", GetJYLX(m_loginInfo.JYLBDH));
                    Add("CPXH", m_loginInfo.PPXH);
                }
                if (m_kerbmass != null)
                {
                    Add("JCSJ", m_kerbmass.KSSJ);
                    Add("STD_ZBZL", m_loginInfo.ZBZL);
                    Add("SC_ZBZL", m_kerbmass.SCZBZL);
                    int sczbzl = m_kerbmass.SCZBZL.SafeParse();
                    int stdzbzl = m_loginInfo.ZBZL.SafeParse();
                    int iCZ = Math.Abs(sczbzl - stdzbzl);
                    string strCZ = "";
                    if (sczbzl > stdzbzl)
                        strCZ = "+" + iCZ;
                    else
                        strCZ = "-" + iCZ;
                    Add("CZ", strCZ);

                    float fSTD_ZBZL = m_loginInfo.ZBZL.SafeParseF();
                    float fCZ_BFB = (float)Math.Round((iCZ / fSTD_ZBZL) * 100, 2);

                    Add("BZXZ", LessThan + m_kerbmass.ZBZLXZSX +"或"+ LessThan + m_kerbmass.ZBZLXZXX);
                    Add("CZ_BFB", fCZ_BFB.ToString() + "%");
                    Add("JYCS", m_kerbmass.ZBZLJCCS);
                    Add("PD", GetPD_Text(m_kerbmass.ZBZL_PD));
                    Add("WGJYY", m_vehicleDispatch.WGJYY);
                    Add("YCY", m_vehicleDispatch.YCY); 
                }
                return true;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                throw ex;
            }
        }

        public override ReportDocument GetReportInstance()
        {
            return m_doc;
        }

    }
}
