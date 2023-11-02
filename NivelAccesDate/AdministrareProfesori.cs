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
    public class AdministrareProfesori : IStocareProfesori
    {
        private const int First_Table = 0;
        private const int First_Line = 0;
        public bool AddProfesor(Profesori p)
        {
            
                return SQLDbHelper.ExecuteNonQuery(
                 "INSERT INTO profesori_DAC (IdProfesor, Nume, Prenume, Titlu, Email, Telefon) " +
                    "VALUES (seq_studenti_dac.NEXTVAL, :Nume, :Prenume, :Titlu, :Email, :Telefon)",
                CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.Varchar2, p.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.Varchar2, p.Prenume, ParameterDirection.Input),
                new OracleParameter(":Titlu", OracleDbType.Varchar2, p.Titlu, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.Varchar2, p.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Varchar2, p.Telefon, ParameterDirection.Input)
                );
            
        }

        public Profesori GetProfesor(int id)
        {
            Profesori result = null;
            var dsProfesori = SQLDbHelper.ExecuteDataSet("select * from profesori_DAC where IdProfesor = :IdProfesor", CommandType.Text,
                new OracleParameter(":IdProfesor", OracleDbType.Int32, id, ParameterDirection.Input));
            if (dsProfesori.Tables[First_Table].Rows.Count > 0)
            {
                DataRow linieBD = dsProfesori.Tables[First_Table].Rows[First_Line];
                result = new Profesori(linieBD);

            }
            return result;
        }

        public List<Profesori> GetProfesori()
        {
            var result = new List<Profesori>();
            var dsProfesori = SQLDbHelper.ExecuteDataSet("select * from profesori_DAC", CommandType.Text);
            foreach (DataRow linieBD in dsProfesori.Tables[First_Table].Rows)
            {
                result.Add(new Profesori(linieBD));
            }
            return result;
        }

        public bool UpdateProfesor(Profesori p)
        {
            {
                return SQLDbHelper.ExecuteNonQuery(
                "Update profesori_DAC set Nume= :Nume, Prenume=:Prenume,Titlu=:Titlu,Email=:Email,Telefon=:Telefon where IdProfesor=:IdProfesor",
                CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.Varchar2, p.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.Varchar2, p.Prenume, ParameterDirection.Input),
                new OracleParameter(":Titlu", OracleDbType.Varchar2, p.Titlu, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.Varchar2, p.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Varchar2, p.Telefon, ParameterDirection.Input)
                );
            }
        }
        public bool DeleteProfesor(int id)
        {
           return SQLDbHelper.ExecuteNonQuery(
                "DELETE FROM profesori_DAC WHERE IdProfesor = :IdProfesor",
                CommandType.Text,
                new OracleParameter(":IdProfesor", OracleDbType.Int32, id, ParameterDirection.Input));

            
        }

    }
}
