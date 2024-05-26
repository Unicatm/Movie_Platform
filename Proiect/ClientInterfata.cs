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
    public partial class ClientInterfata : Form
    {
        string connName = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=filme;Integrated Security=True";
        private List<Film> _filme = new List<Film>();
        private AdminInterfata _adminForm;
        public ClientInterfata(AdminInterfata adminForm)
        {
            InitializeComponent();
            _adminForm = adminForm;
            //_filme = filme;
            PopuleazaFilme();
        }


        private void PopuleazaFilme()
        {
            FlowLayoutFilmeClient.Controls.Clear();


            using (SqlConnection connection = new SqlConnection(connName))
            {
                connection.Open();

                string query = "SELECT * FROM filme_tbl";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read()) {
                            Film film = new Film(reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                            FilmCard filmControl = new FilmCard(film, this);
                            FlowLayoutFilmeClient.Controls.Add(filmControl);
                        }
                    }

                }
            }


/*            foreach (Film film in _filme)
            {
                FilmCard filmControl = new FilmCard(film);
                FlowLayoutFilmeClient.Controls.Add(filmControl);
            }*/
        }


        public void FilmControl_RezervareFilm(Film film)
        {
            if (film.Bucati > 0)
            {
                using (SqlConnection connection = new SqlConnection(connName))
                {
                    connection.Open();
                    string query = "UPDATE filme_tbl SET buc = buc - 1 WHERE id_film = @IdFilm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdFilm", film.IdFilm);
                        command.ExecuteNonQuery();
                    }
                }

                film.Bucati--;
                PopuleazaFilme();
                _adminForm.IncarcaDate();
            }
        }

            private void ClientInterfata_Load(object sender, EventArgs e)
        {

        }

        private void FlowLayoutFilmeClient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LnkToHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage hp = new Homepage(_filme);
            this.Hide();
            hp.ShowDialog();
            this.Close();
        }
    }
}
