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
using System.Collections;

namespace Proiect
{
    public partial class AdminInterfata : Form
    {
        string connName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=filme;Integrated Security=True";

        DataSet dsFilme = new DataSet();

        private List<Film> listaFilme = new List<Film>();

        public AdminInterfata(List<Film> filme)
        {
            InitializeComponent();
            listaFilme = filme;
            filme_tblDataGridView.Columns[0].Visible = false;
            filme_tblDataGridView.Columns[6].Visible = false;
            IncarcaDate();
        }

        public void IncarcaDate()
        {

            using (SqlConnection connection = new SqlConnection(connName))
            {
                string selectQuery = "SELECT * FROM filme_tbl";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                filmetblBindingSource.DataSource = dataTable;
                filme_tblDataGridView.DataSource = filmetblBindingSource;
            }
           
        }

        private void AdminInterfata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'filmeDataSetF.filme_tbl' table. You can move, or remove it, as needed.
            this.filme_tblTableAdapter.Fill(this.filmeDataSetF.filme_tbl);

        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Film f = null;
            FilmForm fform = new FilmForm(f);
            //ClientInterfata clform = new ClientInterfata();

            if (fform.ShowDialog() == DialogResult.OK)
            {

                // filmul de aici va fi egal cu cel din formularul de adaugare si va prelua datele de acolo
                f = fform.fSecundar;
                /*ListViewItem lvi = new ListViewItem(new string[] { f.IdFilm.ToString(), f.Titlu, f.Descriere, f.Bucati.ToString(), f.AnLansare.ToString(),f.Gen, f.Durata.ToString()});
                lvi.Tag = f;
                LVFilme.Items.Add(lvi);*/
                listaFilme.Add(fform.fSecundar);

                using (SqlConnection connection = new SqlConnection(connName))
                {
                    connection.Open();

                    string query = "INSERT INTO filme_tbl (id_film, titlu, descriere, data_publi, gen, buc, durata) VALUES (@IdFilm, @Titlu, @Desc, @DataPub, @Gen, @Buc, @Durata)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdFilm", f.IdFilm);
                        command.Parameters.AddWithValue("@Titlu", f.Titlu);
                        command.Parameters.AddWithValue("@Desc", f.Descriere);
                        command.Parameters.AddWithValue("@DataPub", f.AnLansare.ToString());
                        command.Parameters.AddWithValue("@Gen", f.Gen);
                        command.Parameters.AddWithValue("@Buc", f.Bucati);
                        command.Parameters.AddWithValue("@Durata", f.Durata);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datele au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                IncarcaDate();
            }
        }

        private void DGFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CMenuOperations_Opening(object sender, CancelEventArgs e)
        {
            if( filme_tblDataGridView.SelectedRows.Count > 0)
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

            if (filme_tblDataGridView.SelectedRows.Count > 0)
            {

                int selectedRowIndex = filme_tblDataGridView.SelectedRows[0].Index;
                Film f = new Film();

                f.IdFilm = Convert.ToInt32(filme_tblDataGridView.Rows[selectedRowIndex].Cells[0].Value);
                f.Titlu = filme_tblDataGridView.Rows[selectedRowIndex].Cells[1].Value.ToString();
                f.Descriere = filme_tblDataGridView.Rows[selectedRowIndex].Cells[2].Value.ToString();
                f.AnLansare = Convert.ToDateTime(filme_tblDataGridView.Rows[selectedRowIndex].Cells[3].Value);
                f.Gen = filme_tblDataGridView.Rows[selectedRowIndex].Cells[4].Value.ToString();
                f.Bucati = Convert.ToInt32(filme_tblDataGridView.Rows[selectedRowIndex].Cells[5].Value);

                FilmForm form = new FilmForm(f);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection connection = new SqlConnection(connName))
                    {
                        connection.Open();

                        string query = "UPDATE filme_tbl SET titlu=@Titlu, descriere=@Desc, data_publi=@DataPub, gen=@Gen, buc=@Buc WHERE id_film=@IdFilm";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdFilm", f.IdFilm);
                            command.Parameters.AddWithValue("@Titlu", f.Titlu);
                            command.Parameters.AddWithValue("@Desc", f.Descriere);
                            command.Parameters.AddWithValue("@DataPub", f.AnLansare.ToString());
                            command.Parameters.AddWithValue("@Gen", f.Gen);
                            command.Parameters.AddWithValue("@Buc", f.Bucati);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Datele au fost modificate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    IncarcaDate();
                }
            }

            /*if (LVFilme.SelectedItems.Count > 0)
            {
                Film f = LVFilme.SelectedItems[0].Tag as Film;

                FilmForm form = new FilmForm(f);
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
            }*/
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugareToolStripMenuItem_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int selectedIndex = filme_tblDataGridView.SelectedRows[0].Index;
                int filmId = (int)filme_tblDataGridView.Rows[selectedIndex].Cells[0].Value;

                using (SqlConnection connection = new SqlConnection(connName))
                {
                    connection.Open();

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM filme_tbl WHERE id_film=@IdFilm", connection);
                    deleteCommand.Parameters.AddWithValue("@IdFilm", filmId);
                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Datele au fost sterse cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                IncarcaDate();
            }

/*            if (LVFilme.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?","Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LVFilme.SelectedItems[0].Remove();
                }
            }*/
        }

        private void binarToolStripMenuItem_Click(object sender, EventArgs e)   
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "filme (*bin)|*.bin";
            fd.CheckPathExists = true;

            if(fd.ShowDialog() == DialogResult.OK)
            {
                List<Film> filme = new List<Film>();

                using (SqlConnection conexiune = new SqlConnection(connName))
                {
                    conexiune.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM filme_tbl", conexiune);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Film film = new Film
                        {
                            IdFilm = (int)reader["id_film"],
                            Titlu = reader["titlu"].ToString(),
                            Descriere = reader["descriere"].ToString(),
                            Bucati = (int)reader["buc"],
                            AnLansare = (DateTime)reader["data_publi"],
                            Gen = reader["gen"].ToString()
                        };

                        filme.Add(film);
                    }
                }

/*                foreach (ListViewItem lvi in LVFilme.Items)
                {
                    filme.Add((Film)lvi.Tag);

                }*/
                try
                {
                    BinaryFormatter ser = new BinaryFormatter();
                    Stream fis = File.Create(fd.FileName);

                    ser.Serialize(fis, filme);
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

                using (SqlConnection connection = new SqlConnection(connName))
                {
                    connection.Open();
                    using (SqlConnection conexiune = new SqlConnection(connName))
                    {
                        conexiune.Open();
                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM filme_tbl", conexiune);
                        deleteCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Baza de date a fost stearsa!", "!", MessageBoxButtons.OK);

                    foreach (Film f in listFilm)
                    {
                        string query = "INSERT INTO filme_tbl (id_film, titlu, descriere, data_publi, gen, buc, durata) VALUES (@IdFilm, @Titlu, @Desc, @DataPub, @Gen, @Buc, @Durata)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdFilm", f.IdFilm);
                            command.Parameters.AddWithValue("@Titlu", f.Titlu);
                            command.Parameters.AddWithValue("@Desc", f.Descriere);
                            command.Parameters.AddWithValue("@DataPub", f.AnLansare.ToString());
                            command.Parameters.AddWithValue("@Gen", f.Gen);
                            command.Parameters.AddWithValue("@Buc", f.Bucati);
                            command.Parameters.AddWithValue("@Durata", f.Durata);
                            command.ExecuteNonQuery();
                        }

                    }
                    MessageBox.Show("Baza de date a fost restaurata!", "!", MessageBoxButtons.OK);
                    IncarcaDate();
                }
                /*if (LVFilme.Items.Count > 0)
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
                }*/
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "filme xml|*.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {

                List<Film> filme = new List<Film>();

                using (SqlConnection conexiune = new SqlConnection(connName))
                {
                    conexiune.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM filme_tbl", conexiune);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Film film = new Film
                        {
                            IdFilm = (int)reader["id_film"],
                            Titlu = reader["titlu"].ToString(),
                            Descriere = reader["descriere"].ToString(),
                            Bucati = (int)reader["buc"],
                            AnLansare = (DateTime)reader["data_publi"],
                            Gen = reader["gen"].ToString()
                        };

                        filme.Add(film);
                    }
                }

/*
                foreach (ListViewItem lvi in LVFilme.Items)
                {
                    filme.Add((Film)lvi.Tag);

                }*/
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Film>));
                    Stream fis = File.Create(fd.FileName);

                    ser.Serialize(fis, filme);
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

                using (SqlConnection connection = new SqlConnection(connName))
                {
                    connection.Open();
                    using (SqlConnection conexiune = new SqlConnection(connName))
                    {
                        conexiune.Open();
                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM filme_tbl", conexiune);
                        deleteCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Baza de date a fost stearsa!", "!",MessageBoxButtons.OK);

                    foreach (Film f in listFilm)
                    {
                        string query = "INSERT INTO filme_tbl (id_film, titlu, descriere, data_publi, gen, buc, durata) VALUES (@IdFilm, @Titlu, @Desc, @DataPub, @Gen, @Buc, @Durata)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdFilm", f.IdFilm);
                            command.Parameters.AddWithValue("@Titlu", f.Titlu);
                            command.Parameters.AddWithValue("@Desc", f.Descriere);
                            command.Parameters.AddWithValue("@DataPub", f.AnLansare.ToString());
                            command.Parameters.AddWithValue("@Gen", f.Gen);
                            command.Parameters.AddWithValue("@Buc", f.Bucati);
                            command.Parameters.AddWithValue("@Durata", f.Durata);
                            command.ExecuteNonQuery();
                        }

                    }
                    MessageBox.Show("Baza de date a fost restaurata!", "!", MessageBoxButtons.OK);
                    IncarcaDate();
                }

               

               /*     if (LVFilme.Items.Count > 0)
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
                }*/
            }
        }

        private void filme_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
/*            this.Validate();
            this.filme_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.filme_dbDS);*/

        }

        private void LnkToHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage hp = new Homepage(listaFilme);
            this.Hide();
            hp.ShowDialog();
            this.Close();
        }

        private void filme_tblDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filme_tblDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaugareToolStripMenuItem_Click(sender, e);
        }
    }
}
