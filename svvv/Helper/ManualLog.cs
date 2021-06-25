using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svvv.Helper
{
    public class ManualLog
    {
        public void WriteLog(string prefix, string message, params object[] param)
        {

            try
            {
                var logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
                var path = Path.Combine(logPath, "log_" + DateTime.Now.ToString("yyyyMMdd") + ".log");
                if (!Directory.Exists(logPath))
                    Directory.CreateDirectory(logPath);

                var msg = message;
                try
                {
                    if (param.Length > 0)
                        msg = String.Format(message, param);
                }
                catch (Exception ex)
                {

                }

                string log = String.Format("{0} : {1} \t - \t {2}\n",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    prefix,
                    msg
                );

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(log);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void ErrorFormat(string message, params object[] param)
        {
            WriteLog("ERROR", message, param);
        }

        public void InfoFormat(string message, params object[] param)
        {
            WriteLog("INFO ", message, param);
        }

        public void DebugFormat(string message, params object[] param)
        {
            WriteLog("DEBUG", message, param);
        }

        public void FatalFormat(string message, params object[] param)
        {
            WriteLog("FATAL", message, param);
        }

        public void Fatal(string message, params object[] param)
        {
            WriteLog("FATAL", message, param);
        }

        public void Error(string message, Exception ex)
        {
            WriteLog("FATAL", message + " " + ex.GetBaseException());
        }
    }
}
