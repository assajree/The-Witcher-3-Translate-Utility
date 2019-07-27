using svvv.Classes;
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
        private static AppSetting mAppSetting = null;
        public static AppSetting GetAppSetting()
        {
            return mAppSetting;
        }

        public static void SetAppSetting(AppSetting setting)
        {
            mAppSetting = setting;
        }

        public static bool IsGamer { get; set; } = false;
        public const string modThaiStoryBook = "modThaiStoryBook";
        public const string modFontSarabun = "modFontSarabun";
        public const string modFontCsParkas = "modFontCsPraKas";
        public const string modFontPrompt = "modFontPrompt";

        public const string modFontMahaniyom = "modFontMahaniyom";
        public const string modFontSrisakdi = "modFontSrisakdi";
        public const string modFontSuperMarket = "modFontSuperMarket";

        public const string modThaiFont = "modThaiFont";
        public const string modDoubleSubtitle = "modDoubleSubtitle";
        public const string modThaiLanguage = "modThaiLanguage"; // translate
        public const string modKuntoonFont = "modKuntoonW3thai_mod";
        

        public static string CUSTOM_TRANSLATE_LABEL = "การแปลภาษาแบบปรับแต่ง";

        public const int MaxLegacyEmptyRow = 5;
        public const string MissingText = "[MISSING MESSAGE]";
        public const string Separator = "  ";

        public const string UpdateFileId = "1HOmaK3jaI2oW194CvyDXlzZBUEoWzGbU";
        public const string VersionFileId = "1dChsKp641mD3EPREqSZTN_yxlu9KFXJP";
        public const string StorybookFileId = "132FnSeYLJAQamrTptaEVtqfwqiOzdHRj";
        public const string StorybookVersionFileId = "1TGw2rDafTr0ObM-7Bvzd3S6pIgLbrnjW";
        public const string TemplateFileId = "1QPvUzSLTJ4GRy552BLH1l4hZOPcWq8wb";
        public const string TemplateVersionFileId = "1bZwJvkY1APBNTSS5Y3kmzt8n9_2P8guj";
        public const string DefaultCustomTranslateFileId = "1X2VOm21x5ow_duSutaXV3AsCdz2YT1RVZZQoiPZHp14";

        public static string StartupPath = Application.StartupPath;

        public static string ToolsPath = Path.Combine(StartupPath,"Tools");
        public static string TempPath = Path.Combine(StartupPath, "temp");
        public static string DownloadPath = Path.Combine(StartupPath, "download");
        public static string BackupPath = Path.Combine(StartupPath, "backup");
        public static string LogPath = Path.Combine(StartupPath, "changelog.txt");
        public static string SettingPath = Path.Combine(StartupPath, "setting.ini");
        public static string CustomTranslateSettingPath = Path.Combine(StartupPath, "custom.ini");

        public static string StorybookPath = Path.Combine(ToolsPath, modThaiStoryBook);
        public static string StorybookExcelPath = Path.Combine(ToolsPath, "storybook.xlsx");
        public static string StorybookVersionPath = Path.Combine(StorybookPath, "version_storybook.ini");

        public static string FontSarabunPath = Path.Combine(ToolsPath, modFontSarabun);
        public static string FontKunToonPath = Path.Combine(ToolsPath, modThaiFont);
        public static string FontCsPrakasPath = Path.Combine(ToolsPath, modFontCsParkas);
        public static string FontPromptPath = Path.Combine(ToolsPath, modFontPrompt);
        public static string FontMahaniyomPath = Path.Combine(ToolsPath, modFontMahaniyom);
        public static string FontSrisakdiPath = Path.Combine(ToolsPath, modFontSrisakdi);
        public static string FontSuperMarketPath = Path.Combine(ToolsPath, modFontSuperMarket);

        public static string TemplatePath = Path.Combine(ToolsPath, "Template");
        public static string TemplateFilePath = Path.Combine(TemplatePath, "template.xlsx");
        public static string TemplateVersionPath = Path.Combine(TemplatePath, "version_template.ini");       

        public static string UpdaterZipPath = Path.Combine(StartupPath, "Tools", "updater.zip");
        public static string UpdaterDir = Path.Combine(StartupPath, "temp", "updater");
        public static string UpdaterPath = Path.Combine(UpdaterDir, "Updater.exe");

        //public static string CustomTranslateFileId { get; private set; }        
        //public static string CustomTranslateFileName { get; private set; }        
        //public static string CustomTranslateFilePath { get; private set; }        
        //public static void SetCustomTranslateFileId(string fileId)
        //{
        //    CustomTranslateFileId = fileId;
        //    CustomTranslateFileName = fileId+".xlsx";
        //    CustomTranslateFilePath = Path.Combine(DownloadPath, CustomTranslateFileName);
        //}

    }
}
