using DAL_Chapoo;
using Model_Chapoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Chapoo
{
    public class Bestelling_Service
    {
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
