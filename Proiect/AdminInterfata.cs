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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace Proiect
{
    public partial class AdminInterfata : Form
    {
        string connName = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=filme_db;Integrated Security=True;";

        DataSet dsFilme = new DataSet();

        private List<Film> listaFilme;

        public AdminInterfata()
        {
            InitializeComponent();
            IncarcaDate();
        }

        public void IncarcaDate()
        {
/*            
            using (SqlConnection conn = new SqlConnection(connName))
            {
            conn.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from filme_tbl", conn);
            adaptor.Fill(dsFilme, "Filme");
            dsFilme.Tables["Filme"].PrimaryKey = new DataColumn[1] { dsFilme.Tables["Filme"].Columns["id_film"] };

*//*            TBId.DataBindings.Add("Text", dsFilme.Tables["Filme"], "id_film");
            TbTitle.DataBindings.Add("Text", dsFilme.Tables["Filme"], "titlu");
            TBDescr.DataBindings.Add("Text", dsFilme.Tables["Filme"], "descriere");
            TBStoc.DataBindings.Add("Text", dsFilme.Tables["Filme"], "stoc");*//*
            }*/
        }

        public void populareGrid()
        {
/*            SqlConnection con = new SqlConnection(connName);
            con.Open();
            string query = "select * from filme_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder cmdBuiler = new SqlCommandBuilder(da);
            da.Fill(dsFilme, "Filme");
            DGFilme.DataSource = dsFilme.Tables[0];
            con.Close();*/
        }
        private void AdminInterfata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filme_dbDataSet.filme_tbl' table. You can move, or remove it, as needed.
            //this.filme_tblTableAdapter.Fill(this.filme_dbDataSet.filme_tbl);
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Film f = null;
            FilmForm fform = new FilmForm(f, LVFilme);

            if (fform.ShowDialog() == DialogResult.OK)
            {

                // filmul de aici va fi egal cu cel din formularul de adaugare si va prelua datele de acolo
                f = fform.fSecundar;
                ListViewItem lvi = new ListViewItem(new string[] { f.IdFilm.ToString(), f.Titlu, f.Descriere, f.Bucati.ToString(), f.AnLansare.ToString(),f.Gen, f.Durata.ToString() });
                lvi.Tag = f;
                LVFilme.Items.Add(lvi);
                //listaFilme.Add(f);
            }
        }

        private void DGFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CMenuOperations_Opening(object sender, CancelEventArgs e)
        {
            if(LVFilme.SelectedItems.Count > 0)
            {
                adaugareToolStripMenuItem.Enabled = false;
                editeazaToolStripMenuItem.Enabled = true;
                stergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                adaugareToolStripMenuItem.Enabled = true;
                editeazaToolStripMenuItem.Enabled = false;
                stergeToolStripMenuItem.Enabled = false;
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVFilme.SelectedItems.Count > 0)
            {
                Film f = LVFilme.SelectedItems[0].Tag as Film;

                FilmForm form = new FilmForm(f, LVFilme);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = LVFilme.SelectedItems[0] as ListViewItem;
                    lvi.SubItems[0].Text = f.IdFilm.ToString();
                    lvi.SubItems[1].Text = f.Titlu;
                    lvi.SubItems[2].Text = f.Descriere;
                    lvi.SubItems[3].Text = f.Bucati.ToString();
                    lvi.SubItems[4].Text = f.AnLansare.ToString();
                    lvi.SubItems[5].Text = f.Gen;
                    lvi.SubItems[6].Text = f.Durata.ToString();
                }
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareToolStripMenuItem_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LVFilme.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?","Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LVFilme.SelectedItems[0].Remove();
                }
            }
        }

        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "filme (*bin)|*.bin";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Film> listFilm = new List<Film>();
                foreach(ListViewItem lvi in LVFilme.Items)
                {
                    listFilm.Add((Film)lvi.Tag);

                }
                try
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    Stream fis = File.Create(fd.FileName);

                    ser.Serialize(fis, listFilm);
                    fis.Close();
                    MessageBox.Show("Lista de filme a fost serializata sub format binar!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void binarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "filme (*bin)|*.bin";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Film> listFilm = new List<Film>();

                Stream fis = File.OpenRead(fd.FileName);
                BinaryFormatter ser = new BinaryFormatter();

                listFilm.AddRange((List<Film>)ser.Deserialize(fis));

                if (LVFilme.Items.Count > 0)
                {
                    if (MessageBox.Show("Sunt medici in lista. Doriti sa sterg lista existenta?",
                        "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        LVFilme.Items.Clear();
                }

                foreach (Film f in listFilm)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { f.IdFilm.ToString(), f.Titlu, f.Descriere, f.Bucati.ToString(), f.AnLansare.ToString() });
                    lvi.Tag = f;
                    LVFilme.Items.Add(lvi);
                }
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "filme xml|*.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Film> listFilm = new List<Film>();
                foreach (ListViewItem lvi in LVFilme.Items)
                {
                    listFilm.Add((Film)lvi.Tag);

                }
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Film>));
                    Stream fis = File.Create(fd.FileName);

                    ser.Serialize(fis, listFilm);
                    fis.Close();
                    MessageBox.Show("Lista de filme a fost serializata sub format XML!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "filme xml|*.xml";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Film> listFilm = new List<Film>();

                Stream fis = File.OpenRead(fd.FileName);
                XmlSerializer ser = new XmlSerializer(typeof(List<Film>));

                listFilm.AddRange((List<Film>)ser.Deserialize(fis));

                if (LVFilme.Items.Count > 0)
                {
                    if (MessageBox.Show("Sunt medici in lista. Doriti sa sterg lista existenta?",
                        "Intrebare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        LVFilme.Items.Clear();
                }

                foreach (Film f in listFilm)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { f.IdFilm.ToString(), f.Titlu, f.Descriere, f.Bucati.ToString(), f.AnLansare.ToString() });
                    lvi.Tag = f;
                    LVFilme.Items.Add(lvi);
                }
            }
        }
    }
}
