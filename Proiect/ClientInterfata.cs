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
    public partial class ClientInterfata : Form
    {

        private List<Film> _filme = new List<Film>();
        public ClientInterfata(List<Film> filme)
        {
            InitializeComponent();
            _filme = filme;
            PopuleazaFilme();
        }

        private void PopuleazaFilme()
        {
            FlowLayoutFilmeClient.Controls.Clear();
            foreach (Film film in _filme)
            {
                FilmCard filmControl = new FilmCard(film);
                FlowLayoutFilmeClient.Controls.Add(filmControl);
            }
        }

        private void ClientInterfata_Load(object sender, EventArgs e)
        {

        }
    }
}
