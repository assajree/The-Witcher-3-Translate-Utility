using Svvv.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace TranslateUtility
{
    /// <summary>
    /// for generate mod file
    /// </summary>
    public partial class frmModTools : Form
    {
        private Common c = new Common();

        public frmModTools()
        {
            InitializeComponent();
        }


        private void frmModTools_Load(object sender, EventArgs e)
        {

        }

        private void frmModTools_Shown(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void InitialScreen()
        {
            string gamePath = c.GetGameDirectory();
            //string backupPath = Path.Combine(Application.StartupPath, "backup");
            string outputPath = Path.Combine(Application.StartupPath, "output");
            string excelOutput = Path.Combine(Application.StartupPath, "output", "translate.xlsx");
            string translatePath= c.GetTranslateFile();

            // Mod from Mod
            //txtModSource.SetDefault(backupPath);
            txtModOutput.SetDefault(outputPath);
            txtModExcel.SetDefault(translatePath);
            EnableModOption();

            // mod from excel
            EnableExcelOption();
            txtExcelSource.SetDefault(translatePath);
            txtExcelOutput.SetDefault(outputPath);

        }

        #region Mod from Backup


        private void EnableModOption()
        {
            rdoModOriginFirst.Enabled = chkModDoubleLanguage.Checked;
            rdoModTranslateFirst.Enabled = chkModDoubleLanguage.Checked;
        }

        private void btnModFromBackup_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtModSource.Text))
            {
                c.ShowErrorMessage("Original directory not exist.");
            }
            else if (!File.Exists(txtModExcel.Text))
            {
                c.ShowErrorMessage("Translate file not exist.");
            }
            else
            {
                c.Processing(ModFromBackup, "Processing..."); 
            }
        }

        private void ModFromBackup()
        {
            c.GenerateModFromGameFile(
                txtModExcel.Text,
                txtModSource.Text,
                txtModOutput.Text,
                chkModDoubleLanguage.Checked,
                rdoModOriginFirst.Checked
            );
        }

        private void chkModDoubleLanguage_CheckedChanged(object sender, EventArgs e)
        {
            EnableModOption();
        }

        private void btnModSource_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtModSource);
        }

        private void btnModExcel_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtModExcel);
        }

        private void btnModOutput_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtModOutput);
        }

        private void btnModExcelDownload_Click(object sender, EventArgs e)
        {
            //c.DownloadMod();
        }

        private void btnModOutputOpen_Click(object sender, EventArgs e)
        {
            c.Open(txtModOutput.Text);
        }

        #endregion


        #region Mod from Excel

        private void btnExcelSource_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtExcelSource);
        }

        private void btnExcelSourceDownload_Click(object sender, EventArgs e)
        {

        }

        private void btnExcelOutput_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtExcelOutput);
        }

        private void btnExcelOutputOpen_Click(object sender, EventArgs e)
        {
            c.OpenFileDirectory(txtExcelOutput.Text);
        }

        private void chkExcelDoubleLanguage_CheckedChanged(object sender, EventArgs e)
        {
            EnableExcelOption();
        }

        private void btnExcelTranslat_Click(object sender, EventArgs e)
        {
            c.Processing(GenerateModFromExcel, "Processing", "Translate Complete");
        }

        private void EnableExcelOption()
        {
            var enabled = chkExcelDoubleLanguage.Checked;
            rdoExcelOriginFirst.Enabled = enabled;
            rdoExcelTranslateFirst.Enabled = enabled;
        }

        private void GenerateModFromExcel()
        {
            c.GenerateModFromExcel(
                txtExcelSource.Text,
                txtExcelOutput.Text,
                chkExcelDoubleLanguage.Checked,
                rdoExcelOriginFirst.Checked
            );
        }

        #endregion

        private void frmModTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Save();
        }
    }
}
