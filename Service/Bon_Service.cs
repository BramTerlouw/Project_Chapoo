using System;
using Model_Chapoo;
using DAL_Chapoo;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class Bon_Service
    {
        Bon_DAO bonDAO = new Bon_DAO();

        //Voeg een bon toe via de DAL aan de DB
        public void Insert_Bon(int BestellingID, int TafelID, double Totaalbedrag, float Fooi, string Betaalmethode)
        {
            bonDAO.Db_Insert_Bon(BestellingID, TafelID, Totaalbedrag, Fooi, Betaalmethode);
        }
    }
}
