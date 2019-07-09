namespace TranslateUtility
{
    partial class frmStorybook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadStart = new System.Windows.Forms.Button();
            this.btnReadOutput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReadPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWriteStart = new System.Windows.Forms.Button();
            this.btnWriteOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWriteInput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWriteOutput = new System.Windows.Forms.TextBox();
            this.txtWriteInput = new System.Windows.Forms.TextBox();
            this.txtReadOutput = new System.Windows.Forms.TextBox();
            this.txtReadPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadStart);
            this.groupBox1.Controls.Add(this.btnReadOutput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtReadOutput);
            this.groupBox1.Controls.Add(this.btnReadPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtReadPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Storybook to Excel";
            // 
            // btnReadStart
            // 
            this.btnReadStart.Location = new System.Drawing.Point(524, 17);
            this.btnReadStart.Name = "btnReadStart";
            this.btnReadStart.Size = new System.Drawing.Size(75, 49);
            this.btnReadStart.TabIndex = 6;
            this.btnReadStart.Text = "Start";
            this.btnReadStart.UseVisualStyleBackColor = true;
            this.btnReadStart.Click += new System.EventHandler(this.btnReadStart_Click);
            // 
            // btnReadOutput
            // 
            this.btnReadOutput.Location = new System.Drawing.Point(491, 43);
            this.btnReadOutput.Name = "btnReadOutput";
            this.btnReadOutput.Size = new System.Drawing.Size(26, 23);
            this.btnReadOutput.TabIndex = 5;
            this.btnReadOutput.Text = "...";
            this.btnReadOutput.UseVisualStyleBackColor = true;
            this.btnReadOutput.Click += new System.EventHandler(this.btnReadOutput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Path";
            // 
            // btnReadPath
            // 
            this.btnReadPath.Location = new System.Drawing.Point(491, 17);
            this.btnReadPath.Name = "btnReadPath";
            this.btnReadPath.Size = new System.Drawing.Size(26, 23);
            this.btnReadPath.TabIndex = 2;
            this.btnReadPath.Text = "...";
            this.btnReadPath.UseVisualStyleBackColor = true;
            this.btnReadPath.Click += new System.EventHandler(this.btnReadPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mod Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWriteStart);
            this.groupBox2.Controls.Add(this.btnWriteOutput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtWriteOutput);
            this.groupBox2.Controls.Add(this.btnWriteInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtWriteInput);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Storybook from Excel";
            // 
            // btnWriteStart
            // 
            this.btnWriteStart.Location = new System.Drawing.Point(524, 17);
            this.btnWriteStart.Name = "btnWriteStart";
            this.btnWriteStart.Size = new System.Drawing.Size(75, 49);
            this.btnWriteStart.TabIndex = 6;
            this.btnWriteStart.Text = "Start";
            this.btnWriteStart.UseVisualStyleBackColor = true;
            this.btnWriteStart.Click += new System.EventHandler(this.btnWriteStart_Click);
            // 
            // btnWriteOutput
            // 
            this.btnWriteOutput.Location = new System.Drawing.Point(491, 43);
            this.btnWriteOutput.Name = "btnWriteOutput";
            this.btnWriteOutput.Size = new System.Drawing.Size(26, 23);
            this.btnWriteOutput.TabIndex = 5;
            this.btnWriteOutput.Text = "...";
            this.btnWriteOutput.UseVisualStyleBackColor = true;
            this.btnWriteOutput.Click += new System.EventHandler(this.btnWriteOutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output Path";
            // 
            // btnWriteInput
            // 
            this.btnWriteInput.Location = new System.Drawing.Point(491, 17);
            this.btnWriteInput.Name = "btnWriteInput";
            this.btnWriteInput.Size = new System.Drawing.Size(26, 23);
            this.btnWriteInput.TabIndex = 2;
            this.btnWriteInput.Text = "...";
            this.btnWriteInput.UseVisualStyleBackColor = true;
            this.btnWriteInput.Click += new System.EventHandler(this.btnWriteInput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Excel Path";
            // 
            // txtWriteOutput
            // 
            this.txtWriteOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookWriteOutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWriteOutput.Location = new System.Drawing.Point(101, 45);
            this.txtWriteOutput.Name = "txtWriteOutput";
            this.txtWriteOutput.Size = new System.Drawing.Size(384, 20);
            this.txtWriteOutput.TabIndex = 3;
            this.txtWriteOutput.Text = global::AdvanceTools.Properties.Settings.Default.StorybookWriteOutputPath;
            this.txtWriteOutput.DoubleClick += new System.EventHandler(this.txtWriteOutput_DoubleClick);
            // 
            // txtWriteInput
            // 
            this.txtWriteInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookWriteInputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWriteInput.Location = new System.Drawing.Point(101, 19);
            this.txtWriteInput.Name = "txtWriteInput";
            this.txtWriteInput.Size = new System.Drawing.Size(384, 20);
            this.txtWriteInput.TabIndex = 0;
            this.txtWriteInput.Text = global::AdvanceTools.Properties.Settings.Default.StorybookWriteInputPath;
            // 
            // txtReadOutput
            // 
            this.txtReadOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookReadOutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtReadOutput.Location = new System.Drawing.Point(101, 45);
            this.txtReadOutput.Name = "txtReadOutput";
            this.txtReadOutput.Size = new System.Drawing.Size(384, 20);
            this.txtReadOutput.TabIndex = 3;
            this.txtReadOutput.Text = global::AdvanceTools.Properties.Settings.Default.StorybookReadOutputPath;
            this.txtReadOutput.DoubleClick += new System.EventHandler(this.txtReadOutput_DoubleClick);
            // 
            // txtReadPath
            // 
            this.txtReadPath.Location = new System.Drawing.Point(101, 19);
            this.txtReadPath.Name = "txtReadPath";
            this.txtReadPath.Size = new System.Drawing.Size(384, 20);
            this.txtReadPath.TabIndex = 0;
            this.txtReadPath.Text = global::AdvanceTools.Properties.Settings.Default.StorybookReadInputPath;
            // 
            // frmStorybook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStorybook";
            this.Text = "frmStorybook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStorybook_FormClosing);
            this.Load += new System.EventHandler(this.frmStorybook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReadStart;
        private System.Windows.Forms.Button btnReadOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReadOutput;
        private System.Windows.Forms.Button btnReadPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReadPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWriteStart;
        private System.Windows.Forms.Button btnWriteOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriteOutput;
        private System.Windows.Forms.Button btnWriteInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWriteInput;
    }
}