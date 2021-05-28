using System;
using Model_Chapoo;
using DAL_Chapoo;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class Bon_Service
    {
        private Bon_DAO bon_DAO = new Bon_DAO();
        public List<Bon> GetOrdersPerTable(int TafelID)
        {
            return bon_DAO.Db_Get_Orders_Per_Table(TafelID);
        }

        public void UpdateOrderStatusAfgerond(int BestellingID)
        {
            bon_DAO.Db_Update_OrderStatus_Afgerond(BestellingID);
        }
    }
}
