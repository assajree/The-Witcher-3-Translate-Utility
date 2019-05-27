using svvv;
using System;
using System.IO;
using System.Windows.Forms;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace TranslateUtility
{
    public partial class frmVeryVerySimple : Form
    {
        Common c = new Common();
        string modPath = null;
        string resultPath = null;
        string translatePath = null;

        bool ShowAdvance
        {
            get
            {
                return Properties.Settings.Default._SimpleShowAdvance;
            }
            set
            {
                Properties.Settings.Default._SimpleShowAdvance = value;
            }

        }

        public frmVeryVerySimple()
        {
            InitializeComponent();
        }

        private void frmVerySimple_Load(object sender, EventArgs e)
        {
            InitialScreen();
            InitialTooTip();

            if (!ShowAdvance)
                ToggleAdvance();
        }

        private void InitialTooTip()
        {
            toolTip1.SetToolTip(rdoDownloadAlways, "ดาวน์โหลดทุกครั้ง");
            toolTip1.SetToolTip(rdoDownloadDialy, "ดาวน์โหลดเมื่อผ่านไป 1 วัน จากการดาวน์โหลดครั้งที่แล้วเท่านั้น");
            toolTip1.SetToolTip(rdoDownloadHourly, "ดาวน์โหลดเมื่อผ่านไป 1 ชั่วโมง จากการดาวน์โหลดครั้งที่แล้วเท่านั้น");
            toolTip1.SetToolTip(rdoDownloadOnce, "ดาวน์โหลดเมื่อไม่มีไฟล์แปลภาษาเท่านั้น");
        }

        private void InitialScreen()
        {
            string downloadPath = Configs.DownloadPath;
            modPath = Path.Combine(Configs.StartupPath, "mod");
            resultPath = Path.Combine(modPath, "result.xlsx");

            //if (!Directory.Exists(downloadPath))
            //    Directory.CreateDirectory(downloadPath);

            //if (!Directory.Exists(modPath))
            //    Directory.CreateDirectory(modPath);

            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            miVersion.Text = $@"Version : {c.GetVersionText(version)}";

            //ReadLocalVersion();
            EnableExtraOption();
            EnableButton();

            // install
            txtGamePath.SetDefault(c.GetGameDirectory());

            SetDownloadFrequencyRadio();
            SetFontRadio();

        }

        private void lblModVersion_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(modPath))
                c.Open(modPath);
        }

        private void btnLegacyGenerate_Click(object sender, EventArgs e)
        {
            StartAlt();
        }

        private void Start()
        {
            // download translate excel file
            translatePath = Path.Combine(Configs.DownloadPath, "translate.xlsx");
            translatePath = c.DownloadLegacyExcel(translatePath, false, GetDownloadFrequency());
            if (translatePath == null)
                return;

            // generate mod
            var result = c.Processing(GenerateMod, false, "กำลังสร้าง...");
            if (result != DialogResult.OK)
                return;

            // install mod
            result = c.Processing(InstallMod, false, "กำลังติดตั้ง");
            if (result != DialogResult.OK)
                return;

            c.ShowMessage("ติดตั้งสำเร็จ");
            EnableButton();
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
                chkTranslateInfo.Checked
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
                chkTranslateInfo.Checked,
                chkUiInfo.Checked,
                GetFontSetting()
            );
        }

        private void InstallMod()
        {
            // silence backup
            //if (!c.BackupExists(Configs.BackupPath))
            //    Backup(false);

            c.InstallMod(
                modPath,
                txtGamePath.Text,
                !rdoFontNone.Checked
            );
        }

        private void Backup(bool overwrite)
        {
            c.Backup(txtGamePath.Text, Configs.BackupPath, overwrite, true);
        }

        private void EnableButton()
        {
            // result button
            btnResult.Enabled = File.Exists(resultPath);

            // install button && restore button
            if (c.IsValidGamePath(txtGamePath.Text))
            {
                btnLegacyGenerate.Enabled = true;
                //btnInstallAlt.Enabled = true;
                btnRestore.Enabled = true;
            }
            else
            {
                btnLegacyGenerate.Enabled = false;
                //btnInstallAlt.Enabled = false;
                btnRestore.Enabled = false;
            }
        }

        private void EnableExtraOption()
        {
            var enable = chkModDoubleLanguage.Checked;
            rdoModOriginFirst.Enabled = enable;
            rdoModTranslateFirst.Enabled = enable;

            rdoModTranslateFirst.Checked = !rdoModOriginFirst.Checked;
        }

        //private void ReadLocalVersion()
        //{
        //    lblModVersion.Text = c.ReadLocalVersion(modPath);
        //}

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
            //if (!c.BackupExists(Configs.BackupPath))
            //{
            //    c.ShowErrorMessage("ไม่พบแบ็คอัพ");
            //    return;
            //}

            if (c.ShowConfirmWarning("ต้องการลบ mod แปลภาษา?"))
                c.Processing(RemoveMod, "กำลังลบ", "ลบสำเร็จ");

            //EnableButton();

        }

        private void RemoveMod()
        {
            c.Backup(Configs.BackupPath, txtGamePath.Text, true, false);
            c.RemoveMod(txtGamePath.Text);
            c.InstallFontMod(txtGamePath.Text);

            //// remove font mod
            //if (c.CheckFontMod(txtGamePath.Text))
            //{
            //    if (c.ShowConfirm("ต้องการลบ font mod ด้วยหรือไม่?"))
            //        c.RemoveFont(txtGamePath.Text);

            //}
        }

        private void frmVerySimple_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default._SimpleDownloadFrequency = GetDownloadFrequency().ToString();
            Properties.Settings.Default._SimpleFontSetting = GetFontSetting().ToString();
            Properties.Settings.Default.Save();
        }

        private void txtGamePath_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }



        private void btnInstallAlt_Click(object sender, EventArgs e)
        {
            StartAlt();
        }

        private void StartAlt()
        {
            // download translate excel file
            translatePath = Path.Combine(Configs.DownloadPath, "translate.xlsx");
            translatePath = c.DownloadLegacyExcel(translatePath, false, GetDownloadFrequency());
            if (translatePath == null)
                return;

            // generate mod
            var result = c.Processing(GenerateModAlt, false, "กำลังสร้าง...");
            if (result != DialogResult.OK)
                return;

            // install mod
            result = c.Processing(InstallMod, false, "กำลังติดตั้ง");
            if (result != DialogResult.OK)
                return;


            c.ShowMessage("ติดตั้งสำเร็จ");
            EnableButton();
        }

        private void lblAdvance_Click(object sender, EventArgs e)
        {
            ToggleAdvance();
        }

        private void ToggleAdvance()
        {
            if (pnAdvance.Visible)
            {
                pnAdvance.Visible = false;
                this.Height -= pnAdvance.Height;
            }
            else
            {
                pnAdvance.Visible = true;
                this.Height += pnAdvance.Height;
            }

            ShowAdvance = pnAdvance.Visible;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            c.Open(resultPath);
        }

        private void txtGamePath_DoubleClick(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtGamePath);
        }

        private void miChangeLog_Click(object sender, EventArgs e)
        {
            c.Open(Configs.LogPath);
        }

        private void miUpdate_Click(object sender, EventArgs e)
        {
            var hasUpdate = c.CheckForUpdate();
            if (hasUpdate)
            {
                this.Close();
                c.UpdateW3tu();                
            }
            else
            {
                c.ShowMessage("ไม่พบอัพเดท");
            }
            
        }

        private void lblGameDir_DoubleClick(object sender, EventArgs e)
        {
            //if (Directory.Exists(txtGamePath.Text))
            //    c.Open(txtGamePath.Text);
            //else
            c.Open(Configs.StartupPath);
        }

        private Common.eFontSetting GetFontSetting()
        {
            if (rdoFontNone.Checked)
                return Common.eFontSetting.None;
            else if (rdoFontSizeLarge.Checked)
                return Common.eFontSetting.Large;
            else
                return Common.eFontSetting.Normal;
        }


        private Common.eDownloadFrequency GetDownloadFrequency()
        {
            if (rdoDownloadAlways.Checked)
                return Common.eDownloadFrequency.Always;
            else if (rdoDownloadHourly.Checked)
                return Common.eDownloadFrequency.Hour;
            else if (rdoDownloadDialy.Checked)
                return Common.eDownloadFrequency.Day;
            else
                return Common.eDownloadFrequency.Once;
        }

        private void SetDownloadFrequencyRadio()
        {
            Common.eDownloadFrequency frequency;
            var setting = Properties.Settings.Default._SimpleDownloadFrequency;
            if (!Enum.TryParse(setting, true, out frequency))
                frequency = Common.eDownloadFrequency.Hour;

            switch (frequency)
            {
                case Common.eDownloadFrequency.Always:
                    rdoDownloadAlways.Checked = true;
                    break;
                case Common.eDownloadFrequency.Day:
                    rdoDownloadDialy.Checked = true;
                    break;
                case Common.eDownloadFrequency.Hour:
                    rdoDownloadHourly.Checked = true;
                    break;
                case Common.eDownloadFrequency.Once:
                    rdoDownloadOnce.Checked = true;
                    break;
            }
        }

        private void SetFontRadio()
        {
            Common.eFontSetting font;
            var setting = Properties.Settings.Default._SimpleFontSetting;
            if (!Enum.TryParse(setting, true, out font))
                font = Common.eFontSetting.Normal;

            switch (font)
            {
                case Common.eFontSetting.None:
                    rdoFontNone.Checked = true;
                    break;
                case Common.eFontSetting.Large:
                    rdoFontSizeLarge.Checked = true;
                    break;
                default:
                    rdoFontSizeNormal.Checked = true;
                    break;
            }
        }
    }
}
