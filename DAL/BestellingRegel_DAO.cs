﻿using Model_Chapoo;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Chapoo
{
    public class BestellingRegel_DAO : Base
    {
        public void Db_VoegBestellingToe(int MenuItemID, int Aantal)
        {
            string query = "INSERT INTO BestellingRegel (MenuItemID, RegelNR, Aantal) VALUES ('@MenuItemID', '@Regel', '@Aantal')";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MenuItemID", MenuItemID);
            sqlParameters[2] = new SqlParameter("@Aantal", Aantal);
            sqlParameters[1] = new SqlParameter("@Regel", ExecuteCount(query, sqlParameters));
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<BestellingRegel> Db_EetBestellingRegelOphalenByID(int ID)
        {
            string query = "SELECT BestellingID, RegelNR, MenuItemID, Aantal, Opmerking FROM BestellingRegel WHERE BestellingID = @BestellingID AND MenuItemID IN (SELECT MenuItemID FROM MenuItem WHERE Soort NOT LIKE '%Drank%')";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", ID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<BestellingRegel> Db_DrankBestellingRegelOphalenByID(int ID)
        {
            string query = "SELECT BestellingID, RegelNR, MenuItemID, Aantal, Opmerking FROM BestellingRegel WHERE BestellingID = @BestellingID AND MenuItemID IN (SELECT MenuItemID FROM MenuItem WHERE Soort LIKE '%Drank%')";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", ID);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_VerwijderBestelling(int ID)
        {
            string query = "DELETE BestellingID, RegelNR, MenuItemID, Aantal FROM BestellingRegel WHERE BestellingID = @BestellingID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", ID);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<BestellingRegel> ReadTables(DataTable dataTable)
        {
            List<BestellingRegel> bestellingLijst = new List<BestellingRegel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                BestellingRegel bestelling = new BestellingRegel()
                {
                    BestellingID = (int)dr["BestellingID"],
                    RegelNR = (int)dr["RegelNR"],
                    MenuItemID = (int)dr["MenuItemID"],
                    Opmerking = (string)dr["Opmerking"],
                    Aantal = (int)dr["Aantal"]
                };
                bestellingLijst.Add(bestelling);
            }
            return bestellingLijst;
        }
    }
}
