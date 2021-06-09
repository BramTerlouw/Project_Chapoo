using Model_Chapoo;
using Service_Chapoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Keuken_Main : Form
    {
        private Bestelling _bestelling;
        private Bestelling_Service _bestellingService;
        private BestellingRegel_Service _bestellingRegelService;
        private List<BestellingRegel> _orderDetails;
        private List<Bestelling> _bestellingen;

        private bool _btnGereedWasClicked = false;

        private Medewerker _medewerker;
        private HoofdMenu _menu;

        
        // constructor
        public Keuken_Main(HoofdMenu menu, Medewerker medewerker)
        {
            InitializeComponent();

            this._medewerker = medewerker;
            this._menu = menu;
            if (_medewerker.Rol == "Chef")
            {

            }
            else if (_medewerker.Rol == "Barman")
            {

            }

            HideDetails();

            _bestellingRegelService = new BestellingRegel_Service();
            _bestellingService = new Bestelling_Service();
        }

        private void btn_Keuken_Openstaand_Click(object sender, EventArgs e)
        {
            // bool setten voor ophalen bestelling
            _btnGereedWasClicked = false;
            // kleuren aanpassen van de knoppen
            btn_Keuken_Openstaand.BackColor = Color.FromArgb(120, 139, 255);
            btn_Keuken_Gereed.BackColor = Color.White;
            // code uitvoeren om de gdv te vullen
            dgv_Keuken_Bestellingen.Rows.Clear();
            GetBestellingen();
        }

        private void btn_Keuken_Gereed_Click(object sender, EventArgs e)
        {
            // bool setten voor ophalen bestelling
            _btnGereedWasClicked = true;
            // kleuren aanpassen van de knoppen
            btn_Keuken_Openstaand.BackColor = Color.White;
            btn_Keuken_Gereed.BackColor = Color.FromArgb(120, 139, 255);
            // code uitvoeren om de gdv te vullen
            dgv_Keuken_Bestellingen.Rows.Clear();
            GetBestellingen();
        }

        private void HideDetails()
        {
            //dgv en knoppen verbergen
            dgv_Keuken_BestellingDetails.Hide();
            btn_Keuken_Details_Sluiten.Hide();
            btn_Keuken_Bestelling_Afmelden.Hide();
        }

        private void ShowDetails()
        {
            //dgv en knoppen laten zien
            dgv_Keuken_BestellingDetails.Show();
            btn_Keuken_Details_Sluiten.Show();
            if (btn_Keuken_Openstaand.Enabled)
            {
                btn_Keuken_Bestelling_Afmelden.Show();
            }
        }

        private void GridBestellingDetailsVullen()
        {
            foreach (BestellingRegel regel in _orderDetails)
            {
                dgv_Keuken_BestellingDetails.Rows.Add(regel.dataGrid(regel));
            }
            ShowDetails();
        }

        private void GridClearDetails()
        {
            // dgv leeg maken
            dgv_Keuken_BestellingDetails.Rows.Clear();
        }

        private void dgv_Keuken_Bestellingen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // als 1 bestelling is geselecteerd details laten zien anders details hiden
            if (dgv_Keuken_Bestellingen.SelectedRows.Count is 1)
            {
                int selectedOrderNr = int.Parse(dgv_Keuken_Bestellingen.SelectedRows[0].Cells[0].Value + string.Empty);
                _bestelling = _bestellingService.GetBestellingByID(selectedOrderNr);
                GetBestellingDetails();
                GridBestellingDetailsVullen();
            }
            else
            {
                dgv_Keuken_BestellingDetails.Hide();
                GridClearDetails();
            }
        }

        private void GetBestellingDetails()
        {
            _orderDetails = _bestellingRegelService.GetEetBestellingDetailsByBestellingID(_bestelling.BestellingID);
        }

        private void GetBestellingen()
        {
            // als button gereed is geklikt moeten de gereed bestellingen worden opgehaald anders is de andere knop ingedrukt
            // en moeten de openstaander bestellingen worden opgehaald
            if (_btnGereedWasClicked is true)
            {
                _bestellingen = _bestellingService.GetEetBestellingGereed();
            }
            else
            {
                _bestellingen = _bestellingService.GetEetBestellingOpen();
            }

            Update_BestellingGrid();
        }

        private void btnTerugHoofdMenu_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        private void btn_Keuken_Bestelling_Afmelden_Click(object sender, EventArgs e)
        {
            _bestellingService.GereedMelden(_bestelling.BestellingID);
            Update_BestellingGrid();
        }

        private void btn_Keuken_Details_Sluiten_Click(object sender, EventArgs e)
        {
            HideDetails();
            GridClearDetails();
            dgv_Keuken_Bestellingen.ClearSelection();
            Update_BestellingGrid();
        }

        private void Update_BestellingGrid()
        {
            //eerst grid legen daarna opnieuw vullen
            dgv_Keuken_Bestellingen.Rows.Clear();

            if (_bestellingen != null)
            {
                foreach (Bestelling bestelling in _bestellingen)
                {
                    dgv_Keuken_Bestellingen.Rows.Add(bestelling.dataGrid(bestelling));
                }
            }
        }
    }
}
