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

        public List<Tafel> Get_Tables_Occupied(string statusBezet)
        {
           return tafel_DAO.Db_Get_Tables_Occupied(statusBezet);
        }

        public List<Tafel> Get_All_Tables(string status)
        {
            return tafel_DAO.Db_Get_All_Tables(status);
        }

        public void Update_TableStatus(int TafelID, string Status)
        {
            tafel_DAO.Db_Update_TableStatus(TafelID, Status);
        }
    }
}
