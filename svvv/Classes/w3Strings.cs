using svvv.Classes;
using System;

namespace TheWitcher3Thai
{
    public class w3Strings
    {
        public enum eTranslateStatus
        {
            NotTranslate,
            SameWord,
            Translated
        }

        public string ID { get; set; }
        public string KeyHex { get; set; }
        public string KeyString { get; set; }
        public string Text { get; set; }
        public string Translate { get; set; }
        public int? RowNumber { get; set; }
        public string SheetName { get; set; }
        public string GoogleTranslate { get; set; }
        public int? Index { get; set; }
        //public bool Locked { get; set; } = false;

        public w3Strings()
        {

        }

        public w3Strings(string id, string keyHex, string keyString, string text, string translate, string sheetName = null, int? rowNumber = null, string googlsTranslate = null, int? index = null)
        {
            this.ID = id;
            this.KeyHex = keyHex;
            this.KeyString = keyString;
            this.Text = text;
            this.Translate = translate?.Trim();
            this.RowNumber = rowNumber;
            this.SheetName = sheetName;
            this.GoogleTranslate = googlsTranslate;
            this.Index = index;

        }

        public w3Strings(string text, string translate)
        {
            this.Text = text;
            this.Translate = translate;
        }

        public w3Strings(string[] arr, bool w3s)
        {
            //this.Key = arr[0];
            //this.Text = arr[1].Replace("[[CSV_EXPORT_PIPE]]", "|");

            if (w3s)
            {
                this.ID = arr[0];
                this.KeyHex = arr[1];
                this.KeyString = arr[2];
                this.Text = arr[3].Replace("[[CSV_EXPORT_PIPE]]", "|"); ;
                //this.Translate = arr[3].Replace("[[CSV_EXPORT_PIPE]]", "|"); ;
            }
            else
            {
                this.Text = arr[0];
                this.Translate = arr[1];
            }
        }

        public eTranslateStatus TranslateStatus
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.Translate))
                    return eTranslateStatus.NotTranslate;
                else if (this.Text == this.Translate)
                    return eTranslateStatus.SameWord;
                else
                    return eTranslateStatus.Translated;
            }
        }

        public bool IsConversation
        {
            get
            {
                // not have key hex
                if (this.KeyHex == "00000000")
                {
                    return true;
                }
                // have key  hex
                //else
                //{
                //    if (this.Text.Contains(":"))
                //        return false;
                //    else if (this.Text.Length > 50)
                //        return true;
                //    else
                //        return false;
                //}

                return false;
            }
        }

        public string IdKey
        {
            get
            {
                return ID.Trim();
            }
        }

        public bool IsUiText
        {
            get
            {
                return !IsConversation;
            }
        }

        public string ToCsvLine()
        {
            return $@"{this.ID}|{this.KeyHex}|{this.KeyString}|{this.Text.Replace("|", "[[CSV_EXPORT_PIPE]]")}" + "\n";
        }

        public bool EmptyTranslate
        {
            get
            {
                return String.IsNullOrWhiteSpace(this.Translate);
            }
        }

        public W2Strings ToW2Strings()
        {
            return new W2Strings()
            {
                Key = this.IdKey,
                //KeyHex = this.KeyHex,
                //KeyString = this.KeyString,
                //Row= this.RowNumber ?? 0,
                //SheetName = this.SheetName,
                Text = this.Text,
                Translate = this.Translate,
                GoogleTranslate = this.GoogleTranslate,
                Index = this.Index ?? 0,
            };
        }
    }
}
