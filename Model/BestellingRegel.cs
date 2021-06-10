using System;
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

        public string Naam { get; set; }

        public int Aantal { get; set; }

        public string Opmerking { get; set; }

        public string[] dataGrid(BestellingRegel regel)
        {
            return new string[]
            {
                Aantal.ToString(),
                Naam,
                Opmerking
            };
        }
    }
}
