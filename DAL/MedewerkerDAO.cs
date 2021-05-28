using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Model_Chapoo;

namespace DAL_Chapoo
{
    public class MedewerkerDAO : Base
    {
        public List<Medewerker> GetAllEmployeesDB()
        {
            string query = "SELECT MedewerkerID, MedewerkerNaam, MedewerkerGeboorteDatum, MedewerkerGeslacht, Rol, Wachtwoord FROM Medewerker";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Medewerker> ReadItems(DataTable table)
        {
            List<Medewerker> medewerkers = new List<Medewerker>();

            foreach (DataRow row in table.Rows)
            {
                Medewerker medewerker = new Medewerker(
                    Convert.ToInt32(row["MedewerkerID"]),
                    row["MedewerkerNaam"].ToString(),
                    row["MedewerkerGeboorteDatum"].ToString(),
                    row["MedewerkerGeslacht"].ToString(),
                    row["Rol"].ToString(),
                    row["Wachtwoord"].ToString()
                );
                medewerkers.Add(medewerker);
            }
            return medewerkers;
        }

        public bool CheckForUserExistence(string name)
        {
            string query = "SELECT COUNT(*) FROM Medewerker WHERE MedewerkerNaam = @Check";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter paraName = new SqlParameter("@Check", SqlDbType.VarChar);
            paraName.Value = name;
            sqlParameters[0] = paraName;

            int value = ExecuteCount(query, sqlParameters);

            // user exists return true, user doesnt exist return false
            if (value == 1)
                return true;
            else
                return false;
        }

        public void AddEmployee(string name, string date, string gender, string function, string ww)
        {
            string query = "INSERT INTO Medewerker VALUES(@Name, @Date, @Gender, @Function, @WW); ";

            SqlParameter[] sqlParameters = new SqlParameter[5];

            SqlParameter paraName = new SqlParameter("@Name", SqlDbType.VarChar);
            paraName.Value = name;
            sqlParameters[0] = paraName;

            SqlParameter paraDate = new SqlParameter("@Date", SqlDbType.Date);
            paraDate.Value = date;
            sqlParameters[1] = paraDate;

            SqlParameter paraGender = new SqlParameter("@Gender", SqlDbType.VarChar);
            paraGender.Value = gender;
            sqlParameters[2] = paraGender;

            SqlParameter paraFunction = new SqlParameter("@Function", SqlDbType.VarChar);
            paraFunction.Value = function;
            sqlParameters[3] = paraFunction;

            SqlParameter paraWW = new SqlParameter("@WW", SqlDbType.VarChar);
            paraWW.Value = ww;
            sqlParameters[4] = paraWW;

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<int> GetEmployeeIdsDB()
        {
            string query = "SELECT MedewerkerID FROM Medewerker";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadIds(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<int> ReadIds(DataTable table)
        {
            List<int> medewerkerIds = new List<int>();

            foreach (DataRow row in table.Rows)
            {
                medewerkerIds.Add((int)row["MedewerkerID"]);
            }
            return medewerkerIds;
        }


        public Medewerker GetEmployeeDB(int id)
        {
            string query = "SELECT MedewerkerID, MedewerkerNaam, MedewerkerGeboorteDatum, MedewerkerGeslacht, Rol, Wachtwoord FROM Medewerker WHERE MedewerkerID = @id";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter paraID = new SqlParameter("@id", SqlDbType.Int);
            paraID.Value = id;
            sqlParameters[0] = paraID;

            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        public Medewerker ReadEmployee(DataTable table)
        {
            DataRow row = table.Rows[0];
            int id = (int)row["MedewerkerID"];
            string naam = row["MedewerkerNaam"].ToString();
            string datum = row["MedewerkerGeboorteDatum"].ToString();
            string geslacht = row["MedewerkerGeslacht"].ToString();
            string rol = row["Rol"].ToString();
            string wachtwoord = row["Wachtwoord"].ToString();
            return new Medewerker(id, naam, datum, geslacht, rol, wachtwoord);

        }

        public List<string> GetColumnsDB()
        {
            string query = "SELECT MedewerkerID, MedewerkerNaam, MedewerkerGeboorteDatum, MedewerkerGeslacht, Rol, Wachtwoord FROM Medewerker";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadColumns(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<string> ReadColumns(DataTable table)
        {
            List<string> columns = new List<string>();
            foreach (DataColumn c in table.Columns)
            {
                if (c.ColumnName == "MedewerkerID") continue;
                columns.Add(c.ColumnName);
            }
            return columns;
        }

        public void UpdateEmployeeDB(int id, string column, string value)
        {
            string query = "Update Medewerker SET " + column + " = @Value WHERE MedewerkerID = @Id";

            SqlParameter[] sqlParameters = new SqlParameter[3];

            SqlParameter paraID = new SqlParameter("@Id", SqlDbType.Int);
            paraID.Value = id;
            sqlParameters[0] = paraID;

            SqlParameter paraColumn = new SqlParameter("@Column", SqlDbType.VarChar);
            paraColumn.Value = column;
            sqlParameters[1] = paraColumn;

            SqlParameter paraValue = new SqlParameter("@Value", SqlDbType.VarChar);
            paraValue.Value = value;
            sqlParameters[2] = paraValue;

            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveEmployeeDB(int id)
        {
            string query = "DELETE FROM Medewerker WHERE MedewerkerID = @Id";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            SqlParameter paraID = new SqlParameter("@Id", SqlDbType.Int);
            paraID.Value = id;
            sqlParameters[0] = paraID;

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
