namespace TranslateUtility
{
    partial class frmModTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModTools));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnModOutputOpen = new System.Windows.Forms.Button();
            this.rdoModTranslateFirst = new System.Windows.Forms.RadioButton();
            this.btnModExcelDonload = new System.Windows.Forms.Button();
            this.rdoModOriginFirst = new System.Windows.Forms.RadioButton();
            this.chkModDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModOutput = new System.Windows.Forms.Button();
            this.txtModOutput = new System.Windows.Forms.TextBox();
            this.btnModStart = new System.Windows.Forms.Button();
            this.btnModExcel = new System.Windows.Forms.Button();
            this.txtModExcel = new System.Windows.Forms.TextBox();
            this.btnModSource = new System.Windows.Forms.Button();
            this.txtModSource = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoExcelTranslateFirst = new System.Windows.Forms.RadioButton();
            this.rdoExcelOriginFirst = new System.Windows.Forms.RadioButton();
            this.btnExcelSourceDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkExcelDoubleLanguage = new System.Windows.Forms.CheckBox();
            this.btnExcelOutputOpen = new System.Windows.Forms.Button();
            this.btnExcelOutput = new System.Windows.Forms.Button();
            this.txtExcelOutput = new System.Windows.Forms.TextBox();
            this.btnExcelTranslat = new System.Windows.Forms.Button();
            this.btnExcelSource = new System.Windows.Forms.Button();
            this.txtExcelSource = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnModOutputOpen);
            this.groupBox4.Controls.Add(this.rdoModTranslateFirst);
            this.groupBox4.Controls.Add(this.btnModExcelDonload);
            this.groupBox4.Controls.Add(this.rdoModOriginFirst);
            this.groupBox4.Controls.Add(this.chkModDoubleLanguage);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnModOutput);
            this.groupBox4.Controls.Add(this.txtModOutput);
            this.groupBox4.Controls.Add(this.btnModStart);
            this.groupBox4.Controls.Add(this.btnModExcel);
            this.groupBox4.Controls.Add(this.txtModExcel);
            this.groupBox4.Controls.Add(this.btnModSource);
            this.groupBox4.Controls.Add(this.txtModSource);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(710, 161);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Translate Game";
            // 
            // btnModOutputOpen
            // 
            this.btnModOutputOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModOutputOpen.Location = new System.Drawing.Point(636, 68);
            this.btnModOutputOpen.Name = "btnModOutputOpen";
            this.btnModOutputOpen.Size = new System.Drawing.Size(67, 23);
            this.btnModOutputOpen.TabIndex = 14;
            this.btnModOutputOpen.Text = "Open";
            this.btnModOutputOpen.UseVisualStyleBackColor = true;
            this.btnModOutputOpen.Click += new System.EventHandler(this.btnModOutputOpen_Click);
            // 
            // rdoModTranslateFirst
            // 
            this.rdoModTranslateFirst.AutoSize = true;
            this.rdoModTranslateFirst.Checked = true;
            this.rdoModTranslateFirst.Location = new System.Drawing.Point(304, 95);
            this.rdoModTranslateFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoModTranslateFirst.Name = "rdoModTranslateFirst";
            this.rdoModTranslateFirst.Size = new System.Drawing.Size(88, 17);
            this.rdoModTranslateFirst.TabIndex = 13;
            this.rdoModTranslateFirst.TabStop = true;
            this.rdoModTranslateFirst.Text = "Translate first";
            this.rdoModTranslateFirst.UseVisualStyleBackColor = true;
            // 
            // btnModExcelDonload
            // 
            this.btnModExcelDonload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModExcelDonload.Enabled = false;
            this.btnModExcelDonload.Location = new System.Drawing.Point(636, 42);
            this.btnModExcelDonload.Name = "btnModExcelDonload";
            this.btnModExcelDonload.Size = new System.Drawing.Size(67, 23);
            this.btnModExcelDonload.TabIndex = 13;
            this.btnModExcelDonload.Text = "Download";
            this.btnModExcelDonload.UseVisualStyleBackColor = true;
            this.btnModExcelDonload.Click += new System.EventHandler(this.btnModExcelDownload_Click);
            // 
            // rdoModOriginFirst
            // 
            this.rdoModOriginFirst.AutoSize = true;
            this.rdoModOriginFirst.Checked = global::TranslateUtility.Properties.Settings.Default._ModTranslateOriginalFirst;
            this.rdoModOriginFirst.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_ModTranslateOriginalFirst", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoModOriginFirst.Location = new System.Drawing.Point(220, 95);
            this.rdoModOriginFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoModOriginFirst.Name = "rdoModOriginFirst";
            this.rdoModOriginFirst.Size = new System.Drawing.Size(79, 17);
            this.rdoModOriginFirst.TabIndex = 12;
            this.rdoModOriginFirst.Text = "Original first";
            this.rdoModOriginFirst.UseVisualStyleBackColor = true;
            // 
            // chkModDoubleLanguage
            // 
            this.chkModDoubleLanguage.AutoSize = true;
            this.chkModDoubleLanguage.Checked = global::TranslateUtility.Properties.Settings.Default._ModTranslateDouble;
            this.chkModDoubleLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_ModTranslateDouble", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkModDoubleLanguage.Location = new System.Drawing.Point(108, 95);
            this.chkModDoubleLanguage.Name = "chkModDoubleLanguage";
            this.chkModDoubleLanguage.Size = new System.Drawing.Size(111, 17);
            this.chkModDoubleLanguage.TabIndex = 14;
            this.chkModDoubleLanguage.Text = "Double Language";
            this.chkModDoubleLanguage.UseVisualStyleBackColor = true;
            this.chkModDoubleLanguage.CheckedChanged += new System.EventHandler(this.chkModDoubleLanguage_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Output Directory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Translate Excel File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Game Directory";
            // 
            // btnModOutput
            // 
            this.btnModOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModOutput.Location = new System.Drawing.Point(602, 68);
            this.btnModOutput.Name = "btnModOutput";
            this.btnModOutput.Size = new System.Drawing.Size(28, 23);
            this.btnModOutput.TabIndex = 7;
            this.btnModOutput.Text = "...";
            this.btnModOutput.UseVisualStyleBackColor = true;
            this.btnModOutput.Click += new System.EventHandler(this.btnModOutput_Click);
            // 
            // txtModOutput
            // 
            this.txtModOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_ModTranslateOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtModOutput.Location = new System.Drawing.Point(108, 71);
            this.txtModOutput.Name = "txtModOutput";
            this.txtModOutput.Size = new System.Drawing.Size(490, 20);
            this.txtModOutput.TabIndex = 6;
            this.txtModOutput.Text = global::TranslateUtility.Properties.Settings.Default._ModTranslateOutput;
            // 
            // btnModStart
            // 
            this.btnModStart.Location = new System.Drawing.Point(108, 124);
            this.btnModStart.Name = "btnModStart";
            this.btnModStart.Size = new System.Drawing.Size(67, 23);
            this.btnModStart.TabIndex = 3;
            this.btnModStart.Text = "Start";
            this.btnModStart.UseVisualStyleBackColor = true;
            this.btnModStart.Click += new System.EventHandler(this.btnModFromBackup_Click);
            // 
            // btnModExcel
            // 
            this.btnModExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModExcel.Location = new System.Drawing.Point(602, 42);
            this.btnModExcel.Name = "btnModExcel";
            this.btnModExcel.Size = new System.Drawing.Size(28, 23);
            this.btnModExcel.TabIndex = 5;
            this.btnModExcel.Text = "...";
            this.btnModExcel.UseVisualStyleBackColor = true;
            this.btnModExcel.Click += new System.EventHandler(this.btnModExcel_Click);
            // 
            // txtModExcel
            // 
            this.txtModExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModExcel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_ModTranslateExcel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtModExcel.Location = new System.Drawing.Point(108, 45);
            this.txtModExcel.Name = "txtModExcel";
            this.txtModExcel.Size = new System.Drawing.Size(490, 20);
            this.txtModExcel.TabIndex = 4;
            this.txtModExcel.Text = global::TranslateUtility.Properties.Settings.Default._ModTranslateExcel;
            // 
            // btnModSource
            // 
            this.btnModSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModSource.Location = new System.Drawing.Point(675, 17);
            this.btnModSource.Name = "btnModSource";
            this.btnModSource.Size = new System.Drawing.Size(28, 23);
            this.btnModSource.TabIndex = 2;
            this.btnModSource.Text = "...";
            this.btnModSource.UseVisualStyleBackColor = true;
            this.btnModSource.Click += new System.EventHandler(this.btnModSource_Click);
            // 
            // txtModSource
            // 
            this.txtModSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_ModTranslateSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtModSource.Location = new System.Drawing.Point(108, 19);
            this.txtModSource.Name = "txtModSource";
            this.txtModSource.Size = new System.Drawing.Size(562, 20);
            this.txtModSource.TabIndex = 1;
            this.txtModSource.Text = global::TranslateUtility.Properties.Settings.Default._ModTranslateSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoExcelTranslateFirst);
            this.groupBox1.Controls.Add(this.rdoExcelOriginFirst);
            this.groupBox1.Controls.Add(this.btnExcelSourceDownload);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkExcelDoubleLanguage);
            this.groupBox1.Controls.Add(this.btnExcelOutputOpen);
            this.groupBox1.Controls.Add(this.btnExcelOutput);
            this.groupBox1.Controls.Add(this.txtExcelOutput);
            this.groupBox1.Controls.Add(this.btnExcelTranslat);
            this.groupBox1.Controls.Add(this.btnExcelSource);
            this.groupBox1.Controls.Add(this.txtExcelSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 128);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate mod from excel file";
            // 
            // rdoExcelTranslateFirst
            // 
            this.rdoExcelTranslateFirst.AutoSize = true;
            this.rdoExcelTranslateFirst.Checked = true;
            this.rdoExcelTranslateFirst.Location = new System.Drawing.Point(304, 75);
            this.rdoExcelTranslateFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoExcelTranslateFirst.Name = "rdoExcelTranslateFirst";
            this.rdoExcelTranslateFirst.Size = new System.Drawing.Size(88, 17);
            this.rdoExcelTranslateFirst.TabIndex = 1;
            this.rdoExcelTranslateFirst.TabStop = true;
            this.rdoExcelTranslateFirst.Text = "Translate first";
            this.rdoExcelTranslateFirst.UseVisualStyleBackColor = true;
            // 
            // rdoExcelOriginFirst
            // 
            this.rdoExcelOriginFirst.AutoSize = true;
            this.rdoExcelOriginFirst.Checked = global::TranslateUtility.Properties.Settings.Default._ModExcelOriginalFirst;
            this.rdoExcelOriginFirst.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_ModExcelOriginalFirst", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdoExcelOriginFirst.Location = new System.Drawing.Point(220, 75);
            this.rdoExcelOriginFirst.Margin = new System.Windows.Forms.Padding(2);
            this.rdoExcelOriginFirst.Name = "rdoExcelOriginFirst";
            this.rdoExcelOriginFirst.Size = new System.Drawing.Size(79, 17);
            this.rdoExcelOriginFirst.TabIndex = 0;
            this.rdoExcelOriginFirst.Text = "Original first";
            this.rdoExcelOriginFirst.UseVisualStyleBackColor = true;
            // 
            // btnExcelSourceDownload
            // 
            this.btnExcelSourceDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelSourceDownload.Enabled = false;
            this.btnExcelSourceDownload.Location = new System.Drawing.Point(636, 16);
            this.btnExcelSourceDownload.Name = "btnExcelSourceDownload";
            this.btnExcelSourceDownload.Size = new System.Drawing.Size(67, 23);
            this.btnExcelSourceDownload.TabIndex = 13;
            this.btnExcelSourceDownload.Text = "Download";
            this.btnExcelSourceDownload.UseVisualStyleBackColor = true;
            this.btnExcelSourceDownload.Click += new System.EventHandler(this.btnExcelSourceDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Excel File";
            // 
            // chkExcelDoubleLanguage
            // 
            this.chkExcelDoubleLanguage.AutoSize = true;
            this.chkExcelDoubleLanguage.Checked = global::TranslateUtility.Properties.Settings.Default._ModExcelDouble;
            this.chkExcelDoubleLanguage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::TranslateUtility.Properties.Settings.Default, "_ModExcelDouble", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkExcelDoubleLanguage.Location = new System.Drawing.Point(108, 75);
            this.chkExcelDoubleLanguage.Name = "chkExcelDoubleLanguage";
            this.chkExcelDoubleLanguage.Size = new System.Drawing.Size(111, 17);
            this.chkExcelDoubleLanguage.TabIndex = 7;
            this.chkExcelDoubleLanguage.Text = "Double Language";
            this.chkExcelDoubleLanguage.UseVisualStyleBackColor = true;
            this.chkExcelDoubleLanguage.CheckedChanged += new System.EventHandler(this.chkExcelDoubleLanguage_CheckedChanged);
            // 
            // btnExcelOutputOpen
            // 
            this.btnExcelOutputOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelOutputOpen.Location = new System.Drawing.Point(636, 42);
            this.btnExcelOutputOpen.Name = "btnExcelOutputOpen";
            this.btnExcelOutputOpen.Size = new System.Drawing.Size(67, 23);
            this.btnExcelOutputOpen.TabIndex = 11;
            this.btnExcelOutputOpen.Text = "Open";
            this.btnExcelOutputOpen.UseVisualStyleBackColor = true;
            this.btnExcelOutputOpen.Click += new System.EventHandler(this.btnExcelOutputOpen_Click);
            // 
            // btnExcelOutput
            // 
            this.btnExcelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelOutput.Location = new System.Drawing.Point(602, 42);
            this.btnExcelOutput.Name = "btnExcelOutput";
            this.btnExcelOutput.Size = new System.Drawing.Size(28, 23);
            this.btnExcelOutput.TabIndex = 7;
            this.btnExcelOutput.Text = "...";
            this.btnExcelOutput.UseVisualStyleBackColor = true;
            this.btnExcelOutput.Click += new System.EventHandler(this.btnExcelOutput_Click);
            // 
            // txtExcelOutput
            // 
            this.txtExcelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcelOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_ModExcelOutput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExcelOutput.Location = new System.Drawing.Point(108, 45);
            this.txtExcelOutput.Name = "txtExcelOutput";
            this.txtExcelOutput.Size = new System.Drawing.Size(490, 20);
            this.txtExcelOutput.TabIndex = 6;
            this.txtExcelOutput.Text = global::TranslateUtility.Properties.Settings.Default._ModExcelOutput;
            // 
            // btnExcelTranslat
            // 
            this.btnExcelTranslat.Location = new System.Drawing.Point(108, 98);
            this.btnExcelTranslat.Name = "btnExcelTranslat";
            this.btnExcelTranslat.Size = new System.Drawing.Size(67, 23);
            this.btnExcelTranslat.TabIndex = 3;
            this.btnExcelTranslat.Text = "Start";
            this.btnExcelTranslat.UseVisualStyleBackColor = true;
            this.btnExcelTranslat.Click += new System.EventHandler(this.btnExcelTranslat_Click);
            // 
            // btnExcelSource
            // 
            this.btnExcelSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelSource.Location = new System.Drawing.Point(602, 16);
            this.btnExcelSource.Name = "btnExcelSource";
            this.btnExcelSource.Size = new System.Drawing.Size(28, 23);
            this.btnExcelSource.TabIndex = 5;
            this.btnExcelSource.Text = "...";
            this.btnExcelSource.UseVisualStyleBackColor = true;
            this.btnExcelSource.Click += new System.EventHandler(this.btnExcelSource_Click);
            // 
            // txtExcelSource
            // 
            this.txtExcelSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcelSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranslateUtility.Properties.Settings.Default, "_ModExcelSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExcelSource.Location = new System.Drawing.Point(108, 19);
            this.txtExcelSource.Name = "txtExcelSource";
            this.txtExcelSource.Size = new System.Drawing.Size(490, 20);
            this.txtExcelSource.TabIndex = 4;
            this.txtExcelSource.Text = global::TranslateUtility.Properties.Settings.Default._ModExcelSource;
            // 
            // frmModTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(734, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(555, 111);
            this.Name = "frmModTools";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mod Utility";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModTools_FormClosed);
            this.Load += new System.EventHandler(this.frmModTools_Load);
            this.Shown += new System.EventHandler(this.frmModTools_Shown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModOutput;
        private System.Windows.Forms.TextBox txtModOutput;
        private System.Windows.Forms.Button btnModStart;
        private System.Windows.Forms.Button btnModExcel;
        private System.Windows.Forms.TextBox txtModExcel;
        private System.Windows.Forms.Button btnModSource;
        private System.Windows.Forms.TextBox txtModSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkExcelDoubleLanguage;
        private System.Windows.Forms.Button btnExcelOutputOpen;
        private System.Windows.Forms.Button btnExcelOutput;
        private System.Windows.Forms.TextBox txtExcelOutput;
        private System.Windows.Forms.Button btnExcelTranslat;
        private System.Windows.Forms.Button btnExcelSource;
        private System.Windows.Forms.TextBox txtExcelSource;
        private System.Windows.Forms.Button btnModOutputOpen;
        private System.Windows.Forms.RadioButton rdoModTranslateFirst;
        private System.Windows.Forms.Button btnModExcelDonload;
        private System.Windows.Forms.RadioButton rdoModOriginFirst;
        private System.Windows.Forms.CheckBox chkModDoubleLanguage;
        private System.Windows.Forms.RadioButton rdoExcelTranslateFirst;
        private System.Windows.Forms.RadioButton rdoExcelOriginFirst;
        private System.Windows.Forms.Button btnExcelSourceDownload;
    }
}