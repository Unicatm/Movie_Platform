using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{

    public enum Gen { Actiune, Fantasy, Politist };

    [Serializable]
    public class Film
    {

        private int idFilm;
        private string titlu;
        private string descriere;
        private int bucati;
        private DateTime anLansare;
        private int durata;
        private string gen;
        private string imgSRC; 

        public Film() { }

        public Film(string titlu, string descriere, DateTime anLansare)
        {
            Titlu = titlu;
            Descriere = descriere;
            AnLansare = anLansare;
        }

        public int IdFilm {  get { return idFilm; } set {  idFilm = value; } }
        public string Titlu { get {  return titlu; } set {  titlu = value; } }
        public string Descriere { get {  return descriere; } set {  descriere = value; } }
        public int Bucati { get {  return bucati; } set { bucati = value; } }
        public DateTime AnLansare { get {  return anLansare; } set {  anLansare = value; } }
        public int Durata { get { return durata; } set {  durata = value; } }   
        public string Gen { get { return gen; } set { gen = value; } }

        public string ImgSRC {  get { return imgSRC; } set {  imgSRC = value; } }
    }
}
