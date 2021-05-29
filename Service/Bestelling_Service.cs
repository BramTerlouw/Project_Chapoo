using System;
using Model_Chapoo;
using DAL_Chapoo;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class Bestelling_Service
    {
        private Bestelling_DAO bestelling_DAO = new Bestelling_DAO();
        public List<Bestelling> GetOrdersPerTable(int TafelID)
        {
            return bestelling_DAO.Db_Get_Orders_Per_Table(TafelID);
        }

        public void UpdateOrderStatusAfgerond(int BestellingID)
        {
            bestelling_DAO.Db_Update_OrderStatus_Afgerond(BestellingID);
        }
    }
}
