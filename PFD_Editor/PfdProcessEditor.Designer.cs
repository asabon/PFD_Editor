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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイトル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "説明";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(58, 31);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(321, 19);
            this.textBoxSubject.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(58, 56);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(321, 108);
            this.textBoxDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(58, 6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(321, 19);
            this.textBoxId.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "キャンセル";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.ItemHeight = 12;
            this.listBoxInput.Location = new System.Drawing.Point(14, 189);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.Size = new System.Drawing.Size(177, 136);
            this.listBoxInput.TabIndex = 8;
            this.listBoxInput.SelectedIndexChanged += new System.EventHandler(this.listBoxInput_SelectedIndexChanged);
            this.listBoxInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxInput_MouseDoubleClick);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 12;
            this.listBoxOutput.Location = new System.Drawing.Point(197, 189);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(177, 136);
            this.listBoxOutput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "アウトプット";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "インプット";
            // 
            // buttonAddInput
            // 
            this.buttonAddInput.Location = new System.Drawing.Point(12, 331);
            this.buttonAddInput.Name = "buttonAddInput";
            this.buttonAddInput.Size = new System.Drawing.Size(75, 23);
            this.buttonAddInput.TabIndex = 19;
            this.buttonAddInput.Text = "追加";
            this.buttonAddInput.UseVisualStyleBackColor = true;
            this.buttonAddInput.Click += new System.EventHandler(this.buttonAddInput_Click);
            // 
            // buttonDeleteInput
            // 
            this.buttonDeleteInput.Location = new System.Drawing.Point(93, 331);
            this.buttonDeleteInput.Name = "buttonDeleteInput";
            this.buttonDeleteInput.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteInput.TabIndex = 20;
            this.buttonDeleteInput.Text = "削除";
            this.buttonDeleteInput.UseVisualStyleBackColor = true;
            this.buttonDeleteInput.Click += new System.EventHandler(this.buttonDeleteInput_Click);
            // 
            // buttonDeleteOutput
            // 
            this.buttonDeleteOutput.Location = new System.Drawing.Point(278, 331);
            this.buttonDeleteOutput.Name = "buttonDeleteOutput";
            this.buttonDeleteOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOutput.TabIndex = 22;
            this.buttonDeleteOutput.Text = "削除";
            this.buttonDeleteOutput.UseVisualStyleBackColor = true;
            this.buttonDeleteOutput.Click += new System.EventHandler(this.buttonDeleteOutput_Click);
            // 
            // buttonAddOutput
            // 
            this.buttonAddOutput.Location = new System.Drawing.Point(197, 331);
            this.buttonAddOutput.Name = "buttonAddOutput";
            this.buttonAddOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOutput.TabIndex = 21;
            this.buttonAddOutput.Text = "追加";
            this.buttonAddOutput.UseVisualStyleBackColor = true;
            this.buttonAddOutput.Click += new System.EventHandler(this.buttonAddOutput_Click);
            // 
            // listBoxWorkProduct
            // 
            this.listBoxWorkProduct.FormattingEnabled = true;
            this.listBoxWorkProduct.ItemHeight = 12;
            this.listBoxWorkProduct.Location = new System.Drawing.Point(14, 383);
            this.listBoxWorkProduct.Name = "listBoxWorkProduct";
            this.listBoxWorkProduct.Size = new System.Drawing.Size(360, 172);
            this.listBoxWorkProduct.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "成果物";
            // 
            // PfdProcessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 603);
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
            this.Text = "プロセスエディット";
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