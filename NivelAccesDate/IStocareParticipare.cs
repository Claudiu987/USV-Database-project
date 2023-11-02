using LibrarieModele;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public interface IStocareParticipare:IStocareFacultate
    {
        List<Participare> GetParticipari();
        Participare GetParticipare(int id);
        bool AddParticipare(Participare p);
        bool UpdateParticipare(Participare p);

        bool DeleteParticipare(int id);
    }
}
