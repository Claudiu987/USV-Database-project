using LibrarieModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareProfesori:IStocareFacultate
    {
        List<Profesori> GetProfesori();
        Profesori GetProfesor(int id);
        bool AddProfesor(Profesori p);
        bool UpdateProfesor(Profesori p);

        bool DeleteProfesor(int id);
    }
}
