using LibrarieModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareActivitati:IStocareFacultate
    {
        List<Activitati> GetActivitati();
        Activitati GetActivitate(int id);
        bool AddActivitate(Activitati a);
        bool UpdateActivitate(Activitati a);

        bool DeleteActivitate(int id);
    }
}
