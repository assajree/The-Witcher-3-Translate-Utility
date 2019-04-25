namespace TranslateUtility
{
    partial class frmVeryVerySimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeryVerySimple));
            this.btnGamePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoModTranslateFirst = new System.Windows.Forms.RadioButton();
            this.btnLegacyGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModVersion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkModDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.rdoModOriginFirst = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUiInfo = new System.Windows.Forms.CheckBox();
            this.chkUntranslateInfo = new System.Windows.Forms.CheckBox();
            this.chkTranslateInfo = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.lblAdvance = new System.Windows.Forms.LinkLabel();
            this.pnAdvance = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnAdvance.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGamePath
            // 
            this.btnGamePath.Location = new System.Drawing.Point(723, 33);
            this.btnGamePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGamePath.Name = "btnGamePath";
            this.btnGamePath.Size = new System.Drawing.Size(35, 28);
            this.btnGamePath.TabIndex = 7;
            this.btnGamePath.Text = "...";
            this.btnGamePath.UseVisualStyleBackColor = true;
            this.btnGamePath.Click += new System.EventHandler(this.btnGamePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "โฟลเดอร์เกม :";
            // 
            // rdoModTranslateFirst
            // 
            this.rdoModTranslateFirst.AutoSize = true;
            this.rdoModTranslateFirst.Checked = true;
            this.rdoModTranslateFirst.Location = new System.Drawing.Point(33, 27);
            this.rdoModTranslateFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoModTranslateFirst.Name = "rdoModTranslateFirst";
            this.rdoModTranslateFirst.Size = new System.Drawing.Size(104, 21);
            this.rdoModTranslateFirst.TabIndex = 35;
            this.rdoModTranslateFirst.TabStop = true;
            this.rdoModTranslateFirst.Text = "ภาษาไทยก่อน";
            this.rdoModTranslateFirst.UseVisualStyleBackColor = true;
            // 
            // btnLegacyGenerate
            // 
            this.btnLegacyGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLegacyGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLegacyGenerate.Location = new System.Drawing.Point(313, 68);
            this.btnLegacyGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLegacyGenerate.Name = "btnLegacyGenerate";
            this.btnLegacyGenerate.Size = new System.Drawing.Size(148, 42);
            this.btnLegacyGenerate.TabIndex = 33;
            this.btnLegacyGenerate.Text = "ติดตั้ง";
            this.btnLegacyGenerate.UseVisualStyleBackColor = true;
            this.btnLegacyGenerate.Click += new System.EventHandler(this.btnLegacyGenerate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "สร้าง mod ครั้งล่าสุด : ";
            this.label1.Visible = false;
            // 
            // lblModVersion
            // 
            this.lblModVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModVersion.AutoSize = true;
            this.lblModVersion.Location = new System.Drawing.Point(255, 320);
            this.lblModVersion.Name = "lblModVersion";
            this.lblModVersion.Size = new System.Drawing.Size(31, 17);
            this.lblModVersion.TabIndex = 29;
            this.lblModVersion.Text = "N/A";
            this.lblModVersion.Visible = false;
            this.lblModVersion.DoubleClick += new System.EventHandler(this.lblModVersion_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkModDoubleLanguage);
            this.groupBox1.Controls.Add(this.rdoModTranslateFirst);
            this.groupBox1.Controls.Add(this.rdoModOriginFirst);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(725, 58);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สองภาษา";
            // 
            // chkModDoubleLanguage
            // 
            this.chkModDoubleLanguage.AutoSize = true;
            this.chkModDoubleLanguage.Checked = global::TranslateUtility.Properties.Settings.Default._Simple2Language;
            this.chkModDoubleLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModDoubleLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_Simple2Language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkModDoubleLanguage.Location = new System.Drawing.Point(12, 0);
            this.chkModDoubleLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkModDoubleLanguage.Name = "chkModDoubleLanguage";
            this.chkModDoubleLanguage.Size = new System.Drawing.Size(79, 21);
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
            this.rdoModOriginFirst.Location = new System.Drawing.Point(164, 27);
            this.rdoModOriginFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoModOriginFirst.Name = "rdoModOriginFirst";
            this.rdoModOriginFirst.Size = new System.Drawing.Size(120, 21);
            this.rdoModOriginFirst.TabIndex = 34;
            this.rdoModOriginFirst.Text = "ภาษาอังกฤษก่อน";
            this.rdoModOriginFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUiInfo);
            this.groupBox2.Controls.Add(this.chkUntranslateInfo);
            this.groupBox2.Controls.Add(this.chkTranslateInfo);
            this.groupBox2.Location = new System.Drawing.Point(4, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(725, 53);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "แสดงรายละเอียดข้อความ";
            // 
            // chkUiInfo
            // 
            this.chkUiInfo.AutoSize = true;
            this.chkUiInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleUiInfo;
            this.chkUiInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleUiInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUiInfo.Location = new System.Drawing.Point(271, 23);
            this.chkUiInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUiInfo.Name = "chkUiInfo";
            this.chkUiInfo.Size = new System.Drawing.Size(43, 21);
            this.chkUiInfo.TabIndex = 40;
            this.chkUiInfo.Text = "UI";
            this.chkUiInfo.UseVisualStyleBackColor = true;
            // 
            // chkUntranslateInfo
            // 
            this.chkUntranslateInfo.AutoSize = true;
            this.chkUntranslateInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleUntranslateInfo;
            this.chkUntranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleUntranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUntranslateInfo.Location = new System.Drawing.Point(33, 23);
            this.chkUntranslateInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUntranslateInfo.Name = "chkUntranslateInfo";
            this.chkUntranslateInfo.Size = new System.Drawing.Size(104, 21);
            this.chkUntranslateInfo.TabIndex = 37;
            this.chkUntranslateInfo.Text = "ที่ยังไม่ได้แปล";
            this.chkUntranslateInfo.UseVisualStyleBackColor = true;
            // 
            // chkTranslateInfo
            // 
            this.chkTranslateInfo.AutoSize = true;
            this.chkTranslateInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleTranslateInfo;
            this.chkTranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleTranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTranslateInfo.Location = new System.Drawing.Point(164, 23);
            this.chkTranslateInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTranslateInfo.Name = "chkTranslateInfo";
            this.chkTranslateInfo.Size = new System.Drawing.Size(83, 21);
            this.chkTranslateInfo.TabIndex = 39;
            this.chkTranslateInfo.Text = "ที่แปลแล้ว";
            this.chkTranslateInfo.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Location = new System.Drawing.Point(341, 316);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(412, 28);
            this.lblVersion.TabIndex = 47;
            this.lblVersion.Text = "Version : 1.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(8, 23);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(121, 28);
            this.btnResult.TabIndex = 48;
            this.btnResult.Text = "ข้อมูลการแปล";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(137, 23);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(121, 28);
            this.btnRestore.TabIndex = 49;
            this.btnRestore.Text = "ถอนการติดตั้ง";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResult);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Location = new System.Drawing.Point(4, 129);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(725, 65);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "อื่นๆ";
            // 
            // txtGamePath
            // 
            this.txtGamePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_SimpleModPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGamePath.Location = new System.Drawing.Point(20, 36);
            this.txtGamePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(693, 22);
            this.txtGamePath.TabIndex = 6;
            this.txtGamePath.Text = global::TranslateUtility.Properties.Settings.Default._SimpleModPath;
            this.txtGamePath.TextChanged += new System.EventHandler(this.txtGamePath_TextChanged);
            this.txtGamePath.DoubleClick += new System.EventHandler(this.txtGamePath_DoubleClick);
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Location = new System.Drawing.Point(20, 113);
            this.lblAdvance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(38, 17);
            this.lblAdvance.TabIndex = 51;
            this.lblAdvance.TabStop = true;
            this.lblAdvance.Text = "ขั้นสูง";
            this.lblAdvance.Click += new System.EventHandler(this.lblAdvance_Click);
            // 
            // pnAdvance
            // 
            this.pnAdvance.Controls.Add(this.groupBox1);
            this.pnAdvance.Controls.Add(this.groupBox2);
            this.pnAdvance.Controls.Add(this.groupBox3);
            this.pnAdvance.Location = new System.Drawing.Point(20, 133);
            this.pnAdvance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnAdvance.Name = "pnAdvance";
            this.pnAdvance.Size = new System.Drawing.Size(733, 206);
            this.pnAdvance.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(313, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 53;
            this.button1.Text = "ติดตั้ง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // frmVeryVerySimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 347);
            this.Controls.Add(this.btnLegacyGenerate);
            this.Controls.Add(this.pnAdvance);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModVersion);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGamePath);
            this.Controls.Add(this.txtGamePath);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmVeryVerySimple";
            this.Text = "The Witcher 3 Translate Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerySimple_FormClosing);
            this.Load += new System.EventHandler(this.frmVerySimple_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnAdvance.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkUiInfo;
        private System.Windows.Forms.LinkLabel lblAdvance;
        private System.Windows.Forms.Panel pnAdvance;
        private System.Windows.Forms.Button button1;
    }
}