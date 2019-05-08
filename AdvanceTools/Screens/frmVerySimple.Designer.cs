namespace TranslateUtility
{
    partial class frmVerySimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerySimple));
            this.btnGamePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoModTranslateFirst = new System.Windows.Forms.RadioButton();
            this.btnLegacyGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModVersion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInstallAlt = new System.Windows.Forms.Button();
            this.chkUiInfo = new System.Windows.Forms.CheckBox();
            this.chkUntranslateInfo = new System.Windows.Forms.CheckBox();
            this.chkTranslateInfo = new System.Windows.Forms.CheckBox();
            this.chkModDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.rdoModOriginFirst = new System.Windows.Forms.RadioButton();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGamePath
            // 
            this.btnGamePath.Location = new System.Drawing.Point(542, 23);
            this.btnGamePath.Name = "btnGamePath";
            this.btnGamePath.Size = new System.Drawing.Size(26, 23);
            this.btnGamePath.TabIndex = 7;
            this.btnGamePath.Text = "...";
            this.btnGamePath.UseVisualStyleBackColor = true;
            this.btnGamePath.Click += new System.EventHandler(this.btnGamePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "โฟลเดอร์เกม";
            // 
            // rdoModTranslateFirst
            // 
            this.rdoModTranslateFirst.AutoSize = true;
            this.rdoModTranslateFirst.Checked = true;
            this.rdoModTranslateFirst.Location = new System.Drawing.Point(25, 22);
            this.rdoModTranslateFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoModTranslateFirst.Name = "rdoModTranslateFirst";
            this.rdoModTranslateFirst.Size = new System.Drawing.Size(91, 17);
            this.rdoModTranslateFirst.TabIndex = 35;
            this.rdoModTranslateFirst.TabStop = true;
            this.rdoModTranslateFirst.Text = "ภาษาไทยก่อน";
            this.rdoModTranslateFirst.UseVisualStyleBackColor = true;
            // 
            // btnLegacyGenerate
            // 
            this.btnLegacyGenerate.Location = new System.Drawing.Point(493, 56);
            this.btnLegacyGenerate.Name = "btnLegacyGenerate";
            this.btnLegacyGenerate.Size = new System.Drawing.Size(75, 92);
            this.btnLegacyGenerate.TabIndex = 33;
            this.btnLegacyGenerate.Text = "ติดตั้ง";
            this.btnLegacyGenerate.UseVisualStyleBackColor = true;
            this.btnLegacyGenerate.Click += new System.EventHandler(this.btnLegacyGenerate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "สร้าง mod ครั้งล่าสุด : ";
            // 
            // lblModVersion
            // 
            this.lblModVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModVersion.AutoSize = true;
            this.lblModVersion.Location = new System.Drawing.Point(116, 216);
            this.lblModVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModVersion.Name = "lblModVersion";
            this.lblModVersion.Size = new System.Drawing.Size(27, 13);
            this.lblModVersion.TabIndex = 29;
            this.lblModVersion.Text = "N/A";
            this.lblModVersion.DoubleClick += new System.EventHandler(this.lblModVersion_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkModDoubleLanguage);
            this.groupBox1.Controls.Add(this.rdoModTranslateFirst);
            this.groupBox1.Controls.Add(this.rdoModOriginFirst);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 47);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สองภาษา";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUiInfo);
            this.groupBox2.Controls.Add(this.chkUntranslateInfo);
            this.groupBox2.Controls.Add(this.chkTranslateInfo);
            this.groupBox2.Location = new System.Drawing.Point(15, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 43);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "แสดงรายละเอียดข้อความ";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Location = new System.Drawing.Point(256, 212);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(309, 23);
            this.lblVersion.TabIndex = 47;
            this.lblVersion.Text = "Version : 1.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "ข้อมูลการแปล";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(103, 19);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(91, 23);
            this.btnRestore.TabIndex = 49;
            this.btnRestore.Text = "ถอนการติดตั้ง";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInstallAlt);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Location = new System.Drawing.Point(15, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 53);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "อื่นๆ";
            // 
            // btnInstallAlt
            // 
            this.btnInstallAlt.Location = new System.Drawing.Point(456, 19);
            this.btnInstallAlt.Name = "btnInstallAlt";
            this.btnInstallAlt.Size = new System.Drawing.Size(91, 23);
            this.btnInstallAlt.TabIndex = 50;
            this.btnInstallAlt.Text = "ติดตั้ง (beta)";
            this.btnInstallAlt.UseVisualStyleBackColor = true;
            this.btnInstallAlt.Click += new System.EventHandler(this.btnInstallAlt_Click);
            // 
            // chkUiInfo
            // 
            this.chkUiInfo.AutoSize = true;
            this.chkUiInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleUiInfo;
            this.chkUiInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleUiInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUiInfo.Location = new System.Drawing.Point(203, 19);
            this.chkUiInfo.Name = "chkUiInfo";
            this.chkUiInfo.Size = new System.Drawing.Size(37, 17);
            this.chkUiInfo.TabIndex = 40;
            this.chkUiInfo.Text = "UI";
            this.chkUiInfo.UseVisualStyleBackColor = true;
            // 
            // chkUntranslateInfo
            // 
            this.chkUntranslateInfo.AutoSize = true;
            this.chkUntranslateInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleUntranslateInfo;
            this.chkUntranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleUntranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUntranslateInfo.Location = new System.Drawing.Point(25, 19);
            this.chkUntranslateInfo.Name = "chkUntranslateInfo";
            this.chkUntranslateInfo.Size = new System.Drawing.Size(92, 17);
            this.chkUntranslateInfo.TabIndex = 37;
            this.chkUntranslateInfo.Text = "ที่ยังไม่ได้แปล";
            this.chkUntranslateInfo.UseVisualStyleBackColor = true;
            // 
            // chkTranslateInfo
            // 
            this.chkTranslateInfo.AutoSize = true;
            this.chkTranslateInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleTranslateInfo;
            this.chkTranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleTranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTranslateInfo.Location = new System.Drawing.Point(123, 19);
            this.chkTranslateInfo.Name = "chkTranslateInfo";
            this.chkTranslateInfo.Size = new System.Drawing.Size(74, 17);
            this.chkTranslateInfo.TabIndex = 39;
            this.chkTranslateInfo.Text = "ที่แปลแล้ว";
            this.chkTranslateInfo.UseVisualStyleBackColor = true;
            // 
            // chkModDoubleLanguage
            // 
            this.chkModDoubleLanguage.AutoSize = true;
            this.chkModDoubleLanguage.Checked = global::TranslateUtility.Properties.Settings.Default._Simple2Language;
            this.chkModDoubleLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModDoubleLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_Simple2Language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkModDoubleLanguage.Location = new System.Drawing.Point(9, 0);
            this.chkModDoubleLanguage.Name = "chkModDoubleLanguage";
            this.chkModDoubleLanguage.Size = new System.Drawing.Size(68, 17);
            this.chkModDoubleLanguage.TabIndex = 36;
            this.chkModDoubleLanguage.Text = "สองภาษา";
            this.chkModDoubleLanguage.UseVisualStyleBackColor = true;
            this.chkModDoubleLanguage.CheckedChanged += new System.EventHandler(this.chkModDoubleLanguage_CheckedChanged);
            // 
            // rdoModOriginFirst
            // 
            this.rdoModOriginFirst.AutoSize = true;
            this.rdoModOriginFirst.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleOriginalFirst;
            this.rdoModOriginFirst.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleOriginalFirst", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoModOriginFirst.Location = new System.Drawing.Point(123, 22);
            this.rdoModOriginFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoModOriginFirst.Name = "rdoModOriginFirst";
            this.rdoModOriginFirst.Size = new System.Drawing.Size(104, 17);
            this.rdoModOriginFirst.TabIndex = 34;
            this.rdoModOriginFirst.Text = "ภาษาอังกฤษก่อน";
            this.rdoModOriginFirst.UseVisualStyleBackColor = true;
            // 
            // txtGamePath
            // 
            this.txtGamePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_SimpleModPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGamePath.Location = new System.Drawing.Point(15, 25);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(521, 20);
            this.txtGamePath.TabIndex = 6;
            this.txtGamePath.Text = global::TranslateUtility.Properties.Settings.Default._SimpleModPath;
            this.txtGamePath.TextChanged += new System.EventHandler(this.txtGamePath_TextChanged);
            // 
            // frmVerySimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLegacyGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGamePath);
            this.Controls.Add(this.txtGamePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVerySimple";
            this.Text = "The Witcher 3 Translate Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerySimple_FormClosing);
            this.Load += new System.EventHandler(this.frmVerySimple_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGamePath;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTranslateInfo;
        private System.Windows.Forms.CheckBox chkUntranslateInfo;
        private System.Windows.Forms.RadioButton rdoModTranslateFirst;
        private System.Windows.Forms.RadioButton rdoModOriginFirst;
        private System.Windows.Forms.CheckBox chkModDoubleLanguage;
        private System.Windows.Forms.Button btnLegacyGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkUiInfo;
        private System.Windows.Forms.Button btnInstallAlt;
    }
}