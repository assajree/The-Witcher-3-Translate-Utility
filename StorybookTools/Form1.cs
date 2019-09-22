using svvv;
using System;
using System.IO;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace StorybookTools
{
    public partial class Form1 : Form
    {
        Common c = new Common();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            c.DownloadLegacyExcel(
                Configs.TranslatePath,
                false,
                Common.eDownloadFrequency.Always
            );

            c.Processing(UpdateFile, "กำลังอัพเดทข้อความ", "สำเร็จ");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            c.Processing(GenerateMod, "กำลังเตรียมไฟล์", "สำเร็จ");
        }

        private void UpdateFile()
        {
            c.DeleteFile(Configs.StorybookExcelPath + ".bak");
            c.CopyFile(Configs.StorybookExcelPath,Configs.StorybookExcelPath + ".bak");
            c.FillStorybookExcel(
                Configs.StorybookExcelPath,
                Configs.TranslatePath,
                true,
                true,
                false
            );
        }

        private void GenerateMod()
        {
            c.GenerateStorybook(
                Configs.StorybookExcelPath,
                Path.Combine(Configs.ToolsPath, "ThaiStorybook", "modThaiStoryBook", "files")
            );

            c.Open(Path.Combine(Configs.ToolsPath, "ThaiStorybook"));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            c.Open(Configs.StorybookExcelPath);
        }
    }
}
