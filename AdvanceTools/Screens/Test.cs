using Newtonsoft.Json;
using svvv;
using svvv.Classes;
using svvv.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace AdvanceTools.Screens
{
    public partial class Test : Form
    {

        Common c = new Common();
        Setting setting = new Setting();
        ManualLog logger = new ManualLog();

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

            var notTranslateJson = jsonData.Where(d => d.Value.IsTranslate == false).ToDictionary(j => j.Value.Key, j => j.Value);
            var notTranslateKey = notTranslateJson.Select(d => d.Key).ToList();

            var diff = sheetData.Where(d =>
                              notTranslateKey.Contains(d.Key) &&
                              d.Value.TranslateStatus > w3Strings.eTranslateStatus.SameWord
                        ).Select(d => d.Value).ToList();

            var result = new List<W2Strings>();
            foreach (var item in diff)
            {
                if (!notTranslateJson.ContainsKey(item.IdKey))
                    continue;

                var msg = notTranslateJson[item.IdKey];
                msg.Translate = item.Translate;
                result.Add(msg);

            }

            var content = result.ToDictionary(r => r.Index.ToString(), r => r);
            c.WriteJson(content, Path.Combine(Configs.OutputPath, "diff.json"));

            //var json = JsonConvert.SerializeObject(content);
            //c.WriteJson(json, Path.Combine(Configs.OutputPath, "diff.json"));

            c.ShowMessage($@"diff {diff.Count}");

            if (diff.Count > 0)
                c.Open(Configs.OutputPath);
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            logger.InfoFormat("test");
            logger.InfoFormat("test with {0}", "param");
            logger.ErrorFormat("error with {0}", "param");
            logger.ErrorFormat("error without param {0}");
            logger.ErrorFormat("error without mark", "param");
        }
    }
}
