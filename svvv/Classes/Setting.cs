using svvv.Classes;
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

            // extra
            //d.Add("DLC1", @"dlc\dlc1\content");
            //d.Add("DLC2", @"dlc\dlc2\content");
            //d.Add("DLC3", @"dlc\dlc3\content");
            //d.Add("DLC4", @"dlc\dlc4\content");
            //d.Add("DLC5", @"dlc\dlc5\content");
            //d.Add("DLC6", @"dlc\dlc6\content");
            //d.Add("DLC7", @"dlc\dlc7\content");
            //d.Add("DLC8", @"dlc\dlc8\content");
            //d.Add("DLC9", @"dlc\dlc9\content");
            //d.Add("DLC10", @"dlc\dlc10\content");
            //d.Add("DLC11", @"dlc\dlc11\content");
            //d.Add("DLC12", @"dlc\dlc12\content");
            //d.Add("DLC13", @"dlc\dlc13\content");
            //d.Add("DLC14", @"dlc\dlc14\content");
            //d.Add("DLC15", @"dlc\dlc15\content");
            //d.Add("DLC16", @"dlc\dlc16\content");

            d.Add("DLCall", @"dlc\dlcAll\content");
            //d.Add("patch1", @"content\patch1");
            //d.Add("MISSING", @"content\missing");

            return d;
        }

        public Dictionary<string, string> GetSheetName()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("content0", "content0");
            d.Add("content1", "content1");
            d.Add("content2", "content2");
            d.Add("content3", "content3");
            d.Add("content4", "content4");
            d.Add("content5", "content5");
            d.Add("content6", "content6");
            d.Add("content7", "content7");
            d.Add("content8", "content8");
            d.Add("content9", "content9");
            d.Add("content10", "content10");
            d.Add("content11", "content11");
            d.Add("content12", "content12");
            
            d.Add("DLCEP1content", "DLCEP1content (Heart of Stone)");
            d.Add("DLCbobcontent", "DLCbobcontent (Blood and Wine)");

            d.Add("DLCall", "DLCall (Other DLC)");
            //d.Add("MISSING", "MISSING");

            return d;
        }


        public Dictionary<string, string> GetExtraSheetConfig()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            // extra
            //d.Add("DLC1", @"dlc\dlc1\content");
            //d.Add("DLC2", @"dlc\dlc2\content");
            //d.Add("DLC3", @"dlc\dlc3\content");
            //d.Add("DLC4", @"dlc\dlc4\content");
            //d.Add("DLC5", @"dlc\dlc5\content");
            //d.Add("DLC6", @"dlc\dlc6\content");
            //d.Add("DLC7", @"dlc\dlc7\content");
            //d.Add("DLC8", @"dlc\dlc8\content");
            //d.Add("DLC9", @"dlc\dlc9\content");
            //d.Add("DLC10", @"dlc\dlc10\content");
            //d.Add("DLC11", @"dlc\dlc11\content");
            //d.Add("DLC12", @"dlc\dlc12\content");
            //d.Add("DLC13", @"dlc\dlc13\content");
            //d.Add("DLC14", @"dlc\dlc14\content");
            //d.Add("DLC15", @"dlc\dlc15\content");
            //d.Add("DLC16", @"dlc\dlc16\content");

            d.Add("MISSING", @"content\missing");

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

        public Dictionary<string,string> GetStorybookMaping()
        {
            var result = new Dictionary<string, string>();

            result.Add("st3 main", "st_3_tr");
            result.Add("flb1a main", "rs_1a_tr");
            result.Add("flb5a main", "rs_5a_tr");
            result.Add("flb4a main", "rs_4a_tr");
            result.Add("flb4b main", "rs_4b_tr");
            result.Add("flb2b main", "rs_2b_tr");
            result.Add("flb2a main", "rs_2a_tr");
            result.Add("flb3b main", "rs_3b_tr");
            result.Add("flb3a main", "rs_3a_tr");
            result.Add("flb5b main", "rs_5b_tr");
            result.Add("flb6a no main", "rs_6a_tr_alt");
            result.Add("flb6a main", "rs_6a_tr");
            result.Add("flb6b main", "rs_6b_tr");
            result.Add("fnb1a", "fb_1a_tr");
            result.Add("fnb1b", "fb_1b_tr");
            result.Add("fnb3a", "fb_3a_tr");
            result.Add("fnb3c", "fb_3c_tr");
            result.Add("fnb3b", "fb_3b_tr");
            result.Add("fnb4b", "fb_4b_tr");
            result.Add("fnb4a", "fb_4a_tr");
            result.Add("fnb2c", "fb_2c_tr");
            result.Add("fnb2b", "fb_2b_tr");
            result.Add("fnb2a", "fb_2a_tr");
            result.Add("fnb6a", "fb_6a_tr");
            result.Add("fnb6c", "fb_6c_tr");
            result.Add("fnb6b", "fb_6b_tr");
            result.Add("fnb5c", "fb_5c_tr");
            result.Add("fnb5a", "fb_5a_tr");
            result.Add("fnb5b", "fb_5b_tr");
            result.Add("fnb1c", "fb_1c_tr");

            result.Add("st10 nm", "st_10_tr_alt");
            result.Add("st10 m", "st_10_tr");
            result.Add("st4 nm", "st_4_tr_alt");
            result.Add("st12 nm", "st_12_tr_alt");
            result.Add("st13 nm", "st_13_tr_alt");
            result.Add("st15 nm", "st_15_tr_alt");
            result.Add("st19 nm", "st_19_tr_alt");
            result.Add("st20 nm", "st_20_tr_alt");
            result.Add("st22 nm", "st_22_tr_alt");
            result.Add("st23 nm", "st_23_tr_alt");
            result.Add("st4 m", "st_4_tr");
            result.Add("st12 m", "st_12_tr");
            result.Add("st13 m", "st_13_tr");
            result.Add("st15 m", "st_15_tr");
            result.Add("st19 m", "st_19_tr");
            result.Add("st20 m", "st_20_tr");
            result.Add("st22 m", "st_22_tr");
            result.Add("st23 m", "st_23_tr");
            result.Add("st14 m", "st_14_tr");
            result.Add("st5 m", "st_5_tr");
            result.Add("st6 m", "st_6_tr");
            result.Add("st7 m", "st_7_tr");
            result.Add("st8 m", "st_8_tr");
            result.Add("st9 m", "st_9_tr");
            result.Add("st11 m", "st_11_tr");

            var keyCount = result.Select(r => r.Key).Distinct().ToList().Count;
            var valueCount = result.Select(r => r.Value).Distinct().ToList().Count;
            if (keyCount != valueCount)
                throw new Exception("Incorrect sheet mapping");

            return result;
        }
    }
}
