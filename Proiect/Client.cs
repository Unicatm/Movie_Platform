using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Client:User
    {
        private string cnp;
        private string nume;
        private string telefon;
        private string email;

        public string Cnp { get { return cnp; } set { cnp = value; } }
        public string Nume { get { return nume; } set { nume = value; } }
        public string Telefon { get { return telefon; } set { telefon = value; } }
        public string Email { get { return email; } set { email = value; } }

    }
}
