using Model_Chapoo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Chapoo
{
    public class Tafel_DAO : Base
    {
        public List<Tafel> Db_Get_Tables(string statusBezet)
        {
            string query = "SELECT TafelID, Aantal_Stoelen, Status FROM Tafel WHERE Status = @statusBezet";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@statusBezet", statusBezet);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

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
