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
    public partial class Homepage : Form
    {
        private AdminInterfata _adminForm;
        private List<Film> _filme = new List<Film>();

        public Homepage(List<Film> filme)
        {
            InitializeComponent();
            _filme = filme;
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Hide();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdminInterfata admin = new AdminInterfata(_filme);
            admin.ShowDialog();
            this.Close();
        }

        private void BTNClient_Click(object sender, EventArgs e)
        {
            ClientInterfata client = new ClientInterfata(_adminForm);
            client.ShowDialog();
            this.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
