using svvv.Classes;
using System.IO;
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

        // firebase storange
        //public const string WebTranslateUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/translate.json?alt=media";
        //public const string WebTranslateVersionUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/version.ini?alt=media";

        // google drive
        public const string WebTranslateUrl = "https://drive.google.com/uc?export=download&id=18EkKYhRGfHf0ifhNn3YretyFE02jCN3U";
        public const string WebTranslateVersionUrl = "https://drive.google.com/uc?export=download&id=1XNs-djSnR5sYrqWDVHJS-F0uA2a6vBEj";

        public const string WebUrl = "https://w3tu-svvv.web.app";
        public const string GoogleSheetUrl = "https://docs.google.com/spreadsheets/d/1AZLkTTaUbRUnnx6tFeTD3YBLt4AIBgeGquRZP5oJVAE";
        public const string ApiKey = "AIzaSyDg03c_bkBM2Tw3TahE3Gei-vx0m--OeWU";

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

        public const string W3eeFileId = "1HehSmP7ukMpBhs_V85JULB0b2GUpkOsFC8xu7VfcycQ";
        //public const string UpdateFileId = "1HOmaK3jaI2oW194CvyDXlzZBUEoWzGbU";
        //public const string VersionFileId = "1dChsKp641mD3EPREqSZTN_yxlu9KFXJP";
        //public const string StorybookFileId = "132FnSeYLJAQamrTptaEVtqfwqiOzdHRj";       
        //public const string StorybookVersionFileId = "1TGw2rDafTr0ObM-7Bvzd3S6pIgLbrnjW";
        //public const string TemplateFileId = "1QPvUzSLTJ4GRy552BLH1l4hZOPcWq8wb";
        //public const string TemplateVersionFileId = "1bZwJvkY1APBNTSS5Y3kmzt8n9_2P8guj";
        //public const string DefaultCustomTranslateFileId = "1X2VOm21x5ow_duSutaXV3AsCdz2YT1RVZZQoiPZHp14";
        //public const string AltTranslateFileId = "1zSuaHmVYN0lTPhf79iBLHp1J2pLsrmrrU1qtMIgKAqY";
        //public const string AltTranslateVersionFileId = "1hkD9fyAHdmk4J43tNGxAeCfptUwEwLmy";

        public const string UpdateFileUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/w3tu.zip?alt=media";
        public const string VersionFileUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/version.ini?alt=media";
        public const string StorybookUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/modThaiStoryBook.zip?alt=media";
        public const string StorybookVersionUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/version_storybook.ini?alt=media";
        public const string TemplateUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/Template.zip?alt=media";
        public const string TemplateVersionUrl = "https://firebasestorage.googleapis.com/v0/b/w3tu-svvv.appspot.com/o/version_template.ini?alt=media";




        public static string StartupPath = Application.StartupPath;
        public static string OutputPath = Path.Combine(StartupPath, "output");

        public static string ToolsPath = Path.Combine(StartupPath, "Tools");
        public static string TempPath = Path.Combine(StartupPath, "temp");
        public static string DownloadPath = Path.Combine(StartupPath, "download");
        public static string BackupPath = Path.Combine(StartupPath, "backup");
        public static string LogPath = Path.Combine(StartupPath, "changelog.txt");
        public static string SettingPath = Path.Combine(StartupPath, "setting.ini");
        public static string CustomTranslateSettingPath = Path.Combine(StartupPath, "custom.ini");
        public static string AltTranslateVersion = Path.Combine(StartupPath, "alt_version.ini");

        public static string TranslatePath = Path.Combine(DownloadPath, "translate.xlsx");
        public static string WebTranslatePath = Path.Combine(DownloadPath, "translate.json");
        public static string WebTranslateVersionPath = Path.Combine(DownloadPath, "version_web.ini");


        public static string StorybookPath = Path.Combine(ToolsPath, modThaiStoryBook);
        public static string StorybookExcelPath = Path.Combine(ToolsPath, "storybook.xlsx");
        public static string StorybookVersionPath = Path.Combine(StorybookPath, "version_storybook.ini");

        public static string FontSarabunPath = Path.Combine(ToolsPath, modFontSarabun);
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
