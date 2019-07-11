using System.IO;
using System.Linq;
using System.Text;
using TheWitcher3Thai.Helper;
using static TheWitcher3Thai.Common;

namespace svvv.Classes
{
    public class AppSetting
    {
        const char SEPARATOR = '=';
        string mSettingPath;

        public bool DoubleLanguage { get; set; }
        public bool EnglishUi { get; set; }
        public bool AlternativeSubtitle { get; set; }
        public bool ThaiFirst { get; set; }
        public bool ShowNotTranslateRow { get; set; }
        public bool ShowTranslateRow { get; set; }
        public bool ShowUiRow { get; set; }
        public eFontSetting FontSetting { get; set; }
        public int SizeCutscene { get; set; }
        public int SizeDialog { get; set; }
        public eDownloadFrequency DownloadFrequency { get; set; }

        public AppSetting(string settingPath)
        {
            mSettingPath = settingPath;
            LoadSetting();
        }


        private void LoadSetting()
        {
            if (!File.Exists(mSettingPath))
            {
                InitialValue();
                return;
            }

            var content = File.ReadAllText(mSettingPath).Split('\n').ToList();
            foreach (var c in content)
            {
                GetValue(c);
            }
        }

        private void InitialValue()
        {
            DoubleLanguage = true;
            EnglishUi = false;
            AlternativeSubtitle = true;
            ThaiFirst = true;
            ShowNotTranslateRow = false;
            ShowTranslateRow = false;
            ShowUiRow = false;
            FontSetting = eFontSetting.Sarabun;
            SizeCutscene = 28;
            SizeDialog = 28;
            DownloadFrequency = eDownloadFrequency.Hour;
        }

        public void SaveSetting()
        {
            File.WriteAllText(mSettingPath, ToString());
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($@"DoubleLanguage = {DoubleLanguage}");
            sb.AppendLine($@"EnglishUi = {EnglishUi}");
            sb.AppendLine($@"AlternativeSubtitle = {AlternativeSubtitle}");
            sb.AppendLine($@"ThaiFirst = {ThaiFirst}");
            sb.AppendLine($@"ShowNotTranslateRow = {ShowNotTranslateRow}");
            sb.AppendLine($@"ShowTranslateRow = {ShowTranslateRow}");
            sb.AppendLine($@"ShowUiRow = {ShowUiRow}");
            sb.AppendLine($@"FontSetting = {FontSetting}");
            sb.AppendLine($@"SizeCutscene = {SizeCutscene}");
            sb.AppendLine($@"SizeDialog = {SizeDialog}");
            sb.AppendLine($@"DownloadFrequency = {DownloadFrequency}");

            return sb.ToString();
        }

        private void GetValue(string str)
        {
            var arr = str.Split(SEPARATOR);
            if (arr.Length != 2)
                return;

            var setting = arr[0].Trim();
            var value = arr[1].Trim();

            switch (setting)
            {
                case "DoubleLanguage":
                    DoubleLanguage = value.ToBoolean(true);
                    break;
                case "EnglishUi":
                    EnglishUi = value.ToBoolean(false);
                    break;
                case "AlternativeSubtitle":
                    AlternativeSubtitle = value.ToBoolean(false);
                    break;
                case "ThaiFirst":
                    ThaiFirst = value.ToBoolean(true);
                    break;
                case "ShowNotTranslateRow":
                    ShowNotTranslateRow = value.ToBoolean(false);
                    break;
                case "ShowTranslateRow":
                    ShowTranslateRow = value.ToBoolean(false);
                    break;
                case "ShowUiRow":
                    ShowUiRow = value.ToBoolean(false);
                    break;
                case "FontSetting":
                    FontSetting = value.ToFontSetting(eFontSetting.Sarabun);
                    break;
                case "SizeCutscene":
                    SizeCutscene = value.ToInt32(28);
                    break;
                case "SizeDialog":
                    SizeDialog = value.ToInt32(28);
                    break;
                case "DownloadFrequency":
                    DownloadFrequency = value.ToDownloadFrequency(eDownloadFrequency.Hour);
                    break;
            }
        }
    }
}
