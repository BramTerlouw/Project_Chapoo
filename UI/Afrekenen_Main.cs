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
        private Medewerker _medewerker;
        private HoofdMenu _menu;

        public Afrekenen_Main(HoofdMenu menu, Medewerker medewerker)
        {
            InitializeComponent();
            this._medewerker = medewerker;
            this._menu = menu;
        }

        private void Afrekenen_Main_Load(object sender, EventArgs e)
        {         
            FillListViewTafel();
        }

        private void btn_KiesTafelConfirm_Click(object sender, EventArgs e)
        {
            int TafelID = int.Parse(lst_KiesTafel.SelectedItems[0].Text);

            ShowOrderPerTabel(TafelID);
        }

        private void FillListViewTafel()
        {
            Tafel_Service tafelservice = new Tafel_Service();

            string statusBezet = "bezet";

            List<Tafel> tafels = tafelservice.Get_Tables(statusBezet);

            lst_KiesTafel.Items.Clear();

            foreach (var tafel in tafels)
            {
                ListViewItem Tafel = new ListViewItem(tafel.TafelID.ToString());
                Tafel.SubItems.Add(tafel.AantalStoelen.ToString()) ;
                Tafel.SubItems.Add(tafel.Status);

                lst_KiesTafel.Items.Add(Tafel);
            }
        }

        private void ShowOrderPerTabel(int TafelID)
        {
            this.Hide();
            new Afrekenen_PerTafel(this, _medewerker, TafelID).Show();
            //this.Close();       
        }

        private void btnTerugHoofdMenu_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }
    }
}
