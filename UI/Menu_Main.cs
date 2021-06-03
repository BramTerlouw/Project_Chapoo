using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model_Chapoo;
using Service_Chapoo;

namespace UI
{
    public partial class Menu_Main : Form
    {
        private Administratie_Main main;
        private List<MenukaartItem> menu;
        private MenuKaartService _service;
        private Medewerker _medewerker;

        public Menu_Main(Administratie_Main main, Medewerker medewerker)
        {
            InitializeComponent();
            this.main = main;
            this._medewerker = medewerker;
            this._service = new MenuKaartService();

            menu = _service.GetMenu();
            PopulateDGVMenu();
            PopulateCMBMenuIDs();
            PopulateCMBColumns();
            PopulateCMBKinds();
            HidePanels();
        }

        public void HidePanels()
        {
            pnlMenuAanpassen.Hide();
            pnlMenuItemToevoegen.Hide();
            pnlMenuItemVerwijderen.Hide();

            if (_medewerker.Rol != "Eigenaar")
            {
                btnMenuAanpassen.Hide();
                btnMenuItemToevoegen.Hide();
                btnMenuItemVerwijderen.Hide();
            }
        }




        // Populating
        private void PopulateDGVMenu()
        {
            dgvMenu.Rows.Clear();
            foreach (MenukaartItem item in menu)
            {
                dgvMenu.Rows.Add(item.dataGridNoAlc(item));
            }
        }

        private void PopulateCMBMenuIDs()
        {
            List<int> ids = _service.GetMenuIDs();
            foreach (int id in ids)
            {
                cmbMenuAanpassenIDs.Items.Add(id);
                cmbVerwijderMenuID.Items.Add(id);
            }
            cmbMenuAanpassenIDs.SelectedIndex = 0;
            cmbVerwijderMenuID.SelectedIndex = 0;
        }

        public void PopulateCMBColumns()
        {
            List<string> columns = _service.GetColumns();
            foreach (string column in columns)
            {
                cmbAanpassenColumn.Items.Add(column);
            }
            cmbAanpassenColumn.SelectedIndex = 0;
        }

        public void PopulateCMBKinds()
        {
            List<String> soorten = _service.GetAllKinds();
            foreach (string soort in soorten)
            {
                cmbToevoegenSoort.Items.Add(soort);
            }
            cmbToevoegenSoort.SelectedIndex = 0;
        }




        // buttons for hiding, showing and filtering
        private void btnInkomstenTerug_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }

        private void btnToonMenuDrank_Click(object sender, EventArgs e)
        {
            menu.Clear();
            menu = _service.GetMenuDrinks();
            PopulateDGVMenu();
        }

        private void btnToonMenuDiner_Click(object sender, EventArgs e)
        {
            menu.Clear();
            menu = _service.GetMenuFoods("Diner");
            PopulateDGVMenu();
        }

        private void btnToonMenuLunch_Click(object sender, EventArgs e)
        {
            menu.Clear();
            menu = _service.GetMenuFoods("Lunch");
            PopulateDGVMenu();
        }

        private void btnToonHeleMenu_Click(object sender, EventArgs e)
        {
            menu.Clear();
            menu = _service.GetMenu();
            PopulateDGVMenu();

            cmbMenuAanpassenIDs.Items.Clear();
            cmbVerwijderMenuID.Items.Clear();
            PopulateCMBMenuIDs();
        }

        private void btnCloseMenuAanpassen_Click(object sender, EventArgs e)
        {
            pnlMenuAanpassen.Hide();
        }

        private void btnCloseMenuToevoegen_Click(object sender, EventArgs e)
        {
            pnlMenuItemToevoegen.Hide();
        }
        private void btnCloseMenuVerwijderen_Click(object sender, EventArgs e)
        {
            pnlMenuItemVerwijderen.Hide();
        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }






        // Menu aanpassen
        private void btnMenuAanpassen_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlMenuAanpassen.Show();
        }

        private void cmbMenuAanpassenIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbMenuAanpassenIDs.SelectedItem;
            MenukaartItem menuItem = _service.GetMenuItem(id);

            lblAanpassenSoort.Text = menuItem.Soort;
            lblAanpassenNaam.Text = menuItem.Naam;
            lblAanpassenAlcohol.Text = menuItem.Alcohol.ToString();
            lblAanpassenPrijs.Text = menuItem.Prijs.ToString("0.00");
        }

        private void cmbAanpassenColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAanpassenColumn.SelectedItem.ToString() == "Alcohol")
            {
                ckbMenuAanpassenAlcohol.Show();
                txtAanpassenNieuw.Hide();
            }
            else
            {
                ckbMenuAanpassenAlcohol.Hide();
                txtAanpassenNieuw.Show();
            }
        }

        private void btnMenuAanpassenDB_Click(object sender, EventArgs e)
        {
            if (cmbAanpassenColumn.SelectedItem.ToString() != "Alcohol" && String.IsNullOrEmpty(txtAanpassenNieuw.Text))
            {
                MessageBox.Show("Vul alle velden!");
                return;
            }

            int id = (int)cmbMenuAanpassenIDs.SelectedItem;
            string column = cmbAanpassenColumn.SelectedItem.ToString();

            bool alcohol = false;
            if (column == "Alcohol")
                if (ckbMenuAanpassenAlcohol.Checked)
                    alcohol = true;
            var input = txtAanpassenNieuw.Text;

            try
            {
                if (column == "Prijs")
                    _service.AdjustMenuItem(id, column, float.Parse(input.Replace('.', ',')));
                else if (column == "Alcohol")
                    _service.AdjustMenuItem(id, column, alcohol);
                else
                    _service.AdjustMenuItem(id, column, input.ToString());
                MessageBox.Show("Menu item aangepast!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong value");
                return;
            }
        }






        // menu item toevoegen
        private void btnMenuItemToevoegen_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlMenuItemToevoegen.Show();
        }

        private void btnMenuToevoegenDb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMenuToevoegenNaam.Text) || String.IsNullOrEmpty(txtMenuToevoegenPrijs.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }

            string soort = cmbToevoegenSoort.SelectedItem.ToString();
            string naam = txtMenuToevoegenNaam.Text;
            float prijs = float.Parse(txtMenuToevoegenPrijs.Text.Replace('.', ','));
            bool alcohol;

            if (cbMenuToevoegenAlcohol.Checked)
                alcohol = true;
            else
                alcohol = false;

            _service.AddMenuItem(soort, naam, alcohol, prijs);
            MessageBox.Show("Menu item toegevoegd!");

        }




        // menu item verwijderen
        private void btnMenuItemVerwijderen_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlMenuItemVerwijderen.Show();
        }

        private void cmbVerwijderMenuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbVerwijderMenuID.SelectedItem;
            MenukaartItem item = _service.GetMenuItem(id);

            lblVerwijderSoort.Text = item.Soort;
            lblVerwijderNaam.Text = item.Naam;
            lblVerwijderAlcohol.Text = item.Alcohol.ToString();
            lblVerwijderPrijs.Text = item.Prijs.ToString("0.00");
        }

        private void btnVerwijderMenuItemDB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u dit item wilt verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)cmbVerwijderMenuID.SelectedItem;
                _service.RemoveMenuItem(id);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlMenuItemVerwijderen.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMenuItemToevoegen.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMenuAanpassen.Hide();
        }

        
    }
}
