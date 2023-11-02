using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Participare
    {
        public int IdParticipare { get; set; }
        public int IdStudent { get; set; }
        public int IdActivitate { get; set; }

        public virtual Activitati Activitati { get; set; }
        public virtual Studenti Studenti { get; set; }

        public Participare()
        { }

        public Participare(int idStudent, int idActivitate ,int idParticipare= 1)
        {
            IdParticipare = idParticipare;
            IdStudent = idStudent;
            IdActivitate = idActivitate;
          
        }

        public Participare(DataRow linieBD)
        {
            IdParticipare = Convert.ToInt32(linieBD["idParticipare"].ToString());
            IdStudent = Convert.ToInt32(linieBD["idStudent"].ToString());
            IdActivitate = Convert.ToInt32(linieBD["idActivitate"].ToString());
           
        }
    }
}
