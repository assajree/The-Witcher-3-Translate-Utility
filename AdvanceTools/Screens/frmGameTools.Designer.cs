namespace TranslateUtility
{
    partial class frmGameTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameTools));
            this.pnTranslate = new System.Windows.Forms.GroupBox();
            this.btnLangSourceOpen = new System.Windows.Forms.Button();
            this.btnLangDesc = new System.Windows.Forms.Button();
            this.btnCheckVersion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLangDesc = new System.Windows.Forms.TextBox();
            this.btnDownloadMod = new System.Windows.Forms.Button();
            this.btnLangSource = new System.Windows.Forms.Button();
            this.lblLastCheck = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLangSource = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInstallLang = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLastedVersion = new System.Windows.Forms.Label();
            this.lblLocalVersion = new System.Windows.Forms.Label();
            this.pnBackup = new System.Windows.Forms.GroupBox();
            this.btnBackupPathOpen = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.chkBackupOverwrite = new System.Windows.Forms.CheckBox();
            this.brnBackupPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBackupGamePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackupGamePath = new System.Windows.Forms.TextBox();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.pnFont = new System.Windows.Forms.GroupBox();
            this.btnFontModRemove = new System.Windows.Forms.Button();
            this.btnFontModDesc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFontModDesc = new System.Windows.Forms.TextBox();
            this.btnFontModInstall = new System.Windows.Forms.Button();
            this.pnTranslate.SuspendLayout();
            this.pnBackup.SuspendLayout();
            this.pnFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTranslate
            // 
            this.pnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTranslate.Controls.Add(this.btnLangSourceOpen);
            this.pnTranslate.Controls.Add(this.btnLangDesc);
            this.pnTranslate.Controls.Add(this.btnCheckVersion);
            this.pnTranslate.Controls.Add(this.label3);
            this.pnTranslate.Controls.Add(this.txtLangDesc);
            this.pnTranslate.Controls.Add(this.btnDownloadMod);
            this.pnTranslate.Controls.Add(this.btnLangSource);
            this.pnTranslate.Controls.Add(this.lblLastCheck);
            this.pnTranslate.Controls.Add(this.label4);
            this.pnTranslate.Controls.Add(this.label6);
            this.pnTranslate.Controls.Add(this.txtLangSource);
            this.pnTranslate.Controls.Add(this.label11);
            this.pnTranslate.Controls.Add(this.btnInstallLang);
            this.pnTranslate.Controls.Add(this.label8);
            this.pnTranslate.Controls.Add(this.lblLastedVersion);
            this.pnTranslate.Controls.Add(this.lblLocalVersion);
            this.pnTranslate.Location = new System.Drawing.Point(12, 140);
            this.pnTranslate.Name = "pnTranslate";
            this.pnTranslate.Size = new System.Drawing.Size(710, 162);
            this.pnTranslate.TabIndex = 9;
            this.pnTranslate.TabStop = false;
            this.pnTranslate.Text = "Translate Mod";
            // 
            // btnLangSourceOpen
            // 
            this.btnLangSourceOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLangSourceOpen.Location = new System.Drawing.Point(626, 16);
            this.btnLangSourceOpen.Name = "btnLangSourceOpen";
            this.btnLangSourceOpen.Size = new System.Drawing.Size(75, 23);
            this.btnLangSourceOpen.TabIndex = 28;
            this.btnLangSourceOpen.Text = "Open";
            this.btnLangSourceOpen.UseVisualStyleBackColor = true;
            this.btnLangSourceOpen.Click += new System.EventHandler(this.btnLangSourceOpen_Click);
            // 
            // btnLangDesc
            // 
            this.btnLangDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLangDesc.Location = new System.Drawing.Point(675, 41);
            this.btnLangDesc.Name = "btnLangDesc";
            this.btnLangDesc.Size = new System.Drawing.Size(26, 23);
            this.btnLangDesc.TabIndex = 5;
            this.btnLangDesc.Text = "...";
            this.btnLangDesc.UseVisualStyleBackColor = true;
            this.btnLangDesc.Click += new System.EventHandler(this.btnLangDesc_Click);
            // 
            // btnCheckVersion
            // 
            this.btnCheckVersion.Location = new System.Drawing.Point(112, 67);
            this.btnCheckVersion.Name = "btnCheckVersion";
            this.btnCheckVersion.Size = new System.Drawing.Size(92, 23);
            this.btnCheckVersion.TabIndex = 21;
            this.btnCheckVersion.Text = "Check Version";
            this.btnCheckVersion.UseVisualStyleBackColor = true;
            this.btnCheckVersion.Click += new System.EventHandler(this.btnCheckVersion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Game Directory";
            // 
            // txtLangDesc
            // 
            this.txtLangDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLangDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_GameModGamePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLangDesc.Location = new System.Drawing.Point(112, 43);
            this.txtLangDesc.Name = "txtLangDesc";
            this.txtLangDesc.Size = new System.Drawing.Size(558, 20);
            this.txtLangDesc.TabIndex = 3;
            this.txtLangDesc.Text = global::TranslateUtility.Properties.Settings.Default._GameModGamePath;
            // 
            // btnDownloadMod
            // 
            this.btnDownloadMod.Location = new System.Drawing.Point(211, 67);
            this.btnDownloadMod.Name = "btnDownloadMod";
            this.btnDownloadMod.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadMod.TabIndex = 20;
            this.btnDownloadMod.Text = "Download";
            this.btnDownloadMod.UseVisualStyleBackColor = true;
            this.btnDownloadMod.Click += new System.EventHandler(this.btnDownloadMod_Click);
            // 
            // btnLangSource
            // 
            this.btnLangSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLangSource.Location = new System.Drawing.Point(594, 16);
            this.btnLangSource.Name = "btnLangSource";
            this.btnLangSource.Size = new System.Drawing.Size(26, 23);
            this.btnLangSource.TabIndex = 2;
            this.btnLangSource.Text = "...";
            this.btnLangSource.UseVisualStyleBackColor = true;
            this.btnLangSource.Click += new System.EventHandler(this.btnLangSource_Click);
            // 
            // lblLastCheck
            // 
            this.lblLastCheck.AutoSize = true;
            this.lblLastCheck.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "LastCheckUpdate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLastCheck.Location = new System.Drawing.Point(208, 135);
            this.lblLastCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastCheck.Name = "lblLastCheck";
            this.lblLastCheck.Size = new System.Drawing.Size(27, 13);
            this.lblLastCheck.TabIndex = 27;
            this.lblLastCheck.Text = global::TranslateUtility.Properties.Settings.Default.LastCheckUpdate;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mod Directory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Local Version    : ";
            // 
            // txtLangSource
            // 
            this.txtLangSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLangSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_GameModDownloadPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLangSource.Location = new System.Drawing.Point(112, 19);
            this.txtLangSource.Name = "txtLangSource";
            this.txtLangSource.Size = new System.Drawing.Size(477, 20);
            this.txtLangSource.TabIndex = 0;
            this.txtLangSource.Text = global::TranslateUtility.Properties.Settings.Default._GameModDownloadPath;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Last Check        :";
            // 
            // btnInstallLang
            // 
            this.btnInstallLang.Location = new System.Drawing.Point(292, 67);
            this.btnInstallLang.Name = "btnInstallLang";
            this.btnInstallLang.Size = new System.Drawing.Size(75, 23);
            this.btnInstallLang.TabIndex = 0;
            this.btnInstallLang.Text = "Install";
            this.btnInstallLang.UseVisualStyleBackColor = true;
            this.btnInstallLang.Click += new System.EventHandler(this.btnInstallLang_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Lastest Version : ";
            // 
            // lblLastedVersion
            // 
            this.lblLastedVersion.AutoSize = true;
            this.lblLastedVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "LastestVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLastedVersion.Location = new System.Drawing.Point(208, 116);
            this.lblLastedVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastedVersion.Name = "lblLastedVersion";
            this.lblLastedVersion.Size = new System.Drawing.Size(27, 13);
            this.lblLastedVersion.TabIndex = 24;
            this.lblLastedVersion.Text = global::TranslateUtility.Properties.Settings.Default.LastestVersion;
            // 
            // lblLocalVersion
            // 
            this.lblLocalVersion.AutoSize = true;
            this.lblLocalVersion.Location = new System.Drawing.Point(208, 97);
            this.lblLocalVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalVersion.Name = "lblLocalVersion";
            this.lblLocalVersion.Size = new System.Drawing.Size(27, 13);
            this.lblLocalVersion.TabIndex = 25;
            this.lblLocalVersion.Text = "N/A";
            // 
            // pnBackup
            // 
            this.pnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBackup.Controls.Add(this.btnBackupPathOpen);
            this.pnBackup.Controls.Add(this.btnRestore);
            this.pnBackup.Controls.Add(this.chkBackupOverwrite);
            this.pnBackup.Controls.Add(this.brnBackupPath);
            this.pnBackup.Controls.Add(this.label2);
            this.pnBackup.Controls.Add(this.txtBackupPath);
            this.pnBackup.Controls.Add(this.btnBackupGamePath);
            this.pnBackup.Controls.Add(this.label1);
            this.pnBackup.Controls.Add(this.txtBackupGamePath);
            this.pnBackup.Controls.Add(this.btnBackUp);
            this.pnBackup.Location = new System.Drawing.Point(12, 12);
            this.pnBackup.Name = "pnBackup";
            this.pnBackup.Size = new System.Drawing.Size(710, 122);
            this.pnBackup.TabIndex = 8;
            this.pnBackup.TabStop = false;
            this.pnBackup.Text = "Backup && Restore";
            // 
            // btnBackupPathOpen
            // 
            this.btnBackupPathOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupPathOpen.Location = new System.Drawing.Point(626, 41);
            this.btnBackupPathOpen.Name = "btnBackupPathOpen";
            this.btnBackupPathOpen.Size = new System.Drawing.Size(75, 23);
            this.btnBackupPathOpen.TabIndex = 14;
            this.btnBackupPathOpen.Text = "Open";
            this.btnBackupPathOpen.UseVisualStyleBackColor = true;
            this.btnBackupPathOpen.Click += new System.EventHandler(this.btnBackupPathOpen_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(194, 89);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // chkBackupOverwrite
            // 
            this.chkBackupOverwrite.AutoSize = true;
            this.chkBackupOverwrite.Checked = global::TranslateUtility.Properties.Settings.Default._GameBackupOverwrite;
            this.chkBackupOverwrite.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_GameBackupOverwrite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkBackupOverwrite.Location = new System.Drawing.Point(112, 67);
            this.chkBackupOverwrite.Margin = new System.Windows.Forms.Padding(2);
            this.chkBackupOverwrite.Name = "chkBackupOverwrite";
            this.chkBackupOverwrite.Size = new System.Drawing.Size(117, 17);
            this.chkBackupOverwrite.TabIndex = 6;
            this.chkBackupOverwrite.Text = "Overwrite Exist files";
            this.chkBackupOverwrite.UseVisualStyleBackColor = true;
            // 
            // brnBackupPath
            // 
            this.brnBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnBackupPath.Location = new System.Drawing.Point(594, 41);
            this.brnBackupPath.Name = "brnBackupPath";
            this.brnBackupPath.Size = new System.Drawing.Size(26, 23);
            this.brnBackupPath.TabIndex = 5;
            this.brnBackupPath.Text = "...";
            this.brnBackupPath.UseVisualStyleBackColor = true;
            this.brnBackupPath.Click += new System.EventHandler(this.brnBackupPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Backup Directory";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_GameBackupDesc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBackupPath.Location = new System.Drawing.Point(112, 43);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(477, 20);
            this.txtBackupPath.TabIndex = 3;
            this.txtBackupPath.Text = global::TranslateUtility.Properties.Settings.Default._GameBackupDesc;
            // 
            // btnBackupGamePath
            // 
            this.btnBackupGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupGamePath.Location = new System.Drawing.Point(675, 16);
            this.btnBackupGamePath.Name = "btnBackupGamePath";
            this.btnBackupGamePath.Size = new System.Drawing.Size(26, 23);
            this.btnBackupGamePath.TabIndex = 2;
            this.btnBackupGamePath.Text = "...";
            this.btnBackupGamePath.UseVisualStyleBackColor = true;
            this.btnBackupGamePath.Click += new System.EventHandler(this.btnBackupGamePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Directory";
            // 
            // txtBackupGamePath
            // 
            this.txtBackupGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupGamePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_GameBackupSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBackupGamePath.Location = new System.Drawing.Point(112, 19);
            this.txtBackupGamePath.Name = "txtBackupGamePath";
            this.txtBackupGamePath.Size = new System.Drawing.Size(558, 20);
            this.txtBackupGamePath.TabIndex = 0;
            this.txtBackupGamePath.Text = global::TranslateUtility.Properties.Settings.Default._GameBackupSource;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(112, 89);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(75, 23);
            this.btnBackUp.TabIndex = 0;
            this.btnBackUp.Text = "Backup";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // pnFont
            // 
            this.pnFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFont.Controls.Add(this.btnFontModRemove);
            this.pnFont.Controls.Add(this.btnFontModDesc);
            this.pnFont.Controls.Add(this.label5);
            this.pnFont.Controls.Add(this.txtFontModDesc);
            this.pnFont.Controls.Add(this.btnFontModInstall);
            this.pnFont.Location = new System.Drawing.Point(12, 308);
            this.pnFont.Name = "pnFont";
            this.pnFont.Size = new System.Drawing.Size(710, 76);
            this.pnFont.TabIndex = 10;
            this.pnFont.TabStop = false;
            this.pnFont.Text = "Font Mod";
            // 
            // btnFontModRemove
            // 
            this.btnFontModRemove.Location = new System.Drawing.Point(194, 43);
            this.btnFontModRemove.Name = "btnFontModRemove";
            this.btnFontModRemove.Size = new System.Drawing.Size(75, 23);
            this.btnFontModRemove.TabIndex = 6;
            this.btnFontModRemove.Text = "Uninstall";
            this.btnFontModRemove.UseVisualStyleBackColor = true;
            this.btnFontModRemove.Click += new System.EventHandler(this.btnFontModRemove_Click);
            // 
            // btnFontModDesc
            // 
            this.btnFontModDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontModDesc.Location = new System.Drawing.Point(675, 16);
            this.btnFontModDesc.Name = "btnFontModDesc";
            this.btnFontModDesc.Size = new System.Drawing.Size(26, 23);
            this.btnFontModDesc.TabIndex = 5;
            this.btnFontModDesc.Text = "...";
            this.btnFontModDesc.UseVisualStyleBackColor = true;
            this.btnFontModDesc.Click += new System.EventHandler(this.btnFontModDesc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Game Directory";
            // 
            // txtFontModDesc
            // 
            this.txtFontModDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFontModDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_GameFontGamePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFontModDesc.Location = new System.Drawing.Point(112, 19);
            this.txtFontModDesc.Name = "txtFontModDesc";
            this.txtFontModDesc.Size = new System.Drawing.Size(558, 20);
            this.txtFontModDesc.TabIndex = 3;
            this.txtFontModDesc.Text = global::TranslateUtility.Properties.Settings.Default._GameFontGamePath;
            // 
            // btnFontModInstall
            // 
            this.btnFontModInstall.Location = new System.Drawing.Point(112, 43);
            this.btnFontModInstall.Name = "btnFontModInstall";
            this.btnFontModInstall.Size = new System.Drawing.Size(75, 23);
            this.btnFontModInstall.TabIndex = 0;
            this.btnFontModInstall.Text = "Install";
            this.btnFontModInstall.UseVisualStyleBackColor = true;
            this.btnFontModInstall.Click += new System.EventHandler(this.btnFontModInstall_Click);
            // 
            // frmGameTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(734, 393);
            this.Controls.Add(this.pnFont);
            this.Controls.Add(this.pnTranslate);
            this.Controls.Add(this.pnBackup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(555, 111);
            this.Name = "frmGameTools";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Utility";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGameTools_FormClosed);
            this.Load += new System.EventHandler(this.frmGameTools_Load);
            this.Shown += new System.EventHandler(this.frmGameTools_Shown);
            this.pnTranslate.ResumeLayout(false);
            this.pnTranslate.PerformLayout();
            this.pnBackup.ResumeLayout(false);
            this.pnBackup.PerformLayout();
            this.pnFont.ResumeLayout(false);
            this.pnFont.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnTranslate;
        private System.Windows.Forms.Button btnLangDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLangDesc;
        private System.Windows.Forms.Button btnLangSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLangSource;
        private System.Windows.Forms.Button btnInstallLang;
        private System.Windows.Forms.GroupBox pnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.CheckBox chkBackupOverwrite;
        private System.Windows.Forms.Button brnBackupPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBackupGamePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBackupGamePath;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.GroupBox pnFont;
        private System.Windows.Forms.Button btnFontModDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFontModDesc;
        private System.Windows.Forms.Button btnFontModInstall;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckVersion;
        private System.Windows.Forms.Button btnDownloadMod;
        private System.Windows.Forms.Label lblLocalVersion;
        private System.Windows.Forms.Label lblLastedVersion;
        private System.Windows.Forms.Label lblLastCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFontModRemove;
        private System.Windows.Forms.Button btnBackupPathOpen;
        private System.Windows.Forms.Button btnLangSourceOpen;
    }
}