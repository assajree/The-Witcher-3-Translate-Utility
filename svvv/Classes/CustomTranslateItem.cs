using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svvv.Classes
{
    public class CustomTranslateItem
    {
        public bool Enable { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        

        public CustomTranslateItem()
        {

        }

        public CustomTranslateItem(string id)
        {
            this.ID = id;
        }

        public CustomTranslateItem(string id, string description): this(id)
        {
            this.Description = description;
        }

        public CustomTranslateItem(bool enable,string id, string description) : this(id,description)
        {
            this.Enable = enable;
        }
    }
}
