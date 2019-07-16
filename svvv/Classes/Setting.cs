﻿using svvv.Classes;
using System.Collections.Generic;
using System.Linq;

namespace TheWitcher3Thai
{
    public class Setting
    {
        Dictionary<string, string> mSheetConfig;
        Dictionary<string, string> mExtraSheetConfig;
        Dictionary<string, string> mStorybookMaping;
        Dictionary<string, string> mSheetName;
        List<CustomTranslateItem> mCustomTranslate;

        public Dictionary<string, string> GetSheetConfig()
        {
            if (mSheetConfig != null)
                return mSheetConfig;

            mSheetConfig = new Dictionary<string, string>();

            mSheetConfig.Add("content0", @"content\content0");
            mSheetConfig.Add("content1", @"content\content1");
            mSheetConfig.Add("content2", @"content\content2");
            mSheetConfig.Add("content3", @"content\content3");
            mSheetConfig.Add("content4", @"content\content4");
            mSheetConfig.Add("content5", @"content\content5");
            mSheetConfig.Add("content6", @"content\content6");
            mSheetConfig.Add("content7", @"content\content7");
            mSheetConfig.Add("content8", @"content\content8");
            mSheetConfig.Add("content9", @"content\content9");
            mSheetConfig.Add("content10", @"content\content10");
            mSheetConfig.Add("content11", @"content\content11");
            mSheetConfig.Add("content12", @"content\content12");

            mSheetConfig.Add("DLCbobcontent", @"dlc\bob\content");
            mSheetConfig.Add("DLCEP1content", @"dlc\ep1\content");

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

            mSheetConfig.Add("DLCall", @"dlc\dlcAll\content");
            //d.Add("patch1", @"content\patch1");

            mSheetConfig.Add("MISSING", @"content\missing");
            mSheetConfig.Add("FIX", @"content\fix");

            return mSheetConfig;
        }

        public Dictionary<string, string> GetSheetName()
        {
            if (mSheetName != null)
                return mSheetName;

            mSheetName = new Dictionary<string, string>();

            mSheetName.Add("content0", "content0");
            mSheetName.Add("content1", "content1");
            mSheetName.Add("content2", "content2");
            mSheetName.Add("content3", "content3");
            mSheetName.Add("content4", "content4");
            mSheetName.Add("content5", "content5");
            mSheetName.Add("content6", "content6");
            mSheetName.Add("content7", "content7");
            mSheetName.Add("content8", "content8");
            mSheetName.Add("content9", "content9");
            mSheetName.Add("content10", "content10");
            mSheetName.Add("content11", "content11");
            mSheetName.Add("content12", "content12");

            mSheetName.Add("DLCEP1content", "DLCEP1content (Heart of Stone)");
            mSheetName.Add("DLCbobcontent", "DLCbobcontent (Blood and Wine)");

            mSheetName.Add("DLCall", "DLCall (Other DLC)");
            //d.Add("MISSING", "MISSING");

            return mSheetName;
        }


        public Dictionary<string, string> GetExtraSheetConfig()
        {
            if (mExtraSheetConfig != null)
                return mExtraSheetConfig;

            mExtraSheetConfig = new Dictionary<string, string>();

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

            mExtraSheetConfig.Add("MISSING", @"content\missing");
            mExtraSheetConfig.Add("FIX", @"content\fix");

            return mExtraSheetConfig;
        }

        public Dictionary<string, string> GetStorybookMaping()
        {
            if (mStorybookMaping != null)
                return mStorybookMaping;

            mStorybookMaping = new Dictionary<string, string>();

            mStorybookMaping.Add("st3 main", "st_3_tr");
            mStorybookMaping.Add("flb1a main", "rs_1a_tr");
            mStorybookMaping.Add("flb5a main", "rs_5a_tr");
            mStorybookMaping.Add("flb4a main", "rs_4a_tr");
            mStorybookMaping.Add("flb4b main", "rs_4b_tr");
            mStorybookMaping.Add("flb2b main", "rs_2b_tr");
            mStorybookMaping.Add("flb2a main", "rs_2a_tr");
            mStorybookMaping.Add("flb3b main", "rs_3b_tr");
            mStorybookMaping.Add("flb3a main", "rs_3a_tr");
            mStorybookMaping.Add("flb5b main", "rs_5b_tr");
            mStorybookMaping.Add("flb6a no main", "rs_6a_tr_alt");
            mStorybookMaping.Add("flb6a main", "rs_6a_tr");
            mStorybookMaping.Add("flb6b main", "rs_6b_tr");
            mStorybookMaping.Add("fnb1a", "fb_1a_tr");
            mStorybookMaping.Add("fnb1b", "fb_1b_tr");
            mStorybookMaping.Add("fnb3a", "fb_3a_tr");
            mStorybookMaping.Add("fnb3c", "fb_3c_tr");
            mStorybookMaping.Add("fnb3b", "fb_3b_tr");
            mStorybookMaping.Add("fnb4b", "fb_4b_tr");
            mStorybookMaping.Add("fnb4a", "fb_4a_tr");
            mStorybookMaping.Add("fnb2c", "fb_2c_tr");
            mStorybookMaping.Add("fnb2b", "fb_2b_tr");
            mStorybookMaping.Add("fnb2a", "fb_2a_tr");
            mStorybookMaping.Add("fnb6a", "fb_6a_tr");
            mStorybookMaping.Add("fnb6c", "fb_6c_tr");
            mStorybookMaping.Add("fnb6b", "fb_6b_tr");
            mStorybookMaping.Add("fnb5c", "fb_5c_tr");
            mStorybookMaping.Add("fnb5a", "fb_5a_tr");
            mStorybookMaping.Add("fnb5b", "fb_5b_tr");
            mStorybookMaping.Add("fnb1c", "fb_1c_tr");

            mStorybookMaping.Add("st10 nm", "st_10_tr_alt");
            mStorybookMaping.Add("st10 m", "st_10_tr");
            mStorybookMaping.Add("st4 nm", "st_4_tr_alt");
            mStorybookMaping.Add("st12 nm", "st_12_tr_alt");
            mStorybookMaping.Add("st13 nm", "st_13_tr_alt");
            mStorybookMaping.Add("st15 nm", "st_15_tr_alt");
            mStorybookMaping.Add("st19 nm", "st_19_tr_alt");
            mStorybookMaping.Add("st20 nm", "st_20_tr_alt");
            mStorybookMaping.Add("st22 nm", "st_22_tr_alt");
            mStorybookMaping.Add("st23 nm", "st_23_tr_alt");
            mStorybookMaping.Add("st4 m", "st_4_tr");
            mStorybookMaping.Add("st12 m", "st_12_tr");
            mStorybookMaping.Add("st13 m", "st_13_tr");
            mStorybookMaping.Add("st15 m", "st_15_tr");
            mStorybookMaping.Add("st19 m", "st_19_tr");
            mStorybookMaping.Add("st20 m", "st_20_tr");
            mStorybookMaping.Add("st22 m", "st_22_tr");
            mStorybookMaping.Add("st23 m", "st_23_tr");
            mStorybookMaping.Add("st14 m", "st_14_tr");
            mStorybookMaping.Add("st5 m", "st_5_tr");
            mStorybookMaping.Add("st6 m", "st_6_tr");
            mStorybookMaping.Add("st7 m", "st_7_tr");
            mStorybookMaping.Add("st8 m", "st_8_tr");
            mStorybookMaping.Add("st9 m", "st_9_tr");
            mStorybookMaping.Add("st11 m", "st_11_tr");

            var keyCount = mStorybookMaping.Select(r => r.Key).Distinct().ToList().Count;
            var valueCount = mStorybookMaping.Select(r => r.Value).Distinct().ToList().Count;
            if (keyCount != valueCount)
                throw new KnowException("Incorrect sheet mapping");

            return mStorybookMaping;
        }

        public List<CustomTranslateItem> GetCustomTranslate()
        {
            if (mCustomTranslate != null)
                return mCustomTranslate;

            mCustomTranslate = new List<CustomTranslateItem>();

            // english quest name
            mCustomTranslate.Add(new CustomTranslateItem(true, "1X2VOm21x5ow_duSutaXV3AsCdz2YT1RVZZQoiPZHp14", null));

            // message fix
            mCustomTranslate.Add(new CustomTranslateItem(false, "1eDp6YF3kdx9FXc8dfMFhz72QbH9wYJfKRx2gwvD4Wcg", null));

            // funny subtitle
            mCustomTranslate.Add(new CustomTranslateItem(false, "19uVPHxzMBwCxpnjKqakNkBqxSOm2CH173L4wpwiUjS0", null));

           

            return mCustomTranslate;
        }
    }
}
