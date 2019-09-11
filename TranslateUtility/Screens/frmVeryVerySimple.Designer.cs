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
            TranslateUtility.Properties.Settings settings1 = new TranslateUtility.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeryVerySimple));
            this.btnGamePath = new System.Windows.Forms.Button();
            this.lblGameDir = new System.Windows.Forms.Label();
            this.rdoModTranslateFirst = new System.Windows.Forms.RadioButton();
            this.btnLegacyGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExcludeUiText = new System.Windows.Forms.CheckBox();
            this.chkModDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.rdoModOriginFirst = new System.Windows.Forms.RadioButton();
            this.chkOldMethod = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUiInfo = new System.Windows.Forms.CheckBox();
            this.chkUntranslateInfo = new System.Windows.Forms.CheckBox();
            this.chkTranslateInfo = new System.Windows.Forms.CheckBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFixMod = new System.Windows.Forms.Button();
            this.btnMessageFinder = new System.Windows.Forms.Button();
            this.lblAdvance = new System.Windows.Forms.LinkLabel();
            this.pnAdvance = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rdoNormalCompatibility = new System.Windows.Forms.RadioButton();
            this.rdoHighCompatibility = new System.Windows.Forms.RadioButton();
            this.rdoMediumCompatibility = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblCustomTranslateCount = new System.Windows.Forms.Label();
            this.btnAltSubSetting = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkChangeTextColor = new System.Windows.Forms.CheckBox();
            this.btnChangeFontSize = new System.Windows.Forms.Button();
            this.txtFontSizeCutScene = new System.Windows.Forms.NumericUpDown();
            this.txtFontSizeSpeak = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoDownloadAlways = new System.Windows.Forms.RadioButton();
            this.rdoDownloadDialy = new System.Windows.Forms.RadioButton();
            this.rdoDownloadOnce = new System.Windows.Forms.RadioButton();
            this.rdoDownloadHourly = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkRandomLoading = new System.Windows.Forms.CheckBox();
            this.chkBackupSetting = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInstallFont = new System.Windows.Forms.Button();
            this.rdoFontPrompt = new System.Windows.Forms.RadioButton();
            this.rdoFontMahaniyom = new System.Windows.Forms.RadioButton();
            this.rdoFontSuperMarket = new System.Windows.Forms.RadioButton();
            this.rdoFontSrisakdi = new System.Windows.Forms.RadioButton();
            this.rdoFontCsPrakas = new System.Windows.Forms.RadioButton();
            this.rdoFontSarabun = new System.Windows.Forms.RadioButton();
            this.rdoFontNone = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.miLog = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.miTranslateProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.miMessageFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.miCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnAdvance.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeCutScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeSpeak)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGamePath
            // 
            this.btnGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamePath.Location = new System.Drawing.Point(489, 27);
            this.btnGamePath.Name = "btnGamePath";
            this.btnGamePath.Size = new System.Drawing.Size(34, 26);
            this.btnGamePath.TabIndex = 7;
            this.btnGamePath.Text = "...";
            this.btnGamePath.UseVisualStyleBackColor = true;
            this.btnGamePath.Click += new System.EventHandler(this.btnGamePath_Click);
            // 
            // lblGameDir
            // 
            this.lblGameDir.AutoSize = true;
            this.lblGameDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGameDir.Location = new System.Drawing.Point(13, 9);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(101, 17);
            this.lblGameDir.TabIndex = 8;
            this.lblGameDir.Text = "โฟลเดอร์เกม : ";
            this.lblGameDir.DoubleClick += new System.EventHandler(this.lblGameDir_DoubleClick);
            this.lblGameDir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblGameDir_MouseClick);
            // 
            // rdoModTranslateFirst
            // 
            this.rdoModTranslateFirst.AutoSize = true;
            this.rdoModTranslateFirst.Checked = true;
            this.rdoModTranslateFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModTranslateFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoModTranslateFirst.Location = new System.Drawing.Point(26, 29);
            this.rdoModTranslateFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoModTranslateFirst.Name = "rdoModTranslateFirst";
            this.rdoModTranslateFirst.Size = new System.Drawing.Size(101, 21);
            this.rdoModTranslateFirst.TabIndex = 35;
            this.rdoModTranslateFirst.TabStop = true;
            this.rdoModTranslateFirst.Text = "ภาษาไทยก่อน";
            this.rdoModTranslateFirst.UseVisualStyleBackColor = true;
            // 
            // btnLegacyGenerate
            // 
            this.btnLegacyGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegacyGenerate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLegacyGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegacyGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLegacyGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLegacyGenerate.Location = new System.Drawing.Point(218, 62);
            this.btnLegacyGenerate.Name = "btnLegacyGenerate";
            this.btnLegacyGenerate.Size = new System.Drawing.Size(97, 36);
            this.btnLegacyGenerate.TabIndex = 33;
            this.btnLegacyGenerate.Text = "ติดตั้ง";
            this.btnLegacyGenerate.UseVisualStyleBackColor = false;
            this.btnLegacyGenerate.Click += new System.EventHandler(this.btnLegacyGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkExcludeUiText);
            this.groupBox1.Controls.Add(this.chkModDoubleLanguage);
            this.groupBox1.Controls.Add(this.rdoModTranslateFirst);
            this.groupBox1.Controls.Add(this.rdoModOriginFirst);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 60);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สองภาษา";
            // 
            // chkExcludeUiText
            // 
            this.chkExcludeUiText.AutoSize = true;
            this.chkExcludeUiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcludeUiText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkExcludeUiText.Location = new System.Drawing.Point(105, 0);
            this.chkExcludeUiText.Name = "chkExcludeUiText";
            this.chkExcludeUiText.Size = new System.Drawing.Size(127, 21);
            this.chkExcludeUiText.TabIndex = 37;
            this.chkExcludeUiText.Text = "เมนูภาษาอังกฤษ";
            this.chkExcludeUiText.UseVisualStyleBackColor = true;
            // 
            // chkModDoubleLanguage
            // 
            this.chkModDoubleLanguage.AutoSize = true;
            this.chkModDoubleLanguage.Checked = true;
            this.chkModDoubleLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModDoubleLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModDoubleLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkModDoubleLanguage.Location = new System.Drawing.Point(6, 0);
            this.chkModDoubleLanguage.Name = "chkModDoubleLanguage";
            this.chkModDoubleLanguage.Size = new System.Drawing.Size(83, 21);
            this.chkModDoubleLanguage.TabIndex = 36;
            this.chkModDoubleLanguage.Text = "สองภาษา";
            this.chkModDoubleLanguage.UseVisualStyleBackColor = true;
            this.chkModDoubleLanguage.CheckedChanged += new System.EventHandler(this.chkModDoubleLanguage_CheckedChanged);
            // 
            // rdoModOriginFirst
            // 
            this.rdoModOriginFirst.AutoSize = true;
            this.rdoModOriginFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModOriginFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoModOriginFirst.Location = new System.Drawing.Point(166, 29);
            this.rdoModOriginFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoModOriginFirst.Name = "rdoModOriginFirst";
            this.rdoModOriginFirst.Size = new System.Drawing.Size(117, 21);
            this.rdoModOriginFirst.TabIndex = 34;
            this.rdoModOriginFirst.Text = "ภาษาอังกฤษก่อน";
            this.rdoModOriginFirst.UseVisualStyleBackColor = true;
            // 
            // chkOldMethod
            // 
            this.chkOldMethod.AutoSize = true;
            this.chkOldMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOldMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkOldMethod.Location = new System.Drawing.Point(26, 22);
            this.chkOldMethod.Name = "chkOldMethod";
            this.chkOldMethod.Size = new System.Drawing.Size(105, 21);
            this.chkOldMethod.TabIndex = 38;
            this.chkOldMethod.Text = "ลงม็อดแบบเก่า";
            this.chkOldMethod.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkUiInfo);
            this.groupBox2.Controls.Add(this.chkUntranslateInfo);
            this.groupBox2.Controls.Add(this.chkTranslateInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(4, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 60);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "แสดงเลขบรรทัด";
            // 
            // chkUiInfo
            // 
            this.chkUiInfo.AutoSize = true;
            settings1._ExcelFillDesc = "";
            settings1._ExcelFillSource = "";
            settings1._ExcelFillText = false;
            settings1._ExcelFillTranslate = true;
            settings1._ExcelLegacyMod = "";
            settings1._ExcelLegacyOutput = "";
            settings1._ExcelLegacyTranslate = "";
            settings1._ExcelMergeAdd = false;
            settings1._ExcelMergeOutput = "";
            settings1._ExcelMergeReplaceText = false;
            settings1._ExcelMergeReplaceTranslate = false;
            settings1._ExcelMergeSource = "";
            settings1._ExcelMergeTranslate = "";
            settings1._ExcelModOutput = "";
            settings1._ExcelModSource = "";
            settings1._ExcelTranslateContain = false;
            settings1._ExcelTranslateContainText = "";
            settings1._ExcelTranslateEmpty = true;
            settings1._ExcelTranslateInput = "";
            settings1._ExcelTranslateOutput = "";
            settings1._ExcelTranslateSame = false;
            settings1._ExcelTranslateSingle = false;
            settings1._ExcelTranslateSortById = true;
            settings1._ExcelTranslateSortByLength = false;
            settings1._ExcelTranslateUiText = false;
            settings1._GameBackupDesc = "";
            settings1._GameBackupOverwrite = false;
            settings1._GameBackupSource = "";
            settings1._GameFontGamePath = "";
            settings1._GameModDownloadPath = "";
            settings1._GameModGamePath = "";
            settings1._ModExcelDouble = false;
            settings1._ModExcelOriginalFirst = false;
            settings1._ModExcelOutput = "";
            settings1._ModExcelSource = "";
            settings1._ModExcelTranslateFirst = true;
            settings1._ModTranslateDouble = false;
            settings1._ModTranslateExcel = "";
            settings1._ModTranslateOriginalFirst = false;
            settings1._ModTranslateOutput = "";
            settings1._ModTranslateSource = "";
            settings1._ModTranslateTranslateFirst = true;
            settings1._Simple2Language = false;
            settings1._SimpleBigFont = false;
            settings1._SimpleDownloadFrequency = "";
            settings1._SimpleFontSetting = "";
            settings1._SimpleForceDownload = false;
            settings1._SimpleGamePath = "";
            settings1._SimpleModInput = "";
            settings1._SimpleModOutput = "";
            settings1._SimpleModPath = "";
            settings1._SimpleOriginalFirst = false;
            settings1._SimpleShowAdvance = false;
            settings1._SimpleTranslateInfo = false;
            settings1._SimpleUiInfo = false;
            settings1._SimpleUntranslateInfo = false;
            settings1._VerySimpleFontSize = new decimal(new int[] {
            28,
            0,
            0,
            0});
            settings1._VerySimpleFontSizeSpeak = new decimal(new int[] {
            28,
            0,
            0,
            0});
            settings1._VerySimpleGamePath = "";
            settings1._VerySimpleOverrideTurkish = false;
            settings1._VerySimpleTranslateUI = false;
            settings1.LastCheckUpdate = "N/A";
            settings1.LastestVersion = "N/A";
            settings1.SettingsKey = "";
            this.chkUiInfo.Checked = settings1._SimpleUiInfo;
            this.chkUiInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_SimpleUiInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUiInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUiInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkUiInfo.Location = new System.Drawing.Point(26, 24);
            this.chkUiInfo.Name = "chkUiInfo";
            this.chkUiInfo.Size = new System.Drawing.Size(100, 21);
            this.chkUiInfo.TabIndex = 40;
            this.chkUiInfo.Text = "ข้อความระบบ";
            this.chkUiInfo.UseVisualStyleBackColor = true;
            // 
            // chkUntranslateInfo
            // 
            this.chkUntranslateInfo.AutoSize = true;
            this.chkUntranslateInfo.Checked = settings1._SimpleUntranslateInfo;
            this.chkUntranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_SimpleUntranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUntranslateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUntranslateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkUntranslateInfo.Location = new System.Drawing.Point(291, 24);
            this.chkUntranslateInfo.Name = "chkUntranslateInfo";
            this.chkUntranslateInfo.Size = new System.Drawing.Size(145, 21);
            this.chkUntranslateInfo.TabIndex = 37;
            this.chkUntranslateInfo.Text = "ข้อความที่ยังไม่ได้แปล";
            this.chkUntranslateInfo.UseVisualStyleBackColor = true;
            // 
            // chkTranslateInfo
            // 
            this.chkTranslateInfo.AutoSize = true;
            this.chkTranslateInfo.Checked = settings1._SimpleTranslateInfo;
            this.chkTranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_SimpleTranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTranslateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTranslateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTranslateInfo.Location = new System.Drawing.Point(150, 24);
            this.chkTranslateInfo.Name = "chkTranslateInfo";
            this.chkTranslateInfo.Size = new System.Drawing.Size(124, 21);
            this.chkTranslateInfo.TabIndex = 39;
            this.chkTranslateInfo.Text = "ข้อความที่แปลแล้ว";
            this.chkTranslateInfo.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(6, 18);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(98, 31);
            this.btnResult.TabIndex = 48;
            this.btnResult.Text = "ข้อมูลการแปล";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackColor = System.Drawing.Color.Red;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestore.Location = new System.Drawing.Point(405, 18);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(98, 31);
            this.btnRestore.TabIndex = 49;
            this.btnRestore.Text = "ลบม็อด";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnFixMod);
            this.groupBox3.Controls.Add(this.btnMessageFinder);
            this.groupBox3.Controls.Add(this.btnResult);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 546);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 60);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "เครื่องมือ";
            // 
            // btnFixMod
            // 
            this.btnFixMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixMod.Location = new System.Drawing.Point(111, 18);
            this.btnFixMod.Name = "btnFixMod";
            this.btnFixMod.Size = new System.Drawing.Size(98, 31);
            this.btnFixMod.TabIndex = 51;
            this.btnFixMod.Text = "ซ่อมม็อด";
            this.btnFixMod.UseVisualStyleBackColor = true;
            this.btnFixMod.Click += new System.EventHandler(this.btnFixMod_Click);
            // 
            // btnMessageFinder
            // 
            this.btnMessageFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageFinder.Location = new System.Drawing.Point(216, 18);
            this.btnMessageFinder.Name = "btnMessageFinder";
            this.btnMessageFinder.Size = new System.Drawing.Size(98, 31);
            this.btnMessageFinder.TabIndex = 50;
            this.btnMessageFinder.Text = "ค้นหา";
            this.btnMessageFinder.UseVisualStyleBackColor = true;
            this.btnMessageFinder.Click += new System.EventHandler(this.btnMessageFinder_Click);
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.LinkColor = System.Drawing.SystemColors.Highlight;
            this.lblAdvance.Location = new System.Drawing.Point(18, 77);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(38, 17);
            this.lblAdvance.TabIndex = 51;
            this.lblAdvance.TabStop = true;
            this.lblAdvance.Text = "ขั้นสูง";
            this.lblAdvance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAdvance.Click += new System.EventHandler(this.lblAdvance_Click);
            // 
            // pnAdvance
            // 
            this.pnAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnAdvance.Controls.Add(this.groupBox9);
            this.pnAdvance.Controls.Add(this.groupBox7);
            this.pnAdvance.Controls.Add(this.groupBox6);
            this.pnAdvance.Controls.Add(this.groupBox5);
            this.pnAdvance.Controls.Add(this.groupBox8);
            this.pnAdvance.Controls.Add(this.groupBox4);
            this.pnAdvance.Controls.Add(this.groupBox1);
            this.pnAdvance.Controls.Add(this.groupBox2);
            this.pnAdvance.Controls.Add(this.groupBox3);
            this.pnAdvance.Location = new System.Drawing.Point(12, 100);
            this.pnAdvance.Name = "pnAdvance";
            this.pnAdvance.Size = new System.Drawing.Size(516, 618);
            this.pnAdvance.TabIndex = 52;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.rdoNormalCompatibility);
            this.groupBox9.Controls.Add(this.rdoHighCompatibility);
            this.groupBox9.Controls.Add(this.rdoMediumCompatibility);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox9.Location = new System.Drawing.Point(4, 222);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(510, 60);
            this.groupBox9.TabIndex = 53;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "ความเข้ากันได้กับม็อดอื่น";
            // 
            // rdoNormalCompatibility
            // 
            this.rdoNormalCompatibility.AutoSize = true;
            this.rdoNormalCompatibility.Checked = true;
            this.rdoNormalCompatibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalCompatibility.ForeColor = System.Drawing.Color.DarkOrange;
            this.rdoNormalCompatibility.Location = new System.Drawing.Point(26, 26);
            this.rdoNormalCompatibility.Name = "rdoNormalCompatibility";
            this.rdoNormalCompatibility.Size = new System.Drawing.Size(53, 21);
            this.rdoNormalCompatibility.TabIndex = 0;
            this.rdoNormalCompatibility.TabStop = true;
            this.rdoNormalCompatibility.Text = "ปกติ";
            this.rdoNormalCompatibility.UseVisualStyleBackColor = true;
            this.rdoNormalCompatibility.CheckedChanged += new System.EventHandler(this.rdoNormalCompatibility_CheckedChanged);
            // 
            // rdoHighCompatibility
            // 
            this.rdoHighCompatibility.AutoSize = true;
            this.rdoHighCompatibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHighCompatibility.ForeColor = System.Drawing.Color.ForestGreen;
            this.rdoHighCompatibility.Location = new System.Drawing.Point(291, 26);
            this.rdoHighCompatibility.Name = "rdoHighCompatibility";
            this.rdoHighCompatibility.Size = new System.Drawing.Size(41, 21);
            this.rdoHighCompatibility.TabIndex = 0;
            this.rdoHighCompatibility.Text = "สูง";
            this.rdoHighCompatibility.UseVisualStyleBackColor = true;
            this.rdoHighCompatibility.CheckedChanged += new System.EventHandler(this.rdoHighCompatibility_CheckedChanged);
            // 
            // rdoMediumCompatibility
            // 
            this.rdoMediumCompatibility.AutoSize = true;
            this.rdoMediumCompatibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMediumCompatibility.ForeColor = System.Drawing.Color.Gold;
            this.rdoMediumCompatibility.Location = new System.Drawing.Point(150, 26);
            this.rdoMediumCompatibility.Name = "rdoMediumCompatibility";
            this.rdoMediumCompatibility.Size = new System.Drawing.Size(83, 21);
            this.rdoMediumCompatibility.TabIndex = 0;
            this.rdoMediumCompatibility.Text = "ปานกลาง";
            this.rdoMediumCompatibility.UseVisualStyleBackColor = true;
            this.rdoMediumCompatibility.CheckedChanged += new System.EventHandler(this.rdoMediumCompatibility_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lblCustomTranslateCount);
            this.groupBox7.Controls.Add(this.btnAltSubSetting);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox7.Location = new System.Drawing.Point(4, 478);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(510, 60);
            this.groupBox7.TabIndex = 52;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "การแปลแบบปรับแต่ง";
            // 
            // lblCustomTranslateCount
            // 
            this.lblCustomTranslateCount.AutoSize = true;
            this.lblCustomTranslateCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomTranslateCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomTranslateCount.Location = new System.Drawing.Point(110, 29);
            this.lblCustomTranslateCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomTranslateCount.Name = "lblCustomTranslateCount";
            this.lblCustomTranslateCount.Size = new System.Drawing.Size(159, 17);
            this.lblCustomTranslateCount.TabIndex = 50;
            this.lblCustomTranslateCount.Text = "ไฟล์ปรับแต่งที่เปิดใช้งาน : 0";
            // 
            // btnAltSubSetting
            // 
            this.btnAltSubSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltSubSetting.Location = new System.Drawing.Point(6, 22);
            this.btnAltSubSetting.Name = "btnAltSubSetting";
            this.btnAltSubSetting.Size = new System.Drawing.Size(98, 31);
            this.btnAltSubSetting.TabIndex = 49;
            this.btnAltSubSetting.Text = "ตั้งค่า";
            this.btnAltSubSetting.UseVisualStyleBackColor = true;
            this.btnAltSubSetting.Click += new System.EventHandler(this.btnAltSubSetting_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.chkChangeTextColor);
            this.groupBox6.Controls.Add(this.btnChangeFontSize);
            this.groupBox6.Controls.Add(this.txtFontSizeCutScene);
            this.groupBox6.Controls.Add(this.txtFontSizeSpeak);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox6.Location = new System.Drawing.Point(3, 158);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(510, 57);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ขนาดและสีซับไตเติ้ล";
            // 
            // chkChangeTextColor
            // 
            this.chkChangeTextColor.AutoSize = true;
            this.chkChangeTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChangeTextColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkChangeTextColor.Location = new System.Drawing.Point(291, 28);
            this.chkChangeTextColor.Name = "chkChangeTextColor";
            this.chkChangeTextColor.Size = new System.Drawing.Size(84, 21);
            this.chkChangeTextColor.TabIndex = 41;
            this.chkChangeTextColor.Text = "เปลี่ยนสีชื่อ";
            this.chkChangeTextColor.UseVisualStyleBackColor = true;
            // 
            // btnChangeFontSize
            // 
            this.btnChangeFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFontSize.Location = new System.Drawing.Point(406, 25);
            this.btnChangeFontSize.Name = "btnChangeFontSize";
            this.btnChangeFontSize.Size = new System.Drawing.Size(98, 24);
            this.btnChangeFontSize.TabIndex = 52;
            this.btnChangeFontSize.Text = "เปลี่ยนตอนนี้";
            this.btnChangeFontSize.UseVisualStyleBackColor = true;
            this.btnChangeFontSize.Click += new System.EventHandler(this.btnChangeFontSize_Click);
            // 
            // txtFontSizeCutScene
            // 
            this.txtFontSizeCutScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeCutScene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFontSizeCutScene.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtFontSizeCutScene.Location = new System.Drawing.Point(70, 26);
            this.txtFontSizeCutScene.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtFontSizeCutScene.Name = "txtFontSizeCutScene";
            this.txtFontSizeCutScene.Size = new System.Drawing.Size(47, 23);
            this.txtFontSizeCutScene.TabIndex = 4;
            this.txtFontSizeCutScene.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFontSizeCutScene.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // txtFontSizeSpeak
            // 
            this.txtFontSizeSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeSpeak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFontSizeSpeak.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtFontSizeSpeak.Location = new System.Drawing.Point(218, 26);
            this.txtFontSizeSpeak.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtFontSizeSpeak.Name = "txtFontSizeSpeak";
            this.txtFontSizeSpeak.Size = new System.Drawing.Size(47, 23);
            this.txtFontSizeSpeak.TabIndex = 4;
            this.txtFontSizeSpeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFontSizeSpeak.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "คัทซีน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(147, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "นอกคัทซีน";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.rdoDownloadAlways);
            this.groupBox5.Controls.Add(this.rdoDownloadDialy);
            this.groupBox5.Controls.Add(this.rdoDownloadOnce);
            this.groupBox5.Controls.Add(this.rdoDownloadHourly);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(4, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(510, 60);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ความถี่การดาวน์โหลดไฟล์แปลภาษา";
            // 
            // rdoDownloadAlways
            // 
            this.rdoDownloadAlways.AutoSize = true;
            this.rdoDownloadAlways.Checked = true;
            this.rdoDownloadAlways.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDownloadAlways.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoDownloadAlways.Location = new System.Drawing.Point(26, 26);
            this.rdoDownloadAlways.Name = "rdoDownloadAlways";
            this.rdoDownloadAlways.Size = new System.Drawing.Size(63, 21);
            this.rdoDownloadAlways.TabIndex = 0;
            this.rdoDownloadAlways.TabStop = true;
            this.rdoDownloadAlways.Text = "ทุกครั้ง";
            this.rdoDownloadAlways.UseVisualStyleBackColor = true;
            // 
            // rdoDownloadDialy
            // 
            this.rdoDownloadDialy.AutoSize = true;
            this.rdoDownloadDialy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDownloadDialy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoDownloadDialy.Location = new System.Drawing.Point(291, 26);
            this.rdoDownloadDialy.Name = "rdoDownloadDialy";
            this.rdoDownloadDialy.Size = new System.Drawing.Size(76, 21);
            this.rdoDownloadDialy.TabIndex = 0;
            this.rdoDownloadDialy.Text = "วันละครั้ง";
            this.rdoDownloadDialy.UseVisualStyleBackColor = true;
            // 
            // rdoDownloadOnce
            // 
            this.rdoDownloadOnce.AutoSize = true;
            this.rdoDownloadOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDownloadOnce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoDownloadOnce.Location = new System.Drawing.Point(406, 26);
            this.rdoDownloadOnce.Name = "rdoDownloadOnce";
            this.rdoDownloadOnce.Size = new System.Drawing.Size(73, 21);
            this.rdoDownloadOnce.TabIndex = 0;
            this.rdoDownloadOnce.Text = "ครั้งเดียว";
            this.rdoDownloadOnce.UseVisualStyleBackColor = true;
            // 
            // rdoDownloadHourly
            // 
            this.rdoDownloadHourly.AutoSize = true;
            this.rdoDownloadHourly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDownloadHourly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoDownloadHourly.Location = new System.Drawing.Point(150, 26);
            this.rdoDownloadHourly.Name = "rdoDownloadHourly";
            this.rdoDownloadHourly.Size = new System.Drawing.Size(77, 21);
            this.rdoDownloadHourly.TabIndex = 0;
            this.rdoDownloadHourly.Text = "ทุกชั่วโมง";
            this.rdoDownloadHourly.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.chkRandomLoading);
            this.groupBox8.Controls.Add(this.chkBackupSetting);
            this.groupBox8.Controls.Add(this.chkOldMethod);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox8.Location = new System.Drawing.Point(4, 354);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(510, 51);
            this.groupBox8.TabIndex = 46;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "อื่นๆ";
            // 
            // chkRandomLoading
            // 
            this.chkRandomLoading.AutoSize = true;
            this.chkRandomLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandomLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkRandomLoading.Location = new System.Drawing.Point(290, 22);
            this.chkRandomLoading.Name = "chkRandomLoading";
            this.chkRandomLoading.Size = new System.Drawing.Size(160, 21);
            this.chkRandomLoading.TabIndex = 39;
            this.chkRandomLoading.Text = "สุ่มข้อความหน้าโหลดเกม";
            this.chkRandomLoading.UseVisualStyleBackColor = true;
            // 
            // chkBackupSetting
            // 
            this.chkBackupSetting.AutoSize = true;
            this.chkBackupSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBackupSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkBackupSetting.Location = new System.Drawing.Point(149, 22);
            this.chkBackupSetting.Name = "chkBackupSetting";
            this.chkBackupSetting.Size = new System.Drawing.Size(129, 21);
            this.chkBackupSetting.TabIndex = 38;
            this.chkBackupSetting.Text = "สำรองไฟล์ setting";
            this.chkBackupSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnInstallFont);
            this.groupBox4.Controls.Add(this.rdoFontPrompt);
            this.groupBox4.Controls.Add(this.rdoFontMahaniyom);
            this.groupBox4.Controls.Add(this.rdoFontSuperMarket);
            this.groupBox4.Controls.Add(this.rdoFontSrisakdi);
            this.groupBox4.Controls.Add(this.rdoFontCsPrakas);
            this.groupBox4.Controls.Add(this.rdoFontSarabun);
            this.groupBox4.Controls.Add(this.rdoFontNone);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(3, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 83);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ฟอนต์";
            // 
            // btnInstallFont
            // 
            this.btnInstallFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallFont.Location = new System.Drawing.Point(406, 48);
            this.btnInstallFont.Name = "btnInstallFont";
            this.btnInstallFont.Size = new System.Drawing.Size(98, 24);
            this.btnInstallFont.TabIndex = 52;
            this.btnInstallFont.Text = "เปลี่ยนตอนนี้";
            this.btnInstallFont.UseVisualStyleBackColor = true;
            this.btnInstallFont.Click += new System.EventHandler(this.btnInstallFont_Click);
            // 
            // rdoFontPrompt
            // 
            this.rdoFontPrompt.AutoSize = true;
            this.rdoFontPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontPrompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoFontPrompt.Location = new System.Drawing.Point(291, 50);
            this.rdoFontPrompt.Name = "rdoFontPrompt";
            this.rdoFontPrompt.Size = new System.Drawing.Size(71, 21);
            this.rdoFontPrompt.TabIndex = 4;
            this.rdoFontPrompt.Text = "Prompt";
            this.rdoFontPrompt.UseVisualStyleBackColor = true;
            // 
            // rdoFontMahaniyom
            // 
            this.rdoFontMahaniyom.AutoSize = true;
            this.rdoFontMahaniyom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontMahaniyom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoFontMahaniyom.Location = new System.Drawing.Point(150, 24);
            this.rdoFontMahaniyom.Name = "rdoFontMahaniyom";
            this.rdoFontMahaniyom.Size = new System.Drawing.Size(73, 21);
            this.rdoFontMahaniyom.TabIndex = 3;
            this.rdoFontMahaniyom.Text = "มหานิยม";
            this.rdoFontMahaniyom.UseVisualStyleBackColor = true;
            // 
            // rdoFontSuperMarket
            // 
            this.rdoFontSuperMarket.AutoSize = true;
            this.rdoFontSuperMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontSuperMarket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoFontSuperMarket.Location = new System.Drawing.Point(150, 50);
            this.rdoFontSuperMarket.Name = "rdoFontSuperMarket";
            this.rdoFontSuperMarket.Size = new System.Drawing.Size(109, 21);
            this.rdoFontSuperMarket.TabIndex = 3;
            this.rdoFontSuperMarket.Text = "ซุปเปอร์มาร์เกต";
            this.rdoFontSuperMarket.UseVisualStyleBackColor = true;
            // 
            // rdoFontSrisakdi
            // 
            this.rdoFontSrisakdi.AutoSize = true;
            this.rdoFontSrisakdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontSrisakdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoFontSrisakdi.Location = new System.Drawing.Point(291, 24);
            this.rdoFontSrisakdi.Name = "rdoFontSrisakdi";
            this.rdoFontSrisakdi.Size = new System.Drawing.Size(76, 21);
            this.rdoFontSrisakdi.TabIndex = 3;
            this.rdoFontSrisakdi.Text = "Srisakdi";
            this.rdoFontSrisakdi.UseVisualStyleBackColor = true;
            // 
            // rdoFontCsPrakas
            // 
            this.rdoFontCsPrakas.AutoSize = true;
            this.rdoFontCsPrakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontCsPrakas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoFontCsPrakas.Location = new System.Drawing.Point(26, 50);
            this.rdoFontCsPrakas.Name = "rdoFontCsPrakas";
            this.rdoFontCsPrakas.Size = new System.Drawing.Size(69, 21);
            this.rdoFontCsPrakas.TabIndex = 3;
            this.rdoFontCsPrakas.Text = "ประกาศ";
            this.rdoFontCsPrakas.UseVisualStyleBackColor = true;
            // 
            // rdoFontSarabun
            // 
            this.rdoFontSarabun.AutoSize = true;
            this.rdoFontSarabun.Checked = true;
            this.rdoFontSarabun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontSarabun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoFontSarabun.Location = new System.Drawing.Point(26, 24);
            this.rdoFontSarabun.Name = "rdoFontSarabun";
            this.rdoFontSarabun.Size = new System.Drawing.Size(64, 21);
            this.rdoFontSarabun.TabIndex = 2;
            this.rdoFontSarabun.TabStop = true;
            this.rdoFontSarabun.Text = "สารบัญ";
            this.rdoFontSarabun.UseVisualStyleBackColor = true;
            // 
            // rdoFontNone
            // 
            this.rdoFontNone.AutoSize = true;
            this.rdoFontNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontNone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoFontNone.Location = new System.Drawing.Point(406, 24);
            this.rdoFontNone.Name = "rdoFontNone";
            this.rdoFontNone.Size = new System.Drawing.Size(91, 21);
            this.rdoFontNone.TabIndex = 1;
            this.rdoFontNone.Text = "ไม่เอาฟอนต์";
            this.rdoFontNone.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVersion,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(412, 76);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miVersion
            // 
            this.miVersion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLog,
            this.miUpdate,
            this.miTranslateProgress,
            this.miMessageFinder,
            this.miChangeLog,
            this.miCredit,
            this.miDebug});
            this.miVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.miVersion.Name = "miVersion";
            this.miVersion.Size = new System.Drawing.Size(113, 20);
            this.miVersion.Text = "V. 9999.99.99.9999";
            this.miVersion.Click += new System.EventHandler(this.miVersion_Click);
            // 
            // miLog
            // 
            this.miLog.Name = "miLog";
            this.miLog.Size = new System.Drawing.Size(176, 22);
            this.miLog.Text = "Log";
            this.miLog.Click += new System.EventHandler(this.miLog_Click);
            // 
            // miUpdate
            // 
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.Size = new System.Drawing.Size(176, 22);
            this.miUpdate.Text = "อัพเดทโปรแกรม";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // miTranslateProgress
            // 
            this.miTranslateProgress.Name = "miTranslateProgress";
            this.miTranslateProgress.Size = new System.Drawing.Size(176, 22);
            this.miTranslateProgress.Text = "ข้อมูลการแปล";
            this.miTranslateProgress.Visible = false;
            this.miTranslateProgress.Click += new System.EventHandler(this.miTranslateProgress_Click);
            // 
            // miMessageFinder
            // 
            this.miMessageFinder.Name = "miMessageFinder";
            this.miMessageFinder.Size = new System.Drawing.Size(176, 22);
            this.miMessageFinder.Text = "เครื่องมือค้นหาข้อความ";
            this.miMessageFinder.Visible = false;
            this.miMessageFinder.Click += new System.EventHandler(this.miMessageFinder_Click);
            // 
            // miChangeLog
            // 
            this.miChangeLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miChangeLog.Name = "miChangeLog";
            this.miChangeLog.Size = new System.Drawing.Size(176, 22);
            this.miChangeLog.Text = "การเปลี่ยนแปลง";
            this.miChangeLog.Click += new System.EventHandler(this.miChangeLog_Click);
            // 
            // miCredit
            // 
            this.miCredit.Name = "miCredit";
            this.miCredit.Size = new System.Drawing.Size(176, 22);
            this.miCredit.Text = "เครดิต";
            this.miCredit.Click += new System.EventHandler(this.miCredit_Click);
            // 
            // miDebug
            // 
            this.miDebug.Name = "miDebug";
            this.miDebug.Size = new System.Drawing.Size(176, 22);
            this.miDebug.Text = "สวัสดี ฉันชื่อสะหวีวี่วี";
            this.miDebug.Click += new System.EventHandler(this.miDebug_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // txtGamePath
            // 
            this.txtGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamePath.Location = new System.Drawing.Point(16, 29);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(467, 23);
            this.txtGamePath.TabIndex = 6;
            this.txtGamePath.TextChanged += new System.EventHandler(this.txtGamePath_TextChanged);
            this.txtGamePath.DoubleClick += new System.EventHandler(this.txtGamePath_DoubleClick);
            // 
            // frmVeryVerySimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 720);
            this.Controls.Add(this.btnLegacyGenerate);
            this.Controls.Add(this.btnGamePath);
            this.Controls.Add(this.txtGamePath);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnAdvance);
            this.Controls.Add(this.lblGameDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmVeryVerySimple";
            this.ShowIcon = false;
            this.Text = "The Witcher 3 Translate Utility by svvv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerySimple_FormClosing);
            this.Load += new System.EventHandler(this.frmVerySimple_Load);
            this.Shown += new System.EventHandler(this.frmVeryVerySimple_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnAdvance.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeCutScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeSpeak)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoDownloadAlways;
        private System.Windows.Forms.RadioButton rdoDownloadHourly;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miVersion;
        private System.Windows.Forms.ToolStripMenuItem miChangeLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miUpdate;
        private System.Windows.Forms.RadioButton rdoDownloadDialy;
        private System.Windows.Forms.RadioButton rdoDownloadOnce;
        private System.Windows.Forms.RadioButton rdoFontNone;
        private System.Windows.Forms.RadioButton rdoFontSarabun;
        private System.Windows.Forms.CheckBox chkExcludeUiText;
        private System.Windows.Forms.NumericUpDown txtFontSizeCutScene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem miCredit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown txtFontSizeSpeak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMessageFinder;
        private System.Windows.Forms.ToolStripMenuItem miTranslateProgress;
        private System.Windows.Forms.ToolStripMenuItem miMessageFinder;
        private System.Windows.Forms.Button btnFixMod;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnAltSubSetting;
        private System.Windows.Forms.CheckBox chkOldMethod;
        private System.Windows.Forms.Label lblCustomTranslateCount;
        private System.Windows.Forms.RadioButton rdoFontPrompt;
        private System.Windows.Forms.RadioButton rdoFontCsPrakas;
        private System.Windows.Forms.Button btnInstallFont;
        private System.Windows.Forms.Button btnChangeFontSize;
        private System.Windows.Forms.ToolStripMenuItem miDebug;
        private System.Windows.Forms.CheckBox chkChangeTextColor;
        private System.Windows.Forms.RadioButton rdoFontMahaniyom;
        private System.Windows.Forms.RadioButton rdoFontSuperMarket;
        private System.Windows.Forms.RadioButton rdoFontSrisakdi;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkBackupSetting;
        private System.Windows.Forms.CheckBox chkRandomLoading;
        private System.Windows.Forms.ToolStripMenuItem miLog;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rdoNormalCompatibility;
        private System.Windows.Forms.RadioButton rdoHighCompatibility;
        private System.Windows.Forms.RadioButton rdoMediumCompatibility;
    }
}