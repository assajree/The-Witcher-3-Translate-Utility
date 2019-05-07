﻿namespace TranslateUtility
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeryVerySimple));
            this.btnGamePath = new System.Windows.Forms.Button();
            this.lblGameDir = new System.Windows.Forms.Label();
            this.rdoModTranslateFirst = new System.Windows.Forms.RadioButton();
            this.btnLegacyGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAdvance = new System.Windows.Forms.LinkLabel();
            this.pnAdvance = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoDownloadHourly = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoFontSizeNormal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rdoDownloadOnce = new System.Windows.Forms.RadioButton();
            this.rdoDownloadDialy = new System.Windows.Forms.RadioButton();
            this.rdoDownloadAlways = new System.Windows.Forms.RadioButton();
            this.rdoFontSizeLarge = new System.Windows.Forms.RadioButton();
            this.chkModDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.rdoModOriginFirst = new System.Windows.Forms.RadioButton();
            this.chkUiInfo = new System.Windows.Forms.CheckBox();
            this.chkUntranslateInfo = new System.Windows.Forms.CheckBox();
            this.chkTranslateInfo = new System.Windows.Forms.CheckBox();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnAdvance.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGamePath
            // 
            this.btnGamePath.Location = new System.Drawing.Point(542, 27);
            this.btnGamePath.Name = "btnGamePath";
            this.btnGamePath.Size = new System.Drawing.Size(26, 23);
            this.btnGamePath.TabIndex = 7;
            this.btnGamePath.Text = "...";
            this.btnGamePath.UseVisualStyleBackColor = true;
            this.btnGamePath.Click += new System.EventHandler(this.btnGamePath_Click);
            // 
            // lblGameDir
            // 
            this.lblGameDir.AutoSize = true;
            this.lblGameDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGameDir.Location = new System.Drawing.Point(12, 9);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(84, 17);
            this.lblGameDir.TabIndex = 8;
            this.lblGameDir.Text = "โฟลเดอร์เกม :";
            this.lblGameDir.DoubleClick += new System.EventHandler(this.lblGameDir_DoubleClick);
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
            this.btnLegacyGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLegacyGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLegacyGenerate.Location = new System.Drawing.Point(235, 55);
            this.btnLegacyGenerate.Name = "btnLegacyGenerate";
            this.btnLegacyGenerate.Size = new System.Drawing.Size(111, 34);
            this.btnLegacyGenerate.TabIndex = 33;
            this.btnLegacyGenerate.Text = "ติดตั้ง";
            this.btnLegacyGenerate.UseVisualStyleBackColor = true;
            this.btnLegacyGenerate.Click += new System.EventHandler(this.btnLegacyGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkModDoubleLanguage);
            this.groupBox1.Controls.Add(this.rdoModTranslateFirst);
            this.groupBox1.Controls.Add(this.rdoModOriginFirst);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 47);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สองภาษา";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUiInfo);
            this.groupBox2.Controls.Add(this.chkUntranslateInfo);
            this.groupBox2.Controls.Add(this.chkTranslateInfo);
            this.groupBox2.Location = new System.Drawing.Point(3, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 43);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "แสดงรายละเอียดข้อความ";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(6, 19);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(91, 23);
            this.btnResult.TabIndex = 48;
            this.btnResult.Text = "ข้อมูลการแปล";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(103, 19);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(91, 23);
            this.btnRestore.TabIndex = 49;
            this.btnRestore.Text = "ถอนการติดตั้ง";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResult);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Location = new System.Drawing.Point(3, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 53);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "อื่นๆ";
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Location = new System.Drawing.Point(15, 83);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(32, 13);
            this.lblAdvance.TabIndex = 51;
            this.lblAdvance.TabStop = true;
            this.lblAdvance.Text = "ขั้นสูง";
            this.lblAdvance.Click += new System.EventHandler(this.lblAdvance_Click);
            // 
            // pnAdvance
            // 
            this.pnAdvance.Controls.Add(this.groupBox5);
            this.pnAdvance.Controls.Add(this.groupBox4);
            this.pnAdvance.Controls.Add(this.groupBox1);
            this.pnAdvance.Controls.Add(this.groupBox2);
            this.pnAdvance.Controls.Add(this.groupBox3);
            this.pnAdvance.Location = new System.Drawing.Point(15, 108);
            this.pnAdvance.Name = "pnAdvance";
            this.pnAdvance.Size = new System.Drawing.Size(553, 276);
            this.pnAdvance.TabIndex = 52;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoDownloadAlways);
            this.groupBox5.Controls.Add(this.rdoDownloadDialy);
            this.groupBox5.Controls.Add(this.rdoDownloadOnce);
            this.groupBox5.Controls.Add(this.rdoDownloadHourly);
            this.groupBox5.Location = new System.Drawing.Point(3, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(544, 47);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ดาวน์โหลดไฟล์แปลภาษา";
            // 
            // rdoDownloadHourly
            // 
            this.rdoDownloadHourly.Checked = true;
            this.rdoDownloadHourly.Location = new System.Drawing.Point(123, 19);
            this.rdoDownloadHourly.Name = "rdoDownloadHourly";
            this.rdoDownloadHourly.Size = new System.Drawing.Size(85, 17);
            this.rdoDownloadHourly.TabIndex = 0;
            this.rdoDownloadHourly.TabStop = true;
            this.rdoDownloadHourly.Text = "ทุกชั่วโมง";
            this.rdoDownloadHourly.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoFontSizeLarge);
            this.groupBox4.Controls.Add(this.rdoFontSizeNormal);
            this.groupBox4.Location = new System.Drawing.Point(3, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 47);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ขนาดฟอนต์";
            // 
            // rdoFontSizeNormal
            // 
            this.rdoFontSizeNormal.Checked = true;
            this.rdoFontSizeNormal.Location = new System.Drawing.Point(25, 19);
            this.rdoFontSizeNormal.Name = "rdoFontSizeNormal";
            this.rdoFontSizeNormal.Size = new System.Drawing.Size(85, 17);
            this.rdoFontSizeNormal.TabIndex = 0;
            this.rdoFontSizeNormal.TabStop = true;
            this.rdoFontSizeNormal.Text = "ปกติ";
            this.rdoFontSizeNormal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(235, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 53;
            this.button1.Text = "ติดตั้ง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVersion,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(420, 79);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(154, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miVersion
            // 
            this.miVersion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChangeLog,
            this.miUpdate});
            this.miVersion.Name = "miVersion";
            this.miVersion.Size = new System.Drawing.Size(147, 20);
            this.miVersion.Text = "Version : 9999.99.99.9999";
            // 
            // miChangeLog
            // 
            this.miChangeLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miChangeLog.Name = "miChangeLog";
            this.miChangeLog.Size = new System.Drawing.Size(144, 22);
            this.miChangeLog.Text = "การเปลี่ยนแปลง";
            this.miChangeLog.Click += new System.EventHandler(this.miChangeLog_Click);
            // 
            // miUpdate
            // 
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.Size = new System.Drawing.Size(144, 22);
            this.miUpdate.Text = "อัพเดท";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // rdoDownloadOnce
            // 
            this.rdoDownloadOnce.Location = new System.Drawing.Point(327, 19);
            this.rdoDownloadOnce.Name = "rdoDownloadOnce";
            this.rdoDownloadOnce.Size = new System.Drawing.Size(85, 17);
            this.rdoDownloadOnce.TabIndex = 0;
            this.rdoDownloadOnce.Text = "ครั้งเดียว";
            this.rdoDownloadOnce.UseVisualStyleBackColor = true;
            // 
            // rdoDownloadDialy
            // 
            this.rdoDownloadDialy.Location = new System.Drawing.Point(220, 19);
            this.rdoDownloadDialy.Name = "rdoDownloadDialy";
            this.rdoDownloadDialy.Size = new System.Drawing.Size(85, 17);
            this.rdoDownloadDialy.TabIndex = 0;
            this.rdoDownloadDialy.Text = "วันละครั้ง";
            this.rdoDownloadDialy.UseVisualStyleBackColor = true;
            // 
            // rdoDownloadAlways
            // 
            this.rdoDownloadAlways.Location = new System.Drawing.Point(25, 19);
            this.rdoDownloadAlways.Name = "rdoDownloadAlways";
            this.rdoDownloadAlways.Size = new System.Drawing.Size(85, 17);
            this.rdoDownloadAlways.TabIndex = 0;
            this.rdoDownloadAlways.Text = "ทุกครั้ง";
            this.rdoDownloadAlways.UseVisualStyleBackColor = true;
            // 
            // rdoFontSizeLarge
            // 
            this.rdoFontSizeLarge.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleBigFont;
            this.rdoFontSizeLarge.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleBigFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoFontSizeLarge.Location = new System.Drawing.Point(123, 19);
            this.rdoFontSizeLarge.Name = "rdoFontSizeLarge";
            this.rdoFontSizeLarge.Size = new System.Drawing.Size(85, 17);
            this.rdoFontSizeLarge.TabIndex = 0;
            this.rdoFontSizeLarge.Text = "ใหญ่";
            this.rdoFontSizeLarge.UseVisualStyleBackColor = true;
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
            // chkUiInfo
            // 
            this.chkUiInfo.AutoSize = true;
            this.chkUiInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleUiInfo;
            this.chkUiInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleUiInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUiInfo.Location = new System.Drawing.Point(220, 19);
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
            // txtGamePath
            // 
            this.txtGamePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_SimpleModPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGamePath.Location = new System.Drawing.Point(15, 29);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(521, 20);
            this.txtGamePath.TabIndex = 6;
            this.txtGamePath.Text = global::TranslateUtility.Properties.Settings.Default._SimpleModPath;
            this.txtGamePath.TextChanged += new System.EventHandler(this.txtGamePath_TextChanged);
            this.txtGamePath.DoubleClick += new System.EventHandler(this.txtGamePath_DoubleClick);
            // 
            // frmVeryVerySimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 382);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnLegacyGenerate);
            this.Controls.Add(this.pnAdvance);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.lblGameDir);
            this.Controls.Add(this.btnGamePath);
            this.Controls.Add(this.txtGamePath);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGamePath;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.Label lblGameDir;
        private System.Windows.Forms.CheckBox chkTranslateInfo;
        private System.Windows.Forms.CheckBox chkUntranslateInfo;
        private System.Windows.Forms.RadioButton rdoModTranslateFirst;
        private System.Windows.Forms.RadioButton rdoModOriginFirst;
        private System.Windows.Forms.CheckBox chkModDoubleLanguage;
        private System.Windows.Forms.Button btnLegacyGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkUiInfo;
        private System.Windows.Forms.LinkLabel lblAdvance;
        private System.Windows.Forms.Panel pnAdvance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoDownloadAlways;
        private System.Windows.Forms.RadioButton rdoDownloadHourly;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoFontSizeLarge;
        private System.Windows.Forms.RadioButton rdoFontSizeNormal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miVersion;
        private System.Windows.Forms.ToolStripMenuItem miChangeLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miUpdate;
        private System.Windows.Forms.RadioButton rdoDownloadDialy;
        private System.Windows.Forms.RadioButton rdoDownloadOnce;
    }
}