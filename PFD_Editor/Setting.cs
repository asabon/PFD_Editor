using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace PFD_Editor
{
    public class Setting
    {
        public enum LanguageType
        {
            English,
            Japanese,
        }
        public LanguageType languageType { get; set; }
        public string graphvizExe { get; set; }
        public string xmlFileName { get; set; }
        public string dotFileName { get; set; }
        public string pngFileName { get; set; }
        private JsonFile iniFile { get; set; }

        public Setting(string filePath)
        {
            iniFile = new JsonFile(filePath);
            LoadSetting(filePath);
            SaveSetting(filePath);
        }

        public void SaveSetting(string fileName)
        {
            string lang;
            switch (this.languageType)
            {
                case LanguageType.English:
                default:
                    lang = "en";
                    break;

                case LanguageType.Japanese:
                    lang = "ja";
                    break;
            }
            iniFile.SetString("language", lang);
            iniFile.SetString("exe", this.graphvizExe);
            iniFile.SetString("dot", this.dotFileName);
            iniFile.SetString("png", this.pngFileName);
        }

        public void LoadSetting(string fileName)
        {
            string lang = iniFile.GetString("language", "");
            switch (lang)
            {
                case "":
                case "en":
                default:
                    this.languageType = LanguageType.English;
                    break;
                case "ja":
                    this.languageType = LanguageType.Japanese;
                    break;
            }
            this.graphvizExe = iniFile.GetString("exe", "C:\\Program Files\\Graphviz\\bin\\dot.exe");
            this.dotFileName = iniFile.GetString("dot", "temp.dot");
            this.pngFileName = iniFile.GetString("png", "temp.png");
            this.xmlFileName = "";
        }
    }
}
