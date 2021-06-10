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
    public partial class Voorraad_Main : Form
    {
        // fields
        private Administratie_Main _main;
        private VoorraadItemService _service;
        private List<VoorraadItem> _voorraadItems;
        private Medewerker _medewerker;




        // ctor
        public Voorraad_Main(Administratie_Main main, Medewerker medewerker)
        {
            InitializeComponent();

            // set main form, service layer, logged employee and fill combobox
            this._main = main;
            this._service = new VoorraadItemService();
            this._medewerker = medewerker;
            
            // hide panels and buttons
            HideItems();

            // get all stock and fill datagridview with the stock, populate cmb
            GetFullStock();
            PopulateGridStock();
            PopulateCMBId();
        }






        // Populate, Hide and Refresh
        public void PopulateGridStock()
        {
            // fill the grid
            foreach (VoorraadItem item in _voorraadItems)
            {
                dgv_Voorraad.Rows.Add(item.dataGrid(item));
            }
        }

        public void HideItems() // all items that need to be hidden at intializemoment
        {
            pnlVoorraadAanpassen.Hide();
            pnlFilterVoorraad.Hide();

            if (_medewerker.Rol != "Eigenaar") // when logged in as owner, show adjustment buttons
                btnVoorraadAanpassen.Hide();
        }

        private void RefreshStock()
        {
            // refresh list and dgv
            _voorraadItems.Clear();
            dgv_Voorraad.Rows.Clear();
            _voorraadItems = _service.GetStock();
            PopulateGridStock();
        }

        public void GetFullStock()
        {
            // get all stock items
            _voorraadItems = _service.GetStock();
        }

        public void PopulateCMBId()
        {
            // populate cmb with id's
            foreach (VoorraadItem item in _voorraadItems)
            {
                cmdAanpassenID.Items.Add(item._id);
            }
            cmdAanpassenID.SelectedIndex = 0;
        }






        // Filter
        private void btnFilterEten_Click(object sender, EventArgs e)
        {
            // clear list and dgv, then get all foods and fill again
            _voorraadItems.Clear();
            dgv_Voorraad.Rows.Clear();

            _voorraadItems = _service.GetFoods();
            PopulateGridStock();
        }

        private void btnFilterDrinken_Click(object sender, EventArgs e)
        {
            // clear list and dgv, then get all drinks and fill again
            _voorraadItems.Clear();
            dgv_Voorraad.Rows.Clear();

            _voorraadItems = _service.GetDrinks();
            PopulateGridStock();
        }

        private void btnFilterVoorraadpnl_Click(object sender, EventArgs e)
        {
            // show filterpanel
            pnlVoorraadAanpassen.Hide();
            pnlFilterVoorraad.Show();
        }

        private void btnFilterVoorraad_Click(object sender, EventArgs e)
        {
            // check for empty fields
            if (String.IsNullOrEmpty(txtVoorraadFilter.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }

            // get filterinput
            string input = txtVoorraadFilter.Text;

            // clear list and dgv, fill with filterd items
            _voorraadItems.Clear();
            dgv_Voorraad.Rows.Clear();
            _voorraadItems = _service.FilterStock(input);
            PopulateGridStock();
        }






        // Voorraad aanpassen
        private void btnVoorraadAanpassen_Click(object sender, EventArgs e)
        {
            // show adjust panel
            RefreshStock();
            pnlFilterVoorraad.Hide();
            pnlVoorraadAanpassen.Show();
        }

        private void btnNieuweVoorraad_Click(object sender, EventArgs e)
        {
            // check if fields are filled
            if (String.IsNullOrEmpty(txtAanpassenAantal.Text))
            {
                MessageBox.Show("Vul alle velden in!");
                return;
            }

            // check input
            int amount;
            if (!int.TryParse(txtAanpassenAantal.Text, out amount))
            {
                MessageBox.Show("Enter a number!");
                return;
            }

            // send id and amount to service layer
            int stockID = (int)cmdAanpassenID.SelectedItem;
            _service.AdjustStock(stockID, amount);

            // empty txtboxes, hide panel and refresh dgv and list
            txtAanpassenAantal.Clear();
            cmdAanpassenID.SelectedIndex = 0;
            pnlVoorraadAanpassen.Hide();
            RefreshStock();
        }

        




        // Close panels or forms
        private void btnCloseVoorraadFilter_Click(object sender, EventArgs e)
        {
            // close pnlvoorraad and refresh dgv with all stock
            pnlFilterVoorraad.Hide();
            RefreshStock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hide panel
            pnlVoorraadAanpassen.Hide();
        }

        private void btnVoorraadTerug_Click(object sender, EventArgs e)
        {
            // close stockmenu and open main menu
            this.Close();
            _main.Show();
        }

        private void btnRefreshVoorraad_Click(object sender, EventArgs e)
        {
            // refresh stock
            RefreshStock();
        }
    }
}
