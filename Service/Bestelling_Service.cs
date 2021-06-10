using System;
using Model_Chapoo;
using DAL_Chapoo;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class Bestelling_Service
    {
        private Bestelling_DAO bestelling_DAO = new Bestelling_DAO();

        //Haal een lijst op met alle bestellingen van de gegeven tafel
        public List<Bestelling> GetOrdersPerTable(int TafelID)
        {
            return bestelling_DAO.Db_Get_Orders_Per_Table(TafelID);
        }

        //Zet de status van de bestelling met het gegeven bestellingID op 'afgerond'

        public void UpdateOrderStatusAfgerond(int BestellingID)
        {
            bestelling_DAO.Db_Update_OrderStatus_Afgerond(BestellingID);
        }

        public Bestelling GetBestellingByID(int selectedOrderNr)
        {
            throw new NotImplementedException();
        }
    }
}
