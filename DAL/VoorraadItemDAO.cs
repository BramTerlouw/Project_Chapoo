using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model_Chapoo;

namespace DAL_Chapoo
{
    public class VoorraadItemDAO : Base
    {
        public List<VoorraadItem> GetAllDBStock()
        {
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<VoorraadItem> ReadItems(DataTable table)
        {
            List<VoorraadItem> items = new List<VoorraadItem>();

            foreach (DataRow row in table.Rows)
            {
                VoorraadItem item = new VoorraadItem(
                    Convert.ToInt32(row["MenuItemID"]),
                    row["Naam"].ToString(),
                    Convert.ToInt32(row["Aantal"])
                );

                items.Add(item);
            }
            return items;
        }

        public List<VoorraadItem> GetAllDBDrinks()
        {
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID " +
                "WHERE Soort LIKE 'Drank%' OR Soort = 'Koffie' OR Soort = 'Thee'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<VoorraadItem> GetAllDBFood()
        {
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID " +
                "WHERE Soort NOT LIKE 'Drank%' AND Soort <> 'Koffie' AND Soort <> 'Thee'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AdjustStockDB(int stockID, int amount)
        {
            string query = "Update Voorraad SET Aantal = @Aantal WHERE MenuItemID = @ID";
            SqlParameter[] sqlParameters = new SqlParameter[2];

            SqlParameter paraStockID = new SqlParameter("@ID", SqlDbType.Int);
            paraStockID.Value = stockID;
            sqlParameters[0] = paraStockID;

            SqlParameter paraStockAmount = new SqlParameter("@Aantal", SqlDbType.Int);
            paraStockAmount.Value = amount;
            sqlParameters[1] = paraStockAmount;

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<VoorraadItem> FilterStockDB(string input)
        {
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID WHERE Naam LIKE '%" + input + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<int> GetAllIDsDB()
        {
            string query = "SELECT MenuItemID FROM Voorraad";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadIDs(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<int> ReadIDs(DataTable table)
        {
            List<int> ids = new List<int>();

            foreach (DataRow row in table.Rows)
            {
                ids.Add((int)row["MenuItemId"]);
            }
            return ids;
        }
    }
}