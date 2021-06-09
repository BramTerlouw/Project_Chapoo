using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_Chapoo;
using Model_Chapoo;

namespace UI
{
    public partial class Tafels_BestellingenPerTafel : Form
    {
        private Tafels_Main _tafelsMain;
        private Medewerker _medewerker;
        private Bestelling_Service bestellingService;
        private int TafelID { get; set; }
        public Tafels_BestellingenPerTafel(Tafels_Main main, Medewerker medewerker, int TafelID)
        {
            InitializeComponent();
            _tafelsMain = main;
            _medewerker = medewerker;
            this.TafelID = TafelID;
            bestellingService = new Bestelling_Service();
        }

        private void Tafels_BestellingenPerTafel_Load(object sender, EventArgs e)
        {
            FillListView_BestellingPerTafel();
            lbl_GekozenTafel.Text = $"Tafel {TafelID}";
        }

        private void FillListView_BestellingPerTafel()
        {
            List<Bestelling> bestellingPerTafel = bestellingService.GetOrdersPerTable(TafelID);

            lst_BestellingPerTafel.Items.Clear();

            foreach (var bestelling in bestellingPerTafel)
            {
                ListViewItem Bestelling = new ListViewItem(bestelling.TafelID.ToString());

                Bestelling.SubItems.Add(bestelling.BestellingID.ToString());
                Bestelling.SubItems.Add(bestelling.MedewerkerID.ToString());
                Bestelling.SubItems.Add(bestelling.Status);
                Bestelling.SubItems.Add(bestelling.BestellingDatum.ToString("dd-MM-yyyy"));
              

                lst_BestellingPerTafel.Items.Add(Bestelling);
            }
        }

        private void btnTerugTafelsMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            _tafelsMain.Show();
        }
    }
}
