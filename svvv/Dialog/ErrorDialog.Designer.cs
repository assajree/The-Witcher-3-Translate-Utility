namespace svvv.Dialog
{
    partial class ErrorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorDialog));
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.pnContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnDetail = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDetail = new System.Windows.Forms.LinkLabel();
            this.lblLog = new System.Windows.Forms.LinkLabel();
            this.pnContainer.SuspendLayout();
            this.pnDetail.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(13, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblMessage.Size = new System.Drawing.Size(189, 28);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Lorem ipsum dolor sit amet";
            // 
            // txtDetail
            // 
            this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(0, 3);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetail.Size = new System.Drawing.Size(553, 441);
            this.txtDetail.TabIndex = 2;
            this.txtDetail.Text = resources.GetString("txtDetail.Text");
            // 
            // pnContainer
            // 
            this.pnContainer.AutoSize = true;
            this.pnContainer.ColumnCount = 1;
            this.pnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnContainer.Controls.Add(this.pnDetail, 0, 2);
            this.pnContainer.Controls.Add(this.lblMessage, 0, 0);
            this.pnContainer.Controls.Add(this.pnButton, 0, 1);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pnContainer.RowCount = 3;
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnContainer.Size = new System.Drawing.Size(582, 566);
            this.pnContainer.TabIndex = 6;
            // 
            // pnDetail
            // 
            this.pnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDetail.Controls.Add(this.btnCopy);
            this.pnDetail.Controls.Add(this.txtDetail);
            this.pnDetail.Location = new System.Drawing.Point(13, 86);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(556, 477);
            this.pnDetail.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Location = new System.Drawing.Point(0, 447);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(78, 27);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "คัดลอก";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // pnButton
            // 
            this.pnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButton.AutoSize = true;
            this.pnButton.Controls.Add(this.lblLog);
            this.pnButton.Controls.Add(this.lblDetail);
            this.pnButton.Controls.Add(this.btnClose);
            this.pnButton.Location = new System.Drawing.Point(13, 41);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(556, 39);
            this.pnButton.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(436, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "ปิด";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(0, 18);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(71, 18);
            this.lblDetail.TabIndex = 7;
            this.lblDetail.TabStop = true;
            this.lblDetail.Text = "รายละเอียด";
            this.lblDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDetail_LinkClicked_1);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(81, 18);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(39, 18);
            this.lblLog.TabIndex = 8;
            this.lblLog.TabStop = true;
            this.lblLog.Text = "ดูล็อก";
            this.lblLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLog_LinkClicked);
            // 
            // ErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 566);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(600, 1000);
            this.MinimizeBox = false;
            this.Name = "ErrorDialog";
            this.ShowIcon = false;
            this.Text = "Error";
            this.Load += new System.EventHandler(this.ErrorDialog_Load);
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.TableLayoutPanel pnContainer;
        private System.Windows.Forms.Panel pnDetail;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lblLog;
        private System.Windows.Forms.LinkLabel lblDetail;
    }
}