using HNK.Infrustracture;
using System.Collections.Generic;
namespace HNK.Core
{
    ///<summary>
    ///实体类RESULT_IMAGE
    ///</summary>
    public class RESULT_IMAGE:Entity
    {
        private int __ID = 0;
        private string __JCLSH = string.Empty;
        private byte[] __Lamp_Image = null;
        private byte[] __Brake_Image = null;
        private byte[] __Power_Image = null;
        private byte[] __Chasiss_Image = null;
        private byte[] __Appearance_Image = null;
        private byte[] __WKCC_IMAGE1 = null;
        private byte[] __WKCC_IMAGE2 = null;
        private byte[] __WKCC_IMAGE3 = null;
        private byte[] __WKCC_IMAGE4 = null;

        private Dictionary<string, bool> __Changed = new Dictionary<string, bool>();


        public RESULT_IMAGE()
        {
            this.__Changed.Add("ID", false);
            this.__Changed.Add("JCLSH", false);
            this.__Changed.Add("Lamp_Image", false);
            this.__Changed.Add("Brake_Image", false);
            this.__Changed.Add("Power_Image", false);
            this.__Changed.Add("Chasiss_Image", false);
            this.__Changed.Add("Appearance_Image", false);
            this.__Changed.Add("WKCC_IMAGE1", false);
            this.__Changed.Add("WKCC_IMAGE2", false);
            this.__Changed.Add("WKCC_IMAGE3", false);
            this.__Changed.Add("WKCC_IMAGE4", false);
        }

        /// <summary>
        /// 将类重置到初始化状态
        /// </summary>
        public void Reset()
        {
            this.__ID = 0;
            this.__JCLSH = string.Empty;
            this.__Lamp_Image = null;
            this.__Brake_Image = null;
            this.__Power_Image = null;
            this.__Chasiss_Image = null;
            this.__Appearance_Image = null;
            this.__WKCC_IMAGE1 = null;
            this.__WKCC_IMAGE2 = null;
            this.__WKCC_IMAGE3 = null;
            this.__WKCC_IMAGE4 = null;
            this.__Changed["ID"] = false;
            this.__Changed["JCLSH"] = false;
            this.__Changed["Lamp_Image"] = false;
            this.__Changed["Brake_Image"] = false;
            this.__Changed["Power_Image"] = false;
            this.__Changed["Chasiss_Image"] = false;
            this.__Changed["Appearance_Image"] = false;
            this.__Changed["WKCC_IMAGE1"] = false;
            this.__Changed["WKCC_IMAGE2"] = false;
            this.__Changed["WKCC_IMAGE3"] = false;
            this.__Changed["WKCC_IMAGE4"] = false;
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
            set { __ID = value; __Changed["ID"] = true; }
            get { return __ID; }
        }
        /// <summary>
        ///设置或获取类中的[JCLSH]的数据
        /// </summary>
        public string JCLSH
        {
            set { __JCLSH = value.Replace("'", "’"); __Changed["JCLSH"] = true; }
            get { return __JCLSH; }
        }
        /// <summary>
        ///设置或获取类中的[Lamp_Image]的数据
        /// </summary>
        public byte[] Lamp_Image
        {
            set { __Lamp_Image = value; __Changed["Lamp_Image"] = true; }
            get { return __Lamp_Image; }
        }
        /// <summary>
        ///设置或获取类中的[Brake_Image]的数据
        /// </summary>
        public byte[] Brake_Image
        {
            set { __Brake_Image = value; __Changed["Brake_Image"] = true; }
            get { return __Brake_Image; }
        }
        /// <summary>
        ///设置或获取类中的[Power_Image]的数据
        /// </summary>
        public byte[] Power_Image
        {
            set { __Power_Image = value; __Changed["Power_Image"] = true; }
            get { return __Power_Image; }
        }
        /// <summary>
        ///设置或获取类中的[Chasiss_Image]的数据
        /// </summary>
        public byte[] Chasiss_Image
        {
            set { __Chasiss_Image = value; __Changed["Chasiss_Image"] = true; }
            get { return __Chasiss_Image; }
        }
        /// <summary>
        ///设置或获取类中的[Appearance_Image]的数据
        /// </summary>
        public byte[] Appearance_Image
        {
            set { __Appearance_Image = value; __Changed["Appearance_Image"] = true; }
            get { return __Appearance_Image; }
        }
        /// <summary>
        ///设置或获取类中的[WKCC_IMAGE1]的数据
        /// </summary>
        public byte[] WKCC_IMAGE1
        {
            set { __WKCC_IMAGE1 = value; __Changed["WKCC_IMAGE1"] = true; }
            get { return __WKCC_IMAGE1; }
        }
        /// <summary>
        ///设置或获取类中的[WKCC_IMAGE2]的数据
        /// </summary>
        public byte[] WKCC_IMAGE2
        {
            set { __WKCC_IMAGE2 = value; __Changed["WKCC_IMAGE2"] = true; }
            get { return __WKCC_IMAGE2; }
        }
        /// <summary>
        ///设置或获取类中的[WKCC_IMAGE3]的数据
        /// </summary>
        public byte[] WKCC_IMAGE3
        {
            set { __WKCC_IMAGE3 = value; __Changed["WKCC_IMAGE3"] = true; }
            get { return __WKCC_IMAGE3; }
        }
        /// <summary>
        ///设置或获取类中的[WKCC_IMAGE4]的数据
        /// </summary>
        public byte[] WKCC_IMAGE4
        {
            set { __WKCC_IMAGE4 = value; __Changed["WKCC_IMAGE4"] = true; }
            get { return __WKCC_IMAGE4; }
        }
    }
}
