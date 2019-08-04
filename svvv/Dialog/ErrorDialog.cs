using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace svvv.Dialog
{
    public partial class ErrorDialog : Form
    {
        public ErrorDialog()
        {
            InitializeComponent();
        }

        private void ErrorDialog_Load(object sender, EventArgs e)
        {
            //ToggleDeteil();
        }

        private void ToggleDeteil()
        {
            if(pnDetail.Visible)
            {
                this.AutoSize = false;
                this.Height -= pnDetail.Height;
                pnDetail.Visible = false;

            }
            else
            {
                this.AutoSize = true;
                pnDetail.Visible = true;
                this.Height += pnDetail.Height;

            }
        }

        private void lblDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToggleDeteil();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblDetail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToggleDeteil();
        }

        private void lblLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMessage.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        }
    }
}
