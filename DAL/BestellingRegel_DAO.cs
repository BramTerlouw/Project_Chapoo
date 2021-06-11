using Model_Chapoo;
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
        public void Db_VoegBestellingToe(BestellingRegel bestellingRegel)
        {
            string query = "INSERT INTO BestellingRegel (MenuItemID, RegelNR, Aantal) VALUES ('@MenuItemID', '@Regel', '@Aantal')";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MenuItemID", bestellingRegel.MenuItemID);
            sqlParameters[1] = new SqlParameter("@Regel", ExecuteCount(query, sqlParameters));
            sqlParameters[2] = new SqlParameter("@Aantal", bestellingRegel.Aantal);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_VerwijderBestelling(BestellingRegel bestellingRegel)
        {
            string query = "DELETE BestellingID, RegelNR, MenuItemID, Aantal FROM BestellingRegel WHERE BestellingID = @BestellingID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", bestellingRegel.BestellingID);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_WijzigBestelling(BestellingRegel bestellingRegel)
        {
            string query = "UPDATE BestellingRegel SET Aantal = '@Aantal' WHERE MenuItemID = '@MenuItemID' AND RegelNR = '@Regel'";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Aantal", bestellingRegel.Aantal);
            sqlParameters[2] = new SqlParameter("@BestellingID", bestellingRegel.BestellingID);
            sqlParameters[0] = new SqlParameter("@Regel", bestellingRegel.RegelNR);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
