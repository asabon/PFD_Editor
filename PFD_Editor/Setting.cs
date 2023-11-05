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
            iniFile.SetString("exe", this.graphvizExe);
        }

        public void LoadSetting(string fileName)
        {
            this.graphvizExe = iniFile.GetString("exe", "C:\\Program Files\\Graphviz\\bin\\dot.exe");
            this.dotFileName = "temp.dot";
            this.pngFileName = "temp.png";
            this.xmlFileName = "";
        }
    }
}
