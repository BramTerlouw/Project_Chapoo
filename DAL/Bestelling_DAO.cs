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
        //Maak een bestelling aan in de DB
        public void Db_VoegBestellingToe(Bestelling bestelling)
        {
            string query = "INSERT INTO Bestelling (BestellingDatum, BestellingSubTotaal, TafelID, MedewerkerID, Status) VALUES (@BestellingDatum, @BestellingSubTotaal, @TafelID, @MedewerkerID, @Status)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@BestellingDatum", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
            sqlParameters[1] = new SqlParameter("@BestellingSubTotaal", bestelling.BestellingSubtotaal);
            sqlParameters[2] = new SqlParameter("@TafelID", bestelling.TafelID);
            sqlParameters[3] = new SqlParameter("@MedewerkerID", 1);
            sqlParameters[4] = new SqlParameter("@Status", bestelling.Status);
            ExecuteEditQuery(query, sqlParameters);
        }

        //Haal een lijst van alle bestellingen op uit de DB
        public List<Bestelling> Db_Get_All_Bestellingen()
        {
            string query = "SELECT BestellingID, BestellingDatum, BestellingSubTotaal, TafelID, MedewerkerID, Status FROM Bestelling ORDER BY BestellingID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Haal alle bestellingen uit de database van de gegeven tafel
        public List<Bestelling> Db_Get_Orders_Per_Table(int TafelID)
        {
            string query = "SELECT BestellingID, BestellingDatum, BestellingSubTotaal, TafelID, MedewerkerID, [Status], BTW FROM Bestelling WHERE TafelID = @TafelID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TafelID", TafelID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Verander de status van de bestelling met het gegeven bestellingID in 'afgerond'
        public void Db_Update_OrderStatus_Afgerond(int BestellingID)
        {
            string query = "UPDATE Bestelling SET [Status] = 'afgerond' WHERE BestellingID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderID", BestellingID);

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Bestelling> Db_Get_Eet_Orders(string status)
        {
            DateTime dag = DateTime.Today.Date;
            string query = "SELECT DISTINCT B.BestellingID, BestellingDatum, BestellingSubTotaal, TafelID, MedewerkerID, [Status] FROM Bestelling AS B JOIN BestellingRegel AS BR ON B.BestellingID = BR.BestellingID WHERE [Status] = @Status AND BestellingDatum > @dag AND BR.MenuItemID IN (SELECT MenuItemID FROM MenuItem WHERE Soort NOT LIKE '%Drank%')";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Status", status);
            sqlParameters[1] = new SqlParameter("@dag", dag);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Bestelling> Db_Get_Drink_Orders(string status)
        {
            DateTime dag = DateTime.Today.Date;
            string query = "SELECT DISTINCT B.BestellingID, BestellingDatum, BestellingSubTotaal, TafelID, MedewerkerID, [Status] FROM Bestelling AS B JOIN BestellingRegel AS BR ON B.BestellingID = BR.BestellingID WHERE [Status] = @Status AND BestellingDatum > @dag AND BR.MenuItemID IN (SELECT MenuItemID FROM MenuItem WHERE Soort LIKE '%Drank%')";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Status", status);
            sqlParameters[1] = new SqlParameter("@dag", dag);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_Update_OrderStatus_Gereed(int bestellingID)
        {
            string query = "UPDATE Bestelling SET Status = 'gereed' WHERE BestellingID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@OrderID", bestellingID);

            ExecuteEditQuery(query, sqlParameters);
        }

        public Bestelling Db_Get_Order_By_ID(int selectedOrderNr)
        {
            string query = "SELECT BestellingID, BestellingDatum, TafelID, MedewerkerID, BestellingSubTotaal, TafelID, MedewerkerID, [Status] FROM Bestelling WHERE BestellingID = @BestellingID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", selectedOrderNr);
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private Bestelling ReadTable(DataTable dataTable)
        {
            Bestelling bestelling = new Bestelling();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    bestelling.BestellingID = (int)dr["BestellingID"];
                    bestelling.BestellingDatum = (DateTime)dr["BestellingDatum"];
                    bestelling.BestellingSubtotaal = (double)dr["BestellingSubTotaal"];
                    bestelling.TafelID = (int)dr["TafelID"];
                    bestelling.MedewerkerID = (int)dr["MedewerkerID"];
                    bestelling.Status = (string)dr["Status"];
                };
            }
            return bestelling;
        }

        private List<Bestelling> ReadTables(DataTable dataTable)
        {
            List<Bestelling> bestellingLijst = new List<Bestelling>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bestelling bestelling = new Bestelling()
                {
                    BestellingID = (int)dr["BestellingID"],
                    BestellingDatum = (DateTime)dr["BestellingDatum"],
                    BestellingSubtotaal = (double)dr["BestellingSubTotaal"],
                    TafelID = (int)dr["TafelID"],
                    MedewerkerID = (int)dr["MedewerkerID"],
                    Status = (string)dr["Status"]
                }; 
                bestellingLijst.Add(bestelling);
            }
            return bestellingLijst;
        }
    }
}
