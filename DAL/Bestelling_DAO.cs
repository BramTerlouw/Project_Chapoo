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
    public class Bestelling_DAO : Base
    {
        public void Db_VoegBestellingToe(Bestelling bestelling)
        {
            string query = "INSERT INTO Bestelling (BestellingDatum, BestellingSubTotaal, TafelID, MedewerkerID, Status) VALUES (@BestellingDatum, @BestellingSubTotaal, @TafelID, @MedewerkerID, @Status)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@BestellingDatum", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            sqlParameters[1] = new SqlParameter("@BestellingSubTotaal", bestelling.BestellingSubTotaal);
            sqlParameters[2] = new SqlParameter("@TafelID", bestelling.TafelID);
            sqlParameters[3] = new SqlParameter("@MedewerkerID", 1);
            sqlParameters[4] = new SqlParameter("@Status", bestelling.Status);
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Bestelling> Db_Get_All_Bestellingen()
        {
            string query = "SELECT BestellingID, BestellingDatum, BestellingSubTotaal, TafelID, MedewerkerID, Status FROM Bestelling ORDER BY BestellingID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Bestelling> ReadTables(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling bestelling = new Bestelling()
                {
                    BestellingID = (int)dr["BestellingID"],
                    BestellingDatum = (DateTime)dr["BestellingDatum"],
                    BestellingSubTotaal = (double)dr["BestellingSubTotaal"],
                    TafelID = (int)dr["TafelID"],
                    MedewerkerID = (int)dr["MedewerkerID"],
                    Status = (string)dr["Status"]
                };
            bestellingen.Add(bestelling);
            }  
            return bestellingen;
        }
    }
}
