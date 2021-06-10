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
        Bon_Service bonService;

        private Medewerker _medewerker;
        private Afrekenen_Main _main;

        public Afrekenen_PerTafel(Afrekenen_Main main, Medewerker medewerker, int TafelID)
        {
            InitializeComponent();

            this._medewerker = medewerker;
            this._main = main;

            this.TafelID = TafelID;
            bestellingService = new Bestelling_Service();
            bonService = new Bon_Service();
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
            else
            {
                MessageBox.Show("Selecteer een bestelling alstublieft!", "Fout bij afrekenen", MessageBoxButtons.OK);
            }
        }

        private void btn_MaakBon_Click(object sender, EventArgs e)
        {
            if (lst_BestellingPerTafel.SelectedItems.Count == 1 && cmbx_BetaalMethode.Text != "")
            {
                DialogResult msbResult = MessageBox.Show("U staat op het punt voor deze tafel een bon aan te maken. \nWeet u dit zeker?", "Afrekenen", MessageBoxButtons.YesNo);
                if (msbResult == DialogResult.Yes)
                {
                    int BestellingID = int.Parse(lst_BestellingPerTafel.SelectedItems[0].SubItems[0].Text);
                    int TafelID = int.Parse(lst_BestellingPerTafel.SelectedItems[0].Text);
                    int fooi = Convert.ToInt32(nup_FooiBedragGeven.Value);
                    float Totaalbedrag = float.Parse(lst_BestellingPerTafel.SelectedItems[0].SubItems[3].Text) + fooi;
                    string betaalmethode = cmbx_BetaalMethode.Text;

                    bonService.Insert_Bon(BestellingID, TafelID, Totaalbedrag, fooi, betaalmethode);
                }
            }
            else
            {
                MessageBox.Show("Kies een bestelling en vul de betaalmethode in alstublieft!", "Fout bij maken van bon", MessageBoxButtons.OK);
            }

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

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            _main.Show();
            this.Close();
            
        }
    }
}
