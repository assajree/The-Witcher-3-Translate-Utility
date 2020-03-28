using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWitcher3Thai;

namespace svvv.Classes
{
    public class W2Strings
    {
        public string Key { get; set; }
        public string Text { get; set; }
        public string Translate { get; set; }
        //public string GoogleTranslate { get; set; }
        public int Index { get; set; }
        //public int Row { get; set; }

        //public string KeyHex { get; set; }
        //public string KeyString { get; set; }
        //public string SheetName { get; set; }


        public bool IsTranslate
        {
            get
            {
                return !String.IsNullOrEmpty(Translate);
            }
        }

        public int Length
        {
            get
            {
                return (Text?.Length) ?? 0;
            }
        }

        public W2Strings()
        {

        }

        public W2Strings(string key, string text, string translate = null, string googleTranslate = null, int row = 0, int index = 0)
        {
            this.Key = key;
            this.Text = text;
            this.Translate = translate;
            //this.GoogleTranslate = googleTranslate;
            //this.Row = row;
            this.Index = index;
        }

        public w3Strings ToW3Strings()
        {
            return new w3Strings()
            {
                ID = this.Key,
                //KeyHex = this.KeyHex,
                //KeyString = this.KeyString,
                //RowNumber = this.Row,
                //SheetName = this.SheetName,
                Text = this.Text,
                Translate = this.Translate,
                Index=this.Index
            };

        }
    }
}
