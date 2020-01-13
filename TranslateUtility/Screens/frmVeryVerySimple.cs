using svvv;
using svvv.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;
using TranslateUtility.Screens;

namespace TranslateUtility
{
    public partial class frmVeryVerySimple : Form
    {
        Common c = new Common();
        Setting setting = new Setting();
        string modPath = null;
        string resultPath = null;
        string translatePath = null;
        AppSetting mAppSetting = new AppSetting(Configs.SettingPath);
        readonly Color mDefaultButtonColor = Color.FromArgb(255, 0, 120, 215);

        int mHeightCollapse = Constant.SIZE_DEFAULT_COLLASPE;
        int mHeightExpand = Constant.SIZE_DEFAULT_EXPAND;

        bool AdvanceMode
        {
            get
            {
                return pnAdvance.Visible;
                //return Properties.Settings.Default._SimpleShowAdvance;
            }
            //set
            //{
            //    Properties.Settings.Default._SimpleShowAdvance = value;
            //}

        }

        public frmVeryVerySimple()
        {
            InitializeComponent();
        }

        private void frmVerySimple_Load(object sender, EventArgs e)
        {
            InitialScreen();
            InitialTooTip();
            //ReadCustomTranslateDescription();


            //DownloadRequireComponent();

            //CheckForUpdate(false, false, false);

        }

        private void frmVeryVerySimple_Shown(object sender, EventArgs e)
        {
            //mExpandHeight = this.Height;           
            CheckForUpdate(false);
        }

        //private void ReadCustomTranslateDescription()
        //{
        //    chkAltSub.Text = c.GetCustomTranslateDescription();
        //}

        private void DownloadRequireComponent()
        {
            // update storybook
            if (!File.Exists(Configs.StorybookVersionPath))
                c.UpdateStorybook();

            // update template
            if (!File.Exists(Configs.TemplateVersionPath))
                c.UpdateTemplate();
        }

        private void UpdateProgram()
        {
            this.Close();
            c.UpdateW3tu();
        }

        private void InitialTooTip()
        {
            toolTip1.SetToolTip(rdoDownloadAlways, "ดาวน์โหลดทุกครั้ง");
            toolTip1.SetToolTip(rdoDownloadDialy, "ดาวน์โหลดเมื่อผ่านไป 1 วัน จากการดาวน์โหลดครั้งที่แล้วเท่านั้น");
            //toolTip1.SetToolTip(rdoDownloadAlt, "ดาวน์โหลดเมื่อผ่านไป 1 ชั่วโมง จากการดาวน์โหลดครั้งที่แล้วเท่านั้น");
            toolTip1.SetToolTip(rdoDownloadAlt, "ใช้ไฟล์แปลภาษาทางเลือก สำหรับคนที่ติดตั้งม็อดแล้วไม่เป็นภาษาไทย");

            toolTip1.SetToolTip(rdoDownloadOnce, "ดาวน์โหลดเมื่อไม่มีไฟล์แปลภาษาเท่านั้น");
            toolTip1.SetToolTip(chkChangeTextColor, "เปลี่ยนสีชื่อในซับไตเติ้ล");
            //toolTip1.SetToolTip(chkOldMethod, $@"มีโอกาสติด Lucky {Constant.CRACK_LUCKY_CHANCE}%");
            toolTip1.SetToolTip(chkOldMethod, "ติดตั้งม็อดบนภาษาอังกฤษ ไม่มีการแปลคัทซีน");
            toolTip1.SetToolTip(chkBackupSetting, "สำรองการตั้งค่าของเกมก่อนติดตั้งม็อด");
            //toolTip1.SetToolTip(chkRandomLoading, $@"จาก {c.GetLoadingMessageList().Count} ข้อความ");

            toolTip1.SetToolTip(rdoNormalCompatibility, "อาจเข้ากับม็อดบางอย่างไม่ได้ แต่ใช้ฟังก์ชัันของม็อดภาษาไทยได้เต็มที่");
            toolTip1.SetToolTip(rdoMediumCompatibility, "เพิ่มความเข้ากันได้กับม็อดอื่น แต่ไม่เหมาะกับออปชั่นสองภาษา \nไฟล์ที่ตัดออก \n-hudModuleOneliners.ws \n-hudModuleQuests.ws");
            toolTip1.SetToolTip(rdoHighCompatibility, "เข้ากันได้กับทุกม็อด แต่ไม่เหมาะกับออปชั่นสองภาษาและปรับขนาดฟอนต์ไม่ได้ \nไฟล์ที่ตัดออก \n-hudModuleOneliners.ws \n-hudModuleQuests.ws \n-hudModuleDialog.ws \n-hudModuleSubtitles.ws");
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
            miVersion.Text = $@"V. {c.GetVersionText(version)}";

            //ReadLocalVersion();
            EnableExtraOption();
            EnableButton();

            // install
            Configs.IsGamer = true;
            //var gamePath = c.GetGameDirectory();
            //Configs.IsGamer = !String.IsNullOrWhiteSpace(gamePath);
            //txtGamePath.SetDefault(gamePath);

            //if (!Configs.IsGamer)
            //{
            //    this.Text += "v";
            //}

            LoadSetting();

            SaveAppSetting();
            RefreshCustomTranslateCount();

        }

        private void RefreshCustomTranslateCount()
        {
            var custom = new CustomTranslateSetting(Configs.CustomTranslateSettingPath, setting.GetCustomTranslate());
            var count = custom.Value.Values.Where(v => v.Enable).ToList().Count;
            lblCustomTranslateCount.Text = $@"ไฟล์ปรับแต่งที่เปิดใช้งาน : {count:#,0}/{custom.Value.Count}";
        }

        private void LoadSetting()
        {
            if (!mAppSetting.AdvanceMode)
                HideAdvance();
            else
                ShowAdvance();

            chkModDoubleLanguage.Checked = mAppSetting.DoubleLanguage;
            chkExcludeUiText.Checked = mAppSetting.EnglishUi;
            chkOldMethod.Checked = mAppSetting.OldMethod;
            chkBackupSetting.Checked = mAppSetting.BackupSetting;
            //chkRandomLoading.Checked = mAppSetting.RandomLoading;
            chkStorybook.Checked = mAppSetting.TranslateStorybook;
            //chkAltSub.Checked = mAppSetting.AlternativeSubtitle;

            if (mAppSetting.ThaiFirst)
                rdoModTranslateFirst.Checked = true;
            else
                rdoModOriginFirst.Checked = true;

            chkUntranslateInfo.Checked = mAppSetting.ShowNotTranslateRow;
            chkTranslateInfo.Checked = mAppSetting.ShowTranslateRow;
            chkUiInfo.Checked = mAppSetting.ShowUiRow;
            chkChangeTextColor.Checked = mAppSetting.ChangeTextColor;
            txtFontSizeCutScene.Value = mAppSetting.SizeCutscene;
            txtFontSizeSpeak.Value = mAppSetting.SizeDialog;

            //if (String.IsNullOrWhiteSpace(txtGamePath.Text))
            //{
                txtGamePath.Text = mAppSetting.GamePath;
            //}

            if (String.IsNullOrWhiteSpace(txtGamePath.Text))
            {
                var gamePath = c.GetGameDirectory();
                txtGamePath.SetDefault(gamePath);
            }

            //mHeightCollapse = mAppSetting.CollaspeHeight;
            //mHeightExpand = mAppSetting.ExpandHeight;


            SetDownloadFrequencyRadio();
            SetFontRadio();
            SetCompatibilityLevel();
        }

        private void lblModVersion_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnLegacyGenerate_Click(object sender, EventArgs e)
        {
            //SaveAppSetting();
            Logger.StartNewLog();
            StartAlt();
        }

        //private void Start()
        //{
        //    // download translate excel file
        //    translatePath = Path.Combine(Configs.DownloadPath, "translate.xlsx");
        //    translatePath = c.DownloadLegacyExcel(translatePath, false, GetDownloadFrequency());
        //    if (translatePath == null)
        //        return;

        //    // generate mod
        //    var result = c.Processing(GenerateMod, false, "กำลังสร้าง...");
        //    if (result != DialogResult.OK)
        //        return;

        //    // install mod
        //    result = c.Processing(InstallMod, false, "กำลังติดตั้ง");
        //    if (result != DialogResult.OK)
        //        return;

        //    c.ShowMessage("ติดตั้งสำเร็จ");
        //    EnableButton();
        //}

        //private void GenerateMod()
        //{
        //    c.GenerateLegacyMod(
        //        translatePath,
        //        modPath,
        //        chkModDoubleLanguage.Checked,
        //        rdoModOriginFirst.Checked,
        //        chkUntranslateInfo.Checked,
        //        chkUiInfo.Checked,
        //        chkTranslateInfo.Checked,
        //        !chkExcludeUiText.Checked
        //    );

        //}

        private void GenerateModAlt()
        {
            Logger.Log("Generate mod");
            c.GenerateLegacyModAlt(
                translatePath,
                modPath,
                chkModDoubleLanguage.Checked,
                rdoModOriginFirst.Checked,
                chkUntranslateInfo.Checked,
                chkTranslateInfo.Checked,
                chkUiInfo.Checked,
                GetFontSetting(),
                !chkExcludeUiText.Checked,
                true // chkAltSub.Checked
            );

            Logger.Log("Change font size");
            c.ChangeFontSize(
                Path.Combine(modPath, Configs.modThaiLanguage),
                (int)txtFontSizeCutScene.Value,
                (int)txtFontSizeSpeak.Value
            );

            if (!chkChangeTextColor.Checked)
                c.ResetTextColor(Path.Combine(modPath, Configs.modThaiLanguage));

            if (!chkOldMethod.Checked)
            {
                // change to tr
                c.UpgradeToFullTranslate(Path.Combine(modPath, Configs.modThaiLanguage));

                // install storybook
                if(chkStorybook.Checked)
                    c.InstallModStoryBook(Configs.StorybookPath, Path.Combine(modPath, Configs.modThaiLanguage));
            }
        }

        private void InstallMod()
        {
            Logger.Log("Install mod");
            c.InstallMod(
                modPath,
                txtGamePath.Text,
                !rdoFontNone.Checked
            );

            var trPath = Path.Combine(txtGamePath.Text, "mods", Configs.modThaiLanguage, "content", "tr.w3strings");
            if (File.Exists(trPath))
            {
                c.MigrateOtherModToTr(Path.Combine(txtGamePath.Text, "mods"));
                c.MigrateOtherModToTr(Path.Combine(txtGamePath.Text, "dlc"));
                c.ChangeLanguageSettingToTR();
            }
            else
            {
                c.ChangeLanguageSettingToEN();
            }

            c.MigrateW3ee(txtGamePath.Text);

        }

        //private void Backup(bool overwrite)
        //{
        //    c.Backup(txtGamePath.Text, Configs.BackupPath, overwrite, true);
        //}

        private void EnableButton()
        {
            // result button
            btnResult.Enabled = File.Exists(resultPath);
            btnMessageFinder.Enabled = btnResult.Enabled;
            SetButtonText();

            // install button && restore button
            if (c.IsValidGamePath(txtGamePath.Text))
            {
                btnLegacyGenerate.Enabled = true;
                btnFixMod.Enabled = true;
                //btnInstallAlt.Enabled = true;
                btnRestore.Enabled = true;
            }
            else
            {
                btnLegacyGenerate.Enabled = false;
                btnFixMod.Enabled = false;
                //btnInstallAlt.Enabled = false;
                btnRestore.Enabled = false;
            }

            if (btnResult.Enabled && btnLegacyGenerate.Enabled)
            {
                btnInstallFont.Enabled = true;
                btnChangeFontSize.Enabled = true;
            }
            else
            {
                btnInstallFont.Enabled = false;
                btnChangeFontSize.Enabled = false;
            }

            // set button color
            if (btnLegacyGenerate.Enabled)
                btnLegacyGenerate.BackColor = mDefaultButtonColor;
            else
                btnLegacyGenerate.BackColor = Color.LightGray;
        }

        private void SetButtonText()
        {
            if (Directory.Exists(Path.Combine(txtGamePath.Text, "mods", Configs.modThaiLanguage)))
            {
                btnLegacyGenerate.Text = "อัปเดต";
            }
            else
            {
                btnLegacyGenerate.Text = "ติดตั้ง";
            }
        }

        private void EnableExtraOption()
        {
            var enable = chkModDoubleLanguage.Checked;
            rdoModOriginFirst.Enabled = enable;
            rdoModTranslateFirst.Enabled = enable;

            if (!enable)
                rdoModTranslateFirst.Checked = true;

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
            SaveAppSetting();
            //c.Backup(Configs.BackupPath, txtGamePath.Text, true, false);
            c.RemoveMod(txtGamePath.Text);
            c.ChangeLanguageSettingToEN();
            //c.InstallFontMod(txtGamePath.Text);

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
            SaveAppSetting();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default._SimpleDownloadFrequency = GetDownloadFrequency().ToString();
            Properties.Settings.Default._SimpleFontSetting = GetFontSetting().ToString();
            Properties.Settings.Default.Save();
        }

        private void SaveAppSetting()
        {
            mAppSetting.AdvanceMode = AdvanceMode;
            mAppSetting.DoubleLanguage = chkModDoubleLanguage.Checked;
            mAppSetting.EnglishUi = chkExcludeUiText.Checked;
            mAppSetting.OldMethod = chkOldMethod.Checked;
            mAppSetting.BackupSetting = chkBackupSetting.Checked;
            //mAppSetting.RandomLoading = chkRandomLoading.Checked;
            mAppSetting.TranslateStorybook = chkStorybook.Checked;
            //mAppSetting.AlternativeSubtitle = chkAltSub.Checked;
            mAppSetting.ThaiFirst = rdoModTranslateFirst.Checked;
            mAppSetting.ShowNotTranslateRow = chkUntranslateInfo.Checked;
            mAppSetting.ShowTranslateRow = chkTranslateInfo.Checked;
            mAppSetting.ShowUiRow = chkUiInfo.Checked;
            mAppSetting.ChangeTextColor = chkChangeTextColor.Checked;
            mAppSetting.FontSetting = GetFontSetting();
            mAppSetting.SizeCutscene = (int)txtFontSizeCutScene.Value;
            mAppSetting.SizeDialog = (int)txtFontSizeSpeak.Value;
            mAppSetting.DownloadFrequency = GetDownloadFrequency();
            mAppSetting.GamePath = txtGamePath.Text;
            mAppSetting.ExpandHeight = mHeightExpand;
            mAppSetting.CollaspeHeight = mHeightCollapse;
            mAppSetting.CompatibilityLevel = GetCompatibilityLevel();
            mAppSetting.AlternativeDownload = rdoDownloadAlt.Checked;

            mAppSetting.SaveSetting();
            Logger.Log($@"Save setting.{Environment.NewLine}{mAppSetting.ToString()}");
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
            SaveAppSetting();

            bool oldMethod = chkOldMethod.Checked;

            if (!oldMethod)
                c.UpdateStorybook();

            c.UpdateTemplate();

            //if (chkAltSub.Checked)
            //{
            Logger.Log("Download custom translate");
            c.Processing(DownloadAllCustomTranslateFile, false, "กำลังดาวน์โหลดไฟล์แปลภาษาแบบปรับแต่ง...");
            //}

            // download translate excel file
            Logger.Log("Download main translate");
            var downloadResult = c.Processing(DownloadTranslateFile, false, "กำลังดาวน์โหลดไฟล์แปลภาษา...");
            if (downloadResult != DialogResult.OK)
                return;

            // generate mod
            if (translatePath == null)
                return;

            Logger.Log("Start generate mod");
            var result = c.Processing(GenerateModAlt, false, "กำลังสร้างม็อด...");
            if (result != DialogResult.OK)
                return;

            c.ChangeCompatibilityLevel(modPath, GetCompatibilityLevel());

            // install mod
            Logger.Log("Start install mod");
            result = c.Processing(InstallMod, false, "กำลังติดตั้ง");
            if (result != DialogResult.OK)
                return;


            Logger.Log("Finish");
            c.ShowMessage("ติดตั้งสำเร็จ");

            // reset download frequency
            if(rdoDownloadAlways.Checked)
                rdoDownloadDialy.Checked = true;

            c.AddGenerateCounter();
            EnableButton();
        }

        private void DownloadAllCustomTranslateFile()
        {
            c.DownloadAllCustomTranslateFile(GetDownloadFrequency());
        }

        //private void DownloadCustomTranslateFile()
        //{
        //    c.DownloadCustomTranslateFile(GetDownloadFrequency());
        //    ReadCustomTranslateDescription();
        //}

        private void DownloadTranslateFile()
        {
            if (rdoDownloadAlt.Checked)
            {
                translatePath = Path.Combine(Configs.DownloadPath, "translate_alt.xlsx");
                if (c.CheckVersion(Configs.AltTranslateVersion, Configs.AltTranslateVersionFileId))
                {                    
                    if (c.DownloadGoogleSheetFile(Configs.AltTranslateFileId, translatePath))
                        c.WriteVersion(Configs.AltTranslateVersion, Configs.AltTranslateVersionFileId);
                }
            }
            else
            {
                translatePath = Path.Combine(Configs.DownloadPath, "translate.xlsx");
                translatePath = c.DownloadLegacyExcel(translatePath, false, GetDownloadFrequency());
            }
        }

        private void lblAdvance_Click(object sender, EventArgs e)
        {
            ToggleAdvance();
        }

        private void ToggleAdvance()
        {
            if (pnAdvance.Visible)
            {
                HideAdvance();

            }
            else
            {
                ShowAdvance();
            }

            //AdvanceMode = pnAdvance.Visible;

            //ShowAdvance = pnAdvance.Visible;

            //Debug();
        }

        private void ShowAdvance()
        {
            //mHeightCollapse = this.Height;
            if (Screen.PrimaryScreen.Bounds.Height < mHeightExpand)
                this.Height = Math.Min(Constant.SIZE_MINI_EXPAND, Screen.PrimaryScreen.Bounds.Height);
            else
                this.Height = mHeightExpand;

            //if (Screen.PrimaryScreen.Bounds.Height < mHeightExpand)
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    this.Height = mHeightExpand;
            //}

            pnAdvance.Visible = true;
        }

        private void HideAdvance()
        {
            // un-maximize
            this.WindowState = FormWindowState.Normal;
            //this.Width = this.DefaultMinimumSize.Width;

            pnAdvance.Visible = false;
            //mHeightExpand = this.Height;

            //this.Height -= pnAdvance.Height;
            this.Height = mHeightCollapse;
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
            //CheckForUpdate(true, true, true);
            CheckForUpdate(true);
        }

        //private void CheckForUpdate(bool isUpdateComponent, bool isForceUpdate, bool isShowMessage)
        private void CheckForUpdate(bool isManualCheck)
        {
            if (isManualCheck)
            {
                c.UpdateTemplate();
                c.UpdateStorybook();
            }

            var hasUpdate = c.CheckForUpdate();
            if (hasUpdate)
            {
                if (isManualCheck || c.ShowConfirm("มีโปรแกรมเวอร์ชั่นใหม่ ต้องการดาวน์โหลดหรือไม่", "อัพเดท"))
                {
                    UpdateProgram();
                }
            }
            else
            {
                if (isManualCheck)
                    c.ShowMessage("โปรแกรมเป็นเวอร์ชั่นล่าสุดแล้ว");
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

            else if (rdoFontPrompt.Checked)
                return Common.eFontSetting.Prompt;

            else if (rdoFontCsPrakas.Checked)
                return Common.eFontSetting.CSPraKas;

            else if (rdoFontMahaniyom.Checked)
                return Common.eFontSetting.Mahaniyom;

            else if (rdoFontSrisakdi.Checked)
                return Common.eFontSetting.Srisakdi;

            else if (rdoFontSuperMarket.Checked)
                return Common.eFontSetting.SuperMarket;

            else
                return Common.eFontSetting.Sarabun;

        }


        private Common.eDownloadFrequency GetDownloadFrequency()
        {
            if (rdoDownloadAlways.Checked)
                return Common.eDownloadFrequency.Always;

            //else if (rdoDownloadAlt.Checked)
            //    return Common.eDownloadFrequency.Hour;

            else if (rdoDownloadOnce.Checked)
                return Common.eDownloadFrequency.Once;

            else if (rdoDownloadDialy.Checked)
                return Common.eDownloadFrequency.Day;

            else
                return Common.eDownloadFrequency.Day;
        }

        private Common.eCompatibilityLevel GetCompatibilityLevel()
        {
            if (rdoMediumCompatibility.Checked)
                return Common.eCompatibilityLevel.Medium;

            else if (rdoHighCompatibility.Checked)
                return Common.eCompatibilityLevel.High;

            else
                return Common.eCompatibilityLevel.Normal;
        }

        private void SetDownloadFrequencyRadio()
        {
            //Common.eDownloadFrequency frequency;
            //var setting = Properties.Settings.Default._SimpleDownloadFrequency;
            //if (!Enum.TryParse(setting, true, out frequency))
            //    frequency = Common.eDownloadFrequency.Hour;
            var frequency = mAppSetting.DownloadFrequency;
            switch (frequency)
            {
                case Common.eDownloadFrequency.Always:
                    rdoDownloadAlways.Checked = true;
                    break;
                case Common.eDownloadFrequency.Day:
                    rdoDownloadDialy.Checked = true;
                    break;
                //case Common.eDownloadFrequency.Hour:
                //    rdoDownloadAlt.Checked = true;
                //    break;
                case Common.eDownloadFrequency.Once:
                    rdoDownloadOnce.Checked = true;
                    break;
            }

            if (mAppSetting.AlternativeDownload)
                rdoDownloadAlt.Checked = true;
        }

        private void SetCompatibilityLevel()
        {
            var val = mAppSetting.CompatibilityLevel;
            switch (val)
            {
                case Common.eCompatibilityLevel.Normal:
                    rdoNormalCompatibility.Checked = true;
                    break;
                case Common.eCompatibilityLevel.Medium:
                    rdoMediumCompatibility.Checked = true;
                    break;
                case Common.eCompatibilityLevel.High:
                    rdoHighCompatibility.Checked = true;
                    break;
            }
        }

        private void SetFontRadio()
        {
            //Common.eFontSetting font;
            //var setting = Properties.Settings.Default._SimpleFontSetting;
            //if (!Enum.TryParse(setting, true, out font))
            //    font = Common.eFontSetting.Sarabun;

            var font = mAppSetting.FontSetting;

            switch (font)
            {
                case Common.eFontSetting.None:
                    rdoFontNone.Checked = true;
                    break;

                case Common.eFontSetting.CSPraKas:
                    rdoFontCsPrakas.Checked = true;
                    break;

                case Common.eFontSetting.Prompt:
                    rdoFontPrompt.Checked = true;
                    break;

                case Common.eFontSetting.Mahaniyom:
                    rdoFontMahaniyom.Checked = true;
                    break;

                case Common.eFontSetting.Srisakdi:
                    rdoFontSrisakdi.Checked = true;
                    break;

                case Common.eFontSetting.SuperMarket:
                    rdoFontSuperMarket.Checked = true;
                    break;

                default:
                    rdoFontSarabun.Checked = true;
                    break;
            }
        }

        private void miCredit_Click(object sender, EventArgs e)
        {
            var credit = new frmCredit();
            credit.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //CheckForUpdate(true, true, true);
            CheckForUpdate(true);
        }

        private void btnMessageFinder_Click(object sender, EventArgs e)
        {
            OpenMessageFinder();
        }

        private void OpenMessageFinder()
        {
            var frm = new frmMessageFinder();
            OpenForm(frm);
        }

        private void OpenForm(Form frm)
        {
            this.Hide();
            frm.Closed += OnChildClosed;
            var result = frm.ShowDialog();
            if (result != DialogResult.OK)
                this.Close();
        }

        private void OnChildClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void miTranslateProgress_Click(object sender, EventArgs e)
        {
            c.Open(resultPath);
        }

        private void miMessageFinder_Click(object sender, EventArgs e)
        {
            OpenMessageFinder();
        }

        private void btnAltSubDownload_Click(object sender, EventArgs e)
        {
            //c.Processing(UpdateCustomTranslate, "กำลังโหลดไฟล์แปลภาษาแบบปรับแต่ง");
        }

        //private void UpdateCustomTranslate()
        //{
        //    if (String.IsNullOrWhiteSpace(Configs.CustomTranslateFileId))
        //    {
        //        c.ShowMessage("ไม่ได้ตั้งค่า");
        //        return;
        //    }

        //    c.DownloadCustomTranslateFile(Common.eDownloadFrequency.Always);
        //    ReadCustomTranslateDescription();
        //}

        private void btnAltSubSetting_Click(object sender, EventArgs e)
        {
            var dlg = new frmCustomTranslateSetting();
            dlg.ShowDialog();
            RefreshCustomTranslateCount();
        }

        private void btnFixMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (c.ShowConfirm("มีม็อดที่แสดงข้อความไม่ถูกต้องหรือข้อความหายใช่หรือไม่?"))
                {
                    c.MigrateOtherModToTr(Path.Combine(txtGamePath.Text, "mods"));
                    c.MigrateOtherModToTr(Path.Combine(txtGamePath.Text, "dlc"));
                    c.MigrateW3ee(txtGamePath.Text);
                    c.ShowMessage("สำเร็จ");
                }
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void SetFontSize(int size)
        {
            txtFontSizeCutScene.Value = size;
            txtFontSizeSpeak.Value = size;
        }

        private void btnInstallFont_Click(object sender, EventArgs e)
        {
            c.Processing(InstallFont, "กำลังติดตั้งฟอนต์", "สำเร็จ");
        }

        private void InstallFont()
        {
            var modPath = Path.Combine(txtGamePath.Text, "mods");
            c.InstallFontMod(GetFontSetting(), modPath);
        }

        private void ChangeFontSize()
        {
            var modPath = Path.Combine(txtGamePath.Text, "mods");
            c.InstallSubtitleMod(modPath);
            c.ChangeFontSize(
                Path.Combine(modPath, Configs.modThaiLanguage),
                (int)txtFontSizeCutScene.Value,
                (int)txtFontSizeSpeak.Value
            );

            if (!chkChangeTextColor.Checked)
                c.ResetTextColor(Path.Combine(modPath, Configs.modThaiLanguage));
        }

        private void btnChangeFontSize_Click(object sender, EventArgs e)
        {
            c.Processing(ChangeFontSize, "กำลังปรับขนาดซับไตเติ้ล", "สำเร็จ");
        }

        private void btnSizeReset_Click(object sender, EventArgs e)
        {
            SetFontSize(28);
        }

        private void btnSizeRecommend_Click(object sender, EventArgs e)
        {
            SetFontSize(34);
        }

        private void Debug()
        {
            miDebug.Text = $@"{this.Height} x {this.Width}";
        }

        private void miDebug_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            c.ShowMessage("ปรับขนาดได้แล้ว :)");
        }

        private void miVersion_Click(object sender, EventArgs e)
        {
            Debug();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.GetGogPath();
        }

        private void miLog_Click(object sender, EventArgs e)
        {
            c.Open(Logger.GetLogPath());
        }

        private void lblGameDir_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                c.Open(Configs.StartupPath);

        }

        private void rdoNormalCompatibility_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCompatibilityLevel();
        }

        private void rdoMediumCompatibility_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCompatibilityLevel();
        }

        private void rdoHighCompatibility_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCompatibilityLevel();
        }

        private void ChangeCompatibilityLevel()
        {
            var level = GetCompatibilityLevel();

            if (level >= Common.eCompatibilityLevel.Medium)
            {
                chkModDoubleLanguage.Checked = false;
            }

            btnChangeFontSize.Enabled = level < Common.eCompatibilityLevel.High;

        }

        /// <summary>
        /// handle maximize state
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
                // window un-maximize
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    ShowAdvance();
                }

                // window un-maximize
                else if (m.WParam == new IntPtr(0xF120))
                {

                    HideAdvance();
                }
            }
            base.WndProc(ref m);
        }
    }
}
