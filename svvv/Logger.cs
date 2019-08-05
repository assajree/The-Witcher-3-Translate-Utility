using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svvv
{
    public static class Logger
    {
        static string logPath = Path.Combine(Application.StartupPath, "log.log");
        const string TAG_INFO = "INFO";
        const string TAG_ERROR = "ERRR";

        public static string GetLogPath()
        {
            return logPath;
        }

        public static void SrartNewLog()
        {
            if (File.Exists(logPath))
                File.Delete(logPath);
        }

        public static void Log(string message, string tag = TAG_INFO)
        {
            File.AppendAllText(logPath, $@"{tag} : {message}{Environment.NewLine}");
        }

        public static void Log(Exception ex)
        {
            Log($@"{ex.GetBaseException().Message}{Environment.NewLine}        {ex.StackTrace}", TAG_ERROR);
        }
    }
}
