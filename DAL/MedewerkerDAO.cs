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
            // querie for selecting all employees
            string query = "SELECT MedewerkerID, MedewerkerNaam, MedewerkerGeboorteDatum, MedewerkerGeslacht, Rol, Wachtwoord FROM Medewerker";

            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters

            return ReadItems(ExecuteSelectQuery(query, sqlParameters)); // use method ReadITems to return a list with employees
        }

        private List<Medewerker> ReadItems(DataTable table)
        {
            List<Medewerker> medewerkers = new List<Medewerker>(); // make a new list

            foreach (DataRow row in table.Rows) // for each row, make a new employee and add to list
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
            return medewerkers; // return the list
        }

        public bool CheckForUserExistence(string name)
        {
            // check user existence by counting all rows with matching name
            string query = "SELECT COUNT(MedewerkerID) FROM Medewerker WHERE MedewerkerNaam = @Check";

            SqlParameter[] sqlParameters = new SqlParameter[1]; // add parameter for name

            SqlParameter paraName = new SqlParameter("@Check", SqlDbType.VarChar);
            paraName.Value = name;
            sqlParameters[0] = paraName;

            int value = ExecuteCount(query, sqlParameters); // get the amount of matching rows

            // user exists return true, user doesnt exist return false
            if (value == 1)
                return true;
            else
                return false;
        }

        public void AddEmployee(string name, string date, string gender, string function, string ww)
        {
            // use a insert into query with all the values to add a new employee
            string query = "INSERT INTO Medewerker VALUES(@Name, @Date, @Gender, @Function, @WW); ";

            SqlParameter[] sqlParameters = new SqlParameter[5]; // add 5 parameters with all the values

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

        public Medewerker GetEmployeeDB(int id)
        {
            // query for selecting a id and filter on ID
            string query = "SELECT MedewerkerID, MedewerkerNaam, MedewerkerGeboorteDatum, MedewerkerGeslacht, Rol, Wachtwoord FROM Medewerker WHERE MedewerkerID = @id";

            SqlParameter[] sqlParameters = new SqlParameter[1]; // add 1 parameter for id

            SqlParameter paraID = new SqlParameter("@id", SqlDbType.Int);
            paraID.Value = id;
            sqlParameters[0] = paraID;

            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters)); // use method ReadEmployee for reading and returning the employee
        }

        private Medewerker ReadEmployee(DataTable table)
        {
            DataRow row = table.Rows[0]; // read first line of table and convert all values into an employee
            int id = (int)row["MedewerkerID"];
            string naam = row["MedewerkerNaam"].ToString();
            string datum = row["MedewerkerGeboorteDatum"].ToString();
            string geslacht = row["MedewerkerGeslacht"].ToString();
            string rol = row["Rol"].ToString();
            string wachtwoord = row["Wachtwoord"].ToString();
            return new Medewerker(id, naam, datum, geslacht, rol, wachtwoord); // return the employee

        }

        public List<string> GetColumnsDB()
        {
            // query for selecting all columns
            string query = "SELECT MedewerkerID, MedewerkerNaam, MedewerkerGeboorteDatum, MedewerkerGeslacht, Rol, Wachtwoord FROM Medewerker";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadColumns(ExecuteSelectQuery(query, sqlParameters)); // use method readColumns to read and add to list
        }

        private List<string> ReadColumns(DataTable table)
        {
            List<string> columns = new List<string>(); // make new list
            foreach (DataColumn c in table.Columns)
            {
                if (c.ColumnName == "MedewerkerID") continue;
                columns.Add(c.ColumnName); // foreach column, get the column name and add to list except MedewerkerID
            }
            return columns; // return list
        }

        public void UpdateEmployeeDB(int id, string column, string value)
        {
            // update query with 3 parameters for updating a specifik column
            string query = "Update Medewerker SET " + column + " = @Value WHERE MedewerkerID = @Id";

            SqlParameter[] sqlParameters = new SqlParameter[3]; // add the parameters

            SqlParameter paraID = new SqlParameter("@Id", SqlDbType.Int);
            paraID.Value = id;
            sqlParameters[0] = paraID;

            SqlParameter paraColumn = new SqlParameter("@Column", SqlDbType.VarChar);
            paraColumn.Value = column;
            sqlParameters[1] = paraColumn;

            SqlParameter paraValue = new SqlParameter("@Value", SqlDbType.VarChar);
            paraValue.Value = value;
            sqlParameters[2] = paraValue;

            ExecuteEditQuery(query, sqlParameters); // perform executeEditquery for updating the employee
        }

        public void RemoveEmployeeDB(int id)
        {
            // query for removing an employee based on a chosen id
            string query = "DELETE FROM Medewerker WHERE MedewerkerID = @Id";

            SqlParameter[] sqlParameters = new SqlParameter[1]; // add parameter for id
            SqlParameter paraID = new SqlParameter("@Id", SqlDbType.Int);
            paraID.Value = id;
            sqlParameters[0] = paraID;

            ExecuteEditQuery(query, sqlParameters); // perform executeEditquery for removing the employee
        }
    }
}
