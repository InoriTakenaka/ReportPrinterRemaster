using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml;

namespace HNK.Infrustracture.Auxiliary
{
    public static class GlobalFunction
    {
        public static XmlElement GetXmlElement(XmlDocument doc, string elementName, string value)
        {
            XmlElement element = doc.CreateElement(elementName);
            element.InnerText = value;
            return element;
        }

        public static string GetXmlValue(string strXml, string strEle)
        {
            string strResult = "";
            Match match = Regex.Match(strXml, @"<" + strEle + @">(?<Value>[\s\S]*?)</" + strEle + ">");
            if (match.Success)
            {

                strResult = match.Groups["Value"].Value;
            }
            return strResult;
        }

        public static T FillEntityByXml<T>(string strXml)
        {
            T t = Activator.CreateInstance<T>();
            try
            {
                PropertyInfo[] propertyInfos = t.GetType().GetProperties();
                foreach (PropertyInfo p in propertyInfos)
                {
                    p.SetValue(t, GetXmlValue(strXml, p.Name), null);
                }
            }
            catch (Exception ex)
            {

            }
            return t;
        }


        public static DateTime RandomDateTimeEx()
        {
            DateTime start = new DateTime(1980, 1, 1, 0, 0, 0);
            DateTime end = new DateTime(2030, 1, 1, 0, 0, 0);
            TimeSpan ts = new TimeSpan(end.Ticks - start.Ticks);
            double dTotalSeconds = ts.TotalSeconds;
            int iMax = 0;
            if (dTotalSeconds > System.Int32.MaxValue)
            {
                iMax = System.Int32.MaxValue;
            }
            else
            {
                iMax = (int)dTotalSeconds;
            }
            int newTs = RandomInt32(iMax, 0);
            return start.AddSeconds(newTs);
        }

        public static string GetRnd(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }

        public static byte[] RandomByte()
        {
            byte[] b = new byte[2048];
            new RNGCryptoServiceProvider().GetBytes(b);
            return b;
        }

        public static int RandomInt32(int Max, int Min)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] byteCsp = new byte[4];
            rng.GetBytes(byteCsp);
            Random r = new Random(BitConverter.ToInt32(byteCsp, 0));
            return r.Next(Min, Max);
        }
    }
}
