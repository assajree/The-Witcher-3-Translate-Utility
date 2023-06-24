using svvv;
using System;
using System.IO;
using System.Windows.Forms;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace TranslateUtility
{
    public partial class frmVerySimple : Form
    {
        Common c = new Common();
        string modPath = null;
        string translatePath = null;

        public frmVerySimple()
        {
            InitializeComponent();
        }

        private void frmVerySimple_Load(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void InitialScreen()
        {
            string downloadPath = Configs.DownloadPath;
            modPath = Path.Combine(Configs.StartupPath, "mod");

            if (!Directory.Exists(downloadPath))
                Directory.CreateDirectory(downloadPath);

            if (!Directory.Exists(modPath))
                Directory.CreateDirectory(modPath);

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text = $@"Version : {c.GetBuildDate(version):yyyy.MM.dd.HHmmss}";

            ReadLocalVersion();
            EnableExtraOption();
            EnableRestoreButton();
            EnableInstallButton();

            // install
            txtGamePath.SetDefault(c.GetGameDirectory());


        }

        private void lblModVersion_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(modPath))
                c.Open(modPath);
        }

        private void btnLegacyGenerate_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            // download translate excel file
            translatePath = Path.Combine(Configs.DownloadPath, "translate.xlsx");
            translatePath = c.DownloadGoogleSheet(translatePath, false);
            if (translatePath == null)
                return;

            // generate mod
            var result = c.Processing(GenerateMod, false, "กำลังสร้าง...");

            // install mod
            c.Processing(InstallMod, false, "กำลังติดตั้ง");


            c.ShowMessage("ติดตั้งสำเร็จ");
            EnableRestoreButton();
        }

        private void GenerateMod()
        {
            c.GenerateLegacyMod(
                translatePath,
                modPath,
                chkModDoubleLanguage.Checked,
                rdoModOriginFirst.Checked,
                chkUntranslateInfo.Checked,
                chkUiInfo.Checked,
                chkTranslateInfo.Checked,
                true
            );
        }

        private void GenerateModAlt()
        {
            c.GenerateLegacyModAlt(
                translatePath,
                modPath,
                chkModDoubleLanguage.Checked,
                rdoModOriginFirst.Checked,
                chkUntranslateInfo.Checked,
                chkUiInfo.Checked,
                chkTranslateInfo.Checked,
                Common.eFontSetting.Sarabun,
                true,
                true
            );
        }

        private void InstallMod()
        {
            // silence backup
            if (!c.BackupExists(Configs.BackupPath))
                Backup(false);

            c.InstallMod(
                modPath,
                txtGamePath.Text
            );
        }

        private void Backup(bool overwrite)
        {
            c.Backup(txtGamePath.Text, Configs.BackupPath, overwrite, true);
        }

        private void EnableRestoreButton()
        {
            btnRestore.Enabled = c.BackupExists(Configs.BackupPath);
        }

        private void EnableExtraOption()
        {
            var enable = chkModDoubleLanguage.Checked;
            rdoModOriginFirst.Enabled = enable;
            rdoModTranslateFirst.Enabled = enable;

            rdoModTranslateFirst.Checked = !rdoModOriginFirst.Checked;
        }

        private void ReadLocalVersion()
        {
            lblModVersion.Text = c.ReadLocalVersion(modPath);
        }

        private void chkModDoubleLanguage_CheckedChanged(object sender, EventArgs e)
        {
            EnableExtraOption();
        }

        private void btnGamePath_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtGamePath);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!c.BackupExists(Configs.BackupPath))
            {
                c.ShowErrorMessage("ไม่พบแบ็คอัพ");
                return;
            }

            if (c.ShowConfirmWarning("ต้องการคืนค่าเกมกลับไปก่อนติดตั้ง mod?"))
                c.Processing(Restore, "กำลังคืนค่า", "คืนค่าสำเร็จ");

            // remove font mod
            if (c.CheckFontMod(txtGamePath.Text))
            {
                if (c.ShowConfirm("ต้องการลบ font mod ด้วยหรือไม่?"))
                    c.RemoveOldFont(txtGamePath.Text);

            }
        }

        private void Restore()
        {
            c.Backup(Configs.BackupPath, txtGamePath.Text, true, false);
        }

        private void frmVerySimple_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Save();
        }

        private void txtGamePath_TextChanged(object sender, EventArgs e)
        {
            EnableInstallButton();
        }

        private void EnableInstallButton()
        {
            if (Directory.Exists(Path.Combine(txtGamePath.Text, "content")))
            {
                btnLegacyGenerate.Enabled = true;
                btnInstallAlt.Enabled = true;
            }
            else
            {
                btnLegacyGenerate.Enabled = false;
                btnInstallAlt.Enabled = false;
            }
        }

        private void btnInstallAlt_Click(object sender, EventArgs e)
        {
            StartAlt();
        }

        private void StartAlt()
        {
            // download translate excel file
            translatePath = Path.Combine(Configs.DownloadPath, "translate.xlsx");
            translatePath = c.DownloadGoogleSheet(translatePath, false);
            if (translatePath == null)
                return;

            // generate mod
            var result = c.Processing(GenerateModAlt, false, "กำลังสร้าง...");

            // install mod
            c.Processing(InstallMod, false, "กำลังติดตั้ง");


            c.ShowMessage("ติดตั้งสำเร็จ");
            EnableRestoreButton();
        }
    }
}
