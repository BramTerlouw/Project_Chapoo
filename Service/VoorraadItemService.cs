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
            _dao = new VoorraadItemDAO(); // connection to DAL layer
        }
        


        // methods
        public List<VoorraadItem> GetStock()
        {
            return _dao.GetAllDBStock(); // return whole stock
        }

        public List<VoorraadItem> GetDrinks()
        {
            return _dao.GetAllDBDrinks(); // return drinks only
        }

        public List<VoorraadItem> GetFoods()
        {
            return _dao.GetAllDBFood(); // return foods only
        }

        public void AdjustStock(int stockID, int amount)
        {
            _dao.AdjustStockDB(stockID, amount); // send id and amount to DAL layer for adjustment
        }

        public List<VoorraadItem> FilterStock(string input)
        {
            return _dao.FilterStockDB(input); // return filtered items
        }
        public void WijzigStockNaOrder(BestellingRegel bestellingRegel)
        {
            _dao.Db_WijzigVoorraadNaBestelling(bestellingRegel);
        }
        public int CheckVoorraad(BestellingRegel bestellingRegel)
        {
          return  _dao.Db_CheckVoorraad(bestellingRegel);
        }
    }
}
