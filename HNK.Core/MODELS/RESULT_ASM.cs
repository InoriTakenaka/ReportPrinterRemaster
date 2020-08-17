using HNK.Infrustracture;
using System.Collections.Generic;
namespace HNK.Core
{
     ///<summary>
     ///实体类RESULT_ASM
     ///</summary>
     public class RESULT_ASM:Entity
     {
         private int __ID=0;
         private string __JCLSH=string.Empty;
         private string __ASMJCCS=string.Empty;
         private string __HC5025JG=string.Empty;
         private string __CO5025JG=string.Empty;
         private string __NO5025JG=string.Empty;
         private string __HC2540JG=string.Empty;
         private string __CO2540JG=string.Empty;
         private string __NO2540JG=string.Empty;
         private string __HC5025XZ=string.Empty;
         private string __CO5025XZ=string.Empty;
         private string __NO5025XZ=string.Empty;
         private string __HC2540XZ=string.Empty;
         private string __CO2540XZ=string.Empty;
         private string __NO2540XZ=string.Empty;
         private string __HC5025_PD=string.Empty;
         private string __CO5025_PD=string.Empty;
         private string __NO5025_PD=string.Empty;
         private string __HC2540_PD=string.Empty;
         private string __CO2540_PD=string.Empty;
         private string __NO2540_PD=string.Empty;
         private string __ASM_5025_PD=string.Empty;
         private string __ASM_2540_PD=string.Empty;
         private string __ASM_PD=string.Empty;
         private string __ASMWD=string.Empty;
         private string __ASMDQY=string.Empty;
         private string __ASMSD=string.Empty;
         private string __ASMYW=string.Empty;
         private string __DSYW=string.Empty;
         private string __DSHC=string.Empty;
         private string __DSCO=string.Empty;
         private string __DSHCXZ=string.Empty;
         private string __DSCOXZ=string.Empty;
         private string __DSHC_PD=string.Empty;
         private string __DSCO_PD=string.Empty;
         private string __GL5025=string.Empty;
         private string __GL2540=string.Empty;
         private string __CO25025JG=string.Empty;
         private string __CO22540JG=string.Empty;
         private string __CO2DSJG=string.Empty;
         private string __O25025JG=string.Empty;
         private string __O22540JG=string.Empty;
         private string __O2DSJG=string.Empty;
         private string __RPM5025JG=string.Empty;
         private string __RPM2540JG=string.Empty;
         private string __RPMDSJG=string.Empty;
         private string __DSNO=string.Empty;
         private string __NMD5025JG=string.Empty;
         private string __NMD2540JG=string.Empty;
         private string __NMDDSJG=string.Empty;
         private string __OBD5025CODE=string.Empty;
         private string __OBD2540CODE=string.Empty;
         private string __CO25025XZ=string.Empty;
         private string __CO22540XZ=string.Empty;
         private string __CO2DSZX=string.Empty;
         private string __O25025XZ=string.Empty;
         private string __O22540XZ=string.Empty;
         private string __O2DSXZ=string.Empty;
         private string __RPM5025XZ=string.Empty;
         private string __RPM2540XZ=string.Empty;
         private string __RPMDSXZ=string.Empty;
         private string __DSNOXZ=string.Empty;
         private string __NMD5025XZ_MAX=string.Empty;
         private string __NMD5025XZ_MIN=string.Empty;
         private string __NMD2540XZ_MAX=string.Empty;
         private string __NMD2540XZ_MIN=string.Empty;
         private string __NMDDSXZ_MAX=string.Empty;
         private string __NMDDSXZ_MIN=string.Empty;
         private string __OBD5025_PD=string.Empty;
         private string __OBD2540_PD=string.Empty;
         private string __CO25025_PD=string.Empty;
         private string __CO22540_PD=string.Empty;
         private string __CO2DS_PD=string.Empty;
         private string __O25025_PD=string.Empty;
         private string __O22540_PD=string.Empty;
         private string __O2DS_PD=string.Empty;
         private string __RPM5025_PD=string.Empty;
         private string __RPM2540_PD=string.Empty;
         private string __RPMDS_PD=string.Empty;
         private string __DSNO_PD=string.Empty;
         private string __NMD5025_PD=string.Empty;
         private string __NMD2540_PD=string.Empty;
         private string __NMDDS_PD=string.Empty;
         private string __ASM_DS_PD=string.Empty;
         private string __KSSJ=string.Empty;
         private string __JSSJ=string.Empty;

         private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


         public RESULT_ASM()
         {
             this.__Changed.Add("ID",false);
             this.__Changed.Add("JCLSH",false);
             this.__Changed.Add("ASMJCCS",false);
             this.__Changed.Add("HC5025JG",false);
             this.__Changed.Add("CO5025JG",false);
             this.__Changed.Add("NO5025JG",false);
             this.__Changed.Add("HC2540JG",false);
             this.__Changed.Add("CO2540JG",false);
             this.__Changed.Add("NO2540JG",false);
             this.__Changed.Add("HC5025XZ",false);
             this.__Changed.Add("CO5025XZ",false);
             this.__Changed.Add("NO5025XZ",false);
             this.__Changed.Add("HC2540XZ",false);
             this.__Changed.Add("CO2540XZ",false);
             this.__Changed.Add("NO2540XZ",false);
             this.__Changed.Add("HC5025_PD",false);
             this.__Changed.Add("CO5025_PD",false);
             this.__Changed.Add("NO5025_PD",false);
             this.__Changed.Add("HC2540_PD",false);
             this.__Changed.Add("CO2540_PD",false);
             this.__Changed.Add("NO2540_PD",false);
             this.__Changed.Add("ASM_5025_PD",false);
             this.__Changed.Add("ASM_2540_PD",false);
             this.__Changed.Add("ASM_PD",false);
             this.__Changed.Add("ASMWD",false);
             this.__Changed.Add("ASMDQY",false);
             this.__Changed.Add("ASMSD",false);
             this.__Changed.Add("ASMYW",false);
             this.__Changed.Add("DSYW",false);
             this.__Changed.Add("DSHC",false);
             this.__Changed.Add("DSCO",false);
             this.__Changed.Add("DSHCXZ",false);
             this.__Changed.Add("DSCOXZ",false);
             this.__Changed.Add("DSHC_PD",false);
             this.__Changed.Add("DSCO_PD",false);
             this.__Changed.Add("GL5025",false);
             this.__Changed.Add("GL2540",false);
             this.__Changed.Add("CO25025JG",false);
             this.__Changed.Add("CO22540JG",false);
             this.__Changed.Add("CO2DSJG",false);
             this.__Changed.Add("O25025JG",false);
             this.__Changed.Add("O22540JG",false);
             this.__Changed.Add("O2DSJG",false);
             this.__Changed.Add("RPM5025JG",false);
             this.__Changed.Add("RPM2540JG",false);
             this.__Changed.Add("RPMDSJG",false);
             this.__Changed.Add("DSNO",false);
             this.__Changed.Add("NMD5025JG",false);
             this.__Changed.Add("NMD2540JG",false);
             this.__Changed.Add("NMDDSJG",false);
             this.__Changed.Add("OBD5025CODE",false);
             this.__Changed.Add("OBD2540CODE",false);
             this.__Changed.Add("CO25025XZ",false);
             this.__Changed.Add("CO22540XZ",false);
             this.__Changed.Add("CO2DSZX",false);
             this.__Changed.Add("O25025XZ",false);
             this.__Changed.Add("O22540XZ",false);
             this.__Changed.Add("O2DSXZ",false);
             this.__Changed.Add("RPM5025XZ",false);
             this.__Changed.Add("RPM2540XZ",false);
             this.__Changed.Add("RPMDSXZ",false);
             this.__Changed.Add("DSNOXZ",false);
             this.__Changed.Add("NMD5025XZ_MAX",false);
             this.__Changed.Add("NMD5025XZ_MIN",false);
             this.__Changed.Add("NMD2540XZ_MAX",false);
             this.__Changed.Add("NMD2540XZ_MIN",false);
             this.__Changed.Add("NMDDSXZ_MAX",false);
             this.__Changed.Add("NMDDSXZ_MIN",false);
             this.__Changed.Add("OBD5025_PD",false);
             this.__Changed.Add("OBD2540_PD",false);
             this.__Changed.Add("CO25025_PD",false);
             this.__Changed.Add("CO22540_PD",false);
             this.__Changed.Add("CO2DS_PD",false);
             this.__Changed.Add("O25025_PD",false);
             this.__Changed.Add("O22540_PD",false);
             this.__Changed.Add("O2DS_PD",false);
             this.__Changed.Add("RPM5025_PD",false);
             this.__Changed.Add("RPM2540_PD",false);
             this.__Changed.Add("RPMDS_PD",false);
             this.__Changed.Add("DSNO_PD",false);
             this.__Changed.Add("NMD5025_PD",false);
             this.__Changed.Add("NMD2540_PD",false);
             this.__Changed.Add("NMDDS_PD",false);
             this.__Changed.Add("ASM_DS_PD",false);
             this.__Changed.Add("KSSJ",false);
             this.__Changed.Add("JSSJ",false);
         }

         /// <summary>
         /// 将类重置到初始化状态
         /// </summary>
         public void Reset()
         {
             this.__ID =0;
             this.__JCLSH =string.Empty;
             this.__ASMJCCS =string.Empty;
             this.__HC5025JG =string.Empty;
             this.__CO5025JG =string.Empty;
             this.__NO5025JG =string.Empty;
             this.__HC2540JG =string.Empty;
             this.__CO2540JG =string.Empty;
             this.__NO2540JG =string.Empty;
             this.__HC5025XZ =string.Empty;
             this.__CO5025XZ =string.Empty;
             this.__NO5025XZ =string.Empty;
             this.__HC2540XZ =string.Empty;
             this.__CO2540XZ =string.Empty;
             this.__NO2540XZ =string.Empty;
             this.__HC5025_PD =string.Empty;
             this.__CO5025_PD =string.Empty;
             this.__NO5025_PD =string.Empty;
             this.__HC2540_PD =string.Empty;
             this.__CO2540_PD =string.Empty;
             this.__NO2540_PD =string.Empty;
             this.__ASM_5025_PD =string.Empty;
             this.__ASM_2540_PD =string.Empty;
             this.__ASM_PD =string.Empty;
             this.__ASMWD =string.Empty;
             this.__ASMDQY =string.Empty;
             this.__ASMSD =string.Empty;
             this.__ASMYW =string.Empty;
             this.__DSYW =string.Empty;
             this.__DSHC =string.Empty;
             this.__DSCO =string.Empty;
             this.__DSHCXZ =string.Empty;
             this.__DSCOXZ =string.Empty;
             this.__DSHC_PD =string.Empty;
             this.__DSCO_PD =string.Empty;
             this.__GL5025 =string.Empty;
             this.__GL2540 =string.Empty;
             this.__CO25025JG =string.Empty;
             this.__CO22540JG =string.Empty;
             this.__CO2DSJG =string.Empty;
             this.__O25025JG =string.Empty;
             this.__O22540JG =string.Empty;
             this.__O2DSJG =string.Empty;
             this.__RPM5025JG =string.Empty;
             this.__RPM2540JG =string.Empty;
             this.__RPMDSJG =string.Empty;
             this.__DSNO =string.Empty;
             this.__NMD5025JG =string.Empty;
             this.__NMD2540JG =string.Empty;
             this.__NMDDSJG =string.Empty;
             this.__OBD5025CODE =string.Empty;
             this.__OBD2540CODE =string.Empty;
             this.__CO25025XZ =string.Empty;
             this.__CO22540XZ =string.Empty;
             this.__CO2DSZX =string.Empty;
             this.__O25025XZ =string.Empty;
             this.__O22540XZ =string.Empty;
             this.__O2DSXZ =string.Empty;
             this.__RPM5025XZ =string.Empty;
             this.__RPM2540XZ =string.Empty;
             this.__RPMDSXZ =string.Empty;
             this.__DSNOXZ =string.Empty;
             this.__NMD5025XZ_MAX =string.Empty;
             this.__NMD5025XZ_MIN =string.Empty;
             this.__NMD2540XZ_MAX =string.Empty;
             this.__NMD2540XZ_MIN =string.Empty;
             this.__NMDDSXZ_MAX =string.Empty;
             this.__NMDDSXZ_MIN =string.Empty;
             this.__OBD5025_PD =string.Empty;
             this.__OBD2540_PD =string.Empty;
             this.__CO25025_PD =string.Empty;
             this.__CO22540_PD =string.Empty;
             this.__CO2DS_PD =string.Empty;
             this.__O25025_PD =string.Empty;
             this.__O22540_PD =string.Empty;
             this.__O2DS_PD =string.Empty;
             this.__RPM5025_PD =string.Empty;
             this.__RPM2540_PD =string.Empty;
             this.__RPMDS_PD =string.Empty;
             this.__DSNO_PD =string.Empty;
             this.__NMD5025_PD =string.Empty;
             this.__NMD2540_PD =string.Empty;
             this.__NMDDS_PD =string.Empty;
             this.__ASM_DS_PD =string.Empty;
             this.__KSSJ =string.Empty;
             this.__JSSJ =string.Empty;
             this.__Changed["ID"] = false;
             this.__Changed["JCLSH"] = false;
             this.__Changed["ASMJCCS"] = false;
             this.__Changed["HC5025JG"] = false;
             this.__Changed["CO5025JG"] = false;
             this.__Changed["NO5025JG"] = false;
             this.__Changed["HC2540JG"] = false;
             this.__Changed["CO2540JG"] = false;
             this.__Changed["NO2540JG"] = false;
             this.__Changed["HC5025XZ"] = false;
             this.__Changed["CO5025XZ"] = false;
             this.__Changed["NO5025XZ"] = false;
             this.__Changed["HC2540XZ"] = false;
             this.__Changed["CO2540XZ"] = false;
             this.__Changed["NO2540XZ"] = false;
             this.__Changed["HC5025_PD"] = false;
             this.__Changed["CO5025_PD"] = false;
             this.__Changed["NO5025_PD"] = false;
             this.__Changed["HC2540_PD"] = false;
             this.__Changed["CO2540_PD"] = false;
             this.__Changed["NO2540_PD"] = false;
             this.__Changed["ASM_5025_PD"] = false;
             this.__Changed["ASM_2540_PD"] = false;
             this.__Changed["ASM_PD"] = false;
             this.__Changed["ASMWD"] = false;
             this.__Changed["ASMDQY"] = false;
             this.__Changed["ASMSD"] = false;
             this.__Changed["ASMYW"] = false;
             this.__Changed["DSYW"] = false;
             this.__Changed["DSHC"] = false;
             this.__Changed["DSCO"] = false;
             this.__Changed["DSHCXZ"] = false;
             this.__Changed["DSCOXZ"] = false;
             this.__Changed["DSHC_PD"] = false;
             this.__Changed["DSCO_PD"] = false;
             this.__Changed["GL5025"] = false;
             this.__Changed["GL2540"] = false;
             this.__Changed["CO25025JG"] = false;
             this.__Changed["CO22540JG"] = false;
             this.__Changed["CO2DSJG"] = false;
             this.__Changed["O25025JG"] = false;
             this.__Changed["O22540JG"] = false;
             this.__Changed["O2DSJG"] = false;
             this.__Changed["RPM5025JG"] = false;
             this.__Changed["RPM2540JG"] = false;
             this.__Changed["RPMDSJG"] = false;
             this.__Changed["DSNO"] = false;
             this.__Changed["NMD5025JG"] = false;
             this.__Changed["NMD2540JG"] = false;
             this.__Changed["NMDDSJG"] = false;
             this.__Changed["OBD5025CODE"] = false;
             this.__Changed["OBD2540CODE"] = false;
             this.__Changed["CO25025XZ"] = false;
             this.__Changed["CO22540XZ"] = false;
             this.__Changed["CO2DSZX"] = false;
             this.__Changed["O25025XZ"] = false;
             this.__Changed["O22540XZ"] = false;
             this.__Changed["O2DSXZ"] = false;
             this.__Changed["RPM5025XZ"] = false;
             this.__Changed["RPM2540XZ"] = false;
             this.__Changed["RPMDSXZ"] = false;
             this.__Changed["DSNOXZ"] = false;
             this.__Changed["NMD5025XZ_MAX"] = false;
             this.__Changed["NMD5025XZ_MIN"] = false;
             this.__Changed["NMD2540XZ_MAX"] = false;
             this.__Changed["NMD2540XZ_MIN"] = false;
             this.__Changed["NMDDSXZ_MAX"] = false;
             this.__Changed["NMDDSXZ_MIN"] = false;
             this.__Changed["OBD5025_PD"] = false;
             this.__Changed["OBD2540_PD"] = false;
             this.__Changed["CO25025_PD"] = false;
             this.__Changed["CO22540_PD"] = false;
             this.__Changed["CO2DS_PD"] = false;
             this.__Changed["O25025_PD"] = false;
             this.__Changed["O22540_PD"] = false;
             this.__Changed["O2DS_PD"] = false;
             this.__Changed["RPM5025_PD"] = false;
             this.__Changed["RPM2540_PD"] = false;
             this.__Changed["RPMDS_PD"] = false;
             this.__Changed["DSNO_PD"] = false;
             this.__Changed["NMD5025_PD"] = false;
             this.__Changed["NMD2540_PD"] = false;
             this.__Changed["NMDDS_PD"] = false;
             this.__Changed["ASM_DS_PD"] = false;
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
         ///设置或获取类中的[JCLSH]的数据
         /// </summary>
         public string JCLSH
         {
              set{ __JCLSH = value.Replace("'","’"); __Changed["JCLSH"] = true;}
              get{return __JCLSH;}
         }
         /// <summary>
         ///设置或获取类中的[ASMJCCS]的数据
         /// </summary>
         public string ASMJCCS
         {
              set{ __ASMJCCS = value.Replace("'","’"); __Changed["ASMJCCS"] = true;}
              get{return __ASMJCCS;}
         }
         /// <summary>
         ///设置或获取类中的[HC5025JG]的数据
         /// </summary>
         public string HC5025JG
         {
              set{ __HC5025JG = value.Replace("'","’"); __Changed["HC5025JG"] = true;}
              get{return __HC5025JG;}
         }
         /// <summary>
         ///设置或获取类中的[CO5025JG]的数据
         /// </summary>
         public string CO5025JG
         {
              set{ __CO5025JG = value.Replace("'","’"); __Changed["CO5025JG"] = true;}
              get{return __CO5025JG;}
         }
         /// <summary>
         ///设置或获取类中的[NO5025JG]的数据
         /// </summary>
         public string NO5025JG
         {
              set{ __NO5025JG = value.Replace("'","’"); __Changed["NO5025JG"] = true;}
              get{return __NO5025JG;}
         }
         /// <summary>
         ///设置或获取类中的[HC2540JG]的数据
         /// </summary>
         public string HC2540JG
         {
              set{ __HC2540JG = value.Replace("'","’"); __Changed["HC2540JG"] = true;}
              get{return __HC2540JG;}
         }
         /// <summary>
         ///设置或获取类中的[CO2540JG]的数据
         /// </summary>
         public string CO2540JG
         {
              set{ __CO2540JG = value.Replace("'","’"); __Changed["CO2540JG"] = true;}
              get{return __CO2540JG;}
         }
         /// <summary>
         ///设置或获取类中的[NO2540JG]的数据
         /// </summary>
         public string NO2540JG
         {
              set{ __NO2540JG = value.Replace("'","’"); __Changed["NO2540JG"] = true;}
              get{return __NO2540JG;}
         }
         /// <summary>
         ///设置或获取类中的[HC5025XZ]的数据
         /// </summary>
         public string HC5025XZ
         {
              set{ __HC5025XZ = value.Replace("'","’"); __Changed["HC5025XZ"] = true;}
              get{return __HC5025XZ;}
         }
         /// <summary>
         ///设置或获取类中的[CO5025XZ]的数据
         /// </summary>
         public string CO5025XZ
         {
              set{ __CO5025XZ = value.Replace("'","’"); __Changed["CO5025XZ"] = true;}
              get{return __CO5025XZ;}
         }
         /// <summary>
         ///设置或获取类中的[NO5025XZ]的数据
         /// </summary>
         public string NO5025XZ
         {
              set{ __NO5025XZ = value.Replace("'","’"); __Changed["NO5025XZ"] = true;}
              get{return __NO5025XZ;}
         }
         /// <summary>
         ///设置或获取类中的[HC2540XZ]的数据
         /// </summary>
         public string HC2540XZ
         {
              set{ __HC2540XZ = value.Replace("'","’"); __Changed["HC2540XZ"] = true;}
              get{return __HC2540XZ;}
         }
         /// <summary>
         ///设置或获取类中的[CO2540XZ]的数据
         /// </summary>
         public string CO2540XZ
         {
              set{ __CO2540XZ = value.Replace("'","’"); __Changed["CO2540XZ"] = true;}
              get{return __CO2540XZ;}
         }
         /// <summary>
         ///设置或获取类中的[NO2540XZ]的数据
         /// </summary>
         public string NO2540XZ
         {
              set{ __NO2540XZ = value.Replace("'","’"); __Changed["NO2540XZ"] = true;}
              get{return __NO2540XZ;}
         }
         /// <summary>
         ///设置或获取类中的[HC5025_PD]的数据
         /// </summary>
         public string HC5025_PD
         {
              set{ __HC5025_PD = value.Replace("'","’"); __Changed["HC5025_PD"] = true;}
              get{return __HC5025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[CO5025_PD]的数据
         /// </summary>
         public string CO5025_PD
         {
              set{ __CO5025_PD = value.Replace("'","’"); __Changed["CO5025_PD"] = true;}
              get{return __CO5025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[NO5025_PD]的数据
         /// </summary>
         public string NO5025_PD
         {
              set{ __NO5025_PD = value.Replace("'","’"); __Changed["NO5025_PD"] = true;}
              get{return __NO5025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[HC2540_PD]的数据
         /// </summary>
         public string HC2540_PD
         {
              set{ __HC2540_PD = value.Replace("'","’"); __Changed["HC2540_PD"] = true;}
              get{return __HC2540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[CO2540_PD]的数据
         /// </summary>
         public string CO2540_PD
         {
              set{ __CO2540_PD = value.Replace("'","’"); __Changed["CO2540_PD"] = true;}
              get{return __CO2540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[NO2540_PD]的数据
         /// </summary>
         public string NO2540_PD
         {
              set{ __NO2540_PD = value.Replace("'","’"); __Changed["NO2540_PD"] = true;}
              get{return __NO2540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[ASM_5025_PD]的数据
         /// </summary>
         public string ASM_5025_PD
         {
              set{ __ASM_5025_PD = value.Replace("'","’"); __Changed["ASM_5025_PD"] = true;}
              get{return __ASM_5025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[ASM_2540_PD]的数据
         /// </summary>
         public string ASM_2540_PD
         {
              set{ __ASM_2540_PD = value.Replace("'","’"); __Changed["ASM_2540_PD"] = true;}
              get{return __ASM_2540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[ASM_PD]的数据
         /// </summary>
         public string ASM_PD
         {
              set{ __ASM_PD = value.Replace("'","’"); __Changed["ASM_PD"] = true;}
              get{return __ASM_PD;}
         }
         /// <summary>
         ///设置或获取类中的[ASMWD]的数据
         /// </summary>
         public string ASMWD
         {
              set{ __ASMWD = value.Replace("'","’"); __Changed["ASMWD"] = true;}
              get{return __ASMWD;}
         }
         /// <summary>
         ///设置或获取类中的[ASMDQY]的数据
         /// </summary>
         public string ASMDQY
         {
              set{ __ASMDQY = value.Replace("'","’"); __Changed["ASMDQY"] = true;}
              get{return __ASMDQY;}
         }
         /// <summary>
         ///设置或获取类中的[ASMSD]的数据
         /// </summary>
         public string ASMSD
         {
              set{ __ASMSD = value.Replace("'","’"); __Changed["ASMSD"] = true;}
              get{return __ASMSD;}
         }
         /// <summary>
         ///设置或获取类中的[ASMYW]的数据
         /// </summary>
         public string ASMYW
         {
              set{ __ASMYW = value.Replace("'","’"); __Changed["ASMYW"] = true;}
              get{return __ASMYW;}
         }
         /// <summary>
         ///设置或获取类中的[DSYW]的数据
         /// </summary>
         public string DSYW
         {
              set{ __DSYW = value.Replace("'","’"); __Changed["DSYW"] = true;}
              get{return __DSYW;}
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
         ///设置或获取类中的[DSCO]的数据
         /// </summary>
         public string DSCO
         {
              set{ __DSCO = value.Replace("'","’"); __Changed["DSCO"] = true;}
              get{return __DSCO;}
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
         ///设置或获取类中的[DSCOXZ]的数据
         /// </summary>
         public string DSCOXZ
         {
              set{ __DSCOXZ = value.Replace("'","’"); __Changed["DSCOXZ"] = true;}
              get{return __DSCOXZ;}
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
         ///设置或获取类中的[DSCO_PD]的数据
         /// </summary>
         public string DSCO_PD
         {
              set{ __DSCO_PD = value.Replace("'","’"); __Changed["DSCO_PD"] = true;}
              get{return __DSCO_PD;}
         }
         /// <summary>
         ///设置或获取类中的[GL5025]的数据
         /// </summary>
         public string GL5025
         {
              set{ __GL5025 = value.Replace("'","’"); __Changed["GL5025"] = true;}
              get{return __GL5025;}
         }
         /// <summary>
         ///设置或获取类中的[GL2540]的数据
         /// </summary>
         public string GL2540
         {
              set{ __GL2540 = value.Replace("'","’"); __Changed["GL2540"] = true;}
              get{return __GL2540;}
         }
         /// <summary>
         ///设置或获取类中的[CO25025JG]的数据
         /// </summary>
         public string CO25025JG
         {
              set{ __CO25025JG = value.Replace("'","’"); __Changed["CO25025JG"] = true;}
              get{return __CO25025JG;}
         }
         /// <summary>
         ///设置或获取类中的[CO22540JG]的数据
         /// </summary>
         public string CO22540JG
         {
              set{ __CO22540JG = value.Replace("'","’"); __Changed["CO22540JG"] = true;}
              get{return __CO22540JG;}
         }
         /// <summary>
         ///设置或获取类中的[CO2DSJG]的数据
         /// </summary>
         public string CO2DSJG
         {
              set{ __CO2DSJG = value.Replace("'","’"); __Changed["CO2DSJG"] = true;}
              get{return __CO2DSJG;}
         }
         /// <summary>
         ///设置或获取类中的[O25025JG]的数据
         /// </summary>
         public string O25025JG
         {
              set{ __O25025JG = value.Replace("'","’"); __Changed["O25025JG"] = true;}
              get{return __O25025JG;}
         }
         /// <summary>
         ///设置或获取类中的[O22540JG]的数据
         /// </summary>
         public string O22540JG
         {
              set{ __O22540JG = value.Replace("'","’"); __Changed["O22540JG"] = true;}
              get{return __O22540JG;}
         }
         /// <summary>
         ///设置或获取类中的[O2DSJG]的数据
         /// </summary>
         public string O2DSJG
         {
              set{ __O2DSJG = value.Replace("'","’"); __Changed["O2DSJG"] = true;}
              get{return __O2DSJG;}
         }
         /// <summary>
         ///设置或获取类中的[RPM5025JG]的数据
         /// </summary>
         public string RPM5025JG
         {
              set{ __RPM5025JG = value.Replace("'","’"); __Changed["RPM5025JG"] = true;}
              get{return __RPM5025JG;}
         }
         /// <summary>
         ///设置或获取类中的[RPM2540JG]的数据
         /// </summary>
         public string RPM2540JG
         {
              set{ __RPM2540JG = value.Replace("'","’"); __Changed["RPM2540JG"] = true;}
              get{return __RPM2540JG;}
         }
         /// <summary>
         ///设置或获取类中的[RPMDSJG]的数据
         /// </summary>
         public string RPMDSJG
         {
              set{ __RPMDSJG = value.Replace("'","’"); __Changed["RPMDSJG"] = true;}
              get{return __RPMDSJG;}
         }
         /// <summary>
         ///设置或获取类中的[DSNO]的数据
         /// </summary>
         public string DSNO
         {
              set{ __DSNO = value.Replace("'","’"); __Changed["DSNO"] = true;}
              get{return __DSNO;}
         }
         /// <summary>
         ///设置或获取类中的[NMD5025JG]的数据
         /// </summary>
         public string NMD5025JG
         {
              set{ __NMD5025JG = value.Replace("'","’"); __Changed["NMD5025JG"] = true;}
              get{return __NMD5025JG;}
         }
         /// <summary>
         ///设置或获取类中的[NMD2540JG]的数据
         /// </summary>
         public string NMD2540JG
         {
              set{ __NMD2540JG = value.Replace("'","’"); __Changed["NMD2540JG"] = true;}
              get{return __NMD2540JG;}
         }
         /// <summary>
         ///设置或获取类中的[NMDDSJG]的数据
         /// </summary>
         public string NMDDSJG
         {
              set{ __NMDDSJG = value.Replace("'","’"); __Changed["NMDDSJG"] = true;}
              get{return __NMDDSJG;}
         }
         /// <summary>
         ///设置或获取类中的[OBD5025CODE]的数据
         /// </summary>
         public string OBD5025CODE
         {
              set{ __OBD5025CODE = value.Replace("'","’"); __Changed["OBD5025CODE"] = true;}
              get{return __OBD5025CODE;}
         }
         /// <summary>
         ///设置或获取类中的[OBD2540CODE]的数据
         /// </summary>
         public string OBD2540CODE
         {
              set{ __OBD2540CODE = value.Replace("'","’"); __Changed["OBD2540CODE"] = true;}
              get{return __OBD2540CODE;}
         }
         /// <summary>
         ///设置或获取类中的[CO25025XZ]的数据
         /// </summary>
         public string CO25025XZ
         {
              set{ __CO25025XZ = value.Replace("'","’"); __Changed["CO25025XZ"] = true;}
              get{return __CO25025XZ;}
         }
         /// <summary>
         ///设置或获取类中的[CO22540XZ]的数据
         /// </summary>
         public string CO22540XZ
         {
              set{ __CO22540XZ = value.Replace("'","’"); __Changed["CO22540XZ"] = true;}
              get{return __CO22540XZ;}
         }
         /// <summary>
         ///设置或获取类中的[CO2DSZX]的数据
         /// </summary>
         public string CO2DSZX
         {
              set{ __CO2DSZX = value.Replace("'","’"); __Changed["CO2DSZX"] = true;}
              get{return __CO2DSZX;}
         }
         /// <summary>
         ///设置或获取类中的[O25025XZ]的数据
         /// </summary>
         public string O25025XZ
         {
              set{ __O25025XZ = value.Replace("'","’"); __Changed["O25025XZ"] = true;}
              get{return __O25025XZ;}
         }
         /// <summary>
         ///设置或获取类中的[O22540XZ]的数据
         /// </summary>
         public string O22540XZ
         {
              set{ __O22540XZ = value.Replace("'","’"); __Changed["O22540XZ"] = true;}
              get{return __O22540XZ;}
         }
         /// <summary>
         ///设置或获取类中的[O2DSXZ]的数据
         /// </summary>
         public string O2DSXZ
         {
              set{ __O2DSXZ = value.Replace("'","’"); __Changed["O2DSXZ"] = true;}
              get{return __O2DSXZ;}
         }
         /// <summary>
         ///设置或获取类中的[RPM5025XZ]的数据
         /// </summary>
         public string RPM5025XZ
         {
              set{ __RPM5025XZ = value.Replace("'","’"); __Changed["RPM5025XZ"] = true;}
              get{return __RPM5025XZ;}
         }
         /// <summary>
         ///设置或获取类中的[RPM2540XZ]的数据
         /// </summary>
         public string RPM2540XZ
         {
              set{ __RPM2540XZ = value.Replace("'","’"); __Changed["RPM2540XZ"] = true;}
              get{return __RPM2540XZ;}
         }
         /// <summary>
         ///设置或获取类中的[RPMDSXZ]的数据
         /// </summary>
         public string RPMDSXZ
         {
              set{ __RPMDSXZ = value.Replace("'","’"); __Changed["RPMDSXZ"] = true;}
              get{return __RPMDSXZ;}
         }
         /// <summary>
         ///设置或获取类中的[DSNOXZ]的数据
         /// </summary>
         public string DSNOXZ
         {
              set{ __DSNOXZ = value.Replace("'","’"); __Changed["DSNOXZ"] = true;}
              get{return __DSNOXZ;}
         }
         /// <summary>
         ///设置或获取类中的[NMD5025XZ_MAX]的数据
         /// </summary>
         public string NMD5025XZ_MAX
         {
              set{ __NMD5025XZ_MAX = value.Replace("'","’"); __Changed["NMD5025XZ_MAX"] = true;}
              get{return __NMD5025XZ_MAX;}
         }
         /// <summary>
         ///设置或获取类中的[NMD5025XZ_MIN]的数据
         /// </summary>
         public string NMD5025XZ_MIN
         {
              set{ __NMD5025XZ_MIN = value.Replace("'","’"); __Changed["NMD5025XZ_MIN"] = true;}
              get{return __NMD5025XZ_MIN;}
         }
         /// <summary>
         ///设置或获取类中的[NMD2540XZ_MAX]的数据
         /// </summary>
         public string NMD2540XZ_MAX
         {
              set{ __NMD2540XZ_MAX = value.Replace("'","’"); __Changed["NMD2540XZ_MAX"] = true;}
              get{return __NMD2540XZ_MAX;}
         }
         /// <summary>
         ///设置或获取类中的[NMD2540XZ_MIN]的数据
         /// </summary>
         public string NMD2540XZ_MIN
         {
              set{ __NMD2540XZ_MIN = value.Replace("'","’"); __Changed["NMD2540XZ_MIN"] = true;}
              get{return __NMD2540XZ_MIN;}
         }
         /// <summary>
         ///设置或获取类中的[NMDDSXZ_MAX]的数据
         /// </summary>
         public string NMDDSXZ_MAX
         {
              set{ __NMDDSXZ_MAX = value.Replace("'","’"); __Changed["NMDDSXZ_MAX"] = true;}
              get{return __NMDDSXZ_MAX;}
         }
         /// <summary>
         ///设置或获取类中的[NMDDSXZ_MIN]的数据
         /// </summary>
         public string NMDDSXZ_MIN
         {
              set{ __NMDDSXZ_MIN = value.Replace("'","’"); __Changed["NMDDSXZ_MIN"] = true;}
              get{return __NMDDSXZ_MIN;}
         }
         /// <summary>
         ///设置或获取类中的[OBD5025_PD]的数据
         /// </summary>
         public string OBD5025_PD
         {
              set{ __OBD5025_PD = value.Replace("'","’"); __Changed["OBD5025_PD"] = true;}
              get{return __OBD5025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[OBD2540_PD]的数据
         /// </summary>
         public string OBD2540_PD
         {
              set{ __OBD2540_PD = value.Replace("'","’"); __Changed["OBD2540_PD"] = true;}
              get{return __OBD2540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[CO25025_PD]的数据
         /// </summary>
         public string CO25025_PD
         {
              set{ __CO25025_PD = value.Replace("'","’"); __Changed["CO25025_PD"] = true;}
              get{return __CO25025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[CO22540_PD]的数据
         /// </summary>
         public string CO22540_PD
         {
              set{ __CO22540_PD = value.Replace("'","’"); __Changed["CO22540_PD"] = true;}
              get{return __CO22540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[CO2DS_PD]的数据
         /// </summary>
         public string CO2DS_PD
         {
              set{ __CO2DS_PD = value.Replace("'","’"); __Changed["CO2DS_PD"] = true;}
              get{return __CO2DS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[O25025_PD]的数据
         /// </summary>
         public string O25025_PD
         {
              set{ __O25025_PD = value.Replace("'","’"); __Changed["O25025_PD"] = true;}
              get{return __O25025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[O22540_PD]的数据
         /// </summary>
         public string O22540_PD
         {
              set{ __O22540_PD = value.Replace("'","’"); __Changed["O22540_PD"] = true;}
              get{return __O22540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[O2DS_PD]的数据
         /// </summary>
         public string O2DS_PD
         {
              set{ __O2DS_PD = value.Replace("'","’"); __Changed["O2DS_PD"] = true;}
              get{return __O2DS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[RPM5025_PD]的数据
         /// </summary>
         public string RPM5025_PD
         {
              set{ __RPM5025_PD = value.Replace("'","’"); __Changed["RPM5025_PD"] = true;}
              get{return __RPM5025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[RPM2540_PD]的数据
         /// </summary>
         public string RPM2540_PD
         {
              set{ __RPM2540_PD = value.Replace("'","’"); __Changed["RPM2540_PD"] = true;}
              get{return __RPM2540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[RPMDS_PD]的数据
         /// </summary>
         public string RPMDS_PD
         {
              set{ __RPMDS_PD = value.Replace("'","’"); __Changed["RPMDS_PD"] = true;}
              get{return __RPMDS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[DSNO_PD]的数据
         /// </summary>
         public string DSNO_PD
         {
              set{ __DSNO_PD = value.Replace("'","’"); __Changed["DSNO_PD"] = true;}
              get{return __DSNO_PD;}
         }
         /// <summary>
         ///设置或获取类中的[NMD5025_PD]的数据
         /// </summary>
         public string NMD5025_PD
         {
              set{ __NMD5025_PD = value.Replace("'","’"); __Changed["NMD5025_PD"] = true;}
              get{return __NMD5025_PD;}
         }
         /// <summary>
         ///设置或获取类中的[NMD2540_PD]的数据
         /// </summary>
         public string NMD2540_PD
         {
              set{ __NMD2540_PD = value.Replace("'","’"); __Changed["NMD2540_PD"] = true;}
              get{return __NMD2540_PD;}
         }
         /// <summary>
         ///设置或获取类中的[NMDDS_PD]的数据
         /// </summary>
         public string NMDDS_PD
         {
              set{ __NMDDS_PD = value.Replace("'","’"); __Changed["NMDDS_PD"] = true;}
              get{return __NMDDS_PD;}
         }
         /// <summary>
         ///设置或获取类中的[ASM_DS_PD]的数据
         /// </summary>
         public string ASM_DS_PD
         {
              set{ __ASM_DS_PD = value.Replace("'","’"); __Changed["ASM_DS_PD"] = true;}
              get{return __ASM_DS_PD;}
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
