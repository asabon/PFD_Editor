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
    public partial class PfdProcessEditor : Form
    {
        private PfdProcess m_item;
        private List<PfdWorkProduct> m_workProductList;

        public PfdProcessEditor()
        {
            InitializeComponent();
        }

        public void SetItem(PfdProcess item, List<PfdWorkProduct> workProducts)
        {
            m_item = item;
            m_workProductList = workProducts;
            textBoxId.Text = item.id.ToString();
            textBoxSubject.Text = item.subject;
            textBoxDescription.Text = item.description;
            UpdateListBox();
        }

        private string GetWorkProductSubject(int id)
        {
            foreach(PfdWorkProduct workProduct in m_workProductList)
            {
                if (workProduct.id == id)
                {
                    return workProduct.subject;
                }
            }
            return "";
        }

        private void UpdateListBox()
        {
            // ListboxInput
            listBoxInput.Items.Clear();
            foreach (int inputId in m_item.inputIdList)
            {
                listBoxInput.Items.Add(GetWorkProductSubject(inputId));
            }

            // ListboxOutput
            listBoxOutput.Items.Clear();
            foreach (int outputId in m_item.outputIdList)
            {
                listBoxOutput.Items.Add(GetWorkProductSubject(outputId));
            }

            // ListboxWorkProduct
            listBoxWorkProduct.Items.Clear();
            foreach(PfdWorkProduct workProduct in m_workProductList)
            {
                listBoxWorkProduct.Items.Add(workProduct.subject);
            }
        }

        public PfdProcess GetItem()
        {
            return m_item;
        }

        public List<PfdWorkProduct> GetWorkProductList()
        {
            return m_workProductList;
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

        private void listBoxInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBoxInput.SelectedIndex;
        }

        private void buttonAddInput_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxWorkProduct.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < m_workProductList.Count)
            {
                bool isExist = false;
                foreach(int inputId in m_item.inputIdList)
                {
                    if (inputId == m_workProductList[selectedIndex].id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    // Add Input
                    m_item.inputIdList.Add(m_workProductList[selectedIndex].id);
                    UpdateListBox();
                }
            }
        }

        private void buttonDeleteInput_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxInput.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < m_item.inputIdList.Count)
            {
                m_item.inputIdList.RemoveAt(selectedIndex);
                UpdateListBox();
            }
        }

        private void buttonAddOutput_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxWorkProduct.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < m_workProductList.Count)
            {
                bool isExist = false;
                foreach (int outputId in m_item.outputIdList)
                {
                    if (outputId == m_workProductList[selectedIndex].id)
                    {
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    // Add Input
                    m_item.outputIdList.Add(m_workProductList[selectedIndex].id);
                    UpdateListBox();
                }
            }
        }

        private void buttonDeleteOutput_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxOutput.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < m_item.outputIdList.Count)
            {
                m_item.outputIdList.RemoveAt(selectedIndex);
                UpdateListBox();
            }
        }
    }
}
