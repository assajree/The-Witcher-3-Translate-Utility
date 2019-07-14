using Gameloop.Vdf;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using OfficeOpenXml;
using svvv;
using svvv.Classes;
using Svvv.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using TheWitcher3Thai.Helper;

namespace TheWitcher3Thai
{
    public class Common
    {
        public enum eDownloadFrequency
        {
            Hour,
            Day,
            Always,
            Once
        }

        public enum eFontSetting
        {
            Sarabun,
            KoonToon,
            None
        }

        private Setting setting = new Setting();

        const string STORYBOOK_SHEET_NAME = "Cinematics ALL";
        const int ROW_STORYBOOK_START = 3;
        const int COL_STORYBOOK_MESSAGE = 3;
        const int COL_STORYBOOK_TRANSLATE = 4;
        const int ROW_STORYBOOK_START_LEGACY = 5;
        const int COL_STORYBOOK_MESSAGE_LEGACY = 1;
        const int COL_STORYBOOK_TRANSLATE_LEGACY = 3;

        #region Decode

        public void DecodeDirectory(string path)
        {
            DirectoryInfo originalDirectory = new DirectoryInfo(path);
            DecodeDirectory(originalDirectory);
        }

        public void OpenGoogleSheet(string fileId)
        {
            Open($@"https://docs.google.com/spreadsheets/d/{fileId}/edit");
        }

        public void DecodeDirectory(DirectoryInfo directory)
        {
            foreach (var file in directory.GetFiles())
            {
                if (file.Extension == ".w3strings")
                {
                    DecodeW3String(file.FullName);
                }
            }

            foreach (var subdirectory in directory.GetDirectories())
            {
                DecodeDirectory(subdirectory);
            }

        }

        public void DecodeW3String(string filePath)
        {
            string w3sPath = Path.Combine(Application.StartupPath, "Tools", "w3strings.exe");
            string strCmdText = $@"--decode ""{filePath}""";

            CallConsoleApp(w3sPath, strCmdText);
        }

        public void DonatePaypal()
        {
            string url = "";

            string business = "M8L7PEDZVW8S6";  // your paypal email
            string description = "Donation for The Witcher 3 Translator Tool";            // '%20' represents a space. remember HTML!
            string country = "TH";                  // AU, US, etc.
            string currency = "THB";                 // AUD, USD, etc.

            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";

            System.Diagnostics.Process.Start(url);
        }

        #endregion

        #region Endcode

        public void EncodeDirectory(string path)
        {
            DirectoryInfo originalDirectory = new DirectoryInfo(path);
            EncodeDirectory(originalDirectory);
        }

        public void EncodeDirectory(DirectoryInfo directory)
        {
            foreach (var file in directory.GetFiles())
            {
                if (file.Extension == ".csv")
                {
                    EncodeW3String(file.FullName);
                }
            }

            //foreach (var subdirectory in directory.GetDirectories())
            //{
            //    EncodeDirectory(subdirectory);
            //}

        }

        public string EncodeW3String(string filePath)
        {
            string w3sPath = Path.Combine(Application.StartupPath, "Tools", "w3strings.exe");
            string strCmdText = $@"--encode ""{filePath}"" --force-ignore-id-space-check-i-know-what-i-am-doing";

            CallConsoleApp(w3sPath, strCmdText);
            return filePath + ".w3strings";
        }

        #endregion

        #region Dialog

        public void SelectCsvTextBox(TextBox txt, string defaultPath = null)
        {
            var path = SelectCsv(txt.Text, defaultPath);
            if (path != null)
                txt.Text = path;
        }

        public string SelectCsv(string initialPath, string defaultPath = null)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Browse Csv Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (String.IsNullOrWhiteSpace(initialPath))
                openFileDialog1.InitialDirectory = defaultPath ?? Application.StartupPath;
            else
                openFileDialog1.InitialDirectory = initialPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return null;
            }
        }

        public void SaveXlsxTextBox(TextBox txt, string defaultPath = null)
        {
            var path = SaveXlsx(txt.Text, defaultPath);
            if (path != null)
            {
                txt.Text = path;
            }
        }

        public void MigrateOtherModToTr(string modPath)
        {
            if (!Directory.Exists(modPath))
                return;

            foreach (string path in Directory.GetFiles(modPath, "*.w3strings", SearchOption.AllDirectories))
            {
                var targetPath = path.Replace("en.w3strings", "tr.w3strings");
                if (!File.Exists(targetPath))
                    File.Copy(path, targetPath);
            }
        }

        public string SaveXlsx(string initialPath, string defaultPath = null)
        {
            if (String.IsNullOrWhiteSpace(initialPath))
                initialPath = Configs.StartupPath;

            var fi = new FileInfo(initialPath);

            SaveFileDialog dlg = new SaveFileDialog()
            {
                //Title = "Save text Files",
                //CheckFileExists = false,
                //CheckPathExists = false,
                FilterIndex = 2,
                RestoreDirectory = true,
                FileName = fi.Name,

                DefaultExt = "xlsx",
                Filter = "Exccel files (*.xlsx)|*.xlsx"
            };


            if (String.IsNullOrWhiteSpace(initialPath))
                dlg.InitialDirectory = defaultPath ?? Application.StartupPath;
            else
                dlg.InitialDirectory = fi.DirectoryName;



            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }
            else
            {
                return null;
            }

        }

        public bool IsValidGamePath(string gamePath)
        {
            return Directory.Exists(Path.Combine(gamePath, "content"));
        }

        public void SelectXlsxTextBox(TextBox txt, string defaultPath = null)
        {
            var path = SelectXlsx(txt.Text, defaultPath);
            if (path != null)
                txt.Text = path;
        }

        public string SelectXlsx(string initialPath, string defaultPath = null)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Browse Excel Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "Exccel files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (String.IsNullOrWhiteSpace(initialPath))
                openFileDialog1.InitialDirectory = defaultPath ?? Application.StartupPath;
            else
                openFileDialog1.InitialDirectory = initialPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }
            else
            {
                return null;
            }
        }

        public void SelectFolderTextBox(TextBox txt, string defaultPath = null)
        {
            var path = SelectFolder(txt.Text, defaultPath);
            if (path != null)
                txt.Text = path;
        }

        public string SelectFolder(string initialPath, string defaultPath = null)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = true;

            if (String.IsNullOrWhiteSpace(initialPath))
                dlg.InitialDirectory = defaultPath ?? Application.StartupPath;
            else
                dlg.InitialDirectory = initialPath;


            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dlg.FileName;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateStorybook()
        {
            // check version
            if (!CheckUpdateStorybook(true))
                return false;

            // download
            string downloadPath = Path.Combine(Configs.TempPath, "modThaiStoryBook.zip");
            if (!DownloadGoogleFile(Configs.StorybookFileId, downloadPath))
            {
                //ShowErrorMessage("การอัพเดทถูกยกเลิก");
                return false;
            }

            // extract
            string modPaht = Path.Combine(Application.StartupPath, "Tools", Configs.modThaiStoryBook);
            ExtractFile(downloadPath, modPaht);

            return true;

        }

        public bool UpdateTemplate()
        {
            // check version
            if (!CheckUpdateTemplate(true))
                return false;

            // download
            string downloadPath = Path.Combine(Configs.TempPath, "Template.zip");
            if (!DownloadGoogleFile(Configs.TemplateFileId, downloadPath))
            {
                //ShowErrorMessage("การอัพเดทถูกยกเลิก");
                return false;
            }

            // extract
            string targetPath = Path.Combine(Application.StartupPath, "Tools", Configs.TemplatePath);
            ExtractFile(downloadPath, targetPath);

            return true;

        }

        public void ShowErrorMessage(Exception ex, string caption = "Error")
        {
            var b = ex.GetBaseException();
            var message = b.Message;            

            if (!(ex is KnowException))
                message += "\n\n" + b.StackTrace.Trim();

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string DownloadLegacyExcel(string initialPath, bool showSaveDialog, eDownloadFrequency frequency = eDownloadFrequency.Hour)
        {
            var excelPath = initialPath;

            if (showSaveDialog)
                excelPath = SaveXlsx(initialPath);

            if (excelPath != null)
            {
                if (File.Exists(excelPath))
                {
                    if (frequency == eDownloadFrequency.Once)
                    {
                        return excelPath;
                    }
                    else
                    {
                        // check translate file up to date
                        var lastDownload = File.GetLastWriteTime(excelPath);
                        switch (frequency)
                        {
                            case eDownloadFrequency.Day:
                                if (lastDownload > DateTime.Now.AddDays(-1)) // download less than 1 day
                                    return excelPath;
                                break;
                            case eDownloadFrequency.Hour:
                                if (lastDownload > DateTime.Now.AddMinutes(-60)) // download less than 1 hour
                                    return excelPath;
                                break;
                            default: // Always
                                break;
                        }
                    }
                }

                var tempDownloadPath = Path.Combine(Configs.TempPath, "legacy.xlsx");
                if (File.Exists(tempDownloadPath))
                    File.Delete(tempDownloadPath);

                // start download
                var downloadComplete = DownloadFile("https://docs.google.com/spreadsheets/d/1XLM0VzU0RFiTw8NIQSZ2NBPlL_i1yzBYarrMWGb5lDA/export?format=xlsx", tempDownloadPath);

                var fi = new FileInfo(excelPath);
                if (downloadComplete == DialogResult.Cancel)
                {
                    // user cancel
                    return null;
                }
                if (downloadComplete == DialogResult.Abort)
                {
                    // cannot download translate file
                    if (fi.Exists && fi.Length > 0)
                    {
                        return excelPath;
                    }
                    else
                    {
                        ShowErrorMessage("ไม่สามารถโหลดไฟล์ได้ กรุณาตรวจสอบการเชื่อมต่ออินเตอร์เน็ต");
                        return null;
                    }
                }
                else
                {
                    if (fi.Exists)
                        fi.Delete();
                    else if (!fi.Directory.Exists)
                        fi.Directory.Create();

                    File.Move(tempDownloadPath, excelPath);
                }
            }

            return excelPath;
        }

        public Dictionary<string, List<w3Strings>> ReadTemplate()
        {
            string templatePath = Configs.TemplateFilePath;
            if (!File.Exists(templatePath))
                throw new Exception("ไม่พบไฟล์ template.xlsx กรุณาติดตั้งโปรแกมใหม่");

            var sheetConfig = setting.GetSheetConfig();
            var template = ReadExcel(templatePath, sheetConfig, true);

            return template;
        }

        public Dictionary<string, List<w3Strings>> ReadGame(String gamePath)
        {
            var files = setting.GetSheetConfig();
            var tempPath = Path.Combine(Application.StartupPath, "temp");
            string tempOriginalPath = Path.Combine(tempPath, "original");

            PrepareFile(gamePath, tempPath, files);

            var result = new Dictionary<string, List<w3Strings>>();
            foreach (var sht in files)
            {
                var csvPath = Path.Combine(tempOriginalPath, sht.Key + ".w3strings.csv");
                var csvContent = ReadOriginalCsv(csvPath, true);

                result.Add(sht.Key, csvContent);
            }

            return result;

        }

        public Dictionary<string, w3Strings> ReadAllExcel(string excelPath)
        {
            var data = ReadExcel(excelPath, setting.GetSheetConfig(), true);
            return GetAllContent(data);
        }

        public List<w3Strings> ConvertToList(Dictionary<string, w3Strings> data)
        {
            return data.Select(d => d.Value).ToList();
        }

        public Dictionary<string, w3Strings> GetAllContent(Dictionary<string, List<w3Strings>> content)
        {
            var all = new List<w3Strings>();
            foreach (var c in content)
            {
                all.AddRange(c.Value);
            }

            var result = ConvertToDictionary(all);

            return result;

        }

        public void GenerateMissing(string inputPath, string outputPath)
        {
            //var files = setting.GetSheetConfig();
            //var tempPath = Path.Combine(Application.StartupPath, "temp");
            //string tempOriginalPath = Path.Combine(tempPath, "original");

            //if (String.IsNullOrWhiteSpace(outputPath))
            //    outputPath = Path.Combine(Application.StartupPath, "output", "mising.xlsx");

            //read

            var templateContent = GetAllContent(ReadTemplate());
            var gameContent = GetAllContent(ReadGame(inputPath));

            var fi = new FileInfo(outputPath);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;

                var content = GetMissing(gameContent, templateContent);
                var sht = wb.Worksheets["Missing"];
                if (sht != null)
                    wb.Worksheets.Delete(sht);

                sht = wb.Worksheets.Add("Missing");
                WriteSheetContent(sht, content, false);

                p.Save();
            }
        }

        private List<w3Strings> GetMissing(Dictionary<string, w3Strings> gameContent, Dictionary<string, w3Strings> templateContent)
        {
            var result = gameContent
                .Where(gc => !templateContent.ContainsKey(gc.Key))
                .Select(gc => gc.Value)
                .ToList();

            return result;
        }

        public void UpdateW3tu()
        {
            ExtractFile(Configs.UpdaterZipPath, Configs.UpdaterDir);
            Open(Configs.UpdaterPath);
        }

        public string DownloadLegacyMod(string initialPath, string defaultPath = null)
        {
            var path = SelectFolder(initialPath, defaultPath);
            if (path != null)
            {
                var downloadResult = DownloadMod(path, true, true);
                if (downloadResult == null)
                    return null;
            }

            return path;

        }

        public void ShowErrorMessage(string message, string caption = "Error")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowMessage(string message, string caption = "")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ShowConfirm(string message, string caption = "")
        {
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public string GetCustomTranslateDescription()
        {
            try
            {
                var fi = new FileInfo(Configs.CustomTranslateFilePath);
                if(!fi.Exists)
                    return Configs.CUSTOM_TRANSLATE_LABEL;

                using (var p = new ExcelPackage(fi))
                {
                    var sht = p.Workbook.Worksheets[1];
                    var desc = sht.Cells[1, 1].Text;

                    if (String.IsNullOrWhiteSpace(desc))
                        desc = "UNKNOW";

                    return $@"{Configs.CUSTOM_TRANSLATE_LABEL} ({desc})";
                }
            }
            catch(Exception)
            {
                return Configs.CUSTOM_TRANSLATE_LABEL;
            }
            
        }

        public bool ShowConfirmWarning(string message, string caption = "")
        {
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        #endregion

        #region Utility

        public void CallConsoleApp(string appPath, string args)
        {
            using (Process p = new Process())
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = appPath;
                p.StartInfo.Arguments = args;

                // Redirect the output stream of the child process.
                //p.StartInfo.UseShellExecute = false;
                //p.StartInfo.RedirectStandardOutput = true;


                p.Start();

                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                // p.WaitForExit();
                // Read the output stream first and then wait.
                //string output = p.StandardOutput.ReadToEnd();

                p.WaitForExit();
            }
        }

        public static void DeleteDirectory(string target_dir)
        {
            if (!Directory.Exists(target_dir))
                return;

            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, true);
        }

        /// <summary>
        /// copy all w3strings from mod directory to temp directory
        /// </summary>
        /// <param name="originalPath"></param>
        /// <param name="tempPath"></param>
        /// <param name="files"></param>
        public void PrepareTemp(string originalPath, string tempPath, Dictionary<string, string> files)
        {
            if (!Directory.Exists(tempPath))
                Directory.CreateDirectory(tempPath);

            foreach (var f in files)
            {
                var sourcePath = Path.Combine(originalPath, f.Value, "en.w3strings");
                var descPath = Path.Combine(tempPath, f.Key + ".w3strings");
                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, descPath, true);
                }
            }
        }

        /// <summary>
        /// copy output w3strings to target path
        /// </summary>
        /// <param name="tempPath"></param>
        /// <param name="targetPath"></param>
        /// <param name="modList"></param>
        private void FinishMod(string tempPath, string targetPath, Dictionary<string, string> modList)
        {
            DeleteDirectory(targetPath);
            foreach (var file in modList)
            {

                var source = new FileInfo(Path.Combine(tempPath, file.Key + ".csv.w3strings"));
                var desc = new FileInfo(Path.Combine(targetPath, file.Value + @"\en.w3strings"));

                if (!source.Exists)
                    continue;

                if (!desc.Directory.Exists)
                    desc.Directory.Create();

                source.CopyTo(desc.FullName, true);
            }

            WriteVersionUnofficial(targetPath, "unofficial");
        }

        public List<w3Strings> ReadExcelSheet(string path, string sheetName, bool isReadTranslate)
        {
            var fi = new FileInfo(path);
            using (var p = new ExcelPackage(fi))
            {
                var sht = p.Workbook.Worksheets[sheetName];
                var result = ReadExcelSheet(sht, isReadTranslate);
                return result;

            }
        }

        public Dictionary<string, w3Strings> ConvertToDictionary(List<w3Strings> content)
        {
            content = DistinctContent(content);
            var result = content.ToDictionary((w3s) => { return w3s.ID.Trim(); });
            return result;
        }


        public List<w3Strings> ReadOriginalCsv(string path, bool sort)
        {
            int skip = 2;
            int i = 0;
            string line = null;
            try
            {
                var w3s = new List<w3Strings>();

                if (!File.Exists(path))
                    return w3s;

                var content = File.ReadAllText(path).Split('\n')
                            .Skip(skip)
                            .Where(c => !String.IsNullOrWhiteSpace(c))
                            //.Select(c => c.Replace("[[CSV_EXPORT_PIPE]]", "|"))
                            //.Select(c => c = c.Replace("\"\"", "{}").Replace("\"", "").Replace("{}", "\""))
                            .ToArray();

                //var w3s = content.Select(c => new w3Strings(SplitOriginalLine(c), true)).ToList();


                for (i = 0; i < content.Length; i++)
                {
                    line = content[i];
                    var message = new w3Strings(SplitOriginalLine(line), true);
                    message.SheetName = Path.GetFileNameWithoutExtension(path).Replace(".w3strings", "");
                    w3s.Add(message);
                }

                if (sort)
                    w3s = w3s.OrderBy(w => w.ID).ToList();

                return w3s;
            }
            catch (Exception)
            {
                throw new KnowException($@"Error at line {i + skip + 2} (index {i}) : ""{line}""");
            }

        }

        public string[] SplitOriginalLine(string line)
        {
            return line.Split(new string[] { "|" }, StringSplitOptions.None);
        }

        public void WriteCsv(List<w3Strings> content, string path)
        {
            var fi = new FileInfo(path);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            using (TextWriter tw = new StreamWriter(path))
            {
                tw.Write(";meta[language=en]\n");
                tw.Write("; id      |key(hex)|key(str)| text\n");

                foreach (var line in content)
                {
                    tw.Write(line.ToCsvLine());
                }
            }
        }


        public void WriteTranslateResult(List<TranslateResult> results, string path)
        {
            var fi = new FileInfo(path);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (var item in results)
                {
                    tw.WriteLine(item.ToString());
                }

                tw.WriteLine(new String('-', 30));
                var all = results.Sum(r => r.AllMessage);
                var skip = results.Sum(r => r.Skip);
                var total = new TranslateResult("Total", all, skip);
                tw.WriteLine(total.ToString());
            }
        }

        #endregion

        #region Legacy Function

        public string GenerateExcelFromLegacy(string modPath, string excelPath, string outputPath)
        {
            float totalTotalMatch = 0, totalNotTranslate = 0, totalContent = 0;
            var sb = new StringBuilder();
            sb.AppendLine("Generate Result");
            sb.AppendLine(new string('=', 20));

            var files = setting.GetSheetConfig();
            var tempPath = Path.Combine(Application.StartupPath, "temp");
            string tempOriginalPath = Path.Combine(tempPath, "original");
            List<TranslateResult> results = new List<TranslateResult>();

            List<w3Strings> skipSource;
            List<w3Strings> skipTranslate;

            PrepareFile(modPath, tempPath, files);

            var content = new Dictionary<string, List<w3Strings>>();

            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {
                foreach (var s in files)
                {
                    var sht = p.Workbook.Worksheets[s.Key];
                    if (sht == null)
                        continue;

                    var sourcePath = Path.Combine(tempOriginalPath, s.Key + ".w3strings.csv");
                    var targetPath = Path.Combine(tempPath, s.Key + ".csv");

                    var sourceContent = ReadOriginalCsv(sourcePath, true);
                    var translateContent = ReadExcelLegacySheet(sht);

                    Debug.WriteLine($@"start merge {s.Key} {sourceContent.Count} rows at {DateTime.Now:HH:mm:ss}");
                    var mergeContent = MergeLegacySheet(sourceContent, translateContent, true, out skipSource, out skipTranslate);

                    content.Add(s.Key, mergeContent);

                    // result
                    float matchCount = sourceContent.Count - skipSource.Count;
                    float skipTranslateCount = skipTranslate.Count;
                    totalTotalMatch += matchCount;
                    totalNotTranslate += skipTranslate.Count;
                    totalContent += sourceContent.Count;
                    sb.AppendLine($@"{sht.Name}");
                    sb.AppendLine($@"    match            : {matchCount:#,0}/{sourceContent.Count:#,0} ({matchCount / sourceContent.Count * 100f:#,0}%)");
                    sb.AppendLine($@"    not translate: {skipTranslateCount:#,0} ({skipTranslateCount / sourceContent.Count * 100f:#,0}%)");



                }

            }

            // write excel
            WriteExcel(outputPath, content, false);

            // total result
            sb.AppendLine(new string('-', 20));
            sb.AppendLine($@"Total");
            sb.AppendLine($@"    match            : {totalTotalMatch:#,0}/{totalContent:#,0} ({totalTotalMatch / totalContent * 100f:#,0}%)");
            sb.AppendLine($@"    not translate: {totalNotTranslate:#,0} ({totalNotTranslate / totalContent * 100f:#,0}%)");

            return sb.ToString();

        }

        public List<w3Strings> MergeLegacySheet(List<w3Strings> source, List<w3Strings> translate, bool forExcel, out List<w3Strings> skipSource, out List<w3Strings> skipTranslate)
        {
            var result = new List<w3Strings>();

            var min = source.Count;
            int extraTranslate = 0;
            int extraSource = 0;
            int nextMatch;

            skipSource = new List<w3Strings>();
            skipTranslate = new List<w3Strings>();

            bool forceMerge = false;
            if (source.Count == translate.Count)
                forceMerge = true;

            for (var i = 0; i < min; i++)
            {
                //Debug.WriteLine($@"merge: {source[i + extraSource].ID}");
                // end of source
                if (i + extraSource >= source.Count)
                    return result;

                // end of translate
                if (i + extraTranslate >= translate.Count)
                {
                    // not translate
                    result.Add(new w3Strings(
                        source[i + extraSource].ID,
                        source[i + extraSource].KeyHex,
                        source[i + extraSource].KeyString,
                        source[i + extraSource].Text,
                        null,

                        source[i + extraSource].SheetName,
                        source[i + extraSource].RowNumber
                    ));

                    skipSource.Add(source[i + extraSource]);
                    continue;
                }


                // text not match
                if (
                    !forceMerge &&
                    source[i + extraSource].Text.GetCompareString() != translate[i + extraTranslate].Text.GetCompareString() &&
                    source[i + extraSource].Text.GetCompareString() != translate[i + extraTranslate].Translate.GetCompareString()
                )
                {

                    nextMatch = FindNextMatchLegacy(source[i].Text, translate, i + extraTranslate);
                    if (nextMatch > 0)
                    {
                        // skip translate
                        for (int sk = 0; sk < nextMatch; sk++)
                        {
                            skipTranslate.Add(translate[i + extraTranslate + sk]);
                        }
                        extraTranslate += nextMatch;
                    }
                    else
                    {
                        skipSource.Add(source[i + extraSource]);

                        result.Add(new w3Strings(
                            source[i + extraSource].ID,
                            source[i + extraSource].KeyHex,
                            source[i + extraSource].KeyString,
                            source[i + extraSource].Text,
                            null,

                            translate[i + extraSource].SheetName,
                            translate[i + extraSource].RowNumber
                        ));

                        continue;
                    }

                }

                result.Add(new w3Strings(
                    source[i + extraSource].ID,
                    source[i + extraSource].KeyHex,
                    source[i + extraSource].KeyString,
                    translate[i + extraTranslate].Text,
                    source[i + extraTranslate].Translate.NullIfEmpty() ?? translate[i + extraTranslate].Translate,

                    translate[i + extraSource].SheetName,
                    translate[i + extraSource].RowNumber
                ));

                if (String.IsNullOrWhiteSpace(translate[i + extraTranslate].Translate))
                    skipTranslate.Add(source[i + extraSource]);
            }

            return result;
        }

        public int FindNextMatchLegacy(string text, List<w3Strings> translate, int startIndex)
        {
            for (int i = 1; i < translate.Count - startIndex - 1; i++)
            {
                if (text.GetCompareString() == translate[startIndex + i].Text.GetCompareString())
                {
                    return i;
                }
            }

            return -1;
        }

        public Dictionary<string, List<w3Strings>> ReadExcelLegacy(string excelPath, Dictionary<string, string> sheetConfig)
        {
            var result = new Dictionary<string, List<w3Strings>>();

            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {
                foreach (var sht in p.Workbook.Worksheets)
                {
                    if (!sheetConfig.ContainsKey(sht.Name))
                        continue;

                    result.Add(sht.Name, ReadExcelLegacySheet(sht));

                }

            }

            return result;
        }

        public List<w3Strings> ReadExcelLegacySheet(ExcelWorksheet sht)
        {
            const int COL_TEXT = 1;
            const int COL_TRANS = 3;
            const int ROW_START = 5;

            List<w3Strings> result = new List<w3Strings>();

            int row = ROW_START;
            string translate;
            string text;
            while (!IsEndLegacy(sht, row))
            {
                text = sht.Cells[row, COL_TEXT].Text;
                if (String.IsNullOrWhiteSpace(text))
                    text = Configs.MissingText;

                translate = sht.Cells[row, COL_TRANS].Text.Replace("\r", "").Replace("\n", "");
                result.Add(new w3Strings(null, null, null, text, translate, sht.Name, row));

                row++;
            }

            return result;

        }

        bool IsEndLegacy(ExcelWorksheet sht, int row)
        {
            string text;
            for (int i = 0; i < Configs.MaxLegacyEmptyRow; i++)
            {
                text = sht.Cells[row + i, 1].Text;
                if (!String.IsNullOrWhiteSpace(text))
                    return false;

            }

            return true;

        }


        #endregion

        #region Merge Language

        public w3Strings GetTranslate(w3Strings source, w3Strings translate, bool forExcel, bool combine, bool originalFirst)
        {
            return GetTranslate(source, translate, forExcel, combine, originalFirst);
        }

        public w3Strings GetTranslate(w3Strings source, w3Strings translate, bool forExcel, bool combine, bool originalFirst, bool includeNotTranslateMessageId, bool includeTranslateMessageId, bool includeUiMessageId, bool translateUI)
        {
            if (forExcel)
            {
                // fill mod text in message column
                // fill mod translate in translate column
                return new w3Strings(
                    source.ID,
                    source.KeyHex,
                    source.KeyString,
                    source.Text,
                    Translate(source, translate.Translate, false, false, false, false, false, true)
                );
            }
            else
            {
                return new w3Strings(
                    source.ID,
                    source.KeyHex,
                    source.KeyString,
                    Translate(source, translate.Translate, combine, originalFirst, includeNotTranslateMessageId, includeTranslateMessageId, includeUiMessageId, translateUI),
                    null
                );
            }
        }

        public void GenerateModFromGameFile(string excelPath, string originalPath, string outputPath, bool combine, bool originalFirst)
        {
            string sheetName = null;
            try
            {
                var files = setting.GetSheetConfig();
                var tempPath = Path.Combine(Application.StartupPath, "temp");
                string tempOriginalPath = Path.Combine(tempPath, "original");
                List<TranslateResult> results = new List<TranslateResult>();

                List<w3Strings> skipSource;
                List<w3Strings> skipTranslate;

                PrepareFile(originalPath, tempPath, files);
                //DeleteDirectory(outputPath);

                var fi = new FileInfo(excelPath);
                using (var p = new ExcelPackage(fi))
                {
                    foreach (var sht in p.Workbook.Worksheets)
                    {
                        if (!files.Keys.Contains(sht.Name))
                            continue;

                        sheetName = sht.Name;
                        var path = files[sht.Name];
                        var sourcePath = Path.Combine(tempOriginalPath, sht.Name + ".w3strings.csv");
                        var targetPath = Path.Combine(tempPath, sht.Name + ".csv");

                        //var sourceContent = ReadOriginalCsv(sourcePath, true);
                        //var translateContent = ReadExcel(sht);
                        var sourceContent = ConvertToDictionary(ReadOriginalCsv(sourcePath, true));
                        var translateContent = ConvertToDictionary(ReadExcelSheet(sht, true));

                        var mergeContent = MergeContentDictionary(sourceContent, translateContent, false, combine, originalFirst, null, out skipSource, out skipTranslate);

                        WriteCsv(mergeContent, targetPath);
                        results.Add(new TranslateResult(sheetName, sourceContent.Count, skipSource.Count));
                    }

                }

                EncodeDirectory(tempPath);
                FinishMod(tempPath, outputPath, files);

                WriteTranslateResult(results, Path.Combine(outputPath, "result.txt"));
            }
            catch (MergeException ex)
            {
                string error = "";
                error += $@"Error          : Message not equal{ Environment.NewLine}";
                error += $@"Sheet          : {sheetName}{Environment.NewLine}";
                error += $@"key            : {ex.Key.Trim()}{Environment.NewLine}";
                error += $@"Source Text    : {ex.SourceText}{Environment.NewLine}";
                error += $@"Translate Text : {ex.TranslateText}";

                throw new KnowException(error);
            }
        }

        public List<w3Strings> MergeContentDictionary(Dictionary<string, w3Strings> source, Dictionary<string, w3Strings> translate, bool forExcel, bool combine, bool originalFirst, List<string> knowIssueList = null)
        {
            List<w3Strings> skipSource, skipTranslate;
            return MergeContentDictionary(source, translate, forExcel, combine, originalFirst, knowIssueList, out skipSource, out skipTranslate);
        }



        public List<w3Strings> MergeContentDictionary(Dictionary<string, w3Strings> source, Dictionary<string, w3Strings> translate, bool forExcel, bool combine, bool originalFirst, List<string> knowIssueList, out List<w3Strings> skipSource, out List<w3Strings> skipTranslate)
        {
            var result = new List<w3Strings>();
            skipSource = new List<w3Strings>();
            skipTranslate = new List<w3Strings>();

            foreach (var w3s in source)
            {
                var s = w3s.Value;

                // match with translate
                if (translate.ContainsKey(w3s.Key))
                {
                    var t = translate[w3s.Key];

                    // not translate yet
                    if (String.IsNullOrWhiteSpace(t.Translate))
                    {
                        skipTranslate.Add(t);
                        result.Add(s);
                    }
                    // translated
                    else
                    {
                        var item = GetTranslate(s, t, forExcel, combine, originalFirst);
                        result.Add(item);
                    }
                }
                // not match with translate
                else
                {
                    skipSource.Add(s);
                    result.Add(s);
                }
            }

            return result;
        }

        public int FindNextMatch(string id, List<w3Strings> translate, int startIndex)
        {
            for (int i = 1; i < translate.Count - startIndex - 1; i++)
            {
                if (id.Trim() == translate[startIndex + i].ID.Trim())
                {
                    return i;
                }
            }

            return -1;
        }

        //public string Translate(string original, string translate, bool combine = false, bool originalFirst = true, bool forceSingle = false)
        //{
        //    if (original.GetCompareString() == translate.GetCompareString() || String.IsNullOrWhiteSpace(translate))
        //        return original;

        //    if (combine && !forceSingle)
        //    {
        //        return CombineText(original, translate, originalFirst);
        //    }
        //    else
        //    {
        //        //return String.IsNullOrWhiteSpace(translate) ? text : translate;
        //        return translate;
        //    }

        //}

        public List<w3Strings> Translate(List<w3Strings> content, bool combine, bool originalFirst, bool includeNotTranslateMessageId, bool includeTranslateMessageId, bool includeUiMessageId, bool translateUI)
        {
            var result = new List<w3Strings>();
            foreach (var c in content)
            {
                var item = new w3Strings(
                    c.ID,
                    c.KeyHex,
                    c.KeyString,
                    Translate(c, c.Translate, combine, originalFirst, includeNotTranslateMessageId, includeTranslateMessageId, includeUiMessageId, translateUI),
                    null
                );

                result.Add(item);

            }

            return result;
        }

        public string Translate(w3Strings w3s, bool combine = false, bool originalFirst = true, bool includeMessageId = false)
        {
            return Translate(w3s, w3s.Translate, combine, originalFirst, false, false, false, true);
        }

        public string Translate(w3Strings original, string translate, bool combine, bool originalFirst, bool includeNotTranslateMessageId, bool includeTranslateMessageId, bool includeUiMessageId, bool translateUI)
        {
            //not translate
            if (String.IsNullOrWhiteSpace(translate))
            {
                // ui text
                if (!original.IsConversation)
                {
                    //if (includeUiMessageId && original.Text.Length > 30)
                    if (includeUiMessageId && includeNotTranslateMessageId)
                        return AppendMessageId(original, original.Text);
                    else
                        return original.Text;
                }
                else
                {
                    if (includeNotTranslateMessageId)
                        return AppendMessageId(original, original.Text);
                    else
                        return original.Text;
                }
            }
            // tranlated ui text
            else if (!original.IsConversation)
            {
                if (translateUI == false)
                    return original.Text;
                if (includeUiMessageId && includeTranslateMessageId)
                    return AppendMessageId(original, translate);
                else
                    return translate;
            }
            // same word
            else if (original.Text.GetCompareString() == translate.GetCompareString())
            {
                if (includeTranslateMessageId)
                    return AppendMessageId(original, original.Text);
                else
                    return original.Text;
            }
            // translated
            else
            {
                if (combine)
                {
                    // return because combine text already include message id
                    return CombineText(original, translate, originalFirst, includeTranslateMessageId);
                }
                else
                {
                    if (includeTranslateMessageId)
                        return AppendMessageId(original, translate);
                    else
                        return translate;
                }
            }

        }

        private string AppendMessageId(w3Strings w3s, string message)
        {
            //if (w3s.KeyHex != "00000000")
            //    return $@"{message} ({w3s.ID.Trim()})";
            //else
            return $@"{message} ({GetMessageId(w3s)})";
        }

        private string GetMessageId(w3Strings w3s)
        {
            return $@"{w3s.SheetName}:{w3s.RowNumber:#,0}";
        }

        private string CombineText(w3Strings original, string translate, bool originalFirst, bool includeMessageId = false)
        {
            string message;

            if (originalFirst)
                message = $@"{original.Text}{Configs.Separator}[{translate}]";
            else
                message = $@"{translate}{Configs.Separator}[{original.Text}]";

            if (includeMessageId)
                message += $@"{Configs.Separator}({GetMessageId(original)})";

            if (!original.Text.Contains("[["))
                message = message.Replace("[[", "[").Replace("]]", "]");

            return message;
        }

        #endregion

        #region Kuntoon Function

        public string GetModLastVersion()
        {
            return GetModLastVersion(0);
        }

        public string GetModLastVersion(int tryCount)
        {
            try
            {
                string url = "http://dl.dropbox.com/s/kj962og72ffu3yv/version.ini?dl=0";
                var client = new WebClient();
                var data = client.DownloadData(url);
                var stream = new StreamReader(new MemoryStream(data));

                //var request = WebRequest.Create(url);
                //var stream = new StreamReader(request.GetResponse().GetResponseStream());
                var lastVersion = stream.ReadToEnd().ToString();

                if (String.IsNullOrWhiteSpace(lastVersion))
                {
                    throw new KnowException("Get version fail. Try again later.");
                    //lastVersion = "N/A";
                }

                return lastVersion;
            }
            catch (Exception ex)
            {
                if (tryCount > 2)
                    throw ex;
                else
                    return GetModLastVersion(tryCount);
            }
        }

        public bool CheckForUpdate(bool silenceMode = false)
        {
            string lastVersion;

            if (silenceMode)
                lastVersion = ProcessingStringSilence(GetLastVersion, "กำลังเช็คเวอร์ชั่นโปรแกรม", false);
            else
                lastVersion = ProcessingString(GetLastVersion, "กำลังเช็คเวอร์ชั่นโปรแกรม", false);

            if (lastVersion == null)
                return false;

            var localVersion = ReadLocalVersion(Configs.StartupPath);

            return localVersion != lastVersion;
        }

        public bool CheckUpdateStorybook(bool silenceMode = false)
        {
            string lastVersion;

            if (silenceMode)
                lastVersion = ProcessingStringSilence(GetVersionStorybook, "กำลังเช็คเวอร์ชั่น Story Book", false);
            else
                lastVersion = ProcessingString(GetVersionStorybook, "กำลังเช็คเวอร์ชั่น Story Book", false);

            if (lastVersion == null)
                return false;

            var localVersion = ReadVersion(Configs.StorybookVersionPath);

            return localVersion != lastVersion;
        }

        public bool CheckUpdateTemplate(bool silenceMode = false)
        {
            string lastVersion;

            if (silenceMode)
                lastVersion = ProcessingStringSilence(GetVersionTemplate, "กำลังเช็คเวอร์ชั่น Template", false);
            else
                lastVersion = ProcessingString(GetVersionTemplate, "กำลังเช็คเวอร์ชั่น Template", false);

            if (lastVersion == null)
                return false;

            var localVersion = ReadVersion(Configs.TemplateVersionPath);

            return localVersion != lastVersion;
        }

        public string GetLastVersion()
        {
            try
            {
                string url = GetGoogleDownloadUrl(Configs.VersionFileId);
                var client = new WebClient();
                var data = client.DownloadData(url);
                var stream = new StreamReader(new MemoryStream(data));

                //var request = WebRequest.Create(url);
                //var stream = new StreamReader(request.GetResponse().GetResponseStream());
                var lastVersion = stream.ReadToEnd().ToString();

                //if (String.IsNullOrWhiteSpace(lastVersion))
                //{
                //    throw new KnowException("Get version fail. Try again later.");
                //    //lastVersion = "N/A";
                //}

                return lastVersion;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public string GetVersionStorybook()
        {
            string url = GetGoogleDownloadUrl(Configs.StorybookVersionFileId);
            var client = new WebClient();
            var data = client.DownloadData(url);
            var stream = new StreamReader(new MemoryStream(data));

            //var request = WebRequest.Create(url);
            //var stream = new StreamReader(request.GetResponse().GetResponseStream());
            var lastVersion = stream.ReadToEnd().ToString();

            //if (String.IsNullOrWhiteSpace(lastVersion))
            //{
            //    throw new KnowException("Get version fail. Try again later.");
            //    //lastVersion = "N/A";
            //}

            return lastVersion;
        }

        public string GetVersionTemplate()
        {
            string version = ReadGoogleFileContent(Configs.TemplateVersionFileId);
            return version;
        }

        public string ReadGoogleFileContent(string fileId)
        {
            string url = GetGoogleDownloadUrl(fileId);
            var client = new WebClient();
            var data = client.DownloadData(url);
            var stream = new StreamReader(new MemoryStream(data));
            var content = stream.ReadToEnd().ToString();

            return content;
        }

        public string ReadLocalVersion(string modPath)
        {
            string versionPath = Path.Combine(modPath, "version.ini");

            if (!File.Exists(versionPath))
                return "N/A";

            var lines = File.ReadLines(versionPath).ToList();
            return lines.FirstOrDefault() ?? "N/A";
        }

        public string ReadVersion(string versionPath)
        {
            if (!File.Exists(versionPath))
                return "N/A";

            var lines = File.ReadLines(versionPath).ToList();
            return lines.FirstOrDefault() ?? "N/A";
        }

        //public void DownloadModAsync(string targetPath)
        //{
        //    string url = "https://dl.dropbox.com/s/iyn4vn4eiq4oegc/Thaimods.zip?dl=0";
        //    string saveToPath = Path.Combine(targetPath, "thaimod.zip");
        //    using (var dlg = new DownloadDialog(url, saveToPath))

        //        if (Directory.Exists(targetPath))
        //            DeleteDirectory(targetPath);

        //    Directory.CreateDirectory(targetPath);
        //}

        public string GetGoogleDownloadUrl(string id)
        {
            return $@"https://drive.google.com/uc?export=download&id={id}";
        }

        public string GetGoogleSheetDownloadUrl(string id)
        {
            return $@"https://docs.google.com/spreadsheets/d/{id}/export?format=xlsx";
        }

        public bool DownloadGoogleFile(string id, string saveToPath)
        {
            string url = GetGoogleDownloadUrl(id);
            using (var dlg = new DownloadDialog(url, saveToPath))
            {
                var result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                    return true;
                else
                    return false;
            }
        }

        public bool DownloadGoogleSheetFile(string id, string saveToPath)
        {
            string url = GetGoogleSheetDownloadUrl(id);
            using (var dlg = new DownloadDialog(url, saveToPath))
            {
                var result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                    return true;
                else
                    return false;
            }
        }

        public DialogResult DownloadFile(string url, string saveToPath)
        {
            using (var dlg = new DownloadDialog(url, saveToPath))
            {
                var result = dlg.ShowDialog();
                return result;
            }
        }

        public void ExtractFile(string zipPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
                DeleteDirectory(outputPath);
            else
                Directory.CreateDirectory(outputPath);

            ZipFile.ExtractToDirectory(zipPath, outputPath);
        }

        private void ProcessDownloadMod(string targetPath, string downloadFilePath, bool writeVersion, bool updateFont)
        {
            string backupPath = Path.Combine(Application.StartupPath, "temp", "mod_backup");
            try
            {
                // backup old mod
                //if (Directory.Exists(targetPath))
                //    Directory.Move(targetPath, backupPath);

                string extractPath = Path.Combine(Application.StartupPath, "temp", "thaimod");

                // extract file
                ExtractFile(downloadFilePath, extractPath);
                //File.Delete(downloadFilePath);

                // rename folder
                Directory.Move(
                    Path.Combine(extractPath, "modKuntoonW3thai_mod"),
                    Path.Combine(extractPath, "mods")
                );

                Directory.Move(
                    Path.Combine(extractPath, "modKuntoonW3thai_modfile"),
                    Path.Combine(extractPath, "content")
                );

                Directory.Move(
                    Path.Combine(extractPath, "modKuntoonW3thai_modfileDLC"),
                    Path.Combine(extractPath, "dlc")
                );

                CopyDirectory(extractPath, targetPath);

                if (writeVersion)
                    WriteVersion(targetPath);

                // update font mod
                if (updateFont)
                    UpdateFont(targetPath);

                //if (Directory.Exists(backupPath))
                //    DeleteDirectory(backupPath);
            }
            catch (Exception ex)
            {
                //if (Directory.Exists(backupPath))
                //    Directory.Move(backupPath, targetPath);


                throw ex;
            }
        }

        public string DownloadMod(string targetPath, bool writeVersion, bool updateFont)
        {
            //string downloadFilePath = Path.Combine(targetPath, "thaimod.zip");
            //new WebClient().DownloadFile(new Uri("https://dl.dropbox.com/s/iyn4vn4eiq4oegc/Thaimods.zip?dl=0"), downloadFilePath);

            // if directory not empty
            //if (Directory.EnumerateFileSystemEntries(targetPath).Any())
            //    throw new KnowException("Please select empty folder");           

            string url = "https://dl.dropbox.com/s/iyn4vn4eiq4oegc/Thaimods.zip?dl=0";
            string downloadFilePath = Path.Combine(Application.StartupPath, "temp", "thaimod.zip");
            var downloadFileResult = DownloadFile(url, downloadFilePath);
            if (downloadFileResult != DialogResult.OK)
                return null;

            Processing(() => { ProcessDownloadMod(targetPath, downloadFilePath, writeVersion, updateFont); }, false);
            return "Download Complete";
        }


        private void WriteVersion(string modPath)
        {
            var version = GetModLastVersion();

            var filePath = Path.Combine(modPath, "version.ini");
            var fi = new FileInfo(filePath);

            if (!fi.Directory.Exists)
                fi.Directory.Create();

            using (TextWriter tw = new StreamWriter(filePath))
            {
                tw.Write(version);
            }
        }

        public void WriteVersionUnofficial(string modPath, string source)
        {
            string path = Path.Combine(modPath, "version.ini");
            CreateFileDirectory(path);
            using (TextWriter tw = new StreamWriter(path))
            {
                tw.WriteLine($@"{DateTime.Now:yyyy.MM.dd HH:mm:ss}");
            }
        }

        private void CreateFileDirectory(string filePath)
        {
            var fi = new FileInfo(filePath);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
        }

        public bool ValidateBeforeBackup(string DestinationPath, string confirmMessage, string title = "")
        {
            //string version = ReadLocalVersion(DestinationPath);
            if (BackupExists(DestinationPath))
                return ShowConfirmWarning(confirmMessage, title);
            else
                return true;
        }

        public bool BackupExists(string path)
        {
            string versionPath = Path.Combine(path, "version.ini");
            return File.Exists(versionPath);
        }

        public bool ModExists(string gamePath)
        {
            var modPath = Path.Combine(gamePath, "mods", Configs.modThaiLanguage);
            return Directory.Exists(modPath);
        }

        public void CopyDirectory(string SourcePath, string DestinationPath, List<string> skips = null)
        {
            if (skips == null)
                skips = new List<string>();

            // create all directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            // copy file and replace
            foreach (string path in Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories))
            {
                if (skips.Contains(path))
                    continue;
                var fi = new FileInfo(path.Replace(SourcePath, DestinationPath));

                if (fi.Exists)
                    fi.Delete();
                else if (!fi.Directory.Exists)
                    fi.Directory.Create();

                File.Copy(path, fi.FullName, true);
            }
        }

        #endregion

        /// <summary>
        /// copy all w3strings file to target directory
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="targrtPath"></param>
        /// <param name="overwrite"></param>
        public void Backup(string sourcePath, string targrtPath, bool overwrite, bool writeVersion)
        {
            var TranslatePath = setting.GetSheetConfig();
            foreach (var p in TranslatePath)
            {
                var s = new FileInfo(Path.Combine(sourcePath, p.Value, "en.w3strings"));
                var t = new FileInfo(Path.Combine(targrtPath, p.Value, "en.w3strings"));

                if (!s.Exists)
                    return;

                if (!t.Directory.Exists)
                    t.Directory.Create();

                s.CopyTo(t.FullName, overwrite);
            }

            if (writeVersion)
                WriteVersionUnofficial(targrtPath, "backup");
        }

        public string GetSteamDirectory()
        {
            string installPath;
            installPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", null) as string;
            if (installPath != null)
                return installPath;

            installPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", null) as string;
            return installPath;
        }

        public string GetGameDirectory()
        {
            var steamPath = GetSteamDirectory();
            if (steamPath == null)
                return null;
            else
            {
                string gamePath = @"steamapps\common\The Witcher 3";
                var path = Path.Combine(steamPath, gamePath, "content");
                if (!Directory.Exists(path))
                {
                    string libraryFoldersFile = Path.Combine(steamPath, "steamapps", String.Format("libraryfolders.vdf"));
                    if (File.Exists(libraryFoldersFile))
                    {
                        var vdf = VdfConvert.Deserialize(File.ReadAllText(libraryFoldersFile));
                        try
                        {
                            for (var i = 1; i <= vdf.Value.Count() - 2; i++)
                            {
                                var libraryPath = vdf.Value[i.ToString()].ToString();
                                path = Path.Combine(libraryPath, gamePath, "content");
                                if (Directory.Exists(path))
                                    return Directory.GetParent(path).FullName;
                            }

                        }
                        catch
                        {
                            return null;
                        }
                    }
                    return null;
                }
                else
                    return Directory.GetParent(path).FullName;
            }

        }

        public void Open(string path)
        {
            try
            {
                Process.Start(path);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.GetBaseException().Message);
            }
        }

        public string GetTranslateFilePath()
        {
            return Configs.TemplateFilePath;
            //var path = Path.Combine(Application.StartupPath, "Translate");
            //var dir = new DirectoryInfo(path);
            //if (!dir.Exists)
            //    return null;

            //var files = dir.GetFiles("*.xlsx", SearchOption.TopDirectoryOnly);

            //var fi = files.FirstOrDefault();
            //return fi?.FullName;
        }

        public void PrepareFile(string modPath, string tempPath, Dictionary<string, string> fileList)
        {
            // for test
            //return;

            string tempOriginalPath = Path.Combine(tempPath, "original");

            DeleteDirectory(tempPath);
            PrepareTemp(modPath, tempOriginalPath, fileList);
            DecodeDirectory(tempOriginalPath);
        }

        public void GenerateExcelFromMod(string modPath, string excelPath = null)
        {
            var files = setting.GetSheetConfig();
            var tempPath = Path.Combine(Application.StartupPath, "temp");
            string tempOriginalPath = Path.Combine(tempPath, "original");

            if (String.IsNullOrWhiteSpace(excelPath))
                excelPath = Path.Combine(Application.StartupPath, "output", "translate.xlsx");

            PrepareFile(modPath, tempPath, files);

            var fi = new FileInfo(excelPath);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            List<w3Strings> all = new List<w3Strings>();
            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;
                foreach (var f in files)
                {
                    if (wb.Worksheets[f.Key] != null)
                        wb.Worksheets.Delete(f.Key);


                    var sourcePath = Path.Combine(tempOriginalPath, f.Key + ".w3strings.csv");
                    var content = ReadOriginalCsv(sourcePath, true);
                    all.AddRange(content);

                    if (content.Count == 0)
                        continue;

                    var sht = wb.Worksheets.Add(f.Key);
                    WriteSheetContent(sht, content, false);
                }

                var shtAll = wb.Worksheets["all"];
                if (shtAll != null)
                    wb.Worksheets.Delete(shtAll);

                shtAll = wb.Worksheets.Add("all");
                WriteSheetContent(shtAll, all.OrderBy(a => a.ID).ToList(), false);

                p.Save();
            }
        }

        private void WriteNotTranslateExcel(string excelPath, Dictionary<string, List<w3Strings>> content, bool reOrder)
        {
            var fi = new FileInfo(excelPath);
            if (fi.Exists)
                fi.Delete();

            if (!fi.Directory.Exists)
                fi.Directory.Create();

            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;
                WriteResultSheet(wb, content);

                foreach (var c in content)
                {
                    var empty = c.Value.Where(v => v.EmptyTranslate).ToList();
                    if (empty.Count == 0)
                        continue;

                    var sht = wb.Worksheets.Add(c.Key);
                    if (reOrder)
                        WriteSheetContent(sht, empty.OrderBy(v => v.ID).ToList(), false);
                    else
                        WriteSheetContent(sht, empty, false);
                }

                p.Save();
            }
        }

        private void WriteExcel(string excelPath, Dictionary<string, List<w3Strings>> content, bool sort)
        {
            var fi = new FileInfo(excelPath);
            if (fi.Exists)
                fi.Delete();

            if (!fi.Directory.Exists)
                fi.Directory.Create();

            List<w3Strings> all = new List<w3Strings>();
            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;
                WriteResultSheet(wb, content);

                foreach (var c in content)
                {
                    if (c.Value.Count == 0)
                        continue;

                    all.AddRange(c.Value);
                    var sht = wb.Worksheets.Add(c.Key);
                    if (sort)
                        WriteSheetContent(sht, c.Value.OrderBy(v => v.ID).ToList(), false);
                    else
                        WriteSheetContent(sht, c.Value, false);
                }

                WriteAllContentSheet(wb, all);

                p.Save();
            }
        }

        private void WriteAllContentSheet(ExcelWorkbook wb, List<w3Strings> all)
        {
            var shtAll = wb.Worksheets["all"];
            if (shtAll != null)
                wb.Worksheets.Delete(shtAll);

            shtAll = wb.Worksheets.Add("all");
            WriteSheetContent(shtAll, all.OrderBy(a => a.ID).ToList(), false);
        }

        private void WriteResultSheet(ExcelWorkbook wb, Dictionary<string, List<w3Strings>> contents)
        {
            string sheetName = "Summary";
            string contentName;

            var sht = wb.Worksheets[sheetName];

            if (sht != null)
                wb.Worksheets.Delete(sheetName);

            sht = wb.Worksheets.Add(sheetName);

            const int ROW_START = 3;
            float totalContent = 0;
            float totalNotTranslate = 0;
            float totalTranslate = 0;

            // column width
            sht.Column(1).Width = 30;

            // summary text
            sht.Row(1).Style.Font.Bold = true;
            sht.Cells[1, 1].Value = "Summary";

            // header
            sht.Row(2).Style.Font.Bold = true;
            sht.Cells[2, 1].Value = "Sheet Name";
            sht.Cells[2, 2].Value = "Total Content";
            sht.Cells[2, 3].Value = "Not Translate";
            sht.Cells[2, 4].Value = "Complete";

            var extraSheet = setting.GetExtraSheetConfig();
            var dictSheetName = setting.GetSheetName();

            // detail
            int currRow = ROW_START;
            foreach (var item in contents)
            {
                // skip extra sheet
                if (extraSheet.ContainsKey(item.Key))
                    continue;

                float notTranslate = item.Value.Where(c => String.IsNullOrWhiteSpace(c.Translate)).ToList().Count;
                float translate = item.Value.Count - notTranslate;
                totalNotTranslate += notTranslate;
                totalTranslate += translate;
                totalContent += item.Value.Count;

                if (dictSheetName.ContainsKey(item.Key))
                {
                    contentName = dictSheetName[item.Key];
                }
                else
                {
                    contentName = item.Key;
                }

                sht.Cells[currRow, 1].Value = contentName;
                sht.Cells[currRow, 2].Value = item.Value.Count.ToString("#,0");
                sht.Cells[currRow, 3].Value = notTranslate.ToString("#,0");

                if (item.Value.Count > 0)
                {
                    var complete = translate / item.Value.Count * 100f;
                    var round = Math.Round(complete, 2, MidpointRounding.AwayFromZero);
                    if (round == 100 && translate != item.Value.Count)
                        complete = 99.99f;

                    sht.Cells[currRow, 4].Value = complete.ToString("#,0.00") + "%";
                }
                else
                    sht.Cells[currRow, 4].Value = "N/A";

                currRow++;
            }

            currRow++;
            sht.Cells[currRow, 1].Value = "Total";
            sht.Cells[currRow, 2].Value = contents.Select(c => c.Value.Count).Sum().ToString("#,0");
            sht.Cells[currRow, 3].Value = totalNotTranslate.ToString("#,0");

            if (totalContent > 0)
                sht.Cells[currRow, 4].Value = (totalTranslate / totalContent * 100f).ToString("#,0.00") + "%";
            else
                sht.Cells[currRow, 4].Value = "N/A";

        }

        public List<w3Strings> ReadExcelSheet(ExcelWorksheet sht, bool isReadTranslate)
        {
            if (IsExtrasheet(sht.Name))
                isReadTranslate = true;

            List<w3Strings> result = new List<w3Strings>();

            int row = Excel.ROW_START;
            string id = sht.Cells[row, Excel.COL_ID].Text;
            while (!String.IsNullOrWhiteSpace(id))
            {
                result.Add(new w3Strings(
                        sht.Cells[row, Excel.COL_ID].Text,
                        sht.Cells[row, Excel.COL_KEY_HEX].Text,
                        sht.Cells[row, Excel.COL_KEY_STRING].Text,
                        sht.Cells[row, Excel.COL_TEXT].Text,
                        isReadTranslate ? sht.Cells[row, Excel.COL_TRANSLATE].Text.Replace("\r", "").Replace("\n", "") : null

                        , sht.Name
                        , sht.Cells[row, Excel.COL_ROW].Text.ToIntOrNull()??row
                ));

                row++;
                id = sht.Cells[row, Excel.COL_ID].Text;
            }

            return result;

        }

        private bool IsExtrasheet(string sheetName)
        {
            return setting.GetExtraSheetConfig().ContainsKey(sheetName);
        }

        public void WriteSheetContent(ExcelWorksheet sht, List<w3Strings> content, bool textAsTranslate)
        {
            // write header
            sht.Row(Excel.ROW_START - 1).Style.Font.Bold = true;
            sht.Cells[Excel.ROW_START - 1, Excel.COL_ID].Value = "ID";
            sht.Cells[Excel.ROW_START - 1, Excel.COL_KEY_HEX].Value = "KEY_HEX";
            sht.Cells[Excel.ROW_START - 1, Excel.COL_KEY_STRING].Value = "KEY_STRING";
            sht.Cells[Excel.ROW_START - 1, Excel.COL_TEXT].Value = "MESSAGE";
            sht.Cells[Excel.ROW_START - 1, Excel.COL_TRANSLATE].Value = "TRANSLATE";

            sht.Cells[Excel.ROW_START - 1, Excel.COL_ROW].Value = "ROW";
            //sht.Cells[Excel.ROW_START - 1, Excel.COL_EMPTY].Value = "EMPTY";
            sht.Cells[Excel.ROW_START - 1, Excel.COL_SHEETNAME].Value = "SHEET";


            for (int i = 0; i < content.Count; i++)
            {
                sht.Cells[Excel.ROW_START + i, Excel.COL_ID].Value = content[i].ID;
                sht.Cells[Excel.ROW_START + i, Excel.COL_KEY_HEX].Value = content[i].KeyHex;
                sht.Cells[Excel.ROW_START + i, Excel.COL_KEY_STRING].Value = content[i].KeyString;
                sht.Cells[Excel.ROW_START + i, Excel.COL_TEXT].Value = content[i].Text;

                if (textAsTranslate)
                    sht.Cells[Excel.ROW_START + i, Excel.COL_TRANSLATE].Value = content[i].Text;
                else
                {
                    sht.Cells[Excel.ROW_START + i, Excel.COL_TRANSLATE].Value = content[i].Translate.NullIfEmpty();
                }

                sht.Cells[Excel.ROW_START + i, Excel.COL_ROW].Value = content[i].RowNumber;
                //sht.Cells[Excel.ROW_START + i, Excel.COL_EMPTY].Value = content[i].EmptyTranslate;
                sht.Cells[Excel.ROW_START + i, Excel.COL_SHEETNAME].Value = content[i].SheetName;

            }
        }

        private int FillSheetContentDictionary(ExcelWorksheet sht, List<w3Strings> content, bool fillText, bool fillTranslate)
        {
            int fill = 0;

            var d = BuildMessageDictionary(sht, Excel.ROW_START);
            foreach (var c in content)
            {
                if (d.ContainsKey(c.ID.Trim()))
                {
                    var row = d[c.ID.Trim()];

                    if (fillText)
                        sht.Cells[row, Excel.COL_TEXT].Value = c.Text;

                    if (fillTranslate)
                        sht.Cells[row, Excel.COL_TRANSLATE].Value = c.Text;

                    fill++;
                }
            }

            return fill;
        }

        private int FillSheetContent(ExcelWorksheet sht, List<w3Strings> content, int col)
        {
            int fill = 0;

            int row = Excel.ROW_START - 1;
            foreach (var c in content)
            {
                row = FindMessageRow(sht, c.ID, row + 1);
                if (row > 0)
                {
                    sht.Cells[row, col].Value = c.Text;
                    fill++;
                }
                else
                {
                    return fill;
                }

            }

            return fill;
        }

        private Dictionary<string, int> BuildMessageDictionary(ExcelWorksheet sht, int startRow)
        {
            var result = new Dictionary<string, int>();

            int curRow = startRow;
            string id = sht.Cells[curRow, Excel.COL_ID].Value as string;
            while (!String.IsNullOrWhiteSpace(id))
            {
                result.Add(id.Trim(), curRow);
                id = sht.Cells[Excel.COL_ID, ++curRow].Value as string;
            }

            return result;
        }

        public string FillExcelFromMod(string modPath, string excelPath, bool fillTranslate)
        {
            string result = "Fill Result" + Environment.NewLine;
            result += new string('=', 20) + Environment.NewLine;


            var files = setting.GetSheetConfig();
            var tempPath = Path.Combine(Application.StartupPath, "temp");
            string tempOriginalPath = Path.Combine(tempPath, "original");

            PrepareFile(modPath, tempPath, files);

            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {

                var wb = p.Workbook;
                foreach (var f in files)
                {
                    var sourcePath = Path.Combine(tempOriginalPath, f.Key + ".w3strings.csv");
                    var content = ReadOriginalCsv(sourcePath, true);

                    var sht = p.Workbook.Worksheets[f.Key];
                    if (sht == null)
                    {
                        sht = wb.Worksheets.Add(f.Key);
                        WriteSheetContent(sht, content, true);
                    }
                    else
                    {
                        var fill = FillSheetContentDictionary(sht, content, !fillTranslate, fillTranslate);
                        result += $@"    {sht.Name} {fill}/{content.Count} row(s)" + Environment.NewLine;
                    }

                }

                p.Save();
            }

            return result;
        }

        public string FillExcelFromExcel(string sourcePath, string targetPath, bool fillText, bool fillTranslate)
        {
            var sheets = setting.GetSheetConfig();

            var contents = ReadExcel(sourcePath, sheets, true);
            var result = FillExcel(targetPath, contents, sheets, fillText, fillTranslate);

            return result;
        }

        public string FillExcel(string excelPath, Dictionary<string, List<w3Strings>> contents, Dictionary<string, string> sheets, bool fillText, bool fillTranslate)
        {
            string result = "Fill Result" + Environment.NewLine;
            result += new string('=', 20) + Environment.NewLine;

            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {

                var wb = p.Workbook;
                foreach (var s in sheets)
                {
                    if (!contents.ContainsKey(s.Key))
                        continue;

                    var content = contents[s.Key];

                    var sht = p.Workbook.Worksheets[s.Key];
                    if (sht == null)
                    {
                        sht = wb.Worksheets.Add(s.Key);
                        WriteSheetContent(sht, content, true);
                    }
                    else
                    {
                        var fill = FillSheetContentDictionary(sht, content, fillText, fillTranslate);
                        result += $@"    {sht.Name} {fill}/{content.Count} row(s)" + Environment.NewLine;
                    }

                }
                p.Save();
            }

            return result;
        }

        public int FindMessageRow(ExcelWorksheet sht, string messageID, int startRow)
        {
            int curRow = startRow;
            string id = sht.Cells[curRow, Excel.COL_ID].Value as string;
            while (!String.IsNullOrWhiteSpace(id))
            {
                if (id.Trim() == messageID.Trim())
                    return curRow;

                id = sht.Cells[Excel.COL_ID, ++curRow].Value as string;
            }

            return -1;
        }

        public void GenerateMod(Dictionary<string, List<w3Strings>> contents, string outputPath, bool combine, bool originalFirst, Dictionary<string, string> sheetConfig, bool includeNotTranslateMessageId, bool includeTranslateMessageId, bool IncludeUiMessageId, bool translateUI)
        {
            var tempPath = Path.Combine(Application.StartupPath, "temp");

            foreach (var sheet in contents)
            {
                var content = Translate(sheet.Value, combine, originalFirst, includeNotTranslateMessageId, includeTranslateMessageId, IncludeUiMessageId, translateUI);

                var path = Path.Combine(tempPath, sheet.Key + ".csv");
                WriteCsv(content, path);
                EncodeW3String(path);
            }

            FinishMod(tempPath, outputPath, sheetConfig);
        }

        public void GenerateModAlt(Dictionary<string, List<w3Strings>> contents, string outputPath, bool combine, bool originalFirst, Dictionary<string, string> sheetConfig, bool includeNotTranslateMessageId, bool includeTranslateMessageId, bool IncludeUiMessageId, eFontSetting font, bool translateUI, bool alternativeTranslate)
        {
            DeleteDirectory(outputPath);

            var tempPath = Path.Combine(Application.StartupPath, "temp");

            // merge all message
            var allMessage = new List<w3Strings>();
            foreach (var sheet in contents)
            {
                allMessage.AddRange(sheet.Value);
            }

            if (alternativeTranslate)
            {
                var allMessageDict = ConvertToDictionary(allMessage);
                var customTranslate = ReadCustomTranslate();
                FillCustomTranslate(allMessageDict, customTranslate);
                allMessage = ConvertToList(allMessageDict);
            }


            // write duplicate sheet
            // WriteDupplicate(allMessage, outputPath);

            // remove dupplicate
            //var distinct = allMessage
            //            .GroupBy(x => x.ID)
            //            .Select(g => g.First())
            //            .ToList();

            var content = Translate(allMessage, combine, originalFirst, includeNotTranslateMessageId, includeTranslateMessageId, IncludeUiMessageId, translateUI);            

            var path = Path.Combine(tempPath, "message" + ".csv");
            WriteCsv(content, path);
            var w3sPath = EncodeW3String(path);
            var targetW3sPath = Path.Combine(outputPath, Configs.modThaiLanguage, "content", "en.w3strings");

            var fi = new FileInfo(targetW3sPath);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            File.Copy(
                w3sPath,
                targetW3sPath,
                true
            );

            // font
            switch (font)
            {
                case eFontSetting.Sarabun:
                    InstallFontSarabun(outputPath);
                    break;
                case eFontSetting.KoonToon:
                    InstallFontKuntoon(outputPath);
                    break;
            }

            // subtitle
            InstallSubtitleMod(outputPath);

            WriteVersionUnofficial(outputPath, "unofficial");

        }

        private void FillCustomTranslate(Dictionary<string, w3Strings> contentDict, List<w3Strings> customTranslate)
        {
            foreach (var message in customTranslate)
            {
                if (contentDict.ContainsKey(message.IdKey))
                {
                    var w3s = contentDict[message.IdKey];

                    //w3s.Locked = true;
                    w3s.Translate = message.Translate;
                    w3s.SheetName = message.SheetName;
                    w3s.RowNumber = message.RowNumber;
                    if (!String.IsNullOrWhiteSpace(message.Text))
                        w3s.Text = message.Text;

                    
                    
                }
            }
        }

        private List<w3Strings> ReadCustomTranslate()
        {
            string path = Configs.CustomTranslateFilePath;

            var fi = new FileInfo(path);
            if (!fi.Exists)
                return new List<w3Strings>();

            using (var p = new ExcelPackage(fi))
            {
                var sht = p.Workbook.Worksheets[1];
                var result = ReadExcelSheet(sht, true);
                return result;
            }

        }

        private List<w3Strings> DistinctContent(List<w3Strings> content)
        {
            var dict = new Dictionary<string, w3Strings>();
            foreach (var item in content)
            {
                if (dict.ContainsKey(item.IdKey))
                {
                    var exist = dict[item.IdKey];
                    if (item.TranslateStatus > exist.TranslateStatus)
                        dict[item.IdKey] = item;
                }
                else
                {
                    dict.Add(item.IdKey, item);
                }
            }

            return dict.Select(d => d.Value).ToList();
        }

        private void WriteDupplicate(List<w3Strings> allMessage, string outputPath)
        {
            // get all dupplicate message by id
            //var dupp = allMessage
            //           .GroupBy(x => x.ID)
            //           .Where(g => g.Count() > 1)
            //           .SelectMany(g => g)
            //           .OrderBy(d=>d.ID)
            //           .ToList();

            // get all dupplicate message by text
            var dupp = allMessage
                       .GroupBy(x => x.Text)
                       .Where(g => g.Count() > 1)
                       .SelectMany(g => g)
                       .OrderBy(d => d.ID)
                       .ToList();

            // get all translate message
            var translated = dupp.Where(d => d.TranslateStatus > w3Strings.eTranslateStatus.NotTranslate).ToList();

            // get all not reanslate message
            var notTranslate = dupp.Where(d => d.TranslateStatus == w3Strings.eTranslateStatus.NotTranslate).ToList();

            // build message list
            var messageDict = new Dictionary<string, w3Strings>();
            foreach (var item in translated)
            {
                if (!messageDict.ContainsKey(item.IdKey))
                {
                    messageDict.Add(item.IdKey, item);
                }
                else
                {
                    if (item.TranslateStatus > messageDict[item.IdKey].TranslateStatus)
                        messageDict[item.IdKey] = item;
                }
            }

            // create sheet content
            var contents = new Dictionary<string, List<w3Strings>>();
            contents.Add("DUPPLICATE", dupp);
            foreach (var item in notTranslate)
            {
                if (!contents.ContainsKey(item.SheetName))
                    contents.Add(item.SheetName, new List<w3Strings>());

                if (messageDict.ContainsKey(item.IdKey))
                {
                    item.Translate = messageDict[item.IdKey].Translate;
                    contents[item.SheetName].Add(item);
                }
            }

            // write excel
            var duppPath = Path.Combine(outputPath, "dupplicate.xlsx");
            WriteExcel(duppPath, contents, true);
        }

        public void GenerateModFromExcel(string excelPath, string outputPath, bool combine, bool originalFirst, bool includeMessageId = false)
        {
            var tempPath = Path.Combine(Application.StartupPath, "temp");
            var sheetConfig = setting.GetSheetConfig();

            var raw = ReadExcel(excelPath, sheetConfig, true);

            GenerateMod(raw, outputPath, combine, originalFirst, sheetConfig, false, false, false, true);
        }

        public Dictionary<string, List<w3Strings>> ReadExcel(string excelPath, Dictionary<string, string> sheetConfig, bool isReadTranslate)
        {
            var result = new Dictionary<string, List<w3Strings>>();

            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {
                if (sheetConfig == null)
                {
                    sheetConfig = new Dictionary<string, string>();
                    foreach (var sht in p.Workbook.Worksheets)
                    {
                        if (sht.Cells[2, 1].Text == "ID")
                            sheetConfig.Add(sht.Name, null);
                    }
                }

                foreach (var s in sheetConfig)
                {
                    var sht = p.Workbook.Worksheets[s.Key];
                    if (sht != null)
                    {
                        var content = ReadExcelSheet(sht, isReadTranslate);
                        result.Add(s.Key, content);
                    }
                    else
                    {
                        continue;
                    }
                }

                return result;

            }
        }

        public DialogResult Processing(Action worker, string title = "Processing", string completeMessage = "Complete")
        {
            return Processing(worker, true, title, completeMessage);
        }

        public DialogResult Processing(Action worker, bool showCompleteMessage, string title = "Processing", string completeMessage = "Complete")
        {
            using (var dlg = new ProcessingDialog(worker, title))
            {
                dlg.ShowDialog();
                if (dlg.DialogResult == DialogResult.OK)
                {
                    if (showCompleteMessage)
                        ShowMessage(completeMessage);
                }
                else
                {
                    ShowErrorMessage(dlg.Message);
                }

                return dlg.DialogResult;
            }
        }

        public void ProcessingString(Func<string> worker, string title = "Processing", string completeMessage = "Complete")
        {
            ProcessingString(worker, title, true, completeMessage);
        }

        public string ProcessingStringSilence(Func<string> worker, string title = "Processing", bool showCompleteMessage = true, string completeMessage = "Complete")
        {
            string result = null;
            using (var dlg = new ProcessingDialog(title))
            {
                dlg.ShowError = false;
                dlg.SetWorkerString(worker);
                dlg.ShowDialog();
                if (dlg.DialogResult == DialogResult.OK)
                {
                    result = dlg.Message;

                    if (showCompleteMessage)
                        ShowMessage(result, completeMessage);
                }
            }

            return result;
        }

        public string ProcessingString(Func<string> worker, string title = "Processing", bool showCompleteMessage = true, string completeMessage = "Complete")
        {
            string result = null;
            using (var dlg = new ProcessingDialog(title))
            {
                dlg.SetWorkerString(worker);
                dlg.ShowDialog();
                if (dlg.DialogResult == DialogResult.OK)
                {
                    result = dlg.Message;

                    if (showCompleteMessage)
                        ShowMessage(result, completeMessage);
                }
                else
                {
                    ShowErrorMessage(dlg.Message);
                }
            }

            return result;
        }

        public void FilterExcel(string excelPath, string outputPath, bool emptyTranslate, bool translated, bool sameWord, bool singleWord, bool uiText, string containText, bool sortByTextLength)
        {
            var contents = ReadExcel(excelPath, null, true);
            var result = new Dictionary<string, List<w3Strings>>();

            foreach (var c in contents)
            {
                var filtered = SortContent(FillterContent(c.Value, emptyTranslate, translated, sameWord, singleWord, uiText, containText), sortByTextLength);
                result.Add(
                    c.Key,
                    filtered
                );
            }

            WriteExcel(outputPath, result, false);
        }

        private List<w3Strings> FillterContent(List<w3Strings> content, bool emptyTranslate, bool translated, bool sameWord, bool singleWord, bool uiText, string containText)
        {
            List<w3Strings> result = new List<w3Strings>();

            if (!emptyTranslate && !sameWord && !singleWord && !uiText && String.IsNullOrWhiteSpace(containText))
                result = content;

            if (emptyTranslate)
                result.AddRange(content.Where(c => String.IsNullOrWhiteSpace(c.Translate)).ToList());

            if (singleWord)
                result.AddRange(content.Where(c => !c.Text.Contains(" ")).ToList());

            if (sameWord)
                result.AddRange(content.Where(c => c.Text.GetCompareString() == c.Translate.GetCompareString()).ToList());

            if (uiText)
                result.AddRange(content.Where(c => c.IsConversation == false).ToList());

            if (!String.IsNullOrEmpty(containText))
            {
                //result.AddRange(content.Where(c => !c.Text.Contains(containText) && (c.Translate?.Contains(containText)??false) ).ToList());
                result.AddRange(content.Where(c =>
                    c.Text.ToLower().Contains(containText.ToLower()) ||
                    (c.Translate?.ToLower().Contains(containText.ToLower()) ?? false)
                ).ToList());
            }

            if (translated)
                result = result.Where(c => !String.IsNullOrWhiteSpace(c.Translate)).ToList();

            // ใส่ <br> เกิน
            //result = result.Where(r =>
            //    (r.Translate?.Contains("<br>") ?? false) &&
            //    r.Translate.Split(new string[] { "<br>" }, StringSplitOptions.None).Length >
            //    r.Text.Split(new string[] { "<br>" }, StringSplitOptions.None).Length
            //).ToList();

            // <br> มากเกินไป
            //result = result.Where(r => r.Translate.Split(new string[] { "<br>"},StringSplitOptions.None).Length>3).ToList();

            return result.Distinct().ToList();

        }

        private List<w3Strings> SortContent(List<w3Strings> content, bool sortByTextLength)
        {
            if (sortByTextLength)
                return content.OrderBy(c => c.Text.Length).ToList();
            else
                return content.OrderBy(c => c.ID.Trim()).ToList();
        }


        public void OpenFileDirectory(string filePath)
        {
            var fi = new FileInfo(filePath);
            if (fi.Exists)
                Open(fi.Directory.FullName);

        }

        /// <summary>
        /// merge excel2 to excel1
        /// can select message source 
        /// source excel1 : find not translate text and get from excel2
        /// source excel2 : use all translate message from excel2
        /// add new message if not exist
        /// </summary>
        public void MergeExcel(string sourcePath, string translatePath, string outputPath, bool addNewMessage, bool replaceTranslate, bool replaceText)
        {
            // result file name
            var fi = new FileInfo(outputPath);
            var resultPath = Path.Combine(fi.Directory.FullName, Path.GetFileNameWithoutExtension(outputPath) + "_result" + Path.GetExtension(outputPath));

            // delete for check file in use
            if (File.Exists(outputPath))
                File.Delete(outputPath);
            if (File.Exists(resultPath))
                File.Delete(resultPath);

            var sheetConfig = setting.GetSheetConfig();
            var source = ReadExcel(sourcePath, sheetConfig, true);
            var translate = ReadExcel(translatePath, sheetConfig, true);
            var newTranslate = new Dictionary<string, List<w3Strings>>();

            // fill message
            // move to under replace translate for improve performance
            // move to over  replace translate for correct new translate result
            source = FillEmptyTranslate(source, translate, out newTranslate);

            if (replaceText)
                source = ReplaceText(source, translate);

            if (replaceTranslate)
                source = ReplaceTranslate(source, translate);

            if (addNewMessage)
                source = AddNewMessage(source, translate);

            WriteExcel(outputPath, source, addNewMessage);
            WriteExcel(resultPath, newTranslate, addNewMessage);
        }

        private Dictionary<string, List<w3Strings>> ReplaceTranslate(Dictionary<string, List<w3Strings>> source, Dictionary<string, List<w3Strings>> translate)
        {
            foreach (var sheet in source)
            {
                if (!translate.ContainsKey(sheet.Key))
                    continue;

                var content = ConvertToDictionary(sheet.Value);

                var messages = translate[sheet.Key].Where(t => !String.IsNullOrWhiteSpace(t.Translate));
                foreach (var msg in messages)
                {
                    if (content.ContainsKey(msg.ID.Trim()))
                        content[msg.ID.Trim()].Translate = msg.Translate;
                }
            }

            return source;
        }

        private Dictionary<string, List<w3Strings>> ReplaceText(Dictionary<string, List<w3Strings>> source, Dictionary<string, List<w3Strings>> translate)
        {
            foreach (var sheet in source)
            {
                if (!translate.ContainsKey(sheet.Key))
                    continue;

                var content = ConvertToDictionary(sheet.Value);

                var messages = translate[sheet.Key].Where(t => !String.IsNullOrWhiteSpace(t.Text));
                foreach (var msg in messages)
                {
                    if (content.ContainsKey(msg.ID.Trim()))
                        content[msg.ID.Trim()].Text = msg.Text;
                }
            }

            return source;
        }

        private Dictionary<string, List<w3Strings>> AddNewMessage(Dictionary<string, List<w3Strings>> content, Dictionary<string, List<w3Strings>> translateContent)
        {
            foreach (var sheet in content)
            {
                if (!translateContent.ContainsKey(sheet.Key))
                    continue;

                var translate = translateContent[sheet.Key];
                var sheetMessage = sheet.Value.Select(s => s.ID.Trim()).ToList();

                var newMessages = translate.Where(m => !sheetMessage.Contains(m.ID.Trim())).ToList();
                sheet.Value.AddRange(newMessages);
            }

            return content;
        }

        private Dictionary<string, List<w3Strings>> FillEmptyTranslate(Dictionary<string, List<w3Strings>> sourceContents, Dictionary<string, List<w3Strings>> translateContents, out Dictionary<string, List<w3Strings>> newTranslate)
        {
            newTranslate = new Dictionary<string, List<w3Strings>>();

            foreach (var s in sourceContents)
            {
                if (!translateContents.ContainsKey(s.Key))
                    continue;

                var ntContent = new List<w3Strings>();
                var t = ConvertToDictionary(translateContents[s.Key]);
                var emptyList = GetEmptyTramslate(s.Value);
                foreach (var empty in emptyList)
                {
                    var id = empty.ID.Trim();
                    if (t.ContainsKey(id) && !String.IsNullOrWhiteSpace(t[id].Translate))
                    {
                        empty.Translate = t[id].Translate;
                        ntContent.Add(t[id]);
                    }
                }

                newTranslate.Add(s.Key, ntContent);
            }

            return sourceContents;
        }

        private Dictionary<string, List<w3Strings>> GetEmptyTramslate(Dictionary<string, List<w3Strings>> source)
        {
            Dictionary<string, List<w3Strings>> result = new Dictionary<string, List<w3Strings>>();
            foreach (var item in source)
            {
                List<w3Strings> empty = GetEmptyTramslate(item.Value);
                if (empty.Count > 0)
                {
                    result.Add(item.Key, empty);
                }

            }

            return result;
        }

        private List<w3Strings> GetEmptyTramslate(List<w3Strings> w3s)
        {
            var result = w3s.Where(w => String.IsNullOrWhiteSpace(w.Translate)).ToList();
            return result;
        }

        public void UpdateFont(string modThaiPath)
        {
            string sourcePath = Path.Combine(modThaiPath, "mods", Configs.modKuntoonFont, "content");
            string targetPath = Path.Combine(Configs.StartupPath, "Tools", Configs.modThaiFont, "content");

            CopyDirectory(sourcePath, targetPath);
        }

        public void UpdateFontOld(string downloadPath)
        {
            string sourcePath = Path.Combine(downloadPath, "mods");
            string targetPath = Path.Combine(Application.StartupPath, "Tools", "font.zip");
            string backupPath = Path.Combine(Application.StartupPath, "Tools", "font_bak.zip");

            try
            {
                if (Directory.Exists(sourcePath))
                {
                    // backup font
                    if (File.Exists(targetPath))
                        File.Move(targetPath, backupPath);

                    // zip font
                    ZipFile.CreateFromDirectory(
                        sourcePath,
                        targetPath,
                        System.IO.Compression.CompressionLevel.Fastest,
                        true
                    );

                    // delete backup
                    File.Delete(backupPath);

                }
            }
            catch (Exception)
            {
                // restore backup
                //if (File.Exists(targetPath))
                //    File.Delete(backupPath);
                //else
                File.Move(backupPath, targetPath);
            }

        }

        public void InstallFontMod(eFontSetting font, string outputPath)
        {
            switch (font)
            {
                case eFontSetting.Sarabun:
                    InstallFontSarabun(outputPath);
                    break;
                case eFontSetting.KoonToon:
                    InstallFontKuntoon(outputPath);
                    break;
            }
        }

        public void InstallFontSarabun(string gamePath)
        {
            //RemoveOldFont(gamePath);

            string modPath = Path.Combine(Application.StartupPath, "Tools", Configs.modFontSarabun);
            var targetPath = Path.Combine(gamePath, Configs.modThaiFont);

            CopyDirectory(modPath, targetPath);
        }

        public void InstallFontKuntoon(string gamePath)
        {
            string modPath = Path.Combine(Application.StartupPath, "Tools", Configs.modThaiFont);
            var targetPath = Path.Combine(gamePath, Configs.modThaiFont);

            CopyDirectory(modPath, targetPath);
        }

        public void InstallFontModOld(string gamePath)
        {
            string modPath = Path.Combine(Application.StartupPath, "Tools", "font.zip");
            ZipFile.ExtractToDirectory(modPath, gamePath);
        }

        public bool CheckFontMod(string gamePath)
        {
            string modPath = Path.Combine(gamePath, "mods", Configs.modKuntoonFont);
            if (Directory.Exists(modPath))
                return true;

            modPath = Path.Combine(gamePath, "mods", Configs.modFontSarabun);
            if (Directory.Exists(modPath))
                return true;

            return false;
        }

        public bool CheckSubtitleMod(string gamePath)
        {
            string modPath = Path.Combine(gamePath, "mods", Configs.modDoubleSubtitle);
            if (Directory.Exists(modPath))
                return true;

            return false;
        }

        public void RemoveOldFont(string gamePath)
        {
            string modPath = Path.Combine(gamePath, "mods", Configs.modKuntoonFont);
            if (Directory.Exists(modPath))
                DeleteDirectory(modPath);
        }

        public void RemoveMod(string gamePath)
        {
            string modPath = Path.Combine(gamePath, "mods", Configs.modThaiLanguage);
            if (Directory.Exists(modPath))
                DeleteDirectory(modPath);

            string fontPath = Path.Combine(gamePath, "mods", Configs.modThaiFont);
            if (Directory.Exists(fontPath))
                DeleteDirectory(fontPath);
        }

        public void InstallMod(string modPath, string gamePath, bool removeKuntoonFont = false)
        {
            var skips = new List<string>();
            skips.Add(Path.Combine(modPath, "version.ini"));
            skips.Add(Path.Combine(modPath, "result.xlsx"));
            skips.Add(Path.Combine(modPath, "translate.xlsx"));
            skips.Add(Path.Combine(modPath, "dupplicate.xlsx"));
            skips.Add(Path.Combine(modPath, "version_storybook.ini"));

            string gameModPath = Path.Combine(gamePath, "mods");

            // delete old mod
            string oldModPath = Path.Combine(gameModPath, Configs.modThaiLanguage);
            if (Directory.Exists(oldModPath))
                DeleteDirectory(oldModPath);

            string oldFontPath = Path.Combine(gameModPath, Configs.modThaiFont);
            if (Directory.Exists(oldFontPath))
                DeleteDirectory(oldFontPath);

            // delete kuntoon mod
            if (removeKuntoonFont)
                RemoveOldFont(gamePath);

            CopyDirectory(modPath, gameModPath, skips);
        }

        public void InstallSubtitleMod(string modPath)
        {
            string sourcePath = Path.Combine(Application.StartupPath, "Tools", Configs.modDoubleSubtitle);
            //var targetPath = Path.Combine(gamePath, "mods", Configs.modThaiLanguage);
            var targetPath = Path.Combine(modPath, Configs.modThaiLanguage);
            CopyDirectory(sourcePath, targetPath);
        }

        public void ChangeFontSize(string modPath, int sizeCutScene, int sizeSpeak)
        {
            string pathScript = @"content\scripts\game\gui\hud\modules";
            string pathDialog = Path.Combine(modPath, pathScript, "hudModuleDialog.ws");
            string pathSubtitle = Path.Combine(modPath, pathScript, "hudModuleSubtitles.ws");

            ReplaceAll(pathDialog, @"<FONT SIZE='28'>", $@"<FONT SIZE='{sizeCutScene}'>");
            ReplaceAll(pathSubtitle, @"<FONT SIZE='28'>", $@"<FONT SIZE='{sizeSpeak}'>");

        }

        public void UpgradeToFullTranslate(string targetPath)
        {
            // rename en to tr
            var w3stringPath = Path.Combine(targetPath, "content", "en.w3strings");
            var fi = new FileInfo(w3stringPath);
            if (fi.Exists)
                fi.MoveTo(w3stringPath.Replace("en.w3strings", "tr.w3strings"));

        }

        public void InstallModStoryBook(string modPath, string targetPath)
        {
            if (!Directory.Exists(modPath))
                return;

            var skips = new List<string>();
            skips.Add(Path.Combine(modPath, "version_storybook.ini"));

            // copy mod
            CopyDirectory(modPath, targetPath, skips);

        }

        private void ReplaceAll(string path, string textToReplace, string replaceWith)
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                text = text.Replace(textToReplace, replaceWith);
                File.WriteAllText(path, text);
            }
        }

        public void GenerateLegacyMod(string excelPath, string outputPath, bool doubleLanguage, bool originalFirst, bool includeNotTranslateMessageId, bool includeTranslateMessageId, bool IncludeUiMessageId, bool translateUI)
        {
            string templatePath = Configs.TemplateFilePath;
            if (!File.Exists(templatePath))
                throw new Exception("ไม่พบ Template กรุณาต่ออินเตอร์เน็ตและเปิดโปรแกรมใหม่เพิ่อดาวน์โหลดไฟล์ Template");

            var sheetConfig = setting.GetSheetConfig();
            var template = ReadExcel(templatePath, sheetConfig, true);
            var translate = ReadExcelLegacy(excelPath, sheetConfig);

            var content = MergeLegacy(template, translate);

            GenerateMod(content, outputPath, doubleLanguage, originalFirst, sheetConfig, includeNotTranslateMessageId, includeTranslateMessageId, IncludeUiMessageId, translateUI);

            // write all text excel file for later use
            string tempPath = Path.Combine(outputPath, "translate.xlsx");
            WriteExcel(tempPath, content, false);

            // write result
            string legacyExcel = Path.Combine(outputPath, "result.xlsx");
            WriteNotTranslateExcel(legacyExcel, content, false);

        }

        public void GenerateLegacyModAlt(string excelPath, string outputPath, bool doubleLanguage, bool originalFirst, bool includeNotTranslateMessageId, bool includeTranslateMessageId, bool includeUiMessageId, eFontSetting font, bool translateUI, bool alternativeTranslate)
        {
            string templatePath = Configs.TemplateFilePath;
            if (!File.Exists(templatePath))
                throw new Exception("ไม่พบ Template กรุณาต่ออินเตอร์เน็ตและเปิดโปรแกรมใหม่เพิ่อดาวน์โหลดไฟล์ Template");

            var sheetConfig = setting.GetSheetConfig();
            var template = ReadExcel(templatePath, sheetConfig, alternativeTranslate);
            var translate = ReadExcelLegacy(excelPath, sheetConfig);

            var content = MergeLegacy(template, translate);

            GenerateModAlt(content, outputPath, doubleLanguage, originalFirst, sheetConfig, includeNotTranslateMessageId, includeTranslateMessageId, includeUiMessageId, font, translateUI, alternativeTranslate);

            // write all text excel file for later use
            string tempPath = Path.Combine(outputPath, "translate.xlsx");
            WriteExcel(tempPath, content, false);

            // write result
            string legacyExcel = Path.Combine(outputPath, "result.xlsx");
            WriteNotTranslateExcel(legacyExcel, content, false);

        }

        public Dictionary<string, List<w3Strings>> MergeLegacy(Dictionary<string, List<w3Strings>> template, Dictionary<string, List<w3Strings>> translate)
        {
            List<TranslateResult> results = new List<TranslateResult>();
            List<w3Strings> skipSource;
            List<w3Strings> skipTranslate;
            var content = new Dictionary<string, List<w3Strings>>();

            //float totalTotalMatch = 0, totalNotTranslate = 0, totalContent = 0;
            //var sb = new StringBuilder();
            //sb.AppendLine("Generate Result");
            //sb.AppendLine(new string('=', 20));


            foreach (var sheet in template)
            {
                if (!translate.ContainsKey(sheet.Key))
                {
                    content.Add(sheet.Key, sheet.Value);
                    continue;
                }

                var mergeContent = MergeLegacySheet(sheet.Value, translate[sheet.Key], true, out skipSource, out skipTranslate);

                content.Add(sheet.Key, mergeContent);

                // result
                //float matchCount = sourceContent.Count - skipSource.Count;
                //float skipTranslateCount = skipTranslate.Count;
                //totalTotalMatch += matchCount;
                //totalNotTranslate += skipTranslate.Count;
                //totalContent += sourceContent.Count;
                //sb.AppendLine($@"{sht.Name}");
                //sb.AppendLine($@"    match            : {matchCount:#,0}/{sourceContent.Count:#,0} ({matchCount / sourceContent.Count * 100f:#,0}%)");
                //sb.AppendLine($@"    not translate: {skipTranslateCount:#,0} ({skipTranslateCount / sourceContent.Count * 100f:#,0}%)");

            }

            // total result
            //sb.AppendLine(new string('-', 20));
            //sb.AppendLine($@"Total");
            //sb.AppendLine($@"    match            : {totalTotalMatch:#,0}/{totalContent:#,0} ({totalTotalMatch / totalContent * 100f:#,0}%)");
            //sb.AppendLine($@"    not translate: {totalNotTranslate:#,0} ({totalNotTranslate / totalContent * 100f:#,0}%)");


            return content;

        }

        public DateTime GetBuildDate(Version version)
        {
            var date = new DateTime(2000, 1, 1)                 // baseline is 01/01/2000
                            .AddDays(version.Build)             // build is number of days after baseline
                            .AddSeconds(version.Revision * 2);  // revision is half the number of seconds into the day

            return date;
        }

        public string GetVersionText(Version version)
        {
            //return $@"{GetBuildDate(version):yyyy.MM.dd.HHmm}";
            return GetBuildDate(version).ToString("yyyy.MM.dd.HHmm", CultureInfo.InvariantCulture);
        }

        public void GenerateExcelFromCsv(string input, string output)
        {
            var data = ReadOriginalCsv(input, true);
            var dupp = data
                        .GroupBy(x => x.ID)
                        .Where(g => g.Count() > 1)
                        .SelectMany(g => g)
                        .ToList();

            var distinct = data
                        .GroupBy(x => x.ID)
                        .Select(g => g.First())
                        .ToList();

            var content = new Dictionary<string, List<w3Strings>>();
            content.Add("content", data);
            content.Add("dupplicate", dupp);
            content.Add("distinct", distinct);

            WriteExcel(output, content, true);
        }

        public void ConvertStorybookToExcel(string modPath, string outputPath)
        {
            var data = ReadStoryBook(modPath);
            WriteStorybookExcel(data, outputPath);

        }

        private List<Storybook> ReadStoryBook(string modPath)
        {
            var data = new List<Storybook>();
            foreach (string path in Directory.GetFiles(modPath, "*.subs", SearchOption.AllDirectories))
            {
                var fi = new FileInfo(path);
                data.Add(ReadSubs(path));
            }

            return data;
        }

        private void WriteStorybookExcel(List<Storybook> content, string outputPath)
        {
            var fi = new FileInfo(outputPath);
            if (fi.Exists)
                fi.Delete();

            if (!fi.Directory.Exists)
                fi.Directory.Create();

            content = content.OrderBy(c => c.UniqueName).ToList();

            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;

                foreach (var c in content)
                {
                    //// remove sheet if exist
                    //if (wb.Worksheets[c.SheetName] != null)
                    //    wb.Worksheets.Delete(c.SheetName);

                    var sht = wb.Worksheets.Add(c.SheetName);
                    WriteStorybookSheet(sht, c);
                }

                p.Save();
            }
        }

        private void WriteStorybookSheet(ExcelWorksheet sht, Storybook data)
        {
            int row = 1;

            // write filepath
            sht.Cells[row++, 1].Value = data.FilePath;

            // write header
            sht.Row(2).Style.Font.Bold = true;
            sht.Cells[row, 1].Value = "START";
            sht.Cells[row, 2].Value = "STOP";
            sht.Cells[row, 3].Value = "MESSAGE";
            sht.Cells[row, 4].Value = "TRANSLATE";
            row++;

            foreach (var c in data.Content)
            {
                sht.Cells[row, 1].Value = c.Start;
                sht.Cells[row, 2].Value = c.Stop;
                sht.Cells[row, 3].Value = c.Message;
                sht.Cells[row, 4].Value = c.Translate;

                if (!String.IsNullOrWhiteSpace(c.Start))
                    row++;
            }
        }

        private Storybook ReadSubs(string path)
        {
            var lines = File.ReadAllLines(path);
            var result = new Storybook(path, lines.ToList());
            return result;
        }

        public void GenerateStorybook(string excelPath, string outputPath)
        {
            var data = ReadStoryBookExcel(excelPath);
            WriteAllStorybook(outputPath, data);
        }

        private List<Storybook> ReadStoryBookExcel(string excelPath)
        {
            var result = new List<Storybook>();

            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {
                foreach (var sht in p.Workbook.Worksheets)
                {
                    var data = ReadStoryBookSheet(sht);
                    if (data != null)
                    {
                        result.Add(data);
                    }
                }

            }

            return result;
        }

        private Storybook ReadStoryBookSheet(ExcelWorksheet sht)
        {
            var fileName = sht.Cells[1, 1].Value as string;
            if (String.IsNullOrEmpty(fileName))
                return null;

            var result = new Storybook(fileName);

            int row = ROW_STORYBOOK_START;
            string start = sht.Cells[row, 1].Value.ToStringOrNull();
            while (!String.IsNullOrWhiteSpace(start))
            {
                result.Content.Add(new StorybookRow()
                {
                    Start = start,
                    Stop = sht.Cells[row, 2].Value.ToStringOrNull(),
                    Message = sht.Cells[row, 3].Value.ToStringOrNull(),
                    Translate = sht.Cells[row, 4].Value.ToStringOrNull()?.Trim()
                });

                start = sht.Cells[++row, 1].Value.ToStringOrNull();
            }

            return result;


        }

        private void WriteAllStorybook(string outputRoot, List<Storybook> data)
        {
            // clear story book
            DeleteDirectory(outputRoot);
            Directory.CreateDirectory(outputRoot);

            foreach (var d in data)
            {
                if (!d.IsComplete())
                    continue;

                WriteStorybook(outputRoot, d);
            }
        }

        private void WriteStorybook(string outputRoot, Storybook d)
        {
            var arr = d.FilePath.Split(new string[] { @"\files\" }, StringSplitOptions.None);
            if (arr.Length != 2)
                return;

            var targetPath = Path.Combine(outputRoot, arr[1]);
            var fi = new FileInfo(targetPath);
            if (fi.Exists)
                fi.Delete();

            if (!fi.Directory.Exists)
                fi.Directory.Create();

            File.WriteAllText(targetPath, d.ToString(), Encoding.Unicode);

        }

        public void FillStorybookExcel(string targetPath, string translatePath, bool fillMessage, bool fillTranslatedMessage, bool fillMessageAsTranslate)
        {
            var map = setting.GetStorybookMaping();
            var translate = ReadLegacyStorybook(translatePath);

            var fi = new FileInfo(targetPath);
            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;

                foreach (var data in translate)
                {
                    string sheetName = GetStorybookSheetName(map, data.Key);
                    var sht = wb.Worksheets[sheetName];
                    if (sht == null)
                        continue;

                    FillStoryBookSheet(sht, data.Value, fillMessage, fillTranslatedMessage, fillMessageAsTranslate);
                }

                p.Save();
            }

        }

        private void FillStoryBookSheet(ExcelWorksheet sht, List<StorybookRow> data, bool fillMessage, bool fillTranslatedMessage, bool fillMessageAsTranslate)
        {
            int sheetDataCount = GetStorybookSheetDataCount(sht);
            if (sheetDataCount != data.Count)
                return;

            int currrow = ROW_STORYBOOK_START;
            foreach (var d in data)
            {
                if (fillMessage && !String.IsNullOrWhiteSpace(d.Message))
                    sht.Cells[currrow, COL_STORYBOOK_MESSAGE].Value = d.Message;

                if (fillMessageAsTranslate)
                {
                    sht.Cells[currrow, COL_STORYBOOK_TRANSLATE].Value = d.Message;
                }
                else if (!String.IsNullOrWhiteSpace(d.Translate))
                {
                    // translate is empty
                    if (String.IsNullOrWhiteSpace(sht.Cells[currrow, COL_STORYBOOK_TRANSLATE].Value.ToStringOrNull()))
                    {
                        sht.Cells[currrow, COL_STORYBOOK_TRANSLATE].Value = d.Translate;
                    }
                    // already translate
                    else
                    {
                        if (fillTranslatedMessage)
                            sht.Cells[currrow, COL_STORYBOOK_TRANSLATE].Value = d.Translate;
                    }
                }

                currrow++;
            }
        }

        private int GetStorybookSheetDataCount(ExcelWorksheet sht)
        {
            int result = 0;
            int row = ROW_STORYBOOK_START;
            string message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
            while (!String.IsNullOrWhiteSpace(message))
            {
                result++;

                row++;
                message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
            }

            return result;
        }

        private string GetStorybookSheetName(Dictionary<string, string> map, string key)
        {
            if (map.ContainsKey(key))
                return map[key];
            else
                return null;
        }

        private Dictionary<string, List<StorybookRow>> ReadLegacyStorybook(string translatePath)
        {
            var result = new Dictionary<string, List<StorybookRow>>();

            var fi = new FileInfo(translatePath);
            using (var p = new ExcelPackage(fi))
            {
                var sht = p.Workbook.Worksheets[STORYBOOK_SHEET_NAME];
                if (sht == null)
                    return result;

                string comment;
                List<StorybookRow> currBook = null;
                int row = ROW_STORYBOOK_START_LEGACY;
                string message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                while (!String.IsNullOrWhiteSpace(message))
                {
                    comment = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Comment?.Text;
                    if (!String.IsNullOrWhiteSpace(comment))
                    {
                        currBook = new List<StorybookRow>();
                        result.Add(comment, currBook);
                        currBook.Add(new StorybookRow() { Start = "0" });
                    }

                    if (currBook != null)
                    {
                        currBook.Add(new StorybookRow()
                        {
                            Start = "0",
                            Stop = "0",
                            Message = message,
                            Translate = sht.Cells[row, COL_STORYBOOK_TRANSLATE_LEGACY].Value.ToStringOrNull()
                        });
                    }

                    row++;
                    message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                }
            }

            return result;

        }



        public string ReadStorybookComment(string translatePath)
        {
            string result = "";
            var fi = new FileInfo(translatePath);
            using (var p = new ExcelPackage(fi))
            {
                var sht = p.Workbook.Worksheets[STORYBOOK_SHEET_NAME];
                if (sht == null)
                    return result;

                string comment;
                int row = ROW_STORYBOOK_START_LEGACY;
                string message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                while (!String.IsNullOrWhiteSpace(message))
                {
                    comment = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Comment?.Text;
                    if (!String.IsNullOrWhiteSpace(comment))
                    {
                        result += comment + Environment.NewLine;
                    }

                    row++;
                    message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                }
            }

            return result;
        }

        public void ClearAllStorybookTranslate(string excelPath)
        {
            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {
                foreach (var sht in p.Workbook.Worksheets)
                {
                    int row = ROW_STORYBOOK_START;
                    string message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                    while (!String.IsNullOrWhiteSpace(message))
                    {
                        sht.Cells[row, COL_STORYBOOK_TRANSLATE].Clear();

                        row++;
                        message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                    }
                }

                p.Save();
            }
        }

        public void ClearStorybookTranslate(string excelPath)
        {
            var sheets = setting.GetStorybookMaping().Select(m => m.Value);
            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;
                foreach (var sheetName in sheets)
                {
                    var sht = wb.Worksheets[sheetName];
                    if (sht == null)
                        continue;

                    int row = ROW_STORYBOOK_START;
                    string message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                    while (!String.IsNullOrWhiteSpace(message))
                    {
                        sht.Cells[row, COL_STORYBOOK_TRANSLATE].Clear();

                        row++;
                        message = sht.Cells[row, COL_STORYBOOK_MESSAGE_LEGACY].Value.ToStringOrNull();
                    }
                }


                p.Save();
            }
        }

        public void ChangeLanguageSettingToTR()
        {
            ChangeLanguageSetting("EN", "TR");
        }

        public void ChangeLanguageSettingToEN()
        {
            ChangeLanguageSetting("TR", "EN");
        }

        private void ChangeLanguageSetting(string fromLangCode, string toLangCode)
        {
            var settingPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "The Witcher 3",
                "user.settings"
            );

            // check file exist
            var fi = new FileInfo(settingPath);
            if (!fi.Exists)
                return;

            // read file content
            var content = File.ReadAllText(settingPath);

            // check neeed to change language setting
            bool needChange = IsNeedToChangeSetting(content, fromLangCode);
            if (!needChange)
                return;

            // backup old setting
            fi.CopyTo(settingPath + $@".{DateTime.Now:yyyyMMddHHmmssffff}.bak");

            content = content.Replace($@"RequestedTextLanguage={fromLangCode}", $@"RequestedTextLanguage={toLangCode}");
            content = content.Replace($@"TextLanguage={fromLangCode}", $@"TextLanguage={toLangCode}");

            File.WriteAllText(settingPath, content);

        }

        private bool IsNeedToChangeSetting(string content, string fromLangCode)
        {
            if (content.Contains($@"RequestedTextLanguage={fromLangCode}"))
                return true;

            if (content.Contains($@"TextLanguage={fromLangCode}"))
                return true;

            return false;
        }

        public bool IsNeedToDownload(string filePath, eDownloadFrequency frequency)
        {
            if (filePath == null)
                return false;


            if (File.Exists(filePath))
            {
                if (frequency == eDownloadFrequency.Once)
                {
                    return false;
                }
                else
                {
                    // check translate file up to date
                    var lastDownload = File.GetLastWriteTime(filePath);
                    switch (frequency)
                    {
                        case eDownloadFrequency.Day:
                            if (lastDownload > DateTime.Now.AddDays(-1)) // download less than 1 day
                                return false;
                            break;
                        case eDownloadFrequency.Hour:
                            if (lastDownload > DateTime.Now.AddMinutes(-60)) // download less than 1 hour
                                return false;
                            break;
                        default: // Always
                            break;
                    }
                }
            }

            return true;
        }

        public void DownloadCustomTranslateFile(eDownloadFrequency frequency)
        {
            var translatePath = Configs.CustomTranslateFilePath;
            if (String.IsNullOrWhiteSpace(Configs.CustomTranslateFileId))
                return;

            if (!IsNeedToDownload(translatePath, frequency))
                return;

            var tmpPath = Path.Combine(Configs.TempPath, Configs.CustomTranslateFileName);
            if (!DownloadGoogleSheetFile(Configs.CustomTranslateFileId, tmpPath))
                return;

            if (!File.Exists(tmpPath))
                return;

            

            CopyFile(tmpPath, translatePath);

        }

        public void CopyFile(string sourcePath, string targetPath)
        {
            if (!File.Exists(sourcePath))
                return;

            var fi = new FileInfo(targetPath);
            if (fi.Exists)
                fi.Delete();
            else if (!fi.Directory.Exists)
                fi.Directory.Create();

            File.Copy(sourcePath, targetPath);
        }

    }
}
