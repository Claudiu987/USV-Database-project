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
    public class AdministrareCoordonare:IStocareCoordonare
    {
        private const int First_Table = 0;
        private const int First_Line = 0;
        public List<Coordonare> GetCoordonari()
        {
            var result = new List<Coordonare>();
            var dsCoordonari = SQLDbHelper.ExecuteDataSet("SELECT * FROM coordonare_DAC", CommandType.Text);
            foreach (DataRow linieBD in dsCoordonari.Tables[First_Table].Rows)
            {
                result.Add(new Coordonare(linieBD));
            }
            return result;
        }

        public Coordonare GetCoordonare(int idCoordonare)
        {
            Coordonare result = null;
            var dsCoordonari = SQLDbHelper.ExecuteDataSet("SELECT * FROM coordonare_DAC WHERE IdCoordonare = :IdCoordonare", CommandType.Text,
                new OracleParameter(":IdCoordonare", OracleDbType.Int32, idCoordonare, ParameterDirection.Input));
            if (dsCoordonari.Tables[First_Table].Rows.Count > 0)
            {
                DataRow linieBD = dsCoordonari.Tables[First_Table].Rows[First_Line];
                result = new Coordonare(linieBD);
            }
            return result;
        }

        public bool AddCoordonare(Coordonare coordonare)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "INSERT INTO coordonare_DAC VALUES (seq_coordonare_DAC.nextval,:IdProfesor, :IdActivitate)",
                CommandType.Text,
                new OracleParameter(":IdProfesor", OracleDbType.Int32, coordonare.IdProfesor, ParameterDirection.Input),
                new OracleParameter(":IdActivitate", OracleDbType.Int32, coordonare.IdActivitate, ParameterDirection.Input));
        }

        public bool UpdateCoordonare(Coordonare coordonare)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "UPDATE coordonare_DAC SET IdProfesor = :IdProfesor, IdActivitate = :IdActivitate WHERE IdCoordonare = :IdCoordonare",
                CommandType.Text,
                new OracleParameter(":IdProfesor", OracleDbType.Int32, coordonare.IdProfesor, ParameterDirection.Input),
                new OracleParameter(":IdActivitate", OracleDbType.Int32, coordonare.IdActivitate, ParameterDirection.Input),
                new OracleParameter(":IdCoordonare", OracleDbType.Int32, coordonare.IdCoordonare, ParameterDirection.Input));
        }

        public bool DeleteCoordonare(int idCoordonare)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "DELETE FROM coordonare_DAC WHERE IdCoordonare = :IdCoordonare",
                CommandType.Text,
                new OracleParameter(":IdCoordonare", OracleDbType.Int32, idCoordonare, ParameterDirection.Input));
        }

    }

}
