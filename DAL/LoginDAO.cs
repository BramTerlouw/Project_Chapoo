using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model_Chapoo;


namespace DAL_Chapoo
{
    public class LoginDAO : Base
    {
        public int VerifyLoginAttemptDB(int id, int wachtwoord)
        {
            // count all employees with the id and password
            string query = "SELECT COUNT(MedewerkerID) FROM Medewerker WHERE MedewerkerID = @ID AND Wachtwoord = @WW";

            // add id and password as parameters
            SqlParameter[] sqlParameters = new SqlParameter[2];

            SqlParameter paraId = new SqlParameter("@ID", SqlDbType.Int);
            paraId.Value = id;
            sqlParameters[0] = paraId;

            SqlParameter paraWW = new SqlParameter("@WW", SqlDbType.VarChar);
            paraWW.Value = wachtwoord;
            sqlParameters[1] = paraWW;

            // use ExecuteCount to return an integer
            return ExecuteCount(query, sqlParameters);
        }
    }
}
