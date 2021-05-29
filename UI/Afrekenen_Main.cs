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
        public Afrekenen_Main()
        {
            InitializeComponent();         
        }

        private void Afrekenen_Main_Load(object sender, EventArgs e)
        {
            pnl_AfrekenenMain.Show();
            FillListViewTafel();
        }

        private void btn_KiesTafelConfirm_Click(object sender, EventArgs e)
        {
            int TafelID = 1;/*int.Parse(lst_KiesTafel.SelectedItems[0].Text);*/

            ShowOrderPerTabel(TafelID);
        }

        private void FillListViewTafel()
        {
            Tafel_Service tafelservice = new Tafel_Service();

            //List<Tafel> tafels = tafelservice.GetTables();

            lst_KiesTafel.Items.Clear();

            //foreach (var tafel in tafels)
            //{
            //    ListViewItem Tafel = new ListViewItem(tafel.TafelID.ToString());

            //    lst_KiesTafel.Items.Add(Tafel);
            //}
        }

        private void ShowOrderPerTabel(int TafelID)
        {
            new Afrekenen_PerTafel(TafelID).Show();
        }

        
    }
}
