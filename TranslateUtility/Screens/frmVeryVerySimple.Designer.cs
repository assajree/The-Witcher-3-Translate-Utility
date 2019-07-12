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
            this.components = new System.ComponentModel.Container();
            TranslateUtility.Properties.Settings settings1 = new TranslateUtility.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeryVerySimple));
            this.btnGamePath = new System.Windows.Forms.Button();
            this.lblGameDir = new System.Windows.Forms.Label();
            this.rdoModTranslateFirst = new System.Windows.Forms.RadioButton();
            this.btnLegacyGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAltSub = new System.Windows.Forms.CheckBox();
            this.chkExcludeUiText = new System.Windows.Forms.CheckBox();
            this.chkModDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.rdoModOriginFirst = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUiInfo = new System.Windows.Forms.CheckBox();
            this.chkUntranslateInfo = new System.Windows.Forms.CheckBox();
            this.chkTranslateInfo = new System.Windows.Forms.CheckBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAdvance = new System.Windows.Forms.LinkLabel();
            this.pnAdvance = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtFontSizeCutScene = new System.Windows.Forms.NumericUpDown();
            this.txtFontSizeSpeak = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoDownloadAlways = new System.Windows.Forms.RadioButton();
            this.rdoDownloadDialy = new System.Windows.Forms.RadioButton();
            this.rdoDownloadOnce = new System.Windows.Forms.RadioButton();
            this.rdoDownloadHourly = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoFontSarabun = new System.Windows.Forms.RadioButton();
            this.rdoFontNone = new System.Windows.Forms.RadioButton();
            this.rdoFontKuntoon = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.miCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.btnMessageFinder = new System.Windows.Forms.Button();
            this.miTranslateProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.miMessageFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnAdvance.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeCutScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeSpeak)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGamePath
            // 
            this.btnGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGamePath.Location = new System.Drawing.Point(536, 29);
            this.btnGamePath.Name = "btnGamePath";
            this.btnGamePath.Size = new System.Drawing.Size(32, 23);
            this.btnGamePath.TabIndex = 7;
            this.btnGamePath.Text = "...";
            this.btnGamePath.UseVisualStyleBackColor = true;
            this.btnGamePath.Click += new System.EventHandler(this.btnGamePath_Click);
            // 
            // lblGameDir
            // 
            this.lblGameDir.AutoSize = true;
            this.lblGameDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDir.Location = new System.Drawing.Point(12, 9);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(96, 17);
            this.lblGameDir.TabIndex = 8;
            this.lblGameDir.Text = "โฟลเดอร์เกม :";
            this.lblGameDir.DoubleClick += new System.EventHandler(this.lblGameDir_DoubleClick);
            // 
            // rdoModTranslateFirst
            // 
            this.rdoModTranslateFirst.AutoSize = true;
            this.rdoModTranslateFirst.Checked = true;
            this.rdoModTranslateFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModTranslateFirst.Location = new System.Drawing.Point(25, 29);
            this.rdoModTranslateFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoModTranslateFirst.Name = "rdoModTranslateFirst";
            this.rdoModTranslateFirst.Size = new System.Drawing.Size(101, 21);
            this.rdoModTranslateFirst.TabIndex = 35;
            this.rdoModTranslateFirst.TabStop = true;
            this.rdoModTranslateFirst.Text = "ภาษาไทยก่อน";
            this.rdoModTranslateFirst.UseVisualStyleBackColor = true;
            // 
            // btnLegacyGenerate
            // 
            this.btnLegacyGenerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLegacyGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLegacyGenerate.Location = new System.Drawing.Point(214, 66);
            this.btnLegacyGenerate.Name = "btnLegacyGenerate";
            this.btnLegacyGenerate.Size = new System.Drawing.Size(141, 34);
            this.btnLegacyGenerate.TabIndex = 33;
            this.btnLegacyGenerate.Text = "สร้างม็อด && ติดตั้ง";
            this.btnLegacyGenerate.UseVisualStyleBackColor = true;
            this.btnLegacyGenerate.Click += new System.EventHandler(this.btnLegacyGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAltSub);
            this.groupBox1.Controls.Add(this.chkExcludeUiText);
            this.groupBox1.Controls.Add(this.chkModDoubleLanguage);
            this.groupBox1.Controls.Add(this.rdoModTranslateFirst);
            this.groupBox1.Controls.Add(this.rdoModOriginFirst);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 61);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สองภาษา";
            // 
            // chkAltSub
            // 
            this.chkAltSub.AutoSize = true;
            this.chkAltSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAltSub.Location = new System.Drawing.Point(395, 0);
            this.chkAltSub.Name = "chkAltSub";
            this.chkAltSub.Size = new System.Drawing.Size(123, 21);
            this.chkAltSub.TabIndex = 38;
            this.chkAltSub.Text = "ซับไทยทางเลือก";
            this.chkAltSub.UseVisualStyleBackColor = true;
            // 
            // chkExcludeUiText
            // 
            this.chkExcludeUiText.AutoSize = true;
            this.chkExcludeUiText.Checked = global::TranslateUtility.Properties.Settings.Default._VerySimpleTranslateUI;
            this.chkExcludeUiText.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_VerySimpleTranslateUI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkExcludeUiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcludeUiText.Location = new System.Drawing.Point(98, 0);
            this.chkExcludeUiText.Name = "chkExcludeUiText";
            this.chkExcludeUiText.Size = new System.Drawing.Size(127, 21);
            this.chkExcludeUiText.TabIndex = 37;
            this.chkExcludeUiText.Text = "เมนูภาษาอังกฤษ";
            this.chkExcludeUiText.UseVisualStyleBackColor = true;
            // 
            // chkModDoubleLanguage
            // 
            this.chkModDoubleLanguage.AutoSize = true;
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
            settings1._Simple2Language = true;
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
            this.chkModDoubleLanguage.Checked = settings1._Simple2Language;
            this.chkModDoubleLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModDoubleLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_Simple2Language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkModDoubleLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.rdoModOriginFirst.Checked = settings1._SimpleOriginalFirst;
            this.rdoModOriginFirst.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_SimpleOriginalFirst", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoModOriginFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoModOriginFirst.Location = new System.Drawing.Point(152, 29);
            this.rdoModOriginFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoModOriginFirst.Name = "rdoModOriginFirst";
            this.rdoModOriginFirst.Size = new System.Drawing.Size(117, 21);
            this.rdoModOriginFirst.TabIndex = 34;
            this.rdoModOriginFirst.Text = "ภาษาอังกฤษก่อน";
            this.rdoModOriginFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkUiInfo);
            this.groupBox2.Controls.Add(this.chkUntranslateInfo);
            this.groupBox2.Controls.Add(this.chkTranslateInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 61);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "แสดงรายละเอียดข้อความ (ข้อความในวงเล็บ)";
            // 
            // chkUiInfo
            // 
            this.chkUiInfo.AutoSize = true;
            this.chkUiInfo.Checked = settings1._SimpleUiInfo;
            this.chkUiInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_SimpleUiInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUiInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUiInfo.Location = new System.Drawing.Point(288, 29);
            this.chkUiInfo.Name = "chkUiInfo";
            this.chkUiInfo.Size = new System.Drawing.Size(40, 21);
            this.chkUiInfo.TabIndex = 40;
            this.chkUiInfo.Text = "UI";
            this.chkUiInfo.UseVisualStyleBackColor = true;
            // 
            // chkUntranslateInfo
            // 
            this.chkUntranslateInfo.AutoSize = true;
            this.chkUntranslateInfo.Checked = settings1._SimpleUntranslateInfo;
            this.chkUntranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_SimpleUntranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUntranslateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUntranslateInfo.Location = new System.Drawing.Point(25, 29);
            this.chkUntranslateInfo.Name = "chkUntranslateInfo";
            this.chkUntranslateInfo.Size = new System.Drawing.Size(101, 21);
            this.chkUntranslateInfo.TabIndex = 37;
            this.chkUntranslateInfo.Text = "ที่ยังไม่ได้แปล";
            this.chkUntranslateInfo.UseVisualStyleBackColor = true;
            // 
            // chkTranslateInfo
            // 
            this.chkTranslateInfo.AutoSize = true;
            this.chkTranslateInfo.Checked = settings1._SimpleTranslateInfo;
            this.chkTranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "_SimpleTranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTranslateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTranslateInfo.Location = new System.Drawing.Point(152, 29);
            this.chkTranslateInfo.Name = "chkTranslateInfo";
            this.chkTranslateInfo.Size = new System.Drawing.Size(80, 21);
            this.chkTranslateInfo.TabIndex = 39;
            this.chkTranslateInfo.Text = "ที่แปลแล้ว";
            this.chkTranslateInfo.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(6, 19);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(123, 32);
            this.btnResult.TabIndex = 48;
            this.btnResult.Text = "ข้อมูลการแปล";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(415, 19);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(123, 32);
            this.btnRestore.TabIndex = 49;
            this.btnRestore.Text = "ลบม็อด";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMessageFinder);
            this.groupBox3.Controls.Add(this.btnResult);
            this.groupBox3.Controls.Add(this.btnRestore);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 61);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "อื่นๆ";
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.Location = new System.Drawing.Point(15, 82);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(38, 17);
            this.lblAdvance.TabIndex = 51;
            this.lblAdvance.TabStop = true;
            this.lblAdvance.Text = "ขั้นสูง";
            this.lblAdvance.Click += new System.EventHandler(this.lblAdvance_Click);
            // 
            // pnAdvance
            // 
            this.pnAdvance.Controls.Add(this.groupBox6);
            this.pnAdvance.Controls.Add(this.groupBox5);
            this.pnAdvance.Controls.Add(this.groupBox4);
            this.pnAdvance.Controls.Add(this.groupBox1);
            this.pnAdvance.Controls.Add(this.groupBox2);
            this.pnAdvance.Controls.Add(this.groupBox3);
            this.pnAdvance.Location = new System.Drawing.Point(15, 108);
            this.pnAdvance.Name = "pnAdvance";
            this.pnAdvance.Size = new System.Drawing.Size(553, 414);
            this.pnAdvance.TabIndex = 52;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtFontSizeCutScene);
            this.groupBox6.Controls.Add(this.txtFontSizeSpeak);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 206);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(544, 61);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ขนาดซับไตเติ้ล (ค่าเริ่มต้น 28)";
            // 
            // txtFontSizeCutScene
            // 
            this.txtFontSizeCutScene.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TranslateUtility.Properties.Settings.Default, "_VerySimpleFontSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFontSizeCutScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeCutScene.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtFontSizeCutScene.Location = new System.Drawing.Point(66, 28);
            this.txtFontSizeCutScene.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtFontSizeCutScene.Name = "txtFontSizeCutScene";
            this.txtFontSizeCutScene.Size = new System.Drawing.Size(44, 23);
            this.txtFontSizeCutScene.TabIndex = 4;
            this.txtFontSizeCutScene.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFontSizeCutScene.Value = global::TranslateUtility.Properties.Settings.Default._VerySimpleFontSize;
            // 
            // txtFontSizeSpeak
            // 
            this.txtFontSizeSpeak.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::TranslateUtility.Properties.Settings.Default, "_VerySimpleFontSizeSpeak", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFontSizeSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFontSizeSpeak.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtFontSizeSpeak.Location = new System.Drawing.Point(215, 27);
            this.txtFontSizeSpeak.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtFontSizeSpeak.Name = "txtFontSizeSpeak";
            this.txtFontSizeSpeak.Size = new System.Drawing.Size(44, 23);
            this.txtFontSizeSpeak.TabIndex = 4;
            this.txtFontSizeSpeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFontSizeSpeak.Value = global::TranslateUtility.Properties.Settings.Default._VerySimpleFontSizeSpeak;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "คัทซีน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "นอกคัทซีน";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoDownloadAlways);
            this.groupBox5.Controls.Add(this.rdoDownloadDialy);
            this.groupBox5.Controls.Add(this.rdoDownloadOnce);
            this.groupBox5.Controls.Add(this.rdoDownloadHourly);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 274);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(544, 61);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ความถี่การดาวน์โหลดไฟล์แปลภาษา";
            // 
            // rdoDownloadAlways
            // 
            this.rdoDownloadAlways.AutoSize = true;
            this.rdoDownloadAlways.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDownloadAlways.Location = new System.Drawing.Point(25, 26);
            this.rdoDownloadAlways.Name = "rdoDownloadAlways";
            this.rdoDownloadAlways.Size = new System.Drawing.Size(63, 21);
            this.rdoDownloadAlways.TabIndex = 0;
            this.rdoDownloadAlways.Text = "ทุกครั้ง";
            this.rdoDownloadAlways.UseVisualStyleBackColor = true;
            // 
            // rdoDownloadDialy
            // 
            this.rdoDownloadDialy.AutoSize = true;
            this.rdoDownloadDialy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDownloadDialy.Location = new System.Drawing.Point(214, 26);
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
            this.rdoDownloadOnce.Location = new System.Drawing.Point(317, 26);
            this.rdoDownloadOnce.Name = "rdoDownloadOnce";
            this.rdoDownloadOnce.Size = new System.Drawing.Size(73, 21);
            this.rdoDownloadOnce.TabIndex = 0;
            this.rdoDownloadOnce.Text = "ครั้งเดียว";
            this.rdoDownloadOnce.UseVisualStyleBackColor = true;
            // 
            // rdoDownloadHourly
            // 
            this.rdoDownloadHourly.AutoSize = true;
            this.rdoDownloadHourly.Checked = true;
            this.rdoDownloadHourly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDownloadHourly.Location = new System.Drawing.Point(116, 26);
            this.rdoDownloadHourly.Name = "rdoDownloadHourly";
            this.rdoDownloadHourly.Size = new System.Drawing.Size(77, 21);
            this.rdoDownloadHourly.TabIndex = 0;
            this.rdoDownloadHourly.TabStop = true;
            this.rdoDownloadHourly.Text = "ทุกชั่วโมง";
            this.rdoDownloadHourly.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoFontSarabun);
            this.groupBox4.Controls.Add(this.rdoFontNone);
            this.groupBox4.Controls.Add(this.rdoFontKuntoon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 61);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ฟอนต์";
            // 
            // rdoFontSarabun
            // 
            this.rdoFontSarabun.AutoSize = true;
            this.rdoFontSarabun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontSarabun.Location = new System.Drawing.Point(25, 24);
            this.rdoFontSarabun.Name = "rdoFontSarabun";
            this.rdoFontSarabun.Size = new System.Drawing.Size(64, 21);
            this.rdoFontSarabun.TabIndex = 2;
            this.rdoFontSarabun.Text = "สารบัญ";
            this.rdoFontSarabun.UseVisualStyleBackColor = true;
            // 
            // rdoFontNone
            // 
            this.rdoFontNone.AutoSize = true;
            this.rdoFontNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontNone.Location = new System.Drawing.Point(288, 24);
            this.rdoFontNone.Name = "rdoFontNone";
            this.rdoFontNone.Size = new System.Drawing.Size(91, 21);
            this.rdoFontNone.TabIndex = 1;
            this.rdoFontNone.Text = "ไม่เอาฟอนต์";
            this.rdoFontNone.UseVisualStyleBackColor = true;
            // 
            // rdoFontKuntoon
            // 
            this.rdoFontKuntoon.AutoSize = true;
            this.rdoFontKuntoon.Checked = true;
            this.rdoFontKuntoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFontKuntoon.Location = new System.Drawing.Point(152, 24);
            this.rdoFontKuntoon.Name = "rdoFontKuntoon";
            this.rdoFontKuntoon.Size = new System.Drawing.Size(62, 21);
            this.rdoFontKuntoon.TabIndex = 0;
            this.rdoFontKuntoon.TabStop = true;
            this.rdoFontKuntoon.Text = "คุณตูน";
            this.rdoFontKuntoon.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVersion,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(420, 80);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(154, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miVersion
            // 
            this.miVersion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUpdate,
            this.miTranslateProgress,
            this.miMessageFinder,
            this.miChangeLog,
            this.miCredit});
            this.miVersion.Name = "miVersion";
            this.miVersion.Size = new System.Drawing.Size(147, 20);
            this.miVersion.Text = "Version : 9999.99.99.9999";
            // 
            // miChangeLog
            // 
            this.miChangeLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miChangeLog.Name = "miChangeLog";
            this.miChangeLog.Size = new System.Drawing.Size(180, 22);
            this.miChangeLog.Text = "การเปลี่ยนแปลง";
            this.miChangeLog.Click += new System.EventHandler(this.miChangeLog_Click);
            // 
            // miUpdate
            // 
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.Size = new System.Drawing.Size(180, 22);
            this.miUpdate.Text = "อัพเดทโปรแกรม";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // miCredit
            // 
            this.miCredit.Name = "miCredit";
            this.miCredit.Size = new System.Drawing.Size(180, 22);
            this.miCredit.Text = "เครดิต";
            this.miCredit.Click += new System.EventHandler(this.miCredit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // txtGamePath
            // 
            this.txtGamePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_VerySimpleGamePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGamePath.Location = new System.Drawing.Point(15, 29);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(516, 23);
            this.txtGamePath.TabIndex = 6;
            this.txtGamePath.Text = global::TranslateUtility.Properties.Settings.Default._VerySimpleGamePath;
            this.txtGamePath.TextChanged += new System.EventHandler(this.txtGamePath_TextChanged);
            this.txtGamePath.DoubleClick += new System.EventHandler(this.txtGamePath_DoubleClick);
            // 
            // btnMessageFinder
            // 
            this.btnMessageFinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessageFinder.Location = new System.Drawing.Point(135, 19);
            this.btnMessageFinder.Name = "btnMessageFinder";
            this.btnMessageFinder.Size = new System.Drawing.Size(123, 32);
            this.btnMessageFinder.TabIndex = 50;
            this.btnMessageFinder.Text = "ค้นหาข้อความ";
            this.btnMessageFinder.UseVisualStyleBackColor = true;
            this.btnMessageFinder.Click += new System.EventHandler(this.btnMessageFinder_Click);
            // 
            // miTranslateProgress
            // 
            this.miTranslateProgress.Name = "miTranslateProgress";
            this.miTranslateProgress.Size = new System.Drawing.Size(180, 22);
            this.miTranslateProgress.Text = "ข้อมูลการแปล";
            this.miTranslateProgress.Click += new System.EventHandler(this.miTranslateProgress_Click);
            // 
            // miMessageFinder
            // 
            this.miMessageFinder.Name = "miMessageFinder";
            this.miMessageFinder.Size = new System.Drawing.Size(180, 22);
            this.miMessageFinder.Text = "เครื่องมือค้นหาข้อความ";
            this.miMessageFinder.Click += new System.EventHandler(this.miMessageFinder_Click);
            // 
            // frmVeryVerySimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 526);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnLegacyGenerate);
            this.Controls.Add(this.pnAdvance);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.lblGameDir);
            this.Controls.Add(this.btnGamePath);
            this.Controls.Add(this.txtGamePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmVeryVerySimple";
            this.Text = "The Witcher 3 Translate Utility by svvv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVerySimple_FormClosing);
            this.Load += new System.EventHandler(this.frmVerySimple_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pnAdvance.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeCutScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontSizeSpeak)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdoFontKuntoon;
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
        private System.Windows.Forms.CheckBox chkAltSub;
        private System.Windows.Forms.Button btnMessageFinder;
        private System.Windows.Forms.ToolStripMenuItem miTranslateProgress;
        private System.Windows.Forms.ToolStripMenuItem miMessageFinder;
    }
}