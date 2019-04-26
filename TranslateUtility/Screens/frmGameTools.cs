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

namespace TranslateUtility
{
    /// <summary>
    /// game utility
    /// </summary>
    public partial class frmGameTools : Form
    {
        Common c = new Common();

        public frmGameTools()
        {
            InitializeComponent();
        }

        private void frmGameTools_Load(object sender, EventArgs e)
        {

        }

        private void frmGameTools_Shown(object sender, EventArgs e)
        {
            InitialScreen();
        }

        private void InitialScreen()
        {
            //string modPath = Path.Combine(Application.StartupPath, "thaimod");
            string backupPath = Path.Combine(Application.StartupPath, "backup");
            string gamePath = c.GetGameDirectory();

            // backup and restore
            txtBackupGamePath.SetDefault(gamePath);
            txtBackupPath.SetDefault(backupPath);

            // Language Mod
            txtLangDesc.SetDefault(gamePath);
            //txtLangSource.SetDefault(Path.Combine(Application.StartupPath, "download"));
            GetLocalVersion();

            // font
            txtFontModDesc.SetDefault(gamePath);
        }

        #region Language Mod

        private void GetLocalVersion()
        {
            if (Directory.Exists(txtLangSource.Text))
                lblLocalVersion.Text = c.ReadLocalVersion(txtLangSource.Text);
        }

        private void btnLangSource_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtLangSource);
            GetLocalVersion();
        }

        private void btnLangSourceOpen_Click(object sender, EventArgs e)
        {
            c.Open(txtLangSource.Text);
        }

        private void btnLangDesc_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtLangDesc);
        }

        private void btnCheckVersion_Click(object sender, EventArgs e)
        {
            GetLastestVersion();
        }

        private void GetLastestVersion()
        {
            var version = c.ProcessingString(c.GetModLastVersion, "Getting Version...", false);
            if (version != null)
            {
                lblLastedVersion.Text = version;
                lblLastCheck.Text = DateTime.Now.ToString("d MMM yyyy HH:mm:ss");
                SaveSetting();
            }
        }

        private void btnDownloadMod_Click(object sender, EventArgs e)
        {
            try
            {
                var downloadPath=c.SelectFolder(Configs.DownloadPath);
                if (downloadPath == null)
                    return;

                var result = c.DownloadMod(downloadPath, true,true);
                if (result != null)
                {
                    GetLocalVersion();
                    GetLastestVersion();
                    c.ShowMessage(result);

                    txtLangSource.Text = downloadPath;
                }
            }
            catch(Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void btnInstallLang_Click(object sender, EventArgs e)
        {
            c.Processing(InstallMod);
        }


        private void InstallMod()
        {
            if (!Directory.Exists(txtLangDesc.Text))
                Directory.CreateDirectory(txtLangDesc.Text);

            c.InstallMod(txtLangSource.Text, txtLangDesc.Text);

        }

        #endregion

        #region Backup and Restore

        private void btnBackupGamePath_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtBackupGamePath);
        }

        private void brnBackupPath_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtBackupPath);
        }

        private void btnBackupPathOpen_Click(object sender, EventArgs e)
        {
            c.Open(txtBackupPath.Text);
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            c.Processing(Backup);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            c.Processing(Restore);
        }


        private void Backup()
        {
            c.Backup(
                txtBackupGamePath.Text,
                txtBackupPath.Text,
                chkBackupOverwrite.Checked,
                true
            );
        }

        private void Restore()
        {
            c.Backup(
                txtBackupPath.Text,
                txtBackupGamePath.Text,
                true,
                false
            );
        }


        #endregion

        #region Font Mod

        private void btnFontModDesc_Click(object sender, EventArgs e)
        {
            c.SelectFolderTextBox(txtFontModDesc);
        }

        private void btnFontModInstall_Click(object sender, EventArgs e)
        {
            c.Processing(InstallFont);
        }

        private void btnFontModRemove_Click(object sender, EventArgs e)
        {
            c.Processing(RemoveFont);
        }

        private void InstallFont()
        {
            c.InstallFontMod(txtFontModDesc.Text);
        }

        private void RemoveFont()
        {
            c.RemoveOldFont(txtFontModDesc.Text);
        }
        #endregion

        private void frmGameTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSetting();
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.Save();
        }
    }
}
