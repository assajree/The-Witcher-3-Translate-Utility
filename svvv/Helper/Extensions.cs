﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheWitcher3Thai.Common;

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

        public static bool ToBoolean(this string obj,bool defaultValue)
        {
            if (Boolean.TryParse(obj, out var val))
                return val;
            else
                return defaultValue;
            
        }

        public static int ToInt32(this string obj, int defaultValue)
        {
            if (Int32.TryParse(obj, out var val))
                return val;
            else
                return defaultValue;

        }

        public static eDownloadFrequency ToDownloadFrequency(this string str, eDownloadFrequency defaultValue)
        {
            if (!Enum.TryParse(str, true, out eDownloadFrequency frequency))
                frequency = defaultValue;

            return frequency;
        }

        public static eFontSetting ToFontSetting(this string str, eFontSetting defaultValue)
        {
            if (!Enum.TryParse(str, true, out eFontSetting val))
                val = defaultValue;

            return val;
        }

        public static string Right(this string str, int length)
        {
            if (length >= str.Length)
                return str;

            return str.Substring(str.Length - length);
        }
    }
}
