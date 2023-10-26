namespace PFD_Editor
{
    partial class PfdProcessEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PfdProcessEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddInput = new System.Windows.Forms.Button();
            this.buttonDeleteInput = new System.Windows.Forms.Button();
            this.buttonDeleteOutput = new System.Windows.Forms.Button();
            this.buttonAddOutput = new System.Windows.Forms.Button();
            this.listBoxWorkProduct = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxSubject
            // 
            resources.ApplyResources(this.textBoxSubject, "textBoxSubject");
            this.textBoxSubject.Name = "textBoxSubject";
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxId
            // 
            resources.ApplyResources(this.textBoxId, "textBoxId");
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxInput
            // 
            resources.ApplyResources(this.listBoxInput, "listBoxInput");
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.SelectedIndexChanged += new System.EventHandler(this.listBoxInput_SelectedIndexChanged);
            this.listBoxInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxInput_MouseDoubleClick);
            // 
            // listBoxOutput
            // 
            resources.ApplyResources(this.listBoxOutput, "listBoxOutput");
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Name = "listBoxOutput";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // buttonAddInput
            // 
            resources.ApplyResources(this.buttonAddInput, "buttonAddInput");
            this.buttonAddInput.Name = "buttonAddInput";
            this.buttonAddInput.UseVisualStyleBackColor = true;
            this.buttonAddInput.Click += new System.EventHandler(this.buttonAddInput_Click);
            // 
            // buttonDeleteInput
            // 
            resources.ApplyResources(this.buttonDeleteInput, "buttonDeleteInput");
            this.buttonDeleteInput.Name = "buttonDeleteInput";
            this.buttonDeleteInput.UseVisualStyleBackColor = true;
            this.buttonDeleteInput.Click += new System.EventHandler(this.buttonDeleteInput_Click);
            // 
            // buttonDeleteOutput
            // 
            resources.ApplyResources(this.buttonDeleteOutput, "buttonDeleteOutput");
            this.buttonDeleteOutput.Name = "buttonDeleteOutput";
            this.buttonDeleteOutput.UseVisualStyleBackColor = true;
            this.buttonDeleteOutput.Click += new System.EventHandler(this.buttonDeleteOutput_Click);
            // 
            // buttonAddOutput
            // 
            resources.ApplyResources(this.buttonAddOutput, "buttonAddOutput");
            this.buttonAddOutput.Name = "buttonAddOutput";
            this.buttonAddOutput.UseVisualStyleBackColor = true;
            this.buttonAddOutput.Click += new System.EventHandler(this.buttonAddOutput_Click);
            // 
            // listBoxWorkProduct
            // 
            resources.ApplyResources(this.listBoxWorkProduct, "listBoxWorkProduct");
            this.listBoxWorkProduct.FormattingEnabled = true;
            this.listBoxWorkProduct.Name = "listBoxWorkProduct";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // PfdProcessEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxWorkProduct);
            this.Controls.Add(this.buttonDeleteOutput);
            this.Controls.Add(this.buttonAddOutput);
            this.Controls.Add(this.buttonDeleteInput);
            this.Controls.Add(this.buttonAddInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PfdProcessEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddInput;
        private System.Windows.Forms.Button buttonDeleteInput;
        private System.Windows.Forms.Button buttonDeleteOutput;
        private System.Windows.Forms.Button buttonAddOutput;
        private System.Windows.Forms.ListBox listBoxWorkProduct;
        private System.Windows.Forms.Label label6;
    }
}