using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Chapoo
{
    public class Opmerking
    {
        public int OpmerkingID { get; set; }

        public int GastID { get; set; }

        public string Bericht { get; set; }

        public DateTime BerichtDatum{ get; set; }

        public int BehandeldDoor { get; set; }

    }
}
