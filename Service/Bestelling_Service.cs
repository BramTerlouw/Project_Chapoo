using DAL_Chapoo;
using Model_Chapoo;
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

        public Bestelling GetBestellingByID(int selectedOrderNr)
        {
            return bestelling_DAO.Db_Get_Order_By_ID(selectedOrderNr);
        }

        public List<Bestelling> GetBestellingGereed()
        {
            return bestelling_DAO.Db_Get_Orders_Done();
        }

        public List<Bestelling> GetBestellingOpen()
        {
            return bestelling_DAO.Db_Get_Orders_Open();
        }
    }
}
