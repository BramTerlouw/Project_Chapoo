using System;
using DAL_Chapoo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Chapoo
{
    public class Opmerking_Service
    {
        Opmerking_DAO opmerking_DAO = new Opmerking_DAO();

        //Voeg een opmerking toe via de DAL aan de DB
        public void Insert_Opmerking(int TafelID, string Opmerking, DateTime opmerkingDatumTijd, int medewerkerID)
        {
            opmerking_DAO.Db_Insert_Opmerking(TafelID, Opmerking, opmerkingDatumTijd, medewerkerID);
        }
    }
}
