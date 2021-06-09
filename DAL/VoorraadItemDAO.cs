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
            // select id, name and amount from voorraad, use a join to get name from menuItem
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID";
            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters

            return ReadItems(ExecuteSelectQuery(query, sqlParameters)); // use method ReadItems to read and return list with items
        }

        private List<VoorraadItem> ReadItems(DataTable table)
        {
            List<VoorraadItem> items = new List<VoorraadItem>(); // make new list

            foreach (DataRow row in table.Rows) // for each row, make a new item and add to the list
            {
                VoorraadItem item = new VoorraadItem(
                    Convert.ToInt32(row["MenuItemID"]),
                    row["Naam"].ToString(),
                    Convert.ToInt32(row["Aantal"])
                );

                items.Add(item);
            }
            return items; // return the list
        }

        public List<VoorraadItem> GetAllDBDrinks()
        {
            // Query for getting all drinks from stock, use join to get name, filter on soort: Drank% || Koffie || Thee
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID " +
                "WHERE Soort LIKE 'Drank%' OR Soort = 'Koffie' OR Soort = 'Thee'";
            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters

            return ReadItems(ExecuteSelectQuery(query, sqlParameters)); // use method ReadItems to read and return list with items
        }

        public List<VoorraadItem> GetAllDBFood()
        {
            // Query for getting all foods from stock, use join to get name, filter on soort not like Drank % && <> Koffie && <> Thee
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID " +
                "WHERE Soort NOT LIKE 'Drank%' AND Soort <> 'Koffie' AND Soort <> 'Thee'";
            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters

            return ReadItems(ExecuteSelectQuery(query, sqlParameters)); // use method ReadItems to read and return list with items
        }

        public void AdjustStockDB(int stockID, int amount)
        {
            // use a update query to set amount for the given id
            string query = "Update Voorraad SET Aantal = @Aantal WHERE MenuItemID = @ID";
            SqlParameter[] sqlParameters = new SqlParameter[2]; // 2 parameters to add

            SqlParameter paraStockID = new SqlParameter("@ID", SqlDbType.Int);
            paraStockID.Value = stockID;
            sqlParameters[0] = paraStockID;

            SqlParameter paraStockAmount = new SqlParameter("@Aantal", SqlDbType.Int);
            paraStockAmount.Value = amount;
            sqlParameters[1] = paraStockAmount;

            ExecuteEditQuery(query, sqlParameters); // perform adjustment by calling the ExecuteEditQuery
        }

        public List<VoorraadItem> FilterStockDB(string input)
        {
            // query for filtering the stock, name Like % input %
            string query = "SELECT Voorraad.MenuItemID, Naam, Aantal FROM Voorraad JOIN MenuItem ON Voorraad.MenuItemID = MenuItem.MenuItemID WHERE Naam LIKE '%" + input + "%'";
            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters

            return ReadItems(ExecuteSelectQuery(query, sqlParameters)); // use method ReadItems to read and return list with items
        }

        public List<int> GetAllIDsDB()
        {
            // get all ids
            string query = "SELECT MenuItemID FROM Voorraad";
            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters

            return ReadIDs(ExecuteSelectQuery(query, sqlParameters)); // use method ReadIDs to read and return list with ids
        }

        private List<int> ReadIDs(DataTable table)
        {
            List<int> ids = new List<int>(); // make new list

            foreach (DataRow row in table.Rows) // foreach row, convert the row to an integer and add to list
            {
                ids.Add((int)row["MenuItemId"]);
            }
            return ids; // return list
        }
    }
}