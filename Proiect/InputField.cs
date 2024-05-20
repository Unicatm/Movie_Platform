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
    public partial class InputField : UserControl
    {
        public InputField()
        {
            InitializeComponent();
        }

        private void InputField_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Properties

        private string title;

        [Category("Custom Props")]
        public string Title
        {
            get { return title; } 
            set { 
                title = value; 
                LblInputReg.Text = value;
                string cleanName = value.Replace(" ", "");
                TxtBInputReg.Name = "TxtB" + cleanName; 
            }
        }


        [Category("Custom Props")]
        public string TxtBName
        {
            get { return TxtBInputReg.Name.ToString(); }
        }


        [Category("Custom Props")]
        public char PasswordCharType
        {
            get { return TxtBInputReg.PasswordChar; }
            set { TxtBInputReg.PasswordChar = value; }
        }

        public string InpFName { get; internal set; }


        #endregion
    }
}
