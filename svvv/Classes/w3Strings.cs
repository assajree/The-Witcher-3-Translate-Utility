using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWitcher3Thai
{
    public class w3Strings
    {
        public string ID { get; set; }
        public string KeyHex { get; set; }
        public string KeyString { get; set; }
        public string Text { get; set; }
        public string Translate { get; set; }

        public w3Strings()
        {

        }

        public w3Strings(string id,string keyHex,string keyString, string text, string translate)
        {
            this.ID = id;
            this.KeyHex = keyHex;
            this.KeyString = keyString;
            this.Text = text;
            this.Translate = translate;
        }

        public w3Strings(string text, string translate)
        {
            this.Text = text;
            this.Translate = translate;
        }

        public w3Strings(string[] arr,bool w3s)
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

        public bool IsConversation
        {
            get
            {
                return this.KeyHex == "00000000";
            }
        }

        public string ToCsvLine()
        {
            return $@"{this.ID}|{this.KeyHex}|{this.KeyString}|{this.Text.Replace("|", "[[CSV_EXPORT_PIPE]]")}" + "\n";
        }
    }
}
