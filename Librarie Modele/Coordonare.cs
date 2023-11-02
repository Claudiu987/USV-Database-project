using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Coordonare
    {
        public int IdCoordonare { get; set; }
        public int IdProfesor { get; set; }
        public int IdActivitate { get; set; }

        public virtual Profesori Profesori { get; set; }
        public virtual Activitati Activitati { get; set; }

        public Coordonare ()
        {

        }
        public Coordonare(int idProfesor, int idActivitate, int idCoodonare = 1)
        {
            IdCoordonare = idCoodonare;
            IdProfesor = idProfesor;
            IdActivitate = idActivitate;
        }
        public Coordonare(DataRow linieBD)
        {
            IdCoordonare = Convert.ToInt32(linieBD["idCoordonare"].ToString());
            IdActivitate = Convert.ToInt32(linieBD["idActivitate"].ToString());
            IdProfesor = Convert.ToInt32(linieBD["idProfesor"].ToString());
        }

    }
}
