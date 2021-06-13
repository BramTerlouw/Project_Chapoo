using Model_Chapoo;
using Service_Chapoo;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class Afrekenen_PerTafel : Form
    {
        //fields
        private int TafelID { get; set; }
        private DateTime DatumVandaag { get; set; }
        Bestelling_Service bestellingService;
        Bon_Service bonService;
        Opmerking_Service opmerkingService;

        private Medewerker _medewerker;
        private Afrekenen_Main _main;

        //constructor
        public Afrekenen_PerTafel(Afrekenen_Main main, Medewerker medewerker, int TafelID)
        {
            InitializeComponent();

            this._medewerker = medewerker;
            this._main = main;

            this.TafelID = TafelID;
            bestellingService = new Bestelling_Service();
            bonService = new Bon_Service();
            opmerkingService = new Opmerking_Service();
        }

        //Vul de listview als de Form geladen word en vul de Text van de 'Gekozen Tafel' lbl met het TafelID
        private void Afrekenen_PerTafel_Load(object sender, EventArgs e)
        {
            lbl_GekozenTafel.Text = $"Tafel {TafelID}";
            FillListView_BestellingPerTafel();
        }

        //Verander de status van de geselecteerde bestelling in 'afgerond' als op de knop word geklikt en een bevestiging word gegegeven
        private void btn_AfrekenenConfirm_Click(object sender, EventArgs e)
        {
            if (lst_BestellingPerTafel.SelectedItems.Count == 1)
            {
                DialogResult msbResult = MessageBox.Show("U staat op het punt voor deze tafel af te rekenen. \nWeet u dit zeker?", "Afrekenen", MessageBoxButtons.YesNo);
                if (msbResult == DialogResult.Yes)
                {
                    int BestellingID = int.Parse(lst_BestellingPerTafel.SelectedItems[0].SubItems[1].Text);

                    bestellingService.UpdateOrderStatusAfgerond(BestellingID);
                  
                }
            }
            else
            {
                MessageBox.Show("Selecteer een bestelling alstublieft!", "Fout bij afrekenen", MessageBoxButtons.OK);
            }
        }

        //Maak een bon van de geselecteerde bestelling als op de knop word geklikt en een bevestiging word gegegeven

        private void btn_MaakBon_Click(object sender, EventArgs e)
        {
            if (lst_BestellingPerTafel.SelectedItems.Count == 1 && cmbx_BetaalMethode.Text != "")
            {
                DialogResult msbResult = MessageBox.Show("U staat op het punt voor deze tafel een bon aan te maken. \nWeet u dit zeker?", "Bon maken", MessageBoxButtons.YesNo);
                if (msbResult == DialogResult.Yes)
                {
                    int BestellingID = int.Parse(lst_BestellingPerTafel.SelectedItems[0].SubItems[1].Text);
                    int TafelID = int.Parse(lst_BestellingPerTafel.SelectedItems[0].Text);
                    float fooi = Convert.ToSingle(nup_FooiBedragGeven.Value);
                    string bedrag = lst_BestellingPerTafel.SelectedItems[0].SubItems[4].Text;
                    double BTW = double.Parse(lst_BestellingPerTafel.SelectedItems[0].SubItems[5].Text);
                    double SubTotaalbedrag = double.Parse(bedrag);
                    double Totaalbedrag = SubTotaalbedrag + fooi + BTW;
                    string betaalmethode = cmbx_BetaalMethode.Text;

                    string opmerking = rtb_OpmerkingPlaatsen.Text;
                    DateTime OpmerkingDatumTijd = DateTime.Now;
                    int medewerkerID = int.Parse(lst_BestellingPerTafel.SelectedItems[0].SubItems[2].Text);

                    bonService.Insert_Bon(BestellingID, TafelID, Totaalbedrag, fooi, betaalmethode);

                    if (opmerking != "")
                    {
                        opmerkingService.Insert_Opmerking(TafelID, opmerking, OpmerkingDatumTijd, medewerkerID);
                    }

                    MessageBox.Show("Bon toegevoegd!", "Bon toevoegen", MessageBoxButtons.OK);

                    _main.Show();
                    this.Close();


                }
            }
            else
            {
                MessageBox.Show("Kies een bestelling en vul de betaalmethode in alstublieft!", "Fout bij maken van bon", MessageBoxButtons.OK);
            }

        }

        //Vul de listview
        private void FillListView_BestellingPerTafel()
        {
            DatumVandaag = DateTime.Today.Date;          
            List<Bestelling> bestellingPerTafel = bestellingService.GetOrdersPerTable(TafelID, DatumVandaag);

            lst_BestellingPerTafel.Items.Clear();

            foreach (var bestelling in bestellingPerTafel)
            {
                ListViewItem Bestelling = new ListViewItem(bestelling.TafelID.ToString());

                Bestelling.SubItems.Add(bestelling.BestellingID.ToString());
                Bestelling.SubItems.Add(bestelling.MedewerkerID.ToString());
                Bestelling.SubItems.Add(bestelling.Status);
                Bestelling.SubItems.Add(bestelling.BestellingSubtotaal.ToString("0.00"));
                Bestelling.SubItems.Add(bestelling.BTW.ToString("0.00"));

                lst_BestellingPerTafel.Items.Add(Bestelling);
            }
        }

        //Clear de RichTextBox voor de opmerking en ga terug naar Form 'Afrekenen_Main' als op de knop word geklikt en een bevestiging word gegeven
        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            DialogResult msbResult = MessageBox.Show("U staat op het punt het afrekenen te annuleren. \nWeet u dit zeker?", "Afrekenen annuleren", MessageBoxButtons.YesNo);
            if (msbResult == DialogResult.Yes)
            {
                _main.Show();
                rtb_OpmerkingPlaatsen.Clear();
                this.Close();
            }
            
            
        }
    }
}
