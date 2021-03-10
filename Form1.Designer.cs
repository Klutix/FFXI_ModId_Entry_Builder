namespace FFXIExtractSharp
{
    partial class frmMain
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
            this.lstModValues = new System.Windows.Forms.ListBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.sd = new System.Windows.Forms.Label();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAddedValues = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPetId = new System.Windows.Forms.Label();
            this.cboPetId = new System.Windows.Forms.ComboBox();
            this.txtSelectedPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModValue = new System.Windows.Forms.TextBox();
            this.txtSelectedItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstModValues
            // 
            this.lstModValues.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstModValues.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstModValues.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstModValues.FormattingEnabled = true;
            this.lstModValues.ItemHeight = 19;
            this.lstModValues.Location = new System.Drawing.Point(17, 82);
            this.lstModValues.Name = "lstModValues";
            this.lstModValues.Size = new System.Drawing.Size(331, 327);
            this.lstModValues.TabIndex = 4;
            this.lstModValues.SelectedIndexChanged += new System.EventHandler(this.lstModValues_SelectedIndexChanged);
            this.lstModValues.Enter += new System.EventHandler(this.lstModValues_Enter);
            this.lstModValues.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstModValues_KeyPress);
            this.lstModValues.Leave += new System.EventHandler(this.lstModValues_Leave);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFilter.Location = new System.Drawing.Point(20, 41);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(110, 27);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sd.Location = new System.Drawing.Point(16, 18);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(100, 19);
            this.sd.TabIndex = 2;
            this.sd.Text = "ModId Filter";
            this.sd.Click += new System.EventHandler(this.sd_Click);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtItemSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtItemSearch.Location = new System.Drawing.Point(16, 40);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(374, 27);
            this.txtItemSearch.TabIndex = 1;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            this.txtItemSearch.Enter += new System.EventHandler(this.txtItemSearch_Enter);
            this.txtItemSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemSearch_KeyPress);
            this.txtItemSearch.Leave += new System.EventHandler(this.txtItemSearch_Leave);
            // 
            // lstItems
            // 
            this.lstItems.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstItems.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 19;
            this.lstItems.Location = new System.Drawing.Point(16, 73);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(374, 137);
            this.lstItems.TabIndex = 2;
            this.lstItems.Click += new System.EventHandler(this.lstItems_Click);
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            this.lstItems.Enter += new System.EventHandler(this.lstItems_Enter);
            this.lstItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstItems_KeyPress);
            this.lstItems.Leave += new System.EventHandler(this.lstItems_Leave);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.ForeColor = System.Drawing.SystemColors.Info;
            this.rtxtDescription.Location = new System.Drawing.Point(400, 40);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(665, 170);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(396, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Search";
            // 
            // lstAddedValues
            // 
            this.lstAddedValues.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstAddedValues.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAddedValues.ForeColor = System.Drawing.Color.White;
            this.lstAddedValues.FormattingEnabled = true;
            this.lstAddedValues.ItemHeight = 19;
            this.lstAddedValues.Location = new System.Drawing.Point(527, 82);
            this.lstAddedValues.Name = "lstAddedValues";
            this.lstAddedValues.Size = new System.Drawing.Size(554, 327);
            this.lstAddedValues.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(358, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">>>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(358, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 33);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "<<<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Black;
            this.btnExport.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(527, 14);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(245, 30);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export(.csv)";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItemSearch);
            this.groupBox1.Controls.Add(this.lstItems);
            this.groupBox1.Controls.Add(this.rtxtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 225);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPetId);
            this.groupBox2.Controls.Add(this.cboPetId);
            this.groupBox2.Controls.Add(this.txtSelectedPath);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtModValue);
            this.groupBox2.Controls.Add(this.txtSelectedItem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstModValues);
            this.groupBox2.Controls.Add(this.txtFilter);
            this.groupBox2.Controls.Add(this.sd);
            this.groupBox2.Controls.Add(this.lstAddedValues);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1087, 415);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // lblPetId
            // 
            this.lblPetId.AutoSize = true;
            this.lblPetId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetId.Location = new System.Drawing.Point(358, 20);
            this.lblPetId.Name = "lblPetId";
            this.lblPetId.Size = new System.Drawing.Size(53, 19);
            this.lblPetId.TabIndex = 24;
            this.lblPetId.Text = "Pet Id";
            // 
            // cboPetId
            // 
            this.cboPetId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboPetId.FormattingEnabled = true;
            this.cboPetId.Items.AddRange(new object[] {
            "All",
            "Avatar",
            "Wyvern",
            "Automaton",
            "Harlequin",
            "Valoredge",
            "Sharpshot",
            "Stormwaker",
            "Luopan",
            "NA \t\t"});
            this.cboPetId.Location = new System.Drawing.Point(358, 41);
            this.cboPetId.Name = "cboPetId";
            this.cboPetId.Size = new System.Drawing.Size(121, 27);
            this.cboPetId.TabIndex = 23;
            this.cboPetId.Text = "NA";
            this.cboPetId.SelectedIndexChanged += new System.EventHandler(this.cboPetId_SelectedIndexChanged);
            // 
            // txtSelectedPath
            // 
            this.txtSelectedPath.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSelectedPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedPath.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSelectedPath.Location = new System.Drawing.Point(527, 49);
            this.txtSelectedPath.Name = "txtSelectedPath";
            this.txtSelectedPath.ReadOnly = true;
            this.txtSelectedPath.Size = new System.Drawing.Size(209, 27);
            this.txtSelectedPath.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(742, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 26);
            this.button2.TabIndex = 21;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(354, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 37);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Item Id";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(287, 40);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(60, 27);
            this.txtId.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Value";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtModValue
            // 
            this.txtModValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtModValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModValue.Location = new System.Drawing.Point(416, 125);
            this.txtModValue.Name = "txtModValue";
            this.txtModValue.Size = new System.Drawing.Size(49, 27);
            this.txtModValue.TabIndex = 5;
            this.txtModValue.Enter += new System.EventHandler(this.txtModValue_Enter);
            this.txtModValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModValue_KeyPress);
            this.txtModValue.Leave += new System.EventHandler(this.txtModValue_Leave);
            // 
            // txtSelectedItem
            // 
            this.txtSelectedItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSelectedItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedItem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSelectedItem.Location = new System.Drawing.Point(151, 41);
            this.txtSelectedItem.Name = "txtSelectedItem";
            this.txtSelectedItem.ReadOnly = true;
            this.txtSelectedItem.Size = new System.Drawing.Size(130, 27);
            this.txtSelectedItem.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item Selected";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1111, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "FFMODIDAssist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstModValues;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAddedValues;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModValue;
        private System.Windows.Forms.TextBox txtSelectedItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSelectedPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cboPetId;
        private System.Windows.Forms.Label lblPetId;
    }
}

