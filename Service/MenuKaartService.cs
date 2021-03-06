using System;
using System.Collections.Generic;
using System.Text;
using DAL_Chapoo;
using Model_Chapoo;

namespace Service_Chapoo
{
    public class MenuKaartService
    {
        // fields
        private MenuKaartItemDAO _dao;

        // ctor
        public MenuKaartService()
        {
            _dao = new MenuKaartItemDAO();
        }


        // Get whole menu or menuItem
        public List<MenukaartItem> GetMenu()
        {
            return _dao.GetMenuDB();
        }

        public MenukaartItem GetMenuItem(int id)
        {
            return _dao.GetMenuItemDB(id);
        }




        // add or remove a menuItem
        public void RemoveMenuItem(int id)
        {
            _dao.RemoveMenuItemDB(id);
        }

        public void AddMenuItem(string soort, string naam, bool alcohol, float prijs)
        {
            _dao.AddMenuItemDB(soort, naam, alcohol, prijs);
        }




        // method overloading because value can be a string, bool or float
        public void AdjustMenuItem(int id, string column, string value)
        {
            _dao.AdjustMenuItemDB(id, column, value);
        }

        public void AdjustMenuItem(int id, string column, bool value)
        {
            _dao.AdjustMenuItemDB(id, column, value);
        }

        public void AdjustMenuItem(int id, string column, float value)
        {
            _dao.AdjustMenuItemDB(id, column, value);
        }



        // filter menu per kind
        public List<MenukaartItem> GetMenuFoods(string soort)
        {
            return _dao.GetMenuFoodDB(soort + "%");
        }
        public List<MenukaartItem> GetMenuDrinks()
        {
            return _dao.GetMenuDrinksDB();
        }




        // get all menukaart columns db
        public List<string> GetColumns()
        {
            return _dao.GetColumnsDB();
        }




        // Get all kinds of foods and drinks
        public List<String> GetAllKinds()
        {
            return _dao.GetAllKindsDB();
        }

        // Get the whole menu for the bediening
        public List<MenukaartItem> GetHardlopers()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_Hardlopers();
            return menuItems;
        }
        public List<MenukaartItem> GetKoffieThee()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_KoffieThee();
            return menuItems;
        }
        public List<MenukaartItem> GetBier()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_Bier();
            return menuItems;
        }
        public List<MenukaartItem> GetWijn()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_Wijn();
            return menuItems;
        }
        public List<MenukaartItem> GetGedeDrink()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_GedeDrank();
            return menuItems;
        }
        public List<MenukaartItem> GetFrisdrank()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_FrisDrank();
            return menuItems;
        }
        public List<MenukaartItem> GetVoorgerecht()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_Voorgerechten();
            return menuItems;
        }
        public List<MenukaartItem> GetTussengerecht()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_Tussengerechten();
            return menuItems;
        }
        public List<MenukaartItem> GetHoofdgerecht()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_Hoofdgerechten();
            return menuItems;
        }
        public List<MenukaartItem> GetNagerecht()
        {
            List<MenukaartItem> menuItems = _dao.Db_Get_All_Nagerechten();
            return menuItems;
        }
    }
}
