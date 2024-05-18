using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    public enum GenFilm
    {
        Actiune,
        Comedie,
        Drama,
        Horror,
        SF,
        Documentar
    }
    internal class Film
    {
        private int idFilm;
        private string titlu;
        private string descriere;
        private int bucati;
        private DateTime anLansare;
        private int durata;
        private GenFilm gen;

        public int IdFilm {  get { return idFilm; } set {  idFilm = value; } }
        public string Titlu { get {  return titlu; } set {  titlu = value; } }
        public string Descriere { get {  return descriere; } set {  descriere = value; } }
        public int Bucati { get {  return bucati; } set { bucati = value; } }
        public DateTime AnLansare { get {  return anLansare; } set {  anLansare = value; } }
        public int Durata { get { return durata; } set {  durata = value; } }   
        public GenFilm Gen {  get { return gen; } set {  gen = value; } }
    }
}
