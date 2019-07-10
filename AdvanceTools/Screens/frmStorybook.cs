using System;
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

        private void txtFillTranslate_DoubleClick(object sender, EventArgs e)
        {
            c.Open(txtFillTranslate.Text);
        }

        private void txtFillTarget_DoubleClick(object sender, EventArgs e)
        {
            c.Open(txtFillTarget.Text);
        }

        private void btnFillTarget_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtFillTarget);
        }

        private void btnFillTranslate_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtFillTranslate);
        }

        private void btnFillStart_Click(object sender, EventArgs e)
        {
            try
            {
                c.FillStorybookExcel(
                    txtFillTarget.Text,
                    txtFillTranslate.Text,
                    chkFillMessage.Checked,
                    chkFillReplaceTranslated.Checked,
                    chkFillMessageAsTranslate.Checked
                );
                c.ShowMessage("Complete");
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void btnReadCommentInput_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtReadCommentInput);
        }

        private void btnStartReadComment_Click(object sender, EventArgs e)
        {
            try
            {
                string str = c.ReadStorybookComment(txtReadCommentInput.Text);
                txtReadCommentOutput.Text = str;
                c.ShowMessage("Complete");
            }
            catch(Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
        }

        private void btnClearTranslateInput_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtClearTranslatePath);
        }

        private void btnClearTranslateStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkClearAllSheet.Checked)
                {
                    if (c.ShowConfirm("Are you sure to clear ALL translate"))
                        c.ClearAllStorybookTranslate(txtClearTranslatePath.Text);
                    else
                        return;
                }
                else
                {
                    c.ClearStorybookTranslate(txtClearTranslatePath.Text);
                }

                c.ShowMessage("Complete");
            }
            catch (Exception ex)
            {
                c.ShowErrorMessage(ex);
            }
            
        }
    }
}
