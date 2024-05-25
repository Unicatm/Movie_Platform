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
    public partial class FilmCard : UserControl
    {
        public FilmCard()
        {
            InitializeComponent();
            LBTitlu.Text = "Ceva";
            LBDescriere.Text = "Alt ceva";
        }

        public FilmCard(Film f)
        {
            InitializeComponent();
            LBTitlu.Text = f.Titlu;
            LBDescriere.Text = f.Descriere;
            PBImage.Image = new Bitmap(f.ImgSRC);
        }

        

        private void FilmCard_Load(object sender, EventArgs e)
        {

        }

        private void PBImage_Click(object sender, EventArgs e)
        {

        }
    }
}
