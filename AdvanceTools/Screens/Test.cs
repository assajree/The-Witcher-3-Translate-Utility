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

namespace AdvanceTools.Screens
{
    public partial class Test : Form
    {

        Common c = new Common();
        Setting setting = new Setting();

        public Test()
        {
            InitializeComponent();
        }

        private void btnDownloadSheet_Click(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            var excelPath = Path.Combine(Configs.DownloadPath, "translate.xlsx");
            DownloadTranslateFile(excelPath);
            DownloadWebTranslateFile();
            Compare(excelPath);
        }

        private void Compare(string excelPath)
        {
            var sheetConfig = setting.GetSheetConfig();
            var excelLegacy = c.ReadExcelLegacy(excelPath, sheetConfig);
            var excelTemplate = c.ReadExcel(Configs.TemplateFilePath, sheetConfig, true);
            var excelData = c.MergeLegacy(excelTemplate, excelLegacy);
            var sheetData = c.DistinctMessage(excelData);
            var jsonData = c.ReadWebJson(Configs.WebTranslatePath);          

            var notTranslateKey = jsonData.Where(d => d.Value.IsTranslate == false).Select(d => d.Value.Key).ToList();
            var diff = sheetData.Where(d =>
                              notTranslateKey.Contains(d.Key) &&
                              d.Value.TranslateStatus > w3Strings.eTranslateStatus.SameWord
                        ).Select(d => d.Value).ToList();

            c.ShowMessage($@"diff {diff.Count}");
        }

        private void DownloadWebTranslateFile()
        {
            var newVersion = c.GetNewVersion(Common.eDownloadFrequency.Day);
            if (newVersion != null)
            {
                if (newVersion == "UNKNOW")
                    newVersion = c.ReadUrl(Configs.WebTranslateVersionUrl, 0)?.Trim();

                c.DownloadWebTranslateFile(newVersion);
            }
        }

        private void DownloadTranslateFile(string translatePath)
        {
            c.DownloadLegacyExcel(translatePath, false, Common.eDownloadFrequency.Day);
        }
    }
}
