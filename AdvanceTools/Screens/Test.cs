using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceTools.Screens
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://witcher-3-translate-utility.web.app/#/addcounter/download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;

        }
    }
}
