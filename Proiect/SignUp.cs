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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void LkLblLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void LnkToHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void CkBViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CkBViewPassword.Checked == true)
            {
                inputField5.PasswordCharType = '\0';
            }
            else
            {
                inputField5.PasswordCharType = '*';
            }
        }

        private void TxtBCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar))
                //if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void TBPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TxtBCNP_KeyPress (sender, e);
        }

        private void TxtBCNP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
