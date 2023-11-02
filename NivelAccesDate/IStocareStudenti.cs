using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareStudenti:IStocareFacultate
    {
        List<Studenti> GetStudenti();
        Studenti GetStudent(int id);
        bool AddStudent(Studenti s);
        bool UpdateStudent(Studenti s);

        bool DeleteStudent(int id);
    }
}
