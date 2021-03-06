using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Service_Chapoo;
using Model_Chapoo;

namespace UI
{
    public partial class Tafels_Main : Form
    {
        //fields
        private Medewerker _medewerker;
        private HoofdMenu _menu;
        private Bestelling_Service bestellingService;
        private Tafel_Service tafelService;
        private int TafelID { get; set; }
        public string Status { get; set; }

        //constructor
        public Tafels_Main(HoofdMenu menu, Medewerker medewerker)
        {
            InitializeComponent();
            this._medewerker = medewerker;
            this._menu = menu;
            bestellingService = new Bestelling_Service();
            tafelService = new Tafel_Service();
        }

        //Vul de listview als de Form geladen word
        private void Tafels_Main_Load(object sender, EventArgs e)
        {
            FillListViewTafel();
        }

        //Zet de status van de geselecteerde tafel op 'bezet' als er op de knop word geklikt
        private void btn_StatusBezet_Click(object sender, EventArgs e)
        {
            if (lst_KiesTafel.SelectedItems.Count == 1)
            {
                TafelID = int.Parse(lst_KiesTafel.SelectedItems[0].Text);
                Status = "bezet";
                tafelService.Update_TableStatus(TafelID, Status);

                FillListViewTafel();
            }
            else
            {
                MessageBox.Show("Selecteer eerst tafel alstublieft!", "Fout bij tafel kiezen", MessageBoxButtons.OK);
            }
            
        }

        //Zet de status van de geselecteerde tafel op 'vrij' als er op de knop word geklikt
        private void btn_StatusVrij_Click(object sender, EventArgs e)
        {
            if (lst_KiesTafel.SelectedItems.Count == 1)
            {
                TafelID = int.Parse(lst_KiesTafel.SelectedItems[0].Text);
                Status = "vrij";
                tafelService.Update_TableStatus(TafelID, Status);

                FillListViewTafel();
            }
            else
            {
                MessageBox.Show("Selecteer eerst tafel alstublieft!", "Fout bij tafel kiezen", MessageBoxButtons.OK);
            }
            
        }

        //Haal het TafelID op van de geselecteerde tafel, laad Form 'Tafels_BestellingenPerTafel' en geef het TafelID mee
        private void btn_BestellingPerTafel_Click(object sender, EventArgs e)
        {
            if (lst_KiesTafel.SelectedItems.Count == 1)
            {
                TafelID = int.Parse(lst_KiesTafel.SelectedItems[0].Text);

                ShowOrderPerTabel(TafelID);
            }
            else
            {
                MessageBox.Show("Selecteer eerst tafel alstublieft!", "Fout bij tafel kiezen", MessageBoxButtons.OK);
            }
            
        }

        //Laad Form 'Tafels_BestellingenPerTafel'
        private void ShowOrderPerTabel(int TafelID)
        {
            this.Hide();
            new Tafels_BestellingenPerTafel(this, _medewerker, TafelID).Show();
            //this.Close();       
        }

        //Ga terug naar het hoofdmenu als er op de knop word geklikt
        private void btnTerugHoofdMenu_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        //Vul de listview
        private void FillListViewTafel()
        {        
            string status = "vrij";

            List<Tafel> tafels = tafelService.Get_All_Tables(status);

            lst_KiesTafel.Items.Clear();

            foreach (var tafel in tafels)
            {
                ListViewItem Tafel = new ListViewItem(tafel.TafelID.ToString());
                Tafel.SubItems.Add(tafel.AantalStoelen.ToString());
                Tafel.SubItems.Add(tafel.Status);

                lst_KiesTafel.Items.Add(Tafel);
            }
        }


    }
}
