using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HNK.Infrustracture.Auxiliary
{
    public static class Log
    {
        /// <summary>
        /// Write Log on Disk
        /// </summary>
        /// <param name="logMessage">Message</param>
        /// <param name="path">Log file's Path</param>
        public static void Write(string logMessage, string path = "")
        {
            StackTrace stackTrace = new StackTrace(true);
            Type type = stackTrace.GetFrame(1).GetMethod().DeclaringType;
            string clsName = type.FullName;
            string funcName = stackTrace.GetFrame(1).GetMethod().ToString();
            string logTime = DateTime.Now.ToString("HH:mm:ss");
            string details = GetStackTraceModelName();
            try
            {
                if (path.IsNullOrEmprty())
                {
                    path = Directory.GetCurrentDirectory() + @"\log\";
                }
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string fileFullPath = path + DateTime.Now.ToString("yyyyMMdd");
                StringBuilder sb = new StringBuilder();
                sb.Append("-------LOG------\r\n");
                sb.Append("Time-> " + logTime + "\r\n");
                sb.Append("Info-> " + logMessage + "\r\n");
                sb.Append("Class Name-> " + clsName + "\r\n");
                sb.Append("Function Name-> " + funcName + "\r\n");
                sb.Append("Callstack-> " + details + "\r\n");
                StreamWriter streamWriter;
                if (!File.Exists(fileFullPath))
                {
                    streamWriter = File.CreateText(fileFullPath);
                }
                else
                {
                    streamWriter = File.AppendText(fileFullPath);
                }
                streamWriter.WriteLine(sb.ToString());
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Get call stack of Function when called
        /// </summary>
        /// <returns>Callstack String</returns>
        public static string GetStackTraceModelName()
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
            System.Diagnostics.StackFrame[] sfs = st.GetFrames();
            string _filterdName = "ResponseWrite,ResponseWriteError,";
            string _fullName = string.Empty, _methodName = string.Empty;
            for (int i = 1; i < sfs.Length; ++i)
            {
                if (System.Diagnostics.StackFrame.OFFSET_UNKNOWN == sfs[i].GetILOffset()) break;
                _methodName = sfs[i].GetMethod().Name;
                if (_filterdName.Contains(_methodName)) continue;
                _fullName = _methodName + "()->" + _fullName;
            }
            st = null;
            sfs = null;
            _filterdName = _methodName = null;
            return _fullName.TrimEnd('-', '>');
        }
    }
}
