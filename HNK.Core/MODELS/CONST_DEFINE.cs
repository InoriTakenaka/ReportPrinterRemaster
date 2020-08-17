using HNK.Infrustracture;
using System.Collections.Generic;
namespace HNK.Core
{
     ///<summary>
     ///实体类CONST_DEFINE
     ///</summary>
     public class CONST_DEFINE:Entity
     {
         private int __ID=0;
         private string __CON_CHNAME=string.Empty;
         private string __CON_NAME=string.Empty;
         private string __CON_CODE=string.Empty;
         private string __CON_CON=string.Empty;
         private string __CON_SPELL=string.Empty;
         private int? __CON_ORDER=null;
         private int? __CON_FLAG=null;
         private int? __CON_VTYPE=null;
         private int? __CON_CLASS=null;
         private string __REMARK=string.Empty;
         private string __CON_JCTYPE=string.Empty;

         private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


         public CONST_DEFINE()
         {
             this.__Changed.Add("ID",false);
             this.__Changed.Add("CON_CHNAME",false);
             this.__Changed.Add("CON_NAME",false);
             this.__Changed.Add("CON_CODE",false);
             this.__Changed.Add("CON_CON",false);
             this.__Changed.Add("CON_SPELL",false);
             this.__Changed.Add("CON_ORDER",false);
             this.__Changed.Add("CON_FLAG",false);
             this.__Changed.Add("CON_VTYPE",false);
             this.__Changed.Add("CON_CLASS",false);
             this.__Changed.Add("REMARK",false);
             this.__Changed.Add("CON_JCTYPE",false);
         }

         /// <summary>
         /// 将类重置到初始化状态
         /// </summary>
         public void Reset()
         {
             this.__ID =0;
             this.__CON_CHNAME =string.Empty;
             this.__CON_NAME =string.Empty;
             this.__CON_CODE =string.Empty;
             this.__CON_CON =string.Empty;
             this.__CON_SPELL =string.Empty;
             this.__CON_ORDER =null;
             this.__CON_FLAG =null;
             this.__CON_VTYPE =null;
             this.__CON_CLASS =null;
             this.__REMARK =string.Empty;
             this.__CON_JCTYPE =string.Empty;
             this.__Changed["ID"] = false;
             this.__Changed["CON_CHNAME"] = false;
             this.__Changed["CON_NAME"] = false;
             this.__Changed["CON_CODE"] = false;
             this.__Changed["CON_CON"] = false;
             this.__Changed["CON_SPELL"] = false;
             this.__Changed["CON_ORDER"] = false;
             this.__Changed["CON_FLAG"] = false;
             this.__Changed["CON_VTYPE"] = false;
             this.__Changed["CON_CLASS"] = false;
             this.__Changed["REMARK"] = false;
             this.__Changed["CON_JCTYPE"] = false;
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
         ///设置或获取类中的[CON_CHNAME]的数据
         /// </summary>
         public string CON_CHNAME
         {
              set{ __CON_CHNAME = value.Replace("'","’"); __Changed["CON_CHNAME"] = true;}
              get{return __CON_CHNAME;}
         }
         /// <summary>
         ///设置或获取类中的[CON_NAME]的数据
         /// </summary>
         public string CON_NAME
         {
              set{ __CON_NAME = value.Replace("'","’"); __Changed["CON_NAME"] = true;}
              get{return __CON_NAME;}
         }
         /// <summary>
         ///设置或获取类中的[CON_CODE]的数据
         /// </summary>
         public string CON_CODE
         {
              set{ __CON_CODE = value.Replace("'","’"); __Changed["CON_CODE"] = true;}
              get{return __CON_CODE;}
         }
         /// <summary>
         ///设置或获取类中的[CON_CON]的数据
         /// </summary>
         public string CON_CON
         {
              set{ __CON_CON = value.Replace("'","’"); __Changed["CON_CON"] = true;}
              get{return __CON_CON;}
         }
         /// <summary>
         ///设置或获取类中的[CON_SPELL]的数据
         /// </summary>
         public string CON_SPELL
         {
              set{ __CON_SPELL = value.Replace("'","’"); __Changed["CON_SPELL"] = true;}
              get{return __CON_SPELL;}
         }
         /// <summary>
         ///设置或获取类中的[CON_ORDER]的数据
         /// </summary>
         public int? CON_ORDER
         {
              set{ __CON_ORDER = value; __Changed["CON_ORDER"] = true;}
              get{return __CON_ORDER;}
         }
         /// <summary>
         ///设置或获取类中的[CON_FLAG]的数据
         /// </summary>
         public int? CON_FLAG
         {
              set{ __CON_FLAG = value; __Changed["CON_FLAG"] = true;}
              get{return __CON_FLAG;}
         }
         /// <summary>
         ///设置或获取类中的[CON_VTYPE]的数据
         /// </summary>
         public int? CON_VTYPE
         {
              set{ __CON_VTYPE = value; __Changed["CON_VTYPE"] = true;}
              get{return __CON_VTYPE;}
         }
         /// <summary>
         ///设置或获取类中的[CON_CLASS]的数据
         /// </summary>
         public int? CON_CLASS
         {
              set{ __CON_CLASS = value; __Changed["CON_CLASS"] = true;}
              get{return __CON_CLASS;}
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
         ///设置或获取类中的[CON_JCTYPE]的数据
         /// </summary>
         public string CON_JCTYPE
         {
              set{ __CON_JCTYPE = value.Replace("'","’"); __Changed["CON_JCTYPE"] = true;}
              get{return __CON_JCTYPE;}
         }
    }
}
