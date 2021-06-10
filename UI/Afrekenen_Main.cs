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
    public partial class Afrekenen_Main : Form
    {
        //fields
        private Medewerker _medewerker;
        private HoofdMenu _menu;

        //constructor
        public Afrekenen_Main(HoofdMenu menu, Medewerker medewerker)
        {
            InitializeComponent();
            this._medewerker = medewerker;
            this._menu = menu;
        }

        //Vul de listview als de Form geladen word
        private void Afrekenen_Main_Load(object sender, EventArgs e)
        {         
            FillListViewTafel();
        }

        //Haal het TafelID op van de gelecteerde tafel, laad Form 'Afrekenen_PerTafel' en geef het TafelID mee als op de knop word geklikt 
        private void btn_KiesTafelConfirm_Click(object sender, EventArgs e)
        {
            if (lst_KiesTafel.SelectedItems.Count == 1)
            {
                int TafelID = int.Parse(lst_KiesTafel.SelectedItems[0].Text);

                ShowOrderPerTabel(TafelID);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een tafel alstublieft!", "Fout bij tafel kiezen", MessageBoxButtons.OK);
            }
            
        }

        //Vul de listview
        private void FillListViewTafel()
        {
            Tafel_Service tafelservice = new Tafel_Service();

            string statusBezet = "bezet";

            List<Tafel> tafels = tafelservice.Get_Tables_Occupied(statusBezet);

            lst_KiesTafel.Items.Clear();

            foreach (var tafel in tafels)
            {
                ListViewItem Tafel = new ListViewItem(tafel.TafelID.ToString());
                Tafel.SubItems.Add(tafel.AantalStoelen.ToString()) ;
                Tafel.SubItems.Add(tafel.Status);               

                lst_KiesTafel.Items.Add(Tafel);
            }
        }

        //Laad Form 'Afrekenen_PerTafel'
        private void ShowOrderPerTabel(int TafelID)
        {
            this.Hide();
            new Afrekenen_PerTafel(this, _medewerker, TafelID).Show();
            //this.Close();       
        }

        //Ga terug naar het hoofdmenu als op de knop word geklikt
        private void btnTerugHoofdMenu_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }
    }
}
