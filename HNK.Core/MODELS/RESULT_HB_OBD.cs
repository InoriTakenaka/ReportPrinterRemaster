using HNK.Infrustracture;
using System.Collections.Generic;
namespace HNK.Core
{
     ///<summary>
     ///实体类RESULT_HB_OBD
     ///</summary>
     public class RESULT_HB_OBD:Entity
     {
         private int __ID=0;
         private string __JCLSH=string.Empty;
         private string __OBDJYY=string.Empty;
         private string __OBDGZZSQ_PD=string.Empty;
         private string __TX_PD=string.Empty;
         private string __TXGZYY=string.Empty;
         private string __GZZSQBJ_PD=string.Empty;
         private string __GZZSQBJNR=string.Empty;
         private string __JXWWCZT_PD=string.Empty;
         private string __JXWWCZT=string.Empty;
         private string __MIL=string.Empty;
         private string __FDJ_CALID=string.Empty;
         private string __FDJ_CVN=string.Empty;
         private string __HCLZZ_CALID=string.Empty;
         private string __HCLZZ_CVN=string.Empty;
         private string __QTKZDY_CALID=string.Empty;
         private string __QTKZDY_CVN=string.Empty;
         private string __OBD_PD=string.Empty;
         private string __JYKCS_PD=string.Empty;
         private string __YXGCS_PD=string.Empty;
         private string __RYZFCS_PD=string.Empty;
         private string __RYZFCSJJY=string.Empty;
         private string __LGMYD_PD=string.Empty;
         private string __LGMYDDJ=string.Empty;

         private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


         public RESULT_HB_OBD()
         {
             this.__Changed.Add("ID",false);
             this.__Changed.Add("JCLSH",false);
             this.__Changed.Add("OBDJYY",false);
             this.__Changed.Add("OBDGZZSQ_PD",false);
             this.__Changed.Add("TX_PD",false);
             this.__Changed.Add("TXGZYY",false);
             this.__Changed.Add("GZZSQBJ_PD",false);
             this.__Changed.Add("GZZSQBJNR",false);
             this.__Changed.Add("JXWWCZT_PD",false);
             this.__Changed.Add("JXWWCZT",false);
             this.__Changed.Add("MIL",false);
             this.__Changed.Add("FDJ_CALID",false);
             this.__Changed.Add("FDJ_CVN",false);
             this.__Changed.Add("HCLZZ_CALID",false);
             this.__Changed.Add("HCLZZ_CVN",false);
             this.__Changed.Add("QTKZDY_CALID",false);
             this.__Changed.Add("QTKZDY_CVN",false);
             this.__Changed.Add("OBD_PD",false);
             this.__Changed.Add("JYKCS_PD",false);
             this.__Changed.Add("YXGCS_PD",false);
             this.__Changed.Add("RYZFCS_PD",false);
             this.__Changed.Add("RYZFCSJJY",false);
             this.__Changed.Add("LGMYD_PD",false);
             this.__Changed.Add("LGMYDDJ",false);
         }

         /// <summary>
         /// 将类重置到初始化状态
         /// </summary>
         public void Reset()
         {
             this.__ID =0;
             this.__JCLSH =string.Empty;
             this.__OBDJYY =string.Empty;
             this.__OBDGZZSQ_PD =string.Empty;
             this.__TX_PD =string.Empty;
             this.__TXGZYY =string.Empty;
             this.__GZZSQBJ_PD =string.Empty;
             this.__GZZSQBJNR =string.Empty;
             this.__JXWWCZT_PD =string.Empty;
             this.__JXWWCZT =string.Empty;
             this.__MIL =string.Empty;
             this.__FDJ_CALID =string.Empty;
             this.__FDJ_CVN =string.Empty;
             this.__HCLZZ_CALID =string.Empty;
             this.__HCLZZ_CVN =string.Empty;
             this.__QTKZDY_CALID =string.Empty;
             this.__QTKZDY_CVN =string.Empty;
             this.__OBD_PD =string.Empty;
             this.__JYKCS_PD =string.Empty;
             this.__YXGCS_PD =string.Empty;
             this.__RYZFCS_PD =string.Empty;
             this.__RYZFCSJJY =string.Empty;
             this.__LGMYD_PD =string.Empty;
             this.__LGMYDDJ =string.Empty;
             this.__Changed["ID"] = false;
             this.__Changed["JCLSH"] = false;
             this.__Changed["OBDJYY"] = false;
             this.__Changed["OBDGZZSQ_PD"] = false;
             this.__Changed["TX_PD"] = false;
             this.__Changed["TXGZYY"] = false;
             this.__Changed["GZZSQBJ_PD"] = false;
             this.__Changed["GZZSQBJNR"] = false;
             this.__Changed["JXWWCZT_PD"] = false;
             this.__Changed["JXWWCZT"] = false;
             this.__Changed["MIL"] = false;
             this.__Changed["FDJ_CALID"] = false;
             this.__Changed["FDJ_CVN"] = false;
             this.__Changed["HCLZZ_CALID"] = false;
             this.__Changed["HCLZZ_CVN"] = false;
             this.__Changed["QTKZDY_CALID"] = false;
             this.__Changed["QTKZDY_CVN"] = false;
             this.__Changed["OBD_PD"] = false;
             this.__Changed["JYKCS_PD"] = false;
             this.__Changed["YXGCS_PD"] = false;
             this.__Changed["RYZFCS_PD"] = false;
             this.__Changed["RYZFCSJJY"] = false;
             this.__Changed["LGMYD_PD"] = false;
             this.__Changed["LGMYDDJ"] = false;
         }

         /// <summary>
         /// 获取类中成员的改变状态
         /// </summary>
         public bool Changed(string strKey)
         {
             return __Changed[strKey];
         }

         /// <summary>
         ///设置或获取类中的[ID]的数据
         /// </summary>
         public int ID
         {
              set{ __ID = value; __Changed["ID"] = true;}
              get{return __ID;}
         }
         /// <summary>
         ///设置或获取类中的[JCLSH]的数据
         /// </summary>
         public string JCLSH
         {
              set{ __JCLSH = value.Replace("'","’"); __Changed["JCLSH"] = true;}
              get{return __JCLSH;}
         }
         /// <summary>
         ///设置或获取类中的[OBDJYY]的数据
         /// </summary>
         public string OBDJYY
         {
              set{ __OBDJYY = value.Replace("'","’"); __Changed["OBDJYY"] = true;}
              get{return __OBDJYY;}
         }
         /// <summary>
         ///设置或获取类中的[OBDGZZSQ_PD]的数据
         /// </summary>
         public string OBDGZZSQ_PD
         {
              set{ __OBDGZZSQ_PD = value.Replace("'","’"); __Changed["OBDGZZSQ_PD"] = true;}
              get{return __OBDGZZSQ_PD;}
         }
         /// <summary>
         ///设置或获取类中的[TX_PD]的数据
         /// </summary>
         public string TX_PD
         {
              set{ __TX_PD = value.Replace("'","’"); __Changed["TX_PD"] = true;}
              get{return __TX_PD;}
         }
         /// <summary>
         ///设置或获取类中的[TXGZYY]的数据
         /// </summary>
         public string TXGZYY
         {
              set{ __TXGZYY = value.Replace("'","’"); __Changed["TXGZYY"] = true;}
              get{return __TXGZYY;}
         }
         /// <summary>
         ///设置或获取类中的[GZZSQBJ_PD]的数据
         /// </summary>
         public string GZZSQBJ_PD
         {
              set{ __GZZSQBJ_PD = value.Replace("'","’"); __Changed["GZZSQBJ_PD"] = true;}
              get{return __GZZSQBJ_PD;}
         }
         /// <summary>
         ///设置或获取类中的[GZZSQBJNR]的数据
         /// </summary>
         public string GZZSQBJNR
         {
              set{ __GZZSQBJNR = value.Replace("'","’"); __Changed["GZZSQBJNR"] = true;}
              get{return __GZZSQBJNR;}
         }
         /// <summary>
         ///设置或获取类中的[JXWWCZT_PD]的数据
         /// </summary>
         public string JXWWCZT_PD
         {
              set{ __JXWWCZT_PD = value.Replace("'","’"); __Changed["JXWWCZT_PD"] = true;}
              get{return __JXWWCZT_PD;}
         }
         /// <summary>
         ///设置或获取类中的[JXWWCZT]的数据
         /// </summary>
         public string JXWWCZT
         {
              set{ __JXWWCZT = value.Replace("'","’"); __Changed["JXWWCZT"] = true;}
              get{return __JXWWCZT;}
         }
         /// <summary>
         ///设置或获取类中的[MIL]的数据
         /// </summary>
         public string MIL
         {
              set{ __MIL = value.Replace("'","’"); __Changed["MIL"] = true;}
              get{return __MIL;}
         }
         /// <summary>
         ///设置或获取类中的[FDJ_CALID]的数据
         /// </summary>
         public string FDJ_CALID
         {
              set{ __FDJ_CALID = value.Replace("'","’"); __Changed["FDJ_CALID"] = true;}
              get{return __FDJ_CALID;}
         }
         /// <summary>
         ///设置或获取类中的[FDJ_CVN]的数据
         /// </summary>
         public string FDJ_CVN
         {
              set{ __FDJ_CVN = value.Replace("'","’"); __Changed["FDJ_CVN"] = true;}
              get{return __FDJ_CVN;}
         }
         /// <summary>
         ///设置或获取类中的[HCLZZ_CALID]的数据
         /// </summary>
         public string HCLZZ_CALID
         {
              set{ __HCLZZ_CALID = value.Replace("'","’"); __Changed["HCLZZ_CALID"] = true;}
              get{return __HCLZZ_CALID;}
         }
         /// <summary>
         ///设置或获取类中的[HCLZZ_CVN]的数据
         /// </summary>
         public string HCLZZ_CVN
         {
              set{ __HCLZZ_CVN = value.Replace("'","’"); __Changed["HCLZZ_CVN"] = true;}
              get{return __HCLZZ_CVN;}
         }
         /// <summary>
         ///设置或获取类中的[QTKZDY_CALID]的数据
         /// </summary>
         public string QTKZDY_CALID
         {
              set{ __QTKZDY_CALID = value.Replace("'","’"); __Changed["QTKZDY_CALID"] = true;}
              get{return __QTKZDY_CALID;}
         }
         /// <summary>
         ///设置或获取类中的[QTKZDY_CVN]的数据
         /// </summary>
         public string QTKZDY_CVN
         {
              set{ __QTKZDY_CVN = value.Replace("'","’"); __Changed["QTKZDY_CVN"] = true;}
              get{return __QTKZDY_CVN;}
         }
         /// <summary>
         ///设置或获取类中的[OBD_PD]的数据
         /// </summary>
         public string OBD_PD
         {
              set{ __OBD_PD = value.Replace("'","’"); __Changed["OBD_PD"] = true;}
              get{return __OBD_PD;}
         }
         /// <summary>
         ///设置或获取类中的[JYKCS_PD]的数据
         /// </summary>
         public string JYKCS_PD
         {
              set{ __JYKCS_PD = value.Replace("'","’"); __Changed["JYKCS_PD"] = true;}
              get{return __JYKCS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[YXGCS_PD]的数据
         /// </summary>
         public string YXGCS_PD
         {
              set{ __YXGCS_PD = value.Replace("'","’"); __Changed["YXGCS_PD"] = true;}
              get{return __YXGCS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[RYZFCS_PD]的数据
         /// </summary>
         public string RYZFCS_PD
         {
              set{ __RYZFCS_PD = value.Replace("'","’"); __Changed["RYZFCS_PD"] = true;}
              get{return __RYZFCS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[RYZFCSJJY]的数据
         /// </summary>
         public string RYZFCSJJY
         {
              set{ __RYZFCSJJY = value.Replace("'","’"); __Changed["RYZFCSJJY"] = true;}
              get{return __RYZFCSJJY;}
         }
         /// <summary>
         ///设置或获取类中的[LGMYD_PD]的数据
         /// </summary>
         public string LGMYD_PD
         {
              set{ __LGMYD_PD = value.Replace("'","’"); __Changed["LGMYD_PD"] = true;}
              get{return __LGMYD_PD;}
         }
         /// <summary>
         ///设置或获取类中的[LGMYDDJ]的数据
         /// </summary>
         public string LGMYDDJ
         {
              set{ __LGMYDDJ = value.Replace("'","’"); __Changed["LGMYDDJ"] = true;}
              get{return __LGMYDDJ;}
         }
    }
}
