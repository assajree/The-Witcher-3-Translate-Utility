using svvv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace AdvanceTools.Screens
{
    public partial class frmFirebase : Form
    {
        Common c = new Common();
        Setting setting = new Setting();
        Dictionary<string, string> sheetConfig;

        public frmFirebase()
        {
            InitializeComponent();
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            c.SelectXlsxTextBox(txtExcelPath);
        }

        private void btnExcelToJson_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtExcelPath.Text))
                return;

            var raw = c.ReadExcel(txtExcelPath.Text, sheetConfig, true);
            var data = c.ConvertToW2String(raw).ToDictionary(d=>d.Index,d=>d);
            var path = Path.Combine(Configs.OutputPath, "data.json");
            var json = c.ToJson(data);
            c.WriteJson(json, path);
            MessageBox.Show("finish");
        }

        private void frmFirebase_Load(object sender, EventArgs e)
        {
            sheetConfig = setting.GetSheetConfig();
        }

        private void txtExcelPath_DoubleClick(object sender, EventArgs e)
        {
            c.Open(Configs.StartupPath);
        }

        private void btnMakeData_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Configs.OutputPath, "data.json");
            var data = c.ReadServerJson(path);            
            c.WriteJson(data, Path.Combine(Configs.OutputPath, $@"data_{DateTime.Now.ToString("yyyyMMdd_HHmmssfff")}.json"));
            MessageBox.Show("finish");

        }
    }
}
