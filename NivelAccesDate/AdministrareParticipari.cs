using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;
using LibrarieModele;

namespace NivelAccesDate
{
    public class AdministrareParticipari:IStocareParticipare
    {
        private const int FirstTable = 0;
        private const int FirstLine = 0;

        public List<Participare> GetParticipari()
        {
            var result = new List<Participare>();
            var dsParticipari = SQLDbHelper.ExecuteDataSet("SELECT * FROM participari_DAC", CommandType.Text);
            foreach (DataRow linieBD in dsParticipari.Tables[FirstTable].Rows)
            {
                result.Add(new Participare(linieBD));
            }
            return result;
        }

        public Participare GetParticipare(int idParticipare)
        {
            Participare result = null;
            var dsParticipari = SQLDbHelper.ExecuteDataSet("SELECT * FROM participari_DAC WHERE IdParticipare = :IdParticipare", CommandType.Text,
                new OracleParameter(":IdParticipare", OracleDbType.Int32, idParticipare, ParameterDirection.Input));
            if (dsParticipari.Tables[FirstTable].Rows.Count > 0)
            {
                DataRow linieBD = dsParticipari.Tables[FirstTable].Rows[FirstLine];
                result = new Participare(linieBD);
            }
            return result;
        }

        public bool AddParticipare(Participare participare)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "INSERT INTO participari_DAC  VALUES (seq_participari_DAC,:IdStudent, :IdActivitate)",
                CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, participare.IdStudent, ParameterDirection.Input),
                new OracleParameter(":IdActivitate", OracleDbType.Int32, participare.IdActivitate, ParameterDirection.Input));
        }

        public bool DeleteParticipare(int idParticipare)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "DELETE FROM participari_DAC WHERE IdParticipare = :IdParticipare",
                CommandType.Text,
                new OracleParameter(":IdParticipare", OracleDbType.Int32, idParticipare, ParameterDirection.Input));
        }

        public bool UpdateParticipare(Participare participare)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "UPDATE participari_DAC SET IdStudent = :IdStudent, IdActivitate = :IdActivitate WHERE IdParticipare = :IdParticipare",
                CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, participare.IdStudent, ParameterDirection.Input),
                new OracleParameter(":IdActivitate", OracleDbType.Int32, participare.IdActivitate, ParameterDirection.Input),
                new OracleParameter(":IdParticipare", OracleDbType.Int32, participare.IdParticipare, ParameterDirection.Input));
        }

    }
}
