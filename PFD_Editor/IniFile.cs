using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PFD_Editor
{
    internal class IniFile
    {
        [DllImport("kernel32.dll")]
        private static extern uint GetPrivateProfileString(
            string lpAppName, 
            string lpKeyName, 
            string lpDefault, 
            StringBuilder lpReturnedString, 
            uint nSize, 
            string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern uint GetPrivateProfileInt(
            string lpAppName, 
            string lpKeyName, 
            int nDefault, 
            string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool WritePrivateProfileString(
            string lpAppName, 
            string lpKeyName, 
            string lpString, 
            string lpFileName);

        public string FilePath { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="filePath">Iniファイル名</param>
        public IniFile(string filePath)
        {
            this.FilePath = filePath;
        }

        public string GetString(string section, string key, string defaultValue = "")
        {
            StringBuilder sb = new StringBuilder(1024);
            uint r = GetPrivateProfileString(section, key, defaultValue, sb, (uint)sb.Capacity, this.FilePath);
            return sb.ToString();
        }

        public bool WriteString(string section, string key, string value)
        {
            return WritePrivateProfileString(section, key, value, this.FilePath);
        }
    }
}
