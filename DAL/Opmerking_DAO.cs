using System;
using System.Data.SqlClient;

namespace DAL_Chapoo
{
    public class Opmerking_DAO : Base
    {
        //Voeg een opmerking toe aan de DB
        public void Db_Insert_Opmerking(int TafelID, string Opmerking, DateTime opmerkingDatumTijd, int medewerkerID)
        {
            string query = "INSERT INTO Opmerking (GastID, Opmerking, OpmerkingDatum, BehandeltDoor) VALUES (@TafelID, @Opmerking, @OpmerkingDatumTijd, @medewerkerID)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@TafelID", TafelID);
            sqlParameters[1] = new SqlParameter("@Opmerking", Opmerking);
            sqlParameters[2] = new SqlParameter("@OpmerkingDatumTijd", opmerkingDatumTijd);
            sqlParameters[3] = new SqlParameter("@medewerkerID", medewerkerID);           

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
