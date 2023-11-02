using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using LibrarieModele;

using Oracle.DataAccess.Client;

namespace NivelAccesDate
{
    public class AdministrareStudenti: IStocareStudenti
    {
        private const int First_Table = 0;
        private const int First_Line = 0;

       public List<Studenti> GetStudenti()
        {
            var result = new List<Studenti>();
            var dsStudenti = SQLDbHelper.ExecuteDataSet("select * from studenti_DAC", CommandType.Text);
            foreach(DataRow linieBD in dsStudenti.Tables[First_Table].Rows)
            {
                result.Add(new Studenti(linieBD));
                }
            return result;

        }
        public Studenti GetStudent(int id) {
            Studenti result = null;
            var dsStudenti = SQLDbHelper.ExecuteDataSet("select * from studenti_DAC where IdStudent = :IdStuent", CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, id, ParameterDirection.Input));
            if (dsStudenti.Tables[First_Table].Rows.Count>0)
            { DataRow linieBD = dsStudenti.Tables[First_Table].Rows[First_Line];
                result = new Studenti(linieBD);

            }
            return result;
        }
        public bool AddStudent(Studenti stud)
        {
            return SQLDbHelper.ExecuteNonQuery(
                    "INSERT INTO studenti_DAC (IdStudent, Nume, Prenume, Facultate, Specializare, AnStudiu, CNP, Email, Telefon, Adresa) " +
                    "VALUES (seq_studenti_dac.NEXTVAL, :Nume, :Prenume, :Facultate, :Specializare, :AnStudiu, :CNP, :Email, :Telefon, :Adresa)",
                    CommandType.Text,
                    new OracleParameter(":Nume", OracleDbType.Varchar2, stud.Nume, ParameterDirection.Input),
                    new OracleParameter(":Prenume", OracleDbType.Varchar2, stud.Prenume, ParameterDirection.Input),
                    new OracleParameter(":Facultate", OracleDbType.Varchar2, stud.Facultate, ParameterDirection.Input),
                    new OracleParameter(":Specializare", OracleDbType.Varchar2, stud.Specializare, ParameterDirection.Input),
                    new OracleParameter(":AnStudiu", OracleDbType.Int32, stud.AnStudiu, ParameterDirection.Input),
                    new OracleParameter(":CNP", OracleDbType.Varchar2, stud.CNP, ParameterDirection.Input),
                    new OracleParameter(":Email", OracleDbType.Varchar2, stud.Email, ParameterDirection.Input),
                    new OracleParameter(":Telefon", OracleDbType.Varchar2, stud.Telefon, ParameterDirection.Input),
                    new OracleParameter(":Adresa", OracleDbType.Varchar2, stud.Adresa, ParameterDirection.Input)
                );

        }




        public bool UpdateStudent(Studenti stud)
        {
            return SQLDbHelper.ExecuteNonQuery(
                "UPDATE studenti_DAC SET Nume = :Nume, Prenume = :Prenume, Facultate = :Facultate, Specializare = :Specializare, AnStudiu = :AnStudiu, CNP = :CNP, Email = :Email, Telefon = :Telefon, Adresa = :Adresa WHERE IdStudent = :IdStudent",
                CommandType.Text,
                new OracleParameter(":Nume", OracleDbType.Varchar2, stud.Nume, ParameterDirection.Input),
                new OracleParameter(":Prenume", OracleDbType.Varchar2, stud.Prenume, ParameterDirection.Input),
                new OracleParameter(":Facultate", OracleDbType.Varchar2, stud.Facultate, ParameterDirection.Input),
                new OracleParameter(":Specializare", OracleDbType.Varchar2, stud.Specializare, ParameterDirection.Input),
                new OracleParameter(":AnStudiu", OracleDbType.Int32, stud.AnStudiu, ParameterDirection.Input),
                new OracleParameter(":CNP", OracleDbType.Varchar2, stud.CNP, ParameterDirection.Input),
                new OracleParameter(":Email", OracleDbType.Varchar2, stud.Email, ParameterDirection.Input),
                new OracleParameter(":Telefon", OracleDbType.Varchar2, stud.Telefon, ParameterDirection.Input),
                new OracleParameter(":Adresa", OracleDbType.Varchar2, stud.Adresa, ParameterDirection.Input),
                new OracleParameter(":IdStudent", OracleDbType.Int32, stud.IdStudent, ParameterDirection.Input)
            );
        }

        public bool DeleteStudent(int id)
        {
           return SQLDbHelper.ExecuteNonQuery(
                "DELETE FROM studenti_DAC WHERE IdStudent = :IdStudent",
                CommandType.Text,
                new OracleParameter(":IdStudent", OracleDbType.Int32, id, ParameterDirection.Input));
           

        }

    }
}