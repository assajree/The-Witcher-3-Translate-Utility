using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TheWitcher3Thai;
using TheWitcher3Thai.Helper;

namespace svvv.Classes
{
    public class CustomTranslateSetting
    {
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

            // set all enable to false
            foreach (var item in this.Value)
            {
                item.Value.Enable = false;
            }

            var content = File.ReadAllText(mSettingPath).Split('\n').ToList();
            foreach (var c in content)
            {
                var val = c.Trim();
                if (!String.IsNullOrWhiteSpace(val))
                {
                    if(this.Value.ContainsKey(val))
                    {
                        this.Value[val].Enable = true;
                    }
                    else
                    {
                        this.Value.Add(val, new CustomTranslateItem(true,val,null));
                    }

                    
                }
            }
        }

        public void Save()
        {
            var text = string.Join(Environment.NewLine, this.Value);
            File.WriteAllText(mSettingPath, text);
        }
    }
}
