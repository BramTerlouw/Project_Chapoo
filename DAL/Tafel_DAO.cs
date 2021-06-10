using Model_Chapoo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Chapoo
{
    public class Tafel_DAO : Base
    {
        //Haal alle tafels op die bezet zijn
        public List<Tafel> Db_Get_Tables_Occupied(string statusBezet)
        {
            string query = "SELECT TafelID, Aantal_Stoelen, Status FROM Tafel WHERE Status = @statusBezet";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@statusBezet", statusBezet);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        
        //Haal alle tafels op
        public List<Tafel> Db_Get_All_Tables(string status)
        {
            string query = "SELECT TafelID, Aantal_Stoelen, Status FROM Tafel WHERE Status = @status OR Status = 'bezet'";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@status", status);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Update de status van de gegeven tafel met de gegeven status
        public void Db_Update_TableStatus(int TafelID, string Status)
        {
            string query = "UPDATE Tafel SET [Status] = @Status WHERE TafelID = @TafelID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TafelID", TafelID);
            sqlParameters[1] = new SqlParameter("@Status", Status);

            ExecuteEditQuery(query, sqlParameters);
        }

        //Lees de resultaten van de query en sla op in list
        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafelLijst = new List<Tafel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    TafelID = (int)dr["TafelID"],
                    AantalStoelen = (int)dr["Aantal_Stoelen"],
                    Status = (string)dr["Status"]             
                };
                tafelLijst.Add(tafel);
            }
            return tafelLijst;
        }
    }
}
