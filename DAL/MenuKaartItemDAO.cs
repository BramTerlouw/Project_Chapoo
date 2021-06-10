using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model_Chapoo;

namespace DAL_Chapoo
{
    public class MenuKaartItemDAO : Base
    {
        // get the full menu
        public List<MenukaartItem> GetMenuDB()
        {
            // query for selecting all menuItems
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem";

            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters)); // use method ReadMenuItems to return a list with menuItems
        }

        private List<MenukaartItem> ReadMenuItems(DataTable table)
        {
            List<MenukaartItem> menu = new List<MenukaartItem>(); // make new list

            foreach (DataRow row in table.Rows)
            {
                MenukaartItem item = new MenukaartItem(
                    Convert.ToInt32(row["MenuItemID"]),
                    row["Soort"].ToString(),
                    row["Naam"].ToString(),
                    Convert.ToBoolean(row["Alcohol"]),
                    Convert.ToSingle(row["Prijs"]));
                menu.Add(item); // add item to list
            }
            return menu; // return list
        }





        // get menu food or drinks per kind
        public List<MenukaartItem> GetMenuFoodDB(string soort)
        {
            // querie for selecting foods only (lunch or diner)
            string query = "SELECT * FROM MenuItem WHERE Soort LIKE @Soort";

            SqlParameter[] sqlParameters = new SqlParameter[1]; // 1 parameter
            SqlParameter paraSoort = new SqlParameter("@Soort", SqlDbType.VarChar);
            paraSoort.Value = soort;
            sqlParameters[0] = paraSoort;

            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenukaartItem> GetMenuDrinksDB()
        {
            // querie for selecting drinks only
            string query = "SELECT * FROM MenuItem WHERE Soort NOT LIKE 'Lunch%' AND Soort NOT LIKE 'Diner%'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }





        // get a single menuitem selected by id
        public MenukaartItem GetMenuItemDB(int id)
        {
            // query for selecting a menu item by the given id
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE MenuItemID = @ID";

            SqlParameter[] sqlParameters = new SqlParameter[1]; // 1 parameter
            SqlParameter paraId = new SqlParameter("@ID", SqlDbType.VarChar);
            paraId.Value = id;
            sqlParameters[0] = paraId;

            return ReadMenuItem(ExecuteSelectQuery(query, sqlParameters)); // use method ReadMenuItem to read a menuItem
        }

        private MenukaartItem ReadMenuItem(DataTable table)
        {
            DataRow row = table.Rows[0];
            MenukaartItem item = new MenukaartItem(
                    Convert.ToInt32(row["MenuItemID"]),
                    row["Soort"].ToString(),
                    row["Naam"].ToString(),
                    Convert.ToBoolean(row["Alcohol"]),
                    Convert.ToSingle(row["Prijs"]));
            return item;
        }




        // method for removing a menu item
        public void RemoveMenuItemDB(int id)
        {
            // querie for removing a menu item, selected by the given id
            string query = "DELETE FROM MenuItem WHERE MenuItemID = @ID";

            SqlParameter[] sqlParameters = new SqlParameter[1]; // 1 parameter
            SqlParameter paraId = new SqlParameter("@ID", SqlDbType.VarChar);
            paraId.Value = id;
            sqlParameters[0] = paraId;

            ExecuteEditQuery(query, sqlParameters);
        }





        // method for adding a menu item
        public void AddMenuItemDB(string soort, string naam, bool alcohol, float prijs)
        {
            // query for adding a menu item using a insert into querie
            string query = "INSERT INTO MenuItem VALUES(@Soort, @Naam, @Alcohol, @Prijs)";

            SqlParameter[] sqlParameters = new SqlParameter[4]; // 4 parameters

            SqlParameter paraSoort = new SqlParameter("@Soort", SqlDbType.VarChar);
            paraSoort.Value = soort;
            sqlParameters[0] = paraSoort;

            SqlParameter paraNaam = new SqlParameter("@Naam", SqlDbType.VarChar);
            paraNaam.Value = naam;
            sqlParameters[1] = paraNaam;

            SqlParameter paraAlcohol = new SqlParameter("@Alcohol", SqlDbType.Bit);
            paraAlcohol.Value = alcohol;
            sqlParameters[2] = paraAlcohol;

            SqlParameter paraPrijs = new SqlParameter("@Prijs", SqlDbType.Float);
            paraPrijs.Value = prijs;
            sqlParameters[3] = paraPrijs;

            ExecuteEditQuery(query, sqlParameters);
        }





        // method overloading because the value can be a string, bool or float
        public void AdjustMenuItemDB(int id, string column, string value)
        {
            // query for adjusting a menuItem with a string value
            string query = "UPDATE MenuItem SET " + column + " = @Value WHERE MenuItemID = @ID";

            SqlParameter[] sqlParameters = new SqlParameter[2]; // 2 parameters
            SqlParameter paraId = new SqlParameter("@ID", SqlDbType.VarChar);
            paraId.Value = id;
            sqlParameters[0] = paraId;

            SqlParameter paraValue = new SqlParameter("@Value", SqlDbType.VarChar);
            paraValue.Value = value;
            sqlParameters[1] = paraValue;

            ExecuteEditQuery(query, sqlParameters);
        }

        public void AdjustMenuItemDB(int id, string column, bool value)
        {
            // query for adjusting a menuItem with a bool value
            string query = "UPDATE MenuItem SET " + column + " = @Value WHERE MenuItemID = @ID";

            SqlParameter[] sqlParameters = new SqlParameter[2]; // 2 parameters
            SqlParameter paraId = new SqlParameter("@ID", SqlDbType.VarChar);
            paraId.Value = id;
            sqlParameters[0] = paraId;

            SqlParameter paraValue = new SqlParameter("@Value", SqlDbType.Bit);
            paraValue.Value = value;
            sqlParameters[1] = paraValue;

            ExecuteEditQuery(query, sqlParameters);
        }

        public void AdjustMenuItemDB(int id, string column, float value)
        {
            // query for adjusting a menuItem with a float value
            string query = "UPDATE MenuItem SET " + column + " = @Value WHERE MenuItemID = @ID";

            SqlParameter[] sqlParameters = new SqlParameter[2]; // 2 parameters
            SqlParameter paraId = new SqlParameter("@ID", SqlDbType.VarChar);
            paraId.Value = id;
            sqlParameters[0] = paraId;

            SqlParameter paraValue = new SqlParameter("@Value", SqlDbType.Float);
            paraValue.Value = value;
            sqlParameters[1] = paraValue;

            ExecuteEditQuery(query, sqlParameters);
        }



        // Get all columns
        public List<string> GetColumnsDB()
        {
            // query for selecting all columns in de db table
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem";
            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters

            return ReadColumns(ExecuteSelectQuery(query, sqlParameters)); // use method ReadColumns to read and return a list with columns
        }

        private List<string> ReadColumns(DataTable table)
        {
            List<string> columns = new List<string>(); // make a new list
            foreach (DataColumn c in table.Columns)
            {
                if (c.ColumnName == "MenuItemID") continue;
                columns.Add(c.ColumnName); // add each columnname to the list
            }
            return columns; // return list
        }





        // Get al kinds of foods and drinks
        public List<string> GetAllKindsDB()
        {
            // query for selecting all the kinds in the menu
            string query = "SELECT DISTINCT Soort FROM MenuItem";
            SqlParameter[] sqlParameters = new SqlParameter[0]; // 0 parameters
            return ReadAllKinds(ExecuteSelectQuery(query, sqlParameters)); // use method ReadAllKinds to read and return a list with string kinds
        }
        private List<string> ReadAllKinds(DataTable table)
        {
            List<string> soorten = new List<string>(); // make a new list
            foreach (DataRow row in table.Rows)
            {
                soorten.Add(row["Soort"].ToString()); // add kinds to list
            }
            return soorten; // return list
        }

        public List<MenukaartItem> Db_Get_All_KoffieThee()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Thee' OR Soort='Koffie'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_Bier()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Drank Bier'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_Wijn()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Drank Wijn'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_GedeDrank()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Drank Gedistilleerd'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_FrisDrank()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Drank Frisdrank'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_Voorgerechten()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Lunch Voorgerecht' OR Soort='Diner Voorgerecht'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_Tussengerechten()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Diner Tussengerecht'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_Hoofdgerechten()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Diner Hoofdgerecht' OR Soort='Lunch Hoofdgerecht'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenukaartItem> Db_Get_All_Nagerechten()
        {
            string query = "SELECT MenuItemID, Soort, Naam, Alcohol, Prijs FROM MenuItem WHERE Soort='Diner Nagerecht' OR Soort='Lunch Nagerecht'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenukaartItem> ReadTables(DataTable table)
        {
            List<MenukaartItem> menu = new List<MenukaartItem>();

            foreach (DataRow row in table.Rows)
            {
                MenukaartItem item = new MenukaartItem(
                    Convert.ToInt32(row["MenuItemID"]),
                    row["Soort"].ToString(),
                    row["Naam"].ToString(),
                    Convert.ToBoolean(row["Alcohol"]),
                    Convert.ToSingle(row["Prijs"]));
                menu.Add(item);
            }
            return menu;
        }
    }
}
