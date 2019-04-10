using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWitcher3Thai
{
    public class MergeException: Exception
    {
        public string Key { get; set; }
        public string SourceText { get; set; }
        public string TranslateText { get; set; }

        public MergeException(string key, string source, string translate)
        {
            this.Key = key.Trim();
            this.SourceText = source;
            this.TranslateText = translate;
        }

        public MergeException(w3Strings source, w3Strings translate)
        {
            this.Key = source.ID;
            this.SourceText = source.Text;
            this.TranslateText = translate.Text;
        }
    }
}
