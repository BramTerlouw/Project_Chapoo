using Model_Chapoo;
using Service_Chapoo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuBediening : Form
    {
        private Medewerker _medewerker;
        private HoofdMenu _menu;
        private Bestelling_Service bestelling_Service = new Bestelling_Service();
        private BestellingRegel_Service BestellingRegel_Service = new BestellingRegel_Service();
        private Model_Chapoo.Bestelling bestelling = new Bestelling();
        private Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
        private Service_Chapoo.MenuKaartService menuKaartService = new Service_Chapoo.MenuKaartService();
        private VoorraadItemService voorraadItemService = new VoorraadItemService();
        private Service_Chapoo.Tafel_Service tafel_Service = new Service_Chapoo.Tafel_Service();

        public MenuBediening(HoofdMenu menu, Medewerker medewerker)
        {
            InitializeComponent();
            this._medewerker = medewerker;
            this._menu = menu;
        }


        // Hide alle panels 
        void HidePanels()
        {
            PNL_Bier.Hide();
            PNL_Frisdrank.Hide();
            PNL_GedeDrank.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_KoffieThee.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Wijn.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_DrankenMenu.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            PNL_MenuStart.Hide();

            BTN_Terug.Hide();
            BTN_Bevestig.Hide();
        }


        // Fullrowselect method
        void FullRowSelect()
        {
            LSV_BestellingOverzicht.FullRowSelect = true;
            LSV_Bier.FullRowSelect = true;
            LSV_Frisdrank.FullRowSelect = true;
            LSV_GedeDrank.FullRowSelect = true;
            LSV_Hardlopers.FullRowSelect = true;
            LSV_Hoofdgerechten.FullRowSelect = true;
            LSV_KoffieThee.FullRowSelect = true;
            LSV_Nagerechten.FullRowSelect = true;
            LSV_Tussengerechten.FullRowSelect = true;
            LSV_Voorgerechten.FullRowSelect = true;
            LSV_Wijn.FullRowSelect = true;

            LSV_VoorgerechtenTafel.FullRowSelect = true;
            LSV_TussengerechtenTafel.FullRowSelect = true;
            LSV_HoofdgerechtTafel.FullRowSelect = true;
            LSV_NagerechtTafel.FullRowSelect = true;
            LSV_FrisdrankTafel.FullRowSelect = true;
            LSV_BierTafel.FullRowSelect = true;
            LSV_GedeTafel.FullRowSelect = true;
            LSV_HardlopersTafel.FullRowSelect = true;
            LSV_KoffieTheeTafel.FullRowSelect = true;
            LSV_WijnTafel.FullRowSelect = true; 
        }




        private void MenuBediening_Load(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();
            // Show start
            PNL_BestellingMaken.Show();

            FullRowSelect();

            // Haal lijst met tafels uit service laag
            List<Tafel> tafels = tafel_Service.GetTafels();

            // Clear the listview and fill it
            LSV_BestellingAanmaken.Items.Clear();

            foreach (Tafel T in tafels)
            {
                ListViewItem taf = new ListViewItem(T.TafelID.ToString());
                LSV_BestellingAanmaken.Items.Add(taf);
            }
        }




        // Bestelling aanmaken
        private void BTN_BestellingAanmaken_Click(object sender, EventArgs e)
        {
            if (LSV_BestellingAanmaken.SelectedItems.Count == 1)
            {
                // Hide other panels
                HidePanels();

                // Show start
                PNL_MenuStart.Show();

                // Maak bestelling aan
                bestelling.BestellingSubtotaal = 0;
                bestelling.TafelID = int.Parse(LSV_BestellingAanmaken.SelectedItems[0].Text.ToString());
                bestelling.Status = "bezig";

                // Geef door aan service laag
                bestelling_Service.Db_VoegBestellingToe(bestelling);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een tafel alstublieft!", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }




        // Hardlopers menu
        private void BTN_Hardlopers_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show menu hardlopers
            PNL_Hardlopers.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullrowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> hardlopers = menuKaartService.GetHardlopers();

            // Clear the listview
            LSV_Hardlopers.Items.Clear();

            // Fill lisview met hardlopers
            foreach (MenukaartItem m in hardlopers)
            {
                ListViewItem Hardlopers = new ListViewItem(m.Id.ToString());
                Hardlopers.Tag = m;
                Hardlopers.SubItems.Add(m.Naam);
                Hardlopers.SubItems.Add(m.Prijs.ToString());
                LSV_Hardlopers.Items.Add(Hardlopers);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_HardlopersTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_HardlopersTafel.Items.Add(best);
            }

        }



        // Gerechten overzicht
        private void BTN_Gerechten_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show menu gerechten
            PNL_GerechtenMenu.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();
        }


        // Dranken overzicht
        private void BTN_Dranken_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show menu dranken
            PNL_DrankenMenu.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();
        }


        // Voorgerechten menu
        private void BTN_Voorgerechten_Click(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show Voorgerechten
            PNL_Voorgerechten.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> Voorgerechten = menuKaartService.GetVoorgerecht();

            // Clear the listview 
            LSV_Voorgerechten.Items.Clear();

            // Fill listview met voorgerechten
            foreach (MenukaartItem m in Voorgerechten)
            {
                ListViewItem Vgerechten = new ListViewItem(m.Id.ToString());
                Vgerechten.Tag = m;
                Vgerechten.SubItems.Add(m.Naam);
                Vgerechten.SubItems.Add(m.Prijs.ToString());
                LSV_Voorgerechten.Items.Add(Vgerechten);
            }
        

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_VoorgerechtenTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_VoorgerechtenTafel.Items.Add(best);
            }
        }



        // Tussengerechten menu
        private void BTN_Tussengerechten_Click(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show tussengerechten
            PNL_Tussengerechten.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> Tussengerechten = menuKaartService.GetTussengerecht();

            // Clear the listview 
            LSV_Tussengerechten.Items.Clear();

            // Fill listview met tussengerechten
            foreach (MenukaartItem m in Tussengerechten)
            {
                ListViewItem tusgerechten = new ListViewItem(m.Id.ToString());
                tusgerechten.Tag = m;
                tusgerechten.SubItems.Add(m.Naam);
                tusgerechten.SubItems.Add(m.Prijs.ToString());
                LSV_Tussengerechten.Items.Add(tusgerechten);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_TussengerechtenTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_TussengerechtenTafel.Items.Add(best);
            }
        }


        // Hoofdgerechten menu
        private void BTN_Hoofdgerechten_Click(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show hoofdgerechten
            PNL_Hoofdgerechten.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> hoofdgerechten = menuKaartService.GetHoofdgerecht();

            // Clear the listview 
            LSV_Hoofdgerechten.Items.Clear();

            // Fill listview met hoofdgerechten
            foreach (MenukaartItem m in hoofdgerechten)
            {
                ListViewItem Hoofdgerechten = new ListViewItem(m.Id.ToString());
                Hoofdgerechten.Tag = m;
                Hoofdgerechten.SubItems.Add(m.Naam);
                Hoofdgerechten.SubItems.Add(m.Prijs.ToString());
                LSV_Hoofdgerechten.Items.Add(Hoofdgerechten);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_HoofdgerechtTafel.Items.Clear();

            // Fill listview
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_HoofdgerechtTafel.Items.Add(best);
            }
        }


        // Nagerechten menu
        private void BTN_Nagerecht_Click(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show nagerechten
            PNL_Nagerechten.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> Nagerecht = menuKaartService.GetNagerecht();

            // Clear the listview 
            LSV_Nagerechten.Items.Clear();

            // Fill listview met nagerechten
            foreach (MenukaartItem m in Nagerecht)
            {
                ListViewItem nagerecht = new ListViewItem(m.Id.ToString());
                nagerecht.Tag = m;
                nagerecht.SubItems.Add(m.Naam);
                nagerecht.SubItems.Add(m.Prijs.ToString());
                LSV_Nagerechten.Items.Add(nagerecht);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_NagerechtTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_NagerechtTafel.Items.Add(best);
            }
        }



        // Frisdrank menu
        private void BTN_Frisdrank_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show frisdrank
            PNL_Frisdrank.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> frisdrank = menuKaartService.GetFrisdrank();

            // Clear the listview 
            LSV_Frisdrank.Items.Clear();

            // Fill listview met frisdrank
            foreach (MenukaartItem m in frisdrank)
            {
                ListViewItem Frisdrank = new ListViewItem(m.Id.ToString());
                Frisdrank.Tag = m;
                Frisdrank.SubItems.Add(m.Naam);
                Frisdrank.SubItems.Add(m.Prijs.ToString());
                LSV_Frisdrank.Items.Add(Frisdrank);
            }

            // Haal lijst op uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_FrisdrankTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_FrisdrankTafel.Items.Add(best);
            }
        }


        // Warme dranken
        private void BTN_KoffieThee_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show koffie en thee
            PNL_KoffieThee.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> koffiethee = menuKaartService.GetKoffieThee();

            // Clear the listview 
            LSV_KoffieThee.Items.Clear();

            // Fill listview met warme dranken
            foreach (MenukaartItem m in koffiethee)
            {
                ListViewItem KoffieThee = new ListViewItem(m.Id.ToString());
                KoffieThee.Tag = m;
                KoffieThee.SubItems.Add(m.Naam);
                KoffieThee.SubItems.Add(m.Prijs.ToString());
                LSV_KoffieThee.Items.Add(KoffieThee);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_KoffieTheeTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_KoffieTheeTafel.Items.Add(best);
            }
        }


        // Bier menu
        private void BTN_Bier_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show bier
            PNL_Bier.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> bier = menuKaartService.GetBier();

            // Clear the listview 
            LSV_Bier.Items.Clear();

            // Fill listview met bier
            foreach (MenukaartItem m in bier)
            {
                ListViewItem Bier = new ListViewItem(m.Id.ToString());
                Bier.Tag = m;
                Bier.SubItems.Add(m.Naam);
                Bier.SubItems.Add(m.Prijs.ToString());
                LSV_Bier.Items.Add(Bier);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_BierTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_BierTafel.Items.Add(best);
            }
        }


        // Wijn menu
        private void BTN_Wijn_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show wijn
            PNL_Wijn.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // Fullrowselect
            FullRowSelect();

            // Haal lijst uit service laag
            List<MenukaartItem> wijn = menuKaartService.GetWijn();

            // Clear the listview 
            LSV_Wijn.Items.Clear();

            // Fill listview met wijn
            foreach (MenukaartItem m in wijn)
            {
                ListViewItem Wijn = new ListViewItem(m.Id.ToString());
                Wijn.Tag = m;
                Wijn.SubItems.Add(m.Naam);
                Wijn.SubItems.Add(m.Prijs.ToString());
                LSV_Wijn.Items.Add(Wijn);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_WijnTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_WijnTafel.Items.Add(best);
            }
        }


        // Gedestileerde dranken menu
        private void BTN_GedeDrank_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show Gedestileerde drank
            PNL_GedeDrank.Show();

            // Show buttons
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal list uit service laag
            List<MenukaartItem> gededrank = menuKaartService.GetGedeDrink();

            // Clear the listview 
            LSV_GedeDrank.Items.Clear();

            // Fill listview met gedestileerde drank
            foreach (MenukaartItem m in gededrank)
            {
                ListViewItem GedeDrank = new ListViewItem(m.Id.ToString());
                GedeDrank.Tag = m;
                GedeDrank.SubItems.Add(m.Naam);
                GedeDrank.SubItems.Add(m.Prijs.ToString());
                LSV_GedeDrank.Items.Add(GedeDrank);
            }

            // Haal lijst uit service laag
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview 
            LSV_GedeTafel.Items.Clear();

            // Fill listview met bestellingen
            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_GedeTafel.Items.Add(best);
            }

        }



        // Terug Knop
        private void BTN_Terug_Click(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show start
            PNL_MenuStart.Show();
            BTN_Bevestig.Show();
        }


   
        // Items toevoegen aan bestelling
        private void BTN_HardlopersPlus_Click(object sender, EventArgs e)
        {
            if (LSV_HardlopersTafel.SelectedItems.Count == 1 && LSV_Hardlopers.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_HardlopersTafel.SelectedItems[0].Text);

                // RegelNR 
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem 
                bestellingRegel.MenuItemID = int.Parse((LSV_Hardlopers.SelectedItems[0].Text));

                // Aantal
                bestellingRegel.Aantal = int.Parse(NUP_Hardlopers.Value.ToString());

                // Check voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs 
                double prijs = double.Parse(LSV_Hardlopers.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_HardlopersTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.09;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voegbestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);
                        
                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_VoorgerechtenPlus_Click(object sender, EventArgs e)
        {
            if (LSV_VoorgerechtenTafel.SelectedItems.Count == 1 && LSV_Voorgerechten.SelectedItems.Count == 1)
            {
                // Bestelling ID
                bestellingRegel.BestellingID = int.Parse(LSV_VoorgerechtenTafel.SelectedItems[0].Text);

                // RegelNR 
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem 
                bestellingRegel.MenuItemID = int.Parse((LSV_Voorgerechten.SelectedItems[0].Text));

                // Aantal 
                bestellingRegel.Aantal = int.Parse(NUP_Voorgerechten.Value.ToString());

                // Voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_Voorgerechten.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_VoorgerechtenTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.09;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voeg bestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);

                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_TussengerechtenPlus_Click(object sender, EventArgs e)
        {
            if (LSV_Tussengerechten.SelectedItems.Count == 1 && LSV_TussengerechtenTafel.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_TussengerechtenTafel.SelectedItems[0].Text.ToString());

                // RegelNR 
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem
                bestellingRegel.MenuItemID = int.Parse(LSV_Tussengerechten.SelectedItems[0].Text.ToString());

                // Aantal 
                bestellingRegel.Aantal = int.Parse(NUP_Tussengerechten.Value.ToString());

                // Voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_Tussengerechten.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_TussengerechtenTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.09;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voeg bestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);

                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_HoofdgerechtenPlus_Click(object sender, EventArgs e)
        {
            if (LSV_HoofdgerechtTafel.SelectedItems.Count == 1 && LSV_Hoofdgerechten.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_HoofdgerechtTafel.SelectedItems[0].Text.ToString());

                // RegelNR 
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem 
                bestellingRegel.MenuItemID = int.Parse(LSV_Hoofdgerechten.SelectedItems[0].Text.ToString());

                // Aantal 
                bestellingRegel.Aantal = int.Parse(NUP_Hoofdgerechten.Value.ToString());

                // Bereken voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_Hoofdgerechten.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_HoofdgerechtTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.09;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voegbestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);

                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_NagerechtenPlus_Click(object sender, EventArgs e)
        {
            if (LSV_NagerechtTafel.SelectedItems.Count == 1 && LSV_Nagerechten.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_NagerechtTafel.SelectedItems[0].Text.ToString());

                // RegelNR
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem 
                bestellingRegel.MenuItemID = int.Parse(LSV_Nagerechten.SelectedItems[0].Text.ToString());

                // Aantal 
                bestellingRegel.Aantal = int.Parse(NUP_Nagerechten.Value.ToString());

                // Bereken voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_Nagerechten.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_NagerechtTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.09;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voeg bestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);
                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_FrisdrankPlus_Click(object sender, EventArgs e)
        {
            if (LSV_FrisdrankTafel.SelectedItems.Count == 1 && LSV_Frisdrank.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_FrisdrankTafel.SelectedItems[0].Text.ToString());

                // RegelNR
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem
                bestellingRegel.MenuItemID = int.Parse(LSV_Frisdrank.SelectedItems[0].Text.ToString());

                // Aantal
                bestellingRegel.Aantal = int.Parse(NUP_Frisdrank.Value.ToString());

                // Voorraad berekenen
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_Frisdrank.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_FrisdrankTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.09;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voeg bestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);
                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_KoffieTheePlus_Click(object sender, EventArgs e)
        {
            if (LSV_KoffieTheeTafel.SelectedItems.Count == 1 && LSV_KoffieThee.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_KoffieTheeTafel.SelectedItems[0].Text.ToString());

                // RegelNR
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem 
                bestellingRegel.MenuItemID = int.Parse(LSV_KoffieThee.SelectedItems[0].Text.ToString());

                // Aantal
                bestellingRegel.Aantal = int.Parse(NUP_KoffieThee.Value.ToString());

                // Bereken voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_KoffieThee.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_KoffieTheeTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.09;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voeg bestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);

                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_BierPlus_Click(object sender, EventArgs e)
        {
            if (LSV_BierTafel.SelectedItems.Count == 1 && LSV_Bier.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_BierTafel.SelectedItems[0].Text.ToString());

                // RegelNR
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem 
                bestellingRegel.MenuItemID = int.Parse(LSV_Bier.SelectedItems[0].Text.ToString());

                // Aantal
                bestellingRegel.Aantal = int.Parse(NUP_Bier.Value.ToString());

                // Bereken voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_Bier.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_BierTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.12;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voeg bestelling toe
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig stock
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);

                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }
  
        private void BTN_WijnPlus_Click(object sender, EventArgs e)
        {
            if (LSV_WijnTafel.SelectedItems.Count == 1 && LSV_Wijn.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_WijnTafel.SelectedItems[0].Text.ToString());

                // RegelNR 
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem 
                bestellingRegel.MenuItemID = int.Parse(LSV_Wijn.SelectedItems[0].Text.ToString());

                // Aantal
                bestellingRegel.Aantal = int.Parse(NUP_Wijn.Value.ToString());

                // Voorraad berekenen
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_Wijn.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_WijnTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.12;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        // Voeg bestelling
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        // Wijzig voorraad
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        // Update subtotaal
                        bestelling_Service.UpdateSubtotaal(bestelling);
                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        private void BTN_GedeDrankPlus_Click(object sender, EventArgs e)
        {
            if (LSV_GedeTafel.SelectedItems.Count == 1 && LSV_GedeDrank.SelectedItems.Count == 1)
            {
                // BestellingID
                bestellingRegel.BestellingID = int.Parse(LSV_GedeTafel.SelectedItems[0].Text.ToString());

                // RegelNR
                int RegelNummer = BestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem
                bestellingRegel.MenuItemID = int.Parse(LSV_GedeDrank.SelectedItems[0].Text.ToString());

                // Aantal 
                bestellingRegel.Aantal = int.Parse(NUP_GedeDrank.Value.ToString());

                // Bereken voorraad
                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);
                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);

                // Bereken prijs
                double prijs = double.Parse(LSV_GedeDrank.SelectedItems[0].SubItems[2].Text);
                bestelling.BestellingSubtotaal = bestellingRegel.Aantal * prijs;
                bestelling.BestellingID = int.Parse(LSV_GedeTafel.SelectedItems[0].Text);

                // Bereken BTW
                bestelling.BTW = bestelling.BestellingSubtotaal * 0.12;

                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling >= 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        BestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
                        bestelling_Service.UpdateSubtotaal(bestelling);
                        MessageBox.Show("Item is toegevoegd aan bestelling!");
                    }
                    else
                    {
                        MessageBox.Show("Voer een juist aantal in!");
                    }
                }
                else
                {
                    MessageBox.Show($"Niet op voorraad.. ({voorraad})");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product en een tafel alstublieft", "Fout bij bestelling opnemen", MessageBoxButtons.OK);
            }
            
        }

        // Bestelling bevestigen
        private void BTN_Bevestig_Click(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();

            // Show bestelling
            PNL_BevestigBestelling.Show();
            BTN_Terug.Show();

            // FullRowSelect
            FullRowSelect();

            // Haal lijst uit servicelaag
            List<BestellingRegel> bestellingRegels = BestellingRegel_Service.Db_GetBestellingen();

            // Clear the listview 
            LSV_BestellingOverzicht.Items.Clear();

            // Fill listview met bestelling
            foreach (BestellingRegel m in bestellingRegels)
            {
                ListViewItem bestelling = new ListViewItem(m.BestellingID.ToString());
                bestelling.Tag = m;
                bestelling.SubItems.Add(m.RegelNR.ToString());
                bestelling.SubItems.Add(m.MenuItemID.ToString());
                bestelling.SubItems.Add(m.Aantal.ToString());
                LSV_BestellingOverzicht.Items.Add(bestelling);
            }
        }

        // Opmerking toevoegen
        private void BTN_BestellingBevestigen_Click(object sender, EventArgs e)
        {
            if (LSV_BestellingOverzicht.SelectedItems.Count == 1 && TXTBOX_Opmerking.Text != "")
            {
                // ID ophalen 
                bestellingRegel.BestellingID = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].Text.ToString());

                // regel ophalen
                bestellingRegel.RegelNR = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[1].Text.ToString());

                DialogResult msbresult = MessageBox.Show("Opmerking toevoegen?", "Opmerking toevoegen", MessageBoxButtons.YesNo);
                if (msbresult == DialogResult.Yes)
                {
                    // Opmerking uit textbox halen
                    bestellingRegel.Opmerking = TXTBOX_Opmerking.Text.ToString();

                    // data meegeven naar "opmerking toevoegen aan bestelling" methode in service laag
                    BestellingRegel_Service.Db_OpmerkingToevoegen(bestellingRegel);

                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een bestelling en vul dan een opmerking in alstublieft!", "Fout bij opmerking toevoegen", MessageBoxButtons.OK);
            }
        }



        // Bestelde item verwijderen
        private void BTN_BestelItemVerwijderen_Click_1(object sender, EventArgs e)
        {
            if (LSV_BestellingOverzicht.SelectedItems.Count == 1)
            {
                // id ophalen
                bestellingRegel.BestellingID = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].Text.ToString());


                // regel ophalen
                bestellingRegel.RegelNR = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[1].Text.ToString());

                // menuitem ophalen
                bestellingRegel.MenuItemID = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[2].Text.ToString());

                // Aantal ophalen
                bestellingRegel.Aantal = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[3].Text.ToString());

                DialogResult msbresult = MessageBox.Show("item verwijderen?", "Item verwijderen", MessageBoxButtons.YesNo);
                if (msbresult == DialogResult.Yes)
                {
                    BestellingRegel_Service.Db_VerwijderBestelling(bestellingRegel);
                    voorraadItemService.WijzigVoorraadPlus(bestellingRegel);
                }

                FullRowSelect();

                // Fill bestellingoverzicht listview with a list of bestellingen
                List<BestellingRegel> bestellingRegels = BestellingRegel_Service.Db_GetBestellingen();

                // Clear the listview and fill it
                LSV_BestellingOverzicht.Items.Clear();

                foreach (BestellingRegel m in bestellingRegels)
                {
                    ListViewItem bestelling = new ListViewItem(m.BestellingID.ToString());
                    bestelling.Tag = m;
                    bestelling.SubItems.Add(m.RegelNR.ToString());
                    bestelling.SubItems.Add(m.MenuItemID.ToString());
                    bestelling.SubItems.Add(m.Aantal.ToString());
                    LSV_BestellingOverzicht.Items.Add(bestelling);
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een bestelling alstublieft!", "Fout bij bestelling verwijderen", MessageBoxButtons.OK);
            }
        }



        // Bestelde item wijzigen
        private void BTN_BestelItemWijzigen_Click(object sender, EventArgs e)
        {
            if (LSV_BestellingOverzicht.SelectedItems.Count == 1)
            {
                // id ophalen
                bestellingRegel.BestellingID = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].Text.ToString());

                // regel ophalen
                bestellingRegel.RegelNR = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[1].Text.ToString());

                // aantal ophalen
                bestellingRegel.Aantal = int.Parse(NUP_BestellingOverzicht.Value.ToString());

                // ID en regel meegeven naar "Item wijzigen" methode in service laag
                BestellingRegel_Service.Db_WijzigBestelling(bestellingRegel);

                FullRowSelect();
                // Fill bestellingoverzicht listview with a list of bestellingen
                List<BestellingRegel> bestellingRegels = BestellingRegel_Service.Db_GetBestellingen();

                // Clear the listview and fill it
                LSV_BestellingOverzicht.Items.Clear();

                foreach (BestellingRegel m in bestellingRegels)
                {
                    ListViewItem bestelling = new ListViewItem(m.BestellingID.ToString());
                    bestelling.Tag = m;
                    bestelling.SubItems.Add(m.RegelNR.ToString());
                    bestelling.SubItems.Add(m.MenuItemID.ToString());
                    bestelling.SubItems.Add(m.Aantal.ToString());
                    LSV_BestellingOverzicht.Items.Add(bestelling);
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een bestelling alstublieft!", "Fout bij bestelling wijzigen", MessageBoxButtons.OK);
            }
        }




        // terug naar bestelling aanmaken
        private void BTN_NieuweBestelling_Click(object sender, EventArgs e)
        {
            // Hide other panels
            HidePanels();
            // Show start
            PNL_BestellingMaken.Show();
        }
        


        // Terug naar hoofdmenu
        private void BTN_Hoofdmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            _menu.Show();
        }
    }
}
