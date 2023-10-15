using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PFD_Editor.Config;

namespace PFD_Editor
{
    internal class Config
    {
        public enum Generator
        {
            PlantUML,
            Graphviz
        }
        public Generator generator { get; set; }
        public String graphvizExe { get; set; }
        public String plantUmlPath { get; set; }
        public String plantUmlJar { get; set; }
        public String dotFileName { get; set; }
        public String umlFileName { get; set; }
        public String xmlFileName { get; set; }
        public String pngFileName { get; set; }

        public Config()
        {
            generator = Generator.Graphviz;
            // Graphviz
            graphvizExe = "C:\\Program Files\\Graphviz\\bin\\dot.exe";
            dotFileName = "temp.dot";
            // PlantUML
            plantUmlPath = "c:\\Tools\\PlantUML";
            plantUmlJar = "plantuml-1.2023.11.jar";
            umlFileName = "temp.uml";
            // Common
            xmlFileName = "";
            pngFileName = "temp.png";
        }

        public void LoadConfig(string filename)
        {

        }

        public void SaveConfig(string filename)
        {

        }
    }
}
