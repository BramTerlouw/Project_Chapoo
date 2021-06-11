using DAL_Chapoo;
using Model_Chapoo;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class BestellingRegel_Service
    {
        BestellingRegel_DAO bestellingRegel_DAO = new BestellingRegel_DAO();

        public void Db_VoegBestellingToe(BestellingRegel bestellingRegel)
        {
            bestellingRegel_DAO.Db_VoegBestellingToe(bestellingRegel);
        }
        public void Db_VerwijderBestelling(BestellingRegel bestellingRegel)
        {
            bestellingRegel_DAO.Db_VerwijderBestelling(bestellingRegel);
        }
        public void Db_WijzigBestelling(BestellingRegel bestellingRegel)
        {
            bestellingRegel_DAO.Db_WijzigBestelling(bestellingRegel);
        }
        private BestellingRegel_DAO _bestellingRegel_DAO = new BestellingRegel_DAO();

        public void Db_VoegBestellingToe(int MenuItemID, int Aantal)
        {
            _bestellingRegel_DAO.Db_VoegBestellingToe(MenuItemID, Aantal);
        }

        public List<BestellingRegel> GetEetBestellingDetailsByBestellingID(int bestellingID)
        {
            return _bestellingRegel_DAO.Db_EetBestellingRegelOphalenByID(bestellingID);
        }

        public List<BestellingRegel> GetDrinkBestellingDetailsByBestellinID(int bestellingID)
        {
            return _bestellingRegel_DAO.Db_DrankBestellingRegelOphalenByID(bestellingID);
        }
    }
}
