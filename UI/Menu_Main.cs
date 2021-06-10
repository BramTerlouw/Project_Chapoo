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

            // fill all cmbs and dgvs
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

            if (_medewerker.Rol != "Eigenaar") // when logged employee is eigenaar, show extra functions
            {
                btnMenuAanpassen.Hide();
                btnMenuItemToevoegen.Hide();
                btnMenuItemVerwijderen.Hide();
            }
        }




        // Populating
        private void PopulateDGVMenu()
        {
            dgvMenu.Rows.Clear(); // fill dgv with menu items
            foreach (MenukaartItem item in menu)
            {
                dgvMenu.Rows.Add(item.dataGridNoAlc(item));
            }
        }

        private void PopulateCMBMenuIDs()
        {
            // fill cmbs with ids of all menu items
            foreach (MenukaartItem item in menu)
            {
                cmbMenuAanpassenIDs.Items.Add(item.Id);
                cmbVerwijderMenuID.Items.Add(item.Id);
            }
            cmbMenuAanpassenIDs.SelectedIndex = 0; // set default selected index to 0
            cmbVerwijderMenuID.SelectedIndex = 0;
        }

        public void PopulateCMBColumns()
        {
            // get a list of columns from service layer and fill cmb
            List<string> columns = _service.GetColumns();
            foreach (string column in columns)
            {
                cmbAanpassenColumn.Items.Add(column);
            }
            cmbAanpassenColumn.SelectedIndex = 0; // set default selected index to 0
        }

        public void PopulateCMBKinds()
        {
            // get a list with all kinds of menu items from service layer and fill cmb
            List<String> soorten = _service.GetAllKinds();
            foreach (string soort in soorten)
            {
                cmbToevoegenSoort.Items.Add(soort);
            }
            cmbToevoegenSoort.SelectedIndex = 0; // set default selected index to 0
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
            PopulateDGVMenu(); // show drinks only
        }

        private void btnToonMenuDiner_Click(object sender, EventArgs e)
        {
            menu.Clear();
            menu = _service.GetMenuFoods("Diner");
            PopulateDGVMenu(); // show diner only
        }

        private void btnToonMenuLunch_Click(object sender, EventArgs e)
        {
            menu.Clear();
            menu = _service.GetMenuFoods("Lunch");
            PopulateDGVMenu(); // show lunch only
        }

        private void btnToonHeleMenu_Click(object sender, EventArgs e)
        {
            menu.Clear();
            menu = _service.GetMenu();
            PopulateDGVMenu(); // show whole menu again

            cmbMenuAanpassenIDs.Items.Clear();
            cmbVerwijderMenuID.Items.Clear();
            PopulateCMBMenuIDs();
        }

        private void btnCloseMenuAanpassen_Click(object sender, EventArgs e)
        {
            pnlMenuAanpassen.Hide(); // hide panel
        }

        private void btnCloseMenuToevoegen_Click(object sender, EventArgs e)
        {
            pnlMenuItemToevoegen.Hide(); // hide panel
        }
        private void btnCloseMenuVerwijderen_Click(object sender, EventArgs e)
        {
            pnlMenuItemVerwijderen.Hide(); // hide panel
        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show(); // close this form and open main menu
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
            MenukaartItem menuItem = _service.GetMenuItem(id); // change the labels when you select a new id

            lblAanpassenSoort.Text = menuItem.Soort;
            lblAanpassenNaam.Text = menuItem.Naam;
            lblAanpassenAlcohol.Text = menuItem.Alcohol.ToString();
            lblAanpassenPrijs.Text = menuItem.Prijs.ToString("0.00");
        }

        private void cmbAanpassenColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if the column alcohol is chosen, show a checkbox for input, else show a txtbox
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
                MessageBox.Show("Vul alle velden!"); // check if all fields are filled except the alcohol checkbox
                return;
            }

            int id = (int)cmbMenuAanpassenIDs.SelectedItem;
            string column = cmbAanpassenColumn.SelectedItem.ToString(); // get values

            bool alcohol = false;
            if (column == "Alcohol") // check alcohol checkbox
                if (ckbMenuAanpassenAlcohol.Checked)
                    alcohol = true;
            var input = txtAanpassenNieuw.Text;

            try // try to adjust depending on the column, use method overloading
            {
                if (column == "Prijs")
                    _service.AdjustMenuItem(id, column, float.Parse(input.Replace('.', ','))); // replace dot with comma because off the float
                else if (column == "Alcohol")
                    _service.AdjustMenuItem(id, column, alcohol);
                else
                    _service.AdjustMenuItem(id, column, input.ToString());
                MessageBox.Show("Menu item aangepast!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong value"); // display error if it went wrong
                return;
            }
        }






        // menu item toevoegen
        private void btnMenuItemToevoegen_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlMenuItemToevoegen.Show(); // show panel
        }

        private void btnMenuToevoegenDb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMenuToevoegenNaam.Text) || String.IsNullOrEmpty(txtMenuToevoegenPrijs.Text))
            {
                MessageBox.Show("Vul alle velden in!"); // check for empty fields
                return;
            }

            string soort = cmbToevoegenSoort.SelectedItem.ToString();
            string naam = txtMenuToevoegenNaam.Text;
            float prijs = float.Parse(txtMenuToevoegenPrijs.Text.Replace('.', ',')); // replace dot with comma because of the float
            
            // check the alcohol value
            bool alcohol;
            if (cbMenuToevoegenAlcohol.Checked)
                alcohol = true;
            else
                alcohol = false;

            _service.AddMenuItem(soort, naam, alcohol, prijs); // add menu item
            MessageBox.Show("Menu item toegevoegd!"); // display confirmation message
        }




        // menu item verwijderen
        private void btnMenuItemVerwijderen_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlMenuItemVerwijderen.Show(); // show panel
        }

        private void cmbVerwijderMenuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cmbVerwijderMenuID.SelectedItem;
            MenukaartItem item = _service.GetMenuItem(id); // change labels depending on the id thats chosen from the cmb

            lblVerwijderSoort.Text = item.Soort;
            lblVerwijderNaam.Text = item.Naam;
            lblVerwijderAlcohol.Text = item.Alcohol.ToString();
            lblVerwijderPrijs.Text = item.Prijs.ToString("0.00");
        }

        private void btnVerwijderMenuItemDB_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u dit item wilt verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) // display a warning message, when user presses enter, delete menu item
            {
                int id = (int)cmbVerwijderMenuID.SelectedItem;
                _service.RemoveMenuItem(id);
            }
            else if (dialogResult == DialogResult.No) // else return
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlMenuItemVerwijderen.Hide(); // hide panel
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlMenuItemToevoegen.Hide(); // hide panel
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMenuAanpassen.Hide(); // hide panel
        }

        
    }
}
