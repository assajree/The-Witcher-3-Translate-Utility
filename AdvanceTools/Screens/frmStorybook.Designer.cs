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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWriteStart = new System.Windows.Forms.Button();
            this.btnWriteOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriteOutput = new System.Windows.Forms.TextBox();
            this.btnWriteInput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWriteInput = new System.Windows.Forms.TextBox();
            this.pnFill = new System.Windows.Forms.GroupBox();
            this.chkFillMessageAsTranslate = new System.Windows.Forms.CheckBox();
            this.chkFillReplaceTranslated = new System.Windows.Forms.CheckBox();
            this.chkFillMessage = new System.Windows.Forms.CheckBox();
            this.btnFillStart = new System.Windows.Forms.Button();
            this.btnFillTranslate = new System.Windows.Forms.Button();
            this.txtFillTarget = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFillTarget = new System.Windows.Forms.Button();
            this.txtFillTranslate = new System.Windows.Forms.TextBox();
            this.txtReadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadPath = new System.Windows.Forms.Button();
            this.txtReadOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReadOutput = new System.Windows.Forms.Button();
            this.btnReadStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartReadComment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReadCommentOutput = new System.Windows.Forms.TextBox();
            this.btnReadCommentInput = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReadCommentInput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkClearAllSheet = new System.Windows.Forms.CheckBox();
            this.btnClearTranslateStart = new System.Windows.Forms.Button();
            this.btnClearTranslateInput = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClearTranslatePath = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.pnFill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
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
            this.label3.Location = new System.Drawing.Point(66, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output Path";
            // 
            // txtWriteOutput
            // 
            this.txtWriteOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookWriteOutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWriteOutput.Location = new System.Drawing.Point(136, 45);
            this.txtWriteOutput.Name = "txtWriteOutput";
            this.txtWriteOutput.Size = new System.Drawing.Size(349, 20);
            this.txtWriteOutput.TabIndex = 3;
            this.txtWriteOutput.Text = global::AdvanceTools.Properties.Settings.Default.StorybookWriteOutputPath;
            this.txtWriteOutput.DoubleClick += new System.EventHandler(this.txtWriteOutput_DoubleClick);
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
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Storybook Excel Path";
            // 
            // txtWriteInput
            // 
            this.txtWriteInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookWriteInputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtWriteInput.Location = new System.Drawing.Point(136, 19);
            this.txtWriteInput.Name = "txtWriteInput";
            this.txtWriteInput.Size = new System.Drawing.Size(349, 20);
            this.txtWriteInput.TabIndex = 0;
            this.txtWriteInput.Text = global::AdvanceTools.Properties.Settings.Default.StorybookWriteInputPath;
            // 
            // pnFill
            // 
            this.pnFill.Controls.Add(this.chkFillMessageAsTranslate);
            this.pnFill.Controls.Add(this.chkFillReplaceTranslated);
            this.pnFill.Controls.Add(this.chkFillMessage);
            this.pnFill.Controls.Add(this.btnFillStart);
            this.pnFill.Controls.Add(this.btnFillTranslate);
            this.pnFill.Controls.Add(this.txtFillTarget);
            this.pnFill.Controls.Add(this.label6);
            this.pnFill.Controls.Add(this.label5);
            this.pnFill.Controls.Add(this.btnFillTarget);
            this.pnFill.Controls.Add(this.txtFillTranslate);
            this.pnFill.Location = new System.Drawing.Point(12, 211);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(611, 94);
            this.pnFill.TabIndex = 2;
            this.pnFill.TabStop = false;
            this.pnFill.Text = "Fill Storybook Excel from Translate";
            // 
            // chkFillMessageAsTranslate
            // 
            this.chkFillMessageAsTranslate.AutoSize = true;
            this.chkFillMessageAsTranslate.Location = new System.Drawing.Point(397, 71);
            this.chkFillMessageAsTranslate.Name = "chkFillMessageAsTranslate";
            this.chkFillMessageAsTranslate.Size = new System.Drawing.Size(145, 17);
            this.chkFillMessageAsTranslate.TabIndex = 9;
            this.chkFillMessageAsTranslate.Text = "Fill Message as Translate";
            this.chkFillMessageAsTranslate.UseVisualStyleBackColor = true;
            // 
            // chkFillReplaceTranslated
            // 
            this.chkFillReplaceTranslated.AutoSize = true;
            this.chkFillReplaceTranslated.Location = new System.Drawing.Point(226, 71);
            this.chkFillReplaceTranslated.Name = "chkFillReplaceTranslated";
            this.chkFillReplaceTranslated.Size = new System.Drawing.Size(165, 17);
            this.chkFillReplaceTranslated.TabIndex = 8;
            this.chkFillReplaceTranslated.Text = "Replace Translated Message";
            this.chkFillReplaceTranslated.UseVisualStyleBackColor = true;
            // 
            // chkFillMessage
            // 
            this.chkFillMessage.AutoSize = true;
            this.chkFillMessage.Location = new System.Drawing.Point(136, 71);
            this.chkFillMessage.Name = "chkFillMessage";
            this.chkFillMessage.Size = new System.Drawing.Size(84, 17);
            this.chkFillMessage.TabIndex = 7;
            this.chkFillMessage.Text = "Fill Message";
            this.chkFillMessage.UseVisualStyleBackColor = true;
            // 
            // btnFillStart
            // 
            this.btnFillStart.Location = new System.Drawing.Point(524, 17);
            this.btnFillStart.Name = "btnFillStart";
            this.btnFillStart.Size = new System.Drawing.Size(75, 49);
            this.btnFillStart.TabIndex = 6;
            this.btnFillStart.Text = "Start";
            this.btnFillStart.UseVisualStyleBackColor = true;
            this.btnFillStart.Click += new System.EventHandler(this.btnFillStart_Click);
            // 
            // btnFillTranslate
            // 
            this.btnFillTranslate.Location = new System.Drawing.Point(491, 17);
            this.btnFillTranslate.Name = "btnFillTranslate";
            this.btnFillTranslate.Size = new System.Drawing.Size(26, 23);
            this.btnFillTranslate.TabIndex = 5;
            this.btnFillTranslate.Text = "...";
            this.btnFillTranslate.UseVisualStyleBackColor = true;
            this.btnFillTranslate.Click += new System.EventHandler(this.btnFillTranslate_Click);
            // 
            // txtFillTarget
            // 
            this.txtFillTarget.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookFillTargetPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFillTarget.Location = new System.Drawing.Point(136, 45);
            this.txtFillTarget.Name = "txtFillTarget";
            this.txtFillTarget.Size = new System.Drawing.Size(349, 20);
            this.txtFillTarget.TabIndex = 0;
            this.txtFillTarget.Text = global::AdvanceTools.Properties.Settings.Default.StorybookFillTargetPath;
            this.txtFillTarget.DoubleClick += new System.EventHandler(this.txtFillTarget_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Storybook Path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Translate Path";
            // 
            // btnFillTarget
            // 
            this.btnFillTarget.Location = new System.Drawing.Point(491, 43);
            this.btnFillTarget.Name = "btnFillTarget";
            this.btnFillTarget.Size = new System.Drawing.Size(26, 23);
            this.btnFillTarget.TabIndex = 2;
            this.btnFillTarget.Text = "...";
            this.btnFillTarget.UseVisualStyleBackColor = true;
            this.btnFillTarget.Click += new System.EventHandler(this.btnFillTarget_Click);
            // 
            // txtFillTranslate
            // 
            this.txtFillTranslate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookFillTranslatePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFillTranslate.Location = new System.Drawing.Point(136, 19);
            this.txtFillTranslate.Name = "txtFillTranslate";
            this.txtFillTranslate.Size = new System.Drawing.Size(349, 20);
            this.txtFillTranslate.TabIndex = 3;
            this.txtFillTranslate.Text = global::AdvanceTools.Properties.Settings.Default.StorybookFillTranslatePath;
            this.txtFillTranslate.DoubleClick += new System.EventHandler(this.txtFillTranslate_DoubleClick);
            // 
            // txtReadPath
            // 
            this.txtReadPath.Location = new System.Drawing.Point(136, 19);
            this.txtReadPath.Name = "txtReadPath";
            this.txtReadPath.Size = new System.Drawing.Size(349, 20);
            this.txtReadPath.TabIndex = 0;
            this.txtReadPath.Text = global::AdvanceTools.Properties.Settings.Default.StorybookReadInputPath;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mod Path";
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
            // txtReadOutput
            // 
            this.txtReadOutput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AdvanceTools.Properties.Settings.Default, "StorybookReadOutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtReadOutput.Location = new System.Drawing.Point(136, 45);
            this.txtReadOutput.Name = "txtReadOutput";
            this.txtReadOutput.Size = new System.Drawing.Size(349, 20);
            this.txtReadOutput.TabIndex = 3;
            this.txtReadOutput.Text = global::AdvanceTools.Properties.Settings.Default.StorybookReadOutputPath;
            this.txtReadOutput.DoubleClick += new System.EventHandler(this.txtReadOutput_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Path";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadStart);
            this.groupBox1.Controls.Add(this.btnReadOutput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtReadOutput);
            this.groupBox1.Controls.Add(this.btnReadPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtReadPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Storybook to Excel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartReadComment);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtReadCommentOutput);
            this.groupBox3.Controls.Add(this.btnReadCommentInput);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtReadCommentInput);
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read Comment";
            // 
            // btnStartReadComment
            // 
            this.btnStartReadComment.Location = new System.Drawing.Point(524, 17);
            this.btnStartReadComment.Name = "btnStartReadComment";
            this.btnStartReadComment.Size = new System.Drawing.Size(75, 94);
            this.btnStartReadComment.TabIndex = 6;
            this.btnStartReadComment.Text = "Start";
            this.btnStartReadComment.UseVisualStyleBackColor = true;
            this.btnStartReadComment.Click += new System.EventHandler(this.btnStartReadComment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Output Path";
            // 
            // txtReadCommentOutput
            // 
            this.txtReadCommentOutput.Location = new System.Drawing.Point(136, 45);
            this.txtReadCommentOutput.Multiline = true;
            this.txtReadCommentOutput.Name = "txtReadCommentOutput";
            this.txtReadCommentOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadCommentOutput.Size = new System.Drawing.Size(381, 66);
            this.txtReadCommentOutput.TabIndex = 3;
            // 
            // btnReadCommentInput
            // 
            this.btnReadCommentInput.Location = new System.Drawing.Point(491, 17);
            this.btnReadCommentInput.Name = "btnReadCommentInput";
            this.btnReadCommentInput.Size = new System.Drawing.Size(26, 23);
            this.btnReadCommentInput.TabIndex = 2;
            this.btnReadCommentInput.Text = "...";
            this.btnReadCommentInput.UseVisualStyleBackColor = true;
            this.btnReadCommentInput.Click += new System.EventHandler(this.btnReadCommentInput_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Translate Path";
            // 
            // txtReadCommentInput
            // 
            this.txtReadCommentInput.Location = new System.Drawing.Point(136, 19);
            this.txtReadCommentInput.Name = "txtReadCommentInput";
            this.txtReadCommentInput.Size = new System.Drawing.Size(349, 20);
            this.txtReadCommentInput.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkClearAllSheet);
            this.groupBox4.Controls.Add(this.btnClearTranslateStart);
            this.groupBox4.Controls.Add(this.btnClearTranslateInput);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtClearTranslatePath);
            this.groupBox4.Location = new System.Drawing.Point(13, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 67);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clear Storybook Translate";
            // 
            // chkClearAllSheet
            // 
            this.chkClearAllSheet.AutoSize = true;
            this.chkClearAllSheet.Location = new System.Drawing.Point(136, 44);
            this.chkClearAllSheet.Name = "chkClearAllSheet";
            this.chkClearAllSheet.Size = new System.Drawing.Size(95, 17);
            this.chkClearAllSheet.TabIndex = 7;
            this.chkClearAllSheet.Text = "Clear All Sheet";
            this.chkClearAllSheet.UseVisualStyleBackColor = true;
            // 
            // btnClearTranslateStart
            // 
            this.btnClearTranslateStart.Location = new System.Drawing.Point(524, 17);
            this.btnClearTranslateStart.Name = "btnClearTranslateStart";
            this.btnClearTranslateStart.Size = new System.Drawing.Size(75, 23);
            this.btnClearTranslateStart.TabIndex = 6;
            this.btnClearTranslateStart.Text = "Start";
            this.btnClearTranslateStart.UseVisualStyleBackColor = true;
            this.btnClearTranslateStart.Click += new System.EventHandler(this.btnClearTranslateStart_Click);
            // 
            // btnClearTranslateInput
            // 
            this.btnClearTranslateInput.Location = new System.Drawing.Point(491, 17);
            this.btnClearTranslateInput.Name = "btnClearTranslateInput";
            this.btnClearTranslateInput.Size = new System.Drawing.Size(26, 23);
            this.btnClearTranslateInput.TabIndex = 2;
            this.btnClearTranslateInput.Text = "...";
            this.btnClearTranslateInput.UseVisualStyleBackColor = true;
            this.btnClearTranslateInput.Click += new System.EventHandler(this.btnClearTranslateInput_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Storybook Excel Path";
            // 
            // txtClearTranslatePath
            // 
            this.txtClearTranslatePath.Location = new System.Drawing.Point(136, 19);
            this.txtClearTranslatePath.Name = "txtClearTranslatePath";
            this.txtClearTranslatePath.Size = new System.Drawing.Size(349, 20);
            this.txtClearTranslatePath.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 6);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmStorybook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 507);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStorybook";
            this.Text = "frmStorybook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStorybook_FormClosing);
            this.Load += new System.EventHandler(this.frmStorybook_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnFill.ResumeLayout(false);
            this.pnFill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWriteStart;
        private System.Windows.Forms.Button btnWriteOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriteOutput;
        private System.Windows.Forms.Button btnWriteInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWriteInput;
        private System.Windows.Forms.GroupBox pnFill;
        private System.Windows.Forms.Button btnFillStart;
        private System.Windows.Forms.Button btnFillTranslate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFillTranslate;
        private System.Windows.Forms.Button btnFillTarget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFillTarget;
        private System.Windows.Forms.CheckBox chkFillMessage;
        private System.Windows.Forms.CheckBox chkFillReplaceTranslated;
        private System.Windows.Forms.TextBox txtReadPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadPath;
        private System.Windows.Forms.TextBox txtReadOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReadOutput;
        private System.Windows.Forms.Button btnReadStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStartReadComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReadCommentOutput;
        private System.Windows.Forms.Button btnReadCommentInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReadCommentInput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearTranslateStart;
        private System.Windows.Forms.Button btnClearTranslateInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClearTranslatePath;
        private System.Windows.Forms.CheckBox chkFillMessageAsTranslate;
        private System.Windows.Forms.CheckBox chkClearAllSheet;
        private System.Windows.Forms.Button btnDownload;
    }
}