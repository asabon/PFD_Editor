using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PFD_Editor
{
    public partial class SettingEditor : Form
    {
        public SettingEditor()
        {
            InitializeComponent();
            Setting setting = new Setting();
            treeView1.Nodes.Add(setting.treeRoot);
            treeView1.ExpandAll();
        }
    }
}
