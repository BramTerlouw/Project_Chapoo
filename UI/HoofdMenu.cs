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
using Service_Chapoo;

namespace UI
{
    public partial class HoofdMenu : Form
    {
        private Medewerker _medewerker;
        private Login _loginForm;
        private MedewerkerService _serviceMedewerker;

        public HoofdMenu(Login loginForm, Medewerker medewerker)
        {
            InitializeComponent();
            this._medewerker = medewerker;
            this._loginForm = loginForm;
            this._serviceMedewerker = new MedewerkerService();

        }

        private void btnLogOutHoofdMenu_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }

        private void btnAdministratie_Click(object sender, EventArgs e)
        {
            new Administratie_Main(this, _medewerker).Show();
            this.Hide();
        }

        private void btnKeuken_Click(object sender, EventArgs e)
        {
            new Keuken_Main(this, _medewerker).Show();
            this.Hide();
        }

        private void btnBestellingAfrekenen_Click(object sender, EventArgs e)
        {
            new Afrekenen_Main(this, _medewerker).Show();
            this.Hide();
        }

        private void btnTafelOverzicht_Click(object sender, EventArgs e)
        {
            new Tafels_Main(this, _medewerker).Show();
            this.Hide();
        }
    }
}
