using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LnkToHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
/*            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();*/
        }

        private void LkLblLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void CkBViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(CkBViewPassword.Checked == true) {
                inputField5.PasswordCharType = '\0';
            }
            else
            {
                inputField5.PasswordCharType = '*';
            }
        }
    }
}
