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
        public static string StartupPath = Application.StartupPath;
        public static string TempPath = Path.Combine(StartupPath, "temp");        
        public static string DownloadPath = Path.Combine(StartupPath, "download");
        public static string BackupPath = Path.Combine(StartupPath, "backup");
        public static string TemplatePath = Path.Combine(StartupPath, "Tools", "template.xlsx");        
        public static string LogPath = Path.Combine(StartupPath, "changelog.txt");

        public static string UpdaterZipPath = Path.Combine(StartupPath, "Tools", "updater.zip");
        public static string UpdaterDir = Path.Combine(StartupPath, "temp", "updater");
        public static string UpdaterPath = Path.Combine(UpdaterDir, "Updater.exe");


        public static string Separator = "  ";
        public static string UpdateFileId = "1HOmaK3jaI2oW194CvyDXlzZBUEoWzGbU";
        public static string VersionFileId = "1dChsKp641mD3EPREqSZTN_yxlu9KFXJP";

        public static string modThaiBigFont = "modThaiBigFont";
        public static string modThaiFont = "modThaiFont";
        public static string modDoubleSubtitle = "modDoubleSubtitle";
        public static string modThaiLanguage = "modThaiLanguage"; // translate
        public static string modKuntoonFont = "modKuntoonW3thai_mod";
    }
}
