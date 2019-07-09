﻿using System;
using System.IO;
using System.Windows.Forms;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace TranslateUtility
{
    public partial class frmStorybook : Form
    {
        Common c = new Common();
        public frmStorybook()
        {
            InitializeComponent();
        }

        private void frmStorybook_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Save();
        }

        #region read

        private void btnReadPath_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtReadPath);
        }

        private void btnReadOutput_Click(object sender, EventArgs e)
        {
            c.SaveXlsxTextBox(txtReadOutput);
        }

        private void btnReadStart_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSetting();
                c.ConvertStorybookToExcel(
                    txtReadPath.Text,
                    txtReadOutput.Text
                );
                c.ShowMessage("Complete");
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void txtReadOutput_DoubleClick(object sender, EventArgs e)
        {
            c.OpenFileDirectory(txtReadOutput.Text);
        }

        private void frmStorybook_Load(object sender, EventArgs e)
        {
            txtReadOutput.SetDefault(Path.Combine(Application.StartupPath, "output", "storybook.xlsx"));
        }




        #endregion

        private void btnWriteStart_Click(object sender, EventArgs e)
        {
            var outputDir = new DirectoryInfo(txtWriteOutput.Text);
            if(outputDir.Name!="files")
            {
                c.ShowMessage("Output directory name should be \"files\"");
                return;
            }

            GenerateStorybook();
        }

        private void GenerateStorybook()
        {
            try
            {
                c.GenerateStorybook(
                    txtWriteInput.Text,
                    txtWriteOutput.Text
                );
                c.ShowMessage("Complete");
            }
            catch(Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void txtWriteOutput_DoubleClick(object sender, EventArgs e)
        {
            c.Open(txtWriteOutput.Text);
        }

        private void btnWriteInput_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtWriteInput);
        }

        private void btnWriteOutput_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtWriteOutput);
        }
    }
}