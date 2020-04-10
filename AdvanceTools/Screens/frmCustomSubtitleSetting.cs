using svvv;
using svvv.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace TranslateUtility.Screens
{
    public partial class frmCustomSubtitleSetting : Form
    {
        Common c = new Common(); 
        AppSetting mAppSetting;

        public frmCustomSubtitleSetting()
        {
            InitializeComponent();
        }

        public frmCustomSubtitleSetting(AppSetting setting) : this()
        {
            mAppSetting = setting;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //mAppSetting.SetFileId(txtFileId.Text.Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmCustomSubtitleSetting_Load(object sender, EventArgs e)
        {
            //if (mAppSetting != null)
            //    txtFileId.Text = mAppSetting.GamePath;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //txtFileId.Text = Configs.DefaultCustomTranslateFileId;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            c.OpenGoogleSheet(txtFileId.Text.Trim());
        }
    }
}
