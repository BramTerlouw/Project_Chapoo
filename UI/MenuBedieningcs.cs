﻿using Model_Chapoo;
using Service_Chapoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Chapoo
{
    public partial class MenuBediening : Form
    {
        public MenuBediening()
        {
            InitializeComponent();
        }
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
            // Show start
            PNL_MenuStart.Show();
        }
        
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
            // Show menu hardlopers
            PNL_Hardlopers.Show();
        }

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
            // Show menu gerechten
            PNL_GerechtenMenu.Show();
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
            // Show menu dranken
            PNL_DrankenMenu.Show();
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
            // Show Voorgerechten
            PNL_Voorgerechten.Show();

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
            // Show tussengerechten
            PNL_Tussengerechten.Show();

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
            // Show hoofdgerechten
            PNL_Hoofdgerechten.Show();

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
            // Show nagerechten
            PNL_Nagerechten.Show();

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
        }

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
            // Show frisdrank
            PNL_Frisdrank.Show();

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
            // Show koffie en thee
            PNL_KoffieThee.Show();

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
            // Show bier
            PNL_Bier.Show();

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
            // Show wijn
            PNL_Wijn.Show();

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
            // Show Gedestileerde drank
            PNL_GedeDrank.Show();

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
        }

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
            // Show start
            PNL_MenuStart.Show();
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
            // Show bestelling
            PNL_BevestigBestelling.Show();
        }


        private void BTN_VoorgerechtenPlus_Click(object sender, EventArgs e)
        {
            // Haal alles op
            int MenuItemID = int.Parse(LSV_Voorgerechten.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_Voorgerechten.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        private void BTN_TussengerechtenPlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_Tussengerechten.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_Tussengerechten.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        private void BTN_HoofdgerechtenPlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_Hoofdgerechten.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_Hoofdgerechten.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }

        }

        private void BTN_NagerechtenPlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_Nagerechten.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_Nagerechten.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        private void BTN_FrisdrankPlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_Frisdrank.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_Frisdrank.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        private void BTN_KoffieTheePlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_KoffieThee.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_KoffieThee.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        private void BTN_BierPlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_Bier.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_Bier.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        
        private void BTN_WijnPlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_Wijn.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_Wijn.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        private void BTN_GedeDrankPlus_Click(object sender, EventArgs e)
        {
            int MenuItemID = int.Parse(LSV_GedeDrank.SelectedItems[0].Text.ToString());
            int Aantal = int.Parse(NUP_GedeDrank.Value.ToString());

            BestellingRegel_Service bestellingRegel_Service = new BestellingRegel_Service();

            // Geef de variable mee naar methode in service laag
            
            if (Aantal > 0)
            {
                bestellingRegel_Service.Db_VoegBestellingToe(MenuItemID, Aantal);
                MessageBox.Show("Item is toegevoegd aan bestelling!");
            }
            else
            {
                MessageBox.Show("Voer een juist aantal in!");
            }
        }

        private void BTN_BestellingBevestigen_Click(object sender, EventArgs e)
        {
            DialogResult msbresult = MessageBox.Show("Bestelling bevestigen?", "Bestelling bevestigen", MessageBoxButtons.YesNo);
            if (msbresult == DialogResult.Yes)
            {
                // Opmerking uit textbox halen
                string opmerking = TXTBOX_Opmerking.Text.ToString();

                // Opmerking meegeven naar "opmerking toevoegen aan bestelling" methode in service laag

                // Bestelling aanmaken
            }
        }

        private void BTN_BestelItemVerwijderen_Click_1(object sender, EventArgs e)
        {
            // id ophalen
            int ID = int.Parse(LSV_BestellingOverzicht.SelectedItems[1].Text.ToString());

            // ID meegeven naar "Item verwijderen" methode in service laag
        }

        private void BTN_BestelItemWijzigen_Click(object sender, EventArgs e)
        {

        }

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
            // Show start
            PNL_MenuStart.Show();
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

            // Show start
            PNL_MenuStart.Show();
        }
    }
}