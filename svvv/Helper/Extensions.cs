using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWitcher3Thai.Helper
{
    public static class Extensions
    {
        public static string GetCompareString(this string txt)
        {
            if (txt == null)
                return null;

            txt = txt.Replace("\"", "").Trim();
            txt = txt.Replace(".", "").Trim();

            return txt;
        }

        public static void SetDefault(this TextBox txt, string defaultText)
        {
            if (String.IsNullOrWhiteSpace(txt.Text))
                txt.Text = defaultText;
        }

        public static int? ToIntOrNull(this string txt)
        {
            int result;
            if (Int32.TryParse(txt, out result))
                return result;
            else
                return null;
        }

        public static string NullIfEmpty(this string txt)
        {
            if(String.IsNullOrWhiteSpace(txt))
            {
                return null;
            }

            return txt;
        }

        public static string ToStringOrNull(this object obj)
        {
            if (obj==null)
            {
                return null;
            }

            return obj.ToString();
        }
    }
}
