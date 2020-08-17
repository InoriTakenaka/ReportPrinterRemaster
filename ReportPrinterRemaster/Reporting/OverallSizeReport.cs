using CrystalDecisions.CrystalReports.Engine;
using HNK.Core;
using HNK.Infrustracture;
using HNK.Infrustracture.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;

namespace ReportPrinterRemaster.Reporting
{
    public class OverallSizeReport:
        SecurityPerformanceReporting
    {
        RESULT_OVERALLSIZE m_overallSize;
        RESULT_KERBMASS m_kerbmass;
        RESULT_IMAGE m_image;
        LOGIN_VEHICLE_INFO m_loginInfo;
        VEHICLE_DISPATCH m_vehicleDispatch;
        readonly string[] m_DSHC = { "H51", "H52", "H53", "H54", "H55", "H5B", "H5C"};
        readonly string[] m_BGQY = { "Q11", "Q21", "Q31" };
        readonly string[] m_PTHC = { "H11", "H21", "H31", "H41" };

        public bool SpecialVehicle { get; set; }
        public string MaxLength { get; set; }
        public string MaxWidth { get; set; }
        public string MaxHeight { get; set; }
        public string WagenHeight { get; set; }

        struct OverallSizeMaxVal
        {
           public int height;
           public int width;
           public int length;
           public int wagenHeight;
        }
        bool print_before_offline;
        public OverallSizeReport(VEHICLE_DISPATCH vehicleDispatch,
                                 DbAccessLayer dbAccess,
                                 RESULT_VEHICLE_INFO vehicleInfo)
            : base(dbAccess, vehicleInfo)
        {
            if (vehicleDispatch != null)
            {
                m_vehicleDispatch = vehicleDispatch;
                print_before_offline = true;
            }
            else { print_before_offline = false; }
            this.m_doc = new ReportDocument();
            m_doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"/rpt/OVERALLSIZE_REPORT.rpt");
            InitDataEntity();
            FillRpoert();
        }

        public override bool InitDataEntity()
        {
            string jclsh = m_vehicleDispatch.JCLSH;
            string vehicleID = m_vehicleDispatch.HPZLDH+m_vehicleDispatch.HPHM;
            try
            {
                m_loginInfo = m_dbAccess.Select<LOGIN_VEHICLE_INFO>(
                  $"SELECT*FROM LOGIN_VEHICLE_INFO WHERE VEHICLEID='{vehicleID}'"
                  ).FirstOrDefault();
                if (m_loginInfo == null)
                    m_loginInfo = m_dbAccess.Select<LOGIN_VEHICLE_INFO>(
                        $"SELECT * FROM LOGIN_VEHICLE_INFO WHERE HPHM='{m_vehicleDispatch.HPHM}'").FirstOrDefault();
                m_overallSize = m_dbAccess.Select<RESULT_OVERALLSIZE>(
                  $"SELECT*FROM RESULT_OVERALLSIZE WHERE JCLSH='{jclsh}'"
                  ).FirstOrDefault();
                m_kerbmass = m_dbAccess.Select<RESULT_KERBMASS>(
                  $"SELECT*FROM RESULT_KERBMASS WHERE JCLSH ='{jclsh}'"
                  ).FirstOrDefault();
                m_image = m_dbAccess.Select<RESULT_IMAGE>(
                  $"SELECT*FROM RESULT_IMAGE WHERE JCLSH='{jclsh}'"
                  ).FirstOrDefault();
                if (m_overallSize == null)
                    throw new NullReferenceException();
                return true;
            }
            catch (Exception ex)
            {
                m_overallSize = null;
                throw ex;
            }
        }

        public override bool FillRpoert()
        {
            try
            {
                ds.DsZJ_WKCC ds = new ds.DsZJ_WKCC();
                ds = (ds.DsZJ_WKCC)BindReportResource_WKCC(ds);
                m_doc.SetDataSource(ds);
                return true;
            }
            catch (Exception ex)
            {
                m_doc = null;
                throw ex;
            }
        }

        public override ReportDocument GetReportInstance()
        {
            return m_doc;
        }

        #region 绑定安检外廓尺寸报告单(宝鸡)

        public DataTable GetDataTableWK_Base(DataTable dataTable)
        {
            DataRow dr = dataTable.NewRow();
            //dr = SetDataTableDefaultValue(ref dataTable, NoDataS);
            dr["HPHM"] = m_loginInfo.HPHM.ValidateAssign(NoDataS);
            dr["VIN"] = m_loginInfo.VIN.ValidateAssign(NoDataS);
            dr["HPZL"] = m_loginInfo.HPZL.ValidateAssign(NoDataS);
            dr["JCZMC"] = "宝鸡市交安机动车检测有限公司";
            dr["CLZL"] = m_loginInfo.CLZL.ValidateAssign(NoDataS);
            dr["FDJH"] = m_loginInfo.FDJH.ValidateAssign(NoDataS);
            dr["PPXH"] = m_loginInfo.PPXH.ValidateAssign(NoDataS);
            dataTable.Rows.Add(dr);
            return dataTable;
        }

        /// <summary>
        /// 获取外廓尺寸最大数值
        /// </summary>
        /// <param name="ggsz">公告数值</param>
        /// <param name="xz">限值</param>
        private OverallSizeMaxVal GenerateWKCCXZ()
        {
            OverallSizeMaxVal maxVal=new OverallSizeMaxVal();
            string clzldh = m_loginInfo.CLZLDH,
                   clzl = m_loginInfo.CLZL,
                   hpzl = m_loginInfo.HPZLDH;
            int axisNumber = m_loginInfo.ZZS.SafeParse(),
                maxWeight = m_loginInfo.ZZL.SafeParse();
            if (SpecialVehicle)
            {
                maxVal.length = MaxLength.SafeParse();
                maxVal.height = MaxHeight.SafeParse();
                maxVal.width =  MaxWidth.SafeParse();
                maxVal.wagenHeight = WagenHeight.SafeParse();
                return maxVal;
            }
            //所有货车
            if (m_DSHC.Contains(clzldh))
            {
                maxVal.length = 6000;
                maxVal.width = 2000;
                maxVal.height = 2500;
            }
            else           
            if (m_BGQY.Contains(clzldh)||clzldh.First()=='H' )
            {
                if (axisNumber == 2)
                {
                    if (maxWeight <= 3500)
                    {
                        maxVal.length = 6000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                    else if (maxWeight > 3500 && maxWeight <= 8000)
                    {
                        maxVal.length = 7000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                    else if (maxWeight > 8000 && maxWeight <= 12000)
                    {
                        maxVal.length = 8000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                    else if (maxWeight > 12000)
                    {
                        maxVal.length = 9000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                }else if (axisNumber == 3)
                {
                    if (maxWeight <= 20000)
                    {
                        maxVal.length = 11000;
                        maxVal.width = 2500;
                        maxVal.height = 4000;
                    }else if (maxWeight > 20000)
                    {
                        maxVal.length = 12000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                }else if(axisNumber == 4)
                {
                    maxVal.length = 12000;
                    maxVal.width = 2550;
                    maxVal.height = 4000;
                }
            }

            //所有客车
            if (clzldh.First() == 'K')
            {
                if (clzldh == "K14" || clzldh == "K24")
                {
                    maxVal.length = 18000;
                    maxVal.width = 2550;
                    maxVal.height = 4000;
                }else if (axisNumber == 2)
                {
                    maxVal.length = 12000;
                    maxVal.width = 2550;
                    maxVal.height = 4000;
                }else if(axisNumber == 3)
                {
                    maxVal.length = 13700;
                    maxVal.width = 2550;
                    maxVal.height = 4000;
                }                
            }

            //所有挂车
            if (hpzl == "15")
            {
                if (clzldh.First() == 'B')
                {
                    if (axisNumber == 3)
                    {
                        maxVal.length = 13000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                    else if (axisNumber == 2)
                    {
                        maxVal.length = 10000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                    else if (axisNumber == 1)
                    {
                        maxVal.length = 8600;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                }
                else if (clzldh.First() == 'G')
                {
                    if (maxWeight <= 100000)
                    {
                        maxVal.length = 7000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                    else if (maxWeight > 100000)
                    {
                        maxVal.length = 8000;
                        maxVal.width = 2550;
                        maxVal.height = 4000;
                    }
                }
            }

            List<CONST_DEFINE> TableConstDefine = m_dbAccess.Select<CONST_DEFINE>($"SELECT*FROM CONST_DEFINE WHERE CON_CHNAME='CLZL'");
            //自卸货车
            List<CONST_DEFINE> vehicleTypeB = (from val in TableConstDefine
                                               where val.CON_CODE.IsEffective() 
                                                     && val.CON_CODE[0] == 'H' 
                                                     && val.CON_CON.Contains("自卸")
                                               select val).ToList();
            //挂车与二轴货车
            if (m_loginInfo.CLZLDH[0] == 'G'
                || (m_loginInfo.CLZLDH[0] == 'H' && m_loginInfo.ZZS.SafeParse() == 2 
                && !vehicleTypeB.Exists(t => t.CON_CODE == m_loginInfo.CLZLDH)))
            {
                maxVal.wagenHeight = 600;
            }
            else if (m_loginInfo.ZZS.SafeParse() >= 2)
            {
                if (vehicleTypeB.Exists(t => t.CON_CODE == m_loginInfo.CLZLDH) && m_loginInfo.ZZS.SafeParse() == 2)
                {//二轴自卸车
                    maxVal.wagenHeight = 800;
                }
                else if ((m_loginInfo.ZZS.SafeParse() == 2 && vehicleTypeB.Exists(t => t.CON_CODE == m_loginInfo.CLZLDH)) ||
                    (m_loginInfo.ZZS.SafeParse() >= 3 && !vehicleTypeB.Exists(t => t.CON_CODE == m_loginInfo.CLZLDH)))
                {
                    maxVal.wagenHeight = 800;
                }
                else if (vehicleTypeB.Exists(t => t.CON_CODE == m_loginInfo.CLZLDH) && m_loginInfo.ZZS.SafeParse() >= 3)
                {
                    maxVal.wagenHeight = 1500;
                }
            }

            return maxVal;
        }

        public DataTable GetDataTableWK_SJ(DataTable dataTable)
        {
            DataRow dr = dataTable.NewRow();
            dr["JCLSH"] = m_vehicleDispatch.AJLSH;
            dr["JCCS"] = m_overallSize.WKCCJCCS;
           dr["JYY"] = m_vehicleDispatch.WGJYY;
            //dr["ZZJ"] = m_loginInfo.YCY;
            dr["CLXXSJ"] = Convert.ToDateTime(m_overallSize.KSSJ).ToString("yyyy-MM-dd") + "/"
                + (m_overallSize.KSSJ).SafeConvertDateTime().ToString("HH:mm:ss")
                + "-" + (m_overallSize.JSSJ).SafeConvertDateTime().ToString("HH:mm:ss");
            DateTime productDate = m_loginInfo.CCRQ.SafeConvertDateTime();
            DateTime time1 = "2017-01-01".SafeConvertDateTime();

            bool enable_GB1589 = DateTime.Compare(productDate, time1) > 0;

            int stdLength = 0, mLength = 0, eLength = 0;// 标准长/测量长/长度误差
            int stdWidth = 0, mWidth = 0, eWidth = 0;// 标准宽/测量宽/宽度误差
            int stdHeight = 0, mHeight = 0, eHeight = 0;//标准高/测量高/高度误差

            OverallSizeMaxVal maxVal = GenerateWKCCXZ();

            //整车长
            dr["ZCC"] = m_loginInfo.CSC;
            dr["ZCCCLZ"] = m_overallSize.ZCSCWKCCCD;
            if (!string.IsNullOrEmpty(m_overallSize.ZCSCWKCCKDCZ))
            {
                dr["ZCCCZ"] = m_overallSize.ZCSCWKCCCDCZ;
                dr["ZCCBFB"] = GetXDWC(m_loginInfo.CSC, m_overallSize.ZCSCWKCCCDCZ);
                dr["ZCCXZ"] = LessThan+maxVal.length+"mm且"+LessThan + m_overallSize.ZCWKCCXZ;//IsNewVehicle ? LessThan + m_overallSize.ZCWKCCXZ : m_overallSize.ZCWKCCXZ;
                dr["ZCC_PD"] = GetWKCC_PD(m_overallSize.ZCWKCCXZ, m_overallSize.ZCSCWKCCCDCZ, dr["ZCCBFB"].ToString());
            }
            else
            {
                int.TryParse(m_loginInfo.CSC, out stdLength);
                int.TryParse(m_overallSize.ZCSCWKCCCD, out mLength);
                eLength = Math.Abs(stdLength - mLength);
                string sELenth = stdLength > mLength ? "-" + eLength.ToString() : eLength.ToString();
                string zccxz = LessThan + m_overallSize.ZCWKCCXZ;
                if (enable_GB1589)
                {
                    if (SpecialVehicle)
                        zccxz += "且" + LessThan + MaxLength + "mm";
                    else
                        zccxz += "且" + LessThan + maxVal.length + "mm";
                }
                dr["ZCCCZ"] = sELenth;
                dr["ZCCBFB"] = GetXDWC(m_loginInfo.CSC, eLength.ToString());
                dr["ZCCXZ"] = zccxz;
                dr["ZCC_PD"] = GetWKCC_PD(m_overallSize.ZCWKCCXZ, eLength.ToString(), dr["ZCCBFB"].ToString());
            }
            //整车宽
            dr["ZCK"] = m_loginInfo.CSK;
            dr["ZCKCLZ"] = m_overallSize.ZCSCWKCCKD;
            if (!string.IsNullOrEmpty(m_overallSize.ZCSCWKCCKDCZ))
            {
                dr["ZCKCZ"] = m_overallSize.ZCSCWKCCKDCZ;
                dr["ZCKBFB"] = GetXDWC(m_loginInfo.CSK, m_overallSize.ZCSCWKCCKDCZ);
                dr["ZCKXZ"] = LessThan + maxVal.width + "mm且" + LessThan + m_overallSize.ZCWKCCXZ; //IsNewVehicle ? LessThan + m_overallSize.ZCWKCCXZ : m_overallSize.ZCWKCCXZ;
                dr["ZCK_PD"] = GetWKCC_PD(m_overallSize.ZCWKCCXZ, m_overallSize.ZCSCWKCCKDCZ, dr["ZCKBFB"].ToString());
            }
            else
            {
                int.TryParse(m_loginInfo.CSK, out stdWidth);
                int.TryParse(m_overallSize.ZCSCWKCCKD, out mWidth);
                eWidth = Math.Abs(stdWidth - mWidth);
                string sEWidth = stdWidth > mWidth ? "-" + eWidth.ToString() : eWidth.ToString();
                string zckxz = LessThan + m_overallSize.ZCWKCCXZ;
                if (enable_GB1589)
                {
                    if (SpecialVehicle)
                        zckxz += "且" + LessThan + MaxWidth + "mm";
                    else
                        zckxz += "且" + LessThan + maxVal.width + "mm";
                }
                dr["ZCKCZ"] = sEWidth;
                dr["ZCKBFB"] = GetXDWC(m_loginInfo.CSK, eWidth.ToString());
                dr["ZCKXZ"] = zckxz;
                dr["ZCK_PD"] = GetWKCC_PD(m_overallSize.ZCWKCCXZ, eWidth.ToString(), dr["ZCKBFB"].ToString());
            }
            //整车高
            dr["ZCG"] = m_loginInfo.CSG;
            dr["ZCGCLZ"] = m_overallSize.ZCSCWKCCGD;
            if (!string.IsNullOrEmpty(m_overallSize.ZCSCWKCCGDCZ))
            {
                dr["ZCGCZ"] = m_overallSize.ZCSCWKCCGDCZ;
                dr["ZCGBFB"] = GetXDWC(m_loginInfo.CSG, m_overallSize.ZCSCWKCCGDCZ);
                dr["ZCGXZ"] = LessThan + maxVal.height + "mm且" + LessThan + m_overallSize.ZCWKCCXZ;//IsNewVehicle ? LessThan + m_overallSize.ZCWKCCXZ : m_overallSize.ZCWKCCXZ;
                dr["ZCG_PD"] = GetWKCC_PD(m_overallSize.ZCWKCCXZ, m_overallSize.ZCSCWKCCGDCZ, dr["ZCGBFB"].ToString());
            }
            else
            {
                int.TryParse(m_loginInfo.CSG, out stdHeight);
                int.TryParse(m_overallSize.ZCSCWKCCGD, out mHeight);
                eHeight = Math.Abs(stdHeight - mHeight);
                string EHeight = stdHeight > mHeight ? "-" + eHeight.ToString() : eHeight.ToString();
                string zcgxz = LessThan + m_overallSize.ZCWKCCXZ;
                if (enable_GB1589)
                {
                    if (SpecialVehicle)
                    {
                        zcgxz += "且" + LessThan + MaxHeight + "mm";
                    }else
                        zcgxz += "且" + LessThan + maxVal.height + "mm";
                }
                dr["ZCGCZ"] = EHeight;
                dr["ZCGBFB"] = GetXDWC(m_loginInfo.CSG, eHeight.ToString());
                dr["ZCGXZ"] = zcgxz;
                dr["ZCG_PD"] = GetWKCC_PD(m_overallSize.ZCWKCCXZ, eHeight.ToString(), dr["ZCGBFB"].ToString());
            }

            //车厢篮板高度


            //整备质量
            dr["ZBZL"] = m_loginInfo.ZBZL;
            if (m_kerbmass != null)
            {
                dr["ZBZLCLZ"] = m_kerbmass.SCZBZL;

                if (double.TryParse(m_kerbmass.SCZBZL, out double dSCZBZL) && double.TryParse(m_loginInfo.ZBZL, out double dZBZL))
                    dr["ZBZLCZ"] = dSCZBZL - dZBZL;
                else
                    dr["ZBZLCZ"] = "";

                dr["ZBZLBFB"] = GetXDWC(m_loginInfo.ZBZL, dr["ZBZLCZ"].ToString());

                if (!string.IsNullOrEmpty(m_kerbmass.ZBZLXZXX) && !string.IsNullOrEmpty(m_kerbmass.ZBZLXZSX))
                    dr["ZBZLXZ"] = string.Format("{0}或{1}", m_kerbmass.ZBZLXZXX, m_kerbmass.ZBZLXZSX);
                else
                    dr["ZBZLXZ"] = NoDataS;

                dr["ZBZL_PD"] = NoDataS;
                if (int.TryParse(m_kerbmass.ZBZL_PD, out int dZBZL_PD))
                {
                    if (dZBZL_PD == 1)
                        dr["ZBZL_PD"] = PASS;
                    else if (dZBZL_PD == 2)
                        dr["ZBZL_PD"] = FAIL;
                }
            }
            else
            {
                dr["ZBZLCLZ"]=NoDataS;
                dr["ZBZLCZ"] = NoDataS;
                dr["ZBZLBFB"] = NoDataS;
                dr["ZBZLXZ"] = NoDataS;
                dr["ZBZL_PD"] = NoDataS;
            }


            //外廓尺寸照片
            dr["WKCC_IMAGE1"] = m_image.WKCC_IMAGE1;
            dr["WKCC_IMAGE2"] = m_image.WKCC_IMAGE2;
            dr["WKCC_IMAGE3"] = m_image.WKCC_IMAGE3;
            dr["WKCC_IMAGE4"] = m_image.WKCC_IMAGE4;

            //拦板高度
            if (m_loginInfo.ZCLBGD.IsEffective())
            {
                string eMaxWagenHeight = "";
                if (m_loginInfo.JYLBDH.Contains("02"))
                    eMaxWagenHeight = LessThan + "±50mm或±1%";
                else
                    eMaxWagenHeight = LessThan + "±50mm或±2%";
                dr["LBGD"] = GetDefaultValue(m_loginInfo.ZCLBGD);
                dr["LBGDCLZ"] = GetDefaultValue(m_overallSize.SCLBGD);
                dr["LBGDCZ"] = GetDefaultValue(m_overallSize.LBGDJDWC);
                dr["LBGDBFB"] = GetDefaultValue(m_overallSize.LBGDXDWC);
                string lbgdxz = eMaxWagenHeight;
                if (enable_GB1589)
                    lbgdxz += "且" + LessThan + maxVal.wagenHeight + "mm";
                dr["LBGDXZ"] = lbgdxz;
                if (m_loginInfo.ZCLBGD.IsEffective())
                {
                    dr["LBGD_PD"] = GetPD_Text(m_overallSize.LBGD_PD);
                }
                else
                {
                    dr["LBGD_PD"] = NoDataS;
                }
            }
            else
            {
                 dr["LBGD"] = NoDataS;
                 dr["LBGDCLZ"]=NoDataS;
                 dr["LBGDCZ"] =NoDataS;
                 dr["LBGDBFB"]=NoDataS;
                 dr["LBGDXZ"] =NoDataS;
                 dr["LBGD_PD"] = NoDataS;
            }
            //总轴距
            dr["ZZJ"] = m_vehicleDispatch.YCY;
            dr["ZZJCLZ"] = NoDataS;
            dr["ZZJCZ"] = NoDataS;
            dr["ZZJBFB"] = NoDataS;
            dr["ZZJXZ"] = NoDataS;
            dr["ZZJ_PD"] = NoDataS;

            //货箱长宽高
            dr["HXNBCD"] = NoDataS;
            dr["HXNBKD"] = NoDataS;
            dr["HXNBGD"] = NoDataS;

            //结果判定
            if (dr["ZBZL_PD"].ToString() == FAIL || dr["ZCC_PD"].ToString() == FAIL || dr["ZCK_PD"].ToString() == FAIL || dr["ZCG_PD"].ToString() == FAIL)
            {
                dr["JCJG_PD"] = FAIL;
            }
            else if (dr["ZBZL_PD"].ToString() == PASS || dr["ZCC_PD"].ToString() == PASS || dr["ZCK_PD"].ToString() == PASS || dr["ZCG_PD"].ToString() == PASS)
            {
                dr["JCJG_PD"] = PASS;
            }
            else
            {
                dr["JCJG_PD"] = NoDataS;
            }
            dr["ZBZLBFB"] = GetJYLX(m_loginInfo.JYLBDH);
            dataTable.Rows.Add(dr);
            return dataTable;
        }

        private string GetDefaultValue(string s)
        {
            if (string.IsNullOrEmpty(m_loginInfo.ZCLBGD))
            {
                return "-";
            }
            if (string.IsNullOrEmpty(s))
                return NoDataS;
            return s;
        }

        public DataSet BindReportResource_WKCC(DataSet ds)
        {
            DataTable dtBase = GetDataTableWK_Base(ds.Tables["DtBase"]);
            DataTable dtWK_SJ = GetDataTableWK_SJ(ds.Tables["DtWKCC"]);
            return ds;
        }

        /// <summary>
        /// 获得相对误差
        /// </summary>
        /// <param name="strCZ">差值</param>
        /// <param name="strBZZ">标准值</param>
        /// <returns></returns>
        private string GetXDWC(string strBZZ, string strCZ)
        {
            string strResult = NoDataS;
            double dCZ, dBZZ;
            if (double.TryParse(strCZ, out dCZ) && double.TryParse(strBZZ, out dBZZ))
                strResult = Math.Round(dCZ * 100 / dBZZ, 2).ToString();
            return strResult;
        }

        /// <summary>
        /// 获取判定
        /// </summary>
        /// <param name="strXZ">限值</param>
        /// <param name="strCZ">差值</param>
        /// <param name="strXDWC">相对误差</param>
        /// <returns></returns>
        private string GetWKCC_PD(string strXZ, string strCZ, string strXDWC)
        {
            string strPD = NoDataS;
            double dJDWCXZ, dXDWCXZ, dCZ, dXDWC;
            if (strXZ != null && strXZ != string.Empty && strXZ.Contains("或"))
            {
                MatchCollection mc = Regex.Matches(strXZ, @"\d+\.?\d*");
                if (mc.Count == 2)
                {
                    if (double.TryParse(mc[0].Value.ToString(), out dJDWCXZ) && double.TryParse(mc[1].Value.ToString(), out dXDWCXZ) && double.TryParse(strCZ, out dCZ)
                        && double.TryParse(strXDWC, out dXDWC))
                    {
                        if (Math.Abs(dCZ) <= dJDWCXZ || dXDWC <= dXDWCXZ)
                            strPD = PASS;
                        else
                            strPD = FAIL;
                    }
                }

            }
            return strPD;
        }

        #endregion
    }
}
