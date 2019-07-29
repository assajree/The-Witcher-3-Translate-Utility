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

        public bool DoubleLanguage { get; set; } = false;
        public bool EnglishUi { get; set; } = false;
        public bool OldMethod { get; set; } = false;
        public bool BackupSetting { get; set; } = true;
        public bool ThaiFirst { get; set; } = true;
        public bool ShowNotTranslateRow { get; set; } = false;
        public bool ShowTranslateRow { get; set; } = false;
        public bool ShowUiRow { get; set; } = false;
        public bool ChangeTextColor { get; set; } = true;
        public eFontSetting FontSetting { get; set; } = eFontSetting.Sarabun;
        public int SizeCutscene { get; set; } = 34;
        public int SizeDialog { get; set; } = 34;
        public eDownloadFrequency DownloadFrequency { get; set; } = eDownloadFrequency.Hour;
        public string GamePath { get; set; } = "";
        public int ExpandHeight { get; set; } = Constant.SIZE_DEFAULT_EXPAND;
        public int CollaspeHeight { get; set; } = Constant.SIZE_DEFAULT_COLLASPE;

        public AppSetting(string settingPath)
        {
            mSettingPath = settingPath;
            LoadSetting();
            SaveSetting();            
        }

        private void LoadSetting()
        {
            //InitialValue();
            if (!File.Exists(mSettingPath))
                return;

            var content = File.ReadAllText(mSettingPath).Split('\n').ToList();
            foreach (var c in content)
            {
                GetValue(c);
            }
        }

        public void SaveSetting()
        {
            File.WriteAllText(mSettingPath, ToString());
            Configs.SetAppSetting(this);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($@"GamePath={GamePath}");
            sb.AppendLine($@"DoubleLanguage={DoubleLanguage}");
            sb.AppendLine($@"EnglishUi={EnglishUi}");
            sb.AppendLine($@"OldMethod={OldMethod}");
            sb.AppendLine($@"BackupSetting={BackupSetting}");
            sb.AppendLine($@"ThaiFirst={ThaiFirst}");
            sb.AppendLine($@"ShowNotTranslateRow={ShowNotTranslateRow}");
            sb.AppendLine($@"ShowTranslateRow={ShowTranslateRow}");
            sb.AppendLine($@"ShowUiRow={ShowUiRow}");
            sb.AppendLine($@"ChangeTextColor={ChangeTextColor}");
            sb.AppendLine($@"FontSetting={FontSetting}");
            sb.AppendLine($@"SizeCutscene={SizeCutscene}");
            sb.AppendLine($@"SizeDialog={SizeDialog}");
            sb.AppendLine($@"DownloadFrequency={DownloadFrequency}");

            if(ExpandHeight!= Constant.SIZE_DEFAULT_EXPAND)
                sb.AppendLine($@"ExpandHeight={ExpandHeight}");

            if (CollaspeHeight != Constant.SIZE_DEFAULT_COLLASPE)
                sb.AppendLine($@"CollaspeHeight={CollaspeHeight}");

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
                    DoubleLanguage = value.ToBoolean(false);
                    break;
                case "EnglishUi":
                    EnglishUi = value.ToBoolean(false);
                    break;
                case "OldMethod":
                    OldMethod = value.ToBoolean(false);
                    break;
                case "BackupSetting":
                    BackupSetting = value.ToBoolean(true);
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
                case "ChangeTextColor":
                    ChangeTextColor = value.ToBoolean(true);
                    break;
                case "FontSetting":
                    FontSetting = value.ToFontSetting(eFontSetting.Sarabun);
                    break;
                case "SizeCutscene":
                    SizeCutscene = value.ToInt32(34);
                    break;
                case "SizeDialog":
                    SizeDialog = value.ToInt32(34);
                    break;
                case "DownloadFrequency":
                    DownloadFrequency = value.ToDownloadFrequency(eDownloadFrequency.Hour);
                    break;
                case "GamePath":
                    GamePath = value;
                    break;
                case "ExpandHeight":
                    ExpandHeight = value.ToInt32(Constant.SIZE_DEFAULT_EXPAND);
                    break;
                case "CollaspeHeight":
                    CollaspeHeight = value.ToInt32(Constant.SIZE_DEFAULT_COLLASPE);
                    break;
            }
        }
    }
}
