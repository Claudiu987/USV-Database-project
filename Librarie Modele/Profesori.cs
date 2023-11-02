using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Profesori
    {
        public int IdProfesor { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Titlu { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public Profesori()
        { }

        public Profesori(string nume, string prenume, string titlu, string email, string telefon, int idProfesor = 1)
        {
            IdProfesor = idProfesor;
            Prenume = prenume;
            Nume = nume;
            Titlu = titlu;
            Email = email;
            Telefon = telefon;

        }

        public Profesori(DataRow linieBD)
        {
            IdProfesor = Convert.ToInt32(linieBD["idProfesor"].ToString());
            Nume = linieBD["nume"].ToString();
            Prenume = linieBD["prenume"].ToString();
            Titlu = linieBD["titlu"].ToString();
            Email = linieBD["email"].ToString();
            Telefon = linieBD["telefon"].ToString();
        }

        }
}
