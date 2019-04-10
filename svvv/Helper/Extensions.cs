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

            return txt.Replace("\"", "").Trim();
        }

        public static void SetDefault(this TextBox txt, string defaultText)
        {
            if (String.IsNullOrWhiteSpace(txt.Text))
                txt.Text = defaultText;
        }
    }
}
