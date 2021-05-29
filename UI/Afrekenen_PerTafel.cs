using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Service_Chapoo;
using Model_Chapoo;

namespace UI
{
    public partial class Afrekenen_PerTafel : Form
    {
        private int TafelID { get; set; }
        Bestelling_Service bestellingService;
        public Afrekenen_PerTafel(int TafelID)
        {
            InitializeComponent();
            this.TafelID = TafelID;
            bestellingService = new Bestelling_Service();
        }

        private void Afrekenen_PerTafel_Load(object sender, EventArgs e)
        {
            lbl_GekozenTafel.Text = $"Tafel {TafelID}";
            FillListView_BestellingPerTafel();
        }

        private void btn_AfrekenenConfirm_Click(object sender, EventArgs e)
        {
            if (lst_BestellingPerTafel.SelectedItems.Count == 1)
            {
                DialogResult msbResult = MessageBox.Show("U staat op het punt voor deze tafel af te rekenen. \nWeet u dit zeker?", "Afrekenen", MessageBoxButtons.YesNo);
                if (msbResult == DialogResult.Yes)
                {
                    int BestellingID = int.Parse(lst_BestellingPerTafel.SelectedItems[0].SubItems[0].Text);

                    bestellingService.UpdateOrderStatusAfgerond(BestellingID);
                }
            }           
        }

        private void btn_MaakBon_Click(object sender, EventArgs e)
        {
            //Maak bon object aan en stuur naar de database
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
                Bestelling.SubItems.Add(bestelling.BestellingSubtotaal.ToString());

                lst_BestellingPerTafel.Items.Add(Bestelling);
            }
        }

        
    }
}
