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


        // constructor
        public Keuken_Main()
        {
            InitializeComponent();
            dgv_Keuken_BestellingDetails.Hide();
            btn_Keuken_Details_Sluiten.Hide();
            btn_Keuken_Bestelling_Afmelden.Hide();
        }

        private void btn_Keuken_Openstaand_Click(object sender, EventArgs e)
        {
            // kleuren aanpassen van de knoppen
            btn_Keuken_Openstaand.BackColor = Color.FromArgb(76,42,133);
            btn_Keuken_Gereed.BackColor = Color.White;
            // code uitvoeren om de gdv te vullen

            //dgv en knoppen laten zien
            dgv_Keuken_BestellingDetails.Show();
            btn_Keuken_Details_Sluiten.Show();
            btn_Keuken_Bestelling_Afmelden.Show();
        }

        private void btn_Keuken_Gereed_Click(object sender, EventArgs e)
        {
            // kleuren aanpassen van de knoppen
            btn_Keuken_Openstaand.BackColor = Color.White;
            btn_Keuken_Gereed.BackColor = Color.FromArgb(76, 42, 133);
            // code uitvoeren om de gdv te vullen

            //dgv en knoppen laten zien
            dgv_Keuken_BestellingDetails.Show();
            btn_Keuken_Details_Sluiten.Show();
            btn_Keuken_Bestelling_Afmelden.Hide();
        }

        private void GridBestellingDetailsVullen()
        {
            foreach (BestellingRegel regel in _orderDetails)
            {
                dgv_Keuken_BestellingDetails.Rows.Add(regel.dataGrid(regel));
            }
        }

        private void GridClearDetails()
        {
            dgv_Keuken_BestellingDetails.Rows.Clear();
        }

        private void dgv_Keuken_Bestellingen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_Keuken_Bestellingen.SelectedRows.Count is 1)
            {
                int selectedOrderNr = int.Parse(dgv_Keuken_Bestellingen.SelectedRows[0].Cells[0].Value + string.Empty);
                _bestelling = _bestellingService.GetBestellingByID(selectedOrderNr);
                GetBestellingDetails();
            }
        }

        private void GetBestellingDetails()
        {

        }
    }
}
