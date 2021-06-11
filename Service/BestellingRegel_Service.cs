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
    }
}
