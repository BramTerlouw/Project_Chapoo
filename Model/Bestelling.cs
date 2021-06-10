using System;

namespace Model_Chapoo
{
    public class Bestelling
    {
        public int BestellingID { get; set; }

        public DateTime BestellingDatum { get; set; }

        public double BestellingSubtotaal { get; set; }

        public int TafelID { get; set; }

        public int MedewerkerID { get; set; }

        public string Status { get; set; }
        public double BTW { get; set; }

        public string[] dataGrid(Bestelling bestelling)
        {
            return new string[]
            {
                TafelID.ToString(),
                BestellingID.ToString(),
                BestellingDatum.ToString("HH:mm")
            };
        }
    }
}
