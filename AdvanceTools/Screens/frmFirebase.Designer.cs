namespace AdvanceTools.Screens
{
    partial class frmFirebase
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
            this.pnFont = new System.Windows.Forms.GroupBox();
            this.btnExtraJson = new System.Windows.Forms.Button();
            this.btnGenerateExtraLanguage = new System.Windows.Forms.Button();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.btnExcelToJson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMakeData = new System.Windows.Forms.Button();
            this.btnDownloadJson = new System.Windows.Forms.Button();
            this.btnSelectJson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJsonPath = new System.Windows.Forms.TextBox();
            this.pnFont.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFont
            // 
            this.pnFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFont.Controls.Add(this.btnExtraJson);
            this.pnFont.Controls.Add(this.btnGenerateExtraLanguage);
            this.pnFont.Controls.Add(this.btnSelectExcel);
            this.pnFont.Controls.Add(this.label5);
            this.pnFont.Controls.Add(this.txtExcelPath);
            this.pnFont.Controls.Add(this.btnExcelToJson);
            this.pnFont.Location = new System.Drawing.Point(12, 12);
            this.pnFont.Name = "pnFont";
            this.pnFont.Size = new System.Drawing.Size(588, 76);
            this.pnFont.TabIndex = 11;
            this.pnFont.TabStop = false;
            this.pnFont.Text = "Excel Tool";
            // 
            // btnExtraJson
            // 
            this.btnExtraJson.Location = new System.Drawing.Point(316, 43);
            this.btnExtraJson.Name = "btnExtraJson";
            this.btnExtraJson.Size = new System.Drawing.Size(117, 23);
            this.btnExtraJson.TabIndex = 7;
            this.btnExtraJson.Text = "to extra json";
            this.btnExtraJson.UseVisualStyleBackColor = true;
            this.btnExtraJson.Click += new System.EventHandler(this.btnExtraJson_Click);
            // 
            // btnGenerateExtraLanguage
            // 
            this.btnGenerateExtraLanguage.Location = new System.Drawing.Point(193, 43);
            this.btnGenerateExtraLanguage.Name = "btnGenerateExtraLanguage";
            this.btnGenerateExtraLanguage.Size = new System.Drawing.Size(117, 23);
            this.btnGenerateExtraLanguage.TabIndex = 6;
            this.btnGenerateExtraLanguage.Text = "to extra language";
            this.btnGenerateExtraLanguage.UseVisualStyleBackColor = true;
            this.btnGenerateExtraLanguage.Click += new System.EventHandler(this.btnGenerateExtraLanguage_Click);
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectExcel.Location = new System.Drawing.Point(553, 16);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(26, 23);
            this.btnSelectExcel.TabIndex = 5;
            this.btnSelectExcel.Text = "...";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Excel File";
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcelPath.Location = new System.Drawing.Point(112, 19);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.ReadOnly = true;
            this.txtExcelPath.Size = new System.Drawing.Size(436, 20);
            this.txtExcelPath.TabIndex = 3;
            this.txtExcelPath.DoubleClick += new System.EventHandler(this.txtExcelPath_DoubleClick);
            // 
            // btnExcelToJson
            // 
            this.btnExcelToJson.Location = new System.Drawing.Point(112, 43);
            this.btnExcelToJson.Name = "btnExcelToJson";
            this.btnExcelToJson.Size = new System.Drawing.Size(75, 23);
            this.btnExcelToJson.TabIndex = 0;
            this.btnExcelToJson.Text = "to json";
            this.btnExcelToJson.UseVisualStyleBackColor = true;
            this.btnExcelToJson.Click += new System.EventHandler(this.btnExcelToJson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSelectJson);
            this.groupBox1.Controls.Add(this.btnMakeData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtJsonPath);
            this.groupBox1.Controls.Add(this.btnDownloadJson);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Json Tool";
            // 
            // btnMakeData
            // 
            this.btnMakeData.Location = new System.Drawing.Point(112, 45);
            this.btnMakeData.Name = "btnMakeData";
            this.btnMakeData.Size = new System.Drawing.Size(109, 23);
            this.btnMakeData.TabIndex = 0;
            this.btnMakeData.Text = "make data";
            this.btnMakeData.UseVisualStyleBackColor = true;
            this.btnMakeData.Click += new System.EventHandler(this.btnMakeData_Click);
            // 
            // btnDownloadJson
            // 
            this.btnDownloadJson.Location = new System.Drawing.Point(6, 45);
            this.btnDownloadJson.Name = "btnDownloadJson";
            this.btnDownloadJson.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadJson.TabIndex = 13;
            this.btnDownloadJson.Text = "download json";
            this.btnDownloadJson.UseVisualStyleBackColor = true;
            this.btnDownloadJson.Click += new System.EventHandler(this.btnDownloadJson_Click);
            // 
            // btnSelectJson
            // 
            this.btnSelectJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectJson.Location = new System.Drawing.Point(553, 16);
            this.btnSelectJson.Name = "btnSelectJson";
            this.btnSelectJson.Size = new System.Drawing.Size(26, 23);
            this.btnSelectJson.TabIndex = 17;
            this.btnSelectJson.Text = "...";
            this.btnSelectJson.UseVisualStyleBackColor = true;
            this.btnSelectJson.Click += new System.EventHandler(this.btnSelectJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Json File";
            // 
            // txtJsonPath
            // 
            this.txtJsonPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJsonPath.Location = new System.Drawing.Point(112, 19);
            this.txtJsonPath.Name = "txtJsonPath";
            this.txtJsonPath.ReadOnly = true;
            this.txtJsonPath.Size = new System.Drawing.Size(436, 20);
            this.txtJsonPath.TabIndex = 15;
            // 
            // frmFirebase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnFont);
            this.Name = "frmFirebase";
            this.Text = "frmFirebase";
            this.Load += new System.EventHandler(this.frmFirebase_Load);
            this.pnFont.ResumeLayout(false);
            this.pnFont.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnFont;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Button btnExcelToJson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMakeData;
        private System.Windows.Forms.Button btnGenerateExtraLanguage;
        private System.Windows.Forms.Button btnExtraJson;
        private System.Windows.Forms.Button btnDownloadJson;
        private System.Windows.Forms.Button btnSelectJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJsonPath;
    }
}