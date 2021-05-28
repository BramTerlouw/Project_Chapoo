using System;
using System.Collections.Generic;
using DAL_Chapoo;
using Model_Chapoo;

namespace Service_Chapoo
{
    public class VoorraadItemService
    {
        // fields
        private VoorraadItemDAO _dao;
        
        // ctor
        public VoorraadItemService()
        {
            _dao = new VoorraadItemDAO();
        }
        


        // methods
        public List<VoorraadItem> GetStock()
        {
            return _dao.GetAllDBStock();
        }

        public List<VoorraadItem> GetDrinks()
        {
            return _dao.GetAllDBDrinks();
        }

        public List<VoorraadItem> GetFoods()
        {
            return _dao.GetAllDBFood();
        }

        public void AdjustStock(int stockID, int amount)
        {
            _dao.AdjustStockDB(stockID, amount);
        }

        public List<VoorraadItem> FilterStock(string input)
        {
            return _dao.FilterStockDB(input);
        }
    }
}
