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
    public class BestellingRegel_DAO : Base
    {
        public void Db_VoegBestellingToe(BestellingRegel bestellingRegel)
        {
            string query = "INSERT INTO BestellingRegel (BestellingID, RegelNR, MenuItemID, Aantal, Opmerking) VALUES (@BestellingID, @Regel, @MenuItemID, @Aantal, NULL)";
            
            SqlParameter[] sqlParameters = new SqlParameter[4]; // add 5 parameters with all the values

            SqlParameter paraName = new SqlParameter("@BestellingID", SqlDbType.Int);
            paraName.Value = bestellingRegel.BestellingID;
            sqlParameters[0] = paraName;

            SqlParameter paraDate = new SqlParameter("@Regel", SqlDbType.Int);
            paraDate.Value = bestellingRegel.RegelNR;
            sqlParameters[1] = paraDate;

            SqlParameter paraGender = new SqlParameter("@MenuItemID", SqlDbType.Int);
            paraGender.Value = bestellingRegel.MenuItemID;
            sqlParameters[2] = paraGender;

            SqlParameter paraFunction = new SqlParameter("@Aantal", SqlDbType.Int);
            paraFunction.Value = bestellingRegel.Aantal;
            sqlParameters[3] = paraFunction;
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_VoegOpmerkingToe(BestellingRegel bestellingRegel)
        {
            string query = "UPDATE BestellingRegel SET Opmerking = @Opmerking WHERE BestellingID = @BestellingID AND RegelNR = @Regel; ";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Opmerking", bestellingRegel.Opmerking);
            sqlParameters[1] = new SqlParameter("@BestellingID", bestellingRegel.BestellingID);
            sqlParameters[2] = new SqlParameter("@Regel", bestellingRegel.RegelNR);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_VerwijderBestelling(BestellingRegel bestellingRegel)
        {
            string query = "DELETE FROM BestellingRegel WHERE BestellingID = @BestellingID AND RegelNR = @RegelNR";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@BestellingID", bestellingRegel.BestellingID);
            sqlParameters[1] = new SqlParameter("@RegelNR", bestellingRegel.RegelNR);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void Db_WijzigBestelling(BestellingRegel bestellingRegel)
        {
            string query = "UPDATE BestellingRegel SET Aantal = @Aantal WHERE BestellingID = @BestellingID AND RegelNR = @Regel";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Aantal", bestellingRegel.Aantal);
            sqlParameters[1] = new SqlParameter("@BestellingID", bestellingRegel.BestellingID);
            sqlParameters[2] = new SqlParameter("@Regel", bestellingRegel.RegelNR);
            ExecuteEditQuery(query, sqlParameters);
        }
        public int Db_TelRegels(BestellingRegel bestellingRegel)
        {
            string query = "SELECT COUNT (RegelNR) FROM BestellingRegel WHERE BestellingID = @BestellingID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", bestellingRegel.BestellingID);
            int RegelNR = ExecuteCount(query, sqlParameters);
            return RegelNR;
        }
        public List<BestellingRegel> Db_Get_All_bestellingen()
        {
            string query = "SELECT BestellingID, RegelNR, MenuItemID, Aantal FROM BestellingRegel ORDER BY BestellingID DESC, RegelNR ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<BestellingRegel> ReadTables(DataTable dataTable)
        {
            List<BestellingRegel> bestellingRegels = new List<BestellingRegel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                BestellingRegel bestelling = new BestellingRegel()
                {
                    BestellingID = (int)dr["BestellingID"],
                    RegelNR = (int)dr["RegelNR"],
                    MenuItemID = (int)dr["MenuItemID"],
                    Aantal = (int)dr["Aantal"]
                };
                bestellingRegels.Add(bestelling);
            }
            return bestellingRegels;
        }
    }
    
}
