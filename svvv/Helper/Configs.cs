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


        public static string Separator = "  ";

        public static string modThaiBigFont = "modThaiBigFont";
        public static string modThaiFont = "modThaiFont";
        public static string modDoubleSubtitle = "modDoubleSubtitle";
        public static string modThaiLanguage = "modThaiLanguage"; // translate
        public static string modKuntoonFont = "modKuntoonW3thai_mod";
    }
}
