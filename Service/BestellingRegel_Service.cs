using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Chapoo;
using Model_Chapoo;

namespace Service_Chapoo
{
    public class BestellingRegel_Service
    {
        BestellingRegel_DAO bestellingRegel_DAO = new BestellingRegel_DAO();

        public void Db_VoegBestellingToe(int MenuItemID, int Aantal)
        {
            bestellingRegel_DAO.Db_VoegBestellingToe(MenuItemID, Aantal);
        }

        public List<BestellingRegel> GetEetBestellingDetailsByBestellingID(int bestellingID)
        {
            return bestellingRegel_DAO.Db_EetBestellingRegelOphalenByID(bestellingID);
        }
    }
}
