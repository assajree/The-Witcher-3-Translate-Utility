using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svvv.Classes
{
    public class SheetConfig
    {
        public string SheetName { get; set; }
        public string Path { get; set; }

        public SheetConfig()
        {
        }

        public SheetConfig(string sheetName, string path)
        {
            SheetName = sheetName;
            Path = path;
        }
    }
}
