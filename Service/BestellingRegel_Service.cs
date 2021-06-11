using DAL_Chapoo;
using Model_Chapoo;
using System.Collections.Generic;

namespace Service_Chapoo
{
    public class BestellingRegel_Service
    {
        private BestellingRegel_DAO _bestellingRegel_DAO = new BestellingRegel_DAO();

        public void Db_VoegBestellingToe(BestellingRegel bestellingRegel)
        {
            _bestellingRegel_DAO.Db_VoegBestellingToe(bestellingRegel);
        }
        public void Db_OpmerkingToevoegen(BestellingRegel bestellingRegel)
        {
            _bestellingRegel_DAO.Db_VoegOpmerkingToe(bestellingRegel);
        }
        public void Db_VerwijderBestelling(BestellingRegel bestellingRegel)
        {
            _bestellingRegel_DAO.Db_VerwijderBestelling(bestellingRegel);
        }
        public void Db_WijzigBestelling(BestellingRegel bestellingRegel)
        {
            _bestellingRegel_DAO.Db_WijzigBestelling(bestellingRegel);
        }
        public int DB_TelRegels(BestellingRegel bestellingRegel)
        {
            return _bestellingRegel_DAO.Db_TelRegels(bestellingRegel);
        }
        public List<BestellingRegel> Db_GetBestellingen()
        {
            List<BestellingRegel> bestellingRegels = _bestellingRegel_DAO.Db_Get_All_bestellingen();
            return bestellingRegels;
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
