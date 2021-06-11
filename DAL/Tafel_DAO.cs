using Model_Chapoo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Chapoo
{
    public class Tafel_DAO : Base
    {
        public List<Tafel> Db_Get_All_tafels()
        {
            string query = "SELECT TafelID, Aantal_Stoelen, Status FROM Tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    TafelID = (int)dr["TafelID"],
                    Aantal_Stoelen = (int)dr["Aantal_Stoelen"],
                    Status = (string)dr["Status"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
