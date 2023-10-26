using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PFD_Editor
{
    public partial class MainForm : Form
    {
        private TreeNode treeNode;
        private TreeNode addWorkProductNode;
        private TreeNode addProcessNode;
        private SettingEditor settingEditor;
        private PfdWorkProductEditor workProductEditor;
        private PfdProcessEditor processEditor;
        private Config config;

        private List<PfdWorkProduct> workProducts;
        private List<PfdProcess> processes;

        public MainForm()
        {
            InitializeComponent();
            config = new Config();
            config.LoadConfig("PfdEditor.ini");
            settingEditor = new SettingEditor();
            workProductEditor = new PfdWorkProductEditor();
            processEditor = new PfdProcessEditor();
            LoadSetting();
            InitializeData();
            treeNode = new TreeNode("PFDデータ");
        }

        private void InitializeData()
        {
            addWorkProductNode = new TreeNode("(追加)");
            addProcessNode = new TreeNode("(追加)");
            // データの初期化
            workProducts = new List<PfdWorkProduct>();
            processes = new List<PfdProcess>();
            // ツリーを生成
            TreeNode treeNodeworkProduct = new TreeNode("成果物");
            TreeNode treeNodeProcess = new TreeNode("プロセス");
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(treeNodeworkProduct);
            treeView1.Nodes.Add(treeNodeProcess);
            UpdateTreeView();
            // 表示モード初期化
            ノーマルToolStripMenuItem.Checked = true;
            ズームToolStripMenuItem.Checked = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void UpdateTreeView()
        {
            treeView1.Nodes[0].Nodes.Clear();
            foreach(PfdWorkProduct workProduct in workProducts)
            {
                TreeNode treeNodeWorkProduct = new TreeNode();
                treeNodeWorkProduct.Text = GetItemName(workProduct.id);
                treeNodeWorkProduct.Tag = workProduct;
                treeView1.Nodes[0].Nodes.Add(treeNodeWorkProduct);
            }
            treeView1.Nodes[0].Nodes.Add(addWorkProductNode);

            treeView1.Nodes[1].Nodes.Clear();
            foreach (PfdProcess process in processes)
            {
                TreeNode treeNodeProcess = new TreeNode();
                treeNodeProcess.Text = GetItemName(process.id);
                treeNodeProcess.Tag = process;
                treeView1.Nodes[1].Nodes.Add(treeNodeProcess);
            }
            treeView1.Nodes[1].Nodes.Add(addProcessNode);
            treeView1.ExpandAll();
        }

        private void LoadData(string filename)
        {
            InitializeData();
            XDocument xmlDocument = XDocument.Load(filename);
            XElement rootElement = xmlDocument.Element("PFD");
            foreach (XElement workProductElement in rootElement.Elements("WorkProduct"))
            {
                PfdWorkProduct workProduct = new PfdWorkProduct();
                workProduct.id = int.Parse(workProductElement.Element("ID").Value);
                workProduct.subject = workProductElement.Element("Subject").Value;
                workProduct.description = workProductElement.Element("Description").Value;
                workProducts.Add(workProduct);
            }
            foreach (XElement processElement in rootElement.Elements("Process"))
            {
                PfdProcess process = new PfdProcess();
                process.id = int.Parse(processElement.Element("ID").Value);
                process.subject = processElement.Element("Subject").Value;
                process.description = processElement.Element("Description").Value;
                foreach (XElement inputIdElement in processElement.Elements("Input"))
                {
                    int inputId = int.Parse(inputIdElement.Value);
                    process.inputIdList.Add(inputId);
                }
                foreach (XElement outputIdElement in processElement.Elements("Output"))
                {
                    int outputId = int.Parse(outputIdElement.Value);
                    process.outputIdList.Add(outputId);
                }
                processes.Add(process);
            }
            UpdateTreeView();
        }

        private void SaveData(string filename)
        {
            Encoding enc = Encoding.GetEncoding("UTF-8");
            StreamWriter writer = new StreamWriter(filename, false, enc);
            writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
            writer.WriteLine("<PFD>");
            foreach (PfdWorkProduct workProduct in workProducts)
            {
                writer.WriteLine("    <WorkProductInfo>");
                writer.WriteLine("        <ID>" + workProduct.id.ToString() + "</ID>");
                writer.WriteLine("        <Subject>" + workProduct.subject + "</Subject>");
                writer.WriteLine("        <Description>" + workProduct.description + "</Description>");
                writer.WriteLine("    </WorkProductInfo>");
            }
            foreach (PfdProcess process in processes)
            {
                writer.WriteLine("    <ProcessInfo>");
                writer.WriteLine("        <ID>" + process.id.ToString() + "</ID>");
                writer.WriteLine("        <Subject>" + process.subject + "</Subject>");
                writer.WriteLine("        <Description>" + process.description + "</Description>");
                writer.WriteLine("        <Inputs>");
                foreach (int inputId in process.inputIdList)
                {
                    writer.WriteLine("            <InputID>" + inputId + "</InputID>");
                }
                writer.WriteLine("        </Inputs>");
                writer.WriteLine("        <Outputs>");
                foreach (int outputId in process.outputIdList)
                {
                    writer.WriteLine("            <OutputID>" + outputId + "</OutputID>");
                }
                writer.WriteLine("        </Outputs>");
                writer.WriteLine("    </ProcessInfo>");
            }
            writer.WriteLine("</PFD>");
            writer.Close();
        }

        private void UpdateData()
        {
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeData();
            UpdateTitle("new");
            config.xmlFileName = "";
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                config.xmlFileName = openFileDialog1.FileName;
                LoadData(config.xmlFileName);
                UpdateTitle(config.xmlFileName);
                UpdateDiagram();
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (config.xmlFileName == "")
            {
                名前を付けて保存ToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveData(config.xmlFileName);
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                config.xmlFileName = saveFileDialog1.FileName;
                SaveData(config.xmlFileName);
                UpdateTitle(config.xmlFileName);
            }

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionInfo versionInfo = new VersionInfo();
            versionInfo.ShowDialog();
        }

        private String GetItemName(int id)
        {
            foreach (PfdWorkProduct pfdWorkProduct in workProducts)
            {
                if (id == pfdWorkProduct.id)
                {
                    return pfdWorkProduct.subject;
                }
            }
            foreach(PfdProcess pfdProcess in processes)
            {
                if (id == pfdProcess.id)
                {
                    return pfdProcess.subject;
                }
            }
            return "";
        }

        private int GetUniqueId()
        {
            int uniqueId = 0;
            foreach (PfdWorkProduct pfdWorkProduct in workProducts)
            {
                if (uniqueId <= pfdWorkProduct.id)
                {
                    uniqueId = pfdWorkProduct.id; 
                }
            }
            foreach (PfdProcess pfdProcess in processes)
            {
                if (uniqueId <= pfdProcess.id)
                {
                    uniqueId = pfdProcess.id;
                }
            }
            return ++uniqueId;
        }

        private void CreateWorkDotFile()
        {
            //Encoding enc = Encoding.GetEncoding("Shift-JIS");
            //StreamWriter writer = new StreamWriter(config.dotFileName, false, enc);
            StreamWriter writer = new StreamWriter(config.dotFileName, false);
            writer.WriteLine("digraph PFD {");
            writer.WriteLine("    graph [");
            writer.WriteLine("        fontname = \"MS Gothic\"");
            writer.WriteLine("    ]");
            writer.WriteLine("    node [");
            writer.WriteLine("        fontname = \"MS Gothic\"");
            writer.WriteLine("    ]");
            writer.WriteLine("    edge [");
            writer.WriteLine("        fontname = \"MS Gothic\"");
            writer.WriteLine("    ]");
            foreach (PfdWorkProduct workProduct in workProducts)
            {
                writer.WriteLine("    item" + workProduct.id.ToString() + " [label = " + workProduct.subject + ", shape = box];");
            }
            foreach (PfdProcess process in processes)
            {
                writer.WriteLine("    item" + process.id.ToString() + " [label = " + process.subject + "];");
            }
            foreach (PfdProcess process in processes)
            {
                foreach(int inputId in process.inputIdList)
                {
                    writer.WriteLine("    item" + inputId.ToString() + " -> item" + process.id.ToString() + ";");
                }
                foreach (int outputId in process.outputIdList)
                {
                    writer.WriteLine("    item" + process.id.ToString() + " -> item" + outputId.ToString() + ";");
                }
            }
            writer.WriteLine("}");
            writer.Close();
        }

        private void CreateWorkUmlFile()
        {
            Encoding enc = Encoding.GetEncoding("UTF-8");
            StreamWriter writer = new StreamWriter(config.umlFileName, false, enc);
            writer.WriteLine("@startuml");
            foreach(PfdWorkProduct workProduct in workProducts)
            {
                writer.WriteLine("    usecase \"" + workProduct.subject + "\" as item" + workProduct.id);
            }
            foreach (PfdProcess process in processes)
            {
                writer.WriteLine("    usecase \"" + process.subject + "\" as item" + process.id);
            }
            foreach(PfdProcess process in processes)
            {
                foreach(int inputId in process.inputIdList)
                {
                    writer.WriteLine("   item" + inputId + " --> item" + process.id);
                }
                foreach (int outputId in process.outputIdList)
                {
                    writer.WriteLine("   item" + process.id + " --> item" + outputId);
                }
            }
            writer.WriteLine("@enduml");
            writer.Close();
        }

        private void UpdateDiagram()
        {
            switch(config.generator)
            {
                case Config.Generator.Graphviz:
                    CreateWorkDotFile();
                    break;
                case Config.Generator.PlantUML:
                    CreateWorkUmlFile();
                    break;
                default:
                    // Error
                    return;
            }
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd";

            switch (config.generator)
            {
                case Config.Generator.Graphviz:
                    psi.Arguments = "/c \"" + config.graphvizExe + "\" -Tpng -o " + config.pngFileName + " " + config.dotFileName;
                    config.pngFileName = config.dotFileName.Replace(".dot", ".png");
                    break;
                case Config.Generator.PlantUML:
                    psi.Arguments = "/c " + config.plantUmlPath + "\\" + config.plantUmlJar + " " + config.umlFileName + " -charset UTF-8";
                    config.pngFileName = config.umlFileName.Replace(".uml", ".png");
                    break;
                default:
                    break;
            }
            psi.CreateNoWindow = true; // コンソール開かない
            psi.UseShellExecute = false; // シェル機能使用しない
            psi.RedirectStandardOutput = true; // 標準出力をリダイレクト
            toolStripMenuItem1.Text = "working ...";
            Process process_ = Process.Start(psi);
            process_.WaitForExit();
            process_.Close();
            toolStripMenuItem1.Text = "";
            pictureBox1.ImageLocation = config.pngFileName;
        }

        private void plantUMLの設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settingEditor.ShowDialog() == DialogResult.OK)
            {
                //SaveConfig();
            }
        }

        private void LoadSetting()
        {

        }

        private void SaveConfig()
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void UpdateTitle(string filename)
        {
            this.Text = "PFD Editor (" + filename + ")";
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode selectedTreeNode = treeView1.SelectedNode;
            TreeNode workProductRoot = treeView1.Nodes[0];
            TreeNode processRoot = treeView1.Nodes[1];
            PfdItem item = (PfdItem)(selectedTreeNode.Tag);
            if (selectedTreeNode == addWorkProductNode)
            {
                PfdWorkProduct workProduct = new PfdWorkProduct();
                workProduct.id = GetUniqueId();
                workProductEditor.SetItem(workProduct);
                if (workProductEditor.ShowDialog() == DialogResult.OK)
                {
                    TreeNode workProductNode = new TreeNode();
                    workProduct = workProductEditor.GetItem();
                    workProductNode.Text = workProduct.subject;
                    workProductNode.Tag = workProduct;
                    workProductRoot.Nodes.Insert(workProducts.Count, workProductNode);
                    workProducts.Add(workProduct);
                    UpdateDiagram();
                }
            }
            else if (selectedTreeNode == addProcessNode)
            {
                PfdProcess process = new PfdProcess();
                process.id = GetUniqueId();
                processEditor.SetItem(process, workProducts);
                if (processEditor.ShowDialog() == DialogResult.OK)
                {
                    TreeNode processNode = new TreeNode();
                    process = processEditor.GetItem();
                    processNode.Text = process.subject;
                    processNode.Tag = process;
                    processRoot.Nodes.Insert(processes.Count, processNode);
                    processes.Add(process);
                    UpdateDiagram();
                }
            }
            else
            {
                if (item != null)
                {
                    switch (item.type)
                    {
                        case PfdItem.PfdItemType.WorkProduct:
                            PfdWorkProduct pfdWorkProduct = (PfdWorkProduct)(selectedTreeNode.Tag);
                            workProductEditor.SetItem(pfdWorkProduct);
                            if (workProductEditor.ShowDialog() == DialogResult.OK)
                            {
                                pfdWorkProduct = workProductEditor.GetItem();
                                selectedTreeNode.Tag = pfdWorkProduct;
                                selectedTreeNode.Text = pfdWorkProduct.subject;
                                UpdateDiagram();
                            }
                            break;
                        case PfdItem.PfdItemType.Process:
                            PfdProcess pfdProcess = (PfdProcess)(selectedTreeNode.Tag);
                            processEditor.SetItem(pfdProcess, workProducts);
                            if (processEditor.ShowDialog() == DialogResult.OK)
                            {
                                pfdProcess = processEditor.GetItem();
                                workProducts = processEditor.GetWorkProductList();
                                selectedTreeNode.Tag = pfdProcess;
                                selectedTreeNode.Text = pfdProcess.subject;
                                UpdateDiagram();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void ノーマルToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode != PictureBoxSizeMode.Normal)
            {
                ノーマルToolStripMenuItem.Checked = true;
                ズームToolStripMenuItem.Checked = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                UpdateDiagram();
            }
        }

        private void ズームToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.SizeMode != PictureBoxSizeMode.Zoom)
            {
                ノーマルToolStripMenuItem.Checked = false;
                ズームToolStripMenuItem.Checked = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                UpdateDiagram();
            }
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Press delete key
            }
        }
    }
}
