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
    public partial class FilmForm : Form
    {
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
            }
            else
            {
                BtnAdauga.Text = "Modifica";
                LbHeader.Text = "Editeaza filmul";
                TBId.Text = f.IdFilm.ToString();
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
            foreach (ListViewItem lvi in lvSec.Items)
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
    }
}
