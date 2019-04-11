using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svvv.Helper
{
    class Deprecate
    {

        #region Not Use

        //public List<w3Strings> MergeSheet(List<w3Strings> source, List<w3Strings> translate, bool forExcel, bool combine, bool originalFirst, List<string> knowIssueList, out List<w3Strings> skipSource, out List<w3Strings> skipTranslate)
        //{
        //    var result = new List<w3Strings>();
        //    //var min = Math.Min(source.Count, translate.Count);
        //    var min = source.Count;
        //    int extraTranslate = 0;
        //    int extraSource = 0;
        //    int nextMatch;

        //    skipSource = new List<w3Strings>();
        //    skipTranslate = new List<w3Strings>();

        //    for (var i = 0; i < min; i++)
        //    {
        //        // end of source
        //        if (i + extraSource >= source.Count)
        //            return result;

        //        // end of translate
        //        if (i + extraTranslate >= translate.Count)
        //        {
        //            // not translate
        //            result.Add(new w3Strings(
        //                source[i + extraSource].ID,
        //                source[i + extraSource].KeyHex,
        //                source[i + extraSource].KeyString,
        //                source[i + extraSource].Text,
        //                null
        //            ));

        //            skipSource.Add(source[i + extraSource]);
        //            continue;
        //        }

        //        // id not match
        //        if (source[i + extraSource].ID.Trim() != translate[i + extraTranslate].ID.Trim())
        //        {
        //            // find match id in other row
        //            nextMatch = FindNextMatch(source[i].ID, translate, i + extraTranslate);
        //            if (nextMatch > 0)
        //            {
        //                // skip translate
        //                //for (int sk = 0; sk < nextMatch; sk++)
        //                //{
        //                //    skipTranslate.Add(translate[i + extraTranslate + sk]);
        //                //}
        //                extraTranslate += nextMatch;
        //            }
        //            else
        //            {
        //                // not id match
        //                skipSource.Add(source[i + extraSource]);
        //                result.Add(new w3Strings(
        //                    source[i + extraSource].ID,
        //                    source[i + extraSource].KeyHex,
        //                    source[i + extraSource].KeyString,
        //                    source[i + extraSource].Text,
        //                    null
        //                ));

        //                continue;
        //            }
        //        }

        //        var item = GetTranslate(source[i + extraSource], translate[i + extraTranslate], forExcel, combine, originalFirst);
        //        result.Add(item);

        //        if (String.IsNullOrWhiteSpace(translate[i + extraTranslate].Translate))
        //            skipSource.Add(source[i + extraSource]);
        //    }

        //    return result;
        //}

        //public string[] SplitTranslateLine(string line)
        //{
        //    return line.Split(new string[] { ",," }, StringSplitOptions.None);
        //}

        //public bool CompareContent(List<w3Strings> c1, List<w3Strings> c2)
        //{
        //    var min = Math.Min(c1.Count, c2.Count);
        //    for (var i = 0; i < min; i++)
        //    {
        //        if (c1[i].Text.GetCompareString() != c2[i].Text.GetCompareString())
        //        {
        //            Debug.WriteLine($@"original:  {c1[i].Text}");
        //            Debug.WriteLine($@"translate: {c2[i].Text}");
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        //public string[] GetSheetName(string path)
        //{
        //    var fi = new FileInfo(path);
        //    using (var p = new ExcelPackage(fi))
        //    {
        //        return p.Workbook.Worksheets.Select(ws => ws.Name).ToArray();

        //    }
        //}

        //public List<w3Strings> ReadTranslateCsv(string path)
        //{
        //    int skip = 4;
        //    int i = 0;
        //    string line = null;
        //    try
        //    {
        //        var content = File.ReadAllText(path).Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
        //                        .Skip(skip)
        //                        //.Where(c=>c.Contains(",,"))
        //                        //.Select(c => c = c.Replace("\"\"", "{}").Replace("\"", "").Replace("{}", "\""))
        //                        .ToArray();

        //        //var w3s = content.Select(c => new w3Strings(SplitTranslateLine(c), false)).ToList();
        //        var w3s = new List<w3Strings>();

        //        for (i = 0; i < content.Length; i++)
        //        {
        //            line = content[i];
        //            w3s.Add(new w3Strings(SplitTranslateLine(line), false));
        //        }

        //        return w3s;
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception($@"Error at line {i + skip + 2} (index {i}) : ""{line}""");
        //    }

        //}

        //public void CompareCsv(string path1, string path2, bool w3s1, bool w3s2, bool sort)
        //{

        //    var c1 = ReadCsv(path1, w3s1, sort);
        //    var c2 = ReadCsv(path2, w3s2, sort);

        //    var equal = CompareContent(c1, c2);
        //}

        //public void CompareExcel(string csvPath, bool sort, string excelPath, string sheetName)
        //{
        //    var c1 = ReadOriginalCsv(csvPath, sort);
        //    var c2 = ReadExcelSheet(excelPath, sheetName);

        //    var equal = CompareContent(c1, c2);
        //}


        //public List<w3Strings> ReadCsv(string path, bool w3s, bool sort)
        //{
        //    List<w3Strings> result;

        //    if (w3s)
        //    {
        //        result = ReadOriginalCsv(path, sort);
        //    }
        //    else
        //    {
        //        result = ReadTranslateCsv(path);
        //    }

        //    return result;

        //}

        //public void SortCsv(string path)
        //{
        //    var content = ReadOriginalCsv(path, true);
        //    WriteCsv(content, path + "_sort_.csv");
        //    MessageBox.Show("Complete");
        //}



        #endregion
    }
}
