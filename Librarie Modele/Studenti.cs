using System;
using System.Data;

namespace LibrarieModele
{
    public class Studenti
    {
        public int IdStudent { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Facultate { get; set; }
        public string Specializare { get; set; }
        public int AnStudiu { get; set; }
        public string CNP { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string  Adresa { get; set; }

        public Studenti()
        { }
        public Studenti(string nume, string prenume, string facultate, string specializare, int an, string cnp, string email, string telefon ,string adresa,int idStudent = 1)
        {
            IdStudent = idStudent;
            Nume = nume;
            Prenume = prenume;
            Facultate = facultate;
            Specializare = specializare;
            AnStudiu = an;
            CNP = cnp;
            Email = email;
            Telefon = telefon;
            Adresa = adresa;


        }

        public Studenti(DataRow linieBD)
        {
            IdStudent = Convert.ToInt32(linieBD["idStudent"].ToString());
            Nume = linieBD["nume"].ToString();
            Prenume = linieBD["prenume"].ToString();
            Facultate = linieBD["facultate"].ToString();
            Specializare = linieBD["specializare"].ToString();
            AnStudiu = Convert.ToInt32(linieBD["anStudiu"].ToString());
            CNP = linieBD["cnp"].ToString();
            Email = linieBD["email"].ToString();
            Telefon = linieBD["telefon"].ToString();
            Adresa = linieBD["adresa"].ToString();
        }

    }

}