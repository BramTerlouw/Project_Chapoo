using DAL_Chapoo;
using Model_Chapoo;
using System;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class Bestelling_Service
    {
        private Bestelling_DAO _bestelling_DAO = new Bestelling_DAO();
        public List<Bestelling> GetOrdersPerTable(int TafelID)
        {
            return _bestelling_DAO.Db_Get_Orders_Per_Table(TafelID);
        }

        public void UpdateOrderStatusAfgerond(int BestellingID)
        {
            _bestelling_DAO.Db_Update_OrderStatus_Afgerond(BestellingID);
        }

        public Bestelling GetBestellingByID(int selectedOrderNr)
        {
            return _bestelling_DAO.Db_Get_Order_By_ID(selectedOrderNr);
        }

        public List<Bestelling> GetEetBestelling(string status)
        {
            try
            {
                return _bestelling_DAO.Db_Get_Eet_Orders(status);
            }
            catch (Exception e)
            {
                List<Bestelling> lijst = new List<Bestelling>();

                Bestelling bestelling = new Bestelling();

                bestelling.TafelID = 0;
                bestelling.BestellingID = 0;
                bestelling.BestellingDatum = DateTime.Now;


                lijst.Add(bestelling);

                return lijst;
            }
        }

        public List<Bestelling> GetDrinkBestelling(string status)
        {
            try
            {
                return _bestelling_DAO.Db_Get_Drink_Orders(status);
            }
            catch(Exception e)
            {
                List<Bestelling> lijst = new List<Bestelling>();

                Bestelling bestelling = new Bestelling();

                bestelling.TafelID = 0;
                bestelling.BestellingID = 0;
                bestelling.BestellingDatum = DateTime.Now;
                

                lijst.Add(bestelling);

                return lijst;
            }
        }

        public void GereedMelden(int _bestelling)
        {
            _bestelling_DAO.Db_Update_OrderStatus_Gereed(_bestelling);
        }
    }
}
