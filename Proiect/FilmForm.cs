using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class FilmForm : Form
    {
        string connName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=filme;Integrated Security=True";
        public Film fSecundar;
        private ListView lvSec;
        public FilmForm(Film f, ListView lv)
        {
            InitializeComponent();
            if(f == null)
            {
                f = new Film();
                BtnAdauga.Text = "Adauga";
                LbHeader.Text = "Adauga un nou film";
                TBId.ReadOnly = false;
            }
            else
            {
                BtnAdauga.Text = "Modifica";
                LbHeader.Text = "Editeaza filmul";
                TBId.Text = f.IdFilm.ToString();
                TBId.ReadOnly = true;
                TbTitle.Text = f.Titlu;
                TBDescr.Text = f.Descriere;
                TBStoc.Text = f.Bucati.ToString();
                DTAn.Value = f.AnLansare;
                TBDurata.Text = f.Durata.ToString();
            }
            fSecundar = f;
            lvSec = lv;
            var genValueLits = Enum.GetValues(typeof(Gen));
            foreach (Gen unGen in genValueLits)
            {
                CBGen.Items.Add(unGen);
            }
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {
            CBGen.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'filme_dbDS.filme_tbl' table. You can move, or remove it, as needed.
            //this.filme_tblTableAdapter.Fill(this.filme_dbDS.filme_tbl);

        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            fSecundar.IdFilm = Convert.ToInt32(TBId.Text);
            fSecundar.Titlu = TbTitle.Text;
            fSecundar.Descriere = TBDescr.Text;
            fSecundar.Bucati = Convert.ToInt32(TBStoc.Text);
            fSecundar.AnLansare = DTAn.Value;
            fSecundar.Gen = CBGen.SelectedItem.ToString();
            fSecundar.Durata = Convert.ToInt32(TBDurata.Text);
        }

        private void TBId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void TBStoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void TBId_Validating(object sender, CancelEventArgs e)
        {
            if (BtnAdauga.Text == "Adauga")
            {
                using (SqlConnection connection = new SqlConnection(connName))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM filme_tbl WHERE id_film = @IdFilm";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@IdFilm", TBId.Text);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            errorProvider1.SetError(TBId, "Id-ul exista!");
                            BtnAdauga.Enabled = false;
                        }
                        else
                        {
                            errorProvider1.SetError(TBId, "");
                            BtnAdauga.Enabled = true;
                        }

                    }

                    /*foreach (ListViewItem lvi in lvSec.Items)
                    {
                        if (lvi.SubItems[0].Text == TBId.Text)
                        {
                            errorProvider1.SetError(TBId, "Id-ul exista!");
                            BtnAdauga.Enabled = false;
                        }
                        else
                        {
                            errorProvider1.SetError(TBId, "");
                            BtnAdauga.Enabled = true;

                        }
                    }*/
                }
            }
        }

        private void TBDurata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filme_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (of.ShowDialog() == DialogResult.OK)
            {
                fSecundar.ImgSRC = of.FileName;
            }
        }
    }
}
