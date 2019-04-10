﻿using Microsoft.Win32;
using OfficeOpenXml;
using Svvv.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private Setting setting = new Setting();

        #region Decode

        public void DecodeDirectory(string path)
        {
            DirectoryInfo originalDirectory = new DirectoryInfo(path);
            DecodeDirectory(originalDirectory);
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

        public void EncodeW3String(string filePath)
        {
            string w3sPath = Path.Combine(Application.StartupPath, "Tools", "w3strings.exe");
            string strCmdText = $@"--encode ""{filePath}"" --force-ignore-id-space-check-i-know-what-i-am-doing";

            CallConsoleApp(w3sPath, strCmdText);
        }

        #endregion

        #region Dialog

        public string SelectCsv(string initialPath)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Browse csv Files",

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
                openFileDialog1.InitialDirectory = Application.StartupPath;
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

        public string SaveXlsx(string initialPath, string defaultPath = null)
        {
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
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (!String.IsNullOrWhiteSpace(defaultPath))
            {
                if (!Directory.Exists(defaultPath))
                    Directory.CreateDirectory(defaultPath);
            }

            if (String.IsNullOrWhiteSpace(initialPath))
                fbd.SelectedPath = defaultPath ?? Application.StartupPath;
            else
                fbd.SelectedPath = initialPath;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            else
            {
                return null;
            }
        }

        public void ShowErrorMessage(Exception ex, string caption = "Error")
        {
            MessageBox.Show(ex.GetBaseException().Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string DownloadLegacyExcel(string initialPath)
        {
            var path = SaveXlsx(initialPath);
            if (path != null)
            {
                var downloadComplete = DownloadFile("https://docs.google.com/spreadsheets/d/1XLM0VzU0RFiTw8NIQSZ2NBPlL_i1yzBYarrMWGb5lDA/export?format=xlsx", path);
                if (downloadComplete == false)
                    return null;
            }

            return path;
        }

        public string DownloadLegacyMod(string initialPath)
        {
            var path = SelectFolder(initialPath);
            if (path != null)
            {
                var downloadResult = DownloadMod(path, false, false);
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
            var result=MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            foreach (var file in modList)
            {
                var source = new FileInfo(Path.Combine(tempPath, file.Key + ".csv.w3strings"));
                var desc = new FileInfo(Path.Combine(targetPath, file.Value + @"\en.w3strings"));

                if (!desc.Directory.Exists)
                    desc.Directory.Create();

                source.CopyTo(desc.FullName, true);
            }

            WriteVersionUnofficial(targetPath);
        }

        public List<w3Strings> ReadExcelSheet(string path, string sheetName)
        {
            var fi = new FileInfo(path);
            using (var p = new ExcelPackage(fi))
            {
                var sht = p.Workbook.Worksheets[sheetName];
                var result = ReadExcelSheet(sht);
                return result;

            }
        }

        public Dictionary<string, w3Strings> ConvertToDictionary(List<w3Strings> content)
        {
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
                var content = File.ReadAllText(path).Split('\n')
                            .Skip(skip)
                            .Where(c => !String.IsNullOrWhiteSpace(c))
                            //.Select(c => c.Replace("[[CSV_EXPORT_PIPE]]", "|"))
                            //.Select(c => c = c.Replace("\"\"", "{}").Replace("\"", "").Replace("{}", "\""))
                            .ToArray();

                //var w3s = content.Select(c => new w3Strings(SplitOriginalLine(c), true)).ToList();
                var w3s = new List<w3Strings>();

                for (i = 0; i < content.Length; i++)
                {
                    line = content[i];
                    w3s.Add(new w3Strings(SplitOriginalLine(line), true));
                }

                if (sort)
                    w3s = w3s.OrderBy(w => w.ID).ToList();

                return w3s;
            }
            catch (Exception)
            {
                throw new Exception($@"Error at line {i + skip + 2} (index {i}) : ""{line}""");
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
            //var min = Math.Min(source.Count, translate.Count);
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
                        null
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
                        //for (int sk = 0; sk < nextMatch; sk++)
                        //{
                        //    skipTranslate.Add(translate[i + extraTranslate + sk]);
                        //}
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
                            null
                        ));

                        continue;
                    }

                    //else
                    //{
                    //    nextMatch = FindNextMatch(translate[i].Text, source, i + extraSource);

                    //    if (nextMatch > 0)
                    //    {
                    //        // skip source
                    //        for (int sk = 0; sk < nextMatch; sk++)
                    //        {
                    //            result.Add(new w3Strings(
                    //                source[i].Key,
                    //                Translate(source[i + extraSource + sk].Text, null, combine),
                    //                null
                    //            ));

                    //            skipSource.Add(source[i + extraSource + sk]);
                    //        }
                    //        extraSource += nextMatch;
                    //    }
                    //    else
                    //    {
                    //        //throw new MergeException(source[i+extraSource], translate[i + extraTranslate]);
                    //        result.Add(new w3Strings(
                    //                source[i].Key,
                    //                Translate(source[i + extraSource].Text, null, combine),
                    //                null
                    //            ));

                    //        skipSource.Add(source[i + extraSource]);
                    //    }
                    //}

                }

                //var item = GetTranslate(source[i + extraSource], translate[i + extraTranslate], forExcel);
                //result.Add(item);

                result.Add(new w3Strings(
                    source[i + extraSource].ID,
                    source[i + extraSource].KeyHex,
                    source[i + extraSource].KeyString,
                    translate[i + extraTranslate].Text,
                    translate[i + extraTranslate].Translate
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
            string text = sht.Cells[row, COL_TEXT].Text;
            while (!String.IsNullOrWhiteSpace(text))
            {

                translate = sht.Cells[row, COL_TRANS].Text.Replace("\r", "").Replace("\n", "");
                result.Add(new w3Strings(text, translate));

                row++;
                text = sht.Cells[row, COL_TEXT].Text;
            }

            return result;

        }


        #endregion

        #region Merge Language

        public w3Strings GetTranslate(w3Strings source, w3Strings translate, bool forExcel, bool combine = false, bool originalFirst = true)
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
                    Translate(source.Text, translate.Translate, false, false)
                );
            }
            else
            {
                return new w3Strings(
                    source.ID,
                    source.KeyHex,
                    source.KeyString,
                    Translate(source.Text, translate.Translate, combine, originalFirst, source.KeyHex != "00000000"),
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
                        var translateContent = ConvertToDictionary(ReadExcelSheet(sht));

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
                //error+= $@"xxxxxx";

                throw new Exception(error);
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

        public string Translate(string text, string translate, bool combine = false, bool originalFirst = true, bool forceSingle = false)
        {
            // same word or no translate
            if (text.GetCompareString() == translate.GetCompareString() || String.IsNullOrWhiteSpace(translate))
                return text;

            //if (combine && text.Contains(":"))
            //{
            //    if (originalFirst)
            //        return text;
            //    else
            //        return translate;
            //}

            if (combine && !forceSingle)
            {
                if (originalFirst)
                    return text + "<br>" + translate;
                else
                    return translate + "<br>" + text;
            }
            else
            {
                //return String.IsNullOrWhiteSpace(translate) ? text : translate;
                return translate;
            }

        }

        #endregion

        #region Not Use

        public List<w3Strings> MergeSheet(List<w3Strings> source, List<w3Strings> translate, bool forExcel, bool combine, bool originalFirst, List<string> knowIssueList, out List<w3Strings> skipSource, out List<w3Strings> skipTranslate)
        {
            var result = new List<w3Strings>();
            //var min = Math.Min(source.Count, translate.Count);
            var min = source.Count;
            int extraTranslate = 0;
            int extraSource = 0;
            int nextMatch;

            skipSource = new List<w3Strings>();
            skipTranslate = new List<w3Strings>();

            for (var i = 0; i < min; i++)
            {
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
                        null
                    ));

                    skipSource.Add(source[i + extraSource]);
                    continue;
                }

                // id not match
                if (source[i + extraSource].ID.Trim() != translate[i + extraTranslate].ID.Trim())
                {
                    // find match id in other row
                    nextMatch = FindNextMatch(source[i].ID, translate, i + extraTranslate);
                    if (nextMatch > 0)
                    {
                        // skip translate
                        //for (int sk = 0; sk < nextMatch; sk++)
                        //{
                        //    skipTranslate.Add(translate[i + extraTranslate + sk]);
                        //}
                        extraTranslate += nextMatch;
                    }
                    else
                    {
                        // not id match
                        skipSource.Add(source[i + extraSource]);
                        result.Add(new w3Strings(
                            source[i + extraSource].ID,
                            source[i + extraSource].KeyHex,
                            source[i + extraSource].KeyString,
                            source[i + extraSource].Text,
                            null
                        ));

                        continue;
                    }
                }

                var item = GetTranslate(source[i + extraSource], translate[i + extraTranslate], forExcel, combine, originalFirst);
                result.Add(item);

                if (String.IsNullOrWhiteSpace(translate[i + extraTranslate].Translate))
                    skipSource.Add(source[i + extraSource]);
            }

            return result;
        }

        public string[] SplitTranslateLine(string line)
        {
            return line.Split(new string[] { ",," }, StringSplitOptions.None);
        }

        public bool CompareContent(List<w3Strings> c1, List<w3Strings> c2)
        {
            var min = Math.Min(c1.Count, c2.Count);
            for (var i = 0; i < min; i++)
            {
                if (c1[i].Text.GetCompareString() != c2[i].Text.GetCompareString())
                {
                    Debug.WriteLine($@"original:  {c1[i].Text}");
                    Debug.WriteLine($@"translate: {c2[i].Text}");
                    return false;
                }
            }

            return true;
        }

        public string[] GetSheetName(string path)
        {
            var fi = new FileInfo(path);
            using (var p = new ExcelPackage(fi))
            {
                return p.Workbook.Worksheets.Select(ws => ws.Name).ToArray();

            }
        }

        public List<w3Strings> ReadTranslateCsv(string path)
        {
            int skip = 4;
            int i = 0;
            string line = null;
            try
            {
                var content = File.ReadAllText(path).Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
                                .Skip(skip)
                                //.Where(c=>c.Contains(",,"))
                                //.Select(c => c = c.Replace("\"\"", "{}").Replace("\"", "").Replace("{}", "\""))
                                .ToArray();

                //var w3s = content.Select(c => new w3Strings(SplitTranslateLine(c), false)).ToList();
                var w3s = new List<w3Strings>();

                for (i = 0; i < content.Length; i++)
                {
                    line = content[i];
                    w3s.Add(new w3Strings(SplitTranslateLine(line), false));
                }

                return w3s;
            }
            catch (Exception)
            {
                throw new Exception($@"Error at line {i + skip + 2} (index {i}) : ""{line}""");
            }

        }

        public void CompareCsv(string path1, string path2, bool w3s1, bool w3s2, bool sort)
        {

            var c1 = ReadCsv(path1, w3s1, sort);
            var c2 = ReadCsv(path2, w3s2, sort);

            var equal = CompareContent(c1, c2);
        }

        public void CompareExcel(string csvPath, bool sort, string excelPath, string sheetName)
        {
            var c1 = ReadOriginalCsv(csvPath, sort);
            var c2 = ReadExcelSheet(excelPath, sheetName);

            var equal = CompareContent(c1, c2);
        }


        public List<w3Strings> ReadCsv(string path, bool w3s, bool sort)
        {
            List<w3Strings> result;

            if (w3s)
            {
                result = ReadOriginalCsv(path, sort);
            }
            else
            {
                result = ReadTranslateCsv(path);
            }

            return result;

        }

        public void SortCsv(string path)
        {
            var content = ReadOriginalCsv(path, true);
            WriteCsv(content, path + "_sort_.csv");
            MessageBox.Show("Complete");
        }



        #endregion

        #region Kuntoon Function

        public string GetLastVersion()
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
                throw new Exception("Get version fail. Try again later.");
                //lastVersion = "N/A";
            }

            return lastVersion;
        }

        public string ReadVersion(string modPath)
        {
            string versionPath = Path.Combine(modPath, "version.ini");

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

        public bool DownloadFile(string url, string saveToPath)
        {
            using (var dlg = new DownloadDialog(url, saveToPath))
            {
                var result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                    return true;
                else
                    return false;
            }
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

                if (Directory.Exists(extractPath))
                    DeleteDirectory(extractPath);

                // extract file
                ZipFile.ExtractToDirectory(downloadFilePath, extractPath);
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
            //    throw new Exception("Please select empty folder");           

            string url = "https://dl.dropbox.com/s/iyn4vn4eiq4oegc/Thaimods.zip?dl=0";
            string downloadFilePath = Path.Combine(Application.StartupPath, "temp", "thaimod.zip");
            var downloadFileResult = DownloadFile(url, downloadFilePath);
            if (downloadFileResult == false)
                return null;

            Processing(() => { ProcessDownloadMod(targetPath, downloadFilePath, writeVersion, updateFont); }, false);
            return "Download Complete";
        }


        private void WriteVersion(string modPath)
        {
            var version = GetLastVersion();
            var filePath = Path.Combine(modPath, "version.ini");

            var fi = new FileInfo(filePath);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            using (TextWriter tw = new StreamWriter(filePath))
            {
                tw.Write(version);
            }
        }

        public void WriteVersionUnofficial(string modPath)
        {
            string path = Path.Combine(modPath, "version.ini");

            using (TextWriter tw = new StreamWriter(path))
            {
                tw.WriteLine($@"{DateTime.Now:yyyy.MM.dd.HHmmss} (unofficial)");
            }
        }

        public void CopyDirectory(string SourcePath, string DestinationPath)
        {
            // create all directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            // copy file and replace
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
        }

        #endregion

        /// <summary>
        /// copy all w3strings file to target directory
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="targrtPath"></param>
        /// <param name="overwrite"></param>
        public void Backup(string sourcePath, string targrtPath, bool overwrite)
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
            var installPath = GetSteamDirectory();
            if (installPath == null)
                return null;
            else
            {
                string path = Path.Combine(installPath, @"steamapps\common\The Witcher 3");
                return path;
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

        public string GetTranslateFile()
        {
            var path = Path.Combine(Application.StartupPath, "Translate");
            var dir = new DirectoryInfo(path);
            if (!dir.Exists)
                return null;

            var files = dir.GetFiles("*.xlsx", SearchOption.TopDirectoryOnly);

            var fi = files.FirstOrDefault();
            return fi?.FullName;
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
            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;
                foreach (var f in files)
                {
                    if (wb.Worksheets[f.Key] != null)
                        wb.Worksheets.Delete(f.Key);

                    var sht = wb.Worksheets.Add(f.Key);
                    var sourcePath = Path.Combine(tempOriginalPath, sht.Name + ".w3strings.csv");
                    var content = ReadOriginalCsv(sourcePath, true);
                    WriteSheetContent(sht, content, true);
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

            using (var p = new ExcelPackage(fi))
            {
                var wb = p.Workbook;
                WriteResultSheet(wb, content);

                foreach (var c in content)
                {
                    if (c.Value.Count == 0)
                        continue;

                    var sht = wb.Worksheets.Add(c.Key);
                    if (sort)
                        WriteSheetContent(sht, c.Value.OrderBy(v => v.ID).ToList(), false);
                    else
                        WriteSheetContent(sht, c.Value, false);
                }

                p.Save();
            }
        }

        private void WriteResultSheet(ExcelWorkbook wb, Dictionary<string, List<w3Strings>> contents)
        {
            string sheetName = "Summary";

            var sht = wb.Worksheets[sheetName];

            if (sht != null)
                wb.Worksheets.Delete(sheetName);

            sht = wb.Worksheets.Add(sheetName);

            const int ROW_START = 3;
            float totalContent = 0;
            float totalNotTranslate = 0;
            float totalTranslate = 0;


            // summary text
            sht.Row(1).Style.Font.Bold = true;
            sht.Cells[1, 1].Value = "Summary";

            // header
            sht.Row(2).Style.Font.Bold = true;
            sht.Cells[2, 1].Value = "Sheet Name";
            sht.Cells[2, 2].Value = "Total Content";
            sht.Cells[2, 3].Value = "Not Translate";
            sht.Cells[2, 4].Value = "Complete";

            // detail
            int currRow = ROW_START;
            foreach (var item in contents)
            {
                float notTranslate = item.Value.Where(c => String.IsNullOrWhiteSpace(c.Translate)).ToList().Count;
                float translate = item.Value.Count - notTranslate;
                totalNotTranslate += notTranslate;
                totalTranslate += translate;
                totalContent += item.Value.Count;

                sht.Cells[currRow, 1].Value = item.Key;
                sht.Cells[currRow, 2].Value = item.Value.Count.ToString("#,0");
                sht.Cells[currRow, 3].Value = notTranslate.ToString("#,0");

                if (item.Value.Count > 0)
                    sht.Cells[currRow, 4].Value = (translate / item.Value.Count * 100f).ToString("#,0.00") + "%";
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

        public List<w3Strings> ReadExcelSheet(ExcelWorksheet sht)
        {
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
                        sht.Cells[row, Excel.COL_TRANSLATE].Text.Replace("\r", "").Replace("\n", "")
                ));

                row++;
                id = sht.Cells[row, Excel.COL_ID].Text;
            }

            return result;

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

            for (int i = 0; i < content.Count; i++)
            {
                sht.Cells[Excel.ROW_START + i, Excel.COL_ID].Value = content[i].ID;
                sht.Cells[Excel.ROW_START + i, Excel.COL_KEY_HEX].Value = content[i].KeyHex;
                sht.Cells[Excel.ROW_START + i, Excel.COL_KEY_STRING].Value = content[i].KeyString;
                sht.Cells[Excel.ROW_START + i, Excel.COL_TEXT].Value = content[i].Text;

                if (textAsTranslate)
                    sht.Cells[Excel.ROW_START + i, Excel.COL_TRANSLATE].Value = content[i].Text;
                else
                    sht.Cells[Excel.ROW_START + i, Excel.COL_TRANSLATE].Value = content[i].Translate;

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

            var contents = ReadExcel(sourcePath, sheets);
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

        public void GenerateMod(Dictionary<string,List<w3Strings>> contents, string outputPath, bool combine, bool originalFirst, Dictionary<string,string> sheetConfig)
        {
            var tempPath = Path.Combine(Application.StartupPath, "temp");

            foreach (var sheet in contents)
            {
                var content = TranslateExcel(sheet.Value, combine , originalFirst);

                var path = Path.Combine(tempPath, sheet.Key + ".csv");
                WriteCsv(content, path);
                EncodeW3String(path);
            }

            FinishMod(tempPath, outputPath, sheetConfig);
        }

        public void GenerateModFromExcel(string excelPath, string outputPath, bool combine, bool originalFirst)
        {
            var tempPath = Path.Combine(Application.StartupPath, "temp");
            var sheetConfig = setting.GetSheetConfig();

            var raw = ReadExcel(excelPath, sheetConfig);

            GenerateMod(raw, outputPath, combine, originalFirst, sheetConfig);            
        }

        public List<w3Strings> TranslateExcel(List<w3Strings> content, bool combine, bool originalFirst)
        {
            var result = new List<w3Strings>();
            foreach (var c in content)
            {
                var item = new w3Strings(
                    c.ID,
                    c.KeyHex,
                    c.KeyString,
                    Translate(c.Text, c.Translate, combine, originalFirst, c.KeyHex != "00000000"),
                    null
                );

                result.Add(item);
            }

            return result;
        }

        //public Dictionary<string, List<w3Strings>> ReadExcelDictionary(string excelPath, Dictionary<string, string> sheets = null)
        //{
        //    var result
        //    var raw = ReadExcel(excelPath, sheets);
        //    foreach (var data in raw)
        //    {

        //    }
        //}

        public Dictionary<string, List<w3Strings>> ReadExcel(string excelPath, Dictionary<string, string> sheetConfig = null)
        {
            var result = new Dictionary<string, List<w3Strings>>();

            if (sheetConfig == null)
                sheetConfig = setting.GetSheetConfig();

            var fi = new FileInfo(excelPath);
            using (var p = new ExcelPackage(fi))
            {
                foreach (var s in sheetConfig)
                {
                    var sht = p.Workbook.Worksheets[s.Key];
                    if (sht != null)
                    {
                        var content = ReadExcelSheet(sht);
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

        public void FilterExcel(string excelPath, string outputPath, bool emptyTranslate, bool sameWord, bool singleWord, string containText, bool sortByTextLength)
        {
            var sheets = setting.GetSheetConfig();
            var contents = ReadExcel(excelPath, sheets);
            var result = new Dictionary<string, List<w3Strings>>();

            foreach (var c in contents)
            {
                var filtered = SortContent(FillterContent(c.Value, emptyTranslate, sameWord, singleWord, containText), sortByTextLength);
                result.Add(
                    c.Key,
                    filtered
                );
            }

            WriteExcel(outputPath, result, false);
        }

        private List<w3Strings> FillterContent(List<w3Strings> content, bool emptyTranslate, bool sameWord, bool singleWord, string containText)
        {
            List<w3Strings> result = new List<w3Strings>();

            if (!emptyTranslate && !sameWord && !singleWord && String.IsNullOrWhiteSpace(containText))
                return content;

            if (emptyTranslate)
                result.AddRange(content.Where(c => String.IsNullOrWhiteSpace(c.Translate)).ToList());

            if (singleWord)
                result.AddRange(content.Where(c => !c.Text.Contains(" ")).ToList());

            if (sameWord)
                result.AddRange(content.Where(c => c.Text.GetCompareString() == c.Translate.GetCompareString()).ToList());

            if (!String.IsNullOrEmpty(containText))
                result.AddRange(content.Where(c => c.Text.Contains(containText)).ToList());

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

            var source = ReadExcel(sourcePath);
            var translate = ReadExcel(translatePath);
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

        public void UpdateFont(string downloadPath)
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
            catch (Exception ex)
            {
                // restore backup
                //if (File.Exists(targetPath))
                //    File.Delete(backupPath);
                //else
                File.Move(backupPath, targetPath);
            }

        }

        public void InstallFont(string gamePath)
        {
            string modPath = Path.Combine(Application.StartupPath, "Tools", "font.zip");
            ZipFile.ExtractToDirectory(modPath, gamePath);

        }

        public void RemoveFont(string gamePath)
        {
            string modPath = Path.Combine(gamePath, "mods", "modKuntoonW3thai_mod");
            if (Directory.Exists(modPath))
                DeleteDirectory(modPath);
        }

        public void InstallMod(string modPath, string gamePath)
        {
            // create all directories
            foreach (string dirPath in Directory.GetDirectories(modPath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(modPath, gamePath));

            // copy file and replace
            foreach (string path in Directory.GetFiles(modPath, "*.*", SearchOption.AllDirectories))
            {
                if (path == Path.Combine(modPath, "version.ini"))
                    continue;

                File.Copy(path, path.Replace(modPath, gamePath), true);
            }
        }

        public void GenerateLegacyMod(string excelPath, string outputPath, bool doubleLanguage, bool originalFirst)
        {
            string templatePath = Path.Combine(Application.StartupPath, "Translate", "template.xlsx");
            if (!File.Exists(templatePath))
                throw new Exception("ไม่พบไฟล์ template.xlsx กรุณาติดตั้งโปรแกมใหม่");

            var sheetConfig = setting.GetSheetConfig();
            var template = ReadExcel(templatePath, sheetConfig);
            var translate = ReadExcelLegacy(excelPath, sheetConfig);

            var content = MergeLegacy(template, translate);

            // write excel file for check result
            string legacyExcel= Path.Combine(Application.StartupPath, "temp", "legacy.xlsx");
            WriteExcel(legacyExcel, content,false);

            GenerateMod(content, outputPath, doubleLanguage, originalFirst, sheetConfig);

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
                    continue;

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




    }

}
