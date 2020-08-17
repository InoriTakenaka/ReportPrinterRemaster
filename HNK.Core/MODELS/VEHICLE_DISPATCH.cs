using HNK.Infrustracture;
using System.Collections.Generic;
namespace HNK.Core
{
     ///<summary>
     ///实体类VEHICLE_DISPATCH
     ///</summary>
     public class VEHICLE_DISPATCH:Entity
     {
         private int __ID=0;
         private string __VEHICLEID=string.Empty;
         private int? __JCXH=null;
         private string __JCXHMS=string.Empty;
         private string __JCZL=string.Empty;
         private int? __SCJCXH=null;
         private int? __JCZT_STATUS=null;
         private int? __GW_STATUS=null;
         private int? __GWBH=null;
         private string __YJGWH=string.Empty;
         private int? __ZDGWBH=null;
         private int? __JCCS=null;
         private int? __AJJCCS=null;
         private int? __ZJJCCS=null;
         private int? __WJJCCS=null;
         private string __JCLSH=string.Empty;
         private string __JYXM=string.Empty;
         private string __YJXM=string.Empty;
         private string __FJXM=string.Empty;
         private string __JCBGDBH01=string.Empty;
         private string __JCBGDBH02=string.Empty;
         private string __HPHM=string.Empty;
         private string __HPZL=string.Empty;
         private string __HPZLDH=string.Empty;
         private string __GLCHPHM=string.Empty;
         private string __CLZLDH=string.Empty;
         private string __VIN=string.Empty;
         private string __JYLB=string.Empty;
         private string __JYLBDH=string.Empty;
         private string __QDXS=string.Empty;
         private string __QZDZ=string.Empty;
         private string __YGGSNFKT=string.Empty;
         private string __RLLB=string.Empty;
         private string __ZBZL=string.Empty;
         private string __BSXLX=string.Empty;
         private string __CLSXSJ=string.Empty;
         private string __CLXXSJ=string.Empty;
         private string __DLY=string.Empty;
         private string __YCY=string.Empty;
         private string __WGJYY=string.Empty;
         private string __DPJYY=string.Empty;
         private string __DTDPJYY=string.Empty;
         private string __LSJYY=string.Empty;
         private string __SQQZR=string.Empty;
         private string __WQCZY=string.Empty;
         private string __GXRQ=string.Empty;
         private string __JYXM_EX=string.Empty;
         private string __ZZS=string.Empty;
         private string __GLCJCLSH=string.Empty;
         private string __GLCHPZL=string.Empty;
         private string __GLCHPZLDH=string.Empty;
         private string __LWCXWZJL=string.Empty;
         private string __SFSQCLC=string.Empty;
         private string __GLCJYXM=string.Empty;
         private string __LWCXWZJLDH=string.Empty;
         private string __HDZH=string.Empty;
         private string __EDNJGL=string.Empty;
         private string __JZZZWZ=string.Empty;
         private string __FWQ_ZYXZ=string.Empty;
         private string __LWLRLSH=string.Empty;
         private string __LWLRHENF=string.Empty;
         private string __LTGG=string.Empty;
         private string __LTGGLX=string.Empty;
         private string __LTGGLXDH=string.Empty;
         private string __QDZKZZL=string.Empty;
         private string __WQLSH=string.Empty;
         private string __AJLSH=string.Empty;
         private string __ZJLSH=string.Empty;
         private string __MTLSH=string.Empty;
         private string __ZZL=string.Empty;
         private string __MTCSFDJSS=string.Empty;
         private string __MTCSFDJSSDH=string.Empty;
         private string __ZYWLB=string.Empty;
         private string __ZYWLBDH=string.Empty;
         private string __JYLB_TYPE=string.Empty;
         private string __CLSSLB=string.Empty;
         private string __CLSSLBDH=string.Empty;
         private string __SYRSFZ=string.Empty;
         private string __ZJJYRQ=string.Empty;
         private string __BXZZRQ=string.Empty;
         private string __JYYXQZ=string.Empty;
         private string __CLYTDH=string.Empty;
         private string __YTSXDH=string.Empty;
         private string __JYXM_LW=string.Empty;
         private int? __WAIT_LINE=null;
         private string __GCPZH=string.Empty;
         private string __GCLX=string.Empty;
         private string __GCLXDH=string.Empty;
         private string __QYCMZZZL=string.Empty;
         private string __DCZS=string.Empty;
         private string __XZQY=string.Empty;
         private string __ZCLBGD=string.Empty;
         private string __GCLBGD=string.Empty;
         private string __GCCSC=string.Empty;
         private string __GCCSK=string.Empty;
         private string __GCCSG=string.Empty;
         private string __GCBZZXS=string.Empty;
         private string __GCBZZXSDH=string.Empty;
         private string __ZJCLLX=string.Empty;
         private string __ZJCLLXDH=string.Empty;
         private string __SFSWPC=string.Empty;
         private string __DLYSZH=string.Empty;
         private string __SFSGSQC=string.Empty;
         private string __CLCCLX=string.Empty;
         private string __CLCCLXDH=string.Empty;
         private string __DLRQ=string.Empty;
         private string __LED=string.Empty;
         private string __SJZDYH=string.Empty;
         private string __SJZDYH1=string.Empty;
         private string __ZJPZ=string.Empty;
         private string __PFLSH=string.Empty;
         private string __DGSFZXTS=string.Empty;
         private string __DGSFZXTSDH=string.Empty;
         private string __ZDJGL=string.Empty;
         private string __ZJLWZT=string.Empty;
         private string __HPYS=string.Empty;
         private string __SFJMPZ=string.Empty;

         private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


         public VEHICLE_DISPATCH()
         {
             this.__Changed.Add("ID",false);
             this.__Changed.Add("VEHICLEID",false);
             this.__Changed.Add("JCXH",false);
             this.__Changed.Add("JCXHMS",false);
             this.__Changed.Add("JCZL",false);
             this.__Changed.Add("SCJCXH",false);
             this.__Changed.Add("JCZT_STATUS",false);
             this.__Changed.Add("GW_STATUS",false);
             this.__Changed.Add("GWBH",false);
             this.__Changed.Add("YJGWH",false);
             this.__Changed.Add("ZDGWBH",false);
             this.__Changed.Add("JCCS",false);
             this.__Changed.Add("AJJCCS",false);
             this.__Changed.Add("ZJJCCS",false);
             this.__Changed.Add("WJJCCS",false);
             this.__Changed.Add("JCLSH",false);
             this.__Changed.Add("JYXM",false);
             this.__Changed.Add("YJXM",false);
             this.__Changed.Add("FJXM",false);
             this.__Changed.Add("JCBGDBH01",false);
             this.__Changed.Add("JCBGDBH02",false);
             this.__Changed.Add("HPHM",false);
             this.__Changed.Add("HPZL",false);
             this.__Changed.Add("HPZLDH",false);
             this.__Changed.Add("GLCHPHM",false);
             this.__Changed.Add("CLZLDH",false);
             this.__Changed.Add("VIN",false);
             this.__Changed.Add("JYLB",false);
             this.__Changed.Add("JYLBDH",false);
             this.__Changed.Add("QDXS",false);
             this.__Changed.Add("QZDZ",false);
             this.__Changed.Add("YGGSNFKT",false);
             this.__Changed.Add("RLLB",false);
             this.__Changed.Add("ZBZL",false);
             this.__Changed.Add("BSXLX",false);
             this.__Changed.Add("CLSXSJ",false);
             this.__Changed.Add("CLXXSJ",false);
             this.__Changed.Add("DLY",false);
             this.__Changed.Add("YCY",false);
             this.__Changed.Add("WGJYY",false);
             this.__Changed.Add("DPJYY",false);
             this.__Changed.Add("DTDPJYY",false);
             this.__Changed.Add("LSJYY",false);
             this.__Changed.Add("SQQZR",false);
             this.__Changed.Add("WQCZY",false);
             this.__Changed.Add("GXRQ",false);
             this.__Changed.Add("JYXM_EX",false);
             this.__Changed.Add("ZZS",false);
             this.__Changed.Add("GLCJCLSH",false);
             this.__Changed.Add("GLCHPZL",false);
             this.__Changed.Add("GLCHPZLDH",false);
             this.__Changed.Add("LWCXWZJL",false);
             this.__Changed.Add("SFSQCLC",false);
             this.__Changed.Add("GLCJYXM",false);
             this.__Changed.Add("LWCXWZJLDH",false);
             this.__Changed.Add("HDZH",false);
             this.__Changed.Add("EDNJGL",false);
             this.__Changed.Add("JZZZWZ",false);
             this.__Changed.Add("FWQ_ZYXZ",false);
             this.__Changed.Add("LWLRLSH",false);
             this.__Changed.Add("LWLRHENF",false);
             this.__Changed.Add("LTGG",false);
             this.__Changed.Add("LTGGLX",false);
             this.__Changed.Add("LTGGLXDH",false);
             this.__Changed.Add("QDZKZZL",false);
             this.__Changed.Add("WQLSH",false);
             this.__Changed.Add("AJLSH",false);
             this.__Changed.Add("ZJLSH",false);
             this.__Changed.Add("MTLSH",false);
             this.__Changed.Add("ZZL",false);
             this.__Changed.Add("MTCSFDJSS",false);
             this.__Changed.Add("MTCSFDJSSDH",false);
             this.__Changed.Add("ZYWLB",false);
             this.__Changed.Add("ZYWLBDH",false);
             this.__Changed.Add("JYLB_TYPE",false);
             this.__Changed.Add("CLSSLB",false);
             this.__Changed.Add("CLSSLBDH",false);
             this.__Changed.Add("SYRSFZ",false);
             this.__Changed.Add("ZJJYRQ",false);
             this.__Changed.Add("BXZZRQ",false);
             this.__Changed.Add("JYYXQZ",false);
             this.__Changed.Add("CLYTDH",false);
             this.__Changed.Add("YTSXDH",false);
             this.__Changed.Add("JYXM_LW",false);
             this.__Changed.Add("WAIT_LINE",false);
             this.__Changed.Add("GCPZH",false);
             this.__Changed.Add("GCLX",false);
             this.__Changed.Add("GCLXDH",false);
             this.__Changed.Add("QYCMZZZL",false);
             this.__Changed.Add("DCZS",false);
             this.__Changed.Add("XZQY",false);
             this.__Changed.Add("ZCLBGD",false);
             this.__Changed.Add("GCLBGD",false);
             this.__Changed.Add("GCCSC",false);
             this.__Changed.Add("GCCSK",false);
             this.__Changed.Add("GCCSG",false);
             this.__Changed.Add("GCBZZXS",false);
             this.__Changed.Add("GCBZZXSDH",false);
             this.__Changed.Add("ZJCLLX",false);
             this.__Changed.Add("ZJCLLXDH",false);
             this.__Changed.Add("SFSWPC",false);
             this.__Changed.Add("DLYSZH",false);
             this.__Changed.Add("SFSGSQC",false);
             this.__Changed.Add("CLCCLX",false);
             this.__Changed.Add("CLCCLXDH",false);
             this.__Changed.Add("DLRQ",false);
             this.__Changed.Add("LED",false);
             this.__Changed.Add("SJZDYH",false);
             this.__Changed.Add("SJZDYH1",false);
             this.__Changed.Add("ZJPZ",false);
             this.__Changed.Add("PFLSH",false);
             this.__Changed.Add("DGSFZXTS",false);
             this.__Changed.Add("DGSFZXTSDH",false);
             this.__Changed.Add("ZDJGL",false);
             this.__Changed.Add("ZJLWZT",false);
             this.__Changed.Add("HPYS",false);
             this.__Changed.Add("SFJMPZ",false);
         }

         /// <summary>
         /// 将类重置到初始化状态
         /// </summary>
         public void Reset()
         {
             this.__ID =0;
             this.__VEHICLEID =string.Empty;
             this.__JCXH =null;
             this.__JCXHMS =string.Empty;
             this.__JCZL =string.Empty;
             this.__SCJCXH =null;
             this.__JCZT_STATUS =null;
             this.__GW_STATUS =null;
             this.__GWBH =null;
             this.__YJGWH =string.Empty;
             this.__ZDGWBH =null;
             this.__JCCS =null;
             this.__AJJCCS =null;
             this.__ZJJCCS =null;
             this.__WJJCCS =null;
             this.__JCLSH =string.Empty;
             this.__JYXM =string.Empty;
             this.__YJXM =string.Empty;
             this.__FJXM =string.Empty;
             this.__JCBGDBH01 =string.Empty;
             this.__JCBGDBH02 =string.Empty;
             this.__HPHM =string.Empty;
             this.__HPZL =string.Empty;
             this.__HPZLDH =string.Empty;
             this.__GLCHPHM =string.Empty;
             this.__CLZLDH =string.Empty;
             this.__VIN =string.Empty;
             this.__JYLB =string.Empty;
             this.__JYLBDH =string.Empty;
             this.__QDXS =string.Empty;
             this.__QZDZ =string.Empty;
             this.__YGGSNFKT =string.Empty;
             this.__RLLB =string.Empty;
             this.__ZBZL =string.Empty;
             this.__BSXLX =string.Empty;
             this.__CLSXSJ =string.Empty;
             this.__CLXXSJ =string.Empty;
             this.__DLY =string.Empty;
             this.__YCY =string.Empty;
             this.__WGJYY =string.Empty;
             this.__DPJYY =string.Empty;
             this.__DTDPJYY =string.Empty;
             this.__LSJYY =string.Empty;
             this.__SQQZR =string.Empty;
             this.__WQCZY =string.Empty;
             this.__GXRQ =string.Empty;
             this.__JYXM_EX =string.Empty;
             this.__ZZS =string.Empty;
             this.__GLCJCLSH =string.Empty;
             this.__GLCHPZL =string.Empty;
             this.__GLCHPZLDH =string.Empty;
             this.__LWCXWZJL =string.Empty;
             this.__SFSQCLC =string.Empty;
             this.__GLCJYXM =string.Empty;
             this.__LWCXWZJLDH =string.Empty;
             this.__HDZH =string.Empty;
             this.__EDNJGL =string.Empty;
             this.__JZZZWZ =string.Empty;
             this.__FWQ_ZYXZ =string.Empty;
             this.__LWLRLSH =string.Empty;
             this.__LWLRHENF =string.Empty;
             this.__LTGG =string.Empty;
             this.__LTGGLX =string.Empty;
             this.__LTGGLXDH =string.Empty;
             this.__QDZKZZL =string.Empty;
             this.__WQLSH =string.Empty;
             this.__AJLSH =string.Empty;
             this.__ZJLSH =string.Empty;
             this.__MTLSH =string.Empty;
             this.__ZZL =string.Empty;
             this.__MTCSFDJSS =string.Empty;
             this.__MTCSFDJSSDH =string.Empty;
             this.__ZYWLB =string.Empty;
             this.__ZYWLBDH =string.Empty;
             this.__JYLB_TYPE =string.Empty;
             this.__CLSSLB =string.Empty;
             this.__CLSSLBDH =string.Empty;
             this.__SYRSFZ =string.Empty;
             this.__ZJJYRQ =string.Empty;
             this.__BXZZRQ =string.Empty;
             this.__JYYXQZ =string.Empty;
             this.__CLYTDH =string.Empty;
             this.__YTSXDH =string.Empty;
             this.__JYXM_LW =string.Empty;
             this.__WAIT_LINE =null;
             this.__GCPZH =string.Empty;
             this.__GCLX =string.Empty;
             this.__GCLXDH =string.Empty;
             this.__QYCMZZZL =string.Empty;
             this.__DCZS =string.Empty;
             this.__XZQY =string.Empty;
             this.__ZCLBGD =string.Empty;
             this.__GCLBGD =string.Empty;
             this.__GCCSC =string.Empty;
             this.__GCCSK =string.Empty;
             this.__GCCSG =string.Empty;
             this.__GCBZZXS =string.Empty;
             this.__GCBZZXSDH =string.Empty;
             this.__ZJCLLX =string.Empty;
             this.__ZJCLLXDH =string.Empty;
             this.__SFSWPC =string.Empty;
             this.__DLYSZH =string.Empty;
             this.__SFSGSQC =string.Empty;
             this.__CLCCLX =string.Empty;
             this.__CLCCLXDH =string.Empty;
             this.__DLRQ =string.Empty;
             this.__LED =string.Empty;
             this.__SJZDYH =string.Empty;
             this.__SJZDYH1 =string.Empty;
             this.__ZJPZ =string.Empty;
             this.__PFLSH =string.Empty;
             this.__DGSFZXTS =string.Empty;
             this.__DGSFZXTSDH =string.Empty;
             this.__ZDJGL =string.Empty;
             this.__ZJLWZT =string.Empty;
             this.__HPYS =string.Empty;
             this.__SFJMPZ =string.Empty;
             this.__Changed["ID"] = false;
             this.__Changed["VEHICLEID"] = false;
             this.__Changed["JCXH"] = false;
             this.__Changed["JCXHMS"] = false;
             this.__Changed["JCZL"] = false;
             this.__Changed["SCJCXH"] = false;
             this.__Changed["JCZT_STATUS"] = false;
             this.__Changed["GW_STATUS"] = false;
             this.__Changed["GWBH"] = false;
             this.__Changed["YJGWH"] = false;
             this.__Changed["ZDGWBH"] = false;
             this.__Changed["JCCS"] = false;
             this.__Changed["AJJCCS"] = false;
             this.__Changed["ZJJCCS"] = false;
             this.__Changed["WJJCCS"] = false;
             this.__Changed["JCLSH"] = false;
             this.__Changed["JYXM"] = false;
             this.__Changed["YJXM"] = false;
             this.__Changed["FJXM"] = false;
             this.__Changed["JCBGDBH01"] = false;
             this.__Changed["JCBGDBH02"] = false;
             this.__Changed["HPHM"] = false;
             this.__Changed["HPZL"] = false;
             this.__Changed["HPZLDH"] = false;
             this.__Changed["GLCHPHM"] = false;
             this.__Changed["CLZLDH"] = false;
             this.__Changed["VIN"] = false;
             this.__Changed["JYLB"] = false;
             this.__Changed["JYLBDH"] = false;
             this.__Changed["QDXS"] = false;
             this.__Changed["QZDZ"] = false;
             this.__Changed["YGGSNFKT"] = false;
             this.__Changed["RLLB"] = false;
             this.__Changed["ZBZL"] = false;
             this.__Changed["BSXLX"] = false;
             this.__Changed["CLSXSJ"] = false;
             this.__Changed["CLXXSJ"] = false;
             this.__Changed["DLY"] = false;
             this.__Changed["YCY"] = false;
             this.__Changed["WGJYY"] = false;
             this.__Changed["DPJYY"] = false;
             this.__Changed["DTDPJYY"] = false;
             this.__Changed["LSJYY"] = false;
             this.__Changed["SQQZR"] = false;
             this.__Changed["WQCZY"] = false;
             this.__Changed["GXRQ"] = false;
             this.__Changed["JYXM_EX"] = false;
             this.__Changed["ZZS"] = false;
             this.__Changed["GLCJCLSH"] = false;
             this.__Changed["GLCHPZL"] = false;
             this.__Changed["GLCHPZLDH"] = false;
             this.__Changed["LWCXWZJL"] = false;
             this.__Changed["SFSQCLC"] = false;
             this.__Changed["GLCJYXM"] = false;
             this.__Changed["LWCXWZJLDH"] = false;
             this.__Changed["HDZH"] = false;
             this.__Changed["EDNJGL"] = false;
             this.__Changed["JZZZWZ"] = false;
             this.__Changed["FWQ_ZYXZ"] = false;
             this.__Changed["LWLRLSH"] = false;
             this.__Changed["LWLRHENF"] = false;
             this.__Changed["LTGG"] = false;
             this.__Changed["LTGGLX"] = false;
             this.__Changed["LTGGLXDH"] = false;
             this.__Changed["QDZKZZL"] = false;
             this.__Changed["WQLSH"] = false;
             this.__Changed["AJLSH"] = false;
             this.__Changed["ZJLSH"] = false;
             this.__Changed["MTLSH"] = false;
             this.__Changed["ZZL"] = false;
             this.__Changed["MTCSFDJSS"] = false;
             this.__Changed["MTCSFDJSSDH"] = false;
             this.__Changed["ZYWLB"] = false;
             this.__Changed["ZYWLBDH"] = false;
             this.__Changed["JYLB_TYPE"] = false;
             this.__Changed["CLSSLB"] = false;
             this.__Changed["CLSSLBDH"] = false;
             this.__Changed["SYRSFZ"] = false;
             this.__Changed["ZJJYRQ"] = false;
             this.__Changed["BXZZRQ"] = false;
             this.__Changed["JYYXQZ"] = false;
             this.__Changed["CLYTDH"] = false;
             this.__Changed["YTSXDH"] = false;
             this.__Changed["JYXM_LW"] = false;
             this.__Changed["WAIT_LINE"] = false;
             this.__Changed["GCPZH"] = false;
             this.__Changed["GCLX"] = false;
             this.__Changed["GCLXDH"] = false;
             this.__Changed["QYCMZZZL"] = false;
             this.__Changed["DCZS"] = false;
             this.__Changed["XZQY"] = false;
             this.__Changed["ZCLBGD"] = false;
             this.__Changed["GCLBGD"] = false;
             this.__Changed["GCCSC"] = false;
             this.__Changed["GCCSK"] = false;
             this.__Changed["GCCSG"] = false;
             this.__Changed["GCBZZXS"] = false;
             this.__Changed["GCBZZXSDH"] = false;
             this.__Changed["ZJCLLX"] = false;
             this.__Changed["ZJCLLXDH"] = false;
             this.__Changed["SFSWPC"] = false;
             this.__Changed["DLYSZH"] = false;
             this.__Changed["SFSGSQC"] = false;
             this.__Changed["CLCCLX"] = false;
             this.__Changed["CLCCLXDH"] = false;
             this.__Changed["DLRQ"] = false;
             this.__Changed["LED"] = false;
             this.__Changed["SJZDYH"] = false;
             this.__Changed["SJZDYH1"] = false;
             this.__Changed["ZJPZ"] = false;
             this.__Changed["PFLSH"] = false;
             this.__Changed["DGSFZXTS"] = false;
             this.__Changed["DGSFZXTSDH"] = false;
             this.__Changed["ZDJGL"] = false;
             this.__Changed["ZJLWZT"] = false;
             this.__Changed["HPYS"] = false;
             this.__Changed["SFJMPZ"] = false;
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
         ///设置或获取类中的[VEHICLEID]的数据
         /// </summary>
         public string VEHICLEID
         {
              set{ __VEHICLEID = value.Replace("'","’"); __Changed["VEHICLEID"] = true;}
              get{return __VEHICLEID;}
         }
         /// <summary>
         ///设置或获取类中的[JCXH]的数据
         /// </summary>
         public int? JCXH
         {
              set{ __JCXH = value; __Changed["JCXH"] = true;}
              get{return __JCXH;}
         }
         /// <summary>
         ///设置或获取类中的[JCXHMS]的数据
         /// </summary>
         public string JCXHMS
         {
              set{ __JCXHMS = value.Replace("'","’"); __Changed["JCXHMS"] = true;}
              get{return __JCXHMS;}
         }
         /// <summary>
         ///设置或获取类中的[JCZL]的数据
         /// </summary>
         public string JCZL
         {
              set{ __JCZL = value.Replace("'","’"); __Changed["JCZL"] = true;}
              get{return __JCZL;}
         }
         /// <summary>
         ///设置或获取类中的[SCJCXH]的数据
         /// </summary>
         public int? SCJCXH
         {
              set{ __SCJCXH = value; __Changed["SCJCXH"] = true;}
              get{return __SCJCXH;}
         }
         /// <summary>
         ///设置或获取类中的[JCZT_STATUS]的数据
         /// </summary>
         public int? JCZT_STATUS
         {
              set{ __JCZT_STATUS = value; __Changed["JCZT_STATUS"] = true;}
              get{return __JCZT_STATUS;}
         }
         /// <summary>
         ///设置或获取类中的[GW_STATUS]的数据
         /// </summary>
         public int? GW_STATUS
         {
              set{ __GW_STATUS = value; __Changed["GW_STATUS"] = true;}
              get{return __GW_STATUS;}
         }
         /// <summary>
         ///设置或获取类中的[GWBH]的数据
         /// </summary>
         public int? GWBH
         {
              set{ __GWBH = value; __Changed["GWBH"] = true;}
              get{return __GWBH;}
         }
         /// <summary>
         ///设置或获取类中的[YJGWH]的数据
         /// </summary>
         public string YJGWH
         {
              set{ __YJGWH = value.Replace("'","’"); __Changed["YJGWH"] = true;}
              get{return __YJGWH;}
         }
         /// <summary>
         ///设置或获取类中的[ZDGWBH]的数据
         /// </summary>
         public int? ZDGWBH
         {
              set{ __ZDGWBH = value; __Changed["ZDGWBH"] = true;}
              get{return __ZDGWBH;}
         }
         /// <summary>
         ///设置或获取类中的[JCCS]的数据
         /// </summary>
         public int? JCCS
         {
              set{ __JCCS = value; __Changed["JCCS"] = true;}
              get{return __JCCS;}
         }
         /// <summary>
         ///设置或获取类中的[安检检测次数]的数据
         /// </summary>
         public int? AJJCCS
         {
              set{ __AJJCCS = value; __Changed["AJJCCS"] = true;}
              get{return __AJJCCS;}
         }
         /// <summary>
         ///设置或获取类中的[综检检测次数]的数据
         /// </summary>
         public int? ZJJCCS
         {
              set{ __ZJJCCS = value; __Changed["ZJJCCS"] = true;}
              get{return __ZJJCCS;}
         }
         /// <summary>
         ///设置或获取类中的[排放检测次数]的数据
         /// </summary>
         public int? WJJCCS
         {
              set{ __WJJCCS = value; __Changed["WJJCCS"] = true;}
              get{return __WJJCCS;}
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
         ///设置或获取类中的[JYXM]的数据
         /// </summary>
         public string JYXM
         {
              set{ __JYXM = value.Replace("'","’"); __Changed["JYXM"] = true;}
              get{return __JYXM;}
         }
         /// <summary>
         ///设置或获取类中的[YJXM]的数据
         /// </summary>
         public string YJXM
         {
              set{ __YJXM = value.Replace("'","’"); __Changed["YJXM"] = true;}
              get{return __YJXM;}
         }
         /// <summary>
         ///设置或获取类中的[FJXM]的数据
         /// </summary>
         public string FJXM
         {
              set{ __FJXM = value.Replace("'","’"); __Changed["FJXM"] = true;}
              get{return __FJXM;}
         }
         /// <summary>
         ///设置或获取类中的[JCBGDBH01]的数据
         /// </summary>
         public string JCBGDBH01
         {
              set{ __JCBGDBH01 = value.Replace("'","’"); __Changed["JCBGDBH01"] = true;}
              get{return __JCBGDBH01;}
         }
         /// <summary>
         ///设置或获取类中的[JCBGDBH02]的数据
         /// </summary>
         public string JCBGDBH02
         {
              set{ __JCBGDBH02 = value.Replace("'","’"); __Changed["JCBGDBH02"] = true;}
              get{return __JCBGDBH02;}
         }
         /// <summary>
         ///设置或获取类中的[HPHM]的数据
         /// </summary>
         public string HPHM
         {
              set{ __HPHM = value.Replace("'","’"); __Changed["HPHM"] = true;}
              get{return __HPHM;}
         }
         /// <summary>
         ///设置或获取类中的[HPZL]的数据
         /// </summary>
         public string HPZL
         {
              set{ __HPZL = value.Replace("'","’"); __Changed["HPZL"] = true;}
              get{return __HPZL;}
         }
         /// <summary>
         ///设置或获取类中的[HPZLDH]的数据
         /// </summary>
         public string HPZLDH
         {
              set{ __HPZLDH = value.Replace("'","’"); __Changed["HPZLDH"] = true;}
              get{return __HPZLDH;}
         }
         /// <summary>
         ///设置或获取类中的[GLCHPHM]的数据
         /// </summary>
         public string GLCHPHM
         {
              set{ __GLCHPHM = value.Replace("'","’"); __Changed["GLCHPHM"] = true;}
              get{return __GLCHPHM;}
         }
         /// <summary>
         ///设置或获取类中的[CLZLDH]的数据
         /// </summary>
         public string CLZLDH
         {
              set{ __CLZLDH = value.Replace("'","’"); __Changed["CLZLDH"] = true;}
              get{return __CLZLDH;}
         }
         /// <summary>
         ///设置或获取类中的[VIN]的数据
         /// </summary>
         public string VIN
         {
              set{ __VIN = value.Replace("'","’"); __Changed["VIN"] = true;}
              get{return __VIN;}
         }
         /// <summary>
         ///设置或获取类中的[JYLB]的数据
         /// </summary>
         public string JYLB
         {
              set{ __JYLB = value.Replace("'","’"); __Changed["JYLB"] = true;}
              get{return __JYLB;}
         }
         /// <summary>
         ///设置或获取类中的[JYLBDH]的数据
         /// </summary>
         public string JYLBDH
         {
              set{ __JYLBDH = value.Replace("'","’"); __Changed["JYLBDH"] = true;}
              get{return __JYLBDH;}
         }
         /// <summary>
         ///设置或获取类中的[QDXS]的数据
         /// </summary>
         public string QDXS
         {
              set{ __QDXS = value.Replace("'","’"); __Changed["QDXS"] = true;}
              get{return __QDXS;}
         }
         /// <summary>
         ///设置或获取类中的[QZDZ]的数据
         /// </summary>
         public string QZDZ
         {
              set{ __QZDZ = value.Replace("'","’"); __Changed["QZDZ"] = true;}
              get{return __QZDZ;}
         }
         /// <summary>
         ///设置或获取类中的[YGGSNFKT]的数据
         /// </summary>
         public string YGGSNFKT
         {
              set{ __YGGSNFKT = value.Replace("'","’"); __Changed["YGGSNFKT"] = true;}
              get{return __YGGSNFKT;}
         }
         /// <summary>
         ///设置或获取类中的[RLLB]的数据
         /// </summary>
         public string RLLB
         {
              set{ __RLLB = value.Replace("'","’"); __Changed["RLLB"] = true;}
              get{return __RLLB;}
         }
         /// <summary>
         ///设置或获取类中的[ZBZL]的数据
         /// </summary>
         public string ZBZL
         {
              set{ __ZBZL = value.Replace("'","’"); __Changed["ZBZL"] = true;}
              get{return __ZBZL;}
         }
         /// <summary>
         ///设置或获取类中的[BSXLX]的数据
         /// </summary>
         public string BSXLX
         {
              set{ __BSXLX = value.Replace("'","’"); __Changed["BSXLX"] = true;}
              get{return __BSXLX;}
         }
         /// <summary>
         ///设置或获取类中的[CLSXSJ]的数据
         /// </summary>
         public string CLSXSJ
         {
              set{ __CLSXSJ = value.Replace("'","’"); __Changed["CLSXSJ"] = true;}
              get{return __CLSXSJ;}
         }
         /// <summary>
         ///设置或获取类中的[CLXXSJ]的数据
         /// </summary>
         public string CLXXSJ
         {
              set{ __CLXXSJ = value.Replace("'","’"); __Changed["CLXXSJ"] = true;}
              get{return __CLXXSJ;}
         }
         /// <summary>
         ///设置或获取类中的[DLY]的数据
         /// </summary>
         public string DLY
         {
              set{ __DLY = value.Replace("'","’"); __Changed["DLY"] = true;}
              get{return __DLY;}
         }
         /// <summary>
         ///设置或获取类中的[YCY]的数据
         /// </summary>
         public string YCY
         {
              set{ __YCY = value.Replace("'","’"); __Changed["YCY"] = true;}
              get{return __YCY;}
         }
         /// <summary>
         ///设置或获取类中的[WGJYY]的数据
         /// </summary>
         public string WGJYY
         {
              set{ __WGJYY = value.Replace("'","’"); __Changed["WGJYY"] = true;}
              get{return __WGJYY;}
         }
         /// <summary>
         ///设置或获取类中的[DPJYY]的数据
         /// </summary>
         public string DPJYY
         {
              set{ __DPJYY = value.Replace("'","’"); __Changed["DPJYY"] = true;}
              get{return __DPJYY;}
         }
         /// <summary>
         ///设置或获取类中的[DTDPJYY]的数据
         /// </summary>
         public string DTDPJYY
         {
              set{ __DTDPJYY = value.Replace("'","’"); __Changed["DTDPJYY"] = true;}
              get{return __DTDPJYY;}
         }
         /// <summary>
         ///设置或获取类中的[LSJYY]的数据
         /// </summary>
         public string LSJYY
         {
              set{ __LSJYY = value.Replace("'","’"); __Changed["LSJYY"] = true;}
              get{return __LSJYY;}
         }
         /// <summary>
         ///设置或获取类中的[SQQZR]的数据
         /// </summary>
         public string SQQZR
         {
              set{ __SQQZR = value.Replace("'","’"); __Changed["SQQZR"] = true;}
              get{return __SQQZR;}
         }
         /// <summary>
         ///设置或获取类中的[WQCZY]的数据
         /// </summary>
         public string WQCZY
         {
              set{ __WQCZY = value.Replace("'","’"); __Changed["WQCZY"] = true;}
              get{return __WQCZY;}
         }
         /// <summary>
         ///设置或获取类中的[GXRQ]的数据
         /// </summary>
         public string GXRQ
         {
              set{ __GXRQ = value.Replace("'","’"); __Changed["GXRQ"] = true;}
              get{return __GXRQ;}
         }
         /// <summary>
         ///设置或获取类中的[JYXM_EX]的数据
         /// </summary>
         public string JYXM_EX
         {
              set{ __JYXM_EX = value.Replace("'","’"); __Changed["JYXM_EX"] = true;}
              get{return __JYXM_EX;}
         }
         /// <summary>
         ///设置或获取类中的[ZZS]的数据
         /// </summary>
         public string ZZS
         {
              set{ __ZZS = value.Replace("'","’"); __Changed["ZZS"] = true;}
              get{return __ZZS;}
         }
         /// <summary>
         ///设置或获取类中的[GLCJCLSH]的数据
         /// </summary>
         public string GLCJCLSH
         {
              set{ __GLCJCLSH = value.Replace("'","’"); __Changed["GLCJCLSH"] = true;}
              get{return __GLCJCLSH;}
         }
         /// <summary>
         ///设置或获取类中的[GLCHPZL]的数据
         /// </summary>
         public string GLCHPZL
         {
              set{ __GLCHPZL = value.Replace("'","’"); __Changed["GLCHPZL"] = true;}
              get{return __GLCHPZL;}
         }
         /// <summary>
         ///设置或获取类中的[GLCHPZLDH]的数据
         /// </summary>
         public string GLCHPZLDH
         {
              set{ __GLCHPZLDH = value.Replace("'","’"); __Changed["GLCHPZLDH"] = true;}
              get{return __GLCHPZLDH;}
         }
         /// <summary>
         ///设置或获取类中的[LWCXWZJL]的数据
         /// </summary>
         public string LWCXWZJL
         {
              set{ __LWCXWZJL = value.Replace("'","’"); __Changed["LWCXWZJL"] = true;}
              get{return __LWCXWZJL;}
         }
         /// <summary>
         ///设置或获取类中的[SFSQCLC]的数据
         /// </summary>
         public string SFSQCLC
         {
              set{ __SFSQCLC = value.Replace("'","’"); __Changed["SFSQCLC"] = true;}
              get{return __SFSQCLC;}
         }
         /// <summary>
         ///设置或获取类中的[GLCJYXM]的数据
         /// </summary>
         public string GLCJYXM
         {
              set{ __GLCJYXM = value.Replace("'","’"); __Changed["GLCJYXM"] = true;}
              get{return __GLCJYXM;}
         }
         /// <summary>
         ///设置或获取类中的[LWCXWZJLDH]的数据
         /// </summary>
         public string LWCXWZJLDH
         {
              set{ __LWCXWZJLDH = value.Replace("'","’"); __Changed["LWCXWZJLDH"] = true;}
              get{return __LWCXWZJLDH;}
         }
         /// <summary>
         ///设置或获取类中的[HDZH]的数据
         /// </summary>
         public string HDZH
         {
              set{ __HDZH = value.Replace("'","’"); __Changed["HDZH"] = true;}
              get{return __HDZH;}
         }
         /// <summary>
         ///设置或获取类中的[EDNJGL]的数据
         /// </summary>
         public string EDNJGL
         {
              set{ __EDNJGL = value.Replace("'","’"); __Changed["EDNJGL"] = true;}
              get{return __EDNJGL;}
         }
         /// <summary>
         ///设置或获取类中的[JZZZWZ]的数据
         /// </summary>
         public string JZZZWZ
         {
              set{ __JZZZWZ = value.Replace("'","’"); __Changed["JZZZWZ"] = true;}
              get{return __JZZZWZ;}
         }
         /// <summary>
         ///设置或获取类中的[FWQ_ZYXZ]的数据
         /// </summary>
         public string FWQ_ZYXZ
         {
              set{ __FWQ_ZYXZ = value.Replace("'","’"); __Changed["FWQ_ZYXZ"] = true;}
              get{return __FWQ_ZYXZ;}
         }
         /// <summary>
         ///设置或获取类中的[LWLRLSH]的数据
         /// </summary>
         public string LWLRLSH
         {
              set{ __LWLRLSH = value.Replace("'","’"); __Changed["LWLRLSH"] = true;}
              get{return __LWLRLSH;}
         }
         /// <summary>
         ///设置或获取类中的[LWLRHENF]的数据
         /// </summary>
         public string LWLRHENF
         {
              set{ __LWLRHENF = value.Replace("'","’"); __Changed["LWLRHENF"] = true;}
              get{return __LWLRHENF;}
         }
         /// <summary>
         ///设置或获取类中的[LTGG]的数据
         /// </summary>
         public string LTGG
         {
              set{ __LTGG = value.Replace("'","’"); __Changed["LTGG"] = true;}
              get{return __LTGG;}
         }
         /// <summary>
         ///设置或获取类中的[LTGGLX]的数据
         /// </summary>
         public string LTGGLX
         {
              set{ __LTGGLX = value.Replace("'","’"); __Changed["LTGGLX"] = true;}
              get{return __LTGGLX;}
         }
         /// <summary>
         ///设置或获取类中的[LTGGLXDH]的数据
         /// </summary>
         public string LTGGLXDH
         {
              set{ __LTGGLXDH = value.Replace("'","’"); __Changed["LTGGLXDH"] = true;}
              get{return __LTGGLXDH;}
         }
         /// <summary>
         ///设置或获取类中的[QDZKZZL]的数据
         /// </summary>
         public string QDZKZZL
         {
              set{ __QDZKZZL = value.Replace("'","’"); __Changed["QDZKZZL"] = true;}
              get{return __QDZKZZL;}
         }
         /// <summary>
         ///设置或获取类中的[WQLSH]的数据
         /// </summary>
         public string WQLSH
         {
              set{ __WQLSH = value.Replace("'","’"); __Changed["WQLSH"] = true;}
              get{return __WQLSH;}
         }
         /// <summary>
         ///设置或获取类中的[AJLSH]的数据
         /// </summary>
         public string AJLSH
         {
              set{ __AJLSH = value.Replace("'","’"); __Changed["AJLSH"] = true;}
              get{return __AJLSH;}
         }
         /// <summary>
         ///设置或获取类中的[ZJLSH]的数据
         /// </summary>
         public string ZJLSH
         {
              set{ __ZJLSH = value.Replace("'","’"); __Changed["ZJLSH"] = true;}
              get{return __ZJLSH;}
         }
         /// <summary>
         ///设置或获取类中的[MTLSH]的数据
         /// </summary>
         public string MTLSH
         {
              set{ __MTLSH = value.Replace("'","’"); __Changed["MTLSH"] = true;}
              get{return __MTLSH;}
         }
         /// <summary>
         ///设置或获取类中的[ZZL]的数据
         /// </summary>
         public string ZZL
         {
              set{ __ZZL = value.Replace("'","’"); __Changed["ZZL"] = true;}
              get{return __ZZL;}
         }
         /// <summary>
         ///设置或获取类中的[MTCSFDJSS]的数据
         /// </summary>
         public string MTCSFDJSS
         {
              set{ __MTCSFDJSS = value.Replace("'","’"); __Changed["MTCSFDJSS"] = true;}
              get{return __MTCSFDJSS;}
         }
         /// <summary>
         ///设置或获取类中的[MTCSFDJSSDH]的数据
         /// </summary>
         public string MTCSFDJSSDH
         {
              set{ __MTCSFDJSSDH = value.Replace("'","’"); __Changed["MTCSFDJSSDH"] = true;}
              get{return __MTCSFDJSSDH;}
         }
         /// <summary>
         ///设置或获取类中的[ZYWLB]的数据
         /// </summary>
         public string ZYWLB
         {
              set{ __ZYWLB = value.Replace("'","’"); __Changed["ZYWLB"] = true;}
              get{return __ZYWLB;}
         }
         /// <summary>
         ///设置或获取类中的[ZYWLBDH]的数据
         /// </summary>
         public string ZYWLBDH
         {
              set{ __ZYWLBDH = value.Replace("'","’"); __Changed["ZYWLBDH"] = true;}
              get{return __ZYWLBDH;}
         }
         /// <summary>
         ///设置或获取类中的[JYLB_TYPE]的数据
         /// </summary>
         public string JYLB_TYPE
         {
              set{ __JYLB_TYPE = value.Replace("'","’"); __Changed["JYLB_TYPE"] = true;}
              get{return __JYLB_TYPE;}
         }
         /// <summary>
         ///设置或获取类中的[CLSSLB]的数据
         /// </summary>
         public string CLSSLB
         {
              set{ __CLSSLB = value.Replace("'","’"); __Changed["CLSSLB"] = true;}
              get{return __CLSSLB;}
         }
         /// <summary>
         ///设置或获取类中的[CLSSLBDH]的数据
         /// </summary>
         public string CLSSLBDH
         {
              set{ __CLSSLBDH = value.Replace("'","’"); __Changed["CLSSLBDH"] = true;}
              get{return __CLSSLBDH;}
         }
         /// <summary>
         ///设置或获取类中的[SYRSFZ]的数据
         /// </summary>
         public string SYRSFZ
         {
              set{ __SYRSFZ = value.Replace("'","’"); __Changed["SYRSFZ"] = true;}
              get{return __SYRSFZ;}
         }
         /// <summary>
         ///设置或获取类中的[ZJJYRQ]的数据
         /// </summary>
         public string ZJJYRQ
         {
              set{ __ZJJYRQ = value.Replace("'","’"); __Changed["ZJJYRQ"] = true;}
              get{return __ZJJYRQ;}
         }
         /// <summary>
         ///设置或获取类中的[BXZZRQ]的数据
         /// </summary>
         public string BXZZRQ
         {
              set{ __BXZZRQ = value.Replace("'","’"); __Changed["BXZZRQ"] = true;}
              get{return __BXZZRQ;}
         }
         /// <summary>
         ///设置或获取类中的[JYYXQZ]的数据
         /// </summary>
         public string JYYXQZ
         {
              set{ __JYYXQZ = value.Replace("'","’"); __Changed["JYYXQZ"] = true;}
              get{return __JYYXQZ;}
         }
         /// <summary>
         ///设置或获取类中的[CLYTDH]的数据
         /// </summary>
         public string CLYTDH
         {
              set{ __CLYTDH = value.Replace("'","’"); __Changed["CLYTDH"] = true;}
              get{return __CLYTDH;}
         }
         /// <summary>
         ///设置或获取类中的[YTSXDH]的数据
         /// </summary>
         public string YTSXDH
         {
              set{ __YTSXDH = value.Replace("'","’"); __Changed["YTSXDH"] = true;}
              get{return __YTSXDH;}
         }
         /// <summary>
         ///设置或获取类中的[JYXM_LW]的数据
         /// </summary>
         public string JYXM_LW
         {
              set{ __JYXM_LW = value.Replace("'","’"); __Changed["JYXM_LW"] = true;}
              get{return __JYXM_LW;}
         }
         /// <summary>
         ///设置或获取类中的[WAIT_LINE]的数据
         /// </summary>
         public int? WAIT_LINE
         {
              set{ __WAIT_LINE = value; __Changed["WAIT_LINE"] = true;}
              get{return __WAIT_LINE;}
         }
         /// <summary>
         ///设置或获取类中的[GCPZH]的数据
         /// </summary>
         public string GCPZH
         {
              set{ __GCPZH = value.Replace("'","’"); __Changed["GCPZH"] = true;}
              get{return __GCPZH;}
         }
         /// <summary>
         ///设置或获取类中的[GCLX]的数据
         /// </summary>
         public string GCLX
         {
              set{ __GCLX = value.Replace("'","’"); __Changed["GCLX"] = true;}
              get{return __GCLX;}
         }
         /// <summary>
         ///设置或获取类中的[GCLXDH]的数据
         /// </summary>
         public string GCLXDH
         {
              set{ __GCLXDH = value.Replace("'","’"); __Changed["GCLXDH"] = true;}
              get{return __GCLXDH;}
         }
         /// <summary>
         ///设置或获取类中的[QYCMZZZL]的数据
         /// </summary>
         public string QYCMZZZL
         {
              set{ __QYCMZZZL = value.Replace("'","’"); __Changed["QYCMZZZL"] = true;}
              get{return __QYCMZZZL;}
         }
         /// <summary>
         ///设置或获取类中的[DCZS]的数据
         /// </summary>
         public string DCZS
         {
              set{ __DCZS = value.Replace("'","’"); __Changed["DCZS"] = true;}
              get{return __DCZS;}
         }
         /// <summary>
         ///设置或获取类中的[XZQY]的数据
         /// </summary>
         public string XZQY
         {
              set{ __XZQY = value.Replace("'","’"); __Changed["XZQY"] = true;}
              get{return __XZQY;}
         }
         /// <summary>
         ///设置或获取类中的[ZCLBGD]的数据
         /// </summary>
         public string ZCLBGD
         {
              set{ __ZCLBGD = value.Replace("'","’"); __Changed["ZCLBGD"] = true;}
              get{return __ZCLBGD;}
         }
         /// <summary>
         ///设置或获取类中的[GCLBGD]的数据
         /// </summary>
         public string GCLBGD
         {
              set{ __GCLBGD = value.Replace("'","’"); __Changed["GCLBGD"] = true;}
              get{return __GCLBGD;}
         }
         /// <summary>
         ///设置或获取类中的[GCCSC]的数据
         /// </summary>
         public string GCCSC
         {
              set{ __GCCSC = value.Replace("'","’"); __Changed["GCCSC"] = true;}
              get{return __GCCSC;}
         }
         /// <summary>
         ///设置或获取类中的[GCCSK]的数据
         /// </summary>
         public string GCCSK
         {
              set{ __GCCSK = value.Replace("'","’"); __Changed["GCCSK"] = true;}
              get{return __GCCSK;}
         }
         /// <summary>
         ///设置或获取类中的[GCCSG]的数据
         /// </summary>
         public string GCCSG
         {
              set{ __GCCSG = value.Replace("'","’"); __Changed["GCCSG"] = true;}
              get{return __GCCSG;}
         }
         /// <summary>
         ///设置或获取类中的[GCBZZXS]的数据
         /// </summary>
         public string GCBZZXS
         {
              set{ __GCBZZXS = value.Replace("'","’"); __Changed["GCBZZXS"] = true;}
              get{return __GCBZZXS;}
         }
         /// <summary>
         ///设置或获取类中的[GCBZZXSDH]的数据
         /// </summary>
         public string GCBZZXSDH
         {
              set{ __GCBZZXSDH = value.Replace("'","’"); __Changed["GCBZZXSDH"] = true;}
              get{return __GCBZZXSDH;}
         }
         /// <summary>
         ///设置或获取类中的[ZJCLLX]的数据
         /// </summary>
         public string ZJCLLX
         {
              set{ __ZJCLLX = value.Replace("'","’"); __Changed["ZJCLLX"] = true;}
              get{return __ZJCLLX;}
         }
         /// <summary>
         ///设置或获取类中的[ZJCLLXDH]的数据
         /// </summary>
         public string ZJCLLXDH
         {
              set{ __ZJCLLXDH = value.Replace("'","’"); __Changed["ZJCLLXDH"] = true;}
              get{return __ZJCLLXDH;}
         }
         /// <summary>
         ///设置或获取类中的[SFSWPC]的数据
         /// </summary>
         public string SFSWPC
         {
              set{ __SFSWPC = value.Replace("'","’"); __Changed["SFSWPC"] = true;}
              get{return __SFSWPC;}
         }
         /// <summary>
         ///设置或获取类中的[DLYSZH]的数据
         /// </summary>
         public string DLYSZH
         {
              set{ __DLYSZH = value.Replace("'","’"); __Changed["DLYSZH"] = true;}
              get{return __DLYSZH;}
         }
         /// <summary>
         ///设置或获取类中的[SFSGSQC]的数据
         /// </summary>
         public string SFSGSQC
         {
              set{ __SFSGSQC = value.Replace("'","’"); __Changed["SFSGSQC"] = true;}
              get{return __SFSGSQC;}
         }
         /// <summary>
         ///设置或获取类中的[CLCCLX]的数据
         /// </summary>
         public string CLCCLX
         {
              set{ __CLCCLX = value.Replace("'","’"); __Changed["CLCCLX"] = true;}
              get{return __CLCCLX;}
         }
         /// <summary>
         ///设置或获取类中的[CLCCLXDH]的数据
         /// </summary>
         public string CLCCLXDH
         {
              set{ __CLCCLXDH = value.Replace("'","’"); __Changed["CLCCLXDH"] = true;}
              get{return __CLCCLXDH;}
         }
         /// <summary>
         ///设置或获取类中的[DLRQ]的数据
         /// </summary>
         public string DLRQ
         {
              set{ __DLRQ = value.Replace("'","’"); __Changed["DLRQ"] = true;}
              get{return __DLRQ;}
         }
         /// <summary>
         ///设置或获取类中的[LED]的数据
         /// </summary>
         public string LED
         {
              set{ __LED = value.Replace("'","’"); __Changed["LED"] = true;}
              get{return __LED;}
         }
         /// <summary>
         ///设置或获取类中的[SJZDYH]的数据
         /// </summary>
         public string SJZDYH
         {
              set{ __SJZDYH = value.Replace("'","’"); __Changed["SJZDYH"] = true;}
              get{return __SJZDYH;}
         }
         /// <summary>
         ///设置或获取类中的[SJZDYH1]的数据
         /// </summary>
         public string SJZDYH1
         {
              set{ __SJZDYH1 = value.Replace("'","’"); __Changed["SJZDYH1"] = true;}
              get{return __SJZDYH1;}
         }
         /// <summary>
         ///设置或获取类中的[ZJPZ]的数据
         /// </summary>
         public string ZJPZ
         {
              set{ __ZJPZ = value.Replace("'","’"); __Changed["ZJPZ"] = true;}
              get{return __ZJPZ;}
         }
         /// <summary>
         ///设置或获取类中的[PFLSH]的数据
         /// </summary>
         public string PFLSH
         {
              set{ __PFLSH = value.Replace("'","’"); __Changed["PFLSH"] = true;}
              get{return __PFLSH;}
         }
         /// <summary>
         ///设置或获取类中的[DGSFZXTS]的数据
         /// </summary>
         public string DGSFZXTS
         {
              set{ __DGSFZXTS = value.Replace("'","’"); __Changed["DGSFZXTS"] = true;}
              get{return __DGSFZXTS;}
         }
         /// <summary>
         ///设置或获取类中的[DGSFZXTSDH]的数据
         /// </summary>
         public string DGSFZXTSDH
         {
              set{ __DGSFZXTSDH = value.Replace("'","’"); __Changed["DGSFZXTSDH"] = true;}
              get{return __DGSFZXTSDH;}
         }
         /// <summary>
         ///设置或获取类中的[ZDJGL]的数据
         /// </summary>
         public string ZDJGL
         {
              set{ __ZDJGL = value.Replace("'","’"); __Changed["ZDJGL"] = true;}
              get{return __ZDJGL;}
         }
         /// <summary>
         ///设置或获取类中的[综检联网状态]的数据
         /// </summary>
         public string ZJLWZT
         {
              set{ __ZJLWZT = value.Replace("'","’"); __Changed["ZJLWZT"] = true;}
              get{return __ZJLWZT;}
         }
         /// <summary>
         ///设置或获取类中的[HPYS]的数据
         /// </summary>
         public string HPYS
         {
              set{ __HPYS = value.Replace("'","’"); __Changed["HPYS"] = true;}
              get{return __HPYS;}
         }
         /// <summary>
         ///设置或获取类中的[是否进门拍照（1,拍照 0 不拍照）]的数据
         /// </summary>
         public string SFJMPZ
         {
              set{ __SFJMPZ = value.Replace("'","’"); __Changed["SFJMPZ"] = true;}
              get{return __SFJMPZ;}
         }
    }
}
