using LibrarieModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareCoordonare:IStocareFacultate
    {
        List<Coordonare> GetCoordonari();
        Coordonare GetCoordonare(int id);
        bool AddCoordonare(Coordonare c);
        bool UpdateCoordonare(Coordonare c);

        bool DeleteCoordonare(int id);
    }
}

