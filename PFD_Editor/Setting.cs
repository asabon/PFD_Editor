using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFD_Editor
{
    public class Setting
    {
        public string graphvizExe { get; set; }
        public string xmlFileName { get; set; }
        public string dotFileName { get; set; }
        public string pngFileName { get; set; }

        public Setting()
        {
            this.graphvizExe = "C:\\Program Files\\Graphviz\\bin\\dot.exe";
            this.xmlFileName = "";
            this.dotFileName = "temp.dot";
            this.pngFileName = "temp.png";
        }

        public void SaveSetting(string fileName)
        {

        }

        public void LoadSetting(string fileName)
        {

        }
    }
}
