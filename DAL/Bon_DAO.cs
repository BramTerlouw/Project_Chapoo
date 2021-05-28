using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Model_Chapoo;

namespace DAL_Chapoo
{
    public class Bon_DAO : Base
    {
        public List<Bon> Db_Get_Orders_Per_Table(int TafelID)
        {
            string query = "SELECT BonID, BestellingID, TafelID, Totaalbedrag, Fooi, Betaalmethode FROM Bon WHERE TafelID = @TafelID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TafelID", TafelID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_Update_OrderStatus_Afgerond(int BestellingID)
        {
            string query = "UPDATE Bestelling SET Status = 'afgerond' WHERE BestellingID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@OrderID", BestellingID);

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Bon> ReadTables(DataTable dataTable)
        {
            List<Bon> bonLijst = new List<Bon>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bon bon = new Bon()
                {
                    BonID = (int)dr["BonID"],
                    BestellingID = (int)dr["BestellingID"],
                    TafelID = (int)dr["TafelID"],
                    TotaalBedrag = (double)dr["Totaalbedrag"],
                    Fooi = (double)dr["Fooi"],
                    BetaalMethode = (string)dr["Betaalmethode"]
                };
                bonLijst.Add(bon);
            }
            return bonLijst;
        }
    }
}
