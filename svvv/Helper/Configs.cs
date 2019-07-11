using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svvv
{
    public static class Configs
    {
        public const string modThaiStoryBook = "modThaiStoryBook";
        public const string modFontSarabun = "modFontSarabun";
        public const string modThaiFont = "modThaiFont";
        public const string modDoubleSubtitle = "modDoubleSubtitle";
        public const string modThaiLanguage = "modThaiLanguage"; // translate
        public const string modKuntoonFont = "modKuntoonW3thai_mod";
        public static string modThaiStorybook = "modThaiStorybook";

        public const int MaxLegacyEmptyRow = 5;
        public const string MissingText = "[MISSING MESSAGE]";
        public const string Separator = "  ";

        public const string UpdateFileId = "1HOmaK3jaI2oW194CvyDXlzZBUEoWzGbU";
        public const string VersionFileId = "1dChsKp641mD3EPREqSZTN_yxlu9KFXJP";
        public const string StorybookFileId = "132FnSeYLJAQamrTptaEVtqfwqiOzdHRj";
        public const string StorybookVersionFileId = "1TGw2rDafTr0ObM-7Bvzd3S6pIgLbrnjW";
        public const string TemplateFileId = "1QPvUzSLTJ4GRy552BLH1l4hZOPcWq8wb";
        public const string TemplateVersionFileId = "1bZwJvkY1APBNTSS5Y3kmzt8n9_2P8guj";


        public static string StartupPath = Application.StartupPath;

        public static string ToolsPath = Path.Combine(StartupPath,"Tools");
        public static string TempPath = Path.Combine(StartupPath, "temp");
        public static string DownloadPath = Path.Combine(StartupPath, "download");
        public static string BackupPath = Path.Combine(StartupPath, "backup");
        public static string LogPath = Path.Combine(StartupPath, "changelog.txt");
        public static string SettingPath = Path.Combine(StartupPath, "setting.ini");

        public static string StorybookPath = Path.Combine(ToolsPath, modThaiStoryBook);
        public static string StorybookExcelPath = Path.Combine(ToolsPath, "storybook.xlsx");
        public static string StorybookVersionPath = Path.Combine(StorybookPath, "version_storybook.ini");

        public static string TemplatePath = Path.Combine(ToolsPath, "Template");
        public static string TemplateFilePath = Path.Combine(TemplatePath, "template.xlsx");
        public static string TemplateVersionPath = Path.Combine(TemplatePath, "version_template.ini");       

        public static string UpdaterZipPath = Path.Combine(StartupPath, "Tools", "updater.zip");
        public static string UpdaterDir = Path.Combine(StartupPath, "temp", "updater");
        public static string UpdaterPath = Path.Combine(UpdaterDir, "Updater.exe");        
        
        
        
    }
}
