using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svvv.Classes
{
    public class StorybookRow
    {
        public string Start { get; set; }
        public string Stop { get; set; }
        public string Message { get; set; }
        public string Translate { get; set; }
        private const string SEPARATOR = ", ";

        public StorybookRow() { }
        public StorybookRow(string row)
        {
            var arr = row.Split(new string[] { ", " }, StringSplitOptions.None);

            if (arr.Length > 0)
                Start = arr[0];

            if (arr.Length > 1)
                Stop = arr[1];

            if (arr.Length > 2)
                Message = GetMessage(arr);

            //if (arr.Length > 3)
            //    Translate = arr[3];
        }

        private string GetMessage(string[] arr)
        {
            List<string> message = new List<string>();
            for (int i = 2; i < arr.Length; i++)
                message.Add(arr[i]);

            return String.Join(SEPARATOR, message); ;
        }

        public override string ToString()
        {
            string result = Start;

            if (Stop == null)
                return result;
            else
                result += SEPARATOR + Stop;


            string message = Translate;
            if (String.IsNullOrWhiteSpace(message))
                message = Message;

            if (message == null)
                return result;
            else
                result += SEPARATOR + message;

            return result;
        }
    }
    public class Storybook
    {

        public string FilePath { get; private set; } 
        //private List<string> Content { get; set; }
        public List<StorybookRow> Content { get; set; }
        

        public string FileName { get; set; }
        public string FileType { get; private set; }
        public string SheetName { get; private set; }
        public string Parent { get; private set; }
        public string UniqueName { get; private set; }

        public Storybook() { }

        public Storybook(string path)
        {
            SetPath(path);
            Content = new List<StorybookRow>();
        }

        public Storybook(string path, List<string> content)
        {
            SetPath(path);
            SetContent(content);
        }

        public void SetPath(string path)
        {
            this.FilePath = path;
            Initial();
        }

        public void SetContent(List<string> content)
        {
            this.Content = new List<StorybookRow>();
            foreach (var row in content)
            {
                this.Content.Add(new StorybookRow(row));
            }
        }

        private void Initial()
        {
            if (String.IsNullOrWhiteSpace(FilePath))
                return;

            var fi = new FileInfo(FilePath);

            FileType = fi.Directory.Name;
            Parent = fi.Directory.Parent.Name;
            FileName = Path.GetFileNameWithoutExtension(FilePath);

            UniqueName=$@"{Parent}|{FileName}|{FileType}";

            this.SheetName = FileName;
            if(FileType== "altsubs")
            {
                this.SheetName += "_alt";
            }
        }

        private string GetFilePathFromUniqueName(string rootPath, string uniqueName)
        {
            var arr = uniqueName.Split('|');
            if (arr.Length < 3)
                return null;

            string path = Path.Combine(rootPath, arr[0], arr[2], arr[1] + ".subs");
            return rootPath;
        }

        public override string ToString()
        {
            if (this.Content == null || this.Content.Count == 0)
                return null;

            var sb = new StringBuilder();
            foreach(var c in Content)
            {
                sb.Append(c.ToString() + Environment.NewLine);
            }

            return sb.ToString();
        }
    }

    
}
