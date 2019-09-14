namespace AdvanceTools.Screens
{
    partial class Test
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLegacyGenerate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnLegacyGenerate, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 199);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(669, 53);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // btnLegacyGenerate
            // 
            this.btnLegacyGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLegacyGenerate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLegacyGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegacyGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLegacyGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLegacyGenerate.Location = new System.Drawing.Point(257, 4);
            this.btnLegacyGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnLegacyGenerate.MaximumSize = new System.Drawing.Size(154, 45);
            this.btnLegacyGenerate.MinimumSize = new System.Drawing.Size(154, 45);
            this.btnLegacyGenerate.Name = "btnLegacyGenerate";
            this.btnLegacyGenerate.Size = new System.Drawing.Size(154, 45);
            this.btnLegacyGenerate.TabIndex = 33;
            this.btnLegacyGenerate.Text = "ติดตั้ง";
            this.btnLegacyGenerate.UseVisualStyleBackColor = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Test";
            this.Text = "Test";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnLegacyGenerate;
    }
}