﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Chapoo
{
    public class BestellingRegel
    {
        public int BestellingID { get; set; }

        public int RegelNR { get; set; }

        public int MenuItemID { get; set; }

        public int Aantal { get; set; }

        public BestellingRegel(int id, int nr, int itemid)
        {
            BestellingID = id;
            RegelNR = nr;
            MenuItemID = itemid;
        }

        public string[] dataGrid(BestellingRegel regel)
        {
            return new string[]
            {
                BestellingID.ToString(),
                RegelNR.ToString(),
                MenuItemID.ToString()
            };
        }
    }
}
