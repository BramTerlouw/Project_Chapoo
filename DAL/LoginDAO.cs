using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;


namespace DAL_Chapoo
{
    public class LoginDAO : Base
    {
        public int VerifyLoginAttemptDB(int id, int wachtwoord)
        {
            string query = "SELECT COUNT(MedewerkerID) FROM Medewerker WHERE MedewerkerID = @ID AND Wachtwoord = @WW";

            SqlParameter[] sqlParameters = new SqlParameter[2];

            SqlParameter paraId = new SqlParameter("@ID", SqlDbType.Int);
            paraId.Value = id;
            sqlParameters[0] = paraId;

            SqlParameter paraWW = new SqlParameter("@WW", SqlDbType.VarChar);
            paraWW.Value = wachtwoord;
            sqlParameters[1] = paraWW;

            return ExecuteCount(query, sqlParameters);
        }
    }
}
