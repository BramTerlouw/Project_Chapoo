using DAL_Chapoo;
using Model_Chapoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Chapoo
{
    public class Tafel_Service
    {
        Tafel_DAO tafel_DAO = new Tafel_DAO();

        // Get list of tables
        public List<Tafel> GetTafels()
        {
            List<Tafel> tafels = tafel_DAO.Db_Get_All_tafels();
            return tafels;
        }
    }
}
