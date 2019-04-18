using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheWitcher3Thai;

namespace TranslateUtility
{
    public partial class frmLauncher : Form
    {
        Common c = new Common();

        public frmLauncher()
        {
            InitializeComponent();
        }

        private void OnChildClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnGameTools_Click(object sender, EventArgs e)
        {
            OpenForm(new frmGameTools());
        }       

        private void btnModTools_Click(object sender, EventArgs e)
        {
            OpenForm(new frmModTools());
        }

        private void btnExcelTools_Click(object sender, EventArgs e)
        {
            OpenForm(new frmExcelTools());
        }


        private void btnSimple_Click(object sender, EventArgs e)
        {
            OpenForm(new frmSimple());
        }

        private void btnDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForm(new frmDonate());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenForm(Form frm)
        {
            this.Hide();
            frm.Closed += OnChildClosed;
            frm.ShowDialog();
        }

        private void btnVerySimple_Click(object sender, EventArgs e)
        {
            OpenForm(new frmVerySimple());
        }
    }
}
