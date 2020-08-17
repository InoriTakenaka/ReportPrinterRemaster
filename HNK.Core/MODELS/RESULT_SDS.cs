using HNK.Infrustracture;
using System.Collections.Generic;
namespace HNK.Core
{
     ///<summary>
     ///实体类RESULT_SDS
     ///</summary>
     public class RESULT_SDS:Entity
     {
         private int __ID=0;
         private string __SDSJCCS=string.Empty;
         private string __JCLSH=string.Empty;
         private string __GDSCO=string.Empty;
         private string __GDSHC=string.Empty;
         private string __DSCO=string.Empty;
         private string __DSHC=string.Empty;
         private string __GDSCOXZ=string.Empty;
         private string __GDSHCXZ=string.Empty;
         private string __DSCOXZ=string.Empty;
         private string __DSHCXZ=string.Empty;
         private string __GDSCO_PD=string.Empty;
         private string __GDSHC_PD=string.Empty;
         private string __DSCO_PD=string.Empty;
         private string __DSHC_PD=string.Empty;
         private string __GLKQXS=string.Empty;
         private string __GLKQXSSX=string.Empty;
         private string __GLKQXSXX=string.Empty;
         private string __GLKQXS_PD=string.Empty;
         private string __SDSWD=string.Empty;
         private string __SDSDQY=string.Empty;
         private string __SDSSD=string.Empty;
         private string __GDSCO2=string.Empty;
         private string __GDSO2=string.Empty;
         private string __DSCO2=string.Empty;
         private string __DSO2=string.Empty;
         private string __SDSYW=string.Empty;
         private string __SDSDSZS=string.Empty;
         private string __SDSGDSZS=string.Empty;
         private string __GDSCOXZZ=string.Empty;
         private string __DSCOXZZ=string.Empty;
         private string __GDSCOXYZ=string.Empty;
         private string __GDSCO2XYZ=string.Empty;
         private string __GDSHCXYZ=string.Empty;
         private string __DSCOXYZ=string.Empty;
         private string __DSCO2XYZ=string.Empty;
         private string __DSHCXYZ=string.Empty;
         private string __SDS_PD=string.Empty;
         private string __DS_PD=string.Empty;
         private string __GDS_PD=string.Empty;
         private string __KSSJ=string.Empty;
         private string __JSSJ=string.Empty;

         private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


         public RESULT_SDS()
         {
             this.__Changed.Add("ID",false);
             this.__Changed.Add("SDSJCCS",false);
             this.__Changed.Add("JCLSH",false);
             this.__Changed.Add("GDSCO",false);
             this.__Changed.Add("GDSHC",false);
             this.__Changed.Add("DSCO",false);
             this.__Changed.Add("DSHC",false);
             this.__Changed.Add("GDSCOXZ",false);
             this.__Changed.Add("GDSHCXZ",false);
             this.__Changed.Add("DSCOXZ",false);
             this.__Changed.Add("DSHCXZ",false);
             this.__Changed.Add("GDSCO_PD",false);
             this.__Changed.Add("GDSHC_PD",false);
             this.__Changed.Add("DSCO_PD",false);
             this.__Changed.Add("DSHC_PD",false);
             this.__Changed.Add("GLKQXS",false);
             this.__Changed.Add("GLKQXSSX",false);
             this.__Changed.Add("GLKQXSXX",false);
             this.__Changed.Add("GLKQXS_PD",false);
             this.__Changed.Add("SDSWD",false);
             this.__Changed.Add("SDSDQY",false);
             this.__Changed.Add("SDSSD",false);
             this.__Changed.Add("GDSCO2",false);
             this.__Changed.Add("GDSO2",false);
             this.__Changed.Add("DSCO2",false);
             this.__Changed.Add("DSO2",false);
             this.__Changed.Add("SDSYW",false);
             this.__Changed.Add("SDSDSZS",false);
             this.__Changed.Add("SDSGDSZS",false);
             this.__Changed.Add("GDSCOXZZ",false);
             this.__Changed.Add("DSCOXZZ",false);
             this.__Changed.Add("GDSCOXYZ",false);
             this.__Changed.Add("GDSCO2XYZ",false);
             this.__Changed.Add("GDSHCXYZ",false);
             this.__Changed.Add("DSCOXYZ",false);
             this.__Changed.Add("DSCO2XYZ",false);
             this.__Changed.Add("DSHCXYZ",false);
             this.__Changed.Add("SDS_PD",false);
             this.__Changed.Add("DS_PD",false);
             this.__Changed.Add("GDS_PD",false);
             this.__Changed.Add("KSSJ",false);
             this.__Changed.Add("JSSJ",false);
         }

         /// <summary>
         /// 将类重置到初始化状态
         /// </summary>
         public void Reset()
         {
             this.__ID =0;
             this.__SDSJCCS =string.Empty;
             this.__JCLSH =string.Empty;
             this.__GDSCO =string.Empty;
             this.__GDSHC =string.Empty;
             this.__DSCO =string.Empty;
             this.__DSHC =string.Empty;
             this.__GDSCOXZ =string.Empty;
             this.__GDSHCXZ =string.Empty;
             this.__DSCOXZ =string.Empty;
             this.__DSHCXZ =string.Empty;
             this.__GDSCO_PD =string.Empty;
             this.__GDSHC_PD =string.Empty;
             this.__DSCO_PD =string.Empty;
             this.__DSHC_PD =string.Empty;
             this.__GLKQXS =string.Empty;
             this.__GLKQXSSX =string.Empty;
             this.__GLKQXSXX =string.Empty;
             this.__GLKQXS_PD =string.Empty;
             this.__SDSWD =string.Empty;
             this.__SDSDQY =string.Empty;
             this.__SDSSD =string.Empty;
             this.__GDSCO2 =string.Empty;
             this.__GDSO2 =string.Empty;
             this.__DSCO2 =string.Empty;
             this.__DSO2 =string.Empty;
             this.__SDSYW =string.Empty;
             this.__SDSDSZS =string.Empty;
             this.__SDSGDSZS =string.Empty;
             this.__GDSCOXZZ =string.Empty;
             this.__DSCOXZZ =string.Empty;
             this.__GDSCOXYZ =string.Empty;
             this.__GDSCO2XYZ =string.Empty;
             this.__GDSHCXYZ =string.Empty;
             this.__DSCOXYZ =string.Empty;
             this.__DSCO2XYZ =string.Empty;
             this.__DSHCXYZ =string.Empty;
             this.__SDS_PD =string.Empty;
             this.__DS_PD =string.Empty;
             this.__GDS_PD =string.Empty;
             this.__KSSJ =string.Empty;
             this.__JSSJ =string.Empty;
             this.__Changed["ID"] = false;
             this.__Changed["SDSJCCS"] = false;
             this.__Changed["JCLSH"] = false;
             this.__Changed["GDSCO"] = false;
             this.__Changed["GDSHC"] = false;
             this.__Changed["DSCO"] = false;
             this.__Changed["DSHC"] = false;
             this.__Changed["GDSCOXZ"] = false;
             this.__Changed["GDSHCXZ"] = false;
             this.__Changed["DSCOXZ"] = false;
             this.__Changed["DSHCXZ"] = false;
             this.__Changed["GDSCO_PD"] = false;
             this.__Changed["GDSHC_PD"] = false;
             this.__Changed["DSCO_PD"] = false;
             this.__Changed["DSHC_PD"] = false;
             this.__Changed["GLKQXS"] = false;
             this.__Changed["GLKQXSSX"] = false;
             this.__Changed["GLKQXSXX"] = false;
             this.__Changed["GLKQXS_PD"] = false;
             this.__Changed["SDSWD"] = false;
             this.__Changed["SDSDQY"] = false;
             this.__Changed["SDSSD"] = false;
             this.__Changed["GDSCO2"] = false;
             this.__Changed["GDSO2"] = false;
             this.__Changed["DSCO2"] = false;
             this.__Changed["DSO2"] = false;
             this.__Changed["SDSYW"] = false;
             this.__Changed["SDSDSZS"] = false;
             this.__Changed["SDSGDSZS"] = false;
             this.__Changed["GDSCOXZZ"] = false;
             this.__Changed["DSCOXZZ"] = false;
             this.__Changed["GDSCOXYZ"] = false;
             this.__Changed["GDSCO2XYZ"] = false;
             this.__Changed["GDSHCXYZ"] = false;
             this.__Changed["DSCOXYZ"] = false;
             this.__Changed["DSCO2XYZ"] = false;
             this.__Changed["DSHCXYZ"] = false;
             this.__Changed["SDS_PD"] = false;
             this.__Changed["DS_PD"] = false;
             this.__Changed["GDS_PD"] = false;
             this.__Changed["KSSJ"] = false;
             this.__Changed["JSSJ"] = false;
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
         ///设置或获取类中的[SDSJCCS]的数据
         /// </summary>
         public string SDSJCCS
         {
              set{ __SDSJCCS = value.Replace("'","’"); __Changed["SDSJCCS"] = true;}
              get{return __SDSJCCS;}
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
         ///设置或获取类中的[GDSCO]的数据
         /// </summary>
         public string GDSCO
         {
              set{ __GDSCO = value.Replace("'","’"); __Changed["GDSCO"] = true;}
              get{return __GDSCO;}
         }
         /// <summary>
         ///设置或获取类中的[GDSHC]的数据
         /// </summary>
         public string GDSHC
         {
              set{ __GDSHC = value.Replace("'","’"); __Changed["GDSHC"] = true;}
              get{return __GDSHC;}
         }
         /// <summary>
         ///设置或获取类中的[DSCO]的数据
         /// </summary>
         public string DSCO
         {
              set{ __DSCO = value.Replace("'","’"); __Changed["DSCO"] = true;}
              get{return __DSCO;}
         }
         /// <summary>
         ///设置或获取类中的[DSHC]的数据
         /// </summary>
         public string DSHC
         {
              set{ __DSHC = value.Replace("'","’"); __Changed["DSHC"] = true;}
              get{return __DSHC;}
         }
         /// <summary>
         ///设置或获取类中的[GDSCOXZ]的数据
         /// </summary>
         public string GDSCOXZ
         {
              set{ __GDSCOXZ = value.Replace("'","’"); __Changed["GDSCOXZ"] = true;}
              get{return __GDSCOXZ;}
         }
         /// <summary>
         ///设置或获取类中的[GDSHCXZ]的数据
         /// </summary>
         public string GDSHCXZ
         {
              set{ __GDSHCXZ = value.Replace("'","’"); __Changed["GDSHCXZ"] = true;}
              get{return __GDSHCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[DSCOXZ]的数据
         /// </summary>
         public string DSCOXZ
         {
              set{ __DSCOXZ = value.Replace("'","’"); __Changed["DSCOXZ"] = true;}
              get{return __DSCOXZ;}
         }
         /// <summary>
         ///设置或获取类中的[DSHCXZ]的数据
         /// </summary>
         public string DSHCXZ
         {
              set{ __DSHCXZ = value.Replace("'","’"); __Changed["DSHCXZ"] = true;}
              get{return __DSHCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[GDSCO_PD]的数据
         /// </summary>
         public string GDSCO_PD
         {
              set{ __GDSCO_PD = value.Replace("'","’"); __Changed["GDSCO_PD"] = true;}
              get{return __GDSCO_PD;}
         }
         /// <summary>
         ///设置或获取类中的[GDSHC_PD]的数据
         /// </summary>
         public string GDSHC_PD
         {
              set{ __GDSHC_PD = value.Replace("'","’"); __Changed["GDSHC_PD"] = true;}
              get{return __GDSHC_PD;}
         }
         /// <summary>
         ///设置或获取类中的[DSCO_PD]的数据
         /// </summary>
         public string DSCO_PD
         {
              set{ __DSCO_PD = value.Replace("'","’"); __Changed["DSCO_PD"] = true;}
              get{return __DSCO_PD;}
         }
         /// <summary>
         ///设置或获取类中的[DSHC_PD]的数据
         /// </summary>
         public string DSHC_PD
         {
              set{ __DSHC_PD = value.Replace("'","’"); __Changed["DSHC_PD"] = true;}
              get{return __DSHC_PD;}
         }
         /// <summary>
         ///设置或获取类中的[GLKQXS]的数据
         /// </summary>
         public string GLKQXS
         {
              set{ __GLKQXS = value.Replace("'","’"); __Changed["GLKQXS"] = true;}
              get{return __GLKQXS;}
         }
         /// <summary>
         ///设置或获取类中的[GLKQXSSX]的数据
         /// </summary>
         public string GLKQXSSX
         {
              set{ __GLKQXSSX = value.Replace("'","’"); __Changed["GLKQXSSX"] = true;}
              get{return __GLKQXSSX;}
         }
         /// <summary>
         ///设置或获取类中的[GLKQXSXX]的数据
         /// </summary>
         public string GLKQXSXX
         {
              set{ __GLKQXSXX = value.Replace("'","’"); __Changed["GLKQXSXX"] = true;}
              get{return __GLKQXSXX;}
         }
         /// <summary>
         ///设置或获取类中的[GLKQXS_PD]的数据
         /// </summary>
         public string GLKQXS_PD
         {
              set{ __GLKQXS_PD = value.Replace("'","’"); __Changed["GLKQXS_PD"] = true;}
              get{return __GLKQXS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[SDSWD]的数据
         /// </summary>
         public string SDSWD
         {
              set{ __SDSWD = value.Replace("'","’"); __Changed["SDSWD"] = true;}
              get{return __SDSWD;}
         }
         /// <summary>
         ///设置或获取类中的[SDSDQY]的数据
         /// </summary>
         public string SDSDQY
         {
              set{ __SDSDQY = value.Replace("'","’"); __Changed["SDSDQY"] = true;}
              get{return __SDSDQY;}
         }
         /// <summary>
         ///设置或获取类中的[SDSSD]的数据
         /// </summary>
         public string SDSSD
         {
              set{ __SDSSD = value.Replace("'","’"); __Changed["SDSSD"] = true;}
              get{return __SDSSD;}
         }
         /// <summary>
         ///设置或获取类中的[GDSCO2]的数据
         /// </summary>
         public string GDSCO2
         {
              set{ __GDSCO2 = value.Replace("'","’"); __Changed["GDSCO2"] = true;}
              get{return __GDSCO2;}
         }
         /// <summary>
         ///设置或获取类中的[GDSO2]的数据
         /// </summary>
         public string GDSO2
         {
              set{ __GDSO2 = value.Replace("'","’"); __Changed["GDSO2"] = true;}
              get{return __GDSO2;}
         }
         /// <summary>
         ///设置或获取类中的[DSCO2]的数据
         /// </summary>
         public string DSCO2
         {
              set{ __DSCO2 = value.Replace("'","’"); __Changed["DSCO2"] = true;}
              get{return __DSCO2;}
         }
         /// <summary>
         ///设置或获取类中的[DSO2]的数据
         /// </summary>
         public string DSO2
         {
              set{ __DSO2 = value.Replace("'","’"); __Changed["DSO2"] = true;}
              get{return __DSO2;}
         }
         /// <summary>
         ///设置或获取类中的[SDSYW]的数据
         /// </summary>
         public string SDSYW
         {
              set{ __SDSYW = value.Replace("'","’"); __Changed["SDSYW"] = true;}
              get{return __SDSYW;}
         }
         /// <summary>
         ///设置或获取类中的[SDSDSZS]的数据
         /// </summary>
         public string SDSDSZS
         {
              set{ __SDSDSZS = value.Replace("'","’"); __Changed["SDSDSZS"] = true;}
              get{return __SDSDSZS;}
         }
         /// <summary>
         ///设置或获取类中的[SDSGDSZS]的数据
         /// </summary>
         public string SDSGDSZS
         {
              set{ __SDSGDSZS = value.Replace("'","’"); __Changed["SDSGDSZS"] = true;}
              get{return __SDSGDSZS;}
         }
         /// <summary>
         ///设置或获取类中的[GDSCOXZZ]的数据
         /// </summary>
         public string GDSCOXZZ
         {
              set{ __GDSCOXZZ = value.Replace("'","’"); __Changed["GDSCOXZZ"] = true;}
              get{return __GDSCOXZZ;}
         }
         /// <summary>
         ///设置或获取类中的[DSCOXZZ]的数据
         /// </summary>
         public string DSCOXZZ
         {
              set{ __DSCOXZZ = value.Replace("'","’"); __Changed["DSCOXZZ"] = true;}
              get{return __DSCOXZZ;}
         }
         /// <summary>
         ///设置或获取类中的[GDSCOXYZ]的数据
         /// </summary>
         public string GDSCOXYZ
         {
              set{ __GDSCOXYZ = value.Replace("'","’"); __Changed["GDSCOXYZ"] = true;}
              get{return __GDSCOXYZ;}
         }
         /// <summary>
         ///设置或获取类中的[GDSCO2XYZ]的数据
         /// </summary>
         public string GDSCO2XYZ
         {
              set{ __GDSCO2XYZ = value.Replace("'","’"); __Changed["GDSCO2XYZ"] = true;}
              get{return __GDSCO2XYZ;}
         }
         /// <summary>
         ///设置或获取类中的[GDSHCXYZ]的数据
         /// </summary>
         public string GDSHCXYZ
         {
              set{ __GDSHCXYZ = value.Replace("'","’"); __Changed["GDSHCXYZ"] = true;}
              get{return __GDSHCXYZ;}
         }
         /// <summary>
         ///设置或获取类中的[DSCOXYZ]的数据
         /// </summary>
         public string DSCOXYZ
         {
              set{ __DSCOXYZ = value.Replace("'","’"); __Changed["DSCOXYZ"] = true;}
              get{return __DSCOXYZ;}
         }
         /// <summary>
         ///设置或获取类中的[DSCO2XYZ]的数据
         /// </summary>
         public string DSCO2XYZ
         {
              set{ __DSCO2XYZ = value.Replace("'","’"); __Changed["DSCO2XYZ"] = true;}
              get{return __DSCO2XYZ;}
         }
         /// <summary>
         ///设置或获取类中的[DSHCXYZ]的数据
         /// </summary>
         public string DSHCXYZ
         {
              set{ __DSHCXYZ = value.Replace("'","’"); __Changed["DSHCXYZ"] = true;}
              get{return __DSHCXYZ;}
         }
         /// <summary>
         ///设置或获取类中的[SDS_PD]的数据
         /// </summary>
         public string SDS_PD
         {
              set{ __SDS_PD = value.Replace("'","’"); __Changed["SDS_PD"] = true;}
              get{return __SDS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[DS_PD]的数据
         /// </summary>
         public string DS_PD
         {
              set{ __DS_PD = value.Replace("'","’"); __Changed["DS_PD"] = true;}
              get{return __DS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[GDS_PD]的数据
         /// </summary>
         public string GDS_PD
         {
              set{ __GDS_PD = value.Replace("'","’"); __Changed["GDS_PD"] = true;}
              get{return __GDS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[KSSJ]的数据
         /// </summary>
         public string KSSJ
         {
              set{ __KSSJ = value.Replace("'","’"); __Changed["KSSJ"] = true;}
              get{return __KSSJ;}
         }
         /// <summary>
         ///设置或获取类中的[JSSJ]的数据
         /// </summary>
         public string JSSJ
         {
              set{ __JSSJ = value.Replace("'","’"); __Changed["JSSJ"] = true;}
              get{return __JSSJ;}
         }
    }
}
