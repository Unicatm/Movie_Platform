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
    }
}
