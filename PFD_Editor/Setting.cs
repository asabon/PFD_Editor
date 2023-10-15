using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFD_Editor
{
    internal class Setting
    {
        public TreeNode treeRoot { get; set; }

        public Setting() 
        {
            treeRoot = new TreeNode();

            TreeNode plantUml = new TreeNode();
            plantUml.Text = "PlantUML";

            TreeNode plantUmlPath = new TreeNode();
            plantUmlPath.Text = "path";
            // "c:\\Tools\\PlantUML"

            TreeNode plantUmlJar = new TreeNode();
            plantUmlJar.Text = "jar";
            // "plantuml-1.2023.11.jar"

            treeRoot.Nodes.Add(plantUml);
            plantUml.Nodes.Add(plantUmlPath);
            plantUml.Nodes.Add(plantUmlJar);
        }

        public string GetValue(string name)
        {
            return "";
        }

        public void SaveSetting(string fileName)
        {

        }

        public void LoadSetting(string fileName)
        {

        }
    }
}
