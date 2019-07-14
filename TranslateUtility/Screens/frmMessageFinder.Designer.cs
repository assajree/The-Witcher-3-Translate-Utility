namespace TranslateUtility.Screens
{
    partial class frmMessageFinder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoOriginal = new System.Windows.Forms.RadioButton();
            this.rdoTranslate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvSearchResult = new System.Windows.Forms.DataGridView();
            this.ButtonCopy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SheetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranslateMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRowNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSheetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTranslateText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginalText = new System.Windows.Forms.TextBox();
            this.lblDetail = new System.Windows.Forms.LinkLabel();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).BeginInit();
            this.pnDetail.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtInput.Location = new System.Drawing.Point(8, 60);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(619, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdoAll.Location = new System.Drawing.Point(8, 27);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(80, 24);
            this.rdoAll.TabIndex = 2;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "ทั้งหมด";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoOriginal
            // 
            this.rdoOriginal.AutoSize = true;
            this.rdoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdoOriginal.Location = new System.Drawing.Point(107, 27);
            this.rdoOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOriginal.Name = "rdoOriginal";
            this.rdoOriginal.Size = new System.Drawing.Size(81, 24);
            this.rdoOriginal.TabIndex = 3;
            this.rdoOriginal.Text = "ต้นฉบับ";
            this.rdoOriginal.UseVisualStyleBackColor = true;
            // 
            // rdoTranslate
            // 
            this.rdoTranslate.AutoSize = true;
            this.rdoTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rdoTranslate.Location = new System.Drawing.Point(205, 27);
            this.rdoTranslate.Margin = new System.Windows.Forms.Padding(4);
            this.rdoTranslate.Name = "rdoTranslate";
            this.rdoTranslate.Size = new System.Drawing.Size(78, 24);
            this.rdoTranslate.TabIndex = 4;
            this.rdoTranslate.Text = "คำแปล";
            this.rdoTranslate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Controls.Add(this.rdoTranslate);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Controls.Add(this.rdoOriginal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(744, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหา";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(636, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvSearchResult
            // 
            this.gvSearchResult.AllowUserToAddRows = false;
            this.gvSearchResult.AllowUserToDeleteRows = false;
            this.gvSearchResult.AllowUserToResizeRows = false;
            this.gvSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSearchResult.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.gvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButtonCopy,
            this.SheetName,
            this.RowNumber,
            this.ID,
            this.KeyHex,
            this.KeyString,
            this.OriginalMessage,
            this.TranslateMessage});
            this.gvSearchResult.Location = new System.Drawing.Point(4, 4);
            this.gvSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.gvSearchResult.Name = "gvSearchResult";
            this.gvSearchResult.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gvSearchResult.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSearchResult.Size = new System.Drawing.Size(736, 226);
            this.gvSearchResult.TabIndex = 8;
            this.gvSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearchResult_CellDoubleClick);
            this.gvSearchResult.SelectionChanged += new System.EventHandler(this.gvSearchResult_SelectionChanged);
            this.gvSearchResult.Click += new System.EventHandler(this.gvSearchResult_Click);
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ButtonCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCopy.HeaderText = "";
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.ReadOnly = true;
            this.ButtonCopy.Text = "คัดลอก";
            this.ButtonCopy.UseColumnTextForButtonValue = true;
            this.ButtonCopy.Visible = false;
            this.ButtonCopy.Width = 50;
            // 
            // SheetName
            // 
            this.SheetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SheetName.DataPropertyName = "SheetName";
            this.SheetName.HeaderText = "ชีท";
            this.SheetName.Name = "SheetName";
            this.SheetName.ReadOnly = true;
            this.SheetName.Width = 53;
            // 
            // RowNumber
            // 
            this.RowNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RowNumber.DataPropertyName = "RowNumber";
            this.RowNumber.HeaderText = "บรรทัด";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Width = 75;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // KeyHex
            // 
            this.KeyHex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KeyHex.DataPropertyName = "KeyHex";
            this.KeyHex.HeaderText = "Key 1";
            this.KeyHex.Name = "KeyHex";
            this.KeyHex.ReadOnly = true;
            this.KeyHex.Visible = false;
            // 
            // KeyString
            // 
            this.KeyString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KeyString.DataPropertyName = "KeyString";
            this.KeyString.HeaderText = "Key 2";
            this.KeyString.Name = "KeyString";
            this.KeyString.ReadOnly = true;
            this.KeyString.Visible = false;
            // 
            // OriginalMessage
            // 
            this.OriginalMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalMessage.DataPropertyName = "Text";
            this.OriginalMessage.HeaderText = "ข้อความต้นฉบับ";
            this.OriginalMessage.Name = "OriginalMessage";
            this.OriginalMessage.ReadOnly = true;
            // 
            // TranslateMessage
            // 
            this.TranslateMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TranslateMessage.DataPropertyName = "Translate";
            this.TranslateMessage.HeaderText = "คำแปล";
            this.TranslateMessage.Name = "TranslateMessage";
            this.TranslateMessage.ReadOnly = true;
            // 
            // pnDetail
            // 
            this.pnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetail.Controls.Add(this.label4);
            this.pnDetail.Controls.Add(this.txtRowNumber);
            this.pnDetail.Controls.Add(this.label3);
            this.pnDetail.Controls.Add(this.txtSheetName);
            this.pnDetail.Controls.Add(this.label2);
            this.pnDetail.Controls.Add(this.txtTranslateText);
            this.pnDetail.Controls.Add(this.label1);
            this.pnDetail.Controls.Add(this.txtOriginalText);
            this.pnDetail.Location = new System.Drawing.Point(4, 284);
            this.pnDetail.Margin = new System.Windows.Forms.Padding(4);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(736, 108);
            this.pnDetail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(537, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "บรรทัด";
            // 
            // txtRowNumber
            // 
            this.txtRowNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtRowNumber.Location = new System.Drawing.Point(607, 4);
            this.txtRowNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRowNumber.Name = "txtRowNumber";
            this.txtRowNumber.ReadOnly = true;
            this.txtRowNumber.Size = new System.Drawing.Size(124, 26);
            this.txtRowNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(101, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ชีท";
            // 
            // txtSheetName
            // 
            this.txtSheetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSheetName.Location = new System.Drawing.Point(141, 4);
            this.txtSheetName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSheetName.Name = "txtSheetName";
            this.txtSheetName.ReadOnly = true;
            this.txtSheetName.Size = new System.Drawing.Size(387, 26);
            this.txtSheetName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(73, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "คำแปล";
            // 
            // txtTranslateText
            // 
            this.txtTranslateText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTranslateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTranslateText.Location = new System.Drawing.Point(141, 75);
            this.txtTranslateText.Margin = new System.Windows.Forms.Padding(4);
            this.txtTranslateText.Name = "txtTranslateText";
            this.txtTranslateText.ReadOnly = true;
            this.txtTranslateText.Size = new System.Drawing.Size(589, 26);
            this.txtTranslateText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ข้อความต้นฉบับ";
            // 
            // txtOriginalText
            // 
            this.txtOriginalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOriginalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtOriginalText.Location = new System.Drawing.Point(141, 39);
            this.txtOriginalText.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginalText.Name = "txtOriginalText";
            this.txtOriginalText.ReadOnly = true;
            this.txtOriginalText.Size = new System.Drawing.Size(589, 26);
            this.txtOriginalText.TabIndex = 1;
            // 
            // lblDetail
            // 
            this.lblDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(647, 9);
            this.lblDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(85, 20);
            this.lblDetail.TabIndex = 52;
            this.lblDetail.TabStop = true;
            this.lblDetail.Text = "รายละเอียด";
            this.lblDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDetail_LinkClicked);
            // 
            // pnButton
            // 
            this.pnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButton.Controls.Add(this.btnCopy);
            this.pnButton.Controls.Add(this.lblDetail);
            this.pnButton.Location = new System.Drawing.Point(4, 238);
            this.pnButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(736, 38);
            this.pnButton.TabIndex = 53;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCopy.Location = new System.Drawing.Point(4, 3);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(97, 32);
            this.btnCopy.TabIndex = 53;
            this.btnCopy.Text = "คัดลอก";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnDetail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gvSearchResult, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 122);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 396);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // frmMessageFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(794, 481);
            this.Name = "frmMessageFinder";
            this.ShowIcon = false;
            this.Text = "Message Finder";
            this.Activated += new System.EventHandler(this.frmMessageFinder_Activated);
            this.Load += new System.EventHandler(this.frmMessageFinder_Load);
            this.Shown += new System.EventHandler(this.frmMessageFinder_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResult)).EndInit();
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnButton.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoOriginal;
        private System.Windows.Forms.RadioButton rdoTranslate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvSearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyHex;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyString;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranslateMessage;
        private System.Windows.Forms.Panel pnDetail;
        private System.Windows.Forms.LinkLabel lblDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTranslateText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginalText;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRowNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSheetName;
        private System.Windows.Forms.Button btnCopy;
    }
}