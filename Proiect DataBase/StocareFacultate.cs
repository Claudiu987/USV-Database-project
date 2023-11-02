using LibrarieModele;
using NivelAccesDate;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfataUtilizator
{
    public class StocareFacultate
    {
        public IStocareFacultate GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Studenti))
                        {
                            return new AdministrareStudenti();
                        }
                        if (tipEntitate == typeof(Profesori))
                        {
                            return new AdministrareProfesori();
                        }
                        if (tipEntitate == typeof(Activitati))
                        {
                            return new AdministrareActivitati();
                        }
                        if (tipEntitate == typeof(Coordonare))
                        {
                            return new AdministrareCoordonare();
                        }
                        if (tipEntitate == typeof(Participare))
                        {
                            return new AdministrareParticipari();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
