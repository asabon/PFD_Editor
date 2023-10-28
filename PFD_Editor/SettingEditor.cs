using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PFD_Editor
{
    public partial class SettingEditor : Form
    {
        private Setting setting;

        public SettingEditor()
        {
            InitializeComponent();
        }

        public void SetSetting(Setting setting)
        {
            this.setting = setting;
            this.textBox1.Text = setting.graphvizExe;
        }

        public Setting GetSetting()
        {
            return this.setting;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.setting.graphvizExe = this.textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "exe";
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(this.textBox1.Text);
            openFileDialog1.FileName = Path.GetFileName(this.textBox1.Text);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string graphvizExe = openFileDialog1.FileName;
                textBox1.Text = graphvizExe;
                this.setting.graphvizExe = graphvizExe;
            }
        }
    }
}
