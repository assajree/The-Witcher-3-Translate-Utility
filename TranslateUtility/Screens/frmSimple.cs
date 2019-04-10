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
        string modDownloadPath = Path.Combine(Configs.DownloadPath, "mod");

        public frmSimple()
        {
            InitializeComponent();
        }

        private void frmSimple_Load(object sender, EventArgs e)
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            
            lblVersion.Text = $@"Version : {c.GetBuildDate(version):yyyy.MM.dd.HHmmss}";
            InitialScreen();
        }

        private void InitialScreen()
        {
            string tempPath = Configs.TempPath;
            
            string downloadPath = Configs.DownloadPath;
            string modPath = Path.Combine(Configs.StartupPath, "mod");

            if (!Directory.Exists(downloadPath))
                Directory.CreateDirectory(downloadPath);

            if (!Directory.Exists(modPath))
                Directory.CreateDirectory(modPath);

            ReadLocalVersion();
            EnableExtraOption();
            EnableRestoreButton();

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
                //ReadLocalVersion();
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

        private void ReadLocalVersion()
        {
            lblLocalVersion.Text=c.ReadLocalVersion(txtModPath.Text);
        }

        private void btnLangDesc_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtGamePath);
        }

        private void btnCheckVersion_Click(object sender, EventArgs e)
        {
            var version = c.ProcessingString(c.GetLastVersion, "Getting Version...", false);
            if (version != null)
            {
                lblLastedVersion.Text = version;
                lblLastCheck.Text = DateTime.Now.ToString("d MMMM yyyy HH:mm:ss");
                SaveSetting();
            }
        }

        private void btnInstallLang_Click(object sender, EventArgs e)
        {
            c.Processing(InstallMod,"กำลังติดตั้ง","ติดตั้งสำเร็จ");
            if (!c.CheckFontMod(txtGamePath.Text))
            {
                if (c.ShowConfirm("ไม่พบการติดตั้ง font mod ต้องการติดตั้งหรือไม่ฮึ?"))
                {
                    c.InstallFont(txtGamePath.Text);
                    c.ShowMessage("ติดตั้งเสร็จแล้วฮึ");
                }
            }
        } 

        private void InstallMod()
        {
            // silence backup
            if (!c.BackupExists(Configs.BackupPath))
                Backup(false);

            c.InstallMod(
                txtModPath.Text,
                txtGamePath.Text
            );
        }

        private void btnModPath_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtModPath);
            //ReadLocalVersion();
        }

        private void btnGamePath_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtGamePath);
        }

        private void btnModDownload_Click(object sender, EventArgs e)
        {
            string path = c.DownloadLegacyMod(txtModPath.Text,modDownloadPath);
            if (path != null)
            {
                txtModPath.Text = path;
                //ReadLocalVersion();
            }
        }

        private void txtModPath_TextChanged(object sender, EventArgs e)
        {
            ReadLocalVersion();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (ValidateBeforeBackup())
                c.Processing(Backup, "กำลังสำรองข้อมูล", "สำรองของมูลสำเร็จ");

        }

        private void Backup()
        {
            Backup(true);            
        }

        private void Backup(bool overwrite)
        {
            c.Backup(txtGamePath.Text, Configs.BackupPath, overwrite, true);
            EnableRestoreButton();
        }

        private bool ValidateBeforeBackup()
        {
            return c.ValidateBeforeBackup(
                Configs.BackupPath,
                "มีแบ็คอัพเดิมอยู่แล้ว ต้องการเขียนทับหรือไม่?"
            );
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if(!c.BackupExists(Configs.BackupPath))
            {
                c.ShowErrorMessage("ไม่พบแบ็คอัพ");
                return;
            }

            if (c.ShowConfirmWarning("ต้องการคืนค่าจากแบ็คอัพ?"))
                c.Processing(Restore, "กำลังคืนค่า", "คืนค่าสำเร็จ");

            // remove font mod
            if (c.CheckFontMod(txtGamePath.Text))
            {
                if (c.ShowConfirm("ต้องการลบ font mod ด้วยหรือไม่?"))
                    c.RemoveFont(txtGamePath.Text);

            }
        }

        private void Restore()
        {
            c.Backup(Configs.BackupPath, txtGamePath.Text, true, false);
        }

        private void EnableRestoreButton()
        {
            btnRestore.Enabled = c.BackupExists(Configs.BackupPath);
        }


        #endregion


    }
}
