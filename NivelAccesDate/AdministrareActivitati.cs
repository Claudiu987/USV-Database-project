using LibrarieModele;

using Oracle.DataAccess.Client;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAccesDate
{
    public class AdministrareActivitati : IStocareActivitati
    {
        private const int First_Table = 0;
        private const int First_Line = 0;
        public bool AddActivitate(Activitati a)
        {
            return SQLDbHelper.ExecuteNonQuery(
       "INSERT INTO activitati_DAC VALUES (seq_activitati_DAC.nextval ,:Denumire, :Descriere,:Data_Inceput,:Data_Sfarsit ) ",
       CommandType.Text,
       new OracleParameter(":Denumire", OracleDbType.Varchar2, a.Denumire, ParameterDirection.Input),
       new OracleParameter(":Descriere", OracleDbType.Varchar2, a.Descriere, ParameterDirection.Input),
       new OracleParameter(":Data_Inceput", OracleDbType.Date, a.Data_Inceput, ParameterDirection.Input),
       new OracleParameter(":Data_Sfarsit", OracleDbType.Date, a.Data_Sfarsit, ParameterDirection.Input)
       );
        }

        public Activitati GetActivitate(int id)
        {
            Activitati result = null;
            var dsActivitate = SQLDbHelper.ExecuteDataSet("select * from activitati_DAC where IdActivitate = :IdActvitate", CommandType.Text,
                new OracleParameter(":IdActivitate", OracleDbType.Int32, id, ParameterDirection.Input));
            if (dsActivitate.Tables[First_Table].Rows.Count > 0)
            {
                DataRow linieBD = dsActivitate.Tables[First_Table].Rows[First_Line];
                result = new Activitati(linieBD);

            }
            return result;
        }

        public List<Activitati> GetActivitati()
        {
            var result = new List<Activitati>();
            var dsActivitati = SQLDbHelper.ExecuteDataSet("select * from activitati_DAC", CommandType.Text);
            foreach (DataRow linieBD in dsActivitati.Tables[First_Table].Rows)
            {
                result.Add(new Activitati(linieBD));
            }
            return result;
        }

        public bool UpdateActivitate(Activitati a)
        {
            return SQLDbHelper.ExecuteNonQuery(
            "Update activitati_DAC set Denumire=:Denumire, Descriere=:Descriere,Data_Inceput=:Data_Inceput,Data_Sfarsit=:Data_Sfarsit  where IdActivitate=:IdActivitate",
            CommandType.Text,
            new OracleParameter(":Denumire", OracleDbType.Varchar2, a.Denumire, ParameterDirection.Input),
            new OracleParameter(":Descriere", OracleDbType.Varchar2, a.Descriere, ParameterDirection.Input),
            new OracleParameter(":Data_Inceput", OracleDbType.Date, a.Data_Inceput, ParameterDirection.Input),
            new OracleParameter(":Data_Sfarsit", OracleDbType.Date, a.Data_Sfarsit, ParameterDirection.Input)
            );

        }
        public bool DeleteActivitate(int id)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "DELETE FROM activitati_DAC WHERE IdActivitate = :IdActivitate",
                CommandType.Text,
                new OracleParameter(":IdActivitate", OracleDbType.Int32, id, ParameterDirection.Input));
            

        }

    }
}