using System.Windows.Forms;
using TheWitcher3Thai;

namespace TranslateUtility
{
    public partial class frmDonate : Form
    {
        Common c = new Common();
        public frmDonate()
        {
            InitializeComponent();
        }

        private void btnPaypal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c.DonatePaypal();
        }
    }
}
