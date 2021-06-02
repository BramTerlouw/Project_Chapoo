using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_Chapoo;

namespace UI
{
    public partial class Administratie_Main : Form
    {
        private Medewerker medewerker;
        private HoofdMenu _hoofdMenu;
        public Administratie_Main(HoofdMenu hoofdMenu, Medewerker medewerker)
        {
            InitializeComponent();
            this._hoofdMenu = hoofdMenu;
            this.medewerker = medewerker;
        }

        private void btnVoorraad_Click(object sender, EventArgs e)
        {
            new Voorraad_Main(this, medewerker).Show();
            this.Hide();
        }

        private void btnMedewerkers_Click(object sender, EventArgs e)
        {
            new Medewerkers_Main(this, medewerker).Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Menu_Main(this, medewerker).Show();
            this.Hide();
        }

        private void btnLogOutAdministratie_Click(object sender, EventArgs e)
        {
            _hoofdMenu.Show();
            this.Close();
        }
    }
}
