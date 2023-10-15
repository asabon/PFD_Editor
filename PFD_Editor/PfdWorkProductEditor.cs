using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFD_Editor
{
    public partial class PfdWorkProductEditor : Form
    {
        private PfdWorkProduct m_item;
        public PfdWorkProductEditor()
        {
            InitializeComponent();
        }

        public void SetItem(PfdWorkProduct item)
        {
            m_item = item;
            textBoxId.Text = item.id.ToString();
            textBoxSubject.Text = item.subject;
            textBoxDescription.Text = item.description;
        }

        public PfdWorkProduct GetItem()
        {
            return m_item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_item.subject = textBoxSubject.Text;
            m_item.description = textBoxDescription.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
