using HNK.Infrustracture;
using System.Collections.Generic;

namespace HNK.Core
{
     ///<summary>
     ///实体类RESULT_KERBMASS
     ///</summary>
     public class RESULT_KERBMASS:Entity
     {
         private int __ID=0;
         private string __ZBZLJCCS=string.Empty;
         private string __JCLSH=string.Empty;
         private string __SCZBZL1=string.Empty;
         private string __SCZBZL2=string.Empty;
         private string __SCZBZL3=string.Empty;
         private string __SCZBZL4=string.Empty;
         private string __SCZBZL5=string.Empty;
         private string __SCZBZL6=string.Empty;
         private string __SCZBZL=string.Empty;
         private string __SCZBZLWC=string.Empty;
         private string __ZBZL_PD=string.Empty;
         private string __ZBZLXZXX=string.Empty;
         private string __ZBZLXZSX=string.Empty;
         private int? __CYDJCFS=null;
         private string __ZBZLJDWC=string.Empty;
         private string __ZBZLXDWC=string.Empty;
         private string __KSSJ=string.Empty;
         private string __JSSJ=string.Empty;

         private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


         public RESULT_KERBMASS()
         {
             this.__Changed.Add("ID",false);
             this.__Changed.Add("ZBZLJCCS",false);
             this.__Changed.Add("JCLSH",false);
             this.__Changed.Add("SCZBZL1",false);
             this.__Changed.Add("SCZBZL2",false);
             this.__Changed.Add("SCZBZL3",false);
             this.__Changed.Add("SCZBZL4",false);
             this.__Changed.Add("SCZBZL5",false);
             this.__Changed.Add("SCZBZL6",false);
             this.__Changed.Add("SCZBZL",false);
             this.__Changed.Add("SCZBZLWC",false);
             this.__Changed.Add("ZBZL_PD",false);
             this.__Changed.Add("ZBZLXZXX",false);
             this.__Changed.Add("ZBZLXZSX",false);
             this.__Changed.Add("CYDJCFS",false);
             this.__Changed.Add("ZBZLJDWC",false);
             this.__Changed.Add("ZBZLXDWC",false);
             this.__Changed.Add("KSSJ",false);
             this.__Changed.Add("JSSJ",false);
         }

         /// <summary>
         /// 将类重置到初始化状态
         /// </summary>
         public void Reset()
         {
             this.__ID =0;
             this.__ZBZLJCCS =string.Empty;
             this.__JCLSH =string.Empty;
             this.__SCZBZL1 =string.Empty;
             this.__SCZBZL2 =string.Empty;
             this.__SCZBZL3 =string.Empty;
             this.__SCZBZL4 =string.Empty;
             this.__SCZBZL5 =string.Empty;
             this.__SCZBZL6 =string.Empty;
             this.__SCZBZL =string.Empty;
             this.__SCZBZLWC =string.Empty;
             this.__ZBZL_PD =string.Empty;
             this.__ZBZLXZXX =string.Empty;
             this.__ZBZLXZSX =string.Empty;
             this.__CYDJCFS =null;
             this.__ZBZLJDWC =string.Empty;
             this.__ZBZLXDWC =string.Empty;
             this.__KSSJ =string.Empty;
             this.__JSSJ =string.Empty;
             this.__Changed["ID"] = false;
             this.__Changed["ZBZLJCCS"] = false;
             this.__Changed["JCLSH"] = false;
             this.__Changed["SCZBZL1"] = false;
             this.__Changed["SCZBZL2"] = false;
             this.__Changed["SCZBZL3"] = false;
             this.__Changed["SCZBZL4"] = false;
             this.__Changed["SCZBZL5"] = false;
             this.__Changed["SCZBZL6"] = false;
             this.__Changed["SCZBZL"] = false;
             this.__Changed["SCZBZLWC"] = false;
             this.__Changed["ZBZL_PD"] = false;
             this.__Changed["ZBZLXZXX"] = false;
             this.__Changed["ZBZLXZSX"] = false;
             this.__Changed["CYDJCFS"] = false;
             this.__Changed["ZBZLJDWC"] = false;
             this.__Changed["ZBZLXDWC"] = false;
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
         ///设置或获取类中的[ZBZLJCCS]的数据
         /// </summary>
         public string ZBZLJCCS
         {
              set{ __ZBZLJCCS = value.Replace("'","’"); __Changed["ZBZLJCCS"] = true;}
              get{return __ZBZLJCCS;}
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
         ///设置或获取类中的[SCZBZL1]的数据
         /// </summary>
         public string SCZBZL1
         {
              set{ __SCZBZL1 = value.Replace("'","’"); __Changed["SCZBZL1"] = true;}
              get{return __SCZBZL1;}
         }
         /// <summary>
         ///设置或获取类中的[SCZBZL2]的数据
         /// </summary>
         public string SCZBZL2
         {
              set{ __SCZBZL2 = value.Replace("'","’"); __Changed["SCZBZL2"] = true;}
              get{return __SCZBZL2;}
         }
         /// <summary>
         ///设置或获取类中的[SCZBZL3]的数据
         /// </summary>
         public string SCZBZL3
         {
              set{ __SCZBZL3 = value.Replace("'","’"); __Changed["SCZBZL3"] = true;}
              get{return __SCZBZL3;}
         }
         /// <summary>
         ///设置或获取类中的[SCZBZL4]的数据
         /// </summary>
         public string SCZBZL4
         {
              set{ __SCZBZL4 = value.Replace("'","’"); __Changed["SCZBZL4"] = true;}
              get{return __SCZBZL4;}
         }
         /// <summary>
         ///设置或获取类中的[SCZBZL5]的数据
         /// </summary>
         public string SCZBZL5
         {
              set{ __SCZBZL5 = value.Replace("'","’"); __Changed["SCZBZL5"] = true;}
              get{return __SCZBZL5;}
         }
         /// <summary>
         ///设置或获取类中的[SCZBZL6]的数据
         /// </summary>
         public string SCZBZL6
         {
              set{ __SCZBZL6 = value.Replace("'","’"); __Changed["SCZBZL6"] = true;}
              get{return __SCZBZL6;}
         }
         /// <summary>
         ///设置或获取类中的[SCZBZL]的数据
         /// </summary>
         public string SCZBZL
         {
              set{ __SCZBZL = value.Replace("'","’"); __Changed["SCZBZL"] = true;}
              get{return __SCZBZL;}
         }
         /// <summary>
         ///设置或获取类中的[SCZBZLWC]的数据
         /// </summary>
         public string SCZBZLWC
         {
              set{ __SCZBZLWC = value.Replace("'","’"); __Changed["SCZBZLWC"] = true;}
              get{return __SCZBZLWC;}
         }
         /// <summary>
         ///设置或获取类中的[ZBZL_PD]的数据
         /// </summary>
         public string ZBZL_PD
         {
              set{ __ZBZL_PD = value.Replace("'","’"); __Changed["ZBZL_PD"] = true;}
              get{return __ZBZL_PD;}
         }
         /// <summary>
         ///设置或获取类中的[ZBZLXZXX]的数据
         /// </summary>
         public string ZBZLXZXX
         {
              set{ __ZBZLXZXX = value.Replace("'","’"); __Changed["ZBZLXZXX"] = true;}
              get{return __ZBZLXZXX;}
         }
         /// <summary>
         ///设置或获取类中的[ZBZLXZSX]的数据
         /// </summary>
         public string ZBZLXZSX
         {
              set{ __ZBZLXZSX = value.Replace("'","’"); __Changed["ZBZLXZSX"] = true;}
              get{return __ZBZLXZSX;}
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
         ///设置或获取类中的[ZBZLJDWC]的数据
         /// </summary>
         public string ZBZLJDWC
         {
              set{ __ZBZLJDWC = value.Replace("'","’"); __Changed["ZBZLJDWC"] = true;}
              get{return __ZBZLJDWC;}
         }
         /// <summary>
         ///设置或获取类中的[ZBZLXDWC]的数据
         /// </summary>
         public string ZBZLXDWC
         {
              set{ __ZBZLXDWC = value.Replace("'","’"); __Changed["ZBZLXDWC"] = true;}
              get{return __ZBZLXDWC;}
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
