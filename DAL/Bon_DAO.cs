using System.Data.SqlClient;

namespace DAL_Chapoo
{
    public class Bon_DAO : Base
    {
        //Voeg een bon toe aan de DB
        public void Db_Insert_Bon(int BestellingID, int TafelID, double Totaalbedrag, float Fooi, string Betaalmethode)
        {
            string query = "INSERT INTO Bon (BestellingID, TafelID, Totaalbedrag, Fooi, Betaalmethode) VALUES (@BestellingID, @TafelID, @Totaalbedrag, @Fooi, @Betaalmethode)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@BestellingID", BestellingID);
            sqlParameters[1] = new SqlParameter("@TafelID", TafelID);
            sqlParameters[2] = new SqlParameter("@Totaalbedrag", Totaalbedrag);
            sqlParameters[3] = new SqlParameter("@Fooi", Fooi);
            sqlParameters[4] = new SqlParameter("@Betaalmethode", Betaalmethode);

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
