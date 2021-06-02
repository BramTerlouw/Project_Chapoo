using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Chapoo
{
    public class BestellingRegel_DAO : Base
    {
        public void Db_VoegBestellingToe(int MenuItemID, int Aantal)
        {
            string query = "INSERT INTO BestellingRegel (MenuItemID, RegelNR, Aantal) VALUES ('@MenuItemID', '@Regel', '@Aantal')";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MenuItemID", MenuItemID);
            sqlParameters[2] = new SqlParameter("@Aantal", Aantal);
            sqlParameters[1] = new SqlParameter("@Regel", ExecuteCount(query, sqlParameters));
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_VerwijderBestelling(int ID)
        {
            string query = "DELETE BestellingID, RegelNR, MenuItemID, Aantal FROM BestellingRegel WHERE BestellingID = @BestellingID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", ID);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
