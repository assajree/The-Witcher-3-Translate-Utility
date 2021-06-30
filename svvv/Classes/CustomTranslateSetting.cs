using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace svvv.Classes
{
    public class CustomTranslateSetting
    {
        const string SEPARATOR = ":";
        Common c = new Common();
        string mSettingPath;

        public Dictionary<string, CustomTranslateItem> Value { get; set; }

        public CustomTranslateSetting(string settingPath) : this(settingPath, null)
        {
        }

        public CustomTranslateSetting(string settingPath, List<CustomTranslateItem> defaultSetting)
        {
            mSettingPath = settingPath;
            LoadSetting(defaultSetting);
            ReadAllDescription();
        }

        private void ReadAllDescription()
        {
            foreach(var item in this.Value.Values)
            {
                var desc = c.GetCustomTranslateDescription(item.ID);
                if (desc == null)
                    desc = "[กดอัพเดทเพื่อดูคำอธิบาย]";

                item.Description = desc;
            }
        }

        private void LoadSetting(List<CustomTranslateItem> defaultSetting)
        {
            this.Value = new Dictionary<string, CustomTranslateItem>();

            // get default custom translate
            if (defaultSetting != null)
            {
                foreach (var item in defaultSetting)
                {
                    if (!this.Value.ContainsKey(item.ID))
                        this.Value.Add(item.ID, item);
                }
            }

            // config file not found
            if (!File.Exists(mSettingPath))
            {
                return;
            }

            //// set all enable to false
            //foreach (var item in this.Value)
            //{
            //    item.Value.Enable = false;
            //}

            var content = File.ReadAllText(mSettingPath).Split('\n').ToList();
            foreach (var c in content)
            {
                var setting = GetSetting(c);
                if (String.IsNullOrWhiteSpace(setting.ID))
                    continue;

                if (this.Value.ContainsKey(setting.ID))
                {
                    this.Value[setting.ID].Enable = setting.Enable;
                }
                else
                {
                    if(setting.ID == Configs.W3eeFileId)
                    {
                        var w3eePath = Path.Combine(Configs.GetAppSetting().GamePath, "mods", "modW3EEMain");
                        if (!Directory.Exists(w3eePath))
                            continue;
                    }

                    this.Value.Add(setting.ID, setting);
                }
            }
        }

        private CustomTranslateItem GetSetting(string str)
        {
            var result = new CustomTranslateItem();
            if (String.IsNullOrWhiteSpace(str))
                return result;

            var arr = str.Split(new string[] { SEPARATOR }, 2, StringSplitOptions.None);
            result.ID = arr[0].Trim();
            if(arr.Length>1)
                result.Enable= arr[1].ToBoolean(false);

            return result;
        }

        public void Save()
        {
            var sb = new StringBuilder();
            foreach(var item in this.Value.Values)
            {
                sb.AppendLine($@"{item.ID}{SEPARATOR}{item.Enable}");
            }
            File.WriteAllText(mSettingPath, sb.ToString());
        }
    }
}
