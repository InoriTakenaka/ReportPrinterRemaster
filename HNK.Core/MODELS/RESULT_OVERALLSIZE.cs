using HNK.Infrustracture;
using System.Collections.Generic;
namespace HNK.Core
{
     ///<summary>
     ///实体类RESULT_OVERALLSIZE
     ///</summary>
     public class RESULT_OVERALLSIZE:Entity
     {
         private int __ID=0;
         private string __WKCCJCCS=string.Empty;
         private string __JCLSH=string.Empty;
         private string __ZCSCWKCCGD=string.Empty;
         private string __ZCSCWKCCGDCZ=string.Empty;
         private string __ZCSCWKCCKD=string.Empty;
         private string __ZCSCWKCCKDCZ=string.Empty;
         private string __ZCSCWKCCCD=string.Empty;
         private string __ZCSCWKCCCDCZ=string.Empty;
         private string __ZCWKCC_PD=string.Empty;
         private string __HXSCWKCCGD=string.Empty;
         private string __HXSCWKCCGDCZ=string.Empty;
         private string __HXSCWKCCKD=string.Empty;
         private string __HXSCWKCCKDCZ=string.Empty;
         private string __HXSCWKCCCD=string.Empty;
         private string __HXSCWKCCCDCZ=string.Empty;
         private string __HXWKCC_PD=string.Empty;
         private string __SCWKCCGDXZXX=string.Empty;
         private string __SCWKCCGDXZSX=string.Empty;
         private string __SCWKCCKDXZXX=string.Empty;
         private string __SCWKCCKDXZSX=string.Empty;
         private string __SCWKCCCDXZXX=string.Empty;
         private string __SCWKCCCDXZSX=string.Empty;
         private int? __CYDJCFS=null;
         private string __GCSCWKCCGD=string.Empty;
         private string __GCSCWKCCGDCZ=string.Empty;
         private string __GCSCWKCCKD=string.Empty;
         private string __GCSCWKCCKDCZ=string.Empty;
         private string __GCSCWKCCCD=string.Empty;
         private string __GCSCWKCCCDCZ=string.Empty;
         private string __GCWKCC_PD=string.Empty;
         private string __ZCWKCCXZ=string.Empty;
         private string __GCWKCCXZ=string.Empty;
         private string __HXWKCCXZ=string.Empty;
         private string __YQCLCC=string.Empty;
         private string __YQCLCK=string.Empty;
         private string __YQCLCG=string.Empty;
         private string __QRRXM=string.Empty;
         private string __REMARK=string.Empty;
         private string __KSSJ=string.Empty;
         private string __JSSJ=string.Empty;
         private string __ZCLBGD=string.Empty;
         private string __SCLBGD=string.Empty;
         private string __LBGDJDWC=string.Empty;
         private string __LBGDXDWC=string.Empty;
         private string __LBGD_PD=string.Empty;
         private string __LBGDJDWCXZ=string.Empty;
         private string __LBGDXDWCXZ=string.Empty;
         private string __WKCCXDWCXZ=string.Empty;
         private string __WKCCJDWCXZ=string.Empty;

         private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


         public RESULT_OVERALLSIZE()
         {
             this.__Changed.Add("ID",false);
             this.__Changed.Add("WKCCJCCS",false);
             this.__Changed.Add("JCLSH",false);
             this.__Changed.Add("ZCSCWKCCGD",false);
             this.__Changed.Add("ZCSCWKCCGDCZ",false);
             this.__Changed.Add("ZCSCWKCCKD",false);
             this.__Changed.Add("ZCSCWKCCKDCZ",false);
             this.__Changed.Add("ZCSCWKCCCD",false);
             this.__Changed.Add("ZCSCWKCCCDCZ",false);
             this.__Changed.Add("ZCWKCC_PD",false);
             this.__Changed.Add("HXSCWKCCGD",false);
             this.__Changed.Add("HXSCWKCCGDCZ",false);
             this.__Changed.Add("HXSCWKCCKD",false);
             this.__Changed.Add("HXSCWKCCKDCZ",false);
             this.__Changed.Add("HXSCWKCCCD",false);
             this.__Changed.Add("HXSCWKCCCDCZ",false);
             this.__Changed.Add("HXWKCC_PD",false);
             this.__Changed.Add("SCWKCCGDXZXX",false);
             this.__Changed.Add("SCWKCCGDXZSX",false);
             this.__Changed.Add("SCWKCCKDXZXX",false);
             this.__Changed.Add("SCWKCCKDXZSX",false);
             this.__Changed.Add("SCWKCCCDXZXX",false);
             this.__Changed.Add("SCWKCCCDXZSX",false);
             this.__Changed.Add("CYDJCFS",false);
             this.__Changed.Add("GCSCWKCCGD",false);
             this.__Changed.Add("GCSCWKCCGDCZ",false);
             this.__Changed.Add("GCSCWKCCKD",false);
             this.__Changed.Add("GCSCWKCCKDCZ",false);
             this.__Changed.Add("GCSCWKCCCD",false);
             this.__Changed.Add("GCSCWKCCCDCZ",false);
             this.__Changed.Add("GCWKCC_PD",false);
             this.__Changed.Add("ZCWKCCXZ",false);
             this.__Changed.Add("GCWKCCXZ",false);
             this.__Changed.Add("HXWKCCXZ",false);
             this.__Changed.Add("YQCLCC",false);
             this.__Changed.Add("YQCLCK",false);
             this.__Changed.Add("YQCLCG",false);
             this.__Changed.Add("QRRXM",false);
             this.__Changed.Add("REMARK",false);
             this.__Changed.Add("KSSJ",false);
             this.__Changed.Add("JSSJ",false);
             this.__Changed.Add("ZCLBGD",false);
             this.__Changed.Add("SCLBGD",false);
             this.__Changed.Add("LBGDJDWC",false);
             this.__Changed.Add("LBGDXDWC",false);
             this.__Changed.Add("LBGD_PD",false);
             this.__Changed.Add("LBGDJDWCXZ",false);
             this.__Changed.Add("LBGDXDWCXZ",false);
             this.__Changed.Add("WKCCXDWCXZ",false);
             this.__Changed.Add("WKCCJDWCXZ",false);
         }

         /// <summary>
         /// 将类重置到初始化状态
         /// </summary>
         public void Reset()
         {
             this.__ID =0;
             this.__WKCCJCCS =string.Empty;
             this.__JCLSH =string.Empty;
             this.__ZCSCWKCCGD =string.Empty;
             this.__ZCSCWKCCGDCZ =string.Empty;
             this.__ZCSCWKCCKD =string.Empty;
             this.__ZCSCWKCCKDCZ =string.Empty;
             this.__ZCSCWKCCCD =string.Empty;
             this.__ZCSCWKCCCDCZ =string.Empty;
             this.__ZCWKCC_PD =string.Empty;
             this.__HXSCWKCCGD =string.Empty;
             this.__HXSCWKCCGDCZ =string.Empty;
             this.__HXSCWKCCKD =string.Empty;
             this.__HXSCWKCCKDCZ =string.Empty;
             this.__HXSCWKCCCD =string.Empty;
             this.__HXSCWKCCCDCZ =string.Empty;
             this.__HXWKCC_PD =string.Empty;
             this.__SCWKCCGDXZXX =string.Empty;
             this.__SCWKCCGDXZSX =string.Empty;
             this.__SCWKCCKDXZXX =string.Empty;
             this.__SCWKCCKDXZSX =string.Empty;
             this.__SCWKCCCDXZXX =string.Empty;
             this.__SCWKCCCDXZSX =string.Empty;
             this.__CYDJCFS =null;
             this.__GCSCWKCCGD =string.Empty;
             this.__GCSCWKCCGDCZ =string.Empty;
             this.__GCSCWKCCKD =string.Empty;
             this.__GCSCWKCCKDCZ =string.Empty;
             this.__GCSCWKCCCD =string.Empty;
             this.__GCSCWKCCCDCZ =string.Empty;
             this.__GCWKCC_PD =string.Empty;
             this.__ZCWKCCXZ =string.Empty;
             this.__GCWKCCXZ =string.Empty;
             this.__HXWKCCXZ =string.Empty;
             this.__YQCLCC =string.Empty;
             this.__YQCLCK =string.Empty;
             this.__YQCLCG =string.Empty;
             this.__QRRXM =string.Empty;
             this.__REMARK =string.Empty;
             this.__KSSJ =string.Empty;
             this.__JSSJ =string.Empty;
             this.__ZCLBGD =string.Empty;
             this.__SCLBGD =string.Empty;
             this.__LBGDJDWC =string.Empty;
             this.__LBGDXDWC =string.Empty;
             this.__LBGD_PD =string.Empty;
             this.__LBGDJDWCXZ =string.Empty;
             this.__LBGDXDWCXZ =string.Empty;
             this.__WKCCXDWCXZ =string.Empty;
             this.__WKCCJDWCXZ =string.Empty;
             this.__Changed["ID"] = false;
             this.__Changed["WKCCJCCS"] = false;
             this.__Changed["JCLSH"] = false;
             this.__Changed["ZCSCWKCCGD"] = false;
             this.__Changed["ZCSCWKCCGDCZ"] = false;
             this.__Changed["ZCSCWKCCKD"] = false;
             this.__Changed["ZCSCWKCCKDCZ"] = false;
             this.__Changed["ZCSCWKCCCD"] = false;
             this.__Changed["ZCSCWKCCCDCZ"] = false;
             this.__Changed["ZCWKCC_PD"] = false;
             this.__Changed["HXSCWKCCGD"] = false;
             this.__Changed["HXSCWKCCGDCZ"] = false;
             this.__Changed["HXSCWKCCKD"] = false;
             this.__Changed["HXSCWKCCKDCZ"] = false;
             this.__Changed["HXSCWKCCCD"] = false;
             this.__Changed["HXSCWKCCCDCZ"] = false;
             this.__Changed["HXWKCC_PD"] = false;
             this.__Changed["SCWKCCGDXZXX"] = false;
             this.__Changed["SCWKCCGDXZSX"] = false;
             this.__Changed["SCWKCCKDXZXX"] = false;
             this.__Changed["SCWKCCKDXZSX"] = false;
             this.__Changed["SCWKCCCDXZXX"] = false;
             this.__Changed["SCWKCCCDXZSX"] = false;
             this.__Changed["CYDJCFS"] = false;
             this.__Changed["GCSCWKCCGD"] = false;
             this.__Changed["GCSCWKCCGDCZ"] = false;
             this.__Changed["GCSCWKCCKD"] = false;
             this.__Changed["GCSCWKCCKDCZ"] = false;
             this.__Changed["GCSCWKCCCD"] = false;
             this.__Changed["GCSCWKCCCDCZ"] = false;
             this.__Changed["GCWKCC_PD"] = false;
             this.__Changed["ZCWKCCXZ"] = false;
             this.__Changed["GCWKCCXZ"] = false;
             this.__Changed["HXWKCCXZ"] = false;
             this.__Changed["YQCLCC"] = false;
             this.__Changed["YQCLCK"] = false;
             this.__Changed["YQCLCG"] = false;
             this.__Changed["QRRXM"] = false;
             this.__Changed["REMARK"] = false;
             this.__Changed["KSSJ"] = false;
             this.__Changed["JSSJ"] = false;
             this.__Changed["ZCLBGD"] = false;
             this.__Changed["SCLBGD"] = false;
             this.__Changed["LBGDJDWC"] = false;
             this.__Changed["LBGDXDWC"] = false;
             this.__Changed["LBGD_PD"] = false;
             this.__Changed["LBGDJDWCXZ"] = false;
             this.__Changed["LBGDXDWCXZ"] = false;
             this.__Changed["WKCCXDWCXZ"] = false;
             this.__Changed["WKCCJDWCXZ"] = false;
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
         ///设置或获取类中的[WKCCJCCS]的数据
         /// </summary>
         public string WKCCJCCS
         {
              set{ __WKCCJCCS = value.Replace("'","’"); __Changed["WKCCJCCS"] = true;}
              get{return __WKCCJCCS;}
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
         ///设置或获取类中的[ZCSCWKCCGD]的数据
         /// </summary>
         public string ZCSCWKCCGD
         {
              set{ __ZCSCWKCCGD = value.Replace("'","’"); __Changed["ZCSCWKCCGD"] = true;}
              get{return __ZCSCWKCCGD;}
         }
         /// <summary>
         ///设置或获取类中的[ZCSCWKCCGDCZ]的数据
         /// </summary>
         public string ZCSCWKCCGDCZ
         {
              set{ __ZCSCWKCCGDCZ = value.Replace("'","’"); __Changed["ZCSCWKCCGDCZ"] = true;}
              get{return __ZCSCWKCCGDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[ZCSCWKCCKD]的数据
         /// </summary>
         public string ZCSCWKCCKD
         {
              set{ __ZCSCWKCCKD = value.Replace("'","’"); __Changed["ZCSCWKCCKD"] = true;}
              get{return __ZCSCWKCCKD;}
         }
         /// <summary>
         ///设置或获取类中的[ZCSCWKCCKDCZ]的数据
         /// </summary>
         public string ZCSCWKCCKDCZ
         {
              set{ __ZCSCWKCCKDCZ = value.Replace("'","’"); __Changed["ZCSCWKCCKDCZ"] = true;}
              get{return __ZCSCWKCCKDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[ZCSCWKCCCD]的数据
         /// </summary>
         public string ZCSCWKCCCD
         {
              set{ __ZCSCWKCCCD = value.Replace("'","’"); __Changed["ZCSCWKCCCD"] = true;}
              get{return __ZCSCWKCCCD;}
         }
         /// <summary>
         ///设置或获取类中的[ZCSCWKCCCDCZ]的数据
         /// </summary>
         public string ZCSCWKCCCDCZ
         {
              set{ __ZCSCWKCCCDCZ = value.Replace("'","’"); __Changed["ZCSCWKCCCDCZ"] = true;}
              get{return __ZCSCWKCCCDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[ZCWKCC_PD]的数据
         /// </summary>
         public string ZCWKCC_PD
         {
              set{ __ZCWKCC_PD = value.Replace("'","’"); __Changed["ZCWKCC_PD"] = true;}
              get{return __ZCWKCC_PD;}
         }
         /// <summary>
         ///设置或获取类中的[HXSCWKCCGD]的数据
         /// </summary>
         public string HXSCWKCCGD
         {
              set{ __HXSCWKCCGD = value.Replace("'","’"); __Changed["HXSCWKCCGD"] = true;}
              get{return __HXSCWKCCGD;}
         }
         /// <summary>
         ///设置或获取类中的[HXSCWKCCGDCZ]的数据
         /// </summary>
         public string HXSCWKCCGDCZ
         {
              set{ __HXSCWKCCGDCZ = value.Replace("'","’"); __Changed["HXSCWKCCGDCZ"] = true;}
              get{return __HXSCWKCCGDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[HXSCWKCCKD]的数据
         /// </summary>
         public string HXSCWKCCKD
         {
              set{ __HXSCWKCCKD = value.Replace("'","’"); __Changed["HXSCWKCCKD"] = true;}
              get{return __HXSCWKCCKD;}
         }
         /// <summary>
         ///设置或获取类中的[HXSCWKCCKDCZ]的数据
         /// </summary>
         public string HXSCWKCCKDCZ
         {
              set{ __HXSCWKCCKDCZ = value.Replace("'","’"); __Changed["HXSCWKCCKDCZ"] = true;}
              get{return __HXSCWKCCKDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[HXSCWKCCCD]的数据
         /// </summary>
         public string HXSCWKCCCD
         {
              set{ __HXSCWKCCCD = value.Replace("'","’"); __Changed["HXSCWKCCCD"] = true;}
              get{return __HXSCWKCCCD;}
         }
         /// <summary>
         ///设置或获取类中的[HXSCWKCCCDCZ]的数据
         /// </summary>
         public string HXSCWKCCCDCZ
         {
              set{ __HXSCWKCCCDCZ = value.Replace("'","’"); __Changed["HXSCWKCCCDCZ"] = true;}
              get{return __HXSCWKCCCDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[HXWKCC_PD]的数据
         /// </summary>
         public string HXWKCC_PD
         {
              set{ __HXWKCC_PD = value.Replace("'","’"); __Changed["HXWKCC_PD"] = true;}
              get{return __HXWKCC_PD;}
         }
         /// <summary>
         ///设置或获取类中的[SCWKCCGDXZXX]的数据
         /// </summary>
         public string SCWKCCGDXZXX
         {
              set{ __SCWKCCGDXZXX = value.Replace("'","’"); __Changed["SCWKCCGDXZXX"] = true;}
              get{return __SCWKCCGDXZXX;}
         }
         /// <summary>
         ///设置或获取类中的[SCWKCCGDXZSX]的数据
         /// </summary>
         public string SCWKCCGDXZSX
         {
              set{ __SCWKCCGDXZSX = value.Replace("'","’"); __Changed["SCWKCCGDXZSX"] = true;}
              get{return __SCWKCCGDXZSX;}
         }
         /// <summary>
         ///设置或获取类中的[SCWKCCKDXZXX]的数据
         /// </summary>
         public string SCWKCCKDXZXX
         {
              set{ __SCWKCCKDXZXX = value.Replace("'","’"); __Changed["SCWKCCKDXZXX"] = true;}
              get{return __SCWKCCKDXZXX;}
         }
         /// <summary>
         ///设置或获取类中的[SCWKCCKDXZSX]的数据
         /// </summary>
         public string SCWKCCKDXZSX
         {
              set{ __SCWKCCKDXZSX = value.Replace("'","’"); __Changed["SCWKCCKDXZSX"] = true;}
              get{return __SCWKCCKDXZSX;}
         }
         /// <summary>
         ///设置或获取类中的[SCWKCCCDXZXX]的数据
         /// </summary>
         public string SCWKCCCDXZXX
         {
              set{ __SCWKCCCDXZXX = value.Replace("'","’"); __Changed["SCWKCCCDXZXX"] = true;}
              get{return __SCWKCCCDXZXX;}
         }
         /// <summary>
         ///设置或获取类中的[SCWKCCCDXZSX]的数据
         /// </summary>
         public string SCWKCCCDXZSX
         {
              set{ __SCWKCCCDXZSX = value.Replace("'","’"); __Changed["SCWKCCCDXZSX"] = true;}
              get{return __SCWKCCCDXZSX;}
         }
         /// <summary>
         ///设置或获取类中的[CYDJCFS]的数据
         /// </summary>
         public int? CYDJCFS
         {
              set{ __CYDJCFS = value; __Changed["CYDJCFS"] = true;}
              get{return __CYDJCFS;}
         }
         /// <summary>
         ///设置或获取类中的[GCSCWKCCGD]的数据
         /// </summary>
         public string GCSCWKCCGD
         {
              set{ __GCSCWKCCGD = value.Replace("'","’"); __Changed["GCSCWKCCGD"] = true;}
              get{return __GCSCWKCCGD;}
         }
         /// <summary>
         ///设置或获取类中的[GCSCWKCCGDCZ]的数据
         /// </summary>
         public string GCSCWKCCGDCZ
         {
              set{ __GCSCWKCCGDCZ = value.Replace("'","’"); __Changed["GCSCWKCCGDCZ"] = true;}
              get{return __GCSCWKCCGDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[GCSCWKCCKD]的数据
         /// </summary>
         public string GCSCWKCCKD
         {
              set{ __GCSCWKCCKD = value.Replace("'","’"); __Changed["GCSCWKCCKD"] = true;}
              get{return __GCSCWKCCKD;}
         }
         /// <summary>
         ///设置或获取类中的[GCSCWKCCKDCZ]的数据
         /// </summary>
         public string GCSCWKCCKDCZ
         {
              set{ __GCSCWKCCKDCZ = value.Replace("'","’"); __Changed["GCSCWKCCKDCZ"] = true;}
              get{return __GCSCWKCCKDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[GCSCWKCCCD]的数据
         /// </summary>
         public string GCSCWKCCCD
         {
              set{ __GCSCWKCCCD = value.Replace("'","’"); __Changed["GCSCWKCCCD"] = true;}
              get{return __GCSCWKCCCD;}
         }
         /// <summary>
         ///设置或获取类中的[GCSCWKCCCDCZ]的数据
         /// </summary>
         public string GCSCWKCCCDCZ
         {
              set{ __GCSCWKCCCDCZ = value.Replace("'","’"); __Changed["GCSCWKCCCDCZ"] = true;}
              get{return __GCSCWKCCCDCZ;}
         }
         /// <summary>
         ///设置或获取类中的[GCWKCC_PD]的数据
         /// </summary>
         public string GCWKCC_PD
         {
              set{ __GCWKCC_PD = value.Replace("'","’"); __Changed["GCWKCC_PD"] = true;}
              get{return __GCWKCC_PD;}
         }
         /// <summary>
         ///设置或获取类中的[ZCWKCCXZ]的数据
         /// </summary>
         public string ZCWKCCXZ
         {
              set{ __ZCWKCCXZ = value.Replace("'","’"); __Changed["ZCWKCCXZ"] = true;}
              get{return __ZCWKCCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[GCWKCCXZ]的数据
         /// </summary>
         public string GCWKCCXZ
         {
              set{ __GCWKCCXZ = value.Replace("'","’"); __Changed["GCWKCCXZ"] = true;}
              get{return __GCWKCCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[HXWKCCXZ]的数据
         /// </summary>
         public string HXWKCCXZ
         {
              set{ __HXWKCCXZ = value.Replace("'","’"); __Changed["HXWKCCXZ"] = true;}
              get{return __HXWKCCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[YQCLCC]的数据
         /// </summary>
         public string YQCLCC
         {
              set{ __YQCLCC = value.Replace("'","’"); __Changed["YQCLCC"] = true;}
              get{return __YQCLCC;}
         }
         /// <summary>
         ///设置或获取类中的[YQCLCK]的数据
         /// </summary>
         public string YQCLCK
         {
              set{ __YQCLCK = value.Replace("'","’"); __Changed["YQCLCK"] = true;}
              get{return __YQCLCK;}
         }
         /// <summary>
         ///设置或获取类中的[YQCLCG]的数据
         /// </summary>
         public string YQCLCG
         {
              set{ __YQCLCG = value.Replace("'","’"); __Changed["YQCLCG"] = true;}
              get{return __YQCLCG;}
         }
         /// <summary>
         ///设置或获取类中的[QRRXM]的数据
         /// </summary>
         public string QRRXM
         {
              set{ __QRRXM = value.Replace("'","’"); __Changed["QRRXM"] = true;}
              get{return __QRRXM;}
         }
         /// <summary>
         ///设置或获取类中的[REMARK]的数据
         /// </summary>
         public string REMARK
         {
              set{ __REMARK = value.Replace("'","’"); __Changed["REMARK"] = true;}
              get{return __REMARK;}
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
         /// <summary>
         ///设置或获取类中的[ZCLBGD]的数据
         /// </summary>
         public string ZCLBGD
         {
              set{ __ZCLBGD = value.Replace("'","’"); __Changed["ZCLBGD"] = true;}
              get{return __ZCLBGD;}
         }
         /// <summary>
         ///设置或获取类中的[SCLBGD]的数据
         /// </summary>
         public string SCLBGD
         {
              set{ __SCLBGD = value.Replace("'","’"); __Changed["SCLBGD"] = true;}
              get{return __SCLBGD;}
         }
         /// <summary>
         ///设置或获取类中的[LBGDJDWC]的数据
         /// </summary>
         public string LBGDJDWC
         {
              set{ __LBGDJDWC = value.Replace("'","’"); __Changed["LBGDJDWC"] = true;}
              get{return __LBGDJDWC;}
         }
         /// <summary>
         ///设置或获取类中的[LBGDXDWC]的数据
         /// </summary>
         public string LBGDXDWC
         {
              set{ __LBGDXDWC = value.Replace("'","’"); __Changed["LBGDXDWC"] = true;}
              get{return __LBGDXDWC;}
         }
         /// <summary>
         ///设置或获取类中的[LBGD_PD]的数据
         /// </summary>
         public string LBGD_PD
         {
              set{ __LBGD_PD = value.Replace("'","’"); __Changed["LBGD_PD"] = true;}
              get{return __LBGD_PD;}
         }
         /// <summary>
         ///设置或获取类中的[LBGDJDWCXZ]的数据
         /// </summary>
         public string LBGDJDWCXZ
         {
              set{ __LBGDJDWCXZ = value.Replace("'","’"); __Changed["LBGDJDWCXZ"] = true;}
              get{return __LBGDJDWCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[LBGDXDWCXZ]的数据
         /// </summary>
         public string LBGDXDWCXZ
         {
              set{ __LBGDXDWCXZ = value.Replace("'","’"); __Changed["LBGDXDWCXZ"] = true;}
              get{return __LBGDXDWCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[WKCCXDWCXZ]的数据
         /// </summary>
         public string WKCCXDWCXZ
         {
              set{ __WKCCXDWCXZ = value.Replace("'","’"); __Changed["WKCCXDWCXZ"] = true;}
              get{return __WKCCXDWCXZ;}
         }
         /// <summary>
         ///设置或获取类中的[WKCCJDWCXZ]的数据
         /// </summary>
         public string WKCCJDWCXZ
         {
              set{ __WKCCJDWCXZ = value.Replace("'","’"); __Changed["WKCCJDWCXZ"] = true;}
              get{return __WKCCJDWCXZ;}
         }
    }
}
