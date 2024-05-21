using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class AdminInterfata : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexandra\OneDrive\Documente\filme_db.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminInterfata()
        {
            InitializeComponent();
        }

        public void populareGrid()
        {
            con.Open();
            string query = "select * from filme_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            SqlCommandBuilder cmdBuiler = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGFilme.DataSource = ds.Tables[0];
            con.Close();
        }
        private void AdminInterfata_Load(object sender, EventArgs e)
        {
            populareGrid();
        }
    }
}
