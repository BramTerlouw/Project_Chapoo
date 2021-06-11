using DAL_Chapoo;
using Model_Chapoo;
using System;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class Bestelling_Service
    {
        private Bestelling_DAO _bestelling_DAO = new Bestelling_DAO();

        //Haal een lijst op met alle bestellingen van de gegeven tafel
        public List<Bestelling> GetOrdersPerTable(int TafelID)
        {
            return _bestelling_DAO.Db_Get_Orders_Per_Table(TafelID);
        }

        //Zet de status van de bestelling met het gegeven bestellingID op 'afgerond'

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
        Bestelling_DAO bestelling_DAO = new Bestelling_DAO();

        public void Db_VoegBestellingToe(Bestelling bestelling)
        {
            bestelling_DAO.Db_VoegBestellingToe(bestelling);
        }
        // Get list of bestellingen
        public List<Bestelling> GetBestellingen()
        {
            List<Bestelling> bestellingen = bestelling_DAO.Db_Get_All_Bestellingen();
            return bestellingen;
        }
       
    }
}
