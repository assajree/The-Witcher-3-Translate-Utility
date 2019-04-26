using System;
using System.IO;
using System.Windows.Forms;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace TranslateUtility
{
    /// <summary>
    /// for generate excel file 
    /// </summary>
    public partial class frmExcelTools : Form
    {

        #region Form Event

        Common c = new Common();

        public frmExcelTools()
        {
            InitializeComponent();
        }

        private void frmExcelTools_Shown(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void InitialScreen()
        {
            string gamePath = c.GetGameDirectory();
            string backupPath = Path.Combine(Application.StartupPath, "backup");
            string outputPath = Path.Combine(Application.StartupPath, "output");
            string translatePath = c.GetTranslateFilePath();

            // generate from mod
            txtModSource.SetDefault(gamePath);
            txtModOutput.SetDefault(Path.Combine(Application.StartupPath, "output", "message.xlsx"));

            // fill from mod
            txtModFillOutput.SetDefault(Path.Combine(Application.StartupPath, "output", "fill.xlsx"));

            // generate from legacy
            txtLegacyMod.SetDefault(TranslateUtility.Properties.Settings.Default._GameModDownloadPath);
            txtLegacyOutput.SetDefault(Path.Combine(Application.StartupPath, "output", "legacy.xlsx"));

            // filter excel
            EnableFilterContain();
            txtFilterSource.SetDefault(translatePath);
            txtFilterOutput.SetDefault(Path.Combine(Application.StartupPath, "output", "filtered.xlsx"));

            // merge excel
            //txtMergeSource.SetDefault(outputPath);
            //txtMergeTranslate.SetDefault(outputPath);
            //txtMergeOutput.SetDefault(outputPath);

            // csv
            txtCsvOutput.SetDefault(Path.Combine(Application.StartupPath, "output", "csv.xlsx"));
        }

        private void frmExcelTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Generate from Mod

        private void btnExcelSource_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtModSource);
        }

        private void brnExcelOutput_Click(object sender, EventArgs e)
        {
            c.SaveXlsxTextBox(txtModOutput);
        }

        private void btnGenerateExcel_Click(object sender, EventArgs e)
        {
            c.Processing(GenerateExcelFromMod, "Processing...", "Generate complete");            
        }

        private void GenerateExcelFromMod()
        {
            c.GenerateExcelFromMod(txtModSource.Text, txtModOutput.Text);
        }

        #endregion

        #region Fill by Mod

        private void btnModFillSource_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtModFillSource);
        }

        private void btnModFillOutput_Click(object sender, EventArgs e)
        {
            c.SaveXlsxTextBox(txtModFillOutput);
        }

        private void btnModFill_Click(object sender, EventArgs e)
        {
            c.ProcessingString(FillByMod, "Processing", "Fill Complete");
        }

        private string FillByMod()
        {
            var result = c.FillExcelFromMod(txtModFillSource.Text, txtModFillOutput.Text, rdoModFillTranslate.Checked);
            c.ShowMessage(result, "Fill Complete");
            return result;
        }

        #endregion

        #region Generate from Legacy

        private void btnLegacyMod_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtLegacyMod);
        }

        private void btnLegacyExcel_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtLegacyExcel);
        }

        private void btnLegacyOutput_Click(object sender, EventArgs e)
        {
            c.SaveXlsxTextBox(txtLegacyOutput);
        }

        private void btnLegacyGenerate_Click(object sender, EventArgs e)
        {
            var startTime = DateTime.Now;
            var message=c.ProcessingString(GenrateFromLegacy, "กรุณานอนรอซักครู่...",false);            

            if(message!=null)
            {
                var endTime = DateTime.Now;
                c.ShowMessage(message + Environment.NewLine + $@"{(endTime - startTime).Minutes} minutes", "Generate Complete");
            }
        }

        private string GenrateFromLegacy()
        {
            return c.GenerateExcelFromLegacy(
                txtLegacyMod.Text,
                txtLegacyExcel.Text,
                txtLegacyOutput.Text
            );
        }

        #endregion

        #region Filter Excel

        private void btnFilterSource_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtFilterSource);
        }

        private void btnFilterOutput_Click(object sender, EventArgs e)
        {
            c.SaveXlsxTextBox(txtFilterOutput);
        }

        private void btnFilterOutputOpen_Click(object sender, EventArgs e)
        {
            c.OpenFileDirectory(txtFilterOutput.Text);
        }

        private void chkFilterContain_CheckedChanged(object sender, EventArgs e)
        {
            EnableFilterContain();
        }

        private void btnFilterStart_Click(object sender, EventArgs e)
        {
            c.Processing(FilterExcel);
        }

        private void FilterExcel()
        {
            c.FilterExcel(
                txtFilterSource.Text,
                txtFilterOutput.Text,
                chkFilterEmpty.Checked,
                chkFilterSameWord.Checked,
                chkFilterSingleWord.Checked,
                chkFilterUi.Checked,
                chkFilterContain.Checked ? txtFilterContain.Text : null,
                rdoSortByLength.Checked
            );
        }

        private void EnableFilterContain()
        {
            txtFilterContain.Enabled = chkFilterContain.Checked;
        }

        #endregion

        #region Merge

        private void btnMergeExcel_Click(object sender, EventArgs e)
        {
            c.Processing(MergeExcel);
        }

        private void MergeExcel()
        {
            c.MergeExcel(
                txtMergeSource.Text,
                txtMergeTranslate.Text,
                txtMergeOutput.Text,
                chkMergeNewMessage.Checked,
                chkMergeReplaceTranslate.Checked,
                chkMergeReplaceText.Checked
            );
        }

        private void btnMergeSource_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtMergeSource);
        }

        private void btnMergeTranslate_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtMergeTranslate);
        }

        private void btnMergeOutput_Click(object sender, EventArgs e)
        {
            c.SaveXlsxTextBox(txtMergeOutput);
        }

        #endregion

        #region Legacy

        private void btnLegacyExcelDownload_Click(object sender, EventArgs e)
        {
            var path = c.DownloadLegacyExcel(txtLegacyExcel.Text,true);
            if (path != null)
                txtLegacyExcel.Text = path;
        }

        private void btnLegacyModDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string path = c.DownloadLegacyMod(txtLegacyMod.Text);
                if (path != null)
                    txtLegacyMod.Text = path;
            }
            catch(Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        #endregion

        #region CSV

        private void lblCsvOutput_DoubleClick(object sender, EventArgs e)
        {
            c.Open(txtCsvOutput.Text);
        }

        private void btnCsvOutput_Click(object sender, EventArgs e)
        {
            c.SaveXlsxTextBox(txtCsvOutput);
        }

        private void btnCsvStart_Click(object sender, EventArgs e)
        {
            c.Processing(GenerateExcelFromCsv);
        }

        private void GenerateExcelFromCsv()
        {
            c.GenerateExcelFromCsv(
                txtCsvInput.Text,
                txtCsvOutput.Text
            );
        }

        private void btnCsvInput_Click(object sender, EventArgs e)
        {
            c.SelectCsvTextBox(txtCsvInput);
        }

        #endregion
    }
}
