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
        public MenuBediening(HoofdMenu menu, Medewerker medewerker)
        {
            InitializeComponent();
            this._medewerker = medewerker;
            this._menu = menu;
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
        }

        private void MenuBediening_Load(object sender, EventArgs e)
        {
            // Hide other panels
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
            PNL_MenuStart.Hide();
            BTN_Terug.Hide();
            BTN_Bevestig.Hide();
            // Show start
            PNL_BestellingMaken.Show();

            FullRowSelect();
            // Fill tafel listview with a list of tables
            Service_Chapoo.Tafel_Service tafel_Service = new Service_Chapoo.Tafel_Service();
            List<Tafel> tafels = tafel_Service.GetTafels();

            // Clear the listview and fill it
            LSV_BestellingAanmaken.Items.Clear();

            foreach (Tafel T in tafels)
            {
                ListViewItem taf = new ListViewItem(T.TafelID.ToString());
                taf.Tag = T;
                taf.SubItems.Add(T.AantalStoelen.ToString());
                taf.SubItems.Add(T.Status);
                LSV_BestellingAanmaken.Items.Add(taf);
            }
        }

        // Bestelling aanmaken
        private void BTN_BestellingAanmaken_Click(object sender, EventArgs e)
        {
            if (LSV_BestellingAanmaken.SelectedItems.Count == 1)
            {
                // Hide other panels
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

                // Show start
                PNL_MenuStart.Show();

                Bestelling_Service bestelling_Service = new Bestelling_Service();
                Model_Chapoo.Bestelling bestelling = new Bestelling();

                bestelling.BestellingSubtotaal = 0;
                bestelling.TafelID = int.Parse(LSV_BestellingAanmaken.SelectedItems[0].Text.ToString());
                bestelling.Status = "bezig";

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
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show menu hardlopers
            BTN_Terug.Show();
            PNL_Hardlopers.Show();
            BTN_Bevestig.Show();
            FullRowSelect();
            // Fill hardlopers listview with a list of hardlopers
            Service_Chapoo.MenuKaartService menuKaartService = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> hardlopers = menuKaartService.GetHardlopers();

            // Clear the listview and fill it
            LSV_Hardlopers.Items.Clear();

            foreach (MenukaartItem m in hardlopers)
            {
                ListViewItem Hardlopers = new ListViewItem(m.Id.ToString());
                Hardlopers.Tag = m;
                Hardlopers.SubItems.Add(m.Naam);
                Hardlopers.SubItems.Add(m.Prijs.ToString());
                LSV_Hardlopers.Items.Add(Hardlopers);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_HardlopersTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_HardlopersTafel.Items.Add(best);
            }

        }

        // Gerechten menu
        private void BTN_Gerechten_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_GedeDrank.Hide();
            PNL_Wijn.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_Frisdrank.Hide();
            PNL_Voorgerechten.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show menu gerechten
            PNL_GerechtenMenu.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();
        }

        private void BTN_Dranken_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
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
            PNL_MenuStart.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show menu dranken
            PNL_DrankenMenu.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();
        }

        private void BTN_Voorgerechten_Click(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_GedeDrank.Hide();
            PNL_Wijn.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_Frisdrank.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show Voorgerechten
            PNL_Voorgerechten.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            FullRowSelect();
            // Fill voorgerechten listview with a list of voorgerechten
            Service_Chapoo.MenuKaartService Voorgerechten_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> Voorgerechten = Voorgerechten_Service.GetVoorgerecht();

            // Clear the listview and fill it
            LSV_Voorgerechten.Items.Clear();

            foreach (MenukaartItem m in Voorgerechten)
            {
                ListViewItem Vgerechten = new ListViewItem(m.Id.ToString());
                Vgerechten.Tag = m;
                Vgerechten.SubItems.Add(m.Naam);
                Vgerechten.SubItems.Add(m.Prijs.ToString());
                LSV_Voorgerechten.Items.Add(Vgerechten);
            }
        

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_VoorgerechtenTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_VoorgerechtenTafel.Items.Add(best);
            }
        }

        private void BTN_Tussengerechten_Click(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_GedeDrank.Hide();
            PNL_Wijn.Hide();
            PNL_Hardlopers.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_Frisdrank.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show tussengerechten
            PNL_Tussengerechten.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            FullRowSelect();
            // Fill tussengerechten listview with a list of tussengerechten
            Service_Chapoo.MenuKaartService tussengerechten_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> Tussengerechten = tussengerechten_Service.GetTussengerecht();
            // Clear the listview and fill it
            LSV_Tussengerechten.Items.Clear();

            foreach (MenukaartItem m in Tussengerechten)
            {
                ListViewItem tusgerechten = new ListViewItem(m.Id.ToString());
                tusgerechten.Tag = m;
                tusgerechten.SubItems.Add(m.Naam);
                tusgerechten.SubItems.Add(m.Prijs.ToString());
                LSV_Tussengerechten.Items.Add(tusgerechten);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_TussengerechtenTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_TussengerechtenTafel.Items.Add(best);
            }
        }

        private void BTN_Hoofdgerechten_Click(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_GedeDrank.Hide();
            PNL_Wijn.Hide();
            PNL_Hardlopers.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_Frisdrank.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show hoofdgerechten
            PNL_Hoofdgerechten.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            FullRowSelect();
            // Fill hoofdgerechten listview with a list of hoofdgerechten
            Service_Chapoo.MenuKaartService Hoofdgerechten_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> hoofdgerechten = Hoofdgerechten_Service.GetHoofdgerecht();

            // Clear the listview and fill it
            LSV_Hoofdgerechten.Items.Clear();

            foreach (MenukaartItem m in hoofdgerechten)
            {
                ListViewItem Hoofdgerechten = new ListViewItem(m.Id.ToString());
                Hoofdgerechten.Tag = m;
                Hoofdgerechten.SubItems.Add(m.Naam);
                Hoofdgerechten.SubItems.Add(m.Prijs.ToString());
                LSV_Hoofdgerechten.Items.Add(Hoofdgerechten);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_HoofdgerechtTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_HoofdgerechtTafel.Items.Add(best);
            }
        }

        private void BTN_Nagerecht_Click(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_GedeDrank.Hide();
            PNL_Wijn.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_Frisdrank.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show nagerechten
            PNL_Nagerechten.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            FullRowSelect();
            // Fill nagerechten listview with a list of nagerechten
            Service_Chapoo.MenuKaartService Nagerecht_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> Nagerecht = Nagerecht_Service.GetNagerecht();

            // Clear the listview and fill it
            LSV_Nagerechten.Items.Clear();

            foreach (MenukaartItem m in Nagerecht)
            {
                ListViewItem nagerecht = new ListViewItem(m.Id.ToString());
                nagerecht.Tag = m;
                nagerecht.SubItems.Add(m.Naam);
                nagerecht.SubItems.Add(m.Prijs.ToString());
                LSV_Nagerechten.Items.Add(nagerecht);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_NagerechtTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_NagerechtTafel.Items.Add(best);
            }
        }

        // Dranken menu
        private void BTN_Frisdrank_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_GedeDrank.Hide();
            PNL_Wijn.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show frisdrank
            PNL_Frisdrank.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            FullRowSelect();
            // Fill Frisdrank listview with a list of Frisdrank
            Service_Chapoo.MenuKaartService fridrank_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> frisdrank = fridrank_Service.GetFrisdrank();

            // Clear the listview and fill it
            LSV_Frisdrank.Items.Clear();
            foreach (MenukaartItem m in frisdrank)
            {
                ListViewItem Frisdrank = new ListViewItem(m.Id.ToString());
                Frisdrank.Tag = m;
                Frisdrank.SubItems.Add(m.Naam);
                Frisdrank.SubItems.Add(m.Prijs.ToString());
                LSV_Frisdrank.Items.Add(Frisdrank);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_FrisdrankTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_FrisdrankTafel.Items.Add(best);
            }
        }

        private void BTN_KoffieThee_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_Bier.Hide();
            PNL_Frisdrank.Hide();
            PNL_GedeDrank.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Wijn.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show koffie en thee
            PNL_KoffieThee.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // Fill koffie en thee listview with a list of koffie en thee
            Service_Chapoo.MenuKaartService koffiethee_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> koffiethee = koffiethee_Service.GetKoffieThee();

            FullRowSelect();
            // Clear the listview and fill it
            LSV_KoffieThee.Items.Clear();

            foreach (MenukaartItem m in koffiethee)
            {
                ListViewItem KoffieThee = new ListViewItem(m.Id.ToString());
                KoffieThee.Tag = m;
                KoffieThee.SubItems.Add(m.Naam);
                KoffieThee.SubItems.Add(m.Prijs.ToString());
                LSV_KoffieThee.Items.Add(KoffieThee);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_KoffieTheeTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_KoffieTheeTafel.Items.Add(best);
            }
        }

        private void BTN_Bier_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_Frisdrank.Hide();
            PNL_GedeDrank.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Wijn.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show bier
            PNL_Bier.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // Fill bier listview with a list of bier
            Service_Chapoo.MenuKaartService bier_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> bier = bier_Service.GetBier();

            FullRowSelect();
            // Clear the listview and fill it
            LSV_Bier.Items.Clear();

            foreach (MenukaartItem m in bier)
            {
                ListViewItem Bier = new ListViewItem(m.Id.ToString());
                Bier.Tag = m;
                Bier.SubItems.Add(m.Naam);
                Bier.SubItems.Add(m.Prijs.ToString());
                LSV_Bier.Items.Add(Bier);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_BierTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_BierTafel.Items.Add(best);
            }
        }

        private void BTN_Wijn_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_Frisdrank.Hide();
            PNL_GedeDrank.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show wijn
            PNL_Wijn.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            // Fill wijn listview with a list of wijn
            Service_Chapoo.MenuKaartService wijn_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> wijn = wijn_Service.GetWijn();

            FullRowSelect();
            // Clear the listview and fill it
            LSV_Wijn.Items.Clear();

            foreach (MenukaartItem m in wijn)
            {
                ListViewItem Wijn = new ListViewItem(m.Id.ToString());
                Wijn.Tag = m;
                Wijn.SubItems.Add(m.Naam);
                Wijn.SubItems.Add(m.Prijs.ToString());
                LSV_Wijn.Items.Add(Wijn);
            }

            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_WijnTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_WijnTafel.Items.Add(best);
            }
        }

        private void BTN_GedeDrank_Click_1(object sender, EventArgs e)
        {
            // Hide other panels
            PNL_Frisdrank.Hide();
            PNL_Wijn.Hide();
            PNL_Hardlopers.Hide();
            PNL_Hoofdgerechten.Hide();
            PNL_Nagerechten.Hide();
            PNL_Tussengerechten.Hide();
            PNL_Voorgerechten.Hide();
            PNL_Bier.Hide();
            PNL_DrankenMenu.Hide();
            PNL_GerechtenMenu.Hide();
            PNL_MenuStart.Hide();
            PNL_KoffieThee.Hide();
            PNL_BevestigBestelling.Hide();
            PNL_BestellingMaken.Hide();
            // Show Gedestileerde drank
            PNL_GedeDrank.Show();
            BTN_Terug.Show();
            BTN_Bevestig.Show();

            FullRowSelect();
            // Fill GedeDrank listview with a list of GedeDrank
            Service_Chapoo.MenuKaartService gededrank_Service = new Service_Chapoo.MenuKaartService();
            List<MenukaartItem> gededrank = gededrank_Service.GetGedeDrink();

            // Clear the listview and fill it
            LSV_GedeDrank.Items.Clear();

            foreach (MenukaartItem m in gededrank)
            {
                ListViewItem GedeDrank = new ListViewItem(m.Id.ToString());
                GedeDrank.Tag = m;
                GedeDrank.SubItems.Add(m.Naam);
                GedeDrank.SubItems.Add(m.Prijs.ToString());
                LSV_GedeDrank.Items.Add(GedeDrank);
            }
            // Fill with bestellingen
            Service_Chapoo.Bestelling_Service bestelling_Service = new Service_Chapoo.Bestelling_Service();
            List<Bestelling> bestellingen = bestelling_Service.GetBestellingen();

            // Clear the listview and fill it
            LSV_GedeTafel.Items.Clear();

            foreach (Bestelling b in bestellingen)
            {
                ListViewItem best = new ListViewItem(b.BestellingID.ToString());
                best.Tag = b;
                best.SubItems.Add(b.TafelID.ToString());
                LSV_GedeTafel.Items.Add(best);
            }

        }

        // Terug Bevestigen Uitloggen
        private void BTN_Terug_Click(object sender, EventArgs e)
        {
            // Hide other panels
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
            // Show start
            PNL_MenuStart.Show();
            BTN_Bevestig.Show();

        }

        private void BTN_Bevestig_Click(object sender, EventArgs e)
        {
            // Hide other panels
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
            PNL_MenuStart.Hide();
            PNL_BestellingMaken.Hide();
            BTN_Bevestig.Hide();
            // Show bestelling
            PNL_BevestigBestelling.Show();
            BTN_Terug.Show();

            FullRowSelect();
            // Fill bestellingoverzicht listview with a list of bestellingen
            Service_Chapoo.BestellingRegel_Service bestelling_Service = new Service_Chapoo.BestellingRegel_Service();
            List<BestellingRegel> bestellingRegels = bestelling_Service.Db_GetBestellingen();

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
        private void BTN_Loguit_Click(object sender, EventArgs e)
        {
            // Hide other panels
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
            PNL_MenuStart.Hide();
            // Show start
            PNL_BestellingMaken.Show();

        }

        // Items toevoegen aan bestelling
        private void BTN_HardlopersPlus_Click(object sender, EventArgs e)
        {
            if (LSV_HardlopersTafel.SelectedItems.Count == 1 && LSV_Hardlopers.SelectedItems.Count == 1)
            {
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();

                // Haal alles op
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();

                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_HardlopersTafel.SelectedItems[0].Text);

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                string menuitemid = (LSV_Hardlopers.SelectedItems[0].Text);
                bestellingRegel.MenuItemID = int.Parse(menuitemid);
                //bestellingRegel.MenuItemID = int.Parse(LSV_Voorgerechten.SelectedItems[0].Text);

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Hardlopers.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();

                // Haal alles op
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();

                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_VoorgerechtenTafel.SelectedItems[0].Text);

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                string menuitemid = (LSV_Voorgerechten.SelectedItems[0].Text);
                bestellingRegel.MenuItemID = int.Parse(menuitemid);
                //bestellingRegel.MenuItemID = int.Parse(LSV_Voorgerechten.SelectedItems[0].Text);

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Voorgerechten.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_TussengerechtenTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_Tussengerechten.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Tussengerechten.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_HoofdgerechtTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_Hoofdgerechten.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Hoofdgerechten.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_NagerechtTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_Nagerechten.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Nagerechten.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_FrisdrankTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_Frisdrank.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Frisdrank.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_KoffieTheeTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_KoffieThee.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_KoffieThee.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_BierTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_Bier.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Bier.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_WijnTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;

                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_Wijn.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_Wijn.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
                Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                VoorraadItemService voorraadItemService = new VoorraadItemService();
                // Bestelling id uit lsv tafel
                bestellingRegel.BestellingID = int.Parse(LSV_GedeTafel.SelectedItems[0].Text.ToString());

                // RegelNR via COUNT
                int RegelNummer = bestellingRegel_Service.DB_TelRegels(bestellingRegel);
                bestellingRegel.RegelNR = RegelNummer + 1;
                // MenuItem uit lsv
                bestellingRegel.MenuItemID = int.Parse(LSV_GedeDrank.SelectedItems[0].Text.ToString());

                // Aantal uit nup
                bestellingRegel.Aantal = int.Parse(NUP_GedeDrank.Value.ToString());

                int voorraad = voorraadItemService.CheckVoorraad(bestellingRegel);

                int voorraadMinBestelling = (voorraad - bestellingRegel.Aantal);
                // Geef de variable mee naar methode in service laag
                if (voorraadMinBestelling > 0)
                {
                    if (bestellingRegel.Aantal > 0)
                    {
                        bestellingRegel_Service.Db_VoegBestellingToe(bestellingRegel);
                        voorraadItemService.WijzigStockNaOrder(bestellingRegel);
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
        private void BTN_BestellingBevestigen_Click(object sender, EventArgs e)
        {
            // id ophalen
            Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
            bestellingRegel.BestellingID = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].Text.ToString());
            // regel ophalen
            bestellingRegel.RegelNR = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[1].Text.ToString());

            DialogResult msbresult = MessageBox.Show("Bestelling bevestigen?", "Bestelling bevestigen", MessageBoxButtons.YesNo);
            if (msbresult == DialogResult.Yes)
            {
                // Opmerking uit textbox halen
                bestellingRegel.Opmerking = TXTBOX_Opmerking.Text.ToString();

                // data meegeven naar "opmerking toevoegen aan bestelling" methode in service laag
                BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
                bestellingRegel_Service.Db_OpmerkingToevoegen(bestellingRegel);

                // Bestelling aanmaken
            }
        }

        // Bestelde item verwijderen
        private void BTN_BestelItemVerwijderen_Click_1(object sender, EventArgs e)
        {
            // id ophalen
            Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
            bestellingRegel.BestellingID = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].Text.ToString());
            VoorraadItemService voorraadItemService = new VoorraadItemService();
            // regel ophalen
            bestellingRegel.RegelNR = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[1].Text.ToString());

            // ID en regel meegeven naar "Item verwijderen" methode in service laag
            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
            bestellingRegel_Service.Db_VerwijderBestelling(bestellingRegel);

            FullRowSelect();
            // Fill bestellingoverzicht listview with a list of bestellingen
            Service_Chapoo.BestellingRegel_Service bestelling_Service = new Service_Chapoo.BestellingRegel_Service();
            List<BestellingRegel> bestellingRegels = bestelling_Service.Db_GetBestellingen();

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

        // Bestelde item wijzigen
        private void BTN_BestelItemWijzigen_Click(object sender, EventArgs e)
        {
            // id ophalen
            Model_Chapoo.BestellingRegel bestellingRegel = new BestellingRegel();
            bestellingRegel.BestellingID = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].Text.ToString());

            // regel ophalen
            bestellingRegel.RegelNR = int.Parse(LSV_BestellingOverzicht.SelectedItems[0].SubItems[1].Text.ToString());

            // aantal ophalen
            bestellingRegel.Aantal = int.Parse(NUP_BestellingOverzicht.Value.ToString());

            // ID en regel meegeven naar "Item wijzigen" methode in service laag
            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();
            bestellingRegel_Service.Db_WijzigBestelling(bestellingRegel);

            FullRowSelect();
            // Fill bestellingoverzicht listview with a list of bestellingen
            Service_Chapoo.BestellingRegel_Service bestelling_Service = new Service_Chapoo.BestellingRegel_Service();
            List<BestellingRegel> bestellingRegels = bestelling_Service.Db_GetBestellingen();

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

        // terug naar bestelling aanmaken
        private void BTN_NieuweBestelling_Click(object sender, EventArgs e)
        {
            // Hide other panels
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
            PNL_MenuStart.Hide();
            BTN_Terug.Hide();
            BTN_Bevestig.Hide();
            // Show start
            PNL_BestellingMaken.Show();
        }
        private void PNL_BevestigBestelling_Paint(object sender, PaintEventArgs e)
        {
            // Hide other panels
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

            // Show start
            PNL_MenuStart.Show();
        }

        private void BTN_Hoofdmenu_Click(object sender, EventArgs e)
        {
            this.Close();
            _menu.Show();
        }
    }
}
