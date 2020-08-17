using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HNK.Infrustracture.Auxiliary
{
    public static class INIFileReader
    {
        private static string m_ConfigPath;
        public static bool ready { get; private set; }
        /// <summary>
        /// Defualt Ctor for IVS30
        /// </summary>
        public static void
            InitConfig()
        {
            m_ConfigPath = Path.GetFullPath(".") + @"\Config\sqlcfg.ini";
            ready = true;
        }
        public static void
            InitConfig(string fileFullPath)
        {
            m_ConfigPath = fileFullPath;
            ready = true;
        }
        public static string
            GetConfigString(string Section,
                                           string Key,
                                           string Defualt,
                                           StringBuilder buffer,
                                           int bufferSize)
        {
            long result = KERNEL32.GetPrivateProfileString(Section, Key, Defualt, buffer, bufferSize, m_ConfigPath);
            if (result > 0) return buffer.ToString();
            else return null;
        }
        public static bool
            SetConfigString(string Section,
                                          string Key,
                                          string Value)
        {
            long result = KERNEL32.WritePrivateProfileString(Section, Key, Value, m_ConfigPath);
            if (result != 0) return true;
            else return false;
        }
    }
}
