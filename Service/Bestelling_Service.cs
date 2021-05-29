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
        private Bestelling_DAO _DAO;

        public Bestelling_Service()
        {
            _DAO = new Bestelling_DAO();
        }

        public Bestelling GetBestellingByID(int selectedOrderNr)
        {
            throw new NotImplementedException();
        }
    }
}
