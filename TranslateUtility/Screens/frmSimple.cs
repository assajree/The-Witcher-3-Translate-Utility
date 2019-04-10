using svvv;
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

namespace TranslateUtility.Screens
{
    public partial class frmSimple : Form
    {
        Common c = new Common();
        string modPath = Path.Combine(Configs.DownloadPath, "mod");

        public frmSimple()
        {
            InitializeComponent();
        }

        private void frmSimple_Load(object sender, EventArgs e)
        {            
            InitialScreen();
        }

        private void InitialScreen()
        {
            string tempPath = Configs.TempPath;
            
            string downloadPath = Configs.DownloadPath;

            if (!Directory.Exists(downloadPath))
                Directory.CreateDirectory(downloadPath);

            if (!Directory.Exists(modPath))
                Directory.CreateDirectory(modPath);

            EnableExtraOption();

            // generate
            txtLegacyOutput.SetDefault(modPath);

            // install
            //txtLangSource.SetDefault(modPath);
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Save();
        }

        private void frmSimple_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        #region generate

        private void btnLegacyExcel_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtLegacyExcel);
        }

        private void btnLegacyOutput_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtLegacyOutput);
        }

        private void btnLegacyExcelDownload_Click(object sender, EventArgs e)
        {
            string path=c.DownloadLegacyExcel(Path.Combine(Configs.DownloadPath,"legacy.xlsx"));
            if(path!=null)
            {
                txtLegacyExcel.Text = path;
            }
        }

        private void btnLegacyOutputOpen_Click(object sender, EventArgs e)
        {
            c.Open(txtLegacyOutput.Text);
        }

        private void chkModDoubleLanguage_CheckedChanged(object sender, EventArgs e)
        {
            EnableExtraOption();
        }

        private void btnLegacyGenerate_Click(object sender, EventArgs e)
        {
            c.Processing(GenerateMod, "กำลังสร้าง...", "สร้าง mod สำเร็จ");
            if(c.ShowConfirm("ต้องการเปลี่ยนโฟลเดอร์ mod เป็นโฟลเดอร์ปลายทางหรือไม่?"))
            {
                txtModPath.Text = txtLegacyOutput.Text;
                CheckLocalVersion();
            }
        }       

        private void EnableExtraOption()
        {
            var enable= chkModDoubleLanguage.Checked;
            rdoModOriginFirst.Enabled = enable;
            rdoModTranslateFirst.Enabled = enable;
        }

        private void GenerateMod()
        {
            c.GenerateLegacyMod(
                txtLegacyExcel.Text,
                txtLegacyOutput.Text,
                chkModDoubleLanguage.Checked,
                rdoModOriginFirst.Checked
            );
        }


        #endregion

        #region install

        private void CheckLocalVersion()
        {
            lblLocalVersion.Text=c.ReadVersion(txtModPath.Text);
        }

        private void btnLangSource_Click(object sender, EventArgs e)
        {

        }

        private void btnLangDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckVersion_Click(object sender, EventArgs e)
        {

        }

        private void btnInstallLang_Click(object sender, EventArgs e)
        {

        }

        private void btnModPath_Click(object sender, EventArgs e)
        {

        }

        private void btnGamePath_Click(object sender, EventArgs e)
        {

        }

        private void btnModDownload_Click(object sender, EventArgs e)
        {

        }


        #endregion


    }
}
