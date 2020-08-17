﻿using System.Runtime.InteropServices;
using System.Text;

namespace HNK.Infrustracture
{
     public static class KERNEL32
    {
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        public static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        public static extern long GetPrivateProfileString(string Section, string Key, string Defualt, StringBuilder buffer, int size, string FilePath);

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetPrivateProfileInt(string Section, string Key, int Defualt, string FilePath);
    }
}
