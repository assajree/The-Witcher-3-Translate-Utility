using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWitcher3Thai
{
    public class Setting
    {
        public Dictionary<string, string> GetSheetConfig()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("content0", @"content\content0");
            d.Add("content1", @"content\content1");
            d.Add("content2", @"content\content2");
            d.Add("content3", @"content\content3");
            d.Add("content4", @"content\content4");
            d.Add("content5", @"content\content5");
            d.Add("content6", @"content\content6");
            d.Add("content7", @"content\content7");
            d.Add("content8", @"content\content8");
            d.Add("content9", @"content\content9");
            d.Add("content10", @"content\content10");
            d.Add("content11", @"content\content11");
            d.Add("content12", @"content\content12");
            d.Add("DLCbobcontent", @"dlc\bob\content");
            d.Add("DLCEP1content", @"dlc\ep1\content");

            return d;
        }

        public List<string> GetKnowIssueKey()
        {
            List<string> result = new List<string>();

            result.Add("1092719"); // Already started in on it. Hope they didn't muck up the tracks. | muck up the tracks..

            return result;
        }

        public List<string> GetDoubleLanguageIgnoreList()
        {
            List<string> result = new List<string>();

            // ui 
            result.Add("1086687"); //เลเวลที่แนะนำ
            result.Add("397232");  //อภิธานศัพท์
            result.Add("1046641"); 
            result.Add("1076399"); 
            result.Add("6dcdb31f"); //ปรุงยา
            result.Add("1084742"); 
            result.Add("1084766"); 
            result.Add("1086265"); 
            result.Add("456530"); //ช่องเก็บของ
            result.Add("69b768e1"); 
            result.Add("1084772"); 

            return result;
        }
    }
}
