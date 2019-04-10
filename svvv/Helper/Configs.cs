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
        public static string TempPath = Path.Combine(Application.StartupPath, "temp");
        public static string ModPath = Path.Combine(Application.StartupPath, "mod");
        public static string DownloadPath = Path.Combine(Application.StartupPath, "download");
    }
}
