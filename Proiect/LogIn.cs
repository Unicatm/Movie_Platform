using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class LogIn : Form
    {
        string connName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=filme;Integrated Security=True";
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
                CPassword.PasswordCharType = '\0';
            }
            else
            {
                CPassword.PasswordCharType = '*';
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            string email = CEmail.TBInput.Text;
            string password = CPassword.TBInput.Text;


            try
            {
                string querry = "SELECT * FROM clienti_tbl WHERE email='" + CEmail.TBInput.Text + "' AND password='" + CPassword.TBInput.Text+"' ";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, connName);

                DataTable dTable = new DataTable();
                adapter.Fill(dTable);

                if(dTable.Rows.Count > 0) { 
                    ClientInterfata clInterface = new ClientInterfata();
                    clInterface.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect email or password! Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login!");
            }
        }
    }
}
