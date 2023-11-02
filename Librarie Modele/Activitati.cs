using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Activitati
    {
        public int IdActivitate { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public DateTime Data_Inceput { get; set; }
        public DateTime Data_Sfarsit { get; set; }
    
        public Activitati()
        { }

        public Activitati(string denumire, string descriere, DateTime dataI, DateTime dataS, int idActivitate = 1)
        {
            IdActivitate = idActivitate;
            Denumire = denumire;
            Descriere = descriere;
            Data_Inceput = dataI;
            Data_Sfarsit = dataS;
        }

        public Activitati(DataRow linieBD)
        {
            IdActivitate = Convert.ToInt32(linieBD["idActivitate"].ToString());
            Denumire = linieBD["denumire"].ToString();
            Descriere = linieBD["descriere"].ToString();
            Data_Inceput = Convert.ToDateTime(linieBD["Data_Inceput"].ToString());
            Data_Sfarsit = Convert.ToDateTime(linieBD["Data_Sfarsit"].ToString());
        }
    }

}
