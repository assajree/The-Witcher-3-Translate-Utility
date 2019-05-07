using svvv;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace Updater
{
    public partial class Form1 : Form
    {
        string w3tuPath, zipPath, extractPath, program1Path, program2Path;
        Common c = new Common();

        public Form1()
        {
            InitializeComponent();
            w3tuPath = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
            //MessageBox.Show(w3tuPath);
            zipPath = Path.Combine(Application.StartupPath, "w3tu.zip");
            extractPath = Path.Combine(Application.StartupPath, "w3u");
            program1Path = Path.Combine(w3tuPath, "w3tu.exe");
            program2Path = Path.Combine(w3tuPath, "TranslateUtility.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CheckProgramExist())
            {
                UpdateW3tu();
            }
            else
            {
                c.ShowErrorMessage("กรุณาอัพเดทจากโปรแกรมหลัก");
            }

            this.Close();
        }

        private bool CheckProgramExist()
        {
            return File.Exists(program1Path) || File.Exists(program2Path);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.Processing(RunW3tu, false, "กำลังเปิดโปรแกรม");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            UpdateW3tu();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void UpdateW3tu()
        {
            //if (!NeedUpdate())
            //    return;

            if (!c.DownloadGoogleFile(Configs.UpdateFileId, zipPath))
            {
                c.ShowErrorMessage("การอัพเดทถูกยกเลิก");
                return;
            }

            c.Processing(ExtractUpdate, false, "กำลังเตรียมไฟล์");
        }

        private void RunW3tu()
        {
            
            if (File.Exists(program1Path))
                c.Open(program1Path);
            else if(File.Exists(program2Path))
                c.Open(program2Path);
        }

        private void ExtractUpdate()
        {
            c.ExtractFile(zipPath, extractPath);
            c.CopyDirectory(extractPath, w3tuPath);
        }

        private bool NeedUpdate()
        {
            var lastVersion = c.GetLastVersion();
            if (lastVersion == null)
                return false;

            var localVersion = c.ReadLocalVersion(w3tuPath);

            return localVersion != lastVersion;
        }
    }
}
