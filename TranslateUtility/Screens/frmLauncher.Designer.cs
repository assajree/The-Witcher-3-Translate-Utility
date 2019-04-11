﻿namespace TranslateUtility
{
    partial class frmLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
            this.btnGameTools = new System.Windows.Forms.Button();
            this.btnExcelTools = new System.Windows.Forms.Button();
            this.btnModTools = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGameTools
            // 
            this.btnGameTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameTools.Location = new System.Drawing.Point(58, 32);
            this.btnGameTools.Margin = new System.Windows.Forms.Padding(2);
            this.btnGameTools.Name = "btnGameTools";
            this.btnGameTools.Size = new System.Drawing.Size(126, 29);
            this.btnGameTools.TabIndex = 0;
            this.btnGameTools.Text = "Game Tools";
            this.btnGameTools.UseVisualStyleBackColor = true;
            this.btnGameTools.Click += new System.EventHandler(this.btnGameTools_Click);
            // 
            // btnExcelTools
            // 
            this.btnExcelTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelTools.Location = new System.Drawing.Point(58, 100);
            this.btnExcelTools.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelTools.Name = "btnExcelTools";
            this.btnExcelTools.Size = new System.Drawing.Size(126, 29);
            this.btnExcelTools.TabIndex = 1;
            this.btnExcelTools.Text = "Excel Tools";
            this.btnExcelTools.UseVisualStyleBackColor = true;
            this.btnExcelTools.Click += new System.EventHandler(this.btnExcelTools_Click);
            // 
            // btnModTools
            // 
            this.btnModTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModTools.Location = new System.Drawing.Point(58, 66);
            this.btnModTools.Margin = new System.Windows.Forms.Padding(2);
            this.btnModTools.Name = "btnModTools";
            this.btnModTools.Size = new System.Drawing.Size(126, 29);
            this.btnModTools.TabIndex = 2;
            this.btnModTools.Text = "Mod Tools";
            this.btnModTools.UseVisualStyleBackColor = true;
            this.btnModTools.Click += new System.EventHandler(this.btnModTools_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(58, 186);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonate.Location = new System.Drawing.Point(0, 215);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(243, 24);
            this.btnDonate.TabIndex = 4;
            this.btnDonate.TabStop = true;
            this.btnDonate.Text = "Donate";
            this.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDonate_LinkClicked);
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(243, 240);
            this.ControlBox = false;
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModTools);
            this.Controls.Add(this.btnExcelTools);
            this.Controls.Add(this.btnGameTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Witcher 3 Thai Translate Utility";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGameTools;
        private System.Windows.Forms.Button btnExcelTools;
        private System.Windows.Forms.Button btnModTools;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel btnDonate;
    }
}