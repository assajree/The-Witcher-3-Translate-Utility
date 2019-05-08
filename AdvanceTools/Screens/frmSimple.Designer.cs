namespace TranslateUtility
{
    partial class frmSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimple));
            this.pnTranslate = new System.Windows.Forms.GroupBox();
            this.btnModDownload = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLocalVersion = new System.Windows.Forms.Label();
            this.lblLastedVersion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLastCheck = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnGamePath = new System.Windows.Forms.Button();
            this.btnCheckVersion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.btnModPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModPath = new System.Windows.Forms.TextBox();
            this.btnInstallLang = new System.Windows.Forms.Button();
            this.btnLegacyOutputOpen = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkTranslateInfo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUntranslateInfo = new System.Windows.Forms.CheckBox();
            this.rdoModTranslateFirst = new System.Windows.Forms.RadioButton();
            this.rdoModOriginFirst = new System.Windows.Forms.RadioButton();
            this.chkModDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.btnLegacyExcelDownload = new System.Windows.Forms.Button();
            this.txtLegacyExcel = new System.Windows.Forms.TextBox();
            this.btnLegacyExcel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLegacyOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLegacyOutput = new System.Windows.Forms.TextBox();
            this.btnLegacyGenerate = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.chkUiInfo = new System.Windows.Forms.CheckBox();
            this.pnTranslate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTranslate
            // 
            this.pnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTranslate.Controls.Add(this.btnModDownload);
            this.pnTranslate.Controls.Add(this.btnRestore);
            this.pnTranslate.Controls.Add(this.panel1);
            this.pnTranslate.Controls.Add(this.btnBackup);
            this.pnTranslate.Controls.Add(this.btnGamePath);
            this.pnTranslate.Controls.Add(this.btnCheckVersion);
            this.pnTranslate.Controls.Add(this.label3);
            this.pnTranslate.Controls.Add(this.txtGamePath);
            this.pnTranslate.Controls.Add(this.btnModPath);
            this.pnTranslate.Controls.Add(this.label4);
            this.pnTranslate.Controls.Add(this.txtModPath);
            this.pnTranslate.Controls.Add(this.btnInstallLang);
            this.pnTranslate.Location = new System.Drawing.Point(12, 171);
            this.pnTranslate.Name = "pnTranslate";
            this.pnTranslate.Size = new System.Drawing.Size(678, 206);
            this.pnTranslate.TabIndex = 11;
            this.pnTranslate.TabStop = false;
            this.pnTranslate.Text = " ติดตั้ง mod ";
            // 
            // btnModDownload
            // 
            this.btnModDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModDownload.Location = new System.Drawing.Point(590, 17);
            this.btnModDownload.Name = "btnModDownload";
            this.btnModDownload.Size = new System.Drawing.Size(75, 23);
            this.btnModDownload.TabIndex = 29;
            this.btnModDownload.Text = "ดาวน์โหลด";
            this.btnModDownload.UseVisualStyleBackColor = true;
            this.btnModDownload.Click += new System.EventHandler(this.btnModDownload_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.Location = new System.Drawing.Point(326, 71);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 31;
            this.btnRestore.Text = "คืนค่า";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblLocalVersion);
            this.panel1.Controls.Add(this.lblLastedVersion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblLastCheck);
            this.panel1.Location = new System.Drawing.Point(112, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 62);
            this.panel1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "เวอร์ชั่น mod ที่กำลังจะติดตั้ง : ";
            // 
            // lblLocalVersion
            // 
            this.lblLocalVersion.AutoSize = true;
            this.lblLocalVersion.Location = new System.Drawing.Point(153, 0);
            this.lblLocalVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalVersion.Name = "lblLocalVersion";
            this.lblLocalVersion.Size = new System.Drawing.Size(27, 13);
            this.lblLocalVersion.TabIndex = 25;
            this.lblLocalVersion.Text = "N/A";
            // 
            // lblLastedVersion
            // 
            this.lblLastedVersion.AutoSize = true;
            this.lblLastedVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "LastestVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLastedVersion.Location = new System.Drawing.Point(153, 21);
            this.lblLastedVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastedVersion.Name = "lblLastedVersion";
            this.lblLastedVersion.Size = new System.Drawing.Size(27, 13);
            this.lblLastedVersion.TabIndex = 24;
            this.lblLastedVersion.Text = global::TranslateUtility.Properties.Settings.Default.LastestVersion;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "เวอร์ชั่น mod ล่าสุด               : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "เช็คเวอร์ชั่นล่าสุดเมื่อ           :";
            // 
            // lblLastCheck
            // 
            this.lblLastCheck.AutoSize = true;
            this.lblLastCheck.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "LastCheckUpdate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblLastCheck.Location = new System.Drawing.Point(153, 42);
            this.lblLastCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastCheck.Name = "lblLastCheck";
            this.lblLastCheck.Size = new System.Drawing.Size(27, 13);
            this.lblLastCheck.TabIndex = 27;
            this.lblLastCheck.Text = global::TranslateUtility.Properties.Settings.Default.LastCheckUpdate;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(245, 71);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 29;
            this.btnBackup.Text = "สำรองข้อมูล";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnGamePath
            // 
            this.btnGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGamePath.Location = new System.Drawing.Point(559, 42);
            this.btnGamePath.Name = "btnGamePath";
            this.btnGamePath.Size = new System.Drawing.Size(26, 23);
            this.btnGamePath.TabIndex = 5;
            this.btnGamePath.Text = "...";
            this.btnGamePath.UseVisualStyleBackColor = true;
            this.btnGamePath.Click += new System.EventHandler(this.btnGamePath_Click);
            // 
            // btnCheckVersion
            // 
            this.btnCheckVersion.Location = new System.Drawing.Point(112, 71);
            this.btnCheckVersion.Name = "btnCheckVersion";
            this.btnCheckVersion.Size = new System.Drawing.Size(127, 23);
            this.btnCheckVersion.TabIndex = 21;
            this.btnCheckVersion.Text = "เช็คเวอร์ชั่นล่าสุด";
            this.btnCheckVersion.UseVisualStyleBackColor = true;
            this.btnCheckVersion.Click += new System.EventHandler(this.btnCheckVersion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "โฟลเดอร์เกม";
            // 
            // txtGamePath
            // 
            this.txtGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGamePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_SimpleModPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGamePath.Location = new System.Drawing.Point(112, 45);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(440, 20);
            this.txtGamePath.TabIndex = 3;
            this.txtGamePath.Text = global::TranslateUtility.Properties.Settings.Default._SimpleModPath;
            // 
            // btnModPath
            // 
            this.btnModPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModPath.Location = new System.Drawing.Point(559, 17);
            this.btnModPath.Name = "btnModPath";
            this.btnModPath.Size = new System.Drawing.Size(26, 23);
            this.btnModPath.TabIndex = 2;
            this.btnModPath.Text = "...";
            this.btnModPath.UseVisualStyleBackColor = true;
            this.btnModPath.Click += new System.EventHandler(this.btnModPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "โฟลเดอร์ mod";
            // 
            // txtModPath
            // 
            this.txtModPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_SimpleGamePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtModPath.Location = new System.Drawing.Point(112, 19);
            this.txtModPath.Name = "txtModPath";
            this.txtModPath.Size = new System.Drawing.Size(440, 20);
            this.txtModPath.TabIndex = 0;
            this.txtModPath.Text = global::TranslateUtility.Properties.Settings.Default._SimpleGamePath;
            this.txtModPath.TextChanged += new System.EventHandler(this.txtModPath_TextChanged);
            // 
            // btnInstallLang
            // 
            this.btnInstallLang.Location = new System.Drawing.Point(112, 171);
            this.btnInstallLang.Name = "btnInstallLang";
            this.btnInstallLang.Size = new System.Drawing.Size(75, 23);
            this.btnInstallLang.TabIndex = 0;
            this.btnInstallLang.Text = "ติดตั้ง";
            this.btnInstallLang.UseVisualStyleBackColor = true;
            this.btnInstallLang.Click += new System.EventHandler(this.btnInstallLang_Click);
            // 
            // btnLegacyOutputOpen
            // 
            this.btnLegacyOutputOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegacyOutputOpen.Location = new System.Drawing.Point(590, 44);
            this.btnLegacyOutputOpen.Name = "btnLegacyOutputOpen";
            this.btnLegacyOutputOpen.Size = new System.Drawing.Size(75, 23);
            this.btnLegacyOutputOpen.TabIndex = 28;
            this.btnLegacyOutputOpen.Text = "เปิด";
            this.btnLegacyOutputOpen.UseVisualStyleBackColor = true;
            this.btnLegacyOutputOpen.Click += new System.EventHandler(this.btnLegacyOutputOpen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chkUiInfo);
            this.groupBox4.Controls.Add(this.chkTranslateInfo);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.chkUntranslateInfo);
            this.groupBox4.Controls.Add(this.rdoModTranslateFirst);
            this.groupBox4.Controls.Add(this.rdoModOriginFirst);
            this.groupBox4.Controls.Add(this.chkModDoubleLanguage);
            this.groupBox4.Controls.Add(this.btnLegacyOutputOpen);
            this.groupBox4.Controls.Add(this.btnLegacyExcelDownload);
            this.groupBox4.Controls.Add(this.txtLegacyExcel);
            this.groupBox4.Controls.Add(this.btnLegacyExcel);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.btnLegacyOutput);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtLegacyOutput);
            this.groupBox4.Controls.Add(this.btnLegacyGenerate);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(678, 153);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "สร้าง mod";
            // 
            // chkTranslateInfo
            // 
            this.chkTranslateInfo.AutoSize = true;
            this.chkTranslateInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleTranslateInfo;
            this.chkTranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleTranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTranslateInfo.Location = new System.Drawing.Point(206, 71);
            this.chkTranslateInfo.Name = "chkTranslateInfo";
            this.chkTranslateInfo.Size = new System.Drawing.Size(74, 17);
            this.chkTranslateInfo.TabIndex = 32;
            this.chkTranslateInfo.Text = "ที่แปลแล้ว";
            this.chkTranslateInfo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "แสดงข้อมูลข้อความ";
            // 
            // chkUntranslateInfo
            // 
            this.chkUntranslateInfo.AutoSize = true;
            this.chkUntranslateInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleUntranslateInfo;
            this.chkUntranslateInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleUntranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUntranslateInfo.Location = new System.Drawing.Point(112, 71);
            this.chkUntranslateInfo.Name = "chkUntranslateInfo";
            this.chkUntranslateInfo.Size = new System.Drawing.Size(92, 17);
            this.chkUntranslateInfo.TabIndex = 30;
            this.chkUntranslateInfo.Text = "ที่ยังไม่ได้แปล";
            this.chkUntranslateInfo.UseVisualStyleBackColor = true;
            // 
            // rdoModTranslateFirst
            // 
            this.rdoModTranslateFirst.AutoSize = true;
            this.rdoModTranslateFirst.Checked = true;
            this.rdoModTranslateFirst.Location = new System.Drawing.Point(206, 93);
            this.rdoModTranslateFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoModTranslateFirst.Name = "rdoModTranslateFirst";
            this.rdoModTranslateFirst.Size = new System.Drawing.Size(91, 17);
            this.rdoModTranslateFirst.TabIndex = 16;
            this.rdoModTranslateFirst.TabStop = true;
            this.rdoModTranslateFirst.Text = "ภาษาไทยก่อน";
            this.rdoModTranslateFirst.UseVisualStyleBackColor = true;
            // 
            // rdoModOriginFirst
            // 
            this.rdoModOriginFirst.AutoSize = true;
            this.rdoModOriginFirst.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleOriginalFirst;
            this.rdoModOriginFirst.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleOriginalFirst", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoModOriginFirst.Location = new System.Drawing.Point(304, 93);
            this.rdoModOriginFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoModOriginFirst.Name = "rdoModOriginFirst";
            this.rdoModOriginFirst.Size = new System.Drawing.Size(104, 17);
            this.rdoModOriginFirst.TabIndex = 15;
            this.rdoModOriginFirst.Text = "ภาษาอังกฤษก่อน";
            this.rdoModOriginFirst.UseVisualStyleBackColor = true;
            // 
            // chkModDoubleLanguage
            // 
            this.chkModDoubleLanguage.AutoSize = true;
            this.chkModDoubleLanguage.Checked = global::TranslateUtility.Properties.Settings.Default._Simple2Language;
            this.chkModDoubleLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModDoubleLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_Simple2Language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkModDoubleLanguage.Location = new System.Drawing.Point(112, 94);
            this.chkModDoubleLanguage.Name = "chkModDoubleLanguage";
            this.chkModDoubleLanguage.Size = new System.Drawing.Size(68, 17);
            this.chkModDoubleLanguage.TabIndex = 17;
            this.chkModDoubleLanguage.Text = "สองภาษา";
            this.chkModDoubleLanguage.UseVisualStyleBackColor = true;
            this.chkModDoubleLanguage.CheckedChanged += new System.EventHandler(this.chkModDoubleLanguage_CheckedChanged);
            // 
            // btnLegacyExcelDownload
            // 
            this.btnLegacyExcelDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegacyExcelDownload.Location = new System.Drawing.Point(590, 18);
            this.btnLegacyExcelDownload.Name = "btnLegacyExcelDownload";
            this.btnLegacyExcelDownload.Size = new System.Drawing.Size(76, 23);
            this.btnLegacyExcelDownload.TabIndex = 10;
            this.btnLegacyExcelDownload.Text = "ดาวน์โหลด";
            this.btnLegacyExcelDownload.UseVisualStyleBackColor = true;
            this.btnLegacyExcelDownload.Click += new System.EventHandler(this.btnLegacyExcelDownload_Click);
            // 
            // txtLegacyExcel
            // 
            this.txtLegacyExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLegacyExcel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_SimpleModInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLegacyExcel.Location = new System.Drawing.Point(112, 20);
            this.txtLegacyExcel.Name = "txtLegacyExcel";
            this.txtLegacyExcel.Size = new System.Drawing.Size(440, 20);
            this.txtLegacyExcel.TabIndex = 9;
            this.txtLegacyExcel.Text = global::TranslateUtility.Properties.Settings.Default._SimpleModInput;
            // 
            // btnLegacyExcel
            // 
            this.btnLegacyExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegacyExcel.Location = new System.Drawing.Point(558, 19);
            this.btnLegacyExcel.Name = "btnLegacyExcel";
            this.btnLegacyExcel.Size = new System.Drawing.Size(26, 23);
            this.btnLegacyExcel.TabIndex = 8;
            this.btnLegacyExcel.Text = "...";
            this.btnLegacyExcel.UseVisualStyleBackColor = true;
            this.btnLegacyExcel.Click += new System.EventHandler(this.btnLegacyExcel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "ไฟล์แปลภาษา";
            // 
            // btnLegacyOutput
            // 
            this.btnLegacyOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegacyOutput.Location = new System.Drawing.Point(558, 43);
            this.btnLegacyOutput.Name = "btnLegacyOutput";
            this.btnLegacyOutput.Size = new System.Drawing.Size(26, 23);
            this.btnLegacyOutput.TabIndex = 5;
            this.btnLegacyOutput.Text = "...";
            this.btnLegacyOutput.UseVisualStyleBackColor = true;
            this.btnLegacyOutput.Click += new System.EventHandler(this.btnLegacyOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "โฟล์เดอร์ปลายทาง";
            // 
            // txtLegacyOutput
            // 
            this.txtLegacyOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLegacyOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_SimpleModOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLegacyOutput.Location = new System.Drawing.Point(112, 44);
            this.txtLegacyOutput.Name = "txtLegacyOutput";
            this.txtLegacyOutput.Size = new System.Drawing.Size(440, 20);
            this.txtLegacyOutput.TabIndex = 3;
            this.txtLegacyOutput.Text = global::TranslateUtility.Properties.Settings.Default._SimpleModOutput;
            // 
            // btnLegacyGenerate
            // 
            this.btnLegacyGenerate.Location = new System.Drawing.Point(112, 118);
            this.btnLegacyGenerate.Name = "btnLegacyGenerate";
            this.btnLegacyGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnLegacyGenerate.TabIndex = 0;
            this.btnLegacyGenerate.Text = "สร้าง";
            this.btnLegacyGenerate.UseVisualStyleBackColor = true;
            this.btnLegacyGenerate.Click += new System.EventHandler(this.btnLegacyGenerate_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Location = new System.Drawing.Point(12, 381);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(678, 23);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Version : 1.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkUiInfo
            // 
            this.chkUiInfo.AutoSize = true;
            this.chkUiInfo.Checked = global::TranslateUtility.Properties.Settings.Default._SimpleTranslateInfo;
            this.chkUiInfo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_SimpleTranslateInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUiInfo.Location = new System.Drawing.Point(304, 72);
            this.chkUiInfo.Name = "chkUiInfo";
            this.chkUiInfo.Size = new System.Drawing.Size(37, 17);
            this.chkUiInfo.TabIndex = 41;
            this.chkUiInfo.Text = "UI";
            this.chkUiInfo.UseVisualStyleBackColor = true;
            // 
            // frmSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 406);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnTranslate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(534, 374);
            this.Name = "frmSimple";
            this.Text = "The Witcher 3 Translate Utility";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSimple_FormClosed);
            this.Load += new System.EventHandler(this.frmSimple_Load);
            this.pnTranslate.ResumeLayout(false);
            this.pnTranslate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnTranslate;
        private System.Windows.Forms.Button btnLegacyOutputOpen;
        private System.Windows.Forms.Button btnGamePath;
        private System.Windows.Forms.Button btnCheckVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.Button btnModPath;
        private System.Windows.Forms.Label lblLastCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInstallLang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLastedVersion;
        private System.Windows.Forms.Label lblLocalVersion;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLegacyExcelDownload;
        private System.Windows.Forms.TextBox txtLegacyExcel;
        private System.Windows.Forms.Button btnLegacyExcel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLegacyOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegacyOutput;
        private System.Windows.Forms.Button btnLegacyGenerate;
        private System.Windows.Forms.RadioButton rdoModTranslateFirst;
        private System.Windows.Forms.RadioButton rdoModOriginFirst;
        private System.Windows.Forms.CheckBox chkModDoubleLanguage;
        private System.Windows.Forms.Button btnModDownload;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.CheckBox chkUntranslateInfo;
        private System.Windows.Forms.CheckBox chkTranslateInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkUiInfo;
    }
}