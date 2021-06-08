using System;

namespace Model_Chapoo
{
    public class Bestelling
    {
        public int BestellingID { get; set; }

        public DateTime BestellingDatum { get; set; }

        public float BestellingSubtotaal { get; set; }

        public int TafelID { get; set; }

        public int MedewerkerID { get; set; }

        public string Status { get; set; }

        public object[] dataGrid(Bestelling bestelling)
        {
            throw new NotImplementedException();
        }
    }
}
