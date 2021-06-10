using Model_Chapoo;
using Service_Chapoo;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private string _keuze;
        private bool _btnGereedWasClicked = false;

        private Medewerker _medewerker;
        private HoofdMenu _menu;

        // voor de klok
        private Timer t = null;


        // constructor
        public Keuken_Main(HoofdMenu menu, Medewerker medewerker)
        {
            InitializeComponent();
            StartTimer();

            this._medewerker = medewerker;
            this._menu = menu;

            if (_medewerker.Rol == "Chef")
            {
                lbl_Locatie.Text = "Keuken";
                _keuze = "keuken";
            }
            else if (_medewerker.Rol == "Barman")
            {
                lbl_Locatie.Text = "Bar";
                _keuze = "bar";
            }
            else
            {
                pnl_Keuze.Show();
            }

            HideDetails();

            _bestellingRegelService = new BestellingRegel_Service();
            _bestellingService = new Bestelling_Service();
        }

        // DataGrid
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
                GridClearDetails();
                int selectedOrderNr = int.Parse(dgv_Keuken_Bestellingen.SelectedRows[0].Cells[1].Value + string.Empty);
                _bestelling = _bestellingService.GetBestellingByID(selectedOrderNr);
                GetBestellingDetails();
                GridBestellingDetailsVullen();
                ShowDetails();
            }
            else
            {
                HideDetails();
                GridClearDetails();
            }
        }

        private void GetBestellingDetails()
        {
            if (_keuze == "keuken")
            {
                _orderDetails = _bestellingRegelService.GetEetBestellingDetailsByBestellingID(_bestelling.BestellingID);
            }
            else
            {
                _orderDetails = _bestellingRegelService.GetDrinkBestellingDetailsByBestellinID(_bestelling.BestellingID);
            }
        }

        private void GetBestellingen()
        {
            if (_keuze == "keuken")
            {
                // als button gereed is geklikt moeten de gereed bestellingen worden opgehaald anders is de andere knop ingedrukt
                // en moeten de openstaande bestellingen worden opgehaald
                if (_btnGereedWasClicked is true)
                {
                    _bestellingen = _bestellingService.GetEetBestelling("gereed");
                }
                else
                {
                    _bestellingen = _bestellingService.GetEetBestelling("bezig");
                }
            }
            else
            {
                if (_btnGereedWasClicked is true)
                {
                    _bestellingen = _bestellingService.GetDrinkBestelling("gereed");
                }
                else
                {
                    _bestellingen = _bestellingService.GetDrinkBestelling("bezig");
                }
            }

            Update_BestellingGrid();
        }

        private void Update_BestellingGrid()
        {
            //eerst grid legen daarna opnieuw vullen
            dgv_Keuken_Bestellingen.Rows.Clear();

            if (_bestellingen.Count != 0)
            {
                foreach (Bestelling bestelling in _bestellingen)
                {
                    dgv_Keuken_Bestellingen.Rows.Add(bestelling.dataGrid(bestelling));
                }
            }
            // selectie ongedaan maken
            dgv_Keuken_Bestellingen.ClearSelection();
        }

        // functies voor klok
        private void StartTimer()
        {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
        }

        // Knoppen
        private void btn_Keuze_Keuken_Click(object sender, EventArgs e)
        {
            _keuze = "keuken";
            pnl_Keuze.Hide();
            lbl_Locatie.Text = "Keuken";
        }

        private void btn_Keuze_Bar_Click(object sender, EventArgs e)
        {
            _keuze = "bar";
            pnl_Keuze.Hide();
            lbl_Locatie.Text = "Bar";
        }

        private void btnTerugHoofdMenu_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        private void btn_Keuken_Bestelling_Afmelden_Click(object sender, EventArgs e)
        {
            _bestellingService.GereedMelden(_bestelling.BestellingID);
            HideDetails();
            GridClearDetails();
            GetBestellingen();
            Update_BestellingGrid();
        }

        private void btn_Keuken_Details_Sluiten_Click(object sender, EventArgs e)
        {
            HideDetails();
            GridClearDetails();
            Update_BestellingGrid();
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
            // details verbergen en grid legen van details
            HideDetails();
            GridClearDetails();
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
            // details verbergen en grid legen van details
            HideDetails();
            GridClearDetails();
        }
    }
}
