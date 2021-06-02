using DAL_Chapoo;
using Model_Chapoo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Service_Chapoo
{
    public class Tafel_Service
    {
        Tafel_DAO tafel_DAO = new Tafel_DAO();

        public List<Tafel> Get_Tables(string statusBezet)
        {
           return tafel_DAO.Db_Get_Tables(statusBezet);
        }
    }
}
