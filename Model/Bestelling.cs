﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Chapoo
{
    public class Bestelling
    {
        public int BestellingID { get; set; }
        public DateTime BestellingDatum { get; set; }
        public double BestellingSubTotaal { get; set; }
        public int TafelID { get; set; }
        public int MedewerkerID { get; set; }
        public string Status { get; set; }

    }
}
