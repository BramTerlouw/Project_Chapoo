using System;

namespace Model_Chapoo
{
    public class Bon
    {
        public int BonID { get; set; }
        public int BestellingID { get; set; }
        public int TafelID { get; set; }
        public double TotaalBedrag { get; set; }
        public double Fooi { get; set; }
        public string BetaalMethode { get; set; }
    }
}
